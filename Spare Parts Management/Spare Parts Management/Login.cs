using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Spare_Parts_Management
{
    public partial class frmLogin : Form
    {

        string CnnStr =
             "Provider=Microsoft.Jet.OLEDB.4.0;Data " +
             "Source= " + Application.StartupPath + "\\SMS.mdb;Jet OLEDB:Database Password=voineadragos2017";
        
        OleDbConnection cnn = new OleDbConnection();

       
        

        public frmLogin()
        {
            InitializeComponent();
        }
        private void Load_Utilizatori()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
           
            try
            {
                string strCom = "Select NumeUtilizator from Utilizatori";


                cnn.ConnectionString = CnnStr;
                cnn.Open();

                OleDbCommand Comm = new OleDbCommand(strCom, cnn);

                OleDbDataReader dr = Comm.ExecuteReader();
                cmbUtilizatori.Items.Clear();
                cmbUtilizatori.Items.Add("Selectati utilizator");
                
                while (dr.Read())
                {
                    cmbUtilizatori.Items.Add(dr[0]);
                }

                cmbUtilizatori.SelectedIndex = 0;

                Comm.Dispose();
                cnn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Check_Expiry()
        {
            DateTime newDate = new DateTime();
            TimeSpan RemainingDay = new TimeSpan();
            DateTime TodayDate = DateTime.Today;

            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }

            try
            {
                string strCom = "Select ExpiryDate, FirstDay from Expiry where sr = 1";


                cnn.ConnectionString = CnnStr;
                cnn.Open();

                OleDbCommand Comm = new OleDbCommand(strCom, cnn);

                OleDbDataReader dr = Comm.ExecuteReader();

                while (dr.Read())
                {
                    if (dr[0] == DBNull.Value)
                    {
                        newDate = DateTime.Today;
                        Insert_Expiry_Date(newDate);
                    }
                    else if (Convert.ToDateTime(dr[1]) > DateTime.Today)
                    {
                        MessageBox.Show("Va rugam corectati data sistemului dvs!", "SMS");
                        Application.Exit();
                    }
                    else if (Convert.ToDateTime(dr[0]) < DateTime.Today)
                    {
                        MessageBox.Show("Va rugam corectati data sistemului dvs!", "SMS");
                        Application.Exit();
                    }
                    else
                    {
                        if (Convert.ToDateTime(dr[0]) == DateTime.Today)
                        {
                            MessageBox.Show("Perioada dvs gratuita a expirat. Va rugam cumparati acest Software.", "SMS");
                            Application.Exit();
                        }
                        else
                        {
                            newDate = Convert.ToDateTime(dr[0]);
                            RemainingDay = newDate.Subtract(TodayDate);

                            MessageBox.Show("Mai aveti " + RemainingDay.Days + " zile ramase.", "SMS");
                        }
                    }
                }

                dr.Dispose();
                Comm.Dispose();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Insert_Expiry_Date(DateTime date)
        {
            try
            {

                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }


                string strCom = "update Expiry set ExpiryDate = #" + date.AddDays(10) +
                    "#, FirstDay = #" + date + "# where sr = 1";
                cnn.ConnectionString = CnnStr;
                cnn.Open();

                OleDbCommand Comm = new OleDbCommand(strCom, cnn);

                Comm.ExecuteNonQuery();

                MessageBox.Show("Au mai ramas 10 zile de folosire Software.", "SMS");

                Comm.Dispose();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            Check_Expiry();
            Load_Utilizatori();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }

            if (cmbUtilizatori.Text == "Selectati utilizator")
            {
                MessageBox.Show("Va rugam selectati nume utilizator!", "SMS");
            }
            else if (txtParola.Text == "")
            {
                MessageBox.Show("Va rugam introduceti parola!", "SMS");
            }
            else
            {
                try
                {
                    string strCom = "Select ParolaUtilizator from Utilizatori where NumeUtilizator = '" + cmbUtilizatori.Text + "'";

                    cnn.ConnectionString = CnnStr;
                    cnn.Open();

                    OleDbCommand Comm = new OleDbCommand(strCom, cnn);

                    OleDbDataReader DR = Comm.ExecuteReader();

                    while (DR.Read())
                    {
                        if (DR[0].ToString() == txtParola.Text)
                        {
                            Program.flag = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nume utilizator sau parola invalida!", "SMS");
                        }
                    }



                    Comm.Dispose();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Program.flag = false;

            Application.Exit();
        }


        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            Load_Utilizatori();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }

            if (cmbUtilizatori.Text == "Selectati utilizator" | txtParola.Text == "")
            {
                MessageBox.Show("Va rugam introduceti nume utilizator si parola!", "SMS");
            }
            else
            {
                try
                {
                    string strCom = "Select ParolaUtilizator from Utilizatori where NumeUtilizator = 'Admin'";

                    cnn.ConnectionString = CnnStr;
                    cnn.Open();

                    OleDbCommand Comm = new OleDbCommand(strCom, cnn);

                    OleDbDataReader DR = Comm.ExecuteReader();

                    while (DR.Read())
                    {
                        if (DR[0].ToString() == txtParola.Text)
                        {
                            frmUtilizatori us = new frmUtilizatori();
                            //us.Show();
                            us.StartPosition = FormStartPosition.CenterParent;
                            us.ShowDialog(this);
                        }
                        else
                        {
                            MessageBox.Show("Parola invalida.", "SMS");
                        }
                    }

                    Comm.Dispose();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
                
            }
        

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.flag != true)
            {
                Application.Exit();
            }

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtParola.Text != " ")
            {
                if (e.KeyCode ==Keys.Enter)
                {
                    Login();
                }
            }
            else
            {
                MessageBox.Show("Va rugam introduceti parola","SMS");
            }
        }

        
    }
}
