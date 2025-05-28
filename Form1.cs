using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace CafeSurveyApp
{
    public partial class Form1 : Form
    {
        private OleDbConnection dbConnection;
        private DataSet cafeDataSet;
        private OleDbDataAdapter menuAdapter;
        private OleDbDataAdapter surveyAdapter;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                // Строка подключения к Access (измените путь к вашей БД)
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseCafe.accdb;";

                dbConnection = new OleDbConnection(connectionString);
                cafeDataSet = new DataSet("CafeDataSet");

                // Инициализация адаптеров для таблиц
                InitializeAdapters();

                // Создание связей между таблицами
                CreateRelations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации базы данных: {ex.Message}");
            }
        }

        private void InitializeAdapters()
        {
            // Адаптер для таблицы Menu
            menuAdapter = new OleDbDataAdapter(
                "SELECT * FROM menu", dbConnection);

            // Адаптер для таблицы Survey
            surveyAdapter = new OleDbDataAdapter(
                "SELECT * FROM survey", dbConnection);

            // Добавляем команды для обновления
            var commandBuilder = new OleDbCommandBuilder(menuAdapter);
            commandBuilder = new OleDbCommandBuilder(surveyAdapter);

            // Заполняем DataSet
            menuAdapter.Fill(cafeDataSet, "menu");
            surveyAdapter.Fill(cafeDataSet, "survey");
        }

        private void CreateRelations()
        {
            // Создаем связь между таблицами
            DataRelation relation = new DataRelation(
                "MenuSurveyRelation",
                cafeDataSet.Tables["menu"].Columns["ID"],
                cafeDataSet.Tables["survey"].Columns["DishID"]);

            cafeDataSet.Relations.Add(relation);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Привязка данных к элементам управления
            menuBindingSource.DataSource = cafeDataSet;
            menuBindingSource.DataMember = "menu";

            surveyBindingSource.DataSource = cafeDataSet;
            surveyBindingSource.DataMember = "survey";

            // Настройка DataGridViews
            ConfigureDataGrids();
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
                menuBindingSource.EndEdit();
                menuAdapter.Update(cafeDataSet, "menu");
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
                surveyBindingSource.EndEdit();
                surveyAdapter.Update(cafeDataSet, "survey");
                MessageBox.Show("Изменения в опросах сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения опросов: {ex.Message}");
            }
        }

        // Остальные методы (LINQ запросы, открытие формы опроса) остаются без изменений
        // ...
    }
}