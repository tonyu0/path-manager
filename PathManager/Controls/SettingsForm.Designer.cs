namespace PathManager.Controls
{
    partial class SettingsForm
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
            SettingsOKButton = new Button();
            SettingsCancelButton = new Button();
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            label1 = new Label();
            AppTitleNameTextBox = new TextBox();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsOKButton
            // 
            SettingsOKButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SettingsOKButton.DialogResult = DialogResult.OK;
            SettingsOKButton.Location = new Point(116, 226);
            SettingsOKButton.Name = "SettingsOKButton";
            SettingsOKButton.Size = new Size(75, 23);
            SettingsOKButton.TabIndex = 0;
            SettingsOKButton.Text = "OK";
            SettingsOKButton.UseVisualStyleBackColor = true;
            // 
            // SettingsCancelButton
            // 
            SettingsCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SettingsCancelButton.DialogResult = DialogResult.Cancel;
            SettingsCancelButton.Location = new Point(197, 226);
            SettingsCancelButton.Name = "SettingsCancelButton";
            SettingsCancelButton.Size = new Size(75, 23);
            SettingsCancelButton.TabIndex = 1;
            SettingsCancelButton.Text = "Cancel";
            SettingsCancelButton.UseVisualStyleBackColor = true;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Location = new Point(12, 12);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(260, 208);
            TabControl1.TabIndex = 2;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(label1);
            TabPage1.Controls.Add(AppTitleNameTextBox);
            TabPage1.Location = new Point(4, 24);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(252, 180);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Setting1";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "App Title Name ";
            // 
            // AppTitleNameTextBox
            // 
            AppTitleNameTextBox.Location = new Point(6, 21);
            AppTitleNameTextBox.Name = "AppTitleNameTextBox";
            AppTitleNameTextBox.Size = new Size(169, 23);
            AppTitleNameTextBox.TabIndex = 0;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(TabControl1);
            Controls.Add(SettingsCancelButton);
            Controls.Add(SettingsOKButton);
            Name = "SettingsForm";
            Text = "SettingsForm";
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button SettingsOKButton;
        private Button SettingsCancelButton;
        private TabControl TabControl1;
        private TabPage TabPage1;
        private Label label1;
        private TextBox AppTitleNameTextBox;
    }
}