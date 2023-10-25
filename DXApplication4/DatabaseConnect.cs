using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication4
{
    public partial class DatabaseConnect : DevExpress.XtraEditors.XtraForm
    {
        Form1 f1;
        public DatabaseConnect(Form1 _f1)
        {
            InitializeComponent();
            f1 = _f1;
        }
        //Data Source=.;Initial Catalog=STOK_DATA;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=5;
        private void DatabaseConnect_Load(object sender, EventArgs e)
        {

        }

        private void authenticationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (authenticationCombo.SelectedIndex == 0)
            {
                userNameCombo.Enabled = false;
                passwordText.Enabled = false;
            }else if(authenticationCombo.SelectedIndex == 1)
            {
                userNameCombo.Enabled = true;
                passwordText.Enabled = true;
            }
            else
            {

            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {

            f1.accordionControl1.Clear();
            f1.server = serverNameCombo.Text;
            SqlConnection sqlConnection = new SqlConnection("server=" + serverNameCombo.Text + "; integrated security=true;");

            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();

            Sunucu sunucu = new Sunucu(serverNameCombo.Text);
            List<Veritabani> veritabanlari = new List<Veritabani>();
            string query = "SELECT name FROM sys.databases where database_id > 4 ";
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string dbName = reader["name"].ToString();
                        Veritabani v1 = new Veritabani();
                        v1.name = dbName;
                        veritabanlari.Add(v1);
                    }
                }
            }

            AccordionControlElement groupElement1 = new AccordionControlElement();
            groupElement1.Text = serverNameCombo.Text;

            foreach (var item in veritabanlari)
            {
                AccordionControlElement itemElement1 = new AccordionControlElement();
                itemElement1.Text = item.name;
                groupElement1.Elements.AddRange(new[] { itemElement1 });



                List<Tablo> tablolar = new List<Tablo>();
                string queryTablolar = "use " + item.name + " select name from sys.tables";
                using (SqlCommand command = new SqlCommand(queryTablolar, sqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tabloName = reader["name"].ToString();
                            Tablo t1 = new Tablo();
                            t1.name = tabloName;
                            tablolar.Add(t1);
                        }
                    }
                }

                foreach (var item1 in tablolar)
                {
                    AccordionControlElement itemTablo = new AccordionControlElement();
                    itemTablo.Style = ElementStyle.Item;
                    itemTablo.Text = item1.name;
                    itemElement1.Elements.AddRange(new[] { itemTablo });
                    itemTablo.Click += f1.ItemElement_Click;
                }


            }



            f1.accordionControl1.Elements.AddRange(new[] { groupElement1 });
            this.Close();
        }
    }
}