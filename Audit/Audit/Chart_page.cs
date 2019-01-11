using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Audit
{
    public partial class Chart_page : Form
    {
        public Chart_page()
        {
            InitializeComponent();
        }

        private void Chart_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Audit_questions' table. You can move, or remove it, as needed.
            this.Audit_questionsTableAdapter.Fill(this.DataSet1.Audit_questions);

            this.reportViewer1.RefreshReport();
        }
    }
}
