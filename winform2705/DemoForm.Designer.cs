namespace winform2705
{
    partial class DemoForm
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
            this.components = new System.ComponentModel.Container();
            this.numLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.startStopTimerBtn = new System.Windows.Forms.Button();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numLbl
            // 
            this.numLbl.AutoSize = true;
            this.numLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numLbl.Location = new System.Drawing.Point(179, 81);
            this.numLbl.Name = "numLbl";
            this.numLbl.Size = new System.Drawing.Size(30, 31);
            this.numLbl.TabIndex = 0;
            this.numLbl.Text = "0";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(99, 151);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(175, 34);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start using task run";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // startStopTimerBtn
            // 
            this.startStopTimerBtn.Location = new System.Drawing.Point(99, 215);
            this.startStopTimerBtn.Name = "startStopTimerBtn";
            this.startStopTimerBtn.Size = new System.Drawing.Size(175, 36);
            this.startStopTimerBtn.TabIndex = 2;
            this.startStopTimerBtn.Text = "Start using Timer";
            this.startStopTimerBtn.UseVisualStyleBackColor = true;
            this.startStopTimerBtn.Click += new System.EventHandler(this.startStopTimerBtn_Click);
            // 
            // timeTimer
            // 
            this.timeTimer.Interval = 10;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timeLbl.Location = new System.Drawing.Point(108, 32);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(30, 31);
            this.timeLbl.TabIndex = 3;
            this.timeLbl.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winform2705.Properties.Resources.aspnet;
            this.pictureBox1.Location = new System.Drawing.Point(0, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 132);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 324);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.startStopTimerBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.numLbl);
            this.Name = "DemoForm";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.DemoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Button startStopTimerBtn;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

