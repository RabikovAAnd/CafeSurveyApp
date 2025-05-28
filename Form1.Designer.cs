namespace CafeSurveyApp
{
    partial class Form1
    {

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.surveyDataGridView = new System.Windows.Forms.DataGridView();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new CafeSurveyApp.CafeDataSet();
            this.surveyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveMenu = new System.Windows.Forms.Button();
            this.btnSaveSurvey = new System.Windows.Forms.Button();
            this.btnOpenSurveyForm = new System.Windows.Forms.Button();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.btnCheapDishes = new System.Windows.Forms.Button();
            this.txtMaxCalories = new System.Windows.Forms.TextBox();
            this.btnLowCalorie = new System.Windows.Forms.Button();
            this.btnBestTaste = new System.Windows.Forms.Button();
            this.btnPopularDishes = new System.Windows.Forms.Button();
            this.btnUnpopularDishes = new System.Windows.Forms.Button();
            this.btnTastyAndCheap = new System.Windows.Forms.Button();
            this.btnBadAndExpensive = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuTableAdapter = new CafeSurveyApp.CafeDataSetTableAdapters.MenuTableAdapter();
            this.surveyTableAdapter = new CafeSurveyApp.CafeDataSetTableAdapters.SurveyTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(12, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 13);
            label1.TabIndex = 14;
            label1.Text = "Меню:";

            // label2
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(12, 280);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 13);
            label2.TabIndex = 15;
            label2.Text = "Опросы:";

            // label3
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(500, 218);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 13);
            label3.TabIndex = 5;
            label3.Text = "Макс. цена:";

            // label4
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(500, 247);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(103, 13);
            label4.TabIndex = 8;
            label4.Text = "Макс. калории:";

            // menuDataGridView
            this.menuDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuDataGridView.AutoGenerateColumns = false;
            this.menuDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.DataSource = this.menuBindingSource;
            this.menuDataGridView.Location = new System.Drawing.Point(12, 56);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.Size = new System.Drawing.Size(760, 150);
            this.menuDataGridView.TabIndex = 0;

            // surveyDataGridView
            this.surveyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surveyDataGridView.AutoGenerateColumns = false;
            this.surveyDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.surveyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.surveyDataGridView.DataSource = this.surveyBindingSource;
            this.surveyDataGridView.Location = new System.Drawing.Point(12, 296);
            this.surveyDataGridView.Name = "surveyDataGridView";
            this.surveyDataGridView.Size = new System.Drawing.Size(760, 200);
            this.surveyDataGridView.TabIndex = 1;

            // menuBindingSource
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.cafeDataSet;

            // cafeDataSet
            this.cafeDataSet.DataSetName = "CafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            // surveyBindingSource
            this.surveyBindingSource.DataMember = "Survey";
            this.surveyBindingSource.DataSource = this.cafeDataSet;

            // btnSaveMenu
            this.btnSaveMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveMenu.Image")));
            this.btnSaveMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveMenu.Location = new System.Drawing.Point(12, 212);
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Size = new System.Drawing.Size(120, 30);
            this.btnSaveMenu.TabIndex = 2;
            this.btnSaveMenu.Text = "Сохранить меню";
            this.btnSaveMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveMenu.UseVisualStyleBackColor = true;
            this.btnSaveMenu.Click += new System.EventHandler(this.btnSaveMenu_Click);

            // btnSaveSurvey
            this.btnSaveSurvey.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSurvey.Image")));
            this.btnSaveSurvey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSurvey.Location = new System.Drawing.Point(12, 502);
            this.btnSaveSurvey.Name = "btnSaveSurvey";
            this.btnSaveSurvey.Size = new System.Drawing.Size(120, 30);
            this.btnSaveSurvey.TabIndex = 3;
            this.btnSaveSurvey.Text = "Сохранить опросы";
            this.btnSaveSurvey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSurvey.UseVisualStyleBackColor = true;
            this.btnSaveSurvey.Click += new System.EventHandler(this.btnSaveSurvey_Click);

            // btnOpenSurveyForm
            this.btnOpenSurveyForm.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSurveyForm.Image")));
            this.btnOpenSurveyForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenSurveyForm.Location = new System.Drawing.Point(652, 502);
            this.btnOpenSurveyForm.Name = "btnOpenSurveyForm";
            this.btnOpenSurveyForm.Size = new System.Drawing.Size(120, 30);
            this.btnOpenSurveyForm.TabIndex = 4;
            this.btnOpenSurveyForm.Text = "Новый опрос";
            this.btnOpenSurveyForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenSurveyForm.UseVisualStyleBackColor = true;
            this.btnOpenSurveyForm.Click += new System.EventHandler(this.btnOpenSurveyForm_Click);

            // txtMaxPrice
            this.txtMaxPrice.Location = new System.Drawing.Point(582, 215);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(50, 20);
            this.txtMaxPrice.TabIndex = 6;
            this.txtMaxPrice.Text = "100";

            // btnCheapDishes
            this.btnCheapDishes.Location = new System.Drawing.Point(638, 213);
            this.btnCheapDishes.Name = "btnCheapDishes";
            this.btnCheapDishes.Size = new System.Drawing.Size(134, 23);
            this.btnCheapDishes.TabIndex = 7;
            this.btnCheapDishes.Text = "Найти дешевые";
            this.btnCheapDishes.UseVisualStyleBackColor = true;
            this.btnCheapDishes.Click += new System.EventHandler(this.btnCheapDishes_Click);

            // txtMaxCalories
            this.txtMaxCalories.Location = new System.Drawing.Point(609, 244);
            this.txtMaxCalories.Name = "txtMaxCalories";
            this.txtMaxCalories.Size = new System.Drawing.Size(50, 20);
            this.txtMaxCalories.TabIndex = 9;
            this.txtMaxCalories.Text = "500";

            // btnLowCalorie
            this.btnLowCalorie.Location = new System.Drawing.Point(665, 242);
            this.btnLowCalorie.Name = "btnLowCalorie";
            this.btnLowCalorie.Size = new System.Drawing.Size(107, 23);
            this.btnLowCalorie.TabIndex = 10;
            this.btnLowCalorie.Text = "Найти легкие";
            this.btnLowCalorie.UseVisualStyleBackColor = true;
            this.btnLowCalorie.Click += new System.EventHandler(this.btnLowCalorie_Click);

            // btnBestTaste
            this.btnBestTaste.Location = new System.Drawing.Point(500, 502);
            this.btnBestTaste.Name = "btnBestTaste";
            this.btnBestTaste.Size = new System.Drawing.Size(146, 23);
            this.btnBestTaste.TabIndex = 11;
            this.btnBestTaste.Text = "Самые вкусные блюда";
            this.btnBestTaste.UseVisualStyleBackColor = true;
            this.btnBestTaste.Click += new System.EventHandler(this.btnBestTaste_Click);

            // btnPopularDishes
            this.btnPopularDishes.Location = new System.Drawing.Point(500, 473);
            this.btnPopularDishes.Name = "btnPopularDishes";
            this.btnPopularDishes.Size = new System.Drawing.Size(146, 23);
            this.btnPopularDishes.TabIndex = 12;
            this.btnPopularDishes.Text = "Популярные блюда";
            this.btnPopularDishes.UseVisualStyleBackColor = true;
            this.btnPopularDishes.Click += new System.EventHandler(this.btnPopularDishes_Click);

            // btnUnpopularDishes
            this.btnUnpopularDishes.Location = new System.Drawing.Point(652, 473);
            this.btnUnpopularDishes.Name = "btnUnpopularDishes";
            this.btnUnpopularDishes.Size = new System.Drawing.Size(120, 23);
            this.btnUnpopularDishes.TabIndex = 13;
            this.btnUnpopularDishes.Text = "Непопулярные";
            this.btnUnpopularDishes.UseVisualStyleBackColor = true;
            this.btnUnpopularDishes.Click += new System.EventHandler(this.btnUnpopularDishes_Click);

            // btnTastyAndCheap
            this.btnTastyAndCheap.Location = new System.Drawing.Point(138, 213);
            this.btnTastyAndCheap.Name = "btnTastyAndCheap";
            this.btnTastyAndCheap.Size = new System.Drawing.Size(146, 23);
            this.btnTastyAndCheap.TabIndex = 16;
            this.btnTastyAndCheap.Text = "Вкусные и дешевые";
            this.btnTastyAndCheap.UseVisualStyleBackColor = true;
            this.btnTastyAndCheap.Click += new System.EventHandler(this.btnTastyAndCheap_Click);

            // btnBadAndExpensive
            this.btnBadAndExpensive.Location = new System.Drawing.Point(290, 213);
            this.btnBadAndExpensive.Name = "btnBadAndExpensive";
            this.btnBadAndExpensive.Size = new System.Drawing.Size(146, 23);
            this.btnBadAndExpensive.TabIndex = 17;
            this.btnBadAndExpensive.Text = "Невкусные и дорогие";
            this.btnBadAndExpensive.UseVisualStyleBackColor = true;
            this.btnBadAndExpensive.Click += new System.EventHandler(this.btnBadAndExpensive_Click);

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";

            // fileToolStripMenuItem
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";

            // exitToolStripMenuItem
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            // helpToolStripMenuItem
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Справка";

            // aboutToolStripMenuItem
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";

            // toolStripStatusLabel
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "Готов к работе...";

            // menuTableAdapter
            this.menuTableAdapter.ClearBeforeFill = true;

            // surveyTableAdapter
            this.surveyTableAdapter.ClearBeforeFill = true;

            // bindingNavigator1
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.menuBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(784, 25);
            this.bindingNavigator1.TabIndex = 20;
            this.bindingNavigator1.Text = "bindingNavigator1";

            // bindingNavigatorAddNewItem
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";

            // bindingNavigatorCountItem
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";

            // bindingNavigatorDeleteItem
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";

            // bindingNavigatorMoveFirstItem
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";

            // bindingNavigatorMovePreviousItem
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";

            // bindingNavigatorSeparator
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);

            // bindingNavigatorPositionItem
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";

            // bindingNavigatorSeparator1
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);

            // bindingNavigatorMoveNextItem
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";

            // bindingNavigatorMoveLastItem
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";

            // bindingNavigatorSeparator2
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);

            // bindingNavigator2
            this.bindingNavigator2.AddNewItem = this.toolStripButton1;
            this.bindingNavigator2.BindingSource = this.surveyBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = this.toolStripButton2;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 49);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(784, 25);
            this.bindingNavigator2.TabIndex = 21;
            this.bindingNavigator2.Text = "bindingNavigator2";

            // toolStripButton1
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";

            // toolStripLabel1
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";

            // toolStripButton2
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";

            // toolStripButton3
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить в начало";

            // toolStripButton4
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить назад";

            // toolStripSeparator1
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);

            // toolStripTextBox1
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";

            // toolStripSeparator2
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);

            // toolStripButton5
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Переместить вперед";

            // toolStripButton6
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Переместить в конец";

            // toolStripSeparator3
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBadAndExpensive);
            this.Controls.Add(this.btnTastyAndCheap);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnUnpopularDishes);
            this.Controls.Add(this.btnPopularDishes);
            this.Controls.Add(this.btnBestTaste);
            this.Controls.Add(this.btnLowCalorie);
            this.Controls.Add(this.txtMaxCalories);
            this.Controls.Add(this.btnCheapDishes);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.btnOpenSurveyForm);
            this.Controls.Add(this.btnSaveSurvey);
            this.Controls.Add(this.btnSaveMenu);
            this.Controls.Add(this.surveyDataGridView);
            this.Controls.Add(this.menuDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор кафе - Анализ меню и опросов";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.DataGridView surveyDataGridView;
        private System.Windows.Forms.Button btnSaveMenu;
        private System.Windows.Forms.Button btnSaveSurvey;
        private System.Windows.Forms.Button btnOpenSurveyForm;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Button btnCheapDishes;
        private System.Windows.Forms.TextBox txtMaxCalories;
        private System.Windows.Forms.Button btnLowCalorie;
        private System.Windows.Forms.Button btnBestTaste;
        private System.Windows.Forms.Button btnPopularDishes;
        private System.Windows.Forms.Button btnUnpopularDishes;
        private System.Windows.Forms.Button btnTastyAndCheap;
        private System.Windows.Forms.Button btnBadAndExpensive;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private CafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private CafeDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.BindingSource surveyBindingSource;
        private CafeDataSetTableAdapters.SurveyTableAdapter surveyTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.Tool