namespace N2
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
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.inputC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.TextBox();
            this.Calcucate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(12, 12);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(100, 20);
            this.inputA.TabIndex = 0;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(162, 12);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(100, 20);
            this.inputB.TabIndex = 1;
            // 
            // inputC
            // 
            this.inputC.Location = new System.Drawing.Point(300, 12);
            this.inputC.Name = "inputC";
            this.inputC.Size = new System.Drawing.Size(100, 20);
            this.inputC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X^2 + ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X + ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "= 0";
            // 
            // result1
            // 
            this.result1.Location = new System.Drawing.Point(128, 40);
            this.result1.Name = "result1";
            this.result1.ReadOnly = true;
            this.result1.Size = new System.Drawing.Size(100, 20);
            this.result1.TabIndex = 6;
            // 
            // Calcucate
            // 
            this.Calcucate.Location = new System.Drawing.Point(12, 38);
            this.Calcucate.Name = "Calcucate";
            this.Calcucate.Size = new System.Drawing.Size(75, 23);
            this.Calcucate.TabIndex = 7;
            this.Calcucate.Text = "Расчитать";
            this.Calcucate.UseVisualStyleBackColor = true;
            this.Calcucate.Click += new System.EventHandler(this.CalculateClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X1 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X2 =";
            // 
            // result2
            // 
            this.result2.Location = new System.Drawing.Point(128, 79);
            this.result2.Name = "result2";
            this.result2.ReadOnly = true;
            this.result2.Size = new System.Drawing.Size(100, 20);
            this.result2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 147);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calcucate);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputC);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.TextBox inputC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.Button Calcucate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox result2;
    }
}

