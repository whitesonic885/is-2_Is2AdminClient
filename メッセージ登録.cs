using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// Form1 �̊T�v�̐����ł��B
	/// </summary>
	public class ���b�Z�[�W�o�^ : ���ʃt�H�[��
	{
		public string s����R�[�h;

		private string   s�X�V���� = "";
		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label lab���b�Z�[�W�^�C�g��;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label lab���b�Z�[�W��;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W��;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn�ۑ�;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ���b�Z�[�W�o�^()
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab���b�Z�[�W�� = new System.Windows.Forms.Label();
			this.tex���b�Z�[�W�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab���b�Z�[�W�^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn�ۑ� = new System.Windows.Forms.Button();
			this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
			this.btn���� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.lab���b�Z�[�W��);
			this.panel1.Controls.Add(this.tex���b�Z�[�W��);
			this.panel1.Location = new System.Drawing.Point(4, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(510, 186);
			this.panel1.TabIndex = 0;
			// 
			// lab���b�Z�[�W��
			// 
			this.lab���b�Z�[�W��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���b�Z�[�W��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���b�Z�[�W��.Location = new System.Drawing.Point(16, 14);
			this.lab���b�Z�[�W��.Name = "lab���b�Z�[�W��";
			this.lab���b�Z�[�W��.Size = new System.Drawing.Size(58, 14);
			this.lab���b�Z�[�W��.TabIndex = 56;
			this.lab���b�Z�[�W��.Text = "���b�Z�[�W��";
			// 
			// tex���b�Z�[�W��
			// 
			this.tex���b�Z�[�W��.BackColor = System.Drawing.SystemColors.Window;
			this.tex���b�Z�[�W��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W��.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex���b�Z�[�W��.Location = new System.Drawing.Point(78, 10);
			this.tex���b�Z�[�W��.MaxLength = 250;
			this.tex���b�Z�[�W��.Multiline = true;
			this.tex���b�Z�[�W��.Name = "tex���b�Z�[�W��";
			this.tex���b�Z�[�W��.Size = new System.Drawing.Size(410, 168);
			this.tex���b�Z�[�W��.TabIndex = 0;
			this.tex���b�Z�[�W��.Text = @"������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab���b�Z�[�W�^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(534, 26);
			this.panel7.TabIndex = 0;
			// 
			// lab���b�Z�[�W�^�C�g��
			// 
			this.lab���b�Z�[�W�^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab���b�Z�[�W�^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���b�Z�[�W�^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab���b�Z�[�W�^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab���b�Z�[�W�^�C�g��.Name = "lab���b�Z�[�W�^�C�g��";
			this.lab���b�Z�[�W�^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab���b�Z�[�W�^�C�g��.TabIndex = 0;
			this.lab���b�Z�[�W�^�C�g��.Text = "���b�Z�[�W�o�^";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btn�ۑ�);
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Location = new System.Drawing.Point(0, 260);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(534, 58);
			this.panel8.TabIndex = 2;
			// 
			// btn�ۑ�
			// 
			this.btn�ۑ�.ForeColor = System.Drawing.Color.Blue;
			this.btn�ۑ�.Location = new System.Drawing.Point(76, 6);
			this.btn�ۑ�.Name = "btn�ۑ�";
			this.btn�ۑ�.Size = new System.Drawing.Size(54, 48);
			this.btn�ۑ�.TabIndex = 0;
			this.btn�ۑ�.Text = "�ۑ�";
			this.btn�ۑ�.Click += new System.EventHandler(this.btn�ۑ�_Click);
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(152, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(376, 50);
			this.tex���b�Z�[�W.TabIndex = 2;
			this.tex���b�Z�[�W.TabStop = false;
			this.tex���b�Z�[�W.Text = "";
			// 
			// btn����
			// 
			this.btn����.ForeColor = System.Drawing.Color.Red;
			this.btn����.Location = new System.Drawing.Point(8, 6);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(54, 48);
			this.btn����.TabIndex = 1;
			this.btn����.TabStop = false;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
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
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(534, 26);
			this.panel6.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(8, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(518, 198);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// ���b�Z�[�W�o�^
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(534, 318);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(540, 350);
			this.Name = "���b�Z�[�W�o�^";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ���b�Z�[�W�o�^";
// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� START
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On�G���^�[�ړ�);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On�G���^�[�L�����Z��);
// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� END
            this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.���b�Z�[�W�o�^_Closed);
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			���b�Z�[�W�ꗗ����();
		}

		private void ���b�Z�[�W�ꗗ����()
		{

			tex���b�Z�[�W��.Text     = "";
			s�X�V����        = "";

			string[] sRet = new string[1];
			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
				sRet = sv_maintenance.Sel_Syskanri(gsa���[�U,"is2" );
			}
			catch (Exception ex)
			{
				sRet[0] = "�ʐM�G���[�F" + ex.Message;
			}
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			if(sRet[0].Length == 4) //����I��
			{
				tex���b�Z�[�W.Text   = "";
				tex���b�Z�[�W��.Text = sRet[1];
				s�X�V����            = sRet[2];
			}
			else
			{
				tex���b�Z�[�W.Text = sRet[0];
				�r�[�v��();
			}
		}
		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn�ۑ�_Click(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W��.Text     = tex���b�Z�[�W��.Text.Trim();

			if(!�S�p�`�F�b�N(tex���b�Z�[�W��,"���b�Z�[�W��")) return;

			try
			{
				tex���b�Z�[�W.Text = "";
				// �J�[�\���������v�ɂ���
				Cursor = System.Windows.Forms.Cursors.AppStarting;

				String[] sList = sv_maintenance.Sel_Syskanri(gsa���[�U, "is2");

				// �J�[�\�����f�t�H���g�ɖ߂�
				Cursor = System.Windows.Forms.Cursors.Default;

				// �G���[��
				if(sList[0].Length != 4)
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					return;
				}

				// �X�V���������ƂȂ�ꍇ
				if(s�X�V���� != sList[2])
				{
					�r�[�v��();
					DialogResult rst;
					rst = MessageBox.Show("����̃R�[�h�����ɑ��̒[�����o�^����Ă��܂��B\n" 
										+ "���b�Z�[�W���ŐV�ɂ��܂����H",
										"�X�V",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Error);
					if(rst == DialogResult.Yes)
					{
						���b�Z�[�W�ꗗ����();
					}
					return;
				}

				if(tex���b�Z�[�W��.Text.Trim().Length == 0)
					tex���b�Z�[�W��.Text = "�@";
				string[] sData = new string[5];
				sData[0]  = "is2";
				sData[1]  = tex���b�Z�[�W��.Text ;
				sData[2]  = "���Z�o�^";
				sData[3]  = gs���p�҃R�[�h;
				sData[4]  = s�X�V����;

				// �J�[�\���������v�ɂ���
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				tex���b�Z�[�W.Text = "�X�V���D�D�D";
				String[] sIUList = sv_maintenance.Upd_Syskanri(gsa���[�U,sData);
				// �J�[�\�����f�t�H���g�ɖ߂�
				Cursor = System.Windows.Forms.Cursors.Default;
				if(sIUList[0].Length == 4)
				{
					tex���b�Z�[�W.Text = "";
					this.Close();
				}
				else
				{
					tex���b�Z�[�W.Text = sIUList[0];
					�r�[�v��();
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
		}

		private void ���b�Z�[�W�o�^_Closed(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W��.Focus();
		}

	}
}
