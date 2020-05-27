using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform2705
{
    public partial class DemoForm : Form
    {
        int counter = 1;

        public DemoForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // this does NOT work   
            /*
            Task.Run(
                () =>
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Thread.Sleep(100);
                        numLbl.Text = i.ToString();
                    }
                });
                */

            // 1. create a new task (worker) which is not the UI thread
            Task.Run(
                () =>
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        // instead-
                        // ask the UI thread to draw the label...
                        // ???

                        // chinese
                        // 2. define Action
                        //    action is a set of commands 
                        Action action = () => { numLbl.Text = i.ToString(); };

                        // 3. ask for UI to perform the action on the label
                        numLbl.BeginInvoke(action);

                        Thread.Sleep(500);
                    }
                });
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            numLbl.Text = counter.ToString();

            counter++;

            // the timer can stop itself
           // if (counter >= 10)
            //    myTimer.Enabled = false;
        }

        private void DemoForm_Load(object sender, EventArgs e)
        {
            //myTimer.Enabled = true;
            //timeTimer.Enabled = true;

            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(300, 300),
                Location = new Point(100, 0),
                Image = Image.FromFile("Resources/aspnet.jpg"),

            };
            this.Controls.Add(picture);

            Label label = new Label // auto initializer
            {
                Name = "mylabel2",
                Text = "hello...",
                Location = new Point(0, 0)
            };
            this.Controls.Add(label);
        }

        private void startStopTimerBtn_Click(object sender, EventArgs e)
        {
            if (myTimer.Enabled == true)
            {
                //myTimer.Enabled = false;
                myTimer.Stop();
                startStopTimerBtn.Text = "Start the Timer";
            }
            else
            {
                //myTimer.Enabled = true;
                myTimer.Start();
                startStopTimerBtn.Text = "Stop the Timer";
            }
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.TimeOfDay.ToString();
        }
    }
}
