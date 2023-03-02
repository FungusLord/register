namespace PayCalculator
{
    partial class main
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
            this.title = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.preTaxOut = new System.Windows.Forms.Label();
            this.preTaxLabel = new System.Windows.Forms.Label();
            this.afterTaxOut = new System.Windows.Forms.Label();
            this.afterTaxLabel = new System.Windows.Forms.Label();
            this.hoursIn = new System.Windows.Forms.TextBox();
            this.payIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.LimeGreen;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(584, 50);
            this.title.TabIndex = 0;
            this.title.Text = "Pay Calculator";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // hoursLabel
            // 
            this.hoursLabel.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(178, 86);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(126, 45);
            this.hoursLabel.TabIndex = 3;
            this.hoursLabel.Text = "Hours Worked:";
            this.hoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hoursLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // payLabel
            // 
            this.payLabel.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payLabel.Location = new System.Drawing.Point(177, 137);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(126, 45);
            this.payLabel.TabIndex = 5;
            this.payLabel.Text = "Pay Rate:";
            this.payLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.payLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.LimeGreen;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(226, 201);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(150, 75);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.UseWaitCursor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // preTaxOut
            // 
            this.preTaxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTaxOut.Location = new System.Drawing.Point(305, 278);
            this.preTaxOut.Name = "preTaxOut";
            this.preTaxOut.Size = new System.Drawing.Size(105, 32);
            this.preTaxOut.TabIndex = 8;
            this.preTaxOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.preTaxOut.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // preTaxLabel
            // 
            this.preTaxLabel.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTaxLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.preTaxLabel.Location = new System.Drawing.Point(184, 278);
            this.preTaxLabel.Name = "preTaxLabel";
            this.preTaxLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.preTaxLabel.Size = new System.Drawing.Size(120, 32);
            this.preTaxLabel.TabIndex = 9;
            this.preTaxLabel.Text = "Pre Tax:";
            this.preTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.preTaxLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // afterTaxOut
            // 
            this.afterTaxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterTaxOut.Location = new System.Drawing.Point(304, 310);
            this.afterTaxOut.Name = "afterTaxOut";
            this.afterTaxOut.Size = new System.Drawing.Size(105, 32);
            this.afterTaxOut.TabIndex = 10;
            this.afterTaxOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.afterTaxOut.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // afterTaxLabel
            // 
            this.afterTaxLabel.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterTaxLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.afterTaxLabel.Location = new System.Drawing.Point(185, 310);
            this.afterTaxLabel.Name = "afterTaxLabel";
            this.afterTaxLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.afterTaxLabel.Size = new System.Drawing.Size(120, 32);
            this.afterTaxLabel.TabIndex = 11;
            this.afterTaxLabel.Text = "After Tax:";
            this.afterTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.afterTaxLabel.Click += new System.EventHandler(this.afterTaxLabel_Click);
            // 
            // hoursIn
            // 
            this.hoursIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursIn.Location = new System.Drawing.Point(309, 93);
            this.hoursIn.Name = "hoursIn";
            this.hoursIn.Size = new System.Drawing.Size(100, 35);
            this.hoursIn.TabIndex = 12;
            // 
            // payIn
            // 
            this.payIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payIn.Location = new System.Drawing.Point(309, 144);
            this.payIn.Name = "payIn";
            this.payIn.Size = new System.Drawing.Size(100, 35);
            this.payIn.TabIndex = 13;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.payIn);
            this.Controls.Add(this.hoursIn);
            this.Controls.Add(this.afterTaxLabel);
            this.Controls.Add(this.afterTaxOut);
            this.Controls.Add(this.preTaxLabel);
            this.Controls.Add(this.preTaxOut);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.title);
            this.Name = "main";
            this.Text = "Pay Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label preTaxOut;
        private System.Windows.Forms.Label preTaxLabel;
        private System.Windows.Forms.Label afterTaxOut;
        private System.Windows.Forms.Label afterTaxLabel;
        private System.Windows.Forms.TextBox hoursIn;
        private System.Windows.Forms.TextBox payIn;
    }
}

