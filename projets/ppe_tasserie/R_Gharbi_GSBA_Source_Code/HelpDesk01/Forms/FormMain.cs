using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk01.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Data.Odbc.OdbcConnection con = new System.Data.Odbc.OdbcConnection("Driver={MySQL ODBC 5.1 Driver};Server=127.0.0.1;Port=3306;Database=dbppe4gsbhd_20202022;User=root;");
            //MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=dbppe4gsbhd_20202022;Uid=root;");
            // System.Data.Odbc.OdbcConnection con = new System.Data.Odbc.OdbcConnection("Server=51.178.86.117;Database=redwan;Uid=redwan;Pwd=zjyLzL9JY;");
            MySqlConnection con = new MySqlConnection("Server=sql11.freemysqlhosting.net;Database=sql11490529;Uid=sql11490529;Pwd=ULWkqf2Uvr;");

            try
            {
                //this.NavigationService?.Navigate(new Page.Home(userinformation));
                con.Open();
                con.Close();
                MessageBox.Show("Connexion OK");

                FormEquipementListe formEquipementListe = new FormEquipementListe();
                formEquipementListe.Show();
            }
            catch(Exception fail)
            {
                System.Diagnostics.Debug.WriteLine(fail.Message);
            }
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
