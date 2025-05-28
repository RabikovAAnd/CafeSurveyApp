using System;
using System.Data;
using System.Windows.Forms;

namespace CafeSurveyApp
{
    public partial class SurveyForm : Form
    {
        private readonly Form1 mainForm;

        public SurveyForm(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            LoadDishes();
        }

        private void LoadDishes()
        {
            dishComboBox.DataSource = mainForm.cafeDataSet.Tables["Menu"];
            dishComboBox.DisplayMember = "Name";
            dishComboBox.ValueMember = "ID";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Добавление новой записи опроса
            mainForm.surveyBindingSource.AddNew();
            DataRowView newRow = (DataRowView)mainForm.surveyBindingSource.Current;

            newRow["MenuID"] = dishComboBox.SelectedValue;
            newRow["TasteRating"] = tasteRatingNumeric.Value;
            newRow["PriceRating"] = priceRatingNumeric.Value;
            newRow["Date"] = DateTime.Now;

            mainForm.surveyBindingSource.EndEdit();
            mainForm.surveyAdapter.Update(mainForm.cafeDataSet, "Survey");

            MessageBox.Show("Спасибо за ваш отзыв!");
            this.Close();
        }
    }
}