using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Task_Manager {
  public partial class Form1 : MetroFramework.Forms.MetroForm {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      Start_PNL.Visible = false;
      Program_List();
      timer.Interval = 500;
      timer1.Interval = 30000;
      timer.Start();
      timer1.Enabled = true;
      Task_End.Enabled = false;
    }

    private Process[] proc;

    // programs listing
    private void Program_List() {
      Task_List.Items.Clear();

      proc = Process.GetProcesses();
      List<int> Parents = new List<int>();
      int counter = 0;

      for (int i = 0; i < proc.Length; i++) {
        Process parentProcess = GetParentProcess(proc[i].Id);
        if (parentProcess == null) return;

        if (!Parents.Contains(parentProcess.Id)) {
          Task_List.Items.Add(parentProcess.Id.ToString());
          Task_List.Items[i - counter].SubItems.Add(parentProcess.ProcessName);
          Task_List.Items[i - counter].SubItems.Add(Convert.ToInt32(Math.Round(Convert.ToDecimal(parentProcess.PrivateMemorySize64 / 1048576))) + "MB");

          Parents.Add(parentProcess.Id);
        } else counter++;
      }

      Apps_LBL.Text = "Running apps : " + Task_List.Items.Count.ToString();
    }

    // killing process
    private void Task_End_Click(object sender, EventArgs e) {
      try {
        Process.GetProcessById(Convert.ToInt32(Task_List.SelectedItems[0].SubItems[0].Text)).Kill();
        Program_List();
      } catch (Exception excptn) {
        MessageBox.Show("hata oluştu" + excptn);
      }
    }

    // starting process
    private void Start_BTN_Click(object sender, EventArgs e) {
      if (Start_PNL.Visible) {
        try {
          Process.Start(APP_Path_TXT.Text);
          Program_List();
        } catch (InvalidOperationException) {
          MessageBox.Show("Please Choose a Path");
        } catch (System.ComponentModel.Win32Exception) {
          MessageBox.Show("Please Choose a Correct Path");
        }
      } else {
        Start_PNL.Visible = true;
      }
    }

    private void çıkışToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void timer_Tick(object sender, EventArgs e) {
      float fcpu = pCPU.NextValue();
      float fram = pRAM.NextValue();
      metroProgressBar_CPU.Value = (int)fcpu;
      metroProgressBar_Memory.Value = (int)fram;
      memory_LBL.Text = string.Format("{0:0.0%}", fram / 100);
      cpu_LBL.Text = string.Format("{0:0.0%}", fcpu / 100);
      chart1.Series["CPU"].Points.AddY(fcpu);
      chart1.Series["RAM"].Points.AddY(fram);
    }

    private void timer1_Tick(object sender, EventArgs e) {
      chart1.Series["CPU"].Points.Clear();
      chart1.Series["RAM"].Points.Clear();
    }

    private void Task_List_SelectedIndexChanged(object sender, EventArgs e) {
      Task_End.Enabled = true;
    }


    // search bar
    private void searchTxt_TextChanged(object sender, EventArgs e) {
      proc = Process.GetProcesses();
      Task_List.Items.Clear();
      int i = 0;
      if (searchTxt.Text == "") {
        Program_List();
      } else {
        foreach (Process p in proc) {
          if (p.ProcessName.Contains(searchTxt.Text)) {
            Task_List.Items.Add(p.Id.ToString());
            Task_List.Items[i].SubItems.Add(p.ProcessName);
            Task_List.Items[i].SubItems.Add(Convert.ToInt32(Math.Round(Convert.ToDecimal(p.PrivateMemorySize64 / 1048576))) + "MB");
            i++;
          }
        }
      }
    }

    private static Process GetParentProcess(int pid) {
      int iParentPid = 0;
      int iCurrentPid = pid;

      IntPtr oHnd = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);

      if (oHnd == IntPtr.Zero)
        return null;

      PROCESSENTRY32 oProcInfo = new PROCESSENTRY32();

      oProcInfo.dwSize =
      (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(PROCESSENTRY32));

      if (Process32First(oHnd, ref oProcInfo) == false)
        return null;

      do {
        if (iCurrentPid == oProcInfo.th32ProcessID)
          iParentPid = (int)oProcInfo.th32ParentProcessID;
      }
      while (iParentPid == 0 && Process32Next(oHnd, ref oProcInfo));

      if (iParentPid > 0) {
        try {
          return Process.GetProcessById(iParentPid);
        } catch {
          return Process.GetProcessById(0);
        }
      } else
        return null;
    }

    static uint TH32CS_SNAPPROCESS = 2;

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSENTRY32 {
      public uint dwSize;
      public uint cntUsage;
      public uint th32ProcessID;
      public IntPtr th32DefaultHeapID;
      public uint th32ModuleID;
      public uint cntThreads;
      public uint th32ParentProcessID;
      public int pcPriClassBase;
      public uint dwFlags;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
      public string szExeFile;
    };

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr CreateToolhelp32Snapshot(uint dwFlags, uint th32ProcessID);

    [DllImport("kernel32.dll")]
    static extern bool Process32First(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

    [DllImport("kernel32.dll")]
    static extern bool Process32Next(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

    private void Task_List_ItemAdded(MetroFramework.Controls.MetroListView obj) {
      Apps_LBL.Text = "Running apps : " + Task_List.Items.Count.ToString();
    }
  }
}
