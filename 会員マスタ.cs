using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [���q�l��񃁃��e�i���X]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� 
	// ADD 2007.01.30 ���s�j���� �p�X���[�h�g�p�\�����̐��� 
	// MOD 2007.02.06 ���s�j���� �c�Ə�����Ή� 
	// DEL 2007.02.06 ���s�j���� �p�X���[�h�g�p�\�����`�F�b�N�̔p�~�iby �K�c�a�j 
	// ADD 2007.02.08 ���s�j���� �c�Ə�����Ή� 
	// ADD 2007.02.15 ���s�j���� �c�Ə�����Ή� 
	// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� 
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 ���s�j���� �ݒu�ꏊ�Z���̑S�p�`�F�b�N�̒ǉ� 
	// MOD 2008.05.07 ���s�j���� ���b�Z�[�W�ύX[���]��[���q�l]
	// ADD 2008.05.29 ���s�j���� �p�X���[�h�X�V�N������\�� 
	//--------------------------------------------------------------------------
	// ADD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� 
	// MOD 2009.04.28 ���s�j���� �폜�m�F���b�Z�[�W�̒ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� 
	// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� 
	//--------------------------------------------------------------------------
	// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2016.03.16 BEVAS�j���{ ���q�^���ŃO���[�o���^�p�Ή� 
	//--------------------------------------------------------------------------
	// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή�
	//--------------------------------------------------------------------------
	public class ����}�X�^ : ���ʃt�H�[��//System.Windows.Forms.Form
	{
// ADD 2005.06.13 ���s�j�����J ���������ǉ� START
		private string s����R�[�h = "";
// ADD 2005.06.13 ���s�j�����J ���������ǉ� END
		private string s�p�X���[�h = "";
		private string s����R�[�h = "";
		private string s����X�V����   = "00000000000000";
		private string s����X�V����   = "00000000000000";
		private string s���p�ҍX�V���� = "00000000000000";
		private int s�F�؃G���[�� = 0;
// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� START
		private string s�Ǘ��X���R�[�h = "";
		private string s�ݒu�ꏊ���R�[�h = "";
		private string s�ݒu�ꏊ�Z���P   = "";
		private string s�ȈՃ��[�U�[ = "";
// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� END

		private short nOldRowB = 0;
		private short nOldRowR = 0;

		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lab����;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lab����}�X�^�^�C�g��;
		private System.Windows.Forms.Button btn�������;
		private System.Windows.Forms.Button btn������s;
		private System.Windows.Forms.Label lab����R�[�h;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmb�Ǘ��ҋ敪;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lab�Ǘ��ҋ敪;
		private System.Windows.Forms.Label lab�����;
		private AxGTABLE32V2Lib.AxGTable32 axGT����;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private ���ʃe�L�X�g�{�b�N�X tex����R�[�h;
		private ���ʃe�L�X�g�{�b�N�X tex���喼;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btn����o�^;
		private System.Windows.Forms.Button btn����폜;
		private System.Windows.Forms.Button btn������;
		private ���ʃe�L�X�g�{�b�N�X tex�ב��l�R�[�h;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label23;
		private ���ʃe�L�X�g�{�b�N�X tex���p�҃R�[�h;
		private System.Windows.Forms.Label label25;
		private AxGTABLE32V2Lib.AxGTable32 axGT���p��;
		private System.Windows.Forms.Button btn���p�Ҏ��;
		private System.Windows.Forms.Button btn���p�ҍ폜;
		private System.Windows.Forms.Button btn���p�ғo�^;
		private System.Windows.Forms.Label lab�g�p�J�n��;
		private System.Windows.Forms.Button btn�ב��l����;
		private System.Windows.Forms.Panel pnl���;
		private System.Windows.Forms.Panel pnl����;
		private System.Windows.Forms.Panel pnl���p��;
		private ���ʃe�L�X�g�{�b�N�X tex�����;
		private ���ʃe�L�X�g�{�b�N�X tex����R�[�h;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����o�^;
		private System.Windows.Forms.Label lab�g�p�I����;
		private System.Windows.Forms.Label lab�Ǘ��X��;
		private System.Windows.Forms.Label lab�o�͏�;
		private System.Windows.Forms.Label lab���喼;
		private System.Windows.Forms.Label lab����R�[�h;
		private System.Windows.Forms.Label lab�ב��l�R�[�h;
		private System.Windows.Forms.Label lab���p�Җ�;
		private System.Windows.Forms.Label lab�p�X���[�h;
		private System.Windows.Forms.Label lab���p�҃R�[�h;
		private ���ʃe�L�X�g�{�b�N�X tex�Ǘ��X����;
		private ���ʃe�L�X�g�{�b�N�X tex���p�Җ�;
		private ���ʃe�L�X�g�{�b�N�X tex�p�X���[�h;
		private System.Windows.Forms.CheckBox chb�g�p�I����;
		private System.Windows.Forms.DateTimePicker dtp�g�p�I����;
		private System.Windows.Forms.DateTimePicker dtp�g�p�J�n��;
		private System.Windows.Forms.NumericUpDown num�o�͏�;
		private ���ʃe�L�X�g�{�b�N�X tex�F�ؗ��p�Җ�;
		private System.Windows.Forms.Label lab�F�ؗ��p�Җ�;
		private System.Windows.Forms.Label lab�F�؉����;
		private ���ʃe�L�X�g�{�b�N�X tex�F�؉����;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btn�Z������;
		private ���ʃe�L�X�g�{�b�N�X tex�X�֔ԍ��Q;
		private ���ʃe�L�X�g�{�b�N�X tex�X�֔ԍ��P;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lab�X�֔ԍ�;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btn�������s;
		private System.Windows.Forms.Button btn�p�X���[�h���b�N;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu��Z���P;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu��Z���Q;
		private System.Windows.Forms.NumericUpDown num�T�[�}���䐔;
		private System.Windows.Forms.Label lab�T�[�}��;
		private System.Windows.Forms.Label lab�ݒu�Z��;
		private System.Windows.Forms.Label lab��;
		private System.Windows.Forms.Label lab�I����;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label11;
		private ���ʃe�L�X�g�{�b�N�X tex�ȈՃ��[�U�[;
		private System.Windows.Forms.Label lab�ȈՃ��[�U�[;
		private System.Windows.Forms.CheckBox chb���x������֎~;
		private System.Windows.Forms.Button btn����폜;
		private System.Windows.Forms.Button btn�V�K;
		private System.Windows.Forms.Label lab�p�X���[�h�X�V��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�p�X���[�h�X�V��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�V���A���ԍ��P;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�V���A���ԍ��Q;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�V���A���ԍ��R;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label49;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�g�p��;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cmb�V���A���ԍ��P;
		private System.Windows.Forms.ComboBox cmb�V���A���ԍ��Q;
		private System.Windows.Forms.ComboBox cmb�V���A���ԍ��R;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�V���A���ԍ��S;
		private System.Windows.Forms.ComboBox cmb�V���A���ԍ��S;
		private System.Windows.Forms.CheckBox cb�^�p���̂��q�l�̂�;
		private System.Windows.Forms.CheckBox cb�ː��d�ʓ��͎捞;
		private System.Windows.Forms.Button btn�Г��`������X�o�^;
		private System.ComponentModel.IContainer components;

		public ����}�X�^()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(����}�X�^));
            this.tex����� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.pnl��� = new System.Windows.Forms.Panel();
            this.cb�ː��d�ʓ��͎捞 = new System.Windows.Forms.CheckBox();
            this.btn����폜 = new System.Windows.Forms.Button();
            this.lab�I���� = new System.Windows.Forms.Label();
            this.chb�g�p�I���� = new System.Windows.Forms.CheckBox();
            this.dtp�g�p�I���� = new System.Windows.Forms.DateTimePicker();
            this.lab�g�p�I���� = new System.Windows.Forms.Label();
            this.btn����o�^ = new System.Windows.Forms.Button();
            this.dtp�g�p�J�n�� = new System.Windows.Forms.DateTimePicker();
            this.cmb�Ǘ��ҋ敪 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab�Ǘ��ҋ敪 = new System.Windows.Forms.Label();
            this.lab�g�p�J�n�� = new System.Windows.Forms.Label();
            this.lab����� = new System.Windows.Forms.Label();
            this.btn�Г��`������X�o�^ = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cb�^�p���̂��q�l�̂� = new System.Windows.Forms.CheckBox();
            this.btn�V�K = new System.Windows.Forms.Button();
            this.btn������� = new System.Windows.Forms.Button();
            this.btn������s = new System.Windows.Forms.Button();
            this.lab����R�[�h = new System.Windows.Forms.Label();
            this.tex����R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tex�F�ؗ��p�Җ� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab�F�ؗ��p�Җ� = new System.Windows.Forms.Label();
            this.lab�F�؉���� = new System.Windows.Forms.Label();
            this.tex�F�؉���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab���� = new System.Windows.Forms.Label();
            this.lab����}�X�^�^�C�g�� = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.btn���� = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl���� = new System.Windows.Forms.Panel();
            this.cmb�V���A���ԍ��S = new System.Windows.Forms.ComboBox();
            this.tex�V���A���ԍ��S = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.cmb�V���A���ԍ��R = new System.Windows.Forms.ComboBox();
            this.cmb�V���A���ԍ��Q = new System.Windows.Forms.ComboBox();
            this.cmb�V���A���ԍ��P = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.tex�ݒu�ꏊ�g�p�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.label34 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tex�V���A���ԍ��R = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.tex�V���A���ԍ��Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.tex�V���A���ԍ��P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab�ȈՃ��[�U�[ = new System.Windows.Forms.Label();
            this.tex�ȈՃ��[�U�[ = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab�� = new System.Windows.Forms.Label();
            this.num�T�[�}���䐔 = new System.Windows.Forms.NumericUpDown();
            this.lab�T�[�}�� = new System.Windows.Forms.Label();
            this.tex�ݒu��Z���Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.tex�ݒu��Z���P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab�ݒu�Z�� = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn�Z������ = new System.Windows.Forms.Button();
            this.tex�X�֔ԍ��Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.tex�X�֔ԍ��P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.label10 = new System.Windows.Forms.Label();
            this.lab�X�֔ԍ� = new System.Windows.Forms.Label();
            this.num�o�͏� = new System.Windows.Forms.NumericUpDown();
            this.tex�Ǘ��X���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.btn������ = new System.Windows.Forms.Button();
            this.btn����폜 = new System.Windows.Forms.Button();
            this.btn����o�^ = new System.Windows.Forms.Button();
            this.lab�Ǘ��X�� = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lab�o�͏� = new System.Windows.Forms.Label();
            this.tex���喼 = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.label6 = new System.Windows.Forms.Label();
            this.lab���喼 = new System.Windows.Forms.Label();
            this.tex����R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.label4 = new System.Windows.Forms.Label();
            this.lab����R�[�h = new System.Windows.Forms.Label();
            this.axGT���� = new AxGTABLE32V2Lib.AxGTable32();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl���p�� = new System.Windows.Forms.Panel();
            this.tex�p�X���[�h�X�V�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab�p�X���[�h�X�V�� = new System.Windows.Forms.Label();
            this.chb���x������֎~ = new System.Windows.Forms.CheckBox();
            this.btn�p�X���[�h���b�N = new System.Windows.Forms.Button();
            this.btn�������s = new System.Windows.Forms.Button();
            this.btn�ב��l���� = new System.Windows.Forms.Button();
            this.btn���p�Ҏ�� = new System.Windows.Forms.Button();
            this.btn���p�ҍ폜 = new System.Windows.Forms.Button();
            this.btn���p�ғo�^ = new System.Windows.Forms.Button();
            this.tex�ב��l�R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab�ב��l�R�[�h = new System.Windows.Forms.Label();
            this.tex���p�Җ� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.label21 = new System.Windows.Forms.Label();
            this.lab���p�Җ� = new System.Windows.Forms.Label();
            this.tex�p�X���[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.label23 = new System.Windows.Forms.Label();
            this.lab�p�X���[�h = new System.Windows.Forms.Label();
            this.tex���p�҃R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.label25 = new System.Windows.Forms.Label();
            this.lab���p�҃R�[�h = new System.Windows.Forms.Label();
            this.axGT���p�� = new AxGTABLE32V2Lib.AxGTable32();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnl���.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnl����.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num�T�[�}���䐔)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num�o�͏�)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGT����)).BeginInit();
            this.pnl���p��.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT���p��)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tex�����
            // 
            this.tex�����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�����.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex�����.Location = new System.Drawing.Point(104, 4);
            this.tex�����.MaxLength = 20;
            this.tex�����.Name = "tex�����";
            this.tex�����.Size = new System.Drawing.Size(326, 23);
            this.tex�����.TabIndex = 1;
            // 
            // pnl���
            // 
            this.pnl���.BackColor = System.Drawing.Color.Honeydew;
            this.pnl���.Controls.Add(this.cb�ː��d�ʓ��͎捞);
            this.pnl���.Controls.Add(this.btn����폜);
            this.pnl���.Controls.Add(this.lab�I����);
            this.pnl���.Controls.Add(this.chb�g�p�I����);
            this.pnl���.Controls.Add(this.dtp�g�p�I����);
            this.pnl���.Controls.Add(this.lab�g�p�I����);
            this.pnl���.Controls.Add(this.btn����o�^);
            this.pnl���.Controls.Add(this.dtp�g�p�J�n��);
            this.pnl���.Controls.Add(this.cmb�Ǘ��ҋ敪);
            this.pnl���.Controls.Add(this.label7);
            this.pnl���.Controls.Add(this.label3);
            this.pnl���.Controls.Add(this.label2);
            this.pnl���.Controls.Add(this.label1);
            this.pnl���.Controls.Add(this.lab�Ǘ��ҋ敪);
            this.pnl���.Controls.Add(this.lab�g�p�J�n��);
            this.pnl���.Controls.Add(this.tex�����);
            this.pnl���.Controls.Add(this.lab�����);
            this.pnl���.ForeColor = System.Drawing.Color.LimeGreen;
            this.pnl���.Location = new System.Drawing.Point(1, 6);
            this.pnl���.Name = "pnl���";
            this.pnl���.Size = new System.Drawing.Size(721, 56);
            this.pnl���.TabIndex = 1;
            // 
            // cb�ː��d�ʓ��͎捞
            // 
            this.cb�ː��d�ʓ��͎捞.ForeColor = System.Drawing.Color.LimeGreen;
            this.cb�ː��d�ʓ��͎捞.Location = new System.Drawing.Point(466, 34);
            this.cb�ː��d�ʓ��͎捞.Name = "cb�ː��d�ʓ��͎捞";
            this.cb�ː��d�ʓ��͎捞.Size = new System.Drawing.Size(142, 16);
            this.cb�ː��d�ʓ��͎捞.TabIndex = 58;
            this.cb�ː��d�ʓ��͎捞.Text = "���q�l�ː��A�d�ʎ捞";
            // 
            // btn����폜
            // 
            this.btn����폜.BackColor = System.Drawing.Color.Blue;
            this.btn����폜.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn����폜.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn����폜.ForeColor = System.Drawing.Color.White;
            this.btn����폜.Location = new System.Drawing.Point(666, 30);
            this.btn����폜.Name = "btn����폜";
            this.btn����폜.Size = new System.Drawing.Size(48, 22);
            this.btn����폜.TabIndex = 57;
            this.btn����폜.Text = "�폜";
            this.btn����폜.UseVisualStyleBackColor = false;
            this.btn����폜.Click += new System.EventHandler(this.btn����폜_Click);
            // 
            // lab�I����
            // 
            this.lab�I����.BackColor = System.Drawing.Color.White;
            this.lab�I����.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�I����.Location = new System.Drawing.Point(326, 32);
            this.lab�I����.Name = "lab�I����";
            this.lab�I����.Size = new System.Drawing.Size(112, 16);
            this.lab�I����.TabIndex = 56;
            // 
            // chb�g�p�I����
            // 
            this.chb�g�p�I����.Location = new System.Drawing.Point(306, 34);
            this.chb�g�p�I����.Name = "chb�g�p�I����";
            this.chb�g�p�I����.Size = new System.Drawing.Size(16, 14);
            this.chb�g�p�I����.TabIndex = 4;
            this.chb�g�p�I����.TabStop = false;
            this.chb�g�p�I����.CheckedChanged += new System.EventHandler(this.chb�g�p�I����_CheckedChanged);
            // 
            // dtp�g�p�I����
            // 
            this.dtp�g�p�I����.CalendarFont = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp�g�p�I����.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp�g�p�I����.Location = new System.Drawing.Point(324, 30);
            this.dtp�g�p�I����.Name = "dtp�g�p�I����";
            this.dtp�g�p�I����.Size = new System.Drawing.Size(134, 22);
            this.dtp�g�p�I����.TabIndex = 5;
            this.dtp�g�p�I����.TabStop = false;
            this.dtp�g�p�I����.DropDown += new System.EventHandler(this.dtp�g�p�I����_DropDown);
            // 
            // lab�g�p�I����
            // 
            this.lab�g�p�I����.Location = new System.Drawing.Point(242, 34);
            this.lab�g�p�I����.Name = "lab�g�p�I����";
            this.lab�g�p�I����.Size = new System.Drawing.Size(66, 14);
            this.lab�g�p�I����.TabIndex = 55;
            this.lab�g�p�I����.Text = "�g�p�I����";
            // 
            // btn����o�^
            // 
            this.btn����o�^.BackColor = System.Drawing.Color.Blue;
            this.btn����o�^.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn����o�^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn����o�^.ForeColor = System.Drawing.Color.White;
            this.btn����o�^.Location = new System.Drawing.Point(612, 30);
            this.btn����o�^.Name = "btn����o�^";
            this.btn����o�^.Size = new System.Drawing.Size(48, 22);
            this.btn����o�^.TabIndex = 6;
            this.btn����o�^.Text = "�o�^";
            this.btn����o�^.UseVisualStyleBackColor = false;
            this.btn����o�^.Click += new System.EventHandler(this.btn����o�^_Click);
            // 
            // dtp�g�p�J�n��
            // 
            this.dtp�g�p�J�n��.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp�g�p�J�n��.Location = new System.Drawing.Point(104, 30);
            this.dtp�g�p�J�n��.Name = "dtp�g�p�J�n��";
            this.dtp�g�p�J�n��.Size = new System.Drawing.Size(134, 22);
            this.dtp�g�p�J�n��.TabIndex = 2;
            // 
            // cmb�Ǘ��ҋ敪
            // 
            this.cmb�Ǘ��ҋ敪.Items.AddRange(new object[] {
            "��ʉ��",
            "�Ǘ��҉��",
            "�c�Ə����",
            "���q��ʉ��",
            "���q�c�Ə����"});
            this.cmb�Ǘ��ҋ敪.Location = new System.Drawing.Point(514, 4);
            this.cmb�Ǘ��ҋ敪.Name = "cmb�Ǘ��ҋ敪";
            this.cmb�Ǘ��ҋ敪.Size = new System.Drawing.Size(108, 20);
            this.cmb�Ǘ��ҋ敪.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(436, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 14);
            this.label7.TabIndex = 51;
            this.label7.Text = "��";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(26, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 14);
            this.label3.TabIndex = 50;
            this.label3.Text = "��";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 14);
            this.label2.TabIndex = 49;
            this.label2.Text = "��";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.label1.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 56);
            this.label1.TabIndex = 44;
            this.label1.Text = "���q�l";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab�Ǘ��ҋ敪
            // 
            this.lab�Ǘ��ҋ敪.Location = new System.Drawing.Point(450, 8);
            this.lab�Ǘ��ҋ敪.Name = "lab�Ǘ��ҋ敪";
            this.lab�Ǘ��ҋ敪.Size = new System.Drawing.Size(66, 14);
            this.lab�Ǘ��ҋ敪.TabIndex = 19;
            this.lab�Ǘ��ҋ敪.Text = "�Ǘ��ҋ敪";
            // 
            // lab�g�p�J�n��
            // 
            this.lab�g�p�J�n��.Location = new System.Drawing.Point(40, 34);
            this.lab�g�p�J�n��.Name = "lab�g�p�J�n��";
            this.lab�g�p�J�n��.Size = new System.Drawing.Size(66, 14);
            this.lab�g�p�J�n��.TabIndex = 15;
            this.lab�g�p�J�n��.Text = "�g�p�J�n��";
            // 
            // lab�����
            // 
            this.lab�����.Location = new System.Drawing.Point(40, 10);
            this.lab�����.Name = "lab�����";
            this.lab�����.Size = new System.Drawing.Size(66, 14);
            this.lab�����.TabIndex = 9;
            this.lab�����.Text = "���q�l��";
            // 
            // btn�Г��`������X�o�^
            // 
            this.btn�Г��`������X�o�^.BackColor = System.Drawing.Color.PaleGreen;
            this.btn�Г��`������X�o�^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�Г��`������X�o�^.ForeColor = System.Drawing.Color.Blue;
            this.btn�Г��`������X�o�^.Location = new System.Drawing.Point(90, 6);
            this.btn�Г��`������X�o�^.Name = "btn�Г��`������X�o�^";
            this.btn�Г��`������X�o�^.Size = new System.Drawing.Size(54, 48);
            this.btn�Г��`������X�o�^.TabIndex = 59;
            this.btn�Г��`������X�o�^.Text = "���X�@�@�o�^";
            this.btn�Г��`������X�o�^.UseVisualStyleBackColor = false;
            this.btn�Г��`������X�o�^.Click += new System.EventHandler(this.btn�Г��`������X�o�^_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.cb�^�p���̂��q�l�̂�);
            this.panel5.Controls.Add(this.btn�V�K);
            this.panel5.Controls.Add(this.btn�������);
            this.panel5.Controls.Add(this.btn������s);
            this.panel5.Controls.Add(this.lab����R�[�h);
            this.panel5.Controls.Add(this.tex����R�[�h);
            this.panel5.Location = new System.Drawing.Point(1, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(609, 32);
            this.panel5.TabIndex = 0;
            // 
            // cb�^�p���̂��q�l�̂�
            // 
            this.cb�^�p���̂��q�l�̂�.ForeColor = System.Drawing.Color.LimeGreen;
            this.cb�^�p���̂��q�l�̂�.Location = new System.Drawing.Point(412, 8);
            this.cb�^�p���̂��q�l�̂�.Name = "cb�^�p���̂��q�l�̂�";
            this.cb�^�p���̂��q�l�̂�.Size = new System.Drawing.Size(152, 16);
            this.cb�^�p���̂��q�l�̂�.TabIndex = 4;
            this.cb�^�p���̂��q�l�̂�.Text = "�^�p���̂��q�l�̂ݑΏ�";
            // 
            // btn�V�K
            // 
            this.btn�V�K.BackColor = System.Drawing.Color.Blue;
            this.btn�V�K.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�V�K.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�V�K.ForeColor = System.Drawing.Color.White;
            this.btn�V�K.Location = new System.Drawing.Point(344, 5);
            this.btn�V�K.Name = "btn�V�K";
            this.btn�V�K.Size = new System.Drawing.Size(48, 22);
            this.btn�V�K.TabIndex = 3;
            this.btn�V�K.Text = "�V�K";
            this.btn�V�K.UseVisualStyleBackColor = false;
            this.btn�V�K.Click += new System.EventHandler(this.btn�V�K_Click);
            // 
            // btn�������
            // 
            this.btn�������.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�������.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�������.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�������.ForeColor = System.Drawing.Color.White;
            this.btn�������.Location = new System.Drawing.Point(236, 5);
            this.btn�������.Name = "btn�������";
            this.btn�������.Size = new System.Drawing.Size(48, 22);
            this.btn�������.TabIndex = 1;
            this.btn�������.TabStop = false;
            this.btn�������.Text = "����";
            this.btn�������.UseVisualStyleBackColor = false;
            this.btn�������.Click += new System.EventHandler(this.btn�������_Click);
            // 
            // btn������s
            // 
            this.btn������s.BackColor = System.Drawing.Color.Blue;
            this.btn������s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn������s.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn������s.ForeColor = System.Drawing.Color.White;
            this.btn������s.Location = new System.Drawing.Point(290, 5);
            this.btn������s.Name = "btn������s";
            this.btn������s.Size = new System.Drawing.Size(48, 22);
            this.btn������s.TabIndex = 2;
            this.btn������s.Text = "���s";
            this.btn������s.UseVisualStyleBackColor = false;
            this.btn������s.Click += new System.EventHandler(this.btn������s_Click);
            // 
            // lab����R�[�h
            // 
            this.lab����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab����R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab����R�[�h.Location = new System.Drawing.Point(4, 8);
            this.lab����R�[�h.Name = "lab����R�[�h";
            this.lab����R�[�h.Size = new System.Drawing.Size(86, 16);
            this.lab����R�[�h.TabIndex = 6;
            this.lab����R�[�h.Text = "���q�l�R�[�h";
            // 
            // tex����R�[�h
            // 
            this.tex����R�[�h.BackColor = System.Drawing.SystemColors.Window;
            this.tex����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex����R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex����R�[�h.Location = new System.Drawing.Point(90, 4);
            this.tex����R�[�h.MaxLength = 10;
            this.tex����R�[�h.Name = "tex����R�[�h";
            this.tex����R�[�h.Size = new System.Drawing.Size(140, 23);
            this.tex����R�[�h.TabIndex = 0;
            this.tex����R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex����R�[�h_KeyPress);
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
            this.tex�F�ؗ��p�Җ�.Location = new System.Drawing.Point(470, 5);
            this.tex�F�ؗ��p�Җ�.Name = "tex�F�ؗ��p�Җ�";
            this.tex�F�ؗ��p�Җ�.ReadOnly = true;
            this.tex�F�ؗ��p�Җ�.Size = new System.Drawing.Size(322, 16);
            this.tex�F�ؗ��p�Җ�.TabIndex = 0;
            this.tex�F�ؗ��p�Җ�.TabStop = false;
            this.tex�F�ؗ��p�Җ�.Text = "����������������������������������������";
            this.tex�F�ؗ��p�Җ�.Visible = false;
            // 
            // lab�F�ؗ��p�Җ�
            // 
            this.lab�F�ؗ��p�Җ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�F�ؗ��p�Җ�.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�F�ؗ��p�Җ�.Location = new System.Drawing.Point(418, 7);
            this.lab�F�ؗ��p�Җ�.Name = "lab�F�ؗ��p�Җ�";
            this.lab�F�ؗ��p�Җ�.Size = new System.Drawing.Size(54, 14);
            this.lab�F�ؗ��p�Җ�.TabIndex = 0;
            this.lab�F�ؗ��p�Җ�.Text = "���[�U�[";
            this.lab�F�ؗ��p�Җ�.Visible = false;
            // 
            // lab�F�؉����
            // 
            this.lab�F�؉����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�F�؉����.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�F�؉����.Location = new System.Drawing.Point(12, 7);
            this.lab�F�؉����.Name = "lab�F�؉����";
            this.lab�F�؉����.Size = new System.Drawing.Size(54, 14);
            this.lab�F�؉����.TabIndex = 0;
            this.lab�F�؉����.Text = "���q�l��";
            // 
            // tex�F�؉����
            // 
            this.tex�F�؉����.BackColor = System.Drawing.Color.PaleGreen;
            this.tex�F�؉����.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex�F�؉����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�F�؉����.ForeColor = System.Drawing.Color.Green;
            this.tex�F�؉����.Location = new System.Drawing.Point(70, 5);
            this.tex�F�؉����.Name = "tex�F�؉����";
            this.tex�F�؉����.ReadOnly = true;
            this.tex�F�؉����.Size = new System.Drawing.Size(328, 16);
            this.tex�F�؉����.TabIndex = 0;
            this.tex�F�؉����.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab����);
            this.panel7.Controls.Add(this.lab����}�X�^�^�C�g��);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(794, 26);
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
            // lab����}�X�^�^�C�g��
            // 
            this.lab����}�X�^�^�C�g��.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab����}�X�^�^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab����}�X�^�^�C�g��.ForeColor = System.Drawing.Color.White;
            this.lab����}�X�^�^�C�g��.Location = new System.Drawing.Point(12, 2);
            this.lab����}�X�^�^�C�g��.Name = "lab����}�X�^�^�C�g��";
            this.lab����}�X�^�^�C�g��.Size = new System.Drawing.Size(264, 24);
            this.lab����}�X�^�^�C�g��.TabIndex = 0;
            this.lab����}�X�^�^�C�g��.Text = "���q�l��񃁃��e�i���X";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PaleGreen;
            this.panel8.Controls.Add(this.tex���b�Z�[�W);
            this.panel8.Controls.Add(this.btn����);
            this.panel8.Controls.Add(this.btn�Г��`������X�o�^);
            this.panel8.Location = new System.Drawing.Point(0, 516);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(794, 58);
            this.panel8.TabIndex = 4;
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
            this.tex���b�Z�[�W.TabIndex = 30;
            this.tex���b�Z�[�W.TabStop = false;
            // 
            // btn����
            // 
            this.btn����.ForeColor = System.Drawing.Color.Red;
            this.btn����.Location = new System.Drawing.Point(8, 6);
            this.btn����.Name = "btn����";
            this.btn����.Size = new System.Drawing.Size(54, 48);
            this.btn����.TabIndex = 29;
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
            // pnl����
            // 
            this.pnl����.BackColor = System.Drawing.Color.Honeydew;
            this.pnl����.Controls.Add(this.cmb�V���A���ԍ��S);
            this.pnl����.Controls.Add(this.tex�V���A���ԍ��S);
            this.pnl����.Controls.Add(this.cmb�V���A���ԍ��R);
            this.pnl����.Controls.Add(this.cmb�V���A���ԍ��Q);
            this.pnl����.Controls.Add(this.cmb�V���A���ԍ��P);
            this.pnl����.Controls.Add(this.label14);
            this.pnl����.Controls.Add(this.label49);
            this.pnl����.Controls.Add(this.tex�ݒu�ꏊ�g�p��);
            this.pnl����.Controls.Add(this.label34);
            this.pnl����.Controls.Add(this.label13);
            this.pnl����.Controls.Add(this.tex�V���A���ԍ��R);
            this.pnl����.Controls.Add(this.tex�V���A���ԍ��Q);
            this.pnl����.Controls.Add(this.tex�V���A���ԍ��P);
            this.pnl����.Controls.Add(this.lab�ȈՃ��[�U�[);
            this.pnl����.Controls.Add(this.tex�ȈՃ��[�U�[);
            this.pnl����.Controls.Add(this.lab��);
            this.pnl����.Controls.Add(this.num�T�[�}���䐔);
            this.pnl����.Controls.Add(this.lab�T�[�}��);
            this.pnl����.Controls.Add(this.tex�ݒu��Z���Q);
            this.pnl����.Controls.Add(this.tex�ݒu��Z���P);
            this.pnl����.Controls.Add(this.lab�ݒu�Z��);
            this.pnl����.Controls.Add(this.label9);
            this.pnl����.Controls.Add(this.btn�Z������);
            this.pnl����.Controls.Add(this.tex�X�֔ԍ��Q);
            this.pnl����.Controls.Add(this.tex�X�֔ԍ��P);
            this.pnl����.Controls.Add(this.label10);
            this.pnl����.Controls.Add(this.lab�X�֔ԍ�);
            this.pnl����.Controls.Add(this.num�o�͏�);
            this.pnl����.Controls.Add(this.tex�Ǘ��X����);
            this.pnl����.Controls.Add(this.btn������);
            this.pnl����.Controls.Add(this.btn����폜);
            this.pnl����.Controls.Add(this.btn����o�^);
            this.pnl����.Controls.Add(this.lab�Ǘ��X��);
            this.pnl����.Controls.Add(this.label12);
            this.pnl����.Controls.Add(this.lab�o�͏�);
            this.pnl����.Controls.Add(this.tex���喼);
            this.pnl����.Controls.Add(this.label6);
            this.pnl����.Controls.Add(this.lab���喼);
            this.pnl����.Controls.Add(this.tex����R�[�h);
            this.pnl����.Controls.Add(this.label4);
            this.pnl����.Controls.Add(this.lab����R�[�h);
            this.pnl����.Controls.Add(this.axGT����);
            this.pnl����.Controls.Add(this.label8);
            this.pnl����.ForeColor = System.Drawing.Color.LimeGreen;
            this.pnl����.Location = new System.Drawing.Point(1, 6);
            this.pnl����.Name = "pnl����";
            this.pnl����.Size = new System.Drawing.Size(429, 356);
            this.pnl����.TabIndex = 2;
            // 
            // cmb�V���A���ԍ��S
            // 
            this.cmb�V���A���ԍ��S.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.cmb�V���A���ԍ��S.Items.AddRange(new object[] {
            "",
            "�ԕi",
            "�s�Ǖi",
            "�s��",
            "���̑�",
            "������"});
            this.cmb�V���A���ԍ��S.Location = new System.Drawing.Point(230, 284);
            this.cmb�V���A���ԍ��S.MaxDropDownItems = 9;
            this.cmb�V���A���ԍ��S.Name = "cmb�V���A���ԍ��S";
            this.cmb�V���A���ԍ��S.Size = new System.Drawing.Size(76, 23);
            this.cmb�V���A���ԍ��S.TabIndex = 16;
            // 
            // tex�V���A���ԍ��S
            // 
            this.tex�V���A���ԍ��S.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�V���A���ԍ��S.Location = new System.Drawing.Point(100, 284);
            this.tex�V���A���ԍ��S.MaxLength = 15;
            this.tex�V���A���ԍ��S.Name = "tex�V���A���ԍ��S";
            this.tex�V���A���ԍ��S.Size = new System.Drawing.Size(130, 22);
            this.tex�V���A���ԍ��S.TabIndex = 15;
            this.tex�V���A���ԍ��S.Text = "123456789012345";
            // 
            // cmb�V���A���ԍ��R
            // 
            this.cmb�V���A���ԍ��R.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.cmb�V���A���ԍ��R.Items.AddRange(new object[] {
            "",
            "�ԕi",
            "�s�Ǖi",
            "�s��",
            "���̑�",
            "������"});
            this.cmb�V���A���ԍ��R.Location = new System.Drawing.Point(230, 262);
            this.cmb�V���A���ԍ��R.MaxDropDownItems = 9;
            this.cmb�V���A���ԍ��R.Name = "cmb�V���A���ԍ��R";
            this.cmb�V���A���ԍ��R.Size = new System.Drawing.Size(76, 23);
            this.cmb�V���A���ԍ��R.TabIndex = 14;
            // 
            // cmb�V���A���ԍ��Q
            // 
            this.cmb�V���A���ԍ��Q.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.cmb�V���A���ԍ��Q.Items.AddRange(new object[] {
            "",
            "�ԕi",
            "�s�Ǖi",
            "�s��",
            "���̑�",
            "������"});
            this.cmb�V���A���ԍ��Q.Location = new System.Drawing.Point(230, 240);
            this.cmb�V���A���ԍ��Q.MaxDropDownItems = 9;
            this.cmb�V���A���ԍ��Q.Name = "cmb�V���A���ԍ��Q";
            this.cmb�V���A���ԍ��Q.Size = new System.Drawing.Size(76, 23);
            this.cmb�V���A���ԍ��Q.TabIndex = 12;
            // 
            // cmb�V���A���ԍ��P
            // 
            this.cmb�V���A���ԍ��P.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.cmb�V���A���ԍ��P.Items.AddRange(new object[] {
            "",
            "�ԕi",
            "�s�Ǖi",
            "�s��",
            "���̑�",
            "������"});
            this.cmb�V���A���ԍ��P.Location = new System.Drawing.Point(230, 218);
            this.cmb�V���A���ԍ��P.MaxDropDownItems = 6;
            this.cmb�V���A���ԍ��P.Name = "cmb�V���A���ԍ��P";
            this.cmb�V���A���ԍ��P.Size = new System.Drawing.Size(76, 23);
            this.cmb�V���A���ԍ��P.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(38, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 14);
            this.label14.TabIndex = 112;
            this.label14.Text = "�T�[�}��";
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(260, 314);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(16, 14);
            this.label49.TabIndex = 111;
            this.label49.Text = "�~";
            // 
            // tex�ݒu�ꏊ�g�p��
            // 
            this.tex�ݒu�ꏊ�g�p��.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.tex�ݒu�ꏊ�g�p��.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�ݒu�ꏊ�g�p��.Location = new System.Drawing.Point(206, 308);
            this.tex�ݒu�ꏊ�g�p��.MaxLength = 6;
            this.tex�ݒu�ꏊ�g�p��.Name = "tex�ݒu�ꏊ�g�p��";
            this.tex�ݒu�ꏊ�g�p��.Size = new System.Drawing.Size(54, 21);
            this.tex�ݒu�ꏊ�g�p��.TabIndex = 18;
            this.tex�ݒu�ꏊ�g�p��.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(166, 312);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(42, 14);
            this.label34.TabIndex = 110;
            this.label34.Text = "�g�p��";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(38, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 14);
            this.label13.TabIndex = 82;
            this.label13.Text = "�V���A���m�n";
            // 
            // tex�V���A���ԍ��R
            // 
            this.tex�V���A���ԍ��R.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�V���A���ԍ��R.Location = new System.Drawing.Point(100, 262);
            this.tex�V���A���ԍ��R.MaxLength = 15;
            this.tex�V���A���ԍ��R.Name = "tex�V���A���ԍ��R";
            this.tex�V���A���ԍ��R.Size = new System.Drawing.Size(130, 22);
            this.tex�V���A���ԍ��R.TabIndex = 13;
            this.tex�V���A���ԍ��R.Text = "123456789012345";
            // 
            // tex�V���A���ԍ��Q
            // 
            this.tex�V���A���ԍ��Q.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�V���A���ԍ��Q.Location = new System.Drawing.Point(100, 240);
            this.tex�V���A���ԍ��Q.MaxLength = 15;
            this.tex�V���A���ԍ��Q.Name = "tex�V���A���ԍ��Q";
            this.tex�V���A���ԍ��Q.Size = new System.Drawing.Size(130, 22);
            this.tex�V���A���ԍ��Q.TabIndex = 11;
            this.tex�V���A���ԍ��Q.Text = "123456789012345";
            // 
            // tex�V���A���ԍ��P
            // 
            this.tex�V���A���ԍ��P.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�V���A���ԍ��P.Location = new System.Drawing.Point(100, 218);
            this.tex�V���A���ԍ��P.MaxLength = 15;
            this.tex�V���A���ԍ��P.Name = "tex�V���A���ԍ��P";
            this.tex�V���A���ԍ��P.Size = new System.Drawing.Size(130, 22);
            this.tex�V���A���ԍ��P.TabIndex = 9;
            this.tex�V���A���ԍ��P.Text = "123456789012345";
            // 
            // lab�ȈՃ��[�U�[
            // 
            this.lab�ȈՃ��[�U�[.Location = new System.Drawing.Point(26, 334);
            this.lab�ȈՃ��[�U�[.Name = "lab�ȈՃ��[�U�[";
            this.lab�ȈՃ��[�U�[.Size = new System.Drawing.Size(74, 14);
            this.lab�ȈՃ��[�U�[.TabIndex = 76;
            this.lab�ȈՃ��[�U�[.Text = "���[�U�[�R�[�h";
            // 
            // tex�ȈՃ��[�U�[
            // 
            this.tex�ȈՃ��[�U�[.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.tex�ȈՃ��[�U�[.Location = new System.Drawing.Point(100, 330);
            this.tex�ȈՃ��[�U�[.MaxLength = 6;
            this.tex�ȈՃ��[�U�[.Name = "tex�ȈՃ��[�U�[";
            this.tex�ȈՃ��[�U�[.Size = new System.Drawing.Size(82, 21);
            this.tex�ȈՃ��[�U�[.TabIndex = 19;
            // 
            // lab��
            // 
            this.lab��.Location = new System.Drawing.Point(144, 312);
            this.lab��.Name = "lab��";
            this.lab��.Size = new System.Drawing.Size(18, 14);
            this.lab��.TabIndex = 74;
            this.lab��.Text = "��";
            // 
            // num�T�[�}���䐔
            // 
            this.num�T�[�}���䐔.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.num�T�[�}���䐔.Location = new System.Drawing.Point(100, 308);
            this.num�T�[�}���䐔.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.num�T�[�}���䐔.Name = "num�T�[�}���䐔";
            this.num�T�[�}���䐔.Size = new System.Drawing.Size(42, 21);
            this.num�T�[�}���䐔.TabIndex = 17;
            this.num�T�[�}���䐔.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lab�T�[�}��
            // 
            this.lab�T�[�}��.Location = new System.Drawing.Point(38, 312);
            this.lab�T�[�}��.Name = "lab�T�[�}��";
            this.lab�T�[�}��.Size = new System.Drawing.Size(62, 14);
            this.lab�T�[�}��.TabIndex = 73;
            this.lab�T�[�}��.Text = "�ݒu�䐔";
            // 
            // tex�ݒu��Z���Q
            // 
            this.tex�ݒu��Z���Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�ݒu��Z���Q.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex�ݒu��Z���Q.Location = new System.Drawing.Point(100, 194);
            this.tex�ݒu��Z���Q.MaxLength = 20;
            this.tex�ݒu��Z���Q.Name = "tex�ݒu��Z���Q";
            this.tex�ݒu��Z���Q.Size = new System.Drawing.Size(326, 23);
            this.tex�ݒu��Z���Q.TabIndex = 8;
            // 
            // tex�ݒu��Z���P
            // 
            this.tex�ݒu��Z���P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�ݒu��Z���P.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex�ݒu��Z���P.Location = new System.Drawing.Point(100, 170);
            this.tex�ݒu��Z���P.MaxLength = 20;
            this.tex�ݒu��Z���P.Name = "tex�ݒu��Z���P";
            this.tex�ݒu��Z���P.Size = new System.Drawing.Size(326, 23);
            this.tex�ݒu��Z���P.TabIndex = 7;
            // 
            // lab�ݒu�Z��
            // 
            this.lab�ݒu�Z��.Location = new System.Drawing.Point(38, 174);
            this.lab�ݒu�Z��.Name = "lab�ݒu�Z��";
            this.lab�ݒu�Z��.Size = new System.Drawing.Size(62, 14);
            this.lab�ݒu�Z��.TabIndex = 72;
            this.lab�ݒu�Z��.Text = "�ݒu�Z��";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(24, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 14);
            this.label9.TabIndex = 71;
            this.label9.Text = "��";
            // 
            // btn�Z������
            // 
            this.btn�Z������.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�Z������.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�Z������.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�Z������.ForeColor = System.Drawing.Color.White;
            this.btn�Z������.Location = new System.Drawing.Point(208, 146);
            this.btn�Z������.Name = "btn�Z������";
            this.btn�Z������.Size = new System.Drawing.Size(48, 22);
            this.btn�Z������.TabIndex = 7;
            this.btn�Z������.TabStop = false;
            this.btn�Z������.Text = "����";
            this.btn�Z������.UseVisualStyleBackColor = false;
            this.btn�Z������.Click += new System.EventHandler(this.btn�Z������_Click);
            // 
            // tex�X�֔ԍ��Q
            // 
            this.tex�X�֔ԍ��Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�X�֔ԍ��Q.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�X�֔ԍ��Q.Location = new System.Drawing.Point(156, 146);
            this.tex�X�֔ԍ��Q.MaxLength = 4;
            this.tex�X�֔ԍ��Q.Name = "tex�X�֔ԍ��Q";
            this.tex�X�֔ԍ��Q.Size = new System.Drawing.Size(48, 23);
            this.tex�X�֔ԍ��Q.TabIndex = 6;
            this.tex�X�֔ԍ��Q.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�X�֔ԍ��Q_KeyDown);
            this.tex�X�֔ԍ��Q.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�X�֔ԍ��Q_KeyPress);
            // 
            // tex�X�֔ԍ��P
            // 
            this.tex�X�֔ԍ��P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�X�֔ԍ��P.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�X�֔ԍ��P.Location = new System.Drawing.Point(100, 146);
            this.tex�X�֔ԍ��P.MaxLength = 3;
            this.tex�X�֔ԍ��P.Name = "tex�X�֔ԍ��P";
            this.tex�X�֔ԍ��P.Size = new System.Drawing.Size(42, 23);
            this.tex�X�֔ԍ��P.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(140, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 14);
            this.label10.TabIndex = 70;
            this.label10.Text = "�|";
            // 
            // lab�X�֔ԍ�
            // 
            this.lab�X�֔ԍ�.Location = new System.Drawing.Point(38, 150);
            this.lab�X�֔ԍ�.Name = "lab�X�֔ԍ�";
            this.lab�X�֔ԍ�.Size = new System.Drawing.Size(62, 14);
            this.lab�X�֔ԍ�.TabIndex = 69;
            this.lab�X�֔ԍ�.Text = "�X�֔ԍ�";
            // 
            // num�o�͏�
            // 
            this.num�o�͏�.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.num�o�͏�.Location = new System.Drawing.Point(270, 98);
            this.num�o�͏�.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.num�o�͏�.Name = "num�o�͏�";
            this.num�o�͏�.Size = new System.Drawing.Size(42, 23);
            this.num�o�͏�.TabIndex = 4;
            this.num�o�͏�.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num�o�͏�.Enter += new System.EventHandler(this.num�o�͏�_Enter);
            // 
            // tex�Ǘ��X����
            // 
            this.tex�Ǘ��X����.BackColor = System.Drawing.Color.Honeydew;
            this.tex�Ǘ��X����.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex�Ǘ��X����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�Ǘ��X����.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�Ǘ��X����.Location = new System.Drawing.Point(318, 150);
            this.tex�Ǘ��X����.MaxLength = 6;
            this.tex�Ǘ��X����.Name = "tex�Ǘ��X����";
            this.tex�Ǘ��X����.ReadOnly = true;
            this.tex�Ǘ��X����.Size = new System.Drawing.Size(90, 16);
            this.tex�Ǘ��X����.TabIndex = 8;
            this.tex�Ǘ��X����.TabStop = false;
            // 
            // btn������
            // 
            this.btn������.BackColor = System.Drawing.Color.Blue;
            this.btn������.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn������.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn������.ForeColor = System.Drawing.Color.White;
            this.btn������.Location = new System.Drawing.Point(370, 330);
            this.btn������.Name = "btn������";
            this.btn������.Size = new System.Drawing.Size(48, 22);
            this.btn������.TabIndex = 25;
            this.btn������.Text = "���";
            this.btn������.UseVisualStyleBackColor = false;
            this.btn������.Click += new System.EventHandler(this.btn������_Click);
            // 
            // btn����폜
            // 
            this.btn����폜.BackColor = System.Drawing.Color.Blue;
            this.btn����폜.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn����폜.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn����폜.ForeColor = System.Drawing.Color.White;
            this.btn����폜.Location = new System.Drawing.Point(316, 330);
            this.btn����폜.Name = "btn����폜";
            this.btn����폜.Size = new System.Drawing.Size(48, 22);
            this.btn����폜.TabIndex = 21;
            this.btn����폜.Text = "�폜";
            this.btn����폜.UseVisualStyleBackColor = false;
            this.btn����폜.Click += new System.EventHandler(this.btn����폜_Click);
            // 
            // btn����o�^
            // 
            this.btn����o�^.BackColor = System.Drawing.Color.Blue;
            this.btn����o�^.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn����o�^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn����o�^.ForeColor = System.Drawing.Color.White;
            this.btn����o�^.Location = new System.Drawing.Point(262, 330);
            this.btn����o�^.Name = "btn����o�^";
            this.btn����o�^.Size = new System.Drawing.Size(48, 22);
            this.btn����o�^.TabIndex = 20;
            this.btn����o�^.Text = "�o�^";
            this.btn����o�^.UseVisualStyleBackColor = false;
            this.btn����o�^.Click += new System.EventHandler(this.btn����o�^_Click);
            // 
            // lab�Ǘ��X��
            // 
            this.lab�Ǘ��X��.Location = new System.Drawing.Point(264, 152);
            this.lab�Ǘ��X��.Name = "lab�Ǘ��X��";
            this.lab�Ǘ��X��.Size = new System.Drawing.Size(54, 14);
            this.lab�Ǘ��X��.TabIndex = 63;
            this.lab�Ǘ��X��.Text = "�Ǘ��X��";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Honeydew;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(214, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 14);
            this.label12.TabIndex = 61;
            this.label12.Text = "��";
            // 
            // lab�o�͏�
            // 
            this.lab�o�͏�.Location = new System.Drawing.Point(228, 102);
            this.lab�o�͏�.Name = "lab�o�͏�";
            this.lab�o�͏�.Size = new System.Drawing.Size(42, 14);
            this.lab�o�͏�.TabIndex = 60;
            this.lab�o�͏�.Text = "�o�͏�";
            // 
            // tex���喼
            // 
            this.tex���喼.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���喼.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex���喼.Location = new System.Drawing.Point(100, 122);
            this.tex���喼.MaxLength = 20;
            this.tex���喼.Name = "tex���喼";
            this.tex���喼.Size = new System.Drawing.Size(326, 23);
            this.tex���喼.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(24, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 14);
            this.label6.TabIndex = 55;
            this.label6.Text = "��";
            // 
            // lab���喼
            // 
            this.lab���喼.Location = new System.Drawing.Point(38, 126);
            this.lab���喼.Name = "lab���喼";
            this.lab���喼.Size = new System.Drawing.Size(62, 14);
            this.lab���喼.TabIndex = 54;
            this.lab���喼.Text = "�Z�N�V������";
            // 
            // tex����R�[�h
            // 
            this.tex����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex����R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex����R�[�h.Location = new System.Drawing.Point(100, 98);
            this.tex����R�[�h.MaxLength = 12;
            this.tex����R�[�h.Name = "tex����R�[�h";
            this.tex����R�[�h.Size = new System.Drawing.Size(110, 23);
            this.tex����R�[�h.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 14);
            this.label4.TabIndex = 52;
            this.label4.Text = "��";
            // 
            // lab����R�[�h
            // 
            this.lab����R�[�h.Location = new System.Drawing.Point(38, 102);
            this.lab����R�[�h.Name = "lab����R�[�h";
            this.lab����R�[�h.Size = new System.Drawing.Size(62, 14);
            this.lab����R�[�h.TabIndex = 51;
            this.lab����R�[�h.Text = "�R�[�h";
            // 
            // axGT����
            // 
            this.axGT����.DataSource = null;
            this.axGT����.Location = new System.Drawing.Point(28, 4);
            this.axGT����.Name = "axGT����";
            this.axGT����.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT����.OcxState")));
            this.axGT����.Size = new System.Drawing.Size(372, 92);
            this.axGT����.TabIndex = 1;
            this.axGT����.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT����_CurPlaceChanged);
            this.axGT����.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT����_CelDblClick);
            this.axGT����.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT����_KeyDownEvent);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.label8.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 356);
            this.label8.TabIndex = 44;
            this.label8.Text = "�Z�N�V�������";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl���p��
            // 
            this.pnl���p��.BackColor = System.Drawing.Color.Honeydew;
            this.pnl���p��.Controls.Add(this.tex�p�X���[�h�X�V��);
            this.pnl���p��.Controls.Add(this.lab�p�X���[�h�X�V��);
            this.pnl���p��.Controls.Add(this.chb���x������֎~);
            this.pnl���p��.Controls.Add(this.btn�p�X���[�h���b�N);
            this.pnl���p��.Controls.Add(this.btn�������s);
            this.pnl���p��.Controls.Add(this.btn�ב��l����);
            this.pnl���p��.Controls.Add(this.btn���p�Ҏ��);
            this.pnl���p��.Controls.Add(this.btn���p�ҍ폜);
            this.pnl���p��.Controls.Add(this.btn���p�ғo�^);
            this.pnl���p��.Controls.Add(this.tex�ב��l�R�[�h);
            this.pnl���p��.Controls.Add(this.lab�ב��l�R�[�h);
            this.pnl���p��.Controls.Add(this.tex���p�Җ�);
            this.pnl���p��.Controls.Add(this.label21);
            this.pnl���p��.Controls.Add(this.lab���p�Җ�);
            this.pnl���p��.Controls.Add(this.tex�p�X���[�h);
            this.pnl���p��.Controls.Add(this.label23);
            this.pnl���p��.Controls.Add(this.lab�p�X���[�h);
            this.pnl���p��.Controls.Add(this.tex���p�҃R�[�h);
            this.pnl���p��.Controls.Add(this.label25);
            this.pnl���p��.Controls.Add(this.lab���p�҃R�[�h);
            this.pnl���p��.Controls.Add(this.axGT���p��);
            this.pnl���p��.Controls.Add(this.label15);
            this.pnl���p��.ForeColor = System.Drawing.Color.LimeGreen;
            this.pnl���p��.Location = new System.Drawing.Point(0, 6);
            this.pnl���p��.Name = "pnl���p��";
            this.pnl���p��.Size = new System.Drawing.Size(352, 356);
            this.pnl���p��.TabIndex = 3;
            // 
            // tex�p�X���[�h�X�V��
            // 
            this.tex�p�X���[�h�X�V��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�p�X���[�h�X�V��.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�p�X���[�h�X�V��.Location = new System.Drawing.Point(258, 198);
            this.tex�p�X���[�h�X�V��.MaxLength = 8;
            this.tex�p�X���[�h�X�V��.Name = "tex�p�X���[�h�X�V��";
            this.tex�p�X���[�h�X�V��.Size = new System.Drawing.Size(72, 23);
            this.tex�p�X���[�h�X�V��.TabIndex = 11;
            // 
            // lab�p�X���[�h�X�V��
            // 
            this.lab�p�X���[�h�X�V��.Location = new System.Drawing.Point(168, 202);
            this.lab�p�X���[�h�X�V��.Name = "lab�p�X���[�h�X�V��";
            this.lab�p�X���[�h�X�V��.Size = new System.Drawing.Size(90, 14);
            this.lab�p�X���[�h�X�V��.TabIndex = 83;
            this.lab�p�X���[�h�X�V��.Text = "�p�X���[�h�X�V��";
            // 
            // chb���x������֎~
            // 
            this.chb���x������֎~.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb���x������֎~.Location = new System.Drawing.Point(32, 200);
            this.chb���x������֎~.Name = "chb���x������֎~";
            this.chb���x������֎~.Size = new System.Drawing.Size(100, 16);
            this.chb���x������֎~.TabIndex = 10;
            this.chb���x������֎~.Text = "���و���֎~";
            this.chb���x������֎~.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn�p�X���[�h���b�N
            // 
            this.btn�p�X���[�h���b�N.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�p�X���[�h���b�N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�p�X���[�h���b�N.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�p�X���[�h���b�N.ForeColor = System.Drawing.Color.White;
            this.btn�p�X���[�h���b�N.Location = new System.Drawing.Point(106, 222);
            this.btn�p�X���[�h���b�N.Name = "btn�p�X���[�h���b�N";
            this.btn�p�X���[�h���b�N.Size = new System.Drawing.Size(104, 22);
            this.btn�p�X���[�h���b�N.TabIndex = 12;
            this.btn�p�X���[�h���b�N.TabStop = false;
            this.btn�p�X���[�h���b�N.Text = "�p�X���[�h���b�N����";
            this.btn�p�X���[�h���b�N.UseVisualStyleBackColor = false;
            this.btn�p�X���[�h���b�N.Click += new System.EventHandler(this.btn�p�X���[�h���b�N_Click);
            // 
            // btn�������s
            // 
            this.btn�������s.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�������s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�������s.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�������s.ForeColor = System.Drawing.Color.White;
            this.btn�������s.Location = new System.Drawing.Point(280, 146);
            this.btn�������s.Name = "btn�������s";
            this.btn�������s.Size = new System.Drawing.Size(60, 22);
            this.btn�������s.TabIndex = 5;
            this.btn�������s.TabStop = false;
            this.btn�������s.Text = "�������s";
            this.btn�������s.UseVisualStyleBackColor = false;
            this.btn�������s.Click += new System.EventHandler(this.btn�������s_Click);
            // 
            // btn�ב��l����
            // 
            this.btn�ב��l����.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�ב��l����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�ב��l����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�ב��l����.ForeColor = System.Drawing.Color.White;
            this.btn�ב��l����.Location = new System.Drawing.Point(264, 170);
            this.btn�ב��l����.Name = "btn�ב��l����";
            this.btn�ב��l����.Size = new System.Drawing.Size(48, 22);
            this.btn�ב��l����.TabIndex = 9;
            this.btn�ב��l����.TabStop = false;
            this.btn�ב��l����.Text = "����";
            this.btn�ב��l����.UseVisualStyleBackColor = false;
            this.btn�ב��l����.Click += new System.EventHandler(this.btn�ב��l����_Click);
            // 
            // btn���p�Ҏ��
            // 
            this.btn���p�Ҏ��.BackColor = System.Drawing.Color.Blue;
            this.btn���p�Ҏ��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn���p�Ҏ��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn���p�Ҏ��.ForeColor = System.Drawing.Color.White;
            this.btn���p�Ҏ��.Location = new System.Drawing.Point(290, 328);
            this.btn���p�Ҏ��.Name = "btn���p�Ҏ��";
            this.btn���p�Ҏ��.Size = new System.Drawing.Size(48, 22);
            this.btn���p�Ҏ��.TabIndex = 15;
            this.btn���p�Ҏ��.Text = "���";
            this.btn���p�Ҏ��.UseVisualStyleBackColor = false;
            this.btn���p�Ҏ��.Click += new System.EventHandler(this.btn���p�Ҏ��_Click);
            // 
            // btn���p�ҍ폜
            // 
            this.btn���p�ҍ폜.BackColor = System.Drawing.Color.Blue;
            this.btn���p�ҍ폜.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn���p�ҍ폜.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn���p�ҍ폜.ForeColor = System.Drawing.Color.White;
            this.btn���p�ҍ폜.Location = new System.Drawing.Point(236, 328);
            this.btn���p�ҍ폜.Name = "btn���p�ҍ폜";
            this.btn���p�ҍ폜.Size = new System.Drawing.Size(48, 22);
            this.btn���p�ҍ폜.TabIndex = 14;
            this.btn���p�ҍ폜.Text = "�폜";
            this.btn���p�ҍ폜.UseVisualStyleBackColor = false;
            this.btn���p�ҍ폜.Click += new System.EventHandler(this.btn���p�ҍ폜_Click);
            // 
            // btn���p�ғo�^
            // 
            this.btn���p�ғo�^.BackColor = System.Drawing.Color.Blue;
            this.btn���p�ғo�^.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn���p�ғo�^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn���p�ғo�^.ForeColor = System.Drawing.Color.White;
            this.btn���p�ғo�^.Location = new System.Drawing.Point(182, 328);
            this.btn���p�ғo�^.Name = "btn���p�ғo�^";
            this.btn���p�ғo�^.Size = new System.Drawing.Size(48, 22);
            this.btn���p�ғo�^.TabIndex = 13;
            this.btn���p�ғo�^.Text = "�o�^";
            this.btn���p�ғo�^.UseVisualStyleBackColor = false;
            this.btn���p�ғo�^.Click += new System.EventHandler(this.btn���p�ғo�^_Click);
            // 
            // tex�ב��l�R�[�h
            // 
            this.tex�ב��l�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�ב��l�R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�ב��l�R�[�h.Location = new System.Drawing.Point(106, 170);
            this.tex�ב��l�R�[�h.MaxLength = 12;
            this.tex�ב��l�R�[�h.Name = "tex�ב��l�R�[�h";
            this.tex�ב��l�R�[�h.Size = new System.Drawing.Size(154, 23);
            this.tex�ב��l�R�[�h.TabIndex = 8;
            this.tex�ב��l�R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�ב��l�R�[�h_KeyDown);
            this.tex�ב��l�R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�ב��l�R�[�h_KeyPress);
            // 
            // lab�ב��l�R�[�h
            // 
            this.lab�ב��l�R�[�h.Location = new System.Drawing.Point(36, 176);
            this.lab�ב��l�R�[�h.Name = "lab�ב��l�R�[�h";
            this.lab�ב��l�R�[�h.Size = new System.Drawing.Size(70, 14);
            this.lab�ב��l�R�[�h.TabIndex = 82;
            this.lab�ב��l�R�[�h.Text = "�ב��l�R�[�h";
            // 
            // tex���p�Җ�
            // 
            this.tex���p�Җ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���p�Җ�.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex���p�Җ�.Location = new System.Drawing.Point(106, 122);
            this.tex���p�Җ�.MaxLength = 20;
            this.tex���p�Җ�.Name = "tex���p�Җ�";
            this.tex���p�Җ�.Size = new System.Drawing.Size(244, 23);
            this.tex���p�Җ�.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Honeydew;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(24, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 14);
            this.label21.TabIndex = 77;
            this.label21.Text = "��";
            // 
            // lab���p�Җ�
            // 
            this.lab���p�Җ�.Location = new System.Drawing.Point(38, 128);
            this.lab���p�Җ�.Name = "lab���p�Җ�";
            this.lab���p�Җ�.Size = new System.Drawing.Size(70, 14);
            this.lab���p�Җ�.TabIndex = 76;
            this.lab���p�Җ�.Text = "���[�U�[��";
            // 
            // tex�p�X���[�h
            // 
            this.tex�p�X���[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�p�X���[�h.Location = new System.Drawing.Point(106, 146);
            this.tex�p�X���[�h.MaxLength = 40;
            this.tex�p�X���[�h.Name = "tex�p�X���[�h";
            this.tex�p�X���[�h.Size = new System.Drawing.Size(170, 23);
            this.tex�p�X���[�h.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Honeydew;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(24, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 14);
            this.label23.TabIndex = 74;
            this.label23.Text = "��";
            // 
            // lab�p�X���[�h
            // 
            this.lab�p�X���[�h.Location = new System.Drawing.Point(38, 152);
            this.lab�p�X���[�h.Name = "lab�p�X���[�h";
            this.lab�p�X���[�h.Size = new System.Drawing.Size(70, 14);
            this.lab�p�X���[�h.TabIndex = 73;
            this.lab�p�X���[�h.Text = "�p�X���[�h";
            // 
            // tex���p�҃R�[�h
            // 
            this.tex���p�҃R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���p�҃R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex���p�҃R�[�h.Location = new System.Drawing.Point(106, 98);
            this.tex���p�҃R�[�h.MaxLength = 6;
            this.tex���p�҃R�[�h.Name = "tex���p�҃R�[�h";
            this.tex���p�҃R�[�h.Size = new System.Drawing.Size(82, 23);
            this.tex���p�҃R�[�h.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Honeydew;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(24, 104);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(16, 14);
            this.label25.TabIndex = 71;
            this.label25.Text = "��";
            // 
            // lab���p�҃R�[�h
            // 
            this.lab���p�҃R�[�h.Location = new System.Drawing.Point(38, 104);
            this.lab���p�҃R�[�h.Name = "lab���p�҃R�[�h";
            this.lab���p�҃R�[�h.Size = new System.Drawing.Size(70, 14);
            this.lab���p�҃R�[�h.TabIndex = 70;
            this.lab���p�҃R�[�h.Text = "�R�[�h";
            // 
            // axGT���p��
            // 
            this.axGT���p��.DataSource = null;
            this.axGT���p��.Location = new System.Drawing.Point(24, 4);
            this.axGT���p��.Name = "axGT���p��";
            this.axGT���p��.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT���p��.OcxState")));
            this.axGT���p��.Size = new System.Drawing.Size(326, 92);
            this.axGT���p��.TabIndex = 0;
            this.axGT���p��.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT���p��_CurPlaceChanged);
            this.axGT���p��.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT���p��_CelDblClick);
            this.axGT���p��.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT���p��_KeyDownEvent);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.label15.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 356);
            this.label15.TabIndex = 44;
            this.label15.Text = "���b�U�b���";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(26, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnl���);
            this.groupBox2.Location = new System.Drawing.Point(4, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnl����);
            this.groupBox3.Location = new System.Drawing.Point(4, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 364);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnl���p��);
            this.groupBox4.Location = new System.Drawing.Point(438, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 364);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(654, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 31;
            this.label5.Text = "�󂪂��鍀�ڂ́@�@�K�{���͍��ڂł��B";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(640, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 14);
            this.label11.TabIndex = 30;
            this.label11.Text = "��";
            // 
            // ����}�X�^
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(794, 580);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(802, 607);
            this.Name = "����}�X�^";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 ���q�l��񃁃��e�i���X";
            this.Closed += new System.EventHandler(this.����}�X�^_Closed);
            this.Load += new System.EventHandler(this.����}�X�^_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On�G���^�[�ړ�);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On�G���^�[�L�����Z��);
            this.pnl���.ResumeLayout(false);
            this.pnl���.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnl����.ResumeLayout(false);
            this.pnl����.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num�T�[�}���䐔)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num�o�͏�)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGT����)).EndInit();
            this.pnl���p��.ResumeLayout(false);
            this.pnl���p��.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT���p��)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void ����}�X�^_Load(object sender, System.EventArgs e)
		{
			s����R�[�h = "";
			tex�F�؉����.Text = gs�����;
			tex�F�ؗ��p�Җ�.Text = gs���p�Җ�;
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
			cb�^�p���̂��q�l�̂�.Checked = true;
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END

			�������[�h();

			// �����̏����ݒ�
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;

			// ���僊�X�g�̏����ݒ�
			axGT����.Cols = 4;
			axGT����.Rows = 4;
			axGT����.ColSep = "|";
			axGT����.CaretRow = 1;
			axGT����.NoBeep = true;

			axGT����.set_RowsText(0, "|�R�[�h|�Z�N�V������|�o�͏�|�X�֔ԍ�|");
//			axGT����.ColsWidth = "0|7|20|5|7|";
			axGT����.ColsWidth = "0|7|20|13.6|13.6|";
			axGT����.ColsAlignHorz = "1|1|0|2|1|";
            
//			axGT����.set_CelForeColor(axGT����.CaretRow,0,111111);
			axGT����.set_CelForeColor(axGT����.CaretRow,0,0x98FB98);  //BGR
			axGT����.set_CelBackColor(axGT����.CaretRow,0,0x006000);

			axGT����.Clear();
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT����.CaretCol = 1;
			axGT����_CurPlaceChanged(null,null);
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END

			// ���p�҃��X�g�̏����ݒ�
			axGT���p��.Cols = 4;
			axGT���p��.Rows = 4;
			axGT���p��.ColSep = "|";
			axGT���p��.CaretRow = 1;
			axGT���p��.NoBeep = true;

			axGT���p��.set_RowsText(0, "|�R�[�h|���[�U�[��|�Z�N�V����|�ב��l�R�[�h|");
//			axGT���p��.ColsWidth = "0|5|18|5|7|";
			axGT���p��.ColsWidth = "0|5|18.6|11.8|11.8|";
			axGT���p��.ColsAlignHorz = "1|1|0|1|1|";
            
//			axGT���p��.set_CelForeColor(axGT���p��.CaretRow,0,111111);
			axGT���p��.set_CelForeColor(axGT���p��.CaretRow,0,0x98FB98);  //BGR
			axGT���p��.set_CelBackColor(axGT���p��.CaretRow,0,0x006000);

			axGT���p��.Clear();
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT���p��.CaretCol = 1;
			axGT���p��_CurPlaceChanged(null,null);
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
		}

		private void �������[�h()
		{
			����o�^���[�h();
			����o�^���[�h();
			���p�ғo�^���[�h();
			pnl���.Enabled = false;
			pnl����.Enabled = false;
			pnl���p��.Enabled = false;
			chb�g�p�I����.Checked = false;
//			dtp�g�p�I����.Enabled = false;
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
			cb�ː��d�ʓ��͎捞.Checked = false;
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� START
			btn�Г��`������X�o�^.Enabled = false;
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� END
			lab�I����.Visible = true;
			tex����R�[�h.Focus();
		}
		private void ����o�^���[�h()
		{
			btn����o�^.Text = "�o�^";

			tex�����.Text = "";
			//dtp�g�p�J�n��
			cmb�Ǘ��ҋ敪.SelectedIndex = 0;
// ADD 2007.02.15 ���s�j���� �c�Ə�����Ή� START
			cmb�Ǘ��ҋ敪.Text
				= (string)cmb�Ǘ��ҋ敪.Items[cmb�Ǘ��ҋ敪.SelectedIndex];
// ADD 2007.02.15 ���s�j���� �c�Ə�����Ή� END
			
			s����X�V���� = "00000000000000";
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� START
			btn�Г��`������X�o�^.Enabled = false;
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� END
		}

		private void ����X�V���[�h()
		{
			btn����o�^.Text = "�X�V";
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� START
			//�Г��`����̏ꍇ�A���X���o�^��ʂ��N������{�^��������������
			if(tex����R�[�h.Text.Trim().Substring(0,2) == "FK")
			{
				btn�Г��`������X�o�^.Enabled = true;
			}
			else
			{
				btn�Г��`������X�o�^.Enabled = false;
			}
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� END
		}

		private void ����o�^���[�h()
		{
			tex����R�[�h.Enabled = true;
			btn����o�^.Text = "�o�^";
			btn����폜.Enabled = false;

			tex����R�[�h.Text = "";
			tex���喼.Text = "";
			num�o�͏�.Text = "0";
			tex�X�֔ԍ��P.Text = "";
			tex�X�֔ԍ��Q.Text = "";
			tex�Ǘ��X����.Text = "";
			tex�ݒu��Z���P.Text = "";
			tex�ݒu��Z���Q.Text = "";
			num�T�[�}���䐔.Text = "0";
// ADD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� START
			tex�V���A���ԍ��P.Text = "";
			cmb�V���A���ԍ��P.SelectedIndex = 0;
			tex�V���A���ԍ��Q.Text = "";
			cmb�V���A���ԍ��Q.SelectedIndex = 0;
			tex�V���A���ԍ��R.Text = "";
			cmb�V���A���ԍ��R.SelectedIndex = 0;
			tex�V���A���ԍ��S.Text = "";
			cmb�V���A���ԍ��S.SelectedIndex = 0;
			tex�ݒu�ꏊ�g�p��.Text = "0";
// ADD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� END
// ADD 2005.08.08 ���s�j�����J �ȈՃ��[�U�[������ START
			tex�ȈՃ��[�U�[.Text = "";
// ADD 2005.08.08 ���s�j�����J �ȈՃ��[�U�[������ END

			s����X�V���� = "00000000000000";

// ADD 2005.06.13 ���s�j�����J ���[�U�[��� START
			���p�ғo�^���[�h();
			axGT���p��.Clear();
			axGT���p��.CaretRow = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT���p��.CaretCol = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
			axGT���p��_CurPlaceChanged(null,null);
			pnl���p��.Enabled = false;
// ADD 2005.06.13 ���s�j�����J ���[�U�[��� END

		}

		private void ����X�V���[�h()
		{
			tex����R�[�h.Enabled = false;
			btn����o�^.Text = "�X�V";
			btn����폜.Enabled = true;

// ADD 2005.06.13 ���s�j�����J ���[�U�[��� START
			���p�ғo�^���[�h();
			axGT���p��.Clear();
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT���p��.CaretRow = 1;
			axGT���p��.CaretCol = 1;
			axGT���p��_CurPlaceChanged(null,null);
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
			pnl���p��.Enabled = true;
// ADD 2005.06.13 ���s�j�����J ���[�U�[��� END

		}

		private void ���p�ғo�^���[�h()
		{
			tex���p�҃R�[�h.Enabled = true;
			btn���p�ғo�^.Text = "�o�^";
			btn���p�ҍ폜.Enabled = false;

			tex���p�҃R�[�h.Text = "";
			tex���p�Җ�.Text = "";
			tex�p�X���[�h.Text = "";
// DEL 2005.06.08 ���s�j�����J �ē��͍폜 START
//			tex�p�X���[�h�ē���.Text = "";
// DEL 2005.06.08 ���s�j�����J �ē��͍폜 END
//			tex���p�ҕ���R�[�h.Text = "";
//			tex���p�ҕ��喼.Text = "";
			tex�ב��l�R�[�h.Text = "";
			btn�p�X���[�h���b�N.Enabled = false;
// ADD 2008.05.29 ���s�j���� �p�X���[�h�X�V�N������\�� START
			tex�p�X���[�h�X�V��.Text = "";
// ADD 2008.05.29 ���s�j���� �p�X���[�h�X�V�N������\�� START
// ADD 2005.07.21 ���s�j���� �X�����[�U�Ή� START
			chb���x������֎~.Checked = false;
// ADD 2005.07.21 ���s�j���� �X�����[�U�Ή� END
			
			s���p�ҍX�V���� = "00000000000000";
			s�F�؃G���[�� = 0;
		}

		private void ���p�ҍX�V���[�h()
		{
			tex���p�҃R�[�h.Enabled = false;
			btn���p�ғo�^.Text = "�X�V";
			btn���p�ҍ폜.Enabled = true;
			btn�p�X���[�h���b�N.Enabled = false;
		}

		private void tex����R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�������.Focus();
				������ꗗ();
				e.Handled = true;
			}
		}

		private void btn�������_Click(object sender, System.EventArgs e)
		{
			������ꗗ();
		}

		private void btn������s_Click(object sender, System.EventArgs e)
		{
			�����񌟍�();
		}

		private void ������ꗗ()
		{
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
// MOD 2008.05.07 ���s�j���� ���b�Z�[�W�ύX[���]��[���q�l] START
//			if(!���p�`�F�b�N(tex����R�[�h, "����R�[�h")) return;
			if(!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
// MOD 2008.05.07 ���s�j���� ���b�Z�[�W�ύX[���]��[���q�l] END

			// ������ʂ��E���ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			������� ��� = new �������();
//			���.Left = this.Left + 404;
//			���.Top = this.Top;

			// �R�[�h�̏����\��
//			���.s����R�[�h = tex����R�[�h.Text.Trim();
//			���.s����� = "";
//			���.ShowDialog();
			if (g������� == null)	 g������� = new �������();
			g�������.Left = this.Left + 404;
			g�������.Top = this.Top;

			// �R�[�h�̏����\��
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� START
//			g�������.s����R�[�h = tex����R�[�h.Text.Trim();
			g�������.s����R�[�h = "";
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� END
			g�������.s����� = "";
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
			g�������.b�^�p���̂��q�l�̂� = cb�^�p���̂��q�l�̂�.Checked;
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END
			g�������.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if(���.s����R�[�h.Trim().Length > 0)
			if(g�������.s����R�[�h.Trim().Length > 0)
			{
//				tex����R�[�h.Text = ���.s����R�[�h.Trim();
				tex����R�[�h.Text = g�������.s����R�[�h.Trim();
				�����񌟍�();
			}
			else
			{
				tex����R�[�h.Focus();
			}
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
		}

		private void �����񌟍�()
		{
			tex���b�Z�[�W.Text = "";
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
// MOD 2008.05.07 ���s�j���� ���b�Z�[�W�ύX[���]��[���q�l] START
//			if(!�K�{�`�F�b�N(tex����R�[�h, "����R�[�h")) return;
//			if(!���p�`�F�b�N(tex����R�[�h, "����R�[�h")) return;
			if(!�K�{�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
			if(!���p�`�F�b�N(tex����R�[�h, "���q�l�R�[�h")) return;
// MOD 2008.05.07 ���s�j���� ���b�Z�[�W�ύX[���]��[���q�l] END

			s����R�[�h = tex����R�[�h.Text.Trim();
			axGT����.Clear();
			axGT���p��.Clear();
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT����.CaretRow = 1;
			axGT����.CaretCol = 1;
			axGT����_CurPlaceChanged(null,null);
			axGT���p��.CaretRow = 1;
			axGT���p��.CaretCol = 1;
			axGT���p��_CurPlaceChanged(null,null);
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END

			pnl���.Enabled = true;
			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			axGT����.CaretRow   = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT����.CaretCol = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
			axGT����_CurPlaceChanged(null,null);
			axGT���p��.CaretRow = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT���p��.CaretCol = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
			axGT���p��_CurPlaceChanged(null,null);

			try
			{
				string[] sKey  = new string[1];
				sKey[0] = s����R�[�h;
				string[] sList = sv_maintenance.Sel_Member(gsa���[�U, sKey);

				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex����R�[�h.Text = sList[1].Trim();
					tex�����.Text     = sList[2].Trim();
					if (sList[3].Trim().Equals("00000000"))
						dtp�g�p�J�n��.Value = System.DateTime.Now;
					else
//
//						dtp�g�p�J�n��.Value = System.DateTime.Parse(sList[3].Substring(0, 4)
//							+ "/" + sList[3].Substring(4, 2)
//							+ "/" + sList[3].Substring(6, 2));
						dtp�g�p�J�n��.Value = new DateTime(int.Parse(sList[3].Substring(0, 4)),
															int.Parse(sList[3].Substring(4, 2)),
															int.Parse(sList[3].Substring(6, 2)));
//
					if (sList[4].Trim().Equals("9")){
// MOD 2007.02.06 ���s�j���� �c�Ə�����Ή� START
//						cmb�Ǘ��ҋ敪.SelectedIndex = 2;
						cmb�Ǘ��ҋ敪.SelectedIndex = 0;
						cmb�Ǘ��ҋ敪.Text = "�����e�i���X���";
// MOD 2007.02.06 ���s�j���� �c�Ə�����Ή� END
					}else{
						cmb�Ǘ��ҋ敪.SelectedIndex = int.Parse(sList[4]);
// ADD 2007.02.15 ���s�j���� �c�Ə�����Ή� START
						cmb�Ǘ��ҋ敪.Text
							= (string)cmb�Ǘ��ҋ敪.Items[cmb�Ǘ��ҋ敪.SelectedIndex];
// ADD 2007.02.15 ���s�j���� �c�Ə�����Ή� END
					}
					if (sList[5].Trim().Equals("99999999"))
						chb�g�p�I����.Checked = false;
					else
					{
						chb�g�p�I����.Checked = true;
//						dtp�g�p�I����.Value = System.DateTime.Parse(sList[5].Substring(0, 4)
//							+ "/" + sList[5].Substring(4, 2)
//							+ "/" + sList[5].Substring(6, 2));
						dtp�g�p�I����.Value = new DateTime(int.Parse(sList[5].Substring(0, 4)),
															int.Parse(sList[5].Substring(4, 2)),
															int.Parse(sList[5].Substring(6, 2)));
					}
					s����X�V���� = sList[6].Trim();
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
					if(sList.Length > 8){
						if(sList[8] == "1"){
							cb�ː��d�ʓ��͎捞.Checked = true;
						}else{
							cb�ː��d�ʓ��͎捞.Checked = false;
						}
					}
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END

					�����񌟍�();
//					���p�ҏ�񌟍�();

					����X�V���[�h();
					pnl����.Enabled = true;
					pnl���p��.Enabled = true;

					���p�ғo�^���[�h();
					����o�^���[�h();
					tex�����.Focus();
				}
				else if (sList[0].Equals("�Y���f�[�^������܂���"))
				{
					tex���b�Z�[�W.Text = "�V�K�o�^";
					����o�^���[�h();
					pnl����.Enabled = false;
					pnl���p��.Enabled = false;
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� START
					btn�Г��`������X�o�^.Enabled = false;
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� END

					���p�ғo�^���[�h();
					����o�^���[�h();
					tex�����.Focus();
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					����o�^���[�h();
					tex����R�[�h.Focus();
					pnl���.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn����o�^_Click(object sender, System.EventArgs e)
		{
			tex�����.Text = tex�����.Text.Trim();
// MOD 2008.05.07 ���s�j���� ���b�Z�[�W�ύX[���]��[���q�l] START
//			if (!�K�{�`�F�b�N(tex�����, "�����")) return;
//			if (!�S�p�`�F�b�N(tex�����, "�����")) return;
			if (!�K�{�`�F�b�N(tex�����, "���q�l��")) return;
			if (!�S�p�`�F�b�N(tex�����, "���q�l��")) return;
// MOD 2008.05.07 ���s�j���� ���b�Z�[�W�ύX[���]��[���q�l] END
// ADD 2007.02.08 ���s�j���� �c�Ə�����Ή� START
			if(cmb�Ǘ��ҋ敪.SelectedIndex < 0){
				MessageBox.Show("�Ǘ��ҋ敪���Ⴂ�܂�","���̓`�F�b�N",MessageBoxButtons.OK);
				return;
			}
// ADD 2007.02.08 ���s�j���� �c�Ə�����Ή� END
// ADD 2007.02.15 ���s�j���� �c�Ə�����Ή� START
			cmb�Ǘ��ҋ敪.Text
				= (string)cmb�Ǘ��ҋ敪.Items[cmb�Ǘ��ҋ敪.SelectedIndex];
// ADD 2007.02.15 ���s�j���� �c�Ə�����Ή� END
// ADD 2007.02.08 ���s�j���� �c�Ə�����Ή� START
			if(cmb�Ǘ��ҋ敪.SelectedIndex < 0){
				MessageBox.Show("�Ǘ��ҋ敪���Ⴂ�܂�","���̓`�F�b�N",MessageBoxButtons.OK);
				return;
			}
// ADD 2007.02.08 ���s�j���� �c�Ə�����Ή� END
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
			if(cmb�Ǘ��ҋ敪.SelectedIndex==0 || cmb�Ǘ��ҋ敪.SelectedIndex==2 )
			{
				if (s����R�[�h.Substring(0,1)=="J")
				{
					MessageBox.Show("�Ǘ��ҋ敪���Ⴂ�܂�","���̓`�F�b�N",MessageBoxButtons.OK);
					return;
				}
			}else if(cmb�Ǘ��ҋ敪.SelectedIndex==3 || cmb�Ǘ��ҋ敪.SelectedIndex==4)
			{
				if (s����R�[�h.Substring(0,1)!="J")
				{
					MessageBox.Show("�Ǘ��ҋ敪���Ⴂ�܂�","���̓`�F�b�N",MessageBoxButtons.OK);
					return;
				}
			}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END


			tex���b�Z�[�W.Text = btn����o�^.Text + "���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
//				string[] sKey  = new string[7];
				string[] sKey  = new string[8];
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
				sKey[0] = s����R�[�h;
				sKey[1] = tex�����.Text;
				sKey[2] = dtp�g�p�J�n��.Value.Year.ToString() + dtp�g�p�J�n��.Value.Month.ToString().PadLeft(2, '0') + dtp�g�p�J�n��.Value.Day.ToString().PadLeft(2, '0');
				if (chb�g�p�I����.Checked)
					sKey[3] = dtp�g�p�I����.Value.Year.ToString() + dtp�g�p�I����.Value.Month.ToString().PadLeft(2, '0') + dtp�g�p�I����.Value.Day.ToString().PadLeft(2, '0');
				else
					sKey[3] = "99999999";
// MOD 2007.02.06 ���s�j���� �c�Ə�����Ή� START
//				if (cmb�Ǘ��ҋ敪.SelectedIndex == 2)
//					sKey[4] = "9";
//				else
//					sKey[4] = cmb�Ǘ��ҋ敪.SelectedIndex.ToString();
				sKey[4] = cmb�Ǘ��ҋ敪.SelectedIndex.ToString();
// MOD 2007.02.06 ���s�j���� �c�Ə�����Ή� START
				sKey[5] = s����X�V����;
				sKey[6] = gs���p�҃R�[�h;
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
				if(cb�ː��d�ʓ��͎捞.Checked){
					sKey[7] = "1";
				}else{
					sKey[7] = "0";
				}
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
				if (btn����o�^.Text.Equals("�o�^"))
				{
					string[] sList = sv_maintenance.Ins_Member(gsa���[�U, sKey);
					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
						//����̒ǉ�
						s����X�V���� = sList[1].Trim();
						����X�V���[�h();
						pnl����.Enabled = true;
						pnl���p��.Enabled = true;
					}
					else
					{
						�r�[�v��();
					}
				}
				else
				{
					string[] sList = sv_maintenance.Upd_Member(gsa���[�U, sKey);
					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
						tex���b�Z�[�W.Text = "";
						//����̍X�V
						s����X�V���� = sList[1].Trim();
						����X�V���[�h();
						pnl����.Enabled = true;
						pnl���p��.Enabled = true;
					}
					else
					{
						�r�[�v��();
					}
				}
				tex�����.Focus();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

// ADD 2005.08.08 ���s�j�����J ����폜 START
		private void btn����폜_Click(object sender, System.EventArgs e)
		{
// MOD 2009.04.28 ���s�j���� �폜�m�F���b�Z�[�W�̒ǉ� START
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();

			// �ŏI�m�F
			if (MessageBox.Show("�폜���Ă���낵���ł����H", "�m�F"
					, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No){
				return;
			}
// MOD 2009.04.28 ���s�j���� �폜�m�F���b�Z�[�W�̒ǉ� END

			tex���b�Z�[�W.Text = "�폜���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[4];
				sKey[0] = s����R�[�h;
				sKey[1] = s����X�V����;
				sKey[2] = gs���p�҃R�[�h;

				string[] sList = sv_maintenance.Del_Member(gsa���[�U, sKey);
				tex���b�Z�[�W.Text = sList[0];
				if (sList[0].Equals("����I��"))
				{
					tex����R�[�h.Text = "";
					dtp�g�p�J�n��.Value = System.DateTime.Now;
					dtp�g�p�I����.Value = System.DateTime.Now;
					axGT����.Clear();
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
					axGT����.CaretRow = 1;
					axGT����.CaretCol = 1;
					axGT����_CurPlaceChanged(null,null);
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
					�������[�h();
				}
				else
				{
					�r�[�v��();
				}
				tex����R�[�h.Focus();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
// ADD 2005.08.08 ���s�j�����J ����폜 END

		private void axGT����_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			���匟��();
		}
		private void axGT����_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				���匟��();
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT����, true, true, true, true);
			}
		}
		
		private void btn����o�^_Click(object sender, System.EventArgs e)
		{
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
			if (!�K�{�`�F�b�N(tex����R�[�h, "�Z�N�V����")) return;
			if (!���p�`�F�b�N(tex����R�[�h, "�Z�N�V����")) return;

			tex���喼.Text = tex���喼.Text.Trim();
			if (!�K�{�`�F�b�N(tex���喼, "�Z�N�V������")) return;
			if (!�S�p�`�F�b�N(tex���喼, "�Z�N�V������")) return;

			if (!�͈̓`�F�b�N(num�o�͏�, "�o�͏�")) return;
			if (!�͈̓`�F�b�N(num�T�[�}���䐔, "�T�[�}���䐔")) return;
			
			//�X�֔ԍ��`�F�b�N
			tex�X�֔ԍ��P.Text = tex�X�֔ԍ��P.Text.Trim();
			tex�X�֔ԍ��Q.Text = tex�X�֔ԍ��Q.Text.Trim();
			if (!�K�{�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return;
			if (!���p�`�F�b�N(tex�X�֔ԍ��P, "�X�֔ԍ��P")) return;
			if (!�K�{�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return;
			if (!���p�`�F�b�N(tex�X�֔ԍ��Q, "�X�֔ԍ��Q")) return;
			if (!�X�֔ԍ�����())
			{
				MessageBox.Show("�X�֔ԍ�(" + tex�X�֔ԍ��P.Text + tex�X�֔ԍ��Q.Text + ")�����݂��܂���" ,"���̓`�F�b�N",MessageBoxButtons.OK);
				tex�X�֔ԍ��P.Focus();
				return;
			}

// ADD 2008.05.07 ���s�j���� �ݒu�ꏊ�Z���̑S�p�`�F�b�N�̒ǉ� START
			//�ݒu��Z���`�F�b�N
			tex�ݒu��Z���P.Text = tex�ݒu��Z���P.Text.Trim();
			tex�ݒu��Z���Q.Text = tex�ݒu��Z���Q.Text.Trim();
			if(!�S�p�`�F�b�N(tex�ݒu��Z���P, "�ݒu��Z���P")) return;
			if(!�S�p�`�F�b�N(tex�ݒu��Z���Q, "�ݒu��Z���Q")) return;
// ADD 2008.05.07 ���s�j���� �ݒu�ꏊ�Z���̑S�p�`�F�b�N�̒ǉ� END
			if (tex�ݒu��Z���P.Text.Length == 0) tex�ݒu��Z���P.Text = " ";
			if (tex�ݒu��Z���Q.Text.Length == 0) tex�ݒu��Z���Q.Text = " ";
			
// ADD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� START
			if(!�͈̓`�F�b�N(num�T�[�}���䐔, "�ݒu�䐔")) return;
			tex�V���A���ԍ��P.Text = tex�V���A���ԍ��P.Text.TrimEnd();
			tex�V���A���ԍ��Q.Text = tex�V���A���ԍ��Q.Text.TrimEnd();
			tex�V���A���ԍ��R.Text = tex�V���A���ԍ��R.Text.TrimEnd();
			tex�V���A���ԍ��S.Text = tex�V���A���ԍ��S.Text.TrimEnd();
			tex�ݒu�ꏊ�g�p��.Text = tex�ݒu�ꏊ�g�p��.Text.Trim();
			if(tex�ݒu�ꏊ�g�p��.Text.Length == 0) tex�ݒu�ꏊ�g�p��.Text = "0";
			if(!�͈̓`�F�b�N(tex�ݒu�ꏊ�g�p��, "�g�p��", 0, 99999)) return;
// ADD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� END

// ADD 2005.06.09 ���s�j�����J �ȈՃ��[�U�[�o�^ START
			tex�ȈՃ��[�U�[.Text = tex�ȈՃ��[�U�[.Text.Trim();
			if (!���p�`�F�b�N(tex�ȈՃ��[�U�[, "���[�U�[")) return;
			if(tex�ȈՃ��[�U�[.Text.Trim().Length != 0)
				if(!���[�U�[���݃`�F�b�N()) return;
// ADD 2005.06.09 ���s�j�����J �ȈՃ��[�U�[�o�^ END

// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή� START
			if(tex����R�[�h.Text.Trim().Substring(0,2) == "FK")
			{
				/** �Г��`�[����̏ꍇ�A�Z�N�V�����o�^���ɂ͈ȉ��̏�����S�Ė������Ă��邱�� */
				//(1) �Ǘ��Ҍ����ȊO�ł́A�Г��`�[����̃Z�N�V�����o�^�������Ȃ�
				if(gs�Ǘ��ҋ敪 != "1")
				{
					MessageBox.Show("�Ǘ��҈ȊO�̌����ł́A�Г��`�[����̃Z�N�V�����͓o�^�ł��܂���",
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
					MessageBox.Show("�Г��`�[����̏ꍇ�A�Z�N�V��������o�^����O�ɎГ��`�[����̈��X�o�^���s���ĉ�����",
						"���̓`�F�b�N",MessageBoxButtons.OK);
					tex����R�[�h.Focus();
					return;
				}
				//(3) �Z�N�V�����̗X�֔ԍ��͎Г��`�[��p�X�֔ԍ�(XXX-0044)�łȂ���΃G���[
				string s�ݒu��X�֔ԍ� = tex�X�֔ԍ��P.Text.Trim() + tex�X�֔ԍ��Q.Text.Trim();
				if(!s�ݒu��X�֔ԍ�.Equals(s�Г��`�[�p�X�֔ԍ�))
				{
					MessageBox.Show("�Г��`�[����̏ꍇ�A�ݒu��̗X�֔ԍ��́u" + s�Г��`�[�p�X�֔ԍ��\���p + "�v���g�p���ĉ�����",
						"���̓`�F�b�N",MessageBoxButtons.OK);
					tex�X�֔ԍ��P.Focus();
					return;
				}
			}
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή� END

			tex���b�Z�[�W.Text = btn����o�^.Text + "���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
// MOD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� START
//				string[] sKey  = new string[10];
				string[] sKey  = new string[19];
// MOD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� END
				sKey[0] = s����R�[�h;
				sKey[1] = tex����R�[�h.Text;
				sKey[2] = tex���喼.Text;
				sKey[3] = num�o�͏�.Text;
				sKey[4] = tex�X�֔ԍ��P.Text + tex�X�֔ԍ��Q.Text;
				sKey[5] = tex�ݒu��Z���P.Text;
				sKey[6] = tex�ݒu��Z���Q.Text;
				sKey[7] = s����X�V����;
				sKey[8] = gs���p�҃R�[�h;
				sKey[9] = num�T�[�}���䐔.Text;
// ADD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� START
				sKey[10] = tex�V���A���ԍ��P.Text;
				sKey[11] = cmb�V���A���ԍ��P.SelectedIndex.ToString();
				sKey[12] = tex�V���A���ԍ��Q.Text;
				sKey[13] = cmb�V���A���ԍ��Q.SelectedIndex.ToString();
				sKey[14] = tex�V���A���ԍ��R.Text;
				sKey[15] = cmb�V���A���ԍ��R.SelectedIndex.ToString();
				sKey[16] = tex�V���A���ԍ��S.Text;
				sKey[17] = cmb�V���A���ԍ��S.SelectedIndex.ToString();
				sKey[18] = tex�ݒu�ꏊ�g�p��.Text.Replace(",","").Trim();

				for(int iCnt = 0; iCnt < sKey.Length ; iCnt++)
					if(sKey[iCnt].Length ==0) sKey[iCnt] = " ";
// ADD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� END

				if (btn����o�^.Text.Equals("�o�^"))
				{
					string[] sList = sv_maintenance.Ins_Section(gsa���[�U, sKey);
					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� START
						s�ȈՃ��[�U�[ = "";
// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� END
// ADD 2005.06.09 ���s�j�����J �ȈՃ��[�U�[�o�^ START
						if(tex�ȈՃ��[�U�[.Text.Trim().Length != 0)
							�ȈՃ��[�U�[�o�^();
// ADD 2005.06.09 ���s�j�����J �ȈՃ��[�U�[�o�^ END
// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� START
						����\�����쐬();
// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� END
						//����̒ǉ�
						����o�^���[�h();
						�����񌟍�();
					}
					else
					{
						�r�[�v��();
					}
				}
				else
				{
					string[] sList = sv_maintenance.Upd_Section(gsa���[�U, sKey);
					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
// ADD 2005.06.09 ���s�j�����J �ȈՃ��[�U�[�o�^ START
						if(tex�ȈՃ��[�U�[.Text.Trim().Length != 0)
							�ȈՃ��[�U�[�o�^();
// ADD 2005.06.09 ���s�j�����J �ȈՃ��[�U�[�o�^ END
						//����̍X�V
						����o�^���[�h();
						�����񌟍�();
					}
					else
					{
						�r�[�v��();
					}
				}
				tex����R�[�h.Focus();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� START
		private bool ����\�����쐬()
		{
			bool bRet = true;

			try{
				string[] sData  = new string[44];
				//��t�m�n���
				sData[0] = " ";		//��t�m�n
				sData[1] = s�Ǘ��X���R�[�h;

				//�\���ҏ��
				sData[2] = " ";		//�\���҃J�i
				sData[3] = tex�����.Text;
									//�\���Җ��i���j
				sData[4] = " ";		//�\���җX��
				sData[5] = " ";		//�\���Ҍ��b�c
				sData[6] = " ";		//�\���ҏZ���P
				sData[7] = " ";		//�\���ҏZ���Q
				// ���p�Ґ\����ʂł͕K�{�����A���p�ғo�^��ʂɂ͊Y������
				// ���͍��ڂ��Ȃ��ׁA��
				sData[8] = " ";		//�\���ғd�b�P�i���j
				sData[9] = " ";		//�\���ғd�b�Q�i���j
				sData[10] = " ";	//�\���ғd�b�R�i���j
				sData[11] = " ";	//�\���ғd�b�i���j
				sData[12] = " ";	//�\���҂e�`�w�P�i���g�p�j
				sData[13] = " ";	//�\���҂e�`�w�Q�i���g�p�j
				sData[14] = " ";	//�\���҂e�`�w�R�i���g�p�j

				sData[15] = " ";	//�ݒu�ꏊ���

				sData[16] = " ";	//�ݒu�ꏊ�J�i
				sData[17] = tex���喼.Text;
									//�ݒu�ꏊ���i���j
				sData[18] = tex�X�֔ԍ��P.Text + tex�X�֔ԍ��Q.Text;
									//�ݒu�ꏊ�X�֔ԍ��i���j

				//�Z���P�̕����������S�p�P�U�����ȏ�̏ꍇ
				���ҏW(tex�ݒu��Z���P.Text);
				sData[19] = s�ݒu�ꏊ���R�[�h;	//�ݒu�ꏊ���R�[�h
				if(s�ݒu�ꏊ�Z���P.Length > 16){
					//���Ӂ@�Z�����J�b�g�����
					sData[20] = s�ݒu�ꏊ�Z���P.Substring(0,16);
				}else{
					sData[20] = s�ݒu�ꏊ�Z���P;
				}
				sData[21] = tex�ݒu��Z���Q.Text;
				// ���p�Ґ\����ʂł͕K�{�����A���p�ғo�^��ʂɂ͊Y������
				// ���͍��ڂ��Ȃ��ׁA��
				sData[22] = " ";	//�ݒu�ꏊ�d�b�P�i���j
				sData[23] = " ";	//�ݒu�ꏊ�d�b�Q�i���j
				sData[24] = " ";	//�ݒu�ꏊ�d�b�R�i���j
				sData[25] = " ";	//�ݒu�ꏊ�e�`�w�P�i���g�p�j
				sData[26] = " ";	//�ݒu�ꏊ�e�`�w�Q�i���g�p�j
				sData[27] = " ";	//�ݒu�ꏊ�e�`�w�R�i���g�p�j
				// ���p�Ґ\����ʂł͕K�{�����A���p�ғo�^��ʂɂ͊Y������
				// ���͍��ڂ��Ȃ��ׁA��
				sData[28] = " ";	//�ݒu�ꏊ�S���Җ��i���j
				sData[29] = " ";	//�ݒu�ꏊ��E���i���g�p�j
				sData[30] = "0";	//�ݒu�ꏊ�g�p��

				//�V�X�e�����
				sData[31] = s����R�[�h;	//���q�l�R�[�h
				sData[32] = dtp�g�p�J�n��.Value.Year.ToString() 
								+ dtp�g�p�J�n��.Value.Month.ToString().PadLeft(2, '0') 
								+ dtp�g�p�J�n��.Value.Day.ToString().PadLeft(2, '0');
				sData[33] = tex����R�[�h.Text;
				sData[34] = tex���喼.Text;
				sData[35] = num�T�[�}���䐔.Value.ToString();

				if(s�ȈՃ��[�U�[.Length > 0){
					sData[36] = s�ȈՃ��[�U�[;			//���[�U�[�R�[�h
					sData[37] = tex���喼.Text;			//���[�U�[��
					sData[38] = s�p�X���[�h;
				}else{
					sData[36] = " ";	//���[�U�[�R�[�h
					sData[37] = " ";	//���[�U�[��
					sData[38] = " ";	//�p�X���[�h
				}

				//���F��ԏ��i_:�o�^���A1:�\�����A2:���ے��A3:���F�ρj
				sData[39] = "3";

				sData[40] = " ";		//����
				//�X�V���
				sData[41] = " ";		//�\���X�V����;
				sData[42] = gs���p�҃R�[�h;
				sData[43] = "����o�^";	//�X�V�o�f

				for(int iCnt = 0; iCnt < sData.Length ; iCnt++)
					if(sData[iCnt].Length ==0) sData[iCnt] = " ";

				string[] sList = new string[1]{""};

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					if (s����R�[�h.Substring(0,1) != "J")
					{
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

						sList = sv_maintenance.Ins_Mosikomi(gsa���[�U, sData);

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					}
					else
					{
						sList = sv_oji.Ins_Mosikomi(gsa���[�U, sData);
					}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

				tex���b�Z�[�W.Text = sList[0];
				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					//s�\���X�V���� = sList[1].Trim();
					//tex��t�m�n.Text = sList[2].Trim();
//�ۗ�
//					�o�^���[�h();
//					tex�\���Җ�.Text = " ";
//					tex�\���Җ�.Focus();
				}
				else
				{
					bRet = false;
					if(sList.Length >= 2 && sList[2] != null)
//�ۗ�
//					tex��t�m�n.Text = sList[2].Trim();
					�r�[�v��();
				}
			}
			catch (Exception ex)
			{
				bRet = false;
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
//				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			
			return bRet;
		}

		private void ���ҏW(string s�Z��)
		{
			//�s���{���n�b�V���e�[�u���̍쐬
			�s���{���n�b�V���ݒ�();

			s�ݒu�ꏊ���R�[�h = "";
			s�ݒu�ꏊ�Z���P   = s�Z��;

			if(s�Z��.Length >= 3)
			{
				//�s���{���b�c�̎擾
				string s�ҏW��     = "";
				int    iIndex      = 0;
				// �u�_�ސ쌧�v�A�u�a�̎R���v�A�u���������v�͂S�����ŕ�������r����
				if((s�Z��[0] == '�_' || s�Z��[0] == '�a' || s�Z��[0] == '��')
					&& s�Z��.Length >= 4 
					&& s�Z��[3] == '��')
				{
					s�ҏW�� = s�Z��.Substring(0,4);
					iIndex  = 4;
				}
				else
				{
					s�ҏW�� = s�Z��.Substring(0,3);
					iIndex  = 3;
				}
				Object obj = h��[s�ҏW��];
				if(obj != null)
				{
					s�ݒu�ꏊ���R�[�h = ((int)obj).ToString("00");
					s�Z�� = s�Z��.Remove(0,iIndex);
					s�ݒu�ꏊ�Z���P = s�Z��;
				}
			}
		}
// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� END

// ADD 2005.06.09 ���s�j�����J ���[�U�[���݃`�F�b�N START
		private bool ���[�U�[���݃`�F�b�N()
		{
			bool Bret = false;
			try
			{
				string[] sKey  = new string[2];
				sKey[0] = s����R�[�h;
				sKey[1] = tex�ȈՃ��[�U�[.Text.Trim();
				string[] sList = sv_maintenance.Sel_User(gsa���[�U, sKey);

				if (sList[0].Equals("����I��"))
				{
					tex�ȈՃ��[�U�[.Focus();
					tex���b�Z�[�W.Text = "���͂��ꂽ���[�U�[�͊��ɓo�^����Ă��܂�";
					�r�[�v��();
				}
				else
				{
					if (sList[0].Equals("�Y���f�[�^������܂���"))
					{
						Bret = true;
						tex���b�Z�[�W.Text = "";
					}
					else
					{
						tex�ȈՃ��[�U�[.Focus();
						tex���b�Z�[�W.Text = sList[0];
						�r�[�v��();
					}
				}
			}
			catch (Exception ex)
			{
				tex�ȈՃ��[�U�[.Focus();
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
			return Bret;
		}
// ADD 2005.06.09 ���s�j�����J ���[�U�[���݃`�F�b�N END

// ADD 2005.06.09 ���s�j�����J �ȈՃ��[�U�[�o�^ START
		private void �ȈՃ��[�U�[�o�^()
		{
			//�p�X���[�h�����擾
			�������s();

			try
			{
// MOD 2005.07.21 ���s�j���� �X�����[�U�Ή� START
//				string[] sKey  = new string[9];
				string[] sKey  = new string[10];
// MOD 2005.07.21 ���s�j���� �X�����[�U�Ή� END
				sKey[0] = s����R�[�h;
				sKey[1] = tex�ȈՃ��[�U�[.Text.Trim();
				sKey[2] = s�p�X���[�h;
				sKey[3] = tex���喼.Text.Trim();
				sKey[4] = tex����R�[�h.Text.Trim();
				sKey[5] = " ";
				sKey[6] = "0";
				sKey[7] = "00000000000000";
				sKey[8] = gs���p�҃R�[�h;
// ADD 2005.07.21 ���s�j���� �X�����[�U�Ή� START
				sKey[9] = " ";
// ADD 2005.07.21 ���s�j���� �X�����[�U�Ή� END

				string[] sList = sv_maintenance.Ins_User(gsa���[�U, sKey);
				if (sList[0].Equals("����I��"))
				{
// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� START
					s�ȈՃ��[�U�[ = tex�ȈՃ��[�U�[.Text;
// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� END
					//���p�҂̒ǉ�
					tex�ȈՃ��[�U�[.Text = "";
					���p�ҏ�񌟍�();
				}
				else
				{
					tex�ȈՃ��[�U�[.Focus();
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
				}
			}
			catch (Exception ex)
			{
				tex�ȈՃ��[�U�[.Focus();
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
		}
// ADD 2005.06.09 ���s�j�����J �ȈՃ��[�U�[�o�^ END

		private void btn����폜_Click(object sender, System.EventArgs e)
		{
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();

// MOD 2009.04.28 ���s�j���� �폜�m�F���b�Z�[�W�̒ǉ� START
			// �ŏI�m�F
			if (MessageBox.Show("�폜���Ă���낵���ł����H", "�m�F"
					, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No){
				return;
			}
// MOD 2009.04.28 ���s�j���� �폜�m�F���b�Z�[�W�̒ǉ� END

			tex���b�Z�[�W.Text = "�폜���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[4];
				sKey[0] = s����R�[�h;
				sKey[1] = tex����R�[�h.Text;
				sKey[2] = s����X�V����;
				sKey[3] = gs���p�҃R�[�h;

				string[] sList = sv_maintenance.Del_Section(gsa���[�U, sKey);
				tex���b�Z�[�W.Text = sList[0];
				if (sList[0].Equals("����I��"))
				{
					//����̍폜
					����o�^���[�h();
					�����񌟍�();
				}
				else
				{
					�r�[�v��();
				}
				tex����R�[�h.Focus();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn������_Click(object sender, System.EventArgs e)
		{
			����o�^���[�h();
			tex����R�[�h.Focus();
		}

		private void ���匟��()
		{
			if (axGT����.get_CelText(axGT����.CaretRow,1).Equals("")) return;

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			
			try
			{
				string[] sKey  = new string[2];
				sKey[0] = s����R�[�h;
				sKey[1] = axGT����.get_CelText(axGT����.CaretRow,1).Trim();
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//				string[] sList = sv_maintenance.Sel_Section(gsa���[�U, sKey);
				String[] sList;
				if (s����R�[�h.Substring(0,1) != "J")
				{
					sList = sv_maintenance.Sel_Section(gsa���[�U, sKey);
				}
				else
				{
					sList = sv_oji.Sel_Section(gsa���[�U, sKey);
				}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END


				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex����R�[�h.Text = sList[1].Trim();
					tex���喼.Text = sList[2].Trim();
					num�o�͏�.Text = sList[3].Trim();
					tex�X�֔ԍ��P.Text = sList[4].PadRight(7).Substring(0, 3).Trim();
					tex�X�֔ԍ��Q.Text = sList[4].PadRight(7).Substring(3, 4).Trim();
					tex�Ǘ��X����.Text = sList[5].Trim();
					tex�ݒu��Z���P.Text = sList[6].Trim();
					tex�ݒu��Z���Q.Text = sList[7].Trim();
					s����X�V���� = sList[8].Trim();
					num�T�[�}���䐔.Text = sList[9].Trim();
// ADD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� START
					if(sList.Length > 10){
						tex�V���A���ԍ��P.Text = sList[10].Trim();
						cmb�V���A���ԍ��P.SelectedIndex = int.Parse(sList[11].Trim());
						tex�V���A���ԍ��Q.Text = sList[12].Trim();
						cmb�V���A���ԍ��Q.SelectedIndex = int.Parse(sList[13].Trim());
						tex�V���A���ԍ��R.Text = sList[14].Trim();
						cmb�V���A���ԍ��R.SelectedIndex = int.Parse(sList[15].Trim());
						tex�V���A���ԍ��S.Text = sList[16].Trim();
						cmb�V���A���ԍ��S.SelectedIndex = int.Parse(sList[17].Trim());
						int i�ݒu�ꏊ�g�p�� = int.Parse(sList[18].Trim());
						if(i�ݒu�ꏊ�g�p�� > 0)
							tex�ݒu�ꏊ�g�p��.Text = i�ݒu�ꏊ�g�p��.ToString("#,##0");
						else
							tex�ݒu�ꏊ�g�p��.Text = "";
					}
// ADD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� END
					����X�V���[�h();
// ADD 2005.06.13 ���s�j�����J ���������ǉ� START
					s����R�[�h = sList[1].Trim();
					���p�ҏ�񌟍�();
// ADD 2005.06.13 ���s�j�����J ���������ǉ� END
					tex���喼.Focus();
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					axGT����.Focus();
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void �����񌟍�()
		{
			axGT����.Clear();
			axGT����.Rows = 4;
			axGT����.CaretRow = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT����.CaretCol = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
			axGT����_CurPlaceChanged(null,null);
			
			try
			{
				string[] sKey  = new string[3];
				sKey[0] = s����R�[�h;
				sKey[1] = "";
				sKey[2] = "";
				string[] sList = sv_maintenance.Get_Section(gsa���[�U, sKey);

				if (sList[0].Equals("����I��") || sList[0].Equals("�Y���f�[�^������܂���"))
				{
					tex���b�Z�[�W.Text = "";
					if (axGT����.Rows < sList.Length - 1)
					{
						axGT����.Rows = (short)(sList.Length - 1);
					}
					for(short sCnt = 1; sCnt < sList.Length; sCnt++)
					{
						axGT����.set_RowsText(sCnt, sList[sCnt]);
					}
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					throw new Exception(sList[0]);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private void axGT���p��_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			���p�Ҍ���();
		}

		private void axGT���p��_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				���p�Ҍ���();
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT���p��, true, true, true, true);
			}
		}

		private void btn���p�ғo�^_Click(object sender, System.EventArgs e)
		{
			tex���p�҃R�[�h.Text = tex���p�҃R�[�h.Text.Trim();
			if (!�K�{�`�F�b�N(tex���p�҃R�[�h, "���[�U�[")) return;
			if (!���p�`�F�b�N(tex���p�҃R�[�h, "���[�U�[")) return;

			tex���p�Җ�.Text = tex���p�Җ�.Text.Trim();
			if (!�K�{�`�F�b�N(tex���p�Җ�, "���[�U�[��")) return;
			if (!�S�p�`�F�b�N(tex���p�Җ�, "���[�U�[��")) return;

			tex�p�X���[�h.Text = tex�p�X���[�h.Text.Trim();
// DEL 2005.06.08 ���s�j�����J �ē��͍폜 START
//			tex�p�X���[�h�ē���.Text = tex�p�X���[�h�ē���.Text.Trim();
// DEL 2005.06.08 ���s�j�����J �ē��͍폜 END
			if (!�K�{�`�F�b�N(tex�p�X���[�h, "�p�X���[�h")) return;
			if (!���p�`�F�b�N(tex�p�X���[�h, "�p�X���[�h")) return;

// ADD 2008.05.29 ���s�j���� �p�X���[�h�X�V�N������\�� START
			tex�p�X���[�h�X�V��.Text = tex�p�X���[�h�X�V��.Text.Trim();
			//�p�X���[�h�������͂�������[����o�^]�ł���ꍇ
			//�i����[�o�^�o�f]���g�p���Ă���ׁA[����o�^]�ɂȂ邱�Ƃ�����j
			if(tex�p�X���[�h�X�V��.Text.Length == 0
					|| tex�p�X���[�h�X�V��.Text.Equals("����o�^")){
				//�V�X�e�����t
				tex�p�X���[�h�X�V��.Text = DateTime.Now.ToString("yyyyMMdd");
			}
			if (!���p�`�F�b�N(tex�p�X���[�h�X�V��, "�p�X���[�h�X�V��")) return;
			if(tex�p�X���[�h�X�V��.Text.Length != 8){
				MessageBox.Show("�p�X���[�h�X�V����8���œ��͂��Ă�������",
					"���̓`�F�b�N",MessageBoxButtons.OK);
				tex�p�X���[�h�X�V��.Focus();
				return;
			}
//			if (!���t�`�F�b�N(tex�p�X���[�h�X�V��, "�p�X���[�h�X�V��")) return;
			if (!���l�`�F�b�N(tex�p�X���[�h�X�V��, "�p�X���[�h�X�V��")) return;
// ADD 2008.05.29 ���s�j���� �p�X���[�h�X�V�N������\�� END

// DEL 2005.06.08 ���s�j�����J �ē��͍폜 START
//			if (!tex�p�X���[�h.Text.Equals(tex�p�X���[�h�ē���.Text))
//			{
//				MessageBox.Show("�p�X���[�h���Ⴂ�܂�","���̓`�F�b�N",MessageBoxButtons.OK);
//				return;
//			}
// DEL 2005.06.08 ���s�j�����J �ē��͍폜 END
// DEL 2007.02.06 ���s�j���� �p�X���[�h�g�p�\�����`�F�b�N�̔p�~�iby �K�c�a�j START
//// ADD 2007.01.30 ���s�j���� �p�X���[�h�g�p�\�����̐��� START
//			if ( tex�p�X���[�h.Text.IndexOf('0') >= 0
//				|| tex�p�X���[�h.Text.IndexOf('1') >= 0
//				|| tex�p�X���[�h.Text.IndexOf('l') >= 0
//				|| tex�p�X���[�h.Text.IndexOf('o') >= 0 )
//			{
//				MessageBox.Show("�p�X���[�h�ɁA[o(��),0(���),l(��),1(��)]�̕����͎g�p�ł��܂���"
//									, "���̓`�F�b�N", MessageBoxButtons.OK);
//				return;
//			}
//// ADD 2007.01.30 ���s�j���� �p�X���[�h�g�p�\�����̐��� END
// DEL 2007.02.06 ���s�j���� �p�X���[�h�g�p�\�����`�F�b�N�̔p�~�iby �K�c�a�j END

			//����`�F�b�N
			if (!���p�ҕ��匟��())
			{
				MessageBox.Show("�Z�N�V����(" + tex����R�[�h.Text + ")�����݂��܂���" ,"���̓`�F�b�N",MessageBoxButtons.OK);
				tex����R�[�h.Focus();
				return;
			}
			//�ב��l�`�F�b�N
			if (tex�ב��l�R�[�h.Text.Trim().Length != 0)
			{
				if (!�ב��l����())
				{
					MessageBox.Show("�ב��l(" + tex�ב��l�R�[�h.Text + ")�����݂��܂���" ,"���̓`�F�b�N",MessageBoxButtons.OK);
					tex�ב��l�R�[�h.Focus();
					return;
				}
			}
			else
			{
				tex�ב��l�R�[�h.Text = " ";
			}

			tex���b�Z�[�W.Text = btn���p�ғo�^.Text + "���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
// MOD 2008.05.29 ���s�j���� �p�X���[�h�X�V�N������\�� START
//// MOD 2005.07.21 ���s�j���� �X�����[�U�Ή� START
////				string[] sKey  = new string[9];
//				string[] sKey  = new string[10];
				string[] sKey  = new string[11];
//// MOD 2005.07.21 ���s�j���� �X�����[�U�Ή� END
// MOD 2008.05.29 ���s�j���� �p�X���[�h�X�V�N������\�� END
				sKey[0] = s����R�[�h;
				sKey[1] = tex���p�҃R�[�h.Text;
				sKey[2] = tex�p�X���[�h.Text;
				sKey[3] = tex���p�Җ�.Text;
// MOD 2005.06.09 ���s�j�����J tex���p�ҕ���R�[�h�폜 START
//				sKey[4] = tex���p�ҕ���R�[�h.Text;
				sKey[4] = tex����R�[�h.Text;
// MOD 2005.06.09 ���s�j�����J tex���p�ҕ���R�[�h�폜 END
				sKey[5] = tex�ב��l�R�[�h.Text;
				sKey[6] = s�F�؃G���[��.ToString();
				sKey[7] = s���p�ҍX�V����;
				sKey[8] = gs���p�҃R�[�h;
// ADD 2005.07.21 ���s�j���� �X�����[�U�Ή� START
				sKey[9] = " ";
				if(chb���x������֎~.Checked)
					sKey[9] = "T";
// ADD 2005.07.21 ���s�j���� �X�����[�U�Ή� END
// ADD 2008.05.29 ���s�j���� �p�X���[�h�X�V�N������\�� START
				sKey[10] = tex�p�X���[�h�X�V��.Text;
// ADD 2008.05.29 ���s�j���� �p�X���[�h�X�V�N������\�� END

				if (btn���p�ғo�^.Text.Equals("�o�^"))
				{
					string[] sList = sv_maintenance.Ins_User(gsa���[�U, sKey);
					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
						//���p�҂̒ǉ�
						���p�ғo�^���[�h();
						���p�ҏ�񌟍�();
					}
					else
					{
						�r�[�v��();
					}
				}
				else
				{
					string[] sList = sv_maintenance.Upd_User(gsa���[�U, sKey);
					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
						//���p�҂̍X�V
						���p�ғo�^���[�h();
						���p�ҏ�񌟍�();
					}
					else
					{
						�r�[�v��();
					}
				}
				tex���p�҃R�[�h.Focus();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn���p�ҍ폜_Click(object sender, System.EventArgs e)
		{
			tex���p�҃R�[�h.Text = tex���p�҃R�[�h.Text.Trim();
			
// MOD 2009.04.28 ���s�j���� �폜�m�F���b�Z�[�W�̒ǉ� START
			// �ŏI�m�F
			if (MessageBox.Show("�폜���Ă���낵���ł����H", "�m�F"
					, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No){
				return;
			}
// MOD 2009.04.28 ���s�j���� �폜�m�F���b�Z�[�W�̒ǉ� END

			tex���b�Z�[�W.Text = "�폜���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[4];
				sKey[0] = s����R�[�h;
				sKey[1] = tex���p�҃R�[�h.Text;
				sKey[2] = s���p�ҍX�V����;
				sKey[3] = gs���p�҃R�[�h;

				string[] sList = sv_maintenance.Del_User(gsa���[�U, sKey);
				tex���b�Z�[�W.Text = sList[0];
				if (sList[0].Equals("����I��"))
				{
					//���p�҂̍폜
					���p�ғo�^���[�h();
					���p�ҏ�񌟍�();
				}
				else
				{
					�r�[�v��();
				}
				tex���p�҃R�[�h.Focus();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn���p�Ҏ��_Click(object sender, System.EventArgs e)
		{
			���p�ғo�^���[�h();
			tex���p�҃R�[�h.Focus();
		}

		private void ���p�Ҍ���()
		{
			if (axGT���p��.get_CelText(axGT���p��.CaretRow,1).Equals("")) return;

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[2];
				sKey[0] = s����R�[�h;
				sKey[1] = axGT���p��.get_CelText(axGT���p��.CaretRow,1).Trim();
				string[] sList = sv_maintenance.Sel_User(gsa���[�U, sKey);

				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex���p�҃R�[�h.Text = sList[1].Trim();
					tex�p�X���[�h.Text = sList[2].Trim();
// DEL 2005.06.08 ���s�j�����J �ē��͍폜 START
//					tex�p�X���[�h�ē���.Text = sList[2].Trim();
// DEL 2005.06.08 ���s�j�����J �ē��͍폜 END
					tex���p�Җ�.Text = sList[3].Trim();
//					tex���p�ҕ���R�[�h.Text = sList[4].Trim();
//					tex���p�ҕ��喼.Text = sList[5].Trim();
					tex�ב��l�R�[�h.Text = sList[6].Trim();
					s�F�؃G���[�� = int.Parse(sList[7]);
					s���p�ҍX�V���� = sList[8].Trim();
// ADD 2005.07.21 ���s�j���� �X�����[�U�Ή� START
					if(sList[9] == "T")
						chb���x������֎~.Checked = true;
					else
						chb���x������֎~.Checked = false;
// ADD 2005.07.21 ���s�j���� �X�����[�U�Ή� END
// ADD 2008.05.29 ���s�j���� �p�X���[�h�X�V�N������\�� START
					if(sList.Length > 10){
						tex�p�X���[�h�X�V��.Text = sList[10].Trim();
					}
// ADD 2008.05.29 ���s�j���� �p�X���[�h�X�V�N������\�� END
					���p�ҍX�V���[�h();
					tex���p�Җ�.Focus();
					
					if (s�F�؃G���[�� != 0)
					{
						btn�p�X���[�h���b�N.Enabled = true;
					}
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					axGT���p��.Focus();
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void ���p�ҏ�񌟍�()
		{
			axGT���p��.Clear();
			axGT���p��.Rows = 4;
			axGT���p��.CaretRow = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT���p��.CaretCol = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
			axGT���p��_CurPlaceChanged(null,null);
			
			try
			{
// MOD 2005.06.13 ���s�j�����J ���������ǉ� START
//				string[] sKey  = new string[3];
//				sKey[0] = s����R�[�h;
//				sKey[1] = "";
//				sKey[2] = "";
				string[] sKey  = new string[4];
				sKey[0] = s����R�[�h;
				sKey[1] = "";
				sKey[2] = "";
				sKey[3] = s����R�[�h;
// MOD 2005.06.13 ���s�j�����J ���������ǉ� END
				string[] sList = sv_maintenance.Get_User(gsa���[�U, sKey);

				if (sList[0].Equals("����I��") || sList[0].Equals("�Y���f�[�^������܂���"))
				{
					tex���b�Z�[�W.Text = "";
					if (axGT���p��.Rows < sList.Length - 1)
					{
						axGT���p��.Rows = (short)(sList.Length - 1);
					}
					for(short sCnt = 1; sCnt < sList.Length; sCnt++)
					{
						axGT���p��.set_RowsText(sCnt, sList[sCnt]);
					}
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					throw new Exception(sList[0]);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void chb�g�p�I����_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chb�g�p�I����.Checked)
			{
				lab�I����.Visible = false;
//				dtp�g�p�I����.Enabled = true;
			}
			else
			{
				lab�I����.Visible = true;
//				dtp�g�p�I����.Enabled = false;
			}
		}

		private void tex�X�֔ԍ��Q_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				if(tex�X�֔ԍ��P.Text.Length == 3 && tex�X�֔ԍ��Q.Text.Length == 4)
					�X�֔ԍ�����();
				else{
					�X�֔ԍ��ꗗ();
				}
			}
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
				//				tex�Ǘ��X����.Text = ���.s�Ǘ��X��.Trim();
				//				tex�ݒu��Z���P.Text = ���.s�Z��.Trim();
				tex�X�֔ԍ��P.Text = g�Z������.s�X�֔ԍ��P.Trim();
				tex�X�֔ԍ��Q.Text = g�Z������.s�X�֔ԍ��Q.Trim();
				tex�Ǘ��X����.Text = g�Z������.s�Ǘ��X��.Trim();
				tex�ݒu��Z���P.Text = g�Z������.s�Z��.Trim();
				tex�ݒu��Z���Q.Text = "";
				tex�ݒu��Z���Q.Focus();
			}
			else
			{
				tex�X�֔ԍ��P.Focus();
			}
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
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

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�X�֔ԍ��P.Text + tex�X�֔ԍ��Q.Text;
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//				string[] sList = sv_maintenance.Sel_Postcode(gsa���[�U, sKey);
				String[] sList;
				if (s����R�[�h.Substring(0,1) != "J")
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
					if (s����R�[�h.Substring(0,1) == "J")
					{
//MOD 2016.03.16 BEVAS�j���{ ���q�^���ŃO���[�o���^�p�Ή� START
						//�I��������������q�O���[�o���׎�̏ꍇ�́A���L�������X�L�b�v����
						if(s����R�[�h.Substring(0,2) != "JG")
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
									tex�Ǘ��X����.Text = "";
									�r�[�v��();
									this.Cursor = System.Windows.Forms.Cursors.Default;
									return false;
								}
							}
							else
							{
								tex���b�Z�[�W.Text = sList1[0];
								tex�Ǘ��X����.Text = "";
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
					tex�Ǘ��X����.Text = sList[1].Trim();
					if(tex�ݒu��Z���P.Text.Trim().Length == 0 && tex�ݒu��Z���Q.Text.Trim().Length == 0)
					{
						tex�ݒu��Z���P.Text = sList[2].Trim();
						tex�ݒu��Z���Q.Focus();
					}
					else
						tex�ݒu��Z���P.Focus();
// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� START
					if(sList.Length > 3)
						s�Ǘ��X���R�[�h = sList[3].Trim();
					else
						s�Ǘ��X���R�[�h = "";
// ADD 2007.01.27 ���s�j���� ����\���ւ̒ǉ� END
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					tex�Ǘ��X����.Text = "";
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

// DEL 2005.06.10 ���s�j�����J ���p�ҕ���폜 START
/*
		private void tex���p�ҕ���R�[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				if(tex���p�ҕ���R�[�h.Text.Trim().Length == 0)
					���p�ҕ���ꗗ();
				else
					���p�ҕ��匟��();
			}
		}

		private void tex���p�ҕ���R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn���p�ҕ��匟��.Focus();
				���p�ҕ���ꗗ();
				e.Handled = true;
			}		
		}

		private void btn���p�ҕ��匟��_Click(object sender, System.EventArgs e)
		{
			���p�ҕ���ꗗ();
		}

		private void ���p�ҕ���ꗗ()
		{
			tex���p�ҕ���R�[�h.Text = tex���p�ҕ���R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex���p�ҕ���R�[�h, "�Z�N�V����")) return;

			// ������ʂ������ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			���匟�� ��� = new ���匟��();
//			���.Left = this.Left;
//			���.Top = this.Top;

			// �R�[�h�̏����\��
//			���.s����R�[�h = s����R�[�h;
//			���.s����R�[�h = tex���p�ҕ���R�[�h.Text;
//			���.s���喼 = "";
//			���.ShowDialog();
			if (g���匟�� == null)	 g���匟�� = new ���匟��();
			g���匟��.Left = this.Left;
			g���匟��.Top = this.Top;
			// �R�[�h�̏����\��
			g���匟��.s����R�[�h = s����R�[�h;
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� START
//			g���匟��.s����R�[�h = tex���p�ҕ���R�[�h.Text;
			g���匟��.s����R�[�h = "";
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� END
			g���匟��.s���喼 = "";
			g���匟��.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (���.s����R�[�h.Trim().Length != 0)
			if (g���匟��.s����R�[�h.Trim().Length != 0)
			{
//				tex���p�ҕ���R�[�h.Text = ���.s����R�[�h.Trim();
//				tex���p�ҕ��喼.Text = ���.s���喼.Trim();
				tex���p�ҕ���R�[�h.Text = g���匟��.s����R�[�h.Trim();
				tex���p�ҕ��喼.Text = g���匟��.s���喼.Trim();
				tex�ב��l�R�[�h.Focus();
			}
			else
			{
				tex���p�ҕ���R�[�h.Focus();
			}
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
		}
*/
// DEL 2005.06.10 ���s�j�����J ���p�ҕ���폜 END

		private bool ���p�ҕ��匟��()
		{
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex����R�[�h, "����R�[�h")) return false;

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[2];
				sKey[0] = s����R�[�h;
				sKey[1] = tex����R�[�h.Text.Trim();
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//				string[] sList = sv_maintenance.Sel_Section(gsa���[�U, sKey);
				String[] sList;
				if (s����R�[�h.Substring(0,1) != "J")
				{
					sList = sv_maintenance.Sel_Section(gsa���[�U, sKey);

				}
				else
				{
					sList = sv_oji.Sel_Section(gsa���[�U, sKey);
				}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
//					tex���喼.Text = sList[2].Trim();
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
//					tex���喼.Text = "";
					�r�[�v��();
					ret =  false;
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�������[�h();
				ret =  false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}
		
		private void tex�ב��l�R�[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				if(tex�ב��l�R�[�h.Text.Trim().Length != 0)
					�ב��l����();
			}
		}

		private void tex�ב��l�R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�ב��l����.Focus();
				�ב��l�ꗗ();
				e.Handled = true;
			}		
		}

		private void btn�ב��l����_Click(object sender, System.EventArgs e)
		{
			�ב��l�ꗗ();
		}
		
		private void �ב��l�ꗗ()
		{
// MOD 2005.06.09 ���s�j�����J tex���p�ҕ���R�[�h�폜 START
//			tex���p�ҕ���R�[�h.Text = tex���p�ҕ���R�[�h.Text.Trim();
//			if(!�K�{�`�F�b�N(tex���p�ҕ���R�[�h, "�Z�N�V����")) return;
//			if(!���p�`�F�b�N(tex���p�ҕ���R�[�h, "�Z�N�V����")) return;
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
			if(!�K�{�`�F�b�N(tex����R�[�h, "�Z�N�V����")) return;
			if(!���p�`�F�b�N(tex����R�[�h, "�Z�N�V����")) return;
// MOD 2005.06.09 ���s�j�����J tex���p�ҕ���R�[�h�폜 END
			tex�ב��l�R�[�h.Text = tex�ב��l�R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�ב��l�R�[�h, "�ב��l�R�[�h")) return;

			// ������ʂ������ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			�ב��l���� ��� = new �ב��l����();
//			���.Left = this.Left;
//			���.Top = this.Top;

			// �R�[�h�̏����\��
//			���.s����R�[�h = s����R�[�h;
//			���.s����R�[�h = tex���p�ҕ���R�[�h.Text.Trim();
//			���.s�ב��l�R�[�h = tex�ב��l�R�[�h.Text.Trim();
//			���.s�J�i���� = "";
//			���.ShowDialog();
			if (g�ב����� == null)	 g�ב����� = new �ב��l����();
			g�ב�����.Left = this.Left;
			g�ב�����.Top = this.Top;
			// �R�[�h�̏����\��
			g�ב�����.s����R�[�h = s����R�[�h;
// MOD 2005.06.09 ���s�j�����J tex���p�ҕ���R�[�h�폜 START
//			g�ב�����.s����R�[�h = tex���p�ҕ���R�[�h.Text.Trim();
			g�ב�����.s����R�[�h = tex����R�[�h.Text.Trim();
// MOD 2005.06.09 ���s�j�����J tex���p�ҕ���R�[�h�폜 END

// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� START
//			g�ב�����.s�ב��l�R�[�h = tex�ב��l�R�[�h.Text.Trim();
			g�ב�����.s�ב��l�R�[�h = "";
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� END
			g�ב�����.s�J�i���� = "";
			g�ב�����.ShowDialog();
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (���.s�ב��l�R�[�h.Trim().Length != 0)
			if (g�ב�����.s�ב��l�R�[�h.Trim().Length != 0)
			{
//				tex�ב��l�R�[�h.Text = ���.s�ב��l�R�[�h.Trim();
				tex�ב��l�R�[�h.Text = g�ב�����.s�ב��l�R�[�h.Trim();
				btn���p�ғo�^.Focus();
			}
			else
			{
				tex�ב��l�R�[�h.Focus();
			}
		}
		
		private bool �ב��l����()
		{
// MOD 2005.06.09 ���s�j�����J tex���p�ҕ���R�[�h�폜 START
//			tex���p�ҕ���R�[�h.Text = tex���p�ҕ���R�[�h.Text.Trim();
//			if(!�K�{�`�F�b�N(tex���p�ҕ���R�[�h, "�Z�N�V����")) return false;
//			if(!���p�`�F�b�N(tex���p�ҕ���R�[�h, "�Z�N�V����")) return false;
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
			if(!�K�{�`�F�b�N(tex����R�[�h, "�Z�N�V����")) return false;
			if(!���p�`�F�b�N(tex����R�[�h, "�Z�N�V����")) return false;
// MOD 2005.06.09 ���s�j�����J tex���p�ҕ���R�[�h�폜 END
			tex�ב��l�R�[�h.Text = tex�ב��l�R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�ב��l�R�[�h, "�ב��l�R�[�h")) return false;

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[3];
				sKey[0] = s����R�[�h;
// MOD 2005.06.09 ���s�j�����J tex���p�ҕ���R�[�h�폜 START
//				sKey[1] = tex���p�ҕ���R�[�h.Text;
				sKey[1] = tex����R�[�h.Text;
// MOD 2005.06.09 ���s�j�����J tex���p�ҕ���R�[�h�폜 END
				sKey[2] = tex�ב��l�R�[�h.Text;
				string[] sList = sv_maintenance.Sel_Consignor(gsa���[�U, sKey);
				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					ret = false;
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

		private void num�o�͏�_Enter(object sender, System.EventArgs e)
		{
			num�o�͏�.Select(0, num�o�͏�.Text.Length);
		}

		private void btn�������s_Click(object sender, System.EventArgs e)
		{
			// �p�X���[�h�̃N���A
			tex�p�X���[�h.Text       = "";

			�������s();

			tex�p�X���[�h.Text       = s�p�X���[�h;
// DEL 2005.06.08 ���s�j�����J �ē��͍폜 START
//			tex�p�X���[�h�ē���.Text = s�p�X���[�h;
// DEL 2005.06.08 ���s�j�����J �ē��͍폜 END
		}

		private void �������s()
		{
// MOD 2005.06.08 ���s�j�����J �啶���Ȃ� START
//			const string s���� = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
// MOD 2007.01.30 ���s�j���� �p�X���[�h�g�p�\�����̐��� START
//			const string s���� = "0123456789abcdefghijklmnopqrstuvwxyz";
			// l��1�A0��o�͏��O����
			const string s���� = "23456789abcdefghijkmnpqrstuvwxyz";
// MOD 2007.01.30 ���s�j���� �p�X���[�h�g�p�\�����̐��� END
// MOD 2005.06.08 ���s�j�����J �啶���Ȃ� END

			s�p�X���[�h = "";

// DEL 2005.06.08 ���s�j�����J �ē��͍폜 START
//			tex�p�X���[�h�ē���.Text = "";
// DEL 2005.06.08 ���s�j�����J �ē��͍폜 END

			Random rdm = new Random();
			int i���� = rdm.Next(0,s����.Length - 1);
			for(int iCnt = 0; iCnt < 6; iCnt++)
			{
				i���� = rdm.Next(0,s����.Length);
				s�p�X���[�h += s����[i����];
			}
		}

		private void btn�p�X���[�h���b�N_Click(object sender, System.EventArgs e)
		{
			s�F�؃G���[�� = 0;
			btn�p�X���[�h���b�N.Enabled = false;
		}

		private void dtp�g�p�I����_DropDown(object sender, System.EventArgs e)
		{
			chb�g�p�I����.Checked = true;
			lab�I����.Visible = false;
		}

		private void axGT����_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT����.set_CelForeColor(nOldRowB,0,0);
			axGT����.set_CelBackColor(nOldRowB,0,0xFFFFFF);
//			axGT����.set_CelForeColor(axGT����.CaretRow,0,111111);
			axGT����.set_CelForeColor(axGT����.CaretRow,0,0x98FB98);  //BGR
			axGT����.set_CelBackColor(axGT����.CaretRow,0,0x006000);
			nOldRowB = axGT����.CaretRow;
		}

		private void axGT���p��_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT���p��.set_CelForeColor(nOldRowR,0,0);
			axGT���p��.set_CelBackColor(nOldRowR,0,0xFFFFFF);
//			axGT���p��.set_CelForeColor(axGT���p��.CaretRow,0,111111);
			axGT���p��.set_CelForeColor(axGT���p��.CaretRow,0,0x98FB98);  //BGR
			axGT���p��.set_CelBackColor(axGT���p��.CaretRow,0,0x006000);
			nOldRowR = axGT���p��.CaretRow;
		}

// ADD 2005.05.25 ���s�j�����J �t�H�[�J�X�ړ� START
		private void ����}�X�^_Closed(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W.Text = "";
			tex����R�[�h.Text = " ";
//�ۗ� MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
//			cb�^�p���̂��q�l�̂�.Checked = true;
//�ۗ� MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END
			dtp�g�p�J�n��.Value = System.DateTime.Now;
			dtp�g�p�I����.Value = System.DateTime.Now;
			axGT����.CaretRow   = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT����.CaretCol = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
			axGT����_CurPlaceChanged(null,null);
			axGT���p��.CaretRow = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT���p��.CaretCol = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
			axGT���p��_CurPlaceChanged(null,null);
			tex����R�[�h.Focus();
		}
// ADD 2005.05.25 ���s�j�����J �t�H�[�J�X�ړ� END

// ADD 2005.08.08 ���s�j�����J �V�K�ǉ� START
		private void btn�V�K_Click(object sender, System.EventArgs e)
		{
			tex����R�[�h.Text = " ";
			dtp�g�p�J�n��.Value = System.DateTime.Now;
			dtp�g�p�I����.Value = System.DateTime.Now;
			axGT����.Clear();
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT����.CaretRow = 1;
			axGT����.CaretCol = 1;
			axGT����_CurPlaceChanged(null,null);
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
			�������[�h();
			tex���b�Z�[�W.Text = "";
		}
// ADD 2005.08.08 ���s�j�����J �V�K�ǉ� END
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� START
		private void btn�Г��`������X�o�^_Click(object sender, System.EventArgs e)
		{
			if (g�Г��` == null)	 g�Г��` = new �Г��`������X�}�X�^();
			g�Г��`.Left = this.Left + (this.Width  - g�Г��`.Width)  / 2;
			g�Г��`.Top = this.Top;
			g�Г��`.ShowDialog();
		}
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� END
	}
}
