namespace Т4
{
    partial class N4
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
            this.input = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedMode = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(126, 9);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 0;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(126, 38);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Получите результат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите значение";
            // 
            // selectedMode
            // 
            this.selectedMode.FormattingEnabled = true;
            this.selectedMode.Items.AddRange(new object[] {
            "Радианы",
            "Градусы"});
            this.selectedMode.Location = new System.Drawing.Point(232, 9);
            this.selectedMode.Name = "selectedMode";
            this.selectedMode.Size = new System.Drawing.Size(120, 94);
            this.selectedMode.TabIndex = 4;
            this.selectedMode.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.selectedMode_ItemCheck);
            // 
            // N4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectedMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.input);
            this.Name = "N4";
            this.Text = "N4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox selectedMode;
    }
}

