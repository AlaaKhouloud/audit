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
    public partial class slogique : Form
    {
        public slogique()
        {
            InitializeComponent();
        }

        private void slogique_Load(object sender, EventArgs e)
        {
            //fill datagridview from database
            string connetionString = "Data Source=DESKTOP-FFB7557;Initial Catalog=crypto_project;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connetionString); ;
            SqlCommand command = new SqlCommand();
            SqlDataAdapter sqlDataAdap = null;
            DataTable dtRecord = null;
            string sql = "select title , subtitle , question , commentaire , coeficient , jugement , etat_traitement from Audit_questions where title = 'Sécurité logique'"; ;

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
            dataGridView1.Columns["subtitle"].ReadOnly = true;
            dataGridView1.Columns["question"].ReadOnly = true;
            dataGridView1.Columns["coeficient"].ReadOnly = true;
            dataGridView1.Columns["etat_traitement"].ReadOnly = true;
            //how many questions do we treat?
            label3.Text = (this.dataGridView1.RowCount - 1).ToString();
        }
    }
}
