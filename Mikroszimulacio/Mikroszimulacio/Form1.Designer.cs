
namespace Mikroszimulacio
{
    partial class MicroSimulation
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
            this.nudYear2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.txtMain2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear2)).BeginInit();
            this.SuspendLayout();
            // 
            // nudYear2
            // 
            this.nudYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudYear2.Location = new System.Drawing.Point(92, 11);
            this.nudYear2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudYear2.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.nudYear2.Name = "nudYear2";
            this.nudYear2.Size = new System.Drawing.Size(120, 30);
            this.nudYear2.TabIndex = 0;
            this.nudYear2.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Záróév";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(231, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Népesség fájl";
            // 
            // txtPath2
            // 
            this.txtPath2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPath2.Location = new System.Drawing.Point(367, 13);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(444, 30);
            this.txtPath2.TabIndex = 2;
            this.txtPath2.Text = "C:\\Temp\\nép-teszt.csv";
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrowse2.Location = new System.Drawing.Point(849, 7);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(95, 43);
            this.btnBrowse2.TabIndex = 3;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart2.Location = new System.Drawing.Point(950, 7);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(95, 43);
            this.btnStart2.TabIndex = 3;
            this.btnStart2.Text = "Start";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // txtMain2
            // 
            this.txtMain2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMain2.Location = new System.Drawing.Point(17, 62);
            this.txtMain2.Name = "txtMain2";
            this.txtMain2.Size = new System.Drawing.Size(1032, 573);
            this.txtMain2.TabIndex = 4;
            this.txtMain2.Text = "";
            // 
            // MicroSimulation
            // 
            this.ClientSize = new System.Drawing.Size(1070, 647);
            this.Controls.Add(this.txtMain2);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudYear2);
            this.Name = "MicroSimulation";
            ((System.ComponentModel.ISupportInitialize)(this.nudYear2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox txtMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudYear2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.RichTextBox txtMain2;
    }
}

