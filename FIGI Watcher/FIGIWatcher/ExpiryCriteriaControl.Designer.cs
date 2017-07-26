namespace SmartRefri
{
    partial class ExpiryCriteriaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.expiryTemperatureButton = new System.Windows.Forms.Button();
            this.expiryDateButton = new System.Windows.Forms.Button();
            this.expiryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inputLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.videoStreamingPictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoStreamingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(44, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Expiry Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(344, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expiry Temperature";
            // 
            // expiryTemperatureButton
            // 
            this.expiryTemperatureButton.BackColor = System.Drawing.Color.White;
            this.expiryTemperatureButton.BackgroundImage = global::SmartRefri.Properties.Resources.url3333;
            this.expiryTemperatureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.expiryTemperatureButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.expiryTemperatureButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expiryTemperatureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expiryTemperatureButton.ForeColor = System.Drawing.Color.Black;
            this.expiryTemperatureButton.Location = new System.Drawing.Point(340, 118);
            this.expiryTemperatureButton.Name = "expiryTemperatureButton";
            this.expiryTemperatureButton.Size = new System.Drawing.Size(130, 110);
            this.expiryTemperatureButton.TabIndex = 5;
            this.expiryTemperatureButton.Text = "Tab To Add Temperature Criteria";
            this.expiryTemperatureButton.UseVisualStyleBackColor = false;
            this.expiryTemperatureButton.Click += new System.EventHandler(this.expiryTemperatureButton_Click);
            // 
            // expiryDateButton
            // 
            this.expiryDateButton.BackColor = System.Drawing.Color.White;
            this.expiryDateButton.BackgroundImage = global::SmartRefri.Properties.Resources.imagesrr;
            this.expiryDateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.expiryDateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.expiryDateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expiryDateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expiryDateButton.ForeColor = System.Drawing.Color.Black;
            this.expiryDateButton.Location = new System.Drawing.Point(176, 118);
            this.expiryDateButton.Name = "expiryDateButton";
            this.expiryDateButton.Size = new System.Drawing.Size(130, 110);
            this.expiryDateButton.TabIndex = 6;
            this.expiryDateButton.Text = "Calculate Expiry Date";
            this.expiryDateButton.UseVisualStyleBackColor = false;
            this.expiryDateButton.Click += new System.EventHandler(this.expiryDateButton_Click);
            // 
            // expiryDateTimePicker
            // 
            this.expiryDateTimePicker.Checked = false;
            this.expiryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiryDateTimePicker.Location = new System.Drawing.Point(29, 92);
            this.expiryDateTimePicker.Name = "expiryDateTimePicker";
            this.expiryDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.expiryDateTimePicker.TabIndex = 7;
            // 
            // maxNumericUpDown
            // 
            this.maxNumericUpDown.Location = new System.Drawing.Point(340, 92);
            this.maxNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.maxNumericUpDown.Name = "maxNumericUpDown";
            this.maxNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.maxNumericUpDown.TabIndex = 8;
            this.maxNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Expiry Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(344, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(431, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Min";
            // 
            // minNumericUpDown
            // 
            this.minNumericUpDown.Location = new System.Drawing.Point(428, 92);
            this.minNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.minNumericUpDown.Name = "minNumericUpDown";
            this.minNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.minNumericUpDown.TabIndex = 11;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.White;
            this.inputLabel.Location = new System.Drawing.Point(409, 3);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(86, 13);
            this.inputLabel.TabIndex = 13;
            this.inputLabel.Text = "Tab To Continue";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(4, -24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // videoStreamingPictureBox
            // 
            this.videoStreamingPictureBox.BackColor = System.Drawing.Color.White;
            this.videoStreamingPictureBox.Image = global::SmartRefri.Properties.Resources.camera_motion_not_found;
            this.videoStreamingPictureBox.Location = new System.Drawing.Point(29, 118);
            this.videoStreamingPictureBox.Name = "videoStreamingPictureBox";
            this.videoStreamingPictureBox.Size = new System.Drawing.Size(130, 110);
            this.videoStreamingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoStreamingPictureBox.TabIndex = 18;
            this.videoStreamingPictureBox.TabStop = false;
            this.videoStreamingPictureBox.Click += new System.EventHandler(this.videoStreamingPictureBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(179, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Calculate Expiry Date";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.categoryLabel.Location = new System.Drawing.Point(179, 98);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(59, 13);
            this.categoryLabel.TabIndex = 20;
            this.categoryLabel.Text = "Category";
            // 
            // backPictureBox
            // 
            this.backPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.backPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPictureBox.Image = global::SmartRefri.Properties.Resources.arrow_left_9_20110809170243_00018;
            this.backPictureBox.Location = new System.Drawing.Point(2, 1);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(28, 19);
            this.backPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backPictureBox.TabIndex = 21;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.Click += new System.EventHandler(this.backPictureBox_Click);
            // 
            // ExpiryCriteriaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SmartRefri.Properties.Resources.clouds_abstract400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.backPictureBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.videoStreamingPictureBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxNumericUpDown);
            this.Controls.Add(this.expiryDateTimePicker);
            this.Controls.Add(this.expiryDateButton);
            this.Controls.Add(this.expiryTemperatureButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExpiryCriteriaControl";
            this.Size = new System.Drawing.Size(500, 300);
            this.Click += new System.EventHandler(this.ExpiryCriteriaControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoStreamingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button expiryTemperatureButton;
        private System.Windows.Forms.Button expiryDateButton;
        private System.Windows.Forms.DateTimePicker expiryDateTimePicker;
        private System.Windows.Forms.NumericUpDown maxNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown minNumericUpDown;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox videoStreamingPictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.PictureBox backPictureBox;
    }
}
