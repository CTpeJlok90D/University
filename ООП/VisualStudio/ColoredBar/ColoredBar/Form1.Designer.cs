namespace ColoredBar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coloredBar = new ColoredBar.ColoredProgressBar();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.caption = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coloredBar
            // 
            this.coloredBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.coloredBar.BackGroundColor = System.Drawing.Color.Gray;
            this.coloredBar.Location = new System.Drawing.Point(12, 12);
            this.coloredBar.Name = "coloredBar";
            this.coloredBar.Size = new System.Drawing.Size(150, 334);
            this.coloredBar.TabIndex = 0;
            this.coloredBar.Value = 50;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(168, 27);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 23);
            this.valueTextBox.TabIndex = 1;
            this.valueTextBox.Text = "50";
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.Location = new System.Drawing.Point(168, 9);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(92, 15);
            this.caption.TabIndex = 2;
            this.caption.Text = "Заполненность";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(193, 323);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(83, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 357);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.coloredBar);
            this.Name = "Form1";
            this.Text = "ColorBarTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColoredProgressBar coloredBar;
        private TextBox valueTextBox;
        private Label caption;
        private Button applyButton;
    }
}