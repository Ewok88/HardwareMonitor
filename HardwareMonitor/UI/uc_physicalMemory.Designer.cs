namespace HardwareMonitor.UI
{
    partial class uc_physicalMemory
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
            this.tab_memory = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tab_memory
            // 
            this.tab_memory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_memory.Location = new System.Drawing.Point(0, 0);
            this.tab_memory.Name = "tab_memory";
            this.tab_memory.SelectedIndex = 0;
            this.tab_memory.Size = new System.Drawing.Size(748, 656);
            this.tab_memory.TabIndex = 0;
            // 
            // uc_physicalMemory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tab_memory);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "uc_physicalMemory";
            this.Size = new System.Drawing.Size(748, 656);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_memory;
    }
}
