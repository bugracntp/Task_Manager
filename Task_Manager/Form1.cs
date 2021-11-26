using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Start_PNL.Visible = false;
            Program_List();
            timer.Interval = 500;
            timer1.Interval = 30000;
            timer.Start();
            timer1.Enabled = true;
            Task_End.Enabled = false;
        }

        private Process[] proc;

        private void Program_List()
        {
            proc = Process.GetProcesses();
            Task_List.Items.Clear();
            for (int i = 0; i < proc.Length; i++)
            {
                Task_List.Items.Add(proc[i].Id.ToString());
                Task_List.Items[i].SubItems.Add(proc[i].ProcessName);
                Task_List.Items[i].SubItems.Add(Convert.ToInt32(Math.Round(Convert.ToDecimal(proc[i].PrivateMemorySize64 / 1048576))) + "MB");
            }
            Apps_LBL.Text = "Running apps : " + Task_List.Items.Count.ToString();
        }

        // killing process
        private void Task_End_Click(object sender, EventArgs e)
        {
            try
            {
                Process.GetProcessById(Convert.ToInt32(Task_List.SelectedItems[0].SubItems[0].Text)).Kill();
                Program_List();
            }
            catch (Exception excptn)
            {
                MessageBox.Show("hata oluştu" + excptn);
            }
        }

        // starting process
        private void Start_BTN_Click(object sender, EventArgs e)
        {
            if (Start_PNL.Visible)
            {
                try
                {
                    Process.Start(APP_Path_TXT.Text);
                    Program_List();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Please Choose a Path");
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    MessageBox.Show("Please Choose a Correct Path");
                }
            }
            else
            {
                Start_PNL.Visible = true;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            metroProgressBar_CPU.Value = (int)fcpu;
            metroProgressBar_Memory.Value = (int)fram;
            memory_LBL.Text = string.Format("{0:0.0%}", fram / 100);
            cpu_LBL.Text = string.Format("{0:0.0%}", fcpu / 100);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.Series["CPU"].Points.Clear();
            chart1.Series["RAM"].Points.Clear();
        }

        private void Task_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task_End.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            proc = Process.GetProcesses();
            Task_List.Items.Clear();
            int i = 0;
            foreach (Process p in proc)
            {
                if (p.ProcessName == searchTxt.Text)
                {
                    Task_List.Items.Add(p.Id.ToString());
                    Task_List.Items[i].SubItems.Add(p.ProcessName);
                    Task_List.Items[i].SubItems.Add(Convert.ToInt32(Math.Round(Convert.ToDecimal(p.PrivateMemorySize64 / 1048576))) + "MB");
                    i++;
                }
            }
        }
    }
}