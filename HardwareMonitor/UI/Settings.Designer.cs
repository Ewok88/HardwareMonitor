namespace HardwareMonitor.UI
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_settings = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnl_main = new System.Windows.Forms.Panel();
            this.tb_direction = new System.Windows.Forms.TextBox();
            this.num_RAM = new System.Windows.Forms.NumericUpDown();
            this.num_space = new System.Windows.Forms.NumericUpDown();
            this.num_temp = new System.Windows.Forms.NumericUpDown();
            this.switch_RAM = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.switch_space = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.slide_RAM = new Bunifu.Framework.UI.BunifuSlider();
            this.slide_space = new Bunifu.Framework.UI.BunifuSlider();
            this.lb_MbRAM = new System.Windows.Forms.Label();
            this.slide_temp = new Bunifu.Framework.UI.BunifuSlider();
            this.lb_percRAM = new System.Windows.Forms.Label();
            this.lb_MbSpace = new System.Windows.Forms.Label();
            this.lb_percSpace = new System.Windows.Forms.Label();
            this.lb_folder = new System.Windows.Forms.Label();
            this.lb_RAM = new System.Windows.Forms.Label();
            this.lb_space = new System.Windows.Forms.Label();
            this.lb_temp = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_folder = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.fbd_save = new System.Windows.Forms.FolderBrowserDialog();
            this.pnl_top.SuspendLayout();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_space)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_temp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.lb_settings);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(490, 30);
            this.pnl_top.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(460, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 10;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_settings
            // 
            this.lb_settings.AutoSize = true;
            this.lb_settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_settings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_settings.Location = new System.Drawing.Point(0, 0);
            this.lb_settings.Name = "lb_settings";
            this.lb_settings.Size = new System.Drawing.Size(86, 24);
            this.lb_settings.TabIndex = 1;
            this.lb_settings.Text = "Settings";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnl_top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.tb_direction);
            this.pnl_main.Controls.Add(this.num_RAM);
            this.pnl_main.Controls.Add(this.num_space);
            this.pnl_main.Controls.Add(this.num_temp);
            this.pnl_main.Controls.Add(this.switch_RAM);
            this.pnl_main.Controls.Add(this.switch_space);
            this.pnl_main.Controls.Add(this.slide_RAM);
            this.pnl_main.Controls.Add(this.slide_space);
            this.pnl_main.Controls.Add(this.lb_MbRAM);
            this.pnl_main.Controls.Add(this.slide_temp);
            this.pnl_main.Controls.Add(this.lb_percRAM);
            this.pnl_main.Controls.Add(this.lb_MbSpace);
            this.pnl_main.Controls.Add(this.lb_percSpace);
            this.pnl_main.Controls.Add(this.lb_folder);
            this.pnl_main.Controls.Add(this.lb_RAM);
            this.pnl_main.Controls.Add(this.lb_space);
            this.pnl_main.Controls.Add(this.lb_temp);
            this.pnl_main.Controls.Add(this.btn_cancel);
            this.pnl_main.Controls.Add(this.btn_folder);
            this.pnl_main.Controls.Add(this.btn_OK);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 30);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(490, 264);
            this.pnl_main.TabIndex = 1;
            // 
            // tb_direction
            // 
            this.tb_direction.BackColor = System.Drawing.SystemColors.Control;
            this.tb_direction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_direction.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_direction.Location = new System.Drawing.Point(8, 229);
            this.tb_direction.Name = "tb_direction";
            this.tb_direction.Size = new System.Drawing.Size(350, 16);
            this.tb_direction.TabIndex = 11;
            // 
            // num_RAM
            // 
            this.num_RAM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num_RAM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_RAM.Location = new System.Drawing.Point(252, 130);
            this.num_RAM.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.num_RAM.Name = "num_RAM";
            this.num_RAM.Size = new System.Drawing.Size(105, 29);
            this.num_RAM.TabIndex = 10;
            this.num_RAM.ValueChanged += new System.EventHandler(this.num_RAM_ValueChanged);
            // 
            // num_space
            // 
            this.num_space.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num_space.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_space.Location = new System.Drawing.Point(216, 70);
            this.num_space.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_space.Name = "num_space";
            this.num_space.Size = new System.Drawing.Size(105, 29);
            this.num_space.TabIndex = 10;
            this.num_space.ValueChanged += new System.EventHandler(this.num_space_ValueChanged);
            // 
            // num_temp
            // 
            this.num_temp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num_temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_temp.Location = new System.Drawing.Point(231, 9);
            this.num_temp.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.num_temp.Name = "num_temp";
            this.num_temp.Size = new System.Drawing.Size(62, 29);
            this.num_temp.TabIndex = 10;
            this.num_temp.ValueChanged += new System.EventHandler(this.num_temp_ValueChanged);
            // 
            // switch_RAM
            // 
            this.switch_RAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.switch_RAM.BackColor = System.Drawing.Color.Transparent;
            this.switch_RAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switch_RAM.BackgroundImage")));
            this.switch_RAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switch_RAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch_RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switch_RAM.Location = new System.Drawing.Point(392, 130);
            this.switch_RAM.Margin = new System.Windows.Forms.Padding(6);
            this.switch_RAM.Name = "switch_RAM";
            this.switch_RAM.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.switch_RAM.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.switch_RAM.Size = new System.Drawing.Size(43, 25);
            this.switch_RAM.TabIndex = 9;
            this.switch_RAM.Value = true;
            this.switch_RAM.OnValueChange += new System.EventHandler(this.switch_RAM_OnValueChange);
            // 
            // switch_space
            // 
            this.switch_space.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.switch_space.BackColor = System.Drawing.Color.Transparent;
            this.switch_space.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switch_space.BackgroundImage")));
            this.switch_space.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switch_space.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch_space.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switch_space.Location = new System.Drawing.Point(390, 70);
            this.switch_space.Margin = new System.Windows.Forms.Padding(6);
            this.switch_space.Name = "switch_space";
            this.switch_space.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.switch_space.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.switch_space.Size = new System.Drawing.Size(43, 25);
            this.switch_space.TabIndex = 9;
            this.switch_space.Value = true;
            this.switch_space.OnValueChange += new System.EventHandler(this.switch_space_OnValueChange);
            // 
            // slide_RAM
            // 
            this.slide_RAM.BackColor = System.Drawing.Color.Transparent;
            this.slide_RAM.BackgroudColor = System.Drawing.Color.DarkGray;
            this.slide_RAM.BorderRadius = 0;
            this.slide_RAM.Font = new System.Drawing.Font("Century Gothic", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slide_RAM.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.slide_RAM.Location = new System.Drawing.Point(5, 164);
            this.slide_RAM.Margin = new System.Windows.Forms.Padding(6);
            this.slide_RAM.MaximumValue = 100;
            this.slide_RAM.Name = "slide_RAM";
            this.slide_RAM.Size = new System.Drawing.Size(400, 24);
            this.slide_RAM.TabIndex = 7;
            this.slide_RAM.Value = 0;
            this.slide_RAM.ValueChanged += new System.EventHandler(this.slide_RAM_ValueChanged);
            // 
            // slide_space
            // 
            this.slide_space.BackColor = System.Drawing.Color.Transparent;
            this.slide_space.BackgroudColor = System.Drawing.Color.DarkGray;
            this.slide_space.BorderRadius = 0;
            this.slide_space.Font = new System.Drawing.Font("Century Gothic", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slide_space.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.slide_space.Location = new System.Drawing.Point(5, 100);
            this.slide_space.Margin = new System.Windows.Forms.Padding(6);
            this.slide_space.MaximumValue = 100;
            this.slide_space.Name = "slide_space";
            this.slide_space.Size = new System.Drawing.Size(400, 24);
            this.slide_space.TabIndex = 7;
            this.slide_space.Value = 0;
            this.slide_space.ValueChanged += new System.EventHandler(this.slide_space_ValueChanged);
            // 
            // lb_MbRAM
            // 
            this.lb_MbRAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_MbRAM.AutoSize = true;
            this.lb_MbRAM.Location = new System.Drawing.Point(438, 130);
            this.lb_MbRAM.Name = "lb_MbRAM";
            this.lb_MbRAM.Size = new System.Drawing.Size(42, 24);
            this.lb_MbRAM.TabIndex = 6;
            this.lb_MbRAM.Text = "Gb";
            // 
            // slide_temp
            // 
            this.slide_temp.BackColor = System.Drawing.Color.Transparent;
            this.slide_temp.BackgroudColor = System.Drawing.Color.DarkGray;
            this.slide_temp.BorderRadius = 0;
            this.slide_temp.Font = new System.Drawing.Font("Century Gothic", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slide_temp.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.slide_temp.Location = new System.Drawing.Point(5, 40);
            this.slide_temp.Margin = new System.Windows.Forms.Padding(6);
            this.slide_temp.MaximumValue = 120;
            this.slide_temp.Name = "slide_temp";
            this.slide_temp.Size = new System.Drawing.Size(400, 24);
            this.slide_temp.TabIndex = 7;
            this.slide_temp.Value = 0;
            this.slide_temp.ValueChanged += new System.EventHandler(this.slide_temp_ValueChanged);
            // 
            // lb_percRAM
            // 
            this.lb_percRAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_percRAM.AutoSize = true;
            this.lb_percRAM.Location = new System.Drawing.Point(359, 130);
            this.lb_percRAM.Name = "lb_percRAM";
            this.lb_percRAM.Size = new System.Drawing.Size(26, 24);
            this.lb_percRAM.TabIndex = 6;
            this.lb_percRAM.Text = "%";
            // 
            // lb_MbSpace
            // 
            this.lb_MbSpace.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_MbSpace.AutoSize = true;
            this.lb_MbSpace.Location = new System.Drawing.Point(441, 70);
            this.lb_MbSpace.Name = "lb_MbSpace";
            this.lb_MbSpace.Size = new System.Drawing.Size(42, 24);
            this.lb_MbSpace.TabIndex = 6;
            this.lb_MbSpace.Text = "Gb";
            // 
            // lb_percSpace
            // 
            this.lb_percSpace.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_percSpace.AutoSize = true;
            this.lb_percSpace.Location = new System.Drawing.Point(361, 70);
            this.lb_percSpace.Name = "lb_percSpace";
            this.lb_percSpace.Size = new System.Drawing.Size(26, 24);
            this.lb_percSpace.TabIndex = 6;
            this.lb_percSpace.Text = "%";
            // 
            // lb_folder
            // 
            this.lb_folder.AutoSize = true;
            this.lb_folder.Location = new System.Drawing.Point(4, 194);
            this.lb_folder.Name = "lb_folder";
            this.lb_folder.Size = new System.Drawing.Size(198, 24);
            this.lb_folder.TabIndex = 5;
            this.lb_folder.Text = "Log save location:";
            // 
            // lb_RAM
            // 
            this.lb_RAM.AutoSize = true;
            this.lb_RAM.Location = new System.Drawing.Point(0, 130);
            this.lb_RAM.Name = "lb_RAM";
            this.lb_RAM.Size = new System.Drawing.Size(252, 24);
            this.lb_RAM.TabIndex = 5;
            this.lb_RAM.Text = "Critical amount of RAM:";
            // 
            // lb_space
            // 
            this.lb_space.AutoSize = true;
            this.lb_space.Location = new System.Drawing.Point(4, 70);
            this.lb_space.Name = "lb_space";
            this.lb_space.Size = new System.Drawing.Size(206, 24);
            this.lb_space.TabIndex = 5;
            this.lb_space.Text = "Critical Free Space:";
            // 
            // lb_temp
            // 
            this.lb_temp.AutoSize = true;
            this.lb_temp.Location = new System.Drawing.Point(4, 10);
            this.lb_temp.Name = "lb_temp";
            this.lb_temp.Size = new System.Drawing.Size(221, 24);
            this.lb_temp.TabIndex = 5;
            this.lb_temp.Text = "Critical Temperature:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_cancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.Location = new System.Drawing.Point(413, 224);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 30);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_folder
            // 
            this.btn_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.btn_folder.FlatAppearance.BorderSize = 0;
            this.btn_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_folder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_folder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_folder.Image = ((System.Drawing.Image)(resources.GetObject("btn_folder.Image")));
            this.btn_folder.Location = new System.Drawing.Point(203, 189);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(35, 35);
            this.btn_folder.TabIndex = 3;
            this.btn_folder.UseVisualStyleBackColor = false;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_OK.Location = new System.Drawing.Point(367, 224);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(40, 30);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(490, 294);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_space)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_temp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lb_settings;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lb_temp;
        private Bunifu.Framework.UI.BunifuSlider slide_temp;
        private System.Windows.Forms.Label lb_MbSpace;
        private System.Windows.Forms.Label lb_percSpace;
        private System.Windows.Forms.Label lb_RAM;
        private System.Windows.Forms.Label lb_space;
        private Bunifu.Framework.UI.BunifuiOSSwitch switch_space;
        private System.Windows.Forms.Button btn_close;
        private Bunifu.Framework.UI.BunifuSlider slide_space;
        private Bunifu.Framework.UI.BunifuiOSSwitch switch_RAM;
        private Bunifu.Framework.UI.BunifuSlider slide_RAM;
        private System.Windows.Forms.Label lb_MbRAM;
        private System.Windows.Forms.Label lb_percRAM;
        private System.Windows.Forms.NumericUpDown num_RAM;
        private System.Windows.Forms.NumericUpDown num_space;
        private System.Windows.Forms.NumericUpDown num_temp;
        private System.Windows.Forms.Label lb_folder;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.FolderBrowserDialog fbd_save;
        private System.Windows.Forms.TextBox tb_direction;
    }
}