using System;
using System.Data;
using System.Windows.Forms;

namespace CafeSurveyApp
{
    public partial class SurveyForm : Form
    {
        private readonly Form1 mainForm;

        public SurveyForm(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void SurveyForm_Load(object sender, EventArgs e)
        {
            // Заполняем список блюд
            dishComboBox.DataSource = mainForm.MenuBindingSource;
            dishComboBox.DisplayMember = "Name";
            dishComboBox.ValueMember = "ID";

            // Настройка NumericUpDown для оценок
            tasteRating.Minimum = 1;
            tasteRating.Maximum = 5;
            priceRating.Minimum = 1;
            priceRating.Maximum = 5;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dishComboBox.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите блюдо!");
                return;
            }

            try
            {
                // Получаем выбранное блюдо
                int dishId = (int)dishComboBox.SelectedValue;
                int taste = (int)tasteRating.Value;
                int price = (int)priceRating.Value;
                DateTime date = DateTime.Now;

                // SQL-запрос для вставки нового опроса
                string query = $"INSERT INTO survey (DishID, Taste, PriceRating, Date) " +
                              $"VALUES ({dishId}, {taste}, {price}, #{date:MM/dd/yyyy}#)";

                // Выполняем запрос
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Спасибо за ваш отзыв!");

                    // Обновляем данные в главной форме
                    mainForm.SurveyBindingSource.EndEdit();
                    mainForm.SurveyAdapter.Update(mainForm.CafeDataSet, "Survey");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить опрос.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении опроса: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}