using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace is2AdminClient
{
	/// <summary>
	/// [�X������]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2007.01.20 ���s�j���� ��ʒ��� 
	// DEL 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX 
	// MOD 2007.02.06 ���s�j���� �C���[�W���[�h�G���[�Ή� 
	//--------------------------------------------------------------------------
	public class �X������ : ���ʃt�H�[��
	{
// DEL 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX START
//		public bool b�F�� = false;
// DEL 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Label lab�p�X���[�h;
		private System.Windows.Forms.Label lab����R�[�h;
		private System.Windows.Forms.Label lab���p�҃R�[�h;
		private System.Windows.Forms.Button btn�X������;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn�L�����Z��;
		private System.Windows.Forms.PictureBox pic���O�I��;
		private ���ʃe�L�X�g�{�b�N�X tex�X���R�[�h;
		private System.ComponentModel.IContainer components = null;

		public �X������()
		{
			//
			// Windows �t�H�[�� �f�U�C�i �T�|�[�g�ɕK�v�ł��B
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent �Ăяo���̌�ɁA�R���X�g���N�^ �R�[�h��ǉ����Ă��������B
			//
		}

		/// <summary>
		/// �g�p����Ă��郊�\�[�X�Ɍ㏈�������s���܂��B
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h 
		/// <summary>
		/// �f�U�C�i �T�|�[�g�ɕK�v�ȃ��\�b�h�ł��B���̃��\�b�h�̓��e��
		/// �R�[�h �G�f�B�^�ŕύX���Ȃ��ł��������B
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(�X������));
			this.panel1 = new System.Windows.Forms.Panel();
			this.tex�X���R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn�L�����Z�� = new System.Windows.Forms.Button();
			this.pic���O�I�� = new System.Windows.Forms.PictureBox();
			this.lab����R�[�h = new System.Windows.Forms.Label();
			this.lab�p�X���[�h = new System.Windows.Forms.Label();
			this.lab���p�҃R�[�h = new System.Windows.Forms.Label();
			this.btn�X������ = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Controls.Add(this.tex�X���R�[�h);
			this.panel1.Controls.Add(this.btn�L�����Z��);
			this.panel1.Controls.Add(this.pic���O�I��);
			this.panel1.Controls.Add(this.lab����R�[�h);
			this.panel1.Controls.Add(this.lab�p�X���[�h);
			this.panel1.Controls.Add(this.lab���p�҃R�[�h);
			this.panel1.Controls.Add(this.btn�X������);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(364, 226);
			this.panel1.TabIndex = 0;
			// 
			// tex�X���R�[�h
			// 
			this.tex�X���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�X���R�[�h.Location = new System.Drawing.Point(168, 98);
			this.tex�X���R�[�h.MaxLength = 3;
			this.tex�X���R�[�h.Name = "tex�X���R�[�h";
			this.tex�X���R�[�h.Size = new System.Drawing.Size(36, 22);
			this.tex�X���R�[�h.TabIndex = 3;
			this.tex�X���R�[�h.Text = "";
			this.tex�X���R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�X���R�[�h_KeyDown);
			// 
			// btn�L�����Z��
			// 
			this.btn�L�����Z��.Location = new System.Drawing.Point(214, 158);
			this.btn�L�����Z��.Name = "btn�L�����Z��";
			this.btn�L�����Z��.Size = new System.Drawing.Size(100, 22);
			this.btn�L�����Z��.TabIndex = 5;
			this.btn�L�����Z��.Text = "�L�����Z��";
			this.btn�L�����Z��.Click += new System.EventHandler(this.btn�L�����Z��_Click);
			// 
			// pic���O�I��
			// 
			this.pic���O�I��.Image = ((System.Drawing.Image)(resources.GetObject("pic���O�I��.Image")));
			this.pic���O�I��.Location = new System.Drawing.Point(-2, -18);
			this.pic���O�I��.Name = "pic���O�I��";
			this.pic���O�I��.Size = new System.Drawing.Size(366, 66);
			this.pic���O�I��.TabIndex = 49;
			this.pic���O�I��.TabStop = false;
			// 
			// lab����R�[�h
			// 
			this.lab����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab����R�[�h.ForeColor = System.Drawing.Color.Black;
			this.lab����R�[�h.Location = new System.Drawing.Point(86, 76);
			this.lab����R�[�h.Name = "lab����R�[�h";
			this.lab����R�[�h.Size = new System.Drawing.Size(206, 14);
			this.lab����R�[�h.TabIndex = 0;
			this.lab����R�[�h.Text = "�󔒂̏ꍇ�͊Ǘ��҃��j���[�ɂȂ�܂��B";
			// 
			// lab�p�X���[�h
			// 
			this.lab�p�X���[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�p�X���[�h.ForeColor = System.Drawing.Color.Black;
			this.lab�p�X���[�h.Location = new System.Drawing.Point(90, 102);
			this.lab�p�X���[�h.Name = "lab�p�X���[�h";
			this.lab�p�X���[�h.Size = new System.Drawing.Size(76, 14);
			this.lab�p�X���[�h.TabIndex = 48;
			this.lab�p�X���[�h.Text = "�X���R�[�h�F";
			// 
			// lab���p�҃R�[�h
			// 
			this.lab���p�҃R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���p�҃R�[�h.ForeColor = System.Drawing.Color.Black;
			this.lab���p�҃R�[�h.Location = new System.Drawing.Point(86, 58);
			this.lab���p�҃R�[�h.Name = "lab���p�҃R�[�h";
			this.lab���p�҃R�[�h.Size = new System.Drawing.Size(128, 14);
			this.lab���p�҃R�[�h.TabIndex = 42;
			this.lab���p�҃R�[�h.Text = "�X������͂��Ă��������B";
			// 
			// btn�X������
			// 
			this.btn�X������.ForeColor = System.Drawing.Color.Black;
			this.btn�X������.Location = new System.Drawing.Point(62, 158);
			this.btn�X������.Name = "btn�X������";
			this.btn�X������.Size = new System.Drawing.Size(100, 22);
			this.btn�X������.TabIndex = 4;
			this.btn�X������.Text = "�n�j";
			this.btn�X������.Click += new System.EventHandler(this.btn�X������_Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(0, 0);
			this.button13.Name = "button13";
			this.button13.TabIndex = 0;
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(0, 0);
			this.button12.Name = "button12";
			this.button12.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(-2, -6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(364, 234);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// �X������
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(354, 190);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(362, 224);
			this.Name = "�X������";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "is-2 �X������";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.�X������_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>
		private void btn�X������_Click(object sender, System.EventArgs e)
		{
			�X�����͔F��();
		}
		
		private void �X�����͔F��()
		{
// DEL 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX START
//			if(tex�X���R�[�h.Text.Trim().Length != 0)
//			{
//				if(!�K�{�`�F�b�N(tex�X���R�[�h, "�X���R�[�h")) return;
//				if(!���l�`�F�b�N(tex�X���R�[�h, "�X���R�[�h")) return;
//				gs�X���R�[�h = tex�X���R�[�h.Text.Trim().PadLeft(3,'0');
//				if(gs�X���R�[�h.StartsWith("0") == true)
//				{
//					gs�X���R�[�h   = "";
//				}
//			}
//			else
//			{
//				gs�X���R�[�h   = "";
//			}
//
//			if(gs�X���R�[�h.Trim().Length != 0)
//			{
//				try
//				{
//					string[] sKeyT = new string[1];
//					sKeyT[0] = gs�X���R�[�h;
//					string[] sList = sv_maintenance.Sel_Shop(gsa���[�U, sKeyT);
//					if(!sList[0].Equals("����I��"))
//					{
//						MessageBox.Show("�F�؃G���[�F�X�������݂��܂���B", "�X������", 
//							MessageBoxButtons.OK, MessageBoxIcon.Error);
//						// ����R�[�h�Ƀt�H�[�J�X
//						�r�[�v��();
//						tex�X���R�[�h.Focus();
//						b�F�� = false;
//						this.Cursor = System.Windows.Forms.Cursors.Default;
//						return;
//					}
//					b�F�� = true;
//				}
//				catch (Exception ex)
//				{
//					b�F�� = false;
//					MessageBox.Show(ex.Message);
//				}
//			}
//			else
//			{
//				b�F�� = true;
//			}
//			this.Cursor = System.Windows.Forms.Cursors.Default;
//
//			// ��ʂ����
//			this.Close();
// DEL 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END
// ADD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX START
			tex�X���R�[�h.Text = tex�X���R�[�h.Text.Trim();
			//�X���R�[�h��������
			if(tex�X���R�[�h.Text.Length == 0)
			{
				gs�X���R�[�h   = "";
				// ��ʂ����
				this.Close();
				return;
			}

			if(!���p�`�F�b�N(tex�X���R�[�h, "�X���R�[�h")) return;
			if(!���l�`�F�b�N(tex�X���R�[�h, "�X���R�[�h")) return;

			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKeyT = new string[1];
				sKeyT[0] = tex�X���R�[�h.Text;
				string[] sList = sv_maintenance.Sel_Shop(gsa���[�U, sKeyT);

				if(sList[0].Equals("����I��"))
				{
					gs�X���R�[�h   = tex�X���R�[�h.Text;
					// ��ʂ����
					this.Close();
					return;
				}
				MessageBox.Show("���̓G���[�F�X�������݂��܂���B", "�X������", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (System.Net.WebException)
			{
				MessageBox.Show(gs�ʐM�G���[);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			�r�[�v��();
			tex�X���R�[�h.Focus();
// ADD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END
		}

		private void btn�L�����Z��_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void �X������_Load(object sender, System.EventArgs e)
		{
// MOD 2007.02.06 ���s�j���� �C���[�W���[�h�G���[�Ή� START
//			pic���O�I��.Image = Image.FromFile("img\\login.gif");
			pic���O�I��.Image = Image.FromFile(gs�A�v���t�H���_ + "\\img\\login.gif");
// MOD 2007.02.06 ���s�j���� �C���[�W���[�h�G���[�Ή� START

// ADD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX START
			lab����R�[�h.Text   = "�X���R�[�h����͂��Ă��������B";
			lab���p�҃R�[�h.Text = "";
			tex�X���R�[�h.Focus();
// ADD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END
		}

// ADD 2007.01.20 ���s�j���� ��ʒ��� START
		private void tex�X���R�[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex�X���R�[�h.Text = tex�X���R�[�h.Text.Trim();
				if(tex�X���R�[�h.Text.Length == 3)
					�X�����͔F��();
			}
		}
// ADD 2007.01.20 ���s�j���� ��ʒ��� END
	}
}
