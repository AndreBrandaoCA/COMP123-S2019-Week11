using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Week11
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the Mainform's FormClosing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the ExitToolStripMenuItem Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the AboutToolStripMenuItem Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }
        /// <summary>
        /// This is the event handler for the HelpToolStripButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sectionCDatabaseDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.sectionCDatabaseDataSet.StudentTable);

        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            var StudentList =
                from student in this.sectionCDatabaseDataSet.StudentTable
                select student;

            foreach(var student in StudentList.ToList())
            {
                Debug.WriteLine("Student ID: " + student.StudentId +
                    "Last Name: " + student.LastName);
            }
        }
    }
}
