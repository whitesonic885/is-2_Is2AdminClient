
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace is2AdminClient
{
	/// <summary>
	/// 共通テキストボックス の概要の説明です。
	/// </summary>
	public class 共通テキストボックス : System.Windows.Forms.TextBox
	{
		public 共通テキストボックス()
		{
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.共通テキストボックス_MouseDown);
			this.Enter += new System.EventHandler(this.共通テキストボックス_Enter);
		}

		private void 共通テキストボックス_Enter(object sender, System.EventArgs e)
		{
			if(this.Text.Length == 0 && this.PasswordChar == '\0') this.Text = " ";
			this.SelectionStart = 0;
			this.SelectionLength = this.Text.Length;
		}

		private void 共通テキストボックス_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (this.Text.Trim().Length == 0)
			{
				this.SelectionStart = 0;
				this.SelectionLength = this.Text.Length;
			}
		}
	}
}
