namespace ATM
{
    partial class frmBalance
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
            this.materialCard = new ReaLTaiizor.Controls.MaterialCard();
            this.lblAccountNumber = new ReaLTaiizor.Controls.MaterialLabel();
            this.lblAccountIdValue = new ReaLTaiizor.Controls.MaterialLabel();
            this.lblBalance = new ReaLTaiizor.Controls.MaterialLabel();
            this.lblBalanceValue = new ReaLTaiizor.Controls.MaterialLabel();
            this.btnBack = new ReaLTaiizor.Controls.MaterialButton();
            this.lblWelcome = new ReaLTaiizor.Controls.MaterialLabel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.materialCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.lblAccountNumber);
            this.materialCard.Controls.Add(this.lblAccountIdValue);
            this.materialCard.Controls.Add(this.lblBalance);
            this.materialCard.Controls.Add(this.lblBalanceValue);
            this.materialCard.Controls.Add(this.btnBack);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(20, 120);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(360, 240);
            this.materialCard.TabIndex = 0;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Depth = 0;
            this.lblAccountNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAccountNumber.Location = new System.Drawing.Point(20, 30);
            this.lblAccountNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(123, 19);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblAccountIdValue
            // 
            this.lblAccountIdValue.AutoSize = true;
            this.lblAccountIdValue.Depth = 0;
            this.lblAccountIdValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAccountIdValue.Location = new System.Drawing.Point(150, 30);
            this.lblAccountIdValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblAccountIdValue.Name = "lblAccountIdValue";
            this.lblAccountIdValue.Size = new System.Drawing.Size(1, 0);
            this.lblAccountIdValue.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Depth = 0;
            this.lblBalance.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBalance.Location = new System.Drawing.Point(20, 70);
            this.lblBalance.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(62, 19);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance:";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Depth = 0;
            this.lblBalanceValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBalanceValue.Location = new System.Drawing.Point(150, 70);
            this.lblBalanceValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(1, 0);
            this.lblBalanceValue.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnBack.Location = new System.Drawing.Point(20, 180);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(320, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.Location = new System.Drawing.Point(17, 57);
            this.lblWelcome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(120, 19);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Account Balance";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ATM.Properties.Resources.Balance;
            this.pictureBoxLogo.Location = new System.Drawing.Point(153, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // frmBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 390);
            this.Controls.Add(this.materialCard);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBalance";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM System - Balance";
            this.Load += new System.EventHandler(this.frmBalance_Load);
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ReaLTaiizor.Controls.MaterialCard materialCard;
        private ReaLTaiizor.Controls.MaterialLabel lblAccountNumber;
        private ReaLTaiizor.Controls.MaterialLabel lblAccountIdValue;
        private ReaLTaiizor.Controls.MaterialLabel lblBalance;
        private ReaLTaiizor.Controls.MaterialLabel lblBalanceValue;
        private ReaLTaiizor.Controls.MaterialButton btnBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private ReaLTaiizor.Controls.MaterialLabel lblWelcome;
        #endregion
    }
}