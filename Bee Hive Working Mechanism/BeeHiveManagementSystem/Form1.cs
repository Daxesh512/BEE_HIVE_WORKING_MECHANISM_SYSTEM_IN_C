using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHiveManagementSystem
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();

            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manu;facturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar Collector", "Honey Manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });

            queen = new Queen(workers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("No workers are available to do the job" + workerBeeJob.Text + "the queen bee says");
            else
                MessageBox.Show("The job" + workerBeeJob.Text + " will be done in " + shifts.Value + "shifts, the queen bee says");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = queen.WorkTheNextShift();
        }
    }
}
