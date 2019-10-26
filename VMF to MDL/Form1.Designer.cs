namespace VMF_to_MDL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.gamesComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.modsComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.vmfListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.removeButton = new DevExpress.XtraEditors.SimpleButton();
            this.compileButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl11 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gamesComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modsComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmfListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // gamesComboBox
            // 
            this.gamesComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamesComboBox.Location = new System.Drawing.Point(64, 0);
            this.gamesComboBox.Name = "gamesComboBox";
            this.gamesComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gamesComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.gamesComboBox.Size = new System.Drawing.Size(477, 20);
            this.gamesComboBox.TabIndex = 15;
            this.gamesComboBox.SelectedIndexChanged += new System.EventHandler(this.gamesComboBox_SelectedIndexChanged);
            // 
            // modsComboBox
            // 
            this.modsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modsComboBox.Location = new System.Drawing.Point(64, 0);
            this.modsComboBox.Name = "modsComboBox";
            this.modsComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.modsComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.modsComboBox.Size = new System.Drawing.Size(477, 20);
            this.modsComboBox.TabIndex = 16;
            this.modsComboBox.SelectedIndexChanged += new System.EventHandler(this.modsComboBox_SelectedIndexChanged);
            // 
            // vmfListBox
            // 
            this.vmfListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.vmfListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vmfListBox.Location = new System.Drawing.Point(12, 0);
            this.vmfListBox.Name = "vmfListBox";
            this.vmfListBox.Size = new System.Drawing.Size(529, 194);
            this.vmfListBox.TabIndex = 17;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(10, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(10, 29);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 19;
            this.removeButton.Text = "Remove";
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // compileButton
            // 
            this.compileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.compileButton.Location = new System.Drawing.Point(10, 171);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(75, 23);
            this.compileButton.TabIndex = 20;
            this.compileButton.Text = "Compile";
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(64, 20);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Branch:";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl2.Location = new System.Drawing.Point(0, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.labelControl2.Size = new System.Drawing.Size(64, 20);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Mod:";
            // 
            // labelControl3
            // 
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl3.Location = new System.Drawing.Point(0, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Padding = new System.Windows.Forms.Padding(12, 6, 0, 6);
            this.labelControl3.Size = new System.Drawing.Size(88, 25);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "VMFs to compile";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.vmfListBox);
            this.panelControl2.Controls.Add(this.panelControl8);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 83);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(626, 194);
            this.panelControl2.TabIndex = 25;
            // 
            // panelControl8
            // 
            this.panelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl8.Location = new System.Drawing.Point(0, 0);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(12, 194);
            this.panelControl8.TabIndex = 19;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.compileButton);
            this.panelControl3.Controls.Add(this.addButton);
            this.panelControl3.Controls.Add(this.removeButton);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(541, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(85, 194);
            this.panelControl3.TabIndex = 18;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(626, 12);
            this.panelControl4.TabIndex = 26;
            // 
            // panelControl5
            // 
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.Controls.Add(this.gamesComboBox);
            this.panelControl5.Controls.Add(this.panelControl10);
            this.panelControl5.Controls.Add(this.labelControl1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(0, 12);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(626, 20);
            this.panelControl5.TabIndex = 27;
            // 
            // panelControl10
            // 
            this.panelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl10.Location = new System.Drawing.Point(541, 0);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(85, 20);
            this.panelControl10.TabIndex = 22;
            // 
            // panelControl6
            // 
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl6.Location = new System.Drawing.Point(0, 32);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(626, 6);
            this.panelControl6.TabIndex = 28;
            // 
            // panelControl7
            // 
            this.panelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl7.Controls.Add(this.modsComboBox);
            this.panelControl7.Controls.Add(this.panelControl11);
            this.panelControl7.Controls.Add(this.labelControl2);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl7.Location = new System.Drawing.Point(0, 38);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(626, 20);
            this.panelControl7.TabIndex = 29;
            // 
            // panelControl11
            // 
            this.panelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl11.Location = new System.Drawing.Point(541, 0);
            this.panelControl11.Name = "panelControl11";
            this.panelControl11.Size = new System.Drawing.Size(85, 20);
            this.panelControl11.TabIndex = 23;
            // 
            // panelControl9
            // 
            this.panelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl9.Location = new System.Drawing.Point(626, 0);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(12, 289);
            this.panelControl9.TabIndex = 30;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 277);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(626, 12);
            this.panelControl1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 289);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panelControl7);
            this.Controls.Add(this.panelControl6);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XBLAH\'s VMF to MDL Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamesComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modsComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmfListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.ComboBoxEdit gamesComboBox;
        private DevExpress.XtraEditors.ComboBoxEdit modsComboBox;
        private DevExpress.XtraEditors.ListBoxControl vmfListBox;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.SimpleButton removeButton;
        private DevExpress.XtraEditors.SimpleButton compileButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraEditors.PanelControl panelControl11;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}

