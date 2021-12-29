
namespace Task_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.pRAM = new System.Diagnostics.PerformanceCounter();
      this.pCPU = new System.Diagnostics.PerformanceCounter();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.metroProgressBar_Memory = new MetroFramework.Controls.MetroProgressBar();
      this.metroProgressBar_CPU = new MetroFramework.Controls.MetroProgressBar();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.Apps_LBL = new MetroFramework.Controls.MetroLabel();
      this.Start_PNL = new MetroFramework.Controls.MetroPanel();
      this.APP_Path_TXT = new MetroFramework.Controls.MetroTextBox();
      this.Task_List = new MetroFramework.Controls.MetroListView();
      this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.Pname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.Start_BTN = new MetroFramework.Controls.MetroButton();
      this.Task_End = new MetroFramework.Controls.MetroButton();
      this.memory_LBL = new MetroFramework.Controls.MetroLabel();
      this.cpu_LBL = new MetroFramework.Controls.MetroLabel();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.x = new MetroFramework.Controls.MetroButton();
      this.searchTxt = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
      this.Start_PNL.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // pRAM
      // 
      this.pRAM.CategoryName = "Memory";
      this.pRAM.CounterName = "% Committed Bytes In use";
      // 
      // pCPU
      // 
      this.pCPU.CategoryName = "Processor";
      this.pCPU.CounterName = "% Processor Time";
      this.pCPU.InstanceName = "_Total";
      // 
      // timer
      // 
      this.timer.Interval = 1000;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // metroProgressBar_Memory
      // 
      this.metroProgressBar_Memory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.metroProgressBar_Memory.Location = new System.Drawing.Point(478, 299);
      this.metroProgressBar_Memory.Name = "metroProgressBar_Memory";
      this.metroProgressBar_Memory.Size = new System.Drawing.Size(249, 34);
      this.metroProgressBar_Memory.TabIndex = 10;
      // 
      // metroProgressBar_CPU
      // 
      this.metroProgressBar_CPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.metroProgressBar_CPU.Location = new System.Drawing.Point(478, 377);
      this.metroProgressBar_CPU.Name = "metroProgressBar_CPU";
      this.metroProgressBar_CPU.Size = new System.Drawing.Size(246, 34);
      this.metroProgressBar_CPU.TabIndex = 11;
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(478, 354);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(36, 20);
      this.metroLabel1.TabIndex = 12;
      this.metroLabel1.Text = "CPU";
      // 
      // metroLabel2
      // 
      this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(478, 276);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(62, 20);
      this.metroLabel2.TabIndex = 13;
      this.metroLabel2.Text = "Memory";
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.Location = new System.Drawing.Point(3, 12);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(72, 20);
      this.metroLabel3.TabIndex = 14;
      this.metroLabel3.Text = "Enter Path";
      // 
      // Apps_LBL
      // 
      this.Apps_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Apps_LBL.AutoSize = true;
      this.Apps_LBL.Location = new System.Drawing.Point(639, 659);
      this.Apps_LBL.Name = "Apps_LBL";
      this.Apps_LBL.Size = new System.Drawing.Size(114, 20);
      this.Apps_LBL.TabIndex = 14;
      this.Apps_LBL.Text = "Running Apps : 0";
      // 
      // Start_PNL
      // 
      this.Start_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Start_PNL.Controls.Add(this.APP_Path_TXT);
      this.Start_PNL.Controls.Add(this.metroLabel3);
      this.Start_PNL.HorizontalScrollbarBarColor = true;
      this.Start_PNL.HorizontalScrollbarHighlightOnWheel = false;
      this.Start_PNL.HorizontalScrollbarSize = 10;
      this.Start_PNL.Location = new System.Drawing.Point(478, 153);
      this.Start_PNL.Name = "Start_PNL";
      this.Start_PNL.Size = new System.Drawing.Size(284, 74);
      this.Start_PNL.TabIndex = 15;
      this.Start_PNL.VerticalScrollbarBarColor = true;
      this.Start_PNL.VerticalScrollbarHighlightOnWheel = false;
      this.Start_PNL.VerticalScrollbarSize = 10;
      // 
      // APP_Path_TXT
      // 
      // 
      // 
      // 
      this.APP_Path_TXT.CustomButton.Image = null;
      this.APP_Path_TXT.CustomButton.Location = new System.Drawing.Point(240, 1);
      this.APP_Path_TXT.CustomButton.Name = "";
      this.APP_Path_TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.APP_Path_TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.APP_Path_TXT.CustomButton.TabIndex = 1;
      this.APP_Path_TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.APP_Path_TXT.CustomButton.UseSelectable = true;
      this.APP_Path_TXT.CustomButton.Visible = false;
      this.APP_Path_TXT.Lines = new string[0];
      this.APP_Path_TXT.Location = new System.Drawing.Point(13, 35);
      this.APP_Path_TXT.MaxLength = 32767;
      this.APP_Path_TXT.Name = "APP_Path_TXT";
      this.APP_Path_TXT.PasswordChar = '\0';
      this.APP_Path_TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.APP_Path_TXT.SelectedText = "";
      this.APP_Path_TXT.SelectionLength = 0;
      this.APP_Path_TXT.SelectionStart = 0;
      this.APP_Path_TXT.ShortcutsEnabled = true;
      this.APP_Path_TXT.Size = new System.Drawing.Size(262, 23);
      this.APP_Path_TXT.TabIndex = 15;
      this.APP_Path_TXT.UseSelectable = true;
      this.APP_Path_TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.APP_Path_TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World);
      // 
      // Task_List
      // 
      this.Task_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Task_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Pname,
            this.memory});
      this.Task_List.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.Task_List.ForeColor = System.Drawing.Color.Beige;
      this.Task_List.FullRowSelect = true;
      this.Task_List.GridLines = true;
      this.Task_List.Location = new System.Drawing.Point(9, 153);
      this.Task_List.Name = "Task_List";
      this.Task_List.OwnerDraw = true;
      this.Task_List.Size = new System.Drawing.Size(443, 526);
      this.Task_List.TabIndex = 16;
      this.Task_List.UseCompatibleStateImageBehavior = false;
      this.Task_List.UseSelectable = true;
      this.Task_List.View = System.Windows.Forms.View.Details;
      this.Task_List.ItemAdded += new System.Action<MetroFramework.Controls.MetroListView>(this.Task_List_ItemAdded);
      this.Task_List.SelectedIndexChanged += new System.EventHandler(this.Task_List_SelectedIndexChanged);
      // 
      // ID
      // 
      this.ID.Text = "ID";
      this.ID.Width = 77;
      // 
      // Pname
      // 
      this.Pname.Text = "Program Name";
      this.Pname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Pname.Width = 184;
      // 
      // memory
      // 
      this.memory.Text = "Memory";
      this.memory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.memory.Width = 191;
      // 
      // Start_BTN
      // 
      this.Start_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Start_BTN.DisplayFocus = true;
      this.Start_BTN.FontSize = MetroFramework.MetroButtonSize.Tall;
      this.Start_BTN.FontWeight = MetroFramework.MetroButtonWeight.Regular;
      this.Start_BTN.Location = new System.Drawing.Point(627, 98);
      this.Start_BTN.Name = "Start_BTN";
      this.Start_BTN.Size = new System.Drawing.Size(135, 49);
      this.Start_BTN.TabIndex = 17;
      this.Start_BTN.Text = "Start";
      this.Start_BTN.UseSelectable = true;
      this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
      // 
      // Task_End
      // 
      this.Task_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Task_End.DisplayFocus = true;
      this.Task_End.FontSize = MetroFramework.MetroButtonSize.Tall;
      this.Task_End.FontWeight = MetroFramework.MetroButtonWeight.Regular;
      this.Task_End.Location = new System.Drawing.Point(478, 98);
      this.Task_End.Name = "Task_End";
      this.Task_End.Size = new System.Drawing.Size(135, 49);
      this.Task_End.TabIndex = 19;
      this.Task_End.Text = "Task End";
      this.Task_End.UseSelectable = true;
      this.Task_End.Click += new System.EventHandler(this.Task_End_Click);
      // 
      // memory_LBL
      // 
      this.memory_LBL.AutoSize = true;
      this.memory_LBL.Location = new System.Drawing.Point(735, 313);
      this.memory_LBL.Name = "memory_LBL";
      this.memory_LBL.Size = new System.Drawing.Size(33, 20);
      this.memory_LBL.TabIndex = 21;
      this.memory_LBL.Text = "% 0";
      // 
      // cpu_LBL
      // 
      this.cpu_LBL.AutoSize = true;
      this.cpu_LBL.Location = new System.Drawing.Point(735, 391);
      this.cpu_LBL.Name = "cpu_LBL";
      this.cpu_LBL.Size = new System.Drawing.Size(33, 20);
      this.cpu_LBL.TabIndex = 22;
      this.cpu_LBL.Text = "% 0";
      // 
      // chart1
      // 
      this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      chartArea3.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea3);
      legend3.Name = "Legend1";
      this.chart1.Legends.Add(legend3);
      this.chart1.Location = new System.Drawing.Point(458, 440);
      this.chart1.Name = "chart1";
      series5.ChartArea = "ChartArea1";
      series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series5.Legend = "Legend1";
      series5.Name = "CPU";
      series6.ChartArea = "ChartArea1";
      series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series6.Legend = "Legend1";
      series6.Name = "RAM";
      this.chart1.Series.Add(series5);
      this.chart1.Series.Add(series6);
      this.chart1.Size = new System.Drawing.Size(328, 199);
      this.chart1.TabIndex = 23;
      this.chart1.Text = "chart1";
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // x
      // 
      this.x.AutoSize = true;
      this.x.BackColor = System.Drawing.Color.White;
      this.x.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x.BackgroundImage")));
      this.x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.x.Cursor = System.Windows.Forms.Cursors.Hand;
      this.x.DisplayFocus = true;
      this.x.FontSize = MetroFramework.MetroButtonSize.Tall;
      this.x.FontWeight = MetroFramework.MetroButtonWeight.Regular;
      this.x.Location = new System.Drawing.Point(735, 18);
      this.x.Name = "x";
      this.x.Size = new System.Drawing.Size(34, 30);
      this.x.TabIndex = 20;
      this.x.UseCustomBackColor = true;
      this.x.UseCustomForeColor = true;
      this.x.UseSelectable = true;
      this.x.UseStyleColors = true;
      this.x.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
      // 
      // searchTxt
      // 
      this.searchTxt.Location = new System.Drawing.Point(77, 98);
      this.searchTxt.Multiline = true;
      this.searchTxt.Name = "searchTxt";
      this.searchTxt.Size = new System.Drawing.Size(187, 25);
      this.searchTxt.TabIndex = 25;
      this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 101);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 17);
      this.label1.TabIndex = 26;
      this.label1.Text = "Search : ";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(791, 690);
      this.ControlBox = false;
      this.Controls.Add(this.label1);
      this.Controls.Add(this.searchTxt);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.cpu_LBL);
      this.Controls.Add(this.memory_LBL);
      this.Controls.Add(this.x);
      this.Controls.Add(this.Task_End);
      this.Controls.Add(this.Start_BTN);
      this.Controls.Add(this.Task_List);
      this.Controls.Add(this.Start_PNL);
      this.Controls.Add(this.Apps_LBL);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.metroProgressBar_CPU);
      this.Controls.Add(this.metroProgressBar_Memory);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.MinimumSize = new System.Drawing.Size(753, 595);
      this.Name = "Form1";
      this.Text = "Task Manager";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
      this.Start_PNL.ResumeLayout(false);
      this.Start_PNL.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar_Memory;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar_CPU;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel Apps_LBL;
        private MetroFramework.Controls.MetroPanel Start_PNL;
        private MetroFramework.Controls.MetroListView Task_List;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Pname;
        private System.Windows.Forms.ColumnHeader memory;
        private MetroFramework.Controls.MetroTextBox APP_Path_TXT;
        private MetroFramework.Controls.MetroButton Start_BTN;
        private MetroFramework.Controls.MetroButton Task_End;
        private MetroFramework.Controls.MetroLabel memory_LBL;
        private MetroFramework.Controls.MetroLabel cpu_LBL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton x;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label1;
    }
}

