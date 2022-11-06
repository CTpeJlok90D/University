using Timer = System.Windows.Forms.Timer;

namespace Stopwatch
{
    partial class OOPN1
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
            this._startButton = new System.Windows.Forms.Button();
            this._resetButton = new System.Windows.Forms.Button();
            this._stopButton = new System.Windows.Forms.Button();
            this._intervalCaption = new System.Windows.Forms.Label();
            this._timeCaption = new System.Windows.Forms.Label();
            this._timeTextBox = new System.Windows.Forms.TextBox();
            this._intervalTextBox = new System.Windows.Forms.NumericUpDown();
            this._timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._intervalTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _startButton
            // 
            this._startButton.Location = new System.Drawing.Point(12, 112);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(75, 23);
            this._startButton.TabIndex = 0;
            this._startButton.Text = "Старт";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this.OnStartButtonClick);
            // 
            // _resetButton
            // 
            this._resetButton.Location = new System.Drawing.Point(219, 112);
            this._resetButton.Name = "_resetButton";
            this._resetButton.Size = new System.Drawing.Size(75, 23);
            this._resetButton.TabIndex = 1;
            this._resetButton.Text = "Сброс";
            this._resetButton.UseVisualStyleBackColor = true;
            this._resetButton.Click += new System.EventHandler(this.OnResetButtonClick);
            // 
            // _stopButton
            // 
            this._stopButton.Location = new System.Drawing.Point(115, 112);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(75, 23);
            this._stopButton.TabIndex = 2;
            this._stopButton.Text = "Стоп";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this.OnStopButtonClick);
            // 
            // _intervalCaption
            // 
            this._intervalCaption.AutoSize = true;
            this._intervalCaption.Location = new System.Drawing.Point(145, 9);
            this._intervalCaption.Name = "_intervalCaption";
            this._intervalCaption.Size = new System.Drawing.Size(86, 15);
            this._intervalCaption.TabIndex = 3;
            this._intervalCaption.Text = "Интервал(сек)";
            // 
            // _timeCaption
            // 
            this._timeCaption.AutoSize = true;
            this._timeCaption.Location = new System.Drawing.Point(12, 9);
            this._timeCaption.Name = "_timeCaption";
            this._timeCaption.Size = new System.Drawing.Size(68, 15);
            this._timeCaption.TabIndex = 4;
            this._timeCaption.Text = "Вермя(сек)";
            // 
            // _timeTextBox
            // 
            this._timeTextBox.Location = new System.Drawing.Point(12, 48);
            this._timeTextBox.Name = "_timeTextBox";
            this._timeTextBox.ReadOnly = true;
            this._timeTextBox.Size = new System.Drawing.Size(100, 23);
            this._timeTextBox.TabIndex = 5;
            this._timeTextBox.Text = "0";
            // 
            // _intervalTextBox
            // 
            this._intervalTextBox.Location = new System.Drawing.Point(145, 48);
            this._intervalTextBox.Name = "_intervalTextBox";
            this._intervalTextBox.Size = new System.Drawing.Size(120, 23);
            this._intervalTextBox.TabIndex = 6;
            this._intervalTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _timer
            // 
            this._timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 169);
            this.Controls.Add(this._intervalTextBox);
            this.Controls.Add(this._timeTextBox);
            this.Controls.Add(this._timeCaption);
            this.Controls.Add(this._intervalCaption);
            this.Controls.Add(this._stopButton);
            this.Controls.Add(this._resetButton);
            this.Controls.Add(this._startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._intervalTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _startButton;
        private Button _resetButton;
        private Button _stopButton;
        private Label _intervalCaption;
        private Label _timeCaption;
        private TextBox _timeTextBox;
        private NumericUpDown _intervalTextBox;
        private Timer _timer;
    }
}