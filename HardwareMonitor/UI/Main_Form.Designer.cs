namespace HardwareMonitor
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.btn_system = new System.Windows.Forms.Button();
            this.btn_accelerator = new System.Windows.Forms.Button();
            this.icn_tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.icn_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lb_hor_line = new System.Windows.Forms.Label();
            this.bt_overlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.btn_ph_mem = new System.Windows.Forms.Button();
            this.btn_gpu = new System.Windows.Forms.Button();
            this.btn_processor = new System.Windows.Forms.Button();
            this.btn_motherboard = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.uc_video_controller1 = new HardwareMonitor.UI.uc_video_controller();
            this.uc_motherboard1 = new HardwareMonitor.UI.uc_motherboard();
            this.uc_system1 = new HardwareMonitor.UI.uc_system();
            this.uc_processor2 = new HardwareMonitor.UI.uc_processor();
            this.uc_accelerator1 = new HardwareMonitor.UI.uc_accelerator();
            this.uc_physicalMemory1 = new HardwareMonitor.UI.uc_physicalMemory();
            this.icn_menu.SuspendLayout();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_system
            // 
            this.btn_system.FlatAppearance.BorderSize = 0;
            this.btn_system.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_system.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_system.Image = ((System.Drawing.Image)(resources.GetObject("btn_system.Image")));
            this.btn_system.Location = new System.Drawing.Point(5, 50);
            this.btn_system.Name = "btn_system";
            this.btn_system.Size = new System.Drawing.Size(45, 45);
            this.btn_system.TabIndex = 3;
            this.btn_system.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_system.UseVisualStyleBackColor = true;
            this.btn_system.Click += new System.EventHandler(this.btn_system_Click);
            // 
            // btn_accelerator
            // 
            this.btn_accelerator.FlatAppearance.BorderSize = 0;
            this.btn_accelerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accelerator.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_accelerator.Image = ((System.Drawing.Image)(resources.GetObject("btn_accelerator.Image")));
            this.btn_accelerator.Location = new System.Drawing.Point(5, 0);
            this.btn_accelerator.Name = "btn_accelerator";
            this.btn_accelerator.Size = new System.Drawing.Size(45, 45);
            this.btn_accelerator.TabIndex = 1;
            this.btn_accelerator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_accelerator.UseVisualStyleBackColor = true;
            this.btn_accelerator.Click += new System.EventHandler(this.btn_accelerator_Click);
            // 
            // icn_tray
            // 
            this.icn_tray.ContextMenuStrip = this.icn_menu;
            this.icn_tray.Icon = ((System.Drawing.Icon)(resources.GetObject("icn_tray.Icon")));
            this.icn_tray.Text = "notifyIcon1";
            this.icn_tray.Visible = true;
            this.icn_tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icn_tray_MouseDoubleClick);
            // 
            // icn_menu
            // 
            this.icn_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.icn_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.icn_menu.Name = "icn_menu";
            this.icn_menu.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pnl_right
            // 
            this.pnl_right.BackColor = System.Drawing.Color.Firebrick;
            this.pnl_right.Location = new System.Drawing.Point(0, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(5, 50);
            this.pnl_right.TabIndex = 2;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.pnl_header.Controls.Add(this.lb_hor_line);
            this.pnl_header.Controls.Add(this.bt_overlay);
            this.pnl_header.Controls.Add(this.pictureBox1);
            this.pnl_header.Controls.Add(this.btn_minimize);
            this.pnl_header.Controls.Add(this.btn_close);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(800, 40);
            this.pnl_header.TabIndex = 4;
            // 
            // lb_hor_line
            // 
            this.lb_hor_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_hor_line.Location = new System.Drawing.Point(715, 5);
            this.lb_hor_line.Name = "lb_hor_line";
            this.lb_hor_line.Size = new System.Drawing.Size(1, 30);
            this.lb_hor_line.TabIndex = 6;
            // 
            // bt_overlay
            // 
            this.bt_overlay.FlatAppearance.BorderSize = 0;
            this.bt_overlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_overlay.ForeColor = System.Drawing.Color.FloralWhite;
            this.bt_overlay.Image = ((System.Drawing.Image)(resources.GetObject("bt_overlay.Image")));
            this.bt_overlay.Location = new System.Drawing.Point(675, 2);
            this.bt_overlay.Name = "bt_overlay";
            this.bt_overlay.Size = new System.Drawing.Size(35, 35);
            this.bt_overlay.TabIndex = 3;
            this.bt_overlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_overlay.UseVisualStyleBackColor = true;
            this.bt_overlay.Click += new System.EventHandler(this.bt_overlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_minimize
            // 
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(720, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(35, 35);
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(760, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 3;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.pnl_left.Controls.Add(this.pnl_right);
            this.pnl_left.Controls.Add(this.btn_accelerator);
            this.pnl_left.Controls.Add(this.btn_ph_mem);
            this.pnl_left.Controls.Add(this.btn_gpu);
            this.pnl_left.Controls.Add(this.btn_processor);
            this.pnl_left.Controls.Add(this.btn_motherboard);
            this.pnl_left.Controls.Add(this.btn_system);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 40);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(52, 660);
            this.pnl_left.TabIndex = 5;
            // 
            // btn_ph_mem
            // 
            this.btn_ph_mem.FlatAppearance.BorderSize = 0;
            this.btn_ph_mem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ph_mem.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_ph_mem.Image = ((System.Drawing.Image)(resources.GetObject("btn_ph_mem.Image")));
            this.btn_ph_mem.Location = new System.Drawing.Point(5, 250);
            this.btn_ph_mem.Name = "btn_ph_mem";
            this.btn_ph_mem.Size = new System.Drawing.Size(45, 45);
            this.btn_ph_mem.TabIndex = 3;
            this.btn_ph_mem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ph_mem.UseVisualStyleBackColor = true;
            this.btn_ph_mem.Click += new System.EventHandler(this.btn_ph_mem_Click);
            // 
            // btn_gpu
            // 
            this.btn_gpu.FlatAppearance.BorderSize = 0;
            this.btn_gpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gpu.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_gpu.Image = ((System.Drawing.Image)(resources.GetObject("btn_gpu.Image")));
            this.btn_gpu.Location = new System.Drawing.Point(5, 200);
            this.btn_gpu.Name = "btn_gpu";
            this.btn_gpu.Size = new System.Drawing.Size(45, 45);
            this.btn_gpu.TabIndex = 3;
            this.btn_gpu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gpu.UseVisualStyleBackColor = true;
            this.btn_gpu.Click += new System.EventHandler(this.btn_gpu_Click);
            // 
            // btn_processor
            // 
            this.btn_processor.FlatAppearance.BorderSize = 0;
            this.btn_processor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_processor.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_processor.Image = ((System.Drawing.Image)(resources.GetObject("btn_processor.Image")));
            this.btn_processor.Location = new System.Drawing.Point(5, 150);
            this.btn_processor.Name = "btn_processor";
            this.btn_processor.Size = new System.Drawing.Size(45, 45);
            this.btn_processor.TabIndex = 3;
            this.btn_processor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_processor.UseVisualStyleBackColor = true;
            this.btn_processor.Click += new System.EventHandler(this.btn_processor_Click);
            // 
            // btn_motherboard
            // 
            this.btn_motherboard.FlatAppearance.BorderSize = 0;
            this.btn_motherboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_motherboard.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_motherboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_motherboard.Image")));
            this.btn_motherboard.Location = new System.Drawing.Point(5, 100);
            this.btn_motherboard.Name = "btn_motherboard";
            this.btn_motherboard.Size = new System.Drawing.Size(45, 45);
            this.btn_motherboard.TabIndex = 3;
            this.btn_motherboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_motherboard.UseVisualStyleBackColor = true;
            this.btn_motherboard.Click += new System.EventHandler(this.btn_motherboard_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnl_header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // uc_video_controller1
            // 
            this.uc_video_controller1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_video_controller1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uc_video_controller1.Location = new System.Drawing.Point(52, 40);
            this.uc_video_controller1.Name = "uc_video_controller1";
            this.uc_video_controller1.Size = new System.Drawing.Size(748, 660);
            this.uc_video_controller1.TabIndex = 10;
            // 
            // uc_motherboard1
            // 
            this.uc_motherboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_motherboard1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uc_motherboard1.Location = new System.Drawing.Point(52, 40);
            this.uc_motherboard1.Name = "uc_motherboard1";
            this.uc_motherboard1.Size = new System.Drawing.Size(748, 660);
            this.uc_motherboard1.TabIndex = 9;
            // 
            // uc_system1
            // 
            this.uc_system1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_system1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uc_system1.Location = new System.Drawing.Point(52, 40);
            this.uc_system1.Margin = new System.Windows.Forms.Padding(8);
            this.uc_system1.Name = "uc_system1";
            this.uc_system1.Size = new System.Drawing.Size(748, 660);
            this.uc_system1.TabIndex = 8;
            // 
            // uc_processor2
            // 
            this.uc_processor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_processor2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uc_processor2.Location = new System.Drawing.Point(52, 40);
            this.uc_processor2.Margin = new System.Windows.Forms.Padding(8);
            this.uc_processor2.Name = "uc_processor2";
            this.uc_processor2.Size = new System.Drawing.Size(748, 660);
            this.uc_processor2.TabIndex = 7;
            // 
            // uc_accelerator1
            // 
            this.uc_accelerator1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uc_accelerator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_accelerator1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uc_accelerator1.Location = new System.Drawing.Point(0, 0);
            this.uc_accelerator1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.uc_accelerator1.Name = "uc_accelerator1";
            this.uc_accelerator1.Size = new System.Drawing.Size(800, 700);
            this.uc_accelerator1.TabIndex = 6;
            // 
            // uc_physicalMemory1
            // 
            this.uc_physicalMemory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_physicalMemory1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uc_physicalMemory1.Location = new System.Drawing.Point(52, 40);
            this.uc_physicalMemory1.Name = "uc_physicalMemory1";
            this.uc_physicalMemory1.Size = new System.Drawing.Size(748, 660);
            this.uc_physicalMemory1.TabIndex = 11;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.uc_physicalMemory1);
            this.Controls.Add(this.uc_video_controller1);
            this.Controls.Add(this.uc_motherboard1);
            this.Controls.Add(this.uc_system1);
            this.Controls.Add(this.uc_processor2);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.uc_accelerator1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware Monitor";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Resize += new System.EventHandler(this.Main_Form_Resize);
            this.icn_menu.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_accelerator;
        private System.Windows.Forms.NotifyIcon icn_tray;
        private System.Windows.Forms.ContextMenuStrip icn_menu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Button btn_system;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_processor;
        private System.Windows.Forms.Button btn_motherboard;
        private System.Windows.Forms.Button btn_gpu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button bt_overlay;
        private System.Windows.Forms.Label lb_hor_line;
        private UI.uc_accelerator uc_accelerator1;
        private UI.uc_processor uc_processor2;
        private UI.uc_system uc_system1;
        private UI.uc_motherboard uc_motherboard1;
        private UI.uc_video_controller uc_video_controller1;
        private System.Windows.Forms.Button btn_ph_mem;
        private UI.uc_physicalMemory uc_physicalMemory1;
    }
}

