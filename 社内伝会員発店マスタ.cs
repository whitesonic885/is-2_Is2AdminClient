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
	public class �Г��`������X�}�X�^ : ���ʃt�H�[��
	{
		public short nOldRow = 0;
		private string[] s�Г��`����ꗗ;
		private string   s�X�V���� = "00000000000000";
		private int      i���ݕŐ�;
		private int      i�ő�Ő�;
		private int      i�J�n��;
		private int      i�I����;
		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lab�Ŕԍ�;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�O��;
		private ���ʃe�L�X�g�{�b�N�X tex�W��X�R�[�h;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label lab�W��X;
		private System.Windows.Forms.Button btn���;
		private System.Windows.Forms.Button btn�o�^;
		private System.Windows.Forms.Button btn�W��X����;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private ���ʃe�L�X�g�{�b�N�X tex�W��X��;
		private AxGTABLE32V2Lib.AxGTable32 axGT�Г��`���;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�������;
		public System.Windows.Forms.Label lab�Г��`������X�^�C�g��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�Г��`�����;
		private System.Windows.Forms.Label lab�������;
		private System.Windows.Forms.Label lab�Г��`����R�[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�Г��`����R�[�h;
		private System.Windows.Forms.Button btn�������;
		private System.Windows.Forms.Button btn�폜;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public �Г��`������X�}�X�^()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(�Г��`������X�}�X�^));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn�폜 = new System.Windows.Forms.Button();
			this.btn������� = new System.Windows.Forms.Button();
			this.tex�Г��`����� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�W��X�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn��� = new System.Windows.Forms.Button();
			this.btn�o�^ = new System.Windows.Forms.Button();
			this.btn�W��X���� = new System.Windows.Forms.Button();
			this.lab�Ŕԍ� = new System.Windows.Forms.Label();
			this.btn���� = new System.Windows.Forms.Button();
			this.btn�O�� = new System.Windows.Forms.Button();
			this.lab�Г��`����R�[�h = new System.Windows.Forms.Label();
			this.tex�Г��`����R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label1 = new System.Windows.Forms.Label();
			this.lab�W��X = new System.Windows.Forms.Label();
			this.tex�W��X�R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.axGT�Г��`��� = new AxGTABLE32V2Lib.AxGTable32();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab�Г��`������X�^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn���� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.tex������� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab������� = new System.Windows.Forms.Label();
			this.btn���� = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axGT�Г��`���)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel5.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.btn�폜);
			this.panel1.Controls.Add(this.btn�������);
			this.panel1.Controls.Add(this.tex�Г��`�����);
			this.panel1.Controls.Add(this.tex�W��X��);
			this.panel1.Controls.Add(this.btn���);
			this.panel1.Controls.Add(this.btn�o�^);
			this.panel1.Controls.Add(this.btn�W��X����);
			this.panel1.Controls.Add(this.lab�Ŕԍ�);
			this.panel1.Controls.Add(this.btn����);
			this.panel1.Controls.Add(this.btn�O��);
			this.panel1.Controls.Add(this.lab�Г��`����R�[�h);
			this.panel1.Controls.Add(this.tex�Г��`����R�[�h);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lab�W��X);
			this.panel1.Controls.Add(this.tex�W��X�R�[�h);
			this.panel1.Controls.Add(this.axGT�Г��`���);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(374, 408);
			this.panel1.TabIndex = 1;
			// 
			// btn�폜
			// 
			this.btn�폜.BackColor = System.Drawing.Color.Blue;
			this.btn�폜.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�폜.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�폜.ForeColor = System.Drawing.Color.White;
			this.btn�폜.Location = new System.Drawing.Point(264, 378);
			this.btn�폜.Name = "btn�폜";
			this.btn�폜.Size = new System.Drawing.Size(48, 22);
			this.btn�폜.TabIndex = 77;
			this.btn�폜.Text = "�폜";
			this.btn�폜.Click += new System.EventHandler(this.btn�폜_Click);
			// 
			// btn�������
			// 
			this.btn�������.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�������.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�������.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�������.ForeColor = System.Drawing.Color.White;
			this.btn�������.Location = new System.Drawing.Point(290, 286);
			this.btn�������.Name = "btn�������";
			this.btn�������.Size = new System.Drawing.Size(48, 22);
			this.btn�������.TabIndex = 76;
			this.btn�������.TabStop = false;
			this.btn�������.Text = "����";
			this.btn�������.Click += new System.EventHandler(this.btn�������_Click);
			// 
			// tex�Г��`�����
			// 
			this.tex�Г��`�����.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex�Г��`�����.BackColor = System.Drawing.Color.Honeydew;
			this.tex�Г��`�����.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�Г��`�����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�Г��`�����.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�Г��`�����.Location = new System.Drawing.Point(112, 318);
			this.tex�Г��`�����.MaxLength = 4;
			this.tex�Г��`�����.Name = "tex�Г��`�����";
			this.tex�Г��`�����.Size = new System.Drawing.Size(230, 16);
			this.tex�Г��`�����.TabIndex = 75;
			this.tex�Г��`�����.Text = "";
			// 
			// tex�W��X��
			// 
			this.tex�W��X��.BackColor = System.Drawing.Color.Honeydew;
			this.tex�W��X��.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�W��X��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�W��X��.Location = new System.Drawing.Point(210, 350);
			this.tex�W��X��.Name = "tex�W��X��";
			this.tex�W��X��.ReadOnly = true;
			this.tex�W��X��.Size = new System.Drawing.Size(74, 16);
			this.tex�W��X��.TabIndex = 74;
			this.tex�W��X��.TabStop = false;
			this.tex�W��X��.Text = "";
			// 
			// btn���
			// 
			this.btn���.BackColor = System.Drawing.Color.Blue;
			this.btn���.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn���.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn���.ForeColor = System.Drawing.Color.White;
			this.btn���.Location = new System.Drawing.Point(318, 378);
			this.btn���.Name = "btn���";
			this.btn���.Size = new System.Drawing.Size(48, 22);
			this.btn���.TabIndex = 6;
			this.btn���.Text = "���";
			this.btn���.Click += new System.EventHandler(this.btn���_Click);
			// 
			// btn�o�^
			// 
			this.btn�o�^.BackColor = System.Drawing.Color.Blue;
			this.btn�o�^.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�o�^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�o�^.ForeColor = System.Drawing.Color.White;
			this.btn�o�^.Location = new System.Drawing.Point(208, 378);
			this.btn�o�^.Name = "btn�o�^";
			this.btn�o�^.Size = new System.Drawing.Size(48, 22);
			this.btn�o�^.TabIndex = 4;
			this.btn�o�^.Text = "�o�^";
			this.btn�o�^.Click += new System.EventHandler(this.btn�o�^_Click);
			// 
			// btn�W��X����
			// 
			this.btn�W��X����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�W��X����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�W��X����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�W��X����.ForeColor = System.Drawing.Color.White;
			this.btn�W��X����.Location = new System.Drawing.Point(156, 346);
			this.btn�W��X����.Name = "btn�W��X����";
			this.btn�W��X����.Size = new System.Drawing.Size(48, 22);
			this.btn�W��X����.TabIndex = 66;
			this.btn�W��X����.TabStop = false;
			this.btn�W��X����.Text = "����";
			this.btn�W��X����.Click += new System.EventHandler(this.btn�W��X����_Click);
			// 
			// lab�Ŕԍ�
			// 
			this.lab�Ŕԍ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�Ŕԍ�.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�Ŕԍ�.Location = new System.Drawing.Point(260, 256);
			this.lab�Ŕԍ�.Name = "lab�Ŕԍ�";
			this.lab�Ŕԍ�.Size = new System.Drawing.Size(48, 14);
			this.lab�Ŕԍ�.TabIndex = 64;
			this.lab�Ŕԍ�.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn����
			// 
			this.btn����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn����.ForeColor = System.Drawing.Color.White;
			this.btn����.Location = new System.Drawing.Point(308, 252);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(48, 22);
			this.btn����.TabIndex = 63;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// btn�O��
			// 
			this.btn�O��.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�O��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�O��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�O��.ForeColor = System.Drawing.Color.White;
			this.btn�O��.Location = new System.Drawing.Point(212, 252);
			this.btn�O��.Name = "btn�O��";
			this.btn�O��.Size = new System.Drawing.Size(48, 22);
			this.btn�O��.TabIndex = 62;
			this.btn�O��.Text = "�O��";
			this.btn�O��.Click += new System.EventHandler(this.btn�O��_Click);
			// 
			// lab�Г��`����R�[�h
			// 
			this.lab�Г��`����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�Г��`����R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�Г��`����R�[�h.Location = new System.Drawing.Point(32, 292);
			this.lab�Г��`����R�[�h.Name = "lab�Г��`����R�[�h";
			this.lab�Г��`����R�[�h.Size = new System.Drawing.Size(74, 14);
			this.lab�Г��`����R�[�h.TabIndex = 61;
			this.lab�Г��`����R�[�h.Text = "���q�l�R�[�h";
			// 
			// tex�Г��`����R�[�h
			// 
			this.tex�Г��`����R�[�h.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex�Г��`����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�Г��`����R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�Г��`����R�[�h.Location = new System.Drawing.Point(110, 286);
			this.tex�Г��`����R�[�h.MaxLength = 10;
			this.tex�Г��`����R�[�h.Name = "tex�Г��`����R�[�h";
			this.tex�Г��`����R�[�h.Size = new System.Drawing.Size(172, 23);
			this.tex�Г��`����R�[�h.TabIndex = 1;
			this.tex�Г��`����R�[�h.Text = "";
			this.tex�Г��`����R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�Г��`����R�[�h_KeyDown);
			this.tex�Г��`����R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�Г��`����R�[�h_KeyPress);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(42, 352);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 14);
			this.label1.TabIndex = 57;
			this.label1.Text = "��";
			// 
			// lab�W��X
			// 
			this.lab�W��X.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�W��X.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�W��X.Location = new System.Drawing.Point(58, 352);
			this.lab�W��X.Name = "lab�W��X";
			this.lab�W��X.Size = new System.Drawing.Size(48, 14);
			this.lab�W��X.TabIndex = 56;
			this.lab�W��X.Text = "���X��";
			// 
			// tex�W��X�R�[�h
			// 
			this.tex�W��X�R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex�W��X�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�W��X�R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�W��X�R�[�h.Location = new System.Drawing.Point(110, 346);
			this.tex�W��X�R�[�h.MaxLength = 4;
			this.tex�W��X�R�[�h.Name = "tex�W��X�R�[�h";
			this.tex�W��X�R�[�h.Size = new System.Drawing.Size(42, 23);
			this.tex�W��X�R�[�h.TabIndex = 2;
			this.tex�W��X�R�[�h.Text = "";
			this.tex�W��X�R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�W��X�R�[�h_KeyDown);
			this.tex�W��X�R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�W��X�R�[�h_KeyPress);
			// 
			// axGT�Г��`���
			// 
			this.axGT�Г��`���.ContainingControl = this;
			this.axGT�Г��`���.DataSource = null;
			this.axGT�Г��`���.Location = new System.Drawing.Point(16, 10);
			this.axGT�Г��`���.Name = "axGT�Г��`���";
			this.axGT�Г��`���.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT�Г��`���.OcxState")));
			this.axGT�Г��`���.Size = new System.Drawing.Size(339, 235);
			this.axGT�Г��`���.TabIndex = 0;
			this.axGT�Г��`���.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT�Г��`���_KeyDownEvent);
			this.axGT�Г��`���.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT�Г��`���_CelDblClick);
			this.axGT�Г��`���.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT�Г��`���_CurPlaceChanged);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab�Г��`������X�^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab�Г��`������X�^�C�g��
			// 
			this.lab�Г��`������X�^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�Г��`������X�^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�Г��`������X�^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab�Г��`������X�^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab�Г��`������X�^�C�g��.Name = "lab�Г��`������X�^�C�g��";
			this.lab�Г��`������X�^�C�g��.Size = new System.Drawing.Size(336, 24);
			this.lab�Г��`������X�^�C�g��.TabIndex = 0;
			this.lab�Г��`������X�^�C�g��.Text = "�Г��`�[������X��񃁃��e�i���X";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(388, 58);
			this.panel8.TabIndex = 2;
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(70, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(312, 50);
			this.tex���b�Z�[�W.TabIndex = 0;
			this.tex���b�Z�[�W.TabStop = false;
			this.tex���b�Z�[�W.Text = "";
			// 
			// btn����
			// 
			this.btn����.ForeColor = System.Drawing.Color.Red;
			this.btn����.Location = new System.Drawing.Point(8, 6);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(54, 48);
			this.btn����.TabIndex = 6;
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
			this.panel6.Size = new System.Drawing.Size(396, 26);
			this.panel6.TabIndex = 15;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Honeydew;
			this.panel5.Controls.Add(this.tex�������);
			this.panel5.Controls.Add(this.lab�������);
			this.panel5.Controls.Add(this.btn����);
			this.panel5.Location = new System.Drawing.Point(1, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(362, 36);
			this.panel5.TabIndex = 0;
			// 
			// tex�������
			// 
			this.tex�������.BackColor = System.Drawing.SystemColors.Window;
			this.tex�������.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�������.Location = new System.Drawing.Point(110, 6);
			this.tex�������.MaxLength = 10;
			this.tex�������.Name = "tex�������";
			this.tex�������.Size = new System.Drawing.Size(160, 23);
			this.tex�������.TabIndex = 0;
			this.tex�������.Text = "";
			this.tex�������.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�������_KeyDown);
			// 
			// lab�������
			// 
			this.lab�������.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�������.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�������.Location = new System.Drawing.Point(8, 10);
			this.lab�������.Name = "lab�������";
			this.lab�������.Size = new System.Drawing.Size(94, 16);
			this.lab�������.TabIndex = 46;
			this.lab�������.Text = "���q�l�R�[�h";
			// 
			// btn����
			// 
			this.btn����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn����.ForeColor = System.Drawing.Color.White;
			this.btn����.Location = new System.Drawing.Point(292, 8);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(64, 22);
			this.btn����.TabIndex = 1;
			this.btn����.TabStop = false;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Location = new System.Drawing.Point(7, 54);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(365, 44);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(7, 98);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(377, 416);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// �Г��`������X�}�X�^
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(388, 582);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(394, 607);
			this.Name = "�Г��`������X�}�X�^";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 �Г��`�[������X��񃁃��e�i���X";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.�Г��`������X�}�X�^_Closed);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axGT�Г��`���)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>

		private void Form1_Load(object sender, System.EventArgs e)
		{
			axGT�Г��`���.Cols = 3;
			axGT�Г��`���.Rows = 12;
			axGT�Г��`���.ColSep = "|";
			axGT�Г��`���.NoBeep = true;

			axGT�Г��`���.set_RowsText(0, "|���q�l�R�[�h|���q�l��|���X��|�X�V���t");

			axGT�Г��`���.ColsWidth = "0|7|14|5|0";
			axGT�Г��`���.ColsAlignHorz = "1|1|0|1|0|";

			axGT�Г��`���.set_CelForeColor(axGT�Г��`���.CaretRow,0,0x98FB98);  //BGR
			axGT�Г��`���.set_CelBackColor(axGT�Г��`���.CaretRow,0,0x006000);

			axGT�Г��`���.CaretRow = 1;
			tex�������.Text = " ";
			�Г��`����ꗗ����();
			�Г��`������X�o�^���[�h();
			tex�������.Focus();
		}

		private void �Г��`������X�o�^���[�h()
		{
			tex�Г��`����R�[�h.Enabled = true;
			btn�������.Enabled = true;
			btn�o�^.Text = "�o�^";
			btn�폜.Enabled = false;

			tex�Г��`����R�[�h.Text = "";
			tex�Г��`�����.Text = "";
			tex�W��X�R�[�h.Text = "";
			tex�W��X��.Text = "";

			s�X�V���� = "00000000000000";
		}

		private void �Г��`������X�X�V���[�h()
		{
			tex�Г��`����R�[�h.Enabled = false;
			btn�������.Enabled = false;
			btn�o�^.Text = "�X�V";
			btn�폜.Enabled = true;
		}

		private void �Г��`����ꗗ����()
		{
			axGT�Г��`���.Clear();

			tex�������.Text = tex�������.Text.Trim();
			if(tex�������.Text.Length == 0)
			{
				tex�������.Text = " ";
			}
			if(!���p�`�F�b�N(tex�������, "���q�l�R�[�h")) return;

			i���ݕŐ� = 1;
			axGT�Г��`���.CaretRow = 1;
			axGT�Г��`���.set_CelForeColor(nOldRow,0,0);
			axGT�Г��`���.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGT�Г��`���.set_CelForeColor(axGT�Г��`���.CaretRow,0,0x98FB98);  //BGR
			axGT�Г��`���.set_CelBackColor(axGT�Г��`���.CaretRow,0,0x006000);
			nOldRow = axGT�Г��`���.CaretRow;
			
			s�Г��`����ꗗ = new string[1];
			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�������.Text;
				s�Г��`����ꗗ = sv_maintenance.Get_HouseSlipMember(gsa���[�U, sKey);
			}
			catch(Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(s�Г��`����ꗗ[0].Equals("����I��"))
			{
				tex���b�Z�[�W.Text = "";
				i�ő�Ő� = (s�Г��`����ꗗ.Length - 2) / (axGT�Г��`���.Rows - 1) + 1;
				if(i���ݕŐ� > i�ő�Ő�)
				{
					i���ݕŐ� = i�ő�Ő�;
				}
				�ŏ��ݒ�();
			}
			else
			{
				tex���b�Z�[�W.Text = s�Г��`����ꗗ[0];
				axGT�Г��`���.Clear();
				i���ݕŐ� = 1;
				btn�O��.Enabled = false;
				btn����.Enabled = false;
				lab�Ŕԍ�.Text = "";
				�r�[�v��();
			}
			tex�������.Text = tex�������.Text.Trim();
		}

		private void �Г��`�������()
		{
			if(axGT�Г��`���.get_CelText(axGT�Г��`���.CaretRow,1).Equals(""))
			{
				return;
			}

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			
			try
			{
				string[] sKey  = new string[1];
				sKey[0] = axGT�Г��`���.get_CelText(axGT�Г��`���.CaretRow,1).Trim();
				string[] sList = sv_maintenance.Sel_HouseSlipMember(gsa���[�U, sKey);

				if(sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex�Г��`����R�[�h.Text = sList[1].Trim();
					tex�Г��`�����.Text     = sList[2].Trim();
					tex�W��X�R�[�h.Text = sList[3].Trim();
					tex�W��X��.Text     = sList[4].Trim();					
		 		    s�X�V���� = sList[5].Trim();
					�Г��`������X�X�V���[�h();
					tex�W��X�R�[�h.Focus();
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					axGT�Г��`���.Focus();
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�Г��`������X�o�^���[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
		
		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void tex�������_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				�Г��`����ꗗ����();
				tex�W��X�R�[�h.Focus();
			}
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			�Г��`����ꗗ����();
			tex�W��X�R�[�h.Focus();
		}

		private void axGT�Г��`���_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			�Г��`�������();
		}

		private void axGT�Г��`���_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT�Г��`���.set_CelForeColor(nOldRow,0,0);
			axGT�Г��`���.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGT�Г��`���.set_CelForeColor(axGT�Г��`���.CaretRow,0,0x98FB98);  //BGR
			axGT�Г��`���.set_CelBackColor(axGT�Г��`���.CaretRow,0,0x006000);
			nOldRow = axGT�Г��`���.CaretRow;
		}

		private void axGT�Г��`���_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if(e.keyCode == 13)
			{
				�Г��`�������();
			}

			if(e.keyCode == 9)
			{
				this.SelectNextControl(axGT�Г��`���, true, true, true, true);
			}
		}

		private void btn�o�^_Click(object sender, System.EventArgs e)
		{
			string s�������[�h = btn�o�^.Text;
			if(�o�^�`�F�b�N(s�������[�h) != true)
			{
				return;
			}

			tex���b�Z�[�W.Text = s�������[�h + "���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[4];
				sKey[0] = tex�Г��`����R�[�h.Text;
				sKey[1] = tex�W��X�R�[�h.Text;
				sKey[2] = s�X�V����;
				sKey[3] = gs���p�҃R�[�h;

				if(s�������[�h.Equals("�o�^"))
				{
					string[] sList = sv_maintenance.Ins_HouseSlipMember(gsa���[�U, sKey);
					tex���b�Z�[�W.Text = sList[0];
					if(sList[0].Equals("����I��"))
					{
						//�W��X�̒ǉ�
						�Г��`������X�o�^���[�h();
						�Г��`����ꗗ����();
					}
					else
					{
						�r�[�v��();
					}
				}
				else
				{
					string[] sList = sv_maintenance.Upd_HouseSlipMember(gsa���[�U, sKey);
					tex���b�Z�[�W.Text = sList[0];
					if(sList[0].Equals("����I��"))
					{
						//�W��X�̍X�V
						�Г��`������X�o�^���[�h();
						�Г��`����ꗗ����();
					}
					else
					{
						�r�[�v��();
					}
				}
				tex�W��X�R�[�h.Focus();
			}
			catch(Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�Г��`������X�o�^���[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;		
		}

		private bool �o�^�`�F�b�N(string s�������[�h)
		{
			//�Г��`�[����`�F�b�N
			if(!�Г��`�[����`�F�b�N())
			{
				tex�Г��`����R�[�h.Focus();
				return false;
			}

			//���X���`�F�b�N
			if(!���X���`�F�b�N())
			{
				tex�W��X�R�[�h.Focus();
				return false;
			}

			//�o�^���̂݁A�Г��`����d���`�F�b�N
			if(s�������[�h.Equals("�o�^"))
			{
				if(!�Г��`�[����d���`�F�b�N())
				{
					MessageBox.Show("���q�l�R�[�h(" + tex�Г��`����R�[�h.Text + ")�͊��ɓo�^����Ă��܂�", "���̓`�F�b�N", MessageBoxButtons.OK);
					tex�Г��`����R�[�h.Focus();
					return false;
				}
			}

			return true;
		}

		private bool �Г��`�[����`�F�b�N()
		{
			string s����R�[�h = tex�Г��`����R�[�h.Text.Trim();

			//�@�󔒃`�F�b�N
			if(s����R�[�h.Length == 0)
			{
				MessageBox.Show("���q�l�R�[�h����͂��Ă�������", "���̓`�F�b�N", MessageBoxButtons.OK);
				return false;
			}

			//�A���p�`�F�b�N
			if(!���p�`�F�b�N(tex�Г��`����R�[�h, "���q�l�R�[�h"))
			{
				return false;
			}

			//�B�`���`�F�b�N(����R�[�h�̐擪2�����́wFK�x�łȂ��Ƒʖ�)
			if(s����R�[�h.Substring(0,2) != "FK")
			{
				MessageBox.Show("���q�l�R�[�h�́wFK�x����n�߂Ă�������", "���̓`�F�b�N", MessageBoxButtons.OK);
				return false;
			}

			//�C�b�l�O�P����}�X�^���݃`�F�b�N
			try
			{
				string[] sKey = new string[1];
				sKey[0] = s����R�[�h;
				string[] sList = sv_maintenance.Sel_Member(gsa���[�U, sKey);
				if(sList[0].Equals("����I��"))
				{
					//�b�l�O�P����}�X�^�ɑ���
					tex���b�Z�[�W.Text = "";
					tex�Г��`�����.Text = sList[2];
				}
				else
				{
					//����ȊO�̏ꍇ
					tex���b�Z�[�W.Text = sList[0].Trim();
					MessageBox.Show("����R�[�h(" + s����R�[�h + ")���s���ł�", "���̓`�F�b�N", MessageBoxButtons.OK);
					return false;
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�Г��`������X�o�^���[�h();
				return false;
			}
			return true;
		}

		private bool ���X���`�F�b�N()
		{
			string s�X���R�[�h = tex�W��X�R�[�h.Text.Trim();

			//�@�󔒃`�F�b�N
			if(s�X���R�[�h.Length == 0)
			{
				MessageBox.Show("���X���R�[�h����͂��Ă�������", "���̓`�F�b�N", MessageBoxButtons.OK);
				return false;
			}

			//�A���p�`�F�b�N
			if(!���p�`�F�b�N(tex�W��X�R�[�h, "���X���R�[�h"))
			{
				return false;
			}

			//�B�b�l�P�O�X���}�X�^���݃`�F�b�N
			try
			{
				string[] sKey = new string[1];
				sKey[0] = s�X���R�[�h;
				string[] sList = sv_maintenance.Sel_Shop(gsa���[�U, sKey);
				if(sList[0].Equals("����I��"))
				{
					//�b�l�P�O�X���}�X�^�ɑ���
					tex���b�Z�[�W.Text = "";
					tex�W��X��.Text = sList[1];
				}
				else
				{
					//����ȊO�̏ꍇ
					tex���b�Z�[�W.Text = sList[0].Trim();
					MessageBox.Show("���X���R�[�h(" + s�X���R�[�h + ")���s���ł�", "���̓`�F�b�N", MessageBoxButtons.OK);
					return false;
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�Г��`������X�o�^���[�h();
				return false;
			}
			return true;
		}

		private bool �Г��`�[����d���`�F�b�N()
		{
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�Г��`����R�[�h.Text.Trim();
				string[] sList = sv_maintenance.Sel_HouseSlipMember(gsa���[�U, sKey);
				if(sList[0].Equals("����I��"))
				{
					//�b�l�O�T������X�e�}�X�^�ɑ��݁i�˃f�[�^�d���j
					tex���b�Z�[�W.Text = "";
					tex�Г��`�����.Text = sList[2];
					return false;
				}
				else if(sList[0].Equals("�Y���f�[�^������܂���"))
				{
					//����ȊO�̏ꍇ
					tex���b�Z�[�W.Text = "";
				}
				else
				{
					//����ȊO�̏ꍇ
					tex���b�Z�[�W.Text = sList[0].Trim();
					return false;
				}
			}
			catch(Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�Г��`������X�o�^���[�h();
				return false;
			}
			return true;
		}

		private void btn�폜_Click(object sender, System.EventArgs e)
		{
			tex�Г��`����R�[�h.Text = tex�Г��`����R�[�h.Text.Trim();

			//�폜�O�̍ŏI�m�F
			DialogResult result = MessageBox.Show("�폜���Ă���낵���ł����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.None);
			if(result == DialogResult.No)
			{
				return;
			}

			tex���b�Z�[�W.Text = "�폜���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[3];
				sKey[0] = tex�Г��`����R�[�h.Text;
				sKey[1] = s�X�V����;
				sKey[2] = gs���p�҃R�[�h;

				string[] sList = sv_maintenance.Del_HouseSlipMember(gsa���[�U, sKey);
				tex���b�Z�[�W.Text = sList[0];
				if(sList[0].Equals("����I��"))
				{
					�Г��`������X�o�^���[�h();
					�Г��`����ꗗ����();
				}
				else
				{
					�r�[�v��();
				}
				tex�Г��`����R�[�h.Focus();
			}
			catch(Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�Г��`������X�o�^���[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn���_Click(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W.Text = "";
			�Г��`������X�o�^���[�h();
			tex�Г��`����R�[�h.Focus();
		}

		private void btn�������_Click(object sender, System.EventArgs e)
		{
			����ꗗ();
		}

		private void tex�Г��`����R�[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				tex�Г��`����R�[�h.Text = tex�Г��`����R�[�h.Text.Trim();
				if(tex�Г��`����R�[�h.Text.Length == 0 || tex�Г��`����R�[�h.Text.Length == 1)
				{
					tex�Г��`����R�[�h.Focus();
				}
				else
				{
					int iRet = �������();
					if(iRet == 0)
					{
						//�����񖢑��ݎ�
						tex�Г��`����R�[�h.Focus();
					}
					else
					{
						//�����񑶍ݎ�
						tex�W��X�R�[�h.Focus();
					}
				}
			}
		}

		private void tex�Г��`����R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar.ToString().Equals("*"))
			{
				btn�������.Focus();
				����ꗗ();
				e.Handled = true;
			}
		}

		private void ����ꗗ()
		{
			tex�Г��`����R�[�h.Text = tex�Г��`����R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�Г��`����R�[�h, "���q�l�R�[�h")) return;

			//������ʂ��E���ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			if (g������� == null)	 g������� = new �������();
			g�������.Left = this.Left + 204;
			g�������.Top = this.Top;

			//�R�[�h�̏����\��
			g�������.s����R�[�h = "";
			g�������.s����� = "";
			g�������.b�^�p���̂��q�l�̂� = true;
			g�������.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g�������.s����R�[�h.Trim().Length > 0)
			{
				tex�Г��`����R�[�h.Text = g�������.s����R�[�h.Trim();
				tex�Г��`�����.Text = g�������.s�����.Trim();
			}
			else
			{
				tex�Г��`����R�[�h.Focus();
			}
		}

		private int �������()
		{
			tex�Г��`����R�[�h.Text = tex�Г��`����R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�Г��`����R�[�h, "���q�l�R�[�h")) return 0;
			if(tex�Г��`����R�[�h.Text.ToUpper().Substring(0,2) != "FK")
			{
				tex���b�Z�[�W.Text = "���q�l�R�[�h�́wFK�x����n�߂Ă�������";
				return 0;
			}

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			int iRet = 0;
			try
			{
				//�b�l�O�P����}�X�^���݃`�F�b�N
				string[] sKey = new string[1];
				sKey[0] = tex�Г��`����R�[�h.Text;
				string[] sList = sv_maintenance.Sel_Member(gsa���[�U, sKey);
				if(sList[0].Equals("����I��"))
				{
					//�b�l�O�T������X�e�}�X�^���݃`�F�b�N
					string[] sList2 = sv_maintenance.Sel_HouseSlipMember(gsa���[�U, sKey);
					if(sList2[0].Equals("����I��"))
					{
						tex���b�Z�[�W.Text = "";
						tex�Г��`����R�[�h.Text = sList2[1].Trim();
						tex�Г��`�����.Text = sList2[2].Trim();
						tex�W��X�R�[�h.Text = sList2[3].Trim();
						tex�W��X��.Text = sList2[4].Trim();					
						s�X�V���� = sList2[5].Trim();
						�Г��`������X�X�V���[�h();
						iRet = 1;
					}
					else if(sList2[0].Equals("�Y���f�[�^������܂���"))
					{
						tex���b�Z�[�W.Text = "";
						tex�Г��`����R�[�h.Text = sList[1].Trim();
						tex�Г��`�����.Text = sList[2].Trim();
						s�X�V���� = "00000000000000";
						btn�o�^.Text = "�o�^";
						btn�폜.Enabled = false;
						iRet = 2;
					}
					else
					{
						tex���b�Z�[�W.Text = sList2[0];
						�Г��`������X�o�^���[�h();
						iRet = 0;
					}
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					iRet = 0;
				}
			}
			catch(Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�Г��`������X�o�^���[�h();
				iRet = 0;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return iRet;
		}

		private void btn�W��X����_Click(object sender, System.EventArgs e)
		{
			�W��X���ꗗ();
		}

		private void tex�W��X�R�[�h_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				tex�W��X�R�[�h.Text = tex�W��X�R�[�h.Text.Trim();
				if(tex�W��X�R�[�h.Text.Length == 0)
				{
					tex�W��X�R�[�h.Focus();
				}
				else
				{
					if(!�W��X������())
					{
						tex�W��X�R�[�h.Focus();
					}
				}
			}
		}

		private void tex�W��X�R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar.ToString().Equals("*"))
			{
				btn�W��X����.Focus();
				�W��X���ꗗ();
				e.Handled = true;
			}		
		}

		private void �W��X���ꗗ()
		{
			tex�W��X�R�[�h.Text = tex�W��X�R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�W��X�R�[�h, "���X���R�[�h")) return;

			//������ʂ��E���ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			if(g�X������ == null)	 g�X������ = new �X������();
			g�X������.Left = this.Left + 204;
			g�X������.Top = this.Top;

			//�R�[�h�̏����\��
			g�X������.s�X���R�[�h = "";
			g�X������.s�X���� = "";
			g�X������.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g�X������.s�X���R�[�h.Trim().Length != 0)
			{
				tex�W��X�R�[�h.Text = g�X������.s�X���R�[�h.Trim();
				tex�W��X��.Text = g�X������.s�X����.Trim();
			}
			else
			{
				tex�W��X�R�[�h.Focus();
			}
		}

		private bool �W��X������()
		{
			tex�W��X�R�[�h.Text = tex�W��X�R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�W��X�R�[�h, "���X���R�[�h")) return false;

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�W��X�R�[�h.Text;
				string[] sList = sv_maintenance.Sel_Shop(gsa���[�U, sKey);
				if(sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex�W��X��.Text = sList[1];
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					ret =  false;
				}
			}
			catch(Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�Г��`������X�o�^���[�h();
				ret = false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}

		private void btn�O��_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�--;
			�ŏ��ݒ�();
			axGT�Г��`���.CaretRow = 1;
			axGT�Г��`���_CurPlaceChanged(null,null);
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�++;
			�ŏ��ݒ�();
			axGT�Г��`���.CaretRow = 1;
			axGT�Г��`���_CurPlaceChanged(null,null);
		}
		
		private void �ŏ��ݒ�()
		{
			axGT�Г��`���.Clear();

			i�J�n�� = (i���ݕŐ� - 1) * axGT�Г��`���.Rows + 1;
			i�I���� = i���ݕŐ� * axGT�Г��`���.Rows;

			short s�\���� = (short)1;
			for(short sCnt = (short)i�J�n��; sCnt < s�Г��`����ꗗ.Length && sCnt <= i�I����; sCnt++)
			{
				axGT�Г��`���.set_RowsText(s�\����, s�Г��`����ꗗ[sCnt]);
				s�\����++;
			}

			lab�Ŕԍ�.Text = i���ݕŐ�.ToString() + " / " + i�ő�Ő�.ToString();

			if(i���ݕŐ� == 1)
			{
				btn�O��.Enabled = false;
			}
			else
			{
				btn�O��.Enabled = true;
			}

			if(i���ݕŐ� == i�ő�Ő�)
			{
				btn����.Enabled = false;
			}
			else
			{
				btn����.Enabled = true;
			}
		}

		private void �Г��`������X�}�X�^_Closed(object sender, System.EventArgs e)
		{
			axGT�Г��`���.CaretRow = 1;
			axGT�Г��`���_CurPlaceChanged(null,null);
			tex�������.Focus();
		}
	}
}
