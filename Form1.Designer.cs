namespace ScaleBot
{
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.cbxScale = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(279, 95);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(69, 15);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Instructions";
            // 
            // cbxScale
            // 
            this.cbxScale.FormattingEnabled = true;
            this.cbxScale.Items.AddRange(new object[] {
            "D Major",
            "C Major"});
            this.cbxScale.Location = new System.Drawing.Point(279, 156);
            this.cbxScale.MaxDropDownItems = 2;
            this.cbxScale.Name = "cbxScale";
            this.cbxScale.Size = new System.Drawing.Size(121, 23);
            this.cbxScale.TabIndex = 1;
            this.cbxScale.Text = "Select a Scale";
            this.cbxScale.SelectedIndexChanged += new System.EventHandler(this.cbxScale_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(279, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Recording";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(433, 226);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop Recording";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbxScale);
            this.Controls.Add(this.lblInstructions);
            this.Name = "Form1";
            this.Text = "ScaleBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInstructions;
        private ComboBox cbxScale;
        private Button btnStart;
        private Button btnStop;
    }
}