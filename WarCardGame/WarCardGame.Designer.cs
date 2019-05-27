namespace WarCardGame
{
    partial class WarCardGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarCardGame));
            this.MainDeckIcon = new System.Windows.Forms.PictureBox();
            this.LeftDeckIcon = new System.Windows.Forms.PictureBox();
            this.RightDeckIcon = new System.Windows.Forms.PictureBox();
            this.DealButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.GameStateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainDeckIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDeckIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDeckIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDeckIcon
            // 
            this.MainDeckIcon.Image = ((System.Drawing.Image)(resources.GetObject("MainDeckIcon.Image")));
            this.MainDeckIcon.Location = new System.Drawing.Point(725, 149);
            this.MainDeckIcon.Name = "MainDeckIcon";
            this.MainDeckIcon.Size = new System.Drawing.Size(123, 192);
            this.MainDeckIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainDeckIcon.TabIndex = 0;
            this.MainDeckIcon.TabStop = false;
            // 
            // LeftDeckIcon
            // 
            this.LeftDeckIcon.Image = ((System.Drawing.Image)(resources.GetObject("LeftDeckIcon.Image")));
            this.LeftDeckIcon.Location = new System.Drawing.Point(29, 573);
            this.LeftDeckIcon.Name = "LeftDeckIcon";
            this.LeftDeckIcon.Size = new System.Drawing.Size(123, 192);
            this.LeftDeckIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftDeckIcon.TabIndex = 1;
            this.LeftDeckIcon.TabStop = false;
            this.LeftDeckIcon.Visible = false;
            // 
            // RightDeckIcon
            // 
            this.RightDeckIcon.Image = ((System.Drawing.Image)(resources.GetObject("RightDeckIcon.Image")));
            this.RightDeckIcon.Location = new System.Drawing.Point(1543, 573);
            this.RightDeckIcon.Name = "RightDeckIcon";
            this.RightDeckIcon.Size = new System.Drawing.Size(123, 192);
            this.RightDeckIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightDeckIcon.TabIndex = 2;
            this.RightDeckIcon.TabStop = false;
            this.RightDeckIcon.Visible = false;
            // 
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(725, 359);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(123, 23);
            this.DealButton.TabIndex = 4;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(725, 656);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(123, 23);
            this.DrawButton.TabIndex = 5;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Visible = false;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // GameStateLabel
            // 
            this.GameStateLabel.AutoSize = true;
            this.GameStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStateLabel.Location = new System.Drawing.Point(706, 476);
            this.GameStateLabel.Name = "GameStateLabel";
            this.GameStateLabel.Size = new System.Drawing.Size(181, 26);
            this.GameStateLabel.TabIndex = 6;
            this.GameStateLabel.Text = "Click Deal to play";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cards from http://acbl.mybigcommerce.com/52-playing-cards/";
            // 
            // WarCardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 777);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameStateLabel);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.DealButton);
            this.Controls.Add(this.RightDeckIcon);
            this.Controls.Add(this.LeftDeckIcon);
            this.Controls.Add(this.MainDeckIcon);
            this.Name = "WarCardGame";
            this.Text = "WarCardGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WarCardGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDeckIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDeckIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDeckIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainDeckIcon;
        private System.Windows.Forms.PictureBox LeftDeckIcon;
        private System.Windows.Forms.PictureBox RightDeckIcon;
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Label GameStateLabel;
        private System.Windows.Forms.Label label1;
    }
}

