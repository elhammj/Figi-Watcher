namespace SmartRefri
{
    partial class ShowItem
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.expireLabel = new System.Windows.Forms.Label();
            this.alarmPictureBox = new System.Windows.Forms.PictureBox();
            this.itemPictureBox = new System.Windows.Forms.PictureBox();
            this.itemToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alarmPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.nameLabel.Location = new System.Drawing.Point(61, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label1";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.typeLabel.Location = new System.Drawing.Point(61, 13);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(41, 13);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "label2";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.BackColor = System.Drawing.Color.Transparent;
            this.codeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.ForeColor = System.Drawing.Color.Blue;
            this.codeLabel.Location = new System.Drawing.Point(61, 26);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(35, 13);
            this.codeLabel.TabIndex = 3;
            this.codeLabel.Text = "label3";
            // 
            // expireLabel
            // 
            this.expireLabel.AutoSize = true;
            this.expireLabel.BackColor = System.Drawing.Color.Transparent;
            this.expireLabel.Font = new System.Drawing.Font("Tahoma", 7F);
            this.expireLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.expireLabel.Location = new System.Drawing.Point(62, 40);
            this.expireLabel.Name = "expireLabel";
            this.expireLabel.Size = new System.Drawing.Size(0, 12);
            this.expireLabel.TabIndex = 5;
            // 
            // alarmPictureBox
            // 
            this.alarmPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.alarmPictureBox.Location = new System.Drawing.Point(176, 16);
            this.alarmPictureBox.Name = "alarmPictureBox";
            this.alarmPictureBox.Size = new System.Drawing.Size(12, 12);
            this.alarmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alarmPictureBox.TabIndex = 4;
            this.alarmPictureBox.TabStop = false;
            this.alarmPictureBox.Visible = false;
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.itemPictureBox.Location = new System.Drawing.Point(5, 8);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.Size = new System.Drawing.Size(53, 48);
            this.itemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPictureBox.TabIndex = 0;
            this.itemPictureBox.TabStop = false;
            // 
            // itemToolTip
            // 
            this.itemToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.itemToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.itemToolTip_Popup);
            // 
            // ShowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.expireLabel);
            this.Controls.Add(this.alarmPictureBox);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.itemPictureBox);
            this.Name = "ShowItem";
            this.Size = new System.Drawing.Size(200, 64);
            ((System.ComponentModel.ISupportInitialize)(this.alarmPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox itemPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.PictureBox alarmPictureBox;
        private System.Windows.Forms.Label expireLabel;
        private System.Windows.Forms.ToolTip itemToolTip;
    }
}
