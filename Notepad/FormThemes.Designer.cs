namespace Notepad
{
    partial class FormThemes
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
            this.ButtonThemeWhite = new System.Windows.Forms.Button();
            this.ButtonThemeDark = new System.Windows.Forms.Button();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonThemeWhite
            // 
            this.ButtonThemeWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonThemeWhite.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonThemeWhite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonThemeWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonThemeWhite.Location = new System.Drawing.Point(23, 187);
            this.ButtonThemeWhite.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ButtonThemeWhite.Name = "ButtonThemeWhite";
            this.ButtonThemeWhite.Size = new System.Drawing.Size(754, 110);
            this.ButtonThemeWhite.TabIndex = 0;
            this.ButtonThemeWhite.Text = "White (default)";
            this.ButtonThemeWhite.UseVisualStyleBackColor = false;
            this.ButtonThemeWhite.Click += new System.EventHandler(this.ButtonThemeWhite_Click);
            // 
            // ButtonThemeDark
            // 
            this.ButtonThemeDark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonThemeDark.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonThemeDark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonThemeDark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonThemeDark.Location = new System.Drawing.Point(23, 317);
            this.ButtonThemeDark.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ButtonThemeDark.Name = "ButtonThemeDark";
            this.ButtonThemeDark.Size = new System.Drawing.Size(754, 110);
            this.ButtonThemeDark.TabIndex = 1;
            this.ButtonThemeDark.Text = "Dark";
            this.ButtonThemeDark.UseVisualStyleBackColor = false;
            this.ButtonThemeDark.Click += new System.EventHandler(this.ButtonThemeDark_Click);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ThemeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ThemeLabel.Location = new System.Drawing.Point(40, 40);
            this.ThemeLabel.Margin = new System.Windows.Forms.Padding(20);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(720, 124);
            this.ThemeLabel.TabIndex = 2;
            this.ThemeLabel.Text = "Select theme:";
            this.ThemeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ThemeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonThemeDark, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonThemeWhite, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FormThemes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormThemes";
            this.Text = "Themes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonThemeWhite;
        private System.Windows.Forms.Button ButtonThemeDark;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}