using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [�_��X����񃁃��e�i���X]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 ���s�j���� �_��X���Z���̑S�p���p���݃`�F�b�N�̒ǉ� 
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� 
	//--------------------------------------------------------------------------
	// ADD 2014.09.10 BEVAS�j�O�c �x�X�~�ߋ@�\�ǉ��Ή� 
	//--------------------------------------------------------------------------
	// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� 
	//--------------------------------------------------------------------------
	public class �X����� : ���ʃt�H�[��//System.Windows.Forms.Form
	{
		public  int    i�A�N�e�B�u�e�f = 0;
		private string s�X�V����   = "00000000000000";
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� START
		private bool b�x�X�~�߂e�f�P = false;
		private bool b�x�X�~�߂e�f�Q = false;
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� END

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label lab�����;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�_��X����;
		private System.Windows.Forms.Label lab�_��X���Z��;
		private System.Windows.Forms.Label label1;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�_��X���Z���Q;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�_��X���Z���P;
		private System.Windows.Forms.Label lab�_��X���X��;
		private System.Windows.Forms.Label lab�_��X���d�b;
		private System.Windows.Forms.ComboBox cb�_��X����;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�_��X���d�b�Q;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�_��X���d�b�R;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�_��X���d�b�P;
		private System.Windows.Forms.Button btn�_��X���X��;
		private System.Windows.Forms.Panel pnl�_��X��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�_��X���X�ւP;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�_��X���X�ւQ;
		private System.Windows.Forms.Button btn���;
		private System.Windows.Forms.Button btn�o�^;
		private System.Windows.Forms.Label lab�_��X�����;
		private System.Windows.Forms.Label lab�_��X�����^�C�g��;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnl�X���R�[�h;
		private System.Windows.Forms.Button btn�X�������s;
		private System.Windows.Forms.Button btn�X����񌟍�;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�X���R�[�h;
		private System.Windows.Forms.Label lab�X���R�[�h;
		private System.Windows.Forms.Label lab�n��P;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�n��P;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�n��Q;
		private System.Windows.Forms.Label lab�n��Q;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox����;
		private System.Windows.Forms.RadioButton rbtn���ʑΉ�;
		private System.Windows.Forms.RadioButton rbtn���ʔ�Ή�;
		private System.Windows.Forms.GroupBox groupBox���q;
		private System.Windows.Forms.RadioButton rbtn���q�Ή�;
		private System.Windows.Forms.RadioButton rbtn���q��Ή�;
		private System.ComponentModel.IContainer components = null;

		public �X�����()
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
			this.tex�_��X���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.pnl�_��X�� = new System.Windows.Forms.Panel();
			this.groupBox���q = new System.Windows.Forms.GroupBox();
			this.rbtn���q��Ή� = new System.Windows.Forms.RadioButton();
			this.rbtn���q�Ή� = new System.Windows.Forms.RadioButton();
			this.groupBox���� = new System.Windows.Forms.GroupBox();
			this.rbtn���ʔ�Ή� = new System.Windows.Forms.RadioButton();
			this.rbtn���ʑΉ� = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.tex�n��Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�n��Q = new System.Windows.Forms.Label();
			this.tex�n��P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�n��P = new System.Windows.Forms.Label();
			this.btn��� = new System.Windows.Forms.Button();
			this.btn�o�^ = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tex�_��X���d�b�Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�_��X���d�b�R = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�_��X���d�b�P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.cb�_��X���� = new System.Windows.Forms.ComboBox();
			this.lab�_��X���d�b = new System.Windows.Forms.Label();
			this.lab�_��X���X�� = new System.Windows.Forms.Label();
			this.lab�_��X����� = new System.Windows.Forms.Label();
			this.lab����� = new System.Windows.Forms.Label();
			this.lab�_��X���Z�� = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tex�_��X���X�ւP = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�_��X���X�ւQ = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn�_��X���X�� = new System.Windows.Forms.Button();
			this.tex�_��X���Z���P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�_��X���Z���Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab�_��X�����^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn���� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pnl�X���R�[�h = new System.Windows.Forms.Panel();
			this.btn�X����񌟍� = new System.Windows.Forms.Button();
			this.btn�X�������s = new System.Windows.Forms.Button();
			this.lab�X���R�[�h = new System.Windows.Forms.Label();
			this.tex�X���R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.pnl�_��X��.SuspendLayout();
			this.groupBox���q.SuspendLayout();
			this.groupBox����.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.pnl�X���R�[�h.SuspendLayout();
			this.SuspendLayout();
			// 
			// tex�_��X����
			// 
			this.tex�_��X����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�_��X����.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�_��X����.Location = new System.Drawing.Point(98, 6);
			this.tex�_��X����.MaxLength = 20;
			this.tex�_��X����.Name = "tex�_��X����";
			this.tex�_��X����.Size = new System.Drawing.Size(326, 23);
			this.tex�_��X����.TabIndex = 0;
			this.tex�_��X����.Text = "";
			// 
			// pnl�_��X��
			// 
			this.pnl�_��X��.BackColor = System.Drawing.Color.Honeydew;
			this.pnl�_��X��.Controls.Add(this.groupBox���q);
			this.pnl�_��X��.Controls.Add(this.groupBox����);
			this.pnl�_��X��.Controls.Add(this.label2);
			this.pnl�_��X��.Controls.Add(this.tex�n��Q);
			this.pnl�_��X��.Controls.Add(this.lab�n��Q);
			this.pnl�_��X��.Controls.Add(this.tex�n��P);
			this.pnl�_��X��.Controls.Add(this.lab�n��P);
			this.pnl�_��X��.Controls.Add(this.btn���);
			this.pnl�_��X��.Controls.Add(this.btn�o�^);
			this.pnl�_��X��.Controls.Add(this.label4);
			this.pnl�_��X��.Controls.Add(this.label9);
			this.pnl�_��X��.Controls.Add(this.label12);
			this.pnl�_��X��.Controls.Add(this.tex�_��X���d�b�Q);
			this.pnl�_��X��.Controls.Add(this.tex�_��X���d�b�R);
			this.pnl�_��X��.Controls.Add(this.tex�_��X���d�b�P);
			this.pnl�_��X��.Controls.Add(this.cb�_��X����);
			this.pnl�_��X��.Controls.Add(this.lab�_��X���d�b);
			this.pnl�_��X��.Controls.Add(this.lab�_��X���X��);
			this.pnl�_��X��.Controls.Add(this.lab�_��X�����);
			this.pnl�_��X��.Controls.Add(this.tex�_��X����);
			this.pnl�_��X��.Controls.Add(this.lab�����);
			this.pnl�_��X��.Controls.Add(this.lab�_��X���Z��);
			this.pnl�_��X��.Controls.Add(this.label1);
			this.pnl�_��X��.Controls.Add(this.tex�_��X���X�ւP);
			this.pnl�_��X��.Controls.Add(this.tex�_��X���X�ւQ);
			this.pnl�_��X��.Controls.Add(this.btn�_��X���X��);
			this.pnl�_��X��.Controls.Add(this.tex�_��X���Z���P);
			this.pnl�_��X��.Controls.Add(this.tex�_��X���Z���Q);
			this.pnl�_��X��.Location = new System.Drawing.Point(1, 6);
			this.pnl�_��X��.Name = "pnl�_��X��";
			this.pnl�_��X��.Size = new System.Drawing.Size(449, 308);
			this.pnl�_��X��.TabIndex = 0;
			// 
			// groupBox���q
			// 
			this.groupBox���q.Controls.Add(this.rbtn���q��Ή�);
			this.groupBox���q.Controls.Add(this.rbtn���q�Ή�);
			this.groupBox���q.Enabled = false;
			this.groupBox���q.ForeColor = System.Drawing.Color.LimeGreen;
			this.groupBox���q.Location = new System.Drawing.Point(102, 222);
			this.groupBox���q.Name = "groupBox���q";
			this.groupBox���q.Size = new System.Drawing.Size(334, 40);
			this.groupBox���q.TabIndex = 105;
			this.groupBox���q.TabStop = false;
			this.groupBox���q.Text = "���q�^��";
			// 
			// rbtn���q��Ή�
			// 
			this.rbtn���q��Ή�.Enabled = false;
			this.rbtn���q��Ή�.Location = new System.Drawing.Point(170, 12);
			this.rbtn���q��Ή�.Name = "rbtn���q��Ή�";
			this.rbtn���q��Ή�.TabIndex = 1;
			this.rbtn���q��Ή�.Text = "��Ή�";
			// 
			// rbtn���q�Ή�
			// 
			this.rbtn���q�Ή�.Enabled = false;
			this.rbtn���q�Ή�.Location = new System.Drawing.Point(26, 14);
			this.rbtn���q�Ή�.Name = "rbtn���q�Ή�";
			this.rbtn���q�Ή�.TabIndex = 0;
			this.rbtn���q�Ή�.Text = "�Ή�";
			// 
			// groupBox����
			// 
			this.groupBox����.Controls.Add(this.rbtn���ʔ�Ή�);
			this.groupBox����.Controls.Add(this.rbtn���ʑΉ�);
			this.groupBox����.ForeColor = System.Drawing.Color.LimeGreen;
			this.groupBox����.Location = new System.Drawing.Point(102, 176);
			this.groupBox����.Name = "groupBox����";
			this.groupBox����.Size = new System.Drawing.Size(334, 44);
			this.groupBox����.TabIndex = 104;
			this.groupBox����.TabStop = false;
			this.groupBox����.Text = "���R�ʉ^";
			// 
			// rbtn���ʔ�Ή�
			// 
			this.rbtn���ʔ�Ή�.Location = new System.Drawing.Point(170, 14);
			this.rbtn���ʔ�Ή�.Name = "rbtn���ʔ�Ή�";
			this.rbtn���ʔ�Ή�.TabIndex = 1;
			this.rbtn���ʔ�Ή�.Text = "��Ή�";
			// 
			// rbtn���ʑΉ�
			// 
			this.rbtn���ʑΉ�.Location = new System.Drawing.Point(26, 16);
			this.rbtn���ʑΉ�.Name = "rbtn���ʑΉ�";
			this.rbtn���ʑΉ�.TabIndex = 0;
			this.rbtn���ʑΉ�.Text = "�Ή�";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.LimeGreen;
			this.label2.Location = new System.Drawing.Point(44, 190);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 18);
			this.label2.TabIndex = 103;
			this.label2.Text = "�x�X�~��";
			// 
			// tex�n��Q
			// 
			this.tex�n��Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�n��Q.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�n��Q.Location = new System.Drawing.Point(98, 150);
			this.tex�n��Q.MaxLength = 3;
			this.tex�n��Q.Name = "tex�n��Q";
			this.tex�n��Q.Size = new System.Drawing.Size(40, 23);
			this.tex�n��Q.TabIndex = 14;
			this.tex�n��Q.Text = "";
			// 
			// lab�n��Q
			// 
			this.lab�n��Q.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�n��Q.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�n��Q.Location = new System.Drawing.Point(60, 156);
			this.lab�n��Q.Name = "lab�n��Q";
			this.lab�n��Q.Size = new System.Drawing.Size(38, 14);
			this.lab�n��Q.TabIndex = 102;
			this.lab�n��Q.Text = "�n��Q";
			// 
			// tex�n��P
			// 
			this.tex�n��P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�n��P.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�n��P.Location = new System.Drawing.Point(98, 126);
			this.tex�n��P.MaxLength = 3;
			this.tex�n��P.Name = "tex�n��P";
			this.tex�n��P.Size = new System.Drawing.Size(40, 23);
			this.tex�n��P.TabIndex = 13;
			this.tex�n��P.Text = "";
			// 
			// lab�n��P
			// 
			this.lab�n��P.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�n��P.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�n��P.Location = new System.Drawing.Point(60, 132);
			this.lab�n��P.Name = "lab�n��P";
			this.lab�n��P.Size = new System.Drawing.Size(38, 14);
			this.lab�n��P.TabIndex = 100;
			this.lab�n��P.Text = "�n��P";
			// 
			// btn���
			// 
			this.btn���.BackColor = System.Drawing.Color.Blue;
			this.btn���.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn���.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn���.ForeColor = System.Drawing.Color.White;
			this.btn���.Location = new System.Drawing.Point(388, 278);
			this.btn���.Name = "btn���";
			this.btn���.Size = new System.Drawing.Size(48, 22);
			this.btn���.TabIndex = 16;
			this.btn���.Text = "���";
			this.btn���.Click += new System.EventHandler(this.btn���_Click);
			// 
			// btn�o�^
			// 
			this.btn�o�^.BackColor = System.Drawing.Color.Blue;
			this.btn�o�^.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�o�^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�o�^.ForeColor = System.Drawing.Color.White;
			this.btn�o�^.Location = new System.Drawing.Point(334, 278);
			this.btn�o�^.Name = "btn�o�^";
			this.btn�o�^.Size = new System.Drawing.Size(48, 22);
			this.btn�o�^.TabIndex = 15;
			this.btn�o�^.Text = "�o�^";
			this.btn�o�^.Click += new System.EventHandler(this.btn�o�^_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.LimeGreen;
			this.label4.Location = new System.Drawing.Point(88, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 14);
			this.label4.TabIndex = 88;
			this.label4.Text = "�i";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label9.ForeColor = System.Drawing.Color.LimeGreen;
			this.label9.Location = new System.Drawing.Point(154, 108);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(12, 14);
			this.label9.TabIndex = 89;
			this.label9.Text = "�j";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label12.ForeColor = System.Drawing.Color.LimeGreen;
			this.label12.Location = new System.Drawing.Point(210, 108);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(12, 14);
			this.label12.TabIndex = 90;
			this.label12.Text = "�|";
			// 
			// tex�_��X���d�b�Q
			// 
			this.tex�_��X���d�b�Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�_��X���d�b�Q.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�_��X���d�b�Q.Location = new System.Drawing.Point(170, 102);
			this.tex�_��X���d�b�Q.MaxLength = 4;
			this.tex�_��X���d�b�Q.Name = "tex�_��X���d�b�Q";
			this.tex�_��X���d�b�Q.Size = new System.Drawing.Size(40, 23);
			this.tex�_��X���d�b�Q.TabIndex = 8;
			this.tex�_��X���d�b�Q.Text = "";
			// 
			// tex�_��X���d�b�R
			// 
			this.tex�_��X���d�b�R.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�_��X���d�b�R.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�_��X���d�b�R.Location = new System.Drawing.Point(224, 102);
			this.tex�_��X���d�b�R.MaxLength = 4;
			this.tex�_��X���d�b�R.Name = "tex�_��X���d�b�R";
			this.tex�_��X���d�b�R.Size = new System.Drawing.Size(40, 23);
			this.tex�_��X���d�b�R.TabIndex = 9;
			this.tex�_��X���d�b�R.Text = "";
			// 
			// tex�_��X���d�b�P
			// 
			this.tex�_��X���d�b�P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�_��X���d�b�P.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�_��X���d�b�P.Location = new System.Drawing.Point(98, 102);
			this.tex�_��X���d�b�P.MaxLength = 6;
			this.tex�_��X���d�b�P.Name = "tex�_��X���d�b�P";
			this.tex�_��X���d�b�P.Size = new System.Drawing.Size(56, 23);
			this.tex�_��X���d�b�P.TabIndex = 7;
			this.tex�_��X���d�b�P.Text = "";
			// 
			// cb�_��X����
			// 
			this.cb�_��X����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cb�_��X����.Location = new System.Drawing.Point(98, 54);
			this.cb�_��X����.Name = "cb�_��X����";
			this.cb�_��X����.Size = new System.Drawing.Size(88, 24);
			this.cb�_��X����.TabIndex = 4;
			// 
			// lab�_��X���d�b
			// 
			this.lab�_��X���d�b.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�_��X���d�b.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�_��X���d�b.Location = new System.Drawing.Point(58, 108);
			this.lab�_��X���d�b.Name = "lab�_��X���d�b";
			this.lab�_��X���d�b.Size = new System.Drawing.Size(30, 14);
			this.lab�_��X���d�b.TabIndex = 82;
			this.lab�_��X���d�b.Text = "�s�d�k";
			// 
			// lab�_��X���X��
			// 
			this.lab�_��X���X��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�_��X���X��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�_��X���X��.Location = new System.Drawing.Point(82, 36);
			this.lab�_��X���X��.Name = "lab�_��X���X��";
			this.lab�_��X���X��.Size = new System.Drawing.Size(14, 14);
			this.lab�_��X���X��.TabIndex = 81;
			this.lab�_��X���X��.Text = "��";
			// 
			// lab�_��X�����
			// 
			this.lab�_��X�����.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�_��X�����.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab�_��X�����.ForeColor = System.Drawing.Color.Blue;
			this.lab�_��X�����.Location = new System.Drawing.Point(0, 0);
			this.lab�_��X�����.Name = "lab�_��X�����";
			this.lab�_��X�����.Size = new System.Drawing.Size(22, 306);
			this.lab�_��X�����.TabIndex = 44;
			this.lab�_��X�����.Text = "�_��X�����";
			this.lab�_��X�����.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab�����
			// 
			this.lab�����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�����.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�����.Location = new System.Drawing.Point(56, 12);
			this.lab�����.Name = "lab�����";
			this.lab�����.Size = new System.Drawing.Size(42, 14);
			this.lab�����.TabIndex = 9;
			this.lab�����.Text = "�X����";
			// 
			// lab�_��X���Z��
			// 
			this.lab�_��X���Z��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�_��X���Z��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�_��X���Z��.Location = new System.Drawing.Point(44, 60);
			this.lab�_��X���Z��.Name = "lab�_��X���Z��";
			this.lab�_��X���Z��.Size = new System.Drawing.Size(54, 14);
			this.lab�_��X���Z��.TabIndex = 77;
			this.lab�_��X���Z��.Text = "�X���Z��";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.Location = new System.Drawing.Point(134, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 14);
			this.label1.TabIndex = 80;
			this.label1.Text = "�|";
			// 
			// tex�_��X���X�ւP
			// 
			this.tex�_��X���X�ւP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�_��X���X�ւP.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�_��X���X�ւP.Location = new System.Drawing.Point(98, 30);
			this.tex�_��X���X�ւP.MaxLength = 3;
			this.tex�_��X���X�ւP.Name = "tex�_��X���X�ւP";
			this.tex�_��X���X�ւP.Size = new System.Drawing.Size(34, 23);
			this.tex�_��X���X�ւP.TabIndex = 1;
			this.tex�_��X���X�ւP.Text = "";
			// 
			// tex�_��X���X�ւQ
			// 
			this.tex�_��X���X�ւQ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�_��X���X�ւQ.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�_��X���X�ւQ.Location = new System.Drawing.Point(154, 30);
			this.tex�_��X���X�ւQ.MaxLength = 4;
			this.tex�_��X���X�ւQ.Name = "tex�_��X���X�ւQ";
			this.tex�_��X���X�ւQ.Size = new System.Drawing.Size(42, 23);
			this.tex�_��X���X�ւQ.TabIndex = 2;
			this.tex�_��X���X�ւQ.Text = "";
			this.tex�_��X���X�ւQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�_��X���X�ւQ_KeyDown);
			this.tex�_��X���X�ւQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�_��X���X�ւQ_KeyPress);
			// 
			// btn�_��X���X��
			// 
			this.btn�_��X���X��.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�_��X���X��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�_��X���X��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�_��X���X��.ForeColor = System.Drawing.Color.White;
			this.btn�_��X���X��.Location = new System.Drawing.Point(204, 30);
			this.btn�_��X���X��.Name = "btn�_��X���X��";
			this.btn�_��X���X��.Size = new System.Drawing.Size(48, 22);
			this.btn�_��X���X��.TabIndex = 3;
			this.btn�_��X���X��.TabStop = false;
			this.btn�_��X���X��.Text = "����";
			this.btn�_��X���X��.Click += new System.EventHandler(this.btn�_��X���X��_Click);
			// 
			// tex�_��X���Z���P
			// 
			this.tex�_��X���Z���P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�_��X���Z���P.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�_��X���Z���P.Location = new System.Drawing.Point(186, 54);
			this.tex�_��X���Z���P.MaxLength = 16;
			this.tex�_��X���Z���P.Name = "tex�_��X���Z���P";
			this.tex�_��X���Z���P.Size = new System.Drawing.Size(262, 23);
			this.tex�_��X���Z���P.TabIndex = 5;
			this.tex�_��X���Z���P.Text = "";
			// 
			// tex�_��X���Z���Q
			// 
			this.tex�_��X���Z���Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�_��X���Z���Q.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�_��X���Z���Q.Location = new System.Drawing.Point(98, 78);
			this.tex�_��X���Z���Q.MaxLength = 20;
			this.tex�_��X���Z���Q.Name = "tex�_��X���Z���Q";
			this.tex�_��X���Z���Q.Size = new System.Drawing.Size(326, 23);
			this.tex�_��X���Z���Q.TabIndex = 6;
			this.tex�_��X���Z���Q.Text = "";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(462, 26);
			this.panel6.TabIndex = 12;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab�_��X�����^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(462, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab�_��X�����^�C�g��
			// 
			this.lab�_��X�����^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�_��X�����^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�_��X�����^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab�_��X�����^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab�_��X�����^�C�g��.Name = "lab�_��X�����^�C�g��";
			this.lab�_��X�����^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab�_��X�����^�C�g��.TabIndex = 0;
			this.lab�_��X�����^�C�g��.Text = "�_��X�����";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(462, 58);
			this.panel8.TabIndex = 0;
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(76, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(376, 50);
			this.tex���b�Z�[�W.TabIndex = 30;
			this.tex���b�Z�[�W.TabStop = false;
			this.tex���b�Z�[�W.Text = "";
			// 
			// btn����
			// 
			this.btn����.ForeColor = System.Drawing.Color.Red;
			this.btn����.Location = new System.Drawing.Point(8, 6);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(54, 48);
			this.btn����.TabIndex = 5;
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pnl�_��X��);
			this.groupBox2.Location = new System.Drawing.Point(4, 86);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(452, 316);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(22, 408);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 14);
			this.label5.TabIndex = 31;
			this.label5.Text = "�S�ĕK�{���͍��ڂł��B";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
			this.groupBox1.Controls.Add(this.pnl�X���R�[�h);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(26, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(430, 40);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// pnl�X���R�[�h
			// 
			this.pnl�X���R�[�h.BackColor = System.Drawing.Color.Honeydew;
			this.pnl�X���R�[�h.Controls.Add(this.btn�X����񌟍�);
			this.pnl�X���R�[�h.Controls.Add(this.btn�X�������s);
			this.pnl�X���R�[�h.Controls.Add(this.lab�X���R�[�h);
			this.pnl�X���R�[�h.Controls.Add(this.tex�X���R�[�h);
			this.pnl�X���R�[�h.ForeColor = System.Drawing.Color.Black;
			this.pnl�X���R�[�h.Location = new System.Drawing.Point(1, 6);
			this.pnl�X���R�[�h.Name = "pnl�X���R�[�h";
			this.pnl�X���R�[�h.Size = new System.Drawing.Size(427, 32);
			this.pnl�X���R�[�h.TabIndex = 0;
			// 
			// btn�X����񌟍�
			// 
			this.btn�X����񌟍�.BackColor = System.Drawing.Color.Blue;
			this.btn�X����񌟍�.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�X����񌟍�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�X����񌟍�.ForeColor = System.Drawing.Color.White;
			this.btn�X����񌟍�.Location = new System.Drawing.Point(124, 6);
			this.btn�X����񌟍�.Name = "btn�X����񌟍�";
			this.btn�X����񌟍�.Size = new System.Drawing.Size(46, 22);
			this.btn�X����񌟍�.TabIndex = 1;
			this.btn�X����񌟍�.TabStop = false;
			this.btn�X����񌟍�.Text = "����";
			this.btn�X����񌟍�.Click += new System.EventHandler(this.btn�X����񌟍�_Click);
			// 
			// btn�X�������s
			// 
			this.btn�X�������s.BackColor = System.Drawing.Color.Blue;
			this.btn�X�������s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�X�������s.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�X�������s.ForeColor = System.Drawing.Color.White;
			this.btn�X�������s.Location = new System.Drawing.Point(176, 6);
			this.btn�X�������s.Name = "btn�X�������s";
			this.btn�X�������s.Size = new System.Drawing.Size(48, 22);
			this.btn�X�������s.TabIndex = 2;
			this.btn�X�������s.Text = "���s";
			this.btn�X�������s.Click += new System.EventHandler(this.btn�X�������s_Click);
			// 
			// lab�X���R�[�h
			// 
			this.lab�X���R�[�h.BackColor = System.Drawing.Color.Honeydew;
			this.lab�X���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�X���R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�X���R�[�h.Location = new System.Drawing.Point(4, 8);
			this.lab�X���R�[�h.Name = "lab�X���R�[�h";
			this.lab�X���R�[�h.Size = new System.Drawing.Size(72, 16);
			this.lab�X���R�[�h.TabIndex = 6;
			this.lab�X���R�[�h.Text = "�X���R�[�h";
			// 
			// tex�X���R�[�h
			// 
			this.tex�X���R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex�X���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�X���R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�X���R�[�h.Location = new System.Drawing.Point(76, 4);
			this.tex�X���R�[�h.MaxLength = 4;
			this.tex�X���R�[�h.Name = "tex�X���R�[�h";
			this.tex�X���R�[�h.Size = new System.Drawing.Size(42, 23);
			this.tex�X���R�[�h.TabIndex = 0;
			this.tex�X���R�[�h.Text = "";
			this.tex�X���R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�X���R�[�h_KeyDown);
			this.tex�X���R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�X���R�[�h_KeyPress);
			// 
			// �X�����
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(460, 582);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(466, 607);
			this.Name = "�X�����";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 �_��X����񃁃��e�i���X";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.�X�����_Load);
			this.Closed += new System.EventHandler(this.�X�����_Closed);
			this.Activated += new System.EventHandler(this.�X�����_Activated);
			this.pnl�_��X��.ResumeLayout(false);
			this.groupBox���q.ResumeLayout(false);
			this.groupBox����.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.pnl�X���R�[�h.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>
		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void �X�����_Load(object sender, System.EventArgs e)
		{
			// �����̏����ݒ�
			cb�_��X����.Items.Clear();
			cb�_��X����.Items.AddRange(sa��);

			�N���A();
			�X�V���[�h();

// ADD 2014.09.10 BEVAS)�O�c �x�X�~�ߒǉ��Ή� START
			// �Ǘ��Ҍ����ł̂݁A�ؑւ�������
			if(gs�Ǘ��ҋ敪 == "1")
			{
				// �Ǘ��҂̂�
				if(gs����R�[�h == "oji")
				{
					// ���q�^���̊Ǘ��҂̏ꍇ�A
					// ���q���̎x�X�~�ߑΉ��݂̂�ύX����
					this.groupBox����.Enabled = false;
					this.groupBox���q.Enabled = true;
					rbtn���ʑΉ�.Enabled = false;
					rbtn���ʔ�Ή�.Enabled = false;
					rbtn���q�Ή�.Enabled = true;
					rbtn���q��Ή�.Enabled = true;	
				}
				else if(gs����R�[�h == "honbu")
				{
					// ���R�ʉ^�̊Ǘ��҂̏ꍇ�A
					// ���ʑ��E���q���̗����̎x�X�~�ߑΉ���ύX����
					this.groupBox����.Enabled = true;
					this.groupBox���q.Enabled = true;
					rbtn���ʑΉ�.Enabled = true;
					rbtn���ʔ�Ή�.Enabled = true;
					rbtn���q�Ή�.Enabled = true;
					rbtn���q��Ή�.Enabled = true;	
				}
			}
			else
			{
				// ����ȊO�̃��O�C�����[�U�[�i�x�X�֌W�ҁA���[�U�[�j�̏ꍇ�A
				// ���ʑ��E���q���̗����̎x�X�~�ߑΉ���ύX�s����
				this.groupBox����.Enabled = false;
				this.groupBox���q.Enabled = false;
				rbtn���ʑΉ�.Enabled = false;
				rbtn���ʔ�Ή�.Enabled = false;
				rbtn���q�Ή�.Enabled = false;
				rbtn���q��Ή�.Enabled = false;	
			}
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� START
			b�x�X�~�߂e�f�P = false;
			b�x�X�~�߂e�f�Q = false;
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� END
// ADD 2014.09.10 BEVAS)�O�c �x�X�~�ߒǉ��Ή� END

			tex�_��X����.Focus();
		}

		private void �X�V���[�h()
		{
			if(gs�X���R�[�h.Trim().Length == 0)
			{
				//�Ǘ��X���̏ꍇ
				btn�X�������s.Visible = true;
				btn�X����񌟍�.Visible = true;
				lab�n��P.Visible = true;
				tex�n��P.Visible = true;
				lab�n��Q.Visible = true;
				tex�n��Q.Visible = true;
				btn���.Visible = true;
			}
			else
			{
				//�X���̏ꍇ
				btn�X�������s.Visible = false;
				btn�X����񌟍�.Visible = false;
				lab�n��P.Visible = false;
				tex�n��P.Visible = false;
				lab�n��Q.Visible = false;
				tex�n��Q.Visible = false;
				btn���.Visible = false;
			}

			pnl�X���R�[�h.Enabled = false;
			pnl�_��X��.Enabled   = true;
			btn�o�^.Text = "�X�V";
			btn�o�^.Enabled = true;
		}

		private void tex�X���R�[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
// MOD 2007.01.20 ���s�j���� ��ʒ��� START
//				�X����񌟍�();
				tex�X���R�[�h.Text = tex�X���R�[�h.Text.Trim();
				if(tex�X���R�[�h.Text.Length == 3)
					�X����񌟍�();
				else
					�X�����ꗗ();
// MOD 2007.01.20 ���s�j���� ��ʒ��� END
			}
		}

		private void tex�X���R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�X����񌟍�.Focus();
				�X�����ꗗ();
				e.Handled = true;
			}
		}

		private void btn�X����񌟍�_Click(object sender, System.EventArgs e)
		{
			�X�����ꗗ();
		}

		private void btn�X�������s_Click(object sender, System.EventArgs e)
		{
			�X����񌟍�();
		}

		private void �X�����ꗗ()
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			//������ʂ�\������
			if(g�X������ == null) g�X������ = new �X������();
			g�X������.Left = this.Left + 404;
//			g�X������.Left = this.Left;
			g�X������.Top = this.Top;

			// �R�[�h�̏����\��
//			g�X������.s�X���R�[�h = s�X���R�[�h.Trim();
// ADD 2007.01.20 ���s�j���� �����\���̃N���A START
			g�X������.s�X���R�[�h = "";
			g�X������.s�X���� = "";
// ADD 2007.01.20 ���s�j���� �����\���̃N���A END
			g�X������.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g�X������.s�X���R�[�h.Trim().Length > 0)
			{
				tex�X���R�[�h.Text = g�X������.s�X���R�[�h.Trim();
				�X����񌟍�();
			}
			else
			{
				tex�X���R�[�h.Focus();
			}
		}

		private void �X����񌟍�()
		{
			tex���b�Z�[�W.Text = "";
			tex�X���R�[�h.Text = tex�X���R�[�h.Text.Trim();
			if(!�K�{�`�F�b�N(tex�X���R�[�h, "�X���R�[�h")) return;
			if(!���p�`�F�b�N(tex�X���R�[�h, "�X���R�[�h")) return;

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[1];
				sKey[0] = tex�X���R�[�h.Text;
				string[] sData = sv_maintenance.Get_ShopInf(gsa���[�U, sKey);
// ADD 2014.09.10 BEVAS)�O�c �x�X�~�ߒǉ��Ή� START
				string[] sDeliData = sv_maintenance.Sel_GeneralDelivery(gsa���[�U, sKey);
// ADD 2014.09.10 BEVAS)�O�c �x�X�~�ߒǉ��Ή� END

// ADD 2014.09.10 BEVAS)�O�c �x�X�~�ߒǉ��Ή� START
				if (sData[0].Equals("����I��"))
				{
// ADD 2014.09.10 BEVAS)�O�c �x�X�~�ߒǉ��Ή� END
					tex���b�Z�[�W.Text = "";

					//�e���ڂ̐ݒ�

					//�X�����
					i�A�N�e�B�u�e�f = 0;

					//�_��X�����
					tex�_��X����.Text   = sData[1];
					if(sData[2].Length > 0)
						cb�_��X����.SelectedIndex = int.Parse(sData[2]);
					else
						cb�_��X����.SelectedIndex = 0;
					tex�_��X���Z���P.Text = sData[3];
					tex�_��X���Z���Q.Text = sData[4];

					string s�_��X���X�� = sData[5];
					if(s�_��X���X��.Length <= 3){
						tex�_��X���X�ւP.Text = s�_��X���X��;
					}else{
						tex�_��X���X�ւP.Text = s�_��X���X��.Substring(0,3);
						tex�_��X���X�ւQ.Text = s�_��X���X��.Substring(3);
					}

					string[] �_��X���d�b  = sData[6].Trim().Split('-');
					if(�_��X���d�b.Length > 0) tex�_��X���d�b�P.Text = �_��X���d�b[0];
					if(�_��X���d�b.Length > 1) tex�_��X���d�b�Q.Text = �_��X���d�b[1];
					if(�_��X���d�b.Length > 2) tex�_��X���d�b�R.Text = �_��X���d�b[2];

// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 START
//					string[] �_��X���e�`�w  = sData[7].Trim().Split('-');
//					if(�_��X���e�`�w.Length > 0) tex�_��X���e�`�w�P.Text = �_��X���e�`�w[0];
//					if(�_��X���e�`�w.Length > 1) tex�_��X���e�`�w�Q.Text = �_��X���e�`�w[1];
//					if(�_��X���e�`�w.Length > 2) tex�_��X���e�`�w�R.Text = �_��X���e�`�w[2];
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 END

					tex�n��P.Text = sData[8];
					tex�n��Q.Text = sData[9];

					//�X�V���
					s�X�V���� = sData[10];

					�X�V���[�h();
					tex�_��X����.Focus();
				}
				else
				{
					tex���b�Z�[�W.Text = sData[0];
					�r�[�v��();
					if(gs�X���R�[�h.Trim().Length == 0){
						pnl�X���R�[�h.Enabled = true;
						tex�X���R�[�h.Focus();
					}
				}
// ADD 2014.09.10 BEVAS)�O�c �x�X�~�ߒǉ��Ή� START
				if (sDeliData[0].Equals("����I��"))
				{
					if ((sDeliData[3].Trim()).Length > 6) 
					{
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� START
						//���ʑ�
						if(sDeliData[1].Equals("1"))
						{
							b�x�X�~�߂e�f�P = true;
						}
						//���q��
						if(sDeliData[2].Equals("1"))
						{
							b�x�X�~�߂e�f�Q = true;
						}
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� END
						// �Ǘ��Ҍ����ł̂݁A�ؑւ�������
						if(gs�Ǘ��ҋ敪 == "1")
						{
							// �Ǘ��҂̂�
							if(gs����R�[�h == "oji")
							{
								// ���q�^���̊Ǘ��҂̏ꍇ�A
								// ���q���̎x�X�~�ߑΉ��݂̂�ύX����
								this.groupBox����.Enabled = false;
								this.groupBox���q.Enabled = true;
								rbtn���ʑΉ�.Enabled = false;
								rbtn���ʔ�Ή�.Enabled = false;
								rbtn���q�Ή�.Enabled = true;
								rbtn���q��Ή�.Enabled = true;	
							}
							else if(gs����R�[�h == "honbu")
							{
								// ���R�ʉ^�̊Ǘ��҂̏ꍇ�A
								// ���ʑ��E���q���̗����̎x�X�~�ߑΉ���ύX����
								this.groupBox����.Enabled = true;
								this.groupBox���q.Enabled = true;
								rbtn���ʑΉ�.Enabled = true;
								rbtn���ʔ�Ή�.Enabled = true;
								rbtn���q�Ή�.Enabled = true;
								rbtn���q��Ή�.Enabled = true;	
							}
						}
						else
						{
							// ����ȊO�̃��O�C�����[�U�[�i�x�X�֌W�ҁA���[�U�[�j�̏ꍇ�A
							// ���ʑ��E���q���̗����̎x�X�~�ߑΉ���ύX�s����
							this.groupBox����.Enabled = false;
							this.groupBox���q.Enabled = false;
							rbtn���ʑΉ�.Enabled = false;
							rbtn���ʔ�Ή�.Enabled = false;
							rbtn���q�Ή�.Enabled = false;
							rbtn���q��Ή�.Enabled = false;	
						}

						// ���W�I�{�^���̃`�F�b�N�\���i���R�ʉ^�p�j
						if (sDeliData[1].Equals("1"))
						{
							rbtn���ʑΉ�.Checked = true;
							rbtn���ʔ�Ή�.Checked = false;
						} 
						else 
						{
							rbtn���ʑΉ�.Checked = false;
							rbtn���ʔ�Ή�.Checked = true;
						}

						// ���W�I�{�^���̃`�F�b�N�\���i���q�^���p�j
						if (sDeliData[2].Equals("1"))
						{
							rbtn���q�Ή�.Checked = true;
							rbtn���q��Ή�.Checked = false;
						}
						else
						{
							rbtn���q�Ή�.Checked = false;
							rbtn���q��Ή�.Checked = true;
						}
					}
					else 
					{
						// �X�֔ԍ����Ȃ����߁A�x�X�~�ߖ���
						this.groupBox����.Enabled = false;
						this.groupBox���q.Enabled = false;
						rbtn���ʑΉ�.Enabled = false;
						rbtn���ʔ�Ή�.Enabled = false;
						rbtn���q�Ή�.Enabled = false;
						rbtn���q��Ή�.Enabled = false;		
					}
				} 
				else 
				{
					// �x�X�~�ߖ���
					this.groupBox����.Enabled = false;
					this.groupBox���q.Enabled = false;
					rbtn���ʑΉ�.Enabled = false;
					rbtn���ʔ�Ή�.Enabled = false;
					rbtn���q�Ή�.Enabled = false;
					rbtn���q��Ή�.Enabled = false;		
				}
// ADD 2014.09.10 BEVAS)�O�c �x�X�~�ߒǉ��Ή� END

			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				if(gs�X���R�[�h.Trim().Length == 0){
					pnl�X���R�[�h.Enabled = true;
					tex�X���R�[�h.Focus();
				}
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn�o�^_Click(object sender, System.EventArgs e)
		{

			if(�o�^_�`�F�b�N() != true) return;
			try
			{
// MOD 2014.09.12 BEVAS) �O�c �x�X�~�ߋ@�\�ǉ� START
				// �x�X�~�߂e�f�P�C�Q��ǉ�
				//string[] sData  = new string[12];
				string[] sData  = new string[14];
// MOD 2014.09.12 BEVAS) �O�c �x�X�~�ߋ@�\�ǉ� END

				//�X���R�[�h
				sData[0] = tex�X���R�[�h.Text;
				//�_��X�����
				sData[1] = tex�_��X����.Text;
				sData[2] = cb�_��X����.SelectedIndex.ToString("00");
				sData[3] = tex�_��X���Z���P.Text;
				sData[4] = tex�_��X���Z���Q.Text;

				sData[5] = tex�_��X���X�ւP.Text + tex�_��X���X�ւQ.Text;
				sData[6] = tex�_��X���d�b�P.Text;
				if(tex�_��X���d�b�Q.Text.Length > 0) sData[6] += "-" + tex�_��X���d�b�Q.Text;
				if(tex�_��X���d�b�R.Text.Length > 0) sData[6] += "-" + tex�_��X���d�b�R.Text;

// MOD 2006.12.11 ���s�j�����J�@�e�`�w�폜 START
//				sData[7] = tex�_��X���e�`�w�P.Text;
//				if(tex�_��X���e�`�w�Q.Text.Length > 0) sData[7] += "-" + tex�_��X���e�`�w�Q.Text;
//				if(tex�_��X���e�`�w�R.Text.Length > 0) sData[7] += "-" + tex�_��X���e�`�w�R.Text;
				sData[7] = " ";
// MOD 2006.12.11 ���s�j�����J�@�e�`�w�폜 END

				sData[8] = tex�n��P.Text;
				sData[9] = tex�n��Q.Text;

				//�X�V���
				sData[10] = s�X�V����;
				sData[11] = gs���p�҃R�[�h;

// ADD 2014.09.12 BEVAS) �O�c �x�X�~�ߋ@�\�ǉ� START
				if (rbtn���ʑΉ�.Enabled) 
				{
					if (rbtn���ʑΉ�.Checked == true) 
					{
						sData[12] = "1";
					} 
					else 
					{
						sData[12] = "0";
					}
				} 
//				else 
//				{
//					sData[12] = "0";
//				}
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� START
				else
				{
					//�ێ����Ă����l�ɂ��ݒ�
					if(b�x�X�~�߂e�f�P)
					{
						sData[12] = "1";
					}
					else
					{
						sData[12] = "0";
					}
				}
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� END
				if (rbtn���q�Ή�.Enabled) 
				{
					if (rbtn���q�Ή�.Checked == true) 
					{
						sData[13] = "1";
					} 
					else 
					{
						sData[13] = "0";
					}
				} 
//				else 
//				{
//					sData[13] = "0";
//				}
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� START
				else
				{
					//�ێ����Ă����l�ɂ��ݒ�
					if(b�x�X�~�߂e�f�Q)
					{
						sData[13] = "1";
					}
					else
					{
						sData[13] = "0";
					}
				}
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� END
// ADD 2014.09.12 BEVAS) �O�c �x�X�~�ߋ@�\�ǉ� END

				for(int iCnt = 0; iCnt < sData.Length ; iCnt++)
					if(sData[iCnt].Length ==0) sData[iCnt] = " ";

				string[] sList = new string[1]{""};
				if (btn�o�^.Text.Equals("�o�^"))
				{
					;
				}
				else
				{
					sList = sv_maintenance.Upd_ShopInf(gsa���[�U, sData);
					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
						tex���b�Z�[�W.Text = "";
						//����̍X�V
						s�X�V���� = sList[1].Trim();
						tex�_��X����.Focus();
// ADD 2006.11.10 ���s�j���؁@�X�V��̉�ʑJ�ڂȂǂ̕ύX START
						if(gs�X���R�[�h.Trim().Length == 0){
							//[btn���_Click]�Ɠ�������
							�N���A();
							pnl�X���R�[�h.Enabled = true;
// ADD 2007.01.26 ���s�j���� ��ʒ��� START
							pnl�_��X��.Enabled = false;
// ADD 2007.01.26 ���s�j���� ��ʒ��� END
							tex�X���R�[�h.Text = " ";
							tex�X���R�[�h.Focus();
						}else{
							this.Close();
						}
// ADD 2006.11.10 ���s�j���؁@�X�V��̉�ʑJ�ڂȂǂ̕ύX END
					}
					else
					{
						�r�[�v��();
					}
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				tex�_��X����.Focus();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private bool �o�^_�`�F�b�N()
		{
			if(gs�X���R�[�h.Trim().Length != 0)
			{
				if (gs�X���R�[�h.Trim() != tex�X���R�[�h.Text.Trim())
				{
					MessageBox.Show("�X���R�[�h������������܂���B�i" + tex�X���R�[�h.Text.Trim() + "�j","���̓`�F�b�N", MessageBoxButtons.OK);
					tex�X���R�[�h.Focus();
					return false;
				}
			}

			//�s������
			tex�_��X����.Text = tex�_��X����.Text.Trim();
			tex�_��X���X�ւP.Text = tex�_��X���X�ւP.Text.Trim();
			tex�_��X���X�ւQ.Text = tex�_��X���X�ւQ.Text.Trim();
			cb�_��X����.Text = cb�_��X����.Text.Trim();
			tex�_��X���Z���P.Text = tex�_��X���Z���P.Text.Trim();
			tex�_��X���Z���Q.Text = tex�_��X���Z���Q.Text.Trim();
			tex�_��X���d�b�P.Text = tex�_��X���d�b�P.Text.Trim();
			tex�_��X���d�b�Q.Text = tex�_��X���d�b�Q.Text.Trim();
			tex�_��X���d�b�R.Text = tex�_��X���d�b�R.Text.Trim();
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 START
//			tex�_��X���e�`�w�P.Text = tex�_��X���e�`�w�P.Text.Trim();
//			tex�_��X���e�`�w�Q.Text = tex�_��X���e�`�w�Q.Text.Trim();
//			tex�_��X���e�`�w�R.Text = tex�_��X���e�`�w�R.Text.Trim();
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 END
			tex�n��P.Text = tex�n��P.Text.Trim();
			tex�n��Q.Text = tex�n��Q.Text.Trim();

			//�K�{�`�F�b�N
// MOD 2014.09.24 BEVAS)�O�c �_�񏑍��ڂ̓��̓`�F�b�N�̊ɘa START
			bool �G���[�`�F�b�NFG = true;
			//if (!�K�{�`�F�b�N(tex�_��X����, "�X����")) return false;
			if (tex�_��X����.Text.Length == 0) �G���[�`�F�b�NFG = false;
			//if (!�K�{�`�F�b�N(tex�_��X���X�ւP, "�X�֔ԍ�")) return false;
			if (tex�_��X���X�ւP.Text.Length == 0) �G���[�`�F�b�NFG = false;
			//if (!�K�{�`�F�b�N(tex�_��X���X�ւQ, "�X�֔ԍ�")) return false;
			if (tex�_��X���X�ւQ.Text.Length == 0) �G���[�`�F�b�NFG = false;

			//if (!�K�{�`�F�b�N(cb�_��X����, "�s���{��")) return false;
			if (cb�_��X����.Text.Length == 0) �G���[�`�F�b�NFG = false;

			//if (!�K�{�`�F�b�N(tex�_��X���Z���P, "�Z���P")) return false;
			if (tex�_��X���Z���P.Text.Length == 0) �G���[�`�F�b�NFG = false;

			//if (!�K�{�`�F�b�N(tex�_��X���d�b�P, "�d�b�ԍ�")) return false;
			if (tex�_��X���d�b�P.Text.Length == 0) �G���[�`�F�b�NFG = false;
			//if (!�K�{�`�F�b�N(tex�_��X���d�b�Q, "�d�b�ԍ�")) return false;
			if (tex�_��X���d�b�Q.Text.Length == 0) �G���[�`�F�b�NFG = false;
			//if (!�K�{�`�F�b�N(tex�_��X���d�b�R, "�d�b�ԍ�")) return false;
			if (tex�_��X���d�b�R.Text.Length == 0) �G���[�`�F�b�NFG = false;

			if (!�G���[�`�F�b�NFG) 
			{
				if (MessageBox.Show("�����͍��ڂ��������܂����X�V���p�����Ă���낵���ł��傤���B","���͊m�F",MessageBoxButtons.YesNo) == DialogResult.No) 
				{
					// No �̏ꍇ�͏����𒆒f���ďI������
					return false;
				}
			}
// MOD 2014.09.24 BEVAS)�O�c �_�񏑍��ڂ̓��̓`�F�b�N�ɘa END
		
			// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 START
//			if (!�K�{�`�F�b�N(tex�_��X���e�`�w�P, "�e�`�w�ԍ�")) return false;
//			if (!�K�{�`�F�b�N(tex�_��X���e�`�w�Q, "�e�`�w�ԍ�")) return false;
//			if (!�K�{�`�F�b�N(tex�_��X���e�`�w�R, "�e�`�w�ԍ�")) return false;
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 END

			//�^�`�F�b�N
			if (!�S�p�`�F�b�N(tex�_��X����, "�X����")) return false;
			if (!���p�`�F�b�N(tex�_��X���X�ւP, "�X�֔ԍ�")) return false;
			if (!���p�`�F�b�N(tex�_��X���X�ւQ, "�X�֔ԍ�")) return false;
//			if (!�S�p�`�F�b�N(tex�_��X���Z���P, "�X���Z���P")) return false;
//			if (!�S�p�`�F�b�N(tex�_��X���Z���Q, "�X���Z���Q")) return false;
// ADD 2008.05.07 ���s�j���� �_��X���Z���̑S�p���p���݃`�F�b�N�̒ǉ� START
			if(!�S�p���p���݃`�F�b�N(tex�_��X���Z���P, "�X���Z���P")) return false;
			if(!�S�p���p���݃`�F�b�N(tex�_��X���Z���Q, "�X���Z���Q")) return false;
// ADD 2008.05.07 ���s�j���� �_��X���Z���̑S�p���p���݃`�F�b�N�̒ǉ� END
			if (!���p�`�F�b�N(tex�_��X���d�b�P, "�d�b�ԍ�")) return false;
			if (!���p�`�F�b�N(tex�_��X���d�b�Q, "�d�b�ԍ�")) return false;
			if (!���p�`�F�b�N(tex�_��X���d�b�R, "�d�b�ԍ�")) return false;
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 START
//			if (!���p�`�F�b�N(tex�_��X���e�`�w�P, "�e�`�w�ԍ�")) return false;
//			if (!���p�`�F�b�N(tex�_��X���e�`�w�Q, "�e�`�w�ԍ�")) return false;
//			if (!���p�`�F�b�N(tex�_��X���e�`�w�R, "�e�`�w�ԍ�")) return false;
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 END
			if (!���p�`�F�b�N(tex�n��P, "�n��P")) return false;
			if (!���p�`�F�b�N(tex�n��Q, "�n��Q")) return false;

// ADD 2006.11.17 ���s�j���؁@�d�b�ԍ��̌����`�F�b�N�̒ǉ� START
			if(tex�_��X���d�b�P.Text.Length + tex�_��X���d�b�Q.Text.Length + tex�_��X���d�b�R.Text.Length > 11)
			{
				MessageBox.Show("�d�b�ԍ���11���ȓ��œ��͂��Ă�������",
					"���̓`�F�b�N",MessageBoxButtons.OK);
				tex�_��X���d�b�P.Focus();
				return false;
			}
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 START
//			if(tex�_��X���e�`�w�P.Text.Length + tex�_��X���e�`�w�Q.Text.Length + tex�_��X���e�`�w�R.Text.Length > 11)
//			{
//				MessageBox.Show("�e�`�w�ԍ���11���ȓ��œ��͂��Ă�������",
//					"���̓`�F�b�N",MessageBoxButtons.OK);
//				tex�_��X���e�`�w�P.Focus();
//				return false;
//			}
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 END
// ADD 2006.11.17 ���s�j���؁@�d�b�ԍ��̌����`�F�b�N�̒ǉ� END

// MOD 2014.09.24 BEVAS) �O�c �X�֔ԍ������͎��̃`�F�b�N����� START
			if ((tex�_��X���X�ւP.Text.Length > 0) || (tex�_��X���X�ւQ.Text.Length > 0)) 
			{
				//�}�X�^�`�F�b�N
				if (!�X�֌���(tex�_��X���X�ւP, tex�_��X���X�ւQ, 
					cb�_��X����, tex�_��X���Z���P, tex�_��X���Z���Q, null))
				{
					MessageBox.Show("�X�֔ԍ�(" + tex�_��X���X�ւP.Text + tex�_��X���X�ւQ.Text + ")�����݂��܂���",
						"���̓`�F�b�N", MessageBoxButtons.OK);
					tex�_��X���X�ւP.Focus();
					return false;
				}
				if (!�����`�F�b�N(cb�_��X����, "�s���{��")) return false;
			}
// MOD 2014.09.24 BEVAS) �O�c �X�֔ԍ������͎��̃`�F�b�N����� END

			tex���b�Z�[�W.Text = btn�o�^.Text + "���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			return(true);
		}

		private void �N���A()
		{
			tex�_��X����.Text = "";
			tex�_��X���X�ւP.Text = "";
			tex�_��X���X�ւQ.Text = "";
			cb�_��X����.SelectedIndex = 0;
			tex�_��X���Z���P.Text = "";
			tex�_��X���Z���Q.Text = "";
			tex�_��X���d�b�P.Text = "";
			tex�_��X���d�b�Q.Text = "";
			tex�_��X���d�b�R.Text = "";
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 START
//			tex�_��X���e�`�w�P.Text = "";
//			tex�_��X���e�`�w�Q.Text = "";
//			tex�_��X���e�`�w�R.Text = "";
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 END

			tex�n��P.Text = "";
			tex�n��Q.Text = "";

// ADD 2014.09.10 BEVAS�j�O�c �x�X�~�ߋ@�\�ǉ��Ή� START
			// �x�X�~�ߑΉ����W�I�{�^����������
			rbtn���ʔ�Ή�.Checked = true;
			rbtn���q��Ή�.Checked = true;
// ADD 2014.09.10 BEVAS�j�O�c �x�X�~�ߋ@�\�ǉ��Ή� END
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� START
			b�x�X�~�߂e�f�P = false;
			b�x�X�~�߂e�f�Q = false;
// MOD 2016.03.31 BEVAS�j���{ �x�X�~�߂e�f���ڒǉ��ɔ�����O�����o�O�̏C�� END
		}

		private void �����\��()
		{
			tex�X���R�[�h.Text = "1234";

			tex�_��X����.Text = "�S�p20";
			tex�_��X���X�ւP.Text = "123";
			tex�_��X���X�ւQ.Text = "4567";
			cb�_��X����.Text = "�S�p4";
			tex�_��X���Z���P.Text = "�S�p16";
			tex�_��X���Z���Q.Text = "�S�p20";
			tex�_��X���d�b�P.Text = "123456";
			tex�_��X���d�b�Q.Text = "1234";
			tex�_��X���d�b�R.Text = "1234";
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 START
//			tex�_��X���e�`�w�P.Text = "123456";
//			tex�_��X���e�`�w�Q.Text = "1234";
//			tex�_��X���e�`�w�R.Text = "1234";
// DEL 2006.12.11 ���s�j�����J�@�e�`�w�폜 END

			tex�n��P.Text = "1234";
			tex�n��Q.Text = "1234";
		}

		private void btn���_Click(object sender, System.EventArgs e)
		{
//			�����\��();
			�N���A();
			tex���b�Z�[�W.Text = "";
			pnl�X���R�[�h.Enabled = true;
// ADD 2007.01.26 ���s�j���� ��ʒ��� START
			pnl�_��X��.Enabled = false;
// ADD 2007.01.26 ���s�j���� ��ʒ��� END
			tex�X���R�[�h.Text = " ";
			tex�X���R�[�h.Focus();
		}

		private void tex�_��X���X�ւQ_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				if(tex�_��X���X�ւP.Text.Length == 3 && tex�_��X���X�ւQ.Text.Length == 4)
					�X�֌���(tex�_��X���X�ւP, tex�_��X���X�ւQ, 
						cb�_��X����, tex�_��X���Z���P, tex�_��X���Z���Q, null);
				else{
					�X�ֈꗗ(tex�_��X���X�ւP, tex�_��X���X�ւQ, 
						cb�_��X����, tex�_��X���Z���P, tex�_��X���Z���Q, null);
				}
			}
		}

		private void tex�_��X���X�ւQ_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�_��X���X��.Focus();
				�X�ֈꗗ(tex�_��X���X�ւP, tex�_��X���X�ւQ, 
					cb�_��X����, tex�_��X���Z���P, tex�_��X���Z���Q, null);
				e.Handled = true;
			}
		}

		private void btn�_��X���X��_Click(object sender, System.EventArgs e)
		{
			�X�ֈꗗ(tex�_��X���X�ւP, tex�_��X���X�ւQ, 
				cb�_��X����, tex�_��X���Z���P, tex�_��X���Z���Q, null);
		}

		private bool �K�{�`�F�b�N(ComboBox cb��, string name)
		{
			if(cb��.Text.Length > 0) return true;
			MessageBox.Show("�K�{����(" + name + ")�����͂���Ă��܂���",
				"���̓`�F�b�N",MessageBoxButtons.OK);
			cb��.Focus();
			return false;
		}

		private void �X�ֈꗗ(TextBox tex�X�֔ԍ��P, TextBox tex�X�֔ԍ��Q, 
			ComboBox cb��, TextBox tex�Z���P, TextBox tex�Z���Q, TextBox tex�X����)
		{
			tex�X�֔ԍ��P.Text = tex�X�֔ԍ��P.Text.Trim();
			tex�X�֔ԍ��Q.Text = tex�X�֔ԍ��Q.Text.Trim();
//			if(!���p�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return;
//			if(!���p�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return;

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			if (g�Z������ == null) g�Z������ = new �Z������();
			// ������ʂ��E���ɕ\������
			g�Z������.Left = this.Left + 404;
			g�Z������.Top = this.Top;
			// �R�[�h�̏����\��
			g�Z������.s�X�֔ԍ��P = "";
			g�Z������.s�X�֔ԍ��Q = "";
			g�Z������.s�Ǘ��X��   = "";
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
			//�X�R�[�h���Ǘ��ҋ敪������
			String[] sList;
			string[] sKey2  = new string[1];
			sKey2[0] = tex�X���R�[�h.Text;
			sList = sv_oji.Sel_Member(gsa���[�U, sKey2);
			g�Z������.s���q�l�b�c = "";
			if (sList[0].Equals("����I��"))
			{
				if ((sList[4].Equals("3"))||(sList[4].Equals("4")))
				{
					//���q�^�����
					g�Z������.s���q�l�b�c = "J";
				}
			}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
			g�Z������.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if (g�Z������.s�X�֔ԍ��P.Trim().Length != 0)
			{
				tex�X�֔ԍ��P.Text = g�Z������.s�X�֔ԍ��P.Trim();
				tex�X�֔ԍ��Q.Text = g�Z������.s�X�֔ԍ��Q.Trim();
				if(tex�X���� != null) 
				{
//					tex�X����.Text = g�Z������.s�Ǘ��X��.Trim();
//					�X�֌���(tex�ݒu�ꏊ�X�ւP, tex�ݒu�ꏊ�X�ւQ, 
//						cb�ݒu�ꏊ��, tex�ݒu�ꏊ�Z���P, tex�ݒu�ꏊ�Z���Q, tex�X����);
				}
				//cb��.SelectedIndex = int.Parse(g�Z������.s�s���{���b�c.Trim());
//				tex�Z���P.Text = g�Z������.s�Z��.Trim();
				���ݒ�(g�Z������.s�Z��.Trim(), cb��, tex�Z���P);
				tex�Z���Q.Text = "";
				tex�Z���Q.Focus();
			}
			else
			{
				tex�X�֔ԍ��P.Focus();
			}
		}

		private bool �X�֌���(TextBox tex�X�֔ԍ��P, TextBox tex�X�֔ԍ��Q, 
			ComboBox cb��, TextBox tex�Z���P, TextBox tex�Z���Q, TextBox tex�X����)
		{
			tex�X�֔ԍ��P.Text = tex�X�֔ԍ��P.Text.Trim();
			tex�X�֔ԍ��Q.Text = tex�X�֔ԍ��Q.Text.Trim();
			//if (!�K�{�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return false;
			//if (!���p�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return false;
			//if (!�K�{�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return false;
			//if (!���p�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return false;
			if (tex�X�֔ԍ��P.Text.Length == 0) return true;
			if (tex�X�֔ԍ��Q.Text.Length == 0) return true;

			tex���b�Z�[�W.Text = "�X�֔ԍ��������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�X�֔ԍ��P.Text + tex�X�֔ԍ��Q.Text;
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//				string[] sList = sv_maintenance.Sel_Postcode1(gsa���[�U, sKey);
				//�X�R�[�h���Ǘ��ҋ敪������
				String[] sList;
				string[] sKey2  = new string[1];
				sKey2[0] = tex�X���R�[�h.Text;
				sList = sv_oji.Sel_Member(gsa���[�U, sKey2);
				if (sList[0].Equals("����I��"))
				{
					if ((sList[4].Equals("3"))||(sList[4].Equals("4")))
					{
						//���q�^�����
						sList = sv_oji.Sel_Postcode1(gsa���[�U, sKey);
					}
					else
					{
						//���ʉ��
						sList = sv_maintenance.Sel_Postcode1(gsa���[�U, sKey);
					}
				}
				else
				{
					sList = sv_maintenance.Sel_Postcode1(gsa���[�U, sKey);
				}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					if(tex�X���� != null) tex�X����.Text = sList[3].Trim();
					if(tex�Z���P.Text.Trim().Length == 0 && tex�Z���Q.Text.Trim().Length == 0)
					{
//						tex�Z���P.Text = sList[2].Trim();
						���ݒ�(sList[2].Trim(), cb��, tex�Z���P);
						tex�Z���Q.Focus();
					}
					else
						tex�Z���P.Focus();
//					s�X���R�[�h = sList[4].Trim();
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					if(tex�X���� != null) tex�X����.Text = "";
					�r�[�v��();
					ret =  false;
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
//				�������[�h();
				ret = false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}

		private void �X�����_Closed(object sender, System.EventArgs e)
		{
			i�A�N�e�B�u�e�f = 0;
			s�X�V���� = "";
			�N���A();
			tex���b�Z�[�W.Text = "";
			pnl�X���R�[�h.Enabled = true;
// ADD 2007.01.26 ���s�j���� ��ʒ��� START
			pnl�_��X��.Enabled = false;
// ADD 2007.01.26 ���s�j���� ��ʒ��� END
			tex�X���R�[�h.Text = " ";
			tex�X���R�[�h.Focus();
		}

		private void �X�����_Activated(object sender, System.EventArgs e)
		{
			if(i�A�N�e�B�u�e�f == 1){
				if(gs�X���R�[�h.Trim().Length > 0)
				{
					tex�X���R�[�h.Text = gs�X���R�[�h;
					pnl�X���R�[�h.Enabled = false;
					�X����񌟍�();
				}else{
					pnl�X���R�[�h.Enabled = true;
					tex�X���R�[�h.Text = " ";
					tex�X���R�[�h.Focus();
// ADD 2007.01.26 ���s�j���� ��ʒ��� START
					pnl�_��X��.Enabled = false;
// ADD 2007.01.26 ���s�j���� ��ʒ��� END
				}
			}
		}


	}
}
