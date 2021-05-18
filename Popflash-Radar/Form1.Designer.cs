
namespace Popflash_Radar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearMapButton = new System.Windows.Forms.Button();
            this.mapComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.locationYTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.locationXTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearPlayerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.playerXTextBox = new System.Windows.Forms.TextBox();
            this.playerYTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clearGrenadeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grenadeXTextBox = new System.Windows.Forms.TextBox();
            this.grenadeYTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grenadePictureBox = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.radarPictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grenadePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.clearMapButton);
            this.groupBox1.Controls.Add(this.mapComboBox);
            this.groupBox1.Location = new System.Drawing.Point(1043, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // clearMapButton
            // 
            this.clearMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearMapButton.Location = new System.Drawing.Point(7, 48);
            this.clearMapButton.Name = "clearMapButton";
            this.clearMapButton.Size = new System.Drawing.Size(286, 23);
            this.clearMapButton.TabIndex = 1;
            this.clearMapButton.Text = "Reset";
            this.clearMapButton.UseVisualStyleBackColor = true;
            this.clearMapButton.Click += new System.EventHandler(this.clearMapButton_Click);
            // 
            // mapComboBox
            // 
            this.mapComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapComboBox.FormattingEnabled = true;
            this.mapComboBox.Items.AddRange(new object[] {
            "Ancient",
            "Cache",
            "Cobblestone",
            "Dust II",
            "Inferno",
            "Mirage",
            "Nuke",
            "Overpass",
            "Train",
            "Vertigo"});
            this.mapComboBox.Location = new System.Drawing.Point(7, 20);
            this.mapComboBox.Name = "mapComboBox";
            this.mapComboBox.Size = new System.Drawing.Size(286, 21);
            this.mapComboBox.TabIndex = 0;
            this.mapComboBox.SelectedIndexChanged += new System.EventHandler(this.mapComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.locationYTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.locationXTextBox);
            this.groupBox2.Location = new System.Drawing.Point(1043, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 74);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // locationYTextBox
            // 
            this.locationYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationYTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.locationYTextBox.Location = new System.Drawing.Point(26, 45);
            this.locationYTextBox.Name = "locationYTextBox";
            this.locationYTextBox.ReadOnly = true;
            this.locationYTextBox.Size = new System.Drawing.Size(267, 20);
            this.locationYTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // locationXTextBox
            // 
            this.locationXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationXTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.locationXTextBox.Location = new System.Drawing.Point(26, 19);
            this.locationXTextBox.Name = "locationXTextBox";
            this.locationXTextBox.ReadOnly = true;
            this.locationXTextBox.Size = new System.Drawing.Size(267, 20);
            this.locationXTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.clearPlayerButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.playerXTextBox);
            this.groupBox3.Controls.Add(this.playerYTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(1043, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Player";
            // 
            // clearPlayerButton
            // 
            this.clearPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearPlayerButton.Location = new System.Drawing.Point(34, 71);
            this.clearPlayerButton.Name = "clearPlayerButton";
            this.clearPlayerButton.Size = new System.Drawing.Size(259, 23);
            this.clearPlayerButton.TabIndex = 8;
            this.clearPlayerButton.Text = "Clear";
            this.clearPlayerButton.UseVisualStyleBackColor = true;
            this.clearPlayerButton.Click += new System.EventHandler(this.clearOutputButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y%";
            // 
            // playerXTextBox
            // 
            this.playerXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerXTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.playerXTextBox.Location = new System.Drawing.Point(34, 19);
            this.playerXTextBox.Name = "playerXTextBox";
            this.playerXTextBox.ReadOnly = true;
            this.playerXTextBox.Size = new System.Drawing.Size(259, 20);
            this.playerXTextBox.TabIndex = 4;
            // 
            // playerYTextBox
            // 
            this.playerYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerYTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.playerYTextBox.Location = new System.Drawing.Point(34, 45);
            this.playerYTextBox.Name = "playerYTextBox";
            this.playerYTextBox.ReadOnly = true;
            this.playerYTextBox.Size = new System.Drawing.Size(259, 20);
            this.playerYTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "X%";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.clearGrenadeButton);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.grenadeXTextBox);
            this.groupBox4.Controls.Add(this.grenadeYTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(1043, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 158);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grenade";
            // 
            // clearGrenadeButton
            // 
            this.clearGrenadeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearGrenadeButton.Location = new System.Drawing.Point(34, 71);
            this.clearGrenadeButton.Name = "clearGrenadeButton";
            this.clearGrenadeButton.Size = new System.Drawing.Size(259, 23);
            this.clearGrenadeButton.TabIndex = 8;
            this.clearGrenadeButton.Text = "Clear";
            this.clearGrenadeButton.UseVisualStyleBackColor = true;
            this.clearGrenadeButton.Click += new System.EventHandler(this.ClearGrenadeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Y%";
            // 
            // grenadeXTextBox
            // 
            this.grenadeXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grenadeXTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.grenadeXTextBox.Location = new System.Drawing.Point(34, 19);
            this.grenadeXTextBox.Name = "grenadeXTextBox";
            this.grenadeXTextBox.ReadOnly = true;
            this.grenadeXTextBox.Size = new System.Drawing.Size(259, 20);
            this.grenadeXTextBox.TabIndex = 4;
            // 
            // grenadeYTextBox
            // 
            this.grenadeYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grenadeYTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.grenadeYTextBox.Location = new System.Drawing.Point(34, 45);
            this.grenadeYTextBox.Name = "grenadeYTextBox";
            this.grenadeYTextBox.ReadOnly = true;
            this.grenadeYTextBox.Size = new System.Drawing.Size(259, 20);
            this.grenadeYTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "X%";
            // 
            // grenadePictureBox
            // 
            this.grenadePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.grenadePictureBox.Image = global::Popflash_Radar.Properties.Resources.png_smoke;
            this.grenadePictureBox.Location = new System.Drawing.Point(12, 43);
            this.grenadePictureBox.Name = "grenadePictureBox";
            this.grenadePictureBox.Size = new System.Drawing.Size(85, 85);
            this.grenadePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grenadePictureBox.TabIndex = 11;
            this.grenadePictureBox.TabStop = false;
            this.grenadePictureBox.Visible = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.playerPictureBox.Image = global::Popflash_Radar.Properties.Resources.icon_t_on_map;
            this.playerPictureBox.Location = new System.Drawing.Point(12, 12);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(25, 25);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPictureBox.TabIndex = 10;
            this.playerPictureBox.TabStop = false;
            this.playerPictureBox.Visible = false;
            // 
            // radarPictureBox
            // 
            this.radarPictureBox.BackColor = System.Drawing.Color.Black;
            this.radarPictureBox.Location = new System.Drawing.Point(12, 12);
            this.radarPictureBox.Name = "radarPictureBox";
            this.radarPictureBox.Size = new System.Drawing.Size(1025, 1025);
            this.radarPictureBox.TabIndex = 0;
            this.radarPictureBox.TabStop = false;
            this.radarPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadarPictureBox_MouseDown);
            this.radarPictureBox.MouseLeave += new System.EventHandler(this.RadarPictureBox_MouseLeave);
            this.radarPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RadarPictureBox_MouseMove);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(34, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 56);
            this.label7.TabIndex = 12;
            this.label7.Text = "[Click] Smoke\r\n[Shift + Click] Flashbang\r\n[Ctrl + Click] Molotov\r\n[Alt + Click] H" +
    "E Grenade";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(34, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "[Right-Click] Terrorist\r\n[Ctrl + Right-Click] Counter-Terrorist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 1049);
            this.Controls.Add(this.grenadePictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radarPictureBox);
            this.Name = "Form1";
            this.Text = "Popflash Radar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grenadePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox radarPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearMapButton;
        private System.Windows.Forms.ComboBox mapComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox locationXTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locationYTextBox;
        private System.Windows.Forms.Button clearPlayerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox playerXTextBox;
        private System.Windows.Forms.TextBox playerYTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button clearGrenadeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox grenadeXTextBox;
        private System.Windows.Forms.TextBox grenadeYTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox grenadePictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

