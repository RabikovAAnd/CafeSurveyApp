namespace CafeSurveyApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new CafeSurveyApp.CafeDataSet();
            this.surveyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new CafeSurveyApp.CafeDataSetTableAdapters.MenuTableAdapter();
            this.surveyTableAdapter = new CafeSurveyApp.CafeDataSetTableAdapters.SurveyTableAdapter();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.surveyDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSaveMenu = new System.Windows.Forms.Button();
            this.btnSaveSurvey = new System.Windows.Forms.Button();
            this.btnOpenSurveyForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.btnCheapDishes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxCalories = new System.Windows.Forms.TextBox();
            this.btnLowCalorie = new System.Windows.Forms.Button();
            this.btnBestTaste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyDataGridView)).BeginInit();
            this.SuspendLayout();

            // menuBindingSource
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.cafeDataSet;

            // cafeDataSet
            this.cafeDataSet.DataSetName = "CafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            // surveyBindingSource
            this.surveyBindingSource.DataMember = "Survey";
            this.surveyBindingSource.DataSource = this.cafeDataSet;

            // menuTableAdapter
            this.menuTableAdapter.ClearBeforeFill = true;

            // surveyTableAdapter
            this.surveyTableAdapter.ClearBeforeFill = true;

            // menuDataGridView
            this.menuDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.Location = new System.Drawing.Point(12, 12);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.Size = new System.Drawing.Size(760, 200);
            this.menuDataGridView.TabIndex = 0;

            // surveyDataGridView
            this.surveyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surveyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.surveyDataGridView.Location = new System.Drawing.Point(12, 250);
            this.surveyDataGridView.Name = "surveyDataGridView";
            this.surveyDataGridView.Size = new System.Drawing.Size(760, 200);
            this.surveyDataGridView.TabIndex = 1;

            // btnSaveMenu
            this.btnSaveMenu.Location = new System.Drawing.Point(12, 218);
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Size = new System.Drawing.Size(100, 23);
            this.btnSaveMenu.TabIndex = 2;
            this.btnSaveMenu.Text = "Сохранить меню";
            this.btnSaveMenu.UseVisualStyleBackColor = true;
            this.btnSaveMenu.Click += new System.EventHandler(this.btnSaveMenu_Click);

            // btnSaveSurvey
            this.btnSaveSurvey.Location = new System.Drawing.Point(12, 456);
            this.btnSaveSurvey.Name = "btnSaveSurvey";
            this.btnSaveSurvey.Size = new System.Drawing.Size(100, 23);
            this.btnSaveSurvey.TabIndex = 3;
            this.btnSaveSurvey.Text = "Сохранить опросы";
            this.btnSaveSurvey.UseVisualStyleBackColor = true;
            this.btnSaveSurvey.Click += new System.EventHandler(this.btnSaveSurvey_Click);

            // btnOpenSurveyForm
            this.btnOpenSurveyForm.Location = new System.Drawing.Point(672, 456);
            this.btnOpenSurveyForm.Name = "btnOpenSurveyForm";
            this.btnOpenSurveyForm.Size = new System.Drawing.Size(100, 23);
            this.btnOpenSurveyForm.TabIndex = 4;
            this.btnOpenSurveyForm.Text = "Новый опрос";
            this.btnOpenSurveyForm.UseVisualStyleBackColor = true;
            this.btnOpenSurveyForm.Click += new System.EventHandler(this.btnOpenSurveyForm_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Макс. цена:";

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

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Макс. калории:";

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
            this.btnBestTaste.Location = new System.Drawing.Point(500, 456);
            this.btnBestTaste.Name = "btnBestTaste";
            this.btnBestTaste.Size = new System.Drawing.Size(166, 23);
            this.btnBestTaste.TabIndex = 11;
            this.btnBestTaste.Text = "Самые вкусные блюда";
            this.btnBestTaste.UseVisualStyleBackColor = true;
            this.btnBestTaste.Click += new System.EventHandler(this.btnBestTaste_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.btnBestTaste);
            this.Controls.Add(this.btnLowCalorie);
            this.Controls.Add(this.txtMaxCalories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheapDishes);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenSurveyForm);
            this.Controls.Add(this.btnSaveSurvey);
            this.Controls.Add(this.btnSaveMenu);
            this.Controls.Add(this.surveyDataGridView);
            this.Controls.Add(this.menuDataGridView);
            this.Name = "Form1";
            this.Text = "Администратор кафе";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.BindingSource menuBindingSource;
        private CafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource surveyBindingSource;
        private CafeDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private CafeDataSetTableAdapters.SurveyTableAdapter surveyTableAdapter;
        private System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.DataGridView surveyDataGridView;
        private System.Windows.Forms.Button btnSaveMenu;
        private System.Windows.Forms.Button btnSaveSurvey;
        private System.Windows.Forms.Button btnOpenSurveyForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Button btnCheapDishes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxCalories;
        private System.Windows.Forms.Button btnLowCalorie;
        private System.Windows.Forms.Button btnBestTaste;
    }
}