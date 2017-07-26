namespace SmartRefri
{
    partial class BarCodeImageControl
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.barcodePictureBox = new System.Windows.Forms.PictureBox();
            this.itemImagePictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.inputLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(97, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(350, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Code";
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Location = new System.Drawing.Point(293, 244);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(181, 20);
            this.itemCodeTextBox.TabIndex = 3;
            // 
            // barcodePictureBox
            // 
            this.barcodePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.barcodePictureBox.Image = global::SmartRefri.Properties.Resources.loading;
            this.barcodePictureBox.InitialImage = null;
            this.barcodePictureBox.Location = new System.Drawing.Point(293, 92);
            this.barcodePictureBox.Name = "barcodePictureBox";
            this.barcodePictureBox.Size = new System.Drawing.Size(181, 95);
            this.barcodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.barcodePictureBox.TabIndex = 4;
            this.barcodePictureBox.TabStop = false;
            this.barcodePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.barcodePictureBox_Paint);
            // 
            // itemImagePictureBox
            // 
            this.itemImagePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemImagePictureBox.Image = global::SmartRefri.Properties.Resources.loading;
            this.itemImagePictureBox.InitialImage = null;
            this.itemImagePictureBox.Location = new System.Drawing.Point(39, 17);
            this.itemImagePictureBox.Name = "itemImagePictureBox";
            this.itemImagePictureBox.Size = new System.Drawing.Size(200, 250);
            this.itemImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.itemImagePictureBox.TabIndex = 5;
            this.itemImagePictureBox.TabStop = false;
            this.itemImagePictureBox.Click += new System.EventHandler(this.itemImagePictureBox_Click);
            this.itemImagePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.itemImagePictureBox_Paint);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.White;
            this.inputLabel.Location = new System.Drawing.Point(407, 5);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(86, 13);
            this.inputLabel.TabIndex = 14;
            this.inputLabel.Text = "Tab To Continue";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jepg|BMP|*.bmp|GIF|*.gif|PNG|*.png";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(51, 313);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // backPictureBox
            // 
            this.backPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.backPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPictureBox.Image = global::SmartRefri.Properties.Resources.arrow_left_9_20110809170243_00018;
            this.backPictureBox.Location = new System.Drawing.Point(3, 2);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(28, 19);
            this.backPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backPictureBox.TabIndex = 16;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.Click += new System.EventHandler(this.backPictureBox_Click);
            // 
            // BarCodeImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SmartRefri.Properties.Resources.clouds_abstract400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.backPictureBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.itemImagePictureBox);
            this.Controls.Add(this.barcodePictureBox);
            this.Controls.Add(this.itemCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BarCodeImageControl";
            this.Size = new System.Drawing.Size(500, 300);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BarCodeImageControl_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox itemPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.PictureBox barcodePictureBox;
        private System.Windows.Forms.PictureBox itemImagePictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox backPictureBox;
    }
}
