namespace ATM.Login
{
    partial class frmLogin
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
            this.lblPin = new ReaLTaiizor.Controls.MaterialLabel();
            this.txtPin = new ReaLTaiizor.Controls.MaterialTextBox();
            this.btnSubmit = new ReaLTaiizor.Controls.MaterialButton();
            this.lblWelcome = new ReaLTaiizor.Controls.MaterialLabel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.materialCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.lblPin);
            this.materialCard.Controls.Add(this.txtPin);
            this.materialCard.Controls.Add(this.btnSubmit);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(16, 122);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(360, 200);
            this.materialCard.TabIndex = 2;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Depth = 0;
            this.lblPin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPin.Location = new System.Drawing.Point(20, 30);
            this.lblPin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(70, 19);
            this.lblPin.TabIndex = 0;
            this.lblPin.Text = "Enter PIN:";
            // 
            // txtPin
            // 
            this.txtPin.AnimateReadOnly = false;
            this.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPin.Depth = 0;
            this.txtPin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPin.Hint = "4-digit PIN";
            this.txtPin.LeadingIcon = null;
            this.txtPin.Location = new System.Drawing.Point(20, 60);
            this.txtPin.MaxLength = 4;
            this.txtPin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPin.Multiline = false;
            this.txtPin.Name = "txtPin";
            this.txtPin.Password = true;
            this.txtPin.Size = new System.Drawing.Size(320, 50);
            this.txtPin.TabIndex = 0;
            this.txtPin.Text = "";
            this.txtPin.TrailingIcon = null;
            this.txtPin.UseAccent = false;
            this.txtPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPin_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = false;
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.HighEmphasis = true;
            this.btnSubmit.Icon = null;
            this.btnSubmit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSubmit.Location = new System.Drawing.Point(20, 119);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubmit.Size = new System.Drawing.Size(320, 50);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSubmit.UseAccentColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.Location = new System.Drawing.Point(13, 52);
            this.lblWelcome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(79, 19);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "ATM Login";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ATM.Properties.Resources.LoginScreenLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(136, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 336);
            this.Controls.Add(this.materialCard);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "frmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM System - Login";
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard;
        private ReaLTaiizor.Controls.MaterialLabel lblPin;
        private ReaLTaiizor.Controls.MaterialTextBox txtPin;
        private ReaLTaiizor.Controls.MaterialButton btnSubmit;
        private ReaLTaiizor.Controls.MaterialLabel lblWelcome;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}