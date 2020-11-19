using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace Doctor
{
    public partial class PrintReport : MetroFramework.Forms.MetroForm
    {
        public PrintReport()
        {
            InitializeComponent();
        }

        private void PrintReport_Load(object sender, EventArgs e)
        {
            GetLoadData();
        }

        public void GetLoadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Rutuja\source\repos\Doctor\Doctor\Database.mdf; Integrated Security = True");
            //SqlCommand cmd;
            string sqlquery = "Select * from Info";
            con.Open();
            SqlCommand comm = new SqlCommand(sqlquery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }
        private void metroButton1_Click(object sender, EventArgs e)
        {

            
            DGVPrinter printer = new DGVPrinter();
            printer.Title = " Ruby Hospital ";
            printer.SubTitle = " All Patient Reports";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
            StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Your Company Name Here";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
