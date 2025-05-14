using System;
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
                // Добавляем новую запись опроса
                mainForm.SurveyBindingSource.AddNew();

                var currentRow = (System.Data.DataRowView)mainForm.SurveyBindingSource.Current;
                currentRow["DishID"] = dishComboBox.SelectedValue;
                currentRow["Taste"] = tasteRating.Value;
                currentRow["PriceRating"] = priceRating.Value;
                currentRow["Date"] = DateTime.Now;

                // Сохраняем изменения
                mainForm.SurveyBindingSource.EndEdit();
                mainForm.SurveyTableAdapter.Update(mainForm.CafeDataSet.Survey);

                MessageBox.Show("Спасибо за ваш отзыв!");
                this.Close();
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