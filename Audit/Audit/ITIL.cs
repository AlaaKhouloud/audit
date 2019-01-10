using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Audit
{
    public partial class ITIL : Form
    {
        public ITIL()
        {
            InitializeComponent();
        }

        private void ITIL_Load(object sender, EventArgs e)
        {
            //fill datagridview from database
            string connetionString = "Data Source=DESKTOP-FFB7557;Initial Catalog=crypto_project;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connetionString); ;
            SqlCommand command = new SqlCommand();
            SqlDataAdapter sqlDataAdap = null;
            DataTable dtRecord = null;
            string sql = "select * from Audit_questions where title = 'ITIL'"; ;

            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                sqlDataAdap = new SqlDataAdapter(command);

                dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;

                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            //how many questions do we treat?
            label3.Text = (this.dataGridView1.RowCount - 1).ToString();
        }
    }
}
