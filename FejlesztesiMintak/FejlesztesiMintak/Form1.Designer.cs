
namespace FejlesztesiMintak
{
    partial class Form1
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnSelectPresent = new System.Windows.Forms.Button();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.btnSelectBall = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.button3);
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Controls.Add(this.btnColor);
            this.mainPanel.Controls.Add(this.lblNext);
            this.mainPanel.Controls.Add(this.btnSelectPresent);
            this.mainPanel.Controls.Add(this.btnSelectCar);
            this.mainPanel.Controls.Add(this.btnSelectBall);
            this.mainPanel.Location = new System.Drawing.Point(13, 13);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(775, 425);
            this.mainPanel.TabIndex = 0;
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(557, 46);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(97, 20);
            this.lblNext.TabIndex = 1;
            this.lblNext.Text = "Coming next";
            // 
            // btnSelectPresent
            // 
            this.btnSelectPresent.Location = new System.Drawing.Point(368, 46);
            this.btnSelectPresent.Name = "btnSelectPresent";
            this.btnSelectPresent.Size = new System.Drawing.Size(143, 59);
            this.btnSelectPresent.TabIndex = 0;
            this.btnSelectPresent.Text = "PRESENT";
            this.btnSelectPresent.UseVisualStyleBackColor = true;
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(45, 46);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(143, 59);
            this.btnSelectCar.TabIndex = 0;
            this.btnSelectCar.Text = "CAR";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // btnSelectBall
            // 
            this.btnSelectBall.Location = new System.Drawing.Point(208, 46);
            this.btnSelectBall.Name = "btnSelectBall";
            this.btnSelectBall.Size = new System.Drawing.Size(143, 59);
            this.btnSelectBall.TabIndex = 0;
            this.btnSelectBall.Text = "BALL";
            this.btnSelectBall.UseVisualStyleBackColor = true;
            this.btnSelectBall.Click += new System.EventHandler(this.btnSelectBall_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Blue;
            this.btnColor.Location = new System.Drawing.Point(208, 132);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(143, 38);
            this.btnColor.TabIndex = 2;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.CausesValidation = false;
            this.button2.Location = new System.Drawing.Point(368, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 38);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(368, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 38);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnSelectPresent;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.Button btnSelectBall;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnColor;
    }
}

