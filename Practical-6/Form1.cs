using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace StudentRegistration
{


    public partial class Form1 : Form
    {
        String gender="";
        string imgPath, imgstudent;
        private object radioButton1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            string select = "select count(*) from Student";
            SqlConnection conn = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            int i = Convert.ToInt16(cmd.ExecuteScalar());
           
            int pkStudent = i + 1;

            string insert = "insert into Student (pkStudent, fname,lname,dob,imgstudent,gender,mobile,email) values ( " + pkStudent + ",'" + txtFname.Text + "','"+ txtLname.Text +"','"+ dob.Value.Date + "','" + (imgPath == null ? "" : imgPath) + "','"+ gender+"','"+txtMobile.Text + "','" + txtEmail.Text + "')";
            cmd = new SqlCommand(insert, conn);

            i = cmd.ExecuteNonQuery();

            MessageBox.Show("You are Done!!!");
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpg|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgPath = @"D:\5HY4M\Pics..!!\" + openFileDialog1.SafeFileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                //MessageBox.Show(imgPath);
            }
        }
    }
}
