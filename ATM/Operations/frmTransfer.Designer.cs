namespace ATM
{
    partial class frmTransfer
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
            this.txtSendTo = new ReaLTaiizor.Controls.MaterialTextBox();
            this.lblAmount = new ReaLTaiizor.Controls.MaterialLabel();
            this.txtAmount = new ReaLTaiizor.Controls.MaterialTextBox();
            this.btnSend = new ReaLTaiizor.Controls.MaterialButton();
            this.btnBack = new ReaLTaiizor.Controls.MaterialButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.txtSendTo);
            this.materialCard.Controls.Add(this.lblAmount);
            this.materialCard.Controls.Add(this.txtAmount);
            this.materialCard.Controls.Add(this.btnSend);
            this.materialCard.Controls.Add(this.btnBack);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(21, 122);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(360, 307);
            this.materialCard.TabIndex = 6;
            // 
            // txtSendTo
            // 
            this.txtSendTo.AnimateReadOnly = false;
            this.txtSendTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSendTo.Depth = 0;
            this.txtSendTo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSendTo.Hint = "To";
            this.txtSendTo.LeadingIcon = null;
            this.txtSendTo.Location = new System.Drawing.Point(20, 65);
            this.txtSendTo.MaxLength = 4;
            this.txtSendTo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSendTo.Multiline = false;
            this.txtSendTo.Name = "txtSendTo";
            this.txtSendTo.Size = new System.Drawing.Size(320, 50);
            this.txtSendTo.TabIndex = 0;
            this.txtSendTo.Text = "";
            this.txtSendTo.TrailingIcon = null;
            this.txtSendTo.UseAccent = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Depth = 0;
            this.lblAmount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAmount.Location = new System.Drawing.Point(20, 30);
            this.lblAmount.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(61, 19);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.AnimateReadOnly = false;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Depth = 0;
            this.txtAmount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.Hint = "Amount";
            this.txtAmount.LeadingIcon = null;
            this.txtAmount.Location = new System.Drawing.Point(20, 121);
            this.txtAmount.MaxLength = 8;
            this.txtAmount.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(320, 50);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Text = "";
            this.txtAmount.TrailingIcon = null;
            this.txtAmount.UseAccent = false;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = false;
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSend.Depth = 0;
            this.btnSend.HighEmphasis = true;
            this.btnSend.Icon = null;
            this.btnSend.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSend.Location = new System.Drawing.Point(20, 180);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSend.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSend.Size = new System.Drawing.Size(320, 50);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSend.UseAccentColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = false;
            this.btnBack.Icon = null;
            this.btnBack.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnBack.Location = new System.Drawing.Point(20, 237);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(320, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ATM.Properties.Resources.TransferMoney;
            this.pictureBoxLogo.Location = new System.Drawing.Point(141, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.Location = new System.Drawing.Point(19, 55);
            this.lblWelcome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(109, 19);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Transfer Funds";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 443);
            this.Controls.Add(this.materialCard);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblWelcome);
            this.MaximizeBox = false;
            this.Name = "frmTransfer";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM System - Transfer";
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard;
        private ReaLTaiizor.Controls.MaterialLabel lblAmount;
        private ReaLTaiizor.Controls.MaterialTextBox txtAmount;
        private ReaLTaiizor.Controls.MaterialButton btnSend;
        private ReaLTaiizor.Controls.MaterialButton btnBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private ReaLTaiizor.Controls.MaterialLabel lblWelcome;
        private ReaLTaiizor.Controls.MaterialTextBox txtSendTo;
    }
}