namespace MovebleObjects
{
    partial class N3
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
            this.components = new System.ComponentModel.Container();
            this._moveButtonDown = new System.Windows.Forms.Button();
            this._moveButtonUp = new System.Windows.Forms.Button();
            this._moveButtonLeft = new System.Windows.Forms.Button();
            this._moveButtonRight = new System.Windows.Forms.Button();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._objectListBox = new System.Windows.Forms.ListBox();
            this._timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _moveButtonDown
            // 
            this._moveButtonDown.Location = new System.Drawing.Point(722, 408);
            this._moveButtonDown.Name = "_moveButtonDown";
            this._moveButtonDown.Size = new System.Drawing.Size(30, 30);
            this._moveButtonDown.TabIndex = 0;
            this._moveButtonDown.Text = "↓";
            this._moveButtonDown.UseVisualStyleBackColor = true;
            this._moveButtonDown.Click += new System.EventHandler(this.MoveButtonDownClick);
            // 
            // _moveButtonUp
            // 
            this._moveButtonUp.Location = new System.Drawing.Point(722, 372);
            this._moveButtonUp.Name = "_moveButtonUp";
            this._moveButtonUp.Size = new System.Drawing.Size(30, 30);
            this._moveButtonUp.TabIndex = 1;
            this._moveButtonUp.Text = "↑";
            this._moveButtonUp.UseVisualStyleBackColor = true;
            this._moveButtonUp.Click += new System.EventHandler(this.MoveButtonUpClick);
            // 
            // _moveButtonLeft
            // 
            this._moveButtonLeft.Location = new System.Drawing.Point(686, 408);
            this._moveButtonLeft.Name = "_moveButtonLeft";
            this._moveButtonLeft.Size = new System.Drawing.Size(30, 30);
            this._moveButtonLeft.TabIndex = 2;
            this._moveButtonLeft.Text = "←";
            this._moveButtonLeft.UseVisualStyleBackColor = true;
            this._moveButtonLeft.Click += new System.EventHandler(this.MoveButtonLeftClick);
            // 
            // _moveButtonRight
            // 
            this._moveButtonRight.Location = new System.Drawing.Point(758, 408);
            this._moveButtonRight.Name = "_moveButtonRight";
            this._moveButtonRight.Size = new System.Drawing.Size(30, 30);
            this._moveButtonRight.TabIndex = 3;
            this._moveButtonRight.Text = "→ ";
            this._moveButtonRight.UseVisualStyleBackColor = true;
            this._moveButtonRight.Click += new System.EventHandler(this.MoveButtonRightClick);
            // 
            // _pictureBox
            // 
            this._pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._pictureBox.Location = new System.Drawing.Point(12, 12);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(534, 426);
            this._pictureBox.TabIndex = 4;
            this._pictureBox.TabStop = false;
            this._pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseDown);
            this._pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseUp);
            // 
            // _objectListBox
            // 
            this._objectListBox.FormattingEnabled = true;
            this._objectListBox.ItemHeight = 15;
            this._objectListBox.Location = new System.Drawing.Point(668, 23);
            this._objectListBox.Name = "_objectListBox";
            this._objectListBox.Size = new System.Drawing.Size(120, 334);
            this._objectListBox.TabIndex = 5;
            // 
            // _timer
            // 
            this._timer.Interval = 1;
            this._timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // N3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._objectListBox);
            this.Controls.Add(this._pictureBox);
            this.Controls.Add(this._moveButtonRight);
            this.Controls.Add(this._moveButtonLeft);
            this.Controls.Add(this._moveButtonUp);
            this.Controls.Add(this._moveButtonDown);
            this.Name = "N3";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button _moveButtonDown;
        private Button _moveButtonUp;
        private Button _moveButtonLeft;
        private Button _moveButtonRight;
        private PictureBox _pictureBox;
        private ListBox _objectListBox;
        private System.Windows.Forms.Timer _timer;
    }
}