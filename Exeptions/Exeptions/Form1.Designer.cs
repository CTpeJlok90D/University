namespace Exeptions
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            this.Calculate = new System.Windows.Forms.Button();
            this.InputA = new System.Windows.Forms.TextBox();
            this.InputB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 38);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(12, 12);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(100, 20);
            this.InputA.TabIndex = 1;
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(136, 12);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(100, 20);
            this.InputB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(261, 12);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 81);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label2;
    }
}

