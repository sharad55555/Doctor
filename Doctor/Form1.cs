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


namespace Doctor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static string SetValueForText1 = "";
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void metroButton2_Click_1(object sender, EventArgs e)
        {

            SetValueForText1 = metroTextEmail.Text;
            

            Email ex = new Email();
           
            ex.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            
          try
            {
             if (metroTextAge.Text !="" & metroTextName.Text != "" & metroTextEmail.Text != "" & metroTextId.Text !="" )
            {
            
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Rutuja\source\repos\Doctor\Doctor\Database.mdf; Integrated Security = True");
            SqlCommand cmd;
            
            con.Open();

             cmd = new SqlCommand("insert into Info values(@Id,@Name,@Age,@Email,@Blood,@Mobile,@Address,@Date)", con);

                     cmd.Parameters.AddWithValue("@Id", metroTextId.Text);
                     cmd.Parameters.AddWithValue("@Name", metroTextName.Text);
                     cmd.Parameters.AddWithValue("@Age", metroTextAge.Text);
                     cmd.Parameters.AddWithValue("@Email", metroTextEmail.Text);
                     cmd.Parameters.AddWithValue("@Blood", metroTextBlood.Text);
                     cmd.Parameters.AddWithValue("@Mobile", metroTextMobile.Text);
                     cmd.Parameters.AddWithValue("@Address", metroTextBoxAdd.Text);
             cmd.Parameters.AddWithValue("@Date", dateTime.Value);

             
            
            cmd.ExecuteNonQuery();
            con.Close();
               MessageBox.Show("Record Added");
            }
            else
            {
              MessageBox.Show("Please add record First");
            }
            }
           catch (Exception)
            {

            MessageBox.Show("Error");
            

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PrintReport pr = new PrintReport();
            pr.ShowDialog();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
