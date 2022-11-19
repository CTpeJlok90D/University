namespace PersonWindowApplicationTest
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.applyButton = new System.Windows.Forms.Button();
            this._ageTextBox = new System.Windows.Forms.TextBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._ageLabel = new System.Windows.Forms.Label();
            this._nameLabel = new System.Windows.Forms.Label();
            this._seletectWorkTabControl = new System.Windows.Forms.TabControl();
            this._student = new System.Windows.Forms.TabPage();
            this._studyDictionaryLabel = new System.Windows.Forms.Label();
            this._studyDictionarity = new System.Windows.Forms.TextBox();
            this._teacher = new System.Windows.Forms.TabPage();
            this._departmentLablel = new System.Windows.Forms.Label();
            this._departmentTextBox = new System.Windows.Forms.TextBox();
            this._seletectWorkTabControl.SuspendLayout();
            this._student.SuspendLayout();
            this._teacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(203, 415);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Принять";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButtonOnClick);
            // 
            // _ageTextBox
            // 
            this._ageTextBox.Location = new System.Drawing.Point(12, 71);
            this._ageTextBox.Name = "_ageTextBox";
            this._ageTextBox.Size = new System.Drawing.Size(100, 23);
            this._ageTextBox.TabIndex = 3;
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(12, 27);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(100, 23);
            this._nameTextBox.TabIndex = 4;
            // 
            // _ageLabel
            // 
            this._ageLabel.AutoSize = true;
            this._ageLabel.Location = new System.Drawing.Point(12, 53);
            this._ageLabel.Name = "_ageLabel";
            this._ageLabel.Size = new System.Drawing.Size(50, 15);
            this._ageLabel.TabIndex = 5;
            this._ageLabel.Text = "Возраст";
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(12, 9);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(31, 15);
            this._nameLabel.TabIndex = 6;
            this._nameLabel.Text = "Имя";
            // 
            // _seletectWorkTabControl
            // 
            this._seletectWorkTabControl.Controls.Add(this._student);
            this._seletectWorkTabControl.Controls.Add(this._teacher);
            this._seletectWorkTabControl.Location = new System.Drawing.Point(12, 100);
            this._seletectWorkTabControl.Name = "_seletectWorkTabControl";
            this._seletectWorkTabControl.SelectedIndex = 0;
            this._seletectWorkTabControl.Size = new System.Drawing.Size(270, 306);
            this._seletectWorkTabControl.TabIndex = 7;
            // 
            // _student
            // 
            this._student.Controls.Add(this._studyDictionaryLabel);
            this._student.Controls.Add(this._studyDictionarity);
            this._student.Location = new System.Drawing.Point(4, 24);
            this._student.Name = "_student";
            this._student.Padding = new System.Windows.Forms.Padding(3);
            this._student.Size = new System.Drawing.Size(262, 278);
            this._student.TabIndex = 0;
            this._student.Text = "Студент";
            this._student.UseVisualStyleBackColor = true;
            // 
            // _studyDictionaryLabel
            // 
            this._studyDictionaryLabel.AutoSize = true;
            this._studyDictionaryLabel.Location = new System.Drawing.Point(6, 3);
            this._studyDictionaryLabel.Name = "_studyDictionaryLabel";
            this._studyDictionaryLabel.Size = new System.Drawing.Size(147, 15);
            this._studyDictionaryLabel.TabIndex = 8;
            this._studyDictionaryLabel.Text = "Направление подготовки";
            // 
            // _studyDictionarity
            // 
            this._studyDictionarity.Location = new System.Drawing.Point(6, 21);
            this._studyDictionarity.Name = "_studyDictionarity";
            this._studyDictionarity.Size = new System.Drawing.Size(213, 23);
            this._studyDictionarity.TabIndex = 8;
            // 
            // _teacher
            // 
            this._teacher.Controls.Add(this._departmentLablel);
            this._teacher.Controls.Add(this._departmentTextBox);
            this._teacher.Location = new System.Drawing.Point(4, 24);
            this._teacher.Name = "_teacher";
            this._teacher.Padding = new System.Windows.Forms.Padding(3);
            this._teacher.Size = new System.Drawing.Size(262, 278);
            this._teacher.TabIndex = 1;
            this._teacher.Text = "Преподаватель";
            this._teacher.UseVisualStyleBackColor = true;
            // 
            // _departmentLablel
            // 
            this._departmentLablel.AutoSize = true;
            this._departmentLablel.Location = new System.Drawing.Point(6, 5);
            this._departmentLablel.Name = "_departmentLablel";
            this._departmentLablel.Size = new System.Drawing.Size(54, 15);
            this._departmentLablel.TabIndex = 9;
            this._departmentLablel.Text = "Кафедра";
            // 
            // _departmentTextBox
            // 
            this._departmentTextBox.Location = new System.Drawing.Point(6, 23);
            this._departmentTextBox.Name = "_departmentTextBox";
            this._departmentTextBox.Size = new System.Drawing.Size(213, 23);
            this._departmentTextBox.TabIndex = 10;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this._seletectWorkTabControl);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._ageLabel);
            this.Controls.Add(this._nameTextBox);
            this.Controls.Add(this._ageTextBox);
            this.Controls.Add(this.applyButton);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this._seletectWorkTabControl.ResumeLayout(false);
            this._student.ResumeLayout(false);
            this._student.PerformLayout();
            this._teacher.ResumeLayout(false);
            this._teacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button applyButton;
        private TextBox _ageTextBox;
        private TextBox _nameTextBox;
        private Label _ageLabel;
        private Label _nameLabel;
        private TabControl _seletectWorkTabControl;
        private TabPage _student;
        private Label _studyDictionaryLabel;
        private TextBox _studyDictionarity;
        private TabPage _teacher;
        private Label _departmentLablel;
        private TextBox _departmentTextBox;
    }
}