namespace CafeSurveyApp
{
    partial class SurveyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dishComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tasteRating = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.priceRating = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tasteRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceRating)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Блюдо:";

            // dishComboBox
            this.dishComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dishComboBox.FormattingEnabled = true;
            this.dishComboBox.Location = new System.Drawing.Point(60, 12);
            this.dishComboBox.Name = "dishComboBox";
            this.dishComboBox.Size = new System.Drawing.Size(200, 21);
            this.dishComboBox.TabIndex = 1;

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оценка вкуса:";

            // tasteRating
            this.tasteRating.Location = new System.Drawing.Point(104, 48);
            this.tasteRating.Name = "tasteRating";
            this.tasteRating.Size = new System.Drawing.Size(50, 20);
            this.tasteRating.TabIndex = 3;
            this.tasteRating.Value = 3;

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Оценка цены:";

            // priceRating
            this.priceRating.Location = new System.Drawing.Point(104, 78);
            this.priceRating.Name = "priceRating";
            this.priceRating.Size = new System.Drawing.Size(50, 20);
            this.priceRating.TabIndex = 5;
            this.priceRating.Value = 3;

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(104, 120);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Отправить";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(185, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // SurveyForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 155);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.priceRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tasteRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dishComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SurveyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оцените блюдо";
            this.Load += new System.EventHandler(this.SurveyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tasteRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dishComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tasteRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown priceRating;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}