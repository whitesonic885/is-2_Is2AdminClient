
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace is2AdminClient
{
	/// <summary>
	/// ���ʃe�L�X�g�{�b�N�X �̊T�v�̐����ł��B
	/// </summary>
	public class ���ʃe�L�X�g�{�b�N�X : System.Windows.Forms.TextBox
	{
		public ���ʃe�L�X�g�{�b�N�X()
		{
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.���ʃe�L�X�g�{�b�N�X_MouseDown);
			this.Enter += new System.EventHandler(this.���ʃe�L�X�g�{�b�N�X_Enter);
		}

		private void ���ʃe�L�X�g�{�b�N�X_Enter(object sender, System.EventArgs e)
		{
			if(this.Text.Length == 0 && this.PasswordChar == '\0') this.Text = " ";
			this.SelectionStart = 0;
			this.SelectionLength = this.Text.Length;
		}

		private void ���ʃe�L�X�g�{�b�N�X_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (this.Text.Trim().Length == 0)
			{
				this.SelectionStart = 0;
				this.SelectionLength = this.Text.Length;
			}
		}
	}
}
