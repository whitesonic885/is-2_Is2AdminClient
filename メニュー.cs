using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Xml;

namespace is2AdminClient
{
	/// <summary>
	/// [Home]�i���j���[�j
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// DEL 2008.05.07 ���s�j���� ���˗��匟���폜 
	// DEL 2008.05.08 ���s�j���� �Z�N�V���������폜 
	// ADD 2008.04.11 ACT Vista�Ή� 
	//�ۗ� ADD 2008.01.06 ���s�j���� ���j���[�O�Q�g���Ή� 
	//--------------------------------------------------------------------------
	// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� 
	// MOD 2009.05.11 ���s�j���� ���o�בΉ� 
	// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� 
	// MOD 2009.08.07 ���s�j���� �ؑփ{�^���̐����Q�Ή� 
	// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� 
	//--------------------------------------------------------------------------
	// ADD 2010.06.05 KCL) �X�{ BLUEDI�Ǘ���ʌďo�@�\�̒ǉ� 
	//�ۗ� MOD 2010.06.29 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� 
	// MOD 2010.09.30 ���s�j���� ��ʕ��R�ʉ^�Ή� 
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� 
	// MOD 2011.01.14 ���s�j���� ���q�^���Ή� 
	// MOD 2011.05.25 ���s�j���� ���x�X�Ή� 
	// MOD 2011.06.30 ���s�j���� ��䒆���x�X�Ή� 
	//--------------------------------------------------------------------------
	// //MOD 2015.02.26 BEVAS) �O�c �p�i�n���f�B�Ή�
	//--------------------------------------------------------------------------
	// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C
	//                            �i�\��̐擪�Ɂu�y�d�v�z�v���t�����̂̓{�^���̐F��ς���j
	//--------------------------------------------------------------------------
	// MOD 2016.06.10 BEVAS) ���{ WiFi�ݒ肵���[����IP�A�h���X������Ɏ擾�ł��Ȃ��s��Ή�
	//--------------------------------------------------------------------------
	public class ���j���[ : ���ʃt�H�[��
	{
		private static System.Threading.Mutex mutex;
// MOD 2005.05.27 ���s�j���� �X���b�h�ʒu�̈ړ� START
//		private Image[]   imageCmd  = null;
//// ADD 2005.05.25 ���s�j�����J �X���b�h�� START
//		private Thread trd = null;
// MOD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX START
//		private static Image[] imageCmd = null;
		private static Image[] imageCmd_a = null;
		private static Image[] imageCmd_b = null;
// MOD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END
		private static Thread trd = null;
//// ADD 2005.05.25 ���s�j�����J �X���b�h�� END
// MOD 2005.05.27 ���s�j���� �X���b�h�ʒu�̈ړ� END
// MOD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX START
//// ADD 2006.07.11 ���s�j���� ��ʕύX START
//		private static Image img������Fa = null;
//		private static Image img������Fb = null;
//		private static Image img�ғ�����a = null;
//		private static Image img�ғ�����b = null;
//		private static Image img�o�׏�a = null;
//		private static Image img�o�׏�b = null;
//// ADD 2006.07.11 ���s�j���� ��ʕύX END
		private static Image img�g�p���Fa = null;
		private static Image img�g�p���Fb = null;
		private static Image img���q�l��a = null;
		private static Image img���q�l��b = null;
		private static Image img�ғ�����a = null;
		private static Image img�ғ�����b = null;
		private static Image img�o�׏�a = null;
		private static Image img�o�׏�b = null;
		private static Image img���b�Z�Wa = null;
		private static Image img���b�Z�Wb = null;
		private static Image img�g�p�o�^a = null;
		private static Image img�g�p�o�^b = null;
		private static Image img������oa = null;
		private static Image img������ob = null;
		private static Image img�W��X�oa = null;
		private static Image img�W��X�ob = null;
		private static Image img�A�����ia = null;
		private static Image img�A�����ib = null;

		private static Image img�g�p�\��a = null;
		private static Image img�g�p�\��b = null;
//		private static Image img������oa = null;
//		private static Image img������ob = null;
		private static Image img�o�׏Ɖ�a = null;
		private static Image img�o�׏Ɖ�b = null;
		private static Image img���X�d��a = null;
		private static Image img���X�d��b = null;
// MOD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� START
		private static Image img���m�点a = null;
		private static Image img���m�点b = null;
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� END
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� START
		private static Image img���m�\��a = null;
		private static Image img���m�\��b = null;
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� END
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� START
		private static Image img�}�j���Aa = null;
		private static Image img�}�j���Ab = null;
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� END
// MOD 2007.11.29 ���s�j���� ���O�C�����̃t�H�[�J�X��Q�Ή� START
		private static ���O�C�� F���O�C�� = null;
// MOD 2007.11.29 ���s�j���� ���O�C�����̃t�H�[�J�X��Q�Ή� END

		private ���m�点�\��{�^�� [] btnList = new ���m�点�\��{�^�� [5];
		private string [][] s���m�点�ꗗ = null;
		// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� START
		private static string s�}�j���A���t�q�k = null;
		// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� END
		
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lab����;
		private System.Windows.Forms.Button btn�I��;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.PictureBox pic�O�V;
		private System.Windows.Forms.PictureBox pic�O�U;
		private System.Windows.Forms.PictureBox pic�O�W;
		private System.Windows.Forms.PictureBox pic�O�Q;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pic�O�X;
		private System.Windows.Forms.PictureBox pic�O�T;
		private System.Windows.Forms.PictureBox pic�z�[��;
		private System.Windows.Forms.PictureBox pic�O�P;
		private System.Windows.Forms.PictureBox pic�O�R;
		private System.Windows.Forms.PictureBox pic�O�S;
		private System.Windows.Forms.Label lab�o�[�W����;
		private System.Windows.Forms.Button btn�ؑ�;
		private System.Windows.Forms.Button btn���X��;
		private System.Windows.Forms.PictureBox pic�P�O;
		private System.Windows.Forms.Button btn�ғ����o�^;
		private System.Windows.Forms.Panel pan���j���[�U;
		private is2AdminClient.���m�点�\��{�^�� btn���m�点�P;
		private is2AdminClient.���m�点�\��{�^�� btn���m�点�Q;
		private is2AdminClient.���m�点�\��{�^�� btn���m�点�R;
		private is2AdminClient.���m�点�\��{�^�� btn���m�点�S;
		private is2AdminClient.���m�点�\��{�^�� btn���m�点�T;
		private System.Windows.Forms.Button btnBLUEDI�Ǘ�;
		private System.ComponentModel.IContainer components;

		public ���j���[()
		{
			//
			// Windows �t�H�[�� �f�U�C�i �T�|�[�g�ɕK�v�ł��B
			//
			InitializeComponent();

// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� START
			// �����ݒ�
			this.���m�点�����ݒ�();
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� END
		}

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

		#region Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h 
		/// <summary>
		/// �f�U�C�i �T�|�[�g�ɕK�v�ȃ��\�b�h�ł��B���̃��\�b�h�̓��e��
		/// �R�[�h �G�f�B�^�ŕύX���Ȃ��ł��������B
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(���j���[));
			this.panel7 = new System.Windows.Forms.Panel();
			this.pic�z�[�� = new System.Windows.Forms.PictureBox();
			this.lab���� = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnBLUEDI�Ǘ� = new System.Windows.Forms.Button();
			this.btn�ғ����o�^ = new System.Windows.Forms.Button();
			this.btn���X�� = new System.Windows.Forms.Button();
			this.btn�ؑ� = new System.Windows.Forms.Button();
			this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
			this.btn�I�� = new System.Windows.Forms.Button();
			this.pic�O�Q = new System.Windows.Forms.PictureBox();
			this.pic�O�W = new System.Windows.Forms.PictureBox();
			this.pic�O�V = new System.Windows.Forms.PictureBox();
			this.pic�O�U = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab�o�[�W���� = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pic�P�O = new System.Windows.Forms.PictureBox();
			this.pic�O�S = new System.Windows.Forms.PictureBox();
			this.pic�O�R = new System.Windows.Forms.PictureBox();
			this.pic�O�P = new System.Windows.Forms.PictureBox();
			this.pic�O�T = new System.Windows.Forms.PictureBox();
			this.pic�O�X = new System.Windows.Forms.PictureBox();
			this.pan���j���[�U = new System.Windows.Forms.Panel();
			this.btn���m�点�P = new is2AdminClient.���m�点�\��{�^��();
			this.btn���m�点�T = new is2AdminClient.���m�点�\��{�^��();
			this.btn���m�点�S = new is2AdminClient.���m�点�\��{�^��();
			this.btn���m�点�R = new is2AdminClient.���m�点�\��{�^��();
			this.btn���m�点�Q = new is2AdminClient.���m�点�\��{�^��();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pan���j���[�U.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.pic�z�[��);
			this.panel7.Controls.Add(this.lab����);
			this.panel7.Controls.Add(this.label29);
			this.panel7.Location = new System.Drawing.Point(0, -2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(792, 26);
			this.panel7.TabIndex = 15;
			// 
			// pic�z�[��
			// 
			this.pic�z�[��.Image = ((System.Drawing.Image)(resources.GetObject("pic�z�[��.Image")));
			this.pic�z�[��.Location = new System.Drawing.Point(8, 4);
			this.pic�z�[��.Name = "pic�z�[��";
			this.pic�z�[��.Size = new System.Drawing.Size(22, 22);
			this.pic�z�[��.TabIndex = 3;
			this.pic�z�[��.TabStop = false;
			// 
			// lab����
			// 
			this.lab����.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab����.ForeColor = System.Drawing.Color.White;
			this.lab����.Location = new System.Drawing.Point(674, 8);
			this.lab����.Name = "lab����";
			this.lab����.Size = new System.Drawing.Size(112, 14);
			this.lab����.TabIndex = 1;
			this.lab����.Text = "2005/xx/xx 12:00:00";
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label29.Font = new System.Drawing.Font("MS UI Gothic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label29.ForeColor = System.Drawing.Color.White;
			this.label29.Location = new System.Drawing.Point(32, 6);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(264, 24);
			this.label29.TabIndex = 0;
			this.label29.Text = "Home";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(-2, 24);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(810, 26);
			this.panel6.TabIndex = 14;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btnBLUEDI�Ǘ�);
			this.panel8.Controls.Add(this.btn�ғ����o�^);
			this.panel8.Controls.Add(this.btn���X��);
			this.panel8.Controls.Add(this.btn�ؑ�);
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn�I��);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 2;
			// 
			// btnBLUEDI�Ǘ�
			// 
			this.btnBLUEDI�Ǘ�.ForeColor = System.Drawing.Color.Blue;
			this.btnBLUEDI�Ǘ�.Location = new System.Drawing.Point(352, 6);
			this.btnBLUEDI�Ǘ�.Name = "btnBLUEDI�Ǘ�";
			this.btnBLUEDI�Ǘ�.Size = new System.Drawing.Size(54, 48);
			this.btnBLUEDI�Ǘ�.TabIndex = 5;
			this.btnBLUEDI�Ǘ�.Text = "BLUEDI �Ǘ�";
			this.btnBLUEDI�Ǘ�.Click += new System.EventHandler(this.btnBLUEDI�Ǘ�_Click);
			// 
			// btn�ғ����o�^
			// 
			this.btn�ғ����o�^.ForeColor = System.Drawing.Color.Blue;
			this.btn�ғ����o�^.Location = new System.Drawing.Point(208, 6);
			this.btn�ғ����o�^.Name = "btn�ғ����o�^";
			this.btn�ғ����o�^.Size = new System.Drawing.Size(54, 48);
			this.btn�ғ����o�^.TabIndex = 4;
			this.btn�ғ����o�^.Text = "�ғ��� �o�^";
			this.btn�ғ����o�^.Visible = false;
			this.btn�ғ����o�^.Click += new System.EventHandler(this.btn�ғ����o�^_Click);
			// 
			// btn���X��
			// 
			this.btn���X��.ForeColor = System.Drawing.Color.Blue;
			this.btn���X��.Location = new System.Drawing.Point(138, 6);
			this.btn���X��.Name = "btn���X��";
			this.btn���X��.Size = new System.Drawing.Size(62, 48);
			this.btn���X��.TabIndex = 3;
			this.btn���X��.Text = "��������";
			this.btn���X��.Visible = false;
			this.btn���X��.Click += new System.EventHandler(this.btn���X��_Click);
			// 
			// btn�ؑ�
			// 
			this.btn�ؑ�.ForeColor = System.Drawing.Color.Blue;
			this.btn�ؑ�.Location = new System.Drawing.Point(76, 6);
			this.btn�ؑ�.Name = "btn�ؑ�";
			this.btn�ؑ�.Size = new System.Drawing.Size(54, 48);
			this.btn�ؑ�.TabIndex = 2;
			this.btn�ؑ�.Text = "�ؑ�";
			this.btn�ؑ�.Click += new System.EventHandler(this.btn�ؑ�_Click);
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(414, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(376, 50);
			this.tex���b�Z�[�W.TabIndex = 1;
			this.tex���b�Z�[�W.TabStop = false;
			this.tex���b�Z�[�W.Text = "";
			// 
			// btn�I��
			// 
			this.btn�I��.ForeColor = System.Drawing.Color.Red;
			this.btn�I��.Location = new System.Drawing.Point(8, 6);
			this.btn�I��.Name = "btn�I��";
			this.btn�I��.Size = new System.Drawing.Size(54, 48);
			this.btn�I��.TabIndex = 0;
			this.btn�I��.TabStop = false;
			this.btn�I��.Text = "�I��";
			this.btn�I��.Click += new System.EventHandler(this.btn�I��_Click);
			// 
			// pic�O�Q
			// 
			this.pic�O�Q.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic�O�Q.Location = new System.Drawing.Point(22, 90);
			this.pic�O�Q.Name = "pic�O�Q";
			this.pic�O�Q.Size = new System.Drawing.Size(352, 42);
			this.pic�O�Q.TabIndex = 12;
			this.pic�O�Q.TabStop = false;
			this.pic�O�Q.Click += new System.EventHandler(this.pic�O�Q_Click);
			this.pic�O�Q.MouseEnter += new System.EventHandler(this.pic�O�Q_MouseEnter);
			this.pic�O�Q.MouseLeave += new System.EventHandler(this.pic�O�Q_MouseLeave);
			// 
			// pic�O�W
			// 
			this.pic�O�W.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic�O�W.Location = new System.Drawing.Point(402, 160);
			this.pic�O�W.Name = "pic�O�W";
			this.pic�O�W.Size = new System.Drawing.Size(352, 42);
			this.pic�O�W.TabIndex = 12;
			this.pic�O�W.TabStop = false;
			this.pic�O�W.Click += new System.EventHandler(this.pic�O�W_Click);
			this.pic�O�W.MouseEnter += new System.EventHandler(this.pic�O�W_MouseEnter);
			this.pic�O�W.MouseLeave += new System.EventHandler(this.pic�O�W_MouseLeave);
			// 
			// pic�O�V
			// 
			this.pic�O�V.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic�O�V.Location = new System.Drawing.Point(402, 90);
			this.pic�O�V.Name = "pic�O�V";
			this.pic�O�V.Size = new System.Drawing.Size(352, 42);
			this.pic�O�V.TabIndex = 11;
			this.pic�O�V.TabStop = false;
			this.pic�O�V.Click += new System.EventHandler(this.pic�O�V_Click);
			this.pic�O�V.MouseEnter += new System.EventHandler(this.pic�O�V_MouseEnter);
			this.pic�O�V.MouseLeave += new System.EventHandler(this.pic�O�V_MouseLeave);
			// 
			// pic�O�U
			// 
			this.pic�O�U.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic�O�U.Location = new System.Drawing.Point(402, 20);
			this.pic�O�U.Name = "pic�O�U";
			this.pic�O�U.Size = new System.Drawing.Size(352, 42);
			this.pic�O�U.TabIndex = 10;
			this.pic�O�U.TabStop = false;
			this.pic�O�U.Click += new System.EventHandler(this.pic�O�U_Click);
			this.pic�O�U.MouseEnter += new System.EventHandler(this.pic�O�U_MouseEnter);
			this.pic�O�U.MouseLeave += new System.EventHandler(this.pic�O�U_MouseLeave);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(782, 65);
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lab�o�[�W����);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.pan���j���[�U);
			this.panel1.Location = new System.Drawing.Point(0, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 448);
			this.panel1.TabIndex = 17;
			// 
			// lab�o�[�W����
			// 
			this.lab�o�[�W����.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(101)), ((System.Byte)(255)));
			this.lab�o�[�W����.ForeColor = System.Drawing.Color.White;
			this.lab�o�[�W����.Location = new System.Drawing.Point(704, 6);
			this.lab�o�[�W����.Name = "lab�o�[�W����";
			this.lab�o�[�W����.Size = new System.Drawing.Size(60, 12);
			this.lab�o�[�W����.TabIndex = 39;
			this.lab�o�[�W����.Text = "Ver.1.6";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pic�P�O);
			this.panel2.Controls.Add(this.pic�O�S);
			this.panel2.Controls.Add(this.pic�O�R);
			this.panel2.Controls.Add(this.pic�O�P);
			this.panel2.Controls.Add(this.pic�O�T);
			this.panel2.Controls.Add(this.pic�O�X);
			this.panel2.Controls.Add(this.pic�O�U);
			this.panel2.Controls.Add(this.pic�O�V);
			this.panel2.Controls.Add(this.pic�O�W);
			this.panel2.Controls.Add(this.pic�O�Q);
			this.panel2.Location = new System.Drawing.Point(4, 68);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 376);
			this.panel2.TabIndex = 17;
			// 
			// pic�P�O
			// 
			this.pic�P�O.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic�P�O.Location = new System.Drawing.Point(402, 300);
			this.pic�P�O.Name = "pic�P�O";
			this.pic�P�O.Size = new System.Drawing.Size(352, 42);
			this.pic�P�O.TabIndex = 19;
			this.pic�P�O.TabStop = false;
			this.pic�P�O.Click += new System.EventHandler(this.pic�P�O_Click);
			this.pic�P�O.MouseEnter += new System.EventHandler(this.pic�P�O_MouseEnter);
			this.pic�P�O.MouseLeave += new System.EventHandler(this.pic�P�O_MouseLeave);
			// 
			// pic�O�S
			// 
			this.pic�O�S.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic�O�S.Location = new System.Drawing.Point(22, 230);
			this.pic�O�S.Name = "pic�O�S";
			this.pic�O�S.Size = new System.Drawing.Size(352, 42);
			this.pic�O�S.TabIndex = 18;
			this.pic�O�S.TabStop = false;
			this.pic�O�S.Click += new System.EventHandler(this.pic�O�S_Click);
			this.pic�O�S.MouseEnter += new System.EventHandler(this.pic�O�S_MouseEnter);
			this.pic�O�S.MouseLeave += new System.EventHandler(this.pic�O�S_MouseLeave);
			// 
			// pic�O�R
			// 
			this.pic�O�R.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic�O�R.Location = new System.Drawing.Point(22, 160);
			this.pic�O�R.Name = "pic�O�R";
			this.pic�O�R.Size = new System.Drawing.Size(352, 42);
			this.pic�O�R.TabIndex = 17;
			this.pic�O�R.TabStop = false;
			this.pic�O�R.Click += new System.EventHandler(this.pic�O�R_Click);
			this.pic�O�R.MouseEnter += new System.EventHandler(this.pic�O�R_MouseEnter);
			this.pic�O�R.MouseLeave += new System.EventHandler(this.pic�O�R_MouseLeave);
			// 
			// pic�O�P
			// 
			this.pic�O�P.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic�O�P.Location = new System.Drawing.Point(22, 20);
			this.pic�O�P.Name = "pic�O�P";
			this.pic�O�P.Size = new System.Drawing.Size(352, 42);
			this.pic�O�P.TabIndex = 16;
			this.pic�O�P.TabStop = false;
			this.pic�O�P.Click += new System.EventHandler(this.pic�O�P_Click);
			this.pic�O�P.MouseEnter += new System.EventHandler(this.pic�O�P_MouseEnter);
			this.pic�O�P.MouseLeave += new System.EventHandler(this.pic�O�P_MouseLeave);
			// 
			// pic�O�T
			// 
			this.pic�O�T.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic�O�T.Location = new System.Drawing.Point(22, 300);
			this.pic�O�T.Name = "pic�O�T";
			this.pic�O�T.Size = new System.Drawing.Size(352, 42);
			this.pic�O�T.TabIndex = 14;
			this.pic�O�T.TabStop = false;
			this.pic�O�T.Click += new System.EventHandler(this.pic�O�T_Click);
			this.pic�O�T.MouseEnter += new System.EventHandler(this.pic�O�T_MouseEnter);
			this.pic�O�T.MouseLeave += new System.EventHandler(this.pic�O�T_MouseLeave);
			// 
			// pic�O�X
			// 
			this.pic�O�X.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic�O�X.Location = new System.Drawing.Point(402, 230);
			this.pic�O�X.Name = "pic�O�X";
			this.pic�O�X.Size = new System.Drawing.Size(352, 42);
			this.pic�O�X.TabIndex = 13;
			this.pic�O�X.TabStop = false;
			this.pic�O�X.Click += new System.EventHandler(this.pic�O�X_Click);
			this.pic�O�X.MouseEnter += new System.EventHandler(this.pic�O�X_MouseEnter);
			this.pic�O�X.MouseLeave += new System.EventHandler(this.pic�O�X_MouseLeave);
			// 
			// pan���j���[�U
			// 
			this.pan���j���[�U.Controls.Add(this.btn���m�点�P);
			this.pan���j���[�U.Controls.Add(this.btn���m�点�T);
			this.pan���j���[�U.Controls.Add(this.btn���m�点�S);
			this.pan���j���[�U.Controls.Add(this.btn���m�点�R);
			this.pan���j���[�U.Controls.Add(this.btn���m�点�Q);
			this.pan���j���[�U.Location = new System.Drawing.Point(4, 68);
			this.pan���j���[�U.Name = "pan���j���[�U";
			this.pan���j���[�U.Size = new System.Drawing.Size(776, 376);
			this.pan���j���[�U.TabIndex = 34;
			// 
			// btn���m�点�P
			// 
			this.btn���m�点�P.Location = new System.Drawing.Point(22, 20);
			this.btn���m�点�P.Name = "btn���m�点�P";
			this.btn���m�点�P.Size = new System.Drawing.Size(482, 42);
			this.btn���m�点�P.TabIndex = 26;
			this.btn���m�点�P.Visible = false;
			this.btn���m�点�P.ButtonClicked += new System.EventHandler(this.pic���m�点�P_Click);
			// 
			// btn���m�点�T
			// 
			this.btn���m�点�T.Location = new System.Drawing.Point(22, 300);
			this.btn���m�点�T.Name = "btn���m�点�T";
			this.btn���m�点�T.Size = new System.Drawing.Size(482, 42);
			this.btn���m�点�T.TabIndex = 29;
			this.btn���m�点�T.Visible = false;
			this.btn���m�点�T.ButtonClicked += new System.EventHandler(this.pic���m�点�T_Click);
			// 
			// btn���m�点�S
			// 
			this.btn���m�点�S.Location = new System.Drawing.Point(22, 230);
			this.btn���m�点�S.Name = "btn���m�点�S";
			this.btn���m�点�S.Size = new System.Drawing.Size(482, 42);
			this.btn���m�点�S.TabIndex = 28;
			this.btn���m�点�S.Visible = false;
			this.btn���m�点�S.ButtonClicked += new System.EventHandler(this.pic���m�点�S_Click);
			// 
			// btn���m�点�R
			// 
			this.btn���m�点�R.Location = new System.Drawing.Point(22, 160);
			this.btn���m�点�R.Name = "btn���m�点�R";
			this.btn���m�点�R.Size = new System.Drawing.Size(482, 42);
			this.btn���m�点�R.TabIndex = 27;
			this.btn���m�点�R.Visible = false;
			this.btn���m�点�R.ButtonClicked += new System.EventHandler(this.pic���m�点�R_Click);
			// 
			// btn���m�点�Q
			// 
			this.btn���m�点�Q.Location = new System.Drawing.Point(22, 90);
			this.btn���m�点�Q.Name = "btn���m�点�Q";
			this.btn���m�点�Q.Size = new System.Drawing.Size(482, 42);
			this.btn���m�点�Q.TabIndex = 26;
			this.btn���m�点�Q.Visible = false;
			this.btn���m�点�Q.ButtonClicked += new System.EventHandler(this.pic���m�点�Q_Click);
			// 
			// ���j���[
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(792, 574);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "���j���[";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "is-2 Home";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pan���j���[�U.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		[STAThread]
		static void Main() 
		{
			// �A�v���P�[�V�����̓�d�N���h�~
			mutex = new System.Threading.Mutex(false, "is2AdminClient");
			if( mutex.WaitOne(0, false) == false) return;

// ADD 2006.12.06 ���s�j�����J �h�o�A�h���X�擾 START
			try
			{
				string sMName = System.Environment.MachineName;
				// �h�o�A�h���X
				System.Net.IPHostEntry iph = System.Net.Dns.GetHostByName(sMName);
#if DEBUG
				iph.AddressList = new System.Net.IPAddress[3];
				try
				{
					iph.AddressList[0] = System.Net.IPAddress.Parse("172.21.25.14");
					iph.AddressList[1] = System.Net.IPAddress.Parse("10.21.25.14");
					iph.AddressList[2] = System.Net.IPAddress.Parse("11.21.25.14");
				}
				catch(Exception ){}
#endif
// MOD 2015.BEVAS)�O�c �p�i�n���f�B�������ɕ���IP�����蓖�Ă��Ă���ꍇ��IP���� START
				//gs�h�o�A�h���X = iph.AddressList[0].ToString();
				foreach (System.Net.IPAddress aIP in iph.AddressList) 
				{
// MOD 2016.06.10 BEVAS) ���{ WiFi�ݒ肵���[����IP�A�h���X������Ɏ擾�ł��Ȃ��s��Ή� START
//					string ipa = aIP.ToString().Substring(0,3);
//					if (ipa.Equals("172") || ipa.Equals("10")) 
					if(aIP == null ||
						aIP.ToString().Substring(0,4) == "172." ||
						aIP.ToString().Substring(0,3) == "10.")
// MOD 2016.06.10 BEVAS) ���{ WiFi�ݒ肵���[����IP�A�h���X������Ɏ擾�ł��Ȃ��s��Ή� END
					{
	 					gs�h�o�A�h���X = aIP.ToString();
					}
				}
				if (gs�h�o�A�h���X.Equals("")) 
				{
					gs�h�o�A�h���X = iph.AddressList[0].ToString();
				}
// MOD 2015.BEVAS)�O�c �p�i�n���f�B�������ɕ���IP�����蓖�Ă��Ă���ꍇ��IP���� END
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
// �{�ԗp�̓R�����g�ɁI�I
//gs�h�o�A�h���X = "10.44.1.200";
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
			}
			catch(Exception)
			{
				MessageBox.Show("�F�؃G���[�F�h�o�A�h���X�̎擾�Ɏ��s���܂����B", "���O�C��", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				// �~���[�e�b�N�X�̔j��
				mutex.Close();
				Application.Exit();
				return;
			}
// ADD 2006.12.06 ���s�j�����J �h�o�A�h���X�擾 END

// ADD 2007.02.06 ���s�j���� �C���[�W���[�h�G���[�Ή� START
			// �J�����g�f�B���N�g���̎擾
			gs�A�v���t�H���_ = System.IO.Directory.GetCurrentDirectory();
// ADD 2007.02.06 ���s�j���� �C���[�W���[�h�G���[�Ή� END

			try
			{
// MOD 2005.05.27 ���s�j���� �X���b�h�ʒu�̕ύX START
//				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
//				sv_maintenance.CookieContainer = cContainer;
				trd = new Thread(new ThreadStart(ThreadTask));
				trd.IsBackground = true;
				trd.Start();
// MOD 2005.05.27 ���s�j���� �X���b�h�ʒu�̕ύX END

// ADD 2008.04.11 ACT Vista�Ή� START
				try
				{
					�����ϊ��n�b�V���ݒ�();
				}
				catch(Exception ex)
				{
					�r�[�v��();
					MessageBox.Show(ex.Message, 
						"�����ϊ��擾", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					// �~���[�e�b�N�X�̔j��
					mutex.Close();
					Application.Exit();
					return;
				}		
// ADD 2008.04.11 ACT Vista�Ή� END

// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� START
			try{
				FileInfo finfo = new FileInfo("is2AdminClient.exe.config");
				if(finfo.Exists){
					XmlDocument xmldoc = new XmlDocument();
					xmldoc.Load(finfo.FullName);
					foreach(XmlNode node in xmldoc["configuration"]["appSettings"]){
							if(node.Attributes.GetNamedItem("key").Value.Equals("HelpURL")){
							s�}�j���A���t�q�k = node.Attributes.GetNamedItem("value").Value;
						}
					}
					xmldoc = null;
				}
				finfo = null;
			}catch(Exception){
				;
			}
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� END

				// ���O�C����ʂ�\��
// MOD 2007.11.29 ���s�j���� ���O�C�����̃t�H�[�J�X��Q�Ή� START
//				���O�C�� ��� = new ���O�C��();
//				���.ShowDialog();
//			
//				// �F�؂Ɏ��s�����ꍇ�F�A�v���I��
//				if(!���.b�F��)
//				{
//					// �~���[�e�b�N�X�̔j��
//					mutex.Close();
//					Application.Exit();
//					return;
//				}
				F���O�C�� = new ���O�C��();
				F���O�C��.WindowState = FormWindowState.Normal;
				F���O�C��.ShowDialog();
			
				// �F�؂Ɏ��s�����ꍇ�F�A�v���I��
				if(!F���O�C��.b�F��)
				{
					// �~���[�e�b�N�X�̔j��
					mutex.Close();
					Application.Exit();
					return;
				}
				F���O�C�� = null;
// MOD 2007.11.29 ���s�j���� ���O�C�����̃t�H�[�J�X��Q�Ή� END
// DEL 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX START
//				//����R�[�h��"honbu"�̏ꍇ�F�X�����͉�ʂ�\��
//// MOD 2007.01.30 ���s�j���� ���ꌠ�����[�U�̒ǉ� START
////				if(gs����R�[�h == "honbu")
//				if(gs����R�[�h == "honbu"
//				|| gs����R�[�h == "kikaku")
//// MOD 2007.01.30 ���s�j���� ���ꌠ�����[�U�̒ǉ� END
//				{
//					// ���O�C����ʂ�\��
//					�X������ �X�� = new �X������();
//					�X��.ShowDialog();
//			
//					// �F�؂Ɏ��s�����ꍇ�F�A�v���I��
//					if(!�X��.b�F��)
//					{
//						// �~���[�e�b�N�X�̔j��
//						mutex.Close();
//						Application.Exit();
//						return;
//					}
//				}
// DEL 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END
			}
			catch (Exception)
			{
				// �~���[�e�b�N�X�̔j��
				mutex.Close();
				Application.Exit();
				return;
			}

// ADD 2005.05.27 ���s�j���� ��ʑJ�ڂ𑬂����� START
			// �X���b�h�ł͎��s�ł��Ȃ��̂ŁA�����Ŏ��{
			if(g����}�X == null) g����}�X = new ����}�X�^();
			if(g������� == null) g������� = new �������();
			if(g�L���o�^ == null) g�L���o�^ = new �L���o�^();
			if(g�W��X�} == null) g�W��X�} = new �W��X�}�X�^();
			if(g�Z������ == null) g�Z������ = new �Z������();
			if(g������} == null) g������} = new ������}�X�^();
			if(g�X������ == null) g�X������ = new �X������();
// DEL 2008.05.08 ���s�j���� �Z�N�V���������폜 START
//			if(g���匟�� == null) g���匟�� = new ���匟��();
// DEL 2008.05.08 ���s�j���� �Z�N�V���������폜 END
// ADD 2005.05.27 ���s�j���� ��ʑJ�ڂ𑬂����� END
// ADD 2006.07.11 ���s�j���� ��ʕύX START
			if(g�������� == null) g�������� = new ��������();
// ADD 2006.07.11 ���s�j���� ��ʕύX END
// ADD 2006.12.12 ���s�j���� ��ʒǉ� START
			if(g�o�׏Ɖ� == null) g�o�׏Ɖ� = new �o�׏Ɖ�();
// DEL 2008.05.07 ���s�j���� ���˗��匟���폜 START
//			if(g�˗����� == null) g�˗����� = new ���˗��匟��();
// DEL 2008.05.07 ���s�j���� ���˗��匟���폜 END
// MOD 2007.01.18 ���s�j���� ��ʖ��̕ύX START
//			if(g���X�d�� == null) g���X�d�� = new ���X�d��();
			if(g���X�d�� == null) g���X�d�� = new ���X�d��();
// MOD 2007.01.18 ���s�j���� ��ʖ��̕ύX END
// ADD 2006.12.12 ���s�j���� ��ʒǉ� END
// ADD 2007.11.16 KCL) �X�{ ��ʒǉ� START
			if (g������Q == null) g������Q = new ��������Q();
			if (g�˗����Q == null) g�˗����Q = new ���˗��匟���Q();
// ADD 2007.11.16 KCL) �X�{ ��ʒǉ� END
// ADD 2007.12.05 KCL) �X�{ ���m�点�ǉ� START
			if (g���m�o�^ == null) g���m�o�^ = new ���m�点�o�^();
			if (g���m���� == null) g���m���� = new ���m�点����();
// ADD 2007.12.05 KCL) �X�{ ���m�点�ǉ� END
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� START
			if (g���m�\�� == null) g���m�\�� = new ���m�点�\��();
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� END
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� START
			if (g�}�j���A == null) g�}�j���A = new �}�j���A���_�E�����[�h();
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� END
// ADD 2006.12.12 ���s�j���� ��ʒǉ� START
			if(��ԏ��擾() == false)
			{
				// �~���[�e�b�N�X�̔j��
				mutex.Close();
				Application.Exit();
				return;
			}
// ADD 2006.12.12 ���s�j���� ��ʒǉ� END

			Application.Run(new ���j���[());
		}

		private static bool ��ԏ��擾()
		{
			// ���Ɏ擾���Ă����ꍇ�ɂ͏I��
			if(gsa��Ԃb�c.Length > 1 && gsa��Ԃb�c[0].Length > 0) return true;

			try
			{	
				// ��ԃ��X�g���擾
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				string[] sRet = sv_maintenance.Get_jyotai(gsa���[�U);
				if( sRet[0].Length == 4 ){
					int i��Ԑ� = int.Parse(sRet[1]);
					if(i��Ԑ� > 0)
					{
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
//						gsa��Ԃb�c = new string[1 + i��Ԑ�];
//						gsa��Ԗ��@ = new string[1 + i��Ԑ�];
						gsa��Ԃb�c = new string[2 + i��Ԑ�];
						gsa��Ԗ��@ = new string[2 + i��Ԑ�];
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
						gsa��Ԃb�c[0] = "00";
						gsa��Ԗ�[0]   = "�S��";
						int iPos = 2;
						for(int iCnt = 1; iCnt <= i��Ԑ� && iPos < sRet.Length; iCnt++)
						{
							gsa��Ԃb�c[iCnt] = sRet[iPos++];
							gsa��Ԗ�[iCnt]   = sRet[iPos++];
						}
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
						gsa��Ԃb�c[i��Ԑ� + 1] = "90";
						gsa��Ԗ�[i��Ԑ� + 1]   = "���o��";
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
					}
				}
			}
// MOD 2005.06.30 ���s�j���� �ʐM�G���[�̃��b�Z�[�W�C�� START
//			catch (Exception)
//			{
//				return false;
//			}
			catch (System.Net.WebException)
			{
				�r�[�v��();
				MessageBox.Show(gs�ʐM�G���[, 
								"�ʐM�G���[", 
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			catch (Exception ex)
			{
				�r�[�v��();
				MessageBox.Show(ex.Message, 
								"�ʐM�G���[", 
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
// MOD 2005.06.30 ���s�j���� �ʐM�G���[�̃��b�Z�[�W�C�� END

			return true;
		}
// ADD 2005.05.27 ���s�j���� �N�����Ԃ�Z������ END

		private void Form3_Load(object sender, System.EventArgs e)
		{
// ADD 2007.10.26 ���s�j���� �o�[�W�������̕\�� START
			if(gsa���[�U[3].Length > 0) lab�o�[�W����.Text = "Ver." + gsa���[�U[3];
// ADD 2007.10.26 ���s�j���� �o�[�W�������̕\�� END
			// �����̏����ݒ�
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;

			�R�}���h�C���[�W�̏�����();

			// �{�^���C���[�W�̏�����
			pic�z�[��.Image          = Image.FromFile("img\\home.gif");
// MOD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX START
//			pictureBox1.Image        = imageCmd[10];
			pictureBox1.Image        = Image.FromFile("img\\upperbar.gif");
// MOD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END
// MOD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX START
//// MOD 2006.10.04 ���s�j�R�{ �X�����j���[�֑̐ؑΉ� START
//			if(gs�X���R�[�h.Trim().Length == 0)
//			{
//				pic�O�U.Image      = imageCmd[0];
//				pic�O�V.Image    = imageCmd[2];
//				pic�O�W.Image    = imageCmd[4];
//				pic�O�Q.Image    = imageCmd[6];
//				pic�O�X.Image        = imageCmd[8];
//// DEL 2006.07.11 ���s�j���� ��ʕύX START
////			pictureBox2.Image        = imageCmd[11];
//// DEL 2006.07.11 ���s�j���� ��ʕύX END
////			pictureBox3.Image        = imageCmd[12];
//				pic�O�T.Image  = imageCmd[13];
//// ADD 2006.07.11 ���s�j���� ��ʕύX START
//				pic�O�P.Image        = img������Fa;
//				pic�O�R.Image        = img�ғ�����a;
//				pic�O�S.Image        = img�o�׏�a;
//// ADD 2006.07.11 ���s�j���� ��ʕύX END
//			}
//			else
//			{
//				pic�O�P.Image        = img������Fa;
//				pic�O�Q.Image    = imageCmd[6];
//				pic�O�R.Image        = img�ғ�����a;
//				pic�O�S.Image        = img�o�׏�a;
//				pic�O�T.Image  = imageCmd[13];
//
//				pic�O�U.Visible = false;
//				pic�O�V.Visible = false;
//				pic�O�W.Visible = false;
//				pic�O�X.Visible = false;
//			
//			}
//// MOD 2006.10.04 ���s�j�R�{ �X�����j���[�֑̐ؑΉ� END
			���j���[�{�^���ݒ�();
// MOD 2009.08.07 ���s�j���� �ؑփ{�^���̐����Q�Ή� START
//			if(gs�X���R�[�h.Trim().Length == 0){
			// �Ǘ��҉���̏ꍇ
			if(gs�Ǘ��ҋ敪 == "1"){
// MOD 2009.08.07 ���s�j���� �ؑփ{�^���̐����Q�Ή� END
				btn�ؑ�.Visible = true;
			}else{
				btn�ؑ�.Visible = false;
			}
// MOD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END
// DEL 2005.05.27 ���s�j���� �X���b�h�ʒu�̈ړ� START
//// ADD 2005.05.25 ���s�j�����J �X���b�h�� START
//			trd = new Thread(new ThreadStart(ThreadTask));
//			trd.IsBackground = true;
//			trd.Start();
//// ADD 2005.05.25 ���s�j�����J �X���b�h�� END
// DEL 2005.05.27 ���s�j���� �X���b�h�ʒu�̈ړ� END
// MOD 2009.08.07 ���s�j���� �ؑփ{�^���̐����Q�Ή� START
			//���m�点�p�l���̔�\��
			pan���j���[�U.Visible = false;
// MOD 2009.08.07 ���s�j���� �ؑփ{�^���̐����Q�Ή� END
		}

		private void btn�I��_Click(object sender, System.EventArgs e)
		{
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� START
			if(pan���j���[�U.Visible){
				panel2.Visible = true;
				pan���j���[�U.Visible = false;
				btn�I��.Text = "�I��";
// MOD 2009.08.07 ���s�j���� �ؑփ{�^���̐����Q�Ή� START
//				if(gs�X���R�[�h.Trim().Length != 0){
				// �Ǘ��҉���̏ꍇ
				if(gs�Ǘ��ҋ敪 == "1"){
// MOD 2009.08.07 ���s�j���� �ؑփ{�^���̐����Q�Ή� END
					btn�ؑ�.Visible = true;
				}
				return;
			}
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� END
// ADD 2007.03.14 FJCS�j�K�c�@�I�����b�Z�[�W�\�� START
			DialogResult result = MessageBox.Show("�I�����܂����H", "�I��", 
				MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
// ADD 2007.03.14 FJCS�j�K�c�@�I�����b�Z�[�W�\�� END
				// �~���[�e�b�N�X�̔j��
				mutex.Close();
				Application.Exit();
// ADD 2007.03.14 FJCS�j�K�c�@�I�����b�Z�[�W�\�� START
			}
			else
			{
				return;
			}
// ADD 2007.03.14 FJCS�j�K�c�@�I�����b�Z�[�W�\�� END
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
		}

		private void pic�O�U_Click(object sender, System.EventArgs e)
		{
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� START
			if(gs�X���R�[�h.Trim().Length != 0)
			{
				panel2.Visible = false;
				btn�I��.Text = "����";
				btn�ؑ�.Visible = false;
				// ���m�点�̐ݒ�
				���m�点�̎擾�ƕ\��();
				pan���j���[�U.Visible = true;
				return;
			}
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� END
			if (g����}�X == null)	 g����}�X = new ����}�X�^();
			g����}�X.Left = this.Left;
			g����}�X.Top = this.Top;
			this.Visible = false;
			g����}�X.ShowDialog(this);
			this.Visible = true;
		}

		private void pic�O�V_Click(object sender, System.EventArgs e)
		{
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� START
			if(gs�X���R�[�h.Trim().Length != 0)
			{
				if(g�}�j���A == null) g�}�j���A = new �}�j���A���_�E�����[�h();
				g�}�j���A.Left = this.Left + (this.Width  - g�}�j���A.Width)  / 2;
				g�}�j���A.Top  = this.Top  + (this.Height - g�}�j���A.Height) / 2;
				g�}�j���A.s�}�j���A���t�q�k = s�}�j���A���t�q�k;
				g�}�j���A.ShowDialog(this);
				
				return;
			}
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� END
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			������}�X�^ ��� = new ������}�X�^();
//			���.Left = this.Left;
//			���.Top = this.Top;
			if (g������} == null)	 g������} = new ������}�X�^();
			g������}.Left = this.Left;
			g������}.Top = this.Top;
// MOD 2005.05.09 ���s�j���� ��ʑJ�ڂ̕ύX START
//			���.ShowDialog();  /////
			this.Visible = false;
//			���.ShowDialog(this);
			g������}.ShowDialog(this);
			this.Visible = true;
// MOD 2005.05.09 ���s�j���� ��ʑJ�ڂ̕ύX END
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
		}

		private void pic�O�W_Click(object sender, System.EventArgs e)
		{
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			�W��X�}�X�^ ��� = new �W��X�}�X�^();
// MOD 2005.05.09 ���s�j���� ��ʑJ�ڂ̕ύX START ////
//			���.Left = this.Left + 202; ////
//			���.Top = this.Top; ////
//			���.ShowDialog(); ////
//			���.Left = this.Left + (this.Width  - ���.Width)  / 2;
//			���.Top = this.Top;
//			���.ShowDialog(this);
			if (g�W��X�} == null)	 g�W��X�} = new �W��X�}�X�^();
			g�W��X�}.Left = this.Left + (this.Width  - g�W��X�}.Width)  / 2;
			g�W��X�}.Top = this.Top;
			g�W��X�}.ShowDialog(this);
// MOD 2005.05.09 ���s�j���� ��ʑJ�ڂ̕ύX END
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
		}

		private void pic�O�Q_Click(object sender, System.EventArgs e)
		{
// MOD 2006.10.04 ���s�j�R�{ �X�����j���[�֑̐ؑΉ� START
			if(gs�X���R�[�h.Trim().Length == 0)
			{
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			������b�r�u�o�� ��� = new ������b�r�u�o��();
// MOD 2005.05.09 ���s�j���� ��ʑJ�ڂ̕ύX START
//			���.Left = this.Left + 202; ////
//			���.Top = this.Top; ////
//			���.ShowDialog(); ////
//			���.Left = this.Left + (this.Width  - ���.Width)  / 2;
//			���.Top  = this.Top  + (this.Height - ���.Height) / 2;
//			���.ShowDialog(this);
				if (g����o�� == null)	 g����o�� = new ������b�r�u�o��();
				g����o��.Left = this.Left + (this.Width  - g����o��.Width)  / 2;
				g����o��.Top  = this.Top  + (this.Height - g����o��.Height) / 2;
				g����o��.ShowDialog(this);
//// MOD 2005.05.09 ���s�j���� ��ʑJ�ڂ̕ύX END
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
			}
			else
			{
				if (g������} == null)	 g������} = new ������}�X�^();
				g������}.Left = this.Left;
				g������}.Top = this.Top;
				this.Visible = false;
				g������}.ShowDialog(this);
				this.Visible = true;
			}
// MOD 2006.10.04 ���s�j�R�{ �X�����j���[�֑̐ؑΉ� END
		}

// ADD 2005.05.16 ���s�j�ɉ� �L���o�^�̒ǉ� START
		private void pic�O�X_Click(object sender, System.EventArgs e)
		{
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			�L���o�^ ��� = new �L���o�^();
//			���.Left = this.Left + (this.Width - ���.Width) / 2;
//			���.Top  = this.Top;
//			���.ShowDialog();
			if (g�L���o�^ == null)	 g�L���o�^ = new �L���o�^();
			g�L���o�^.Left = this.Left + (this.Width - g�L���o�^.Width) / 2;
			g�L���o�^.Top  = this.Top;
			g�L���o�^.ShowDialog();
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
		}
// ADD 2005.05.16 ���s�j�ɉ� �L���o�^�̒ǉ� END

// ADD 2005.05.24 ���s�j�����J ���b�Z�[�W�o�^�̒ǉ� START
		private void pic�O�T_Click(object sender, System.EventArgs e)
		{
// MOD 2006.10.04 ���s�j�R�{ �X�����j���[�֑̐ؑΉ� START
			if(gs�X���R�[�h.Trim().Length == 0)
			{
				// MOD 2005.05.27 ���s�j���� ���b�Z�[�W�o�^��ʂ̒ǉ� START
				//			���b�Z�[�W�o�^ ��� = new ���b�Z�[�W�o�^();
				//			���.Left = this.Left;
				//			���.Top  = this.Top;
				//			���.ShowDialog();
				if(g���Z�o�^ == null) g���Z�o�^ = new ���b�Z�[�W�o�^();
				g���Z�o�^.Left = this.Left + (this.Width  - g���Z�o�^.Width)  / 2;
				g���Z�o�^.Top  = this.Top  + (this.Height - g���Z�o�^.Height) / 2;
				g���Z�o�^.ShowDialog();
				// MOD 2005.05.27 ���s�j���� ���b�Z�[�W�o�^��ʂ̒ǉ� END
			}
			else
			{
// ADD 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� START
// MOD 2007.02.19 FJCS�j�K�c ���j���[���̕ύX START
//				if(g�o�׏� == null) g�o�׏� = new �o�׏�();
//				g�o�׏�.Left = this.Left + (this.Width  - g�o�׏�.Width)  / 2;
//				g�o�׏�.Top  = this.Top  + (this.Height - g�o�׏�.Height) / 2;
//				g�o�׏�.ShowDialog(this);
				if(g���X�d�� == null) g���X�d�� = new ���X�d��();
				g���X�d��.Left = this.Left + (this.Width  - g���X�d��.Width)  / 2;
				g���X�d��.Top  = this.Top  + (this.Height - g���X�d��.Height) / 2;
				g���X�d��.ShowDialog();
// MOD 2007.02.19 FJCS�j�K�c ���j���[���̕ύX END
// ADD 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� END
			}
		}
// ADD 2005.05.24 ���s�j�����J ���b�Z�[�W�o�^�̒ǉ� END

		private void pic�O�U_MouseEnter(object sender, System.EventArgs e)
		{
			pic�O�U.Image = imageCmd_b[6];
		}

		private void pic�O�U_MouseLeave(object sender, System.EventArgs e)
		{
			pic�O�U.Image = imageCmd_a[6];
		}

		private void pic�O�V_MouseEnter(object sender, System.EventArgs e)
		{
			pic�O�V.Image = imageCmd_b[7];
		}

		private void pic�O�V_MouseLeave(object sender, System.EventArgs e)
		{
			pic�O�V.Image = imageCmd_a[7];
		}

		private void pic�O�W_MouseEnter(object sender, System.EventArgs e)
		{
			pic�O�W.Image = imageCmd_b[8];
		}

		private void pic�O�W_MouseLeave(object sender, System.EventArgs e)
		{
			pic�O�W.Image = imageCmd_a[8];
		}

		private void pic�O�Q_MouseEnter(object sender, System.EventArgs e)
		{
			pic�O�Q.Image = imageCmd_b[2];
		}

		private void pic�O�Q_MouseLeave(object sender, System.EventArgs e)
		{
			pic�O�Q.Image = imageCmd_a[2];
		}

		private void pic�O�X_MouseEnter(object sender, System.EventArgs e)
		{
			pic�O�X.Image = imageCmd_b[9];
		}

		private void pic�O�X_MouseLeave(object sender, System.EventArgs e)
		{
			pic�O�X.Image = imageCmd_a[9];
		}

// ADD 2005.05.24 ���s�j�����J ���b�Z�[�W�o�^�̒ǉ� START
		private void pic�O�T_MouseEnter(object sender, System.EventArgs e)
		{
			pic�O�T.Image = imageCmd_b[5];
		}

		private void pic�O�T_MouseLeave(object sender, System.EventArgs e)
		{
			pic�O�T.Image = imageCmd_a[5];
		}
// ADD 2005.05.24 ���s�j�����J ���b�Z�[�W�o�^�̒ǉ� END

// MOD 2005.05.27 ���s�j���� �X���b�h�ʒu�̈ړ� START
//		private void �R�}���h�C���[�W�̏�����()
		private static void �R�}���h�C���[�W�̏�����()
// MOD 2005.05.27 ���s�j���� �X���b�h�ʒu�̈ړ� END
		{
// MOD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END
//			if(imageCmd != null) return;
//
//			imageCmd = new Image[15];
//// MOD 2006.10.04 ���s�j�R�{ �X�����j���[�֑̐ؑΉ� START
//			if(gs�X���R�[�h.Trim().Length == 0)
//			{
//				imageCmd[0] = Image.FromFile("img\\fm101a.gif");
//				imageCmd[1] = Image.FromFile("img\\fm101b.gif");
//				imageCmd[2] = Image.FromFile("img\\fm102a.gif");
//				imageCmd[3] = Image.FromFile("img\\fm102b.gif");
//				imageCmd[4] = Image.FromFile("img\\fm103a.gif");
//				imageCmd[5] = Image.FromFile("img\\fm103b.gif");
//				imageCmd[6] = Image.FromFile("img\\fm104a.gif");
//				imageCmd[7] = Image.FromFile("img\\fm104b.gif");
//				imageCmd[8] = Image.FromFile("img\\fm105a.gif");
//				imageCmd[9] = Image.FromFile("img\\fm105b.gif");
//				imageCmd[10] = Image.FromFile("img\\upperbar.gif");
//// DEL 2006.07.11 ���s�j���� ��ʕύX START
////				imageCmd[11] = Image.FromFile("img\\sidebar.gif");
//// DEL 2006.07.11 ���s�j���� ��ʕύX END
//// DEL 2005.06.14 ���s�j���� �s�v�Ȉ׍폜 START
////				imageCmd[12] = Image.FromFile("img\\i-start.gif");
//// DEL 2005.06.14 ���s�j���� �s�v�Ȉ׍폜 END
//				imageCmd[13] = Image.FromFile("img\\fm106a.gif");
//				imageCmd[14] = Image.FromFile("img\\fm106b.gif");
//// ADD 2006.07.11 ���s�j���� ��ʕύX START
//				img������Fa = �C���[�W�ݒ�("img\\fm107a.gif");
//				img������Fb = �C���[�W�ݒ�("img\\fm107b.gif");
//				img�ғ�����a = �C���[�W�ݒ�("img\\fm108a.gif");
//				img�ғ�����b = �C���[�W�ݒ�("img\\fm108b.gif");
//				img�o�׏�a = �C���[�W�ݒ�("img\\fm109a.gif");
//				img�o�׏�b = �C���[�W�ݒ�("img\\fm109b.gif");
//// ADD 2006.07.11 ���s�j���� ��ʕύX END
//			}
//			else
//			{
//				imageCmd[6] = Image.FromFile("img\\fm102a.gif");
//				imageCmd[7] = Image.FromFile("img\\fm102b.gif");
//				imageCmd[10] = Image.FromFile("img\\upperbar.gif");
//// DEL 2006.11.06 ���s�j���� �X������ʂ̒ǉ� START
////				imageCmd[13] = Image.FromFile("img\\fm�x�X�o�^a.gif");
////				imageCmd[14] = Image.FromFile("img\\fm�x�X�o�^b.gif");
//// DEL 2006.11.06 ���s�j���� �X������ʂ̒ǉ� END
//				img������Fa = �C���[�W�ݒ�("img\\fm201a.gif");
//				img������Fb = �C���[�W�ݒ�("img\\fm201b.gif");
//				img�ғ�����a = �C���[�W�ݒ�("img\\fm203a.gif");
//				img�ғ�����b = �C���[�W�ݒ�("img\\fm203b.gif");
//				img�o�׏�a = �C���[�W�ݒ�("img\\fm204a.gif");
//				img�o�׏�b = �C���[�W�ݒ�("img\\fm204b.gif");
//			}
//// MOD 2006.10.04 ���s�j�R�{ �X�����j���[�֑̐ؑΉ� START
			if(imageCmd_a != null) return;
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� START
//// MOD 2007.12.04 KCL) �X�{ ���m�点�ǉ� START
////		imageCmd_a = new Image[10];
////		imageCmd_b = new Image[10];
//			imageCmd_a = new Image[11];
//			imageCmd_b = new Image[11];
			imageCmd_a = new Image[12];
			imageCmd_b = new Image[12];
// MOD 2007.12.04 KCL) �X�{ ���m�点�ǉ� END
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� END

			img�g�p���Fa = �C���[�W�ݒ�("img\\fm107a.gif");
			img�g�p���Fb = �C���[�W�ݒ�("img\\fm107b.gif");
			img���q�l��a = �C���[�W�ݒ�("img\\fm104a.gif");
			img���q�l��b = �C���[�W�ݒ�("img\\fm104b.gif");
			img�ғ�����a = �C���[�W�ݒ�("img\\fm108a.gif");
			img�ғ�����b = �C���[�W�ݒ�("img\\fm108b.gif");
			img�o�׏�a = �C���[�W�ݒ�("img\\fm109a.gif");
			img�o�׏�b = �C���[�W�ݒ�("img\\fm109b.gif");
			img���b�Z�Wa = �C���[�W�ݒ�("img\\fm106a.gif");
			img���b�Z�Wb = �C���[�W�ݒ�("img\\fm106b.gif");
			img�g�p�o�^a = �C���[�W�ݒ�("img\\fm101a.gif");
			img�g�p�o�^b = �C���[�W�ݒ�("img\\fm101b.gif");
			img������oa = �C���[�W�ݒ�("img\\fm102a.gif");
			img������ob = �C���[�W�ݒ�("img\\fm102b.gif");
			img�W��X�oa = �C���[�W�ݒ�("img\\fm103a.gif");
			img�W��X�ob = �C���[�W�ݒ�("img\\fm103b.gif");
			img�A�����ia = �C���[�W�ݒ�("img\\fm105a.gif");
			img�A�����ib = �C���[�W�ݒ�("img\\fm105b.gif");

			img�g�p�\��a = �C���[�W�ݒ�("img\\fm201a.gif");
			img�g�p�\��b = �C���[�W�ݒ�("img\\fm201b.gif");
//			img������oa = �C���[�W�ݒ�("img\\fm202a.gif");
//			img������ob = �C���[�W�ݒ�("img\\fm202b.gif");
			img�o�׏Ɖ�a = �C���[�W�ݒ�("img\\fm203a.gif");
			img�o�׏Ɖ�b = �C���[�W�ݒ�("img\\fm203b.gif");
			img���X�d��a = �C���[�W�ݒ�("img\\fm204a.gif");
			img���X�d��b = �C���[�W�ݒ�("img\\fm204b.gif");
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� START
			img���m�点a = �C���[�W�ݒ�("img\\fm111a.gif");
			img���m�点b = �C���[�W�ݒ�("img\\fm111b.gif");
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� END
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� START
			img���m�\��a = �C���[�W�ݒ�("img\\fm206a.gif");;
			img���m�\��b = �C���[�W�ݒ�("img\\fm206b.gif");;
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� END
// MOD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� START
			img�}�j���Aa = �C���[�W�ݒ�("img\\fm207a.gif");;
			img�}�j���Ab = �C���[�W�ݒ�("img\\fm207b.gif");;
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� END
		}

// ADD 2006.07.11 ���s�j���� ��ʕύX START
		private static Image �C���[�W�ݒ�(string s�摜)
		{
			try{
				return Image.FromFile(s�摜);
			}catch(FileNotFoundException){
				 ;
			}
			return null;
		}
// ADD 2006.07.11 ���s�j���� ��ʕύX END

// ADD 2005.05.25 ���s�j�����J �X���b�h�� START
		private static  void ThreadTask()
		{
// ADD 2005.05.27 ���s�j���� �X���b�h�ʒu�̕ύX START
			if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
// ADD 2005.05.27 ���s�j���� �X���b�h�ʒu�̕ύX END
// ADD 2007.12.11 KCL) �X�{ ���m�点�ǉ� START
			if(sv_oshirase == null) sv_oshirase = new is2oshirase.Service1();
// ADD 2007.12.11 KCL) �X�{ ���m�点�ǉ� END
// MOD 2011.01.14 ���s�j���� ���q�^���Ή� START
			if(sv_oji == null) sv_oji = new is2oji.Service1();
// MOD 2011.01.14 ���s�j���� ���q�^���Ή� END
			if(g����o�� == null) g����o�� = new ������b�r�u�o��();

// ADD 2005.05.27 ���s�j���� ���b�Z�[�W�o�^��ʂ̒ǉ� START
			if(g���Z�o�^ == null) g���Z�o�^ = new ���b�Z�[�W�o�^();
// DEL 2006.10.04 ���s�j�R�{ �X�����j���[�֑ؑΉ� START
//			�R�}���h�C���[�W�̏�����();
// DEL 2006.10.04 ���s�j�R�{ �X�����j���[�֑ؑΉ� END
// ADD 2005.05.27 ���s�j���� ���b�Z�[�W�o�^��ʂ̒ǉ� END
// ADD 2006.07.11 ���s�j���� ��ʕύX START
			if(g������� == null) g������� = new �������();
			if(g�ғ����� == null) g�ғ����� = new �ғ�����();
			if(g�o�׏� == null) g�o�׏� = new �o�׏�();
// ADD 2006.07.11 ���s�j���� ��ʕύX END
// ADD 2006.11.06 ���s�j���� �X������ʂ̒ǉ� START
			if(g�X����� == null) g�X����� = new �X�����();
// ADD 2006.11.06 ���s�j���� �X������ʂ̒ǉ� END
// ADD 2007.02.06 ���s�j���� �C���[�W���[�h�G���[�Ή� START
			if(g�X������ == null) g�X������ = new �X������();
// ADD 2007.02.06 ���s�j���� �C���[�W���[�h�G���[�Ή� END
// ADD 2007.02.06 ���s�j���� �v���r���[��ʂ̍����� START
			if(g�v���r�� == null) g�v���r�� = new �v���r���[���();
// ADD 2007.02.06 ���s�j���� �v���r���[��ʂ̍����� END
// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� START
			if(g�ғ����o == null) g�ғ����o = new �ғ����o�^();
// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� END

// ADD 2007.11.29 ���s�j���� ���O�C�����̃t�H�[�J�X��Q�Ή� START
			if(F���O�C�� != null) F���O�C��.Focus();
// ADD 2007.11.29 ���s�j���� ���O�C�����̃t�H�[�J�X��Q�Ή� END
		}
// ADD 2005.05.25 ���s�j�����J �X���b�h�� END

// ADD 2006.07.11 ���s�j���� ��ʕύX START
		private void pic�O�P_MouseEnter(object sender, System.EventArgs e)
		{
			pic�O�P.Image = imageCmd_b[1];
		}

		private void pic�O�P_MouseLeave(object sender, System.EventArgs e)
		{
			pic�O�P.Image = imageCmd_a[1];
		}

		private void pic�O�R_MouseEnter(object sender, System.EventArgs e)
		{
			pic�O�R.Image = imageCmd_b[3];
		}

		private void pic�O�R_MouseLeave(object sender, System.EventArgs e)
		{
			pic�O�R.Image = imageCmd_a[3];
		}

		private void pic�O�S_MouseEnter(object sender, System.EventArgs e)
		{
			pic�O�S.Image = imageCmd_b[4];
		}

		private void pic�O�S_MouseLeave(object sender, System.EventArgs e)
		{
			pic�O�S.Image = imageCmd_a[4];
		}
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� START
		private void pic�P�O_MouseEnter(object sender, System.EventArgs e)
		{
			pic�P�O.Image = imageCmd_b[10];
		}

		private void pic�P�O_MouseLeave(object sender, System.EventArgs e)
		{
			pic�P�O.Image = imageCmd_a[10];
		}
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� END

		private void pic�O�P_Click(object sender, System.EventArgs e)
		{
			if(g������� == null) g������� = new �������();
			g�������.Left = this.Left;
			g�������.Top = this.Top;
			this.Visible = false;
			g�������.ShowDialog(this);
			this.Visible = true;
		}

		private void pic�O�R_Click(object sender, System.EventArgs e)
		{
// ADD 2006.11.24 ���s�j���� ��Q����ׁ̈A���s�ł��Ȃ����� START
//			if(gs�X���R�[�h.Trim().Length == 0) return;
// ADD 2006.11.24 ���s�j���� ��Q����ׁ̈A���s�ł��Ȃ����� END
// MOD 2006.10.04 ���s�j�R�{ �X�����j���[�֑̐ؑΉ� START
			if(gs�X���R�[�h.Trim().Length == 0)
			{
				if(g�ғ����� == null) g�ғ����� = new �ғ�����();
				g�ғ�����.Left = this.Left + (this.Width  - g�ғ�����.Width)  / 2;
				g�ғ�����.Top  = this.Top  + (this.Height - g�ғ�����.Height) / 2;
				g�ғ�����.ShowDialog(this);
			}
			else
			{
// ADD 2006.12.12 ���s�j���� ��ʒǉ� START
				if(g�o�׏Ɖ� == null) g�o�׏Ɖ� = new �o�׏Ɖ�();
				g�o�׏Ɖ�.Left = this.Left + (this.Width  - g�o�׏Ɖ�.Width)  / 2;
				g�o�׏Ɖ�.Top  = this.Top  + (this.Height - g�o�׏Ɖ�.Height) / 2;
				this.Visible = false;
				g�o�׏Ɖ�.ShowDialog();
				this.Visible = true;
// ADD 2006.12.12 ���s�j���� ��ʒǉ� END
			}
// MOD 2006.10.04 ���s�j�R�{ �X�����j���[�֑̐ؑΉ� END
		}

		private void pic�O�S_Click(object sender, System.EventArgs e)
		{
// ADD 2006.11.24 ���s�j���� ��Q����ׁ̈A���s�ł��Ȃ����� START
//			if(gs�X���R�[�h.Trim().Length == 0) return;
// ADD 2006.11.24 ���s�j���� ��Q����ׁ̈A���s�ł��Ȃ����� END
// MOD 2006.10.04 ���s�j�R�{ �X�����j���[�֑̐ؑΉ� START
			if(gs�X���R�[�h.Trim().Length == 0)
			{
				if(g�o�׏� == null) g�o�׏� = new �o�׏�();
				g�o�׏�.Left = this.Left + (this.Width  - g�o�׏�.Width)  / 2;
				g�o�׏�.Top  = this.Top  + (this.Height - g�o�׏�.Height) / 2;
				g�o�׏�.ShowDialog(this);
			}
			else
			{
// MOD 2007.01.18 ���s�j���� ��ʖ��̕ύX START
//// ADD 2006.12.12 ���s�j���� ��ʒǉ� START
//				if(g���X�d�� == null) g���X�d�� = new ���X�d��();
//				g���X�d��.Left = this.Left + (this.Width  - g���X�d��.Width)  / 2;
//				g���X�d��.Top  = this.Top  + (this.Height - g���X�d��.Height) / 2;
//				g���X�d��.ShowDialog();
//// ADD 2006.12.12 ���s�j���� ��ʒǉ� END
// MOD 2007.02.19 FJCS�j�K�c ���j���[���̕ύX START
//				if(g���X�d�� == null) g���X�d�� = new ���X�d��();
//				g���X�d��.Left = this.Left + (this.Width  - g���X�d��.Width)  / 2;
//				g���X�d��.Top  = this.Top  + (this.Height - g���X�d��.Height) / 2;
//				g���X�d��.ShowDialog();
				if(g�o�׏� == null) g�o�׏� = new �o�׏�();
				g�o�׏�.Left = this.Left + (this.Width  - g�o�׏�.Width)  / 2;
				g�o�׏�.Top  = this.Top  + (this.Height - g�o�׏�.Height) / 2;
				g�o�׏�.ShowDialog(this);
// MOD 2007.02.19 FJCS�j�K�c ���j���[���̕ύX END
// MOD 2007.01.18 ���s�j���� ��ʖ��̕ύX END
			}
// MOD 2006.10.04 ���s�j�R�{ �X�����j���[�֑̐ؑΉ� END
		}
// ADD 2006.07.11 ���s�j���� ��ʕύX END

// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� START
		private void pic�P�O_Click(object sender, System.EventArgs e)
		{
//�ۗ�// MOD 2010.06.29 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//�ۗ�			if(gs�X���R�[�h.Trim().Length > 0){
//�ۗ�				// ���m�点�o�^�Q�t�H�[���\��
//�ۗ�				if (g���m�o�Q == null) g���m�o�Q = new ���m�点�o�^�Q();
//�ۗ�				g���m�o�Q.Left = this.Left;
//�ۗ�				g���m�o�Q.Top  = this.Top;
//�ۗ�				this.Visible = false;
//�ۗ�				g���m�o�Q.ShowDialog(this);
//�ۗ�				this.Visible = true;
//�ۗ�				return;
//�ۗ�			}
//�ۗ�// MOD 2010.06.29 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
			// ���m�点�o�^�t�H�[���\��
			if (g���m�o�^ == null) g���m�o�^ = new ���m�点�o�^();
			g���m�o�^.Left = this.Left;
			g���m�o�^.Top  = this.Top;
			this.Visible = false;
			g���m�o�^.ShowDialog(this);
			this.Visible = true;
		}
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� END

// ADD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX START
		private void btn�ؑ�_Click(object sender, System.EventArgs e)
		{
// MOD 2009.08.07 ���s�j���� �ؑփ{�^���̐����Q�Ή� START
			// �Ǘ��҉���̏ꍇ
			if(gs�Ǘ��ҋ敪 != "1") return;
// MOD 2009.08.07 ���s�j���� �ؑփ{�^���̐����Q�Ή� END

			if(gs�X���R�[�h.Trim().Length == 0)
			{
				// �X�����͉�ʂ�\��
				if(g�X������ == null) g�X������ = new �X������();
				g�X������.ShowDialog();
			}
			else
			{
				gs�X���R�[�h = "";
			}
			//�{�^���\���̕ύX
			���j���[�{�^���ݒ�();
		}

		private void ���j���[�{�^���ݒ�()
		{
// ADD 2007.09.25 ���s�j���� ���΂炬�Ⓦ�n��ڊǑΉ� START
			btn���X��.Visible = false;
			btn���X��.Text    = "";
			gs�X���R�[�h = gs�X���R�[�h.Trim();
// ADD 2007.09.25 ���s�j���� ���΂炬�Ⓦ�n��ڊǑΉ� END
//�ۗ� ADD 2008.01.06 ���s�j���� ���j���[�O�Q�g���Ή� START
//			if(gs�X���R�[�h.Trim().Length == 0 && btn���j���[�O�Q.Text == "���j���[�O�Q")
//			{
//				imageCmd_a[1] = img�p�X�Ɖ�a;
//				imageCmd_b[1] = img�p�X�Ɖ�b;
//				pic�O�P.Image = imageCmd_a[1];
//
//				pic�O�U.Visible = false;
//				pic�O�V.Visible = false;
//				pic�O�W.Visible = false;
//				pic�O�X.Visible = false;
//				pic�P�O.Visible = false;
//
//				btn�ؑ�.Text = "�c�Ə�\n���j���[";
//				btn���j���[�O�Q.Text = "���j���[�O�P";
//				btn���j���[�O�Q.Visible = true;
//			}
//			else
//�ۗ� ADD 2008.01.06 ���s�j���� ���j���[�O�Q�g���Ή� END
			if(gs�X���R�[�h.Trim().Length == 0)
			{
				imageCmd_a[1] = img�g�p���Fa;
				imageCmd_b[1] = img�g�p���Fb;
				imageCmd_a[2] = img���q�l��a;
				imageCmd_b[2] = img���q�l��b;
				imageCmd_a[3] = img�ғ�����a;
				imageCmd_b[3] = img�ғ�����b;
				imageCmd_a[4] = img�o�׏�a;
				imageCmd_b[4] = img�o�׏�b;
				imageCmd_a[5] = img���b�Z�Wa;
				imageCmd_b[5] = img���b�Z�Wb;

				imageCmd_a[6] = img�g�p�o�^a;
				imageCmd_b[6] = img�g�p�o�^b;
				imageCmd_a[7] = img������oa;
				imageCmd_b[7] = img������ob;
				imageCmd_a[8] = img�W��X�oa;
				imageCmd_b[8] = img�W��X�ob;
				imageCmd_a[9] = img�A�����ia;
				imageCmd_b[9] = img�A�����ib;

// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� START
				imageCmd_a[10] = img���m�点a;
				imageCmd_b[10] = img���m�点b;
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� END

				pic�O�P.Image = imageCmd_a[1];
				pic�O�Q.Image = imageCmd_a[2];
				pic�O�R.Image = imageCmd_a[3];
				pic�O�S.Image = imageCmd_a[4];
				pic�O�T.Image = imageCmd_a[5];
				pic�O�U.Image = imageCmd_a[6];
				pic�O�V.Image = imageCmd_a[7];
				pic�O�W.Image = imageCmd_a[8];
				pic�O�X.Image = imageCmd_a[9];
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� START
				pic�P�O.Image = imageCmd_a[10];
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� END

// DEL 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� START
//				pic�O�T.Visible = true;
// DEL 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� END
				pic�O�U.Visible = true;
				pic�O�V.Visible = true;
				pic�O�W.Visible = true;
				pic�O�X.Visible = true;
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� START
				pic�P�O.Visible = true;
// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� END

				btn�ؑ�.Text = "�c�Ə�\n���j���[";
//�ۗ� ADD 2008.01.06 ���s�j���� ���j���[�O�Q�g���Ή� START
//				btn���j���[�O�Q.Text = "���j���[�O�Q";
//				btn���j���[�O�Q.Visible = true;
//�ۗ� ADD 2008.01.06 ���s�j���� ���j���[�O�Q�g���Ή� END
// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� START
				btn�ғ����o�^.Visible = true;
// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� END
// ADD 2010.06.05 KCL) �X�{ BLUEDI�Ǘ���ʌďo�@�\�̒ǉ� START
				btnBLUEDI�Ǘ�.Visible = true;
// ADD 2010.06.05 KCL) �X�{ BLUEDI�Ǘ���ʌďo�@�\�̒ǉ� START
			}
			else
			{
				imageCmd_a[1] = img�g�p�\��a;
				imageCmd_b[1] = img�g�p�\��b;
				imageCmd_a[2] = img������oa;
				imageCmd_b[2] = img������ob;
				imageCmd_a[3] = img�o�׏Ɖ�a;
				imageCmd_b[3] = img�o�׏Ɖ�b;
// MOD 2007.02.19 FJCS�j�K�c ���j���[���ύX START
//				imageCmd_a[4] = img���X�d��a;
//				imageCmd_b[4] = img���X�d��b;
				imageCmd_a[4] = img�o�׏�a;
				imageCmd_b[4] = img�o�׏�b;
// ADD 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� START
//				imageCmd_a[5] = img�o�׏�a;
//				imageCmd_b[5] = img�o�׏�b;
// ADD 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� END
				imageCmd_a[5] = img���X�d��a;
				imageCmd_b[5] = img���X�d��b;
// MOD 2007.02.19 FJCS�j�K�c ���j���[���ύX END
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� START
				imageCmd_a[6] = img���m�\��a;
				imageCmd_b[6] = img���m�\��b;
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� END
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� START
				imageCmd_a[7] = img�}�j���Aa;
				imageCmd_b[7] = img�}�j���Ab;
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� END
				pic�O�P.Image = imageCmd_a[1];
				pic�O�Q.Image = imageCmd_a[2];
				pic�O�R.Image = imageCmd_a[3];
				pic�O�S.Image = imageCmd_a[4];
// ADD 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� START
				pic�O�T.Image = imageCmd_a[5];
// ADD 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� END
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� START
				pic�O�U.Image = imageCmd_a[6];
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� END
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� START
				pic�O�V.Image = imageCmd_a[7];
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� END
//�ۗ�// MOD 2010.06.29 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//�ۗ�				pic�P�O.Image = imageCmd_a[10];
//�ۗ�// MOD 2010.06.29 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END

// DEL 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� START
//				pic�O�T.Visible = false;
// DEL 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� END
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� START
//// ADD 2009.04.23 KCL) �X�{ �g�p�\�����ݓo�^���\���� START
//				pic�O�U.Visible = false;
//// ADD 2009.04.23 KCL) �X�{ �g�p�\�����ݓo�^���\���� END
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� END
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� START
//				pic�O�V.Visible = false;
// MOD 2009.12.01 PSN�j���� �}�j���A���_�E�����[�h�@�\�̒ǉ� END
				pic�O�W.Visible = false;
				pic�O�X.Visible = false;
//�ۗ�// MOD 2010.06.29 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//�ۗ�//// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� START
				pic�P�O.Visible = false;
//�ۗ�//// ADD 2007.12.04 KCL) �X�{ ���m�点�ǉ� END
//�ۗ�				pic�P�O.Visible = true;
//�ۗ�// MOD 2010.06.29 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END

				btn�ؑ�.Text = "�Ǘ�\n���j���[";
// ADD 2007.09.25 ���s�j���� ���΂炬�Ⓦ�n��ڊǑΉ� START
				if(gs�X���R�[�h == "255")
				{
					btn���X��.Text    = "���X��\n�R�[�h\n(260)";
					btn���X��.Visible = true;
				}
				else if(gs�X���R�[�h == "260")
				{
					btn���X��.Text    = "�V�X��\n�R�[�h\n(255)";
					btn���X��.Visible = true;
// MOD 2010.09.30 ���s�j���� ��ʕ��R�ʉ^�Ή� START
				}else if(gs�X���R�[�h == "263"){ // ����
					btn���X��.Text    = "��ʕ���\n����\n(353)";
					btn���X��.Visible = true;
				}else if(gs�X���R�[�h == "353"){ // ��ʕ��R�ʉ^�F����
					btn���X��.Text    = "����\n(263)";
					btn���X��.Visible = true;
				}else if(gs�X���R�[�h == "264"){ // �[�J
					btn���X��.Text    = "��ʕ���\n�[�J\n(347)";
					btn���X��.Visible = true;
				}else if(gs�X���R�[�h == "347"){ // ��ʕ��R�ʉ^�F�[�J
					btn���X��.Text    = "�[�J\n(264)";
					btn���X��.Visible = true;
				}else if(gs�X���R�[�h == "265"){ // ��z
					btn���X��.Text    = "��ʕ���\n��z\n(333)";
					btn���X��.Visible = true;
				}else if(gs�X���R�[�h == "333"){ // ��ʕ��R�ʉ^�F��z
					btn���X��.Text    = "��z\n(265)";
					btn���X��.Visible = true;
// MOD 2010.09.30 ���s�j���� ��ʕ��R�ʉ^�Ή� END
// MOD 2011.05.25 ���s�j���� ���x�X�Ή� START
				}else if(gs�X���R�[�h == "161"){ // �����
// MOD 2011.06.30 ���s�j���� ��䒆���x�X�Ή� START
//					btn���X��.Text    = "���k\n(162)";
					btn���X��.Text    = "��䒆��\n(162)";
// MOD 2011.06.30 ���s�j���� ��䒆���x�X�Ή� END
					btn���X��.Visible = true;
				}else if(gs�X���R�[�h == "162"){ // ��䒆��
// MOD 2011.06.30 ���s�j���� ��䒆���x�X�Ή� START
//					btn���X��.Text    = "���\n(161)";
					btn���X��.Text    = "�����\n(161)";
// MOD 2011.06.30 ���s�j���� ��䒆���x�X�Ή� END
					btn���X��.Visible = true;
// MOD 2011.05.25 ���s�j���� ���x�X�Ή� END
				}
// ADD 2007.09.25 ���s�j���� ���΂炬�Ⓦ�n��ڊǑΉ� END
//�ۗ� ADD 2008.01.06 ���s�j���� ���j���[�O�Q�g���Ή� START
//				btn���j���[�O�Q.Text = "";
//				btn���j���[�O�Q.Visible = false;
//�ۗ� ADD 2008.01.06 ���s�j���� ���j���[�O�Q�g���Ή� END
// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� START
				btn�ғ����o�^.Visible = false;
// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� END
// ADD 2010.06.05 KCL) �X�{ BLUEDI�Ǘ���ʌďo�@�\�̒ǉ� START
				btnBLUEDI�Ǘ�.Visible = false;
// ADD 2010.06.05 KCL) �X�{ BLUEDI�Ǘ���ʌďo�@�\�̒ǉ� START
			}
		}
// ADD 2007.01.31 ���s�j���� �Ǘ���-�c�Ə���ʐؑ֕ύX END

// ADD 2007.09.25 ���s�j���� ���΂炬�Ⓦ�n��ڊǑΉ� END
		private void btn���X��_Click(object sender, System.EventArgs e)
		{
			if(gs�X���R�[�h.Length == 0) return;

			if(gs�X���R�[�h == "255")
			{
				gs�X���R�[�h      = "260";
			}
			else if(gs�X���R�[�h == "260")
			{
				gs�X���R�[�h      = "255";
// ADD 2010.09.30 ���s�j���� ��ʕ��R�ʉ^�Ή� START
			}else if(gs�X���R�[�h == "263"){ // ����
				gs�X���R�[�h      = "353";
			}else if(gs�X���R�[�h == "353"){ // ��ʕ��R�ʉ^�F����
				gs�X���R�[�h      = "263";
			}else if(gs�X���R�[�h == "264"){ // �[�J
				gs�X���R�[�h      = "347";
			}else if(gs�X���R�[�h == "347"){ // ��ʕ��R�ʉ^�F�[�J
				gs�X���R�[�h      = "264";
			}else if(gs�X���R�[�h == "265"){ // ��z
				gs�X���R�[�h      = "333";
			}else if(gs�X���R�[�h == "333"){ // ��ʕ��R�ʉ^�F��z
				gs�X���R�[�h      = "265";
// ADD 2010.09.30 ���s�j���� ��ʕ��R�ʉ^�Ή� END
// MOD 2011.05.25 ���s�j���� ���x�X�Ή� START
			}else if(gs�X���R�[�h == "161"){ // �����
				gs�X���R�[�h      = "162";
			}else if(gs�X���R�[�h == "162"){ // ��䒆��
				gs�X���R�[�h      = "161";
// MOD 2011.05.25 ���s�j���� ���x�X�Ή� END
			}
			
			//�{�^���\���̕ύX
			���j���[�{�^���ݒ�();
		}
// ADD 2007.09.25 ���s�j���� ���΂炬�Ⓦ�n��ڊǑΉ� END

// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� START
		private void btn�ғ����o�^_Click(object sender, System.EventArgs e)
		{
			g�ғ����o.Left = this.Left;
			g�ғ����o.Top = this.Top;
			this.Visible = false;
			g�ғ����o.ShowDialog();
			this.Visible = true;
		}
// ADD 2009.04.07 ���s�j���� �ғ����̊Ǘ��@�\�̒ǉ� END
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� START
		private string [] ���m�点�ڍד��e�擾(string s�o�^��, string s�V�[�P���X�m��) 
		{
			string [] sResults = new string[3];

			// �����ݒ�
			string [] sKey = new string [2];
			sKey[0] = s�o�^��;
			sKey[1] = s�V�[�P���X�m��;

			// ���m�点���擾
			string [] sRet = null;
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				sRet = sv_oshirase.Sel_Oshirase(gsa���[�U, sKey);
			}
			catch (System.Net.WebException)
			{
				// �ʐM�G���[����
				sRet[0] = gs�ʐM�G���[;
			}
			catch (Exception ex)
			{
				// ���̑��̃G���[����
				sRet[0] = "�ʐM�G���[�F" + ex.Message;
			}

			// ���ʏ���
			switch (sRet[0].Trim()) 
			{
				case "����I��" :	// ����I���̏ꍇ

					// �ڍד��e�A�{�^�����A�A�h���X��Ԃ�
					sResults[0] = sRet[3].Replace("\n", "\r\n");		// �ڍד��e
					sResults[1] = sRet[4];								// �{�^����
					sResults[2] = sRet[5];								// �A�h���X

					break;

				default :			// �ُ�I���̏ꍇ

					// �󕶎����Ԃ�
					sResults[0] = sResults[1] = sResults[2] = string.Empty;
					// �x����
					�r�[�v��();
					// �G���[���b�Z�[�W�\��
					tex���b�Z�[�W.Text = sRet[0];

					break;
			}

			return sResults;
		}
		private void pic���m�点�P_Click(object sender, System.EventArgs e)
		{
			if (s���m�点�ꗗ.Length > 0) 
			{
				this.���m�点�ڍו\��(1);
			}
		}

		private void pic���m�点�Q_Click(object sender, System.EventArgs e)
		{
			if (s���m�点�ꗗ.Length > 1) 
			{
				this.���m�点�ڍו\��(2);
			}
		}

		private void pic���m�点�R_Click(object sender, System.EventArgs e)
		{
			if (s���m�点�ꗗ.Length > 2) 
			{
				this.���m�点�ڍו\��(3);
			}
		}

		private void pic���m�点�S_Click(object sender, System.EventArgs e)
		{
			if (s���m�点�ꗗ.Length > 3) 
			{
				this.���m�点�ڍו\��(4);
			}
		}

		private void pic���m�点�T_Click(object sender, System.EventArgs e)
		{
			if (s���m�点�ꗗ.Length > 4) 
			{
				this.���m�点�ڍו\��(5);
			}
		}

		private void ���m�点�ڍו\��(int no) 
		{
			int idx = no - 1;

			if (g���m�\�� == null) g���m�\�� = new ���m�点�\��();
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
			if((s���m�点�ꗗ[idx]).Length > 4 && s���m�点�ꗗ[idx][4].Equals("2")){
				g���m�\��.i���[�h	= 1;
			}else{
				g���m�\��.i���[�h	= 0;
			}
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
			g���m�\��.s�o�^��	= s���m�点�ꗗ[idx][0];
			g���m�\��.s�\��		= s���m�点�ꗗ[idx][1];
			string [] naiyo		= this.���m�点�ڍד��e�擾(s���m�点�ꗗ[idx][2], s���m�点�ꗗ[idx][3]);
			g���m�\��.s�ڍד��e	= naiyo[0];
			g���m�\��.s�{�^����  = naiyo[1];
			g���m�\��.s�A�h���X	= naiyo[2];
			g���m�\��.Top		= this.Top;
			g���m�\��.Left		= this.Left;
			this.Visible		= false;
			g���m�\��.ShowDialog(this);
			this.Visible		= true;
		}
		private void ���m�点�����ݒ�() 
		{
			// ���m�点�\��{�^����z��ɂ���
			btnList[0] = btn���m�点�P;
			btnList[1] = btn���m�点�Q;
			btnList[2] = btn���m�点�R;
			btnList[3] = btn���m�点�S;
			btnList[4] = btn���m�点�T;
		}
		private void ���m�点�̎擾�ƕ\��() 
		{
			// ���m�点�擾�����̐ݒ�
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			string [] sKey = new string [5];
			string [] sKey = new string [6];
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
			sKey[0] = string.Empty;		// �J�n�o�^��
			sKey[1] = string.Empty;		// �I���o�^��
			sKey[2] = string.Empty;		// �\��
			sKey[3] = string.Empty;		// �ڍד��e
			sKey[4] = "5";				// ��ʂm��
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
			sKey[5] = "���m�点�{�^��";	// �@�\
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END

			// ���m�点�ꗗ���擾
			string [] sRet = null;
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2oshirase.Service1();
				sRet = sv_oshirase.Get_OshiraseTopN(gsa���[�U, sKey);
			}
			catch (System.Net.WebException)
			{
				// �ʐM�G���[����
				sRet[0] = gs�ʐM�G���[;
			}
			catch (Exception ex)
			{
				// ���̑��̃G���[����
				sRet[0] = "�ʐM�G���[�F" + ex.Message;
			}

			// ���ʏ���
			try 
			{
				switch (sRet[0].Trim()) 
				{
					case "����I��" :		// ����I���̏ꍇ

						// ���m�点�擾
						s���m�点�ꗗ = new string [sRet.Length - 1][];
						for (int i=1; i<sRet.Length; i++) 
						{
							string [] s���� = sRet[i].Split('|');
							s���m�点�ꗗ[i-1] = new string [] {
															 s����[1],	// �o�^���i�\���p�j
															 s����[2],	// �\��
															 s����[3],	// �o�^���i�����W���j
															 s����[4]	// �V�[�P���X�m��
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
															 ,s����[5]	// �Ǘ��ҋ敪
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
														 };
						}

						break;

					default :				// �ُ�I���̏ꍇ

						throw new Exception(sRet[0]);
				}
			} 
			catch (Exception ex) 
			{
				// ���m�点�̎擾�Ɏ��s

				// �{�^�������ׂĔ�\����
				for (int i=0; i<5; i++) 
				{
					btnList[i].Visible = false;
				}
				// �x����
				�r�[�v��();
				// �G���[���b�Z�[�W�\��
				tex���b�Z�[�W.Text = "���m�点�̎擾�Ɏ��s���܂����B" + ex.Message;

				return;
			}

			// ���m�点�{�^����\��
			for (int i=0; i<5; i++) 
			{
				if (s���m�点�ꗗ.Length > i) 
				{
					// �\�����邨�m�点�L

					// �{�^����\��
					btnList[i].Visible = true;

					// �o�^���ƕ\���\��
					btnList[i].���t = s���m�点�ꗗ[i][0];
					btnList[i].�\�� = s���m�点�ꗗ[i][1];
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
					if(s���m�点�ꗗ[i][4].Equals("2")){
						btnList[i].���[�h = 1;
					}else{
						btnList[i].���[�h = 0;
					}
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C START
					//���m�点�\��̐擪�Ɂu�y�d�v�z�v���t���Ƃ��́A�{�^���̐F��ς���
					if(s���m�点�ꗗ[i][1].StartsWith("�y�d�v�z"))
					{
						btnList[i].���[�h = 2;
					}
// MOD 2016.01.22 BEVAS) ���{ ���m�点�{�^���̐F�ؑւ����C END
				} 
				else 
				{
					// �\�����邨�m�点��

					// �{�^����\�����Ȃ�
					btnList[i].Visible = false;
				}
			}
		}
// MOD 2009.06.08 ���s�j���� ���m�点�\���@�\�̒ǉ� END

// ADD 2010.06.05 KCL) �X�{ BLUEDI�Ǘ���ʌďo�@�\�̒ǉ� START
		private void btnBLUEDI�Ǘ�_Click(object sender, System.EventArgs e)
		{
			string path = Path.Combine(System.Environment.CurrentDirectory, "BLUEDIAdminClient.exe");
			System.Diagnostics.Process.Start(path, "v@NmA?:fvQ(7#r*g");
		}
// ADD 2010.06.05 KCL) �X�{ BLUEDI�Ǘ���ʌďo�@�\�̒ǉ� END
	}
}
