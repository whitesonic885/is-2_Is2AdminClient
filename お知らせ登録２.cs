// ADD 2007.12.05 KCL) �X�{ ���m�点�ǉ� START
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [���m�点�o�^�Q]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2008.02.07 KCL) �X�{ ���m�点�C�� 
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 ���s�j���� �\��A�ڍד��e�A�{�^���̑S�p���p���݃`�F�b�N�̒ǉ� 
	//--------------------------------------------------------------------------
	// ADD 2008.05.08 ���s�j���� �\��A�ڍד��e�A�{�^���̑S�p���p���݃`�F�b�N�̒ǉ�
	// [�ύX]�{�^���������̊����f�[�^�̕ύX���ǂ����̃`�F�b�N�̃^�C�~���O���ύX
	//--------------------------------------------------------------------------
	// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� 
	//--------------------------------------------------------------------------
	public class ���m�点�o�^�Q : ���ʃt�H�[��
	{
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label lab�ڍד��e;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\��;
		private System.Windows.Forms.Label lab�\��;
		private System.Windows.Forms.Label lab�o�^��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�o�^��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ڍד��e;
		private System.Windows.Forms.Label lab���m�点�o�^�^�C�g��;
		private System.Windows.Forms.Button btn�ύX;
		private System.Windows.Forms.Button btn�ۑ�;
		private System.Windows.Forms.Button btn�폜;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label lab����;
		private System.Windows.Forms.Label lab�F�؉����;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�F�ؗ��p�Җ�;
		private System.Windows.Forms.Label lab�F�ؗ��p�Җ�;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�F�؉����;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components = null;

		private string s�D�揇			= string.Empty;
		private string s�o�^��			= string.Empty;
		private string s�V�[�P���X�m��	= string.Empty;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�����;
		private System.Windows.Forms.Button btn�������;
		private System.Windows.Forms.Label lab����R�[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex����R�[�h;
		private System.Windows.Forms.Button btn������s;
		private System.Windows.Forms.Panel pnl���m�点;
		private System.Windows.Forms.Label lab���m�点�ē����b�Z�[�W;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex���m�点�ē����b�Z�[�W;
		private System.Windows.Forms.Label lab�\������;
		private System.Windows.Forms.GroupBox gp���m�点;
		private System.Windows.Forms.Label lab�\�����ԋL��;
		private System.Windows.Forms.DateTimePicker dt�\�����ԊJ�n;
		private System.Windows.Forms.DateTimePicker dt�\�����ԏI��;
		private System.Windows.Forms.Label lab���b�Z�[�W����;
		private decimal d�X�V����		= 0m;

		public ���m�点�o�^�Q()
		{
			//
			// Windows �t�H�[�� �f�U�C�i �T�|�[�g�ɕK�v�ł��B
			//
			InitializeComponent();
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
			this.components = new System.ComponentModel.Container();
			this.pnl���m�点 = new System.Windows.Forms.Panel();
			this.lab���b�Z�[�W���� = new System.Windows.Forms.Label();
			this.tex�ڍד��e = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�\�����ԋL�� = new System.Windows.Forms.Label();
			this.dt�\�����ԊJ�n = new System.Windows.Forms.DateTimePicker();
			this.dt�\�����ԏI�� = new System.Windows.Forms.DateTimePicker();
			this.lab�\������ = new System.Windows.Forms.Label();
			this.tex���m�点�ē����b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab���m�点�ē����b�Z�[�W = new System.Windows.Forms.Label();
			this.btn���� = new System.Windows.Forms.Button();
			this.lab�ڍד��e = new System.Windows.Forms.Label();
			this.tex�\�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�\�� = new System.Windows.Forms.Label();
			this.lab�o�^�� = new System.Windows.Forms.Label();
			this.tex�o�^�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex����� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn������� = new System.Windows.Forms.Button();
			this.lab����R�[�h = new System.Windows.Forms.Label();
			this.tex����R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn������s = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lab�F�؉���� = new System.Windows.Forms.Label();
			this.tex�F�ؗ��p�Җ� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�F�ؗ��p�Җ� = new System.Windows.Forms.Label();
			this.tex�F�؉���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab���� = new System.Windows.Forms.Label();
			this.lab���m�点�o�^�^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn�폜 = new System.Windows.Forms.Button();
			this.btn�ύX = new System.Windows.Forms.Button();
			this.btn�ۑ� = new System.Windows.Forms.Button();
			this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
			this.btn���� = new System.Windows.Forms.Button();
			this.gp���m�点 = new System.Windows.Forms.GroupBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pnl���m�点.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.gp���m�点.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl���m�点
			// 
			this.pnl���m�点.BackColor = System.Drawing.Color.Honeydew;
			this.pnl���m�点.Controls.Add(this.lab���b�Z�[�W����);
			this.pnl���m�点.Controls.Add(this.tex�ڍד��e);
			this.pnl���m�点.Controls.Add(this.lab�\�����ԋL��);
			this.pnl���m�点.Controls.Add(this.dt�\�����ԊJ�n);
			this.pnl���m�点.Controls.Add(this.dt�\�����ԏI��);
			this.pnl���m�点.Controls.Add(this.lab�\������);
			this.pnl���m�点.Controls.Add(this.tex���m�点�ē����b�Z�[�W);
			this.pnl���m�点.Controls.Add(this.lab���m�点�ē����b�Z�[�W);
			this.pnl���m�点.Controls.Add(this.btn����);
			this.pnl���m�点.Controls.Add(this.lab�ڍד��e);
			this.pnl���m�点.Controls.Add(this.tex�\��);
			this.pnl���m�点.Controls.Add(this.lab�\��);
			this.pnl���m�点.Controls.Add(this.lab�o�^��);
			this.pnl���m�点.Controls.Add(this.tex�o�^��);
			this.pnl���m�点.Controls.Add(this.tex�����);
			this.pnl���m�点.Controls.Add(this.btn�������);
			this.pnl���m�点.Controls.Add(this.lab����R�[�h);
			this.pnl���m�点.Controls.Add(this.tex����R�[�h);
			this.pnl���m�点.Controls.Add(this.btn������s);
			this.pnl���m�点.Location = new System.Drawing.Point(2, 6);
			this.pnl���m�点.Name = "pnl���m�点";
			this.pnl���m�点.Size = new System.Drawing.Size(776, 444);
			this.pnl���m�点.TabIndex = 1;
			// 
			// lab���b�Z�[�W����
			// 
			this.lab���b�Z�[�W����.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���b�Z�[�W����.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���b�Z�[�W����.Location = new System.Drawing.Point(102, 402);
			this.lab���b�Z�[�W����.Name = "lab���b�Z�[�W����";
			this.lab���b�Z�[�W����.Size = new System.Drawing.Size(540, 18);
			this.lab���b�Z�[�W����.TabIndex = 91;
			this.lab���b�Z�[�W����.Text = "��[���m�点�ē����b�Z�[�W]�́A�׎�p�A�v���̃��j���[�E���ɐݒ���ԓ��\������܂�";
			// 
			// tex�ڍד��e
			// 
			this.tex�ڍד��e.BackColor = System.Drawing.SystemColors.Window;
			this.tex�ڍד��e.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ڍד��e.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�ڍד��e.Location = new System.Drawing.Point(102, 102);
			this.tex�ڍד��e.MaxLength = 2000;
			this.tex�ڍד��e.Multiline = true;
			this.tex�ڍד��e.Name = "tex�ڍד��e";
			this.tex�ڍד��e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tex�ڍד��e.Size = new System.Drawing.Size(664, 220);
			this.tex�ڍד��e.TabIndex = 3;
			this.tex�ڍד��e.Text = @"��������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������";
			// 
			// lab�\�����ԋL��
			// 
			this.lab�\�����ԋL��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\�����ԋL��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�\�����ԋL��.Location = new System.Drawing.Point(324, 380);
			this.lab�\�����ԋL��.Name = "lab�\�����ԋL��";
			this.lab�\�����ԋL��.Size = new System.Drawing.Size(18, 16);
			this.lab�\�����ԋL��.TabIndex = 90;
			this.lab�\�����ԋL��.Text = "�`";
			this.lab�\�����ԋL��.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dt�\�����ԊJ�n
			// 
			this.dt�\�����ԊJ�n.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt�\�����ԊJ�n.Location = new System.Drawing.Point(178, 376);
			this.dt�\�����ԊJ�n.Name = "dt�\�����ԊJ�n";
			this.dt�\�����ԊJ�n.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt�\�����ԊJ�n.Size = new System.Drawing.Size(144, 23);
			this.dt�\�����ԊJ�n.TabIndex = 9;
			// 
			// dt�\�����ԏI��
			// 
			this.dt�\�����ԏI��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt�\�����ԏI��.Location = new System.Drawing.Point(344, 376);
			this.dt�\�����ԏI��.Name = "dt�\�����ԏI��";
			this.dt�\�����ԏI��.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt�\�����ԏI��.Size = new System.Drawing.Size(144, 23);
			this.dt�\�����ԏI��.TabIndex = 10;
			// 
			// lab�\������
			// 
			this.lab�\������.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\������.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�\������.Location = new System.Drawing.Point(100, 378);
			this.lab�\������.Name = "lab�\������";
			this.lab�\������.Size = new System.Drawing.Size(76, 18);
			this.lab�\������.TabIndex = 87;
			this.lab�\������.Text = "�\������";
			// 
			// tex���m�点�ē����b�Z�[�W
			// 
			this.tex���m�点�ē����b�Z�[�W.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex���m�点�ē����b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���m�点�ē����b�Z�[�W.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.tex���m�点�ē����b�Z�[�W.Location = new System.Drawing.Point(102, 350);
			this.tex���m�点�ē����b�Z�[�W.MaxLength = 100;
			this.tex���m�点�ē����b�Z�[�W.Name = "tex���m�点�ē����b�Z�[�W";
			this.tex���m�点�ē����b�Z�[�W.Size = new System.Drawing.Size(664, 23);
			this.tex���m�点�ē����b�Z�[�W.TabIndex = 8;
			this.tex���m�点�ē����b�Z�[�W.Text = "������������������������������������������������������������";
			// 
			// lab���m�点�ē����b�Z�[�W
			// 
			this.lab���m�点�ē����b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���m�点�ē����b�Z�[�W.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���m�点�ē����b�Z�[�W.Location = new System.Drawing.Point(4, 352);
			this.lab���m�点�ē����b�Z�[�W.Name = "lab���m�点�ē����b�Z�[�W";
			this.lab���m�点�ē����b�Z�[�W.Size = new System.Drawing.Size(98, 36);
			this.lab���m�点�ē����b�Z�[�W.TabIndex = 85;
			this.lab���m�点�ē����b�Z�[�W.Text = "���m�点�ē����b�Z�[�W";
			// 
			// btn����
			// 
			this.btn����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn����.ForeColor = System.Drawing.Color.White;
			this.btn����.Location = new System.Drawing.Point(236, 10);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(48, 22);
			this.btn����.TabIndex = 1;
			this.btn����.TabStop = false;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// lab�ڍד��e
			// 
			this.lab�ڍד��e.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�ڍד��e.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�ڍד��e.Location = new System.Drawing.Point(4, 104);
			this.lab�ڍד��e.Name = "lab�ڍד��e";
			this.lab�ڍד��e.Size = new System.Drawing.Size(76, 18);
			this.lab�ڍד��e.TabIndex = 79;
			this.lab�ڍד��e.Text = "�ڍד��e";
			// 
			// tex�\��
			// 
			this.tex�\��.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex�\��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\��.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�\��.Location = new System.Drawing.Point(102, 72);
			this.tex�\��.MaxLength = 60;
			this.tex�\��.Name = "tex�\��";
			this.tex�\��.Size = new System.Drawing.Size(518, 23);
			this.tex�\��.TabIndex = 2;
			this.tex�\��.Text = "������������������������������������������������������������";
			// 
			// lab�\��
			// 
			this.lab�\��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�\��.Location = new System.Drawing.Point(4, 74);
			this.lab�\��.Name = "lab�\��";
			this.lab�\��.Size = new System.Drawing.Size(76, 18);
			this.lab�\��.TabIndex = 77;
			this.lab�\��.Text = "�\�@��";
			// 
			// lab�o�^��
			// 
			this.lab�o�^��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�o�^��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�o�^��.Location = new System.Drawing.Point(4, 12);
			this.lab�o�^��.Name = "lab�o�^��";
			this.lab�o�^��.Size = new System.Drawing.Size(76, 18);
			this.lab�o�^��.TabIndex = 76;
			this.lab�o�^��.Text = "�o�^��";
			// 
			// tex�o�^��
			// 
			this.tex�o�^��.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex�o�^��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�o�^��.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�o�^��.Location = new System.Drawing.Point(102, 10);
			this.tex�o�^��.MaxLength = 10;
			this.tex�o�^��.Name = "tex�o�^��";
			this.tex�o�^��.Size = new System.Drawing.Size(130, 23);
			this.tex�o�^��.TabIndex = 0;
			this.tex�o�^��.Text = "123";
			// 
			// tex�����
			// 
			this.tex�����.BackColor = System.Drawing.Color.Honeydew;
			this.tex�����.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�����.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�����.Location = new System.Drawing.Point(342, 46);
			this.tex�����.MaxLength = 20;
			this.tex�����.Name = "tex�����";
			this.tex�����.ReadOnly = true;
			this.tex�����.Size = new System.Drawing.Size(324, 16);
			this.tex�����.TabIndex = 55;
			this.tex�����.TabStop = false;
			this.tex�����.Text = "";
			// 
			// btn�������
			// 
			this.btn�������.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�������.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�������.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�������.ForeColor = System.Drawing.Color.White;
			this.btn�������.Location = new System.Drawing.Point(236, 42);
			this.btn�������.Name = "btn�������";
			this.btn�������.Size = new System.Drawing.Size(48, 22);
			this.btn�������.TabIndex = 13;
			this.btn�������.TabStop = false;
			this.btn�������.Text = "����";
			this.btn�������.Click += new System.EventHandler(this.btn�������_Click);
			// 
			// lab����R�[�h
			// 
			this.lab����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.lab����R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab����R�[�h.Location = new System.Drawing.Point(4, 44);
			this.lab����R�[�h.Name = "lab����R�[�h";
			this.lab����R�[�h.Size = new System.Drawing.Size(88, 18);
			this.lab����R�[�h.TabIndex = 56;
			this.lab����R�[�h.Text = "���q�l����";
			// 
			// tex����R�[�h
			// 
			this.tex����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex����R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex����R�[�h.Location = new System.Drawing.Point(102, 42);
			this.tex����R�[�h.MaxLength = 10;
			this.tex����R�[�h.Name = "tex����R�[�h";
			this.tex����R�[�h.Size = new System.Drawing.Size(130, 23);
			this.tex����R�[�h.TabIndex = 0;
			this.tex����R�[�h.Text = "";
			this.tex����R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex����R�[�h_KeyDown);
			this.tex����R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex����R�[�h_KeyPress);
			// 
			// btn������s
			// 
			this.btn������s.BackColor = System.Drawing.Color.Blue;
			this.btn������s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn������s.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn������s.ForeColor = System.Drawing.Color.White;
			this.btn������s.Location = new System.Drawing.Point(288, 42);
			this.btn������s.Name = "btn������s";
			this.btn������s.Size = new System.Drawing.Size(48, 22);
			this.btn������s.TabIndex = 1;
			this.btn������s.Text = "���s";
			this.btn������s.Click += new System.EventHandler(this.btn������s_Click);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Controls.Add(this.lab�F�؉����);
			this.panel6.Controls.Add(this.tex�F�ؗ��p�Җ�);
			this.panel6.Controls.Add(this.lab�F�ؗ��p�Җ�);
			this.panel6.Controls.Add(this.tex�F�؉����);
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(810, 26);
			this.panel6.TabIndex = 12;
			// 
			// lab�F�؉����
			// 
			this.lab�F�؉����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�F�؉����.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�F�؉����.Location = new System.Drawing.Point(16, 8);
			this.lab�F�؉����.Name = "lab�F�؉����";
			this.lab�F�؉����.Size = new System.Drawing.Size(54, 14);
			this.lab�F�؉����.TabIndex = 7;
			this.lab�F�؉����.Text = "���q�l��";
			// 
			// tex�F�ؗ��p�Җ�
			// 
			this.tex�F�ؗ��p�Җ�.BackColor = System.Drawing.Color.PaleGreen;
			this.tex�F�ؗ��p�Җ�.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�F�ؗ��p�Җ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�F�ؗ��p�Җ�.ForeColor = System.Drawing.Color.Green;
			this.tex�F�ؗ��p�Җ�.Location = new System.Drawing.Point(472, 5);
			this.tex�F�ؗ��p�Җ�.Name = "tex�F�ؗ��p�Җ�";
			this.tex�F�ؗ��p�Җ�.ReadOnly = true;
			this.tex�F�ؗ��p�Җ�.Size = new System.Drawing.Size(322, 16);
			this.tex�F�ؗ��p�Җ�.TabIndex = 6;
			this.tex�F�ؗ��p�Җ�.TabStop = false;
			this.tex�F�ؗ��p�Җ�.Text = "����������������������������������������";
			this.tex�F�ؗ��p�Җ�.Visible = false;
			// 
			// lab�F�ؗ��p�Җ�
			// 
			this.lab�F�ؗ��p�Җ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�F�ؗ��p�Җ�.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�F�ؗ��p�Җ�.Location = new System.Drawing.Point(420, 7);
			this.lab�F�ؗ��p�Җ�.Name = "lab�F�ؗ��p�Җ�";
			this.lab�F�ؗ��p�Җ�.Size = new System.Drawing.Size(54, 14);
			this.lab�F�ؗ��p�Җ�.TabIndex = 5;
			this.lab�F�ؗ��p�Җ�.Text = "���[�U�[";
			this.lab�F�ؗ��p�Җ�.Visible = false;
			// 
			// tex�F�؉����
			// 
			this.tex�F�؉����.BackColor = System.Drawing.Color.PaleGreen;
			this.tex�F�؉����.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�F�؉����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�F�؉����.ForeColor = System.Drawing.Color.Green;
			this.tex�F�؉����.Location = new System.Drawing.Point(74, 5);
			this.tex�F�؉����.Name = "tex�F�؉����";
			this.tex�F�؉����.ReadOnly = true;
			this.tex�F�؉����.Size = new System.Drawing.Size(330, 16);
			this.tex�F�؉����.TabIndex = 4;
			this.tex�F�؉����.TabStop = false;
			this.tex�F�؉����.Text = "999 �����x�X";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab����);
			this.panel7.Controls.Add(this.lab���m�点�o�^�^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(798, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab����
			// 
			this.lab����.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab����.ForeColor = System.Drawing.Color.White;
			this.lab����.Location = new System.Drawing.Point(674, 8);
			this.lab����.Name = "lab����";
			this.lab����.Size = new System.Drawing.Size(112, 14);
			this.lab����.TabIndex = 2;
			this.lab����.Text = "2005/xx/xx 12:00:00";
			// 
			// lab���m�点�o�^�^�C�g��
			// 
			this.lab���m�点�o�^�^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab���m�点�o�^�^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���m�点�o�^�^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab���m�点�o�^�^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab���m�点�o�^�^�C�g��.Name = "lab���m�点�o�^�^�C�g��";
			this.lab���m�点�o�^�^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab���m�点�o�^�^�C�g��.TabIndex = 0;
			this.lab���m�点�o�^�^�C�g��.Text = "���m�点�o�^";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btn�폜);
			this.panel8.Controls.Add(this.btn�ύX);
			this.panel8.Controls.Add(this.btn�ۑ�);
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 2;
			// 
			// btn�폜
			// 
			this.btn�폜.ForeColor = System.Drawing.Color.Blue;
			this.btn�폜.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn�폜.Location = new System.Drawing.Point(198, 6);
			this.btn�폜.Name = "btn�폜";
			this.btn�폜.Size = new System.Drawing.Size(54, 48);
			this.btn�폜.TabIndex = 3;
			this.btn�폜.Text = "�폜";
			this.btn�폜.Click += new System.EventHandler(this.btn�폜_Click);
			// 
			// btn�ύX
			// 
			this.btn�ύX.ForeColor = System.Drawing.Color.Blue;
			this.btn�ύX.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn�ύX.Location = new System.Drawing.Point(134, 6);
			this.btn�ύX.Name = "btn�ύX";
			this.btn�ύX.Size = new System.Drawing.Size(54, 48);
			this.btn�ύX.TabIndex = 2;
			this.btn�ύX.Text = "�ύX";
			this.btn�ύX.Click += new System.EventHandler(this.btn�ύX_Click);
			// 
			// btn�ۑ�
			// 
			this.btn�ۑ�.ForeColor = System.Drawing.Color.Blue;
			this.btn�ۑ�.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn�ۑ�.Location = new System.Drawing.Point(70, 6);
			this.btn�ۑ�.Name = "btn�ۑ�";
			this.btn�ۑ�.Size = new System.Drawing.Size(54, 48);
			this.btn�ۑ�.TabIndex = 1;
			this.btn�ۑ�.Text = "�ۑ�";
			this.btn�ۑ�.Click += new System.EventHandler(this.btn�ۑ�_Click);
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(260, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(530, 50);
			this.tex���b�Z�[�W.TabIndex = 1;
			this.tex���b�Z�[�W.TabStop = false;
			this.tex���b�Z�[�W.Text = "";
			// 
			// btn����
			// 
			this.btn����.ForeColor = System.Drawing.Color.Red;
			this.btn����.Location = new System.Drawing.Point(8, 6);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(54, 48);
			this.btn����.TabIndex = 0;
			this.btn����.TabStop = false;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// gp���m�点
			// 
			this.gp���m�点.Controls.Add(this.pnl���m�点);
			this.gp���m�点.Location = new System.Drawing.Point(8, 58);
			this.gp���m�点.Name = "gp���m�点";
			this.gp���m�点.Size = new System.Drawing.Size(780, 452);
			this.gp���m�点.TabIndex = 1;
			this.gp���m�点.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// ���m�点�o�^�Q
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 574);
			this.Controls.Add(this.gp���m�点);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "���m�点�o�^�Q";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ���m�点�o�^";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ��Q);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z���Q);
			this.Load += new System.EventHandler(this.�o�׏�_Load);
			this.pnl���m�点.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.gp���m�点.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void �o�׏�_Load(object sender, System.EventArgs e)
		{
// ADD 2008.02.07 KCL) �X�{ ���m�点�C�� START
			// �^�C�g���\��
			tex�F�؉����.Text = gs�����;
			tex�F�ؗ��p�Җ�.Text = gs���p�Җ�;

			// �����̏����ݒ�
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;
// ADD 2008.02.07 KCL) �X�{ ���m�点�C�� END

//�ۗ� MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//�ۗ�			// ���僊�X�g�̏����ݒ�
//�ۗ�			axGT����.Cols = 4;
//�ۗ�			axGT����.Rows = 4;
//�ۗ�			axGT����.ColSep = "|";
//�ۗ�			axGT����.CaretRow = 1;
//�ۗ�			axGT����.NoBeep = true;
//�ۗ�
//�ۗ�			axGT����.set_RowsText(0, "|�R�[�h|�Z�N�V������|�o�͏�|�X�֔ԍ�|");
//�ۗ�			axGT����.ColsWidth = "0|7|20|0|0|";
//�ۗ�			axGT����.ColsAlignHorz = "1|1|0|2|1|";
//�ۗ�            
//�ۗ�			axGT����.set_CelForeColor(axGT����.CaretRow,0,0x98FB98);  //BGR
//�ۗ�			axGT����.set_CelBackColor(axGT����.CaretRow,0,0x006000);
//�ۗ�
//�ۗ�			axGT����.Clear();
//�ۗ�			axGT����.CaretCol = 1;
//�ۗ�			axGT����_CurPlaceChanged(null,null);
//�ۗ� MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
			// �\���̏�����
			���ڃN���A();

			// �t�H�[�J�X�ݒ�
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			tex�\��.Focus();
			tex����R�[�h.Focus();
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
		}

		private void ���ڃN���A()
		{
			// �\���N���A
			tex�o�^��.Text		= DateTime.Now.ToString("yyyy/MM/dd");
			tex�\��.Text			= string.Empty;
			tex�ڍד��e.Text		= string.Empty;
			tex���b�Z�[�W.Text	= string.Empty;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			tex�{�^����.Text		= "�ڍ�";
//			tex�A�h���X.Text		= string.Empty;
//// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			cmb����敪.SelectedIndex = 0;
//			cmb����敪.Text
//				= (string)cmb����敪.Items[cmb����敪.SelectedIndex];
//// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
			tex����R�[�h.Text = string.Empty;
			tex�����.Text	   = string.Empty;
//			tex���m�点�ē����b�Z�[�W.Text = string.Empty;
			tex���m�点�ē����b�Z�[�W.Text = "���d�v�Ȃ��ē����@���m�点���Q�Ƃ��ĉ�����";
			dt�\�����ԊJ�n.Value = DateTime.Now;
			dt�\�����ԏI��.Value = DateTime.Now.AddDays(6);
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END

			// �����f�[�^�N���A
			s�D�揇			= string.Empty;
			s�o�^��			= string.Empty;
			s�V�[�P���X�m��	= string.Empty;
			d�X�V����		= 0m;
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			// ���̃t�H�[�������
			this.Close();
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			// �����t�H�[���\��
			if (g���m���Q == null) g���m���Q = new ���m�点�����Q();
			g���m���Q.Left = this.Left + 202;
			g���m���Q.Top  = this.Top;
			g���m���Q.���ڃN���A();
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
			tex����R�[�h.Text = tex����R�[�h.Text.TrimEnd();
			if (!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
			g���m���Q.s����b�c = tex����R�[�h.Text;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
			g���m���Q.ShowDialog(this);

			// ���ʕ\��
			if (g���m���Q.s�\��.Trim().Length != 0)
			{
				// �������ʂ���
				tex�o�^��.Text	= YYYYMMDD�ϊ�(g���m���Q.s�o�^��).ToString("yyyy/MM/dd");
				tex�\��.Text		= g���m���Q.s�\��;
				tex�ڍד��e.Text	= g���m���Q.s�ڍד��e;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//				tex�{�^����.Text	= g���m���Q.s�{�^����;
//				tex�A�h���X.Text	= g���m���Q.s�A�h���X;
				tex����R�[�h.Text	= g���m���Q.s����b�c;
				tex�����.Text	    = g���m���Q.s�����;
				dt�\�����ԊJ�n.Value = YYYYMMDD�ϊ�(g���m���Q.s�\�����ԊJ�n);
				dt�\�����ԏI��.Value = YYYYMMDD�ϊ�(g���m���Q.s�\�����ԏI��);
				tex���m�点�ē����b�Z�[�W.Text 
									 = g���m���Q.s���b�Z�[�W;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
				s�D�揇			= g���m���Q.s�D�揇;
				s�o�^��			= g���m���Q.s�o�^��;
				s�V�[�P���X�m��	= g���m���Q.s�V�[�P���X�m��;
				d�X�V����		= g���m���Q.d�X�V����;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//				if (g���m����.s����敪.Equals("2")){
//					cmb����敪.SelectedIndex = 1;
//				}else{
//					cmb����敪.SelectedIndex = int.Parse(g���m����.s����敪);
//				}
//				cmb����敪.Text
//						= (string)cmb����敪.Items[cmb����敪.SelectedIndex];
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
				tex�o�^��.Focus();
			}
			else
			{
				// �������ʂȂ�
				tex�\��.Focus();
			}

			// ���b�Z�[�W�N���A
			tex���b�Z�[�W.Text = string.Empty;
		}

		private void btn�ۑ�_Click(object sender, System.EventArgs e)
		{
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
			// Trim
			tex�o�^��.Text = tex�o�^��.Text.TrimEnd();
			tex����R�[�h.Text = tex����R�[�h.Text.TrimEnd();
			tex�\��.Text = tex�\��.Text.TrimEnd();
			tex�ڍד��e.Text = tex�ڍד��e.Text.TrimEnd();
			tex���m�点�ē����b�Z�[�W.Text = tex���m�点�ē����b�Z�[�W.Text.TrimEnd();

//			if (!�K�{�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
			if(tex����R�[�h.Text.Trim().Length == 0){
				if(MessageBox.Show(
						"���q�l�R�[�h���ݒ肳��Ă��܂���B\n"
						+ "�Ǌ��̉׎�S�Ăɂ��m�点���\������܂��B\n"
						+ "��낵���ł����H"
						, "���̓`�F�b�N"
						, MessageBoxButtons.YesNo) == DialogResult.No){
					tex����R�[�h.Focus();
					return;
				}
			}
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
			// ���̓`�F�b�N
			if (!�K�{�`�F�b�N(tex�o�^��, "�o�^��")) return;
			if (!�K�{�`�F�b�N(tex�\��, "�\��")) return;
			if (!�K�{�`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;

// ADD 2008.05.07 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� START
			if (!�S�p���p���݃`�F�b�N(tex�\��, "�\��")) return;
			if (!�S�p���p���݃`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			if (!�S�p���p���݃`�F�b�N(tex�{�^����, "�{�^����")) return;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
// ADD 2008.05.07 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� END

			// �^�`�F�b�N
			if (!���t�`�F�b�N(tex�o�^��, "�o�^��")) return;
			// �����`�F�b�N
			if (!�֑������`�F�b�N(tex�\��, "�\��")) return;
			if (!�֑������`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;
			// �o�C�g���`�F�b�N
			if (!�o�C�g���`�F�b�N(tex�\��, "�\��", 60)) return;
			if (!�o�C�g���`�F�b�N(tex�ڍד��e, "�ڍד��e", 2000)) return;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			if (!�o�C�g���`�F�b�N(tex�{�^����, "�{�^����", 20)) return;
//			if (!�o�C�g���`�F�b�N(tex�A�h���X, "�A�h���X", 150)) return;
//			// �t�q�k�`�F�b�N
//			if ((tex�A�h���X.Text.Trim().Length > 0) && !�t�q�k�`�F�b�N(tex�A�h���X, "�A�h���X")) return;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			if(cmb����敪.SelectedIndex < 0){
//				MessageBox.Show("����敪���Ⴂ�܂�","���̓`�F�b�N",MessageBoxButtons.OK);
//				return;
//			}
//			cmb����敪.Text
//				= (string)cmb����敪.Items[cmb����敪.SelectedIndex];
			//�\�����ԃ`�F�b�N
			string s�\�����ԊJ�n = dt�\�����ԊJ�n.Value.ToString("yyyyMMdd");
			string s�\�����ԏI�� = dt�\�����ԏI��.Value.ToString("yyyyMMdd");
			if(s�\�����ԊJ�n.CompareTo(s�\�����ԏI��) > 0){
				MessageBox.Show("�\�����ԏI�����Ɍ�肪����܂��B"
								,"���̓`�F�b�N"
								,MessageBoxButtons.OK);
				dt�\�����ԏI��.Focus();
				return;
			}
			string s�\�����ԏI����� = dt�\�����ԊJ�n.Value.AddDays(6).ToString("yyyyMMdd");
			if(s�\�����ԏI��.CompareTo(s�\�����ԏI�����) > 0){
				MessageBox.Show("�\�����Ԃ́A�J�n�����Œ��V���Ԃł��B"
								,"���̓`�F�b�N"
								,MessageBoxButtons.OK);
				dt�\�����ԏI��.Focus();
				return;
			}
			if (!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
			if (!�֑������`�F�b�N(tex���m�点�ē����b�Z�[�W, "���m�点�ē����b�Z�[�W")) return;
			if (!�o�C�g���`�F�b�N(tex���m�点�ē����b�Z�[�W, "���m�点�ē����b�Z�[�W", 200)) return;
			// ����}�X�^���݃`�F�b�N
			if(!���������()){
				MessageBox.Show("���q�l(" + tex����R�[�h.Text + ")�����݂��܂���"
								,"���̓`�F�b�N"
								,MessageBoxButtons.OK);
				tex����R�[�h.Focus();
				return;
			}
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END

			// �ŏI�m�F
			if (MessageBox.Show("���m�点��V�K�o�^���܂��B��낵���ł����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No)
				return;

			// �󔒏��� �� �o�^�f�[�^�ݒ�
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			string [] sKey  = new string [7];
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			string [] sKey  = new string [8];
			string [] sKey  = new string [13];
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
			sKey[0] = DateTime.Parse(tex�o�^��.Text.Trim()).ToString("yyyyMMdd");
			sKey[1] = tex�\��.Text.Trim();
			sKey[2] = tex�ڍד��e.Text.Trim();
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			sKey[3] = tex�{�^����.Text.Trim();
//			if (sKey[3].Length == 0) sKey[3] = " ";
//			sKey[4] = tex�A�h���X.Text.Trim();
//			if (sKey[4].Length == 0) sKey[4] = " ";
			sKey[3] = " ";
			sKey[4] = " ";
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
			sKey[5] = "1";
			sKey[6] = gs���p�҃R�[�h;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			if (cmb����敪.SelectedIndex == 1){
//				sKey[7] = "2";
//			}else{
//				sKey[7] = cmb����敪.SelectedIndex.ToString();
//			}
			sKey[7] = "0";	// ��ʉ׎�
			sKey[8] = gs�X���R�[�h.Trim();
			if(sKey[8].Length == 0) sKey[8] = " ";
			sKey[9] = tex����R�[�h.Text;
			if(sKey[9].Length == 0) sKey[9] = " ";
			sKey[10] = tex���m�点�ē����b�Z�[�W.Text;
			if(sKey[10].Length == 0) sKey[10] = " ";
			sKey[11] = dt�\�����ԊJ�n.Value.ToString("yyyyMMdd");
			sKey[12] = dt�\�����ԏI��.Value.ToString("yyyyMMdd");
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END

			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			// ���m�点�̓o�^
			tex���b�Z�[�W.Text = "�ۑ����D�D�D";
			string [] sRet = new string [1];
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				sRet = sv_oshirase.Ins_Oshirase(gsa���[�U, sKey);
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
			
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			// ���ʏ���
			switch (sRet[0].Trim()) 
			{
				case "����I��" :
					this.���ڃN���A();
					tex���b�Z�[�W.Text = "���m�点��o�^���܂����B";
					tex�o�^��.Focus();

					break;

				default :
					tex���b�Z�[�W.Text = sRet[0];
					�r�[�v��();
					tex�o�^��.Focus();

					break;
			}
		}

		private void btn�ύX_Click(object sender, System.EventArgs e)
		{
// ADD 2008.05.08 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� START
			// �����f�[�^�̕ύX���ǂ����`�F�b�N
			if (s�V�[�P���X�m�� == string.Empty) 
			{
				// �V�K���̓f�[�^�̏ꍇ
				�r�[�v��();
				string msg = "���m�点��ύX����ɂ́A[����]�������ĕύX�O�̃f�[�^���w�肵�ĉ������B";
				MessageBox.Show(msg, "���̓`�F�b�N", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
// ADD 2008.05.08 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� END

// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
			// Trim
			tex�o�^��.Text = tex�o�^��.Text.TrimEnd();
			tex����R�[�h.Text = tex����R�[�h.Text.TrimEnd();
			tex�\��.Text = tex�\��.Text.TrimEnd();
			tex�ڍד��e.Text = tex�ڍד��e.Text.TrimEnd();
			tex���m�点�ē����b�Z�[�W.Text = tex���m�点�ē����b�Z�[�W.Text.TrimEnd();

//			if (!�K�{�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
			if(tex����R�[�h.Text.Trim().Length == 0){
				if(MessageBox.Show(
						"���q�l�R�[�h���ݒ肳��Ă��܂���B\n"
						+ "�Ǌ��̉׎�S�Ăɂ��m�点���\������܂��B\n"
						+ "��낵���ł����H"
						, "���̓`�F�b�N"
						, MessageBoxButtons.YesNo) == DialogResult.No){
					tex����R�[�h.Focus();
					return;
				}
			}
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
			// ���̓`�F�b�N
			if (!�K�{�`�F�b�N(tex�o�^��, "�o�^��")) return;
			if (!�K�{�`�F�b�N(tex�\��, "�\��")) return;
			if (!�K�{�`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;

// ADD 2008.05.08 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� START
			if (!�S�p���p���݃`�F�b�N(tex�\��, "�\��")) return;
			if (!�S�p���p���݃`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			if (!�S�p���p���݃`�F�b�N(tex�{�^����, "�{�^����")) return;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
// ADD 2008.05.08 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� END

			// �^�`�F�b�N
			if (!���t�`�F�b�N(tex�o�^��, "�o�^��")) return;
			// �����`�F�b�N
			if (!�֑������`�F�b�N(tex�\��, "�\��")) return;
			if (!�֑������`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;
			// �o�C�g���`�F�b�N
			if (!�o�C�g���`�F�b�N(tex�\��, "�\��", 60)) return;
			if (!�o�C�g���`�F�b�N(tex�ڍד��e, "�ڍד��e", 2000)) return;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			if (!�o�C�g���`�F�b�N(tex�{�^����, "�{�^����", 20)) return;
//			if (!�o�C�g���`�F�b�N(tex�A�h���X, "�A�h���X", 150)) return;
//			// �t�q�k�`�F�b�N
//			if ((tex�A�h���X.Text.Trim().Length > 0) && !�t�q�k�`�F�b�N(tex�A�h���X, "�A�h���X")) return;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
			//�\�����ԃ`�F�b�N
			string s�\�����ԊJ�n = dt�\�����ԊJ�n.Value.ToString("yyyyMMdd");
			string s�\�����ԏI�� = dt�\�����ԏI��.Value.ToString("yyyyMMdd");
			if(s�\�����ԊJ�n.CompareTo(s�\�����ԏI��) > 0){
				MessageBox.Show("�\�����ԏI�����Ɍ�肪����܂��B"
								,"���̓`�F�b�N"
								,MessageBoxButtons.OK);
				dt�\�����ԏI��.Focus();
				return;
			}
			string s�\�����ԏI����� = dt�\�����ԊJ�n.Value.AddDays(6).ToString("yyyyMMdd");
			if(s�\�����ԏI��.CompareTo(s�\�����ԏI�����) > 0){
				MessageBox.Show("�\�����Ԃ́A�J�n�����Œ��V���Ԃł��B"
								,"���̓`�F�b�N"
								,MessageBoxButtons.OK);
				dt�\�����ԏI��.Focus();
				return;
			}
			if (!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
			if (!�֑������`�F�b�N(tex���m�点�ē����b�Z�[�W, "���m�点�ē����b�Z�[�W")) return;
			if (!�o�C�g���`�F�b�N(tex���m�点�ē����b�Z�[�W, "���m�点�ē����b�Z�[�W", 200)) return;
			// ����}�X�^���݃`�F�b�N
			if(!���������()){
				MessageBox.Show("���q�l(" + tex����R�[�h.Text + ")�����݂��܂���"
								,"���̓`�F�b�N"
								,MessageBoxButtons.OK);
				tex����R�[�h.Focus();
				return;
			}
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
// DEL 2008.05.08 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� START
//			// �����f�[�^�̕ύX���ǂ����`�F�b�N
//			if (s�V�[�P���X�m�� == string.Empty) 
//			{
//				// �V�K���̓f�[�^�̏ꍇ
//				�r�[�v��();
//				string msg = "���m�点��ύX����ɂ́A[����]�������ĕύX�O�̃f�[�^���w�肵�ĉ������B";
//				MessageBox.Show(msg, "���̓`�F�b�N", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
//				return;
//			}
// DEL 2008.05.08 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� END
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			if(cmb����敪.SelectedIndex < 0){
//				MessageBox.Show("����敪���Ⴂ�܂�","���̓`�F�b�N",MessageBoxButtons.OK);
//				return;
//			}
//			cmb����敪.Text
//				= (string)cmb����敪.Items[cmb����敪.SelectedIndex];
//// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END

			// �ŏI�m�F
			if (MessageBox.Show("���m�点��ύX���܂��B��낵���ł����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No)
				return;

			// �󔒏��� �� �ύX�f�[�^�ݒ�
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			string [] sKey  = new string [10];
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			string [] sKey  = new string [11];
			string [] sKey  = new string [16];
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
			sKey[0] = DateTime.Parse(tex�o�^��.Text.Trim()).ToString("yyyyMMdd");
			sKey[1] = s�V�[�P���X�m��;
			sKey[2] = d�X�V����.ToString();
			sKey[3] = tex�\��.Text.Trim();
			sKey[4] = tex�ڍד��e.Text.Trim();
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//			sKey[5] = tex�{�^����.Text.Trim();
//			if (sKey[5].Length == 0) sKey[5] = " ";
//			sKey[6] = tex�A�h���X.Text.Trim();
//			if (sKey[6].Length == 0) sKey[6] = " ";
			sKey[5] = " ";
			sKey[6] = " ";
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
			sKey[7] = "1";
			sKey[8] = gs���p�҃R�[�h;
			sKey[9] = s�o�^��;
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
//// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			if (cmb����敪.SelectedIndex == 1){
//				sKey[10] = "2";
//			}else{
//				sKey[10] = cmb����敪.SelectedIndex.ToString();
//			}
//// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
			sKey[10] = "0";	// ��ʉ׎�
			sKey[11] = gs�X���R�[�h.Trim();
			if(sKey[11].Length == 0) sKey[11] = " ";
			sKey[12] = tex����R�[�h.Text;
			if(sKey[12].Length == 0) sKey[12] = " ";
			sKey[13] = tex���m�点�ē����b�Z�[�W.Text;
			if(sKey[13].Length == 0) sKey[13] = " ";
			sKey[14] = dt�\�����ԊJ�n.Value.ToString("yyyyMMdd");
			sKey[15] = dt�\�����ԏI��.Value.ToString("yyyyMMdd");
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			// ���m�点�̕ύX
			tex���b�Z�[�W.Text = "�ύX���D�D�D";
			string [] sRet = new string [1];
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				sRet = sv_oshirase.Upd_Oshirase(gsa���[�U, sKey);
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
			
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			// ���ʏ���
			switch (sRet[0].Trim()) 
			{
				case "����I��" :
					this.���ڃN���A();
					tex���b�Z�[�W.Text = "���m�点��ύX���܂����B";
					tex�o�^��.Focus();

					break;

				default :
					tex���b�Z�[�W.Text = sRet[0];
					�r�[�v��();
					tex�o�^��.Focus();

					break;
			}
		}

		private void btn�폜_Click(object sender, System.EventArgs e)
		{
			// ���̓`�F�b�N
			// �����f�[�^�̕ύX���ǂ����`�F�b�N
			if (s�V�[�P���X�m�� == string.Empty) 
			{
				// �V�K���̓f�[�^�̏ꍇ
				�r�[�v��();
				string msg = "���m�点���폜����ɂ́A[����]�������č폜����f�[�^���w�肵�ĉ������B";
				MessageBox.Show(msg, "���̓`�F�b�N", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			// �ŏI�m�F
			if (MessageBox.Show("���̂��m�点��{���ɍ폜���Ă���낵���ł����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No) 
				return;

			// �폜�f�[�^�ݒ�
			string [] sKey  = new string [4];
			sKey[0] = s�o�^��;
			sKey[1] = s�V�[�P���X�m��;
			sKey[2] = d�X�V����.ToString();
			sKey[3] = gs���p�҃R�[�h;

			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			// ���m�点�̍폜
			tex���b�Z�[�W.Text = "�폜���D�D�D";
			string [] sRet = new string [1];
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				sRet = sv_oshirase.Del_Oshirase(gsa���[�U, sKey);
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
			
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			// ���ʏ���
			switch (sRet[0].Trim()) 
			{
				case "����I��" :
					this.���ڃN���A();
					tex���b�Z�[�W.Text = "���m�点���폜���܂����B";
					tex�o�^��.Focus();

					break;

				default :
					tex���b�Z�[�W.Text = sRet[0];
					�r�[�v��();
					tex�o�^��.Focus();

					break;
			}
		}

// ADD 2008.02.07 KCL) �X�{ ���m�点�C�� START
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			// �����̏����ݒ�
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
		}
// ADD 2008.02.07 KCL) �X�{ ���m�点�C�� END
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� START
		private void btn�������_Click(object sender, System.EventArgs e)
		{
//			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
//			if(!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;

			// ������ʂ��E���ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			if (g������� == null)	 g������� = new �������();
			g�������.Left = this.Left + 404;
			g�������.Top = this.Top;
			// �R�[�h�̏����\��
			g�������.s����R�[�h = "";
			g�������.s����� = "";
			g�������.s�X���R�[�h = gs�X���R�[�h.Trim();
			g�������.ShowDialog();
			g�������.s�X���R�[�h = "";
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g�������.s����R�[�h.Trim().Length > 0){
				tex����R�[�h.Text = g�������.s����R�[�h;
				tex�����.Text     = g�������.s�����;
				btn������s.Focus();
				btn������s_Click(sender, e);
			}else{
				tex����R�[�h.Focus();
			}
		}

		private void btn������s_Click(object sender, System.EventArgs e)
		{
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
			if(tex����R�[�h.Text.Length == 0) return;
//			if(!�K�{�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
			if(!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
			//����`�F�b�N
			if(���������()){
//�ۗ�				�����񌟍�(tex����R�[�h.Text);
				tex�\��.Focus();
			}else{
				MessageBox.Show("���q�l(" + tex����R�[�h.Text + ")�����݂��܂���"
								,"���̓`�F�b�N"
								,MessageBoxButtons.OK);
				tex����R�[�h.Focus();
				return;
			}
		}
		private bool ���������()
		{
			tex�����.Text = "";
			if(tex����R�[�h.Text.Length == 0) return true;
			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool bRet = false;
			try{
				string[] sKey = new string[2];
				String[] sList;
				sKey[0] = tex����R�[�h.Text;
				sKey[1] = gs�X���R�[�h.Trim();
				if(gs�X���R�[�h.Trim().Length != 0){
					sList = sv_maintenance.Sel_MemberTn(gsa���[�U, sKey);
				}else{
					sList = sv_maintenance.Sel_Member(gsa���[�U, sKey);
				}
				if(sList[0].Length == 4){
					tex���b�Z�[�W.Text = "";
					tex�����.Text = sList[2];
//					s����X�V���� = sList[6];
//					if(sList.Length < 8){
//						cb�o�׎��шꗗ�^����\��.Enabled = false;
//						btn����X�V.Enabled = false;
//					}else{
//						if(sList[7].Equals("1")){
//							cb�o�׎��шꗗ�^����\��.Checked = true;
//						}else{
//							cb�o�׎��шꗗ�^����\��.Checked = false;
//						}
//						btn����X�V.Enabled = true;
//					}
					bRet = true;
				}else{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					tex�����.Text = "";
					tex����R�[�h.Focus();
				}
			}catch (Exception ex){
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
//				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return bRet;
		}
//�ۗ�		private void �����񌟍�(string s����R�[�h)
//�ۗ�		{
//�ۗ�			axGT����.Clear();
//�ۗ�			axGT����.Rows = 4;
//�ۗ�			axGT����.CaretRow = 1;
//�ۗ�			axGT����.CaretCol = 1;
//�ۗ�			axGT����_CurPlaceChanged(null,null);
//�ۗ�			
//�ۗ�			try{
//�ۗ�				string[] sKey  = new string[3];
//�ۗ�				sKey[0] = s����R�[�h;
//�ۗ�				sKey[1] = "";
//�ۗ�				sKey[2] = "";
//�ۗ�				string[] sList = sv_maintenance.Get_Section(gsa���[�U, sKey);
//�ۗ�
//�ۗ�				if (sList[0].Equals("����I��") || sList[0].Equals("�Y���f�[�^������܂���"))
//�ۗ�				{
//�ۗ�					tex���b�Z�[�W.Text = "";
//�ۗ�					if (axGT����.Rows < sList.Length - 1)
//�ۗ�					{
//�ۗ�						axGT����.Rows = (short)(sList.Length - 1);
//�ۗ�					}
//�ۗ�					for(short sCnt = 1; sCnt < sList.Length; sCnt++)
//�ۗ�					{
//�ۗ�						axGT����.set_RowsText(sCnt, sList[sCnt]);
//�ۗ�					}
//�ۗ�					tex�\��.Focus();
//�ۗ�				}
//�ۗ�				else
//�ۗ�				{
//�ۗ�					tex���b�Z�[�W.Text = sList[0];
//�ۗ�					throw new Exception(sList[0]);
//�ۗ�				}
//�ۗ�			}
//�ۗ�			catch (Exception ex)
//�ۗ�			{
//�ۗ�				throw new Exception(ex.Message);
//�ۗ�			}
//�ۗ�		}
//�ۗ�		private short nOldRowB = 0;
//�ۗ�		private void axGT����_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
//�ۗ�		{
//�ۗ�			axGT����.set_CelForeColor(nOldRowB,0,0);
//�ۗ�			axGT����.set_CelBackColor(nOldRowB,0,0xFFFFFF);
//�ۗ�//			axGT����.set_CelForeColor(axGT����.CaretRow,0,111111);
//�ۗ�			axGT����.set_CelForeColor(axGT����.CaretRow,0,0x98FB98);  //BGR
//�ۗ�			axGT����.set_CelBackColor(axGT����.CaretRow,0,0x006000);
//�ۗ�			nOldRowB = axGT����.CaretRow;
//�ۗ�		}

		private void tex����R�[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
				tex���b�Z�[�W.Text = "";
				btn������s_Click(sender, null);
			}
		}

		private void tex����R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar.ToString().Equals("*")){
				btn�������.Focus();
				btn�������_Click(sender, null);
				e.Handled = true;
			}
		}

		private void �G���^�[�ړ��Q(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(this.ActiveControl.Equals(tex�ڍד��e)) return;
			base.�G���^�[�ړ�(sender, e);
		}

		private void �G���^�[�L�����Z���Q(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(this.ActiveControl.Equals(tex�ڍד��e)) return;
			base.�G���^�[�L�����Z��(sender, e);
		}
// MOD 2010.07.01 ���s�j���� �c�Ə��p���m�点�o�^�@�\�̒ǉ� END
	}
}
// ADD 2007.12.05 KCL) �X�{ ���m�点�ǉ� END
