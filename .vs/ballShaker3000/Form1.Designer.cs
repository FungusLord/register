namespace ballShaker3000
{
    partial class BallShaker3000
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BallShaker3000));
            this.shakeButton = new System.Windows.Forms.Button();
            this.outLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shakeButton
            // 
            this.shakeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shakeButton.BackgroundImage")));
            this.shakeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shakeButton.FlatAppearance.BorderSize = 0;
            this.shakeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shakeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shakeButton.Location = new System.Drawing.Point(12, 99);
            this.shakeButton.Name = "shakeButton";
            this.shakeButton.Size = new System.Drawing.Size(420, 300);
            this.shakeButton.TabIndex = 0;
            this.shakeButton.UseVisualStyleBackColor = true;
            this.shakeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outLabel
            // 
            this.outLabel.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLabel.Location = new System.Drawing.Point(12, 402);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(420, 33);
            this.outLabel.TabIndex = 1;
            this.outLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outLabel.Click += new System.EventHandler(this.outLabel_Click);
            // 
            // promptLabel
            // 
            this.promptLabel.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(12, 9);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(420, 87);
            this.promptLabel.TabIndex = 2;
            this.promptLabel.Text = "Ask a question, click the ball, read the answer.";
            this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BallShaker3000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(444, 444);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.shakeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BallShaker3000";
            this.Text = "Ball Shaker 3000";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shakeButton;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Label promptLabel;
    }
}

