using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using CrystalDecisions.CrystalReports.Engine;

namespace is2AdminClient
{
	/// <summary>
	/// [�g�p�\�����݃����e�i���X]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// MOD 2008.05.02 ���s�j���� �\���җX�֔ԍ��G���[���b�Z�[�W�̕ύX 
	// [�\���җX�֔ԍ�]�̕K�{�`�F�b�N���̃G���[���b�Z�[�W�̕ύX
	//--------------------------------------------------------------------------
	// MOD 2008.05.07 ���s�j���� �G���[�`�F�b�N���̕ύX 
	// �~[���\���҃J�i]��[���q�l]
	// �~[�ݒu�ꏊ�J�i]��[���@�l��]
	// [�ݒu�ꏊ�J�i]��[���@�l���J�i]
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� 
	//--------------------------------------------------------------------------
	// MOD 2011.03.08 ���s�j���� ���q�^���Ή��i���q�c�Ə��Ή��j 
	// MOD 2011.06.21 ���s�j���� ���q�^���Ή� 
	//--------------------------------------------------------------------------
	// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή�
	//--------------------------------------------------------------------------
	public class ������� : ���ʃt�H�[��
	{
		private string s�X���R�[�h = "";
		private string s�\���X�V����   = "00000000000000";
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
		private string s�\�����X���R�[�h = "";
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lab����;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�\�������s;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lab�����;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private ���ʃe�L�X�g�{�b�N�X tex�F�؉����;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lab�ȈՃ��[�U�[;
		private System.Windows.Forms.Label lab��������^�C�g��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���Җ�;
		private System.Windows.Forms.Label lab�\����;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���҃J�i;
		private System.Windows.Forms.Label lab�\���ҏZ��;
		private System.Windows.Forms.Label label1;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���ҏZ���Q;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���ҏZ���P;
		private System.Windows.Forms.Label lab�\���Ǘ�NO;
		private System.Windows.Forms.Label lab�\���җX��;
		private System.Windows.Forms.Label lab�\���ғd�b;
		private System.Windows.Forms.Label lab�\���҂e�`�w;
		private System.Windows.Forms.ComboBox cb�\���Ҍ�;
		private System.Windows.Forms.Button btn�\����񌟍�;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lab�\���҃J�i;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label lab�ݒu�ꏊ�J�i;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label lab�ݒu�ꏊ;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label24;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex���喼;
		private System.Windows.Forms.Label lab���喼;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex����R�[�h;
		private System.Windows.Forms.Label lab����R�[�h;
		private System.Windows.Forms.DateTimePicker dtp�g�p�J�n��;
		private System.Windows.Forms.Label lab�g�p�J�n��;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label lab���p�Җ�;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label lab��;
		private System.Windows.Forms.NumericUpDown num�T�[�}���䐔;
		private System.Windows.Forms.Label lab�T�[�}��;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�Ǘ��X����;
		private System.Windows.Forms.Label lab�Ǘ��X��;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label49;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex��t�m�n;
		private System.Windows.Forms.Label lab�\����;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�J�i;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���҂e�`�w�Q;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���҂e�`�w�R;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���҂e�`�w�P;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���ғd�b�Q;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���ғd�b�R;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���ғd�b�P;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�g�p��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ��E��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�S���Җ�;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�e�`�w�Q;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�e�`�w�R;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�e�`�w�P;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�d�b�Q;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�d�b�R;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�d�b�P;
		private System.Windows.Forms.ComboBox cb�ݒu�ꏊ��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�Z���P;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�Z���Q;
		private System.Windows.Forms.Button btn�o�^;
		private System.Windows.Forms.Button btn�폜;
		private System.Windows.Forms.Button btn���;
		private System.Windows.Forms.RadioButton rb�o�^��;
		private System.Windows.Forms.RadioButton rb���F��;
		private System.Windows.Forms.RadioButton rb���ے�;
		private System.Windows.Forms.RadioButton rb�\����;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex���[�U�[��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�����p�X���[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex���q�l�R�[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex���[�U�[�R�[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex����;
		private System.Windows.Forms.Button btn�\���җX��;
		private System.Windows.Forms.Button btn���q�l�R�[�h;
		private System.Windows.Forms.Button btn�ݒu�ꏊ�X��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�F�ؗ��p�Җ�;
		private System.Windows.Forms.Label lab�F�ؗ��p�Җ�;
		private System.Windows.Forms.CheckBox chb�ݒu�ꏊ;
		private System.Windows.Forms.Panel pnl�\����;
		private System.Windows.Forms.Panel pnl�V�X�e�����;
		private System.Windows.Forms.Panel pnl�ݒu�ꏊ;
		private System.Windows.Forms.Panel pnl��t�m�n;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���җX�ւP;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���җX�ւQ;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�X�ւP;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ݒu�ꏊ�X�ւQ;
		private System.Windows.Forms.Label lab�����p�X���[�h;
		private System.Windows.Forms.Label lab��_�����p�X���[�h;
		private System.Windows.Forms.Label lab����_�����p�X���[�h;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label lab�F�؉����;
		private System.Windows.Forms.Button btn�x�X���o�^;
		private System.Windows.Forms.Button btn�_��;
		private System.ComponentModel.IContainer components;

		public �������()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(�������));
			this.tex�\���Җ� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.pnl�\���� = new System.Windows.Forms.Panel();
			this.label24 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.tex�\���҂e�`�w�Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�\���҂e�`�w�R = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�\���҂e�`�w�P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tex�\���ғd�b�Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�\���ғd�b�R = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�\���ғd�b�P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.cb�\���Ҍ� = new System.Windows.Forms.ComboBox();
			this.lab�\���҂e�`�w = new System.Windows.Forms.Label();
			this.lab�\���ғd�b = new System.Windows.Forms.Label();
			this.lab�\���җX�� = new System.Windows.Forms.Label();
			this.tex�\���҃J�i = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�\���҃J�i = new System.Windows.Forms.Label();
			this.lab�\���� = new System.Windows.Forms.Label();
			this.lab����� = new System.Windows.Forms.Label();
			this.lab�\���ҏZ�� = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tex�\���җX�ւP = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�\���җX�ւQ = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn�\���җX�� = new System.Windows.Forms.Button();
			this.tex�\���ҏZ���P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�\���ҏZ���Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label3 = new System.Windows.Forms.Label();
			this.pnl��t�m�n = new System.Windows.Forms.Panel();
			this.btn�\����񌟍� = new System.Windows.Forms.Button();
			this.btn�\�������s = new System.Windows.Forms.Button();
			this.lab�\���Ǘ�NO = new System.Windows.Forms.Label();
			this.tex��t�m�n = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�\���� = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lab�F�؉���� = new System.Windows.Forms.Label();
			this.tex�F�ؗ��p�Җ� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�F�ؗ��p�Җ� = new System.Windows.Forms.Label();
			this.tex�F�؉���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab���� = new System.Windows.Forms.Label();
			this.lab��������^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn�_�� = new System.Windows.Forms.Button();
			this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn���� = new System.Windows.Forms.Button();
			this.btn�o�^ = new System.Windows.Forms.Button();
			this.btn�폜 = new System.Windows.Forms.Button();
			this.btn��� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pnl�V�X�e����� = new System.Windows.Forms.Panel();
			this.rb���F�� = new System.Windows.Forms.RadioButton();
			this.lab�g�p�J�n�� = new System.Windows.Forms.Label();
			this.rb�o�^�� = new System.Windows.Forms.RadioButton();
			this.label48 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.lab�����p�X���[�h = new System.Windows.Forms.Label();
			this.lab��_�����p�X���[�h = new System.Windows.Forms.Label();
			this.lab�� = new System.Windows.Forms.Label();
			this.num�T�[�}���䐔 = new System.Windows.Forms.NumericUpDown();
			this.lab�T�[�}�� = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.lab����_�����p�X���[�h = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.rb���ے� = new System.Windows.Forms.RadioButton();
			this.rb�\���� = new System.Windows.Forms.RadioButton();
			this.label32 = new System.Windows.Forms.Label();
			this.tex���[�U�[�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab���p�Җ� = new System.Windows.Forms.Label();
			this.tex�����p�X���[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.dtp�g�p�J�n�� = new System.Windows.Forms.DateTimePicker();
			this.tex���喼 = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab���喼 = new System.Windows.Forms.Label();
			this.tex����R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab����R�[�h = new System.Windows.Forms.Label();
			this.tex���q�l�R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label7 = new System.Windows.Forms.Label();
			this.lab�ȈՃ��[�U�[ = new System.Windows.Forms.Label();
			this.tex���[�U�[�R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label8 = new System.Windows.Forms.Label();
			this.btn���q�l�R�[�h = new System.Windows.Forms.Button();
			this.label28 = new System.Windows.Forms.Label();
			this.tex���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label42 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.pnl�ݒu�ꏊ = new System.Windows.Forms.Panel();
			this.label21 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.tex�ݒu�ꏊ�g�p�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label34 = new System.Windows.Forms.Label();
			this.tex�Ǘ��X���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�Ǘ��X�� = new System.Windows.Forms.Label();
			this.tex�ݒu�ꏊ��E�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label30 = new System.Windows.Forms.Label();
			this.tex�ݒu�ꏊ�S���Җ� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label29 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.chb�ݒu�ꏊ = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tex�ݒu�ꏊ�e�`�w�Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�ݒu�ꏊ�e�`�w�R = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�ݒu�ꏊ�e�`�w�P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.tex�ݒu�ꏊ�d�b�Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�ݒu�ꏊ�d�b�R = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�ݒu�ꏊ�d�b�P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.cb�ݒu�ꏊ�� = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.tex�ݒu�ꏊ�J�i = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�ݒu�ꏊ�J�i = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.lab�ݒu�ꏊ = new System.Windows.Forms.Label();
			this.tex�ݒu�ꏊ�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.tex�ݒu�ꏊ�X�ւP = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�ݒu�ꏊ�X�ւQ = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn�ݒu�ꏊ�X�� = new System.Windows.Forms.Button();
			this.tex�ݒu�ꏊ�Z���P = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�ݒu�ꏊ�Z���Q = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label31 = new System.Windows.Forms.Label();
			this.btn�x�X���o�^ = new System.Windows.Forms.Button();
			this.pnl�\����.SuspendLayout();
			this.pnl��t�m�n.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.pnl�V�X�e�����.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num�T�[�}���䐔)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.pnl�ݒu�ꏊ.SuspendLayout();
			this.SuspendLayout();
			// 
			// tex�\���Җ�
			// 
			this.tex�\���Җ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���Җ�.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�\���Җ�.Location = new System.Drawing.Point(98, 4);
			this.tex�\���Җ�.MaxLength = 20;
			this.tex�\���Җ�.Name = "tex�\���Җ�";
			this.tex�\���Җ�.Size = new System.Drawing.Size(326, 23);
			this.tex�\���Җ�.TabIndex = 0;
			this.tex�\���Җ�.Text = "";
			// 
			// pnl�\����
			// 
			this.pnl�\����.BackColor = System.Drawing.Color.Honeydew;
			this.pnl�\����.Controls.Add(this.label24);
			this.pnl�\����.Controls.Add(this.label13);
			this.pnl�\����.Controls.Add(this.label14);
			this.pnl�\����.Controls.Add(this.label15);
			this.pnl�\����.Controls.Add(this.tex�\���҂e�`�w�Q);
			this.pnl�\����.Controls.Add(this.tex�\���҂e�`�w�R);
			this.pnl�\����.Controls.Add(this.tex�\���҂e�`�w�P);
			this.pnl�\����.Controls.Add(this.label4);
			this.pnl�\����.Controls.Add(this.label9);
			this.pnl�\����.Controls.Add(this.label12);
			this.pnl�\����.Controls.Add(this.tex�\���ғd�b�Q);
			this.pnl�\����.Controls.Add(this.tex�\���ғd�b�R);
			this.pnl�\����.Controls.Add(this.tex�\���ғd�b�P);
			this.pnl�\����.Controls.Add(this.cb�\���Ҍ�);
			this.pnl�\����.Controls.Add(this.lab�\���҂e�`�w);
			this.pnl�\����.Controls.Add(this.lab�\���ғd�b);
			this.pnl�\����.Controls.Add(this.lab�\���җX��);
			this.pnl�\����.Controls.Add(this.tex�\���҃J�i);
			this.pnl�\����.Controls.Add(this.lab�\���҃J�i);
			this.pnl�\����.Controls.Add(this.lab�\����);
			this.pnl�\����.Controls.Add(this.tex�\���Җ�);
			this.pnl�\����.Controls.Add(this.lab�����);
			this.pnl�\����.Controls.Add(this.lab�\���ҏZ��);
			this.pnl�\����.Controls.Add(this.label1);
			this.pnl�\����.Controls.Add(this.tex�\���җX�ւP);
			this.pnl�\����.Controls.Add(this.tex�\���җX�ւQ);
			this.pnl�\����.Controls.Add(this.btn�\���җX��);
			this.pnl�\����.Controls.Add(this.tex�\���ҏZ���P);
			this.pnl�\����.Controls.Add(this.tex�\���ҏZ���Q);
			this.pnl�\����.Controls.Add(this.label3);
			this.pnl�\����.Location = new System.Drawing.Point(1, 6);
			this.pnl�\����.Name = "pnl�\����";
			this.pnl�\����.Size = new System.Drawing.Size(449, 176);
			this.pnl�\����.TabIndex = 0;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Honeydew;
			this.label24.ForeColor = System.Drawing.Color.Red;
			this.label24.Location = new System.Drawing.Point(44, 130);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(16, 14);
			this.label24.TabIndex = 97;
			this.label24.Text = "��";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label13.ForeColor = System.Drawing.Color.LimeGreen;
			this.label13.Location = new System.Drawing.Point(88, 154);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(10, 14);
			this.label13.TabIndex = 94;
			this.label13.Text = "�i";
			this.label13.Visible = false;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label14.ForeColor = System.Drawing.Color.LimeGreen;
			this.label14.Location = new System.Drawing.Point(154, 154);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(12, 14);
			this.label14.TabIndex = 95;
			this.label14.Text = "�j";
			this.label14.Visible = false;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label15.ForeColor = System.Drawing.Color.LimeGreen;
			this.label15.Location = new System.Drawing.Point(210, 154);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(12, 14);
			this.label15.TabIndex = 96;
			this.label15.Text = "�|";
			this.label15.Visible = false;
			// 
			// tex�\���҂e�`�w�Q
			// 
			this.tex�\���҂e�`�w�Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���҂e�`�w�Q.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�\���҂e�`�w�Q.Location = new System.Drawing.Point(170, 148);
			this.tex�\���҂e�`�w�Q.MaxLength = 4;
			this.tex�\���҂e�`�w�Q.Name = "tex�\���҂e�`�w�Q";
			this.tex�\���҂e�`�w�Q.Size = new System.Drawing.Size(40, 23);
			this.tex�\���҂e�`�w�Q.TabIndex = 12;
			this.tex�\���҂e�`�w�Q.Text = "";
			this.tex�\���҂e�`�w�Q.Visible = false;
			// 
			// tex�\���҂e�`�w�R
			// 
			this.tex�\���҂e�`�w�R.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���҂e�`�w�R.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�\���҂e�`�w�R.Location = new System.Drawing.Point(224, 148);
			this.tex�\���҂e�`�w�R.MaxLength = 4;
			this.tex�\���҂e�`�w�R.Name = "tex�\���҂e�`�w�R";
			this.tex�\���҂e�`�w�R.Size = new System.Drawing.Size(40, 23);
			this.tex�\���҂e�`�w�R.TabIndex = 13;
			this.tex�\���҂e�`�w�R.Text = "";
			this.tex�\���҂e�`�w�R.Visible = false;
			// 
			// tex�\���҂e�`�w�P
			// 
			this.tex�\���҂e�`�w�P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���҂e�`�w�P.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�\���҂e�`�w�P.Location = new System.Drawing.Point(98, 148);
			this.tex�\���҂e�`�w�P.MaxLength = 6;
			this.tex�\���҂e�`�w�P.Name = "tex�\���҂e�`�w�P";
			this.tex�\���҂e�`�w�P.Size = new System.Drawing.Size(56, 23);
			this.tex�\���҂e�`�w�P.TabIndex = 11;
			this.tex�\���҂e�`�w�P.Text = "";
			this.tex�\���҂e�`�w�P.Visible = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.LimeGreen;
			this.label4.Location = new System.Drawing.Point(88, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 14);
			this.label4.TabIndex = 88;
			this.label4.Text = "�i";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label9.ForeColor = System.Drawing.Color.LimeGreen;
			this.label9.Location = new System.Drawing.Point(154, 130);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(12, 14);
			this.label9.TabIndex = 89;
			this.label9.Text = "�j";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label12.ForeColor = System.Drawing.Color.LimeGreen;
			this.label12.Location = new System.Drawing.Point(210, 130);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(12, 14);
			this.label12.TabIndex = 90;
			this.label12.Text = "�|";
			// 
			// tex�\���ғd�b�Q
			// 
			this.tex�\���ғd�b�Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���ғd�b�Q.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�\���ғd�b�Q.Location = new System.Drawing.Point(170, 124);
			this.tex�\���ғd�b�Q.MaxLength = 4;
			this.tex�\���ғd�b�Q.Name = "tex�\���ғd�b�Q";
			this.tex�\���ғd�b�Q.Size = new System.Drawing.Size(40, 23);
			this.tex�\���ғd�b�Q.TabIndex = 9;
			this.tex�\���ғd�b�Q.Text = "";
			// 
			// tex�\���ғd�b�R
			// 
			this.tex�\���ғd�b�R.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���ғd�b�R.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�\���ғd�b�R.Location = new System.Drawing.Point(224, 124);
			this.tex�\���ғd�b�R.MaxLength = 4;
			this.tex�\���ғd�b�R.Name = "tex�\���ғd�b�R";
			this.tex�\���ғd�b�R.Size = new System.Drawing.Size(40, 23);
			this.tex�\���ғd�b�R.TabIndex = 10;
			this.tex�\���ғd�b�R.Text = "";
			// 
			// tex�\���ғd�b�P
			// 
			this.tex�\���ғd�b�P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���ғd�b�P.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�\���ғd�b�P.Location = new System.Drawing.Point(98, 124);
			this.tex�\���ғd�b�P.MaxLength = 6;
			this.tex�\���ғd�b�P.Name = "tex�\���ғd�b�P";
			this.tex�\���ғd�b�P.Size = new System.Drawing.Size(56, 23);
			this.tex�\���ғd�b�P.TabIndex = 8;
			this.tex�\���ғd�b�P.Text = "";
			// 
			// cb�\���Ҍ�
			// 
			this.cb�\���Ҍ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cb�\���Ҍ�.Location = new System.Drawing.Point(98, 76);
			this.cb�\���Ҍ�.Name = "cb�\���Ҍ�";
			this.cb�\���Ҍ�.Size = new System.Drawing.Size(90, 24);
			this.cb�\���Ҍ�.TabIndex = 5;
			// 
			// lab�\���҂e�`�w
			// 
			this.lab�\���҂e�`�w.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\���҂e�`�w.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�\���҂e�`�w.Location = new System.Drawing.Point(58, 154);
			this.lab�\���҂e�`�w.Name = "lab�\���҂e�`�w";
			this.lab�\���҂e�`�w.Size = new System.Drawing.Size(30, 14);
			this.lab�\���҂e�`�w.TabIndex = 83;
			this.lab�\���҂e�`�w.Text = "�e�`�w";
			this.lab�\���҂e�`�w.Visible = false;
			// 
			// lab�\���ғd�b
			// 
			this.lab�\���ғd�b.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\���ғd�b.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�\���ғd�b.Location = new System.Drawing.Point(58, 130);
			this.lab�\���ғd�b.Name = "lab�\���ғd�b";
			this.lab�\���ғd�b.Size = new System.Drawing.Size(30, 14);
			this.lab�\���ғd�b.TabIndex = 82;
			this.lab�\���ғd�b.Text = "�s�d�k";
			// 
			// lab�\���җX��
			// 
			this.lab�\���җX��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\���җX��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�\���җX��.Location = new System.Drawing.Point(82, 58);
			this.lab�\���җX��.Name = "lab�\���җX��";
			this.lab�\���җX��.Size = new System.Drawing.Size(14, 14);
			this.lab�\���җX��.TabIndex = 81;
			this.lab�\���җX��.Text = "��";
			// 
			// tex�\���҃J�i
			// 
			this.tex�\���҃J�i.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���҃J�i.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�\���҃J�i.Location = new System.Drawing.Point(98, 28);
			this.tex�\���҃J�i.MaxLength = 20;
			this.tex�\���҃J�i.Name = "tex�\���҃J�i";
			this.tex�\���҃J�i.Size = new System.Drawing.Size(326, 23);
			this.tex�\���҃J�i.TabIndex = 1;
			this.tex�\���҃J�i.Text = "";
			// 
			// lab�\���҃J�i
			// 
			this.lab�\���҃J�i.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\���҃J�i.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�\���҃J�i.Location = new System.Drawing.Point(58, 34);
			this.lab�\���҃J�i.Name = "lab�\���҃J�i";
			this.lab�\���҃J�i.Size = new System.Drawing.Size(40, 14);
			this.lab�\���҃J�i.TabIndex = 59;
			this.lab�\���҃J�i.Text = "�t���K�i";
			// 
			// lab�\����
			// 
			this.lab�\����.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�\����.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab�\����.ForeColor = System.Drawing.Color.Blue;
			this.lab�\����.Location = new System.Drawing.Point(0, 0);
			this.lab�\����.Name = "lab�\����";
			this.lab�\����.Size = new System.Drawing.Size(22, 176);
			this.lab�\����.TabIndex = 44;
			this.lab�\����.Text = "���\���ҁ^���q�l";
			this.lab�\����.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab�����
			// 
			this.lab�����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�����.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�����.Location = new System.Drawing.Point(36, 10);
			this.lab�����.Name = "lab�����";
			this.lab�����.Size = new System.Drawing.Size(64, 14);
			this.lab�����.TabIndex = 9;
			this.lab�����.Text = "���\���Җ�";
			// 
			// lab�\���ҏZ��
			// 
			this.lab�\���ҏZ��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\���ҏZ��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�\���ҏZ��.Location = new System.Drawing.Point(58, 82);
			this.lab�\���ҏZ��.Name = "lab�\���ҏZ��";
			this.lab�\���ҏZ��.Size = new System.Drawing.Size(40, 14);
			this.lab�\���ҏZ��.TabIndex = 77;
			this.lab�\���ҏZ��.Text = "���Z��";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.Location = new System.Drawing.Point(134, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 14);
			this.label1.TabIndex = 80;
			this.label1.Text = "�|";
			// 
			// tex�\���җX�ւP
			// 
			this.tex�\���җX�ւP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���җX�ւP.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�\���җX�ւP.Location = new System.Drawing.Point(98, 52);
			this.tex�\���җX�ւP.MaxLength = 3;
			this.tex�\���җX�ւP.Name = "tex�\���җX�ւP";
			this.tex�\���җX�ւP.Size = new System.Drawing.Size(34, 23);
			this.tex�\���җX�ւP.TabIndex = 2;
			this.tex�\���җX�ւP.Text = "";
			// 
			// tex�\���җX�ւQ
			// 
			this.tex�\���җX�ւQ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���җX�ւQ.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�\���җX�ւQ.Location = new System.Drawing.Point(154, 52);
			this.tex�\���җX�ւQ.MaxLength = 4;
			this.tex�\���җX�ւQ.Name = "tex�\���җX�ւQ";
			this.tex�\���җX�ւQ.Size = new System.Drawing.Size(42, 23);
			this.tex�\���җX�ւQ.TabIndex = 3;
			this.tex�\���җX�ւQ.Text = "";
			this.tex�\���җX�ւQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�\���җX�ւQ_KeyDown);
			this.tex�\���җX�ւQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�\���җX�ւQ_KeyPress);
			// 
			// btn�\���җX��
			// 
			this.btn�\���җX��.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�\���җX��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�\���җX��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�\���җX��.ForeColor = System.Drawing.Color.White;
			this.btn�\���җX��.Location = new System.Drawing.Point(204, 52);
			this.btn�\���җX��.Name = "btn�\���җX��";
			this.btn�\���җX��.Size = new System.Drawing.Size(48, 22);
			this.btn�\���җX��.TabIndex = 4;
			this.btn�\���җX��.TabStop = false;
			this.btn�\���җX��.Text = "����";
			this.btn�\���җX��.Click += new System.EventHandler(this.btn�\���җX��_Click);
			// 
			// tex�\���ҏZ���P
			// 
			this.tex�\���ҏZ���P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���ҏZ���P.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�\���ҏZ���P.Location = new System.Drawing.Point(186, 76);
			this.tex�\���ҏZ���P.MaxLength = 16;
			this.tex�\���ҏZ���P.Name = "tex�\���ҏZ���P";
			this.tex�\���ҏZ���P.Size = new System.Drawing.Size(262, 23);
			this.tex�\���ҏZ���P.TabIndex = 6;
			this.tex�\���ҏZ���P.Text = "";
			// 
			// tex�\���ҏZ���Q
			// 
			this.tex�\���ҏZ���Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���ҏZ���Q.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�\���ҏZ���Q.Location = new System.Drawing.Point(98, 100);
			this.tex�\���ҏZ���Q.MaxLength = 20;
			this.tex�\���ҏZ���Q.Name = "tex�\���ҏZ���Q";
			this.tex�\���ҏZ���Q.Size = new System.Drawing.Size(326, 23);
			this.tex�\���ҏZ���Q.TabIndex = 7;
			this.tex�\���ҏZ���Q.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Honeydew;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(24, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 14);
			this.label3.TabIndex = 50;
			this.label3.Text = "��";
			// 
			// pnl��t�m�n
			// 
			this.pnl��t�m�n.BackColor = System.Drawing.Color.Honeydew;
			this.pnl��t�m�n.Controls.Add(this.btn�\����񌟍�);
			this.pnl��t�m�n.Controls.Add(this.btn�\�������s);
			this.pnl��t�m�n.Controls.Add(this.lab�\���Ǘ�NO);
			this.pnl��t�m�n.Controls.Add(this.tex��t�m�n);
			this.pnl��t�m�n.Controls.Add(this.lab�\����);
			this.pnl��t�m�n.Location = new System.Drawing.Point(1, 6);
			this.pnl��t�m�n.Name = "pnl��t�m�n";
			this.pnl��t�m�n.Size = new System.Drawing.Size(427, 32);
			this.pnl��t�m�n.TabIndex = 0;
			// 
			// btn�\����񌟍�
			// 
			this.btn�\����񌟍�.BackColor = System.Drawing.Color.Blue;
			this.btn�\����񌟍�.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�\����񌟍�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�\����񌟍�.ForeColor = System.Drawing.Color.White;
			this.btn�\����񌟍�.Location = new System.Drawing.Point(148, 5);
			this.btn�\����񌟍�.Name = "btn�\����񌟍�";
			this.btn�\����񌟍�.Size = new System.Drawing.Size(46, 22);
			this.btn�\����񌟍�.TabIndex = 1;
			this.btn�\����񌟍�.TabStop = false;
			this.btn�\����񌟍�.Text = "�I��";
			this.btn�\����񌟍�.Click += new System.EventHandler(this.btn�\����񌟍�_Click);
			// 
			// btn�\�������s
			// 
			this.btn�\�������s.BackColor = System.Drawing.Color.Blue;
			this.btn�\�������s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�\�������s.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�\�������s.ForeColor = System.Drawing.Color.White;
			this.btn�\�������s.Location = new System.Drawing.Point(200, 5);
			this.btn�\�������s.Name = "btn�\�������s";
			this.btn�\�������s.Size = new System.Drawing.Size(48, 22);
			this.btn�\�������s.TabIndex = 2;
			this.btn�\�������s.Text = "���s";
			this.btn�\�������s.Click += new System.EventHandler(this.btn�\�������s_Click);
			// 
			// lab�\���Ǘ�NO
			// 
			this.lab�\���Ǘ�NO.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\���Ǘ�NO.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�\���Ǘ�NO.Location = new System.Drawing.Point(14, 8);
			this.lab�\���Ǘ�NO.Name = "lab�\���Ǘ�NO";
			this.lab�\���Ǘ�NO.Size = new System.Drawing.Size(62, 16);
			this.lab�\���Ǘ�NO.TabIndex = 6;
			this.lab�\���Ǘ�NO.Text = "��tNO";
			// 
			// tex��t�m�n
			// 
			this.tex��t�m�n.BackColor = System.Drawing.SystemColors.Window;
			this.tex��t�m�n.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex��t�m�n.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex��t�m�n.Location = new System.Drawing.Point(76, 4);
			this.tex��t�m�n.MaxLength = 7;
			this.tex��t�m�n.Name = "tex��t�m�n";
			this.tex��t�m�n.Size = new System.Drawing.Size(66, 23);
			this.tex��t�m�n.TabIndex = 0;
			this.tex��t�m�n.Text = "";
			this.tex��t�m�n.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex��t�m�n_KeyDown);
			this.tex��t�m�n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex��t�m�n_KeyPress);
			// 
			// lab�\����
			// 
			this.lab�\����.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.lab�\����.ForeColor = System.Drawing.Color.Black;
			this.lab�\����.Location = new System.Drawing.Point(256, 8);
			this.lab�\����.Name = "lab�\����";
			this.lab�\����.Size = new System.Drawing.Size(56, 18);
			this.lab�\����.TabIndex = 102;
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
			this.lab�F�؉����.Location = new System.Drawing.Point(14, 8);
			this.lab�F�؉����.Name = "lab�F�؉����";
			this.lab�F�؉����.Size = new System.Drawing.Size(54, 14);
			this.lab�F�؉����.TabIndex = 3;
			this.lab�F�؉����.Text = "���q�l��";
			// 
			// tex�F�ؗ��p�Җ�
			// 
			this.tex�F�ؗ��p�Җ�.BackColor = System.Drawing.Color.PaleGreen;
			this.tex�F�ؗ��p�Җ�.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�F�ؗ��p�Җ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�F�ؗ��p�Җ�.ForeColor = System.Drawing.Color.Green;
			this.tex�F�ؗ��p�Җ�.Location = new System.Drawing.Point(470, 5);
			this.tex�F�ؗ��p�Җ�.Name = "tex�F�ؗ��p�Җ�";
			this.tex�F�ؗ��p�Җ�.ReadOnly = true;
			this.tex�F�ؗ��p�Җ�.Size = new System.Drawing.Size(322, 16);
			this.tex�F�ؗ��p�Җ�.TabIndex = 2;
			this.tex�F�ؗ��p�Җ�.TabStop = false;
			this.tex�F�ؗ��p�Җ�.Text = "����������������������������������������";
			this.tex�F�ؗ��p�Җ�.Visible = false;
			// 
			// lab�F�ؗ��p�Җ�
			// 
			this.lab�F�ؗ��p�Җ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�F�ؗ��p�Җ�.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�F�ؗ��p�Җ�.Location = new System.Drawing.Point(418, 7);
			this.lab�F�ؗ��p�Җ�.Name = "lab�F�ؗ��p�Җ�";
			this.lab�F�ؗ��p�Җ�.Size = new System.Drawing.Size(54, 14);
			this.lab�F�ؗ��p�Җ�.TabIndex = 1;
			this.lab�F�ؗ��p�Җ�.Text = "���[�U�[";
			this.lab�F�ؗ��p�Җ�.Visible = false;
			// 
			// tex�F�؉����
			// 
			this.tex�F�؉����.BackColor = System.Drawing.Color.PaleGreen;
			this.tex�F�؉����.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�F�؉����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�F�؉����.ForeColor = System.Drawing.Color.Green;
			this.tex�F�؉����.Location = new System.Drawing.Point(72, 5);
			this.tex�F�؉����.Name = "tex�F�؉����";
			this.tex�F�؉����.ReadOnly = true;
			this.tex�F�؉����.Size = new System.Drawing.Size(330, 16);
			this.tex�F�؉����.TabIndex = 0;
			this.tex�F�؉����.TabStop = false;
			this.tex�F�؉����.Text = "999 �����x�X";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab����);
			this.panel7.Controls.Add(this.lab��������^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(794, 26);
			this.panel7.TabIndex = 13;
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
			// lab��������^�C�g��
			// 
			this.lab��������^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab��������^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab��������^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab��������^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab��������^�C�g��.Name = "lab��������^�C�g��";
			this.lab��������^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab��������^�C�g��.TabIndex = 0;
			this.lab��������^�C�g��.Text = "�g�p�\�����݃����e�i���X";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btn�_��);
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Controls.Add(this.btn�o�^);
			this.panel8.Controls.Add(this.btn�폜);
			this.panel8.Controls.Add(this.btn���);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(794, 58);
			this.panel8.TabIndex = 0;
			// 
			// btn�_��
			// 
			this.btn�_��.BackColor = System.Drawing.Color.PaleGreen;
			this.btn�_��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�_��.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btn�_��.Location = new System.Drawing.Point(290, 6);
			this.btn�_��.Name = "btn�_��";
			this.btn�_��.Size = new System.Drawing.Size(54, 48);
			this.btn�_��.TabIndex = 3;
			this.btn�_��.Text = "���";
			this.btn�_��.Click += new System.EventHandler(this.btn�_��_Click);
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
			// btn�o�^
			// 
			this.btn�o�^.BackColor = System.Drawing.Color.PaleGreen;
			this.btn�o�^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�o�^.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btn�o�^.Location = new System.Drawing.Point(104, 6);
			this.btn�o�^.Name = "btn�o�^";
			this.btn�o�^.Size = new System.Drawing.Size(54, 48);
			this.btn�o�^.TabIndex = 0;
			this.btn�o�^.Text = "�o�^";
			this.btn�o�^.Click += new System.EventHandler(this.btn�o�^_Click);
			// 
			// btn�폜
			// 
			this.btn�폜.BackColor = System.Drawing.Color.PaleGreen;
			this.btn�폜.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�폜.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btn�폜.Location = new System.Drawing.Point(228, 6);
			this.btn�폜.Name = "btn�폜";
			this.btn�폜.Size = new System.Drawing.Size(54, 48);
			this.btn�폜.TabIndex = 2;
			this.btn�폜.Text = "�폜";
			this.btn�폜.Click += new System.EventHandler(this.btn�폜_Click);
			// 
			// btn���
			// 
			this.btn���.BackColor = System.Drawing.Color.PaleGreen;
			this.btn���.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn���.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btn���.Location = new System.Drawing.Point(166, 6);
			this.btn���.Name = "btn���";
			this.btn���.Size = new System.Drawing.Size(54, 48);
			this.btn���.TabIndex = 1;
			this.btn���.Text = "���";
			this.btn���.Click += new System.EventHandler(this.btn���_Click);
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
			// pnl�V�X�e�����
			// 
			this.pnl�V�X�e�����.BackColor = System.Drawing.Color.Honeydew;
			this.pnl�V�X�e�����.Controls.Add(this.rb���F��);
			this.pnl�V�X�e�����.Controls.Add(this.lab�g�p�J�n��);
			this.pnl�V�X�e�����.Controls.Add(this.rb�o�^��);
			this.pnl�V�X�e�����.Controls.Add(this.label48);
			this.pnl�V�X�e�����.Controls.Add(this.label47);
			this.pnl�V�X�e�����.Controls.Add(this.label46);
			this.pnl�V�X�e�����.Controls.Add(this.lab�����p�X���[�h);
			this.pnl�V�X�e�����.Controls.Add(this.lab��_�����p�X���[�h);
			this.pnl�V�X�e�����.Controls.Add(this.lab��);
			this.pnl�V�X�e�����.Controls.Add(this.num�T�[�}���䐔);
			this.pnl�V�X�e�����.Controls.Add(this.lab�T�[�}��);
			this.pnl�V�X�e�����.Controls.Add(this.label41);
			this.pnl�V�X�e�����.Controls.Add(this.lab����_�����p�X���[�h);
			this.pnl�V�X�e�����.Controls.Add(this.label39);
			this.pnl�V�X�e�����.Controls.Add(this.label38);
			this.pnl�V�X�e�����.Controls.Add(this.label37);
			this.pnl�V�X�e�����.Controls.Add(this.label36);
			this.pnl�V�X�e�����.Controls.Add(this.label35);
			this.pnl�V�X�e�����.Controls.Add(this.rb���ے�);
			this.pnl�V�X�e�����.Controls.Add(this.rb�\����);
			this.pnl�V�X�e�����.Controls.Add(this.label32);
			this.pnl�V�X�e�����.Controls.Add(this.tex���[�U�[��);
			this.pnl�V�X�e�����.Controls.Add(this.lab���p�Җ�);
			this.pnl�V�X�e�����.Controls.Add(this.tex�����p�X���[�h);
			this.pnl�V�X�e�����.Controls.Add(this.dtp�g�p�J�n��);
			this.pnl�V�X�e�����.Controls.Add(this.tex���喼);
			this.pnl�V�X�e�����.Controls.Add(this.lab���喼);
			this.pnl�V�X�e�����.Controls.Add(this.tex����R�[�h);
			this.pnl�V�X�e�����.Controls.Add(this.lab����R�[�h);
			this.pnl�V�X�e�����.Controls.Add(this.tex���q�l�R�[�h);
			this.pnl�V�X�e�����.Controls.Add(this.label7);
			this.pnl�V�X�e�����.Controls.Add(this.lab�ȈՃ��[�U�[);
			this.pnl�V�X�e�����.Controls.Add(this.tex���[�U�[�R�[�h);
			this.pnl�V�X�e�����.Controls.Add(this.label8);
			this.pnl�V�X�e�����.Controls.Add(this.btn���q�l�R�[�h);
			this.pnl�V�X�e�����.Controls.Add(this.label28);
			this.pnl�V�X�e�����.Controls.Add(this.tex����);
			this.pnl�V�X�e�����.Controls.Add(this.label42);
			this.pnl�V�X�e�����.Controls.Add(this.label43);
			this.pnl�V�X�e�����.Controls.Add(this.label44);
			this.pnl�V�X�e�����.Location = new System.Drawing.Point(1, 6);
			this.pnl�V�X�e�����.Name = "pnl�V�X�e�����";
			this.pnl�V�X�e�����.Size = new System.Drawing.Size(327, 414);
			this.pnl�V�X�e�����.TabIndex = 0;
			// 
			// rb���F��
			// 
			this.rb���F��.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rb���F��.Location = new System.Drawing.Point(114, 324);
			this.rb���F��.Name = "rb���F��";
			this.rb���F��.Size = new System.Drawing.Size(64, 18);
			this.rb���F��.TabIndex = 12;
			this.rb���F��.Text = "���F��";
			// 
			// lab�g�p�J�n��
			// 
			this.lab�g�p�J�n��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�g�p�J�n��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�g�p�J�n��.Location = new System.Drawing.Point(46, 54);
			this.lab�g�p�J�n��.Name = "lab�g�p�J�n��";
			this.lab�g�p�J�n��.Size = new System.Drawing.Size(66, 14);
			this.lab�g�p�J�n��.TabIndex = 86;
			this.lab�g�p�J�n��.Text = "�g�p�J�n��";
			// 
			// rb�o�^��
			// 
			this.rb�o�^��.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rb�o�^��.Location = new System.Drawing.Point(114, 324);
			this.rb�o�^��.Name = "rb�o�^��";
			this.rb�o�^��.Size = new System.Drawing.Size(64, 18);
			this.rb�o�^��.TabIndex = 9;
			this.rb�o�^��.Text = "�o�^��";
			this.rb�o�^��.Visible = false;
			// 
			// label48
			// 
			this.label48.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label48.ForeColor = System.Drawing.Color.DarkGreen;
			this.label48.Location = new System.Drawing.Point(110, 220);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(176, 14);
			this.label48.TabIndex = 125;
			this.label48.Text = "�i�ȗ����F���q�l�R�[�h ��4���j";
			// 
			// label47
			// 
			this.label47.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label47.ForeColor = System.Drawing.Color.DarkGreen;
			this.label47.Location = new System.Drawing.Point(110, 70);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(176, 14);
			this.label47.TabIndex = 124;
			this.label47.Text = "�i�ȗ����F�{�����t�j";
			// 
			// label46
			// 
			this.label46.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label46.ForeColor = System.Drawing.Color.Red;
			this.label46.Location = new System.Drawing.Point(32, 54);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(18, 14);
			this.label46.TabIndex = 123;
			this.label46.Text = "��";
			// 
			// lab�����p�X���[�h
			// 
			this.lab�����p�X���[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�����p�X���[�h.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�����p�X���[�h.Location = new System.Drawing.Point(36, 286);
			this.lab�����p�X���[�h.Name = "lab�����p�X���[�h";
			this.lab�����p�X���[�h.Size = new System.Drawing.Size(78, 14);
			this.lab�����p�X���[�h.TabIndex = 89;
			this.lab�����p�X���[�h.Text = "�����p�X���[�h";
			// 
			// lab��_�����p�X���[�h
			// 
			this.lab��_�����p�X���[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab��_�����p�X���[�h.ForeColor = System.Drawing.Color.Red;
			this.lab��_�����p�X���[�h.Location = new System.Drawing.Point(22, 286);
			this.lab��_�����p�X���[�h.Name = "lab��_�����p�X���[�h";
			this.lab��_�����p�X���[�h.Size = new System.Drawing.Size(18, 14);
			this.lab��_�����p�X���[�h.TabIndex = 122;
			this.lab��_�����p�X���[�h.Text = "��";
			this.lab��_�����p�X���[�h.Visible = false;
			// 
			// lab��
			// 
			this.lab��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab��.Location = new System.Drawing.Point(156, 174);
			this.lab��.Name = "lab��";
			this.lab��.Size = new System.Drawing.Size(18, 14);
			this.lab��.TabIndex = 118;
			this.lab��.Text = "��";
			// 
			// num�T�[�}���䐔
			// 
			this.num�T�[�}���䐔.Location = new System.Drawing.Point(112, 170);
			this.num�T�[�}���䐔.Maximum = new System.Decimal(new int[] {
																	  99,
																	  0,
																	  0,
																	  0});
			this.num�T�[�}���䐔.Name = "num�T�[�}���䐔";
			this.num�T�[�}���䐔.Size = new System.Drawing.Size(42, 19);
			this.num�T�[�}���䐔.TabIndex = 4;
			this.num�T�[�}���䐔.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.num�T�[�}���䐔.Value = new System.Decimal(new int[] {
																	1,
																	0,
																	0,
																	0});
			// 
			// lab�T�[�}��
			// 
			this.lab�T�[�}��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�T�[�}��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�T�[�}��.Location = new System.Drawing.Point(68, 174);
			this.lab�T�[�}��.Name = "lab�T�[�}��";
			this.lab�T�[�}��.Size = new System.Drawing.Size(44, 14);
			this.lab�T�[�}��.TabIndex = 117;
			this.lab�T�[�}��.Text = "�T�[�}��";
			// 
			// label41
			// 
			this.label41.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label41.ForeColor = System.Drawing.Color.OrangeRed;
			this.label41.Location = new System.Drawing.Point(110, 344);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(196, 14);
			this.label41.TabIndex = 115;
			this.label41.Text = "�i���F�ςŕۑ���A�S���ڕҏW�s�j";
			// 
			// lab����_�����p�X���[�h
			// 
			this.lab����_�����p�X���[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab����_�����p�X���[�h.ForeColor = System.Drawing.Color.DarkGreen;
			this.lab����_�����p�X���[�h.Location = new System.Drawing.Point(110, 304);
			this.lab����_�����p�X���[�h.Name = "lab����_�����p�X���[�h";
			this.lab����_�����p�X���[�h.Size = new System.Drawing.Size(176, 14);
			this.lab����_�����p�X���[�h.TabIndex = 114;
			this.lab����_�����p�X���[�h.Text = "�i�ȗ����F�������s�j";
			this.lab����_�����p�X���[�h.Visible = false;
			// 
			// label39
			// 
			this.label39.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label39.ForeColor = System.Drawing.Color.DarkGreen;
			this.label39.Location = new System.Drawing.Point(110, 262);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(176, 14);
			this.label39.TabIndex = 113;
			this.label39.Text = "�i�ȗ����F�ݒu�ꏊ ���@�l���j";
			// 
			// label38
			// 
			this.label38.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label38.ForeColor = System.Drawing.Color.DarkGreen;
			this.label38.Location = new System.Drawing.Point(110, 154);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(176, 14);
			this.label38.TabIndex = 112;
			this.label38.Text = "�i�ȗ����F�ݒu�ꏊ ���@�l���j";
			// 
			// label37
			// 
			this.label37.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label37.ForeColor = System.Drawing.Color.DarkGreen;
			this.label37.Location = new System.Drawing.Point(110, 112);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(176, 14);
			this.label37.TabIndex = 111;
			this.label37.Text = "�i�ȗ����F�ݒu�ꏊ �s�d�k��12���j";
			// 
			// label36
			// 
			this.label36.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label36.ForeColor = System.Drawing.Color.DarkGreen;
			this.label36.Location = new System.Drawing.Point(110, 32);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(176, 14);
			this.label36.TabIndex = 110;
			this.label36.Text = "�i�ȗ����F���\���� �s�d�k��10���j";
			// 
			// label35
			// 
			this.label35.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label35.ForeColor = System.Drawing.Color.LimeGreen;
			this.label35.Location = new System.Drawing.Point(90, 368);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(22, 14);
			this.label35.TabIndex = 109;
			this.label35.Text = "����";
			// 
			// rb���ے�
			// 
			this.rb���ے�.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rb���ے�.Location = new System.Drawing.Point(180, 324);
			this.rb���ے�.Name = "rb���ے�";
			this.rb���ے�.Size = new System.Drawing.Size(64, 18);
			this.rb���ے�.TabIndex = 11;
			this.rb���ے�.Text = "���ے�";
			// 
			// rb�\����
			// 
			this.rb�\����.Checked = true;
			this.rb�\����.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rb�\����.Location = new System.Drawing.Point(180, 324);
			this.rb�\����.Name = "rb�\����";
			this.rb�\����.Size = new System.Drawing.Size(64, 18);
			this.rb�\����.TabIndex = 10;
			this.rb�\����.TabStop = true;
			this.rb�\����.Text = "�\����";
			this.rb�\����.Visible = false;
			// 
			// label32
			// 
			this.label32.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label32.ForeColor = System.Drawing.Color.LimeGreen;
			this.label32.Location = new System.Drawing.Point(58, 326);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(54, 14);
			this.label32.TabIndex = 101;
			this.label32.Text = "���F���";
			// 
			// tex���[�U�[��
			// 
			this.tex���[�U�[��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���[�U�[��.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex���[�U�[��.Location = new System.Drawing.Point(112, 238);
			this.tex���[�U�[��.MaxLength = 20;
			this.tex���[�U�[��.Name = "tex���[�U�[��";
			this.tex���[�U�[��.Size = new System.Drawing.Size(244, 23);
			this.tex���[�U�[��.TabIndex = 6;
			this.tex���[�U�[��.Text = "";
			// 
			// lab���p�Җ�
			// 
			this.lab���p�Җ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���p�Җ�.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���p�Җ�.Location = new System.Drawing.Point(54, 244);
			this.lab���p�Җ�.Name = "lab���p�Җ�";
			this.lab���p�Җ�.Size = new System.Drawing.Size(58, 14);
			this.lab���p�Җ�.TabIndex = 100;
			this.lab���p�Җ�.Text = "���[�U�[��";
			// 
			// tex�����p�X���[�h
			// 
			this.tex�����p�X���[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�����p�X���[�h.Location = new System.Drawing.Point(114, 280);
			this.tex�����p�X���[�h.MaxLength = 40;
			this.tex�����p�X���[�h.Name = "tex�����p�X���[�h";
			this.tex�����p�X���[�h.ReadOnly = true;
			this.tex�����p�X���[�h.Size = new System.Drawing.Size(94, 23);
			this.tex�����p�X���[�h.TabIndex = 7;
			this.tex�����p�X���[�h.TabStop = false;
			this.tex�����p�X���[�h.Text = "";
			// 
			// dtp�g�p�J�n��
			// 
			this.dtp�g�p�J�n��.Location = new System.Drawing.Point(112, 50);
			this.dtp�g�p�J�n��.Name = "dtp�g�p�J�n��";
			this.dtp�g�p�J�n��.Size = new System.Drawing.Size(108, 19);
			this.dtp�g�p�J�n��.TabIndex = 1;
			// 
			// tex���喼
			// 
			this.tex���喼.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���喼.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex���喼.Location = new System.Drawing.Point(112, 130);
			this.tex���喼.MaxLength = 20;
			this.tex���喼.Name = "tex���喼";
			this.tex���喼.Size = new System.Drawing.Size(326, 23);
			this.tex���喼.TabIndex = 3;
			this.tex���喼.Text = "";
			// 
			// lab���喼
			// 
			this.lab���喼.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���喼.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���喼.Location = new System.Drawing.Point(50, 134);
			this.lab���喼.Name = "lab���喼";
			this.lab���喼.Size = new System.Drawing.Size(62, 14);
			this.lab���喼.TabIndex = 84;
			this.lab���喼.Text = "�Z�N�V������";
			// 
			// tex����R�[�h
			// 
			this.tex����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex����R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex����R�[�h.Location = new System.Drawing.Point(112, 88);
			this.tex����R�[�h.MaxLength = 12;
			this.tex����R�[�h.Name = "tex����R�[�h";
			this.tex����R�[�h.Size = new System.Drawing.Size(110, 23);
			this.tex����R�[�h.TabIndex = 2;
			this.tex����R�[�h.Text = "";
			// 
			// lab����R�[�h
			// 
			this.lab����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab����R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab����R�[�h.Location = new System.Drawing.Point(38, 94);
			this.lab����R�[�h.Name = "lab����R�[�h";
			this.lab����R�[�h.Size = new System.Drawing.Size(76, 14);
			this.lab����R�[�h.TabIndex = 82;
			this.lab����R�[�h.Text = "�Z�N�V�����R�[�h";
			// 
			// tex���q�l�R�[�h
			// 
			this.tex���q�l�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���q�l�R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex���q�l�R�[�h.Location = new System.Drawing.Point(112, 8);
			this.tex���q�l�R�[�h.MaxLength = 10;
			this.tex���q�l�R�[�h.Name = "tex���q�l�R�[�h";
			this.tex���q�l�R�[�h.Size = new System.Drawing.Size(94, 23);
			this.tex���q�l�R�[�h.TabIndex = 0;
			this.tex���q�l�R�[�h.Text = "";
			this.tex���q�l�R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex���q�l�R�[�h_KeyDown);
			this.tex���q�l�R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex���q�l�R�[�h_KeyPress);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label7.ForeColor = System.Drawing.Color.LimeGreen;
			this.label7.Location = new System.Drawing.Point(44, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 14);
			this.label7.TabIndex = 77;
			this.label7.Text = "���q�l�R�[�h";
			// 
			// lab�ȈՃ��[�U�[
			// 
			this.lab�ȈՃ��[�U�[.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�ȈՃ��[�U�[.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�ȈՃ��[�U�[.Location = new System.Drawing.Point(38, 202);
			this.lab�ȈՃ��[�U�[.Name = "lab�ȈՃ��[�U�[";
			this.lab�ȈՃ��[�U�[.Size = new System.Drawing.Size(74, 14);
			this.lab�ȈՃ��[�U�[.TabIndex = 76;
			this.lab�ȈՃ��[�U�[.Text = "���[�U�[�R�[�h";
			// 
			// tex���[�U�[�R�[�h
			// 
			this.tex���[�U�[�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���[�U�[�R�[�h.Location = new System.Drawing.Point(112, 196);
			this.tex���[�U�[�R�[�h.MaxLength = 6;
			this.tex���[�U�[�R�[�h.Name = "tex���[�U�[�R�[�h";
			this.tex���[�U�[�R�[�h.Size = new System.Drawing.Size(54, 23);
			this.tex���[�U�[�R�[�h.TabIndex = 5;
			this.tex���[�U�[�R�[�h.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label8.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(22, 414);
			this.label8.TabIndex = 0;
			this.label8.Text = "�V�X�e�����";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn���q�l�R�[�h
			// 
			this.btn���q�l�R�[�h.BackColor = System.Drawing.Color.SteelBlue;
			this.btn���q�l�R�[�h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn���q�l�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn���q�l�R�[�h.ForeColor = System.Drawing.Color.White;
			this.btn���q�l�R�[�h.Location = new System.Drawing.Point(208, 8);
			this.btn���q�l�R�[�h.Name = "btn���q�l�R�[�h";
			this.btn���q�l�R�[�h.Size = new System.Drawing.Size(44, 22);
			this.btn���q�l�R�[�h.TabIndex = 98;
			this.btn���q�l�R�[�h.TabStop = false;
			this.btn���q�l�R�[�h.Text = "����";
			this.btn���q�l�R�[�h.Click += new System.EventHandler(this.btn���q�l�R�[�h_Click);
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label28.ForeColor = System.Drawing.Color.Red;
			this.label28.Location = new System.Drawing.Point(24, 202);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(18, 14);
			this.label28.TabIndex = 33;
			this.label28.Text = "��";
			// 
			// tex����
			// 
			this.tex����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex����.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex����.Location = new System.Drawing.Point(112, 362);
			this.tex����.MaxLength = 10;
			this.tex����.Name = "tex����";
			this.tex����.Size = new System.Drawing.Size(168, 23);
			this.tex����.TabIndex = 13;
			this.tex����.Text = "";
			// 
			// label42
			// 
			this.label42.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label42.ForeColor = System.Drawing.Color.Red;
			this.label42.Location = new System.Drawing.Point(30, 12);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(18, 14);
			this.label42.TabIndex = 119;
			this.label42.Text = "��";
			// 
			// label43
			// 
			this.label43.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label43.ForeColor = System.Drawing.Color.Red;
			this.label43.Location = new System.Drawing.Point(26, 94);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(18, 14);
			this.label43.TabIndex = 120;
			this.label43.Text = "��";
			// 
			// label44
			// 
			this.label44.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label44.ForeColor = System.Drawing.Color.Red;
			this.label44.Location = new System.Drawing.Point(36, 134);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(18, 14);
			this.label44.TabIndex = 121;
			this.label44.Text = "��";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pnl��t�m�n);
			this.groupBox1.Location = new System.Drawing.Point(26, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(430, 40);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pnl�\����);
			this.groupBox2.Location = new System.Drawing.Point(4, 86);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(452, 184);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pnl�V�X�e�����);
			this.groupBox3.Location = new System.Drawing.Point(460, 86);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(330, 422);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(472, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 14);
			this.label5.TabIndex = 31;
			this.label5.Text = "�󂪂��鍀�ڂ͕K�{���͍��ڂł��B";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(458, 58);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(18, 14);
			this.label11.TabIndex = 30;
			this.label11.Text = "��";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.pnl�ݒu�ꏊ);
			this.groupBox4.Location = new System.Drawing.Point(4, 272);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(452, 236);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			// 
			// pnl�ݒu�ꏊ
			// 
			this.pnl�ݒu�ꏊ.BackColor = System.Drawing.Color.Honeydew;
			this.pnl�ݒu�ꏊ.Controls.Add(this.label21);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label33);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label49);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�g�p��);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label34);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�Ǘ��X����);
			this.pnl�ݒu�ꏊ.Controls.Add(this.lab�Ǘ��X��);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ��E��);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label30);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�S���Җ�);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label29);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label22);
			this.pnl�ݒu�ꏊ.Controls.Add(this.chb�ݒu�ꏊ);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label2);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label6);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label10);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�e�`�w�Q);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�e�`�w�R);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�e�`�w�P);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label16);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label17);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label18);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�d�b�Q);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�d�b�R);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�d�b�P);
			this.pnl�ݒu�ꏊ.Controls.Add(this.cb�ݒu�ꏊ��);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label19);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label20);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�J�i);
			this.pnl�ݒu�ꏊ.Controls.Add(this.lab�ݒu�ꏊ�J�i);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label23);
			this.pnl�ݒu�ꏊ.Controls.Add(this.lab�ݒu�ꏊ);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ��);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label25);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label26);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label27);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�X�ւP);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�X�ւQ);
			this.pnl�ݒu�ꏊ.Controls.Add(this.btn�ݒu�ꏊ�X��);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�Z���P);
			this.pnl�ݒu�ꏊ.Controls.Add(this.tex�ݒu�ꏊ�Z���Q);
			this.pnl�ݒu�ꏊ.Controls.Add(this.label31);
			this.pnl�ݒu�ꏊ.Location = new System.Drawing.Point(1, 6);
			this.pnl�ݒu�ꏊ.Name = "pnl�ݒu�ꏊ";
			this.pnl�ݒu�ꏊ.Size = new System.Drawing.Size(449, 228);
			this.pnl�ݒu�ꏊ.TabIndex = 0;
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label21.ForeColor = System.Drawing.Color.LimeGreen;
			this.label21.Location = new System.Drawing.Point(82, 74);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(14, 14);
			this.label21.TabIndex = 2;
			this.label21.Text = "��";
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.Honeydew;
			this.label33.ForeColor = System.Drawing.Color.Red;
			this.label33.Location = new System.Drawing.Point(68, 74);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(16, 14);
			this.label33.TabIndex = 109;
			this.label33.Text = "��";
			// 
			// label49
			// 
			this.label49.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label49.ForeColor = System.Drawing.Color.LimeGreen;
			this.label49.Location = new System.Drawing.Point(152, 170);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(16, 14);
			this.label49.TabIndex = 108;
			this.label49.Text = "�~";
			// 
			// tex�ݒu�ꏊ�g�p��
			// 
			this.tex�ݒu�ꏊ�g�p��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�g�p��.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�ݒu�ꏊ�g�p��.Location = new System.Drawing.Point(98, 164);
			this.tex�ݒu�ꏊ�g�p��.MaxLength = 6;
			this.tex�ݒu�ꏊ�g�p��.Name = "tex�ݒu�ꏊ�g�p��";
			this.tex�ݒu�ꏊ�g�p��.Size = new System.Drawing.Size(54, 23);
			this.tex�ݒu�ꏊ�g�p��.TabIndex = 15;
			this.tex�ݒu�ꏊ�g�p��.Text = "";
			this.tex�ݒu�ꏊ�g�p��.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label34
			// 
			this.label34.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label34.ForeColor = System.Drawing.Color.LimeGreen;
			this.label34.Location = new System.Drawing.Point(58, 170);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(42, 14);
			this.label34.TabIndex = 106;
			this.label34.Text = "�g�p��";
			// 
			// tex�Ǘ��X����
			// 
			this.tex�Ǘ��X����.BackColor = System.Drawing.Color.Honeydew;
			this.tex�Ǘ��X����.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�Ǘ��X����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�Ǘ��X����.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�Ǘ��X����.Location = new System.Drawing.Point(302, 72);
			this.tex�Ǘ��X����.MaxLength = 6;
			this.tex�Ǘ��X����.Name = "tex�Ǘ��X����";
			this.tex�Ǘ��X����.ReadOnly = true;
			this.tex�Ǘ��X����.Size = new System.Drawing.Size(122, 16);
			this.tex�Ǘ��X����.TabIndex = 104;
			this.tex�Ǘ��X����.TabStop = false;
			this.tex�Ǘ��X����.Text = "";
			// 
			// lab�Ǘ��X��
			// 
			this.lab�Ǘ��X��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�Ǘ��X��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�Ǘ��X��.Location = new System.Drawing.Point(258, 74);
			this.lab�Ǘ��X��.Name = "lab�Ǘ��X��";
			this.lab�Ǘ��X��.Size = new System.Drawing.Size(44, 14);
			this.lab�Ǘ��X��.TabIndex = 105;
			this.lab�Ǘ��X��.Text = "�o�דX";
			// 
			// tex�ݒu�ꏊ��E��
			// 
			this.tex�ݒu�ꏊ��E��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ��E��.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�ݒu�ꏊ��E��.Location = new System.Drawing.Point(276, 188);
			this.tex�ݒu�ꏊ��E��.MaxLength = 10;
			this.tex�ݒu�ꏊ��E��.Name = "tex�ݒu�ꏊ��E��";
			this.tex�ݒu�ꏊ��E��.Size = new System.Drawing.Size(168, 23);
			this.tex�ݒu�ꏊ��E��.TabIndex = 17;
			this.tex�ݒu�ꏊ��E��.Text = "";
			this.tex�ݒu�ꏊ��E��.Visible = false;
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label30.ForeColor = System.Drawing.Color.LimeGreen;
			this.label30.Location = new System.Drawing.Point(270, 174);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(42, 14);
			this.label30.TabIndex = 102;
			this.label30.Text = "��E��";
			this.label30.Visible = false;
			// 
			// tex�ݒu�ꏊ�S���Җ�
			// 
			this.tex�ݒu�ꏊ�S���Җ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�S���Җ�.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�ݒu�ꏊ�S���Җ�.Location = new System.Drawing.Point(98, 188);
			this.tex�ݒu�ꏊ�S���Җ�.MaxLength = 10;
			this.tex�ݒu�ꏊ�S���Җ�.Name = "tex�ݒu�ꏊ�S���Җ�";
			this.tex�ݒu�ꏊ�S���Җ�.Size = new System.Drawing.Size(168, 23);
			this.tex�ݒu�ꏊ�S���Җ�.TabIndex = 16;
			this.tex�ݒu�ꏊ�S���Җ�.Text = "";
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label29.ForeColor = System.Drawing.Color.LimeGreen;
			this.label29.Location = new System.Drawing.Point(36, 194);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(64, 14);
			this.label29.TabIndex = 100;
			this.label29.Text = "���S���Җ�";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Honeydew;
			this.label22.ForeColor = System.Drawing.Color.Red;
			this.label22.Location = new System.Drawing.Point(44, 146);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(16, 14);
			this.label22.TabIndex = 98;
			this.label22.Text = "��";
			// 
			// chb�ݒu�ꏊ
			// 
			this.chb�ݒu�ꏊ.ForeColor = System.Drawing.Color.LimeGreen;
			this.chb�ݒu�ꏊ.Location = new System.Drawing.Point(98, 4);
			this.chb�ݒu�ꏊ.Name = "chb�ݒu�ꏊ";
			this.chb�ݒu�ꏊ.Size = new System.Drawing.Size(100, 16);
			this.chb�ݒu�ꏊ.TabIndex = 0;
			this.chb�ݒu�ꏊ.Text = "���\���҂Ɠ���";
			this.chb�ݒu�ꏊ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chb�ݒu�ꏊ.CheckedChanged += new System.EventHandler(this.chb�ݒu�ꏊ_CheckedChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.LimeGreen;
			this.label2.Location = new System.Drawing.Point(88, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(10, 14);
			this.label2.TabIndex = 94;
			this.label2.Text = "�i";
			this.label2.Visible = false;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label6.ForeColor = System.Drawing.Color.LimeGreen;
			this.label6.Location = new System.Drawing.Point(154, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(12, 14);
			this.label6.TabIndex = 95;
			this.label6.Text = "�j";
			this.label6.Visible = false;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label10.ForeColor = System.Drawing.Color.LimeGreen;
			this.label10.Location = new System.Drawing.Point(210, 170);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(12, 14);
			this.label10.TabIndex = 96;
			this.label10.Text = "�|";
			this.label10.Visible = false;
			// 
			// tex�ݒu�ꏊ�e�`�w�Q
			// 
			this.tex�ݒu�ꏊ�e�`�w�Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�e�`�w�Q.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�ݒu�ꏊ�e�`�w�Q.Location = new System.Drawing.Point(170, 164);
			this.tex�ݒu�ꏊ�e�`�w�Q.MaxLength = 4;
			this.tex�ݒu�ꏊ�e�`�w�Q.Name = "tex�ݒu�ꏊ�e�`�w�Q";
			this.tex�ݒu�ꏊ�e�`�w�Q.Size = new System.Drawing.Size(40, 23);
			this.tex�ݒu�ꏊ�e�`�w�Q.TabIndex = 13;
			this.tex�ݒu�ꏊ�e�`�w�Q.Text = "";
			this.tex�ݒu�ꏊ�e�`�w�Q.Visible = false;
			// 
			// tex�ݒu�ꏊ�e�`�w�R
			// 
			this.tex�ݒu�ꏊ�e�`�w�R.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�e�`�w�R.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�ݒu�ꏊ�e�`�w�R.Location = new System.Drawing.Point(224, 164);
			this.tex�ݒu�ꏊ�e�`�w�R.MaxLength = 4;
			this.tex�ݒu�ꏊ�e�`�w�R.Name = "tex�ݒu�ꏊ�e�`�w�R";
			this.tex�ݒu�ꏊ�e�`�w�R.Size = new System.Drawing.Size(40, 23);
			this.tex�ݒu�ꏊ�e�`�w�R.TabIndex = 14;
			this.tex�ݒu�ꏊ�e�`�w�R.Text = "";
			this.tex�ݒu�ꏊ�e�`�w�R.Visible = false;
			// 
			// tex�ݒu�ꏊ�e�`�w�P
			// 
			this.tex�ݒu�ꏊ�e�`�w�P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�e�`�w�P.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�ݒu�ꏊ�e�`�w�P.Location = new System.Drawing.Point(98, 164);
			this.tex�ݒu�ꏊ�e�`�w�P.MaxLength = 6;
			this.tex�ݒu�ꏊ�e�`�w�P.Name = "tex�ݒu�ꏊ�e�`�w�P";
			this.tex�ݒu�ꏊ�e�`�w�P.Size = new System.Drawing.Size(56, 23);
			this.tex�ݒu�ꏊ�e�`�w�P.TabIndex = 12;
			this.tex�ݒu�ꏊ�e�`�w�P.Text = "";
			this.tex�ݒu�ꏊ�e�`�w�P.Visible = false;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label16.ForeColor = System.Drawing.Color.LimeGreen;
			this.label16.Location = new System.Drawing.Point(88, 146);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(10, 14);
			this.label16.TabIndex = 88;
			this.label16.Text = "�i";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label17.ForeColor = System.Drawing.Color.LimeGreen;
			this.label17.Location = new System.Drawing.Point(154, 146);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(12, 14);
			this.label17.TabIndex = 89;
			this.label17.Text = "�j";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label18.ForeColor = System.Drawing.Color.LimeGreen;
			this.label18.Location = new System.Drawing.Point(210, 146);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(12, 14);
			this.label18.TabIndex = 90;
			this.label18.Text = "�|";
			// 
			// tex�ݒu�ꏊ�d�b�Q
			// 
			this.tex�ݒu�ꏊ�d�b�Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�d�b�Q.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�ݒu�ꏊ�d�b�Q.Location = new System.Drawing.Point(170, 140);
			this.tex�ݒu�ꏊ�d�b�Q.MaxLength = 4;
			this.tex�ݒu�ꏊ�d�b�Q.Name = "tex�ݒu�ꏊ�d�b�Q";
			this.tex�ݒu�ꏊ�d�b�Q.Size = new System.Drawing.Size(40, 23);
			this.tex�ݒu�ꏊ�d�b�Q.TabIndex = 10;
			this.tex�ݒu�ꏊ�d�b�Q.Text = "";
			// 
			// tex�ݒu�ꏊ�d�b�R
			// 
			this.tex�ݒu�ꏊ�d�b�R.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�d�b�R.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�ݒu�ꏊ�d�b�R.Location = new System.Drawing.Point(224, 140);
			this.tex�ݒu�ꏊ�d�b�R.MaxLength = 4;
			this.tex�ݒu�ꏊ�d�b�R.Name = "tex�ݒu�ꏊ�d�b�R";
			this.tex�ݒu�ꏊ�d�b�R.Size = new System.Drawing.Size(40, 23);
			this.tex�ݒu�ꏊ�d�b�R.TabIndex = 11;
			this.tex�ݒu�ꏊ�d�b�R.Text = "";
			// 
			// tex�ݒu�ꏊ�d�b�P
			// 
			this.tex�ݒu�ꏊ�d�b�P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�d�b�P.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�ݒu�ꏊ�d�b�P.Location = new System.Drawing.Point(98, 140);
			this.tex�ݒu�ꏊ�d�b�P.MaxLength = 6;
			this.tex�ݒu�ꏊ�d�b�P.Name = "tex�ݒu�ꏊ�d�b�P";
			this.tex�ݒu�ꏊ�d�b�P.Size = new System.Drawing.Size(56, 23);
			this.tex�ݒu�ꏊ�d�b�P.TabIndex = 9;
			this.tex�ݒu�ꏊ�d�b�P.Text = "";
			// 
			// cb�ݒu�ꏊ��
			// 
			this.cb�ݒu�ꏊ��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cb�ݒu�ꏊ��.Location = new System.Drawing.Point(98, 92);
			this.cb�ݒu�ꏊ��.Name = "cb�ݒu�ꏊ��";
			this.cb�ݒu�ꏊ��.Size = new System.Drawing.Size(90, 24);
			this.cb�ݒu�ꏊ��.TabIndex = 6;
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label19.ForeColor = System.Drawing.Color.LimeGreen;
			this.label19.Location = new System.Drawing.Point(58, 170);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(30, 14);
			this.label19.TabIndex = 83;
			this.label19.Text = "�e�`�w";
			this.label19.Visible = false;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label20.ForeColor = System.Drawing.Color.LimeGreen;
			this.label20.Location = new System.Drawing.Point(58, 146);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(30, 14);
			this.label20.TabIndex = 82;
			this.label20.Text = "�s�d�k";
			// 
			// tex�ݒu�ꏊ�J�i
			// 
			this.tex�ݒu�ꏊ�J�i.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�J�i.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�ݒu�ꏊ�J�i.Location = new System.Drawing.Point(98, 44);
			this.tex�ݒu�ꏊ�J�i.MaxLength = 20;
			this.tex�ݒu�ꏊ�J�i.Name = "tex�ݒu�ꏊ�J�i";
			this.tex�ݒu�ꏊ�J�i.Size = new System.Drawing.Size(326, 23);
			this.tex�ݒu�ꏊ�J�i.TabIndex = 2;
			this.tex�ݒu�ꏊ�J�i.Text = "";
			// 
			// lab�ݒu�ꏊ�J�i
			// 
			this.lab�ݒu�ꏊ�J�i.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�ݒu�ꏊ�J�i.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�ݒu�ꏊ�J�i.Location = new System.Drawing.Point(58, 50);
			this.lab�ݒu�ꏊ�J�i.Name = "lab�ݒu�ꏊ�J�i";
			this.lab�ݒu�ꏊ�J�i.Size = new System.Drawing.Size(40, 14);
			this.lab�ݒu�ꏊ�J�i.TabIndex = 59;
			this.lab�ݒu�ꏊ�J�i.Text = "�t���K�i";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Honeydew;
			this.label23.ForeColor = System.Drawing.Color.Red;
			this.label23.Location = new System.Drawing.Point(32, 26);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(16, 14);
			this.label23.TabIndex = 50;
			this.label23.Text = "��";
			// 
			// lab�ݒu�ꏊ
			// 
			this.lab�ݒu�ꏊ.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�ݒu�ꏊ.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab�ݒu�ꏊ.ForeColor = System.Drawing.Color.Blue;
			this.lab�ݒu�ꏊ.Location = new System.Drawing.Point(0, 0);
			this.lab�ݒu�ꏊ.Name = "lab�ݒu�ꏊ";
			this.lab�ݒu�ꏊ.Size = new System.Drawing.Size(22, 228);
			this.lab�ݒu�ꏊ.TabIndex = 0;
			this.lab�ݒu�ꏊ.Text = "�ݒu�ꏊ�^�Z�N�V����";
			this.lab�ݒu�ꏊ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tex�ݒu�ꏊ��
			// 
			this.tex�ݒu�ꏊ��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ��.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�ݒu�ꏊ��.Location = new System.Drawing.Point(98, 20);
			this.tex�ݒu�ꏊ��.MaxLength = 20;
			this.tex�ݒu�ꏊ��.Name = "tex�ݒu�ꏊ��";
			this.tex�ݒu�ꏊ��.Size = new System.Drawing.Size(326, 23);
			this.tex�ݒu�ꏊ��.TabIndex = 1;
			this.tex�ݒu�ꏊ��.Text = "";
			// 
			// label25
			// 
			this.label25.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label25.ForeColor = System.Drawing.Color.LimeGreen;
			this.label25.Location = new System.Drawing.Point(46, 26);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(52, 14);
			this.label25.TabIndex = 9;
			this.label25.Text = "���@�l��";
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label26.ForeColor = System.Drawing.Color.LimeGreen;
			this.label26.Location = new System.Drawing.Point(58, 98);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(40, 14);
			this.label26.TabIndex = 77;
			this.label26.Text = "���Z��";
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label27.Location = new System.Drawing.Point(134, 70);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(12, 14);
			this.label27.TabIndex = 80;
			this.label27.Text = "�|";
			// 
			// tex�ݒu�ꏊ�X�ւP
			// 
			this.tex�ݒu�ꏊ�X�ւP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�X�ւP.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�ݒu�ꏊ�X�ւP.Location = new System.Drawing.Point(98, 68);
			this.tex�ݒu�ꏊ�X�ւP.MaxLength = 3;
			this.tex�ݒu�ꏊ�X�ւP.Name = "tex�ݒu�ꏊ�X�ւP";
			this.tex�ݒu�ꏊ�X�ւP.Size = new System.Drawing.Size(34, 23);
			this.tex�ݒu�ꏊ�X�ւP.TabIndex = 3;
			this.tex�ݒu�ꏊ�X�ւP.Text = "";
			// 
			// tex�ݒu�ꏊ�X�ւQ
			// 
			this.tex�ݒu�ꏊ�X�ւQ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�X�ւQ.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�ݒu�ꏊ�X�ւQ.Location = new System.Drawing.Point(154, 68);
			this.tex�ݒu�ꏊ�X�ւQ.MaxLength = 4;
			this.tex�ݒu�ꏊ�X�ւQ.Name = "tex�ݒu�ꏊ�X�ւQ";
			this.tex�ݒu�ꏊ�X�ւQ.Size = new System.Drawing.Size(42, 23);
			this.tex�ݒu�ꏊ�X�ւQ.TabIndex = 4;
			this.tex�ݒu�ꏊ�X�ւQ.Text = "";
			this.tex�ݒu�ꏊ�X�ւQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�ݒu�ꏊ�X�ւQ_KeyDown);
			this.tex�ݒu�ꏊ�X�ւQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�ݒu�ꏊ�X�ւQ_KeyPress);
			// 
			// btn�ݒu�ꏊ�X��
			// 
			this.btn�ݒu�ꏊ�X��.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�ݒu�ꏊ�X��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�ݒu�ꏊ�X��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�ݒu�ꏊ�X��.ForeColor = System.Drawing.Color.White;
			this.btn�ݒu�ꏊ�X��.Location = new System.Drawing.Point(204, 68);
			this.btn�ݒu�ꏊ�X��.Name = "btn�ݒu�ꏊ�X��";
			this.btn�ݒu�ꏊ�X��.Size = new System.Drawing.Size(48, 22);
			this.btn�ݒu�ꏊ�X��.TabIndex = 5;
			this.btn�ݒu�ꏊ�X��.TabStop = false;
			this.btn�ݒu�ꏊ�X��.Text = "����";
			this.btn�ݒu�ꏊ�X��.Click += new System.EventHandler(this.btn�ݒu�ꏊ�X��_Click);
			// 
			// tex�ݒu�ꏊ�Z���P
			// 
			this.tex�ݒu�ꏊ�Z���P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�Z���P.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�ݒu�ꏊ�Z���P.Location = new System.Drawing.Point(186, 92);
			this.tex�ݒu�ꏊ�Z���P.MaxLength = 16;
			this.tex�ݒu�ꏊ�Z���P.Name = "tex�ݒu�ꏊ�Z���P";
			this.tex�ݒu�ꏊ�Z���P.Size = new System.Drawing.Size(262, 23);
			this.tex�ݒu�ꏊ�Z���P.TabIndex = 7;
			this.tex�ݒu�ꏊ�Z���P.Text = "";
			// 
			// tex�ݒu�ꏊ�Z���Q
			// 
			this.tex�ݒu�ꏊ�Z���Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ݒu�ꏊ�Z���Q.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�ݒu�ꏊ�Z���Q.Location = new System.Drawing.Point(98, 116);
			this.tex�ݒu�ꏊ�Z���Q.MaxLength = 20;
			this.tex�ݒu�ꏊ�Z���Q.Name = "tex�ݒu�ꏊ�Z���Q";
			this.tex�ݒu�ꏊ�Z���Q.Size = new System.Drawing.Size(326, 23);
			this.tex�ݒu�ꏊ�Z���Q.TabIndex = 8;
			this.tex�ݒu�ꏊ�Z���Q.Text = "";
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Honeydew;
			this.label31.ForeColor = System.Drawing.Color.Red;
			this.label31.Location = new System.Drawing.Point(22, 194);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(16, 14);
			this.label31.TabIndex = 103;
			this.label31.Text = "��";
			// 
			// btn�x�X���o�^
			// 
			this.btn�x�X���o�^.BackColor = System.Drawing.Color.Blue;
			this.btn�x�X���o�^.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�x�X���o�^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�x�X���o�^.ForeColor = System.Drawing.Color.White;
			this.btn�x�X���o�^.Location = new System.Drawing.Point(700, 60);
			this.btn�x�X���o�^.Name = "btn�x�X���o�^";
			this.btn�x�X���o�^.Size = new System.Drawing.Size(90, 22);
			this.btn�x�X���o�^.TabIndex = 103;
			this.btn�x�X���o�^.TabStop = false;
			this.btn�x�X���o�^.Text = "�x�X���o�^";
			this.btn�x�X���o�^.Click += new System.EventHandler(this.btn�X�����o�^_Click);
			// 
			// �������
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 573);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btn�x�X���o�^);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(802, 607);
			this.Name = "�������";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 �g�p�\�����݃����e�i���X";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.�������_Load);
			this.Closed += new System.EventHandler(this.�������_Closed);
			this.Activated += new System.EventHandler(this.�������_Activated);
			this.pnl�\����.ResumeLayout(false);
			this.pnl��t�m�n.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.pnl�V�X�e�����.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.num�T�[�}���䐔)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.pnl�ݒu�ꏊ.ResumeLayout(false);
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

		private void �������_Load(object sender, System.EventArgs e)
		{
			tex�F�؉����.Text = gs�����;
			tex�F�ؗ��p�Җ�.Text = gs���p�Җ�;

			// �����̏����ݒ�
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;

			// �����̏����ݒ�
			cb�\���Ҍ�.Items.Clear();
			cb�\���Ҍ�.Items.AddRange(sa��);
			cb�ݒu�ꏊ��.Items.Clear();
			cb�ݒu�ꏊ��.Items.AddRange(sa��);

// DEL 2006.11.10 ���s�j���� ��ʂ̒��� START
//			tex�����p�X���[�h.Visible = false;
// DEL 2006.11.10 ���s�j���� ��ʂ̒��� END

			if( gs�X���R�[�h.Trim().Length != 0)
			{
				//�c�Ə��̏ꍇ
// ADD 2007.01.19 ���s�j���� �c�Ə��ł̉���ꗗ�\���̒�~ START
				btn���q�l�R�[�h.Visible = false;
// ADD 2007.01.19 ���s�j���� �c�Ə��ł̉���ꗗ�\���̒�~ END
				//�p�X���[�h�͔�\��
				lab�����p�X���[�h.Visible = false;
				lab��_�����p�X���[�h.Visible = false;
				tex�����p�X���[�h.Visible = false;
				lab����_�����p�X���[�h.Visible = false;
				//���F���͕ҏW�s��
				rb�o�^��.Enabled = false;
				rb�\����.Enabled = false;
				rb���ے�.Enabled = false;
				rb���F��.Enabled = false;
				tex����.Enabled = false;
// ADD 2007.02.07 ���s�j���� ��ʏ������̕ύX START
			}else{
				//�c�Ə��̏ꍇ
				btn���q�l�R�[�h.Visible = true;
				//�p�X���[�h�͔�\��
				lab�����p�X���[�h.Visible = true;
				lab��_�����p�X���[�h.Visible = true;
				tex�����p�X���[�h.Visible = true;
				lab����_�����p�X���[�h.Visible = true;
				//���F���͕ҏW�s��
				rb�o�^��.Enabled = true;
				rb�\����.Enabled = true;
				rb���ے�.Enabled = true;
				rb���F��.Enabled = true;
				tex����.Enabled = true;
// ADD 2007.02.07 ���s�j���� ��ʏ������̕ύX END
			}
			�o�^���[�h();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� START
//			tex��t�m�n.Focus();
			tex�\���Җ�.Text = " ";
			tex�\���Җ�.Focus();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� END
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX START
			if(gs�X���R�[�h.Trim().Length == 0){
				pnl�\����.Enabled       = false;
				pnl�ݒu�ꏊ.Enabled     = false;
				tex��t�m�n.Focus();
			}
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX END
		}

		private void �o�^���[�h()
		{
			pnl��t�m�n.Enabled = true;
			pnl�\����.Enabled       = true;
			pnl�ݒu�ꏊ.Enabled     = true;
			pnl�V�X�e�����.Enabled = true;
			�N���A();
			btn�o�^.Text = "�o�^";
			btn�o�^.Enabled = true;
			btn�폜.Enabled = false;
// 2006.10.26 ADD�@FJCS�j�K�c ����n�̃{�^�����g����悤�ɂ��� START
			btn�_��.Enabled = true;
// DEL 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� START
//			btn�\����.Enabled = true;
// DEL 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� END
// 2006.10.26 ADD�@FJCS�j�K�c ����n�̃{�^�����g����悤�ɂ��� END

			s�\���X�V���� = "00000000000000";
		}

		private void �X�V���[�h()
		{
			pnl��t�m�n.Enabled = false;
			pnl�\����.Enabled       = true;
			pnl�ݒu�ꏊ.Enabled     = true;
			pnl�V�X�e�����.Enabled = true;
			btn�o�^.Text = "�X�V";
			btn�o�^.Enabled = true;
			btn�폜.Enabled = true;
// 2006.10.26 ADD�@FJCS�j�K�c ����n�̃{�^�����g����悤�ɂ��� START
			btn�_��.Enabled = true;
// DEL 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� START
//			btn�\����.Enabled = true;
// DEL 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� END
// 2006.10.26 ADD�@FJCS�j�K�c ����n�̃{�^�����g����悤�ɂ��� END
		}

		private void tex��t�m�n_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�\����񌟍�.Focus();
				�\�����ꗗ();
				e.Handled = true;
			}
		}

		private void btn�\����񌟍�_Click(object sender, System.EventArgs e)
		{
			�\�����ꗗ();
		}

		private void btn�\�������s_Click(object sender, System.EventArgs e)
		{
			�\����񌟍�();
		}

		private void �\�����ꗗ()
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			//������ʂ��E���ɕ\������
			if(g�������� == null) g�������� = new ��������();
			g��������.Left = this.Left + 404;
			g��������.Top = this.Top;

			// �R�[�h�̏����\��
			g��������.s�X���R�[�h = gs�X���R�[�h.Trim();
			g��������.s��t�m�n = "";
			g��������.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g��������.s��t�m�n.Trim().Length > 0)
			{
				tex��t�m�n.Text = g��������.s��t�m�n.Trim();
				�\����񌟍�();
			}
			else
			{
				tex��t�m�n.Focus();
			}
		}

		private void �\����񌟍�()
		{
			tex���b�Z�[�W.Text = "";
			tex��t�m�n.Text = tex��t�m�n.Text.Trim();
// MOD 2007.01.19 ���s�j���� �����̕ύX START
			if(!�K�{�`�F�b�N(tex��t�m�n, "��t�m�n")) return;
			if(!���p�`�F�b�N(tex��t�m�n, "��t�m�n")) return;
// MOD 2007.01.19 ���s�j���� �����̕ύX END

			//���O�l
			tex��t�m�n.Text = tex��t�m�n.Text.PadLeft(7,'0');
			string s��t�m�n = tex��t�m�n.Text;

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[2];
				sKey[0] = tex��t�m�n.Text;
				sKey[1] = gs�X���R�[�h.Trim();
				string[] sData = sv_maintenance.Sel_Mosikomi(gsa���[�U, sKey);

				if (sData[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";

					//�e���ڂ̐ݒ�

					//��t�m�n���
					s�X���R�[�h = sData[1];
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					s�\�����X���R�[�h = sData[1];
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

					//�\���ҏ��
					tex�\���҃J�i.Text = sData[2];
					tex�\���Җ�.Text   = sData[3];
					string s�\���җX�� = sData[4];
					if(s�\���җX��.Length <= 3){
						tex�\���җX�ւP.Text = s�\���җX��;
					}else{
						tex�\���җX�ւP.Text = s�\���җX��.Substring(0,3);
						tex�\���җX�ւQ.Text = s�\���җX��.Substring(3);
					}
					if(sData[5].Length > 0)
						cb�\���Ҍ�.SelectedIndex = int.Parse(sData[5]);
					else
						cb�\���Ҍ�.SelectedIndex = 0;

					tex�\���ҏZ���P.Text = sData[6];
					tex�\���ҏZ���Q.Text = sData[7];
					tex�\���ғd�b�P.Text = sData[8];
					tex�\���ғd�b�Q.Text = sData[9];
					tex�\���ғd�b�R.Text = sData[10];
					//sData[11] = tex�\���ғd�b�P.Text + tex�\���ғd�b�Q.Text + tex�\���ғd�b�R.Text;
					tex�\���҂e�`�w�P.Text = sData[12];
					tex�\���҂e�`�w�Q.Text = sData[13];
					tex�\���҂e�`�w�R.Text = sData[14];
					//�ݒu�ꏊ���
					if(sData[15] == "1")
						chb�ݒu�ꏊ.Checked = true;
					else
						chb�ݒu�ꏊ.Checked = false;
					�ݒu�ꏊ���͐���`�k�k();
					tex�ݒu�ꏊ�J�i.Text = sData[16];
					tex�ݒu�ꏊ��.Text   = sData[17];
					string s�ݒu�ꏊ�X�� = sData[18];
					if(s�ݒu�ꏊ�X��.Length <= 3){
						tex�ݒu�ꏊ�X�ւP.Text = s�ݒu�ꏊ�X��;
					}else{
						tex�ݒu�ꏊ�X�ւP.Text = s�ݒu�ꏊ�X��.Substring(0,3);
						tex�ݒu�ꏊ�X�ւQ.Text = s�ݒu�ꏊ�X��.Substring(3);
					}
					if(sData[19].Length > 0)
						cb�ݒu�ꏊ��.SelectedIndex = int.Parse(sData[19]);
					else
						cb�ݒu�ꏊ��.SelectedIndex = 0;

					tex�ݒu�ꏊ�Z���P.Text = sData[20];
					tex�ݒu�ꏊ�Z���Q.Text = sData[21];
					tex�ݒu�ꏊ�d�b�P.Text = sData[22];
					tex�ݒu�ꏊ�d�b�Q.Text = sData[23];
					tex�ݒu�ꏊ�d�b�R.Text = sData[24];
					tex�ݒu�ꏊ�e�`�w�P.Text = sData[25];
					tex�ݒu�ꏊ�e�`�w�Q.Text = sData[26];
					tex�ݒu�ꏊ�e�`�w�R.Text = sData[27];
					tex�ݒu�ꏊ�S���Җ�.Text = sData[28];
					tex�ݒu�ꏊ��E��.Text = sData[29];

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//�X�֌����ɂ��q�l�R�[�h���K�v�Ȃ̂ŕҏW�ꏊ��ύX
					tex���q�l�R�[�h.Text = sData[31];
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

// 2006.08.23 ADD�@���s�j�R�{  �������ɏo�דX�R�[�h��\�� START
					if(tex�ݒu�ꏊ�X�ւP.Text.Length == 3 && tex�ݒu�ꏊ�X�ւQ.Text.Length == 4)
						�X�֌���(tex�ݒu�ꏊ�X�ւP, tex�ݒu�ꏊ�X�ւQ, 
							cb�ݒu�ꏊ��, tex�ݒu�ꏊ�Z���P, tex�ݒu�ꏊ�Z���Q, tex�Ǘ��X����);
// 2006.08.23 ADD�@���s�j�R�{  �������ɏo�דX�R�[�h��\�� END

					int i�ݒu�ꏊ�g�p�� = int.Parse(sData[30]);
					if(i�ݒu�ꏊ�g�p�� > 0)
						tex�ݒu�ꏊ�g�p��.Text = i�ݒu�ꏊ�g�p��.ToString("#,##0");
					else
						tex�ݒu�ꏊ�g�p��.Text = "";
					//�V�X�e�����
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//�X�֌����ɂ��q�l�R�[�h���K�v�Ȃ̂ŕҏW�ꏊ��ύX
//					tex���q�l�R�[�h.Text = sData[31];
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

					if(sData[32].Length == 8)
						dtp�g�p�J�n��.Value = new DateTime(int.Parse(sData[32].Substring(0, 4)),
															int.Parse(sData[32].Substring(4, 2)),
															int.Parse(sData[32].Substring(6, 2)));
					else
						dtp�g�p�J�n��.Value = DateTime.Now;
					tex����R�[�h.Text     = sData[33];
					tex���喼.Text         = sData[34];
					int i�T�[�}���䐔 = int.Parse(sData[35]);
					if(i�T�[�}���䐔 > 0)
						num�T�[�}���䐔.Value = i�T�[�}���䐔;
					else
						num�T�[�}���䐔.Value = 1;
					tex���[�U�[�R�[�h.Text = sData[36];
					tex���[�U�[��.Text     = sData[37];
					tex�����p�X���[�h.Text = sData[38];
					//���F��ԏ��
					if(sData[39].Length == 0) rb�o�^��.Checked = true;
					else if(sData[39] == "1") rb�\����.Checked = true;
					else if(sData[39] == "2") rb���ے�.Checked = true;
					else if(sData[39] == "3") rb���F��.Checked = true;
					else rb�o�^��.Checked = true;
					if(rb�o�^��.Checked)      lab�\����.Text = "�o�^��";
					else if(rb�\����.Checked) lab�\����.Text = "�\����";
					else if(rb���ے�.Checked) lab�\����.Text = "���ے�";
					else if(rb���F��.Checked) lab�\����.Text = "���F��";

					tex����.Text  = sData[40];
					//�X�V���
					s�\���X�V���� = sData[41];

					�X�V���[�h();
// ADD 2007.01.30 ���s�j���� ����ρi�\�����j�ȍ~�́A�X�V�ł��Ȃ����� START
					if(sData[39].Length == 0)
						btn�o�^.Enabled = true;
					else
						btn�o�^.Enabled = false;
// ADD 2007.01.30 ���s�j���� ����ρi�\�����j�ȍ~�́A�X�V�ł��Ȃ����� END
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� START
//					tex�\���҃J�i.Focus();
					tex�\���Җ�.Focus();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� END
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX START
					if(gs�X���R�[�h.Trim().Length == 0){
						pnl�\����.Enabled   = false;
						pnl�ݒu�ꏊ.Enabled = false;
						btn�o�^.Enabled     = true;
						tex��t�m�n.Focus();
					}
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX END

					//���F�ς̏ꍇ�A�X�V�s��
					if(rb���F��.Checked)
					{
						pnl�\����.Enabled       = false;
						pnl�ݒu�ꏊ.Enabled     = false;
						pnl�V�X�e�����.Enabled = false;
						btn�o�^.Enabled = false;
						btn�폜.Enabled = false;
// 2006.10.26 ADD�@FJCS�j�K�c ����n�̃{�^�����g���Ȃ����� START
						btn�_��.Enabled = false;
// DEL 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� START
//						btn�\����.Enabled = false;
// DEL 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� END
// 2006.10.26 ADD�@FJCS�j�K�c ����n�̃{�^�����g���Ȃ����� END
						btn���.Focus();
					}
				}
				else
				{
					tex���b�Z�[�W.Text = sData[0];
					�r�[�v��();
					�o�^���[�h();
					tex��t�m�n.Text = s��t�m�n;
					tex��t�m�n.Focus();
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�o�^���[�h();
				tex��t�m�n.Text = s��t�m�n;
				tex��t�m�n.Focus();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn�o�^_Click(object sender, System.EventArgs e)
		{

			if(�o�^_�`�F�b�N() != true) return;
			try
			{
				string[] sData  = new string[43];
				//��t�m�n���
				sData[0] = tex��t�m�n.Text.Trim();
				sData[1] = s�X���R�[�h;
				//�\���ҏ��
				sData[2] = tex�\���҃J�i.Text;
				sData[3] = tex�\���Җ�.Text;
				sData[4] = tex�\���җX�ւP.Text + tex�\���җX�ւQ.Text;
				sData[5] = cb�\���Ҍ�.SelectedIndex.ToString("00");
				sData[6] = tex�\���ҏZ���P.Text;
				sData[7] = tex�\���ҏZ���Q.Text;
				sData[8] = tex�\���ғd�b�P.Text;
				sData[9] = tex�\���ғd�b�Q.Text;
				sData[10] = tex�\���ғd�b�R.Text;
				sData[11] = tex�\���ғd�b�P.Text + tex�\���ғd�b�Q.Text + tex�\���ғd�b�R.Text;
				sData[12] = tex�\���҂e�`�w�P.Text;
				sData[13] = tex�\���҂e�`�w�Q.Text;
				sData[14] = tex�\���҂e�`�w�R.Text;
				//�ݒu�ꏊ���
				if(chb�ݒu�ꏊ.Checked)
					sData[15] = "1";
				else
					sData[15] = " ";
//				�ݒu�ꏊ���͐���`�k�k();
				sData[16] = tex�ݒu�ꏊ�J�i.Text;
				sData[17] = tex�ݒu�ꏊ��.Text;
				sData[18] = tex�ݒu�ꏊ�X�ւP.Text + tex�ݒu�ꏊ�X�ւQ.Text;
				sData[19] = cb�ݒu�ꏊ��.SelectedIndex.ToString("00");
				sData[20] = tex�ݒu�ꏊ�Z���P.Text;
				sData[21] = tex�ݒu�ꏊ�Z���Q.Text;
				sData[22] = tex�ݒu�ꏊ�d�b�P.Text;
				sData[23] = tex�ݒu�ꏊ�d�b�Q.Text;
				sData[24] = tex�ݒu�ꏊ�d�b�R.Text;
				sData[25] = tex�ݒu�ꏊ�e�`�w�P.Text;
				sData[26] = tex�ݒu�ꏊ�e�`�w�Q.Text;
				sData[27] = tex�ݒu�ꏊ�e�`�w�R.Text;
				sData[28] = tex�ݒu�ꏊ�S���Җ�.Text;
				sData[29] = tex�ݒu�ꏊ��E��.Text;
				sData[30] = tex�ݒu�ꏊ�g�p��.Text.Replace(",","");
				//�V�X�e�����
				sData[31] = tex���q�l�R�[�h.Text;
				sData[32] = dtp�g�p�J�n��.Value.Year.ToString() 
								+ dtp�g�p�J�n��.Value.Month.ToString().PadLeft(2, '0') 
								+ dtp�g�p�J�n��.Value.Day.ToString().PadLeft(2, '0');
				sData[33] = tex����R�[�h.Text;
				sData[34] = tex���喼.Text;
				sData[35] = num�T�[�}���䐔.Value.ToString();
				sData[36] = tex���[�U�[�R�[�h.Text;
				sData[37] = tex���[�U�[��.Text;
				sData[38] = tex�����p�X���[�h.Text;
				//���F��ԏ��
				if(rb�o�^��.Checked) sData[39] = " ";
				else if(rb�\����.Checked) sData[39] = "1";
				else if(rb���ے�.Checked) sData[39] = "2";
				else if(rb���F��.Checked) sData[39] = "3";
				else sData[39] = " ";
				sData[40] = tex����.Text;
				//�X�V���
				sData[41] = s�\���X�V����;
				sData[42] = gs���p�҃R�[�h;

				for(int iCnt = 0; iCnt < sData.Length ; iCnt++)
					if(sData[iCnt].Length ==0) sData[iCnt] = " ";

				string[] sList = new string[1]{""};
				if (btn�o�^.Text.Equals("�o�^"))
				{

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					if ((tex���q�l�R�[�h.Text == "") || (tex���q�l�R�[�h.Text.Substring(0,1) != "J"))
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
						�o�^���[�h();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� START
//						tex��t�m�n.Focus();
						tex�\���Җ�.Text = " ";
						tex�\���Җ�.Focus();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� END
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX START
						if(gs�X���R�[�h.Trim().Length == 0) tex��t�m�n.Focus();
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX END
					}
					else
					{
						if(sList.Length >= 2 && sList[2] != null)
							tex��t�m�n.Text = sList[2].Trim();
						�r�[�v��();
					}
				}
				else
				{

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					if ((tex���q�l�R�[�h.Text == "") || (tex���q�l�R�[�h.Text.Substring(0,1) != "J"))
					{
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

						sList = sv_maintenance.Upd_Mosikomi(gsa���[�U, sData);

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					}
					else
					{
						sList = sv_oji.Upd_Mosikomi(gsa���[�U, sData);
					}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
					
					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
						tex���b�Z�[�W.Text = "";
						//����̍X�V
						s�\���X�V���� = sList[1].Trim();
						�o�^���[�h();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� START
//						tex��t�m�n.Focus();
						tex�\���Җ�.Text = " ";
						tex�\���Җ�.Focus();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� END
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX START
						if(gs�X���R�[�h.Trim().Length == 0) tex��t�m�n.Focus();
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX END
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
//				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private bool �o�^_�`�F�b�N()
		{
// DEL 2006.11.06 ���s�j���� �o�דX�`�F�b�N�ʒu�ύX START
//			if(gs�X���R�[�h.Trim().Length != 0)
//			{
//				if (gs�X���R�[�h.Trim() != s�X���R�[�h.Trim())
//				{
//					MessageBox.Show("�o�דX������������܂���B�i�o�דX�F" + s�X���R�[�h.Trim() + "�j","���̓`�F�b�N", MessageBoxButtons.OK);
//					tex�ݒu�ꏊ�X�ւP.Focus();
//					return(false);
//				}
//			}
// DEL 2006.11.06 ���s�j���� �o�דX�`�F�b�N�ʒu�ύX END

			//�s������
			tex�\���Җ�.Text = tex�\���Җ�.Text.Trim();
			tex�\���҃J�i.Text = tex�\���҃J�i.Text.Trim();
			tex�\���Җ�.Text = tex�\���Җ�.Text.Trim();
			tex�\���җX�ւP.Text = tex�\���җX�ւP.Text.Trim();
			tex�\���җX�ւQ.Text = tex�\���җX�ւQ.Text.Trim();
// ADD 2006.11.06 ���s�j���� �x�X�o�^��ʂ̒ǉ� START
			cb�\���Ҍ�.Text = cb�\���Ҍ�.Text.Trim();
// ADD 2006.11.06 ���s�j���� �x�X�o�^��ʂ̒ǉ� END
			tex�\���ҏZ���P.Text = tex�\���ҏZ���P.Text.Trim();
			tex�\���ҏZ���Q.Text = tex�\���ҏZ���Q.Text.Trim();
			tex�\���ғd�b�P.Text = tex�\���ғd�b�P.Text.Trim();
			tex�\���ғd�b�Q.Text = tex�\���ғd�b�Q.Text.Trim();
			tex�\���ғd�b�R.Text = tex�\���ғd�b�R.Text.Trim();
			tex�\���҂e�`�w�P.Text = tex�\���҂e�`�w�P.Text.Trim();
			tex�\���҂e�`�w�Q.Text = tex�\���҂e�`�w�Q.Text.Trim();
			tex�\���҂e�`�w�R.Text = tex�\���҂e�`�w�R.Text.Trim();

//			chb�ݒu�ꏊ.Checked = false;
			�ݒu�ꏊ���͐���`�k�k();
			tex�ݒu�ꏊ�J�i.Text = tex�ݒu�ꏊ�J�i.Text.Trim();
			tex�ݒu�ꏊ��.Text = tex�ݒu�ꏊ��.Text.Trim();
			tex�ݒu�ꏊ�X�ւP.Text = tex�ݒu�ꏊ�X�ւP.Text.Trim();
			tex�ݒu�ꏊ�X�ւQ.Text = tex�ݒu�ꏊ�X�ւQ.Text.Trim();
			tex�Ǘ��X����.Text = tex�Ǘ��X����.Text.Trim();
// ADD 2006.11.06 ���s�j���� �x�X�o�^��ʂ̒ǉ� START
			cb�ݒu�ꏊ��.Text = cb�ݒu�ꏊ��.Text.Trim();
// ADD 2006.11.06 ���s�j���� �x�X�o�^��ʂ̒ǉ� END
			tex�ݒu�ꏊ�Z���P.Text = tex�ݒu�ꏊ�Z���P.Text.Trim();
			tex�ݒu�ꏊ�Z���Q.Text = tex�ݒu�ꏊ�Z���Q.Text.Trim();
			tex�ݒu�ꏊ�d�b�P.Text = tex�ݒu�ꏊ�d�b�P.Text.Trim();
			tex�ݒu�ꏊ�d�b�Q.Text = tex�ݒu�ꏊ�d�b�Q.Text.Trim();
			tex�ݒu�ꏊ�d�b�R.Text = tex�ݒu�ꏊ�d�b�R.Text.Trim();
			tex�ݒu�ꏊ�e�`�w�P.Text = tex�ݒu�ꏊ�e�`�w�P.Text.Trim();
			tex�ݒu�ꏊ�e�`�w�Q.Text = tex�ݒu�ꏊ�e�`�w�Q.Text.Trim();
			tex�ݒu�ꏊ�e�`�w�R.Text = tex�ݒu�ꏊ�e�`�w�R.Text.Trim();
			tex�ݒu�ꏊ�S���Җ�.Text = tex�ݒu�ꏊ�S���Җ�.Text.Trim();
			tex�ݒu�ꏊ��E��.Text = tex�ݒu�ꏊ��E��.Text.Trim();
			tex�ݒu�ꏊ�g�p��.Text = tex�ݒu�ꏊ�g�p��.Text.Trim();

			tex���q�l�R�[�h.Text = tex���q�l�R�[�h.Text.Trim();
//			dtp�g�p�J�n��.Value = DateTime.Now;
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
			tex���喼.Text = tex���喼.Text.Trim();
//			num�T�[�}���䐔.Value = 1;
			tex���[�U�[�R�[�h.Text = tex���[�U�[�R�[�h.Text.Trim();
			tex���[�U�[��.Text = tex���[�U�[��.Text.Trim();
			tex�����p�X���[�h.Text = tex�����p�X���[�h.Text.Trim();
//			rb�\����.Checked = true;
			tex����.Text = tex����.Text.Trim();
			
			//�K�{�`�F�b�N
			if (!�K�{�`�F�b�N(tex�\���Җ�, "���\���Җ�")) return(false);
			if (!�K�{�`�F�b�N(tex�\���ғd�b�P, "���\���ғd�b�ԍ�")) return(false);
			if (!�K�{�`�F�b�N(tex�\���ғd�b�Q, "���\���ғd�b�ԍ�")) return(false);
			if (!�K�{�`�F�b�N(tex�\���ғd�b�R, "���\���ғd�b�ԍ�")) return(false);
			if (!�K�{�`�F�b�N(tex�ݒu�ꏊ��, "���@�l��")) return(false);
// MOD 2007.01.20 ���s�j���� ��ʒ��� START
//			if (!�K�{�`�F�b�N(tex�ݒu�ꏊ�X�ւP, "�ݒu�ꏊ�X�֔ԍ�")) return(false);
//			if (!�K�{�`�F�b�N(tex�ݒu�ꏊ�X�ւQ, "�ݒu�ꏊ�X�֔ԍ�")) return(false);
			if(tex�ݒu�ꏊ�X�ւP.Enabled){
				if (!�K�{�`�F�b�N(tex�ݒu�ꏊ�X�ւP, "�ݒu�ꏊ�X�֔ԍ�")) return(false);
				if (!�K�{�`�F�b�N(tex�ݒu�ꏊ�X�ւQ, "�ݒu�ꏊ�X�֔ԍ�")) return(false);
			}else{
// MOD 2008.05.02 ���s�j���� �\���җX�֔ԍ��G���[���b�Z�[�W�̕ύX START
//				if (!�K�{�`�F�b�N(tex�\���җX�ւP, "�ݒu�ꏊ�X�֔ԍ�")) return(false);
//				if (!�K�{�`�F�b�N(tex�\���җX�ւQ, "�ݒu�ꏊ�X�֔ԍ�")) return(false);
				if (!�K�{�`�F�b�N(tex�\���җX�ւP, "�\���җX�֔ԍ�")) return(false);
				if (!�K�{�`�F�b�N(tex�\���җX�ւQ, "�\���җX�֔ԍ�")) return(false);
// MOD 2008.05.02 ���s�j���� �\���җX�֔ԍ��G���[���b�Z�[�W�̕ύX END
			}
// MOD 2007.01.20 ���s�j���� ��ʒ��� END
			if (!�K�{�`�F�b�N(tex�ݒu�ꏊ�d�b�P, "�ݒu�ꏊ�d�b�ԍ�")) return(false);
			if (!�K�{�`�F�b�N(tex�ݒu�ꏊ�d�b�Q, "�ݒu�ꏊ�d�b�ԍ�")) return(false);
			if (!�K�{�`�F�b�N(tex�ݒu�ꏊ�d�b�R, "�ݒu�ꏊ�d�b�ԍ�")) return(false);
			if (!�K�{�`�F�b�N(tex�ݒu�ꏊ�S���Җ�, "���S���Җ�")) return(false);

			//�^�`�F�b�N
// MOD 2008.05.07 ���s�j���� �G���[�`�F�b�N���̕ύX START
//			if (!�S�p�`�F�b�N(tex�\���҃J�i, "���\���҃J�i")) return(false);
//			if (!�S�p�`�F�b�N(tex�\���Җ�, "���\���Җ�")) return(false);
			if (!�S�p�`�F�b�N(tex�\���Җ�, "���\���Җ�")) return(false);
			if (!�S�p�`�F�b�N(tex�\���҃J�i, "���\���҃J�i")) return(false);
// MOD 2008.05.07 ���s�j���� �G���[�`�F�b�N���̕ύX END
			if (!���p�`�F�b�N(tex�\���җX�ւP, "���\���җX�֔ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�\���җX�ւQ, "���\���җX�֔ԍ�")) return(false);
			if (!�S�p�`�F�b�N(tex�\���ҏZ���P, "���\���ҏZ���P")) return(false);
			if (!�S�p�`�F�b�N(tex�\���ҏZ���Q, "���\���ҏZ���Q")) return(false);
			if (!���p�`�F�b�N(tex�\���ғd�b�P, "���\���ғd�b�ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�\���ғd�b�Q, "���\���ғd�b�ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�\���ғd�b�R, "���\���ғd�b�ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�\���҂e�`�w�P, "���\���҂e�`�w�ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�\���҂e�`�w�Q, "���\���҂e�`�w�ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�\���҂e�`�w�R, "���\���҂e�`�w�ԍ�")) return(false);

// MOD 2008.05.07 ���s�j���� �G���[�`�F�b�N���̕ύX START
//			if (!�S�p�`�F�b�N(tex�ݒu�ꏊ�J�i, "�ݒu�ꏊ�J�i")) return(false);
//			if (!�S�p�`�F�b�N(tex�ݒu�ꏊ��, "���@�l��")) return(false);
			if (!�S�p�`�F�b�N(tex�ݒu�ꏊ��, "���@�l��")) return(false);
			if (!�S�p�`�F�b�N(tex�ݒu�ꏊ�J�i, "���@�l���J�i")) return(false);
// MOD 2008.05.07 ���s�j���� �G���[�`�F�b�N���̕ύX END
			if (!���p�`�F�b�N(tex�ݒu�ꏊ�X�ւP, "�ݒu�ꏊ�X�֔ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�ݒu�ꏊ�X�ւQ, "�ݒu�ꏊ�X�֔ԍ�")) return(false);
			if (!�S�p�`�F�b�N(tex�ݒu�ꏊ�Z���P, "�ݒu�ꏊ�Z���P")) return(false);
			if (!�S�p�`�F�b�N(tex�ݒu�ꏊ�Z���Q, "�ݒu�ꏊ�Z���Q")) return(false);
			if (!���p�`�F�b�N(tex�ݒu�ꏊ�d�b�P, "�ݒu�ꏊ�d�b�ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�ݒu�ꏊ�d�b�Q, "�ݒu�ꏊ�d�b�ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�ݒu�ꏊ�d�b�R, "�ݒu�ꏊ�d�b�ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�ݒu�ꏊ�e�`�w�P, "�ݒu�ꏊ�e�`�w�ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�ݒu�ꏊ�e�`�w�Q, "�ݒu�ꏊ�e�`�w�ԍ�")) return(false);
			if (!���p�`�F�b�N(tex�ݒu�ꏊ�e�`�w�R, "�ݒu�ꏊ�e�`�w�ԍ�")) return(false);
			if (!�S�p�`�F�b�N(tex�ݒu�ꏊ�S���Җ�, "���S���Җ�")) return(false);
			if (!�S�p�`�F�b�N(tex�ݒu�ꏊ��E��, "��E��")) return(false);
			if (tex�ݒu�ꏊ�g�p��.Text.Length == 0) tex�ݒu�ꏊ�g�p��.Text = "0";
			if (!�͈̓`�F�b�N(tex�ݒu�ꏊ�g�p��, "�g�p��", 0, 99999)) return(false);

			if (!���p�`�F�b�N(tex���q�l�R�[�h, "���q�l�R�[�h")) return(false);
			if (!���p�`�F�b�N(tex����R�[�h, "�Z�N�V�����R�[�h")) return(false);
			if (!�S�p�`�F�b�N(tex���喼, "�Z�N�V������")) return(false);
			if (!�͈̓`�F�b�N(num�T�[�}���䐔, "�T�[�}���䐔")) return(false);
			if (!���p�`�F�b�N(tex���[�U�[�R�[�h, "���[�U�[�R�[�h")) return(false);
			if (!�S�p�`�F�b�N(tex���[�U�[��, "���[�U�[��")) return(false);
			if (!���p�`�F�b�N(tex�����p�X���[�h, "�����p�X���[�h")) return(false);
			if (!�S�p�`�F�b�N(tex����, "����")) return(false);

			//�}�X�^�`�F�b�N
			if (!�X�֌���(tex�\���җX�ւP, tex�\���җX�ւQ, 
				cb�\���Ҍ�, tex�\���ҏZ���P, tex�\���ҏZ���Q, null))
			{
				MessageBox.Show("�X�֔ԍ�(" + tex�\���җX�ւP.Text + tex�\���җX�ւQ.Text + ")�����݂��܂���",
					"���̓`�F�b�N", MessageBoxButtons.OK);
				tex�\���җX�ւP.Focus();
				return(false);
			}
			if (!�X�֌���(tex�ݒu�ꏊ�X�ւP, tex�ݒu�ꏊ�X�ւQ, 
				cb�ݒu�ꏊ��, tex�ݒu�ꏊ�Z���P, tex�ݒu�ꏊ�Z���Q, tex�Ǘ��X����))
			{
				MessageBox.Show("�X�֔ԍ�(" + tex�ݒu�ꏊ�X�ւP.Text + tex�ݒu�ꏊ�X�ւQ.Text + ")�����݂��܂���",
					"���̓`�F�b�N", MessageBoxButtons.OK);
				tex�ݒu�ꏊ�X�ւP.Focus();
				return(false);
			}
// ADD 2006.11.06 ���s�j���� �o�דX�`�F�b�N�ʒu�ύX START
			if(gs�X���R�[�h.Trim().Length != 0)
			{
				if (gs�X���R�[�h.Trim() != s�X���R�[�h.Trim())
				{
// MOD 2007.01.20 ���s�j���� ��ʒ��� START
//					MessageBox.Show("�o�דX������������܂���B�i�o�דX�F" + s�X���R�[�h.Trim() + "�j","���̓`�F�b�N", MessageBoxButtons.OK);
//					tex�ݒu�ꏊ�X�ւP.Focus();
					MessageBox.Show("�o�דX�i�X�֔ԍ��j������������܂���B�i�o�דX�F" + s�X���R�[�h.Trim() + "�j","���̓`�F�b�N", MessageBoxButtons.OK);
					if(tex�ݒu�ꏊ�X�ւP.Enabled)
						tex�ݒu�ꏊ�X�ւP.Focus();
					else
						tex�\���җX�ւP.Focus();
// MOD 2007.01.20 ���s�j���� ��ʒ��� END
					return(false);
				}
			}
// ADD 2006.11.06 ���s�j���� �o�דX�`�F�b�N�ʒu�ύX END

// ADD 2006.11.06 ���s�j���� �x�X�o�^��ʂ̒ǉ� START
			if (cb�\���Ҍ�.Text.Length > 0 || tex�\���ҏZ���P.Text.Length > 0 || tex�\���ҏZ���Q.Text.Length > 0)
				if (!�����`�F�b�N(cb�\���Ҍ�, "���\���ғs���{��")) return false;
			if (cb�ݒu�ꏊ��.Text.Length > 0 || tex�ݒu�ꏊ�Z���P.Text.Length > 0 || tex�ݒu�ꏊ�Z���Q.Text.Length > 0)
				if (!�����`�F�b�N(cb�ݒu�ꏊ��, "�ݒu�ꏊ�s���{��")) return false;
// ADD 2006.11.06 ���s�j���� �x�X�o�^��ʂ̒ǉ� END

			//�ȗ����̐ݒ�
			string s�\���ғd�b = tex�\���ғd�b�P.Text + tex�\���ғd�b�Q.Text + tex�\���ғd�b�R.Text;
			string s�ݒu�ꏊ�d�b = tex�ݒu�ꏊ�d�b�P.Text + tex�ݒu�ꏊ�d�b�Q.Text + tex�ݒu�ꏊ�d�b�R.Text;
			if(tex���q�l�R�[�h.Text.Length == 0)
			{
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
				if(gs�X���R�[�h.Trim().Length != 0)
				{
					try
					{
						String[] sKey = new string[1];
						sKey[0] = gs�X���R�[�h;
						string[] sList = sv_oji.Sel_Member(gsa���[�U, sKey);

						if (sList[0].Equals("����I��"))
						{
							if ((sList[4] == "3") || (sList[4] == "4"))
							{
								if(s�\���ғd�b.Length > 9)		
									s�\���ғd�b = s�\���ғd�b.Substring(s�\���ғd�b.Length - 9);
								s�\���ғd�b = "J" + s�\���ғd�b;
							}
						}
					}
					catch (Exception ex)
					{
						tex���b�Z�[�W.Text = ex.Message;
						�r�[�v��();
					}
				}else if(s�\�����X���R�[�h.Trim().Length != 0)
				{
					try
					{
						String[] sKey1 = new string[1];
						sKey1[0] = s�\�����X���R�[�h;
						string[] sList = sv_oji.Sel_Member(gsa���[�U, sKey1);
						string s���q�l�R�[�h = "";
						s���q�l�R�[�h = tex���q�l�R�[�h.Text;
						if (sList[0].Equals("����I��"))
						{
							if ((sList[4] == "3") || (sList[4] == "4"))
							{
								if(s�\���ғd�b.Length > 9)		
									s�\���ғd�b = s�\���ғd�b.Substring(s�\���ғd�b.Length - 9);
								s�\���ғd�b = "J" + s�\���ғd�b;
							}
						}
					}
					catch (Exception ex)
					{
						tex���b�Z�[�W.Text = ex.Message;
						�r�[�v��();
					}
				}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
				
				if(s�\���ғd�b.Length <= 10)
					tex���q�l�R�[�h.Text = s�\���ғd�b;
				else				
					tex���q�l�R�[�h.Text = s�\���ғd�b.Substring(s�\���ғd�b.Length - 10);
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
			}
			else
			{
				if(s�\�����X���R�[�h.Trim().Length != 0)
				{
					try
					{
						String[] sKey1 = new string[1];
						sKey1[0] = s�\�����X���R�[�h;
						string[] sList = sv_oji.Sel_Member(gsa���[�U, sKey1);
						string s���q�l�R�[�h = "";
						s���q�l�R�[�h = tex���q�l�R�[�h.Text;
						if (sList[0].Equals("����I��"))
						{
							if ((sList[4] == "3") || (sList[4] == "4"))
							{
								if ((s���q�l�R�[�h.Trim() == "") || (s���q�l�R�[�h.Trim().Substring(0,1) != "J"))
								{
									MessageBox.Show("���q�l�R�[�h���Ⴂ�܂��B�u���q�l�R�[�h�擪�F�i�c���q�^���v","���̓`�F�b�N",MessageBoxButtons.OK);
									return false;
								}
							}
							else if ((sList[4] == "0") || (sList[4] == "2"))
							{
								if ((s���q�l�R�[�h.Trim() == "") || (s���q�l�R�[�h.Trim().Substring(0,1) == "J"))
								{
									MessageBox.Show("���q�l�R�[�h���Ⴂ�܂��B�u���q�l�R�[�h�擪�F�i�c���q�^���v","���̓`�F�b�N",MessageBoxButtons.OK);
									return false;
								}
							}
						}
					}
					catch (Exception ex)
					{
						tex���b�Z�[�W.Text = ex.Message;
						�r�[�v��();
					}
// MOD 2011.03.08 ���s�j���� ���q�^���Ή��i���q�c�Ə��Ή��j START
				}else{
					// ���q�^���c�Ə��̏ꍇ�A���q�^���p���q�l�R�[�h�����o�^�ł��Ȃ�
					if(gs�Ǘ��ҋ敪 == "4"){
						if(tex���q�l�R�[�h.Text.Trim().Substring(0,1) == "J"){
							MessageBox.Show("���q�l�R�[�h���Ⴂ�܂��B�u���q�l�R�[�h�擪�F�i�c���q�^���v"
											, "���̓`�F�b�N"
											, MessageBoxButtons.OK);
							return false;
						}
					}
// MOD 2011.03.08 ���s�j���� ���q�^���Ή��i���q�c�Ə��Ή��j END
				}

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
			}

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
			//�}�X�^�`�F�b�N�i���q�l�R�[�h�ݒ�ɂ��ă`�F�b�N�v�j
			if (!�X�֌���(tex�\���җX�ւP, tex�\���җX�ւQ, 
				cb�\���Ҍ�, tex�\���ҏZ���P, tex�\���ҏZ���Q, null))
			{
				MessageBox.Show("�X�֔ԍ�(" + tex�\���җX�ւP.Text + tex�\���җX�ւQ.Text + ")�����݂��܂���",
					"���̓`�F�b�N", MessageBoxButtons.OK);
				tex�\���җX�ւP.Focus();
				return(false);
			}
			if (!�X�֌���(tex�ݒu�ꏊ�X�ւP, tex�ݒu�ꏊ�X�ւQ, 
				cb�ݒu�ꏊ��, tex�ݒu�ꏊ�Z���P, tex�ݒu�ꏊ�Z���Q, tex�Ǘ��X����))
			{
				MessageBox.Show("�X�֔ԍ�(" + tex�ݒu�ꏊ�X�ւP.Text + tex�ݒu�ꏊ�X�ւQ.Text + ")�����݂��܂���",
					"���̓`�F�b�N", MessageBoxButtons.OK);
				tex�ݒu�ꏊ�X�ւP.Focus();
				return(false);
			}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END


			if(tex����R�[�h.Text.Length == 0)
			{
				if(s�ݒu�ꏊ�d�b.Length <= 12)
					tex����R�[�h.Text = s�ݒu�ꏊ�d�b;
				else				
					tex����R�[�h.Text = s�ݒu�ꏊ�d�b.Substring(s�ݒu�ꏊ�d�b.Length - 12);
			}
			if(tex���喼.Text.Length == 0)
				tex���喼.Text = tex�ݒu�ꏊ��.Text;
			if(tex���[�U�[�R�[�h.Text.Length == 0)
			{
				if(s�\���ғd�b.Length <= 4)
					tex���[�U�[�R�[�h.Text = s�\���ғd�b;
				else				
					tex���[�U�[�R�[�h.Text = s�\���ғd�b.Substring(s�\���ғd�b.Length - 4);
			}
			if(tex���[�U�[��.Text.Length == 0)
				tex���[�U�[��.Text = tex�ݒu�ꏊ��.Text;
			if(tex�����p�X���[�h.Text.Length == 0)
			{
				tex�����p�X���[�h.Text = �p�X���[�h���s();
			}

			if(!������݃`�F�b�N()) return(false);
			if(!���[�U�[���݃`�F�b�N()) return(false);

// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή� START
			if(gs�Ǘ��ҋ敪 != "1")
			{
				//�Ǘ��Ҍ����ȊO�ł́A�Г��`�[����̎g�p�\�����݂������Ȃ�
				if(tex���q�l�R�[�h.Text.Substring(0,2) == "FK")
				{
					MessageBox.Show("�Ǘ��҈ȊO�̌����ł́A�Г��`�[����̎g�p�\�����݂͂ł��܂���B\n���R�ʉ^�̉c�Ɩ{���ւ��₢���킹�������B"
						, "���̓`�F�b�N"
						, MessageBoxButtons.OK);
					tex���q�l�R�[�h.Focus();
					return(false);
				}
				if(tex����R�[�h.Text.Substring(0,2) == "FK")
				{
					MessageBox.Show("�Ǘ��҈ȊO�̌����ł́A�Г��`�[����̎g�p�\�����݂͂ł��܂���B\n���R�ʉ^�̉c�Ɩ{���ւ��₢���킹�������B"
						, "���̓`�F�b�N"
						, MessageBoxButtons.OK);
					tex����R�[�h.Focus();
					return(false);
				}
			}
// MOD 2016.04.13 BEVAS�j���{ �Г��`�[�Ή� END

			tex���b�Z�[�W.Text = btn�o�^.Text + "���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			return(true);
		}

		private void btn�폜_Click(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W.Text = "";
			tex��t�m�n.Text = tex��t�m�n.Text.Trim();
// MOD 2007.01.19 ���s�j���� �����̕ύX START
			if(!�K�{�`�F�b�N(tex��t�m�n, "��t�m�n")) return;
			if(!���p�`�F�b�N(tex��t�m�n, "��t�m�n")) return;
// MOD 2007.01.19 ���s�j���� �����̕ύX END

			tex��t�m�n.Text = tex��t�m�n.Text.PadLeft(7,'0');

			tex���b�Z�[�W.Text = "�폜���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[4];
				sKey[0] = tex��t�m�n.Text.Trim();
				sKey[1] = s�\���X�V����;
				sKey[2] = gs���p�҃R�[�h;

				string[] sList = sv_maintenance.Del_Mosikomi(gsa���[�U, sKey);
				tex���b�Z�[�W.Text = sList[0];
				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					�o�^���[�h();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� START
//					tex��t�m�n.Focus();
					tex�\���Җ�.Text = " ";
					tex�\���Җ�.Focus();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� END
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX START
					if(gs�X���R�[�h.Trim().Length == 0) tex��t�m�n.Focus();
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX END
				}
				else
				{
					�r�[�v��();
				}
				tex��t�m�n.Focus();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
//				�������[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private bool ������݃`�F�b�N()
		{
			bool Bret = false;
			try
			{
				string[] sKey  = new string[1]{""};
				sKey[0] = tex���q�l�R�[�h.Text.Trim();
				string[] sList = sv_maintenance.Sel_Member(gsa���[�U, sKey);

				if (sList[0].Equals("����I��"))
				{
					tex���q�l�R�[�h.Focus();
					tex���b�Z�[�W.Text = "���͂��ꂽ���q�l�R�[�h�͊��ɓo�^����Ă��܂�";
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
						tex���q�l�R�[�h.Focus();
						tex���b�Z�[�W.Text = sList[0];
						�r�[�v��();
					}
				}
			}
			catch (Exception ex)
			{
				tex���q�l�R�[�h.Focus();
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
			return Bret;
		}

		private bool ���[�U�[���݃`�F�b�N()
		{
			bool Bret = false;
			try
			{
				string[] sKey  = new string[2];
				sKey[0] = tex���q�l�R�[�h.Text.Trim();
				sKey[1] = tex���[�U�[�R�[�h.Text.Trim();
				string[] sList = sv_maintenance.Sel_User(gsa���[�U, sKey);

				if (sList[0].Equals("����I��"))
				{
					tex���[�U�[�R�[�h.Focus();
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
						tex���[�U�[�R�[�h.Focus();
						tex���b�Z�[�W.Text = sList[0];
						�r�[�v��();
					}
				}
			}
			catch (Exception ex)
			{
				tex���[�U�[�R�[�h.Focus();
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
			return Bret;
		}

		private void �N���A()
		{
			tex��t�m�n.Text = " ";
			lab�\����.Text = "";

			tex�\���҃J�i.Text = "";
			tex�\���Җ�.Text = "";
			tex�\���җX�ւP.Text = "";
			tex�\���җX�ւQ.Text = "";
//			cb�\���Ҍ�.Text = "";
			cb�\���Ҍ�.SelectedIndex = 0;
			tex�\���ҏZ���P.Text = "";
			tex�\���ҏZ���Q.Text = "";
			tex�\���ғd�b�P.Text = "";
			tex�\���ғd�b�Q.Text = "";
			tex�\���ғd�b�R.Text = "";
			tex�\���҂e�`�w�P.Text = "";
			tex�\���҂e�`�w�Q.Text = "";
			tex�\���҂e�`�w�R.Text = "";

			chb�ݒu�ꏊ.Checked = false;
			tex�ݒu�ꏊ�J�i.Text = "";
			tex�ݒu�ꏊ��.Text = "";
			tex�ݒu�ꏊ�X�ւP.Text = "";
			tex�ݒu�ꏊ�X�ւQ.Text = "";
			tex�Ǘ��X����.Text = "";
//			cb�ݒu�ꏊ��.Text = "";
			cb�ݒu�ꏊ��.SelectedIndex = 0;
			tex�ݒu�ꏊ�Z���P.Text = "";
			tex�ݒu�ꏊ�Z���Q.Text = "";
			tex�ݒu�ꏊ�d�b�P.Text = "";
			tex�ݒu�ꏊ�d�b�Q.Text = "";
			tex�ݒu�ꏊ�d�b�R.Text = "";
			tex�ݒu�ꏊ�e�`�w�P.Text = "";
			tex�ݒu�ꏊ�e�`�w�Q.Text = "";
			tex�ݒu�ꏊ�e�`�w�R.Text = "";
			tex�ݒu�ꏊ�S���Җ�.Text = "";
			tex�ݒu�ꏊ��E��.Text = "";
			tex�ݒu�ꏊ�g�p��.Text = "";

			tex���q�l�R�[�h.Text = "";
			dtp�g�p�J�n��.Value = DateTime.Now;
			tex����R�[�h.Text = "";
			tex���喼.Text = "";
			num�T�[�}���䐔.Value = 1;
// ADD 2006.11.06 ���s�j���� �x�X�o�^��ʂ̒ǉ� START
			num�T�[�}���䐔.Text = "1";
// ADD 2006.11.06 ���s�j���� �x�X�o�^��ʂ̒ǉ� END
			tex���[�U�[�R�[�h.Text = "";
			tex���[�U�[��.Text = "";
			tex�����p�X���[�h.Text = "";
			rb�o�^��.Checked = true;
			tex����.Text = "";
		}

		private void �����\��()
		{
			tex��t�m�n.Text = "����7���i�A�ԁj";
			lab�\����.Text = "�\����";

			tex�\���҃J�i.Text = "�S�p20";
			tex�\���Җ�.Text = "�S�p20";
			tex�\���җX�ւP.Text = "123";
			tex�\���җX�ւQ.Text = "4567";
			cb�\���Ҍ�.Text = "�S�p4";
			tex�\���ҏZ���P.Text = "�S�p16";
			tex�\���ҏZ���Q.Text = "�S�p20";
			tex�\���ғd�b�P.Text = "123456";
			tex�\���ғd�b�Q.Text = "1234";
			tex�\���ғd�b�R.Text = "1234";
			tex�\���҂e�`�w�P.Text = "123456";
			tex�\���҂e�`�w�Q.Text = "1234";
			tex�\���҂e�`�w�R.Text = "1234";

			chb�ݒu�ꏊ.Checked = false;
			tex�ݒu�ꏊ�J�i.Text = "�S�p20";
			tex�ݒu�ꏊ��.Text = "�S�p20";
			tex�ݒu�ꏊ�X�ւP.Text = "123";
			tex�ݒu�ꏊ�X�ւQ.Text = "4567";
			tex�Ǘ��X����.Text = "�����x�X";
			cb�ݒu�ꏊ��.Text = "�S�p4";
			tex�ݒu�ꏊ�Z���P.Text = "�S�p16";
			tex�ݒu�ꏊ�Z���Q.Text = "�S�p20";
			tex�ݒu�ꏊ�d�b�P.Text = "123456";
			tex�ݒu�ꏊ�d�b�Q.Text = "1234";
			tex�ݒu�ꏊ�d�b�R.Text = "1234";
			tex�ݒu�ꏊ�e�`�w�P.Text = "123456";
			tex�ݒu�ꏊ�e�`�w�Q.Text = "1234";
			tex�ݒu�ꏊ�e�`�w�R.Text = "1234";
			tex�ݒu�ꏊ�S���Җ�.Text = "�S�p10";
			tex�ݒu�ꏊ��E��.Text = "�S�p10";
			tex�ݒu�ꏊ�g�p��.Text = "12,345";

			tex���q�l�R�[�h.Text = "���p10";
			dtp�g�p�J�n��.Value = DateTime.Now;
			tex����R�[�h.Text = "���p12";
			tex���喼.Text = "�S�p20";
			num�T�[�}���䐔.Value = 1;
			tex���[�U�[�R�[�h.Text = "���p6";
			tex���[�U�[��.Text = "�S�p20";
			tex�����p�X���[�h.Text = "���p10";
			rb�o�^��.Checked = true;
			tex����.Text = "�S�p10";
		}

		private void btn���_Click(object sender, System.EventArgs e)
		{
//			�����\��();
			�o�^���[�h();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� START
//			tex��t�m�n.Focus();
			tex�\���Җ�.Text = " ";
			tex�\���Җ�.Focus();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� END
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX START
			if(gs�X���R�[�h.Trim().Length == 0) tex��t�m�n.Focus();
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX END
		}

		private void tex�\���җX�ւQ_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				if(tex�\���җX�ւP.Text.Length == 3 && tex�\���җX�ւQ.Text.Length == 4)
					�X�֌���(tex�\���җX�ւP, tex�\���җX�ւQ, 
						cb�\���Ҍ�, tex�\���ҏZ���P, tex�\���ҏZ���Q, null);
				else{
					�X�ֈꗗ(tex�\���җX�ւP, tex�\���җX�ւQ, 
						cb�\���Ҍ�, tex�\���ҏZ���P, tex�\���ҏZ���Q, null);
				}
			}
		}

		private void tex�\���җX�ւQ_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�\���җX��.Focus();
				�X�ֈꗗ(tex�\���җX�ւP, tex�\���җX�ւQ, 
					cb�\���Ҍ�, tex�\���ҏZ���P, tex�\���ҏZ���Q, null);
				e.Handled = true;
			}
		}

		private void btn�\���җX��_Click(object sender, System.EventArgs e)
		{
			�X�ֈꗗ(tex�\���җX�ւP, tex�\���җX�ւQ, 
				cb�\���Ҍ�, tex�\���ҏZ���P, tex�\���ҏZ���Q, null);
		}

		private void tex�ݒu�ꏊ�X�ւQ_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				if(tex�ݒu�ꏊ�X�ւP.Text.Length == 3 && tex�ݒu�ꏊ�X�ւQ.Text.Length == 4)
					�X�֌���(tex�ݒu�ꏊ�X�ւP, tex�ݒu�ꏊ�X�ւQ, 
						cb�ݒu�ꏊ��, tex�ݒu�ꏊ�Z���P, tex�ݒu�ꏊ�Z���Q, tex�Ǘ��X����);
				else{
					�X�ֈꗗ(tex�ݒu�ꏊ�X�ւP, tex�ݒu�ꏊ�X�ւQ, 
						cb�ݒu�ꏊ��, tex�ݒu�ꏊ�Z���P, tex�ݒu�ꏊ�Z���Q, tex�Ǘ��X����);
				}
			}
		}

		private void btn�ݒu�ꏊ�X��_Click(object sender, System.EventArgs e)
		{
			�X�ֈꗗ(tex�ݒu�ꏊ�X�ւP, tex�ݒu�ꏊ�X�ւQ, 
						cb�ݒu�ꏊ��, tex�ݒu�ꏊ�Z���P, tex�ݒu�ꏊ�Z���Q, tex�Ǘ��X����);
		}

		private void tex�ݒu�ꏊ�X�ւQ_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�ݒu�ꏊ�X��.Focus();
				�X�ֈꗗ(tex�ݒu�ꏊ�X�ւP, tex�ݒu�ꏊ�X�ւQ, 
					cb�ݒu�ꏊ��, tex�ݒu�ꏊ�Z���P, tex�ݒu�ꏊ�Z���Q, tex�Ǘ��X����);
				e.Handled = true;
			}
		}

// DEL 2006.11.06 ���s�j���� �x�X�o�^��ʂ̒ǉ� START
//		private void ���ݒ�(string s�Z��, ComboBox cb��, TextBox tex�Z���P)
//		{
//			//�s���{���n�b�V���e�[�u���̍쐬
//			if(h�� == null)
//			{
//				h�� = new Hashtable();
//				for(int iCnt = 1; iCnt < sa��.Length; iCnt++)
//				{
//					h��.Add(sa��[iCnt], iCnt);
//				}
//			}
//
//			if(s�Z��.Length >= 3)
//			{
//				//�s���{���b�c�̎擾
//				string s�ҏW��     = "";
//				int    iIndex      = 0;
//				// �u�_�ސ쌧�v�A�u�a�̎R���v�A�u���������v�͂S�����ŕ�������r����
//				if((s�Z��[0] == '�_' || s�Z��[0] == '�a' || s�Z��[0] == '��')
//					&& s�Z��.Length >= 4 
//					&& s�Z��[3] == '��')
//				{
//					s�ҏW�� = s�Z��.Substring(0,4);
//					iIndex  = 4;
//				}
//				else
//				{
//					s�ҏW�� = s�Z��.Substring(0,3);
//					iIndex  = 3;
//				}
//				Object obj = h��[s�ҏW��];
//				if(obj != null)
//				{
//					cb��.SelectedIndex = (int)obj;
//					s�Z�� = s�Z��.Remove(0,iIndex);
//					tex�Z���P.Text = s�Z��;
//				}
//			}
//		}
// DEL 2006.11.06 ���s�j���� �x�X�o�^��ʂ̒ǉ� END

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
			g�Z������.s���q�l�b�c = tex���q�l�R�[�h.Text.Trim();
			if (tex���q�l�R�[�h.Text.Trim() == "" )
			{
				//�X�R�[�h���Ǘ��ҋ敪������
				String[] sList;
				string[] sKey2  = new string[1];
				sKey2[0] = gs�X���R�[�h;
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
					�X�֌���(tex�ݒu�ꏊ�X�ւP, tex�ݒu�ꏊ�X�ւQ, 
						cb�ݒu�ꏊ��, tex�ݒu�ꏊ�Z���P, tex�ݒu�ꏊ�Z���Q, tex�X����);
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
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//				sKey[0] = tex�X�֔ԍ��P.Text + tex�X�֔ԍ��Q.Text;
//				string[] sList = sv_maintenance.Sel_Postcode1(gsa���[�U, sKey);
				String[] sList;
				string s���q�l�R�[�h = "";
				s���q�l�R�[�h = tex���q�l�R�[�h.Text;
				if (s���q�l�R�[�h.Trim() == "") 
				{
					if(gs�X���R�[�h.Trim().Length != 0)
					{
						sKey[0] = gs�X���R�[�h;
						sList = sv_oji.Sel_Member(gsa���[�U, sKey);

						if (sList[0].Equals("����I��"))
						{
							if ((sList[4] == "3") || (sList[4] == "4"))
							{
								s���q�l�R�[�h = "J";
							}
						}
					}
				}

				sKey[0] = tex�X�֔ԍ��P.Text + tex�X�֔ԍ��Q.Text;
				if ((s���q�l�R�[�h == "") || (s���q�l�R�[�h.Substring(0,1) != "J"))
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
					s�X���R�[�h = sList[4].Trim();
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

		private string �p�X���[�h���s()
		{
// MOD 2005.06.08 ���s�j�����J �啶���Ȃ� START
//			const string s���� = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
//			const string s���� = "0123456789abcdefghijklmnopqrstuvwxyz";
// MOD 2005.06.08 ���s�j�����J �啶���Ȃ� END
			// l��1�A0��o�͏��O����
			const string s���� = "23456789abcdefghijkmnpqrstuvwxyz";
			string s�p�X���[�h = "";

			Random rdm = new Random();
			int i���� = rdm.Next(0,s����.Length - 1);
			for(int iCnt = 0; iCnt < 6; iCnt++)
			{
				i���� = rdm.Next(0,s����.Length);
				s�p�X���[�h += s����[i����];
			}
			return s�p�X���[�h;
		}

		private void �������_Closed(object sender, System.EventArgs e)
		{
			�N���A();
			tex���b�Z�[�W.Text = "";
			tex��t�m�n.Text = " ";
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� START
//			tex��t�m�n.Focus();
			tex�\���Җ�.Text = " ";
			tex�\���Җ�.Focus();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� END
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX START
			if(gs�X���R�[�h.Trim().Length == 0) tex��t�m�n.Focus();
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX END
		}

		private void btn�������s_Click(object sender, System.EventArgs e)
		{
			// �p�X���[�h�̃N���A
			tex�����p�X���[�h.Text = "";
			tex�����p�X���[�h.Text = �p�X���[�h���s();
		}

		private void btn���q�l�R�[�h_Click(object sender, System.EventArgs e)
		{
			������ꗗ();
		}

		private void ������ꗗ()
		{
			tex���q�l�R�[�h.Text = tex���q�l�R�[�h.Text.Trim();
//			if(!���p�`�F�b�N(tex���q�l�R�[�h, "����R�[�h")) return;

			// ������ʂ��E���ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			if (g������� == null)	 g������� = new �������();
			g�������.Left = this.Left;
			g�������.Top = this.Top;

			// �R�[�h�̏����\��
			g�������.s����R�[�h = "";
			g�������.s����� = "";
//�ۗ� MOD 2007.01.19 ���s�j���� ��ʃ��C�A�E�g�ύX���� START
			g�������.ShowDialog();
//�ۗ� ���X�̉�����I������ѕ\���ł���悤�ɂ���H�i�ڋq�m�F���K�v�j
//			g�������.s�X���R�[�h = gs�X���R�[�h.Trim();
//			g�������.ShowDialog();
//			g�������.s�X���R�[�h = "";
//�ۗ� MOD 2007.01.19 ���s�j���� ��ʃ��C�A�E�g�ύX���� END
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g�������.s����R�[�h.Trim().Length > 0)
			{
				tex���q�l�R�[�h.Text = g�������.s����R�[�h.Trim();
			}
			else
			{
				tex���q�l�R�[�h.Focus();
			}
		}

		private void �ݒu�ꏊ���͐���(CheckBox chbObj, Control texObj1, Control texObj2)
		{
			if (chbObj.Checked)
			{
				texObj1.Text = texObj2.Text.Trim();
				texObj1.Enabled = false;
			}
			else
			{
				//texObj1.Text = "";
				texObj1.Enabled = true;
			}
		}

		private void �ݒu�ꏊ���͐���`�k�k()
		{
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�J�i, tex�\���҃J�i);
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ��, tex�\���Җ�);
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�X�ւP, tex�\���җX�ւP);
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�X�ւQ, tex�\���җX�ւQ);
// ADD 2007.01.20 ���s�j���� ��ʒ��� START
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�X�ւQ, tex�\���җX�ւQ);
			if (chb�ݒu�ꏊ.Checked)
			{
				btn�ݒu�ꏊ�X��.Enabled = false;
				tex�Ǘ��X����.Text = "";
			}
			else
			{
				btn�ݒu�ꏊ�X��.Enabled = true;
			}
// ADD 2007.01.20 ���s�j���� ��ʒ��� END
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, cb�ݒu�ꏊ��, cb�\���Ҍ�);
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�Z���P, tex�\���ҏZ���P);
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�Z���Q, tex�\���ҏZ���Q);
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�d�b�P, tex�\���ғd�b�P);
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�d�b�Q, tex�\���ғd�b�Q);
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�d�b�R, tex�\���ғd�b�R);
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�e�`�w�P, tex�\���҂e�`�w�P);
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�e�`�w�Q, tex�\���҂e�`�w�Q);
			�ݒu�ꏊ���͐���(chb�ݒu�ꏊ, tex�ݒu�ꏊ�e�`�w�R, tex�\���҂e�`�w�R);
		}

		private void chb�ݒu�ꏊ_CheckedChanged(object sender, System.EventArgs e)
		{
			�ݒu�ꏊ���͐���`�k�k();
		}

		private void �������_Activated(object sender, System.EventArgs e)
		{
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� START
//			tex��t�m�n.Focus();
			if(tex��t�m�n.Text.Trim().Length > 0) return;
			if(tex�\���Җ�.Text.Trim().Length > 0) return;
			tex�\���Җ�.Text = " ";
			tex�\���Җ�.Focus();
// MOD 2006.11.30 ���s�j���� ��ʂ̒��� END
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX START
			if(gs�X���R�[�h.Trim().Length == 0) tex��t�m�n.Focus();
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX END
		}

		private void btn�_��_Click(object sender, System.EventArgs e)
		{
// MOD 2006.12.01 ���s�j���� �_�񏑈���̒��� START
			rb�\����.Checked = true;
// MOD 2006.12.01 ���s�j���� �_�񏑈���̒��� END

			if(�o�^�X�V����() != true) return;

// ADD 2006.12.14 ���s�j�����J �Č��� START
			�\����񌟍�();
// ADD 2006.12.14 ���s�j�����J �Č��� END

// ADD 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� START
			tex���b�Z�[�W.Text = "�_�񏑕ҏW��...";
// ADD 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			string[] sList;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = s�X���R�[�h;
				sList = sv_maintenance.Get_ShopInf(gsa���[�U, sKey);
				if (!sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					return;
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				//				�������[�h();
				return;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

			// �܂��̓f�[�^�Z�b�g�̃C���X�^���X�𐶐�
			�_�񏑃f�[�^ ds = new �_�񏑃f�[�^();

			for( int i=0 ; i < 2;i++)
			{
				�_�񏑃f�[�^.table�_��Row tr = (�_�񏑃f�[�^.table�_��Row)ds.table�_��.NewRow();
				tr.BeginEdit();
// ADD 2006.11.09 ���s�j���� �_�񏑈���̒��� START
				if(tex�\���җX�ւP.Text.Trim().Length == 0)
					tr.�\���җX�֔ԍ� = "�@�@�@-" + tex�\���җX�ւQ.Text.Trim();
				else
// ADD 2006.11.09 ���s�j���� �_�񏑈���̒��� END
					tr.�\���җX�֔ԍ� = tex�\���җX�ւP.Text.Trim() + '-' + tex�\���җX�ւQ.Text.Trim();
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� START
//				tr.�\���ҏZ���� = cb�\���Ҍ�.Text.Trim();
//				tr.�\���ҏZ���P = tex�\���ҏZ���P.Text.Trim();
				tr.�\���ҏZ���� = cb�\���Ҍ�.Text.Trim() + ' ' + tex�\���ҏZ���P.Text.Trim();
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� END
				tr.�\���ҏZ���Q = tex�\���ҏZ���Q.Text.Trim();
				tr.�\���Җ��t���K�i = tex�\���҃J�i.Text.Trim();
				tr.�\���Җ�     = tex�\���Җ�.Text.Trim();
				if(tex�\���ғd�b�P.Text.Length == 0)
					tex�\���ғd�b�P.Text = "�@�@�@�@�@";
				if(tex�\���ғd�b�Q.Text.Length == 0)
					tex�\���ғd�b�Q.Text = "�@�@�@�@�@";
				if(tex�\���ғd�b�R.Text.Length == 0)
					tex�\���ғd�b�R.Text = "�@�@�@�@�@";
				tr.�\���ғd�b�ԍ�   = '(' + tex�\���ғd�b�P.Text + ')' + tex�\���ғd�b�Q.Text + '-'  + tex�\���ғd�b�R.Text;
				if(tex�\���҂e�`�w�P.Text.Length == 0)
					tex�\���҂e�`�w�P.Text = "�@�@�@�@�@";
				if(tex�\���҂e�`�w�Q.Text.Length == 0)
					tex�\���҂e�`�w�Q.Text = "�@�@�@�@�@";
				if(tex�\���҂e�`�w�R.Text.Length == 0)
					tex�\���҂e�`�w�R.Text = "�@�@�@�@�@";
				tr.�\���҂e�`�w�ԍ� = '(' + tex�\���҂e�`�w�P.Text + ')' + tex�\���҂e�`�w�Q.Text + '-'  + tex�\���҂e�`�w�R.Text;
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� START
//				tr.��X���X�֔ԍ� = sList[5].Trim();
				string s��X���X�� = sList[5].Trim();
				if(s��X���X��.Length >= 4){
					tr.��X���X�֔ԍ� = s��X���X��.Substring(0,3) + '-' + s��X���X��.Substring(3);
				}else{
					tr.��X���X�֔ԍ� = s��X���X��;
				}
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� END
				if(sList[2].Trim().Length != 0)
				{
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� START
//					tr.��X���Z����   = sList[2].Trim();
//					tr.��X���Z���P   = sList[3].Trim();
					tr.��X���Z����   = sList[2].Trim();
					int i��X���� = int.Parse(sList[2].Trim());
					if(i��X���� > 0 && i��X���� < sa��.Length)
						tr.��X���Z���� = sa��[i��X����];
					tr.��X���Z���� += ' ' + sList[3].Trim();
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� END
					tr.��X���Z���Q   = sList[4].Trim();
				}
				else
				{
					if(sList[3].Trim().Length != 0)
					{
						tr.��X���Z����   = sList[3].Trim();
						tr.��X���Z���P   = sList[4].Trim();
						tr.��X���Z���Q   = "";
					}
					else
					{
						tr.��X���Z����   = sList[4].Trim();
						tr.��X���Z���P   = "";
						tr.��X���Z���Q   = "";
					}
				}

				tr.��X����       = sList[1].Trim();
				tr.��X���d�b�ԍ�   = sList[6].Trim();
// ADD 2006.11.09 ���s�j���� �_�񏑈���̒��� START
				string[] s��X���d�b = sList[6].Trim().Split('-');
				if(s��X���d�b.Length == 3)
					tr.��X���d�b�ԍ� = '(' + s��X���d�b[0] + ')' + s��X���d�b[1] + '-' + s��X���d�b[2];
// ADD 2006.11.09 ���s�j���� �_�񏑈���̒��� END
				tr.��X���e�`�w�ԍ� = sList[7].Trim();
// ADD 2006.11.09 ���s�j���� �_�񏑈���̒��� START
				string[] s��X���e�`�w = sList[7].Trim().Split('-');
				if(s��X���e�`�w.Length == 3)
					tr.��X���e�`�w�ԍ� = '(' + s��X���e�`�w[0] + ')' + s��X���e�`�w[1] + '-' + s��X���e�`�w[2];
// ADD 2006.11.09 ���s�j���� �_�񏑈���̒��� END
				tr.�ݒu�ꏊ�X�֔ԍ� = tex�ݒu�ꏊ�X�ւP.Text.Trim() + '-' + tex�ݒu�ꏊ�X�ւQ.Text.Trim();
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� START
//				tr.�ݒu�ꏊ�Z���� = cb�\���Ҍ�.Text.Trim();
//				tr.�ݒu�ꏊ�Z���P = tex�ݒu�ꏊ�Z���P.Text.Trim();
				tr.�ݒu�ꏊ�Z���� = cb�ݒu�ꏊ��.Text.Trim() + ' ' + tex�ݒu�ꏊ�Z���P.Text.Trim();
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� END
				tr.�ݒu�ꏊ�Z���Q = tex�ݒu�ꏊ�Z���Q.Text.Trim();
				tr.�ݒu�ꏊ�@�l���t���K�i = tex�ݒu�ꏊ�J�i.Text.Trim();
				tr.�ݒu�ꏊ�@�l�� = tex�ݒu�ꏊ��.Text.Trim();
// DEL 2006.12.13 ���s�j�����J �폜 START
//				tr.�ݒu�ꏊ�S���Җ�E = tex�ݒu�ꏊ��E��.Text.Trim();
// DEL 2006.12.13 ���s�j�����J �폜 END
				tr.�ݒu�ꏊ�S���Җ� = tex�ݒu�ꏊ�S���Җ�.Text.Trim();
				if(tex�ݒu�ꏊ�d�b�P.Text.Length == 0)
					tex�ݒu�ꏊ�d�b�P.Text = "�@�@�@�@�@";
				if(tex�ݒu�ꏊ�d�b�Q.Text.Length == 0)
					tex�ݒu�ꏊ�d�b�Q.Text = "�@�@�@�@�@";
				if(tex�ݒu�ꏊ�d�b�R.Text.Length == 0)
					tex�ݒu�ꏊ�d�b�R.Text = "�@�@�@�@�@";
				tr.�ݒu�ꏊ�d�b�ԍ� = '(' + tex�ݒu�ꏊ�d�b�P.Text + ')' + tex�ݒu�ꏊ�d�b�Q.Text + '-'  + tex�ݒu�ꏊ�d�b�R.Text;
				if(tex�ݒu�ꏊ�e�`�w�P.Text.Length == 0)
					tex�ݒu�ꏊ�e�`�w�P.Text = "�@�@�@�@�@";
				if(tex�ݒu�ꏊ�e�`�w�Q.Text.Length == 0)
					tex�ݒu�ꏊ�e�`�w�Q.Text = "�@�@�@�@�@";
				if(tex�ݒu�ꏊ�e�`�w�R.Text.Length == 0)
					tex�ݒu�ꏊ�e�`�w�R.Text = "�@�@�@�@�@";
				tr.�ݒu�ꏊ�e�`�w�ԍ�= '(' + tex�ݒu�ꏊ�e�`�w�P.Text + ')' + tex�ݒu�ꏊ�e�`�w�Q.Text + '-'  + tex�ݒu�ꏊ�e�`�w�R.Text;
				if(i == 0)
// MOD 2006.12.11 FJCS)�K�c ���o���ύX START
// MOD 2006.11.29 FJCS)�K�c ���o���ύX START
//					tr.�Ō��o�� = "�@���R�ʉ^�i�T�j";
//					tr.�Ō��o�� = "�@���R�ʉ^�\�����ݓX�T��";
// MOD 2011.06.21 ���s�j���� ���q�^���Ή� START
//					tr.�Ō��o�� = "�@���R�ʉ^�\�����ݓX�i�T�j";
					if ((tex���q�l�R�[�h.Text == "") || (tex���q�l�R�[�h.Text.Substring(0,1) != "J")){
						tr.�Ō��o�� = "�@���R�ʉ^�\�����ݓX�i�T�j";
					}else{
						tr.�Ō��o�� = "�@���q�^���\�����ݓX�i�T�j";
					}
// MOD 2011.06.21 ���s�j���� ���q�^���Ή� END
// MOD 2006.11.29 FJCS)�K�c ���o���ύX END
// MOD 2006.12.11 FJCS)�K�c ���o���ύX END
				else
					tr.�Ō��o�� = "�A���q�l�i�T�j";
				tr.EndEdit();
				// �Ō�Ƀf�[�^�Z�b�g�ɒǉ�����
				ds.table�_��.Rows.Add(tr);
			}

// MOD 2011.06.21 ���s�j���� ���q�^���Ή� START
//			�_�񏑃��|�[�g cr = new �_�񏑃��|�[�g();
			ReportClass cr = null;
			if ((tex���q�l�R�[�h.Text == "") || (tex���q�l�R�[�h.Text.Substring(0,1) != "J")){
				cr = new �_�񏑃��|�[�g();
			}else{
				cr = new �_�񏑃��|�[�g_���q�^��();
			}
// MOD 2011.06.21 ���s�j���� ���q�^���Ή� END
			//CrystalReport�Ƀp�����[�^�ƃf�[�^�Z�b�g��n��
			cr.SetDataSource(ds);

// ADD 2006.12.06 ���s�j���� �p������ї]���ݒ�̒ǉ� START
			// �p������ї]���ݒ�
			// �i�J���n�ł́Aleft 288�Atop 288�Aright 288�Abottom 279�j
			cr.PrintOptions.PaperSize
				= CrystalDecisions.Shared.PaperSize.PaperA4;
			CrystalDecisions.Shared.PageMargins margins 
				= new CrystalDecisions.Shared.PageMargins(576,576,0,0);
			cr.PrintOptions.ApplyPageMargins(margins);
// ADD 2006.12.06 ���s�j���� �p������ї]���ݒ�̒ǉ� END

// ADD 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� START
			tex���b�Z�[�W.Text = "";
// ADD 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� END

			//�v���r���[�\��
// MOD 2007.02.06 ���s�j���� �v���r���[��ʂ̍����� START
//			�v���r���[��� ��� = new �v���r���[���();
//			���.Left = this.Left;
//			���.Top = this.Top;
//			���.crv���[.PrintReport();
//			���.crv���[.ReportSource = cr;
//			lab�\����.Text = "�\����";
//			rb�\����.Checked = true;
//			���.ShowDialog();
			if(g�v���r�� == null) g�v���r�� = new �v���r���[���();
			g�v���r��.Left = this.Left;
			g�v���r��.Top = this.Top;
//			g�v���r��.crv���[.PrintReport();
			g�v���r��.crv���[.ReportSource = cr;
			lab�\����.Text = "�\����";
			rb�\����.Checked = true;
			g�v���r��.ShowDialog();
// MOD 2007.02.06 ���s�j���� �v���r���[��ʂ̍����� END

// ADD 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� START
			�\�������();
// ADD 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� END
		}

// MOD 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� START
//		private void btn�\����_Click(object sender, System.EventArgs e)
//		{
//// MOD 2006.12.01 ���s�j���� �_�񏑈���̒��� START
//			rb�\����.Checked = true;
//// MOD 2006.12.01 ���s�j���� �_�񏑈���̒��� END
//			if(�o�^�X�V����() != true) return;
//
//// ADD 2006.12.14 ���s�j�����J �Č��� START
//			�\����񌟍�();
//// ADD 2006.12.14 ���s�j�����J �Č��� END
		private void �\�������()
		{
// MOD 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� END
			tex���b�Z�[�W.Text = "�g�p�\�����ҏW��...";

			// �܂��̓f�[�^�Z�b�g�̃C���X�^���X�𐶐�
			�_�񏑃f�[�^ ds = new �_�񏑃f�[�^();

			�_�񏑃f�[�^.table�_��Row tr = (�_�񏑃f�[�^.table�_��Row)ds.table�_��.NewRow();
			tr.BeginEdit();
// ADD 2006.11.09 ���s�j���� �_�񏑈���̒��� START
			if(tex�\���җX�ւP.Text.Trim().Length == 0)
				tr.�\���җX�֔ԍ� = "�@�@�@-" + tex�\���җX�ւQ.Text.Trim();
			else
// ADD 2006.11.09 ���s�j���� �_�񏑈���̒��� END
				tr.�\���җX�֔ԍ� = tex�\���җX�ւP.Text.Trim() + '-' + tex�\���җX�ւQ.Text.Trim();
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� START
//			tr.�\���ҏZ���� = cb�\���Ҍ�.Text.Trim();
//			tr.�\���ҏZ���P = tex�\���ҏZ���P.Text.Trim();
			tr.�\���ҏZ���� = cb�\���Ҍ�.Text.Trim() + ' ' + tex�\���ҏZ���P.Text.Trim();
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� END
			tr.�\���ҏZ���Q = tex�\���ҏZ���Q.Text.Trim();
			tr.�\���Җ��t���K�i = tex�\���҃J�i.Text.Trim();
			tr.�\���Җ�     = tex�\���Җ�.Text.Trim();
			if(tex�\���ғd�b�P.Text.Length == 0)
				tex�\���ғd�b�P.Text = "�@�@�@�@�@";
			if(tex�\���ғd�b�Q.Text.Length == 0)
				tex�\���ғd�b�Q.Text = "�@�@�@�@�@";
			if(tex�\���ғd�b�R.Text.Length == 0)
				tex�\���ғd�b�R.Text = "�@�@�@�@�@";
			tr.�\���ғd�b�ԍ�   = '(' + tex�\���ғd�b�P.Text + ')' + tex�\���ғd�b�Q.Text + '-'  + tex�\���ғd�b�R.Text;
			if(tex�\���҂e�`�w�P.Text.Length == 0)
				tex�\���҂e�`�w�P.Text = "�@�@�@�@�@";
			if(tex�\���҂e�`�w�Q.Text.Length == 0)
				tex�\���҂e�`�w�Q.Text = "�@�@�@�@�@";
			if(tex�\���҂e�`�w�R.Text.Length == 0)
				tex�\���҂e�`�w�R.Text = "�@�@�@�@�@";
			tr.�\���҂e�`�w�ԍ� = '(' + tex�\���҂e�`�w�P.Text + ')' + tex�\���҂e�`�w�Q.Text + '-'  + tex�\���҂e�`�w�R.Text;
			tr.�ݒu�ꏊ�X�֔ԍ� = tex�ݒu�ꏊ�X�ւP.Text.Trim() + '-' + tex�ݒu�ꏊ�X�ւQ.Text.Trim();
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� START
//			tr.�ݒu�ꏊ�Z���� = cb�\���Ҍ�.Text.Trim();
//			tr.�ݒu�ꏊ�Z���P = tex�ݒu�ꏊ�Z���P.Text.Trim();
			tr.�ݒu�ꏊ�Z���� = cb�ݒu�ꏊ��.Text.Trim() + ' ' + tex�ݒu�ꏊ�Z���P.Text.Trim();
// MOD 2006.11.09 ���s�j���� �_�񏑈���̒��� END
			tr.�ݒu�ꏊ�Z���Q = tex�ݒu�ꏊ�Z���Q.Text.Trim();
			tr.�ݒu�ꏊ�@�l���t���K�i = tex�ݒu�ꏊ�J�i.Text.Trim();
			tr.�ݒu�ꏊ�@�l�� = tex�ݒu�ꏊ��.Text.Trim();
// DEL 2007.01.19 ���s�j���� �폜 START
//			tr.�ݒu�ꏊ�S���Җ�E = tex�ݒu�ꏊ��E��.Text.Trim();
// DEL 2007.01.19 ���s�j���� �폜 END
			tr.�ݒu�ꏊ�S���Җ� = tex�ݒu�ꏊ�S���Җ�.Text.Trim();
			if(tex�ݒu�ꏊ�d�b�P.Text.Length == 0)
				tex�ݒu�ꏊ�d�b�P.Text = "�@�@�@�@�@";
			if(tex�ݒu�ꏊ�d�b�Q.Text.Length == 0)
				tex�ݒu�ꏊ�d�b�Q.Text = "�@�@�@�@�@";
			if(tex�ݒu�ꏊ�d�b�R.Text.Length == 0)
				tex�ݒu�ꏊ�d�b�R.Text = "�@�@�@�@�@";
			tr.�ݒu�ꏊ�d�b�ԍ� = '(' + tex�ݒu�ꏊ�d�b�P.Text + ')' + tex�ݒu�ꏊ�d�b�Q.Text + '-'  + tex�ݒu�ꏊ�d�b�R.Text;
			if(tex�ݒu�ꏊ�e�`�w�P.Text.Length == 0)
				tex�ݒu�ꏊ�e�`�w�P.Text = "�@�@�@�@�@";
			if(tex�ݒu�ꏊ�e�`�w�Q.Text.Length == 0)
				tex�ݒu�ꏊ�e�`�w�Q.Text = "�@�@�@�@�@";
			if(tex�ݒu�ꏊ�e�`�w�R.Text.Length == 0)
				tex�ݒu�ꏊ�e�`�w�R.Text = "�@�@�@�@�@";
			tr.�ݒu�ꏊ�e�`�w�ԍ�= '(' + tex�ݒu�ꏊ�e�`�w�P.Text + ')' + tex�ݒu�ꏊ�e�`�w�Q.Text + '-'  + tex�ݒu�ꏊ�e�`�w�R.Text;
// ADD 2006.11.30 FJCS�j�K�c �\���Ǘ��ԍ��̒ǉ� START
			tr.�\���Ǘ��ԍ� = tex��t�m�n.Text.Trim();
			tr.�\���Ǘ��ԍ��o�[�R�[�h = 'a' + tex��t�m�n.Text.Trim() + 'a';
// ADD 2006.11.30 FJCS�j�K�c �\���Ǘ��ԍ��̒ǉ� END
			tr.EndEdit();
			// �Ō�Ƀf�[�^�Z�b�g�ɒǉ�����
			ds.table�_��.Rows.Add(tr);

// MOD 2011.06.21 ���s�j���� ���q�^���Ή� START
//			�g�p�����|�[�g cr = new �g�p�����|�[�g();
			ReportClass cr = null;
			if ((tex���q�l�R�[�h.Text == "") || (tex���q�l�R�[�h.Text.Substring(0,1) != "J")){
				cr = new �g�p�����|�[�g();
			}else{
				cr = new �g�p�����|�[�g_���q�^��();
			}
// MOD 2011.06.21 ���s�j���� ���q�^���Ή� END
			//CrystalReport�Ƀp�����[�^�ƃf�[�^�Z�b�g��n��
			cr.SetDataSource(ds);

// ADD 2006.12.06 ���s�j���� �p������ї]���ݒ�̒ǉ� START
			// �p������ї]���ݒ�
			// �i�J���n�ł́Aleft 288�Atop 288�Aright 288�Abottom 279�j
			cr.PrintOptions.PaperSize
				= CrystalDecisions.Shared.PaperSize.PaperA4;
			CrystalDecisions.Shared.PageMargins margins 
				= new CrystalDecisions.Shared.PageMargins(576,576,0,0);
			cr.PrintOptions.ApplyPageMargins(margins);
// ADD 2006.12.06 ���s�j���� �p������ї]���ݒ�̒ǉ� END

// ADD 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� START
			tex���b�Z�[�W.Text = "";
// ADD 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� END

			//�v���r���[�\��
			�v���r���[��� ��� = new �v���r���[���();
			���.Left = this.Left;
			���.Top = this.Top;
			���.crv���[.PrintReport();
			���.crv���[.ReportSource = cr;
			lab�\����.Text = "�\����";
			rb�\����.Checked = true;
			���.ShowDialog();
		}

		private bool �o�^�X�V����()
		{

			if(�o�^_�`�F�b�N() != true) return(false);
			try
			{
				string[] sData  = new string[43];
				//��t�m�n���
				sData[0] = tex��t�m�n.Text.Trim();
				sData[1] = s�X���R�[�h;
				//�\���ҏ��
				sData[2] = tex�\���҃J�i.Text;
				sData[3] = tex�\���Җ�.Text;
				sData[4] = tex�\���җX�ւP.Text + tex�\���җX�ւQ.Text;
				sData[5] = cb�\���Ҍ�.SelectedIndex.ToString("00");
				sData[6] = tex�\���ҏZ���P.Text;
				sData[7] = tex�\���ҏZ���Q.Text;
				sData[8] = tex�\���ғd�b�P.Text;
				sData[9] = tex�\���ғd�b�Q.Text;
				sData[10] = tex�\���ғd�b�R.Text;
				sData[11] = tex�\���ғd�b�P.Text + tex�\���ғd�b�Q.Text + tex�\���ғd�b�R.Text;
				sData[12] = tex�\���҂e�`�w�P.Text;
				sData[13] = tex�\���҂e�`�w�Q.Text;
				sData[14] = tex�\���҂e�`�w�R.Text;
				//�ݒu�ꏊ���
				if(chb�ݒu�ꏊ.Checked)
					sData[15] = "1";
				else
					sData[15] = " ";
				//				�ݒu�ꏊ���͐���`�k�k();
				sData[16] = tex�ݒu�ꏊ�J�i.Text;
				sData[17] = tex�ݒu�ꏊ��.Text;
				sData[18] = tex�ݒu�ꏊ�X�ւP.Text + tex�ݒu�ꏊ�X�ւQ.Text;
				sData[19] = cb�ݒu�ꏊ��.SelectedIndex.ToString("00");
				sData[20] = tex�ݒu�ꏊ�Z���P.Text;
				sData[21] = tex�ݒu�ꏊ�Z���Q.Text;
				sData[22] = tex�ݒu�ꏊ�d�b�P.Text;
				sData[23] = tex�ݒu�ꏊ�d�b�Q.Text;
				sData[24] = tex�ݒu�ꏊ�d�b�R.Text;
				sData[25] = tex�ݒu�ꏊ�e�`�w�P.Text;
				sData[26] = tex�ݒu�ꏊ�e�`�w�Q.Text;
				sData[27] = tex�ݒu�ꏊ�e�`�w�R.Text;
				sData[28] = tex�ݒu�ꏊ�S���Җ�.Text;
				sData[29] = tex�ݒu�ꏊ��E��.Text;
				sData[30] = tex�ݒu�ꏊ�g�p��.Text.Replace(",","");
				//�V�X�e�����
				sData[31] = tex���q�l�R�[�h.Text;
				sData[32] = dtp�g�p�J�n��.Value.Year.ToString() 
					+ dtp�g�p�J�n��.Value.Month.ToString().PadLeft(2, '0') 
					+ dtp�g�p�J�n��.Value.Day.ToString().PadLeft(2, '0');
				sData[33] = tex����R�[�h.Text;
				sData[34] = tex���喼.Text;
				sData[35] = num�T�[�}���䐔.Value.ToString();
				sData[36] = tex���[�U�[�R�[�h.Text;
				sData[37] = tex���[�U�[��.Text;
				sData[38] = tex�����p�X���[�h.Text;
				//���F��ԏ��
				if(rb�o�^��.Checked) sData[39] = " ";
				else if(rb�\����.Checked) sData[39] = "1";
				else if(rb���ے�.Checked) sData[39] = "2";
				else if(rb���F��.Checked) sData[39] = "3";
				else sData[39] = " ";
				sData[40] = tex����.Text;
				//�X�V���
				sData[41] = s�\���X�V����;
				sData[42] = gs���p�҃R�[�h;

				for(int iCnt = 0; iCnt < sData.Length ; iCnt++)
					if(sData[iCnt].Length ==0) sData[iCnt] = " ";

				string[] sList = new string[1]{""};
				if (btn�o�^.Text.Equals("�o�^"))
				{
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					if ((tex���q�l�R�[�h.Text == "") || (tex���q�l�R�[�h.Text.Substring(0,1) != "J"))
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
						if(sList.Length >= 2 && sList[2] != null)
							tex��t�m�n.Text = sList[2].Trim();
					}
					else
					{
						if(sList.Length >= 2 && sList[2] != null)
							tex��t�m�n.Text = sList[2].Trim();
						�r�[�v��();
						return(false);
					}
				}
				else
				{
					sList = sv_maintenance.Upd_Mosikomi(gsa���[�U, sData);
					tex���b�Z�[�W.Text = sList[0];
// ADD 2007.01.30 ���s�j���� �X�V���Ɏ󒍂m�n���X�V���� START
					if(sList.Length > 2 && sList[2] != null)
						tex��t�m�n.Text = sList[2].Trim();
// ADD 2007.01.30 ���s�j���� �X�V���Ɏ󒍂m�n���X�V���� END
					if (sList[0].Equals("����I��"))
					{
						tex���b�Z�[�W.Text = "";
						//����̍X�V
						s�\���X�V���� = sList[1].Trim();
					}
					else
					{
						�r�[�v��();
						return(false);
					}
				}

				pnl��t�m�n.Enabled = false;
				pnl�\����.Enabled       = true;
				pnl�ݒu�ꏊ.Enabled     = true;
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX START
				if(gs�X���R�[�h.Trim().Length == 0){
					pnl�\����.Enabled       = false;
					pnl�ݒu�ꏊ.Enabled     = false;
				}
// ADD 2007.01.30 ���s�j���� �Ǘ��҂̏ꍇ�̃t�H�[�J�X�̈ʒu�ύX END
				pnl�V�X�e�����.Enabled = true;
				btn�o�^.Text = "�X�V";
				btn�o�^.Enabled = true;
				btn�폜.Enabled = true;
// 2006.10.26 ADD�@FJCS�j�K�c ����n�̃{�^�����g����悤�ɂ��� START
				btn�_��.Enabled = true;
// DEL 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� START
//				btn�\����.Enabled = true;
// DEL 2007.01.19 ���s�j���� �_�񏑁E�\��������{�^���̓��� END
// 2006.10.26 ADD�@FJCS�j�K�c ����n�̃{�^�����g����悤�ɂ��� END
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				return(false);
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return(true);
		}

		private void btn�X�����o�^_Click(object sender, System.EventArgs e)
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			if (g�X����� == null) g�X����� = new �X�����();
			// ��ʂ������ɕ\������
			g�X�����.Left = this.Left;
			g�X�����.Top = this.Top;
			g�X�����.i�A�N�e�B�u�e�f = 1;
			// �R�[�h�̏����\��
			g�X�����.ShowDialog();

			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

// ADD 2007.01.20 ���s�j���� ��ʒ��� START
		private void tex��t�m�n_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				tex��t�m�n.Text = tex��t�m�n.Text.Trim();
				if(tex��t�m�n.Text.Length == 7)
					�\����񌟍�();
				else
					�\�����ꗗ();
			}
		}

		private void tex���q�l�R�[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(btn���q�l�R�[�h.Visible){
				if(e.KeyCode == Keys.Enter)
				{
					tex���b�Z�[�W.Text = "";
					tex���q�l�R�[�h.Text = tex���q�l�R�[�h.Text.Trim();
					if(tex���q�l�R�[�h.Text.Length == 0)
						������ꗗ();
				}
			}
		}

		private void tex���q�l�R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(btn���q�l�R�[�h.Visible){
				if (e.KeyChar.ToString().Equals("*"))
				{
					btn���q�l�R�[�h.Focus();
					������ꗗ();
					e.Handled = true;
				}
			}
		}
// ADD 2007.01.20 ���s�j���� ��ʒ��� END
	}
}
