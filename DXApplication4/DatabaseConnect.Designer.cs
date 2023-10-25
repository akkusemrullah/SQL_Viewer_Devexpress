
namespace DXApplication4
{
    partial class DatabaseConnect
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.serverTypeCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.serverNameCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.authenticationCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.userNameCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.passwordText = new DevExpress.XtraEditors.TextEdit();
            this.connectBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.helpBtn = new DevExpress.XtraEditors.SimpleButton();
            this.optionsBtn = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.serverTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverNameCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticationCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(174, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(297, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CONNECT TO DATABASE";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(91, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Server Name:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(78, 159);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(114, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Authentication:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(104, 197);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 21);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "User Name:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(115, 234);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 21);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Password:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(98, 85);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(94, 21);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Server Type:";
            // 
            // serverTypeCombo
            // 
            this.serverTypeCombo.EditValue = "Database Engine";
            this.serverTypeCombo.Location = new System.Drawing.Point(198, 82);
            this.serverTypeCombo.Name = "serverTypeCombo";
            this.serverTypeCombo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serverTypeCombo.Properties.Appearance.Options.UseFont = true;
            this.serverTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.serverTypeCombo.Properties.Items.AddRange(new object[] {
            "Database Engine"});
            this.serverTypeCombo.Size = new System.Drawing.Size(369, 28);
            this.serverTypeCombo.TabIndex = 6;
            // 
            // serverNameCombo
            // 
            this.serverNameCombo.Location = new System.Drawing.Point(198, 118);
            this.serverNameCombo.Name = "serverNameCombo";
            this.serverNameCombo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serverNameCombo.Properties.Appearance.Options.UseFont = true;
            this.serverNameCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.serverNameCombo.Size = new System.Drawing.Size(369, 28);
            this.serverNameCombo.TabIndex = 7;
            // 
            // authenticationCombo
            // 
            this.authenticationCombo.EditValue = "Windows Authentication";
            this.authenticationCombo.Location = new System.Drawing.Point(198, 156);
            this.authenticationCombo.Name = "authenticationCombo";
            this.authenticationCombo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authenticationCombo.Properties.Appearance.Options.UseFont = true;
            this.authenticationCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.authenticationCombo.Properties.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.authenticationCombo.Size = new System.Drawing.Size(369, 28);
            this.authenticationCombo.TabIndex = 8;
            this.authenticationCombo.SelectedIndexChanged += new System.EventHandler(this.authenticationCombo_SelectedIndexChanged);
            // 
            // userNameCombo
            // 
            this.userNameCombo.Enabled = false;
            this.userNameCombo.Location = new System.Drawing.Point(198, 194);
            this.userNameCombo.Name = "userNameCombo";
            this.userNameCombo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameCombo.Properties.Appearance.Options.UseFont = true;
            this.userNameCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.userNameCombo.Size = new System.Drawing.Size(369, 28);
            this.userNameCombo.TabIndex = 9;
            // 
            // passwordText
            // 
            this.passwordText.Enabled = false;
            this.passwordText.Location = new System.Drawing.Point(198, 231);
            this.passwordText.Name = "passwordText";
            this.passwordText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordText.Properties.Appearance.Options.UseFont = true;
            this.passwordText.Size = new System.Drawing.Size(369, 28);
            this.passwordText.TabIndex = 10;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(83, 294);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(115, 29);
            this.connectBtn.TabIndex = 11;
            this.connectBtn.Text = "Connect";
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(204, 294);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(115, 29);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(325, 294);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(115, 29);
            this.helpBtn.TabIndex = 13;
            this.helpBtn.Text = "Help";
            // 
            // optionsBtn
            // 
            this.optionsBtn.Location = new System.Drawing.Point(446, 294);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(115, 29);
            this.optionsBtn.TabIndex = 14;
            this.optionsBtn.Text = "Options >>";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 265);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(620, 23);
            this.separatorControl1.TabIndex = 15;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Location = new System.Drawing.Point(12, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(619, 10);
            this.panelControl1.TabIndex = 16;
            // 
            // DatabaseConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 356);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.userNameCombo);
            this.Controls.Add(this.authenticationCombo);
            this.Controls.Add(this.serverNameCombo);
            this.Controls.Add(this.serverTypeCombo);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.passwordText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DatabaseConnect";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONNECT TO DATABASE";
            this.Load += new System.EventHandler(this.DatabaseConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serverTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverNameCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticationCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit serverTypeCombo;
        private DevExpress.XtraEditors.ComboBoxEdit serverNameCombo;
        private DevExpress.XtraEditors.ComboBoxEdit authenticationCombo;
        private DevExpress.XtraEditors.ComboBoxEdit userNameCombo;
        private DevExpress.XtraEditors.TextEdit passwordText;
        private DevExpress.XtraEditors.SimpleButton connectBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton helpBtn;
        private DevExpress.XtraEditors.SimpleButton optionsBtn;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}