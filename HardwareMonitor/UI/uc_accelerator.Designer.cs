namespace HardwareMonitor.UI
{
    partial class uc_accelerator
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_accelerator));
            this.lb_CPU = new System.Windows.Forms.Label();
            this.lb_hor_line = new System.Windows.Forms.Label();
            this.prbar_cpu_load = new CircularProgressBar.CircularProgressBar();
            this.lb_cpu_load = new System.Windows.Forms.Label();
            this.prbar_temperature = new CircularProgressBar.CircularProgressBar();
            this.lb_cpu_temperature = new System.Windows.Forms.Label();
            this.lb_RAM = new System.Windows.Forms.Label();
            this.lb_proc_name = new System.Windows.Forms.Label();
            this.prbar_ram_used = new CircularProgressBar.CircularProgressBar();
            this.lb_storage = new System.Windows.Forms.Label();
            this.timer_uc_acc = new System.Windows.Forms.Timer(this.components);
            this.lb_RAM_use = new System.Windows.Forms.Label();
            this.lb_space_freeValue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.prbar_usedSpace_total = new CircularProgressBar.CircularProgressBar();
            this.prbar_freeSpace_total = new CircularProgressBar.CircularProgressBar();
            this.lb_space_usedValue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_space_free = new System.Windows.Forms.Label();
            this.lb_space_used = new System.Windows.Forms.Label();
            this.tab_storage = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chart = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.tab_storage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_CPU
            // 
            this.lb_CPU.AutoSize = true;
            this.lb_CPU.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_CPU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_CPU.Location = new System.Drawing.Point(30, 30);
            this.lb_CPU.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CPU.Name = "lb_CPU";
            this.lb_CPU.Size = new System.Drawing.Size(145, 33);
            this.lb_CPU.TabIndex = 0;
            this.lb_CPU.Text = "Processor:";
            // 
            // lb_hor_line
            // 
            this.lb_hor_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_hor_line.Location = new System.Drawing.Point(0, 250);
            this.lb_hor_line.Name = "lb_hor_line";
            this.lb_hor_line.Size = new System.Drawing.Size(748, 2);
            this.lb_hor_line.TabIndex = 1;
            // 
            // prbar_cpu_load
            // 
            this.prbar_cpu_load.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.prbar_cpu_load.AnimationSpeed = 1000;
            this.prbar_cpu_load.BackColor = System.Drawing.Color.Transparent;
            this.prbar_cpu_load.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prbar_cpu_load.ForeColor = System.Drawing.Color.Black;
            this.prbar_cpu_load.InnerColor = System.Drawing.SystemColors.Control;
            this.prbar_cpu_load.InnerMargin = 0;
            this.prbar_cpu_load.InnerWidth = 0;
            this.prbar_cpu_load.Location = new System.Drawing.Point(35, 80);
            this.prbar_cpu_load.Margin = new System.Windows.Forms.Padding(5);
            this.prbar_cpu_load.MarqueeAnimationSpeed = 2000;
            this.prbar_cpu_load.Name = "prbar_cpu_load";
            this.prbar_cpu_load.OuterColor = System.Drawing.Color.Gainsboro;
            this.prbar_cpu_load.OuterMargin = -5;
            this.prbar_cpu_load.OuterWidth = 5;
            this.prbar_cpu_load.ProgressColor = System.Drawing.Color.SteelBlue;
            this.prbar_cpu_load.ProgressWidth = 8;
            this.prbar_cpu_load.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prbar_cpu_load.Size = new System.Drawing.Size(125, 125);
            this.prbar_cpu_load.StartAngle = 270;
            this.prbar_cpu_load.Step = 1;
            this.prbar_cpu_load.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbar_cpu_load.SubscriptColor = System.Drawing.Color.Gray;
            this.prbar_cpu_load.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.prbar_cpu_load.SubscriptText = "";
            this.prbar_cpu_load.SuperscriptColor = System.Drawing.Color.Gray;
            this.prbar_cpu_load.SuperscriptMargin = new System.Windows.Forms.Padding(8, 28, 0, 0);
            this.prbar_cpu_load.SuperscriptText = "%";
            this.prbar_cpu_load.TabIndex = 3;
            this.prbar_cpu_load.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.prbar_cpu_load.Value = 100;
            // 
            // lb_cpu_load
            // 
            this.lb_cpu_load.AutoSize = true;
            this.lb_cpu_load.Location = new System.Drawing.Point(65, 210);
            this.lb_cpu_load.Name = "lb_cpu_load";
            this.lb_cpu_load.Size = new System.Drawing.Size(57, 22);
            this.lb_cpu_load.TabIndex = 4;
            this.lb_cpu_load.Text = "Load";
            // 
            // prbar_temperature
            // 
            this.prbar_temperature.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.prbar_temperature.AnimationSpeed = 500;
            this.prbar_temperature.BackColor = System.Drawing.Color.Transparent;
            this.prbar_temperature.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prbar_temperature.ForeColor = System.Drawing.Color.Black;
            this.prbar_temperature.InnerColor = System.Drawing.SystemColors.Control;
            this.prbar_temperature.InnerMargin = 0;
            this.prbar_temperature.InnerWidth = 0;
            this.prbar_temperature.Location = new System.Drawing.Point(220, 80);
            this.prbar_temperature.Margin = new System.Windows.Forms.Padding(5);
            this.prbar_temperature.MarqueeAnimationSpeed = 2000;
            this.prbar_temperature.Maximum = 120;
            this.prbar_temperature.Name = "prbar_temperature";
            this.prbar_temperature.OuterColor = System.Drawing.Color.Gainsboro;
            this.prbar_temperature.OuterMargin = -5;
            this.prbar_temperature.OuterWidth = 5;
            this.prbar_temperature.ProgressColor = System.Drawing.Color.SteelBlue;
            this.prbar_temperature.ProgressWidth = 8;
            this.prbar_temperature.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prbar_temperature.Size = new System.Drawing.Size(125, 125);
            this.prbar_temperature.StartAngle = 270;
            this.prbar_temperature.SubscriptColor = System.Drawing.Color.Gray;
            this.prbar_temperature.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.prbar_temperature.SubscriptText = "";
            this.prbar_temperature.SuperscriptColor = System.Drawing.Color.Gray;
            this.prbar_temperature.SuperscriptMargin = new System.Windows.Forms.Padding(8, 28, 0, 0);
            this.prbar_temperature.SuperscriptText = "C";
            this.prbar_temperature.TabIndex = 3;
            this.prbar_temperature.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.prbar_temperature.Value = 120;
            // 
            // lb_cpu_temperature
            // 
            this.lb_cpu_temperature.AutoSize = true;
            this.lb_cpu_temperature.Location = new System.Drawing.Point(217, 210);
            this.lb_cpu_temperature.Name = "lb_cpu_temperature";
            this.lb_cpu_temperature.Size = new System.Drawing.Size(128, 22);
            this.lb_cpu_temperature.TabIndex = 4;
            this.lb_cpu_temperature.Text = "Temperature";
            // 
            // lb_RAM
            // 
            this.lb_RAM.AutoSize = true;
            this.lb_RAM.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_RAM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_RAM.Location = new System.Drawing.Point(393, 30);
            this.lb_RAM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_RAM.Name = "lb_RAM";
            this.lb_RAM.Size = new System.Drawing.Size(82, 33);
            this.lb_RAM.TabIndex = 0;
            this.lb_RAM.Text = "RAM:";
            // 
            // lb_proc_name
            // 
            this.lb_proc_name.AutoSize = true;
            this.lb_proc_name.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_proc_name.Location = new System.Drawing.Point(165, 30);
            this.lb_proc_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_proc_name.Name = "lb_proc_name";
            this.lb_proc_name.Size = new System.Drawing.Size(0, 33);
            this.lb_proc_name.TabIndex = 0;
            // 
            // prbar_ram_used
            // 
            this.prbar_ram_used.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.prbar_ram_used.AnimationSpeed = 500;
            this.prbar_ram_used.BackColor = System.Drawing.Color.Transparent;
            this.prbar_ram_used.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prbar_ram_used.ForeColor = System.Drawing.Color.Black;
            this.prbar_ram_used.InnerColor = System.Drawing.SystemColors.Control;
            this.prbar_ram_used.InnerMargin = 0;
            this.prbar_ram_used.InnerWidth = 0;
            this.prbar_ram_used.Location = new System.Drawing.Point(399, 80);
            this.prbar_ram_used.Margin = new System.Windows.Forms.Padding(5);
            this.prbar_ram_used.MarqueeAnimationSpeed = 2000;
            this.prbar_ram_used.Maximum = 0;
            this.prbar_ram_used.Name = "prbar_ram_used";
            this.prbar_ram_used.OuterColor = System.Drawing.Color.Gainsboro;
            this.prbar_ram_used.OuterMargin = -5;
            this.prbar_ram_used.OuterWidth = 5;
            this.prbar_ram_used.ProgressColor = System.Drawing.Color.SteelBlue;
            this.prbar_ram_used.ProgressWidth = 8;
            this.prbar_ram_used.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prbar_ram_used.Size = new System.Drawing.Size(125, 125);
            this.prbar_ram_used.StartAngle = 270;
            this.prbar_ram_used.SubscriptColor = System.Drawing.Color.Gray;
            this.prbar_ram_used.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.prbar_ram_used.SubscriptText = "";
            this.prbar_ram_used.SuperscriptColor = System.Drawing.Color.Gray;
            this.prbar_ram_used.SuperscriptMargin = new System.Windows.Forms.Padding(8, 28, 0, 0);
            this.prbar_ram_used.SuperscriptText = "Mb";
            this.prbar_ram_used.TabIndex = 3;
            this.prbar_ram_used.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // lb_storage
            // 
            this.lb_storage.AutoSize = true;
            this.lb_storage.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_storage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_storage.Location = new System.Drawing.Point(30, 263);
            this.lb_storage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_storage.Name = "lb_storage";
            this.lb_storage.Size = new System.Drawing.Size(125, 33);
            this.lb_storage.TabIndex = 0;
            this.lb_storage.Text = "Storage:";
            // 
            // timer_uc_acc
            // 
            this.timer_uc_acc.Enabled = true;
            this.timer_uc_acc.Interval = 1000;
            this.timer_uc_acc.Tick += new System.EventHandler(this.timer_uc_acc_Tick);
            // 
            // lb_RAM_use
            // 
            this.lb_RAM_use.AutoSize = true;
            this.lb_RAM_use.Location = new System.Drawing.Point(428, 210);
            this.lb_RAM_use.Name = "lb_RAM_use";
            this.lb_RAM_use.Size = new System.Drawing.Size(63, 22);
            this.lb_RAM_use.TabIndex = 4;
            this.lb_RAM_use.Text = "In use";
            // 
            // lb_space_freeValue
            // 
            this.lb_space_freeValue.AutoSize = true;
            this.lb_space_freeValue.BackColor = System.Drawing.Color.Transparent;
            this.lb_space_freeValue.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_space_freeValue.ForeColor = System.Drawing.Color.Gray;
            this.lb_space_freeValue.Location = new System.Drawing.Point(220, 155);
            this.lb_space_freeValue.Name = "lb_space_freeValue";
            this.lb_space_freeValue.Size = new System.Drawing.Size(31, 36);
            this.lb_space_freeValue.TabIndex = 7;
            this.lb_space_freeValue.Text = "0";
            this.lb_space_freeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.prbar_usedSpace_total);
            this.tabPage1.Controls.Add(this.prbar_freeSpace_total);
            this.tabPage1.Controls.Add(this.lb_space_usedValue);
            this.tabPage1.Controls.Add(this.lb_space_freeValue);
            this.tabPage1.Controls.Add(this.lb_space_free);
            this.tabPage1.Controls.Add(this.lb_space_used);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(700, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Total";
            // 
            // prbar_usedSpace_total
            // 
            this.prbar_usedSpace_total.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.prbar_usedSpace_total.AnimationSpeed = 500;
            this.prbar_usedSpace_total.BackColor = System.Drawing.Color.Transparent;
            this.prbar_usedSpace_total.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prbar_usedSpace_total.ForeColor = System.Drawing.Color.Black;
            this.prbar_usedSpace_total.InnerColor = System.Drawing.SystemColors.Control;
            this.prbar_usedSpace_total.InnerMargin = 0;
            this.prbar_usedSpace_total.InnerWidth = 0;
            this.prbar_usedSpace_total.Location = new System.Drawing.Point(5, 25);
            this.prbar_usedSpace_total.Margin = new System.Windows.Forms.Padding(5);
            this.prbar_usedSpace_total.MarqueeAnimationSpeed = 2000;
            this.prbar_usedSpace_total.Name = "prbar_usedSpace_total";
            this.prbar_usedSpace_total.OuterColor = System.Drawing.Color.Gainsboro;
            this.prbar_usedSpace_total.OuterMargin = -30;
            this.prbar_usedSpace_total.OuterWidth = 30;
            this.prbar_usedSpace_total.ProgressColor = System.Drawing.Color.SteelBlue;
            this.prbar_usedSpace_total.ProgressWidth = 30;
            this.prbar_usedSpace_total.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prbar_usedSpace_total.Size = new System.Drawing.Size(125, 125);
            this.prbar_usedSpace_total.StartAngle = 270;
            this.prbar_usedSpace_total.SubscriptColor = System.Drawing.Color.Gray;
            this.prbar_usedSpace_total.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.prbar_usedSpace_total.SubscriptText = "";
            this.prbar_usedSpace_total.SuperscriptColor = System.Drawing.Color.Gray;
            this.prbar_usedSpace_total.SuperscriptMargin = new System.Windows.Forms.Padding(8, 28, 0, 0);
            this.prbar_usedSpace_total.SuperscriptText = "Mb";
            this.prbar_usedSpace_total.TabIndex = 3;
            this.prbar_usedSpace_total.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.prbar_usedSpace_total.Value = 25;
            // 
            // prbar_freeSpace_total
            // 
            this.prbar_freeSpace_total.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.prbar_freeSpace_total.AnimationSpeed = 500;
            this.prbar_freeSpace_total.BackColor = System.Drawing.Color.Transparent;
            this.prbar_freeSpace_total.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prbar_freeSpace_total.ForeColor = System.Drawing.Color.Black;
            this.prbar_freeSpace_total.InnerColor = System.Drawing.SystemColors.Control;
            this.prbar_freeSpace_total.InnerMargin = 0;
            this.prbar_freeSpace_total.InnerWidth = 0;
            this.prbar_freeSpace_total.Location = new System.Drawing.Point(220, 25);
            this.prbar_freeSpace_total.Margin = new System.Windows.Forms.Padding(5);
            this.prbar_freeSpace_total.MarqueeAnimationSpeed = 2000;
            this.prbar_freeSpace_total.Name = "prbar_freeSpace_total";
            this.prbar_freeSpace_total.OuterColor = System.Drawing.Color.Gainsboro;
            this.prbar_freeSpace_total.OuterMargin = -30;
            this.prbar_freeSpace_total.OuterWidth = 30;
            this.prbar_freeSpace_total.ProgressColor = System.Drawing.Color.SteelBlue;
            this.prbar_freeSpace_total.ProgressWidth = 30;
            this.prbar_freeSpace_total.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prbar_freeSpace_total.Size = new System.Drawing.Size(125, 125);
            this.prbar_freeSpace_total.StartAngle = 270;
            this.prbar_freeSpace_total.SubscriptColor = System.Drawing.Color.Gray;
            this.prbar_freeSpace_total.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.prbar_freeSpace_total.SubscriptText = "";
            this.prbar_freeSpace_total.SuperscriptColor = System.Drawing.Color.Gray;
            this.prbar_freeSpace_total.SuperscriptMargin = new System.Windows.Forms.Padding(8, 28, 0, 0);
            this.prbar_freeSpace_total.SuperscriptText = "Mb";
            this.prbar_freeSpace_total.TabIndex = 3;
            this.prbar_freeSpace_total.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.prbar_freeSpace_total.Value = 25;
            // 
            // lb_space_usedValue
            // 
            this.lb_space_usedValue.AutoSize = true;
            this.lb_space_usedValue.BackColor = System.Drawing.Color.Transparent;
            this.lb_space_usedValue.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_space_usedValue.ForeColor = System.Drawing.Color.Gray;
            this.lb_space_usedValue.Location = new System.Drawing.Point(5, 155);
            this.lb_space_usedValue.Name = "lb_space_usedValue";
            this.lb_space_usedValue.Size = new System.Drawing.Size(31, 36);
            this.lb_space_usedValue.TabIndex = 7;
            this.lb_space_usedValue.Text = "0";
            this.lb_space_usedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_space_free
            // 
            this.lb_space_free.AutoSize = true;
            this.lb_space_free.Location = new System.Drawing.Point(215, 5);
            this.lb_space_free.Name = "lb_space_free";
            this.lb_space_free.Size = new System.Drawing.Size(54, 22);
            this.lb_space_free.TabIndex = 9;
            this.lb_space_free.Text = "Free:";
            // 
            // lb_space_used
            // 
            this.lb_space_used.AutoSize = true;
            this.lb_space_used.Location = new System.Drawing.Point(5, 5);
            this.lb_space_used.Name = "lb_space_used";
            this.lb_space_used.Size = new System.Drawing.Size(59, 22);
            this.lb_space_used.TabIndex = 8;
            this.lb_space_used.Text = "Used:";
            // 
            // tab_storage
            // 
            this.tab_storage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_storage.Controls.Add(this.tabPage1);
            this.tab_storage.Location = new System.Drawing.Point(20, 309);
            this.tab_storage.Name = "tab_storage";
            this.tab_storage.SelectedIndex = 0;
            this.tab_storage.Size = new System.Drawing.Size(708, 243);
            this.tab_storage.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(214, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensor:";
            // 
            // btn_chart
            // 
            this.btn_chart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_chart.BackgroundImage")));
            this.btn_chart.FlatAppearance.BorderSize = 0;
            this.btn_chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chart.Location = new System.Drawing.Point(694, 33);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Size = new System.Drawing.Size(30, 30);
            this.btn_chart.TabIndex = 9;
            this.btn_chart.UseVisualStyleBackColor = true;
            this.btn_chart.Click += new System.EventHandler(this.btn_chart_Click);
            // 
            // uc_accelerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_chart);
            this.Controls.Add(this.tab_storage);
            this.Controls.Add(this.lb_cpu_temperature);
            this.Controls.Add(this.lb_RAM_use);
            this.Controls.Add(this.lb_cpu_load);
            this.Controls.Add(this.prbar_temperature);
            this.Controls.Add(this.prbar_ram_used);
            this.Controls.Add(this.prbar_cpu_load);
            this.Controls.Add(this.lb_hor_line);
            this.Controls.Add(this.lb_storage);
            this.Controls.Add(this.lb_RAM);
            this.Controls.Add(this.lb_proc_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_CPU);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "uc_accelerator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(748, 656);
            this.Load += new System.EventHandler(this.uc_accelerator_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab_storage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CPU;
        private System.Windows.Forms.Label lb_hor_line;
        private CircularProgressBar.CircularProgressBar prbar_cpu_load;
        private System.Windows.Forms.Label lb_cpu_load;
        private CircularProgressBar.CircularProgressBar prbar_temperature;
        private System.Windows.Forms.Label lb_cpu_temperature;
        private System.Windows.Forms.Label lb_RAM;
        private System.Windows.Forms.Label lb_proc_name;
        private CircularProgressBar.CircularProgressBar prbar_ram_used;
        private System.Windows.Forms.Label lb_storage;
        private System.Windows.Forms.Timer timer_uc_acc;
        private System.Windows.Forms.Label lb_RAM_use;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_space_freeValue;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tab_storage;
        private System.Windows.Forms.Label lb_space_free;
        private System.Windows.Forms.Label lb_space_used;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_space_usedValue;
        private CircularProgressBar.CircularProgressBar prbar_usedSpace_total;
        private CircularProgressBar.CircularProgressBar prbar_freeSpace_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chart;
    }
}
