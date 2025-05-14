using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CafeSurveyApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        public void SetData<T>(List<T> data)
        {
            resultsDataGridView.DataSource = data;
            resultsDataGridView.AutoResizeColumns();
        }
    }
}