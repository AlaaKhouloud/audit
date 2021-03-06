﻿using System;
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
    public partial class splan : Form
    {
        public splan()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FFB7557;Initial Catalog=crypto_project;Integrated Security=True");
        SqlDataAdapter sqlAdapter = null;
        SqlCommandBuilder sqlCommand = null;
        DataSet dataset = new DataSet();
        SqlCommandBuilder cmdbl = null;
        private void splan_Load(object sender, EventArgs e)
        {
                connection.Open();
                //fill datagridview from database 
                string sql = "select id_question as 'N°' , subtitle , question , coeficient , jugement , commentaire from Audit_questions where title = 'Sauvegarde et plan de secours'"; ;
                sqlAdapter = new SqlDataAdapter(sql, connection);
                sqlCommand = new SqlCommandBuilder(sqlAdapter); 
                dataset = new DataSet();
                sqlAdapter.Fill(dataset, "data");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataset.Tables["data"];

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns["subtitle"].ReadOnly = true;
                dataGridView1.Columns["question"].ReadOnly = true;
                dataGridView1.Columns["coeficient"].ReadOnly = true;

                dataGridView1.Visible = true;
                label2.Text = (this.dataGridView1.RowCount-1).ToString();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //save modifs into database
            try{
                cmdbl = new SqlCommandBuilder(sqlAdapter);
                sqlAdapter.Update(dataset, "data");
                label2.Text = (this.dataGridView1.RowCount - 1).ToString();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Lime;
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "oui" || dataGridView1.Rows[i].Cells[4].Value.ToString() == "non") 
                         dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                }
            }
            catch (Exception ex)
            {
            }
        }
 
    }
}
