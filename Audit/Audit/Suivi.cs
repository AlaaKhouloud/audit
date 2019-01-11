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
    public partial class Suivi : Form
    {
        public Suivi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FFB7557;Initial Catalog=crypto_project;Integrated Security=True");
        SqlCommand sqlCommand = null;
        SqlDataReader reader = null;

        private void Suivi_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sql = "select count(*) , title from Audit_questions where jugement!='nan' group by title ";
            sqlCommand = new SqlCommand(sql, connection);
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                if (int.Parse(reader[0].ToString()) > 0)
                {
                    if (reader[1].Equals("Sécurité physique"))
                    {
                        textBox1.Visible = true; label30.Text = reader[0].ToString();
                    }
                    if (reader[1].Equals("Sécurité logique"))
                    {
                        textBox1.Visible = true; label29.Text = reader[0].ToString();
                    }
                    if (reader[1].Equals("Sauvegarde et plan de secours"))
                    {
                        textBox1.Visible = true; label28.Text = reader[0].ToString();
                    }
                    if (reader[1].Equals("Stratégie et controle interne"))
                    {
                        textBox1.Visible = true; label27.Text = reader[0].ToString();
                    }
                    if (reader[1].Equals("ITIL"))
                    {
                        textBox1.Visible = true; label26.Text = reader[0].ToString();
                    }
                    if (reader[1].Equals("Gestion des changements"))
                    {
                        textBox1.Visible = true; label25.Text = reader[0].ToString();
                    }
                }
            }
            reader.Close();
            /////////////////////////////////////////////
            string sql1 = "select count(*) , title from Audit_questions group by title";
            sqlCommand = new SqlCommand(sql1, connection);
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader[1].Equals("Sécurité physique")) label24.Text = reader[0].ToString();
                if (reader[1].Equals("Sécurité logique")) label23.Text = reader[0].ToString();
                if (reader[1].Equals("Sauvegarde et plan de secours")) label22.Text = reader[0].ToString();
                if (reader[1].Equals("Stratégie et controle interne")) label21.Text = reader[0].ToString();
                if (reader[1].Equals("ITIL")) label20.Text = reader[0].ToString();
                if (reader[1].Equals("Gestion des changements")) label19.Text = reader[0].ToString();
            }
            reader.Close();
            /////////////////////////////////////////////
            string sql2 = "select count(*) , title from Audit_questions where jugement='nan' group by title ";
            sqlCommand = new SqlCommand(sql2, connection);
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader[1].Equals("Sécurité physique")) label34.Text = reader[0].ToString();
                if (reader[1].Equals("Sécurité logique")) label33.Text = reader[0].ToString();
                if (reader[1].Equals("Sauvegarde et plan de secours")) label32.Text = reader[0].ToString();
                if (reader[1].Equals("Stratégie et controle interne")) label31.Text = reader[0].ToString();
                if (reader[1].Equals("ITIL")) label12.Text = reader[0].ToString();
                if (reader[1].Equals("Gestion des changements")) label1.Text = reader[0].ToString();
            }
            reader.Close();
            connection.Close();
        }
    }
}
