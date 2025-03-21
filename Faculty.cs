using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facultysystem
{
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Faculty";
            dataGridView1.Columns[1].Name = "Course";
            dataGridView1.Columns[2].Name = "Semester";
            dataGridView1.Columns[3].Name = "Hours";

            // Add rows (example data)
            dataGridView1.Rows.Add("Dr. Smith", "C++ Programming", "Spring 2025", "3");
            dataGridView1.Rows.Add("Prof. John", "AI Fundamentals", "Fall 2024", "4");
        }
    }
}
