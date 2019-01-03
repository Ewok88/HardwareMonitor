namespace HardwareMonitor.UI
{
    partial class uc_processor
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
            this.lb_CPU = new System.Windows.Forms.Label();
            this.lb_proc_name = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_arch = new System.Windows.Forms.Label();
            this.lb_proc_arch = new System.Windows.Forms.Label();
            this.lb_caption = new System.Windows.Forms.Label();
            this.lb_proc_capt = new System.Windows.Forms.Label();
            this.lb_clspeed = new System.Windows.Forms.Label();
            this.lb_proc_clspeed = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_proc_descr = new System.Windows.Forms.Label();
            this.lb_extClock = new System.Windows.Forms.Label();
            this.lb_proc_extClock = new System.Windows.Forms.Label();
            this.pnl_clocks = new System.Windows.Forms.Panel();
            this.lb_clocks = new System.Windows.Forms.Label();
            this.lb_max_clspeed = new System.Windows.Forms.Label();
            this.lb_proc_maxclspeed = new System.Windows.Forms.Label();
            this.pnl_cache = new System.Windows.Forms.Panel();
            this.lb_cache = new System.Windows.Forms.Label();
            this.lb_cache_lvl3 = new System.Windows.Forms.Label();
            this.lb_cache_lvl2 = new System.Windows.Forms.Label();
            this.lb_proc_cache_lvl3 = new System.Windows.Forms.Label();
            this.lb_proc_cache_lvl2 = new System.Windows.Forms.Label();
            this.lb_maanufact = new System.Windows.Forms.Label();
            this.lb_proc_manuf = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_proc_type = new System.Windows.Forms.Label();
            this.lb_core = new System.Windows.Forms.Label();
            this.lb_proc_numcor = new System.Windows.Forms.Label();
            this.lb_threads = new System.Windows.Forms.Label();
            this.lb_proc_numthreads = new System.Windows.Forms.Label();
            this.pnl_cpuinfo = new System.Windows.Forms.Panel();
            this.lb_proc_role = new System.Windows.Forms.Label();
            this.lb_proc_revision = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.lb_revision = new System.Windows.Forms.Label();
            this.pnl_clocks.SuspendLayout();
            this.pnl_cache.SuspendLayout();
            this.pnl_cpuinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_CPU
            // 
            this.lb_CPU.AutoSize = true;
            this.lb_CPU.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_CPU.Location = new System.Drawing.Point(20, 20);
            this.lb_CPU.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_CPU.Name = "lb_CPU";
            this.lb_CPU.Size = new System.Drawing.Size(70, 33);
            this.lb_CPU.TabIndex = 1;
            this.lb_CPU.Text = "CPU";
            // 
            // lb_proc_name
            // 
            this.lb_proc_name.AutoSize = true;
            this.lb_proc_name.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_name.Location = new System.Drawing.Point(135, 70);
            this.lb_proc_name.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_proc_name.Name = "lb_proc_name";
            this.lb_proc_name.Size = new System.Drawing.Size(52, 23);
            this.lb_proc_name.TabIndex = 2;
            this.lb_proc_name.Text = "Intel";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_name.Location = new System.Drawing.Point(20, 70);
            this.lb_name.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(76, 23);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Name:";
            // 
            // lb_arch
            // 
            this.lb_arch.AutoSize = true;
            this.lb_arch.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_arch.Location = new System.Drawing.Point(0, 60);
            this.lb_arch.Name = "lb_arch";
            this.lb_arch.Size = new System.Drawing.Size(135, 23);
            this.lb_arch.TabIndex = 4;
            this.lb_arch.Text = "Architecture:";
            // 
            // lb_proc_arch
            // 
            this.lb_proc_arch.AutoSize = true;
            this.lb_proc_arch.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_arch.Location = new System.Drawing.Point(165, 60);
            this.lb_proc_arch.Name = "lb_proc_arch";
            this.lb_proc_arch.Size = new System.Drawing.Size(32, 23);
            this.lb_proc_arch.TabIndex = 5;
            this.lb_proc_arch.Text = "64";
            // 
            // lb_caption
            // 
            this.lb_caption.AutoSize = true;
            this.lb_caption.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_caption.Location = new System.Drawing.Point(20, 100);
            this.lb_caption.Name = "lb_caption";
            this.lb_caption.Size = new System.Drawing.Size(94, 23);
            this.lb_caption.TabIndex = 4;
            this.lb_caption.Text = "Caption:";
            // 
            // lb_proc_capt
            // 
            this.lb_proc_capt.AutoSize = true;
            this.lb_proc_capt.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_capt.Location = new System.Drawing.Point(135, 100);
            this.lb_proc_capt.Name = "lb_proc_capt";
            this.lb_proc_capt.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_capt.TabIndex = 5;
            this.lb_proc_capt.Text = "qwer";
            // 
            // lb_clspeed
            // 
            this.lb_clspeed.AutoSize = true;
            this.lb_clspeed.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_clspeed.Location = new System.Drawing.Point(0, 30);
            this.lb_clspeed.Name = "lb_clspeed";
            this.lb_clspeed.Size = new System.Drawing.Size(142, 23);
            this.lb_clspeed.TabIndex = 4;
            this.lb_clspeed.Text = "Clock Speed:";
            // 
            // lb_proc_clspeed
            // 
            this.lb_proc_clspeed.AutoSize = true;
            this.lb_proc_clspeed.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_clspeed.Location = new System.Drawing.Point(190, 30);
            this.lb_proc_clspeed.Name = "lb_proc_clspeed";
            this.lb_proc_clspeed.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_clspeed.TabIndex = 5;
            this.lb_proc_clspeed.Text = "qwer";
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_description.Location = new System.Drawing.Point(20, 130);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(122, 23);
            this.lb_description.TabIndex = 4;
            this.lb_description.Text = "Description:";
            // 
            // lb_proc_descr
            // 
            this.lb_proc_descr.AutoSize = true;
            this.lb_proc_descr.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_descr.Location = new System.Drawing.Point(135, 130);
            this.lb_proc_descr.Name = "lb_proc_descr";
            this.lb_proc_descr.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_descr.TabIndex = 5;
            this.lb_proc_descr.Text = "qwer";
            // 
            // lb_extClock
            // 
            this.lb_extClock.AutoSize = true;
            this.lb_extClock.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_extClock.Location = new System.Drawing.Point(0, 60);
            this.lb_extClock.Name = "lb_extClock";
            this.lb_extClock.Size = new System.Drawing.Size(156, 23);
            this.lb_extClock.TabIndex = 4;
            this.lb_extClock.Text = "External Clock:";
            // 
            // lb_proc_extClock
            // 
            this.lb_proc_extClock.AutoSize = true;
            this.lb_proc_extClock.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_extClock.Location = new System.Drawing.Point(190, 90);
            this.lb_proc_extClock.Name = "lb_proc_extClock";
            this.lb_proc_extClock.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_extClock.TabIndex = 5;
            this.lb_proc_extClock.Text = "qwer";
            // 
            // pnl_clocks
            // 
            this.pnl_clocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_clocks.Controls.Add(this.lb_clocks);
            this.pnl_clocks.Controls.Add(this.lb_max_clspeed);
            this.pnl_clocks.Controls.Add(this.lb_proc_extClock);
            this.pnl_clocks.Controls.Add(this.lb_clspeed);
            this.pnl_clocks.Controls.Add(this.lb_proc_maxclspeed);
            this.pnl_clocks.Controls.Add(this.lb_proc_clspeed);
            this.pnl_clocks.Controls.Add(this.lb_extClock);
            this.pnl_clocks.Location = new System.Drawing.Point(398, 170);
            this.pnl_clocks.Name = "pnl_clocks";
            this.pnl_clocks.Size = new System.Drawing.Size(300, 137);
            this.pnl_clocks.TabIndex = 6;
            // 
            // lb_clocks
            // 
            this.lb_clocks.AutoSize = true;
            this.lb_clocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_clocks.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lb_clocks.Location = new System.Drawing.Point(0, 0);
            this.lb_clocks.Name = "lb_clocks";
            this.lb_clocks.Size = new System.Drawing.Size(77, 25);
            this.lb_clocks.TabIndex = 6;
            this.lb_clocks.Text = "Clocks";
            this.lb_clocks.UseMnemonic = false;
            // 
            // lb_max_clspeed
            // 
            this.lb_max_clspeed.AutoSize = true;
            this.lb_max_clspeed.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_max_clspeed.Location = new System.Drawing.Point(0, 90);
            this.lb_max_clspeed.Name = "lb_max_clspeed";
            this.lb_max_clspeed.Size = new System.Drawing.Size(189, 23);
            this.lb_max_clspeed.TabIndex = 4;
            this.lb_max_clspeed.Text = "Max Clock Speed:";
            // 
            // lb_proc_maxclspeed
            // 
            this.lb_proc_maxclspeed.AutoSize = true;
            this.lb_proc_maxclspeed.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_maxclspeed.Location = new System.Drawing.Point(190, 60);
            this.lb_proc_maxclspeed.Name = "lb_proc_maxclspeed";
            this.lb_proc_maxclspeed.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_maxclspeed.TabIndex = 5;
            this.lb_proc_maxclspeed.Text = "qwer";
            // 
            // pnl_cache
            // 
            this.pnl_cache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_cache.Controls.Add(this.lb_cache);
            this.pnl_cache.Controls.Add(this.lb_cache_lvl3);
            this.pnl_cache.Controls.Add(this.lb_cache_lvl2);
            this.pnl_cache.Controls.Add(this.lb_proc_cache_lvl3);
            this.pnl_cache.Controls.Add(this.lb_proc_cache_lvl2);
            this.pnl_cache.Location = new System.Drawing.Point(398, 316);
            this.pnl_cache.Name = "pnl_cache";
            this.pnl_cache.Size = new System.Drawing.Size(165, 91);
            this.pnl_cache.TabIndex = 7;
            // 
            // lb_cache
            // 
            this.lb_cache.AutoSize = true;
            this.lb_cache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_cache.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lb_cache.Location = new System.Drawing.Point(0, 0);
            this.lb_cache.Name = "lb_cache";
            this.lb_cache.Size = new System.Drawing.Size(80, 25);
            this.lb_cache.TabIndex = 6;
            this.lb_cache.Text = "Cache";
            this.lb_cache.UseMnemonic = false;
            // 
            // lb_cache_lvl3
            // 
            this.lb_cache_lvl3.AutoSize = true;
            this.lb_cache_lvl3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_cache_lvl3.Location = new System.Drawing.Point(0, 60);
            this.lb_cache_lvl3.Name = "lb_cache_lvl3";
            this.lb_cache_lvl3.Size = new System.Drawing.Size(85, 23);
            this.lb_cache_lvl3.TabIndex = 4;
            this.lb_cache_lvl3.Text = "Level 3:";
            // 
            // lb_cache_lvl2
            // 
            this.lb_cache_lvl2.AutoSize = true;
            this.lb_cache_lvl2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_cache_lvl2.Location = new System.Drawing.Point(0, 30);
            this.lb_cache_lvl2.Name = "lb_cache_lvl2";
            this.lb_cache_lvl2.Size = new System.Drawing.Size(85, 23);
            this.lb_cache_lvl2.TabIndex = 4;
            this.lb_cache_lvl2.Text = "Level 2:";
            // 
            // lb_proc_cache_lvl3
            // 
            this.lb_proc_cache_lvl3.AutoSize = true;
            this.lb_proc_cache_lvl3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_cache_lvl3.Location = new System.Drawing.Point(85, 60);
            this.lb_proc_cache_lvl3.Name = "lb_proc_cache_lvl3";
            this.lb_proc_cache_lvl3.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_cache_lvl3.TabIndex = 5;
            this.lb_proc_cache_lvl3.Text = "qwer";
            // 
            // lb_proc_cache_lvl2
            // 
            this.lb_proc_cache_lvl2.AutoSize = true;
            this.lb_proc_cache_lvl2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_cache_lvl2.Location = new System.Drawing.Point(85, 30);
            this.lb_proc_cache_lvl2.Name = "lb_proc_cache_lvl2";
            this.lb_proc_cache_lvl2.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_cache_lvl2.TabIndex = 5;
            this.lb_proc_cache_lvl2.Text = "qwer";
            // 
            // lb_maanufact
            // 
            this.lb_maanufact.AutoSize = true;
            this.lb_maanufact.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_maanufact.Location = new System.Drawing.Point(0, 0);
            this.lb_maanufact.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_maanufact.Name = "lb_maanufact";
            this.lb_maanufact.Size = new System.Drawing.Size(147, 23);
            this.lb_maanufact.TabIndex = 3;
            this.lb_maanufact.Text = "Manufacturer:";
            // 
            // lb_proc_manuf
            // 
            this.lb_proc_manuf.AutoSize = true;
            this.lb_proc_manuf.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_manuf.Location = new System.Drawing.Point(165, 0);
            this.lb_proc_manuf.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_proc_manuf.Name = "lb_proc_manuf";
            this.lb_proc_manuf.Size = new System.Drawing.Size(52, 23);
            this.lb_proc_manuf.TabIndex = 2;
            this.lb_proc_manuf.Text = "Intel";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_type.Location = new System.Drawing.Point(0, 30);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(159, 23);
            this.lb_type.TabIndex = 4;
            this.lb_type.Text = "Processor Type:";
            // 
            // lb_proc_type
            // 
            this.lb_proc_type.AutoSize = true;
            this.lb_proc_type.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_type.Location = new System.Drawing.Point(165, 30);
            this.lb_proc_type.Name = "lb_proc_type";
            this.lb_proc_type.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_type.TabIndex = 5;
            this.lb_proc_type.Text = "qwer";
            // 
            // lb_core
            // 
            this.lb_core.AutoSize = true;
            this.lb_core.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_core.Location = new System.Drawing.Point(0, 90);
            this.lb_core.Name = "lb_core";
            this.lb_core.Size = new System.Drawing.Size(71, 23);
            this.lb_core.TabIndex = 4;
            this.lb_core.Text = "Cores:";
            // 
            // lb_proc_numcor
            // 
            this.lb_proc_numcor.AutoSize = true;
            this.lb_proc_numcor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_numcor.Location = new System.Drawing.Point(165, 90);
            this.lb_proc_numcor.Name = "lb_proc_numcor";
            this.lb_proc_numcor.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_numcor.TabIndex = 5;
            this.lb_proc_numcor.Text = "qwer";
            // 
            // lb_threads
            // 
            this.lb_threads.AutoSize = true;
            this.lb_threads.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_threads.Location = new System.Drawing.Point(0, 120);
            this.lb_threads.Name = "lb_threads";
            this.lb_threads.Size = new System.Drawing.Size(90, 23);
            this.lb_threads.TabIndex = 4;
            this.lb_threads.Text = "Threads:";
            // 
            // lb_proc_numthreads
            // 
            this.lb_proc_numthreads.AutoSize = true;
            this.lb_proc_numthreads.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_numthreads.Location = new System.Drawing.Point(165, 120);
            this.lb_proc_numthreads.Name = "lb_proc_numthreads";
            this.lb_proc_numthreads.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_numthreads.TabIndex = 5;
            this.lb_proc_numthreads.Text = "qwer";
            // 
            // pnl_cpuinfo
            // 
            this.pnl_cpuinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_cpuinfo.Controls.Add(this.lb_maanufact);
            this.pnl_cpuinfo.Controls.Add(this.lb_proc_manuf);
            this.pnl_cpuinfo.Controls.Add(this.lb_type);
            this.pnl_cpuinfo.Controls.Add(this.lb_proc_role);
            this.pnl_cpuinfo.Controls.Add(this.lb_proc_revision);
            this.pnl_cpuinfo.Controls.Add(this.lb_proc_numthreads);
            this.pnl_cpuinfo.Controls.Add(this.lb_proc_type);
            this.pnl_cpuinfo.Controls.Add(this.lb_proc_numcor);
            this.pnl_cpuinfo.Controls.Add(this.lb_arch);
            this.pnl_cpuinfo.Controls.Add(this.lb_role);
            this.pnl_cpuinfo.Controls.Add(this.lb_revision);
            this.pnl_cpuinfo.Controls.Add(this.lb_threads);
            this.pnl_cpuinfo.Controls.Add(this.lb_proc_arch);
            this.pnl_cpuinfo.Controls.Add(this.lb_core);
            this.pnl_cpuinfo.Location = new System.Drawing.Point(20, 170);
            this.pnl_cpuinfo.Name = "pnl_cpuinfo";
            this.pnl_cpuinfo.Size = new System.Drawing.Size(360, 237);
            this.pnl_cpuinfo.TabIndex = 8;
            // 
            // lb_proc_role
            // 
            this.lb_proc_role.AutoSize = true;
            this.lb_proc_role.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_role.Location = new System.Drawing.Point(165, 180);
            this.lb_proc_role.Name = "lb_proc_role";
            this.lb_proc_role.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_role.TabIndex = 5;
            this.lb_proc_role.Text = "qwer";
            // 
            // lb_proc_revision
            // 
            this.lb_proc_revision.AutoSize = true;
            this.lb_proc_revision.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_proc_revision.Location = new System.Drawing.Point(165, 150);
            this.lb_proc_revision.Name = "lb_proc_revision";
            this.lb_proc_revision.Size = new System.Drawing.Size(61, 23);
            this.lb_proc_revision.TabIndex = 5;
            this.lb_proc_revision.Text = "qwer";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_role.Location = new System.Drawing.Point(0, 180);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(58, 23);
            this.lb_role.TabIndex = 4;
            this.lb_role.Text = "Role:";
            // 
            // lb_revision
            // 
            this.lb_revision.AutoSize = true;
            this.lb_revision.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_revision.Location = new System.Drawing.Point(0, 150);
            this.lb_revision.Name = "lb_revision";
            this.lb_revision.Size = new System.Drawing.Size(92, 23);
            this.lb_revision.TabIndex = 4;
            this.lb_revision.Text = "Revision:";
            // 
            // uc_processor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_cpuinfo);
            this.Controls.Add(this.pnl_cache);
            this.Controls.Add(this.pnl_clocks);
            this.Controls.Add(this.lb_proc_descr);
            this.Controls.Add(this.lb_proc_capt);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.lb_caption);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_proc_name);
            this.Controls.Add(this.lb_CPU);
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "uc_processor";
            this.Size = new System.Drawing.Size(748, 656);
            this.pnl_clocks.ResumeLayout(false);
            this.pnl_clocks.PerformLayout();
            this.pnl_cache.ResumeLayout(false);
            this.pnl_cache.PerformLayout();
            this.pnl_cpuinfo.ResumeLayout(false);
            this.pnl_cpuinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_CPU;
        private System.Windows.Forms.Label lb_proc_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_arch;
        private System.Windows.Forms.Label lb_proc_arch;
        private System.Windows.Forms.Label lb_caption;
        private System.Windows.Forms.Label lb_proc_capt;
        private System.Windows.Forms.Label lb_clspeed;
        private System.Windows.Forms.Label lb_proc_clspeed;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lb_proc_descr;
        private System.Windows.Forms.Label lb_extClock;
        private System.Windows.Forms.Label lb_proc_extClock;
        private System.Windows.Forms.Panel pnl_clocks;
        private System.Windows.Forms.Label lb_max_clspeed;
        private System.Windows.Forms.Label lb_proc_maxclspeed;
        private System.Windows.Forms.Label lb_clocks;
        private System.Windows.Forms.Panel pnl_cache;
        private System.Windows.Forms.Label lb_cache;
        private System.Windows.Forms.Label lb_cache_lvl3;
        private System.Windows.Forms.Label lb_cache_lvl2;
        private System.Windows.Forms.Label lb_proc_cache_lvl3;
        private System.Windows.Forms.Label lb_proc_cache_lvl2;
        private System.Windows.Forms.Label lb_maanufact;
        private System.Windows.Forms.Label lb_proc_manuf;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_proc_type;
        private System.Windows.Forms.Label lb_core;
        private System.Windows.Forms.Label lb_proc_numcor;
        private System.Windows.Forms.Label lb_threads;
        private System.Windows.Forms.Label lb_proc_numthreads;
        private System.Windows.Forms.Panel pnl_cpuinfo;
        private System.Windows.Forms.Label lb_proc_revision;
        private System.Windows.Forms.Label lb_revision;
        private System.Windows.Forms.Label lb_proc_role;
        private System.Windows.Forms.Label lb_role;
    }
}
