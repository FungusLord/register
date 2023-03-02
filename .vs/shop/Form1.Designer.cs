namespace shop
{
    partial class ItemShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemShop));
            this.logo = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.crateImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.crateLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.hatLabel = new System.Windows.Forms.Label();
            this.crateIn = new System.Windows.Forms.TextBox();
            this.keyIn = new System.Windows.Forms.TextBox();
            this.hatIn = new System.Windows.Forms.TextBox();
            this.calculateTotal = new System.Windows.Forms.Button();
            this.taxRateLabel = new System.Windows.Forms.Label();
            this.preTaxLabel = new System.Windows.Forms.Label();
            this.postTaxLabel = new System.Windows.Forms.Label();
            this.payIn = new System.Windows.Forms.TextBox();
            this.payInLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.receipt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crateImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(56, 56);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(74, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(338, 56);
            this.title.TabIndex = 0;
            this.title.Text = "Mann Co. Item Shop";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // crateImage
            // 
            this.crateImage.Image = ((System.Drawing.Image)(resources.GetObject("crateImage.Image")));
            this.crateImage.Location = new System.Drawing.Point(12, 105);
            this.crateImage.Name = "crateImage";
            this.crateImage.Size = new System.Drawing.Size(56, 56);
            this.crateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crateImage.TabIndex = 1;
            this.crateImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // crateLabel
            // 
            this.crateLabel.AutoSize = true;
            this.crateLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateLabel.Location = new System.Drawing.Point(8, 83);
            this.crateLabel.Name = "crateLabel";
            this.crateLabel.Size = new System.Drawing.Size(108, 19);
            this.crateLabel.TabIndex = 4;
            this.crateLabel.Text = "Crate: $3.00";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.Location = new System.Drawing.Point(8, 245);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(90, 19);
            this.keyLabel.TabIndex = 5;
            this.keyLabel.Text = "Key: $5.00";
            // 
            // hatLabel
            // 
            this.hatLabel.AutoSize = true;
            this.hatLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hatLabel.Location = new System.Drawing.Point(8, 164);
            this.hatLabel.Name = "hatLabel";
            this.hatLabel.Size = new System.Drawing.Size(91, 19);
            this.hatLabel.TabIndex = 6;
            this.hatLabel.Text = "Hat: $1.50";
            // 
            // crateIn
            // 
            this.crateIn.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateIn.Location = new System.Drawing.Point(74, 105);
            this.crateIn.Name = "crateIn";
            this.crateIn.Size = new System.Drawing.Size(128, 32);
            this.crateIn.TabIndex = 7;
            // 
            // keyIn
            // 
            this.keyIn.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyIn.Location = new System.Drawing.Point(74, 267);
            this.keyIn.Name = "keyIn";
            this.keyIn.Size = new System.Drawing.Size(128, 32);
            this.keyIn.TabIndex = 8;
            // 
            // hatIn
            // 
            this.hatIn.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hatIn.Location = new System.Drawing.Point(74, 186);
            this.hatIn.Name = "hatIn";
            this.hatIn.Size = new System.Drawing.Size(128, 32);
            this.hatIn.TabIndex = 9;
            // 
            // calculateTotal
            // 
            this.calculateTotal.Location = new System.Drawing.Point(12, 329);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(190, 50);
            this.calculateTotal.TabIndex = 10;
            this.calculateTotal.Text = "Calculate Total";
            this.calculateTotal.UseVisualStyleBackColor = true;
            this.calculateTotal.Click += new System.EventHandler(this.calculate_Click);
            // 
            // taxRateLabel
            // 
            this.taxRateLabel.AutoSize = true;
            this.taxRateLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxRateLabel.Location = new System.Drawing.Point(8, 401);
            this.taxRateLabel.Name = "taxRateLabel";
            this.taxRateLabel.Size = new System.Drawing.Size(122, 19);
            this.taxRateLabel.TabIndex = 11;
            this.taxRateLabel.Text = "Tax Rate: 13%";
            // 
            // preTaxLabel
            // 
            this.preTaxLabel.AutoSize = true;
            this.preTaxLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTaxLabel.Location = new System.Drawing.Point(8, 382);
            this.preTaxLabel.Name = "preTaxLabel";
            this.preTaxLabel.Size = new System.Drawing.Size(82, 19);
            this.preTaxLabel.TabIndex = 12;
            this.preTaxLabel.Text = "Pre Tax: ";
            this.preTaxLabel.Click += new System.EventHandler(this.preTaxLabel_Click);
            // 
            // postTaxLabel
            // 
            this.postTaxLabel.AutoSize = true;
            this.postTaxLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postTaxLabel.Location = new System.Drawing.Point(8, 420);
            this.postTaxLabel.Name = "postTaxLabel";
            this.postTaxLabel.Size = new System.Drawing.Size(110, 19);
            this.postTaxLabel.TabIndex = 13;
            this.postTaxLabel.Text = "After Tax: $";
            // 
            // payIn
            // 
            this.payIn.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payIn.Location = new System.Drawing.Point(12, 461);
            this.payIn.Name = "payIn";
            this.payIn.Size = new System.Drawing.Size(190, 32);
            this.payIn.TabIndex = 14;
            // 
            // payInLabel
            // 
            this.payInLabel.AutoSize = true;
            this.payInLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payInLabel.Location = new System.Drawing.Point(8, 439);
            this.payInLabel.Name = "payInLabel";
            this.payInLabel.Size = new System.Drawing.Size(132, 19);
            this.payInLabel.TabIndex = 15;
            this.payInLabel.Text = "Amount Paid: $";
            this.payInLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(8, 496);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(88, 19);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.Text = "Change: $";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(12, 518);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(190, 31);
            this.payButton.TabIndex = 17;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(208, 518);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(190, 31);
            this.printButton.TabIndex = 18;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(404, 518);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(68, 31);
            this.reset.TabIndex = 19;
            this.reset.Text = "New Order";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // receipt
            // 
            this.receipt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.receipt.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt.Location = new System.Drawing.Point(208, 83);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(264, 432);
            this.receipt.TabIndex = 20;
            this.receipt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.receipt.Visible = false;
            // 
            // ItemShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.payInLabel);
            this.Controls.Add(this.payIn);
            this.Controls.Add(this.postTaxLabel);
            this.Controls.Add(this.preTaxLabel);
            this.Controls.Add(this.taxRateLabel);
            this.Controls.Add(this.calculateTotal);
            this.Controls.Add(this.hatIn);
            this.Controls.Add(this.keyIn);
            this.Controls.Add(this.crateIn);
            this.Controls.Add(this.hatLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.crateLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crateImage);
            this.Controls.Add(this.title);
            this.Controls.Add(this.logo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ItemShop";
            this.Text = "Mann Co. Item Shop";
            this.Load += new System.EventHandler(this.ItemShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crateImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox crateImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label crateLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label hatLabel;
        private System.Windows.Forms.TextBox crateIn;
        private System.Windows.Forms.TextBox keyIn;
        private System.Windows.Forms.TextBox hatIn;
        private System.Windows.Forms.Button calculateTotal;
        private System.Windows.Forms.Label taxRateLabel;
        private System.Windows.Forms.Label preTaxLabel;
        private System.Windows.Forms.Label postTaxLabel;
        private System.Windows.Forms.TextBox payIn;
        private System.Windows.Forms.Label payInLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label receipt;
    }
}

