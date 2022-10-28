namespace TreeWindow
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
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.treeViewTextBox = new System.Windows.Forms.RichTextBox();
            this.removeTextBox = new System.Windows.Forms.TextBox();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(420, 42);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(420, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddClick);
            // 
            // treeViewTextBox
            // 
            this.treeViewTextBox.Location = new System.Drawing.Point(12, 12);
            this.treeViewTextBox.Name = "treeViewTextBox";
            this.treeViewTextBox.ReadOnly = true;
            this.treeViewTextBox.Size = new System.Drawing.Size(296, 352);
            this.treeViewTextBox.TabIndex = 4;
            this.treeViewTextBox.Text = "";
            // 
            // removeTextBox
            // 
            this.removeTextBox.Location = new System.Drawing.Point(314, 42);
            this.removeTextBox.Name = "removeTextBox";
            this.removeTextBox.Size = new System.Drawing.Size(100, 23);
            this.removeTextBox.TabIndex = 5;
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(314, 12);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(100, 23);
            this.addTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.removeTextBox);
            this.Controls.Add(this.treeViewTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button removeButton;
        private Button addButton;
        private RichTextBox treeViewTextBox;
        private TextBox removeTextBox;
        private TextBox addTextBox;
    }
}