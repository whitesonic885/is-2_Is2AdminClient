using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using CrystalDecisions.CrystalReports.Engine;

namespace is2AdminClient
{
	/// <summary>
	/// [�o�׏Ɖ�]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// MOD 2007.01.11 ���s�j���� �s����10�s�ɂ��� 
	// DEL 2007.01.11 ���s�j���� �˗���̕K�{�`�F�b�N�̔p�~ 
	// ADD 2007.01.11 ���s�j���� �����ԍ��Ō����������A���q�l���A�˗��喼��\�� 
	// MOD 2007.01.17 ���s�j���� �ꗗ�\�����ڂ̕ύX 
	// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX 
	// MOD 2007.01.22 ���s�j���� �f�t�H���g�l�̕ύX 
	// ADD 2007.01.23 ���s�j���� ��ʂ̒��� 
	// MOD 2007.01.23 ���s�j���� 1000���ȏ�͕\���ł��Ȃ����� 
	// ADD 2007.01.25 ���s�j���� ���q�l�R�[�h�`�F�b�N�̒ǉ� 
	// MOD 2007.01.25 ���s�j���� ���������G���[ 
	// MOD 2007.02.02 ���s�j���� ���b�Z�[�W�ύX 
	// MOD 2007.02.02 ���s�j���� 1000���ȏ�G���[�̃��b�Z�[�W�ύX 
	// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� 
	// MOD 2007.11.13 KCL) �X�{ global�Ή�[��������Q]��ʂɕύX 
	// MOD 2007.11.14 KCL) �X�{ global�Ή� 
	// MOD 2007.11.16 KCL) �X�{ global�Ή� 
	//--------------------------------------------------------------------------
	// MOD 2009.05.11 ���s�j���� ���o�בΉ� 
	// MOD 2009.09.11 ���s�j���� �o�׏Ɖ�ŏo�׍ςe�f,���M�ςe�f�Ȃǂ�ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2010.04.06 ���s�j���� �o�׏Ɖ�ɓ��Ӑ�A�X�֔ԍ��Ȃǂ�ǉ� 
	// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� 
	// MOD 2010.04.30 ���s�j���� �b�r�u�o�͋@�\�̒ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2010.11.19 ���s�j���� �z�����Ȃǂ̎擾 
	// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� 
	// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� 
	//--------------------------------------------------------------------------
	// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� 
	// MOD 2011.05.20 ���s�j���� �b�r�u�o�͌`���̒ǉ� 
	// MOD 2011.05.20 ���s�j���� �o�׏Ɖ���̏�������̉��� 
	// MOD 2011.07.14 ���s�j���� �����\�ȏo�׃f�[�^���Ԃ̖��L
	//--------------------------------------------------------------------------
	// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ�
	// MOD 2014.03.20 BEVAS�j���� �b�r�u�o�͂ɔz�����t�E������ǉ�
	//--------------------------------------------------------------------------
	// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή�
	//--------------------------------------------------------------------------
	public class �o�׏Ɖ� : ���ʃt�H�[��
	{
		public short OldRow = 0;
		private short nSrow = 0;
		private short nErow = 0;
		private short nWork = 0;
		private string s����b�c;
		private string s�˗���b�c;
		private string s�˗��喼;

		private string[] s�o�׈ꗗ;

// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� START
		private string[] sa�s��S
			= {
				  "�s���s","�s��s","���s�s","�]�s�S","���S�s",
				  "�S��s","���S�s","�S�R�s","���s�S","�S��S",
				  "�����s�s","�l���s�s","�����s��s"
			  };
//		private bool gb��� = true;
		// ��������p�f�[�^�Z�b�g
		private �����f�[�^ ds����� = new �����f�[�^();
		private int i����� = 0;
// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� END



		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lab����;
		private System.Windows.Forms.TextBox tex�d�ʍ��v;
		private System.Windows.Forms.TextBox tex�����v;
		private System.Windows.Forms.Label lab�o�^����;
		private System.Windows.Forms.TextBox tex�o�^����;
		private System.Windows.Forms.Label lab�����v;
		private System.Windows.Forms.Label lab�d�ʍ��v;
		private System.Windows.Forms.Label lab�˗���;
		private ���ʃe�L�X�g�{�b�N�X tex�˗���R�[�h;
		private System.Windows.Forms.Label lab���;
		private System.Windows.Forms.TextBox tex�˗��喼;
		private System.Windows.Forms.Label lab���q�l;
		private System.Windows.Forms.Label lab�o�׏Ɖ�^�C�g��;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�˗��匟��;
		private System.Windows.Forms.Button btn�o�׌���;
		private AxGTABLE32V2Lib.AxGTable32 axGT�o�׈ꗗ;
		private System.Windows.Forms.DateTimePicker dt�J�n���t;
		private System.Windows.Forms.DateTimePicker dt�I�����t;
		private System.Windows.Forms.ComboBox cmb���;
		private System.Windows.Forms.ComboBox cmb�o�ד�;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label lab�����ԍ�;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�����ԍ�;
		private System.Windows.Forms.Label lab���q�l��;
		private System.Windows.Forms.TextBox tex�F�؉����;
		private System.Windows.Forms.TextBox tex�F�ؗ��p�Җ�;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn���q�l����;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex���q�l�R�[�h;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tex���q�l��;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmb�폜�敪;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lab�X��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�X��;
		private System.Windows.Forms.CheckBox cb�^�p���̂��q�l�̂�;
		private System.Windows.Forms.Button btn�b�r�u�o��;
		private System.Windows.Forms.TextBox tex�G���g���v;
		private System.Windows.Forms.Label lab�G���g���d�ʌv;
		private System.Windows.Forms.Label lab�o�ד��͈�;
		private System.Windows.Forms.CheckBox cBox�z���r�o��;
		private System.Windows.Forms.Button btn���ѕ\���;
		private System.Windows.Forms.Button btn���x���C���[�W���;
		private System.ComponentModel.IContainer components;

		public �o�׏Ɖ�()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(�o�׏Ɖ�));
			this.panel2 = new System.Windows.Forms.Panel();
			this.tex�G���g���v = new System.Windows.Forms.TextBox();
			this.lab�G���g���d�ʌv = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.axGT�o�׈ꗗ = new AxGTABLE32V2Lib.AxGTable32();
			this.tex�d�ʍ��v = new System.Windows.Forms.TextBox();
			this.tex�����v = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.lab�o�^���� = new System.Windows.Forms.Label();
			this.tex�o�^���� = new System.Windows.Forms.TextBox();
			this.lab�����v = new System.Windows.Forms.Label();
			this.lab�d�ʍ��v = new System.Windows.Forms.Label();
			this.lab�˗��� = new System.Windows.Forms.Label();
			this.btn�˗��匟�� = new System.Windows.Forms.Button();
			this.tex�˗���R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.panel5 = new System.Windows.Forms.Panel();
			this.cBox�z���r�o�� = new System.Windows.Forms.CheckBox();
			this.lab�o�ד��͈� = new System.Windows.Forms.Label();
			this.cb�^�p���̂��q�l�̂� = new System.Windows.Forms.CheckBox();
			this.tex�X�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�X�� = new System.Windows.Forms.Label();
			this.cmb�폜�敪 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tex���q�l�� = new System.Windows.Forms.TextBox();
			this.btn���q�l���� = new System.Windows.Forms.Button();
			this.tex���q�l�R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tex�����ԍ� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�����ԍ� = new System.Windows.Forms.Label();
			this.cmb��� = new System.Windows.Forms.ComboBox();
			this.lab��� = new System.Windows.Forms.Label();
			this.cmb�o�ד� = new System.Windows.Forms.ComboBox();
			this.btn�o�׌��� = new System.Windows.Forms.Button();
			this.tex�˗��喼 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dt�J�n���t = new System.Windows.Forms.DateTimePicker();
			this.dt�I�����t = new System.Windows.Forms.DateTimePicker();
			this.panel6 = new System.Windows.Forms.Panel();
			this.tex�F�ؗ��p�Җ� = new System.Windows.Forms.TextBox();
			this.lab���q�l = new System.Windows.Forms.Label();
			this.lab���q�l�� = new System.Windows.Forms.Label();
			this.tex�F�؉���� = new System.Windows.Forms.TextBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab���� = new System.Windows.Forms.Label();
			this.lab�o�׏Ɖ�^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn���x���C���[�W��� = new System.Windows.Forms.Button();
			this.btn���ѕ\��� = new System.Windows.Forms.Button();
			this.btn�b�r�u�o�� = new System.Windows.Forms.Button();
			this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
			this.btn���� = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.ds�����)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axGT�o�׈ꗗ)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Honeydew;
			this.panel2.Controls.Add(this.tex�G���g���v);
			this.panel2.Controls.Add(this.lab�G���g���d�ʌv);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.axGT�o�׈ꗗ);
			this.panel2.Controls.Add(this.tex�d�ʍ��v);
			this.panel2.Controls.Add(this.tex�����v);
			this.panel2.Controls.Add(this.label21);
			this.panel2.Controls.Add(this.lab�o�^����);
			this.panel2.Controls.Add(this.tex�o�^����);
			this.panel2.Controls.Add(this.lab�����v);
			this.panel2.Controls.Add(this.lab�d�ʍ��v);
			this.panel2.Location = new System.Drawing.Point(0, 6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(764, 344);
			this.panel2.TabIndex = 1;
			// 
			// tex�G���g���v
			// 
			this.tex�G���g���v.BackColor = System.Drawing.SystemColors.Window;
			this.tex�G���g���v.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�G���g���v.Location = new System.Drawing.Point(332, 6);
			this.tex�G���g���v.Name = "tex�G���g���v";
			this.tex�G���g���v.ReadOnly = true;
			this.tex�G���g���v.Size = new System.Drawing.Size(86, 23);
			this.tex�G���g���v.TabIndex = 57;
			this.tex�G���g���v.TabStop = false;
			this.tex�G���g���v.Text = "";
			this.tex�G���g���v.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lab�G���g���d�ʌv
			// 
			this.lab�G���g���d�ʌv.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�G���g���d�ʌv.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�G���g���d�ʌv.ForeColor = System.Drawing.Color.Blue;
			this.lab�G���g���d�ʌv.Location = new System.Drawing.Point(284, 8);
			this.lab�G���g���d�ʌv.Name = "lab�G���g���d�ʌv";
			this.lab�G���g���d�ʌv.Size = new System.Drawing.Size(48, 18);
			this.lab�G���g���d�ʌv.TabIndex = 56;
			this.lab�G���g���d�ʌv.Text = "���،v";
			this.lab�G���g���d�ʌv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(564, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(198, 28);
			this.label5.TabIndex = 55;
			this.label5.Text = "���^���ɂ��Ă͌��[�o�^�f�[�^���x�[�X�ɂ��Ă���܂��B";
			// 
			// axGT�o�׈ꗗ
			// 
			this.axGT�o�׈ꗗ.ContainingControl = this;
			this.axGT�o�׈ꗗ.DataSource = null;
			this.axGT�o�׈ꗗ.Location = new System.Drawing.Point(28, 32);
			this.axGT�o�׈ꗗ.Name = "axGT�o�׈ꗗ";
			this.axGT�o�׈ꗗ.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT�o�׈ꗗ.OcxState")));
			this.axGT�o�׈ꗗ.Size = new System.Drawing.Size(732, 308);
			this.axGT�o�׈ꗗ.TabIndex = 51;
			this.axGT�o�׈ꗗ.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT�o�׈ꗗ_KeyDownEvent);
			this.axGT�o�׈ꗗ.CelClick += new AxGTABLE32V2Lib._DGTable32Events_CelClickEventHandler(this.axGT�o�׈ꗗ_CelClick);
			this.axGT�o�׈ꗗ.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT�o�׈ꗗ_CelDblClick);
			this.axGT�o�׈ꗗ.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT�o�׈ꗗ_CurPlaceChanged);
			// 
			// tex�d�ʍ��v
			// 
			this.tex�d�ʍ��v.BackColor = System.Drawing.SystemColors.Window;
			this.tex�d�ʍ��v.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�d�ʍ��v.Location = new System.Drawing.Point(472, 6);
			this.tex�d�ʍ��v.Name = "tex�d�ʍ��v";
			this.tex�d�ʍ��v.ReadOnly = true;
			this.tex�d�ʍ��v.Size = new System.Drawing.Size(86, 23);
			this.tex�d�ʍ��v.TabIndex = 50;
			this.tex�d�ʍ��v.TabStop = false;
			this.tex�d�ʍ��v.Text = "";
			this.tex�d�ʍ��v.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tex�����v
			// 
			this.tex�����v.BackColor = System.Drawing.SystemColors.Window;
			this.tex�����v.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�����v.Location = new System.Drawing.Point(206, 6);
			this.tex�����v.Name = "tex�����v";
			this.tex�����v.ReadOnly = true;
			this.tex�����v.Size = new System.Drawing.Size(70, 23);
			this.tex�����v.TabIndex = 49;
			this.tex�����v.TabStop = false;
			this.tex�����v.Text = "";
			this.tex�����v.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label21.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.White;
			this.label21.Location = new System.Drawing.Point(0, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(22, 346);
			this.label21.TabIndex = 3;
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab�o�^����
			// 
			this.lab�o�^����.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�o�^����.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab�o�^����.ForeColor = System.Drawing.Color.Blue;
			this.lab�o�^����.Location = new System.Drawing.Point(62, 8);
			this.lab�o�^����.Name = "lab�o�^����";
			this.lab�o�^����.Size = new System.Drawing.Size(34, 18);
			this.lab�o�^����.TabIndex = 4;
			this.lab�o�^����.Text = "����";
			this.lab�o�^����.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tex�o�^����
			// 
			this.tex�o�^����.BackColor = System.Drawing.SystemColors.Window;
			this.tex�o�^����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�o�^����.Location = new System.Drawing.Point(96, 6);
			this.tex�o�^����.Name = "tex�o�^����";
			this.tex�o�^����.ReadOnly = true;
			this.tex�o�^����.Size = new System.Drawing.Size(54, 23);
			this.tex�o�^����.TabIndex = 46;
			this.tex�o�^����.TabStop = false;
			this.tex�o�^����.Text = "";
			this.tex�o�^����.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lab�����v
			// 
			this.lab�����v.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�����v.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab�����v.ForeColor = System.Drawing.Color.Blue;
			this.lab�����v.Location = new System.Drawing.Point(160, 8);
			this.lab�����v.Name = "lab�����v";
			this.lab�����v.Size = new System.Drawing.Size(46, 18);
			this.lab�����v.TabIndex = 6;
			this.lab�����v.Text = "���v";
			this.lab�����v.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab�d�ʍ��v
			// 
			this.lab�d�ʍ��v.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�d�ʍ��v.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab�d�ʍ��v.ForeColor = System.Drawing.Color.Blue;
			this.lab�d�ʍ��v.Location = new System.Drawing.Point(426, 8);
			this.lab�d�ʍ��v.Name = "lab�d�ʍ��v";
			this.lab�d�ʍ��v.Size = new System.Drawing.Size(46, 18);
			this.lab�d�ʍ��v.TabIndex = 8;
			this.lab�d�ʍ��v.Text = "�d�ʌv";
			this.lab�d�ʍ��v.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab�˗���
			// 
			this.lab�˗���.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�˗���.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�˗���.Location = new System.Drawing.Point(12, 30);
			this.lab�˗���.Name = "lab�˗���";
			this.lab�˗���.Size = new System.Drawing.Size(82, 16);
			this.lab�˗���.TabIndex = 8;
			this.lab�˗���.Text = "���˗���";
			// 
			// btn�˗��匟��
			// 
			this.btn�˗��匟��.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�˗��匟��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�˗��匟��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�˗��匟��.ForeColor = System.Drawing.Color.White;
			this.btn�˗��匟��.Location = new System.Drawing.Point(200, 26);
			this.btn�˗��匟��.Name = "btn�˗��匟��";
			this.btn�˗��匟��.Size = new System.Drawing.Size(48, 22);
			this.btn�˗��匟��.TabIndex = 3;
			this.btn�˗��匟��.TabStop = false;
			this.btn�˗��匟��.Text = "����";
			this.btn�˗��匟��.Click += new System.EventHandler(this.btn�˗��匟��_Click);
			// 
			// tex�˗���R�[�h
			// 
			this.tex�˗���R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex�˗���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�˗���R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�˗���R�[�h.Location = new System.Drawing.Point(94, 26);
			this.tex�˗���R�[�h.MaxLength = 12;
			this.tex�˗���R�[�h.Name = "tex�˗���R�[�h";
			this.tex�˗���R�[�h.Size = new System.Drawing.Size(102, 23);
			this.tex�˗���R�[�h.TabIndex = 2;
			this.tex�˗���R�[�h.Text = "123456789012";
			this.tex�˗���R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�˗���R�[�h_KeyDown);
			this.tex�˗���R�[�h.LostFocus += new System.EventHandler(this.tex�˗���R�[�h_LostFocus);
			this.tex�˗���R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�˗���R�[�h_KeyPress);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Honeydew;
			this.panel5.Controls.Add(this.cBox�z���r�o��);
			this.panel5.Controls.Add(this.lab�o�ד��͈�);
			this.panel5.Controls.Add(this.cb�^�p���̂��q�l�̂�);
			this.panel5.Controls.Add(this.tex�X��);
			this.panel5.Controls.Add(this.lab�X��);
			this.panel5.Controls.Add(this.cmb�폜�敪);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.tex���q�l��);
			this.panel5.Controls.Add(this.btn���q�l����);
			this.panel5.Controls.Add(this.tex���q�l�R�[�h);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.tex�����ԍ�);
			this.panel5.Controls.Add(this.lab�����ԍ�);
			this.panel5.Controls.Add(this.cmb���);
			this.panel5.Controls.Add(this.lab���);
			this.panel5.Controls.Add(this.cmb�o�ד�);
			this.panel5.Controls.Add(this.btn�o�׌���);
			this.panel5.Controls.Add(this.tex�˗��喼);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.dt�J�n���t);
			this.panel5.Controls.Add(this.lab�˗���);
			this.panel5.Controls.Add(this.tex�˗���R�[�h);
			this.panel5.Controls.Add(this.btn�˗��匟��);
			this.panel5.Controls.Add(this.dt�I�����t);
			this.panel5.Location = new System.Drawing.Point(2, 8);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(762, 102);
			this.panel5.TabIndex = 0;
			// 
			// cBox�z���r�o��
			// 
			this.cBox�z���r�o��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBox�z���r�o��.ForeColor = System.Drawing.Color.LimeGreen;
			this.cBox�z���r�o��.Location = new System.Drawing.Point(584, 42);
			this.cBox�z���r�o��.Name = "cBox�z���r�o��";
			this.cBox�z���r�o��.Size = new System.Drawing.Size(162, 16);
			this.cBox�z���r�o��.TabIndex = 60;
			this.cBox�z���r�o��.Text = "�z�����t�E������CSV�o��";
			// 
			// lab�o�ד��͈�
			// 
			this.lab�o�ד��͈�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�o�ד��͈�.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�o�ד��͈�.Location = new System.Drawing.Point(644, 60);
			this.lab�o�ד��͈�.Name = "lab�o�ד��͈�";
			this.lab�o�ד��͈�.Size = new System.Drawing.Size(116, 40);
			this.lab�o�ד��͈�.TabIndex = 59;
			this.lab�o�ד��͈�.Text = "���ߋ��P�N�Ԃ̏o�׃f�[�^���Ɖ�\�ł��B";
			// 
			// cb�^�p���̂��q�l�̂�
			// 
			this.cb�^�p���̂��q�l�̂�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cb�^�p���̂��q�l�̂�.ForeColor = System.Drawing.Color.LimeGreen;
			this.cb�^�p���̂��q�l�̂�.Location = new System.Drawing.Point(584, 24);
			this.cb�^�p���̂��q�l�̂�.Name = "cb�^�p���̂��q�l�̂�";
			this.cb�^�p���̂��q�l�̂�.Size = new System.Drawing.Size(152, 16);
			this.cb�^�p���̂��q�l�̂�.TabIndex = 58;
			this.cb�^�p���̂��q�l�̂�.Text = "�^�p���̂��q�l�̂ݑΏ�";
			// 
			// tex�X��
			// 
			this.tex�X��.BackColor = System.Drawing.SystemColors.Window;
			this.tex�X��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�X��.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.tex�X��.Location = new System.Drawing.Point(630, 0);
			this.tex�X��.MaxLength = 3;
			this.tex�X��.Name = "tex�X��";
			this.tex�X��.Size = new System.Drawing.Size(36, 23);
			this.tex�X��.TabIndex = 57;
			this.tex�X��.Text = "123";
			// 
			// lab�X��
			// 
			this.lab�X��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�X��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�X��.Location = new System.Drawing.Point(584, 4);
			this.lab�X��.Name = "lab�X��";
			this.lab�X��.Size = new System.Drawing.Size(46, 16);
			this.lab�X��.TabIndex = 56;
			this.lab�X��.Text = "�X��";
			// 
			// cmb�폜�敪
			// 
			this.cmb�폜�敪.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb�폜�敪.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cmb�폜�敪.Items.AddRange(new object[] {
														 "�S��",
														 "�폜",
														 "�o�ו�"});
			this.cmb�폜�敪.Location = new System.Drawing.Point(482, 78);
			this.cmb�폜�敪.Name = "cmb�폜�敪";
			this.cmb�폜�敪.Size = new System.Drawing.Size(76, 24);
			this.cmb�폜�敪.TabIndex = 55;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(200, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(190, 28);
			this.label4.TabIndex = 54;
			this.label4.Text = "�������ԍ�����͂����ꍇ�́A��L�̌��������͖�������܂��B";
			// 
			// tex���q�l��
			// 
			this.tex���q�l��.BackColor = System.Drawing.Color.Honeydew;
			this.tex���q�l��.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex���q�l��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���q�l��.Location = new System.Drawing.Point(252, 4);
			this.tex���q�l��.Name = "tex���q�l��";
			this.tex���q�l��.ReadOnly = true;
			this.tex���q�l��.Size = new System.Drawing.Size(322, 16);
			this.tex���q�l��.TabIndex = 53;
			this.tex���q�l��.TabStop = false;
			this.tex���q�l��.Text = "����������������������������������������";
			// 
			// btn���q�l����
			// 
			this.btn���q�l����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn���q�l����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn���q�l����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn���q�l����.ForeColor = System.Drawing.Color.White;
			this.btn���q�l����.Location = new System.Drawing.Point(200, 0);
			this.btn���q�l����.Name = "btn���q�l����";
			this.btn���q�l����.Size = new System.Drawing.Size(48, 22);
			this.btn���q�l����.TabIndex = 52;
			this.btn���q�l����.TabStop = false;
			this.btn���q�l����.Text = "����";
			this.btn���q�l����.Click += new System.EventHandler(this.btn���q�l����_Click);
			// 
			// tex���q�l�R�[�h
			// 
			this.tex���q�l�R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex���q�l�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���q�l�R�[�h.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.tex���q�l�R�[�h.Location = new System.Drawing.Point(94, 0);
			this.tex���q�l�R�[�h.MaxLength = 10;
			this.tex���q�l�R�[�h.Name = "tex���q�l�R�[�h";
			this.tex���q�l�R�[�h.Size = new System.Drawing.Size(102, 23);
			this.tex���q�l�R�[�h.TabIndex = 1;
			this.tex���q�l�R�[�h.Text = "1234567890";
			this.tex���q�l�R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex���q�l�R�[�h_KeyDown);
			this.tex���q�l�R�[�h.LostFocus += new System.EventHandler(this.tex���q�l�R�[�h_LostFocus);
			this.tex���q�l�R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex���q�l�R�[�h_KeyPress);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label3.ForeColor = System.Drawing.Color.LimeGreen;
			this.label3.Location = new System.Drawing.Point(12, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 51;
			this.label3.Text = "���q�l";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.LimeGreen;
			this.label2.Location = new System.Drawing.Point(406, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "���";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tex�����ԍ�
			// 
			this.tex�����ԍ�.BackColor = System.Drawing.SystemColors.Window;
			this.tex�����ԍ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�����ԍ�.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�����ԍ�.Location = new System.Drawing.Point(94, 78);
			this.tex�����ԍ�.MaxLength = 11;
			this.tex�����ԍ�.Multiline = true;
			this.tex�����ԍ�.Name = "tex�����ԍ�";
			this.tex�����ԍ�.Size = new System.Drawing.Size(102, 23);
			this.tex�����ԍ�.TabIndex = 15;
			this.tex�����ԍ�.Text = "12345678901";
			// 
			// lab�����ԍ�
			// 
			this.lab�����ԍ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�����ԍ�.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�����ԍ�.Location = new System.Drawing.Point(12, 82);
			this.lab�����ԍ�.Name = "lab�����ԍ�";
			this.lab�����ԍ�.Size = new System.Drawing.Size(82, 16);
			this.lab�����ԍ�.TabIndex = 14;
			this.lab�����ԍ�.Text = "�����ԍ�";
			// 
			// cmb���
			// 
			this.cmb���.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb���.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cmb���.Location = new System.Drawing.Point(482, 52);
			this.cmb���.Name = "cmb���";
			this.cmb���.Size = new System.Drawing.Size(76, 24);
			this.cmb���.TabIndex = 6;
			this.cmb���.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb���_KeyDown);
			// 
			// lab���
			// 
			this.lab���.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���.Location = new System.Drawing.Point(406, 56);
			this.lab���.Name = "lab���";
			this.lab���.Size = new System.Drawing.Size(76, 16);
			this.lab���.TabIndex = 13;
			this.lab���.Text = "�A����";
			// 
			// cmb�o�ד�
			// 
			this.cmb�o�ד�.BackColor = System.Drawing.Color.White;
			this.cmb�o�ד�.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb�o�ד�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cmb�o�ד�.ForeColor = System.Drawing.Color.LimeGreen;
			this.cmb�o�ד�.Items.AddRange(new object[] {
														"�o�ד�",
														"�o�^��"});
			this.cmb�o�ד�.Location = new System.Drawing.Point(12, 52);
			this.cmb�o�ד�.Name = "cmb�o�ד�";
			this.cmb�o�ד�.Size = new System.Drawing.Size(80, 24);
			this.cmb�o�ד�.TabIndex = 4;
			// 
			// btn�o�׌���
			// 
			this.btn�o�׌���.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�o�׌���.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�o�׌���.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�o�׌���.ForeColor = System.Drawing.Color.White;
			this.btn�o�׌���.Location = new System.Drawing.Point(564, 60);
			this.btn�o�׌���.Name = "btn�o�׌���";
			this.btn�o�׌���.Size = new System.Drawing.Size(74, 36);
			this.btn�o�׌���.TabIndex = 7;
			this.btn�o�׌���.TabStop = false;
			this.btn�o�׌���.Text = "�Ɖ�";
			this.btn�o�׌���.Click += new System.EventHandler(this.btn�o�׌���_Click);
			// 
			// tex�˗��喼
			// 
			this.tex�˗��喼.BackColor = System.Drawing.Color.Honeydew;
			this.tex�˗��喼.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�˗��喼.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�˗��喼.Location = new System.Drawing.Point(252, 30);
			this.tex�˗��喼.Name = "tex�˗��喼";
			this.tex�˗��喼.ReadOnly = true;
			this.tex�˗��喼.Size = new System.Drawing.Size(322, 16);
			this.tex�˗��喼.TabIndex = 12;
			this.tex�˗��喼.TabStop = false;
			this.tex�˗��喼.Text = "����������������������������������������";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.LimeGreen;
			this.label1.Location = new System.Drawing.Point(240, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "�`";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dt�J�n���t
			// 
			this.dt�J�n���t.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt�J�n���t.Location = new System.Drawing.Point(94, 52);
			this.dt�J�n���t.Name = "dt�J�n���t";
			this.dt�J�n���t.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt�J�n���t.Size = new System.Drawing.Size(144, 23);
			this.dt�J�n���t.TabIndex = 4;
			// 
			// dt�I�����t
			// 
			this.dt�I�����t.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt�I�����t.Location = new System.Drawing.Point(260, 52);
			this.dt�I�����t.Name = "dt�I�����t";
			this.dt�I�����t.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt�I�����t.Size = new System.Drawing.Size(144, 23);
			this.dt�I�����t.TabIndex = 5;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Controls.Add(this.tex�F�ؗ��p�Җ�);
			this.panel6.Controls.Add(this.lab���q�l);
			this.panel6.Controls.Add(this.lab���q�l��);
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
			this.tex�F�ؗ��p�Җ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�F�ؗ��p�Җ�.ForeColor = System.Drawing.Color.LimeGreen;
			this.tex�F�ؗ��p�Җ�.Location = new System.Drawing.Point(470, 5);
			this.tex�F�ؗ��p�Җ�.Name = "tex�F�ؗ��p�Җ�";
			this.tex�F�ؗ��p�Җ�.ReadOnly = true;
			this.tex�F�ؗ��p�Җ�.Size = new System.Drawing.Size(322, 16);
			this.tex�F�ؗ��p�Җ�.TabIndex = 12;
			this.tex�F�ؗ��p�Җ�.TabStop = false;
			this.tex�F�ؗ��p�Җ�.Text = "����������������������������������������";
			this.tex�F�ؗ��p�Җ�.Visible = false;
			// 
			// lab���q�l
			// 
			this.lab���q�l.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���q�l.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���q�l.Location = new System.Drawing.Point(418, 7);
			this.lab���q�l.Name = "lab���q�l";
			this.lab���q�l.Size = new System.Drawing.Size(52, 14);
			this.lab���q�l.TabIndex = 11;
			this.lab���q�l.Text = "���[�U�[";
			this.lab���q�l.Visible = false;
			// 
			// lab���q�l��
			// 
			this.lab���q�l��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���q�l��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���q�l��.Location = new System.Drawing.Point(14, 8);
			this.lab���q�l��.Name = "lab���q�l��";
			this.lab���q�l��.Size = new System.Drawing.Size(58, 14);
			this.lab���q�l��.TabIndex = 10;
			this.lab���q�l��.Text = "���q�l��";
			// 
			// tex�F�؉����
			// 
			this.tex�F�؉����.BackColor = System.Drawing.Color.PaleGreen;
			this.tex�F�؉����.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�F�؉����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�F�؉����.ForeColor = System.Drawing.Color.LimeGreen;
			this.tex�F�؉����.Location = new System.Drawing.Point(78, 6);
			this.tex�F�؉����.Name = "tex�F�؉����";
			this.tex�F�؉����.ReadOnly = true;
			this.tex�F�؉����.Size = new System.Drawing.Size(330, 16);
			this.tex�F�؉����.TabIndex = 8;
			this.tex�F�؉����.TabStop = false;
			this.tex�F�؉����.Text = "999 �����x�X";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab����);
			this.panel7.Controls.Add(this.lab�o�׏Ɖ�^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(792, 26);
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
			// lab�o�׏Ɖ�^�C�g��
			// 
			this.lab�o�׏Ɖ�^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�o�׏Ɖ�^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�o�׏Ɖ�^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab�o�׏Ɖ�^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab�o�׏Ɖ�^�C�g��.Name = "lab�o�׏Ɖ�^�C�g��";
			this.lab�o�׏Ɖ�^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab�o�׏Ɖ�^�C�g��.TabIndex = 0;
			this.lab�o�׏Ɖ�^�C�g��.Text = "�o�׏Ɖ�";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btn���x���C���[�W���);
			this.panel8.Controls.Add(this.btn���ѕ\���);
			this.panel8.Controls.Add(this.btn�b�r�u�o��);
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 2;
			// 
			// btn���x���C���[�W���
			// 
			this.btn���x���C���[�W���.ForeColor = System.Drawing.Color.Blue;
			this.btn���x���C���[�W���.Location = new System.Drawing.Point(260, 6);
			this.btn���x���C���[�W���.Name = "btn���x���C���[�W���";
			this.btn���x���C���[�W���.Size = new System.Drawing.Size(60, 48);
			this.btn���x���C���[�W���.TabIndex = 8;
			this.btn���x���C���[�W���.Text = "�C���[�W�@�@���";
			this.btn���x���C���[�W���.Click += new System.EventHandler(this.btn���x���C���[�W���_Click);
			// 
			// btn���ѕ\���
			// 
			this.btn���ѕ\���.ForeColor = System.Drawing.Color.Blue;
			this.btn���ѕ\���.Location = new System.Drawing.Point(168, 6);
			this.btn���ѕ\���.Name = "btn���ѕ\���";
			this.btn���ѕ\���.Size = new System.Drawing.Size(60, 48);
			this.btn���ѕ\���.TabIndex = 7;
			this.btn���ѕ\���.Text = "���ѕ\�@�@���";
			this.btn���ѕ\���.Click += new System.EventHandler(this.btn���ѕ\���_Click);
			// 
			// btn�b�r�u�o��
			// 
			this.btn�b�r�u�o��.ForeColor = System.Drawing.Color.Blue;
			this.btn�b�r�u�o��.Location = new System.Drawing.Point(352, 6);
			this.btn�b�r�u�o��.Name = "btn�b�r�u�o��";
			this.btn�b�r�u�o��.Size = new System.Drawing.Size(60, 48);
			this.btn�b�r�u�o��.TabIndex = 6;
			this.btn�b�r�u�o��.Text = "�b�r�u�@�@�o��";
			this.btn�b�r�u�o��.Click += new System.EventHandler(this.btn�b�r�u�o��_Click);
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(446, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(344, 50);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.groupBox1.ForeColor = System.Drawing.Color.Green;
			this.groupBox1.Location = new System.Drawing.Point(16, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(768, 114);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel2);
			this.groupBox2.Location = new System.Drawing.Point(16, 162);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(768, 352);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// �o�׏Ɖ�
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(792, 580);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "�o�׏Ɖ�";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 �o�׏Ɖ�";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.�o�׏Ɖ�_Closed);
			((System.ComponentModel.ISupportInitialize)(this.ds�����)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axGT�o�׈ꗗ)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
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
			// �w�b�_�[���ڂ̐ݒ�
			tex�F�؉����.Text = gs�����;
			tex�F�ؗ��p�Җ�.Text = gs���p�Җ�;
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
			cb�^�p���̂��q�l�̂�.Checked = true;
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END

			// �����̏����ݒ�
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;
			// �R���{�̏����l�ݒ�
			cmb�o�ד�.SelectedIndex = 0;
			cmb���.Items.Clear();
			cmb���.Items.AddRange(gsa��Ԗ�);
			cmb���.SelectedIndex = 0;

			// �o�ד��̏����ݒ�i�����j
			dt�J�n���t.Value   = DateTime.Now;
			dt�I�����t.Value   = DateTime.Now;
//			����o�ד����X�V();
//			dt�J�n���t.Value   = gdt�o�ד�;
//			dt�I�����t.Value   = gdt�o�ד�;

// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
			// �Ǘ��҉���̏ꍇ�A�X���b�c��I����
			if(gs�Ǘ��ҋ敪.Equals("1")){
				lab�X��.Visible = true;
				tex�X��.Visible = true;
			}else{
				lab�X��.Visible = false;
				tex�X��.Visible = false;
			}
			tex�X��.Text = gs�X���R�[�h;
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
// MOD 2014.03.20 BEVAS�j���� �b�r�u�o�͂ɔz�����t�E������ǉ� START
			cBox�z���r�o��.Visible = true;
			cBox�z���r�o��.Checked = false;
// MOD 2014.03.20 BEVAS�j���� �b�r�u�o�͂ɔz�����t�E������ǉ� END
// MOD 2007.06.12 ���s�j���� �F�s�{�Ȃǂ̑Ή� START
			���ڏ�����();

// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� START
			// �����\���̏ꍇ�A���x���C���[�W����{�^���͗��p�s��
			btn���x���C���[�W���.Enabled = false;
// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� END

// MOD 2009.09.11 ���s�j���� �o�׏Ɖ�ŏo�׍ςe�f,���M�ςe�f�Ȃǂ�ǉ� START
//// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START
////			axGT�o�׈ꗗ.Cols = 16;
//			axGT�o�׈ꗗ.Cols = 18;
//// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END
// MOD 2010.04.06 ���s�j���� �o�׏Ɖ�ɓ��Ӑ�A�X�֔ԍ��Ȃǂ�ǉ� START
//			axGT�o�׈ꗗ.Cols = 24;
// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� START
//			axGT�o�׈ꗗ.Cols = 34;
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
//			axGT�o�׈ꗗ.Cols = 38;
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� START
//			axGT�o�׈ꗗ.Cols = 39;
			axGT�o�׈ꗗ.Cols = 40;
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� END
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� END
// MOD 2010.04.06 ���s�j���� �o�׏Ɖ�ɓ��Ӑ�A�X�֔ԍ��Ȃǂ�ǉ� END
// MOD 2009.09.11 ���s�j���� �o�׏Ɖ�ŏo�׍ςe�f,���M�ςe�f�Ȃǂ�ǉ� END
// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� START

// MOD 2007.01.11 ���s�j���� �s����10�s�ɂ��� START
//			axGT�o�׈ꗗ.Rows = 7;
			axGT�o�׈ꗗ.Rows = 10;
// MOD 2007.01.11 ���s�j���� �s����10�s�ɂ��� END
			axGT�o�׈ꗗ.ColSep = "|";

// MOD 2009.09.11 ���s�j���� �o�׏Ɖ�ŏo�׍ςe�f,���M�ςe�f�Ȃǂ�ǉ� START
//// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START
////			axGT�o�׈ꗗ.set_RowsText(0, "|�o�ד�|���͂���|��|�d��|�ی����i���~�j|�^���i���~�j|�A�����i�^�L���E�i��|�����ԍ�|�w���|�A����|�o�^��|���q�l�ԍ�|�W���[�i���m�n|��|�o��|�o�^��|");//
////			axGT�o�׈ꗗ.ColsWidth =    "0|4|17|4|4.5|6|6|12|7|6|6.5|5|17|0|0|0|0|";
////			axGT�o�׈ꗗ.ColsAlignHorz = "1|1|0|2|2|2|2|0|0|1|1|1|0|0|0|0|0|";
//			axGT�o�׈ꗗ.set_RowsText(0, "||����|�o�ד�|���͂���|��|�d��|�����ԍ�|���q�l�ԍ�|�w���|�A����|�A�����i�^�L���E�i��|�^��|�ی���|�o�^��|�W���[�i���m�n|��|�o��|�o�^��|");
////			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|1.4|4|17|4|4.5|7|17|6|6.5|12|6|6|5|0|0|0|0|";
////			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.2|3|3.6|6.5|8.5|5.3|4.8|12.8|6|6|5|0|0|0|0|";
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|";
//			axGT�o�׈ꗗ.ColsAlignHorz = "1|1|1|1|0|2|2|0|0|1|1|0|2|2|1|0|0|0|0|";
//// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END
// MOD 2010.04.06 ���s�j���� �o�׏Ɖ�ɓ��Ӑ�A�X�֔ԍ��Ȃǂ�ǉ� START
//			axGT�o�׈ꗗ.set_RowsText(0, "||����|�o�ד�|���͂���|��|�d��|�����ԍ�|���q�l�ԍ�|�w���|�A����|�A�����i�^�L���E�i��|�^��|�ی���|�o�^��|�W���[�i���m�n|��|�o��|�o�^��|||||||");
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|";
//			axGT�o�׈ꗗ.ColsAlignHorz = "1|1|1|1|0|2|2|0|0|1|1|0|2|2|1|0|0|0|0|0|0|0|0|0|0|";
// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� START
//			axGT�o�׈ꗗ.set_RowsText(0, "||����|�o�ד�|���͂���|��|�d��|�����ԍ�|���q�l�ԍ�|�w���|�A����|�A�����i�^�L���E�i��|�^��|�ی���|�o�^��|�W���[�i���m�n|��|�o��|�o�^��|||||||||||||||||");
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
//			axGT�o�׈ꗗ.ColsAlignHorz = "1|1|1|1|0|2|2|0|0|1|1|0|2|2|1|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
//			axGT�o�׈ꗗ.set_RowsText(0, "||����|�o�ד�|���͂���|��|�d��|�����ԍ�|���q�l�ԍ�|�w���|�A����|"
//										+"�A�����i�^�L���E�i��|�^��|�ی���|�o�^��|"
//										+"�W���[�i���m�n|��|�o��|�o�^��|||||||||||||||||||||");
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
//			axGT�o�׈ꗗ.ColsAlignHorz = "1|1|1|1|0|2|2|0|0|1|1|"
//										+"0|2|2|1|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� START
//			axGT�o�׈ꗗ.set_RowsText(0, "||����|�o�ד�|���͂���|��|����|�d��|�����ԍ�|���q�l�ԍ�|�w���|�A����|"
//										+"�A�����i�^�L���E�i��|�^��|�ی���|�o�^��|"
//										+"�W���[�i���m�n|��|�o��|�o�^��|||||||||||||||||||||");
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
//			axGT�o�׈ꗗ.ColsAlignHorz = "1|1|1|1|0|2|2|2|0|0|1|1|"
//										+"0|2|2|1|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
			axGT�o�׈ꗗ.set_RowsText(0, "||����|�o�ד�|���͂���|��|����|�d��|�����ԍ�|���q�l�ԍ�|�w���|�A����|"
										+"�z�����t�E����|�A�����i�^�L���E�i��|�^��|�ی���|�o�^��|"
										+"�W���[�i���m�n|��|�o��|�o�^��|||||||||||||||||||||");
			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
										+"8.0|13.0|5.7|5.7|3.8|"
										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
			axGT�o�׈ꗗ.ColsAlignHorz = "1|1|1|1|0|2|2|2|0|0|1|1|"
										+"1|0|2|2|1|"
										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� END
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� END
// MOD 2010.04.06 ���s�j���� �o�׏Ɖ�ɓ��Ӑ�A�X�֔ԍ��Ȃǂ�ǉ� END
// MOD 2009.09.11 ���s�j���� �o�׏Ɖ�ŏo�׍ςe�f,���M�ςe�f�Ȃǂ�ǉ� END
// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� START
// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� END

			axGT�o�׈ꗗ.set_CelForeColor(axGT�o�׈ꗗ.CaretRow,0,0x98FB98);  //BGR
			axGT�o�׈ꗗ.set_CelBackColor(axGT�o�׈ꗗ.CaretRow,0,0x006000);

			for(short i = 1; i <= axGT�o�׈ꗗ.Rows; i++ )
			{
				axGT�o�׈ꗗ.set_CelHeight(i,0,2.3);
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START
//				axGT�o�׈ꗗ.set_CelAlignVert(i,2,3);
//				axGT�o�׈ꗗ.set_CelAlignVert(i,7,3);
//				axGT�o�׈ꗗ.set_CelAlignVert(i,8,3);
				axGT�o�׈ꗗ.set_CelAlignVert(i,4,3);
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
//				axGT�o�׈ꗗ.set_CelAlignVert(i,7,3);
//				axGT�o�׈ꗗ.set_CelAlignVert(i,11,3);
				axGT�o�׈ꗗ.set_CelAlignVert(i,8,3);
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� START
//				axGT�o�׈ꗗ.set_CelAlignVert(i,12,3);
				axGT�o�׈ꗗ.set_CelAlignVert(i,13,3);
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� END
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END
			}

			s����b�c = "";
			s�˗���b�c = "";
			s�˗��喼 = "";
		}

		private void ���ڏ�����()
		{
			tex���q�l�R�[�h.Text = "";
			tex���q�l��.Text     = "";
			tex�˗���R�[�h.Text = "";
			tex�˗��喼.Text     = "";
			tex�����ԍ�.Text   = "";
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START
//			rb�o�ו�.Checked = true;
// MOD 2007.01.22 ���s�j���� �f�t�H���g�l�̕ύX START
//			cmb�폜�敪.SelectedIndex = 2;
			cmb�폜�敪.SelectedIndex = 0;
// MOD 2007.01.22 ���s�j���� �f�t�H���g�l�̕ύX END
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END
			tex�o�^����.Text     = "";
			tex�����v.Text     = "";
			tex�d�ʍ��v.Text     = "";
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
			tex�G���g���v.Text = "";
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END

			tex���b�Z�[�W.Text   = "";
			axGT�o�׈ꗗ.Clear();
// MOD 2009.09.11 ���s�j���� �o�׏Ɖ�ŏo�׍ςe�f,���M�ςe�f�Ȃǂ�ǉ� START
//// ADD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START
////			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.2|3|3.6|6.5|8.5|5.3|4.8|12.8|6|6|5|0|0|0|0|";
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|";
//// ADD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END
// MOD 2010.04.06 ���s�j���� �o�׏Ɖ�ɓ��Ӑ�A�X�֔ԍ��Ȃǂ�ǉ� START
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|";
// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� END
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� START
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
										+"8.0|13.0|5.7|5.7|3.8|"
										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� END
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� END
// MOD 2010.04.06 ���s�j���� �o�׏Ɖ�ɓ��Ӑ�A�X�֔ԍ��Ȃǂ�ǉ� END
// MOD 2009.09.11 ���s�j���� �o�׏Ɖ�ŏo�׍ςe�f,���M�ςe�f�Ȃǂ�ǉ� END
			axGT�o�׈ꗗ.CaretRow = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT�o�׈ꗗ.CaretCol = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
			axGT�o�׈ꗗ_CurPlaceChanged(null,null);

//			�����\��();
		}

// ADD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START
		private void �����\��()
		{
			tex���q�l�R�[�h.Text = "1234567890";
//			tex���q�l��.Text     = "����������������������������������������";
			tex���q�l��.Text     = "���q�l���T�U�V�W�X�O�P�Q�R�S�T�U�V�W�X�O";
			tex�˗���R�[�h.Text = "123456789012";
//			tex�˗��喼.Text     = "����������������������������������������";
			tex�˗��喼.Text     = "���˗��喼�U�V�W�X�O�P�Q�R�S�T�U�V�W�X�O";
			tex�����ԍ�.Text   = "12345678901";
			tex�o�^����.Text     = "5,000";
			tex�����v.Text     = "999,999";
			tex�d�ʍ��v.Text     = "99,999,999";
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
			tex�G���g���v.Text = "99,999,999";
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END

			axGT�o�׈ꗗ.Clear();
			axGT�o�׈ꗗ.set_RowsText(1,
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� START
//			 "|��|��|10/25|���͂���Z���P�Q�X�O�P�Q�R�S�T�U�V�W�X�O\r\n���͂��於�O�P�Q�X�O�P�Q�R�S�T�U�V�W�X�O|999|99,999|12345678901\r\n����|OKYAKU789012345|10/27�K��|�����s|�P�O�d�w�o�q�d�r�r\r\n�L���P�Q�T�U�V�W�X�O�P�Q�R�S�T|9,999|0|01/16|J1|1|20061025|test|");
			 "|��|��|10/25|���͂���Z���P�Q�X�O�P�Q�R�S�T�U�V�W�X�O\r\n���͂��於�O�P�Q�X�O�P�Q�R�S�T�U�V�W�X�O|999|99,999|12345678901\r\n����|OKYAKU789012345|10/27�K��|�����s|2014/10/27 13:00|�P�O�d�w�o�q�d�r�r\r\n�L���P�Q�T�U�V�W�X�O�P�Q�R�S�T|9,999|0|01/16|J1|1|20061025|test|");
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� END
//			axGT�o�׈ꗗ.set_RowsText(2,
//			 "|��|��|10/25|����������������������������������������\r\n����������������������������������������|999|99,999|12345678901\r\n����|OKYAKU789012345|10/27�K��|�����s|�P�O�d�w�o�q�d�r�r\r\n�L���P�Q�T�U�V�W�X�O�P�Q�R�S�T|9,999|0|01/16|J1|1|20061025|test|");
		}
// ADD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END

		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn�˗��匟��_Click(object sender, System.EventArgs e)
		{
// ADD 2007.01.25 ���s�j���� ���q�l�R�[�h�`�F�b�N�̒ǉ� START
			tex���q�l�R�[�h.Text = tex���q�l�R�[�h.Text.Trim();
			if(!�K�{�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;
			if(!���p�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;
// ADD 2007.01.25 ���s�j���� ���q�l�R�[�h�`�F�b�N�̒ǉ� END

// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
			tex�X��.Text = tex�X��.Text.Trim();
			if(!gs�Ǘ��ҋ敪.Equals("1")){
				if(!�K�{�`�F�b�N(tex�X��,"�X���R�[�h")) return;
			}
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END

			tex�˗���R�[�h.Text = tex�˗���R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�˗���R�[�h,"�˗���R�[�h")) return;

// MOD 2007.11.14 KCL) �X�{ global�Ή� START
//			if (g�˗����� == null)	 g�˗����� = new ���˗��匟��();
//			g�˗�����.Left = this.Left;
//			g�˗�����.Top = this.Top;
//
//			g�˗�����.sKcode = tex���q�l�R�[�h.Text;
//			g�˗�����.sIcode = tex�˗���R�[�h.Text;
//			g�˗�����.ShowDialog();
//
//			if(g�˗�����.sIcode.Trim().Length != 0)
//			{
//				tex���q�l�R�[�h.Text = g�˗�����.sKcode;
//				tex���q�l��.Text = g�˗�����.sKname;
//				s����b�c   = g�˗�����.sBcode;
//				s�˗���b�c = g�˗�����.sIcode;
//				s�˗��喼   = g�˗�����.sIname;
			if (g�˗����Q == null)	 g�˗����Q = new ���˗��匟���Q();
			g�˗����Q.Left = this.Left;
			g�˗����Q.Top = this.Top;

			g�˗����Q.sKcode = tex���q�l�R�[�h.Text;
			g�˗����Q.sIcode = tex�˗���R�[�h.Text;
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
			g�˗����Q.s�X���R�[�h = tex�X��.Text;
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
			g�˗����Q.ShowDialog();

			if(g�˗����Q.sIcode.Trim().Length != 0)
			{
				tex���q�l�R�[�h.Text = g�˗����Q.sKcode;
				tex���q�l��.Text = g�˗����Q.sKname;
				s����b�c   = g�˗����Q.sBcode;
				s�˗���b�c = g�˗����Q.sIcode;
				s�˗��喼   = g�˗����Q.sIname;
// MOD 2007.11.14 KCL) �X�{ global�Ή� END
				if(s�˗���b�c.Length != 0)
				{
					tex�˗���R�[�h.Text = s�˗���b�c;
					tex�˗��喼.Text     = s�˗��喼;
					cmb�o�ד�.Focus();
				}
				else
				{
					tex�˗���R�[�h.Focus();
				}
			}
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
		}

		private void axGT�o�׈ꗗ_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT�o�׈ꗗ.set_CelForeColor(OldRow,0,0);
			axGT�o�׈ꗗ.set_CelBackColor(OldRow,0,0xFFFFFF);
			if(axGT�o�׈ꗗ.SelStartRow == axGT�o�׈ꗗ.SelEndRow)
			{
				if(nSrow > nErow)
				{
					nWork = nSrow;
					nSrow = nErow;
					nErow = nWork;
				}
				for(short nCnt = nSrow; nCnt <= nErow; nCnt++)
				{
					axGT�o�׈ꗗ.set_CelForeColor(nCnt,0,0);
					axGT�o�׈ꗗ.set_CelBackColor(nCnt,0,0xFFFFFF);
				}
			}
			axGT�o�׈ꗗ.set_CelForeColor(axGT�o�׈ꗗ.SelStartRow,0,0x98FB98);
			axGT�o�׈ꗗ.set_CelBackColor(axGT�o�׈ꗗ.SelStartRow,0,0x006000);
			axGT�o�׈ꗗ.set_CelForeColor(axGT�o�׈ꗗ.SelEndRow,0,0x98FB98);
			axGT�o�׈ꗗ.set_CelBackColor(axGT�o�׈ꗗ.SelEndRow,0,0x006000);
			axGT�o�׈ꗗ.set_CelForeColor(axGT�o�׈ꗗ.CaretRow,0,0x98FB98);
			axGT�o�׈ꗗ.set_CelBackColor(axGT�o�׈ꗗ.CaretRow,0,0x006000);

			if(axGT�o�׈ꗗ.SelEndRow > axGT�o�׈ꗗ.CaretRow
				&& axGT�o�׈ꗗ.SelStartRow <= axGT�o�׈ꗗ.CaretRow
				&& axGT�o�׈ꗗ.get_CelForeColor(axGT�o�׈ꗗ.SelEndRow,0) != Color.Black)
			{
				axGT�o�׈ꗗ.set_CelForeColor(axGT�o�׈ꗗ.SelEndRow,0,0);
				axGT�o�׈ꗗ.set_CelBackColor(axGT�o�׈ꗗ.SelEndRow,0,0xFFFFFF);
			}

			if(axGT�o�׈ꗗ.SelEndRow < axGT�o�׈ꗗ.CaretRow
				&& axGT�o�׈ꗗ.SelStartRow >= axGT�o�׈ꗗ.CaretRow
				&& axGT�o�׈ꗗ.get_CelForeColor(axGT�o�׈ꗗ.SelEndRow,0) != Color.Black)
			{
				axGT�o�׈ꗗ.set_CelForeColor(axGT�o�׈ꗗ.SelEndRow,0,0);
				axGT�o�׈ꗗ.set_CelBackColor(axGT�o�׈ꗗ.SelEndRow,0,0xFFFFFF);
			}

			OldRow = axGT�o�׈ꗗ.CaretRow;
			nSrow  = axGT�o�׈ꗗ.SelStartRow;
			nErow  = axGT�o�׈ꗗ.SelEndRow;

		}

		private void axGT�o�׈ꗗ_CelClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelClickEvent e)
		{
			axGT�o�׈ꗗ_CurPlaceChanged(null,null);
			if(axGT�o�׈ꗗ.SelStartRow != axGT�o�׈ꗗ.SelEndRow)
			{
				if(nSrow > nErow)
				{
					nWork = nSrow;
					nSrow = nErow;
					nErow = nWork;
				}
				for(short nCnt = nSrow; nCnt <= nErow; nCnt++)
				{
					axGT�o�׈ꗗ.set_CelForeColor(nCnt,0,0x98FB98);
					axGT�o�׈ꗗ.set_CelBackColor(nCnt,0,0x006000);
				}
				for(int nCnt = int.Parse(nSrow.ToString()) - 1; nCnt >= 1; nCnt--)
				{
					axGT�o�׈ꗗ.set_CelForeColor(short.Parse(nCnt.ToString()),0,0);
					axGT�o�׈ꗗ.set_CelBackColor(short.Parse(nCnt.ToString()),0,0xFFFFFF);
				}
				for(int nCnt = int.Parse(nErow.ToString()) + 1; nCnt <= axGT�o�׈ꗗ.Rows; nCnt++)
				{
					axGT�o�׈ꗗ.set_CelForeColor(short.Parse(nCnt.ToString()),0,0);
					axGT�o�׈ꗗ.set_CelBackColor(short.Parse(nCnt.ToString()),0,0xFFFFFF);
				}
			}
		}

		private void btn�o�׌���_Click(object sender, System.EventArgs e)
		{
// MOD 2011.05.20 ���s�j���� �o�׏Ɖ���̏�������̉��� START
//			string[] sData = new string[10];
			bool bAltKey   = ((GetAsyncKeyState(Keys.Menu) & 0x8000) == 0) ? false : true;
			string[] sData = new string[11];
			sData[10] = (bAltKey) ? "1" : "0";
// MOD 2011.05.20 ���s�j���� �o�׏Ɖ���̏�������̉��� END

			if(tex�����ԍ�.Text.Trim().Length != 0)
			{
				if(tex���q�l�R�[�h.Text.Length == 0)
				{
					tex���q�l��.Text = "";
				}
				if(tex�˗���R�[�h.Text.Length == 0)
				{
					tex�˗��喼.Text = "";
				}

				if(!���p�`�F�b�N(tex�����ԍ�,"�����ԍ�")) return;
//				if(!���l�`�F�b�N(tex�����ԍ�,"�����ԍ�")) return;
			}
			else
			{

				tex���q�l�R�[�h.Text = tex���q�l�R�[�h.Text.Trim();
				tex�˗���R�[�h.Text = tex�˗���R�[�h.Text.Trim();
				if(tex���q�l�R�[�h.Text.Length == 0)
				{
					tex���q�l��.Text = "";
				}
				if(tex�˗���R�[�h.Text.Length == 0)
				{
					tex�˗��喼.Text = "";
				}
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
//				if(!�K�{�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;
				if(!gsa��Ԃb�c[cmb���.SelectedIndex].Equals("90")){
					if(!�K�{�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;
				}
				tex�X��.Text = tex�X��.Text.Trim();
				if(!gs�Ǘ��ҋ敪.Equals("1")){
					if(!�K�{�`�F�b�N(tex�X��,"�X���R�[�h")) return;
				}
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
				if(!���p�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;
// DEL 2007.01.11 ���s�j���� �˗���̕K�{�`�F�b�N�̔p�~ START
//				if(!�K�{�`�F�b�N(tex�˗���R�[�h,"�˗���R�[�h")) return;
// DEL 2007.01.11 ���s�j���� �˗���̕K�{�`�F�b�N�̔p�~ END
				if(!���p�`�F�b�N(tex�˗���R�[�h,"�˗���R�[�h")) return;
// ADD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START

				//����}�X�^�`�F�b�N
				tex���q�l��.Text = "";
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
				if(tex���q�l�R�[�h.Text.Length > 0){
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
					���q�l����();
					if(tex���q�l��.Text.Length == 0){
						MessageBox.Show("���q�l�R�[�h�����������͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK );
						tex���q�l�R�[�h.Focus();
						return;
					}

					//�ב��l�}�X�^�`�F�b�N
					tex�˗���R�[�h.Text = tex�˗���R�[�h.Text.Trim();
					if(tex�˗���R�[�h.Text.Length > 0){
						tex�˗��喼.Text = "";
						�˗��匟��();
						if(tex�˗��喼.Text.Length == 0){
							MessageBox.Show("�˗���R�[�h�����������͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK );
							tex�˗���R�[�h.Focus();
							return;
						}
					}
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
				}
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
// ADD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END
				tex���b�Z�[�W.Text = "";

				if (dt�J�n���t.Value > dt�I�����t.Value)
				{
					MessageBox.Show("���t�͈̔͂����������͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK );
					dt�J�n���t.Focus();
					return;
				}
				string sSdayh = YYYYMMDD�ϊ�(dt�J�n���t.Value.AddMonths(3));
				string sEdayh = YYYYMMDD�ϊ�(dt�I�����t.Value);
				if (int.Parse(sSdayh) < int.Parse(sEdayh))
				{
					MessageBox.Show("���t�͈̔͂́A�R�����ȓ��Ŏw�肵�Ă�������","���̓`�F�b�N",MessageBoxButtons.OK );
					dt�J�n���t.Focus();
					return;
				}
			}


			tex�o�^����.Text = "";
			tex�����v.Text = "";
			tex�d�ʍ��v.Text = "";
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
			tex�G���g���v.Text = "";
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
			tex���b�Z�[�W.Text = "�������D�D�D";
			axGT�o�׈ꗗ.Clear();
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
			if(tex�����ԍ�.Text.Trim().Length == 0
					&& gsa��Ԃb�c[cmb���.SelectedIndex].Equals("90")){
				axGT�o�׈ꗗ.set_CelText(0, 4, "���q�l");
			}else{
				axGT�o�׈ꗗ.set_CelText(0, 4, "���͂���");
			}
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
// MOD 2009.09.11 ���s�j���� �o�׏Ɖ�ŏo�׍ςe�f,���M�ςe�f�Ȃǂ�ǉ� START
//// ADD 2007.01.23 ���s�j���� ��ʂ̒��� START
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|";
//// ADD 2007.01.23 ���s�j���� ��ʂ̒��� END
// MOD 2010.04.06 ���s�j���� �o�׏Ɖ�ɓ��Ӑ�A�X�֔ԍ��Ȃǂ�ǉ� START
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� END
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� START
//			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
			axGT�o�׈ꗗ.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
										+"8.0|13.0|5.7|5.7|3.8|"
										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� END
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
// MOD 2010.11.25 ���s�j���� �o�׏Ɖ�ɍ폜�����Ȃǂ�ǉ� END
// MOD 2010.04.06 ���s�j���� �o�׏Ɖ�ɓ��Ӑ�A�X�֔ԍ��Ȃǂ�ǉ� END
// MOD 2009.09.11 ���s�j���� �o�׏Ɖ�ŏo�׍ςe�f,���M�ςe�f�Ȃǂ�ǉ� END
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT�o�׈ꗗ.CaretRow = 1;
			axGT�o�׈ꗗ.CaretCol = 1;
			axGT�o�׈ꗗ_CurPlaceChanged(null,null);
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END

			string sSday = YYYYMMDD�ϊ�(dt�J�n���t.Value);
			string sEday = YYYYMMDD�ϊ�(dt�I�����t.Value);

			sData[0] = tex���q�l�R�[�h.Text.Trim();

			//���˗��匟������Ƃ��Ă����ꍇ�́A����b�c�������ɓ����
			if(s�˗���b�c.Trim() == tex�˗���R�[�h.Text.Trim())
			{
				sData[1] = s����b�c;
			}
			else
			{
				sData[1] = "";
				tex�˗��喼.Text = "";
			}

			sData[2] = tex�˗���R�[�h.Text.Trim();
			sData[3] = cmb�o�ד�.SelectedIndex.ToString();
			sData[4] = sSday;
			sData[5] = sEday;
			sData[6] = gsa��Ԃb�c[cmb���.SelectedIndex];
			if(tex�����ԍ�.Text.Trim().Length == 0)
				sData[7] = "";
			else
				sData[7] = tex�����ԍ�.Text.Trim().PadLeft(15,'0');
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START
//			if(rb�S��.Checked)
//				sData[8] = "0";
//			if(rb�폜.Checked)
//				sData[8] = "1";
//			if(rb�o�ו�.Checked)
//				sData[8] = "2";
			switch(cmb�폜�敪.SelectedIndex)
			{
				case 1:
					sData[8] = "1";		// �폜��
					break;
				case 2:
					sData[8] = "2";		// �o�ו�
					break;
				default:
					sData[8] = "0";		// �S��
					break;
			}
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END

// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
//			sData[9] = gs�X���R�[�h;
			tex�X��.Text = tex�X��.Text.Trim();
			sData[9] = tex�X��.Text;
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				s�o�׈ꗗ = new string[1];
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				s�o�׈ꗗ = sv_maintenance.Get_syukka(gsa���[�U,sData);
				tex���b�Z�[�W.Text = s�o�׈ꗗ[0];
				if(s�o�׈ꗗ[0].Length == 4)
				{
					tex���b�Z�[�W.Text = "";
					tex�o�^����.Text = s�o�׈ꗗ[1];
					tex�����v.Text = s�o�׈ꗗ[2];
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
//					tex�d�ʍ��v.Text = s�o�׈ꗗ[3];
					string[] sWrk = s�o�׈ꗗ[3].Split('|');
					if(sWrk.Length >= 2){
						tex�G���g���v.Text = sWrk[0];
						tex�d�ʍ��v.Text   = sWrk[1];
					}else{
						tex�G���g���v.Text = s�o�׈ꗗ[3];
						tex�d�ʍ��v.Text   = "";
					}
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
// ADD 2007.01.11 ���s�j���� �����ԍ��Ō����������A���q�l���A�˗��喼��\�� START
					if(tex�����ԍ�.Text.Trim().Length > 0){
						if(s�o�׈ꗗ[4] != null && s�o�׈ꗗ[4].Length > 0){
							tex���q�l�R�[�h.Text = "";
							s����b�c            = "";
							tex�˗���R�[�h.Text = "";

							tex���q�l��.Text = s�o�׈ꗗ[7];
							tex�˗��喼.Text = s�o�׈ꗗ[9];
						}
					}
// ADD 2007.01.11 ���s�j���� �����ԍ��Ō����������A���q�l���A�˗��喼��\�� END

// MOD 2007.01.11 ���s�j���� �s����10�s�ɂ��� START
//					axGT�o�׈ꗗ.Rows = 7;
					axGT�o�׈ꗗ.Rows = 10;
// MOD 2007.01.11 ���s�j���� �s����10�s�ɂ��� END
					�ŏ��ݒ�();

// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� START
					// �Y������o�׃f�[�^�����݂����ꍇ�̂݁A���x���C���[�W����{�^���𗘗p�Ƃ���
					btn���x���C���[�W���.Enabled = true;
// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� END

				}
				else
				{
					if(s�o�׈ꗗ[0].Equals("�Y���f�[�^������܂���"))
					{
						tex���b�Z�[�W.Text = "";
						MessageBox.Show("�Y���f�[�^������܂���","�o�׌���",MessageBoxButtons.OK);
					}
// ADD 2006.12.22 ���s�j�����J 5000���`�F�b�N�ȏ�͕\���ł��Ȃ����� START
// MOD 2007.01.23 ���s�j���� 1000���ȏ�͕\���ł��Ȃ����� START
//					else if(int.Parse(s�o�׈ꗗ[1].Replace(",","")) > 5000)
					else if(int.Parse(s�o�׈ꗗ[1].Replace(",","")) > 1000)
// MOD 2007.01.23 ���s�j���� 1000���ȏ�͕\���ł��Ȃ����� END
					{
						tex���b�Z�[�W.Text = "";
						tex�o�^����.Text = s�o�׈ꗗ[1];
						tex�����v.Text = s�o�׈ꗗ[2];
						tex�d�ʍ��v.Text = s�o�׈ꗗ[3];
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
//						tex�d�ʍ��v.Text = s�o�׈ꗗ[3];
						string[] sWrk = s�o�׈ꗗ[3].Split('|');
						if(sWrk.Length >= 2){
							tex�G���g���v.Text = sWrk[0];
							tex�d�ʍ��v.Text   = sWrk[1];
						}else{
							tex�G���g���v.Text = s�o�׈ꗗ[3];
							tex�d�ʍ��v.Text   = "";
						}
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
// MOD 2007.02.02 ���s�j���� 1000���ȏ�G���[�̃��b�Z�[�W�ύX START
//// MOD 2007.01.23 ���s�j���� 1000���ȏ�͕\���ł��Ȃ����� START
////						MessageBox.Show("�Y���f�[�^��5000���𒴂����ׁA�\���ł��܂���B\n"
//						MessageBox.Show("�Y���f�[�^��1000���𒴂����ׁA�\���ł��܂���B\n"
//// MOD 2007.01.23 ���s�j���� 1000���ȏ�͕\���ł��Ȃ����� END
//										+ "����������ύX���āA�Č������Ă��������B",
						MessageBox.Show("�f�[�^�������A1,000���ȏ�̂��ߕ\���ł��܂���B\n"
										+ "�����������i�荞��ŉ������B",
// MOD 2007.02.02 ���s�j���� 1000���ȏ�G���[�̃��b�Z�[�W�ύX START
										"�o�׌���",MessageBoxButtons.OK);
					}
// ADD 2006.12.22 ���s�j�����J 5000���`�F�b�N�ȏ�͕\���ł��Ȃ����� END
					else
					{
						�r�[�v��();
					}
					tex�˗���R�[�h.Focus();
				}
			}
			catch (System.Net.WebException)
			{
				tex���b�Z�[�W.Text = gs�ʐM�G���[;
				�r�[�v��();
				tex�˗���R�[�h.Focus();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = "�ʐM�G���[�F" + ex.Message;
				�r�[�v��();
				tex�˗���R�[�h.Focus();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			axGT�o�׈ꗗ.CaretRow = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT�o�׈ꗗ.CaretCol = 1;
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END
			axGT�o�׈ꗗ_CurPlaceChanged(sender,null);
		}

// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START
		private void ���q�l����()
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				// ����
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
// MOD 2007.11.14 KCL) �X�{ global�Ή� START
//				String[] sList = sv_maintenance.Get_Sirainusi(gsa���[�U,tex���q�l�R�[�h.Text,"","",gs�X���R�[�h);
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
//				String[] sList = sv_maintenance.Get_Sirainusi2(gsa���[�U,tex���q�l�R�[�h.Text,"","",gs�X���R�[�h);
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//				String[] sList = sv_maintenance.Get_Sirainusi2(gsa���[�U,tex���q�l�R�[�h.Text,"","",tex�X��.Text);
				String[] sList;
				if ((tex���q�l�R�[�h.Text == "") || (tex���q�l�R�[�h.Text.Substring(0,1) != "J"))
				{
					sList = sv_maintenance.Get_Sirainusi2(gsa���[�U,tex���q�l�R�[�h.Text,"","",tex�X��.Text);
				}
				else
				{
					if(sv_oji == null) sv_oji = new is2oji.Service1();
					sList = sv_oji.Get_Sirainusi2(gsa���[�U,tex���q�l�R�[�h.Text,"","",tex�X��.Text);
				}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END					
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
// MOD 2007.11.14 KCL) �X�{ global�Ή� END
				// ����I����
				if(sList[0].Length == 4)
				{
					tex���q�l��.Text   = sList[1];
					tex���b�Z�[�W.Text = "";
					tex�˗���R�[�h.Focus();
				}
				else if(sList[0].Length == 0)
				{
					tex���b�Z�[�W.Text = "";
					tex�˗���R�[�h.Focus();
				}
				else
				{
					// �ُ�I����
					�r�[�v��();
					tex���b�Z�[�W.Text = sList[0];
					tex���q�l�R�[�h.Focus();
				}
			}
			catch (System.Net.WebException)
			{
				tex���b�Z�[�W.Text = gs�ʐM�G���[;
				�r�[�v��();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = "�ʐM�G���[�F" + ex.Message;
				�r�[�v��();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

		}
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END

		private void �˗��匟��()
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				// ����
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START
//				if(sv_goirai == null) sv_goirai = new is2goirai.Service1();
//				String[] sList = sv_goirai.Get_Sirainusi(gsa���[�U,gs����b�c,gs����b�c,s�˗���b�c);
//				// ���b�Z�[�W��[�o�^]�A[�X�V]�̎��A����I��
//				if(sList[0].Length == 2)
//
//				{
//					if(sList[17] == "U")
//					{
//						tex�˗��喼.Text     = sList[9];
//						tex���b�Z�[�W.Text = "";
//						cmb�o�ד�.Focus();
//					}
//					else
//					{
//						tex���b�Z�[�W.Text = "";
//						cmb�o�ד�.Focus();
//					}
//				}
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
// MOD 2007.11.16 KCL) �X�{ global�Ή� START
//// MOD 2007.01.25 ���s�j���� ���������G���[ START
////				String[] sList = sv_maintenance.Get_Sirainusi(gsa���[�U,tex���q�l�R�[�h.Text,s����b�c,s�˗���b�c,gs�X���R�[�h);
//				String[] sList = sv_maintenance.Get_Sirainusi(
//					gsa���[�U,  tex���q�l�R�[�h.Text, s����b�c, tex�˗���R�[�h.Text, gs�X���R�[�h);
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
//				String[] sList = sv_maintenance.Get_Sirainusi2(
//					gsa���[�U,  tex���q�l�R�[�h.Text, s����b�c, tex�˗���R�[�h.Text, gs�X���R�[�h);
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//				String[] sList = sv_maintenance.Get_Sirainusi2(
//					gsa���[�U,  tex���q�l�R�[�h.Text, s����b�c, tex�˗���R�[�h.Text, tex�X��.Text);
				String[] sList;
				if ((tex���q�l�R�[�h.Text == "") || (tex���q�l�R�[�h.Text.Substring(0,1) != "J"))
				{
					sList = sv_maintenance.Get_Sirainusi2(
						gsa���[�U,  tex���q�l�R�[�h.Text, s����b�c, tex�˗���R�[�h.Text, tex�X��.Text);
				}
				else
				{
					if(sv_oji == null) sv_oji = new is2oji.Service1();
					sList = sv_oji.Get_Sirainusi2(
						gsa���[�U,  tex���q�l�R�[�h.Text, s����b�c, tex�˗���R�[�h.Text, tex�X��.Text);
				}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
					
					
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
// MOD 2007.01.25 ���s�j���� ���������G���[ END
// MOD 2007.11.16 KCL) �X�{ global�Ή� END
				// ����I����
				if(sList[0].Length == 4)
				{
					tex�˗��喼.Text   = sList[3];
					tex���b�Z�[�W.Text = "";
					cmb�o�ד�.Focus();
				}
				else if(sList[0].Length == 0)
				{
					tex���b�Z�[�W.Text = "";
					cmb�o�ד�.Focus();
				}
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END
				else
				{
					// �ُ�I����
					�r�[�v��();
					tex���b�Z�[�W.Text = sList[0];
					tex�˗���R�[�h.Focus();
				}
			}
			catch (System.Net.WebException)
			{
				tex���b�Z�[�W.Text = gs�ʐM�G���[;
				�r�[�v��();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = "�ʐM�G���[�F" + ex.Message;
				�r�[�v��();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

		}

// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START
		private void tex���q�l�R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn���q�l����.Focus();
				btn���q�l����_Click(sender,e);
				e.Handled = true;
			}
		}

		private void tex���q�l�R�[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
//				btn���q�l����.Focus();
				// ���b�Z�[�W�̃N���A
				tex���b�Z�[�W.Text = "";
				tex���q�l��.Text   = "";

				// �󔒏���
				tex���q�l�R�[�h.Text = tex���q�l�R�[�h.Text.Trim();
				if(tex���q�l�R�[�h.Text.Length != 0)
				{
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
					tex�X��.Text = tex�X��.Text.Trim();
					if(!gs�Ǘ��ҋ敪.Equals("1")){
						if(!�K�{�`�F�b�N(tex�X��,"�X���R�[�h")) return;
					}
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
					if(!���p�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;

					tex���b�Z�[�W.Text = "�������D�D�D";
//					s�˗���b�c = tex���q�l�R�[�h.Text;
					���q�l����();
				}
			}
		}

		private void tex���q�l�R�[�h_LostFocus(object sender, EventArgs e)
		{
			if(tex���q�l�R�[�h.Text.Trim() == "")
				tex���q�l��.Text = "";
		}
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END

		private void tex�˗���R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�˗��匟��.Focus();
				btn�˗��匟��_Click(sender,e);
				e.Handled = true;
			}		

		}

		private void tex�˗���R�[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
//				btn�˗��匟��.Focus();
				// ���b�Z�[�W�̃N���A
				tex���b�Z�[�W.Text = "";
				tex�˗��喼.Text   = "";

// ADD 2007.01.25 ���s�j���� ���q�l�R�[�h�`�F�b�N�̒ǉ� START
				tex���q�l�R�[�h.Text = tex���q�l�R�[�h.Text.Trim();
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
//				if(!�K�{�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;
				if(!gsa��Ԃb�c[cmb���.SelectedIndex].Equals("90")){
					if(!�K�{�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;
				}
				tex�X��.Text = tex�X��.Text.Trim();
				if(!gs�Ǘ��ҋ敪.Equals("1")){
					if(!�K�{�`�F�b�N(tex�X��,"�X���R�[�h")) return;
				}
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
				if(!���p�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;
// ADD 2007.01.25 ���s�j���� ���q�l�R�[�h�`�F�b�N�̒ǉ� END

				// �󔒏���
				tex�˗���R�[�h.Text = tex�˗���R�[�h.Text.Trim();
				if(tex�˗���R�[�h.Text.Length != 0)
				{
					if(!���p�`�F�b�N(tex�˗���R�[�h,"�˗���R�[�h")) return;

					tex���b�Z�[�W.Text = "�������D�D�D";
					s�˗���b�c = tex�˗���R�[�h.Text;
					�˗��匟��();
				}
			}
		}

		private void axGT�o�׈ꗗ_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT�o�׈ꗗ, true, true, true, true);
			}
		}

		private void tex�˗���R�[�h_LostFocus(object sender, EventArgs e)
		{
			if(tex�˗���R�[�h.Text.Trim() == "")
				tex�˗��喼.Text = "";

		}

		private void �ŏ��ݒ�()
		{
//
// MOD 2007.01.11 ���s�j���� �s����10�s�ɂ��� START
//			if (s�o�׈ꗗ.Length - 4 <= 7)
//			{
//				axGT�o�׈ꗗ.Rows = 7;
//			}
//			else if (axGT�o�׈ꗗ.Rows < s�o�׈ꗗ.Length - 4)
//			{
//				axGT�o�׈ꗗ.Rows = (short)(s�o�׈ꗗ.Length - 4);
//			}
			if (s�o�׈ꗗ.Length - 10 <= 10)
			{
				axGT�o�׈ꗗ.Rows = 10;
			}
			else if (axGT�o�׈ꗗ.Rows < s�o�׈ꗗ.Length - 10)
			{
				axGT�o�׈ꗗ.Rows = (short)(s�o�׈ꗗ.Length - 10);
			}
// MOD 2007.01.11 ���s�j���� �s����10�s�ɂ��� END
			for(short i = 1; i <= axGT�o�׈ꗗ.Rows; i++ )
			{
				axGT�o�׈ꗗ.set_CelHeight(i,0,2.3);
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX START
//				axGT�o�׈ꗗ.set_CelAlignVert(i,2,3);
//				axGT�o�׈ꗗ.set_CelAlignVert(i,7,3);
//				axGT�o�׈ꗗ.set_CelAlignVert(i,8,3);
				axGT�o�׈ꗗ.set_CelAlignVert(i,4,3);
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
//				axGT�o�׈ꗗ.set_CelAlignVert(i,7,3);
//				axGT�o�׈ꗗ.set_CelAlignVert(i,11,3);
				axGT�o�׈ꗗ.set_CelAlignVert(i,8,3);
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� START
//				axGT�o�׈ꗗ.set_CelAlignVert(i,12,3);
				axGT�o�׈ꗗ.set_CelAlignVert(i,13,3);
// MOD 2014.03.19 BEVAS�j���� �o�׏Ɖ�ɔz�����t�E������ǉ� END
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
// MOD 2007.01.17 ���s�j���� �������ځA�ꗗ�\�����ڂ̕ύX END
			}
//
			axGT�o�׈ꗗ.Clear();
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� START
			axGT�o�׈ꗗ.CaretRow = 1;
			axGT�o�׈ꗗ.CaretCol = 1;
			axGT�o�׈ꗗ_CurPlaceChanged(null,null);
// ADD 2007.02.21 ���s�j���� ������̃J�����ʒu�̒��� END

			short s�\���� = (short)1;
//			for(short sCnt = (short)i�J�n��; sCnt < s�o�׈ꗗ.Length && sCnt <= i�I���� ; sCnt++)
// MOD 2007.01.11 ���s�j���� �����ԍ��Ō����������A���q�l���A�˗��喼��\�� START
//			for(short sCnt = (short)4; sCnt < s�o�׈ꗗ.Length; sCnt++)
			for(short sCnt = (short)10; sCnt < s�o�׈ꗗ.Length; sCnt++)
// MOD 2007.01.11 ���s�j���� �����ԍ��Ō����������A���q�l���A�˗��喼��\�� END
			{
				string sRList = s�o�׈ꗗ[sCnt].Replace("\\r\\n","\r\n");
				axGT�o�׈ꗗ.set_RowsText(s�\����, sRList);
				s�\����++;
			}
			axGT�o�׈ꗗ.Focus();
		}

		private void cmb���_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btn�o�׌���_Click(sender,e);
			}

		}

		private void �o�׏Ɖ�_Closed(object sender, System.EventArgs e)
		{
			tex���q�l�R�[�h.Focus();
		}

		private void btn���q�l����_Click(object sender, System.EventArgs e)
		{
			tex���q�l�R�[�h.Text = tex���q�l�R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex���q�l�R�[�h, "���q�l�R�[�h")) return;

// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
			tex�X��.Text = tex�X��.Text.Trim();
			if(!gs�Ǘ��ҋ敪.Equals("1")){
				if(!�K�{�`�F�b�N(tex�X��,"�X���R�[�h")) return;
			}
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2007.11.13 KCL) �X�{ global�Ή�[��������Q]��ʂɕύX START
//			if (g������� == null)	 g������� = new �������();
//			g�������.Left = this.Left + 404;
//			g�������.Top = this.Top;
//			g�������.s����R�[�h = "";
//			g�������.s����� = "";
//// MOD 2007.01.19 ���s�j���� ��ʃ��C�A�E�g�ύX���� START
////			g�������.ShowDialog();
//			g�������.s�X���R�[�h = gs�X���R�[�h.Trim();
//			g�������.ShowDialog();
//			g�������.s�X���R�[�h = "";
//// MOD 2007.01.19 ���s�j���� ��ʃ��C�A�E�g�ύX���� END
//			this.Cursor = System.Windows.Forms.Cursors.Default;
//
//			if (g�������.s����R�[�h.Trim().Length != 0)
//			{
//				tex���q�l�R�[�h.Text = g�������.s����R�[�h;
//				tex���q�l��.Text = g�������.s�����;
			if (g������Q == null)	 g������Q = new ��������Q();
			g������Q.Left = this.Left + 404;
			g������Q.Top = this.Top;
			g������Q.s����R�[�h = "";
			g������Q.s����� = "";
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
//			g������Q.s�X���R�[�h = gs�X���R�[�h.Trim();
			g������Q.s�X���R�[�h = tex�X��.Text;
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
			g������Q.b�^�p���̂��q�l�̂� = cb�^�p���̂��q�l�̂�.Checked;
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END
			g������Q.ShowDialog();
			g������Q.s�X���R�[�h = "";
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if (g������Q.s����R�[�h.Trim().Length != 0)
			{
				tex���q�l�R�[�h.Text = g������Q.s����R�[�h;
				tex���q�l��.Text = g������Q.s�����;
// MOD 2007.11.13 KCL) �X�{ global�Ή�[��������Q]��ʂɕύX END
				tex�˗���R�[�h.Focus();
			}
			else
			{
				tex���q�l�R�[�h.Focus();
			}
		}

// MOD 2010.04.30 ���s�j���� �b�r�u�o�͋@�\�̒ǉ� START
		private void btn�b�r�u�o��_Click(object sender, System.EventArgs e)
		{
// MOD 2010.11.19 ���s�j���� �z�����Ȃǂ̎擾 START
			bool bAltKey   = ((GetAsyncKeyState(Keys.Menu) & 0x8000) == 0) ? false : true;
			bool bShiftKey = ((GetAsyncKeyState(Keys.ShiftKey) & 0x8000) == 0) ? false : true;
// MOD 2011.05.20 ���s�j���� �b�r�u�o�͌`���̒ǉ� START
//			if(bAltKey && bShiftKey){
			if(bAltKey){
// MOD 2011.05.20 ���s�j���� �b�r�u�o�͌`���̒ǉ� END
				�ꗗ�I���b�r�u�o��();
				return;
			}
// MOD 2010.11.19 ���s�j���� �z�����Ȃǂ̎擾 END
// MOD 2011.05.20 ���s�j���� �b�r�u�o�͌`���̒ǉ� START
//			string[] sData = new string[]{"","","","",""
//											,"","","","",""};
			string s�b�r�u�o�͌`�� = (bShiftKey) ? "1" : "0";
			string[] sData = new string[]{"","","","",""
										 ,"","","","",""
										 ,s�b�r�u�o�͌`��
// MOD 2014.03.20 BEVAS�j���� �b�r�u�o�͂ɔz�����t�E������ǉ� START
										 ,""
// MOD 2014.03.20 BEVAS�j���� �b�r�u�o�͂ɔz�����t�E������ǉ� END
										};
// MOD 2011.05.20 ���s�j���� �b�r�u�o�͌`���̒ǉ� END
			tex���q�l��.Text = "";
			tex�˗��喼.Text = "";

			tex�X��.Text         = tex�X��.Text.TrimEnd();
			tex���q�l�R�[�h.Text = tex���q�l�R�[�h.Text.TrimEnd();
			tex�˗���R�[�h.Text = tex�˗���R�[�h.Text.TrimEnd();
			tex�����ԍ�.Text   = tex�����ԍ�.Text.TrimEnd();

			if(tex�����ԍ�.Text.Trim().Length > 0){
				if(!���p�`�F�b�N(tex�X��        ,"�X���R�[�h"  )) return;
				if(!���p�`�F�b�N(tex�����ԍ�  ,"�����ԍ�"  )) return;
			}else{
				//[��Ԃb�c]��[���o��]�ȊO�̎��A[���q�l�R�[�h]���K�{
				if(!gsa��Ԃb�c[cmb���.SelectedIndex].Equals("90")){
					if(!�K�{�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;
				}
				//[�Ǘ��ҋ敪]��[�Ǘ���]�ȊO�̎��A[�X���R�[�h]���K�{
				if(!gs�Ǘ��ҋ敪.Equals("1")){
					if(!�K�{�`�F�b�N(tex�X��,"�X���R�[�h")) return;
				}
				if(!���p�`�F�b�N(tex�X��        ,"�X���R�[�h"  )) return;
				if(!���p�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;
				if(!���p�`�F�b�N(tex�˗���R�[�h,"�˗���R�[�h")) return;

				//����}�X�^�`�F�b�N
				tex���q�l��.Text = "";
				if(tex���q�l�R�[�h.Text.Length > 0){
					���q�l����();
					if(tex���q�l��.Text.Length == 0){
						MessageBox.Show("���q�l�R�[�h�����������͂���Ă��܂���"
										, "���̓`�F�b�N", MessageBoxButtons.OK );
						tex���q�l�R�[�h.Focus();
						return;
					}

					//�ב��l�}�X�^�`�F�b�N
					tex�˗���R�[�h.Text = tex�˗���R�[�h.Text.Trim();
					if(tex�˗���R�[�h.Text.Length > 0){
						�˗��匟��();
						if(tex�˗��喼.Text.Length == 0){
							MessageBox.Show("�˗���R�[�h�����������͂���Ă��܂���"
											, "���̓`�F�b�N", MessageBoxButtons.OK );
							tex�˗���R�[�h.Focus();
							return;
						}
					}
				}

				tex���b�Z�[�W.Text = "";

				if (dt�J�n���t.Value > dt�I�����t.Value){
					MessageBox.Show("���t�͈̔͂����������͂���Ă��܂���"
									, "���̓`�F�b�N", MessageBoxButtons.OK );
					dt�J�n���t.Focus();
					return;
				}
				string s�J�n���t = YYYYMMDD�ϊ�(dt�J�n���t.Value.AddMonths(3));
				string s�I�����t = YYYYMMDD�ϊ�(dt�I�����t.Value);
				if (int.Parse(s�J�n���t) < int.Parse(s�I�����t)){
					MessageBox.Show("���t�͈̔͂́A�R�����ȓ��Ŏw�肵�Ă�������"
									, "���̓`�F�b�N", MessageBoxButtons.OK );
					dt�J�n���t.Focus();
					return;
				}
			}

			sData[0] = tex���q�l�R�[�h.Text;
			//���˗��匟������Ƃ��Ă����ꍇ�́A����b�c�������ɓ����
			if(s�˗���b�c.Trim() == tex�˗���R�[�h.Text.Trim()){
				sData[1] = s����b�c;
			}else{
				sData[1] = "";
				tex�˗��喼.Text = "";
			}
			sData[2] = tex�˗���R�[�h.Text;
			sData[3] = cmb�o�ד�.SelectedIndex.ToString();
			sData[4] = YYYYMMDD�ϊ�(dt�J�n���t.Value);;
			sData[5] = YYYYMMDD�ϊ�(dt�I�����t.Value);
			sData[6] = gsa��Ԃb�c[cmb���.SelectedIndex];
			if(tex�����ԍ�.Text.Trim().Length == 0){
				sData[7] = "";
			}else{
				sData[7] = tex�����ԍ�.Text.Trim().PadLeft(15,'0');
			}
			switch(cmb�폜�敪.SelectedIndex){
				case 1:
					sData[8] = "1";		// �폜��
					break;
				case 2:
					sData[8] = "2";		// �o�ו�
					break;
				default:
					sData[8] = "0";		// �S��
					break;
			}
			sData[9] = tex�X��.Text;
// MOD 2014.03.20 BEVAS�j���� �b�r�u�o�͂ɔz�����t�E������ǉ� START
			if(cBox�z���r�o��.Checked)
			{
				sData[11] = "1";
			}
			else
			{
				sData[11] = "";
			}
// MOD 2014.03.20 BEVAS�j���� �b�r�u�o�͂ɔz�����t�E������ǉ� END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sList = new string[]{""};
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				sList = sv_maintenance.Get_csvwrite3(gsa���[�U,sData);
				if(sList[0].Length == 4){
// MOD 2011.05.20 ���s�j���� �b�r�u�o�͌`���̒ǉ� START
					if(s�b�r�u�o�͌`��.Equals("1")){
						//�b�r�u�G���g���[�`��
						sList[0] = ""
							+ "\"�׎�l�R�[�h\",\"�d�b�ԍ�\","
							+ "\"�Z��\",\"�Z���Q\",\"�Z���R\","
							+ "\"���O\",\"���O�Q\","
							+ "\"�X�֔ԍ�\",\"����v\",\"���X�R�[�h\","
							+ "\"�ב��l�R�[�h\","
							+ "\"��\",\"�ː�\",\"�d��\","
							+ "\"�A�����i�P\",\"�A�����i�Q\","
							+ "\"�i���L���P\",\"�i���L���Q\",\"�i���L���R\","
							+ "\"�z�B�w���\",\"���q�l�Ǘ��ԍ�\","
							+ "\"�\��\","
							+ "\"�����敪\",\"�ی����z\","
							+ "\"�o�ד��t\",\"�o�^���t\""
							;
					}else{
// MOD 2011.05.20 ���s�j���� �b�r�u�o�͌`���̒ǉ� END
						sList[0] = "\"�o�^��\",\"�o�ד�\",\"�����ԍ�\","
							+ "\"�׎�l�R�[�h\",\"�׎�l�X�֔ԍ�\",\"�׎�l�d�b�ԍ�\","
							+ "\"�׎�l�Z���P\",\"�׎�l�Z���Q\",\"�׎�l�Z���R\","
							+ "\"�׎�l���O�P\",\"�׎�l���O�Q\",\"����v\",\"���X�R�[�h\",\"���X��\","
							+ "\"�ב��l�R�[�h\",\"�ב��l�X�֔ԍ�\",\"�ב��l�d�b�ԍ�\","
							+ "\"�ב��l�Z���P\",\"�ב��l�Z���Q\","
							+ "\"�ב��l���O�P\",\"�ב��l���O�Q\","
							+ "\"��\",\"�d��\","
							+ "\"�w���\",\"�A�����i�P\",\"�A�����i�Q\","
							+ "\"�i���L���P\",\"�i���L���Q\",\"�i���L���R\",\"�����敪\","
							+ "\"�ی����z\",\"���q�l�Ǘ��ԍ�\","
							+ "\"������R�[�h\",\"�����敔�ۏ��R�[�h\"";
// MOD 2011.05.20 ���s�j���� �b�r�u�o�͌`���̒ǉ� START
					}
// MOD 2011.05.20 ���s�j���� �b�r�u�o�͌`���̒ǉ� END
// MOD 2014.03.20 BEVAS�j���� �b�r�u�o�͂ɔz�����t�E������ǉ� START
					if(sData[11].Equals("1"))
					{
						sList[0] += ",\"�z�����t�E����\"";
					}
// MOD 2014.03.20 BEVAS�j���� �b�r�u�o�͂ɔz�����t�E������ǉ� END

					// �f�t�H���g�̃t�H���_���f�X�N�g�b�v�t�H���_�ɂ���
					saveFileDialog1.InitialDirectory
						= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
					saveFileDialog1.Filter = "�b�r�u�t�@�C�� (*.csv)|*.csv";
					byte[] bSJIS;
					if(saveFileDialog1.ShowDialog(this) == DialogResult.OK){
						System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
						for(int iCnt = 0; iCnt < sList.Length; iCnt++){
							bSJIS = toSJIS(sList[iCnt]);
							fs.Write(bSJIS, 0 , bSJIS.Length);
						}
						fs.Close();
						tex���b�Z�[�W.Text = "";
					}
				}else{
					�r�[�v��();
					tex���b�Z�[�W.Text = sList[0];
				}
			}catch (System.Net.WebException){
				this.Cursor = System.Windows.Forms.Cursors.Default;
				tex���b�Z�[�W.Text = gs�ʐM�G���[;
			}catch(Exception ex){
				this.Cursor = System.Windows.Forms.Cursors.Default;
				tex���b�Z�[�W.Text = ex.Message;
// MOD 2010.11.19 ���s�j���� �z�����Ȃǂ̎擾 START
			}finally{
				this.Cursor = System.Windows.Forms.Cursors.Default;
// MOD 2010.11.19 ���s�j���� �z�����Ȃǂ̎擾 END
			}
			tex���q�l�R�[�h.Focus();
		}
// MOD 2010.04.30 ���s�j���� �b�r�u�o�͋@�\�̒ǉ� END
// MOD 2010.11.19 ���s�j���� �z�����Ȃǂ̎擾 START
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� START
//		const short n��_�����ԍ�     =  7;
//		const short n��_�A����       = 10;
//		const short n��_�W���[�i���m�n = 15;
//		const short n��_�o�^��         = 16;
//		const short n��_����b�c       = 31;
//		const short n��_����b�c       = 32;
		const short n��_�����ԍ�     =  8;
		const short n��_�A����       = 11;
		const short n��_�W���[�i���m�n = 16;
		const short n��_�o�^��         = 17;
		const short n��_����b�c       = 32;
		const short n��_����b�c       = 33;
// MOD 2011.05.06 ���s�j���� �o�׏Ɖ�ɉ׎���͏d�ʁA�X�����͏d�ʂ�ǉ� END
		private void axGT�o�׈ꗗ_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
//			if(axGT�o�׈ꗗ.SelStartRow != axGT�o�׈ꗗ.SelEndRow){
//				MessageBox.Show("�����̃f�[�^��I��������Ԃł͎��s�ł��܂���B\r\n"
//					+"�P���̂ݑI�����Ď��s���Ă��������B"
//					, "�m�F", MessageBoxButtons.OK );
//				return;
//			}
//			short n�s = axGT�o�׈ꗗ.CaretRow;
			short n�� = axGT�o�׈ꗗ.CaretCol;
			short n�s�J�n = (axGT�o�׈ꗗ.SelStartRow <= axGT�o�׈ꗗ.SelEndRow)
								? axGT�o�׈ꗗ.SelStartRow : axGT�o�׈ꗗ.SelEndRow;
			short n�s�I�� = (axGT�o�׈ꗗ.SelStartRow <= axGT�o�׈ꗗ.SelEndRow)
								? axGT�o�׈ꗗ.SelEndRow : axGT�o�׈ꗗ.SelStartRow;
			bool bAltKey   = ((GetAsyncKeyState(Keys.Menu) & 0x8000) == 0) ? false : true;
			bool bShiftKey = ((GetAsyncKeyState(Keys.ShiftKey) & 0x8000) == 0) ? false : true;

			//�����ԍ��̕ҏW
			string[] sa�����ԍ� = new string[]{
				 "","","","",""
				,"","","","",""
			};
			int iCnt����� = 0;
			string sw�����ԍ� = "";
			for(short n�s = n�s�J�n; n�s <= n�s�I��; n�s++){
				sw�����ԍ� = axGT�o�׈ꗗ.get_CelText(n�s, n��_�����ԍ�).Trim();
				int iPosEnd = sw�����ԍ�.IndexOf('\r');
				if(iPosEnd < 1) continue;
				sa�����ԍ�[iCnt�����] = sw�����ԍ�.Substring(0,iPosEnd);
				iCnt�����++;
			}
			if(iCnt����� == 0) return;

			switch(n��){
			case n��_�����ԍ�:
			case n��_�A����:
				if(bAltKey){
					if(bShiftKey){
						�z�����擾�Q(sa�����ԍ�[0]);
					}else{
						���ו��z�B�󋵏Ɖ�ꗗ(sa�����ԍ�);
					}
				}
				break;
			}
		}
		private void �ꗗ�I���b�r�u�o��()
		{
			short n�s�J�n = (axGT�o�׈ꗗ.SelStartRow <= axGT�o�׈ꗗ.SelEndRow)
								? axGT�o�׈ꗗ.SelStartRow : axGT�o�׈ꗗ.SelEndRow;
			short n�s�I�� = (axGT�o�׈ꗗ.SelStartRow <= axGT�o�׈ꗗ.SelEndRow)
								? axGT�o�׈ꗗ.SelEndRow : axGT�o�׈ꗗ.SelStartRow;

			//�o�׃L�[�̕ҏW
			string[] sa�o�׃L�[   = new string[n�s�I�� - n�s�J�n +1];
			int iCnt�o�׃L�[ = 0;
			string sw�����ԍ� = "";
			string sw�o�׃L�[   = "";
			string[] sa�����ԍ� = new string[n�s�I�� - n�s�J�n +1];
			int iCnt����� = 0;
			for(short n�s = n�s�J�n; n�s <= n�s�I��; n�s++){
				sw�o�׃L�[ = axGT�o�׈ꗗ.get_CelText(n�s, n��_����b�c);
				if(sw�o�׃L�[ == null) break;
				if(sw�o�׃L�[.Length == 0) break;
				sw�o�׃L�[ += "," + axGT�o�׈ꗗ.get_CelText(n�s, n��_����b�c);
				sw�o�׃L�[ += "," + axGT�o�׈ꗗ.get_CelText(n�s, n��_�o�^��);
				sw�o�׃L�[ += "," + axGT�o�׈ꗗ.get_CelText(n�s, n��_�W���[�i���m�n);
				sw�����ԍ� = axGT�o�׈ꗗ.get_CelText(n�s, n��_�����ԍ�).Trim();
				int iPosEnd = sw�����ԍ�.IndexOf('\r');
				if(iPosEnd > 1){
					sw�o�׃L�[ += "," + sw�����ԍ�.Substring(0,iPosEnd);
					sa�����ԍ�[iCnt�����] = sw�����ԍ�.Substring(0,iPosEnd);
					iCnt�����++;
				}else{
					sw�o�׃L�[ += ",";
				}
				sa�o�׃L�[[iCnt�o�׃L�[] = sw�o�׃L�[;
				iCnt�o�׃L�[++;
			}
			if(iCnt�o�׃L�[ == 0){
				return;
			}

// MOD 2011.05.20 ���s�j���� �b�r�u�o�͌`���̒ǉ� START
//			bool bCtrlKey = ((GetAsyncKeyState(Keys.ControlKey) & 0x8000) == 0) ? false : true;
//			// �R���g���[���L�[��������Ă��Ȃ���
//			if(!bCtrlKey){
			bool bShiftKey = ((GetAsyncKeyState(Keys.ShiftKey) & 0x8000) == 0) ? false : true;
			// �V�t�g�L�[��������Ă��Ȃ���
			if(!bShiftKey){
// MOD 2011.05.20 ���s�j���� �b�r�u�o�͌`���̒ǉ� END
				if(iCnt����� > 0){
//					if(iCnt����� == 1){
//						���ו��z�B�󋵏Ɖ�ڍ�(sa�����ԍ�[0]);
//					}else{
						���ו��z�B�󋵏Ɖ�ꗗ(sa�����ԍ�);
//					}
				}
				return;
			}

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try{
				string[] sList = new string[]{""};
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				sList = sv_maintenance.Get_SyukkaEtc(gsa���[�U,sa�o�׃L�[);
				if(sList[0].Length == 4){

					// �f�t�H���g�̃t�H���_���f�X�N�g�b�v�t�H���_�ɂ���
					saveFileDialog1.InitialDirectory
						= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
					saveFileDialog1.Filter = "�b�r�u�t�@�C�� (*.csv)|*.csv";
					byte[] bSJIS;
					if(saveFileDialog1.ShowDialog(this) == DialogResult.OK){
						System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
						for(int iCnt = 1; iCnt < sList.Length; iCnt++){
							bSJIS = toSJIS("\"" + sList[iCnt].Replace(",","\",\"'") + "\"");
							fs.Write(bSJIS, 0 , bSJIS.Length);
						}
						fs.Close();
						tex���b�Z�[�W.Text = "";
					}
				}else{
					�r�[�v��();
					tex���b�Z�[�W.Text = sList[0];
				}
			}catch (System.Net.WebException){
				tex���b�Z�[�W.Text = gs�ʐM�G���[;
			}catch(Exception ex){
				tex���b�Z�[�W.Text = ex.Message;
			}finally{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}
		static string[] sa�z����� = new string[]{
			 "���[�ԍ�","�W�דX�b�c","�W�ד�","�W�׎���","�����X�b�c","������"
			,"�����X�b�c","������","��������","���o�X�b�c","���o��","���o����"
			,"�z���X�b�c","�z����","�z������","���R�b�c"
			,"�폜�e�f","�o�^����","�o�^�o�f","�o�^��","�X�V����","�X�V�o�f","�X�V��"
		};
		private void �z�����擾�P(string[] sa�����ԍ�)
		{
			if(sa�����ԍ�[0].Length == 0) return;
			�z�����擾�Q(sa�����ԍ�[0]);
		}
		private void �z�����擾�Q(string s�����ԍ�)
		{
			string[] sData = new string[]{"0000" + s�����ԍ�};
			string[] sRet  = new string[]{""};
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try{
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				sRet = sv_maintenance.Sel_Haikan(gsa���[�U,sData);
				if(sRet[0].Length != 4){
					MessageBox.Show(sRet[0]
						, "�z���f�[�^�擾", MessageBoxButtons.OK );
					return;
				}
				if(sRet[1] == null){
					MessageBox.Show("�f�[�^������܂���"
						, "�z���f�[�^�擾", MessageBoxButtons.OK );
					return;
				}
				string sMsg = "";
				for(int iPos = 1; iPos < sRet.Length; iPos++){
					if(sRet[iPos] == null) break;
					if(iPos < sa�z�����.Length){
						sMsg += sa�z�����[iPos].PadRight(5,'�@');
					}
					sMsg += "�F["+sRet[iPos]+"]�@\n";
				}
				MessageBox.Show(sMsg
					, "�z���f�[�^�擾", MessageBoxButtons.OK );
			}catch (System.Net.WebException){
				MessageBox.Show(gs�ʐM�G���[
					, "�z���f�[�^�擾", MessageBoxButtons.OK );
			}catch(Exception ex){
				MessageBox.Show(ex.Message
					, "�z���f�[�^�擾", MessageBoxButtons.OK );
			}finally{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}

		/*********************************************************************
		* ���ו��z�B�󋵏Ɖ�i�v�����́u���ו��z�B�󋵏Ɖ�v�̕\���j
		* �����F�����ԍ��̔z��
		* �ߒl�F�Ȃ�
		**********************************************************************/
		static string[] saUrl���ו��z�B�󋵏Ɖ�ꗗ = new string[]{
			 "http://www2.fukutsu.co.jp/inq/INQJS120?toino="
			,"&some_order_number=0&some_status_message=0&toino="
			,"&some_order_number=1&some_status_message=1&toino="
			,"&some_order_number=2&some_status_message=2&toino="
			,"&some_order_number=3&some_status_message=3&toino="
			,"&some_order_number=4&some_status_message=4&toino="
			,"&some_order_number=5&some_status_message=5&toino="
			,"&some_order_number=6&some_status_message=6&toino="
			,"&some_order_number=7&some_status_message=7&toino="
			,"&some_order_number=8&some_status_message=8&toino="
			,"&some_order_number=9&some_status_message=9&btn1=%8C%9F%81@%8D%F5&order_number="
			,"&status_message="
		};
		private void ���ו��z�B�󋵏Ɖ�ꗗ(string[] as�����ԍ�)
		{
			if(as�����ԍ�[0].Length == 0) return;

			string sUrl = "";
			for(int iCnt = 0; iCnt < saUrl���ו��z�B�󋵏Ɖ�ꗗ.Length; iCnt++){
				sUrl += saUrl���ו��z�B�󋵏Ɖ�ꗗ[iCnt];
				if(iCnt >= as�����ԍ�.Length) continue;
				if(as�����ԍ�[iCnt] == null) continue;
				if(as�����ԍ�[iCnt].Length == 0) continue;
				sUrl += as�����ԍ�[iCnt];
			}
			Process.Start("iexplore.exe", sUrl);
		}
		
		/*********************************************************************
		* ���ו��z�B�󋵏Ɖ�ڍׁi�v�����́u���ו��z�B�󋵏Ɖ�v�̏ڍו\���j
		* �����F�����ԍ�
		* �ߒl�F�Ȃ�
		**********************************************************************/
		static string[] saUrl���ו��z�B�󋵏Ɖ�ڍ� = new string[]{
			 "http://www2.fukutsu.co.jp/inq/INQJS150?toino="
			,"&some_order_number=0&some_status_message=0&toino="
			,"&some_order_number=1&some_status_message=1&toino="
			,"&some_order_number=2&some_status_message=2&toino="
			,"&some_order_number=3&some_status_message=3&toino="
			,"&some_order_number=4&some_status_message=4&toino="
			,"&some_order_number=5&some_status_message=5&toino="
			,"&some_order_number=6&some_status_message=6&toino="
			,"&some_order_number=7&some_status_message=7&toino="
			,"&some_order_number=8&some_status_message=8&toino="
			,"&some_order_number=9&some_status_message=9&order_number="
			,"&status_message="
		};
		private void ���ו��z�B�󋵏Ɖ�ڍ�(string s�����ԍ�)
		{
			string sUrl = "";
			for(int iCnt = 0; iCnt < saUrl���ו��z�B�󋵏Ɖ�ڍ�.Length; iCnt++){
				sUrl += saUrl���ו��z�B�󋵏Ɖ�ڍ�[iCnt];
				if(iCnt == 0 || iCnt == 10){
					sUrl += s�����ԍ�;
				}
			}
			Process.Start("iexplore.exe", sUrl);
		}

// MOD 2010.11.19 ���s�j���� �z�����Ȃǂ̎擾 END

// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� START
		private void btn���ѕ\���_Click(object sender, System.EventArgs e)
		{
			string s�o�ד� = "";
			string s���v�L�[ = "";
			string s���v�L�[�ێ� = "";
			string s�K�� = "";
			int i�� = 0;
			int i�ː� = 0;
			int i�d�� = 0;
			int i�ی� = 0;
			int i�ː��d�� = 0;
			string s�^���ː� = "";
			string s�^���d�� = "";
			int i�������v = 0;
			int i�����v = 0;
			int i�d�ʏ��v = 0;
			int i�ی����v = 0;
			int i�^�� = 0;
			int i�^�����v = 0;
			string s����b�c = "";
			string[] sData = new string[10];
			tex���b�Z�[�W.Text = "";

			tex���q�l��.Text = "";
			tex�˗��喼.Text = "";

			tex�X��.Text = tex�X��.Text.TrimEnd();
			tex���q�l�R�[�h.Text = tex���q�l�R�[�h.Text.TrimEnd();
			tex�˗���R�[�h.Text = tex�˗���R�[�h.Text.TrimEnd();
			tex�����ԍ�.Text = tex�����ԍ�.Text.TrimEnd();

			//�����ԍ������͂���Ă���΁A���̏����͖���
			if(tex�����ԍ�.Text.Trim().Length > 0)
			{
				if(!���p�`�F�b�N(tex�X��, "�X���R�[�h")) return;
				if(!���p�`�F�b�N(tex�����ԍ�, "�����ԍ�")) return;
			}
			else
			{
				// [��Ԃb�c]��[���o��]�ȊO�̎��A[���q�l�R�[�h]���K�{
				if(!gsa��Ԃb�c[cmb���.SelectedIndex].Equals("90"))
				{
					if(!�K�{�`�F�b�N(tex���q�l�R�[�h, "���q�l�R�[�h")) return;
				}
				// [�Ǘ��ҋ敪]��[�Ǘ���]�ȊO�̎��A[�X���R�[�h]���K�{
				if(!gs�Ǘ��ҋ敪.Equals("1"))
				{
					if(!�K�{�`�F�b�N(tex�X��, "�X���R�[�h")) return;
				}
				if(!���p�`�F�b�N(tex�X��, "�X���R�[�h")) return;
				if(!���p�`�F�b�N(tex���q�l�R�[�h, "���q�l�R�[�h")) return;
				if(!���p�`�F�b�N(tex�˗���R�[�h, "�˗���R�[�h")) return;

				// ����}�X�^�`�F�b�N
				tex���q�l��.Text = "";
				if(tex���q�l�R�[�h.Text.Length > 0)
				{
					���q�l����();
					if(tex���q�l��.Text.Length == 0)
					{
						MessageBox.Show("���q�l�R�[�h�����������͂���Ă��܂���", "���̓`�F�b�N", MessageBoxButtons.OK);
						tex���q�l�R�[�h.Focus();
						return;
					}

					//�ב��l�}�X�^�`�F�b�N
					tex�˗���R�[�h.Text = tex�˗���R�[�h.Text.Trim();
					if(tex�˗���R�[�h.Text.Length > 0)
					{
						�˗��匟��();
						if(tex�˗��喼.Text.Length == 0)
						{
							MessageBox.Show("�˗���R�[�h�����������͂���Ă��܂���", "���̓`�F�b�N", MessageBoxButtons.OK);
							tex�˗���R�[�h.Focus();
							return;
						}
					}
				}

				tex���b�Z�[�W.Text = "";

				if (dt�J�n���t.Value > dt�I�����t.Value)
				{
					MessageBox.Show("���t�͈̔͂����������͂���Ă��܂���", "���̓`�F�b�N", MessageBoxButtons.OK);
					dt�J�n���t.Focus();
					return;
				}
				string s�J�n���t = YYYYMMDD�ϊ�(dt�J�n���t.Value.AddMonths(3));
				string s�I�����t = YYYYMMDD�ϊ�(dt�I�����t.Value);
				if (int.Parse(s�J�n���t) < int.Parse(s�I�����t))
				{
					MessageBox.Show("���t�͈̔͂́A�R�����ȓ��Ŏw�肵�Ă�������", "���̓`�F�b�N", MessageBoxButtons.OK);
					dt�J�n���t.Focus();
					return;
				}
			}

			s����b�c = tex���q�l�R�[�h.Text;
			sData[0] = s����b�c;

			//���˗��匟������Ƃ��Ă����ꍇ�́A����b�c�������ɓ����
			if(s�˗���b�c.Trim() == tex�˗���R�[�h.Text.Trim())
			{
				sData[1] = s����b�c;
			}
			else
			{
				sData[1] = "";
				tex�˗��喼.Text = "";
			}

			sData[2] = tex�˗���R�[�h.Text;
			sData[3] = cmb�o�ד�.SelectedIndex.ToString();
			sData[4] = YYYYMMDD�ϊ�(dt�J�n���t.Value);
			sData[5] = YYYYMMDD�ϊ�(dt�I�����t.Value);
			sData[6] = gsa��Ԃb�c[cmb���.SelectedIndex];

			if(tex�����ԍ�.Text.Trim().Length == 0)
			{
				sData[7] = "";
			}
			else
			{
				sData[7] = tex�����ԍ�.Text.Trim().PadLeft(15,'0');
			}

			switch(cmb�폜�敪.SelectedIndex)
			{
				case 1:
					sData[8] = "1";		// �폜��
					break;
				case 2:
					sData[8] = "2";		// �o�ו�
					break;
				default:
					sData[8] = "0";		// �S��
					break;
			}

			sData[9] = tex�X��.Text;

			string sSday = YYYYMMDD�ϊ�(dt�J�n���t.Value);
			string sEday = YYYYMMDD�ϊ�(dt�I�����t.Value);

			tex���b�Z�[�W.Text = "�o�׎��шꗗ������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sRet = new string[1];
				IEnumerator iEnum = null;

				if(sv_maintenance == null)
				{
					sv_maintenance = new is2maintenance.Service1();
				}
				iEnum = sv_maintenance.Get_PublishedPrintData4(gsa���[�U, sData).GetEnumerator();
				iEnum.MoveNext();
				sRet = (string[])iEnum.Current;
				if (sRet[0].Equals("����I��"))
				{
					�o�׎��уf�[�^ ds = new �o�׎��уf�[�^();

					int iCnt = 1;
					//�f�[�^�Z�b�g�ɒl���Z�b�g
					while (iEnum.MoveNext())
					{
						string[] sList = new string[40];
						sList = (string[])iEnum.Current;
					
						�o�׎��уf�[�^.table�o�׎���Row tr = (�o�׎��уf�[�^.table�o�׎���Row)ds.table�o�׎���.NewRow();
						tr.BeginEdit();

						if(cmb�o�ד�.SelectedIndex == 0)
						{
							// [�o�ד�]��[�o�ד�]�̏ꍇ
							s�o�ד� = sList[1].Trim(); //�o�ד�
						}
						else
						{
							// [�o�ד�]��[�o�^��]�̏ꍇ
							s�o�ד� = sList[0].Trim(); //�o�^��
						}

						/** ���y�[�W�L�[�̐ݒ� */
//						//�w�o�ד��^�o�^���x�̂�
//						s���v�L�[ = s�o�ד�;
						//�w�o�ד��^�o�^���x�{�w���˗���b�c�x
						s���v�L�[ = s�o�ד� + sList[15];
//						//�w�o�ד��^�o�^���x�{�w���Ӑ�b�c�x�{�w���ۂb�c�x
//						s���v�L�[ = s�o�ד� + sList[39] + sList[40];
//						//�w�o�ד��^�o�^���x�{�w���Ӑ�b�c�x�{�w���ۂb�c�x�{�w����b�c�x
//						s���v�L�[ = s�o�ד� + sList[39] + sList[40] + sList[49];

						if((s���v�L�[�ێ� != "") && (s���v�L�[�ێ� != s���v�L�[))
						{
							s���v�L�[�ێ� = s���v�L�[;
							tr.���v�t���O = 1;
							iCnt = 1;
							tr.�������v = i�������v;
							tr.�����v = i�����v;
							tr.�d�ʏ��v = i�d�ʏ��v;
							tr.�ی����v = i�ی����v;
							tr.�^�����v = i�^�����v;
							i�������v = 1;
							i�����v = 0;
							i�d�ʏ��v = 0;
							i�ی����v = 0;
							i�^�����v = 0;
						}
						else
						{
							if(s���v�L�[�ێ� == "")
							{
								s���v�L�[�ێ� = s���v�L�[;
							}
							tr.���v�t���O = 0;
							i�������v++;
						}

						tr.�ԍ� = iCnt++; //�Ԋ|������
//						tr.�ԍ� = -1; //�Ԋ|���Ȃ�

						if(cmb�o�ד�.SelectedIndex == 0)
						{
							tr.�o�^�� = sList[0].Substring(4,2) + "/" + sList[0].Substring(6,2);
							tr.�o�ד� = "�o�ד� " + sList[1].Substring(2,2) + "�N" + sList[1].Substring(4,2) + "��" + sList[1].Substring(6,2) + "��";
							tr.���t�^�C�g�� = "�o�^��";
						}
						else
						{
							tr.�o�ד� = "�o�^�� " + sList[0].Substring(2,2) + "�N" + sList[0].Substring(4,2) + "��" + sList[0].Substring(6,2) + "��";
							tr.�o�^�� = sList[1].Substring(4,2) + "/" + sList[1].Substring(6,2);
							tr.���t�^�C�g�� = "�o�ד�";
						}

						if(sList[2].Trim().Length == 0)
						{
							tr.�����ԍ� = sList[2].Trim();
						}
						else
						{
							tr.�����ԍ� = sList[2].Substring(4,3) + "-" + sList[2].Substring(7,4) + "-" + sList[2].Substring(11,4);
						}

						tr.�׎�l�R�[�h = sList[3].Trim();
						tr.�׎�l�X�֔ԍ� = sList[4].Substring(0,3) + "-" + sList[4].Substring(3,4);
						if(sList[5].Trim().Length == 0)
						{
							tr.�׎�l�d�b�ԍ� = sList[6].Trim() + "-" + sList[7].Trim();
						}
						else
						{
							tr.�׎�l�d�b�ԍ� = "(" + sList[5].Trim() + ")" + sList[6].Trim() + "-" + sList[7].Trim();
						}
//						tr.�׎�l�Z���P = sList[8].Trim() + sList[9].Trim();
//						tr.�׎�l�Z���Q = sList[10].Trim();
//						tr.�׎�l���O�P = sList[11].Trim() + "  " + sList[12].Trim();
						tr.�׎�l�Z���P = sList[8].TrimEnd() + sList[9].TrimEnd();
						tr.�׎�l�Z���Q = sList[10].TrimEnd();
						tr.�׎�l���O�P = sList[11].TrimEnd() + "  " + sList[12].TrimEnd();
						tr.���X�R�[�h = sList[13].Trim();
						tr.���X�� = sList[14].Trim();

						tr.�ב��l�R�[�h = sList[15].Trim();
						if(sList[16].Trim().Length != 0)
						{
							tr.�ב��l�X�֔ԍ� = sList[16].Substring(0,3) + "-" + sList[16].Substring(3,4);
						}

						if(sList[17].Trim().Length == 0)
						{
							tr.�ב��l�d�b�ԍ� = sList[18].Trim() + "-" + sList[19].Trim();
						}
						else
						{
							tr.�ב��l�d�b�ԍ� = "(" + sList[17].Trim() + ")" + sList[18].Trim() + "-" + sList[19].Trim();
						}
//						tr.�ב��l�Z���P = sList[20].Trim() + sList[21].Trim();
//						tr.�ב��l���O�P = sList[22].Trim() + "  " + sList[23].Trim();
//						tr.�S��  = sList[24].Trim();
						tr.�ב��l�Z���P = sList[20].TrimEnd() + sList[21].TrimEnd();
						tr.�ב��l���O�P = sList[22].TrimEnd() + "  " + sList[23].TrimEnd();
						tr.�S�� = sList[24].TrimEnd();

						i�� = int.Parse(sList[25].Trim());
						i�����v = i�����v + i��;
						tr.�� = sList[25].Trim();

						i�d�� = 0;
						i�ː� = 0;
						i�ː��d�� = 0;
						i�d�� = (int)(double.Parse(sList[26].Trim()) + 0.5);
						i�ː� = (int)(double.Parse(sList[36].Trim()) + 0.5);
						i�ː� = i�ː� * 8;
						i�ː��d�� = i�d�� + i�ː�;
						tr.�d�� = i�ː��d��.ToString("#,##0");
						if(i�ː��d�� == 0)
						{
							// �^���ː��A�^���d�ʂ����ݒ�̏ꍇ�͋�
							s�^���ː� = sList[42].TrimEnd();
							s�^���d�� = sList[43].TrimEnd();
							if(s�^���ː�.Length == 0 && s�^���d��.Length == 0)
							{
								tr.�d�� = "";
							}
						}
						i�d�ʏ��v += i�ː��d��;

						if(sList[37].Trim() == "0")
						{
							s�K�� = "�K��";
						}
						else
						{
							s�K�� = "�w��";
						}

						if(sList[27].Trim().Length == 1)
						{
							tr.�w��� = "";
						}
						else
						{
							tr.�w��� = sList[27].Substring(4,2) + "/" + sList[27].Substring(6,2) + s�K��;
						}

//						tr.�A���w���P = sList[28].Trim();
//						tr.�A���w���Q = sList[29].Trim();
//						tr.�i���L���P = sList[30].Trim();
//						tr.�i���L���Q = sList[31].Trim();
//						tr.�i���L���R = sList[32].Trim();
						tr.�A���w���P = sList[28].TrimEnd();
						tr.�A���w���Q = sList[29].TrimEnd();
						tr.�i���L���P = sList[30].TrimEnd();
						tr.�i���L���Q = sList[31].TrimEnd();
						tr.�i���L���R = sList[32].TrimEnd();
						if(sList.Length > 44)
						{
//							tr.�i���L���S = sList[44].Trim();
//							tr.�i���L���T = sList[45].Trim();
//							tr.�i���L���U = sList[46].Trim();
							tr.�i���L���S = sList[44].TrimEnd();
							tr.�i���L���T = sList[45].TrimEnd();
							tr.�i���L���U = sList[46].TrimEnd();
						}
						else
						{
							tr.�i���L���S = "";
							tr.�i���L���T = "";
							tr.�i���L���U = "";
						}

						if(sList[33].Trim() == "1")
						{
							tr.�����敪 = "����";
						}
						else
						{
							if(sList[33].Trim() == "2")
							{
								tr.�����敪 = "����";
							}
							else
							{
								tr.�����敪 = sList[33].Trim();
							}
						}

						i�ی� = int.Parse(sList[34].Trim());
						i�ی����v = i�ی����v + i�ی�;
						tr.�ی����z = i�ی�.ToString("#,##0");

						tr.���q�l�ԍ� = sList[35].Trim();

						i�^�� = int.Parse(sList[38].Trim());
						i�^�����v = i�^�����v + i�^��;
						if(i�^�� == 0)
						{
							tr.�^�� = "*";
						}
						else
						{
							tr.�^�� = i�^��.ToString("#,##0");
						}

//						//�w�w�b�_�P���́x�ɂ́A�����󎚂��Ȃ�
						tr.�w�b�_�P���� = "";
//						//�w�w�b�_�P���́x�ɁA�����������
//						tr.�w�b�_�P���� = "�@������" + " " + sList[39].Trim() + " " + sList[40].Trim() + " " + sList[41].Trim();
//						tr.�w�b�_�P���� = "�@������" + " " + sList[39].TrimEnd() + " " + sList[40].TrimEnd() + " " + sList[41].TrimEnd();
//						//�w�w�b�_�P���́x�ɁA���˗��������
//						tr.�w�b�_�P���� = "�@���˗���" + " " + sList[15].Trim() + " " + sList[22].Trim() + " " + sList[23].Trim();
//						tr.�w�b�_�P���� = "�@���˗���" + " " + sList[15].TrimEnd() + " " + sList[22].TrimEnd() + " " + sList[23].TrimEnd();


						if(sList[48].Trim().Substring(0,1) != "J")
						{
							tr.���q�^��FLG = "0";
						}
						else
						{
							tr.���q�^��FLG = "1";
						}

						tr.�z���������� = "�z�����t�E����";
						if(sList[47].Trim() != "")
						{
							tr.�z������ = "20" + sList[47].Substring(0,2) + "/" + sList[47].Substring(2,2) + "/" + sList[47].Substring(4,2)
								+ " " + sList[47].Substring(6,2) + ":" + sList[47].Substring(8,2);
						}
						else
						{
							tr.�z���������� = "";
							tr.�z������ = "";
						}

						tr.����R�[�h = sList[48].Trim();
						tr.����� = sList[49].Trim();

						tr.EndEdit();
						ds.table�o�׎���.Rows.Add(tr);
					}

					//���v�s���쐬
					�o�׎��уf�[�^.table�o�׎���Row tr2 = (�o�׎��уf�[�^.table�o�׎���Row)ds.table�o�׎���.NewRow();
					tr2.���v�t���O = 2;
					tr2.�ԍ� = 1;
					tr2.�������v = i�������v;
					tr2.�����v = i�����v;
					tr2.�d�ʏ��v = i�d�ʏ��v;
					tr2.�ی����v = i�ی����v;
					tr2.�^�����v = i�^�����v;
					ds.table�o�׎���.Rows.Add(tr2);

					ReportClass cr = new �o�׎��ђ��[();
//					ReportClass cr = new �o�׎��ђ��[�Q();

					//CrystalReport�Ƀp�����[�^�ƃf�[�^�Z�b�g��n��
//					cr.SetParameterValue("����b�c", "");
//					cr.SetParameterValue("���喼",   "");
					cr.SetParameterValue("���˗���󎚂Ȃ�", false);
					cr.SetParameterValue("�^���󎚂Ȃ�", false);
					cr.SetParameterValue("�Ж�����", false);
					cr.SetParameterValue("�T�u�^�C�g��", "");
					cr.SetDataSource(ds);

					//�v���r���[�\��
					�v���r���[��� ��� = new �v���r���[���();
					���.Left = this.Left;
					���.Top = this.Top;
					���.crv���[.PrintReport();
					���.crv���[.ReportSource = cr;
					���.ShowDialog();

					tex���b�Z�[�W.Text = "";
					try
					{
						cr.Close();
						cr.Dispose();
					}
					catch(Exception)
					{
						;
					}

					//�����I�̈�J��
					cr = null;
					ds = null;

					//�����I�K�x�[�W�R���N�^
					System.GC.Collect();
				}
				else
				{
					if(sRet[0].Equals("1000���I�[�o�["))
					{
						tex���b�Z�[�W.Text = "�f�[�^�������A1,000���ȏ�̂��߈���ł��܂���B�����������i�荞��ŉ������B";
						�r�[�v��();
					}
					else
					{
						tex���b�Z�[�W.Text = sRet[0];
						�r�[�v��();
					}
				}
			}
			catch (System.Net.WebException)
			{
				tex���b�Z�[�W.Text = gs�ʐM�G���[;
				�r�[�v��();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			tex���q�l�R�[�h.Focus();
		}

		private void btn���x���C���[�W���_Click(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W.Text = "";

			//�o�^���`�F�b�N
			if(axGT�o�׈ꗗ.get_CelText(axGT�o�׈ꗗ.CaretRow,17).Trim().Length == 0)
			{
				return;
			}

			//�A���󋵃`�F�b�N
			string s�A���� = gsa��Ԗ�[cmb���.SelectedIndex];
			if(s�A���� == "�����s")
			{
				�r�[�v��();
				MessageBox.Show(
						"�����s�f�[�^�̃��x���C���[�W�́A����ł��܂���B",
						"�o�׃��x���C���[�W���",
						MessageBoxButtons.OK
					);
				cmb���.Focus();
				return;
			}

			//��ԃ`�F�b�N
			string s�폜�敪 = cmb�폜�敪.SelectedItem.ToString();
			if(s�폜�敪 == "�폜")
			{
				�r�[�v��();
				MessageBox.Show(
						"�폜���ꂽ�o�׃f�[�^�̃��x���C���[�W�́A����ł��܂���B",
						"�o�׃��x���C���[�W���",
						MessageBoxButtons.OK
					);
				cmb�폜�敪.Focus();
				return;
			}

			tex���b�Z�[�W.Text = "���x���C���[�W������D�D�D";
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			short n�J�n;
			short n�I��;
			if(axGT�o�׈ꗗ.SelStartRow > axGT�o�׈ꗗ.SelEndRow)
			{
				n�I�� = axGT�o�׈ꗗ.SelStartRow;
				n�J�n = axGT�o�׈ꗗ.SelEndRow;
			}
			else
			{
				n�J�n = axGT�o�׈ꗗ.SelStartRow;
				n�I�� = axGT�o�׈ꗗ.SelEndRow;
			}

			short n�\���J�n = axGT�o�׈ꗗ.TopRow;
			string s�J�n�o�^�� = axGT�o�׈ꗗ.get_CelText(n�J�n,17).Trim();
			string s�J�n�W���[�i���m�n = axGT�o�׈ꗗ.get_CelText(n�J�n,16).Trim();
			string s�I���o�^�� = axGT�o�׈ꗗ.get_CelText(n�I��,17).Trim();
			string s�I���W���[�i���m�n = axGT�o�׈ꗗ.get_CelText(n�I��,16).Trim();
			string s���s�o�^�� = "";
			string s���s�W���[�i���m�n = "";
			short n���s = (short)(n�I�� + 1);
			if(n���s <= axGT�o�׈ꗗ.Rows)
			{
				s���s�o�^�� = axGT�o�׈ꗗ.get_CelText(n���s,17).Trim();
				s���s�W���[�i���m�n = axGT�o�׈ꗗ.get_CelText(n���s,16).Trim();
			}

			�����f�[�^�N���A();

			for(short nCnt = n�J�n ; nCnt <= n�I��; nCnt++)
			{
				try
				{
					// �o�׃f�[�^�̊e��X�e�[�^�X���`�F�b�N
					/** (1)�폜�ς̏o�׃f�[�^��I�����Ă��Ȃ����ǂ������`�F�b�N */
					string s�폜�X�e�[�^�X = axGT�o�׈ꗗ.get_CelText(nCnt, 1);
					if(s�폜�X�e�[�^�X == "��")
					{
						tex���b�Z�[�W.Text = "";
						�r�[�v��();
						Cursor = System.Windows.Forms.Cursors.Default;
						MessageBox.Show(
							"�폜���ꂽ�o�׃f�[�^���܂܂�܂��B���x���C���[�W�͈���ł��܂���B",
							"�o�׃��x���C���[�W���",
							MessageBoxButtons.OK
							);
						return;
					}

					/** (2)���x�������s�̏o�׃f�[�^��I�����Ă��Ȃ����ǂ������`�F�b�N */
					string s���s�σX�e�[�^�X = axGT�o�׈ꗗ.get_CelText(nCnt, 2);
					if(s���s�σX�e�[�^�X == " ")
					{
						tex���b�Z�[�W.Text = "";
						�r�[�v��();
						Cursor = System.Windows.Forms.Cursors.Default;
						MessageBox.Show(
								"���x�������s�̏o�׃f�[�^���܂܂�܂��B���x���C���[�W�͈���ł��܂���B",
								"�o�׃��x���C���[�W���",
								MessageBoxButtons.OK
							);
						return;
					}

					string[] sData = new string[4];
					//����b�c�A����b�c�A�o�^���A�W���[�i���m�n
					sData[0] = axGT�o�׈ꗗ.get_CelText(nCnt, 33); //����b�c
					sData[1] = axGT�o�׈ꗗ.get_CelText(nCnt, 34); //����b�c
					sData[2] = axGT�o�׈ꗗ.get_CelText(nCnt, 18); //�o�^��
					sData[3] = axGT�o�׈ꗗ.get_CelText(nCnt, 17); //�W���[�i���m�n

					//���x���C���[�W����p�f�[�^�쐬
					�׎D�T������w��(sData, 1, 99);
//					if(!gb���)
//					{
//						tex���b�Z�[�W.Text = "";
//						�r�[�v��();
//						Cursor = System.Windows.Forms.Cursors.Default;
//						MessageBox.Show("�W�דX���Ⴂ�܂��B����ł��܂���B", "�o�׃��x���C���[�W���", MessageBoxButtons.OK);
//						return;
//					}
				}
				catch (Exception ex)
				{
					tex���b�Z�[�W.Text = ex.Message;
					�r�[�v��();
					Cursor = System.Windows.Forms.Cursors.Default;
					return;
				}
			}

			�׎D�T�����[���();

			Cursor = System.Windows.Forms.Cursors.Default;

			// �Č���
			btn�o�׌���_Click(sender, e);
			�ꗗ�J�[�\���ړ�(n�J�n, n�I��, n�\���J�n
				, s�J�n�o�^��, s�J�n�W���[�i���m�n
				, s�I���o�^��, s�I���W���[�i���m�n
				, s���s�o�^��, s���s�W���[�i���m�n);
			tex���b�Z�[�W.Text = "";
		}

		private void �ꗗ�J�[�\���ړ�(short n�J�n, short n�I��, short n�\���J�n
			, string s�J�n�o�^��, string s�J�n�W���[�i���m�n
			, string s�I���o�^��, string s�I���W���[�i���m�n
			, string s���s�o�^��, string s���s�W���[�i���m�n)
		{
			//�I���s�̃N���A
			axGT�o�׈ꗗ.CaretRow = 1;
			axGT�o�׈ꗗ.SelStartRow = 1;
			axGT�o�׈ꗗ.SelEndRow = 1;
			axGT�o�׈ꗗ.CaretCol = 2;

			//�I���s�̐ݒ�
			short n�V�J�n = 0;
			short n�V�I�� = 0;

			//�I���J�n�s�ƑI���I���s�������Ȃ��ꍇ
			if(s�J�n�o�^�� == axGT�o�׈ꗗ.get_CelText(n�J�n,17).Trim()
				&& s�J�n�W���[�i���m�n == axGT�o�׈ꗗ.get_CelText(n�J�n,16).Trim()
				&& s�I���o�^�� == axGT�o�׈ꗗ.get_CelText(n�I��,17).Trim()
				&& s�I���W���[�i���m�n == axGT�o�׈ꗗ.get_CelText(n�I��,16).Trim())
			{
				n�V�J�n = n�J�n;
				n�V�I�� = n�I��;
			}
			else
			{
				for(short n�s = 1; n�s <= axGT�o�׈ꗗ.Rows; n�s++)
				{
					//�I���J�n�s�̒l�i�o�^���A�W���[�i���m�n�j�������ꍇ
					if(s�J�n�o�^�� == axGT�o�׈ꗗ.get_CelText(n�s,17).Trim()
						&& s�J�n�W���[�i���m�n == axGT�o�׈ꗗ.get_CelText(n�s,16).Trim())
					{
						n�V�J�n = n�s;
					}
					//�I���I���s�̒l�i�o�^���A�W���[�i���m�n�j�������ꍇ
					if(s�I���o�^�� == axGT�o�׈ꗗ.get_CelText(n�s,17).Trim()
						&& s�I���W���[�i���m�n == axGT�o�׈ꗗ.get_CelText(n�s,16).Trim())
					{
						n�V�I�� = n�s;
						break;
					}
				}
			}
			//�X�N���[���ʒu�̐ݒ�
			if(n�\���J�n <= axGT�o�׈ꗗ.Rows)
			{
				axGT�o�׈ꗗ.TopRow = n�\���J�n;
			}
			//�Č�����̈ꗗ�ɊY���f�[�^�����݂���ꍇ
			if(n�V�I�� > 0)
			{
				//�I���s���������ꍇ
				if(n�V�J�n > 0 && (n�I�� - n�J�n == n�V�I�� - n�V�J�n))
				{
					axGT�o�׈ꗗ.CaretRow = n�V�J�n;
					axGT�o�׈ꗗ.SelStartRow = n�V�J�n;
					axGT�o�׈ꗗ.SelEndRow = n�V�I��;
				}
				else
				{
					axGT�o�׈ꗗ.CaretRow = n�V�I��;
					axGT�o�׈ꗗ.SelStartRow = n�V�I��;
					axGT�o�׈ꗗ.SelEndRow = n�V�I��;
				}
			}
			else
			{
				if(s���s�o�^��.Length > 0 && s���s�W���[�i���m�n.Length > 0)
				{
					for(short n�s = 1; n�s <= axGT�o�׈ꗗ.Rows; n�s++)
					{
						//�I���J�n�s�̒l�i�o�^���A�W���[�i���m�n�j�������ꍇ
						if(s���s�o�^�� == axGT�o�׈ꗗ.get_CelText(n�s,17).Trim()
							&& s���s�W���[�i���m�n == axGT�o�׈ꗗ.get_CelText(n�s,16).Trim())
						{
							axGT�o�׈ꗗ.CaretRow = n�s;
							axGT�o�׈ꗗ.SelStartRow = n�s;
							axGT�o�׈ꗗ.SelEndRow = n�s;
							break;
						}
					}
				}
			}
			axGT�o�׈ꗗ_CurPlaceChanged(null,null);
		}

		protected static string �S���W�דX���擾(string s����b�c, string s����b�c)
		{
			try
			{
				// ����X���̎擾
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				if(sv_oji == null) sv_oji = new is2oji.Service1();
				String[] sRet;
				if (s����b�c.Substring(0,1) != "J")
				{
					sRet = sv_maintenance.Get_hatuten3(gsa���[�U, s����b�c, s����b�c);

				}
				else
				{
					sRet = sv_oji.Get_hatuten3(gsa���[�U, s����b�c, s����b�c);
				}

				if(sRet[0].Length == 4)
				{
					return sRet[1];
				}
				else
				{
					�r�[�v��();
					MessageBox.Show(sRet[0], "�W�דX�擾", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch(System.Net.WebException)
			{
				�r�[�v��();
				MessageBox.Show(gs�ʐM�G���[, "�ʐM�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch(Exception ex)
			{
				�r�[�v��();
				MessageBox.Show(ex.Message, "�ʐM�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return "";
		}

		protected void �׎D�T������w��(string[] sData, int i�J�n, int i�I��)
		{
//			gb��� = true;
			string s����b�c = sData[0];
			string s����b�c = sData[1];

			try
			{
				//����f�[�^�̍쐬
				string[] sPrintKey = new string[4];
				sPrintKey[0] = s����b�c;    //����b�c
				sPrintKey[1] = s����b�c;    //����b�c
				sPrintKey[2] = sData[2];	//�o�^��
				sPrintKey[3] = sData[3];	//�W���[�i���m�n

				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				if(sv_oji == null) sv_oji = new is2oji.Service1();

				string[] sPrintData;
				if (s����b�c.Substring(0,1) != "J")
				{
					sPrintData = sv_maintenance.Get_InvoicePrintData(gsa���[�U, sPrintKey);
				}
				else
				{
					sPrintData = sv_oji.Get_InvoicePrintData(gsa���[�U, sPrintKey);
				}

				if (!sPrintData[0].Equals("����I��"))
				{
					throw new Exception(sPrintData[0]);
				}

//				// �X���`�F�b�N
//				string s�S���W�דX�R�[�h = �S���W�דX���擾(s����b�c, s����b�c);
//				/** (1)�S���W�דX�ƃ��O�C���X�����Ⴄ�ꍇ */
//				if(s�S���W�דX�R�[�h.Trim() != gs�X���R�[�h)
//				{
//					gb��� = false;
//					return;
//				}
//				/** (2)�S���W�דX�Əo�׃f�[�^�̔��X���Ⴄ�ꍇ */
//				if(s�S���W�דX�R�[�h.Trim() != sPrintData[14].Substring(1, 3))
//				{
//					gb��� = false;
//					return;
//				}
//				/** (3)���O�C���X���Əo�׃f�[�^�̔��X���Ⴄ�ꍇ */
//				if(gs�X���R�[�h != sPrintData[14].Substring(1, 3))
//				{
//					gb��� = false;
//					return;
//				}

//				sPrintData[5] = sPrintData[5].Trim(); // �׎�l�Z���P
//				sPrintData[6] = sPrintData[6].Trim(); // �׎�l�Z���Q
//				sPrintData[7] = sPrintData[7].Trim(); // �׎�l�Z���R
//				sPrintData[8] = sPrintData[8].Trim(); // �׎�l���O�P
//				sPrintData[9] = sPrintData[9].Trim(); // �׎�l���O�Q
//				sPrintData[18] = sPrintData[18].Trim(); // �ב��l�Z���P
//				sPrintData[19] = sPrintData[19].Trim(); // �ב��l�Z���Q
//				sPrintData[21] = sPrintData[21].Trim(); // �ב��l���O�P
//				sPrintData[22] = sPrintData[22].Trim(); // �ב��l���O�Q
//				sPrintData[34] = sPrintData[34].Trim(); // �S����
//				sPrintData[29] = sPrintData[29].Trim(); // �i���L���P
//				sPrintData[30] = sPrintData[30].Trim(); // �i���L���Q
//				sPrintData[31] = sPrintData[31].Trim(); // �i���L���R
//				if(sPrintData.Length > 42)
//				{
//					sPrintData[42] = sPrintData[42].Trim(); // �i���L���S
//					sPrintData[43] = sPrintData[43].Trim(); // �i���L���T
//					sPrintData[44] = sPrintData[44].Trim(); // �i���L���U
//				}
				sPrintData[5] = sPrintData[5].TrimEnd(); // �׎�l�Z���P
				sPrintData[6] = sPrintData[6].TrimEnd(); // �׎�l�Z���Q
				sPrintData[7] = sPrintData[7].TrimEnd(); // �׎�l�Z���R
				sPrintData[8] = sPrintData[8].TrimEnd(); // �׎�l���O�P
				sPrintData[9] = sPrintData[9].TrimEnd(); // �׎�l���O�Q
				sPrintData[18] = sPrintData[18].TrimEnd(); // �ב��l�Z���P
				sPrintData[19] = sPrintData[19].TrimEnd(); // �ב��l�Z���Q
				sPrintData[21] = sPrintData[21].TrimEnd(); // �ב��l���O�P
				sPrintData[22] = sPrintData[22].TrimEnd(); // �ב��l���O�Q
				sPrintData[34] = sPrintData[34].TrimEnd(); // �S����
				sPrintData[29] = sPrintData[29].TrimEnd(); // �i���L���P
				sPrintData[30] = sPrintData[30].TrimEnd(); // �i���L���Q
				sPrintData[31] = sPrintData[31].TrimEnd(); // �i���L���R
				if(sPrintData.Length > 42)
				{
					sPrintData[42] = sPrintData[42].TrimEnd(); // �i���L���S
					sPrintData[43] = sPrintData[43].TrimEnd(); // �i���L���T
					sPrintData[44] = sPrintData[44].TrimEnd(); // �i���L���U
				}

				// ��(sPrintData[23])�͎g�p�����A�P��݈̂������
//				int iLabel�I�� = int.Parse(sPrintData[23]);
				int iLabel�I�� = 1;
				if(iLabel�I�� > i�I��)
				{
					iLabel�I�� = i�I��;
				}

				for (int iPage = i�J�n; iPage <= iLabel�I��; iPage++)
				{
					�����f�[�^.table�����Row tr = (�����f�[�^.table�����Row)ds�����.table�����.NewRow();
					tr.BeginEdit();
					tr.����� = i�����++;

					if(sPrintData[12].Length >= 7)
					{
						tr.�׎�l�X�֔ԍ� = "��";
						tr.�׎�l�X�֔ԍ� += sPrintData[12].Substring(0,3);
						tr.�׎�l�X�֔ԍ� += "-";
						tr.�׎�l�X�֔ԍ� += sPrintData[12].Substring(3,4);
					}
					else
					{
						tr.�׎�l�X�֔ԍ� = "";
					}

					tr.�׎�l�b�c     = "";
//					tr.�׎�l�b�c     = sPrintData[1];
					tr.�׎�l�d�b�ԍ� = "(" + sPrintData[2] + ")" + sPrintData[3] + "-" + sPrintData[4];
					if(sPrintData[2].Replace("0","").Trim().Length == 0
						&& sPrintData[3].Replace("0","").Trim().Length == 0
						&& sPrintData[4].Replace("0","").Trim().Length == 0)
					{
						tr.�׎�l�d�b�ԍ� = " ";
					}
					tr.�׎�l�Z����   = "";
					tr.�׎�l�Z���s   = "";
					tr.�׎�l�Z����   = "";
					tr.�׎�l�Z���P   = sPrintData[5];
					tr.�׎�l�Z���Q   = sPrintData[6];
					tr.�׎�l�Z���R   = sPrintData[7];
					tr.�׎�l���O�P   = sPrintData[8];
					tr.�׎�l���O�Q   = sPrintData[9];
					if (sPrintData[5].Equals("�����x�X�~�߁���"))
					{
						// �x�X�~�߂ł���Ƃ��A�׎�l�Z�����ڂɈȉ��̐ݒ���s�Ȃ�
						// �@�E�׎�l�Z�����F�u�����x�X�~�߁����v�i���[���ڂ̕\������Ɏg�p�A��\�����ځj
						// �@�E�׎�l�Z���P�F�u���R�ʉ^�^���q�^���v����
						// �@�E�׎�l�Z���Q�F�u�����x�X�^�c�Ə��~�߁v
						// �@�E�׎�l�Z���R�F�����󎚂��Ȃ�
						tr.�׎�l�Z���� = sPrintData[5];
						if(sPrintData[6].Substring(0, 2) == "���q")
						{
							tr.�׎�l�Z���P = "���q�^��";
						}
						else
						{
							tr.�׎�l�Z���P = "���R�ʉ^";
						}
						tr.�׎�l�Z���R = "";
					}

					tr.�o�ד��N       = sPrintData[10];
					if(sPrintData[10].Substring(4, 1) == "0")
					{
						tr.�o�ד���       = " " + sPrintData[10].Substring(5, 1);
					}
					else
					{
						tr.�o�ד���       = sPrintData[10].Substring(4, 2);
					}

					if(sPrintData[10].Substring(6, 1) == "0")
					{
						tr.�o�ד���       = " " + sPrintData[10].Substring(7, 1);
					}
					else
					{
						tr.�o�ד���       = sPrintData[10].Substring(6, 2);
					}

					tr.�����ԍ�     = sPrintData[11].Substring(4,3) + "-" + sPrintData[11].Substring(7,4) + "-" + sPrintData[11].Substring(11,4);
					tr.�o�[�R�[�h     = "A" + sPrintData[11].Substring(4) + "A";

					if(sPrintData[13].Length == 0)
					{
						tr.���X�b�c       = "";
					}
					else
					{
						tr.���X�b�c       = sPrintData[13].Substring(1);
					}
					if(sPrintData[13].Equals("0000"))
					{
						tr.���X�b�c       = "";
					}

					//�d���b�c���ݒ肳��Ă���ꍇ�A�d���b�c����
					if(sPrintData[37].Length > 0)
					{
						tr.�d���b�c       = sPrintData[37];
					}
					else
					{
						tr.�d���b�c       = "";
					}

					tr.���X�b�c       = sPrintData[14].Substring(1, 3);

					//�O���[�o���Ή��i�o�ד��A���X�̔�\���j
					if(sPrintData[14].Substring(1, 3) == "047")
					{
						tr.�o�ד��N       = "";
						tr.�o�ד���       = "";
						tr.�o�ד���       = "";
						tr.���X��         = "";
						tr.���X�b�c       = "";
					}

					if(sPrintData.Length > 40 && sPrintData[40].Length >= 7)
					{
						tr.�ב��l�X�֔ԍ� = "��";
						tr.�ב��l�X�֔ԍ� += sPrintData[40].Substring(0,3);
						tr.�ב��l�X�֔ԍ� += "-";
						tr.�ב��l�X�֔ԍ� += sPrintData[40].Substring(3,4);
					}
					else
					{
						tr.�ב��l�X�֔ԍ� = "";
					}

					tr.�ב��l�d�b�ԍ� = "(" + sPrintData[15] + ")" + sPrintData[16] + "-" + sPrintData[17];
					tr.�ב��l�Z���P   = �Z���ҏW(sPrintData[18]);
					tr.�ב��l�Z���Q   = sPrintData[19];
					tr.�ב��l�Z���R   = sPrintData[18];
					tr.�ב��l���O�P   = sPrintData[21];
					tr.�ב��l���O�Q   = sPrintData[22];
					tr.�S����         = sPrintData[34];
					tr.��           = sPrintData[23];

					// �A�Ԃ͂O�Œ�Ƃ���B
//					tr.�A��           = iPage.ToString();
					tr.�A��           = "0";
					tr.�d��           = sPrintData[24];

					int i�ی��� = int.Parse(sPrintData[25]) * 10;
					if(i�ی��� > 0 && i�ی��� < 50)
					{
						tr.�ی���     = "50";
					}
					else
					{
						string s�ی��� = i�ی���.ToString();
						if(s�ی���.Length == 4)
						{
							s�ی��� = s�ی���.Insert(1,",");
						}
						else
						{
							if(s�ی���.Length == 5)
							{
								s�ی��� = s�ی���.Insert(2,",");
							}
						}
						tr.�ی���     = s�ی���;
					}

					string s�w�茎;
					string s�w���;
					if (sPrintData[26] != null && !sPrintData[26].Equals("") && !sPrintData[26].Equals("0"))
					{
						if(sPrintData[26].Substring(4, 1) == "0")
						{
							s�w�茎 = " " + sPrintData[26].Substring(5, 1);
						}
						else
						{
							s�w�茎 = sPrintData[26].Substring(4, 2);
						}

						if(sPrintData[26].Substring(6, 1) == "0")
						{
							s�w��� = " " + sPrintData[26].Substring(7, 1);
						}
						else
						{
							s�w��� = sPrintData[26].Substring(6, 2);
						}

						tr.�w���     = s�w�茎 + "��" + s�w��� + "��";
						if (sPrintData[36].Equals("0"))
						{
							tr.�w��� += "�K��";
						}
						else if (sPrintData[36].Equals("1"))
						{
							tr.�w��� += "�w��";
						}
					}
					else
					{
						tr.�w���     = "";
					}

					if(sPrintData[35].Length != 0)
					{
						tr.���q�l�ԍ�     = "���q�l�ԍ�:" + sPrintData[35];
					}
					else
					{
						tr.���q�l�ԍ�     = sPrintData[35];
					}

					tr.�A���L���P     = sPrintData[27];
					tr.�A���L���Q     = sPrintData[28];
					tr.�i���L���P     = sPrintData[29];
					tr.�i���L���Q     = sPrintData[30];
					tr.�i���L���R     = sPrintData[31];

					if(sPrintData.Length > 42)
					{
						tr.�i���L���S = sPrintData[42];
						tr.�i���L���T = sPrintData[43];
						tr.�i���L���U = sPrintData[44];
					}
					else
					{
						tr.�i���L���S = "";
						tr.�i���L���T = "";
						tr.�i���L���U = "";
					}
					if(tr.�i���L���S.Length > 0 || tr.�i���L���T.Length > 0 || tr.�i���L���U.Length > 0)
					{
						// �S�p�X�����A���͔��p�P�W����
						tr.�i���L���P = �o�C�g���J�b�g(tr.�i���L���P, 18);
						tr.�i���L���Q = �o�C�g���J�b�g(tr.�i���L���Q, 18);
						tr.�i���L���R = �o�C�g���J�b�g(tr.�i���L���R, 18);
						tr.�i���L���S = �o�C�g���J�b�g(tr.�i���L���S, 18);
						tr.�i���L���T = �o�C�g���J�b�g(tr.�i���L���T, 18);
						tr.�i���L���U = �o�C�g���J�b�g(tr.�i���L���U, 18);
					}

					tr.�׎�l�t�H���g�T�C�Y�g��FLG = "0";
//					tr.�׎�l�t�H���g�T�C�Y�g��FLG = "1";

					if(s����b�c.Substring(0,1) != "J")
					{
						tr.���q�^��FLG = "0";
					}
					else
					{
						tr.���q�^��FLG = "1";
					}

					string s�d�ʓ��͐��� = (sPrintData.Length > 41) ? sPrintData[41] : "0";
					tr.�d�ʓ��͐��� = s�d�ʓ��͐���;

					if(tr.���X�b�c == "" || tr.���X�b�c == "000")
					{
						tr.���X��     = ""; // ���X�b�c�����ݒ莞(�O���[�o����)
					}
					else
					{
						if(sPrintData[38] == "")
						{
							tr.���X��     = tr.���X�b�c;
						}
						else
						{
							tr.���X��     = sPrintData[38];
						}
					}
					string s���X�� = (sPrintData.Length > 45) ? sPrintData[45] : "";
					if(tr.���X�b�c == "" || tr.���X�b�c == "000")
					{
						tr.���X��     = ""; // ���X�b�c�����ݒ莞
					}
					else
					{
						if(s���X�� == "")
						{
							tr.���X��     = tr.���X�b�c;
						}
						else
						{
							tr.���X��     = s���X��;
						}
					}
					// �����x���̃o�b�N�̍��h��[���X��]�ɐݒ肵�Ă����
					//   ���X�����\������Ȃ����A�o�b�N�̐F�������܂�

// MOD 2016.04.15 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� START
					//�Г��`�[�ł���΁A�l���Z�b�g����
					if(s����b�c.Substring(0,2).ToUpper().Equals("FK"))
					{
						// �Г��`�[�ł���Ƃ��A�׎�l�Z�����ڂɈȉ��̐ݒ���s�Ȃ�
						// �@�E�׎�l�Z�����@�@�@�@�@�F�u�����Г��`�[�����v
						//�@�@�@�i���[���ڂ̕\������Ɏg�p�A��\�����ځj
						// �@�E���X�b�c�i��j�@�@�@�@�F�󎚂��Ȃ�
						// �@�E���X�b�c�i���j�@�@�@�@�F�󎚂���
						// �@�E�w�Г���p�x�e�L�X�g�F�󎚂���
						tr.�׎�l�Z���� = "�����Г��`�[����";
					}
// MOD 2016.04.15 BEVAS�j���{ �Г��`�[�@�\�ǉ��Ή� END

					tr.EndEdit();

					ds�����.table�����.Rows.Add(tr);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected void �׎D�T�����[���()
		{
			// �����I�K�x�[�W�R���N�^
			System.GC.Collect();

			// �v���r���[�\��
			�����T���`�S���[ crA4 = new �����T���`�S���[();

			DataView dv = ds�����.table�����.DefaultView;
			dv.Sort = "����� ASC";
			DataTable dt2 = ds�����.table�����.Clone();
			foreach (DataRowView drv in dv) 
			{
				dt2.Rows.Add(drv.Row.ItemArray);
			}
			dt2.AcceptChanges();
			crA4.SetDataSource(dt2);

			�v���r���[��� ��� = new �v���r���[���();
			���.crv���[.PrintReport();
			���.crv���[.ReportSource = crA4;
			���.ShowDialog();

			// �����I�̈�J��
			crA4 = null;
			dv  = null;
			dt2 = null;

			// �����I�K�x�[�W�R���N�^
			System.GC.Collect();

			�����f�[�^�N���A();
		}

		protected void �����f�[�^�N���A()
		{
			i����� = 0;

			ds�����.Clear();

			//�����I�̈�J��
			ds����� = null;

			//�����I�K�x�[�W�R���N�^
			System.GC.Collect();

			//�����f�[�^�̈�č쐬
			ds����� = new �����f�[�^();
		}

		protected string �Z���ҏW(string s�Z��)
		{
			if(s�Z��.Length <= 2)
			{
				return s�Z��;
			}

			// �s���{���n�b�V���e�[�u���̍쐬
			if(h�� == null)
			{
				h�� = new Hashtable();
				for(int iCnt = 1; iCnt < sa��.Length; iCnt++)
				{
					h��.Add(iCnt,sa��[iCnt]);
				}
			}

			string s����   = "";
			string s�s��S = "";
			string s�ҏW�� = "";
			string s�ҏW�� = "";
			int    iIndex  = 0;

			// �u�_�ސ쌧�v�A�u�a�̎R���v�A�u���������v�͂S�����ŕ�������r����
			if(s�Z��.StartsWith("�_") || s�Z��.StartsWith("�a") || s�Z��.StartsWith("��"))
			{
				if(s�Z��.Length >= 4)
				{
					s�ҏW�� = s�Z��.Substring(0,4);
					iIndex  = 4;
				}
			}
			else
			{
				s�ҏW�� = s�Z��.Substring(0,3);
				iIndex  = 3;
			}

			if(h��.ContainsValue(s�ҏW��))
			{
				s����   = s�ҏW��;
				s�ҏW�� = s�Z��.Remove(0,iIndex);
			}
			else
				s�ҏW�� = s�Z��;

			s�s��S = s�ҏW��;
			for(int iCnt = 0; iCnt < sa�s��S.Length; iCnt++)
			{
				if(sa�s��S[iCnt].Length <= s�s��S.Length)
				{
					if(sa�s��S[iCnt] == s�s��S.Substring(0,sa�s��S[iCnt].Length))
					{
						s�s��S = s�ҏW��.Insert(sa�s��S[iCnt].Length," ");
						s�ҏW�� = s���� + " " + s�s��S;
						return s�ҏW��.Trim();
					}
				}
			}

			for(iIndex = 1; iIndex < s�ҏW��.Length; iIndex++)
			{
				if(s�ҏW��.Substring(iIndex,1) == "�s"
					|| s�ҏW��.Substring(iIndex,1) == "��"
					|| s�ҏW��.Substring(iIndex,1) == "�S")
				{
					s�s��S = s�ҏW��.Insert(iIndex + 1," ");
					break;
				}
			}
			s�ҏW�� = s���� + " " + s�s��S;
			return s�ҏW��.Trim();
		}

		protected static string �o�C�g���J�b�g(string data, int iMaxLength)
		{
			string sRet = data;
			byte[] bSjis;

			bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(data);
			//�͈͓��Ȃ炻�̂܂ܖ߂�
			if(bSjis.Length <= iMaxLength)
			{
				return sRet;
			}

			try
			{
				string sUnicode;
				for(int iLen = iMaxLength / 2; iLen <= data.Length; iLen++)
				{
					sUnicode = data.Substring(0,iLen);
					bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sUnicode);
					if(bSjis.Length > iMaxLength)
					{
						break;
					}
					sRet = sUnicode;
				}
			}
			catch(Exception)
			{
				;
			}

			return sRet;
		}
// ADD 2015.11.19 BEVAS�j���{ ���R�샍�O�C������яo�׎��ѕ\�E���x���C���[�W����Ή� END
	}
}
