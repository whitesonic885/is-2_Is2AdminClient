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
	/// [���m�点�o�^]
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
	public class ���m�点�o�^ : ���ʃt�H�[��
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.GroupBox groupBox3;
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
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�{�^����;
		private System.Windows.Forms.Label lab�{�^����;
		private System.Windows.Forms.Label lab�A�h���X;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�A�h���X;
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
		private System.Windows.Forms.ComboBox cmb����敪;
		private System.Windows.Forms.Label lab����敪;
		private decimal d�X�V����		= 0m;

		public ���m�点�o�^()
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmb����敪 = new System.Windows.Forms.ComboBox();
			this.lab����敪 = new System.Windows.Forms.Label();
			this.lab�A�h���X = new System.Windows.Forms.Label();
			this.tex�A�h���X = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�{�^���� = new System.Windows.Forms.Label();
			this.tex�{�^���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn���� = new System.Windows.Forms.Button();
			this.lab�ڍד��e = new System.Windows.Forms.Label();
			this.tex�\�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�\�� = new System.Windows.Forms.Label();
			this.lab�o�^�� = new System.Windows.Forms.Label();
			this.tex�o�^�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�ڍד��e = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.cmb����敪);
			this.panel1.Controls.Add(this.lab����敪);
			this.panel1.Controls.Add(this.lab�A�h���X);
			this.panel1.Controls.Add(this.tex�A�h���X);
			this.panel1.Controls.Add(this.lab�{�^����);
			this.panel1.Controls.Add(this.tex�{�^����);
			this.panel1.Controls.Add(this.btn����);
			this.panel1.Controls.Add(this.lab�ڍד��e);
			this.panel1.Controls.Add(this.tex�\��);
			this.panel1.Controls.Add(this.lab�\��);
			this.panel1.Controls.Add(this.lab�o�^��);
			this.panel1.Controls.Add(this.tex�o�^��);
			this.panel1.Controls.Add(this.tex�ڍד��e);
			this.panel1.Location = new System.Drawing.Point(2, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(770, 434);
			this.panel1.TabIndex = 1;
			// 
			// cmb����敪
			// 
			this.cmb����敪.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.cmb����敪.Items.AddRange(new object[] {
														 "��ʉ��",
														 "�c�Ə����"});
			this.cmb����敪.Location = new System.Drawing.Point(400, 10);
			this.cmb����敪.Name = "cmb����敪";
			this.cmb����敪.Size = new System.Drawing.Size(108, 24);
			this.cmb����敪.TabIndex = 85;
			// 
			// lab����敪
			// 
			this.lab����敪.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.lab����敪.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab����敪.Location = new System.Drawing.Point(318, 12);
			this.lab����敪.Name = "lab����敪";
			this.lab����敪.Size = new System.Drawing.Size(78, 18);
			this.lab����敪.TabIndex = 86;
			this.lab����敪.Text = "����敪";
			// 
			// lab�A�h���X
			// 
			this.lab�A�h���X.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�A�h���X.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�A�h���X.Location = new System.Drawing.Point(10, 408);
			this.lab�A�h���X.Name = "lab�A�h���X";
			this.lab�A�h���X.Size = new System.Drawing.Size(76, 18);
			this.lab�A�h���X.TabIndex = 84;
			this.lab�A�h���X.Text = "�A�h���X";
			// 
			// tex�A�h���X
			// 
			this.tex�A�h���X.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex�A�h���X.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�A�h���X.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.tex�A�h���X.Location = new System.Drawing.Point(86, 406);
			this.tex�A�h���X.MaxLength = 150;
			this.tex�A�h���X.Name = "tex�A�h���X";
			this.tex�A�h���X.Size = new System.Drawing.Size(670, 23);
			this.tex�A�h���X.TabIndex = 83;
			this.tex�A�h���X.Text = "������������������������������������������������������������";
			// 
			// lab�{�^����
			// 
			this.lab�{�^����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�{�^����.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�{�^����.Location = new System.Drawing.Point(10, 380);
			this.lab�{�^����.Name = "lab�{�^����";
			this.lab�{�^����.Size = new System.Drawing.Size(76, 18);
			this.lab�{�^����.TabIndex = 82;
			this.lab�{�^����.Text = "�{�^����";
			// 
			// tex�{�^����
			// 
			this.tex�{�^����.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex�{�^����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�{�^����.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�{�^����.Location = new System.Drawing.Point(86, 378);
			this.tex�{�^����.MaxLength = 10;
			this.tex�{�^����.Name = "tex�{�^����";
			this.tex�{�^����.Size = new System.Drawing.Size(168, 23);
			this.tex�{�^����.TabIndex = 81;
			this.tex�{�^����.Text = "��������������������";
			// 
			// btn����
			// 
			this.btn����.BackColor = System.Drawing.Color.Blue;
			this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn����.ForeColor = System.Drawing.Color.White;
			this.btn����.Location = new System.Drawing.Point(248, 10);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(46, 22);
			this.btn����.TabIndex = 80;
			this.btn����.TabStop = false;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// lab�ڍד��e
			// 
			this.lab�ڍד��e.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�ڍד��e.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�ڍד��e.Location = new System.Drawing.Point(10, 68);
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
			this.tex�\��.Location = new System.Drawing.Point(86, 38);
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
			this.lab�\��.Location = new System.Drawing.Point(10, 40);
			this.lab�\��.Name = "lab�\��";
			this.lab�\��.Size = new System.Drawing.Size(76, 18);
			this.lab�\��.TabIndex = 77;
			this.lab�\��.Text = "�\�@��";
			// 
			// lab�o�^��
			// 
			this.lab�o�^��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�o�^��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�o�^��.Location = new System.Drawing.Point(10, 12);
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
			this.tex�o�^��.Location = new System.Drawing.Point(86, 10);
			this.tex�o�^��.MaxLength = 10;
			this.tex�o�^��.Name = "tex�o�^��";
			this.tex�o�^��.Size = new System.Drawing.Size(150, 23);
			this.tex�o�^��.TabIndex = 0;
			this.tex�o�^��.Text = "123";
			// 
			// tex�ڍד��e
			// 
			this.tex�ڍד��e.BackColor = System.Drawing.SystemColors.Window;
			this.tex�ڍד��e.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ڍד��e.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�ڍד��e.Location = new System.Drawing.Point(86, 66);
			this.tex�ڍד��e.MaxLength = 2000;
			this.tex�ڍד��e.Multiline = true;
			this.tex�ڍד��e.Name = "tex�ڍד��e";
			this.tex�ڍד��e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tex�ڍד��e.Size = new System.Drawing.Size(664, 310);
			this.tex�ڍד��e.TabIndex = 3;
			this.tex�ڍד��e.Text = @"��������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������";
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.panel1);
			this.groupBox3.Location = new System.Drawing.Point(10, 62);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(774, 442);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// ���m�点�o�^
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 575);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "���m�点�o�^";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ���m�点�o�^";
			this.Load += new System.EventHandler(this.�o�׏�_Load);
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
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

			// �\���̏�����
			���ڃN���A();

			// �t�H�[�J�X�ݒ�
			tex�\��.Focus();
		}

		private void ���ڃN���A()
		{
			// �\���N���A
			tex�o�^��.Text		= DateTime.Now.ToString("yyyy/MM/dd");
			tex�\��.Text			= string.Empty;
			tex�ڍד��e.Text		= string.Empty;
			tex���b�Z�[�W.Text	= string.Empty;
			tex�{�^����.Text		= "�ڍ�";
			tex�A�h���X.Text		= string.Empty;
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
			cmb����敪.SelectedIndex = 0;
			cmb����敪.Text
				= (string)cmb����敪.Items[cmb����敪.SelectedIndex];
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END

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
			if (g���m���� == null) g���m���� = new ���m�点����();
			g���m����.Left = this.Left + 202;
			g���m����.Top  = this.Top;
			g���m����.���ڃN���A();
			g���m����.ShowDialog(this);

			// ���ʕ\��
			if (g���m����.s�\��.Trim().Length != 0)
			{
				// �������ʂ���
				tex�o�^��.Text	= YYYYMMDD�ϊ�(g���m����.s�o�^��).ToString("yyyy/MM/dd");
				tex�\��.Text		= g���m����.s�\��;
				tex�ڍד��e.Text	= g���m����.s�ڍד��e;
				tex�{�^����.Text	= g���m����.s�{�^����;
				tex�A�h���X.Text	= g���m����.s�A�h���X;
				s�D�揇			= g���m����.s�D�揇;
				s�o�^��			= g���m����.s�o�^��;
				s�V�[�P���X�m��	= g���m����.s�V�[�P���X�m��;
				d�X�V����		= g���m����.d�X�V����;
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
				if (g���m����.s����敪.Equals("2")){
					cmb����敪.SelectedIndex = 1;
				}else{
					cmb����敪.SelectedIndex = int.Parse(g���m����.s����敪);
				}
				cmb����敪.Text
						= (string)cmb����敪.Items[cmb����敪.SelectedIndex];
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
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
			// ���̓`�F�b�N
			if (!�K�{�`�F�b�N(tex�o�^��, "�o�^��")) return;
			if (!�K�{�`�F�b�N(tex�\��, "�\��")) return;
			if (!�K�{�`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;

// ADD 2008.05.07 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� START
			if (!�S�p���p���݃`�F�b�N(tex�\��, "�\��")) return;
			if (!�S�p���p���݃`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;
			if (!�S�p���p���݃`�F�b�N(tex�{�^����, "�{�^����")) return;
// ADD 2008.05.07 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� END

			// �^�`�F�b�N
			if (!���t�`�F�b�N(tex�o�^��, "�o�^��")) return;
			// �����`�F�b�N
			if (!�֑������`�F�b�N(tex�\��, "�\��")) return;
			if (!�֑������`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;
			// �o�C�g���`�F�b�N
			if (!�o�C�g���`�F�b�N(tex�\��, "�\��", 60)) return;
			if (!�o�C�g���`�F�b�N(tex�ڍד��e, "�ڍד��e", 2000)) return;
			if (!�o�C�g���`�F�b�N(tex�{�^����, "�{�^����", 20)) return;
			if (!�o�C�g���`�F�b�N(tex�A�h���X, "�A�h���X", 150)) return;
			// �t�q�k�`�F�b�N
			if ((tex�A�h���X.Text.Trim().Length > 0) && !�t�q�k�`�F�b�N(tex�A�h���X, "�A�h���X")) return;
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
			if(cmb����敪.SelectedIndex < 0){
				MessageBox.Show("����敪���Ⴂ�܂�","���̓`�F�b�N",MessageBoxButtons.OK);
				return;
			}
			cmb����敪.Text
				= (string)cmb����敪.Items[cmb����敪.SelectedIndex];
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END

			// �ŏI�m�F
			if (MessageBox.Show("���m�点��V�K�o�^���܂��B��낵���ł����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No)
				return;

			// �󔒏��� �� �o�^�f�[�^�ݒ�
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			string [] sKey  = new string [7];
			string [] sKey  = new string [8];
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
			sKey[0] = DateTime.Parse(tex�o�^��.Text.Trim()).ToString("yyyyMMdd");
			sKey[1] = tex�\��.Text.Trim();
			sKey[2] = tex�ڍד��e.Text.Trim();
			sKey[3] = tex�{�^����.Text.Trim();
			if (sKey[3].Length == 0) sKey[3] = " ";
			sKey[4] = tex�A�h���X.Text.Trim();
			if (sKey[4].Length == 0) sKey[4] = " ";
			sKey[5] = "1";
			sKey[6] = gs���p�҃R�[�h;
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
			if (cmb����敪.SelectedIndex == 1){
				sKey[7] = "2";
			}else{
				sKey[7] = cmb����敪.SelectedIndex.ToString();
			}
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END

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

			// ���̓`�F�b�N
			if (!�K�{�`�F�b�N(tex�o�^��, "�o�^��")) return;
			if (!�K�{�`�F�b�N(tex�\��, "�\��")) return;
			if (!�K�{�`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;

// ADD 2008.05.08 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� START
			if (!�S�p���p���݃`�F�b�N(tex�\��, "�\��")) return;
			if (!�S�p���p���݃`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;
			if (!�S�p���p���݃`�F�b�N(tex�{�^����, "�{�^����")) return;
// ADD 2008.05.08 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� END

			// �^�`�F�b�N
			if (!���t�`�F�b�N(tex�o�^��, "�o�^��")) return;
			// �����`�F�b�N
			if (!�֑������`�F�b�N(tex�\��, "�\��")) return;
			if (!�֑������`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;
			// �o�C�g���`�F�b�N
			if (!�o�C�g���`�F�b�N(tex�\��, "�\��", 60)) return;
			if (!�o�C�g���`�F�b�N(tex�ڍד��e, "�ڍד��e", 2000)) return;
			if (!�o�C�g���`�F�b�N(tex�{�^����, "�{�^����", 20)) return;
			if (!�o�C�g���`�F�b�N(tex�A�h���X, "�A�h���X", 150)) return;
			// �t�q�k�`�F�b�N
			if ((tex�A�h���X.Text.Trim().Length > 0) && !�t�q�k�`�F�b�N(tex�A�h���X, "�A�h���X")) return;
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
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
			if(cmb����敪.SelectedIndex < 0){
				MessageBox.Show("����敪���Ⴂ�܂�","���̓`�F�b�N",MessageBoxButtons.OK);
				return;
			}
			cmb����敪.Text
				= (string)cmb����敪.Items[cmb����敪.SelectedIndex];
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END

			// �ŏI�m�F
			if (MessageBox.Show("���m�点��ύX���܂��B��낵���ł����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No)
				return;

			// �󔒏��� �� �ύX�f�[�^�ݒ�
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			string [] sKey  = new string [10];
			string [] sKey  = new string [11];
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
			sKey[0] = DateTime.Parse(tex�o�^��.Text.Trim()).ToString("yyyyMMdd");
			sKey[1] = s�V�[�P���X�m��;
			sKey[2] = d�X�V����.ToString();
			sKey[3] = tex�\��.Text.Trim();
			sKey[4] = tex�ڍד��e.Text.Trim();
			sKey[5] = tex�{�^����.Text.Trim();
			if (sKey[5].Length == 0) sKey[5] = " ";
			sKey[6] = tex�A�h���X.Text.Trim();
			if (sKey[6].Length == 0) sKey[6] = " ";
			sKey[7] = "1";
			sKey[8] = gs���p�҃R�[�h;
			sKey[9] = s�o�^��;
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
			if (cmb����敪.SelectedIndex == 1){
				sKey[10] = "2";
			}else{
				sKey[10] = cmb����敪.SelectedIndex.ToString();
			}
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END

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
	}
}
// ADD 2007.12.05 KCL) �X�{ ���m�点�ǉ� END
