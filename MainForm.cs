using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FixTheDamnPrinter {
	using FixTheDamnPrinter.Properties;
	using KVP = KeyValuePair<byte, string>;

	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();

			this.Text += " v." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

			PrintingMode.Items.Add(new KVP(0, "Always (including feed button)"));
			PrintingMode.Items.Add(new KVP(1, "Only when printing"));

			Alignment.Items.Add(new KVP(0, "Left"));
			Alignment.Items.Add(new KVP(1, "Center"));
			Alignment.Items.Add(new KVP(2, "Right"));

			HEnlargement.Items.Add((byte)1);
			HEnlargement.Items.Add((byte)2);
			HEnlargement.Items.Add((byte)3);
			HEnlargement.Items.Add((byte)4);
			HEnlargement.Items.Add((byte)5);
			HEnlargement.Items.Add((byte)6);
			
			VEnlargement.Items.Add((byte)1);
			VEnlargement.Items.Add((byte)2);
			VEnlargement.Items.Add((byte)3);
			VEnlargement.Items.Add((byte)4);
			VEnlargement.Items.Add((byte)5);
			VEnlargement.Items.Add((byte)6);

			LoadSettings();
		}

		private void SaveSettingsButton_Click(object sender, EventArgs e) {
			var settings = SaveSettings();
			Printer.SendSettingsToPrinter(settings.Port, settings);
		}

		private void TurnOnWatermarkButton_Click(object sender, EventArgs e) {
			var settings = SaveSettings();
			Printer.SetWatermarkOnOff(settings.Port, true);
		}

		private void TurnOffWatermarkButton_Click(object sender, EventArgs e) {
			var settings = SaveSettings();
			Printer.SetWatermarkOnOff(settings.Port, false);
		}

		private void CutButton_Click(object sender, EventArgs e) {
			var settings = SaveSettings();
			Printer.CutPaper(settings.Port);
		}

		private void LoadSettings() {
			var settings = Settings.Default;

			Port.Text = settings.Port;
			ImageID.Value = settings.ImageID;
			Brightness.Value = settings.Brightness;
			PrintingMode.Select(settings.PrintingMode);
			Alignment.Select(settings.Alignment);
			HEnlargement.Select(settings.HEnlargement);
			VEnlargement.Select(settings.VEnlargement);
		}

		private Settings SaveSettings() {
			var settings = Settings.Default;

			settings.Port = Port.Text;
			settings.ImageID = (byte)ImageID.Value;
			settings.Brightness = (byte)Brightness.Value;
			settings.PrintingMode = (byte)(((KVP)PrintingMode.SelectedItem).Key);
			settings.Alignment = (byte)(((KVP)Alignment.SelectedItem).Key);
			settings.HEnlargement = (byte)HEnlargement.SelectedItem;
			settings.VEnlargement = (byte)VEnlargement.SelectedItem;

			settings.Save();
			return settings;
		}
	}

	static class ComboBoxExtensions {
		public static void Select(this ComboBox box, byte value) {
			for (var i = 0; i < box.Items.Count; i++) {
				var item = box.Items[i];
				var asInt = item as byte?;
				var kvp = item as KVP?;
				if (asInt == value || (kvp != null && kvp.Value.Key == value)) {
					box.SelectedIndex = i;
					return;
				}
			}
		}
	}
}