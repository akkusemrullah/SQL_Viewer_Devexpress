using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication4
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }
       

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        public string server="";
        public void ItemElement_Click(object sender,  EventArgs e)
        {
            AccordionControlElement clickedElement = (AccordionControlElement)sender;
            string xx = clickedElement.OwnerElement.Text;

           
            SqlConnection sqlConnection = new SqlConnection("server=" +server + "; initial catalog="+xx+"; integrated security=true;");

            using (SqlConnection connection = new SqlConnection(sqlConnection.ConnectionString))
            {
                connection.Open();

                // Veriyi çekmek için sorgu
                string query = "SELECT * FROM "+ clickedElement.Text;

                // SqlDataAdapter ile verileri çek
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridView1.Columns.Clear();
                    gridControl1.DataSource = dataTable;
                    gridView1.PopulateColumns();

                }
            }
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

           

        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            gridControl1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DatabaseConnect databaseConnect = new DatabaseConnect(this);
            databaseConnect.Show();
        }
    }


}

public class Sunucu
{
    public Sunucu(string _name)
    {
        name = _name;
    }

    public string name { get; set; }
    public List<Veritabani> veritabanlari { get; set; }
}
public class Veritabani
{
    public string name { get; set; }
    public List<Tablo> tablolar { get; set; }

}

public class Tablo
{
    public string name { get; set; }
}

