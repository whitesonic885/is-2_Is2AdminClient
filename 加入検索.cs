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
	public class �������� : ���ʃt�H�[��
	{
		public short nOldRow = 0;

		public string s��t�m�n;
		public string s�X���R�[�h;

		private string[] s�\���ꗗ;
		private int      i���ݕŐ�;
		private int      i�ő�Ő�;
		private int      i�J�n��;
		private int      i�I����;
//		private int      i�A�N�e�B�u�e�f = 0;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btn�m��;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btn����;
		private AxGTABLE32V2Lib.AxGTable32 axGT���;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lab�Ŕԍ�;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�O��;
		private System.Windows.Forms.Label lab��t�m�n;
		private System.Windows.Forms.Label lab�\���Җ�;
		private System.Windows.Forms.Label label1;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�X���R�[�h;
		private System.Windows.Forms.Label label2;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���҃J�i;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex��t�m�n;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\���Җ�;
		private System.Windows.Forms.Label lab��t�m�n����;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ��������()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(��������));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab�Ŕԍ� = new System.Windows.Forms.Label();
			this.btn���� = new System.Windows.Forms.Button();
			this.btn�O�� = new System.Windows.Forms.Button();
			this.axGT��� = new AxGTABLE32V2Lib.AxGTable32();
			this.btn�m�� = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab��t�m�n���� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn���� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tex�\���҃J�i = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�X���R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex��t�m�n = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab��t�m�n = new System.Windows.Forms.Label();
			this.lab�\���Җ� = new System.Windows.Forms.Label();
			this.tex�\���Җ� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn���� = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axGT���)).BeginInit();
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
			this.panel1.Controls.Add(this.lab�Ŕԍ�);
			this.panel1.Controls.Add(this.btn����);
			this.panel1.Controls.Add(this.btn�O��);
			this.panel1.Controls.Add(this.axGT���);
			this.panel1.Controls.Add(this.btn�m��);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(374, 348);
			this.panel1.TabIndex = 0;
			// 
			// lab�Ŕԍ�
			// 
			this.lab�Ŕԍ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�Ŕԍ�.ForeColor = System.Drawing.Color.Green;
			this.lab�Ŕԍ�.Location = new System.Drawing.Point(220, 292);
			this.lab�Ŕԍ�.Name = "lab�Ŕԍ�";
			this.lab�Ŕԍ�.Size = new System.Drawing.Size(58, 14);
			this.lab�Ŕԍ�.TabIndex = 76;
			this.lab�Ŕԍ�.Text = "999 / 999";
			this.lab�Ŕԍ�.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn����
			// 
			this.btn����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn����.ForeColor = System.Drawing.Color.White;
			this.btn����.Location = new System.Drawing.Point(278, 288);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(48, 22);
			this.btn����.TabIndex = 2;
			this.btn����.TabStop = false;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// btn�O��
			// 
			this.btn�O��.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�O��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�O��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�O��.ForeColor = System.Drawing.Color.White;
			this.btn�O��.Location = new System.Drawing.Point(172, 288);
			this.btn�O��.Name = "btn�O��";
			this.btn�O��.Size = new System.Drawing.Size(48, 22);
			this.btn�O��.TabIndex = 1;
			this.btn�O��.TabStop = false;
			this.btn�O��.Text = "�O��";
			this.btn�O��.Click += new System.EventHandler(this.btn�O��_Click);
			// 
			// axGT���
			// 
			this.axGT���.ContainingControl = this;
			this.axGT���.DataSource = null;
			this.axGT���.Location = new System.Drawing.Point(8, 8);
			this.axGT���.Name = "axGT���";
			this.axGT���.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT���.OcxState")));
			this.axGT���.Size = new System.Drawing.Size(357, 271);
			this.axGT���.TabIndex = 0;
			this.axGT���.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT���_KeyDownEvent);
			this.axGT���.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT���_CelDblClick);
			this.axGT���.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT���_CurPlaceChanged);
			// 
			// btn�m��
			// 
			this.btn�m��.BackColor = System.Drawing.Color.Blue;
			this.btn�m��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�m��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�m��.ForeColor = System.Drawing.Color.White;
			this.btn�m��.Location = new System.Drawing.Point(302, 318);
			this.btn�m��.Name = "btn�m��";
			this.btn�m��.Size = new System.Drawing.Size(64, 22);
			this.btn�m��.TabIndex = 3;
			this.btn�m��.Text = "�m��";
			this.btn�m��.Click += new System.EventHandler(this.btn�m��_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab��t�m�n����);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab��t�m�n����
			// 
			this.lab��t�m�n����.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab��t�m�n����.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab��t�m�n����.ForeColor = System.Drawing.Color.White;
			this.lab��t�m�n����.Location = new System.Drawing.Point(12, 2);
			this.lab��t�m�n����.Name = "lab��t�m�n����";
			this.lab��t�m�n����.Size = new System.Drawing.Size(264, 24);
			this.lab��t�m�n����.TabIndex = 0;
			this.lab��t�m�n����.Text = "��t�m�n����";
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
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(68, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(314, 50);
			this.tex���b�Z�[�W.TabIndex = 6;
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
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.tex�\���҃J�i);
			this.panel5.Controls.Add(this.tex�X���R�[�h);
			this.panel5.Controls.Add(this.tex��t�m�n);
			this.panel5.Controls.Add(this.lab��t�m�n);
			this.panel5.Controls.Add(this.lab�\���Җ�);
			this.panel5.Controls.Add(this.tex�\���Җ�);
			this.panel5.Controls.Add(this.btn����);
			this.panel5.Location = new System.Drawing.Point(1, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(373, 90);
			this.panel5.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.LimeGreen;
			this.label2.Location = new System.Drawing.Point(192, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 16);
			this.label2.TabIndex = 50;
			this.label2.Text = "�X���R�[�h";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.LimeGreen;
			this.label1.Location = new System.Drawing.Point(20, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 16);
			this.label1.TabIndex = 49;
			this.label1.Text = "�t���K�i";
			// 
			// tex�\���҃J�i
			// 
			this.tex�\���҃J�i.BackColor = System.Drawing.SystemColors.Window;
			this.tex�\���҃J�i.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���҃J�i.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�\���҃J�i.Location = new System.Drawing.Point(74, 60);
			this.tex�\���҃J�i.MaxLength = 20;
			this.tex�\���҃J�i.Name = "tex�\���҃J�i";
			this.tex�\���҃J�i.Size = new System.Drawing.Size(230, 23);
			this.tex�\���҃J�i.TabIndex = 3;
			this.tex�\���҃J�i.Text = "";
			this.tex�\���҃J�i.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�\���҃J�i_KeyDown);
			// 
			// tex�X���R�[�h
			// 
			this.tex�X���R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex�X���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�X���R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�X���R�[�h.Location = new System.Drawing.Point(268, 8);
			this.tex�X���R�[�h.MaxLength = 3;
			this.tex�X���R�[�h.Name = "tex�X���R�[�h";
			this.tex�X���R�[�h.Size = new System.Drawing.Size(36, 23);
			this.tex�X���R�[�h.TabIndex = 1;
			this.tex�X���R�[�h.Text = "";
			// 
			// tex��t�m�n
			// 
			this.tex��t�m�n.BackColor = System.Drawing.SystemColors.Window;
			this.tex��t�m�n.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex��t�m�n.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex��t�m�n.Location = new System.Drawing.Point(74, 8);
			this.tex��t�m�n.MaxLength = 7;
			this.tex��t�m�n.Name = "tex��t�m�n";
			this.tex��t�m�n.Size = new System.Drawing.Size(72, 23);
			this.tex��t�m�n.TabIndex = 0;
			this.tex��t�m�n.Text = "";
			// 
			// lab��t�m�n
			// 
			this.lab��t�m�n.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab��t�m�n.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab��t�m�n.Location = new System.Drawing.Point(8, 12);
			this.lab��t�m�n.Name = "lab��t�m�n";
			this.lab��t�m�n.Size = new System.Drawing.Size(66, 16);
			this.lab��t�m�n.TabIndex = 46;
			this.lab��t�m�n.Text = "��t�m�n";
			// 
			// lab�\���Җ�
			// 
			this.lab�\���Җ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\���Җ�.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�\���Җ�.Location = new System.Drawing.Point(2, 38);
			this.lab�\���Җ�.Name = "lab�\���Җ�";
			this.lab�\���Җ�.Size = new System.Drawing.Size(72, 16);
			this.lab�\���Җ�.TabIndex = 6;
			this.lab�\���Җ�.Text = "�\���Җ�";
			// 
			// tex�\���Җ�
			// 
			this.tex�\���Җ�.BackColor = System.Drawing.SystemColors.Window;
			this.tex�\���Җ�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\���Җ�.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�\���Җ�.Location = new System.Drawing.Point(74, 34);
			this.tex�\���Җ�.MaxLength = 20;
			this.tex�\���Җ�.Name = "tex�\���Җ�";
			this.tex�\���Җ�.Size = new System.Drawing.Size(230, 23);
			this.tex�\���Җ�.TabIndex = 2;
			this.tex�\���Җ�.Text = "";
			// 
			// btn����
			// 
			this.btn����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn����.ForeColor = System.Drawing.Color.White;
			this.btn����.Location = new System.Drawing.Point(306, 60);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(64, 22);
			this.btn����.TabIndex = 4;
			this.btn����.TabStop = false;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Location = new System.Drawing.Point(7, 54);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(377, 98);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(7, 152);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(377, 356);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// ��������
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(388, 574);
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
			this.Name = "��������";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ��t�m�n����";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.��������_Closed);
			this.Activated += new System.EventHandler(this.��������_Activated);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axGT���)).EndInit();
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
//			i�A�N�e�B�u�e�f = 0;
			tex�X���R�[�h.Text = s�X���R�[�h;
			if(s�X���R�[�h.Length > 0) tex�X���R�[�h.Enabled = false;
			
			axGT���.Cols = 4;
			axGT���.Rows = 14;
			axGT���.ColSep = "|";
			axGT���.CaretRow = 1;
			axGT���.NoBeep = true;
			
			axGT���.set_RowsText(0, "|��t�m�n|���q�l��|�t���K�i||");

			axGT���.ColsWidth = "0|4.6|12|9.4|0|";
			axGT���.ColsAlignHorz = "1|1|0|0|0|";
//			axGT���.set_CelForeColor(axGT���.CaretRow,0,111111);
			axGT���.set_CelForeColor(axGT���.CaretRow,0,0x98FB98);  //BGR
			axGT���.set_CelBackColor(axGT���.CaretRow,0,0x006000);

			btn�O��.Enabled = false;
			btn����.Enabled = false;
			lab�Ŕԍ�.Text = "";
			i���ݕŐ� = 1;

			axGT���.CaretRow = 1;
			axGT���_CurPlaceChanged(null,null);

			tex��t�m�n.Focus();
		}

		private void �����\��()
		{
			tex��t�m�n.Text = "1234567";
			tex�X���R�[�h.Text = "123";
			tex�\���Җ�.Text = "�S�p�P�R";
			tex�\���҃J�i.Text = "�S�p�P�R";

			lab�Ŕԍ�.Text = "999 / 999";
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			s��t�m�n = "";
			s�X���R�[�h   = "";
			this.Close();
		}

		private void axGT���_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			s��t�m�n = axGT���.get_CelText(axGT���.CaretRow,1);
			s�X���R�[�h   = axGT���.get_CelText(axGT���.CaretRow,4);
			if(!s��t�m�n.Equals(""))
				this.Close();
		}

		private void axGT���_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT���.set_CelForeColor(nOldRow,0,0);
			axGT���.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT���.set_CelForeColor(axGT���.CaretRow,0,111111);
			axGT���.set_CelForeColor(axGT���.CaretRow,0,0x98FB98);  //BGR
			axGT���.set_CelBackColor(axGT���.CaretRow,0,0x006000);
			nOldRow = axGT���.CaretRow;

		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			�\���ꗗ����();
		}

		private void btn�m��_Click(object sender, System.EventArgs e)
		{
			s��t�m�n = axGT���.get_CelText(axGT���.CaretRow,1);
			s�X���R�[�h   = axGT���.get_CelText(axGT���.CaretRow,4);
			if(!s��t�m�n.Equals(""))
				this.Close();
		}

		private void �\���ꗗ����()
		{
//			i�A�N�e�B�u�e�f = 1;
			//�s������
			tex��t�m�n.Text = tex��t�m�n.Text.Trim();
			tex�X���R�[�h.Text = tex�X���R�[�h.Text.Trim();
			tex�\���Җ�.Text = tex�\���Җ�.Text.Trim();
			tex�\���҃J�i.Text = tex�\���҃J�i.Text.Trim();
			//�^�`�F�b�N
			if(!���p�`�F�b�N(tex��t�m�n, "��t�m�n")) return;
			if(!���p�`�F�b�N(tex�X���R�[�h, "�X���R�[�h")) return;
			if(!�S�p�`�F�b�N(tex�\���Җ�, "�\���Җ�")) return;
			if(!�S�p�`�F�b�N(tex�\���҃J�i, "�\���҃J�i")) return;

			axGT���.Clear();

			tex���b�Z�[�W.Text = "�������D�D�D";

			s�\���ꗗ = new string[1];
			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey  = new string[4]{"","","",""};
				sKey[0] = tex��t�m�n.Text;
				sKey[1] = tex�X���R�[�h.Text;
				sKey[2] = tex�\���Җ�.Text;
				sKey[3] = tex�\���҃J�i.Text;
				s�\���ꗗ = sv_maintenance.Get_Mosikomi(gsa���[�U, sKey);
			}
			catch (System.Net.WebException)
			{
				s�\���ꗗ[0] = gs�ʐM�G���[;
			}
			catch (Exception ex)
			{
				s�\���ꗗ[0] = "�ʐM�G���[�F" + ex.Message;
			}
			
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			if (s�\���ꗗ[0].Equals("����I��"))
			{
				tex���b�Z�[�W.Text = "";
				i�ő�Ő� = (s�\���ꗗ.Length - 2) / (axGT���.Rows - 1) + 1;
				if (i���ݕŐ� > i�ő�Ő�)
					i���ݕŐ� = i�ő�Ő�;
				�ŏ��ݒ�();

				//��s�ڑI��
				axGT���.CaretRow = 1;
				axGT���_CurPlaceChanged(null,null);

				axGT���.Focus();
			}
			else
			{
				if (s�\���ꗗ[0].Equals("�Y���f�[�^������܂���"))
				{
					tex���b�Z�[�W.Text = "";
					MessageBox.Show("�Y���f�[�^������܂���","��t�m�n����",MessageBoxButtons.OK);
				}
				else
				{
					tex���b�Z�[�W.Text = s�\���ꗗ[0];
					i���ݕŐ� = 1;
					btn�O��.Enabled = false;
					btn����.Enabled = false;
					lab�Ŕԍ�.Text = "";
					�r�[�v��();
				}
				tex��t�m�n.Focus();
			}
		}

		private void axGT���_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				s��t�m�n = axGT���.get_CelText(axGT���.CaretRow,1);
				s�X���R�[�h   = axGT���.get_CelText(axGT���.CaretRow,4);
				if(!s��t�m�n.Equals(""))
					this.Close();
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT���, true, true, true, true);
			}
		}

		private void tex�\���҃J�i_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				�\���ꗗ����();
			}
		}

		private void btn�O��_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�--;
			�ŏ��ݒ�();

			axGT���.CaretRow = 1;
			axGT���_CurPlaceChanged(null,null);
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�++;
			�ŏ��ݒ�();

			axGT���.CaretRow = 1;
			axGT���_CurPlaceChanged(null,null);
		}

		private void �ŏ��ݒ�()
		{
			axGT���.Clear();

			i�J�n�� = (i���ݕŐ� - 1) * (axGT���.Rows - 1) + 1;
			i�I���� = i���ݕŐ� * (axGT���.Rows - 1);

			short s�\���� = (short)2;
			for(short sCnt = (short)i�J�n��; sCnt < s�\���ꗗ.Length && sCnt <= i�I���� ; sCnt++)
			{
				axGT���.set_RowsText(s�\����, s�\���ꗗ[sCnt]);
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
			axGT���.Focus();
		}

		private void ��������_Activated(object sender, System.EventArgs e)
		{
//			if(i�A�N�e�B�u�e�f == 0)
//				�\���ꗗ����();		
		}

		private void ��������_Closed(object sender, System.EventArgs e)
		{
			tex��t�m�n.Text = "";
			tex�X���R�[�h.Text = "";
			tex�\���Җ�.Text = "";
			tex�\���҃J�i.Text = "";
			tex���b�Z�[�W.Text = "";
			axGT���.Clear();
			tex��t�m�n.Focus();
		}
	}
}
