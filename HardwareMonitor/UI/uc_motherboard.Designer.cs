namespace HardwareMonitor.UI
{
    partial class uc_motherboard
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
            this.lb_motherboard = new System.Windows.Forms.Label();
            this.lb_caption = new System.Windows.Forms.Label();
            this.lb_manufact = new System.Windows.Forms.Label();
            this.lb_serial = new System.Windows.Forms.Label();
            this.lb_vers = new System.Windows.Forms.Label();
            this.lb_prod = new System.Windows.Forms.Label();
            this.lb_board_caption = new System.Windows.Forms.Label();
            this.lb_board_manufact = new System.Windows.Forms.Label();
            this.lb_board_serial = new System.Windows.Forms.Label();
            this.lb_board_version = new System.Windows.Forms.Label();
            this.lb_board_product = new System.Windows.Forms.Label();
            this.pnl_boad_info = new System.Windows.Forms.Panel();
            this.pnl_boad_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_motherboard
            // 
            this.lb_motherboard.AutoSize = true;
            this.lb_motherboard.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_motherboard.Location = new System.Drawing.Point(20, 20);
            this.lb_motherboard.Name = "lb_motherboard";
            this.lb_motherboard.Size = new System.Drawing.Size(191, 33);
            this.lb_motherboard.TabIndex = 0;
            this.lb_motherboard.Text = "Motherboard";
            // 
            // lb_caption
            // 
            this.lb_caption.AutoSize = true;
            this.lb_caption.Location = new System.Drawing.Point(0, 0);
            this.lb_caption.Name = "lb_caption";
            this.lb_caption.Size = new System.Drawing.Size(94, 23);
            this.lb_caption.TabIndex = 1;
            this.lb_caption.Text = "Caption:";
            // 
            // lb_manufact
            // 
            this.lb_manufact.AutoSize = true;
            this.lb_manufact.Location = new System.Drawing.Point(0, 30);
            this.lb_manufact.Name = "lb_manufact";
            this.lb_manufact.Size = new System.Drawing.Size(147, 23);
            this.lb_manufact.TabIndex = 1;
            this.lb_manufact.Text = "Manufacturer:";
            // 
            // lb_serial
            // 
            this.lb_serial.AutoSize = true;
            this.lb_serial.Location = new System.Drawing.Point(0, 90);
            this.lb_serial.Name = "lb_serial";
            this.lb_serial.Size = new System.Drawing.Size(151, 23);
            this.lb_serial.TabIndex = 1;
            this.lb_serial.Text = "Serial Number:";
            // 
            // lb_vers
            // 
            this.lb_vers.AutoSize = true;
            this.lb_vers.Location = new System.Drawing.Point(0, 120);
            this.lb_vers.Name = "lb_vers";
            this.lb_vers.Size = new System.Drawing.Size(85, 23);
            this.lb_vers.TabIndex = 1;
            this.lb_vers.Text = "Version:";
            // 
            // lb_prod
            // 
            this.lb_prod.AutoSize = true;
            this.lb_prod.Location = new System.Drawing.Point(0, 60);
            this.lb_prod.Name = "lb_prod";
            this.lb_prod.Size = new System.Drawing.Size(92, 23);
            this.lb_prod.TabIndex = 1;
            this.lb_prod.Text = "Product:";
            // 
            // lb_board_caption
            // 
            this.lb_board_caption.AutoSize = true;
            this.lb_board_caption.Location = new System.Drawing.Point(155, 0);
            this.lb_board_caption.Name = "lb_board_caption";
            this.lb_board_caption.Size = new System.Drawing.Size(72, 23);
            this.lb_board_caption.TabIndex = 2;
            this.lb_board_caption.Text = "label1";
            // 
            // lb_board_manufact
            // 
            this.lb_board_manufact.AutoSize = true;
            this.lb_board_manufact.Location = new System.Drawing.Point(155, 30);
            this.lb_board_manufact.Name = "lb_board_manufact";
            this.lb_board_manufact.Size = new System.Drawing.Size(72, 23);
            this.lb_board_manufact.TabIndex = 2;
            this.lb_board_manufact.Text = "label1";
            // 
            // lb_board_serial
            // 
            this.lb_board_serial.AutoSize = true;
            this.lb_board_serial.Location = new System.Drawing.Point(155, 90);
            this.lb_board_serial.Name = "lb_board_serial";
            this.lb_board_serial.Size = new System.Drawing.Size(72, 23);
            this.lb_board_serial.TabIndex = 2;
            this.lb_board_serial.Text = "label1";
            // 
            // lb_board_version
            // 
            this.lb_board_version.AutoSize = true;
            this.lb_board_version.Location = new System.Drawing.Point(155, 120);
            this.lb_board_version.Name = "lb_board_version";
            this.lb_board_version.Size = new System.Drawing.Size(72, 23);
            this.lb_board_version.TabIndex = 2;
            this.lb_board_version.Text = "label1";
            // 
            // lb_board_product
            // 
            this.lb_board_product.AutoSize = true;
            this.lb_board_product.Location = new System.Drawing.Point(155, 60);
            this.lb_board_product.Name = "lb_board_product";
            this.lb_board_product.Size = new System.Drawing.Size(72, 23);
            this.lb_board_product.TabIndex = 2;
            this.lb_board_product.Text = "label1";
            // 
            // pnl_boad_info
            // 
            this.pnl_boad_info.Controls.Add(this.lb_prod);
            this.pnl_boad_info.Controls.Add(this.lb_board_product);
            this.pnl_boad_info.Controls.Add(this.lb_caption);
            this.pnl_boad_info.Controls.Add(this.lb_board_version);
            this.pnl_boad_info.Controls.Add(this.lb_manufact);
            this.pnl_boad_info.Controls.Add(this.lb_board_serial);
            this.pnl_boad_info.Controls.Add(this.lb_serial);
            this.pnl_boad_info.Controls.Add(this.lb_board_manufact);
            this.pnl_boad_info.Controls.Add(this.lb_vers);
            this.pnl_boad_info.Controls.Add(this.lb_board_caption);
            this.pnl_boad_info.Location = new System.Drawing.Point(26, 56);
            this.pnl_boad_info.Name = "pnl_boad_info";
            this.pnl_boad_info.Size = new System.Drawing.Size(460, 155);
            this.pnl_boad_info.TabIndex = 3;
            // 
            // uc_motherboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnl_boad_info);
            this.Controls.Add(this.lb_motherboard);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "uc_motherboard";
            this.Size = new System.Drawing.Size(748, 656);
            this.pnl_boad_info.ResumeLayout(false);
            this.pnl_boad_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_motherboard;
        private System.Windows.Forms.Label lb_caption;
        private System.Windows.Forms.Label lb_manufact;
        private System.Windows.Forms.Label lb_serial;
        private System.Windows.Forms.Label lb_vers;
        private System.Windows.Forms.Label lb_prod;
        private System.Windows.Forms.Label lb_board_caption;
        private System.Windows.Forms.Label lb_board_manufact;
        private System.Windows.Forms.Label lb_board_serial;
        private System.Windows.Forms.Label lb_board_version;
        private System.Windows.Forms.Label lb_board_product;
        private System.Windows.Forms.Panel pnl_boad_info;
    }
}
