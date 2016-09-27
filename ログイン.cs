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
	/// [���O�C��]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// DEL 2005.05.27 ���s�j���� �Z�b�V��������̔p�~ 
	//--------------------------------------------------------------------------
	// MOD 2006.10.03 ���s�j�R�{ �X�����j���[���菈���ǉ� 
	// ADD 2006.12.06 ���s�j�����J IP�A�h���X 
	// ADD 2006.12.06 ���s�j�����J �X���擾���@�ύX 
	// ADD 2006.12.06 ���s�j�����J �h�o�A�h���X�`�F�b�N 
	// ADD 2006.12.07 ���s�j�����J �X�����݃`�F�b�N 
	//--------------------------------------------------------------------------
	// MOD 2007.01.30 ���s�j���� ���ꌠ�����[�U�̒ǉ� 
	// ADD 2007.02.03 ���s�j���� �����t�H�[�J�X�̐ݒ� 
	// DEL 2007.02.06 ���s�j���� �c�Ə�����Ή� 
	// MOD 2007.06.12 ���s�j���� �F�s�{�Ȃǂ̑Ή� 
	// ADD 2007.07.02 ���s�j���� �a�c�R�c�Ə��Ή� 
	// ADD 2007.09.25 ���s�j���� ���΂炬�Ⓦ�n��ڊǑΉ� 
	// ADD 2007.10.26 ���s�j���� �o�[�W�������̕\�� 
	//--------------------------------------------------------------------------
	// ADD 2008.03.21 ���s�j�O���[�o���Ή� 
	//--------------------------------------------------------------------------
	// ADD 2010.04.02 ���s�j���� ���΂炬�}���c�Ə��Ή� 
	// ADD 2010.05.11 ���s�j���� �����Y�����ʃZ���^�[�Ή� 
	// MOD 2010.06.25 ���s�j���� ���O�C����Q���̑Ή����� 
	// ADD 2010.07.01 ���s�j���� ���c���ʃZ���^�[�Ή� 
	// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� 
	// MOD 2011.01.14 ���s�j���� ���q�^���Ή� 
	// MOD 2011.07.12 ���s�j���� ���q�^���u�K��Ή� 
	// ADD 2013.07.12 tdi�j�j�V �����e���g���ڊǐ惍�O�C���Ή�
	// ADD 2014.07.31 BEVAS) �O�c ��ˉc�Ə����O�C���Ή�
	// ADD 2014.08.08 BEVAS) �O�c ������`�ݕ����O�C���Ή�
	// ADD 2015.03.26 BEVAS) �O�c �������ܐ�����O�C���Ή�
	//--------------------------------------------------------------------------
	// ADD 2015.09.28 bevas�j���{ �ɉ���A���R�_�Ӄ��O�C���Ή�
	//--------------------------------------------------------------------------
	// ADD 2015.10.08 bevas�j���{ �L�����ʃZ���^�[���O�C���Ή�
	//--------------------------------------------------------------------------
	// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή�
	//--------------------------------------------------------------------------
	// ADD 2016.02.12 BEVAS�j���{ �������ʃZ���^�[���O�C���Ή�(STEP1)
	//�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�yIP�̌n�ύX�ɔ����Ή��z
	//--------------------------------------------------------------------------
	// ADD 2016.02.18 BEVAS�j���{ �������ʃZ���^�[���O�C���Ή�(STEP2)
	//�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�y�X���R�[�h�ύX�ɔ����Ή��z
	//--------------------------------------------------------------------------
	public class ���O�C�� : ���ʃt�H�[��
	{
		public bool b�F�� = false;
		// ADD 2006.12.06 ���s�j�����J IP�A�h���X START
		private string[] sValue;
		// ADD 2006.12.06 ���s�j�����J IP�A�h���X END

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Label lab�p�X���[�h;
		private ���ʃe�L�X�g�{�b�N�X tex�p�X���[�h;
		private ���ʃe�L�X�g�{�b�N�X tex���p�҃R�[�h;
		private System.Windows.Forms.Label lab����R�[�h;
		private ���ʃe�L�X�g�{�b�N�X tex����R�[�h;
		private System.Windows.Forms.Label lab���p�҃R�[�h;
		private System.Windows.Forms.Button btn���O�C��;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn�L�����Z��;
		private System.Windows.Forms.PictureBox pic���O�I��;
		private System.Windows.Forms.Label lab�o�[�W����;

		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public ���O�C��()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(���O�C��));
			this.tex���p�҃R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab�o�[�W���� = new System.Windows.Forms.Label();
			this.btn�L�����Z�� = new System.Windows.Forms.Button();
			this.pic���O�I�� = new System.Windows.Forms.PictureBox();
			this.lab����R�[�h = new System.Windows.Forms.Label();
			this.tex����R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�p�X���[�h = new System.Windows.Forms.Label();
			this.tex�p�X���[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab���p�҃R�[�h = new System.Windows.Forms.Label();
			this.btn���O�C�� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tex���p�҃R�[�h
			// 
			this.tex���p�҃R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex���p�҃R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���p�҃R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex���p�҃R�[�h.Location = new System.Drawing.Point(132, 90);
			this.tex���p�҃R�[�h.MaxLength = 6;
			this.tex���p�҃R�[�h.Name = "tex���p�҃R�[�h";
			this.tex���p�҃R�[�h.Size = new System.Drawing.Size(82, 23);
			this.tex���p�҃R�[�h.TabIndex = 1;
			this.tex���p�҃R�[�h.Text = "";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Controls.Add(this.lab�o�[�W����);
			this.panel1.Controls.Add(this.btn�L�����Z��);
			this.panel1.Controls.Add(this.pic���O�I��);
			this.panel1.Controls.Add(this.lab����R�[�h);
			this.panel1.Controls.Add(this.tex����R�[�h);
			this.panel1.Controls.Add(this.lab�p�X���[�h);
			this.panel1.Controls.Add(this.tex�p�X���[�h);
			this.panel1.Controls.Add(this.lab���p�҃R�[�h);
			this.panel1.Controls.Add(this.tex���p�҃R�[�h);
			this.panel1.Controls.Add(this.btn���O�C��);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(364, 226);
			this.panel1.TabIndex = 0;
			// 
			// lab�o�[�W����
			// 
			this.lab�o�[�W����.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(191)), ((System.Byte)(190)));
			this.lab�o�[�W����.ForeColor = System.Drawing.Color.Black;
			this.lab�o�[�W����.Location = new System.Drawing.Point(300, 4);
			this.lab�o�[�W����.Name = "lab�o�[�W����";
			this.lab�o�[�W����.Size = new System.Drawing.Size(46, 12);
			this.lab�o�[�W����.TabIndex = 53;
			this.lab�o�[�W����.Text = "Ver.1.5";
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
			this.lab����R�[�h.Location = new System.Drawing.Point(50, 66);
			this.lab����R�[�h.Name = "lab����R�[�h";
			this.lab����R�[�h.Size = new System.Drawing.Size(76, 14);
			this.lab����R�[�h.TabIndex = 0;
			this.lab����R�[�h.Text = "���q�l�R�[�h�F";
			// 
			// tex����R�[�h
			// 
			this.tex����R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex����R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex����R�[�h.Location = new System.Drawing.Point(132, 60);
			this.tex����R�[�h.MaxLength = 10;
			this.tex����R�[�h.Name = "tex����R�[�h";
			this.tex����R�[�h.Size = new System.Drawing.Size(130, 23);
			this.tex����R�[�h.TabIndex = 0;
			this.tex����R�[�h.Text = "";
			// 
			// lab�p�X���[�h
			// 
			this.lab�p�X���[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�p�X���[�h.ForeColor = System.Drawing.Color.Black;
			this.lab�p�X���[�h.Location = new System.Drawing.Point(50, 126);
			this.lab�p�X���[�h.Name = "lab�p�X���[�h";
			this.lab�p�X���[�h.Size = new System.Drawing.Size(76, 14);
			this.lab�p�X���[�h.TabIndex = 48;
			this.lab�p�X���[�h.Text = "�p�X���[�h�F";
			// 
			// tex�p�X���[�h
			// 
			this.tex�p�X���[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex�p�X���[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�p�X���[�h.Location = new System.Drawing.Point(132, 120);
			this.tex�p�X���[�h.MaxLength = 20;
			this.tex�p�X���[�h.Name = "tex�p�X���[�h";
			this.tex�p�X���[�h.PasswordChar = '*';
			this.tex�p�X���[�h.Size = new System.Drawing.Size(170, 23);
			this.tex�p�X���[�h.TabIndex = 2;
			this.tex�p�X���[�h.Text = "";
			this.tex�p�X���[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�p�X���[�h_KeyDown);
			// 
			// lab���p�҃R�[�h
			// 
			this.lab���p�҃R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���p�҃R�[�h.ForeColor = System.Drawing.Color.Black;
			this.lab���p�҃R�[�h.Location = new System.Drawing.Point(50, 96);
			this.lab���p�҃R�[�h.Name = "lab���p�҃R�[�h";
			this.lab���p�҃R�[�h.Size = new System.Drawing.Size(76, 14);
			this.lab���p�҃R�[�h.TabIndex = 42;
			this.lab���p�҃R�[�h.Text = "���[�U�[�F";
			// 
			// btn���O�C��
			// 
			this.btn���O�C��.ForeColor = System.Drawing.Color.Black;
			this.btn���O�C��.Location = new System.Drawing.Point(62, 158);
			this.btn���O�C��.Name = "btn���O�C��";
			this.btn���O�C��.Size = new System.Drawing.Size(100, 22);
			this.btn���O�C��.TabIndex = 4;
			this.btn���O�C��.Text = "�n�j";
			this.btn���O�C��.Click += new System.EventHandler(this.btn���O�C��_Click);
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
			// ���O�C��
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
			this.Name = "���O�C��";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "is-2�Ǘ� �փ��O�C��";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.���O�C��_Load);
			this.Activated += new System.EventHandler(this.���O�C��_Activated);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>
		private void btn���O�C��_Click(object sender, System.EventArgs e)
		{
			���O�C���F��();
		}
		
		private void ���O�C���F��()
		{
			// �󔒏���
			tex����R�[�h.Text   = tex����R�[�h.Text.Trim();
			tex���p�҃R�[�h.Text = tex���p�҃R�[�h.Text.Trim();
			tex�p�X���[�h.Text   = tex�p�X���[�h.Text.Trim();

			// ���ڃ`�F�b�N
			if(!�K�{�`�F�b�N(tex����R�[�h, "����R�[�h")) return;
			if(!�K�{�`�F�b�N(tex���p�҃R�[�h, "���[�U�[")) return;
			if(!�K�{�`�F�b�N(tex�p�X���[�h, "�p�X���[�h")) return;
			if(!���p�`�F�b�N(tex����R�[�h, "����R�[�h")) return;
			if(!���p�`�F�b�N(tex���p�҃R�[�h, "���[�U�[")) return;
			if(!���p�`�F�b�N(tex�p�X���[�h, "�p�X���[�h")) return;

			// DEL 2007.02.06 ���s�j���� �c�Ə�����Ή� START
			//// ADD 2006.12.06 ���s�j�����J �X���擾���@�ύX START
			//// MOD 2007.01.30 ���s�j���� ���ꌠ�����[�U�̒ǉ� START
			////			if(tex����R�[�h.Text != "honbu")
			//			if(tex����R�[�h.Text != "honbu"
			//			&& tex����R�[�h.Text != "kikaku")
			//// MOD 2007.01.30 ���s�j���� ���ꌠ�����[�U�̒ǉ� END
			//			{
			//				string sTensyo;
			//				string sIp = sValue[1].Trim().PadLeft(3,'0');
			//				if(sIp == "016") sTensyo = "0";
			//				else if(sIp == "017") sTensyo = "1";
			//				else if(sIp == "018") sTensyo = "2";
			//				else if(sIp == "019") sTensyo = "3";
			//				else if(sIp == "020") sTensyo = "4";
			//				else if(sIp == "021") sTensyo = "5";
			//				else if(sIp == "022") sTensyo = "6";
			//				else if(sIp == "023") sTensyo = "7";
			//				else if(sIp == "024") sTensyo = "8";
			//				else if(sIp == "025") sTensyo = "9";
			//				else 
			//				{
			//					MessageBox.Show("�F�؃G���[�F�[�����s���ł��B", "���O�C��",
			//						MessageBoxButtons.OK, MessageBoxIcon.Error);
			//					return;
			//				}
			//				gs�X���R�[�h = sTensyo + sValue[2].Trim().PadLeft(3,'0').Substring(1,2);
			//
			//				if(gs�X���R�[�h.StartsWith("0") == true)
			//				{
			//					gs�X���R�[�h   = "";
			//				}
			//			}
			//
			//// ADD 2006.12.06 ���s�j�����J �X���擾���@�ύX END
			// DEL 2007.02.06 ���s�j���� �c�Ə�����Ή� END

			// �f�[�^�쐬
			String[] sKey = new string[3];
			sKey[0] = tex����R�[�h.Text;
			sKey[1] = tex���p�҃R�[�h.Text;
			sKey[2] = tex�p�X���[�h.Text;

			//			tex���b�Z�[�W.Text = "�F�ؒ�";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			// ADD 2008.03.21 ���s�j�O���[�o���Ή� START
			string s�Z�N�V�����X�� = "";
			// ADD 2008.03.21 ���s�j�O���[�o���Ή� END

			// ADD 2013.07.12 tdi�j�j�V �����e���g���ڊǐ惍�O�C���Ή� START
			string s�e���g���X�e�f = "";
			// ADD 2013.07.12 tdi�j�j�V �����e���g���ڊǐ惍�O�C���Ή� END

			try
			{
				// �����F����R�[�h�A���p�҃R�[�h�A�p�X���[�h
				if (sv_maintenance == null)
				{
					sv_maintenance = new is2maintenance.Service1();
					// DEL 2005.05.27 ���s�j���� �Z�b�V��������̔p�~ START
					//					sv_maintenance.CookieContainer = cContainer;
					// DEL 2005.05.27 ���s�j���� �Z�b�V��������̔p�~ END
				}
				// MOD 2011.01.14 ���s�j���� ���q�^���Ή� START
				if(sv_oji == null) sv_oji = new is2oji.Service1();
				// MOD 2011.01.14 ���s�j���� ���q�^���Ή� END
				gsa���[�U[0]   = "";
				gsa���[�U[1]   = "";
				gsa���[�U[2]   = "";
				// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
				//				String[] sRet = sv_maintenance.Set_login(gsa���[�U, sKey);
				String[] sRet;
				if (sKey[0].Substring(0,1) != "J")
				{
					sRet = sv_maintenance.Set_login(gsa���[�U, sKey);

				}
				else
				{
					// MOD 2011.01.14 ���s�j���� ���q�^���Ή� START
					//					if (sv_oji == null) sv_oji = new is2oji.Service1();
					// MOD 2011.01.14 ���s�j���� ���q�^���Ή� END
					sRet = sv_oji.Set_login(gsa���[�U, sKey);
				}
				// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

				// MOD 2010.06.25 ���s�j���� ���O�C����Q���̑Ή����� START
				if(sRet[0].Length != 4)
				{
					MessageBox.Show(sRet[0]
						, "���O�C��"
						, MessageBoxButtons.OK, MessageBoxIcon.Error);
					�r�[�v��();
					tex����R�[�h.Focus();
					this.Cursor = System.Windows.Forms.Cursors.Default;
					b�F�� = false;
					return;
				}
				// MOD 2010.06.25 ���s�j���� ���O�C����Q���̑Ή����� END

				if(sRet[1] == null)
				{
					//					tex���b�Z�[�W.Text = "�F�؃G���[�F�ēx���͂��Ă��������B";
					MessageBox.Show("�F�؃G���[�F�ēx���͂��Ă��������B", "���O�C��", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					// ����R�[�h�Ƀt�H�[�J�X
					�r�[�v��();
					tex����R�[�h.Focus();
					this.Cursor = System.Windows.Forms.Cursors.Default;
					return;
				}
				else
				{
					gs����R�[�h   = sRet[1];
					gs�����       = sRet[2];
					gs���p�҃R�[�h = sRet[3];
					gs���p�Җ�     = sRet[4];
					// DEL 2006.12.06 ���s�j�����J �X���擾���@�ύX START
					// MOD 2006.10.03 ���s�j�R�{ �X�����j���[���菈���ǉ� START
					//					if(sRet[5].StartsWith("0") != true)
					//						gs�X���R�[�h   = sRet[5].Trim();
					// MOD 2006.10.03 ���s�j�R�{ �X�����j���[���菈���ǉ� END
					// DEL 2006.12.06 ���s�j�����J �X���擾���@�ύX END
					// ADD 2007.02.06 ���s�j���� �c�Ə�����Ή� START
					gs�Ǘ��ҋ敪   = sRet[5];
					// ADD 2007.02.06 ���s�j���� �c�Ə�����Ή� END
					// ADD 2008.03.21 ���s�j�O���[�o���Ή� START
					if(sRet.Length > 6) s�Z�N�V�����X�� = sRet[6];
					// ADD 2008.03.21 ���s�j�O���[�o���Ή� END
					//sv_maintenance.SetSession(gs����R�[�h, gs���p�҃R�[�h);
					gsa���[�U[0]   = gs����R�[�h;
					gsa���[�U[1]   = gs���p�҃R�[�h;
					gsa���[�U[2]   = "";
					b�F�� = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				this.Cursor = System.Windows.Forms.Cursors.Default;
				// MOD 2010.06.25 ���s�j���� ���O�C����Q���̑Ή����� START
				b�F�� = false;
				// MOD 2010.06.25 ���s�j���� ���O�C����Q���̑Ή����� END
				// ��ʂ����
				this.Close();
			}

			// ADD 2007.02.06 ���s�j���� �c�Ə�����Ή� START
			gs�X���R�[�h = "";
			// �c�Ə�����̏ꍇ�A�h�o�œX���b�c��ݒ�
			// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
			// ���q�c�Ə�����̏ꍇ�A�X���b�c�����
			//			if(gs�Ǘ��ҋ敪 == "2")
			if((gs�Ǘ��ҋ敪 == "2") || (gs�Ǘ��ҋ敪 == "4"))
				// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
			{
				// MOD 2007.06.12 ���s�j���� �F�s�{�Ȃǂ̑Ή� START
				//				string sTensyo;
				//				string sIp = sValue[1].Trim().PadLeft(3,'0');
				//				if(sIp == "016") sTensyo = "0";
				//				else if(sIp == "017") sTensyo = "1";
				//				else if(sIp == "018") sTensyo = "2";
				//				else if(sIp == "019") sTensyo = "3";
				//				else if(sIp == "020") sTensyo = "4";
				//				else if(sIp == "021") sTensyo = "5";
				//				else if(sIp == "022") sTensyo = "6";
				//				else if(sIp == "023") sTensyo = "7";
				//				else if(sIp == "024") sTensyo = "8";
				//				else if(sIp == "025") sTensyo = "9";
				//				else 
				//				{
				//					MessageBox.Show("�F�؃G���[�F�[�����s���ł��B", "���O�C��",
				//						MessageBoxButtons.OK, MessageBoxIcon.Error);
				//					// ����R�[�h�Ƀt�H�[�J�X
				//					�r�[�v��();
				//					tex����R�[�h.Focus();
				//					b�F�� = false;
				//					this.Cursor = System.Windows.Forms.Cursors.Default;
				//					return;
				//				}
				//
				//				gs�X���R�[�h = sTensyo + sValue[2].Trim().PadLeft(3,'0').Substring(1,2);
				// MOD 2010.06.25 ���s�j���� ���O�C����Q���̑Ή����� START

				bool b�[���h�o�G���[ = false;
				try
				{
//#if DEBUG
////					//���O�C���Ή��m�F
////					gs�h�o�A�h���X = "172.21.17.200";  // ���R��A���R�����O�C���U���m�F�p�i���R���x�X��IP�A�h���X�̌n�j
////					gs�h�o�A�h���X = "172.21.17.194";  // ���R��c�Ə��̃��O�C��IP�A�h���X�i��IP�A�h���X�̌n�́A���R���x�X�̂��́j
////					gs�h�o�A�h���X = "172.18.17.200";  // �e���g���X�ڊǓX���m�F�p�i�i��x�X��IP�A�h���X�̌n�j
////					gs�h�o�A�h���X = "172.23.2.200";   // ���������x�X���O�C���m�F�pIP�i���̌n�́A�������ʃZ���^�[�̂��́j
////					gs�h�o�A�h���X = "172.23.102.200"; // �������ʃZ���^�[���O�C���m�F�pIP�i�V�̌n�j
//#endif
					sValue = gs�h�o�A�h���X.Split('.');

					if(sValue == null)
					{
						b�[���h�o�G���[ = true;
					}
					else if(sValue.Length != 4)
					{
						b�[���h�o�G���[ = true;
						// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
						//					}else if(sValue[0] != "172"){
					}
					else if((sValue[0] != "172") && (sValue[0] != "10"))
					{
						// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
						b�[���h�o�G���[ = true;
					}
					//�ۗ��@�����̂h�o������ꍇ
				}
				catch(Exception)
				{
					b�[���h�o�G���[ = true;
				}
				if(b�[���h�o�G���[)
				{
					MessageBox.Show("�F�؃G���[�F�[�����s���ł��B", "���O�C��",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					// ����R�[�h�Ƀt�H�[�J�X
					�r�[�v��();
					tex����R�[�h.Focus();
					b�F�� = false;
					this.Cursor = System.Windows.Forms.Cursors.Default;
					return;
				}
				// MOD 2010.06.25 ���s�j���� ���O�C����Q���̑Ή����� END

				// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
				// ���q�c�Ə�����̏ꍇ�A�X���b�c�����
				// MOD 2011.07.12 ���s�j���� ���q�^���u�K��Ή� START
				//				if((sValue[0] == "10"))
				if(gs�Ǘ��ҋ敪 == "4") // ���q�c�Ə����
					// MOD 2011.07.12 ���s�j���� ���q�^���u�K��Ή� END
				{
					if(gs�X���R�[�h.Trim().Length == 0)
					{
						// �X�����͉�ʂ�\��
						if(g�X������ == null) g�X������ = new �X������();
						g�X������.ShowDialog();
						try
						{
							sKey[0] = gs�X���R�[�h;
							string[] sList = sv_oji.Sel_Member(gsa���[�U, sKey);

							if (sList[0].Equals("����I��"))
							{
								if ((sList[4] != "3") && (sList[4] != "4"))
								{
									MessageBox.Show("�F�؃G���[�F�X���R�[�h���s���ł��B", "���O�C��",
										MessageBoxButtons.OK, MessageBoxIcon.Error);
									// ����R�[�h�Ƀt�H�[�J�X
									�r�[�v��();
									tex����R�[�h.Focus();
									b�F�� = false;
									this.Cursor = System.Windows.Forms.Cursors.Default;
									return;
								}
							}
							else
							{
								MessageBox.Show("�F�؃G���[�F�X�������݂��܂���B", "���O�C��", 
									MessageBoxButtons.OK, MessageBoxIcon.Error);
								// ����R�[�h�Ƀt�H�[�J�X
								�r�[�v��();
								tex����R�[�h.Focus();
								b�F�� = false;
								this.Cursor = System.Windows.Forms.Cursors.Default;
								return;
							}
						}
						catch (Exception ex)
						{
							b�F�� = false;
							MessageBox.Show(ex.Message);
							return;
						}
					}
					else
					{
						gs�X���R�[�h = "";
					}
				}
				else
				{
					// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
					int iIp1 = int.Parse(sValue[1].Trim());
					if(iIp1 < 16 || iIp1 > 25)
					{
						MessageBox.Show("�F�؃G���[�F�[�����s���ł��B", "���O�C��",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						// ����R�[�h�Ƀt�H�[�J�X
						�r�[�v��();
						tex����R�[�h.Focus();
						b�F�� = false;
						this.Cursor = System.Windows.Forms.Cursors.Default;
						return;
					}
					int iIp2 = int.Parse(sValue[2].Trim());
					string sTensyo2 = sValue[2].Trim().PadLeft(3,'0').Substring(1,2);

					switch(iIp1)
					{
						case 16:
							gs�X���R�[�h = "0" + sTensyo2;
							break;
						case 17:
						switch(iIp2)
						{
							case 141:
								gs�X���R�[�h = "241";		//�F�s�{����
								break;
							default:
								gs�X���R�[�h = "1" + sTensyo2;
								break;
						}
							break;
						case 18:
						switch(iIp2)
						{
							case 191:
								gs�X���R�[�h = "191";		//�q��ݕ�
								break;
							case 137:
								gs�X���R�[�h = "337";		//�B��
								break;
							case 136:
								gs�X���R�[�h = "336";		//�s��
								break;
							case 192:
								gs�X���R�[�h = "192";		//�H�c��`�i������`�j
								break;
							case 132:
								gs�X���R�[�h = "332";		//�b�{
								break;
							case 31:
								gs�X���R�[�h = "235";		//���v����
								break;
								// ADD 2007.09.25 ���s�j���� ���΂炬�Ⓦ�n��ڊǑΉ� START
							case 60:
								gs�X���R�[�h = "255";		//���΂炬�Ⓦ
								break;
								// ADD 2007.09.25 ���s�j���� ���΂炬�Ⓦ�n��ڊǑΉ� END
								// ADD 2010.04.02 ���s�j���� ���΂炬�}���c�Ə��Ή� START
							case 112:
								gs�X���R�[�h = "250";		//���΂炬�}��
								break;
								// ADD 2010.04.02 ���s�j���� ���΂炬�}���c�Ə��Ή� END
								// ADD 2010.05.11 ���s�j���� �����Y�����ʃZ���^�[�Ή� START
							case  38:
								gs�X���R�[�h = "270";		//�����Y�����ʃZ���^�[
								break;
								// ADD 2010.05.11 ���s�j���� �����Y�����ʃZ���^�[�Ή� END
								// ADD 2010.07.01 ���s�j���� ���c���ʃZ���^�[�Ή� START
							case  99:
								gs�X���R�[�h = "193";		//���c���ʃZ���^�[
								break;
								// ADD 2010.07.01 ���s�j���� ���c���ʃZ���^�[�Ή� END
							    // ADD 2014.07.31 BEVAS) �O�c�@��ˉc�Ə��Ή� START
							case 108:
								gs�X���R�[�h = "354";		//��ˉc�Ə�
								break;
								// ADD 2014.07.31 BEVAS) �O�c�@��ˉc�Ə��Ή� END
								// ADD 2014.08.08 BEVAS) �O�c ������`�ݕ����O�C���Ή� START
							case 103:
								gs�X���R�[�h = "192";		//������`�ݕ�
								break;
								// ADD 2014.08.08 BEVAS) �O�c ������`�ݕ����O�C���Ή� END
								// ADD 2015.03.26 BEVAS) �O�c �������ܐ�����O�C���Ή� START
							case 28:
								gs�X���R�[�h = "225";		//�������ܐ��
								break;
								// ADD 2015.03.26 BEVAS) �O�c �������ܐ�����O�C���Ή� END
							default:
								gs�X���R�[�h = "2" + sTensyo2;
								break;
						}
							break;
						case 19:
							gs�X���R�[�h = "3" + sTensyo2;
							break;
						case 20:
						switch(iIp2)
						{
							case 185:
								gs�X���R�[�h = "385";		//����
								break;
							case 197:
								gs�X���R�[�h = "397";		//����
								break;
							case 186:
								gs�X���R�[�h = "386";		//����
								break;
// ADD 2015.09.28 bevas�j���{ �ɉ���A���R�_�Ӄ��O�C���Ή� START
							case 13:
								gs�X���R�[�h = "414";		//�ɉ���
								break;
// ADD 2015.09.28 bevas�j���{ �ɉ���A���R�_�Ӄ��O�C���Ή� END
							default:
								gs�X���R�[�h = "4" + sTensyo2;
								break;
						}
							break;
						case 21:
						switch(iIp2)
						{
							case 102:
								gs�X���R�[�h = "402";		//�L��
								break;
								// ADD 2007.07.02 ���s�j���� �a�c�R�c�Ə��Ή� START
							case 103:
								gs�X���R�[�h = "403";		//�a�c�R
								break;
								// ADD 2007.07.02 ���s�j���� �a�c�R�c�Ə��Ή� END
// ADD 2015.09.28 bevas�j���{ �ɉ���A���R�_�Ӄ��O�C���Ή� START
							case 29:
								gs�X���R�[�h = "506";		//���R�_��
								break;
// ADD 2015.09.28 bevas�j���{ �ɉ���A���R�_�Ӄ��O�C���Ή� END
// ADD 2015.10.08 bevas�j���{ �L�����ʃZ���^�[���O�C���Ή� START
							case 40:
								gs�X���R�[�h = "588";		//�L�����ʃZ���^�[
								break;
// ADD 2015.10.08 bevas�j���{ �L�����ʃZ���^�[���O�C���Ή� END
							default:
								gs�X���R�[�h = "5" + sTensyo2;
								break;
						}
							break;
						case 22:
							gs�X���R�[�h = "6" + sTensyo2;
							break;
						case 23:
						switch(iIp2)
						{
							case 168:
								gs�X���R�[�h = "568";		//����
								break;
// ADD 2016.02.12 BEVAS�j���{ �������ʃZ���^�[���O�C���Ή�(STEP1) START
							// 2/20�`2/29�܂ł̑Ή��@��3/1����͓X���R�[�h���ύX[702 -> 748]
							case 102:
// ADD 2016.02.18 BEVAS�j���{ �������ʃZ���^�[���O�C���Ή�(STEP2) START
								//3/1����A�������ʃZ���^�[�̓X���R�[�h���ύX
								//�@[(��)702 -> (�V)748]
								//�������������x�X�͌��s�̕������ʃZ���^�[��IP�A�h���X(172.23.2.XXX)�ƓX���R�[�h(702)��
								//�@�@�����p���ׁA�Ή��s�v
//								gs�X���R�[�h = "702";		//��������(�VIP)
								gs�X���R�[�h = "748";		//��������
// ADD 2016.02.18 BEVAS�j���{ �������ʃZ���^�[���O�C���Ή�(STEP2) END
								break;
// ADD 2016.02.12 BEVAS�j���{ �������ʃZ���^�[���O�C���Ή�(STEP1) END
							default:
								gs�X���R�[�h = "7" + sTensyo2;
								break;
						}
							break;
						case 24:
							gs�X���R�[�h = "8" + sTensyo2;
							break;
						case 25:
							gs�X���R�[�h = "9" + sTensyo2;
							break;
					}
					// MOD 2010.06.25 ���s�j���� ���O�C����Q���̑Ή����� START

					// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
				}

// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� START
				// ���R��c�Ə�(516)�^���R���x�X(517) ����̃��O�C���̏ꍇ
				if(gs�X���R�[�h == "517")
				{
					// �m�F���b�Z�[�W�\��
					DialogResult dr�I�� = MessageBox.Show(
							"���R��c�Ə��Ƃ��ă��O�C�����܂����H",
							"���O�C���m�F",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Information
						);
					if(dr�I�� == DialogResult.Yes)
					{
						/*************************************************************************
						 ** DialogResult = "OK"�ł����"516"�Ń��O�C������B                     **
						 ** �p�X��[�p�X����.cs]��<btn�p�X����_Click>�C�x���g�֋L�q  "516minami"   **
						 *************************************************************************/
						if(g�p�X���� == null)
						{
							g�p�X���� = new �p�X����();
						}
						g�p�X����.ShowDialog();
						if(g�p�X����.DialogResult == DialogResult.OK)
						{
							// ���R��c�Ə�(516)�Ń��O�C��
							gs�X���R�[�h = "516";
						}
					}
				}
// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� END

				// ADD 2013.07.12 tdi�j�j�V �����e���g���ڊǐ惍�O�C���Ή� START
				// �����e���g���Ή��I������2013.7.12�̍X�V��S�ăR�����g�A�E�g

				switch(gs�X���R�[�h)
				{
					case "213":
						//�H�c
						s�e���g���X�e�f = "1";
						break;
					case "217":
						//�i��
						s�e���g���X�e�f = "1";
						break;
					case "218":
						//�[��
						s�e���g���X�e�f = "1";
						break;
					case "248":
						//���
						s�e���g���X�e�f = "1";
						break;
					case "279":
						//�s��
						s�e���g���X�e�f = "1";
						break;
					case "308":
						//���쉮
						s�e���g���X�e�f = "1";
						break;
					case "679":
						//���q����
						s�e���g���X�e�f = "1";
						break;
					case "688":
						//���q����
						s�e���g���X�e�f = "1";
						break;
					case "690":
						//���q���l
						s�e���g���X�e�f = "1";
						break;
					default:
						//�����Ȃ�
						s�e���g���X�e�f = "";
						break;
				}

				//�e���g���X�ڊǐ�̃��O�C���������ꍇ�A���b�Z�\�W��\������B
				if (s�e���g���X�e�f == "1")
				{
					//�m�F���b�Z�[�W�\��
					DialogResult d�I�� = MessageBox.Show("�����x�X�Ƃ��ă��O�C�����܂����H",
						"���O�C���m�F",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Information
						);
					if (d�I�� == DialogResult.Yes)
					{

						//DialogResult = "OK"�ł����"211"�Ń��O�C������B
						//�p�X�̓p�X����.cs ��btn�p�X����_Click�C�x���g�֋L�q"211tokyo"
						if(g�p�X���� == null) g�p�X���� = new �p�X����();
						g�p�X����.ShowDialog();

						if (g�p�X����.DialogResult == DialogResult.OK)
						{

							//�����x�X�Ƃ��ă��O�C������B
							gs�X���R�[�h = "211";
						}
					}
					else
					{
						//�ʏ�X���Ń��O�C��
						;
					}
				}
				else
				{
					//�����Ȃ�
				}
				// ADD 2013.07.12 tdi�j�j�V �����e���g���ڊǐ惍�O�C���Ή� END

				// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
			}
			else if(gs�Ǘ��ҋ敪 == "1")
			{ // �Ǘ���
				;
			}
			else
			{
				b�F�� = false;
				return;

				// MOD 2010.06.25 ���s�j���� ���O�C����Q���̑Ή����� END
				// MOD 2007.06.12 ���s�j���� �F�s�{�Ȃǂ̑Ή� END

				//				// �X���b�c�̓����O�̏ꍇ�͊Ǘ��ɐݒ�
				//				if(gs�X���R�[�h.StartsWith("0") == true)
				//				{
				//					gs�X���R�[�h   = "";
				//				}
			}
			// ADD 2007.02.06 ���s�j���� �c�Ə�����Ή� END

			// ADD 2006.12.07 ���s�j�����J �X�����݃`�F�b�N START
			if(gs�X���R�[�h.Trim().Length != 0)
			{
				try
				{
					string[] sKeyT = new string[1];
					sKeyT[0] = gs�X���R�[�h;
					string[] sList = sv_maintenance.Sel_Shop(gsa���[�U, sKeyT);
					if(!sList[0].Equals("����I��"))
					{
						MessageBox.Show("�F�؃G���[�F�X�������݂��܂���B", "���O�C��", 
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						// ����R�[�h�Ƀt�H�[�J�X
						�r�[�v��();
						tex����R�[�h.Focus();
						b�F�� = false;
						this.Cursor = System.Windows.Forms.Cursors.Default;
						return;
					}
				}
				catch (Exception ex)
				{
					b�F�� = false;
					MessageBox.Show(ex.Message);
				}
			}
			// ADD 2008.03.21 ���s�j�O���[�o���Ή� START
			if(s�Z�N�V�����X��.Equals("047"))
			{
				gs�X���R�[�h = s�Z�N�V�����X��;
			}
			// ADD 2008.03.21 ���s�j�O���[�o���Ή� END
			this.Cursor = System.Windows.Forms.Cursors.Default;

			// ��ʂ����
			this.Close();
			// ADD 2006.12.07 ���s�j�����J �X�����݃`�F�b�N END
		}

		private void tex�p�X���[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
				���O�C���F��();
		}

		private void btn�L�����Z��_Click(object sender, System.EventArgs e)
		{
			// MOD 2010.06.25 ���s�j���� ���O�C����Q���̑Ή����� START
			b�F�� = false;
			// MOD 2010.06.25 ���s�j���� ���O�C����Q���̑Ή����� END
			this.Close();
		}

		private void ���O�C��_Load(object sender, System.EventArgs e)
		{
			pic���O�I��.Image = Image.FromFile("img\\login.gif");
			// ADD 2007.10.26 ���s�j���� �o�[�W�������̕\�� START
			if(gsa���[�U[3].Length == 0)
			{
				int iPos = 0;
				//�P�ڂ̃s���I�h
				iPos = Application.ProductVersion.IndexOf('.');
				if(iPos >= 0)
				{
					//�Q�ڂ̃s���I�h
					iPos = Application.ProductVersion.IndexOf('.',iPos+1);
					if(iPos >= 0)
					{
						gsa���[�U[3] = Application.ProductVersion.Substring(0,iPos);
					}
				}
			}
			if(gsa���[�U[3].Length > 0) lab�o�[�W����.Text = "Ver." + gsa���[�U[3];
			// ADD 2007.10.26 ���s�j���� �o�[�W�������̕\�� END
			// ADD 2006.12.06 ���s�j�����J �h�o�A�h���X�`�F�b�N START
			sValue = gs�h�o�A�h���X.Split('.');
			// ADD 2006.12.06 ���s�j�����J �h�o�A�h���X�`�F�b�N END
			// ADD 2007.02.03 ���s�j���� �����t�H�[�J�X�̐ݒ� START
			tex����R�[�h.Focus();
			// ADD 2007.02.03 ���s�j���� �����t�H�[�J�X�̐ݒ� END
		}

		// ADD 2007.02.03 ���s�j���� �����t�H�[�J�X�̐ݒ� START
		private void ���O�C��_Activated(object sender, System.EventArgs e)
		{
			tex����R�[�h.Focus();
		}
		// ADD 2007.02.03 ���s�j���� �����t�H�[�J�X�̐ݒ� END
	}
}
