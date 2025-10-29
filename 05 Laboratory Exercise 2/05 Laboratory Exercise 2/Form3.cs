using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLab
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboProgram.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            string studentNo = txtStudentNo.Text;
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string mi = txtMi.Text;
            string program = cboProgram.Text;
            string gender = cboGender.Text;
            string age = txtAge.Text;
            string birthday = dtpBirthday.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string contactNo = txtContact.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = $"{studentNo}.txt";
            string filePath = Path.Combine(docPath, fileName);

            string[] lines =
            {
                $"Student No.: {studentNo}",
                $"Full Name: {lastName}, {firstName} {mi}",
                $"Program: {program}",
                $"Gender: {gender}",
                $"Age: {age}",
                $"Birthday: {birthday}",
                $"Contact No.: {contactNo}"
            };

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }

            MessageBox.Show($"File saved successfully at:\n{filePath}",
                "Registration Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            cboProgram.Items.Add("BS in Information Technology");
            cboProgram.Items.Add("BS Criminology");
            cboProgram.Items.Add("BS Tourism Management");
            cboProgram.Items.Add("BS Hospitality Management");

            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");

            cboProgram.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
        }
    }
}

        
    



