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
    public partial class frmUtilizatori : Form
    {
        string CnnStr =
               "Provider=Microsoft.Jet.OLEDB.4.0;Data " +
               "Source= " + Application.StartupPath + "\\SMS.mdb;Jet OLEDB:Database Password=voineadragos2017";

        OleDbConnection cnn = new OleDbConnection();

        Int64 uID = 0; // User Id
        public frmUtilizatori()
        {
            InitializeComponent();
        }
        public void Add()
        {
            try
            {
                string strCom = "Insert into Utilizatori(NumeUtilizator, ParolaUtilizator) values ('" +
                          txtUtilizator.Text + "','" + txtParola.Text + "')";

                cnn.ConnectionString = CnnStr;
                cnn.Open();

                OleDbCommand Comm = new OleDbCommand(strCom, cnn);

                Comm.ExecuteNonQuery();
                Comm.Dispose();
                cnn.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();

            try
            {
                cnn.ConnectionString = CnnStr;
                cnn.Open();

                
                OleDbCommand cmd = new OleDbCommand("select * from Utilizatori order by UtilizatorID", cnn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);//executing and filling dataadapter

                da.Fill(ds);//filling datatable and returning

                cmd.Dispose();
                cnn.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ds;


        }
        public void Update_User()
        {
            try
            {
                string strCom = "UPdate Utilizatori set NumeUtilizator = '" +
                        txtUtilizator.Text + "', ParolaUtilizator = '" + txtParola.Text +
                        "' where UtilizatorID = " + uID;


                cnn.ConnectionString = CnnStr;
                cnn.Open();

                OleDbCommand Comm = new OleDbCommand(strCom, cnn);

                Comm.ExecuteNonQuery();
                Comm.Dispose();
                cnn.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                txtUtilizator.Text = "";
                txtParola.Text = "";
                txtParola.Enabled = true;
                txtUtilizator.Enabled = true;

                txtUtilizator.Focus();

                cmdUpdate.Enabled = true;
                cmdUpdate.Text = "Salveaza";
                cmdAdd.Enabled = false;
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
        try
            {
                if (cmdUpdate.Text == "Salveaza")
                {
                    Add();
                    Bind_Grid();
                    txtParola.Enabled = false;
                    txtUtilizator.Enabled = false;
                    cmdUpdate.Enabled = false;

                    cmdAdd.Enabled = true;
                    button1.Enabled = true;

                    MessageBox.Show("Utilizator nou adaugat cu succes!.", "SMS");
                }
                else
                {
                    Update_User();
                    Bind_Grid();
                    txtParola.Enabled = false;
                    txtUtilizator.Enabled = false;
                    cmdUpdate.Enabled = false;

                    cmdAdd.Enabled = true;
                    button1.Enabled = true;

                    MessageBox.Show("Inegistrare utilizator nou cu succes!", "SMS");
                }
            }
            catch (OleDbException ex)
            {
                if (ex.ErrorCode == -2147467259)
                {
                    MessageBox.Show("Acest utilizator deja exista!.", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
       
        private void Bind_Grid()
        {
            try
            {
                DataSet Ds;

                //Ds.Clear();
                Ds = this.SelectAll();
                
                dataGridView1.DataSource = Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtParola.Enabled = true;
            txtUtilizator.Enabled = true;

            cmdAdd.Enabled = false;
            button1.Enabled = false;

            txtUtilizator.Focus();

            cmdUpdate.Enabled = true;
            cmdUpdate.Text = "Actualizeaza";
        }
        public void Sterge()
        {
            try
            {
                string strCom = "Delete * from Utilizatori where UtilizatorID = " + uID;

                cnn.ConnectionString = CnnStr;
                cnn.Open();

                OleDbCommand Comm = new OleDbCommand(strCom, cnn);

                Comm.ExecuteNonQuery();
                Comm.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        
        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Vreti sa stergeti aceasta inregistrare?", "SMS",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result1 == DialogResult.Yes)
            {
                Sterge();

                MessageBox.Show("Utilizator sters cu succes!", "SMS");

                Bind_Grid();
                txtParola.Enabled = false;
                txtUtilizator.Enabled = false;
                cmdUpdate.Enabled = false;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            txtParola.Enabled = false;
            txtUtilizator.Enabled = false;
            cmdUpdate.Enabled = false;

            cmdAdd.Enabled = true;
            button1.Enabled = true;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int SelectedIndex = 0;

                if (e.RowIndex >= 0)
                {
                    SelectedIndex = e.RowIndex;
                }

                uID = Convert.ToInt64(dataGridView1.Rows[SelectedIndex].Cells[0].Value.ToString());
                txtUtilizator.Text = dataGridView1.Rows[SelectedIndex].Cells[1].Value.ToString();
                txtParola.Text = dataGridView1.Rows[SelectedIndex].Cells[2].Value.ToString();

                cmdUpdate.Text = "Actualizeaza";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
           
       
        private void frmUtilizatori_Load(object sender, EventArgs e)
        {
            Bind_Grid();

        }
    }
}
