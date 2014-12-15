using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using FixTheDamnPrinter.Properties;

namespace FixTheDamnPrinter {
	static class Printer {
		private static readonly byte[] feedBytes = new byte[] { 0x0a };
		private static readonly byte[] cutBytes = new byte[] { 0x1d, 0x56, 0x42, 0x00 };
		private static readonly byte[] watermarkHeaderBytes = new byte[] { 0x1d, 0x7b, 0x77 };
		private static readonly byte[] watermarkOnBytes = new byte[] { 0x01 };
		private static readonly byte[] watermarkOffBytes = new byte[] { 0x00 };
		private static readonly byte[] watermarkSettingsHeaderBytes = new byte[] { 0x02 };

		private delegate void Action();

		private static void HandleExceptions(Action action) {
			try {
				action();
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public static void SendSettingsToPrinter(string port, Settings settings) {
			HandleExceptions(() => {
				Print(port,
					watermarkHeaderBytes,
					watermarkSettingsHeaderBytes,
					new[] { 
						settings.PrintingMode,
						settings.Alignment,
						CalcEnlargement(settings.HEnlargement, settings.VEnlargement),
						settings.Brightness,
						settings.ImageID
					}
				);
			});
		}

		public static void SetWatermarkOnOff(string port, bool on) {
			HandleExceptions(() => {
				Print(port, watermarkHeaderBytes, on ? watermarkOnBytes : watermarkOffBytes);
			});
		}

		public static void CutPaper(string port) {
			HandleExceptions(() => {
				Print(port, cutBytes);
			});
		}

		public static void Feed(string port) {
			HandleExceptions(() => {
				Print(port, feedBytes);
			});
		}

		private static byte CalcEnlargement(byte h, byte v) {
			return (byte)(v * 16 + h);
		}

		private static void Print(string portName, params byte[][] data) {
			using (var port = new SerialPort(portName)) {
				port.Open();
				foreach (var buffer in data) {
					port.Write(buffer, 0, buffer.Length);
				}
			}
		}
	}
}
