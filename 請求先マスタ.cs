using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [�������񃁃��e�i���X]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// MOD 2008.05.02 ���s�j���� �Ǘ��X���̐���̏C�� 
	// ADD 2008.11.20 ���s�j���� ���Ӑ敔�ۃR�[�h�̋󔒎��Ή� 
	//                Oracle���֎��̐ݒ�ڍs����H or �o�[�W�����ɂ�鍷��
	//--------------------------------------------------------------------------
	// MOD 2009.05.28 ���s�j���� �o�׎��шꗗ�^����\���Ή� 
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� 
	//--------------------------------------------------------------------------
	// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2016.03.16 BEVAS�j���{ ���q�^���ŃO���[�o���^�p�Ή� 
	//--------------------------------------------------------------------------
	// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή�
	//--------------------------------------------------------------------------
	public class ������}�X�^ : ���ʃt�H�[��
	{
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//		private string s�Ǘ��X���R�[�h = "";
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
		private string s�X�֔ԍ� = "";
		private string s�X�V���� = "";
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� START
		private string s����b�c = "";
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� END
		private short nOldRow = 0;
// MOD 2009.05.28 ���s�j���� �o�׎��шꗗ�^����\���Ή� START
		private string s����X�V���� = "";
// MOD 2009.05.28 ���s�j���� �o�׎��шꗗ�^����\���Ή� END

		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lab����;
		private System.Windows.Forms.Label lab�L���R�[�h;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lab������^�C�g��;
		private ���ʃe�L�X�g�{�b�N�X tex�Ǘ��X���R�[�h;
		private System.Windows.Forms.Label lab���Ӑ敔�ۖ�;
		private System.Windows.Forms.Label lab����R�[�h;
		private ���ʃe�L�X�g�{�b�N�X tex����R�[�h;
		private System.Windows.Forms.Button btn�Ǘ��X������;
		private System.Windows.Forms.Button btn�������;
		private ���ʃe�L�X�g�{�b�N�X tex�����;
		private System.Windows.Forms.Button btn��������;
		private System.Windows.Forms.Button btn������폜;
		private System.Windows.Forms.Button btn������o�^;
		private System.Windows.Forms.Label lab�Ǘ��X����;
		private ���ʃe�L�X�g�{�b�N�X tex�Ǘ��X����;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lab���Ӑ�R�[�h;
		private System.Windows.Forms.Label lab���Ӑ敔�ۃR�[�h;
		private AxGTABLE32V2Lib.AxGTable32 axGT������;
		private ���ʃe�L�X�g�{�b�N�X tex���Ӑ�R�[�h;
		private ���ʃe�L�X�g�{�b�N�X tex���Ӑ敔�ۃR�[�h;
		private ���ʃe�L�X�g�{�b�N�X tex���Ӑ敔�ۖ�;
		private System.Windows.Forms.Panel pnl������;
		private ���ʃe�L�X�g�{�b�N�X tex�F�ؗ��p�Җ�;
		private System.Windows.Forms.Label lab�F�ؗ��p�Җ�;
		private System.Windows.Forms.Label lab�F�؉����;
		private ���ʃe�L�X�g�{�b�N�X tex�F�؉����;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lab�X�֔ԍ�;
		private System.Windows.Forms.Button btn�Z������;
		private ���ʃe�L�X�g�{�b�N�X tex�X�֔ԍ��Q;
		private ���ʃe�L�X�g�{�b�N�X tex�X�֔ԍ��P;
		private System.Windows.Forms.Label label10;
		private ���ʃe�L�X�g�{�b�N�X tex�X�֔ԍ��X��;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex���吔;
		private System.Windows.Forms.Button btn������s;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cb�o�׎��шꗗ�^����\��;
		private System.Windows.Forms.Button btn����X�V;
		private System.Windows.Forms.GroupBox gp���q�l;
		private System.ComponentModel.IContainer components;

		public ������}�X�^()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(������}�X�^));
            this.pnl������ = new System.Windows.Forms.Panel();
            this.btn����X�V = new System.Windows.Forms.Button();
            this.cb�o�׎��шꗗ�^����\�� = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tex���吔 = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.label5 = new System.Windows.Forms.Label();
            this.tex�X�֔ԍ��X�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.btn�Z������ = new System.Windows.Forms.Button();
            this.tex�X�֔ԍ��Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.tex�X�֔ԍ��P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.label10 = new System.Windows.Forms.Label();
            this.lab�X�֔ԍ� = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tex���Ӑ敔�ۖ� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.tex���Ӑ敔�ۃR�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.tex���Ӑ�R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab���Ӑ敔�ۃR�[�h = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab���Ӑ�R�[�h = new System.Windows.Forms.Label();
            this.axGT������ = new AxGTABLE32V2Lib.AxGTable32();
            this.tex�Ǘ��X���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab�Ǘ��X���� = new System.Windows.Forms.Label();
            this.btn�������� = new System.Windows.Forms.Button();
            this.btn������폜 = new System.Windows.Forms.Button();
            this.btn������o�^ = new System.Windows.Forms.Button();
            this.tex����� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.btn������� = new System.Windows.Forms.Button();
            this.lab���Ӑ敔�ۖ� = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lab����R�[�h = new System.Windows.Forms.Label();
            this.tex����R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.btn������s = new System.Windows.Forms.Button();
            this.gp���q�l = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn�Ǘ��X������ = new System.Windows.Forms.Button();
            this.lab�L���R�[�h = new System.Windows.Forms.Label();
            this.tex�Ǘ��X���R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tex�F�ؗ��p�Җ� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab�F�ؗ��p�Җ� = new System.Windows.Forms.Label();
            this.lab�F�؉���� = new System.Windows.Forms.Label();
            this.tex�F�؉���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab���� = new System.Windows.Forms.Label();
            this.lab������^�C�g�� = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.btn���� = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnl������.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT������)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl������
            // 
            this.pnl������.BackColor = System.Drawing.Color.Honeydew;
            this.pnl������.Controls.Add(this.btn����X�V);
            this.pnl������.Controls.Add(this.cb�o�׎��шꗗ�^����\��);
            this.pnl������.Controls.Add(this.label4);
            this.pnl������.Controls.Add(this.tex���吔);
            this.pnl������.Controls.Add(this.label5);
            this.pnl������.Controls.Add(this.tex�X�֔ԍ��X��);
            this.pnl������.Controls.Add(this.btn�Z������);
            this.pnl������.Controls.Add(this.tex�X�֔ԍ��Q);
            this.pnl������.Controls.Add(this.tex�X�֔ԍ��P);
            this.pnl������.Controls.Add(this.label10);
            this.pnl������.Controls.Add(this.lab�X�֔ԍ�);
            this.pnl������.Controls.Add(this.label2);
            this.pnl������.Controls.Add(this.tex���Ӑ敔�ۖ�);
            this.pnl������.Controls.Add(this.tex���Ӑ敔�ۃR�[�h);
            this.pnl������.Controls.Add(this.tex���Ӑ�R�[�h);
            this.pnl������.Controls.Add(this.lab���Ӑ敔�ۃR�[�h);
            this.pnl������.Controls.Add(this.label3);
            this.pnl������.Controls.Add(this.lab���Ӑ�R�[�h);
            this.pnl������.Controls.Add(this.axGT������);
            this.pnl������.Controls.Add(this.tex�Ǘ��X����);
            this.pnl������.Controls.Add(this.lab�Ǘ��X����);
            this.pnl������.Controls.Add(this.btn��������);
            this.pnl������.Controls.Add(this.btn������폜);
            this.pnl������.Controls.Add(this.btn������o�^);
            this.pnl������.Controls.Add(this.tex�����);
            this.pnl������.Controls.Add(this.btn�������);
            this.pnl������.Controls.Add(this.lab���Ӑ敔�ۖ�);
            this.pnl������.Controls.Add(this.label1);
            this.pnl������.Controls.Add(this.label22);
            this.pnl������.Controls.Add(this.lab����R�[�h);
            this.pnl������.Controls.Add(this.tex����R�[�h);
            this.pnl������.Controls.Add(this.btn������s);
            this.pnl������.Controls.Add(this.gp���q�l);
            this.pnl������.Location = new System.Drawing.Point(1, 6);
            this.pnl������.Name = "pnl������";
            this.pnl������.Size = new System.Drawing.Size(667, 366);
            this.pnl������.TabIndex = 1;
            // 
            // btn����X�V
            // 
            this.btn����X�V.BackColor = System.Drawing.Color.Blue;
            this.btn����X�V.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn����X�V.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn����X�V.ForeColor = System.Drawing.Color.White;
            this.btn����X�V.Location = new System.Drawing.Point(600, 64);
            this.btn����X�V.Name = "btn����X�V";
            this.btn����X�V.Size = new System.Drawing.Size(48, 22);
            this.btn����X�V.TabIndex = 90;
            this.btn����X�V.Text = "�X�V";
            this.btn����X�V.UseVisualStyleBackColor = false;
            this.btn����X�V.Click += new System.EventHandler(this.btn����X�V_Click);
            // 
            // cb�o�׎��шꗗ�^����\��
            // 
            this.cb�o�׎��шꗗ�^����\��.ForeColor = System.Drawing.Color.LimeGreen;
            this.cb�o�׎��шꗗ�^����\��.Location = new System.Drawing.Point(422, 64);
            this.cb�o�׎��шꗗ�^����\��.Name = "cb�o�׎��шꗗ�^����\��";
            this.cb�o�׎��шꗗ�^����\��.Size = new System.Drawing.Size(174, 22);
            this.cb�o�׎��шꗗ�^����\��.TabIndex = 89;
            this.cb�o�׎��шꗗ�^����\��.Text = "�o�׎��шꗗ�F�^���\���Ȃ�";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(34, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 14);
            this.label4.TabIndex = 88;
            this.label4.Text = "��";
            // 
            // tex���吔
            // 
            this.tex���吔.BackColor = System.Drawing.Color.Honeydew;
            this.tex���吔.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex���吔.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���吔.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex���吔.Location = new System.Drawing.Point(152, 332);
            this.tex���吔.MaxLength = 10;
            this.tex���吔.Name = "tex���吔";
            this.tex���吔.ReadOnly = true;
            this.tex���吔.Size = new System.Drawing.Size(28, 16);
            this.tex���吔.TabIndex = 87;
            this.tex���吔.TabStop = false;
            this.tex���吔.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(48, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 14);
            this.label5.TabIndex = 86;
            this.label5.Text = "�Z�N�V������";
            // 
            // tex�X�֔ԍ��X��
            // 
            this.tex�X�֔ԍ��X��.BackColor = System.Drawing.Color.Honeydew;
            this.tex�X�֔ԍ��X��.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex�X�֔ԍ��X��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�X�֔ԍ��X��.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�X�֔ԍ��X��.Location = new System.Drawing.Point(304, 308);
            this.tex�X�֔ԍ��X��.MaxLength = 6;
            this.tex�X�֔ԍ��X��.Name = "tex�X�֔ԍ��X��";
            this.tex�X�֔ԍ��X��.ReadOnly = true;
            this.tex�X�֔ԍ��X��.Size = new System.Drawing.Size(74, 16);
            this.tex�X�֔ԍ��X��.TabIndex = 85;
            this.tex�X�֔ԍ��X��.TabStop = false;
            // 
            // btn�Z������
            // 
            this.btn�Z������.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�Z������.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�Z������.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�Z������.ForeColor = System.Drawing.Color.White;
            this.btn�Z������.Location = new System.Drawing.Point(252, 304);
            this.btn�Z������.Name = "btn�Z������";
            this.btn�Z������.Size = new System.Drawing.Size(48, 22);
            this.btn�Z������.TabIndex = 3;
            this.btn�Z������.TabStop = false;
            this.btn�Z������.Text = "����";
            this.btn�Z������.UseVisualStyleBackColor = false;
            this.btn�Z������.Click += new System.EventHandler(this.btn�Z������_Click);
            // 
            // tex�X�֔ԍ��Q
            // 
            this.tex�X�֔ԍ��Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�X�֔ԍ��Q.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�X�֔ԍ��Q.Location = new System.Drawing.Point(200, 304);
            this.tex�X�֔ԍ��Q.MaxLength = 4;
            this.tex�X�֔ԍ��Q.Name = "tex�X�֔ԍ��Q";
            this.tex�X�֔ԍ��Q.Size = new System.Drawing.Size(48, 23);
            this.tex�X�֔ԍ��Q.TabIndex = 8;
            this.tex�X�֔ԍ��Q.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�X�֔ԍ��Q_KeyDown);
            this.tex�X�֔ԍ��Q.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�X�֔ԍ��Q_KeyPress);
            // 
            // tex�X�֔ԍ��P
            // 
            this.tex�X�֔ԍ��P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�X�֔ԍ��P.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�X�֔ԍ��P.Location = new System.Drawing.Point(150, 304);
            this.tex�X�֔ԍ��P.MaxLength = 3;
            this.tex�X�֔ԍ��P.Name = "tex�X�֔ԍ��P";
            this.tex�X�֔ԍ��P.Size = new System.Drawing.Size(38, 23);
            this.tex�X�֔ԍ��P.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(188, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 84;
            this.label10.Text = "�|";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab�X�֔ԍ�
            // 
            this.lab�X�֔ԍ�.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�X�֔ԍ�.Location = new System.Drawing.Point(48, 310);
            this.lab�X�֔ԍ�.Name = "lab�X�֔ԍ�";
            this.lab�X�֔ԍ�.Size = new System.Drawing.Size(95, 14);
            this.lab�X�֔ԍ�.TabIndex = 79;
            this.lab�X�֔ԍ�.Text = "�X�֔ԍ�";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(34, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 14);
            this.label2.TabIndex = 78;
            this.label2.Text = "��";
            // 
            // tex���Ӑ敔�ۖ�
            // 
            this.tex���Ӑ敔�ۖ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���Ӑ敔�ۖ�.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex���Ӑ敔�ۖ�.Location = new System.Drawing.Point(150, 278);
            this.tex���Ӑ敔�ۖ�.MaxLength = 10;
            this.tex���Ӑ敔�ۖ�.Name = "tex���Ӑ敔�ۖ�";
            this.tex���Ӑ敔�ۖ�.Size = new System.Drawing.Size(170, 23);
            this.tex���Ӑ敔�ۖ�.TabIndex = 6;
            // 
            // tex���Ӑ敔�ۃR�[�h
            // 
            this.tex���Ӑ敔�ۃR�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���Ӑ敔�ۃR�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex���Ӑ敔�ۃR�[�h.Location = new System.Drawing.Point(150, 254);
            this.tex���Ӑ敔�ۃR�[�h.MaxLength = 6;
            this.tex���Ӑ敔�ۃR�[�h.Name = "tex���Ӑ敔�ۃR�[�h";
            this.tex���Ӑ敔�ۃR�[�h.Size = new System.Drawing.Size(82, 23);
            this.tex���Ӑ敔�ۃR�[�h.TabIndex = 5;
            // 
            // tex���Ӑ�R�[�h
            // 
            this.tex���Ӑ�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���Ӑ�R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex���Ӑ�R�[�h.Location = new System.Drawing.Point(150, 230);
            this.tex���Ӑ�R�[�h.MaxLength = 10;
            this.tex���Ӑ�R�[�h.Name = "tex���Ӑ�R�[�h";
            this.tex���Ӑ�R�[�h.Size = new System.Drawing.Size(130, 23);
            this.tex���Ӑ�R�[�h.TabIndex = 4;
            // 
            // lab���Ӑ敔�ۃR�[�h
            // 
            this.lab���Ӑ敔�ۃR�[�h.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab���Ӑ敔�ۃR�[�h.Location = new System.Drawing.Point(48, 260);
            this.lab���Ӑ敔�ۃR�[�h.Name = "lab���Ӑ敔�ۃR�[�h";
            this.lab���Ӑ敔�ۃR�[�h.Size = new System.Drawing.Size(95, 14);
            this.lab���Ӑ敔�ۃR�[�h.TabIndex = 77;
            this.lab���Ӑ敔�ۃR�[�h.Text = "���Ӑ敔�ۃR�[�h";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(34, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 14);
            this.label3.TabIndex = 76;
            this.label3.Text = "��";
            // 
            // lab���Ӑ�R�[�h
            // 
            this.lab���Ӑ�R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab���Ӑ�R�[�h.Location = new System.Drawing.Point(48, 236);
            this.lab���Ӑ�R�[�h.Name = "lab���Ӑ�R�[�h";
            this.lab���Ӑ�R�[�h.Size = new System.Drawing.Size(95, 14);
            this.lab���Ӑ�R�[�h.TabIndex = 75;
            this.lab���Ӑ�R�[�h.Text = "���Ӑ�R�[�h";
            // 
            // axGT������
            // 
            this.axGT������.DataSource = null;
            this.axGT������.Location = new System.Drawing.Point(30, 96);
            this.axGT������.Name = "axGT������";
            this.axGT������.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT������.OcxState")));
            this.axGT������.Size = new System.Drawing.Size(624, 128);
            this.axGT������.TabIndex = 3;
            this.axGT������.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT������_CurPlaceChanged);
            this.axGT������.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT������_CelDblClick);
            this.axGT������.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT������_KeyDownEvent);
            // 
            // tex�Ǘ��X����
            // 
            this.tex�Ǘ��X����.BackColor = System.Drawing.Color.Honeydew;
            this.tex�Ǘ��X����.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex�Ǘ��X����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�Ǘ��X����.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�Ǘ��X����.Location = new System.Drawing.Point(150, 10);
            this.tex�Ǘ��X����.MaxLength = 6;
            this.tex�Ǘ��X����.Name = "tex�Ǘ��X����";
            this.tex�Ǘ��X����.ReadOnly = true;
            this.tex�Ǘ��X����.Size = new System.Drawing.Size(74, 16);
            this.tex�Ǘ��X����.TabIndex = 73;
            this.tex�Ǘ��X����.TabStop = false;
            // 
            // lab�Ǘ��X����
            // 
            this.lab�Ǘ��X����.BackColor = System.Drawing.Color.Honeydew;
            this.lab�Ǘ��X����.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�Ǘ��X����.Location = new System.Drawing.Point(48, 12);
            this.lab�Ǘ��X����.Name = "lab�Ǘ��X����";
            this.lab�Ǘ��X����.Size = new System.Drawing.Size(95, 14);
            this.lab�Ǘ��X����.TabIndex = 72;
            this.lab�Ǘ��X����.Text = "�Ǘ��X����";
            // 
            // btn��������
            // 
            this.btn��������.BackColor = System.Drawing.Color.Blue;
            this.btn��������.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn��������.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn��������.ForeColor = System.Drawing.Color.White;
            this.btn��������.Location = new System.Drawing.Point(446, 336);
            this.btn��������.Name = "btn��������";
            this.btn��������.Size = new System.Drawing.Size(48, 22);
            this.btn��������.TabIndex = 11;
            this.btn��������.Text = "���";
            this.btn��������.UseVisualStyleBackColor = false;
            this.btn��������.Click += new System.EventHandler(this.btn��������_Click);
            // 
            // btn������폜
            // 
            this.btn������폜.BackColor = System.Drawing.Color.Blue;
            this.btn������폜.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn������폜.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn������폜.ForeColor = System.Drawing.Color.White;
            this.btn������폜.Location = new System.Drawing.Point(392, 336);
            this.btn������폜.Name = "btn������폜";
            this.btn������폜.Size = new System.Drawing.Size(48, 22);
            this.btn������폜.TabIndex = 10;
            this.btn������폜.Text = "�폜";
            this.btn������폜.UseVisualStyleBackColor = false;
            this.btn������폜.Click += new System.EventHandler(this.btn������폜_Click);
            // 
            // btn������o�^
            // 
            this.btn������o�^.BackColor = System.Drawing.Color.Blue;
            this.btn������o�^.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn������o�^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn������o�^.ForeColor = System.Drawing.Color.White;
            this.btn������o�^.Location = new System.Drawing.Point(338, 336);
            this.btn������o�^.Name = "btn������o�^";
            this.btn������o�^.Size = new System.Drawing.Size(48, 22);
            this.btn������o�^.TabIndex = 9;
            this.btn������o�^.Text = "�o�^";
            this.btn������o�^.UseVisualStyleBackColor = false;
            this.btn������o�^.Click += new System.EventHandler(this.btn������o�^_Click);
            // 
            // tex�����
            // 
            this.tex�����.BackColor = System.Drawing.Color.Honeydew;
            this.tex�����.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex�����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�����.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�����.Location = new System.Drawing.Point(392, 44);
            this.tex�����.MaxLength = 20;
            this.tex�����.Name = "tex�����";
            this.tex�����.ReadOnly = true;
            this.tex�����.Size = new System.Drawing.Size(258, 16);
            this.tex�����.TabIndex = 9;
            this.tex�����.TabStop = false;
            // 
            // btn�������
            // 
            this.btn�������.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�������.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�������.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�������.ForeColor = System.Drawing.Color.White;
            this.btn�������.Location = new System.Drawing.Point(286, 40);
            this.btn�������.Name = "btn�������";
            this.btn�������.Size = new System.Drawing.Size(48, 22);
            this.btn�������.TabIndex = 1;
            this.btn�������.TabStop = false;
            this.btn�������.Text = "����";
            this.btn�������.UseVisualStyleBackColor = false;
            this.btn�������.Click += new System.EventHandler(this.btn�������_Click);
            // 
            // lab���Ӑ敔�ۖ�
            // 
            this.lab���Ӑ敔�ۖ�.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab���Ӑ敔�ۖ�.Location = new System.Drawing.Point(48, 284);
            this.lab���Ӑ敔�ۖ�.Name = "lab���Ӑ敔�ۖ�";
            this.lab���Ӑ敔�ۖ�.Size = new System.Drawing.Size(95, 14);
            this.lab���Ӑ敔�ۖ�.TabIndex = 52;
            this.lab���Ӑ敔�ۖ�.Text = "���Ӑ敔�ۖ�";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 14);
            this.label1.TabIndex = 51;
            this.label1.Text = "��";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.label22.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 366);
            this.label22.TabIndex = 50;
            this.label22.Text = "��������";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab����R�[�h
            // 
            this.lab����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab����R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab����R�[�h.Location = new System.Drawing.Point(50, 46);
            this.lab����R�[�h.Name = "lab����R�[�h";
            this.lab����R�[�h.Size = new System.Drawing.Size(95, 14);
            this.lab����R�[�h.TabIndex = 19;
            this.lab����R�[�h.Text = "���q�l�R�[�h";
            // 
            // tex����R�[�h
            // 
            this.tex����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex����R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex����R�[�h.Location = new System.Drawing.Point(150, 40);
            this.tex����R�[�h.MaxLength = 10;
            this.tex����R�[�h.Name = "tex����R�[�h";
            this.tex����R�[�h.Size = new System.Drawing.Size(130, 23);
            this.tex����R�[�h.TabIndex = 0;
            this.tex����R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex����R�[�h_KeyDown);
            this.tex����R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex����R�[�h_KeyPress);
            // 
            // btn������s
            // 
            this.btn������s.BackColor = System.Drawing.Color.Blue;
            this.btn������s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn������s.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn������s.ForeColor = System.Drawing.Color.White;
            this.btn������s.Location = new System.Drawing.Point(338, 40);
            this.btn������s.Name = "btn������s";
            this.btn������s.Size = new System.Drawing.Size(48, 22);
            this.btn������s.TabIndex = 2;
            this.btn������s.Text = "���s";
            this.btn������s.UseVisualStyleBackColor = false;
            this.btn������s.Click += new System.EventHandler(this.btn������s_Click);
            // 
            // gp���q�l
            // 
            this.gp���q�l.Location = new System.Drawing.Point(30, 28);
            this.gp���q�l.Name = "gp���q�l";
            this.gp���q�l.Size = new System.Drawing.Size(624, 64);
            this.gp���q�l.TabIndex = 91;
            this.gp���q�l.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.btn�Ǘ��X������);
            this.panel5.Controls.Add(this.lab�L���R�[�h);
            this.panel5.Controls.Add(this.tex�Ǘ��X���R�[�h);
            this.panel5.Location = new System.Drawing.Point(1, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 32);
            this.panel5.TabIndex = 0;
            // 
            // btn�Ǘ��X������
            // 
            this.btn�Ǘ��X������.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�Ǘ��X������.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�Ǘ��X������.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�Ǘ��X������.ForeColor = System.Drawing.Color.White;
            this.btn�Ǘ��X������.Location = new System.Drawing.Point(178, 4);
            this.btn�Ǘ��X������.Name = "btn�Ǘ��X������";
            this.btn�Ǘ��X������.Size = new System.Drawing.Size(48, 22);
            this.btn�Ǘ��X������.TabIndex = 1;
            this.btn�Ǘ��X������.TabStop = false;
            this.btn�Ǘ��X������.Text = "����";
            this.btn�Ǘ��X������.UseVisualStyleBackColor = false;
            this.btn�Ǘ��X������.Click += new System.EventHandler(this.btn�Ǘ��X������_Click);
            // 
            // lab�L���R�[�h
            // 
            this.lab�L���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�L���R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�L���R�[�h.Location = new System.Drawing.Point(8, 7);
            this.lab�L���R�[�h.Name = "lab�L���R�[�h";
            this.lab�L���R�[�h.Size = new System.Drawing.Size(110, 17);
            this.lab�L���R�[�h.TabIndex = 6;
            this.lab�L���R�[�h.Text = "�Ǘ��X���R�[�h";
            // 
            // tex�Ǘ��X���R�[�h
            // 
            this.tex�Ǘ��X���R�[�h.BackColor = System.Drawing.SystemColors.Window;
            this.tex�Ǘ��X���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�Ǘ��X���R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�Ǘ��X���R�[�h.Location = new System.Drawing.Point(128, 4);
            this.tex�Ǘ��X���R�[�h.MaxLength = 4;
            this.tex�Ǘ��X���R�[�h.Name = "tex�Ǘ��X���R�[�h";
            this.tex�Ǘ��X���R�[�h.Size = new System.Drawing.Size(42, 23);
            this.tex�Ǘ��X���R�[�h.TabIndex = 0;
            this.tex�Ǘ��X���R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�Ǘ��X���R�[�h_KeyDown);
            this.tex�Ǘ��X���R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�Ǘ��X���R�[�h_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleGreen;
            this.panel6.Controls.Add(this.tex�F�ؗ��p�Җ�);
            this.panel6.Controls.Add(this.lab�F�ؗ��p�Җ�);
            this.panel6.Controls.Add(this.lab�F�؉����);
            this.panel6.Controls.Add(this.tex�F�؉����);
            this.panel6.Location = new System.Drawing.Point(0, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(810, 26);
            this.panel6.TabIndex = 12;
            // 
            // tex�F�ؗ��p�Җ�
            // 
            this.tex�F�ؗ��p�Җ�.BackColor = System.Drawing.Color.PaleGreen;
            this.tex�F�ؗ��p�Җ�.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex�F�ؗ��p�Җ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�F�ؗ��p�Җ�.ForeColor = System.Drawing.Color.Green;
            this.tex�F�ؗ��p�Җ�.Location = new System.Drawing.Point(622, 5);
            this.tex�F�ؗ��p�Җ�.Name = "tex�F�ؗ��p�Җ�";
            this.tex�F�ؗ��p�Җ�.ReadOnly = true;
            this.tex�F�ؗ��p�Җ�.Size = new System.Drawing.Size(162, 16);
            this.tex�F�ؗ��p�Җ�.TabIndex = 3;
            this.tex�F�ؗ��p�Җ�.TabStop = false;
            this.tex�F�ؗ��p�Җ�.Visible = false;
            // 
            // lab�F�ؗ��p�Җ�
            // 
            this.lab�F�ؗ��p�Җ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�F�ؗ��p�Җ�.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�F�ؗ��p�Җ�.Location = new System.Drawing.Point(564, 7);
            this.lab�F�ؗ��p�Җ�.Name = "lab�F�ؗ��p�Җ�";
            this.lab�F�ؗ��p�Җ�.Size = new System.Drawing.Size(54, 14);
            this.lab�F�ؗ��p�Җ�.TabIndex = 4;
            this.lab�F�ؗ��p�Җ�.Text = "���[�U�[";
            this.lab�F�ؗ��p�Җ�.Visible = false;
            // 
            // lab�F�؉����
            // 
            this.lab�F�؉����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�F�؉����.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�F�؉����.Location = new System.Drawing.Point(12, 7);
            this.lab�F�؉����.Name = "lab�F�؉����";
            this.lab�F�؉����.Size = new System.Drawing.Size(52, 14);
            this.lab�F�؉����.TabIndex = 1;
            this.lab�F�؉����.Text = "���q�l��";
            // 
            // tex�F�؉����
            // 
            this.tex�F�؉����.BackColor = System.Drawing.Color.PaleGreen;
            this.tex�F�؉����.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex�F�؉����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�F�؉����.ForeColor = System.Drawing.Color.Green;
            this.tex�F�؉����.Location = new System.Drawing.Point(68, 5);
            this.tex�F�؉����.Name = "tex�F�؉����";
            this.tex�F�؉����.ReadOnly = true;
            this.tex�F�؉����.Size = new System.Drawing.Size(328, 16);
            this.tex�F�؉����.TabIndex = 2;
            this.tex�F�؉����.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab����);
            this.panel7.Controls.Add(this.lab������^�C�g��);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(792, 26);
            this.panel7.TabIndex = 13;
            // 
            // lab����
            // 
            this.lab����.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab����.ForeColor = System.Drawing.Color.White;
            this.lab����.Location = new System.Drawing.Point(674, 8);
            this.lab����.Name = "lab����";
            this.lab����.Size = new System.Drawing.Size(112, 14);
            this.lab����.TabIndex = 1;
            this.lab����.Text = "2005/xx/xx 12:00:00";
            // 
            // lab������^�C�g��
            // 
            this.lab������^�C�g��.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab������^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab������^�C�g��.ForeColor = System.Drawing.Color.White;
            this.lab������^�C�g��.Location = new System.Drawing.Point(12, 2);
            this.lab������^�C�g��.Name = "lab������^�C�g��";
            this.lab������^�C�g��.Size = new System.Drawing.Size(264, 24);
            this.lab������^�C�g��.TabIndex = 0;
            this.lab������^�C�g��.Text = "�������񃁃��e�i���X";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PaleGreen;
            this.panel8.Controls.Add(this.tex���b�Z�[�W);
            this.panel8.Controls.Add(this.btn����);
            this.panel8.Location = new System.Drawing.Point(0, 516);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(792, 58);
            this.panel8.TabIndex = 2;
            // 
            // tex���b�Z�[�W
            // 
            this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
            this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
            this.tex���b�Z�[�W.Location = new System.Drawing.Point(414, 4);
            this.tex���b�Z�[�W.Multiline = true;
            this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
            this.tex���b�Z�[�W.ReadOnly = true;
            this.tex���b�Z�[�W.Size = new System.Drawing.Size(376, 50);
            this.tex���b�Z�[�W.TabIndex = 1;
            this.tex���b�Z�[�W.TabStop = false;
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
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(43, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnl������);
            this.groupBox2.Location = new System.Drawing.Point(21, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 374);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ������}�X�^
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(792, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 607);
            this.Name = "������}�X�^";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 �������񃁃��e�i���X";
            this.Closed += new System.EventHandler(this.������}�X�^_Closed);
            this.Load += new System.EventHandler(this.������}�X�^_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On�G���^�[�ړ�);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On�G���^�[�L�����Z��);
            this.pnl������.ResumeLayout(false);
            this.pnl������.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT������)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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

		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>
		private void ������}�X�^_Load(object sender, System.EventArgs e)
		{
			tex�F�؉����.Text = gs�����;
			tex�F�ؗ��p�Җ�.Text = gs���p�Җ�;

			�������[�h();
			
			// �����̏����ݒ�
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;

			// �����惊�X�g�̏����ݒ�
			axGT������.Cols = 7;
			axGT������.Rows = 6;
			axGT������.ColSep = "|";
			axGT������.CaretRow = 1;
			axGT������.CaretCol = 2;
			axGT������.NoBeep = true;			

// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//			axGT������.set_RowsText(0, "|�X�֔ԍ�|���Ӑ�R�[�h|���ۃR�[�h|���ۖ�|���q�l�R�[�h|���q�l��|�X�V����|");
//			axGT������.ColsWidth = "0|0|6|5|10|6|19.5|0|";
//			axGT������.ColsAlignHorz = "1|1|1|1|0|1|0|0|";
			axGT������.set_RowsText(0, "|�X�֔ԍ�|���q�l�R�[�h|���q�l��|���Ӑ�R�[�h|���ۃR�[�h|���ۖ�|�X�V����|");
			axGT������.ColsWidth = "0|0|6|14.5|6|5|15|0|";
			axGT������.ColsAlignHorz = "1|1|1|0|1|1|0|0|";
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
            
			axGT������.set_CelForeColor(axGT������.CaretRow,0,0x98FB98);  //BGR
			axGT������.set_CelBackColor(axGT������.CaretRow,0,0x006000);

			if(gs�X���R�[�h.Trim().Length != 0)
			{
				tex�Ǘ��X���R�[�h.Text = gs�X���R�[�h.Trim();
				tex�Ǘ��X���R�[�h.Enabled = false;
				btn�Ǘ��X������.Visible = false;
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				btn��������s.Visible = false;
//				s�Ǘ��X���R�[�h   =  tex�Ǘ��X���R�[�h.Text;
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				if(������ꗗ����())
//				{
//					������o�^���[�h();
//					pnl������.Enabled = true;
//					axGT������.CaretRow = 1;
//					axGT������_CurPlaceChanged(null,null);
//					tex�X�֔ԍ��P.Focus();
//				}
//				else
//				{
//					�r�[�v��();
//					tex�Ǘ��X���R�[�h.Focus();
//					�������[�h();
//					axGT������.Clear();
//					tex�Ǘ��X����.Text = "";
//					pnl������.Enabled = false;
//				}
				�Ǘ��X������();
				�������[�h�P();
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			}
			else
			{
// ADD 2008.05.02 ���s�j���� �Ǘ��X���̐���̏C�� START
				tex�Ǘ��X���R�[�h.Text    = "";
				tex�Ǘ��X���R�[�h.Enabled = true;
				btn�Ǘ��X������.Visible   = true;
// ADD 2008.05.02 ���s�j���� �Ǘ��X���̐���̏C�� END
				axGT������.Clear();
			}
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//			�����\��();
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
		}

// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
		private void �����\��()
		{
			tex�����.Text = "������S�T�U�V�W�X�O�P�Q�R�S�T�U�V�W�X�O";
			tex�X�֔ԍ��X��.Text = "�X�����S";
			tex���吔.Text = "";
		}

		private void �������[�h�P()
		{
			������o�^���[�h();
			pnl������.Enabled = true;

			tex����R�[�h.Enabled = true;
			btn�������.Enabled = true;
			btn������s.Enabled = true;
// MOD 2009.05.28 ���s�j���� �o�׎��шꗗ�^����\���Ή� START
			cb�o�׎��шꗗ�^����\��.Checked = false;
			btn����X�V.Enabled = false;
// MOD 2009.05.28 ���s�j���� �o�׎��шꗗ�^����\���Ή� END

			axGT������.Clear();
			axGT������.CaretRow = 1;
			axGT������_CurPlaceChanged(null,null);
			axGT������.Enabled = false;
			tex���Ӑ�R�[�h.Enabled = false;
			tex���Ӑ敔�ۃR�[�h.Enabled = false;
			tex���Ӑ敔�ۖ�.Enabled = false;
			tex�X�֔ԍ��P.Enabled = false;
			tex�X�֔ԍ��Q.Enabled = false;
// MOD 2007.01.22 ���s�j���� ��ʏC�� START
//			btn�Ǘ��X������.Enabled = false;
			btn�Z������.Enabled = false;
// MOD 2007.01.22 ���s�j���� ��ʏC�� END

			btn������o�^.Text = "�o�^";
			btn������폜.Enabled = false;
// ADD 2007.01.22 ���s�j���� ��ʏC�� START
			btn������o�^.Enabled = false;
			btn��������.Enabled = false;
// ADD 2007.01.22 ���s�j���� ��ʏC�� END

			tex����R�[�h.Text = " ";
// ADD 2007.01.22 ���s�j���� ��ʏC�� START
			tex�����.Text = "";
// ADD 2007.01.22 ���s�j���� ��ʏC�� END
			tex����R�[�h.Focus();
		}
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END

		private void �������[�h()
		{
			������o�^���[�h();
			pnl������.Enabled = false;
			tex�Ǘ��X���R�[�h.Focus();
		}

		private void ������o�^���[�h()
		{
			tex���Ӑ�R�[�h.Enabled = true;
			tex���Ӑ敔�ۃR�[�h.Enabled = true;
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
			tex���Ӑ敔�ۖ�.Enabled = true;
			tex�X�֔ԍ��P.Enabled = true;
			tex�X�֔ԍ��Q.Enabled = true;
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
// ADD 2007.01.22 ���s�j���� ��ʏC�� START
			btn�Z������.Enabled = true;
// ADD 2007.01.22 ���s�j���� ��ʏC�� END
			btn������o�^.Text = "�o�^";
			btn������폜.Enabled = false;
// ADD 2007.01.22 ���s�j���� ��ʏC�� START
			btn������o�^.Enabled = true;
			btn��������.Enabled = true;
// ADD 2007.01.22 ���s�j���� ��ʏC�� END

			tex�X�֔ԍ��P.Text = "";
			tex�X�֔ԍ��Q.Text = "";
			tex�X�֔ԍ��X��.Text = "";
			tex���Ӑ�R�[�h.Text = "";
			tex���Ӑ敔�ۃR�[�h.Text = "";
			tex���Ӑ敔�ۖ�.Text = "";
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//			tex����R�[�h.Text = "";
//			tex�����.Text = "";
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			tex���吔.Text = "";
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
			s�X�V���� = "";
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
		}

		private void ������X�V���[�h()
		{
			tex���Ӑ�R�[�h.Enabled = false;
			tex���Ӑ敔�ۃR�[�h.Enabled = false;
			btn������o�^.Text = "�X�V";
			btn������폜.Enabled = true;
// ADD 2007.01.22 ���s�j���� ��ʏC�� START
			btn������o�^.Enabled = true;
			btn��������.Enabled = true;
// ADD 2007.01.22 ���s�j���� ��ʏC�� END
		}

		private void tex�Ǘ��X���R�[�h_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				axGT������.CaretRow = 1;
				axGT������_CurPlaceChanged(null,null);

				tex���b�Z�[�W.Text = "";
				tex�Ǘ��X���R�[�h.Text = tex�Ǘ��X���R�[�h.Text.Trim();
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				if(tex�Ǘ��X���R�[�h.Text.Length == 0)
//					btn�Ǘ��X������_Click(null,null);
//				else
//					btn��������s_Click(sender,e);
				if(tex�Ǘ��X���R�[�h.Text.Length == 0){
					btn�Ǘ��X������_Click(null,null);
				}else{
					if(�Ǘ��X������()){
						tex�Ǘ��X���R�[�h.Enabled = false;
						btn�Ǘ��X������.Enabled = false;
						�������[�h�P();
					}else{
						tex�Ǘ��X���R�[�h.Focus();
					}
				}
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			}
		}

		private void tex�Ǘ��X���R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�Ǘ��X������.Focus();
				btn�Ǘ��X������_Click(sender,e);
				e.Handled = true;
			}				
		}

		private void btn�Ǘ��X������_Click(object sender, System.EventArgs e)
		{
			tex�Ǘ��X���R�[�h.Text = tex�Ǘ��X���R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�Ǘ��X���R�[�h, "�Ǘ��X���R�[�h")) return;

			// ������ʂ��E���ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			�X������ ��� = new �X������();
//			���.Left = this.Left + 404;
//			���.Top = this.Top;

			// �R�[�h�̏����\��
//			���.s�X���R�[�h = tex�Ǘ��X���R�[�h.Text;
//			���.ShowDialog();
			if (g�X������ == null)	 g�X������ = new �X������();
			g�X������.Left = this.Left + 404;
			g�X������.Top = this.Top;

			// �R�[�h�̏����\��
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� START
//			g�X������.s�X���R�[�h = tex�Ǘ��X���R�[�h.Text;
			g�X������.s�X���R�[�h = "";
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� END
			g�X������.s�X���� = "";
			g�X������.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

////		tex�Ǘ��X���R�[�h.Text = ���.s�X���R�[�h;
//			tex�Ǘ��X���R�[�h.Text = g�X������.s�X���R�[�h;
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
//			if(tex�Ǘ��X���R�[�h.Text.Length > 0)
			if(g�X������.s�X���R�[�h.Length > 0)
			{
				tex�Ǘ��X���R�[�h.Text = g�X������.s�X���R�[�h;
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				tex�Ǘ��X���R�[�h.Focus();
//				btn��������s_Click(sender, e);
				tex�Ǘ��X����.Text = g�X������.s�X����;

				tex�Ǘ��X���R�[�h.Enabled = false;
				btn�Ǘ��X������.Enabled = false;
				�������[�h�P();
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			}
			else
			{
				tex�Ǘ��X���R�[�h.Focus();
			}
		}

		private bool �Ǘ��X������()
		{
			tex�Ǘ��X���R�[�h.Text = tex�Ǘ��X���R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�Ǘ��X���R�[�h, "�Ǘ��X���R�[�h")) return false;

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�Ǘ��X���R�[�h.Text;
				string[] sList = sv_maintenance.Sel_Shop(gsa���[�U, sKey);
				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex�Ǘ��X����.Text = sList[1];
				}
				else
				{
					if(sList[0].Equals("�Y���f�[�^������܂���"))
						tex���b�Z�[�W.Text = "";
					else
						tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					ret =  false;
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
				ret = false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}

// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//		private void btn��������s_Click(object sender, System.EventArgs e)
//		{
//			tex���b�Z�[�W.Text = "";
//
//			tex�Ǘ��X���R�[�h.Text = tex�Ǘ��X���R�[�h.Text.Trim();
//			if(!�K�{�`�F�b�N(tex�Ǘ��X���R�[�h, "�Ǘ��X���R�[�h")) return;
//			if(!���p�`�F�b�N(tex�Ǘ��X���R�[�h, "�Ǘ��X���R�[�h")) return;
//
//			s�Ǘ��X���R�[�h   =  tex�Ǘ��X���R�[�h.Text;
//			if(������ꗗ����())
//			{
//				������o�^���[�h();
//				pnl������.Enabled = true;
//				axGT������.CaretRow = 1;
//				axGT������_CurPlaceChanged(null,null);
//				tex�X�֔ԍ��P.Focus();
//			}
//			else
//			{
//				�r�[�v��();
//				tex�Ǘ��X���R�[�h.Focus();
//				�������[�h();
//				axGT������.Clear();
//				tex�Ǘ��X����.Text = "";
//				pnl������.Enabled = false;
//			}
//		}
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END

		private bool ������ꗗ����()
		{
			axGT������.Clear();
			axGT������.Rows = 6;
			axGT������.CaretRow = 1;
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
			axGT������_CurPlaceChanged(null,null);
			axGT������.ColsWidth = "0|0|6|14.5|6|5|15|0|";
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END

			bool bRet = false;
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//			axGT������.Clear();
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				//�Ǘ��X���`�F�b�N
//				if (!�Ǘ��X������())
//				{
//					MessageBox.Show("�Ǘ��X��(" + tex�Ǘ��X���R�[�h.Text + ")�����݂��܂���" ,"���̓`�F�b�N",MessageBoxButtons.OK);
//					tex�Ǘ��X���R�[�h.Focus();
//					return false;
//				}
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
				String[] sList;
				tex����R�[�h.Text = tex����R�[�h.Text.Trim();
				if (tex����R�[�h.Text == "")
				{
					String[] sKey1 = new string[1];
					sKey1[0] = tex�Ǘ��X���R�[�h.Text.Trim();
					string[] sList1 = sv_oji.Sel_Member(gsa���[�U, sKey1);

					if (sList1[0].Equals("����I��"))
					{
						if ((sList1[4] != "3") && (sList1[4] != "4"))
						{
							sList = sv_maintenance.Get_Claim2(gsa���[�U, tex�Ǘ��X���R�[�h.Text, tex����R�[�h.Text);
						}
						else
						{
							sList = sv_oji.Get_Claim2(gsa���[�U, tex�Ǘ��X���R�[�h.Text, tex����R�[�h.Text);
						}
					}
					else
					{
						sList = sv_maintenance.Get_Claim2(gsa���[�U, tex�Ǘ��X���R�[�h.Text, tex����R�[�h.Text);
					}
				}
				else if (tex����R�[�h.Text.Substring(0,1) != "J")
				{
//					// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//					//				String[] sList = sv_maintenance.Get_Claim(gsa���[�U, tex�Ǘ��X���R�[�h.Text.Trim());
//					String[] sList = sv_maintenance.Get_Claim2(gsa���[�U, tex�Ǘ��X���R�[�h.Text, tex����R�[�h.Text);
//					// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
					sList = sv_maintenance.Get_Claim2(gsa���[�U, tex�Ǘ��X���R�[�h.Text, tex����R�[�h.Text);
				}
				else
				{
					sList = sv_oji.Get_Claim2(gsa���[�U, tex�Ǘ��X���R�[�h.Text, tex����R�[�h.Text);
				}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
				if(sList[0].Equals("����I��") || sList[0].Equals("�Y���f�[�^������܂���"))
					{
						tex���b�Z�[�W.Text = "";
						if (axGT������.Rows < sList.Length - 1)
						{
							axGT������.Rows = (short)(sList.Length - 1);
						}
						for(short nCnt = 1; nCnt < sList.Length; nCnt++)
						{
							axGT������.set_RowsText(nCnt, sList[nCnt]);
						}
						bRet = true;
					}
					else
					{
						tex���b�Z�[�W.Text = sList[0];
					}

			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return bRet;
		}

		private void axGT������_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//			string s���Ӑ� = axGT������.get_CelText(axGT������.CaretRow,2);
			string s���Ӑ� = axGT������.get_CelText(axGT������.CaretRow,4);
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			if(!s���Ӑ�.Equals(""))
			{
				tex�X�֔ԍ��P.Text       = axGT������.get_CelText(axGT������.CaretRow,1).PadRight(7).Substring(0, 3);
				tex�X�֔ԍ��Q.Text       = axGT������.get_CelText(axGT������.CaretRow,1).PadRight(7).Substring(3, 4);
				tex�X�֔ԍ��X��.Text     = tex�Ǘ��X����.Text;
				tex���Ӑ�R�[�h.Text     = s���Ӑ�;
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				tex���Ӑ敔�ۃR�[�h.Text = axGT������.get_CelText(axGT������.CaretRow,3);
//				tex���Ӑ敔�ۖ�.Text     = axGT������.get_CelText(axGT������.CaretRow,4);
//				tex����R�[�h.Text       = axGT������.get_CelText(axGT������.CaretRow,5);
//				tex�����.Text           = axGT������.get_CelText(axGT������.CaretRow,6);
				tex���Ӑ敔�ۃR�[�h.Text = axGT������.get_CelText(axGT������.CaretRow,5);
				tex���Ӑ敔�ۖ�.Text     = axGT������.get_CelText(axGT������.CaretRow,6);
				tex����R�[�h.Text       = axGT������.get_CelText(axGT������.CaretRow,2);
				tex�����.Text           = axGT������.get_CelText(axGT������.CaretRow,3);
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
				s�X�֔ԍ�                = axGT������.get_CelText(axGT������.CaretRow,1);
				s�X�V����                = axGT������.get_CelText(axGT������.CaretRow,7);
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� START
				s����b�c                = axGT������.get_CelText(axGT������.CaretRow,2);
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� END

				//�Z�N�V�������̎擾
				this.Cursor = System.Windows.Forms.Cursors.AppStarting;
				string[] sSectionKey = new string[2];
				sSectionKey[0] = tex����R�[�h.Text;
				sSectionKey[1] = tex�X�֔ԍ��P.Text.Trim() + tex�X�֔ԍ��Q.Text.Trim();
				string[] sSectionList = sv_maintenance.Sel_SectionCount(gsa���[�U, sSectionKey);
				if (sSectionList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex���吔.Text = sSectionList[1];
					������X�V���[�h();
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//					tex�X�֔ԍ��P.Focus();
					tex���Ӑ敔�ۖ�.Focus();
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
				}
				else
				{
					tex���b�Z�[�W.Text = sSectionList[0];
					�r�[�v��();
					�������[�h();
				}
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}

		private void axGT������_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				string s���Ӑ� = axGT������.get_CelText(axGT������.CaretRow,2);
				string s���Ӑ� = axGT������.get_CelText(axGT������.CaretRow,4);
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
				if(!s���Ӑ�.Equals(""))
				{
					tex�X�֔ԍ��P.Text       = axGT������.get_CelText(axGT������.CaretRow,1).PadRight(7).Substring(0, 3);
					tex�X�֔ԍ��Q.Text       = axGT������.get_CelText(axGT������.CaretRow,1).PadRight(7).Substring(3, 4);
					tex�X�֔ԍ��X��.Text     = tex�Ǘ��X����.Text;
					tex���Ӑ�R�[�h.Text     = s���Ӑ�;
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//					tex���Ӑ敔�ۃR�[�h.Text = axGT������.get_CelText(axGT������.CaretRow,3);
//					tex���Ӑ敔�ۖ�.Text     = axGT������.get_CelText(axGT������.CaretRow,4);
//					tex����R�[�h.Text       = axGT������.get_CelText(axGT������.CaretRow,5);
//					tex�����.Text           = axGT������.get_CelText(axGT������.CaretRow,6);
					tex���Ӑ敔�ۃR�[�h.Text = axGT������.get_CelText(axGT������.CaretRow,5);
					tex���Ӑ敔�ۖ�.Text     = axGT������.get_CelText(axGT������.CaretRow,6);
					tex����R�[�h.Text       = axGT������.get_CelText(axGT������.CaretRow,2);
					tex�����.Text           = axGT������.get_CelText(axGT������.CaretRow,3);
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
					s�X�֔ԍ�                = axGT������.get_CelText(axGT������.CaretRow,1);
					s�X�V����                = axGT������.get_CelText(axGT������.CaretRow,7);
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� START
					s����b�c                = axGT������.get_CelText(axGT������.CaretRow,2);
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� END

					//�Z�N�V�������̎擾
					this.Cursor = System.Windows.Forms.Cursors.AppStarting;
					string[] sSectionKey = new string[2];
					sSectionKey[0] = tex����R�[�h.Text;
					sSectionKey[1] = tex�X�֔ԍ��P.Text.Trim() + tex�X�֔ԍ��Q.Text.Trim();
					string[] sSectionList = sv_maintenance.Sel_SectionCount(gsa���[�U, sSectionKey);
					if (sSectionList[0].Equals("����I��"))
					{
						tex���b�Z�[�W.Text = "";
						tex���吔.Text = sSectionList[1];
						������X�V���[�h();
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//						tex�X�֔ԍ��P.Focus();
						tex���Ӑ敔�ۖ�.Focus();
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
					}
					else
					{
						tex���b�Z�[�W.Text = sSectionList[0];
						�r�[�v��();
						�������[�h();
					}
					this.Cursor = System.Windows.Forms.Cursors.Default;
				}
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT������, true, true, true, true);
			}
		}
		
		private void tex�X�֔ԍ��Q_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				if(tex�X�֔ԍ��P.Text.Length == 3 && tex�X�֔ԍ��Q.Text.Length == 4)
					�X�֔ԍ�����();
				else
					�X�֔ԍ��ꗗ();
			}
// ADD 2006.11.09 ���s�j�R�{ ���������ʂ���̕��A�ɂăZ�N�V��������\������l�ɏC�� START
			�Z�N�V�������擾();
// ADD 2006.11.09 ���s�j�R�{ ���������ʂ���̕��A�ɂăZ�N�V��������\������l�ɏC�� END
		}

		private void tex�X�֔ԍ��Q_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�Z������.Focus();
				�X�֔ԍ��ꗗ();
				e.Handled = true;
			}
		}

		private void btn�Z������_Click(object sender, System.EventArgs e)
		{
			�X�֔ԍ��ꗗ();
// ADD 2006.11.09 ���s�j�R�{ ���������ʂ���̕��A�ɂăZ�N�V��������\������l�ɏC�� START
			�Z�N�V�������擾();
// ADD 2006.11.09 ���s�j�R�{ ���������ʂ���̕��A�ɂăZ�N�V��������\������l�ɏC�� END
		}

		private void �X�֔ԍ��ꗗ()
		{

			tex�X�֔ԍ��P.Text = tex�X�֔ԍ��P.Text.Trim();
			tex�X�֔ԍ��Q.Text = tex�X�֔ԍ��Q.Text.Trim();
			if(!���p�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return;
			if(!���p�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return;

			// ������ʂ��E���ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			�Z������ ��� = new �Z������();
//			���.Left = this.Left + 404;
//			���.Top = this.Top;

			// �R�[�h�̏����\��
//			���.s�X�֔ԍ��P = tex�X�֔ԍ��P.Text;
//			���.s�X�֔ԍ��Q = tex�X�֔ԍ��Q.Text;
//			���.s�Ǘ��X��   = "";
//			���.ShowDialog();
			if (g�Z������ == null)	 g�Z������ = new �Z������();
			g�Z������.Left = this.Left + 404;
			g�Z������.Top = this.Top;
			// �R�[�h�̏����\��
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� START
//			g�Z������.s�X�֔ԍ��P = tex�X�֔ԍ��P.Text;
//			g�Z������.s�X�֔ԍ��Q = tex�X�֔ԍ��Q.Text;
			g�Z������.s�X�֔ԍ��P = "";
			g�Z������.s�X�֔ԍ��Q = "";
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� END
			g�Z������.s�Ǘ��X��   = "";
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
			g�Z������.s���q�l�b�c = tex����R�[�h.Text.Trim();
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
			g�Z������.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (���.s�X�֔ԍ��P.Trim().Length != 0)
			if (g�Z������.s�X�֔ԍ��P.Trim().Length != 0)
			{
//				tex�X�֔ԍ��P.Text = ���.s�X�֔ԍ��P.Trim();
//				tex�X�֔ԍ��Q.Text = ���.s�X�֔ԍ��Q.Trim();
//				tex�X�֔ԍ��X��.Text = ���.s�Ǘ��X��.Trim();
				tex�X�֔ԍ��P.Text = g�Z������.s�X�֔ԍ��P.Trim();
				tex�X�֔ԍ��Q.Text = g�Z������.s�X�֔ԍ��Q.Trim();
				tex�X�֔ԍ��X��.Text = g�Z������.s�Ǘ��X��.Trim();
				this.SelectNextControl(btn�Z������, true, true, true, true);
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
			}
			else
			{
				tex�X�֔ԍ��P.Focus();
			}
		}

		private bool �X�֔ԍ�����()
		{
			tex�X�֔ԍ��P.Text = tex�X�֔ԍ��P.Text.Trim();
			tex�X�֔ԍ��Q.Text = tex�X�֔ԍ��Q.Text.Trim();
			if (!�K�{�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return false;
			if (!���p�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return false;
			if (!�K�{�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return false;
			if (!���p�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return false;
			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool bRet = false;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�X�֔ԍ��P.Text + tex�X�֔ԍ��Q.Text;
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//				string[] sList = sv_maintenance.Sel_Postcode(gsa���[�U, sKey);
				String[] sList;
				tex����R�[�h.Text = tex����R�[�h.Text.Trim();
				if ((tex����R�[�h.Text == "") || (tex����R�[�h.Text.Substring(0,1) != "J"))
				{
					sList = sv_maintenance.Sel_Postcode(gsa���[�U, sKey);
				}
				else
				{
					sList = sv_oji.Sel_Postcode(gsa���[�U, sKey);
				}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
				if (sList[0].Equals("����I��"))
				{
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					if((tex����R�[�h.Text != "") && (tex����R�[�h.Text.Substring(0,1) == "J"))
					{
//MOD 2016.03.16 BEVAS�j���{ ���q�^���ŃO���[�o���^�p�Ή� START
						//�I�������X�֔ԍ����O���[�o����p�X�֔ԍ��̏ꍇ�́A���L�������X�L�b�v����
						if(sList[3].Trim() != "047")
						{
//MOD 2016.03.16 BEVAS�j���{ ���q�^���ŃO���[�o���^�p�Ή� END
							String[] sKey1 = new string[1];
							sKey1[0] = sList[3].Trim();
							string[] sList1 = sv_oji.Sel_Member(gsa���[�U, sKey1);

							if (sList1[0].Equals("����I��"))
							{
								if ((sList1[4] != "3") && (sList1[4] != "4"))
								{
									tex���b�Z�[�W.Text = "�w�肵���Z���́A�Z�N�V�����o�^�s�\�G���A�ł�";
									tex�X�֔ԍ��X��.Text = "";
									�r�[�v��();
									this.Cursor = System.Windows.Forms.Cursors.Default;
									return false;
								}
							}
							else
							{
								tex���b�Z�[�W.Text = sList1[0];
								tex�X�֔ԍ��X��.Text = "";
								�r�[�v��();
								this.Cursor = System.Windows.Forms.Cursors.Default;
								return false;
							}
//MOD 2016.03.16 BEVAS�j���{ ���q�^���ŃO���[�o���^�p�Ή� START
						}
//MOD 2016.03.16 BEVAS�j���{ ���q�^���ŃO���[�o���^�p�Ή� END
					}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
					tex���b�Z�[�W.Text = "";
					tex�X�֔ԍ��X��.Text = sList[1];
					bRet = true;
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					tex�X�֔ԍ��X��.Text = "";
					tex�X�֔ԍ��P.Focus();
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return bRet;
		}

		private void tex����R�[�h_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				tex����R�[�h.Text = tex����R�[�h.Text.Trim();
				if(tex����R�[�h.Text.Length == 0)
					btn�������_Click(sender,e);
				else
				{
					tex����R�[�h.Text = tex����R�[�h.Text.Trim();
//					if(!���p�`�F�b�N(tex����R�[�h, "����R�[�h")) return;
					if(!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
					���������();
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
					btn������s.Focus();
//					btn������s_Click(sender,e);
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
				}
			}
		}

		private void tex����R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�������.Focus();
				btn�������_Click(sender, e);
				e.Handled = true;
			}				
		}

		private bool ���������()
		{
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
//			if (!�K�{�`�F�b�N(tex����R�[�h, "����R�[�h")) return false;
//			if (!���p�`�F�b�N(tex����R�[�h, "����R�[�h")) return false;
			tex�����.Text = "";
			tex���吔.Text = "";
			if (tex����R�[�h.Text.Length == 0) return true;
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool bRet = false;
			try
			{
				string[] sKey = new string[2];
				String[] sList;
				sKey[0] = tex����R�[�h.Text;
// ADD 2006.11.08 ���s�j�R�{ �X�����O�C�����̐�����o�^����ꍇ�̓X���R�[�h�`�F�b�N�ǉ� START
				sKey[1] = gs�X���R�[�h.Trim();
				if(gs�X���R�[�h.Trim().Length != 0)
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					if ((tex����R�[�h.Text == "") || (tex����R�[�h.Text.Substring(0,1) != "J"))
					{
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
						sList = sv_maintenance.Sel_MemberTn(gsa���[�U, sKey);
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					}
					else
					{
						sList = sv_oji.Sel_MemberTn(gsa���[�U, sKey);
					}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
						// ADD 2006.11.08 ���s�j�R�{ �X�����O�C�����̐�����o�^����ꍇ�̓X���R�[�h�`�F�b�N�ǉ� END
						sList = sv_maintenance.Sel_Member(gsa���[�U, sKey);
				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex�����.Text = sList[2];
// MOD 2009.05.28 ���s�j���� �o�׎��шꗗ�^����\���Ή� START
					s����X�V���� = sList[6];
					if(sList.Length < 8){
						cb�o�׎��шꗗ�^����\��.Enabled = false;
						btn����X�V.Enabled = false;
					}else{
						if(sList[7].Equals("1")){
							cb�o�׎��шꗗ�^����\��.Checked = true;
						}else{
							cb�o�׎��шꗗ�^����\��.Checked = false;
						}
						btn����X�V.Enabled = true;
					}
// MOD 2009.05.28 ���s�j���� �o�׎��шꗗ�^����\���Ή� END
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//					string[] sSectionKey = new string[2];
//					sSectionKey[0] = tex����R�[�h.Text;
//					sSectionKey[1] = tex�X�֔ԍ��P.Text.Trim() + tex�X�֔ԍ��Q.Text.Trim();
//					string[] sSectionList = sv_maintenance.Sel_SectionCount(gsa���[�U, sSectionKey);
//					if (sSectionList[0].Equals("����I��"))
//					{
//						tex���b�Z�[�W.Text = "";
//						tex���吔.Text = sSectionList[1];
//						bRet = true;
//					}
//					else
//					{
//						tex���b�Z�[�W.Text = sSectionList[0];
//						�r�[�v��();
//						tex�����.Text = "";
//						tex���吔.Text = "";
//						tex����R�[�h.Focus();
//					}
					tex���吔.Text = "";
					bRet = true;
					�Z�N�V�������擾();
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					tex�����.Text = "";
					tex���吔.Text = "";
					tex����R�[�h.Focus();
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return bRet;
		}

		private void btn�������_Click(object sender, System.EventArgs e)
		{
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;

			// ������ʂ��E���ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			������� ��� = new �������();
//			���.Left = this.Left + 404;
//			���.Top = this.Top;
//
//			// �R�[�h�̏����\��
//			���.s����R�[�h = tex����R�[�h.Text;
//			���.ShowDialog();
			if (g������� == null)	 g������� = new �������();
			g�������.Left = this.Left + 404;
			g�������.Top = this.Top;
			// �R�[�h�̏����\��
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� START
//			g�������.s����R�[�h = tex����R�[�h.Text;
			g�������.s����R�[�h = "";
			g�������.s����� = "";
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� END
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
			g�������.s�X���R�[�h = tex�Ǘ��X���R�[�h.Text.Trim();
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			g�������.ShowDialog();
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
			g�������.s�X���R�[�h = "";
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (���.s����R�[�h.Trim().Length != 0)
			if (g�������.s����R�[�h.Trim().Length != 0)
			{
//				tex����R�[�h.Text = ���.s����R�[�h;
//				tex�����.Text     = ���.s�����;
				tex����R�[�h.Text = g�������.s����R�[�h;
				tex�����.Text     = g�������.s�����;
// ADD 2006.11.09 ���s�j�R�{ ���������ʂ���̕��A�ɂăZ�N�V��������\������l�ɏC�� START
				�Z�N�V�������擾();
// ADD 2006.11.09 ���s�j�R�{ ���������ʂ���̕��A�ɂăZ�N�V��������\������l�ɏC�� END
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				btn������o�^.Focus();
//// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
				btn������s.Focus();
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			}
			else
			{
				tex����R�[�h.Focus();
			}
		}

		private void btn������o�^_Click(object sender, System.EventArgs e)
		{
			int nRet;

			tex���Ӑ�R�[�h.Text     =  tex���Ӑ�R�[�h.Text.Trim();
			tex���Ӑ敔�ۃR�[�h.Text =  tex���Ӑ敔�ۃR�[�h.Text.Trim();
			tex���Ӑ敔�ۖ�.Text     =  tex���Ӑ敔�ۖ�.Text.Trim();
			tex����R�[�h.Text       =  tex����R�[�h.Text.Trim();

// ADD 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX START
			if(!�K�{�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
// ADD 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX END
			if(!�K�{�`�F�b�N(tex���Ӑ�R�[�h, "���Ӑ�R�[�h")) return;
			if (tex���Ӑ敔�ۃR�[�h.Text.Length == 0)
			{
				tex���Ӑ敔�ۃR�[�h.Text = " ";
			}
			if(!�K�{�`�F�b�N(tex���Ӑ敔�ۖ�, "���Ӑ敔�ۖ�")) return;
// DEL 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX START
//			if(!�K�{�`�F�b�N(tex����R�[�h, "����R�[�h")) return;
// DEL 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX END

// ADD 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX START
			if(!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
// ADD 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX END
			if(!���p�`�F�b�N(tex���Ӑ�R�[�h, "���Ӑ�R�[�h")) return;
			if(!���p�`�F�b�N(tex���Ӑ敔�ۃR�[�h, "���Ӑ敔�ۃR�[�h")) return;
// DEL 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX START
//			if(!���p�`�F�b�N(tex����R�[�h, "����R�[�h")) return;
// DEL 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX END
			if(!�S�p�`�F�b�N(tex���Ӑ敔�ۖ�, "���Ӑ敔�ۖ�")) return;

			//�X�֔ԍ��`�F�b�N
// MOD 2006.11.08 ���s�j�R�{ �X�����O�C�����̐�����o�^����ꍇ�̓X���R�[�h�`�F�b�N�ǉ� START
//			if (!�X�֔ԍ�����())
			if ((nRet = �X�֔ԍ��`�F�b�N()) != 0)
// MOD 2006.11.08 ���s�j�R�{ �X�����O�C�����̐�����o�^����ꍇ�̓X���R�[�h�`�F�b�N�ǉ� END
			{
// ADD 2006.11.08 ���s�j�R�{ �X�����O�C�����̐�����o�^����ꍇ�̓X���R�[�h�`�F�b�N�ǉ� START
// MOD 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				if(nRet != -1)
//					MessageBox.Show("���͂��ꂽ�X�֔ԍ��̓X���R�[�h���Ǘ��X���R�[�h�ƈ�v���Ă��܂���B","���̓`�F�b�N",MessageBoxButtons.OK);
//				else
//// ADD 2006.11.08 ���s�j�R�{ �X�����O�C�����̐�����o�^����ꍇ�̓X���R�[�h�`�F�b�N�ǉ� END
//					MessageBox.Show("�X�֔ԍ�(" + tex�X�֔ԍ��P.Text.Trim() + tex�X�֔ԍ��Q.Text.Trim() + ")�����݂��܂���" ,"���̓`�F�b�N",MessageBoxButtons.OK);
//				tex�X�֔ԍ��P.Focus();
				switch(nRet)
				{
				case -1:
					MessageBox.Show("�X�֔ԍ�(" + tex�X�֔ԍ��P.Text.Trim() + tex�X�֔ԍ��Q.Text.Trim() + ")�����݂��܂���",
									"���̓`�F�b�N",MessageBoxButtons.OK);
					tex�X�֔ԍ��P.Focus();
					break;
				case -2:
					MessageBox.Show("���͂��ꂽ�X�֔ԍ��̓X���R�[�h���Ǘ��X���R�[�h�ƈ�v���Ă��܂���B",
									"���̓`�F�b�N",MessageBoxButtons.OK);
					tex�X�֔ԍ��P.Focus();
					break;
				case -3:
					break;
				}
// MOD 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX END
				return;
			}

			//����`�F�b�N
			if (!���������())
			{
//				MessageBox.Show("���(" + tex����R�[�h.Text + ")�����݂��܂���" ,"���̓`�F�b�N",MessageBoxButtons.OK);
				MessageBox.Show("���q�l(" + tex����R�[�h.Text + ")�����݂��܂���" ,"���̓`�F�b�N",MessageBoxButtons.OK);
				tex����R�[�h.Focus();
				return;
			}

// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή� START
			if(tex����R�[�h.Text.Trim().Substring(0,2).ToUpper() == "FK")
			{
				/** �Г��`�[����̏ꍇ�A������o�^���ɂ͈ȉ��̏�����S�Ė������Ă��邱�� */
				//(1) �Ǘ��Ҍ����ȊO�ł́A�Г��`�[����̐�����o�^�������Ȃ�
				if(gs�Ǘ��ҋ敪 != "1")
				{
					MessageBox.Show("�Ǘ��҈ȊO�̌����ł́A�Г��`�[����̐�����͓o�^�ł��܂���",
									"���̓`�F�b�N",MessageBoxButtons.OK);
					tex����R�[�h.Focus();
					return;
				}
				//(2) �Г��`����̈��X�o�^���Ȃ���΃G���[�i���X�̓o�^�R���h���ׁj
				string[] sKey2  = new string[1];
				sKey2[0] = tex����R�[�h.Text.Trim();
				string[] sRet2 = sv_maintenance.Sel_HouseSlipMember(gsa���[�U, sKey2);
				if(!sRet2[0].Equals("����I��"))
				{
					MessageBox.Show("�Г��`�[����̏ꍇ�A���������o�^����O�ɎГ��`�[����̈��X�o�^���s���ĉ�����",
									"���̓`�F�b�N",MessageBoxButtons.OK);
					tex����R�[�h.Focus();
					return;
				}
				//(3) �Г��`�[����̏ꍇ�A������̗X�֔ԍ��͎Г��`�[��p�X�֔ԍ�(XXX-0044)�łȂ���΃G���[
				string s������X�֔ԍ� = tex�X�֔ԍ��P.Text.Trim() + tex�X�֔ԍ��Q.Text.Trim();
				if(!s������X�֔ԍ�.Equals(s�Г��`�[�p�X�֔ԍ�))
				{
					MessageBox.Show("�Г��`�[����̏ꍇ�A������̗X�֔ԍ��́u" + s�Г��`�[�p�X�֔ԍ��\���p + "�v���g�p���ĉ�����",
									"���̓`�F�b�N",MessageBoxButtons.OK);
					tex�X�֔ԍ��P.Focus();
					return;
				}
			}
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή� END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� START
//				string[] sKey  = new string[9];
				string[] sKey  = new string[10];
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� END
				sKey[0] = tex�X�֔ԍ��P.Text.Trim() + tex�X�֔ԍ��Q.Text.Trim();
				sKey[1] = tex���Ӑ�R�[�h.Text;
				sKey[2] = tex���Ӑ敔�ۃR�[�h.Text;
				sKey[3] = tex���Ӑ敔�ۖ�.Text;
				sKey[4] = tex����R�[�h.Text;
				sKey[5] = "������}";
				sKey[6] = gs���p�҃R�[�h;
				sKey[7] = s�X�֔ԍ�;
				sKey[8] = s�X�V����;
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� START
				sKey[9] = s����b�c;
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� END

				//������̒ǉ��X�V
				if (btn������o�^.Text.Equals("�o�^"))
				{
					//������̒ǉ�
					tex���b�Z�[�W.Text = "�o�^���D�D�D";

					string[] sList = sv_maintenance.Ins_Claim(gsa���[�U, sKey);

					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
						������ꗗ����();
						������o�^���[�h();
					}
					else
					{
						�r�[�v��();
					}
				}
				else
				{
					//������̍X�V
					tex���b�Z�[�W.Text = "�X�V���D�D�D";

					string[] sList = sv_maintenance.Upd_Claim(gsa���[�U, sKey);

					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
						������ꗗ����();
						������o�^���[�h();
					}
					else
					{
						�r�[�v��();
					}
				}
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				tex�X�֔ԍ��P.Focus();
				tex���Ӑ�R�[�h.Focus();
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn������폜_Click(object sender, System.EventArgs e)
		{
			//������̍폜
			tex���b�Z�[�W.Text = "�폜���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

// ADD 2008.11.20 ���s�j���� ���Ӑ敔�ۃR�[�h�̋󔒎��Ή� START
//			tex���Ӑ�R�[�h.Text     =  tex���Ӑ�R�[�h.Text.Trim();
//			tex���Ӑ敔�ۃR�[�h.Text =  tex���Ӑ敔�ۃR�[�h.Text.Trim();
//			if(!�K�{�`�F�b�N(tex���Ӑ�R�[�h, "���Ӑ�R�[�h")) return;
			if (tex���Ӑ敔�ۃR�[�h.Text.Length == 0)
			{
				tex���Ӑ敔�ۃR�[�h.Text = " ";
			}
//			if(!���p�`�F�b�N(tex���Ӑ�R�[�h, "���Ӑ�R�[�h")) return;
//			if(!���p�`�F�b�N(tex���Ӑ敔�ۃR�[�h, "���Ӑ敔�ۃR�[�h")) return;
// ADD 2008.11.20 ���s�j���� ���Ӑ敔�ۃR�[�h�̋󔒎��Ή� END

			try
			{
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� START
//				string[] sKey  = new string[6];
				string[] sKey  = new string[7];
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� END
				sKey[0] = s�X�֔ԍ�;
				sKey[1] = tex���Ӑ�R�[�h.Text;
				sKey[2] = tex���Ӑ敔�ۃR�[�h.Text;
				sKey[3] = "������}";
				sKey[4] = gs���p�҃R�[�h;
				sKey[5] = s�X�V����;
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� START
				sKey[6] = s����b�c;
// MOD 2011.03.09 ���s�j���� ������}�X�^�̎�L�[��[����b�c]��ǉ� END

				string[] sList = sv_maintenance.Del_Claim(gsa���[�U, sKey);

				tex���b�Z�[�W.Text = sList[0];
				if (sList[0].Equals("����I��"))
				{
					������ꗗ����();
					������o�^���[�h();
				}
				else
				{
					�r�[�v��();
				}
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				tex�X�֔ԍ��P.Focus();
				tex���Ӑ�R�[�h.Focus();
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn��������_Click(object sender, System.EventArgs e)
		{
// MOD 2007.01.22 ���s�j���� ��ʏC�� START
//			������o�^���[�h();
			�������[�h�P();
// MOD 2007.01.22 ���s�j���� ��ʏC�� END
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//			tex�X�֔ԍ��P.Focus();
			tex���b�Z�[�W.Text = "";

// DEL 2007.01.22 ���s�j���� ��ʏC�� START
//			tex����R�[�h.Text = "";
//			tex�����.Text = "";
//
//			axGT������.Clear();
//			axGT������.CaretRow = 1;
//			axGT������_CurPlaceChanged(null,null);
//			axGT������.Enabled = false;
// DEL 2007.01.22 ���s�j���� ��ʏC�� END

// MOD 2007.01.22 ���s�j���� ��ʏC�� START
//			if(gs�X���R�[�h.Trim().Length != 0)
//			{
//				tex����R�[�h.Enabled = true;
//				btn�������.Enabled = true;
//				btn������s.Enabled = true;
//				tex����R�[�h.Text = " ";
//				tex����R�[�h.Focus();
//			}else{
			if(gs�X���R�[�h.Trim().Length == 0)
			{
// DEL 2007.01.22 ���s�j���� ��ʏC�� START
				tex����R�[�h.Enabled = false;
				btn�������.Enabled = false;
				btn������s.Enabled = false;

				tex�Ǘ��X���R�[�h.Enabled = true;
				btn�Ǘ��X������.Enabled = true;
				tex�Ǘ��X���R�[�h.Text = " ";
				tex�Ǘ��X����.Text = "";
				tex�Ǘ��X���R�[�h.Focus();
				pnl������.Enabled = false;
			}
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
		}

		private void axGT������_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT������.set_CelForeColor(nOldRow,0,0);
			axGT������.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT������.set_CelForeColor(axGT������.CaretRow,0,111111);
			axGT������.set_CelForeColor(axGT������.CaretRow,0,0x98FB98);  //BGR
			axGT������.set_CelBackColor(axGT������.CaretRow,0,0x006000);
			nOldRow = axGT������.CaretRow;
		}

// ADD 2005.05.25 ���s�j�����J �t�H�[�J�X�ړ� START
		private void ������}�X�^_Closed(object sender, System.EventArgs e)
		{
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//			tex�Ǘ��X���R�[�h.Text = " ";
//			tex���b�Z�[�W.Text = "";
//			tex�Ǘ��X����.Text = "";
//			axGT������.CaretRow = 1;
//			axGT������_CurPlaceChanged(null,null);
//			tex�Ǘ��X���R�[�h.Focus();
			btn��������_Click(sender, e);
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
// ADD 2008.02.14 ���s�j���� �c�Ə��Ŏg�p��A�Ǘ��Ŏg�p�������̏����\����Q�Ή� START
			tex�Ǘ��X���R�[�h.Text    = " ";
			tex�Ǘ��X���R�[�h.Enabled = true;
			btn�Ǘ��X������.Visible   = true;
			tex�Ǘ��X����.Text        = "";
			tex���b�Z�[�W.Text        = "";
// MOD 2009.05.28 ���s�j���� �o�׎��шꗗ�^����\���Ή� START
			cb�o�׎��шꗗ�^����\��.Checked = false;
			btn����X�V.Enabled = false;
// MOD 2009.05.28 ���s�j���� �o�׎��шꗗ�^����\���Ή� END

			tex�Ǘ��X���R�[�h.Focus();
// ADD 2008.02.14 ���s�j���� �c�Ə��Ŏg�p��A�Ǘ��Ŏg�p�������̏����\����Q�Ή� END
		}
// ADD 2005.05.25 ���s�j�����J �t�H�[�J�X�ړ� END

// ADD 2006.11.08 ���s�j�R�{ �X�����O�C�����̐�����o�^����ꍇ�̓X���R�[�h�`�F�b�N�ǉ� START
		private int �X�֔ԍ��`�F�b�N()
		{
			tex�X�֔ԍ��P.Text = tex�X�֔ԍ��P.Text.Trim();
			tex�X�֔ԍ��Q.Text = tex�X�֔ԍ��Q.Text.Trim();
// MOD 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX START
//			if (!�K�{�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return -1;
//			if (!���p�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return -1;
//			if (!�K�{�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return -1;
//			if (!���p�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return -1;
			if (!�K�{�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return -3;
			if (!�K�{�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return -3;
			if (!���p�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return -3;
			if (!���p�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return -3;
// MOD 2007.01.22 ���s�j���� ��ʃ��C�A�E�g�ύX END
			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			int bRet = -1;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�X�֔ԍ��P.Text + tex�X�֔ԍ��Q.Text;
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//				string[] sList = sv_maintenance.Sel_Postcode1(gsa���[�U, sKey);
				String[] sList;
				tex����R�[�h.Text = tex����R�[�h.Text.Trim();
				if ((tex����R�[�h.Text == "") || (tex����R�[�h.Text.Substring(0,1) != "J"))
				{
					sList = sv_maintenance.Sel_Postcode1(gsa���[�U, sKey);

				}
				else
				{
					sList = sv_oji.Sel_Postcode1(gsa���[�U, sKey);
				}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

				if (sList[0].Equals("����I��"))
				{
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					if ((tex����R�[�h.Text != "") && (tex����R�[�h.Text.Substring(0,1) == "J"))
					{
//MOD 2016.03.16 BEVAS�j���{ ���q�^���ŃO���[�o���^�p�Ή� START
						//�I��������������q�O���[�o���׎�̏ꍇ�́A���L�������X�L�b�v����
						if(tex����R�[�h.Text.Substring(0,2) != "JG")
						{
//MOD 2016.03.16 BEVAS�j���{ ���q�^���ŃO���[�o���^�p�Ή� END
							String[] sKey1 = new string[1];
							sKey1[0] = sList[4].Trim();
							string[] sList1 = sv_oji.Sel_Member(gsa���[�U, sKey1);
							if (sList1[0].Equals("����I��"))
							{
								if ((sList1[4] != "3") && (sList1[4] != "4"))
								{
									tex���b�Z�[�W.Text = "�w�肵���Z���́A�Z�N�V�����o�^�s�\�G���A�ł�";
									tex�X�֔ԍ��X��.Text = "";
									�r�[�v��();
									this.Cursor = System.Windows.Forms.Cursors.Default;
									return -3;
								}
							}
							else
							{
								tex���b�Z�[�W.Text = sList[0];
								�r�[�v��();
								tex�X�֔ԍ��X��.Text = "";
								tex�X�֔ԍ��P.Focus();
								this.Cursor = System.Windows.Forms.Cursors.Default;
								return -3;
							}
//MOD 2016.03.16 BEVAS�j���{ ���q�^���ŃO���[�o���^�p�Ή� START
						}
//MOD 2016.03.16 BEVAS�j���{ ���q�^���ŃO���[�o���^�p�Ή� END
					}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

					tex���b�Z�[�W.Text = "";
					tex�X�֔ԍ��X��.Text = sList[1];
					if(gs�X���R�[�h.Trim().Length != 0)
					{
						if(gs�X���R�[�h.Trim() != sList[4].Trim())
						{
							tex���b�Z�[�W.Text = "���͂��ꂽ�X�֔ԍ��̓X���R�[�h���Ǘ��X���R�[�h�ƈ�v���Ă��܂���B";
							bRet = -2;
						}
						else
							bRet = 0;
					}
					else
						bRet = 0;
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					tex�X�֔ԍ��X��.Text = "";
					tex�X�֔ԍ��P.Focus();
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return bRet;
		}
// ADD 2006.11.08 ���s�j�R�{ �X�����O�C�����̐�����o�^����ꍇ�̓X���R�[�h�`�F�b�N�ǉ� END
// ADD 2006.11.09 ���s�j�R�{ ���������ʂ���̕��A�ɂăZ�N�V��������\������l�ɏC�� START
		private void �Z�N�V�������擾()
		{
			if((tex����R�[�h.Text.Trim().Length != 0)&&
			   (tex�X�֔ԍ��P.Text.Trim().Length != 0)&&
			   (tex�X�֔ԍ��Q.Text.Trim().Length != 0))     // ����R�[�h�ƗX�֔ԍ��̓��͂���H
			{
				tex���b�Z�[�W.Text = "";
				string[] sSectionKey = new string[2];
				sSectionKey[0] = tex����R�[�h.Text;
				sSectionKey[1] = tex�X�֔ԍ��P.Text.Trim() + tex�X�֔ԍ��Q.Text.Trim();
				string[] sSectionList = sv_maintenance.Sel_SectionCount(gsa���[�U, sSectionKey);
															// �Z�N�V�������̎擾
				if (sSectionList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex���吔.Text = sSectionList[1];
				}
				else
				{
					tex���b�Z�[�W.Text = sSectionList[0];
					�r�[�v��();
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//					tex�����.Text = "";
// DEL 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
					tex���吔.Text = "";
				}
			}
			return;
		}
// ADD 2006.11.09 ���s�j�R�{ ���������ʂ���̕��A�ɂăZ�N�V��������\������l�ɏC�� START
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
		private void btn������s_Click(object sender, System.EventArgs e)
		{
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
//			if(!�K�{�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
			if(!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
			//����`�F�b�N
			if(!���������())
			{
				MessageBox.Show("���q�l(" + tex����R�[�h.Text + ")�����݂��܂���" ,"���̓`�F�b�N",MessageBoxButtons.OK);
				tex����R�[�h.Focus();
				return;
			}

			if(������ꗗ����())
			{
				axGT������.Enabled = true;
				������o�^���[�h();
				tex���Ӑ�R�[�h.Focus();
			}
		}
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
// MOD 2009.05.28 ���s�j���� �o�׎��шꗗ�^����\���Ή� START
		private void btn����X�V_Click(object sender, System.EventArgs e)
		{
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
			if(!�K�{�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
			if(!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;

			tex���b�Z�[�W.Text = "���q�l���X�V���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey = new string[5];
				sKey[0] = tex����R�[�h.Text;
				if(cb�o�׎��шꗗ�^����\��.Checked){
					sKey[1] = "1";
				}else{
					sKey[1] = "0";
				}
				sKey[2] = s����X�V����;
				sKey[3] = "������}";
				sKey[4] = gs���p�҃R�[�h;
				string[] sList = sv_maintenance.Upd_Member2(gsa���[�U, sKey);
				if (sList[0].Equals("����I��"))
				{
					s����X�V���� = sList[1];
					tex���b�Z�[�W.Text = "";
					MessageBox.Show("�X�V���܂���" ,"���q�l���X�V",MessageBoxButtons.OK);
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
// MOD 2009.05.28 ���s�j���� �o�׎��шꗗ�^����\���Ή� END
	}
}
