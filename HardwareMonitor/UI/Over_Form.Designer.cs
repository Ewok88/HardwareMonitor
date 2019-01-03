namespace HardwareMonitor
{
    partial class Over_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.prbar_RAM = new Bunifu.Framework.UI.BunifuProgressBar();
            this.overlay_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prbar_CPU = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.overlay_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.prbar_RAM);
            this.panel1.Controls.Add(this.prbar_CPU);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 60);
            this.panel1.TabIndex = 0;
            // 
            // prbar_RAM
            // 
            this.prbar_RAM.BackColor = System.Drawing.Color.Silver;
            this.prbar_RAM.BorderRadius = 5;
            this.prbar_RAM.ContextMenuStrip = this.overlay_menu;
            this.prbar_RAM.Location = new System.Drawing.Point(0, 22);
            this.prbar_RAM.MaximumValue = 7000;
            this.prbar_RAM.Name = "prbar_RAM";
            this.prbar_RAM.ProgressColor = System.Drawing.Color.DarkGreen;
            this.prbar_RAM.Size = new System.Drawing.Size(100, 15);
            this.prbar_RAM.TabIndex = 0;
            this.prbar_RAM.Value = 50;
            // 
            // overlay_menu
            // 
            this.overlay_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.overlay_menu.Name = "overlay_menu";
            this.overlay_menu.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // prbar_CPU
            // 
            this.prbar_CPU.BackColor = System.Drawing.Color.Silver;
            this.prbar_CPU.BorderRadius = 5;
            this.prbar_CPU.ContextMenuStrip = this.overlay_menu;
            this.prbar_CPU.Location = new System.Drawing.Point(0, 0);
            this.prbar_CPU.MaximumValue = 100;
            this.prbar_CPU.Name = "prbar_CPU";
            this.prbar_CPU.ProgressColor = System.Drawing.SystemColors.HotTrack;
            this.prbar_CPU.Size = new System.Drawing.Size(100, 15);
            this.prbar_CPU.TabIndex = 0;
            this.prbar_CPU.Value = 40;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.prbar_CPU;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.prbar_RAM;
            this.bunifuDragControl2.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Over_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 60);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Over_Form";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Over_Form";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.panel1.ResumeLayout(false);
            this.overlay_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuProgressBar prbar_CPU;
        private Bunifu.Framework.UI.BunifuProgressBar prbar_RAM;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip overlay_menu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}