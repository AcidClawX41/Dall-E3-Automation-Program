// A program in C# to automate the process of sending messages repeteadly to the Dall-E3 Chatbox.
// The program will send the message every 2 minutes by default, but this can be changed by modifying the interval In Minutes by the User.
// Created by Eric V. Gramunt (30/01/2024)
// This program is in constant development, so it may be updated in the future.

using System;
using System.Drawing;
using System.Windows.Forms;

public partial class DallE3AutomationProgram : Form
{
    private System.Windows.Forms.Timer messageTimer;
    private System.Windows.Forms.Timer countdownTimer;
    private Label countdownLabel;
    private DateTime nextRun;
    private string message = "Draw me more of this pics!";
    private int intervalInMinutes = 2; // Change this to the desired interval in minutes

    public DallE3AutomationProgram()
    {
        InitializeComponent();
        SetupForm();
    }

    private void SetupForm()
    {
        this.Size = new Size(350, 250);

        countdownLabel = new Label
        {
            Location = new Point(this.Width / 3, this.Height / 2), 
            Size = new Size(280, 20),
            Text = "Ready to start.",
            TextAlign = ContentAlignment.MiddleCenter 
        };
        this.Controls.Add(countdownLabel);

        messageTimer = new System.Windows.Forms.Timer
        {
            Interval = (int)TimeSpan.FromMinutes(intervalInMinutes).TotalMilliseconds
        };
        messageTimer.Tick += (sender, args) => SendMessage();

        countdownTimer = new System.Windows.Forms.Timer
        {
            Interval = 1000 
        };
        countdownTimer.Tick += (sender, args) => UpdateCountdown();

        nextRun = DateTime.Now.AddMinutes(intervalInMinutes); 
    }

    private void startButton_Click(object sender, EventArgs e)
    {
        nextRun = DateTime.Now.AddMinutes(intervalInMinutes);
        messageTimer.Start();
        countdownTimer.Start();
        startButton.Enabled = false;
        stopButton.Enabled = true;
        UpdateCountdown(); 
    }

    private void stopButton_Click(object sender, EventArgs e)
    {
        messageTimer.Stop();
        countdownTimer.Stop();
        startButton.Enabled = true;
        stopButton.Enabled = false;
        countdownLabel.Text = "Stopped";
    }

    private void SendMessage()
    {
        Clipboard.SetText(message);
        SendKeys.SendWait("^v");
        Thread.Sleep(200); 
        SendKeys.SendWait("{ENTER}");
        nextRun = DateTime.Now.AddMinutes(intervalInMinutes); 
    }

    private void UpdateCountdown()
    {
        TimeSpan timeLeft = nextRun - DateTime.Now;
        if (timeLeft.TotalMilliseconds > 0)
        {
            countdownLabel.Text = $"Next run in: {timeLeft.ToString(@"mm\:ss")}";
        }
        else
        {
            countdownLabel.Text = "Running...";
            nextRun = DateTime.Now.AddMinutes(intervalInMinutes); 
        }
    }
}