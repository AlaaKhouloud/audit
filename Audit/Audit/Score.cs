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
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FFB7557;Initial Catalog=crypto_project;Integrated Security=True");
        SqlCommand sqlCommand = null; 
        SqlDataReader reader = null;
        private void Suivi_Load(object sender, EventArgs e)
        {
            string sql = "select count(*) from Audit_questions where title = @title and jugement=@jug";  
            connection.Open();
            sqlCommand = new SqlCommand(sql , connection);
            sqlCommand.Parameters.AddWithValue("@title", "Sécurité physique");
            sqlCommand.Parameters.AddWithValue("@jug", "oui");
            reader = sqlCommand.ExecuteReader(); 
            while (reader.Read())
            {
                label13.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Sécurité physique");
            sqlCommand.Parameters.AddWithValue("@jug", "non"); 
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label24.Text = reader[0].ToString();
            }
            reader.Close();
            /////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Sécurité physique");
            sqlCommand.Parameters.AddWithValue("@jug", "nan"); 
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label30.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Sécurité logique");
            sqlCommand.Parameters.AddWithValue("@jug", "oui"); 
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label18.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Sécurité logique");
            sqlCommand.Parameters.AddWithValue("@jug", "non"); 
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label23.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Sécurité logique");
            sqlCommand.Parameters.AddWithValue("@jug", "nan"); 
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label29.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Sauvegarde et plan de secours");
            sqlCommand.Parameters.AddWithValue("@jug", "oui");
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label17.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Sauvegarde et plan de secours");
            sqlCommand.Parameters.AddWithValue("@jug", "non");
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label22.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Sauvegarde et plan de secours");
            sqlCommand.Parameters.AddWithValue("@jug", "nan");
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label28.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Stratégie et controle interne");
            sqlCommand.Parameters.AddWithValue("@jug", "oui");
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label16.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Stratégie et controle interne");
            sqlCommand.Parameters.AddWithValue("@jug", "non");
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label21.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Stratégie et controle interne");
            sqlCommand.Parameters.AddWithValue("@jug", "nan");
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label27.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "ITIL");
            sqlCommand.Parameters.AddWithValue("@jug", "oui"); 
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label15.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "ITIL");
            sqlCommand.Parameters.AddWithValue("@jug", "non"); 
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label20.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "ITIL");
            sqlCommand.Parameters.AddWithValue("@jug", "nan"); 
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label26.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Gestion des changements");
            sqlCommand.Parameters.AddWithValue("@jug", "oui"); 
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label14.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Gestion des changements");
            sqlCommand.Parameters.AddWithValue("@jug", "non"); 
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label19.Text = reader[0].ToString();
            }
            reader.Close();
            ///////////////////////////////////////////////
            sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Gestion des changements");
            sqlCommand.Parameters.AddWithValue("@jug", "nan"); 
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label25.Text = reader[0].ToString();
            }
            reader.Close();
 
            ///////////////////////////////Calcule de score////////////////////////
            String sqlScore = "select (sum(coeficient)*(select count(*)  from Audit_questions where title = @title and jugement!='nan'))/(select count(*)  from Audit_questions where title = @title) from Audit_questions";
            try
            {
                sqlCommand = new SqlCommand(sqlScore, connection);
                sqlCommand.Parameters.AddWithValue("@title", "Sécurité physique");
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    label36.Text = reader[0].ToString();
                }
               
            }
            catch (SqlException ex)
            {
                label36.Text = "0";
            } reader.Close();
            /////////////////////////////// 
            try
            {
                sqlCommand = new SqlCommand(sqlScore, connection);
                sqlCommand.Parameters.AddWithValue("@title", "Sécurité logique");
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    label35.Text = reader[0].ToString();
                } 
            }
            catch (SqlException ex)
            {
                label35.Text = "0";
            }
            reader.Close();
            /////////////////////////////// 
            try{
            sqlCommand = new SqlCommand(sqlScore, connection);
            sqlCommand.Parameters.AddWithValue("@title", "Sauvegarde et plan de secours");
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label34.Text = reader[0].ToString();
            } 
            }
            catch (SqlException ex)
            {
                label34.Text = "0";
            }
            reader.Close();
            /////////////////////////////// 
            try
            {
                sqlCommand = new SqlCommand(sqlScore, connection);
                sqlCommand.Parameters.AddWithValue("@title", "Stratégie et controle interne");
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    label33.Text = reader[0].ToString();
                } 
            }
            catch (SqlException ex)
            {
                label33.Text = "0";
            }
            reader.Close();
            /////////////////////////////// 
            try
            {
                sqlCommand = new SqlCommand(sqlScore, connection);
                sqlCommand.Parameters.AddWithValue("@title", "ITIL");
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    label32.Text = reader[0].ToString();
                } 
            }
            catch (SqlException ex)
            {
                label32.Text = "0";
            }
            reader.Close();
            /////////////////////////////// 
            try
            {
                sqlCommand = new SqlCommand(sqlScore, connection);
                sqlCommand.Parameters.AddWithValue("@title", "Gestion des changements");
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    label31.Text = reader[0].ToString();
                } 
            }
            catch (SqlException ex)
            {
                label31.Text = "0";
            }
            reader.Close();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chart_page chart = new Chart_page();
            chart.Show();
        }
    }
}
