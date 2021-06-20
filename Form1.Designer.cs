
namespace HW1
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
            this.ResumeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResumeButton
            // 
            this.ResumeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResumeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResumeButton.Location = new System.Drawing.Point(12, 12);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(155, 59);
            this.ResumeButton.TabIndex = 0;
            this.ResumeButton.Text = "MyResume";
            this.ResumeButton.UseVisualStyleBackColor = false;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 22);
            this.textBox1.TabIndex = 1;
            // 
            // TryButton
            // 
            this.TryButton.Location = new System.Drawing.Point(184, 197);
            this.TryButton.Name = "TryButton";
            this.TryButton.Size = new System.Drawing.Size(50, 31);
            this.TryButton.TabIndex = 3;
            this.TryButton.Text = "Try";
            this.TryButton.UseVisualStyleBackColor = true;
            this.TryButton.Click += new System.EventHandler(this.TryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guess the Number (1 to 2000)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TryButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ResumeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TryButton;
        private System.Windows.Forms.Label label1;
    }
}

