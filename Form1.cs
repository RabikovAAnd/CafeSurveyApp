using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace CafeSurveyApp
{
    public partial class Form1 : Form
    {
        public DataSet cafeDataSet;
        public BindingSource menuBindingSource;
        public BindingSource surveyBindingSource;
        private OleDbDataAdapter menuAdapter;
        private OleDbDataAdapter surveyAdapter;
        private OleDbConnection connection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            SetupDataGridViews();
            SetupNavigation();
        }

        private void InitializeDatabase()
        {
            cafeDataSet = new DataSet();
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CafeDatabase.accdb;");

            // Инициализация адаптеров
            menuAdapter = new OleDbDataAdapter("SELECT * FROM Menu", connection);
            surveyAdapter = new OleDbDataAdapter("SELECT * FROM Survey", connection);

            // Заполнение DataSet
            menuAdapter.Fill(cafeDataSet, "Menu");
            surveyAdapter.Fill(cafeDataSet, "Survey");

            // Установка связей
            DataRelation relation = new DataRelation("MenuSurveyRelation",
                cafeDataSet.Tables["Menu"].Columns["ID"],
                cafeDataSet.Tables["Survey"].Columns["MenuID"]);
            cafeDataSet.Relations.Add(relation);

            // Инициализация BindingSource
            menuBindingSource = new BindingSource(cafeDataSet, "Menu");
            surveyBindingSource = new BindingSource(menuBindingSource, "MenuSurveyRelation");
        }

        private void SetupDataGridViews()
        {
            // Настройка DataGridView для меню
            menuDataGridView.DataSource = menuBindingSource;
            menuDataGridView.AutoGenerateColumns = true;

            // Настройка DataGridView для опроса
            surveyDataGridView.DataSource = surveyBindingSource;
            surveyDataGridView.AutoGenerateColumns = true;

            // Добавление ComboBox для выбора блюда в опросе
            DataGridViewComboBoxColumn dishColumn = new DataGridViewComboBoxColumn();
            dishColumn.HeaderText = "Блюдо";
            dishColumn.DataSource = cafeDataSet.Tables["Menu"];
            dishColumn.DisplayMember = "Name";
            dishColumn.ValueMember = "ID";
            dishColumn.DataPropertyName = "MenuID";
            surveyDataGridView.Columns.Add(dishColumn);
        }

        private void SetupNavigation()
        {
            // Навигация для меню
            BindingNavigator menuNavigator = new BindingNavigator(menuBindingSource);
            menuNavigator.Dock = DockStyle.Top;
            this.Controls.Add(menuNavigator);

            // Кнопка сохранения для меню
            Button saveMenuButton = new Button();
            saveMenuButton.Text = "Сохранить меню";
            saveMenuButton.Click += SaveMenuButton_Click;
            menuNavigator.Controls.Add(saveMenuButton);

            // Навигация для опроса
            BindingNavigator surveyNavigator = new BindingNavigator(surveyBindingSource);
            surveyNavigator.Dock = DockStyle.Bottom;
            this.Controls.Add(surveyNavigator);

            // Кнопка сохранения для опроса
            Button saveSurveyButton = new Button();
            saveSurveyButton.Text = "Сохранить опрос";
            saveSurveyButton.Click += SaveSurveyButton_Click;
            surveyNavigator.Controls.Add(saveSurveyButton);
        }

        private void SaveMenuButton_Click(object sender, EventArgs e)
        {
            menuBindingSource.EndEdit();
            menuAdapter.Update(cafeDataSet, "Menu");
            MessageBox.Show("Изменения в меню сохранены");
        }

        private void SaveSurveyButton_Click(object sender, EventArgs e)
        {
            surveyBindingSource.EndEdit();
            surveyAdapter.Update(cafeDataSet, "Survey");
            MessageBox.Show("Изменения в опросе сохранены");
        }

        private void openSurveyFormButton_Click(object sender, EventArgs e)
        {
            SurveyForm surveyForm = new SurveyForm(this);
            surveyForm.ShowDialog();
        }

        // LINQ запросы
        private void ShowDishesBelowPrice(decimal price)
        {
            var query = from row in cafeDataSet.Tables["Menu"].AsEnumerable()
                        where row.Field<decimal>("Price") < price
                        select new
                        {
                            Name = row.Field<string>("Name"),
                            Price = row.Field<decimal>("Price")
                        };

            DisplayQueryResults(query, "Блюда дешевле " + price);
        }

        private void ShowDishesBelowCalories(int calories)
        {
            var query = from row in cafeDataSet.Tables["Menu"].AsEnumerable()
                        where row.Field<int>("Calories") < calories
                        select new
                        {
                            Name = row.Field<string>("Name"),
                            Calories = row.Field<int>("Calories")
                        };

            DisplayQueryResults(query, "Блюда с калорийностью ниже " + calories);
        }

        private void ShowMostTastyDishes()
        {
            var query = from survey in cafeDataSet.Tables["Survey"].AsEnumerable()
                        join menu in cafeDataSet.Tables["Menu"].AsEnumerable()
                        on survey.Field<int>("MenuID") equals menu.Field<int>("ID")
                        group survey by new
                        {
                            MenuID = menu.Field<int>("ID"),
                            DishName = menu.Field<string>("Name")
                        } into g
                        orderby g.Average(s => s.Field<int>("TasteRating")) descending
                        select new
                        {
                            DishName = g.Key.DishName,
                            AvgTasteRating = g.Average(s => s.Field<int>("TasteRating"))
                        };

            DisplayQueryResults(query.Take(3), "Самые вкусные блюда");
        }

        private void DisplayQueryResults<T>(IEnumerable<T> results, string title)
        {
            QueryResultsForm resultsForm = new QueryResultsForm();
            resultsForm.Text = title;
            resultsForm.dataGridView.DataSource = results.ToList();
            resultsForm.ShowDialog();
        }
    }
}