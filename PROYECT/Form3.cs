using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECT
{
    public partial class Form3 : Form
    {
        private string currentFilePath;
        public Form3()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (currentFilePath != null)
            {
                DataTable dt = (DataTable)dgvinformation.DataSource;
                string[] lines = new string[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lines[i] = dt.Rows[i][0].ToString();
                }

                File.WriteAllLines(currentFilePath, lines);
                MessageBox.Show("File saved successfully!");
            }
            else
            {
                MessageBox.Show("No file loaded to save.");
            }
        }

        private void btnopenfile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                string[] fileData = File.ReadAllLines(currentFilePath);

                DataTable dt = new DataTable();
                dt.Columns.Add("Recipe");

                foreach (string line in fileData)
                {
                    dt.Rows.Add(line);
                }

                dgvinformation.DataSource = dt;
                dgvinformation.ReadOnly = false; 
            }
        }
        private void btnback2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
