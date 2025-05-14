using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CafeSurveyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузка данных при запуске формы
            LoadData();
            ConfigureDataGrids();
        }

        private void LoadData()
        {
            try
            {
                // Загрузка данных из базы
                this.menuTableAdapter.Fill(this.cafeDataSet.Menu);
                this.surveyTableAdapter.Fill(this.cafeDataSet.Survey);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void ConfigureDataGrids()
        {
            // Настройка DataGridView для меню
            menuDataGridView.AutoGenerateColumns = true;
            menuDataGridView.DataSource = menuBindingSource;

            // Настройка DataGridView для опросов
            surveyDataGridView.AutoGenerateColumns = true;
            surveyDataGridView.DataSource = surveyBindingSource;

            // Добавляем выпадающий список для выбора блюда в опросах
            var dishColumn = new DataGridViewComboBoxColumn();
            dishColumn.HeaderText = "Блюдо";
            dishColumn.DataPropertyName = "DishID";
            dishColumn.DataSource = menuBindingSource;
            dishColumn.DisplayMember = "Name";
            dishColumn.ValueMember = "ID";
            surveyDataGridView.Columns.Add(dishColumn);
        }

        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            SaveMenuChanges();
        }

        private void SaveMenuChanges()
        {
            try
            {
                this.Validate();
                this.menuBindingSource.EndEdit();
                this.menuTableAdapter.Update(this.cafeDataSet.Menu);
                MessageBox.Show("Изменения в меню сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения меню: {ex.Message}");
            }
        }

        private void btnSaveSurvey_Click(object sender, EventArgs e)
        {
            SaveSurveyChanges();
        }

        private void SaveSurveyChanges()
        {
            try
            {
                this.Validate();
                this.surveyBindingSource.EndEdit();
                this.surveyTableAdapter.Update(this.cafeDataSet.Survey);
                MessageBox.Show("Изменения в опросах сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения опросов: {ex.Message}");
            }
        }

        private void btnOpenSurveyForm_Click(object sender, EventArgs e)
        {
            OpenSurveyForm();
        }

        private void OpenSurveyForm()
        {
            SurveyForm surveyForm = new SurveyForm(this);
            surveyForm.ShowDialog();
        }

        // LINQ запросы
        private void btnCheapDishes_Click(object sender, EventArgs e)
        {
            decimal maxPrice = decimal.Parse(txtMaxPrice.Text);
            var query = from dish in cafeDataSet.Menu
                        where dish.Price < maxPrice
                        select dish;
            ShowQueryResults(query.ToList(), "Блюда дешевле " + maxPrice);
        }

        private void btnLowCalorie_Click(object sender, EventArgs e)
        {
            int maxCalories = int.Parse(txtMaxCalories.Text);
            var query = from dish in cafeDataSet.Menu
                        where dish.Calories < maxCalories
                        select dish;
            ShowQueryResults(query.ToList(), "Блюда с калорийностью ниже " + maxCalories);
        }

        private void btnBestTaste_Click(object sender, EventArgs e)
        {
            var query = from survey in cafeDataSet.Survey
                        group survey by survey.DishID into g
                        join dish in cafeDataSet.Menu on g.Key equals dish.ID
                        orderby g.Average(s => s.Taste) descending
                        select new
                        {
                            Dish = dish.Name,
                            AvgTaste = g.Average(s => s.Taste)
                        };
            ShowQueryResults(query.ToList(), "Самые вкусные блюда");
        }

        private void ShowQueryResults<T>(List<T> results, string title)
        {
            ResultsForm resultsForm = new ResultsForm();
            resultsForm.Text = title;
            resultsForm.SetData(results);
            resultsForm.Show();
        }
    }
}