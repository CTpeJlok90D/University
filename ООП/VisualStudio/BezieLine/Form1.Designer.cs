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
            this.components = new System.ComponentModel.Container();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.coefficientLabel = new System.Windows.Forms.Label();
            this._coefficientTextBox = new System.Windows.Forms.TextBox();
            this._debug = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // _pictureBox
            // 
            this._pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBox.Location = new System.Drawing.Point(0, 0);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(955, 450);
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            this._pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseDown);
            this._pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseUp);
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            this._timer.Interval = 10;
            this._timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.coefficientLabel);
            this.panel1.Controls.Add(this._coefficientTextBox);
            this.panel1.Controls.Add(this._debug);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(749, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 450);
            this.panel1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 56);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBarOnScroll);
            // 
            // coefficientLabel
            // 
            this.coefficientLabel.AutoSize = true;
            this.coefficientLabel.Location = new System.Drawing.Point(3, 9);
            this.coefficientLabel.Name = "coefficientLabel";
            this.coefficientLabel.Size = new System.Drawing.Size(65, 15);
            this.coefficientLabel.TabIndex = 2;
            this.coefficientLabel.Text = "Coefficient";
            // 
            // _coefficientTextBox
            // 
            this._coefficientTextBox.Location = new System.Drawing.Point(3, 27);
            this._coefficientTextBox.Name = "_coefficientTextBox";
            this._coefficientTextBox.ReadOnly = true;
            this._coefficientTextBox.Size = new System.Drawing.Size(100, 23);
            this._coefficientTextBox.TabIndex = 1;
            this._coefficientTextBox.Text = "0,5";
            // 
            // _debug
            // 
            this._debug.AutoSize = true;
            this._debug.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this._debug.Location = new System.Drawing.Point(109, 12);
            this._debug.Name = "_debug";
            this._debug.Size = new System.Drawing.Size(46, 33);
            this._debug.TabIndex = 0;
            this._debug.Text = "Debug";
            this._debug.UseVisualStyleBackColor = true;
            this._debug.CheckedChanged += new System.EventHandler(this.DebugOnCheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private PictureBox _pictureBox;
    private System.Windows.Forms.Timer _timer;
    private Panel panel1;
    private TextBox _coefficientTextBox;
    private CheckBox _debug;
    private Label coefficientLabel;
    private TrackBar trackBar1;
}