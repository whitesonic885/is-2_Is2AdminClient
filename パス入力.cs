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
	/// [�p�X����]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2013.07.12 tdi�j�j�V �����e���g���ڊǐ惍�O�C���Ή�
	//--------------------------------------------------------------------------
	// // ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή�
	//--------------------------------------------------------------------------
	public class �p�X���� : ���ʃt�H�[��
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn�L�����Z��;
		private System.Windows.Forms.PictureBox pic���O�I��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�p�X���[�h;
		private System.Windows.Forms.Button btn�p�X����;
		private System.ComponentModel.IContainer components = null;

		public �p�X����()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(�p�X����));
			this.panel1 = new System.Windows.Forms.Panel();
			this.tex�p�X���[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn�L�����Z�� = new System.Windows.Forms.Button();
			this.pic���O�I�� = new System.Windows.Forms.PictureBox();
			this.lab����R�[�h = new System.Windows.Forms.Label();
			this.lab�p�X���[�h = new System.Windows.Forms.Label();
			this.lab���p�҃R�[�h = new System.Windows.Forms.Label();
			this.btn�p�X���� = new System.Windows.Forms.Button();
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
			this.panel1.Controls.Add(this.tex�p�X���[�h);
			this.panel1.Controls.Add(this.btn�L�����Z��);
			this.panel1.Controls.Add(this.pic���O�I��);
			this.panel1.Controls.Add(this.lab����R�[�h);
			this.panel1.Controls.Add(this.lab�p�X���[�h);
			this.panel1.Controls.Add(this.lab���p�҃R�[�h);
			this.panel1.Controls.Add(this.btn�p�X����);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(364, 226);
			this.panel1.TabIndex = 0;
			// 
			// tex�p�X���[�h
			// 
			this.tex�p�X���[�h.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�p�X���[�h.Location = new System.Drawing.Point(168, 98);
			this.tex�p�X���[�h.MaxLength = 10;
			this.tex�p�X���[�h.Name = "tex�p�X���[�h";
			this.tex�p�X���[�h.Size = new System.Drawing.Size(92, 22);
			this.tex�p�X���[�h.TabIndex = 3;
			this.tex�p�X���[�h.Text = "";
			this.tex�p�X���[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�p�X���[�h_KeyDown);
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
			this.lab����R�[�h.Size = new System.Drawing.Size(232, 14);
			this.lab����R�[�h.TabIndex = 0;
			this.lab����R�[�h.Text = "�L�����Z�����͒ʏ�X���Ń��O�C�����܂��B";
			// 
			// lab�p�X���[�h
			// 
			this.lab�p�X���[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�p�X���[�h.ForeColor = System.Drawing.Color.Black;
			this.lab�p�X���[�h.Location = new System.Drawing.Point(90, 102);
			this.lab�p�X���[�h.Name = "lab�p�X���[�h";
			this.lab�p�X���[�h.Size = new System.Drawing.Size(76, 14);
			this.lab�p�X���[�h.TabIndex = 48;
			this.lab�p�X���[�h.Text = "�p�X���[�h�F";
			// 
			// lab���p�҃R�[�h
			// 
			this.lab���p�҃R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���p�҃R�[�h.ForeColor = System.Drawing.Color.Black;
			this.lab���p�҃R�[�h.Location = new System.Drawing.Point(86, 58);
			this.lab���p�҃R�[�h.Name = "lab���p�҃R�[�h";
			this.lab���p�҃R�[�h.Size = new System.Drawing.Size(158, 14);
			this.lab���p�҃R�[�h.TabIndex = 42;
			this.lab���p�҃R�[�h.Text = "�p�X���[�h����͂��Ă��������B";
			// 
			// btn�p�X����
			// 
			this.btn�p�X����.ForeColor = System.Drawing.Color.Black;
			this.btn�p�X����.Location = new System.Drawing.Point(62, 158);
			this.btn�p�X����.Name = "btn�p�X����";
			this.btn�p�X����.Size = new System.Drawing.Size(100, 22);
			this.btn�p�X����.TabIndex = 4;
			this.btn�p�X����.Text = "�n�j";
			this.btn�p�X����.Click += new System.EventHandler(this.btn�p�X����_Click);
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
			// �p�X����
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(354, 216);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(362, 224);
			this.Name = "�p�X����";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "is-2 �p�X���[�h����";
// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� START
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On�G���^�[�ړ�);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On�G���^�[�L�����Z��);
// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� END
            this.Load += new System.EventHandler(this.�p�X����_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� START
        protected void On�G���^�[�ړ�(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.�G���^�[�ړ�(sender, e);
        }

        protected void On�G���^�[�L�����Z��(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            base.�G���^�[�L�����Z��(sender, e);
        }
// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� END

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>
		private void btn�p�X����_Click(object sender, System.EventArgs e)
		{
			�p�X���͔F��();
		}
		
		private void �p�X���͔F��()
		{
			// ADD 2013.07.12 tdi�j�j�V �����e���g���ڊǐ惍�O�C���Ή� START
			tex�p�X���[�h.Text = tex�p�X���[�h.Text.Trim();
			//�p�X���[�h��������
			if(tex�p�X���[�h.Text.Length == 0)
			{
				//�����̓��b�Z�[�W�\������
				MessageBox.Show("���̓G���[�F�p�X���[�h�����͂���Ă��܂���B", "�p�X���[�h����", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			//���p�`�F�b�N����
			if(!���p�`�F�b�N(tex�p�X���[�h, "�p�X���[�h")) return;

			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				//�p�X���[�h�`�F�b�N����
// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� START
//				if (tex�p�X���[�h.Text.ToUpper() == "211TOKYO")
//				{
//					//�F�؂n�j
//					this.DialogResult = DialogResult.OK;
//					this.Close();
//				}
//				else
//				{
//					//�F�؃G���[
//					MessageBox.Show("���̓G���[�F�p�X���[�h�Ɍ�肪����܂��B", "�p�X���[�h����", 
//						MessageBoxButtons.OK, MessageBoxIcon.Error);
//					tex�p�X���[�h.Focus();
//				}
				/* ������������������������������������������
				 * (��) ����{��ʂ��g�p����ꍇ�A
				 *      �p�X���[�h�`�F�b�N������
				 *      else��̑O�ɑ}�����Ēǉ����ĉ������B
				 * ������������������������������������������ */
				bool b�F�ؐ����e�f = false;
				if(gs�X���R�[�h == "517")
				{
					// ���R��^���R�����O�C���̏ꍇ
					if (tex�p�X���[�h.Text.ToUpper() == "516MINAMI")
					{
						//�F�؂n�j
						b�F�ؐ����e�f = true;
					}
				}
				else
				{
					// �����e���g���ڊǐ惍�O�C���̏ꍇ
					if (tex�p�X���[�h.Text.ToUpper() == "211TOKYO")
					{
						//�F�؂n�j
						b�F�ؐ����e�f = true;
					}
				}

				if(b�F�ؐ����e�f)
				{
					//�F�؂n�j
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					//�F�؃G���[
					MessageBox.Show("���̓G���[�F�p�X���[�h�Ɍ�肪����܂��B", "�p�X���[�h����", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					tex�p�X���[�h.Focus();
				}
// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� END
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
			tex�p�X���[�h.Focus();
		}


		private void btn�L�����Z��_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void �p�X����_Load(object sender, System.EventArgs e)
		{
			pic���O�I��.Image = Image.FromFile(gs�A�v���t�H���_ + "\\img\\login.gif");
			tex�p�X���[�h.PasswordChar = '*';
// ADD 2015.11.17 bevas�j���{ ���R�샍�O�C���Ή��i���R���Ƃ̃��O�C���U�������j START
			// ���R��E���R���̃��O�C���U���̏ꍇ�A�L�����Z�����̋������b�Z�[�W��ύX����
			if(gs�X���R�[�h == "517")
			{
				lab����R�[�h.Text = "�L�����Z�����͉��R���x�X�Ń��O�C�����܂��B";
			}
// ADD 2015.11.17 bevas�j���{ ���R�샍�O�C���Ή��i���R���Ƃ̃��O�C���U�������j END
			tex�p�X���[�h.Focus();
		}

		private void tex�p�X���[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex�p�X���[�h.Text = tex�p�X���[�h.Text.Trim();
				if(tex�p�X���[�h.Text.Length > 0)
					�p�X���͔F��();
			}
		}
	}
}
