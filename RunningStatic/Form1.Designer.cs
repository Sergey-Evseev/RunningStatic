namespace RunningStatic
{
    partial class Form1
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
            this.btnStatic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatic
            // 
            this.btnStatic.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStatic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStatic.Location = new System.Drawing.Point(347, 182);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(80, 80);
            this.btnStatic.TabIndex = 0;
            this.btnStatic.Text = "Catch me!";
            this.btnStatic.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStatic);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStatic;
    }
}

