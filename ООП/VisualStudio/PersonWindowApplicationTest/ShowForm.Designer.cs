namespace PersonWindowApplicationTest
{
    partial class ShowForm
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
            this._studentListBox = new System.Windows.Forms.ListBox();
            this._teacherListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._infoTextBox = new System.Windows.Forms.RichTextBox();
            this._addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _studentListBox
            // 
            this._studentListBox.FormattingEnabled = true;
            this._studentListBox.ItemHeight = 15;
            this._studentListBox.Location = new System.Drawing.Point(12, 42);
            this._studentListBox.Name = "_studentListBox";
            this._studentListBox.Size = new System.Drawing.Size(217, 454);
            this._studentListBox.TabIndex = 0;
            this._studentListBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedStudentIndexChanged);
            // 
            // _teacherListBox
            // 
            this._teacherListBox.FormattingEnabled = true;
            this._teacherListBox.ItemHeight = 15;
            this._teacherListBox.Location = new System.Drawing.Point(235, 42);
            this._teacherListBox.Name = "_teacherListBox";
            this._teacherListBox.Size = new System.Drawing.Size(220, 454);
            this._teacherListBox.TabIndex = 1;
            this._teacherListBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedTeacherIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Студенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Преподаватели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Иформация о выделнном объекте";
            // 
            // _infoTextBox
            // 
            this._infoTextBox.Location = new System.Drawing.Point(460, 42);
            this._infoTextBox.Name = "_infoTextBox";
            this._infoTextBox.ReadOnly = true;
            this._infoTextBox.Size = new System.Drawing.Size(219, 222);
            this._infoTextBox.TabIndex = 5;
            this._infoTextBox.Text = "Имя:\nВозраст:";
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(604, 473);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(75, 23);
            this._addButton.TabIndex = 6;
            this._addButton.Text = "Добавить";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonOnClick);
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 512);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._infoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._teacherListBox);
            this.Controls.Add(this._studentListBox);
            this.Name = "ShowForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox _studentListBox;
        private ListBox _teacherListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox _infoTextBox;
        private Button _addButton;
    }
}