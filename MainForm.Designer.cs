namespace FixTheDamnPrinter {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.Label PortLabel;
			System.Windows.Forms.Label BrightnessLabel;
			System.Windows.Forms.Label ImageIDLabel;
			System.Windows.Forms.Label PrintingModeLabel;
			System.Windows.Forms.Label AlignmentLabel;
			System.Windows.Forms.Label EnlargementLabel;
			System.Windows.Forms.Label EnlargementLabelX;
			this.Port = new System.Windows.Forms.ComboBox();
			this.Brightness = new System.Windows.Forms.NumericUpDown();
			this.TurnOffWatermarkButton = new System.Windows.Forms.Button();
			this.TurnOnWatermarkButton = new System.Windows.Forms.Button();
			this.SaveSettingsButton = new System.Windows.Forms.Button();
			this.ImageID = new System.Windows.Forms.NumericUpDown();
			this.PrintingMode = new System.Windows.Forms.ComboBox();
			this.Alignment = new System.Windows.Forms.ComboBox();
			this.HEnlargement = new System.Windows.Forms.ComboBox();
			this.VEnlargement = new System.Windows.Forms.ComboBox();
			this.CutButton = new System.Windows.Forms.Button();
			PortLabel = new System.Windows.Forms.Label();
			BrightnessLabel = new System.Windows.Forms.Label();
			ImageIDLabel = new System.Windows.Forms.Label();
			PrintingModeLabel = new System.Windows.Forms.Label();
			AlignmentLabel = new System.Windows.Forms.Label();
			EnlargementLabel = new System.Windows.Forms.Label();
			EnlargementLabelX = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Brightness)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageID)).BeginInit();
			this.SuspendLayout();
			// 
			// PortLabel
			// 
			PortLabel.AutoSize = true;
			PortLabel.Location = new System.Drawing.Point(12, 15);
			PortLabel.Name = "PortLabel";
			PortLabel.Size = new System.Drawing.Size(26, 13);
			PortLabel.TabIndex = 1;
			PortLabel.Text = "Port";
			// 
			// BrightnessLabel
			// 
			BrightnessLabel.AutoSize = true;
			BrightnessLabel.Location = new System.Drawing.Point(12, 79);
			BrightnessLabel.Name = "BrightnessLabel";
			BrightnessLabel.Size = new System.Drawing.Size(56, 13);
			BrightnessLabel.TabIndex = 3;
			BrightnessLabel.Text = "Brightness";
			// 
			// ImageIDLabel
			// 
			ImageIDLabel.AutoSize = true;
			ImageIDLabel.Location = new System.Drawing.Point(12, 53);
			ImageIDLabel.Name = "ImageIDLabel";
			ImageIDLabel.Size = new System.Drawing.Size(50, 13);
			ImageIDLabel.TabIndex = 8;
			ImageIDLabel.Text = "Image ID";
			// 
			// PrintingModeLabel
			// 
			PrintingModeLabel.AutoSize = true;
			PrintingModeLabel.Location = new System.Drawing.Point(12, 106);
			PrintingModeLabel.Name = "PrintingModeLabel";
			PrintingModeLabel.Size = new System.Drawing.Size(71, 13);
			PrintingModeLabel.TabIndex = 11;
			PrintingModeLabel.Text = "Printing mode";
			// 
			// AlignmentLabel
			// 
			AlignmentLabel.AutoSize = true;
			AlignmentLabel.Location = new System.Drawing.Point(12, 133);
			AlignmentLabel.Name = "AlignmentLabel";
			AlignmentLabel.Size = new System.Drawing.Size(53, 13);
			AlignmentLabel.TabIndex = 13;
			AlignmentLabel.Text = "Alignment";
			// 
			// EnlargementLabel
			// 
			EnlargementLabel.AutoSize = true;
			EnlargementLabel.Location = new System.Drawing.Point(12, 160);
			EnlargementLabel.Name = "EnlargementLabel";
			EnlargementLabel.Size = new System.Drawing.Size(66, 13);
			EnlargementLabel.TabIndex = 16;
			EnlargementLabel.Text = "Enlargement";
			// 
			// EnlargementLabelX
			// 
			EnlargementLabelX.AutoSize = true;
			EnlargementLabelX.Location = new System.Drawing.Point(211, 160);
			EnlargementLabelX.Name = "EnlargementLabelX";
			EnlargementLabelX.Size = new System.Drawing.Size(14, 13);
			EnlargementLabelX.TabIndex = 17;
			EnlargementLabelX.Text = "X";
			EnlargementLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Port
			// 
			this.Port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Port.FormattingEnabled = true;
			this.Port.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
			this.Port.Location = new System.Drawing.Point(104, 12);
			this.Port.Name = "Port";
			this.Port.Size = new System.Drawing.Size(228, 21);
			this.Port.TabIndex = 0;
			// 
			// Brightness
			// 
			this.Brightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Brightness.Location = new System.Drawing.Point(104, 77);
			this.Brightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.Brightness.Name = "Brightness";
			this.Brightness.Size = new System.Drawing.Size(228, 20);
			this.Brightness.TabIndex = 4;
			// 
			// TurnOffWatermarkButton
			// 
			this.TurnOffWatermarkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TurnOffWatermarkButton.Location = new System.Drawing.Point(104, 242);
			this.TurnOffWatermarkButton.Name = "TurnOffWatermarkButton";
			this.TurnOffWatermarkButton.Size = new System.Drawing.Size(228, 23);
			this.TurnOffWatermarkButton.TabIndex = 5;
			this.TurnOffWatermarkButton.Text = "Turn off watermark";
			this.TurnOffWatermarkButton.UseVisualStyleBackColor = true;
			this.TurnOffWatermarkButton.Click += new System.EventHandler(this.TurnOffWatermarkButton_Click);
			// 
			// TurnOnWatermarkButton
			// 
			this.TurnOnWatermarkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TurnOnWatermarkButton.Location = new System.Drawing.Point(104, 271);
			this.TurnOnWatermarkButton.Name = "TurnOnWatermarkButton";
			this.TurnOnWatermarkButton.Size = new System.Drawing.Size(228, 23);
			this.TurnOnWatermarkButton.TabIndex = 6;
			this.TurnOnWatermarkButton.Text = "Turn on watermark";
			this.TurnOnWatermarkButton.UseVisualStyleBackColor = true;
			this.TurnOnWatermarkButton.Click += new System.EventHandler(this.TurnOnWatermarkButton_Click);
			// 
			// SaveSettingsButton
			// 
			this.SaveSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveSettingsButton.Location = new System.Drawing.Point(104, 213);
			this.SaveSettingsButton.Name = "SaveSettingsButton";
			this.SaveSettingsButton.Size = new System.Drawing.Size(228, 23);
			this.SaveSettingsButton.TabIndex = 7;
			this.SaveSettingsButton.Text = "Save watermark settings";
			this.SaveSettingsButton.UseVisualStyleBackColor = true;
			this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
			// 
			// ImageID
			// 
			this.ImageID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ImageID.Location = new System.Drawing.Point(104, 51);
			this.ImageID.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.ImageID.Name = "ImageID";
			this.ImageID.Size = new System.Drawing.Size(228, 20);
			this.ImageID.TabIndex = 9;
			// 
			// PrintingMode
			// 
			this.PrintingMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PrintingMode.DisplayMember = "Value";
			this.PrintingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PrintingMode.FormattingEnabled = true;
			this.PrintingMode.Location = new System.Drawing.Point(104, 103);
			this.PrintingMode.Name = "PrintingMode";
			this.PrintingMode.Size = new System.Drawing.Size(228, 21);
			this.PrintingMode.TabIndex = 10;
			this.PrintingMode.ValueMember = "Key";
			// 
			// Alignment
			// 
			this.Alignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Alignment.DisplayMember = "Value";
			this.Alignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Alignment.FormattingEnabled = true;
			this.Alignment.Location = new System.Drawing.Point(104, 130);
			this.Alignment.Name = "Alignment";
			this.Alignment.Size = new System.Drawing.Size(228, 21);
			this.Alignment.TabIndex = 12;
			this.Alignment.ValueMember = "Key";
			// 
			// HEnlargement
			// 
			this.HEnlargement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HEnlargement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.HEnlargement.FormattingEnabled = true;
			this.HEnlargement.Location = new System.Drawing.Point(104, 157);
			this.HEnlargement.Name = "HEnlargement";
			this.HEnlargement.Size = new System.Drawing.Size(92, 21);
			this.HEnlargement.TabIndex = 14;
			// 
			// VEnlargement
			// 
			this.VEnlargement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.VEnlargement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VEnlargement.FormattingEnabled = true;
			this.VEnlargement.Location = new System.Drawing.Point(240, 157);
			this.VEnlargement.Name = "VEnlargement";
			this.VEnlargement.Size = new System.Drawing.Size(92, 21);
			this.VEnlargement.TabIndex = 15;
			// 
			// CutButton
			// 
			this.CutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CutButton.Location = new System.Drawing.Point(104, 300);
			this.CutButton.Name = "CutButton";
			this.CutButton.Size = new System.Drawing.Size(228, 23);
			this.CutButton.TabIndex = 18;
			this.CutButton.Text = "Cut paper";
			this.CutButton.UseVisualStyleBackColor = true;
			this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 335);
			this.Controls.Add(this.CutButton);
			this.Controls.Add(EnlargementLabelX);
			this.Controls.Add(EnlargementLabel);
			this.Controls.Add(this.VEnlargement);
			this.Controls.Add(this.HEnlargement);
			this.Controls.Add(AlignmentLabel);
			this.Controls.Add(this.Alignment);
			this.Controls.Add(PrintingModeLabel);
			this.Controls.Add(this.PrintingMode);
			this.Controls.Add(this.ImageID);
			this.Controls.Add(ImageIDLabel);
			this.Controls.Add(this.SaveSettingsButton);
			this.Controls.Add(this.TurnOnWatermarkButton);
			this.Controls.Add(this.TurnOffWatermarkButton);
			this.Controls.Add(this.Brightness);
			this.Controls.Add(BrightnessLabel);
			this.Controls.Add(PortLabel);
			this.Controls.Add(this.Port);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Fix the damn printer";
			((System.ComponentModel.ISupportInitialize)(this.Brightness)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox Port;
		private System.Windows.Forms.NumericUpDown Brightness;
		private System.Windows.Forms.Button TurnOffWatermarkButton;
		private System.Windows.Forms.Button TurnOnWatermarkButton;
		private System.Windows.Forms.Button SaveSettingsButton;
		private System.Windows.Forms.NumericUpDown ImageID;
		private System.Windows.Forms.ComboBox PrintingMode;
		private System.Windows.Forms.ComboBox Alignment;
		private System.Windows.Forms.ComboBox HEnlargement;
		private System.Windows.Forms.ComboBox VEnlargement;
		private System.Windows.Forms.Button CutButton;
	}
}

