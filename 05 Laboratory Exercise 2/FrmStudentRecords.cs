using System;
using System.IO;
using System.Windows.Forms;

namespace FrmLab1
{
    public partial class FrmStudentRecord : Form
    {
        private string path;

        public FrmStudentRecord()
        {
            InitializeComponent();
        }
        private void btnBackRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration registrationForm = new FrmRegistration();
            registrationForm.Show();
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog1.Title = "Browse Student Record Files";
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                    DisplayToList(path);
                }
                else
                {
                    MessageBox.Show("No file selected.");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found. Please check the file path.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }
        private void DisplayToList(string filePath)
        {
            listView1.Items.Clear();
            listView1.View = View.List;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    listView1.Items.Add(line);
                }
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            listView1.Items.Clear();
        }
    }
}
