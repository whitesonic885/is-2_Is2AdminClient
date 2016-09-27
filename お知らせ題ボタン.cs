using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace is2AdminClient
{
	/// <summary>
	/// [���m�点�\��{�^��]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// MOD 2010.06.01 ���s�j���� ���j���[�̃��C�A�E�g�\�����̏�Q�Ή� 
	//--------------------------------------------------------------------------
	// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C
	//                            �i�\��̐擪�Ɂu�y�d�v�z�v���t�����̂̓{�^���̐F��ς���j
	//--------------------------------------------------------------------------
	public class ���m�点�\��{�^�� : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.PictureBox pic�\��;
		private System.Windows.Forms.Label lab���t;
		private System.Windows.Forms.Label lab�\��;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// �\���\���������̃t�H���g�T�C�Y�ł��B
		/// </summary>
		private readonly float _OriginalFontSize;
		/// <summary>
		/// �w�i�Ɏg�p����C���[�W�̃��X�g�ł��B
		/// </summary>
		private Image [] _ImageList;
		/// <summary>
		/// �I�����̕����F�ł��B
		/// </summary>
		private readonly Color _SelectedColor = Color.FromArgb(102, 102, 255);
		/// <summary>
		/// ���I�����̕����F�ł��B
		/// </summary>
		private readonly Color _UnSelectedColor = Color.SeaGreen;
		/// <summary>
		/// �I�����̕����F�Q�ł��B
		/// </summary>
		private readonly Color _SelectedColor2 = Color.DarkOrange;
		/// <summary>
		/// ���I�����̕����F�Q�ł��B
		/// </summary>
//		private readonly Color _UnSelectedColor2 = Color.Orange;
//		private readonly Color _UnSelectedColor2 = Color.FromArgb(254, 172, 0);
		private readonly Color _UnSelectedColor2 = Color.FromArgb(224, 163, 0);
//		private readonly Color _UnSelectedColor2 = Color.DarkOrange;
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C START
		/// <summary>
		/// �I�����̕����F�R�ł��B
		/// </summary>
		private readonly Color _SelectedColor3 = Color.FromArgb(254,  80, 60);
		/// <summary>
		/// ���I�����̕����F�R�ł��B
		/// </summary>
		private readonly Color _UnSelectedColor3 = Color.FromArgb(254, 123, 85);
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C END
		/// <summary>
		/// �{�^���̕����F���[�h�ł��B
		/// </summary>
		private int _Mode = 0;

		#region �C�x���g
		/// <summary>
		/// ���̃��[�U�[�R���g���[�����N���b�N�������ɔ�������C�x���g�ł��B
		/// </summary>
		public event EventHandler ButtonClicked;

		/// <summary>
		/// ���̃��[�U�[�R���g���[���̃N���b�N�C�x���g�����ł��B
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnButtonClicked(EventArgs e) 
		{
			if (ButtonClicked != null) 
				ButtonClicked(this, e);
		}
		#endregion

		#region �v���p�e�B
		/// <summary>
		/// �\��������t��ݒ肵�܂��B
		/// </summary>
		public string ���t 
		{
			set { lab���t.Text = (value == null) ? string.Empty : value; }
		}
		/// <summary>
		/// �\������\���ݒ肵�܂��B
		/// </summary>
		public string �\�� 
		{
			set 
			{ 
				if (value == null) 
				{
					lab�\��.Text = string.Empty;
				} 
				else 
				{
					this.SetStringToLabel(value, lab�\��);
				}
			}
		}
		/// <summary>
		/// �����F���[�h��ݒ肵�܂��B
		/// </summary>
		public int ���[�h 
		{
			set
			{
				_Mode = value;
				switch(_Mode){
				case 1:
					pic�\��.Image     = _ImageList[2];
					lab���t.ForeColor = _UnSelectedColor2;
					lab�\��.ForeColor = _UnSelectedColor2;
					break;
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C START
					case 2:
						pic�\��.Image     = _ImageList[4];
						lab���t.ForeColor = _UnSelectedColor3;
						lab�\��.ForeColor = _UnSelectedColor3;
						break;
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C END
				default:
					pic�\��.Image     = _ImageList[0];
					lab���t.ForeColor = _UnSelectedColor;
					lab�\��.ForeColor = _UnSelectedColor;
					break;
				}
			}
		}
		#endregion

		/// <summary>
		/// �R���X�g���N�^�ł��B
		/// </summary>
		public ���m�点�\��{�^��()
		{
			// ���̌Ăяo���́AWindows.Forms �t�H�[�� �f�U�C�i�ŕK�v�ł��B
			InitializeComponent();

			// �C���[�W���X�g�̏�����
			this.InitImageList();

			// �w�i�̐ݒ�
			pic�\��.Image = _ImageList[0];

			// �t�H���g�T�C�Y�̋K��l���擾
			_OriginalFontSize = lab�\��.Font.Size;

			// �t�H���g�J���[�̐ݒ�
			lab���t.ForeColor = _UnSelectedColor;
			lab�\��.ForeColor = _UnSelectedColor;
		}

		#region �C���[�W���X�g�̏�����
		/// <summary>
		/// �C���[�W���X�g�����������܂��B
		/// </summary>
		private void InitImageList()
		{
			if (_ImageList != null) return;

// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C START
//			_ImageList = new Image[4];
			_ImageList = new Image[6];
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C END
// MOD 2010.06.01 ���s�j���� ���j���[�̃��C�A�E�g�\�����̏�Q�Ή� START
			try
			{
// MOD 2010.06.01 ���s�j���� ���j���[�̃��C�A�E�g�\�����̏�Q�Ή� END
				_ImageList[0] = Image.FromFile("img\\fm601a.gif");
				_ImageList[1] = Image.FromFile("img\\fm601b.gif");
				_ImageList[2] = Image.FromFile("img\\fm602a.gif");
				_ImageList[3] = Image.FromFile("img\\fm602b.gif");
// MOD 2010.06.01 ���s�j���� ���j���[�̃��C�A�E�g�\�����̏�Q�Ή� START
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C START
				_ImageList[4] = Image.FromFile("img\\fm603a.gif");
				_ImageList[5] = Image.FromFile("img\\fm603b.gif");
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C END
			}
			catch(Exception)
			{
				_ImageList[0] = Image.FromFile(@"bin\Debug\img\fm601a.gif");
				_ImageList[1] = Image.FromFile(@"bin\Debug\img\fm601b.gif");
				_ImageList[2] = Image.FromFile(@"bin\Debug\img\fm602a.gif");
				_ImageList[3] = Image.FromFile(@"bin\Debug\img\fm602b.gif");
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C START
				_ImageList[4] = Image.FromFile(@"bin\Debug\img\fm603a.gif");
				_ImageList[5] = Image.FromFile(@"bin\Debug\img\fm603b.gif");
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C END
			}
// MOD 2010.06.01 ���s�j���� ���j���[�̃��C�A�E�g�\�����̏�Q�Ή� END
		}
		#endregion

		/// <summary>
		/// �g�p����Ă��郊�\�[�X�Ɍ㏈�������s���܂��B
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region �R���|�[�l���g �f�U�C�i�Ő������ꂽ�R�[�h 
		/// <summary>
		/// �f�U�C�i �T�|�[�g�ɕK�v�ȃ��\�b�h�ł��B���̃��\�b�h�̓��e��
		/// �R�[�h �G�f�B�^�ŕύX���Ȃ��ł��������B
		/// </summary>
		private void InitializeComponent()
		{
			this.pic�\�� = new System.Windows.Forms.PictureBox();
			this.lab���t = new System.Windows.Forms.Label();
			this.lab�\�� = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pic�\��
			// 
			this.pic�\��.Location = new System.Drawing.Point(0, 0);
			this.pic�\��.Name = "pic�\��";
			this.pic�\��.Size = new System.Drawing.Size(482, 42);
			this.pic�\��.TabIndex = 0;
			this.pic�\��.TabStop = false;
			this.pic�\��.Click += new System.EventHandler(this.���m�点�\��_Click);
			this.pic�\��.MouseEnter += new System.EventHandler(this.���m�点�\��_MouseEnter);
			this.pic�\��.MouseLeave += new System.EventHandler(this.���m�点�\��_MouseLeave);
			// 
			// lab���t
			// 
			this.lab���t.BackColor = System.Drawing.Color.Transparent;
			this.lab���t.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���t.ForeColor = System.Drawing.Color.SeaGreen;
			this.lab���t.Location = new System.Drawing.Point(44, 20);
			this.lab���t.Name = "lab���t";
			this.lab���t.Size = new System.Drawing.Size(94, 16);
			this.lab���t.TabIndex = 1;
			this.lab���t.Text = "9999/99/99";
			this.lab���t.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lab���t.Click += new System.EventHandler(this.���m�点�\��_Click);
			this.lab���t.MouseEnter += new System.EventHandler(this.���m�点�\��_MouseEnter);
			this.lab���t.MouseLeave += new System.EventHandler(this.���m�点�\��_MouseLeave);
			// 
			// lab�\��
			// 
			this.lab�\��.BackColor = System.Drawing.Color.Transparent;
			this.lab�\��.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\��.ForeColor = System.Drawing.Color.SeaGreen;
			this.lab�\��.Location = new System.Drawing.Point(136, 12);
			this.lab�\��.Name = "lab�\��";
			this.lab�\��.Size = new System.Drawing.Size(344, 22);
			this.lab�\��.TabIndex = 2;
			this.lab�\��.Text = "����������������������������������������";
			this.lab�\��.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lab�\��.Click += new System.EventHandler(this.���m�点�\��_Click);
			this.lab�\��.MouseEnter += new System.EventHandler(this.���m�点�\��_MouseEnter);
			this.lab�\��.MouseLeave += new System.EventHandler(this.���m�点�\��_MouseLeave);
			// 
			// ���m�点�\��{�^��
			// 
			this.Controls.Add(this.lab�\��);
			this.Controls.Add(this.lab���t);
			this.Controls.Add(this.pic�\��);
			this.Name = "���m�点�\��{�^��";
			this.Size = new System.Drawing.Size(482, 42);
			this.ResumeLayout(false);

		}
		#endregion

		private void ���m�点�\��_MouseEnter(object sender, System.EventArgs e)
		{
			switch(_Mode){
			case 1:
				pic�\��.Image     = _ImageList[3];
				lab���t.ForeColor = _SelectedColor2;
				lab�\��.ForeColor = _SelectedColor2;
				break;
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C START
				case 2:
					pic�\��.Image     = _ImageList[5];
					lab���t.ForeColor = _SelectedColor3;
					lab�\��.ForeColor = _SelectedColor3;
					break;
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C END
			default:
				pic�\��.Image     = _ImageList[1];
				lab���t.ForeColor = _SelectedColor;
				lab�\��.ForeColor = _SelectedColor;
				break;
			}
		}

		private void ���m�点�\��_MouseLeave(object sender, System.EventArgs e)
		{
			switch(_Mode){
			case 1:
				pic�\��.Image     = _ImageList[2];
				lab���t.ForeColor = _UnSelectedColor2;
				lab�\��.ForeColor = _UnSelectedColor2;
				break;
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C START
				case 2:
					pic�\��.Image     = _ImageList[4];
					lab���t.ForeColor = _UnSelectedColor3;
					lab�\��.ForeColor = _UnSelectedColor3;
					break;
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C END
			default:
				pic�\��.Image     = _ImageList[0];
				lab���t.ForeColor = _UnSelectedColor;
				lab�\��.ForeColor = _UnSelectedColor;
				break;
			}
		}

		private void ���m�点�\��_Click(object sender, System.EventArgs e)
		{
			this.OnButtonClicked(EventArgs.Empty);
		}

		#region ���x���ւ̕�����ݒ�
		/// <summary>
		/// ���x���ɕ������ݒ肵�܂��B
		/// �����񂪒������ĕ\���ł��Ȃ����́A�����I�Ƀt�H���g�����������ĕ\�����܂��B
		/// </summary>
		/// <param name="str">�\�����镶����</param>
		/// <param name="label">�������\�����郉�x��</param>
		private void SetStringToLabel(string str, Label label) 
		{
			// �t�H���g�T�C�Y���f�t�H���g�ɖ߂�
			label.Font = new Font(label.Font.FontFamily, _OriginalFontSize, label.Font.Style);

			// �����񕝂̎擾
			Font fnt = label.Font;
			// �P�����̍ő�T�C�Y�i�����������̂��炢����΂����H�j
			int charSize = Convert.ToInt32(fnt.Size * 2);
			// ���x���ɕ\���������̂P�s�̍ő啝
			int width    = this.GetStringWidth(str, fnt, label.Width, label.Height);
			// ������S�̂̕�
			int maxWidth = this.GetStringWidth(str, fnt, charSize * str.Length, charSize);

			if (width < maxWidth) 
			{
				// �͂��肫��Ȃ��ꍇ�@�|�@�t�H���g�T�C�Y������������

				// �ŏ��̈��́A�{���ɂ��t�H���g�T�C�Y���v�Z
				float ritsu = (float) width / (float) maxWidth;
				// �ł��邾���傫���T�C�Y�ŕ\������ׁA�v�Z���ʂ��P�傫���T�C�Y����X�^�[�g����
				float fntSize = fnt.Size * ritsu + 1;
				fnt = new Font(fnt.FontFamily, fntSize, fnt.Style);
				charSize = Convert.ToInt32(fntSize * 2);
				width    = this.GetStringWidth(str, fnt, label.Width, label.Height);
				maxWidth = this.GetStringWidth(str, fnt, charSize * str.Length, charSize);

				while (width < maxWidth) 
				{
					// ���ڈȍ~�́A0.1 ���݂ŏ��������Ă����i�������j
					fntSize = fnt.Size - (float) 0.1;
					fnt = new Font(fnt.FontFamily, fntSize, fnt.Style);
					charSize = Convert.ToInt32(fntSize * 2);
					width    = this.GetStringWidth(str, fnt, label.Width, label.Height);
					maxWidth = this.GetStringWidth(str, fnt, charSize * str.Length, charSize);
				}

				// �t�H���g�ݒ聕������\��
				label.Font = fnt;
				label.Text = str;
			} 
			else 
			{
				// �͂���ꍇ�@�|�@���̂܂ܕ\��

				// ���x���ɕ\��
				label.Text = str;
			}
		}
		#endregion

		#region �����񕝂̎擾
		/// <summary>
		/// ������̕����擾���܂��B
		/// </summary>
		/// <param name="str">�����擾���镶����</param>
		/// <param name="fnt">������̃t�H���g</param>
		/// <param name="layoutWidth">�������\������̈�̕�</param>
		/// <param name="layoutHeight">�������\������̈�̍���</param>
		/// <returns>������̕�</returns>
		private int GetStringWidth(string str, Font fnt, int layoutWidth, int layoutHeight) 
		{
			int width = 0;

			// PictureBox �� Graphics �I�u�W�F�N�g���擾
			PictureBox pbox = new PictureBox();
			Graphics g = pbox.CreateGraphics();

			// �������`��
			StringFormat sf = new StringFormat();
			//g.DrawString(str, fnt, Brushes.Black, 0, 0, sf);
			CharacterRange [] charRanges = { new CharacterRange(0, str.Length) };
			sf.SetMeasurableCharacterRanges(charRanges);

			// ������̃��C�A�E�g�l�p�`���w��
			RectangleF layoutRect = new RectangleF(0, 0, layoutWidth, layoutHeight);

			// ������ɊO�ڂ��� Region �z����擾
			Region [] strRegions = g.MeasureCharacterRanges(str, fnt, layoutRect, sf);

			// �擾����������̑傫�����g���ĕ����񕝂��擾
			RectangleF rect = strRegions[0].GetBounds(g);
			width = Rectangle.Round(rect).Width;

			// ���\�[�X���J��
			g.Dispose();

			return width;
		}
		#endregion
	}
}
