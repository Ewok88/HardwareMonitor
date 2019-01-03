namespace HardwareMonitor.UI
{
    partial class uc_video_controller
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
            this.tab_gpu = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tab_gpu
            // 
            this.tab_gpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_gpu.Location = new System.Drawing.Point(0, 0);
            this.tab_gpu.Name = "tab_gpu";
            this.tab_gpu.SelectedIndex = 0;
            this.tab_gpu.Size = new System.Drawing.Size(748, 656);
            this.tab_gpu.TabIndex = 6;
            // 
            // uc_video_controller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tab_gpu);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "uc_video_controller";
            this.Size = new System.Drawing.Size(748, 656);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tab_gpu;
    }
}
