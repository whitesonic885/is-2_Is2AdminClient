using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Net;

namespace is2AdminClient
{
	/// <summary>
	/// [�}�j���A���_�E�����[�h]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2009.12.01 PSN) ���� �V�K�쐬 
	//--------------------------------------------------------------------------
	// MOD 2010.04.02 PSN) ���� �Q��PDF�̕ύX 
	// MOD 2010.04.13 ���s�j���� �w��STAR-2�V�K�׎�\���t�����x���ǉ� 
	// MOD 2010.06.01 PSN) ����A���s�j���� FAQ��Web�\���̒ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2011.06.22 ���s�j���� ���q�^���Ή� 
	//--------------------------------------------------------------------------
	// MOD 2011.08.09 �A�N�g�j��� �V�׎�EDI�ABluetooth�Ή��V�K�ݒu�菇������}�j���A���ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2015.04.24 BEVAS)�O�c�@SS�A�C�e���ŏЉ���_�E�����[�h�{�^���̒ǉ�
	// MOD 2015.04.24 BEVAS)�O�c�@iS2�����o�̓}�j���A���_�E�����[�h�{�^���̒ǉ�
	//--------------------------------------------------------------------------
	// MOD 2016.05.19 BEVAS�j���{�@iS2�v�����^�����˗����_�E�����[�h�{�^���̒ǉ�
	//--------------------------------------------------------------------------
	public class �}�j���A���_�E�����[�h : ���ʃt�H�[��
	{
		public string s�}�j���A���t�q�k = "";
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
		private string s��Ћ敪 = "";
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label lab����;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btniS2�}�j���A���U;
		private System.Windows.Forms.Button btniS2�}�j���A���T;
		private System.Windows.Forms.Button btniS2�}�j���A���S;
		private System.Windows.Forms.Button btniS2�}�j���A���R;
		private System.Windows.Forms.Button btniS2�}�j���A���Q;
		private System.Windows.Forms.Button btniS2�}�j���A���P;
		private System.Windows.Forms.Button btnSS�}�j���A���Q;
		private System.Windows.Forms.Button btnSS�}�j���A���P;
		private System.Windows.Forms.Button btn���̑��P;
		private System.Windows.Forms.Label lab�}�j���A���_�E�����[�h�^�C�g��;
		private System.Windows.Forms.GroupBox grbiS2;
		private System.Windows.Forms.GroupBox grbSS;
		private System.Windows.Forms.GroupBox grb���̑�;
		private System.Windows.Forms.Button btn���̑��Q;
		private System.Windows.Forms.Button btn���̑��R;
		private System.Windows.Forms.Label lab���̑��R;
		private System.Windows.Forms.Label lab���̑��Q;
		private System.Windows.Forms.Label lab���̑��P;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btniS2FAQ;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnSS�}�j���A���R;
		private System.Windows.Forms.Button btnSS�}�j���A���S;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnSS�}�j���A���Qc;
		private System.Windows.Forms.Button btnSS�}�j���A��3�ʎ�;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lab���̑��S;
		private System.Windows.Forms.Button btn���̑��S;
		private System.Windows.Forms.Label label6;
		//private decimal d�X�V����		= 0m;

		public �}�j���A���_�E�����[�h()
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
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab���� = new System.Windows.Forms.Label();
			this.lab�}�j���A���_�E�����[�h�^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
			this.btn���� = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.grbiS2 = new System.Windows.Forms.GroupBox();
			this.btniS2FAQ = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btniS2�}�j���A���U = new System.Windows.Forms.Button();
			this.btniS2�}�j���A���T = new System.Windows.Forms.Button();
			this.btniS2�}�j���A���S = new System.Windows.Forms.Button();
			this.btniS2�}�j���A���R = new System.Windows.Forms.Button();
			this.btniS2�}�j���A���Q = new System.Windows.Forms.Button();
			this.btniS2�}�j���A���P = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.grbSS = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnSS�}�j���A���Qc = new System.Windows.Forms.Button();
			this.btnSS�}�j���A��3�ʎ� = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnSS�}�j���A���S = new System.Windows.Forms.Button();
			this.btnSS�}�j���A���R = new System.Windows.Forms.Button();
			this.btnSS�}�j���A���Q = new System.Windows.Forms.Button();
			this.btnSS�}�j���A���P = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.grb���̑� = new System.Windows.Forms.GroupBox();
			this.btn���̑��S = new System.Windows.Forms.Button();
			this.lab���̑��S = new System.Windows.Forms.Label();
			this.btn���̑��R = new System.Windows.Forms.Button();
			this.btn���̑��Q = new System.Windows.Forms.Button();
			this.lab���̑��R = new System.Windows.Forms.Label();
			this.lab���̑��Q = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btn���̑��P = new System.Windows.Forms.Button();
			this.lab���̑��P = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.grbiS2.SuspendLayout();
			this.grbSS.SuspendLayout();
			this.grb���̑�.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(810, 26);
			this.panel6.TabIndex = 12;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab����);
			this.panel7.Controls.Add(this.lab�}�j���A���_�E�����[�h�^�C�g��);
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
			// lab�}�j���A���_�E�����[�h�^�C�g��
			// 
			this.lab�}�j���A���_�E�����[�h�^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�}�j���A���_�E�����[�h�^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�}�j���A���_�E�����[�h�^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab�}�j���A���_�E�����[�h�^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab�}�j���A���_�E�����[�h�^�C�g��.Name = "lab�}�j���A���_�E�����[�h�^�C�g��";
			this.lab�}�j���A���_�E�����[�h�^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab�}�j���A���_�E�����[�h�^�C�g��.TabIndex = 0;
			this.lab�}�j���A���_�E�����[�h�^�C�g��.Text = "�}�j���A���_�E�����[�h";
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
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// grbiS2
			// 
			this.grbiS2.Controls.Add(this.btniS2FAQ);
			this.grbiS2.Controls.Add(this.label4);
			this.grbiS2.Controls.Add(this.btniS2�}�j���A���U);
			this.grbiS2.Controls.Add(this.btniS2�}�j���A���T);
			this.grbiS2.Controls.Add(this.btniS2�}�j���A���S);
			this.grbiS2.Controls.Add(this.btniS2�}�j���A���R);
			this.grbiS2.Controls.Add(this.btniS2�}�j���A���Q);
			this.grbiS2.Controls.Add(this.btniS2�}�j���A���P);
			this.grbiS2.Controls.Add(this.label8);
			this.grbiS2.Controls.Add(this.label16);
			this.grbiS2.Controls.Add(this.label17);
			this.grbiS2.Controls.Add(this.label18);
			this.grbiS2.Controls.Add(this.label19);
			this.grbiS2.Controls.Add(this.label20);
			this.grbiS2.Controls.Add(this.label22);
			this.grbiS2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.grbiS2.ForeColor = System.Drawing.Color.Green;
			this.grbiS2.Location = new System.Drawing.Point(36, 60);
			this.grbiS2.Name = "grbiS2";
			this.grbiS2.Size = new System.Drawing.Size(350, 446);
			this.grbiS2.TabIndex = 28;
			this.grbiS2.TabStop = false;
			// 
			// btniS2FAQ
			// 
			this.btniS2FAQ.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2FAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2FAQ.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2FAQ.ForeColor = System.Drawing.Color.White;
			this.btniS2FAQ.Location = new System.Drawing.Point(256, 354);
			this.btniS2FAQ.Name = "btniS2FAQ";
			this.btniS2FAQ.Size = new System.Drawing.Size(72, 22);
			this.btniS2FAQ.TabIndex = 96;
			this.btniS2FAQ.TabStop = false;
			this.btniS2FAQ.Text = "�v����";
			this.btniS2FAQ.Click += new System.EventHandler(this.btniS2FAQ_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(24, 360);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(168, 16);
			this.label4.TabIndex = 95;
			this.label4.Text = "�i�V�j�@�e�`�p�i�悭���鎿��j";
			// 
			// btniS2�}�j���A���U
			// 
			this.btniS2�}�j���A���U.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2�}�j���A���U.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2�}�j���A���U.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2�}�j���A���U.ForeColor = System.Drawing.Color.White;
			this.btniS2�}�j���A���U.Location = new System.Drawing.Point(256, 310);
			this.btniS2�}�j���A���U.Name = "btniS2�}�j���A���U";
			this.btniS2�}�j���A���U.Size = new System.Drawing.Size(72, 22);
			this.btniS2�}�j���A���U.TabIndex = 94;
			this.btniS2�}�j���A���U.TabStop = false;
			this.btniS2�}�j���A���U.Text = "�_�E�����[�h";
			this.btniS2�}�j���A���U.Click += new System.EventHandler(this.btniS2�}�j���A���U_Click);
			// 
			// btniS2�}�j���A���T
			// 
			this.btniS2�}�j���A���T.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2�}�j���A���T.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2�}�j���A���T.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2�}�j���A���T.ForeColor = System.Drawing.Color.White;
			this.btniS2�}�j���A���T.Location = new System.Drawing.Point(256, 257);
			this.btniS2�}�j���A���T.Name = "btniS2�}�j���A���T";
			this.btniS2�}�j���A���T.Size = new System.Drawing.Size(72, 22);
			this.btniS2�}�j���A���T.TabIndex = 93;
			this.btniS2�}�j���A���T.TabStop = false;
			this.btniS2�}�j���A���T.Text = "�_�E�����[�h";
			this.btniS2�}�j���A���T.Click += new System.EventHandler(this.btniS2�}�j���A���T_Click);
			// 
			// btniS2�}�j���A���S
			// 
			this.btniS2�}�j���A���S.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2�}�j���A���S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2�}�j���A���S.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2�}�j���A���S.ForeColor = System.Drawing.Color.White;
			this.btniS2�}�j���A���S.Location = new System.Drawing.Point(255, 200);
			this.btniS2�}�j���A���S.Name = "btniS2�}�j���A���S";
			this.btniS2�}�j���A���S.Size = new System.Drawing.Size(72, 22);
			this.btniS2�}�j���A���S.TabIndex = 92;
			this.btniS2�}�j���A���S.TabStop = false;
			this.btniS2�}�j���A���S.Text = "�_�E�����[�h";
			this.btniS2�}�j���A���S.Click += new System.EventHandler(this.btniS2�}�j���A���S_Click);
			// 
			// btniS2�}�j���A���R
			// 
			this.btniS2�}�j���A���R.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2�}�j���A���R.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2�}�j���A���R.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2�}�j���A���R.ForeColor = System.Drawing.Color.White;
			this.btniS2�}�j���A���R.Location = new System.Drawing.Point(256, 152);
			this.btniS2�}�j���A���R.Name = "btniS2�}�j���A���R";
			this.btniS2�}�j���A���R.Size = new System.Drawing.Size(72, 22);
			this.btniS2�}�j���A���R.TabIndex = 91;
			this.btniS2�}�j���A���R.TabStop = false;
			this.btniS2�}�j���A���R.Text = "�_�E�����[�h";
			this.btniS2�}�j���A���R.Click += new System.EventHandler(this.btniS2�}�j���A���R_Click);
			// 
			// btniS2�}�j���A���Q
			// 
			this.btniS2�}�j���A���Q.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2�}�j���A���Q.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2�}�j���A���Q.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2�}�j���A���Q.ForeColor = System.Drawing.Color.White;
			this.btniS2�}�j���A���Q.Location = new System.Drawing.Point(256, 96);
			this.btniS2�}�j���A���Q.Name = "btniS2�}�j���A���Q";
			this.btniS2�}�j���A���Q.Size = new System.Drawing.Size(72, 22);
			this.btniS2�}�j���A���Q.TabIndex = 90;
			this.btniS2�}�j���A���Q.TabStop = false;
			this.btniS2�}�j���A���Q.Text = "�_�E�����[�h";
			this.btniS2�}�j���A���Q.Click += new System.EventHandler(this.btniS2�}�j���A���Q_Click);
			// 
			// btniS2�}�j���A���P
			// 
			this.btniS2�}�j���A���P.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2�}�j���A���P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2�}�j���A���P.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2�}�j���A���P.ForeColor = System.Drawing.Color.White;
			this.btniS2�}�j���A���P.Location = new System.Drawing.Point(256, 45);
			this.btniS2�}�j���A���P.Name = "btniS2�}�j���A���P";
			this.btniS2�}�j���A���P.Size = new System.Drawing.Size(72, 22);
			this.btniS2�}�j���A���P.TabIndex = 89;
			this.btniS2�}�j���A���P.TabStop = false;
			this.btniS2�}�j���A���P.Text = "�_�E�����[�h";
			this.btniS2�}�j���A���P.Click += new System.EventHandler(this.btniS2�}�j���A���P_Click);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(24, 313);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(216, 16);
			this.label8.TabIndex = 76;
			this.label8.Text = "�i�U�j�@SATO�v�����^�ăZ�b�g�A�b�v�����";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label16.Location = new System.Drawing.Point(24, 260);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(200, 16);
			this.label16.TabIndex = 75;
			this.label16.Text = "�i�T�j�@iSTAR-2�ăZ�b�g�A�b�v�����";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label17.Location = new System.Drawing.Point(23, 207);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(200, 16);
			this.label17.TabIndex = 74;
			this.label17.Text = "�i�S�j�@iSTAR-2�Z�b�g�A�b�v�����";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label18.Location = new System.Drawing.Point(24, 155);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(200, 16);
			this.label18.TabIndex = 73;
			this.label18.Text = "�i�R�j�@iSTAR-2�c�Ə��}�j���A��";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label19.Location = new System.Drawing.Point(24, 99);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(200, 16);
			this.label19.TabIndex = 72;
			this.label19.Text = "�i�Q�j�@iSTAR-2�ȈՃ}�j���A��";
			// 
			// label20
			// 
			this.label20.Cursor = System.Windows.Forms.Cursors.No;
			this.label20.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label20.Location = new System.Drawing.Point(24, 48);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(192, 16);
			this.label20.TabIndex = 70;
			this.label20.Text = "�i�P�j�@iSTAR-2����}�j���A��";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label22.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.White;
			this.label22.Location = new System.Drawing.Point(0, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(349, 20);
			this.label22.TabIndex = 68;
			this.label22.Text = "iSTAR-2";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grbSS
			// 
			this.grbSS.Controls.Add(this.label12);
			this.grbSS.Controls.Add(this.btnSS�}�j���A���Qc);
			this.grbSS.Controls.Add(this.btnSS�}�j���A��3�ʎ�);
			this.grbSS.Controls.Add(this.label11);
			this.grbSS.Controls.Add(this.label10);
			this.grbSS.Controls.Add(this.btnSS�}�j���A���S);
			this.grbSS.Controls.Add(this.btnSS�}�j���A���R);
			this.grbSS.Controls.Add(this.btnSS�}�j���A���Q);
			this.grbSS.Controls.Add(this.btnSS�}�j���A���P);
			this.grbSS.Controls.Add(this.label1);
			this.grbSS.Controls.Add(this.label2);
			this.grbSS.Controls.Add(this.label7);
			this.grbSS.Controls.Add(this.label9);
			this.grbSS.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.grbSS.ForeColor = System.Drawing.Color.Honeydew;
			this.grbSS.Location = new System.Drawing.Point(410, 72);
			this.grbSS.Name = "grbSS";
			this.grbSS.Size = new System.Drawing.Size(350, 222);
			this.grbSS.TabIndex = 30;
			this.grbSS.TabStop = false;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label12.Location = new System.Drawing.Point(54, 104);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(200, 16);
			this.label12.TabIndex = 96;
			this.label12.Text = "���������ʎ�";
			// 
			// btnSS�}�j���A���Qc
			// 
			this.btnSS�}�j���A���Qc.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSS�}�j���A���Qc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSS�}�j���A���Qc.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSS�}�j���A���Qc.ForeColor = System.Drawing.Color.White;
			this.btnSS�}�j���A���Qc.Location = new System.Drawing.Point(264, 124);
			this.btnSS�}�j���A���Qc.Name = "btnSS�}�j���A���Qc";
			this.btnSS�}�j���A���Qc.Size = new System.Drawing.Size(72, 22);
			this.btnSS�}�j���A���Qc.TabIndex = 95;
			this.btnSS�}�j���A���Qc.TabStop = false;
			this.btnSS�}�j���A���Qc.Text = "�_�E�����[�h";
			this.btnSS�}�j���A���Qc.Click += new System.EventHandler(this.btnSS�}�j���A���Qc_Click);
			// 
			// btnSS�}�j���A��3�ʎ�
			// 
			this.btnSS�}�j���A��3�ʎ�.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSS�}�j���A��3�ʎ�.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSS�}�j���A��3�ʎ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSS�}�j���A��3�ʎ�.ForeColor = System.Drawing.Color.White;
			this.btnSS�}�j���A��3�ʎ�.Location = new System.Drawing.Point(264, 90);
			this.btnSS�}�j���A��3�ʎ�.Name = "btnSS�}�j���A��3�ʎ�";
			this.btnSS�}�j���A��3�ʎ�.Size = new System.Drawing.Size(72, 22);
			this.btnSS�}�j���A��3�ʎ�.TabIndex = 94;
			this.btnSS�}�j���A��3�ʎ�.TabStop = false;
			this.btnSS�}�j���A��3�ʎ�.Text = "�_�E�����[�h";
			this.btnSS�}�j���A��3�ʎ�.Click += new System.EventHandler(this.button1_Click);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label11.Location = new System.Drawing.Point(24, 128);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(224, 16);
			this.label11.TabIndex = 93;
			this.label11.Text = "�i�S�j�@�X�[�p�[�X�^�[�A�C�e���Ő�������";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label10.Location = new System.Drawing.Point(24, 88);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(232, 16);
			this.label10.TabIndex = 92;
			this.label10.Text = "�i�R�j�@�X�[�p�[�X�^�[�A�C�e����";
			// 
			// btnSS�}�j���A���S
			// 
			this.btnSS�}�j���A���S.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSS�}�j���A���S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSS�}�j���A���S.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSS�}�j���A���S.ForeColor = System.Drawing.Color.White;
			this.btnSS�}�j���A���S.Location = new System.Drawing.Point(264, 188);
			this.btnSS�}�j���A���S.Name = "btnSS�}�j���A���S";
			this.btnSS�}�j���A���S.Size = new System.Drawing.Size(72, 22);
			this.btnSS�}�j���A���S.TabIndex = 91;
			this.btnSS�}�j���A���S.TabStop = false;
			this.btnSS�}�j���A���S.Text = "�_�E�����[�h";
			this.btnSS�}�j���A���S.Click += new System.EventHandler(this.btnSS�}�j���A���S_Click);
			// 
			// btnSS�}�j���A���R
			// 
			this.btnSS�}�j���A���R.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSS�}�j���A���R.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSS�}�j���A���R.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSS�}�j���A���R.ForeColor = System.Drawing.Color.White;
			this.btnSS�}�j���A���R.Location = new System.Drawing.Point(264, 156);
			this.btnSS�}�j���A���R.Name = "btnSS�}�j���A���R";
			this.btnSS�}�j���A���R.Size = new System.Drawing.Size(72, 22);
			this.btnSS�}�j���A���R.TabIndex = 91;
			this.btnSS�}�j���A���R.TabStop = false;
			this.btnSS�}�j���A���R.Text = "�_�E�����[�h";
			this.btnSS�}�j���A���R.Click += new System.EventHandler(this.btnSS�}�j���A���R_Click);
			// 
			// btnSS�}�j���A���Q
			// 
			this.btnSS�}�j���A���Q.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSS�}�j���A���Q.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSS�}�j���A���Q.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSS�}�j���A���Q.ForeColor = System.Drawing.Color.White;
			this.btnSS�}�j���A���Q.Location = new System.Drawing.Point(264, 52);
			this.btnSS�}�j���A���Q.Name = "btnSS�}�j���A���Q";
			this.btnSS�}�j���A���Q.Size = new System.Drawing.Size(72, 22);
			this.btnSS�}�j���A���Q.TabIndex = 91;
			this.btnSS�}�j���A���Q.TabStop = false;
			this.btnSS�}�j���A���Q.Text = "�_�E�����[�h";
			this.btnSS�}�j���A���Q.Click += new System.EventHandler(this.btnSS�}�j���A���Q_Click);
			// 
			// btnSS�}�j���A���P
			// 
			this.btnSS�}�j���A���P.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSS�}�j���A���P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSS�}�j���A���P.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSS�}�j���A���P.ForeColor = System.Drawing.Color.White;
			this.btnSS�}�j���A���P.Location = new System.Drawing.Point(264, 20);
			this.btnSS�}�j���A���P.Name = "btnSS�}�j���A���P";
			this.btnSS�}�j���A���P.Size = new System.Drawing.Size(72, 22);
			this.btnSS�}�j���A���P.TabIndex = 90;
			this.btnSS�}�j���A���P.TabStop = false;
			this.btnSS�}�j���A���P.Text = "�_�E�����[�h";
			this.btnSS�}�j���A���P.Click += new System.EventHandler(this.btnSS�}�j���A���P_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(24, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 16);
			this.label1.TabIndex = 64;
			this.label1.Text = "�i�Q�j�@�X�[�p�[�X�^�[�A�C�e���ő�������";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(24, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(248, 16);
			this.label2.TabIndex = 62;
			this.label2.Text = "�i�P�j�@�X�[�p�[�X�^�[�W���ő�������";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(24, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(256, 16);
			this.label7.TabIndex = 64;
			this.label7.Text = "�i�T�j�@�V�׎�EDI(Bluetooth)����}�j���A��";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(24, 192);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(256, 16);
			this.label9.TabIndex = 64;
			this.label9.Text = "�i�U�j�@Bluetooth�Ή��V�K�ݒu�菇��";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label3.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(410, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(349, 22);
			this.label3.TabIndex = 60;
			this.label3.Text = "�X�[�p�[�X�^�[";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grb���̑�
			// 
			this.grb���̑�.Controls.Add(this.btn���̑��S);
			this.grb���̑�.Controls.Add(this.lab���̑��S);
			this.grb���̑�.Controls.Add(this.btn���̑��R);
			this.grb���̑�.Controls.Add(this.btn���̑��Q);
			this.grb���̑�.Controls.Add(this.lab���̑��R);
			this.grb���̑�.Controls.Add(this.lab���̑��Q);
			this.grb���̑�.Controls.Add(this.label6);
			this.grb���̑�.Controls.Add(this.btn���̑��P);
			this.grb���̑�.Controls.Add(this.lab���̑��P);
			this.grb���̑�.Controls.Add(this.label5);
			this.grb���̑�.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.grb���̑�.ForeColor = System.Drawing.Color.Green;
			this.grb���̑�.Location = new System.Drawing.Point(410, 300);
			this.grb���̑�.Name = "grb���̑�";
			this.grb���̑�.Size = new System.Drawing.Size(350, 206);
			this.grb���̑�.TabIndex = 31;
			this.grb���̑�.TabStop = false;
			// 
			// btn���̑��S
			// 
			this.btn���̑��S.BackColor = System.Drawing.Color.SteelBlue;
			this.btn���̑��S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn���̑��S.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn���̑��S.ForeColor = System.Drawing.Color.White;
			this.btn���̑��S.Location = new System.Drawing.Point(264, 148);
			this.btn���̑��S.Name = "btn���̑��S";
			this.btn���̑��S.Size = new System.Drawing.Size(72, 22);
			this.btn���̑��S.TabIndex = 99;
			this.btn���̑��S.TabStop = false;
			this.btn���̑��S.Text = "�_�E�����[�h";
			this.btn���̑��S.Click += new System.EventHandler(this.btn���̑��S_Click);
			// 
			// lab���̑��S
			// 
			this.lab���̑��S.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���̑��S.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lab���̑��S.Location = new System.Drawing.Point(24, 152);
			this.lab���̑��S.Name = "lab���̑��S";
			this.lab���̑��S.Size = new System.Drawing.Size(224, 16);
			this.lab���̑��S.TabIndex = 98;
			this.lab���̑��S.Text = "�i�S�j�@iSTAR-2�v�����^�����˗���";
			// 
			// btn���̑��R
			// 
			this.btn���̑��R.BackColor = System.Drawing.Color.SteelBlue;
			this.btn���̑��R.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn���̑��R.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn���̑��R.ForeColor = System.Drawing.Color.White;
			this.btn���̑��R.Location = new System.Drawing.Point(264, 116);
			this.btn���̑��R.Name = "btn���̑��R";
			this.btn���̑��R.Size = new System.Drawing.Size(72, 22);
			this.btn���̑��R.TabIndex = 97;
			this.btn���̑��R.TabStop = false;
			this.btn���̑��R.Text = "�_�E�����[�h";
			this.btn���̑��R.Click += new System.EventHandler(this.btn���̑��R_Click);
			// 
			// btn���̑��Q
			// 
			this.btn���̑��Q.BackColor = System.Drawing.Color.SteelBlue;
			this.btn���̑��Q.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn���̑��Q.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn���̑��Q.ForeColor = System.Drawing.Color.White;
			this.btn���̑��Q.Location = new System.Drawing.Point(264, 84);
			this.btn���̑��Q.Name = "btn���̑��Q";
			this.btn���̑��Q.Size = new System.Drawing.Size(72, 22);
			this.btn���̑��Q.TabIndex = 96;
			this.btn���̑��Q.TabStop = false;
			this.btn���̑��Q.Text = "�_�E�����[�h";
			this.btn���̑��Q.Click += new System.EventHandler(this.btn���̑��Q_Click);
			// 
			// lab���̑��R
			// 
			this.lab���̑��R.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���̑��R.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lab���̑��R.Location = new System.Drawing.Point(24, 120);
			this.lab���̑��R.Name = "lab���̑��R";
			this.lab���̑��R.Size = new System.Drawing.Size(224, 16);
			this.lab���̑��R.TabIndex = 95;
			this.lab���̑��R.Text = "�i�R�j�@�X�[�p�[�X�^�[�����˗���";
			// 
			// lab���̑��Q
			// 
			this.lab���̑��Q.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���̑��Q.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lab���̑��Q.Location = new System.Drawing.Point(24, 88);
			this.lab���̑��Q.Name = "lab���̑��Q";
			this.lab���̑��Q.Size = new System.Drawing.Size(224, 16);
			this.lab���̑��Q.TabIndex = 94;
			this.lab���̑��Q.Text = "�i�Q�j�@��STAR-2�V�K�׎�\���t����";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(56, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 23);
			this.label6.TabIndex = 93;
			this.label6.Text = "(iSTAR-2�E292�V���[�Y)";
			// 
			// btn���̑��P
			// 
			this.btn���̑��P.BackColor = System.Drawing.Color.SteelBlue;
			this.btn���̑��P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn���̑��P.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn���̑��P.ForeColor = System.Drawing.Color.White;
			this.btn���̑��P.Location = new System.Drawing.Point(264, 43);
			this.btn���̑��P.Name = "btn���̑��P";
			this.btn���̑��P.Size = new System.Drawing.Size(72, 22);
			this.btn���̑��P.TabIndex = 92;
			this.btn���̑��P.TabStop = false;
			this.btn���̑��P.Text = "�_�E�����[�h";
			this.btn���̑��P.Click += new System.EventHandler(this.btn���̑��P_Click);
			// 
			// lab���̑��P
			// 
			this.lab���̑��P.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���̑��P.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lab���̑��P.Location = new System.Drawing.Point(24, 40);
			this.lab���̑��P.Name = "lab���̑��P";
			this.lab���̑��P.Size = new System.Drawing.Size(224, 32);
			this.lab���̑��P.TabIndex = 60;
			this.lab���̑��P.Text = "�i�P�j�@�L�����Z���񍐏�";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label5.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(349, 20);
			this.label5.TabIndex = 58;
			this.label5.Text = "���̑�";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// �}�j���A���_�E�����[�h
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 582);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.grb���̑�);
			this.Controls.Add(this.grbSS);
			this.Controls.Add(this.grbiS2);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "�}�j���A���_�E�����[�h";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 �}�j���A���_�E�����[�h";
			this.Load += new System.EventHandler(this.�}�j���A���_�E�����[�h_Load);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.grbiS2.ResumeLayout(false);
			this.grbSS.ResumeLayout(false);
			this.grb���̑�.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		//�}�j���A���̂o�c�e
		private static string[] s�}�j���A���o�c�e = {"is2manual.pdf"
												, "is2manual_kani.pdf"
// MOD 2010.04.02 PSN) ���� �Q��PDF�̕ύX START
//												, "is2_eigyo.pdf"
												, "is2manual_eigyo.pdf"
// MOD 2010.04.02 PSN) ���� �Q��PDF�̕ύX END
												, "is2Setuptebiki.pdf"
												, "is-2saisetup.pdf"
												, "satosetup.pdf"
// MOD 2010.04.02 PSN) ���� �Q��PDF�̕ύX START
//												, "SSnormal.pdf"
//												, "SSitem.pdf"
												, "SSmanual_normal.pdf"
												, "SSmanual_item.pdf"
// MOD 2010.04.02 PSN) ���� �Q��PDF�̕ύX END
// MOD 2011.08.09 �A�N�g�j���@Bluetooth�֘A����}�j���A���ǉ� START
												, "SSmanual_bluetooth.pdf"
												, "SSmanual_bluetoothsinki.pdf"
// MOD 2011.08.09 �A�N�g�j���@Bluetooth�֘A����}�j���A���ǉ� END
												, "cancel.xls"
// MOD 2010.04.13 ���s�j���� �w��STAR-2�V�K�׎�\���t�����x���ǉ� START
												, "iS-2�V�K�׎�\���t����.xls"
												, "�X�[�p�[�X�^�[�����˗���.xls"
// MOD 2010.04.13 ���s�j���� �w��STAR-2�V�K�׎�\���t�����x���ǉ� END
// MOD 2015.04.24 BEVAS)�O�c�@SS�A�C�e���ŏЉ���_�E�����[�h�{�^���̒ǉ� START
												, "SS_item_appendix.pdf"
												, "SS_item_outline.pdf"
// MOD 2015.04.24 BEVAS)�O�c�@SS�A�C�e���ŏЉ���_�E�����[�h�{�^���̒ǉ� END
// MOD 2016.05.19 BEVAS�j���{�@iS2�v�����^�����˗����_�E�����[�h�{�^���̒ǉ� START
												, "�yiSTAR-2�z�v�����^�[�����˗���.xls"
// MOD 2016.05.19 BEVAS�j���{�@iS2�v�����^�����˗����_�E�����[�h�{�^���̒ǉ� END
											};
		private void btn����_Click(object sender, System.EventArgs e)
		{
			// ���̃t�H�[�������
			this.Close();
		}


		private void timer1_Tick(object sender, System.EventArgs e)
		{
			// �����̏����ݒ�
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
		}


		private void �}�j���A���_�E�����[�h_Load(object sender, System.EventArgs e)
		{
			// �����̏����ݒ�
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� START
			label1.Visible = true;
			btnSS�}�j���A���Q.Visible = true;
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� END
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			s��Ћ敪 = "";
			try{
				string[] sKey = {gs�X���R�[�h};
				if(sv_oji == null) sv_oji = new is2oji.Service1();
				string[] sList = sv_oji.Sel_Member(gsa���[�U, sKey);
				if(sList[0].Equals("����I��")){
					if((sList[4] == "3") || (sList[4] == "4")){
						s��Ћ敪 = "J";
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� START
						label1.Visible = false;
						btnSS�}�j���A���Q.Visible = false;
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� END
					}
				}else if(sList[0].Equals("�Y���f�[�^������܂���")){
					;
				}else{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
				}
			}catch (Exception ex){
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
		}

		private void btniS2�}�j���A���P_Click(object sender, System.EventArgs e)
		{
			//iS-2����}�j���A��
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			if(s��Ћ敪 != "J"){
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
				Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[0]);
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			}else{
				Process.Start("iexplore.exe"
								, s�}�j���A���t�q�k.Replace("/manual/","/manualJ/")
								 + s�}�j���A���o�c�e[0].Replace(".pdf","(���q).pdf"));
			}
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
		}

		private void btniS2�}�j���A���Q_Click(object sender, System.EventArgs e)
		{
			//iS-2�ȈՃ}�j���A��
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			if(s��Ћ敪 != "J"){
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
				Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[1]);
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			}else{
				Process.Start("iexplore.exe"
								, s�}�j���A���t�q�k.Replace("/manual/","/manualJ/")
								 + s�}�j���A���o�c�e[1].Replace(".pdf","(���q).pdf"));
			}
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
		}

		private void btniS2�}�j���A���R_Click(object sender, System.EventArgs e)
		{
			//iS-2�c�Ə��}�j���A��
			Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[2]);
		}

		private void btniS2�}�j���A���S_Click(object sender, System.EventArgs e)
		{
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			if(s��Ћ敪 != "J"){
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
				//iS-2�Z�b�g�A�b�v�����
				Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[3]);
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			}else{
				Process.Start("iexplore.exe"
								, s�}�j���A���t�q�k.Replace("/manual/","/manualJ/")
								 + s�}�j���A���o�c�e[3].Replace(".pdf","(���q).pdf"));
			}
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
		}

		private void btniS2�}�j���A���T_Click(object sender, System.EventArgs e)
		{
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			if(s��Ћ敪 != "J"){
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
				//iS-2�ăZ�b�g�A�b�v�����
				Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[4]);
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			}else{
				Process.Start("iexplore.exe"
								, s�}�j���A���t�q�k.Replace("/manual/","/manualJ/")
								 + s�}�j���A���o�c�e[4].Replace(".pdf","(���q).pdf"));
			}
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
		}

		private void btniS2�}�j���A���U_Click(object sender, System.EventArgs e)
		{
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			if(s��Ћ敪 != "J"){
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
				//SATO�ăZ�b�g�A�b�v�����
				Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[5]);
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			}else{
				Process.Start("iexplore.exe"
								, s�}�j���A���t�q�k.Replace("/manual/","/manualJ/")
								 + s�}�j���A���o�c�e[5].Replace(".pdf","(���q).pdf"));
			}
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
		}

		private void btnSS�}�j���A���P_Click(object sender, System.EventArgs e)
		{
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� START
			if(s��Ћ敪 != "J")
			{
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� END
				//SS�W���ő�������
				Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[6]);
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� START
			}
			else
			{
				Process.Start("iexplore.exe"
					, s�}�j���A���t�q�k.Replace("/manual/","/manualJ/")
					+ s�}�j���A���o�c�e[6].Replace(".pdf","(���q).pdf"));
			}
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� END
		}

		private void btnSS�}�j���A���Q_Click(object sender, System.EventArgs e)
		{
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� START
			if(s��Ћ敪 != "J")
			{
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� END
				//SS�A�C�e���ő�������
				Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[7]);
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� START
			}
			else
			{
				Process.Start("iexplore.exe"
				, s�}�j���A���t�q�k.Replace("/manual/","/manualJ/")
				+ s�}�j���A���o�c�e[7].Replace(".pdf","(���q).pdf"));
			}
// MOD 2011.07.13 �A�N�g�j��� ���q�^���Ή� END
		}
// MOD 2011.08.09 �A�N�g�j���@Bluetooth�֘A����}�j���A���ǉ� START
		private void btnSS�}�j���A���R_Click(object sender, System.EventArgs e)
		{
			//�V�׎�EDI(Bluetooth)����}�j���A��
			if(s��Ћ敪 != "J")
			{
				Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[8]);
			}
			else
			{
				Process.Start("iexplore.exe"
					, s�}�j���A���t�q�k.Replace("/manual/","/manualJ/")
					+ s�}�j���A���o�c�e[8].Replace(".pdf","(���q).pdf"));
			}
		}
		private void btnSS�}�j���A���S_Click(object sender, System.EventArgs e)
		{
			//Bluetooth�Ή��V�K�ݒu�菇��
			if(s��Ћ敪 != "J")
			{
				Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[9]);
			}
			else
			{
				Process.Start("iexplore.exe"
					, s�}�j���A���t�q�k.Replace("/manual/","/manualJ/")
					+ s�}�j���A���o�c�e[9].Replace(".pdf","(���q).pdf"));
			}
		}
// MOD 2011.08.09 �A�N�g�j���@Bluetooth�֘A����}�j���A���ǉ� END

		private void btn���̑��P_Click(object sender, System.EventArgs e)
		{
			//�L�����Z���񍐏�
// MOD 2011.08.09 �A�N�g�j���@Bluetooth�֘A����}�j���A���ǉ� START
			//Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[8]);
			Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[10]);
// MOD 2011.08.09 �A�N�g�j���@Bluetooth�֘A����}�j���A���ǉ� END
		}
// MOD 2010.04.13 ���s�j���� �w��STAR-2�V�K�׎�\���t�����x���ǉ� START
		private void btn���̑��Q_Click(object sender, System.EventArgs e)
		{
			//��STAR-2�V�K�׎�\���t����
// MOD 2011.08.09 �A�N�g�j���@Bluetooth�֘A����}�j���A���ǉ� START
			//Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[9]);
			Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[11]);
// MOD 2011.08.09 �A�N�g�j���@Bluetooth�֘A����}�j���A���ǉ� END
		}

		private void btn���̑��R_Click(object sender, System.EventArgs e)
		{
			//�X�[�p�[�X�^�[�����˗���
// MOD 2011.08.09 �A�N�g�j���@Bluetooth�֘A����}�j���A���ǉ� START
			//Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[10]);
			Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[12]);
// MOD 2011.08.09 �A�N�g�j���@Bluetooth�֘A����}�j���A���ǉ� END
		}
// MOD 2010.04.13 ���s�j���� �w��STAR-2�V�K�׎�\���t�����x���ǉ� END
// MOD 2010.06.01 PSN) ����A���s�j���� FAQ��Web�\���̒ǉ� START
		private void btniS2FAQ_Click(object sender, System.EventArgs e)
		{
			//iS-2 FAQ
			// s�}�j���A���t�q�k[https://wwwis2.fukutsu.co.jp/is2/manual/]
			//                  [https://wwwis2.fukutsu.co.jp/hp/faq/is2Faq.htm]
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			if(s��Ћ敪 != "J"){
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
				Process.Start("iexplore.exe"
				, s�}�j���A���t�q�k.Replace("/is2/manual/","/hp/faq/is2Faq.htm"));
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� START
			}else{
				Process.Start("iexplore.exe"
				, s�}�j���A���t�q�k.Replace("/is2/manual/","/hpj/faq/is2Faq.htm"));
			}
// MOD 2011.06.22 ���s�j���� ���q�^���Ή� END
		}

// MOD 2015.04.24 BEVAS)�O�c�@SS�A�C�e���ŏЉ���_�E�����[�h�{�^���̒ǉ� START
		private void btnSS�}�j���A���Qc_Click(object sender, System.EventArgs e)
		{
			Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[14]);	
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[13]);		
		}
// MOD 2015.04.24 BEVAS)�O�c�@SS�A�C�e���ŏЉ���_�E�����[�h�{�^���̒ǉ� END

// MOD 2010.06.01 PSN) ����A���s�j���� FAQ��Web�\���̒ǉ� END
// MOD 2016.05.19 BEVAS�j���{�@iS2�v�����^�����˗����_�E�����[�h�{�^���̒ǉ� START
		private void btn���̑��S_Click(object sender, System.EventArgs e)
		{
			Process.Start("iexplore.exe", s�}�j���A���t�q�k + s�}�j���A���o�c�e[15]);
		}
// MOD 2016.05.19 BEVAS�j���{�@iS2�v�����^�����˗����_�E�����[�h�{�^���̒ǉ� END
	}

}
