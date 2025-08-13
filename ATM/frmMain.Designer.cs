namespace ATM
{
    partial class frmMain
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
            this.btnBalance = new ReaLTaiizor.Controls.MaterialButton();
            this.btnWithdraw = new ReaLTaiizor.Controls.MaterialButton();
            this.btnDeposit = new ReaLTaiizor.Controls.MaterialButton();
            this.btnTransfer = new ReaLTaiizor.Controls.MaterialButton();
            this.btnLogout = new ReaLTaiizor.Controls.MaterialButton();
            this.lblWelcome = new ReaLTaiizor.Controls.MaterialLabel();
            this.pictureBoxBalance = new System.Windows.Forms.PictureBox();
            this.pictureBoxWithdraw = new System.Windows.Forms.PictureBox();
            this.pictureBoxDeposit = new System.Windows.Forms.PictureBox();
            this.pictureBoxTransfer = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.materialCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.btnBalance);
            this.materialCard.Controls.Add(this.btnWithdraw);
            this.materialCard.Controls.Add(this.btnDeposit);
            this.materialCard.Controls.Add(this.btnTransfer);
            this.materialCard.Controls.Add(this.btnLogout);
            this.materialCard.Controls.Add(this.pictureBoxBalance);
            this.materialCard.Controls.Add(this.pictureBoxWithdraw);
            this.materialCard.Controls.Add(this.pictureBoxDeposit);
            this.materialCard.Controls.Add(this.pictureBoxTransfer);
            this.materialCard.Controls.Add(this.pictureBoxLogout);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(20, 120);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(560, 260);
            this.materialCard.TabIndex = 0;
            // 
            // btnBalance
            // 
            this.btnBalance.AutoSize = false;
            this.btnBalance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBalance.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBalance.Depth = 0;
            this.btnBalance.HighEmphasis = true;
            this.btnBalance.Icon = null;
            this.btnBalance.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnBalance.Location = new System.Drawing.Point(70, 20);
            this.btnBalance.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBalance.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBalance.Size = new System.Drawing.Size(200, 50);
            this.btnBalance.TabIndex = 0;
            this.btnBalance.Text = "Balance";
            this.btnBalance.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBalance.UseAccentColor = false;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.AutoSize = false;
            this.btnWithdraw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWithdraw.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnWithdraw.Depth = 0;
            this.btnWithdraw.HighEmphasis = true;
            this.btnWithdraw.Icon = null;
            this.btnWithdraw.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnWithdraw.Location = new System.Drawing.Point(70, 90);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWithdraw.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnWithdraw.Size = new System.Drawing.Size(200, 50);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnWithdraw.UseAccentColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.AutoSize = false;
            this.btnDeposit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeposit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeposit.Depth = 0;
            this.btnDeposit.HighEmphasis = true;
            this.btnDeposit.Icon = null;
            this.btnDeposit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnDeposit.Location = new System.Drawing.Point(70, 160);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeposit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeposit.Size = new System.Drawing.Size(200, 50);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeposit.UseAccentColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.AutoSize = false;
            this.btnTransfer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTransfer.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTransfer.Depth = 0;
            this.btnTransfer.HighEmphasis = true;
            this.btnTransfer.Icon = null;
            this.btnTransfer.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnTransfer.Location = new System.Drawing.Point(342, 20);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTransfer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTransfer.Size = new System.Drawing.Size(200, 50);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTransfer.UseAccentColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.HighEmphasis = false;
            this.btnLogout.Icon = null;
            this.btnLogout.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnLogout.Location = new System.Drawing.Point(342, 90);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.Location = new System.Drawing.Point(17, 51);
            this.lblWelcome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(159, 19);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to Your ATM";
            // 
            // pictureBoxBalance
            // 
            this.pictureBoxBalance.Image = global::ATM.Properties.Resources.Balance;
            this.pictureBoxBalance.Location = new System.Drawing.Point(17, 20);
            this.pictureBoxBalance.Name = "pictureBoxBalance";
            this.pictureBoxBalance.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBalance.TabIndex = 2;
            this.pictureBoxBalance.TabStop = false;
            // 
            // pictureBoxWithdraw
            // 
            this.pictureBoxWithdraw.Image = global::ATM.Properties.Resources.Withdraw;
            this.pictureBoxWithdraw.Location = new System.Drawing.Point(17, 90);
            this.pictureBoxWithdraw.Name = "pictureBoxWithdraw";
            this.pictureBoxWithdraw.Size = new System.Drawing.Size(46, 50);
            this.pictureBoxWithdraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWithdraw.TabIndex = 3;
            this.pictureBoxWithdraw.TabStop = false;
            // 
            // pictureBoxDeposit
            // 
            this.pictureBoxDeposit.Image = global::ATM.Properties.Resources.Deposit;
            this.pictureBoxDeposit.Location = new System.Drawing.Point(17, 160);
            this.pictureBoxDeposit.Name = "pictureBoxDeposit";
            this.pictureBoxDeposit.Size = new System.Drawing.Size(46, 50);
            this.pictureBoxDeposit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDeposit.TabIndex = 4;
            this.pictureBoxDeposit.TabStop = false;
            // 
            // pictureBoxTransfer
            // 
            this.pictureBoxTransfer.Image = global::ATM.Properties.Resources.TransferMoney;
            this.pictureBoxTransfer.Location = new System.Drawing.Point(289, 20);
            this.pictureBoxTransfer.Name = "pictureBoxTransfer";
            this.pictureBoxTransfer.Size = new System.Drawing.Size(46, 50);
            this.pictureBoxTransfer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTransfer.TabIndex = 5;
            this.pictureBoxTransfer.TabStop = false;
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Image = global::ATM.Properties.Resources.Logout;
            this.pictureBoxLogout.Location = new System.Drawing.Point(289, 90);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(46, 50);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogout.TabIndex = 6;
            this.pictureBoxLogout.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ATM.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(250, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(115, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.materialCard);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM System - Main Menu";
            this.materialCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ReaLTaiizor.Controls.MaterialCard materialCard;
        private ReaLTaiizor.Controls.MaterialLabel lblWelcome;
        private ReaLTaiizor.Controls.MaterialButton btnBalance;
        private ReaLTaiizor.Controls.MaterialButton btnWithdraw;
        private ReaLTaiizor.Controls.MaterialButton btnDeposit;
        private ReaLTaiizor.Controls.MaterialButton btnTransfer;
        private ReaLTaiizor.Controls.MaterialButton btnLogout;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxBalance;
        private System.Windows.Forms.PictureBox pictureBoxWithdraw;
        private System.Windows.Forms.PictureBox pictureBoxDeposit;
        private System.Windows.Forms.PictureBox pictureBoxTransfer;
        private System.Windows.Forms.PictureBox pictureBoxLogout;

        #endregion
    }
}