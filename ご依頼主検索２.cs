// ADD 2007.11.14 KCL) �X�{ [���˗��匟��]�t�H�[�����R�s�[���A���O��[���˗��匟���Q]�ɕύX�iglobal�Ή��j START
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [���˗��匟���Q]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 ���s�j���� ���˗��喼�̑S�p�`�F�b�N�̒ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2009.05.11 ���s�j���� ���o�בΉ� 
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� 
	//--------------------------------------------------------------------------
	public class ���˗��匟���Q : ���ʃt�H�[��
	{
		private short nOldRow = 0;
		public string sIcode;     //���˗���b�c
		public string sIname;     //���˗��喼
		public string sBcode;     //����b�c
		public string sKcode;     //���q�l�b�c
		public string sKname;     //���q�l��
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
		public string s�X���R�[�h;
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END

		private int      i�A�N�e�B�u�e�f = 0;

		private string[] s�˗���ꗗ;
		private int      i���ݕŐ�;
		private int      i�ő�Ő�;
		private int      i�J�n��;
		private int      i�I����;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label lab�˗���R�[�h;
		private ���ʃe�L�X�g�{�b�N�X tex�˗���R�[�h;
		private System.Windows.Forms.Label lab�˗���^�C�g��;
		private System.Windows.Forms.Button btn�m��;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private AxGTABLE32V2Lib.AxGTable32 axGT�˗���;
		private System.Windows.Forms.Label lab�Ŕԍ�;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�O��;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lab���˗��喼;
		private System.Windows.Forms.Label label1;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex���q�l�R�[�h;
		private System.Windows.Forms.Button btn���q�l����;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�˗��喼;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ���˗��匟���Q()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(���˗��匟���Q));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab�Ŕԍ� = new System.Windows.Forms.Label();
			this.btn���� = new System.Windows.Forms.Button();
			this.btn�O�� = new System.Windows.Forms.Button();
			this.axGT�˗��� = new AxGTABLE32V2Lib.AxGTable32();
			this.btn�m�� = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btn���q�l���� = new System.Windows.Forms.Button();
			this.tex���q�l�R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label1 = new System.Windows.Forms.Label();
			this.tex�˗��喼 = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab���˗��喼 = new System.Windows.Forms.Label();
			this.lab�˗���R�[�h = new System.Windows.Forms.Label();
			this.tex�˗���R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn���� = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab�˗���^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
			this.btn���� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axGT�˗���)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.lab�Ŕԍ�);
			this.panel1.Controls.Add(this.btn����);
			this.panel1.Controls.Add(this.btn�O��);
			this.panel1.Controls.Add(this.axGT�˗���);
			this.panel1.Controls.Add(this.btn�m��);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(741, 350);
			this.panel1.TabIndex = 1;
			// 
			// lab�Ŕԍ�
			// 
			this.lab�Ŕԍ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�Ŕԍ�.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�Ŕԍ�.Location = new System.Drawing.Point(606, 294);
			this.lab�Ŕԍ�.Name = "lab�Ŕԍ�";
			this.lab�Ŕԍ�.Size = new System.Drawing.Size(48, 14);
			this.lab�Ŕԍ�.TabIndex = 70;
			this.lab�Ŕԍ�.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn����
			// 
			this.btn����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn����.ForeColor = System.Drawing.Color.White;
			this.btn����.Location = new System.Drawing.Point(654, 290);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(48, 22);
			this.btn����.TabIndex = 69;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// btn�O��
			// 
			this.btn�O��.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�O��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�O��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�O��.ForeColor = System.Drawing.Color.White;
			this.btn�O��.Location = new System.Drawing.Point(558, 290);
			this.btn�O��.Name = "btn�O��";
			this.btn�O��.Size = new System.Drawing.Size(48, 22);
			this.btn�O��.TabIndex = 68;
			this.btn�O��.Text = "�O��";
			this.btn�O��.Click += new System.EventHandler(this.btn�O��_Click);
			// 
			// axGT�˗���
			// 
			this.axGT�˗���.ContainingControl = this;
			this.axGT�˗���.DataSource = null;
			this.axGT�˗���.Location = new System.Drawing.Point(20, 8);
			this.axGT�˗���.Name = "axGT�˗���";
			this.axGT�˗���.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT�˗���.OcxState")));
			this.axGT�˗���.Size = new System.Drawing.Size(700, 271);
			this.axGT�˗���.TabIndex = 2;
			this.axGT�˗���.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT�˗���_KeyDownEvent);
			this.axGT�˗���.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT�˗���_CelDblClick);
			this.axGT�˗���.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT�˗���_CurPlaceChanged);
			// 
			// btn�m��
			// 
			this.btn�m��.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�m��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�m��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�m��.ForeColor = System.Drawing.Color.White;
			this.btn�m��.Location = new System.Drawing.Point(652, 320);
			this.btn�m��.Name = "btn�m��";
			this.btn�m��.Size = new System.Drawing.Size(64, 22);
			this.btn�m��.TabIndex = 1;
			this.btn�m��.TabStop = false;
			this.btn�m��.Text = "�m��";
			this.btn�m��.Click += new System.EventHandler(this.btn�m��_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Honeydew;
			this.panel5.Controls.Add(this.btn���q�l����);
			this.panel5.Controls.Add(this.tex���q�l�R�[�h);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.tex�˗��喼);
			this.panel5.Controls.Add(this.lab���˗��喼);
			this.panel5.Controls.Add(this.lab�˗���R�[�h);
			this.panel5.Controls.Add(this.tex�˗���R�[�h);
			this.panel5.Controls.Add(this.btn����);
			this.panel5.Location = new System.Drawing.Point(1, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(435, 82);
			this.panel5.TabIndex = 0;
			// 
			// btn���q�l����
			// 
			this.btn���q�l����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn���q�l����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn���q�l����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn���q�l����.ForeColor = System.Drawing.Color.White;
			this.btn���q�l����.Location = new System.Drawing.Point(228, 4);
			this.btn���q�l����.Name = "btn���q�l����";
			this.btn���q�l����.Size = new System.Drawing.Size(64, 22);
			this.btn���q�l����.TabIndex = 49;
			this.btn���q�l����.TabStop = false;
			this.btn���q�l����.Text = "����";
			this.btn���q�l����.Click += new System.EventHandler(this.btn���q�l����_Click);
			// 
			// tex���q�l�R�[�h
			// 
			this.tex���q�l�R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex���q�l�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���q�l�R�[�h.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.tex���q�l�R�[�h.Location = new System.Drawing.Point(118, 2);
			this.tex���q�l�R�[�h.MaxLength = 10;
			this.tex���q�l�R�[�h.Name = "tex���q�l�R�[�h";
			this.tex���q�l�R�[�h.Size = new System.Drawing.Size(104, 23);
			this.tex���q�l�R�[�h.TabIndex = 0;
			this.tex���q�l�R�[�h.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.LimeGreen;
			this.label1.Location = new System.Drawing.Point(8, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 16);
			this.label1.TabIndex = 47;
			this.label1.Text = "���q�l�R�[�h";
			// 
			// tex�˗��喼
			// 
			this.tex�˗��喼.BackColor = System.Drawing.SystemColors.Window;
			this.tex�˗��喼.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�˗��喼.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�˗��喼.Location = new System.Drawing.Point(118, 28);
			this.tex�˗��喼.MaxLength = 10;
			this.tex�˗��喼.Name = "tex�˗��喼";
			this.tex�˗��喼.Size = new System.Drawing.Size(174, 23);
			this.tex�˗��喼.TabIndex = 1;
			this.tex�˗��喼.Text = "";
			// 
			// lab���˗��喼
			// 
			this.lab���˗��喼.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���˗��喼.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���˗��喼.Location = new System.Drawing.Point(8, 32);
			this.lab���˗��喼.Name = "lab���˗��喼";
			this.lab���˗��喼.Size = new System.Drawing.Size(110, 16);
			this.lab���˗��喼.TabIndex = 46;
			this.lab���˗��喼.Text = "���˗��喼";
			// 
			// lab�˗���R�[�h
			// 
			this.lab�˗���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�˗���R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�˗���R�[�h.Location = new System.Drawing.Point(8, 58);
			this.lab�˗���R�[�h.Name = "lab�˗���R�[�h";
			this.lab�˗���R�[�h.Size = new System.Drawing.Size(110, 16);
			this.lab�˗���R�[�h.TabIndex = 6;
			this.lab�˗���R�[�h.Text = "���˗���R�[�h";
			// 
			// tex�˗���R�[�h
			// 
			this.tex�˗���R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex�˗���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�˗���R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�˗���R�[�h.Location = new System.Drawing.Point(118, 54);
			this.tex�˗���R�[�h.MaxLength = 12;
			this.tex�˗���R�[�h.Name = "tex�˗���R�[�h";
			this.tex�˗���R�[�h.Size = new System.Drawing.Size(174, 23);
			this.tex�˗���R�[�h.TabIndex = 2;
			this.tex�˗���R�[�h.Text = "";
			this.tex�˗���R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�˗���R�[�h_KeyDown);
			// 
			// btn����
			// 
			this.btn����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn����.ForeColor = System.Drawing.Color.White;
			this.btn����.Location = new System.Drawing.Point(358, 56);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(64, 22);
			this.btn����.TabIndex = 2;
			this.btn����.TabStop = false;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab�˗���^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(794, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab�˗���^�C�g��
			// 
			this.lab�˗���^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�˗���^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�˗���^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab�˗���^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab�˗���^�C�g��.Name = "lab�˗���^�C�g��";
			this.lab�˗���^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab�˗���^�C�g��.TabIndex = 0;
			this.lab�˗���^�C�g��.Text = "���˗��匟���Q";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Location = new System.Drawing.Point(0, 518);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(794, 58);
			this.panel8.TabIndex = 2;
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(416, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(376, 50);
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
			this.panel6.Size = new System.Drawing.Size(794, 26);
			this.panel6.TabIndex = 15;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Location = new System.Drawing.Point(26, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(438, 92);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(26, 154);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(744, 358);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// ���˗��匟���Q
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 574);
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
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "���˗��匟���Q";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ���˗��匟���Q";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.���˗��匟���Q_Closed);
			this.Activated += new System.EventHandler(this.���˗��匟���Q_Activated);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axGT�˗���)).EndInit();
			this.panel5.ResumeLayout(false);
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
			i�A�N�e�B�u�e�f = 0;

			tex���q�l�R�[�h.Text = sKcode;
			tex�˗���R�[�h.Text = sIcode;
			sKcode = "";
			sIcode = "";

			axGT�˗���.Cols = 7;
			axGT�˗���.Rows = 14;
			axGT�˗���.ColSep = "|";

			axGT�˗���.set_RowsText(0, "|���q�l�R�[�h|���q�l��|���喼|���˗���R�[�h|���˗��喼|�Z��|����b�c|");

			axGT�˗���.ColsWidth = "0|7.8|7.4|7.4|8.7|10.2|12.4|0|";
			axGT�˗���.ColsAlignHorz = "1|0|0|0|0|0|0|0|";

			axGT�˗���.set_CelForeColor(axGT�˗���.CaretRow,0,0x98FB98);  //BGR
			axGT�˗���.set_CelBackColor(axGT�˗���.CaretRow,0,0x006000);

			btn�O��.Enabled = false;
			btn����.Enabled = false;
			lab�Ŕԍ�.Text = "";

			if(tex�˗���R�[�h.Text.Trim().Length != 0 || tex���q�l�R�[�h.Text.Trim().Length != 0)
				btn����_Click(sender,e);
		}

		private void �����\��()
		{
			tex�˗��喼.Text = "�n�n���X�T�U�V�W�X�O";
			tex�˗���R�[�h.Text = "084931XXXX";

			axGT�˗���.Clear();
			axGT�˗���.set_RowsText(2, "|1234567890|�c�Ɩ{��|�T�|�[�g�Z���^�[�@�e�X�g�p|0849318141 |�n�n���X�T�U�V�W�X�O|�L�������R�s�������P�|�Q|");
			axGT�˗���.set_RowsText(3, "|WWWWWWWWWW|������S�T�U�V�W�X�O�P�Q�R�S�T�U�V�W�X�O|���喼�S�T�U�V�W�X�O�P�Q�R�S�T�U�V�W�X�O|IRAINUSICD12|���˗��喼�U�V�W�X�O�P�Q�R�S�T�U�V�W�X�O|���˗���Z���V�W�X�O�P�Q�R�S�T�U�V�W�X�O|");
			axGT�˗���.set_RowsText(4, "|MMMMMMMMMM|����������������������������������������|����������������������������������������|WWWWWWWWWWWW|����������������������������������������|����������������������������������������|");

			btn�O��.Enabled = true;
			btn����.Enabled = true;
			lab�Ŕԍ�.Text = " 1 / 99"; // (293-1) / 13
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			sKcode = "";
			sKname = "";
			sIcode = "";
			sIname = "";
			sBcode = "";
			this.Close();
		}

		private void axGT�˗���_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			sKcode = axGT�˗���.get_CelText(axGT�˗���.CaretRow,1);
			sKname = axGT�˗���.get_CelText(axGT�˗���.CaretRow,2);
			sIcode = axGT�˗���.get_CelText(axGT�˗���.CaretRow,4);
			sIname = axGT�˗���.get_CelText(axGT�˗���.CaretRow,5);
			sBcode = axGT�˗���.get_CelText(axGT�˗���.CaretRow,7);
			if(sIcode != "")
				this.Close();

		}

		private void axGT�˗���_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT�˗���.set_CelForeColor(nOldRow,0,0);
			axGT�˗���.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGT�˗���.set_CelForeColor(axGT�˗���.CaretRow,0,0x98FB98);  //BGR
			axGT�˗���.set_CelBackColor(axGT�˗���.CaretRow,0,0x006000);
			nOldRow = axGT�˗���.CaretRow;

		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			i�A�N�e�B�u�e�f = 1;

			axGT�˗���.CaretRow  = 1;
			axGT�˗���_CurPlaceChanged(null,null);
			axGT�˗���.Clear();
			// �󔒏���
			tex���q�l�R�[�h.Text   = tex���q�l�R�[�h.Text.Trim();
			tex�˗��喼.Text     = tex�˗��喼.Text.Trim();
			tex�˗���R�[�h.Text   = tex�˗���R�[�h.Text.Trim();

			if(tex���q�l�R�[�h.Text.Length == 0 &&
				tex�˗��喼.Text.Length == 0 &&
				tex�˗���R�[�h.Text.Length == 0)
			{
				MessageBox.Show("������������͂��Ă��������B","���˗��匟��",MessageBoxButtons.OK);
				tex���q�l�R�[�h.Focus();
				return;
			}

			if(!���p�`�F�b�N(tex���q�l�R�[�h,"���q�l�R�[�h")) return;
// ADD 2008.05.07 ���s�j���� ���˗��喼�̑S�p�`�F�b�N�̒ǉ� START
			if(!�S�p�`�F�b�N(tex�˗��喼, "���˗��喼")) return;
// ADD 2008.05.07 ���s�j���� ���˗��喼�̑S�p�`�F�b�N�̒ǉ� END
			if(!���p�`�F�b�N(tex�˗���R�[�h,"���˗���R�[�h")) return;

			i���ݕŐ� = 1;
			axGT�˗���.CaretRow = 1;
			axGT�˗���.set_CelForeColor(nOldRow,0,0);
			axGT�˗���.set_CelForeColor(axGT�˗���.CaretRow,0,0x98FB98);  //BGR
			axGT�˗���.set_CelBackColor(axGT�˗���.CaretRow,0,0x006000);
			nOldRow = axGT�˗���.CaretRow;

			s�˗���ꗗ = new string[1];

			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey  = new string[4];
				sKey[0] = tex���q�l�R�[�h.Text;
				sKey[1] = tex�˗���R�[�h.Text;
				sKey[2] = tex�˗��喼.Text;
// MOD 2009.05.11 ���s�j���� ���o�בΉ� START
//				sKey[3] = gs�X���R�[�h.Trim();
				sKey[3] = s�X���R�[�h.Trim();
// MOD 2009.05.11 ���s�j���� ���o�בΉ� END
				tex���b�Z�[�W.Text = "�������D�D�D";

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
				if (sKey[0].Substring(0,1) != "J")
				{
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

					if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
					s�˗���ꗗ = sv_maintenance.Get_Goirainusi2(gsa���[�U,sKey);

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
				}
				else
				{
					if(sv_oji == null) sv_oji = new is2oji.Service1();
					s�˗���ꗗ = sv_oji.Get_Goirainusi2(gsa���[�U,sKey);
				}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

			}
			catch (System.Net.WebException)
			{
				s�˗���ꗗ[0] = gs�ʐM�G���[;
			}
			catch (Exception ex)
			{
				s�˗���ꗗ[0] = "�ʐM�G���[�F" + ex.Message;
			}
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			tex���b�Z�[�W.Text = s�˗���ꗗ[0];
			if(s�˗���ꗗ[0].Length == 4)
			{
				tex���b�Z�[�W.Text = "";
				i�ő�Ő� = (s�˗���ꗗ.Length - 2) / (axGT�˗���.Rows - 1) + 1;
				if (i���ݕŐ� > i�ő�Ő�)
					i���ݕŐ� = i�ő�Ő�;
				�ŏ��ݒ�();
			}
			else
			{
				if(s�˗���ꗗ[0].Equals("�Y���f�[�^������܂���"))
				{
					tex���b�Z�[�W.Text = "";
					MessageBox.Show("�Y���f�[�^������܂���","���˗��匟��",MessageBoxButtons.OK);
				}
				else
				{
					axGT�˗���.Clear();
					i���ݕŐ� = 1;
					btn�O��.Enabled = false;
					btn����.Enabled = false;
					lab�Ŕԍ�.Text = "";
					�r�[�v��();
				}
				tex���q�l�R�[�h.Focus();
			}
		}

		private void btn�m��_Click(object sender, System.EventArgs e)
		{
			sKcode = axGT�˗���.get_CelText(axGT�˗���.CaretRow,1);
			sKname = axGT�˗���.get_CelText(axGT�˗���.CaretRow,2);
			sIcode = axGT�˗���.get_CelText(axGT�˗���.CaretRow,4);
			sIname = axGT�˗���.get_CelText(axGT�˗���.CaretRow,5);
			sBcode = axGT�˗���.get_CelText(axGT�˗���.CaretRow,7);
			if(sIcode != "")
				this.Close();

		}

		private void axGT�˗���_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 13)
			{
				btn�m��_Click(sender, null);
			}
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT�˗���, true, true, true, true);
			}
		}

		private void tex�˗���R�[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btn����_Click(sender, e);
			}
		}

		private void btn�O��_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�--;
			�ŏ��ݒ�();
			axGT�˗���.CaretRow = 1;
			axGT�˗���_CurPlaceChanged(null,null);
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�++;
			�ŏ��ݒ�();
			axGT�˗���.CaretRow = 1;
			axGT�˗���_CurPlaceChanged(null,null);
		}

		private void �ŏ��ݒ�()
		{
			axGT�˗���.Clear();

			i�J�n�� = (i���ݕŐ� - 1) * (axGT�˗���.Rows - 1) + 1;
			i�I���� = i���ݕŐ� * (axGT�˗���.Rows - 1);

			short s�\���� = (short)2;
			for(short sCnt = (short)i�J�n��; sCnt < s�˗���ꗗ.Length && sCnt <= i�I���� ; sCnt++)
			{
				axGT�˗���.set_RowsText(s�\����, s�˗���ꗗ[sCnt]);
				s�\����++;
			}
			lab�Ŕԍ�.Text = i���ݕŐ�.ToString() + " / " + i�ő�Ő�.ToString();
			if (i���ݕŐ� == 1)
				btn�O��.Enabled = false;
			else
				btn�O��.Enabled = true;
			if (i���ݕŐ� == i�ő�Ő�)
				btn����.Enabled = false;
			else
				btn����.Enabled = true;
			axGT�˗���.Focus();
		}

		private void ���˗��匟���Q_Activated(object sender, System.EventArgs e)
		{

			if((tex�˗���R�[�h.Text.Trim().Length != 0 || tex���q�l�R�[�h.Text.Trim().Length != 0)
				&& i�A�N�e�B�u�e�f == 0)
				btn����_Click(sender,e);
		}

		private void ���˗��匟���Q_Closed(object sender, System.EventArgs e)
		{
			tex���q�l�R�[�h.Text = "";
			tex�˗��喼.Text   = " ";
			tex�˗���R�[�h.Text = "";
			tex���b�Z�[�W.Text = "";
			axGT�˗���.Clear();
			axGT�˗���.CaretRow  = 1;
			axGT�˗���_CurPlaceChanged(null,null);
			tex���q�l�R�[�h.Focus();
		}

		private void btn���q�l����_Click(object sender, System.EventArgs e)
		{
			tex���q�l�R�[�h.Text = tex���q�l�R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex���q�l�R�[�h, "���q�l�R�[�h")) return;

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			if (g������Q == null)	 g������Q = new ��������Q();
			g������Q.Left = this.Left + 404;
			g������Q.Top = this.Top;
			g������Q.s����R�[�h = "";
			g������Q.s����� = "";
			g������Q.s�X���R�[�h = gs�X���R�[�h.Trim();
			g������Q.ShowDialog();
			g������Q.s�X���R�[�h = "";
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if (g������Q.s����R�[�h.Trim().Length != 0)
			{
				tex���q�l�R�[�h.Text = g������Q.s����R�[�h;
			}
			else
			{
				tex���q�l�R�[�h.Focus();
			}
		}

	}
}
// ADD 2007.11.14 KCL) �X�{ [���˗��匟��]�t�H�[�����R�s�[���A���O��[���˗��匟���Q]�ɕύX�iglobal�Ή��j END
