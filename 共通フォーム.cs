using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace is2AdminClient
{
	/// <summary>
	/// [���ʃt�H�[��]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// MOD 2008.02.14 ���s�j���� Vista�Ή� 
	// ADD 2008.02.14 ���s�j���� �r�i�h�r�`�F�b�N�@�\�̒ǉ� 
	// DEL 2008.05.07 ���s�j���� ���˗��匟���폜 
	// ADD 2008.05.07 ���s�j���� �S�p���p���݃`�F�b�N�@�\�̒ǉ� 
	// DEL 2008.05.08 ���s�j���� �Z�N�V���������폜 
	// MOD 2008.04.11 ACT Vista�Ή� 
	//���~ MOD 2008.12.08 ���s�j���� �c�Ə��ł̃p�X���[�h�Ɖ�Ή� 
	//--------------------------------------------------------------------------
	// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� 
	// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
	// MOD 2009.11.04 ���s�j���� ���͂���b�c�ɋL��[+]�𗘗p�\�ɂ��� 
	// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2010.05.24 ���s�j���� �t�@�C���o�͎��̉��s�R�[�h�̏C�� 
	// MOD 2010.06.29 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� 
	// MOD 2010.11.19 ���s�j���� �z�����Ȃǂ̎擾 
	// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� 
	// ADD 2013.07.12 tdi�j�j�V �����e���g���ڊǐ惍�O�C���Ή�
	//--------------------------------------------------------------------------
	// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή�
	//--------------------------------------------------------------------------
	public class ���ʃt�H�[�� : System.Windows.Forms.Form
	{
		protected static String gs����R�[�h   = "";
		protected static String gs�����       = "";
		protected static String gs���p�҃R�[�h = "";
		protected static String gs���p�Җ�     = "";
		protected static String gs�X���R�[�h   = "";
// ADD 2007.02.06 ���s�j���� �c�Ə�����Ή� START
		protected static String gs�Ǘ��ҋ敪   = "";
// ADD 2007.02.06 ���s�j���� �c�Ə�����Ή� END
// ADD 2006.12.06 ���s�j�����J �h�o�A�h���X START
		protected static String gs�h�o�A�h���X = "";
// ADD 2006.12.06 ���s�j�����J �h�o�A�h���X END
// ADD 2007.02.06 ���s�j���� �C���[�W���[�h�G���[�Ή� START
		protected static String gs�A�v���t�H���_ = "";
// ADD 2007.02.06 ���s�j���� �C���[�W���[�h�G���[�Ή� END
// MOD 2007.10.26 ���s�j���� �o�[�W��������\������ START
//		protected static String[] gsa���[�U    = new string[3];
		protected static String[] gsa���[�U = {"","","",""};
// MOD 2007.10.26 ���s�j���� �o�[�W��������\������ END
		// �v�����T�[�r�X�ϐ�
		protected static is2maintenance.Service1  sv_maintenance  = null;
		//Cookie��ۑ����Ă���CookieContainer
// ADD 2007.12.11 KCL) �X�{ ���m�点�ǉ� START
		protected static is2oshirase.Service1 sv_oshirase = null;
// ADD 2007.12.11 KCL) �X�{ ���m�点�ǉ� END
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
		protected static is2oji.Service1 sv_oji = null;
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

// DEL 2005.05.27 ���s�j���� �Z�b�V��������̔p�~ START
//		protected static System.Net.CookieContainer cContainer = new System.Net.CookieContainer();
// DEL 2005.05.27 ���s�j���� �Z�b�V��������̔p�~ END
// ADD 2005.05.25 ���s�j�����J �X���b�h�� START
		protected static �ב��l����         g�ב�����  = null;
		protected static ����}�X�^         g����}�X  = null;
		protected static �������           g�������  = null;
		protected static ������b�r�u�o�� g����o��  = null;
		protected static �L���o�^           g�L���o�^  = null;
		protected static �W��X�}�X�^       g�W��X�}  = null;
		protected static �Z������           g�Z������  = null;
		protected static ������}�X�^       g������}  = null;
		protected static �X������           g�X������  = null;
// DEL 2008.05.08 ���s�j���� �Z�N�V���������폜 START
//		protected static ���匟��           g���匟��  = null;
// DEL 2008.05.08 ���s�j���� �Z�N�V���������폜 END
// ADD 2006.07.11 ���s�j���� ��ʕύX START
		protected static �������           g�������  = null;
		protected static ��������           g��������  = null;
		protected static �ғ�����           g�ғ�����  = null;
		protected static �o�׏�           g�o�׏�  = null;
// ADD 2006.07.11 ���s�j���� ��ʕύX END
// ADD 2006.11.06 ���s�j���� �X������ʂ̒ǉ� START
		protected static �X�����           g�X�����  = null;
// ADD 2006.11.06 ���s�j���� �X������ʂ̒ǉ� END
// ADD 2005.05.25 ���s�j�����J �X���b�h�� END
// ADD 2005.05.27 ���s�j���� ���b�Z�[�W�o�^��ʂ̒ǉ� START
		protected static ���b�Z�[�W�o�^     g���Z�o�^  = null;
// ADD 2005.05.27 ���s�j���� ���b�Z�[�W�o�^��ʂ̒ǉ� END
// ADD 2006.12.12 ���s�j���� ��ʒǉ� START
		protected static �o�׏Ɖ�           g�o�׏Ɖ�  = null;
// DEL 2008.05.07 ���s�j���� ���˗��匟���폜 START
//		protected static ���˗��匟��       g�˗�����  = null;
// DEL 2008.05.07 ���s�j���� ���˗��匟���폜 END
// MOD 2007.01.18 ���s�j���� ��ʖ��̕ύX START
//		protected static ���X�d��           g���X�d��  = null;
		protected static ���X�d��           g���X�d��  = null;
// MOD 2007.01.18 ���s�j���� ��ʖ��̕ύX END
// ADD 2006.12.12 ���s�j���� ��ʒǉ� END
// ADD 2007.02.06 ���s�j���� �C���[�W���[�h�G���[�Ή� START
		protected static �X������           g�X������ = null;
// ADD 2007.02.06 ���s�j���� �C���[�W���[�h�G���[�Ή� END
// ADD 2007.02.06 ���s�j���� �v���r���[��ʂ̍����� START
		protected static �v���r���[���     g�v���r�� = null;
// ADD 2007.02.06 ���s�j���� �v���r���[��ʂ̍����� END
// ADD 2007.11.13 KCL) �X�{ global�Ή��p������ʒǉ� START
		protected static ��������Q         g������Q  = null;
		protected static ���˗��匟���Q     g�˗����Q  = null;
// ADD 2007.11.13 KCL) �X�{ global�Ή��p������ʒǉ� END
// ADD 2007.12.05 KCL) �X�{ ���m�点�ǉ� START
		protected static ���m�点�o�^       g���m�o�^  = null;
		protected static ���m�点����       g���m����  = null;
// ADD 2007.12.05 KCL) �X�{ ���m�点�ǉ� END
// MOD 2010.06.29 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
		protected static ���m�点�o�^�Q     g���m�o�Q  = null;
		protected static ���m�点�����Q     g���m���Q  = null;
// MOD 2010.06.29 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
//���~ MOD 2008.12.08 ���s�j���� �c�Ə��ł̃p�X���[�h�Ɖ�Ή� START
//		protected static �p�X���[�h�Ɖ�     g�p�X�Ɖ�  = null;
//���~ MOD 2008.12.08 ���s�j���� �c�Ə��ł̃p�X���[�h�Ɖ�Ή� END
// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� START
		protected static �ғ����o�^         g�ғ����o  = null;
// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� END
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
		protected static ���m�点�\��    g���m�\��   = null;
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� START
		protected static �}�j���A���_�E�����[�h    g�}�j���A  = null;
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� END
//ADD 2013.07.12 tdi�j�j�V �����e���g���ڊǐ惍�O�C���Ή� START
		protected static �p�X����           g�p�X���� = null;
//ADD 2013.07.12 tdi�j�j�V �����e���g���ڊǐ惍�O�C���Ή� END
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή� START
		protected static �Г��`������X�}�X�^   g�Г��` = null;
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή� END

// ADD 2005.05.25 ���s�j�����J �ʐM�G���[�̃��b�Z�[�W�C�� START
		protected static String gs�ʐM�G���[
			= "�T�[�o�[�Ƃ̒ʐM�Ɏ��s���܂���\n"
			+ " �k�`�m�P�[�u����l�b�g���[�N�ݒ蓙���m�F���Ă�������";
// ADD 2005.05.25 ���s�j�����J �ʐM�G���[�̃��b�Z�[�W�C�� END
// ADD 2006.08.02 ���s�j���� �s���{���b�c�z��̋��ʉ� START
		protected static string[] sa��
			= { "",												// �s���{���b�c
				  "�k�C��","�X��","��茧","�{�錧","�H�c��",		// 01 -
				  "�R�`��","������","��錧","�Ȗ،�","�Q�n��",		//    - 10
				  "��ʌ�","��t��","�����s","�_�ސ쌧","�V����",	// 11 -
				  "�x�R��","�ΐ쌧","���䌧","�R����","���쌧",		//    - 20
				  "�򕌌�","�É���","���m��","�O�d��","���ꌧ",		// 21 -
				  "���s�{","���{","���Ɍ�","�ޗǌ�","�a�̎R��",	//    - 30
				  "���挧","������","���R��","�L����","�R����",		// 31 -
				  "������","���쌧","���Q��","���m��","������",		//    - 39
				  "���ꌧ","���茧","�F�{��","�啪��","�{�茧",		// 41 -
				  "��������","���ꌧ"								//    - 
			  };
// ADD 2006.08.02 ���s�j���� �s���{���b�c�z��̋��ʉ� END
// ADD 2006.11.06 ���s�j���� �X������ʂ̒ǉ� START
		protected static Hashtable h�� = null;
// ADD 2006.11.06 ���s�j���� �X������ʂ̒ǉ� END
// ADD 2006.12.12 ���s�j���� ��ʒǉ� START
		protected static String[] gsa��Ԃb�c = {""};
		protected static String[] gsa��Ԗ�   = {""};
// ADD 2006.12.12 ���s�j���� ��ʒǉ� END
// ADD 2008.04.11 ACT Vista�Ή� START
		protected static Hashtable gh�����ϊ� = null;
// ADD 2008.04.11 ACT Vista�Ή� END
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή� START
		protected static string s�Г��`�[�p�X�֔ԍ� = "XXX0044";
		protected static string s�Г��`�[�p�X�֔ԍ��\���p = "XXX-0044";
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή� END

		[System.Runtime.InteropServices.DllImport("user32.dll")] 
		protected static extern int MessageBeep(uint n); 
// MOD 2010.11.19 ���s�j���� �z�����Ȃǂ̎擾 START
		[System.Runtime.InteropServices.DllImport("user32.dll")] 
		protected static extern short GetAsyncKeyState(Keys vKey); 
// MOD 2010.11.19 ���s�j���� �z�����Ȃǂ̎擾 END

		protected void �G���^�[�ړ�(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch(e.KeyCode)
			{
					// [Enter]�L�[�������ꂽ���A���̃R���g���[���փt�H�[�J�X�ړ�
				case Keys.Enter:
// MOD 2008.02.14 ���s�j���� Vista�Ή� START
////					System.Windows.Forms.SendKeys.Send("{TAB}");
//					System.Windows.Forms.SendKeys.SendWait("{TAB}");
					// �ʂ̕��@ - ���̂P
					//this.ProcessTabKey(!e.Shift);

					// �ʂ̕��@ - ���̂Q
					this.SelectNextControl(this.ActiveControl, true, true, true, true);
// MOD 2008.02.14 ���s�j���� Vista�Ή� END
					break;
					// [Esc]�L�[�������ꂽ���A�t�H�[�������
				case Keys.Escape:
					Close();
					break;
			}
		}
		protected void �G���^�[�L�����Z��(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 0x0d)
			{
				e.Handled = true;
			}
		}

		private void InitializeComponent()
		{
			// 
			// ���ʃt�H�[��
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Name = "���ʃt�H�[��";

		}
	
		protected static bool �K�{�`�F�b�N(TextBox tex, string name)
		{
			if(tex.Text.Length > 0) return true;
			MessageBox.Show("�K�{����(" + name + ")�����͂���Ă��܂���",
				"���̓`�F�b�N",MessageBoxButtons.OK);
			tex.Focus();
			return false;
		}

// ADD 2008.02.14 ���s�j���� �r�i�h�r�`�F�b�N�@�\�̒ǉ� START
// MOD 2008.04.11 ACT Vista�Ή� START
//		private static bool �r�i�h�r�`�F�b�N(TextBox tex, string name, string sUnicode, byte[] bSjis)
		private static bool �r�i�h�r�`�F�b�N(TextBox tex, string name, ref string sUnicode, ref byte[] bSjis)
// MOD 2008.04.11 ACT Vista�Ή� END
		{
			//�t�ϊ����Ăr�i�h�r�������`�F�b�N����
			string sRevUnicode = System.Text.Encoding.GetEncoding("shift-jis").GetString(bSjis);
			string sErrChars = "";
			for(int iPos = 0; iPos < sUnicode.Length && iPos < sRevUnicode.Length; iPos++)
			{
				if(sUnicode[iPos] != sRevUnicode[iPos])
				{
					sErrChars += sUnicode[iPos];
				}
			}
			if(sErrChars.Length > 0)
			{
// MOD 2008.04.11 ACT Vista�Ή� START
//				MessageBox.Show(name + "�Ɏg�p�ł��Ȃ�����������܂�\n"
//				+ "�w" + sErrChars + "�x",
//				"���̓`�F�b�N",MessageBoxButtons.OK);
//				tex.Focus();
//				return false;
				return �����ϊ�(tex, name, ref sUnicode, ref bSjis);
// MOD 2008.04.11 ACT Vista�Ή� END
			}
			return true;
		}
// ADD 2008.02.14 ���s�j���� �r�i�h�r�`�F�b�N�@�\�̒ǉ� END

		protected static bool �S�p�`�F�b�N(TextBox tex, string name)
		{
			string sUnicode = tex.Text;
			byte[] bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sUnicode);
// MOD 2008.04.11 ACT Vista�Ή� START
//// ADD 2008.02.14 ���s�j���� �r�i�h�r�`�F�b�N�@�\�̒ǉ� START
//			if(!�r�i�h�r�`�F�b�N(tex, name, sUnicode, bSjis)) return false;
			if(!�r�i�h�r�`�F�b�N(tex, name, ref sUnicode, ref bSjis)) return false;
//// ADD 2008.02.14 ���s�j���� �r�i�h�r�`�F�b�N�@�\�̒ǉ� END
// MOD 2008.04.11 ACT Vista�Ή� END
			if(bSjis.Length == sUnicode.Length * 2) return true;
			MessageBox.Show(name + "�͑S�p�����œ��͂��Ă�������",
				"���̓`�F�b�N",MessageBoxButtons.OK);
			tex.Focus();
			return false;
		}
		protected static bool ���p�`�F�b�N(TextBox tex, string name)
		{
			string sUnicode = tex.Text;
			byte[] bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sUnicode);
// MOD 2008.04.11 ACT Vista�Ή� START
//// ADD 2008.02.14 ���s�j���� �r�i�h�r�`�F�b�N�@�\�̒ǉ� START
//			if(!�r�i�h�r�`�F�b�N(tex, name, sUnicode, bSjis)) return false;
			if(!�r�i�h�r�`�F�b�N(tex, name, ref sUnicode, ref bSjis)) return false;
//// ADD 2008.02.14 ���s�j���� �r�i�h�r�`�F�b�N�@�\�̒ǉ� END
// MOD 2008.04.11 ACT Vista�Ή� END
			if(bSjis.Length != sUnicode.Length)
			{
				MessageBox.Show(name + "�͔��p�����œ��͂��Ă�������",
					"���̓`�F�b�N",MessageBoxButtons.OK);
				tex.Focus();
				return false;
			}

			for(int i = 0; i < tex.Text.Length; i++)
			{
				// [!"#$%&'()*,]
				// [:;<=>?]
				// [[]^]
				// [{|}]
				// [\]
// MOD 2009.11.04 ���s�j���� ���͂���b�c�ɋL��[+]�𗘗p�\�ɂ��� START
//				if((tex.Text[i] >= 0x21 && tex.Text[i] <= 0x2C)
				if((tex.Text[i] >= 0x21 && tex.Text[i] <= 0x2A)
					|| (tex.Text[i] == 0x2C)
// MOD 2009.11.04 ���s�j���� ���͂���b�c�ɋL��[+]�𗘗p�\�ɂ��� END
					|| (tex.Text[i] >= 0x3A && tex.Text[i] <= 0x3F)
					|| (tex.Text[i] >= 0x5B && tex.Text[i] <= 0x5E)
					|| (tex.Text[i] >= 0x7B && tex.Text[i] <= 0x7D)
					|| (tex.Text[i] == 0xA5))
				{
					MessageBox.Show(name + "�ɋL�������͂���Ă��܂�","���̓`�F�b�N",MessageBoxButtons.OK);
					tex.Focus();
					return false;
				}
			}
			return true;
		}
// ADD 2008.05.07 ���s�j���� �S�p���p���݃`�F�b�N�@�\�̒ǉ� START
		protected static bool �S�p���p���݃`�F�b�N(TextBox tex, string name)
		{
			string sUnicode = tex.Text;
			byte[] bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sUnicode);
// MOD 2008.04.11 ACT Vista�Ή� START
//// ADD 2008.02.14 ���s�j���� �r�i�h�r�`�F�b�N�@�\�̒ǉ� START
//			if(!�r�i�h�r�`�F�b�N(tex, name, sUnicode, bSjis)) return false;
			if(!�r�i�h�r�`�F�b�N(tex, name, ref sUnicode, ref bSjis)) return false;
//// ADD 2008.02.14 ���s�j���� �r�i�h�r�`�F�b�N�@�\�̒ǉ� END
// MOD 2008.04.11 ACT Vista�Ή� END

			for(int i = 0; i < tex.Text.Length; i++)
			{
				// [!"#$%&'()*,]
				// [:;<=>?]
				// [[]^]
				// [{|}]
				// [\]
// MOD 2009.11.04 ���s�j���� ���͂���b�c�ɋL��[+]�𗘗p�\�ɂ��� START
//				if((tex.Text[i] >= 0x21 && tex.Text[i] <= 0x2C)
				if((tex.Text[i] >= 0x21 && tex.Text[i] <= 0x2A)
					|| (tex.Text[i] == 0x2C)
// MOD 2009.11.04 ���s�j���� ���͂���b�c�ɋL��[+]�𗘗p�\�ɂ��� END
					|| (tex.Text[i] >= 0x3A && tex.Text[i] <= 0x3F)
					|| (tex.Text[i] >= 0x5B && tex.Text[i] <= 0x5E)
					|| (tex.Text[i] >= 0x7B && tex.Text[i] <= 0x7D)
					|| (tex.Text[i] == 0xA5))
				{
					MessageBox.Show(name + "�ɋL�������͂���Ă��܂�","���̓`�F�b�N",MessageBoxButtons.OK);
					tex.Focus();
					return false;
				}
			}
			return true;
		}
// ADD 2008.05.07 ���s�j���� �S�p���p���݃`�F�b�N�@�\�̒ǉ� END
		protected static bool ���l�`�F�b�N(TextBox tex, string name)
		{
			try
			{
				int iChk = int.Parse(tex.Text.Replace(",",""));
				return true;
			}
			catch(System.FormatException)
			{
				MessageBox.Show(name + "�ɐ��l�����͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK);
				tex.Focus();
				
				return false;
			}
		}
		//NumericUpDown�p
		protected static bool �͈̓`�F�b�N(NumericUpDown num, string name)
		{
			try
			{
				int iChk = int.Parse(num.Text.Replace(",", ""));
				if (iChk >= num.Minimum && iChk <= num.Maximum) return true;
				MessageBox.Show(name + "��" + num.Minimum + "�`" + num.Maximum + "�̊Ԃœ��͂��Ă�������","���̓`�F�b�N",MessageBoxButtons.OK);
				num.Focus();
				return false;
			}
			catch(System.FormatException)
			{
				MessageBox.Show(name + "�ɐ��l�����͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK);
				num.Focus();
				return false;
			}
		}
// ADD 2006.07.11 ���s�j���� ��ʕύX START
		//TextBox�p
		protected static bool �͈̓`�F�b�N(TextBox tex, string name, int iMinimum, int iMaximum)
		{
			try
			{
				int iChk = int.Parse(tex.Text.Replace(",", ""));
				if (iChk >= iMinimum && iChk <= iMaximum) return true;
				MessageBox.Show(name + "��" + iMinimum + "�`" + iMaximum + "�̊Ԃœ��͂��Ă�������","���̓`�F�b�N",MessageBoxButtons.OK);
				tex.Focus();
				return false;
			}
			catch(System.FormatException)
			{
				MessageBox.Show(name + "�ɐ��l�����͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK);
				tex.Focus();
				return false;
			}
		}
// ADD 2006.07.11 ���s�j���� ��ʕύX END

		protected static void �r�[�v��()
		{
			MessageBeep(0x00000030);
		}

		protected static byte[] toSJIS(string s�f�[�^)
		{
			byte[] bSJIS;
// MOD 2010.05.24 ���s�j���� �t�@�C���o�͎��̉��s�R�[�h�̏C�� START
//			bSJIS = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(s�f�[�^ + "\n");
			bSJIS = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(s�f�[�^ + "\r\n");
// MOD 2010.05.24 ���s�j���� �t�@�C���o�͎��̉��s�R�[�h�̏C�� END
			return bSJIS;
		}

// ADD 2005.07.08 ���s�j���� ���t�ϊ��̕ύX START
		protected static string YYYYMMDD�ϊ�(DateTime dtDate)
		{
			return dtDate.Year.ToString() + dtDate.ToString("MMdd");
		}
// ADD 2005.07.08 ���s�j���� ���t�ϊ��̕ύX END

// ADD 2006.11.06 ���s�j���� �X������ʂ̒ǉ� START
// MOD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� START
//		private static void �s���{���n�b�V���ݒ�()
		protected static void �s���{���n�b�V���ݒ�()
// MOD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� END
		{
			//�s���{���n�b�V���e�[�u���̍쐬
			if(h�� == null)
			{
				h�� = new Hashtable();
				for(int iCnt = 1; iCnt < sa��.Length; iCnt++)
				{
					h��.Add(sa��[iCnt], iCnt);
				}
			}
		}

		protected static bool �����`�F�b�N(ComboBox cb��, string name)
		{
			//�s���{���n�b�V���e�[�u���̍쐬
			�s���{���n�b�V���ݒ�();

			Object obj = h��[cb��.Text];
			if(obj != null)
			{
				cb��.SelectedIndex = (int)obj;
				return true;
			}
			else
			{
				MessageBox.Show(name + "(" + cb��.Text + ")�����݂��܂���",
					"���̓`�F�b�N", MessageBoxButtons.OK);
				cb��.Focus();
				return false;
			}
		}

		protected static void ���ݒ�(string s�Z��, ComboBox cb��, TextBox tex�Z���P)
		{
			//�s���{���n�b�V���e�[�u���̍쐬
			�s���{���n�b�V���ݒ�();

			if(s�Z��.Length >= 3)
			{
				//�s���{���b�c�̎擾
				string s�ҏW��     = "";
				int    iIndex      = 0;
				// �u�_�ސ쌧�v�A�u�a�̎R���v�A�u���������v�͂S�����ŕ�������r����
				if((s�Z��[0] == '�_' || s�Z��[0] == '�a' || s�Z��[0] == '��')
					&& s�Z��.Length >= 4 
					&& s�Z��[3] == '��')
				{
					s�ҏW�� = s�Z��.Substring(0,4);
					iIndex  = 4;
				}
				else
				{
					s�ҏW�� = s�Z��.Substring(0,3);
					iIndex  = 3;
				}
				Object obj = h��[s�ҏW��];
				if(obj != null)
				{
					cb��.SelectedIndex = (int)obj;
					s�Z�� = s�Z��.Remove(0,iIndex);
					tex�Z���P.Text = s�Z��;
				}
			}
		}
// ADD 2006.11.06 ���s�j���� �X������ʂ̒ǉ� END

// ADD 2007.12.11 KCL) �X�{ ���m�点�ǉ� START
		protected static bool ���t�`�F�b�N(TextBox tex, string name) 
		{
			bool retValue = true;

			try 
			{
				DateTime dt = DateTime.Parse(tex.Text.Trim());
			} 
			catch 
			{
				MessageBox.Show("���t�� /�i�X���b�V���j, -�i�n�C�t���j, .�i�s���I�h�j ���ŋ�؂��ē��͂��ĉ�����\n�@�� �F 2008/1/1","���̓`�F�b�N",MessageBoxButtons.OK);
				tex.Focus();

				retValue = false;
			}

			return retValue;
		}
		protected static bool �o�C�g���`�F�b�N(TextBox tex, string name, int length) 
		{
			bool retValue = true;

			byte [] byteArray = System.Text.Encoding.Unicode.GetBytes(tex.Text.Trim());
			if (byteArray.Length > length) 
			{
				string msg = string.Format("{0} �ɓ��͂������������������܂�", name, length);
				MessageBox.Show(msg, "���̓`�F�b�N", MessageBoxButtons.OK);
				tex.Focus();

				retValue = false;
			}

			return retValue;
		}
		protected static bool �֑������`�F�b�N(TextBox tex, string name) 
		{
			bool retValue = true;
			string s�֑����� = @"[\a\b\f\t\v\|]";

			MatchCollection matchList = Regex.Matches(tex.Text.Trim(), s�֑�����);
			if (matchList.Count > 0)
			{
				string matchChar = " ";
				foreach (Match m in matchList) 
				{
					matchChar += string.Format("{0} ", m.Value);
				}
				string msg = string.Format("{0} �Ɏg�p�ł��Ȃ�����{1}���܂܂�Ă��܂�", name, matchChar);
				MessageBox.Show(msg, "���̓`�F�b�N", MessageBoxButtons.OK);
				tex.Focus();

				retValue = false;
			}

			return retValue;
		}
		protected static bool �t�q�k�`�F�b�N(TextBox tex, string name) 
		{
			bool retValue = true;
			string s�t�q�k = @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";

			if (! Regex.IsMatch(tex.Text.Trim(), s�t�q�k)) 
			{
				string msg = string.Format("{0} ���t�q�k�̌`���ł͂���܂���", name);
				MessageBox.Show(msg, "���̓`�F�b�N", MessageBoxButtons.OK);
				tex.Focus();

				retValue = false;
			}

			return retValue;
		}
		protected static DateTime YYYYMMDD�ϊ�(string sDate) 
		{
			DateTime retValue;

			try 
			{
				retValue = DateTime.ParseExact(
					sDate, 
					"yyyyMMdd",
					System.Globalization.DateTimeFormatInfo.InvariantInfo,
					System.Globalization.DateTimeStyles.None);
			} 
			catch 
			{
				retValue = DateTime.MinValue;
			}

			return retValue;
		}
// ADD 2007.12.11 KCL) �X�{ ���m�点�ǉ� END

// ADD 2008.04.11 ACT Vista�Ή� START
		protected static void �����ϊ��n�b�V���ݒ�()
		{
			string [,] s�����ϊ� = CharConvUtility.CharConvUtility.GetCharConvTable();
			gh�����ϊ�  = new Hashtable();
			for(int iCnt = 0; iCnt < s�����ϊ�.GetLength(0); iCnt++)
			{
				gh�����ϊ�.Add(s�����ϊ�[iCnt,0],s�����ϊ�[iCnt,1]);
			}
		}

		private static bool �����ϊ�(TextBox tex, string name, ref string sUnicode, ref byte[] bSjis)
		{
			string sErrChars = "";
			string sOKHChars = "";
			string sNotHChars = "";
			string sAllChars = "";
			string sBefChars = "";
			string sMessage = "";
			string sMessage2 = "";
			string sAfterCode = null;
			int iNotHash = 0;

			string sOneMozi = "";
			string sOneUni = "";
			System.Text.Encoding enc = System.Text.Encoding.GetEncoding("unicodeFFFE");
			//������̒�����1���������o��
			System.Globalization.TextElementEnumerator Enumerator = System.Globalization.StringInfo.GetTextElementEnumerator(sUnicode);
			while (Enumerator.MoveNext())
			{
				sOneMozi = Enumerator.Current.ToString();

				//���o����1�������o�C�g�^�ɕϊ�
				byte[] bOneCode = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sOneMozi);
				//�o�C�g�^��string�^�ɕϊ�
				string sRevUnicode = System.Text.Encoding.GetEncoding("shift-jis").GetString(bOneCode);

				if(sOneMozi != sRevUnicode)
				{
					//�ϊ��e�[�u����8���Ή�
					byte [] bytes = enc.GetBytes(sOneMozi);
					sOneUni = BitConverter.ToString(bytes).Replace("-","");
					if(sOneUni.Length == 4)
					{
						sOneUni += sOneUni;
					}
					//�����ϊ�
					sAfterCode = (string)gh�����ϊ�[sOneUni];
					if(sAfterCode != null)
					{
						if(sAfterCode == "" || sAfterCode == "4040")
						{	
							//�ϊ��ł��Ȃ���������
							sNotHChars += sOneMozi;
							sAllChars += sOneMozi;
						}
						else
						{
							//�R�[�h���當�����擾
							int iAfter = Convert.ToInt16(sAfterCode,16);
							char cAfter = (char)iAfter;
							string sAfterL = Convert.ToString(cAfter);
							//�ϊ���̕�������
							sOKHChars += sAfterL;
							sAllChars += sAfterL;
							//�ϊ��O�̕�������
							sBefChars += sOneMozi;
						}	
					}
					else
					{
						//�e�[�u���ɑ��݂��Ȃ���������
						sErrChars += sOneMozi;
						sAllChars += sOneMozi;
						sAfterCode = "";
						iNotHash = 1;					
					}	
				}
				else
				{	
					sAllChars += sOneMozi;
				}
			}
			Enumerator.Reset();

			bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sAllChars);
			string sBefMozi = "";
			sBefMozi = sUnicode;

			if(sAfterCode != null)
			{
				if(sNotHChars.Length > 0)
				{
					sMessage = "2";
				}
				else if(sOKHChars.Length > 0)
				{
					sMessage = "1";
				}
			}

			if(iNotHash == 1)
			{
				sMessage2 = "3";
			}

			if(sMessage == "1")
			{
				tex.Text = sAllChars;
				DialogResult result = MessageBox.Show(name + "��Vista�Ή��ɂ�蕶���ϊ��������Ȃ��܂���\n" 
					+ "�w" + sBefChars + " �� " + sOKHChars + "�x", "���̓`�F�b�N", 
					MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				if (result == DialogResult.Cancel)
				{
					tex.Text = sBefMozi;
					tex.Focus();
					return false;
				}
				else
				{
					sUnicode = sAllChars;
				}
			}
			if(sMessage == "2")
			{
				MessageBox.Show(name + "��Vista�Ή��ɂ�蕶���ϊ��������Ȃ��܂���ł���\n"
					+ "�w" + sNotHChars + " �� ? �x",
					"���̓`�F�b�N",MessageBoxButtons.OK);
				if(sMessage2 != "3")
				{
					tex.Focus();
					return false;
				}
			}
			if(sMessage2 == "3")
			{
				MessageBox.Show(name + "�Ɏg�p�ł��Ȃ�����������܂�\n"
					+ "�w" + sErrChars + " �� ? �x",
					"���̓`�F�b�N",MessageBoxButtons.OK);
				tex.Focus();
				return false;
			}
			return true;
		}
// ADD 2008.04.11 ACT Vista�Ή� END
	}
}
