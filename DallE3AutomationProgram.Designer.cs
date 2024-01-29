partial class DallE3AutomationProgram
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.Button stopButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.startButton = new System.Windows.Forms.Button();
        this.stopButton = new System.Windows.Forms.Button();
        this.SuspendLayout();

        //
        // startButton
        //
        this.startButton.Location = new System.Drawing.Point(10, 10);
        this.startButton.Name = "startButton";
        this.startButton.Size = new System.Drawing.Size(75, 23);
        this.startButton.TabIndex = 0;
        this.startButton.Text = "Start";
        this.startButton.UseVisualStyleBackColor = true;
        this.startButton.Click += new System.EventHandler(this.startButton_Click);

        //
        // stopButton
        //
        this.stopButton.Location = new System.Drawing.Point(10, 40);
        this.stopButton.Name = "stopButton";
        this.stopButton.Size = new System.Drawing.Size(75, 23);
        this.stopButton.TabIndex = 1;
        this.stopButton.Text = "Stop";
        this.stopButton.UseVisualStyleBackColor = true;
        this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
        this.stopButton.Enabled = false;

        //
        // MainForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(256, 180);
        this.Controls.Add(this.stopButton);
        this.Controls.Add(this.startButton);
        this.Name = "MainForm";
        this.Text = "Dall·E3 Automation Program";
        this.ResumeLayout(false);
    }
}