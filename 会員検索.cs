using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [���q�l����]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 ���s�j���� ���q�l���̑S�p�`�F�b�N�̒ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� 
	// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� 
	//--------------------------------------------------------------------------
	public class ������� : ���ʃt�H�[��
	{
		public short nOldRow = 0;
		public string s����R�[�h;
		public string s�����;
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
		public string s�X���R�[�h = "";
// ADD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
		public bool b�^�p���̂��q�l�̂� = false;
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END

		private string[] s����ꗗ;
		private int      i���ݕŐ�;
		private int      i�ő�Ő�;
		private int      i�J�n��;
		private int      i�I����;
		private int      i�A�N�e�B�u�e�f = 0;
// ADD 2006.12.18 ���s�j�����J ���ׂ̗]�������� START
		private int      i�ōő�s�� = 100;
// ADD 2006.12.18 ���s�j�����J ���ׂ̗]�������� END

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btn�m��;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label lab����^�C�g��;
		private System.Windows.Forms.Panel panel5;
		private ���ʃe�L�X�g�{�b�N�X tex����R�[�h;
		private System.Windows.Forms.Label lab����R�[�h;
		private System.Windows.Forms.Label lab�����;
		private ���ʃe�L�X�g�{�b�N�X tex�����;
		private System.Windows.Forms.Button btn����;
		private AxGTABLE32V2Lib.AxGTable32 axGT���;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lab�Ŕԍ�;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�O��;
		private System.Windows.Forms.Label lab�g�p��~��;
		private System.Windows.Forms.Label lab�g�p��~���F;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(�������));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab�g�p��~���F = new System.Windows.Forms.Label();
			this.lab�g�p��~�� = new System.Windows.Forms.Label();
			this.lab�Ŕԍ� = new System.Windows.Forms.Label();
			this.btn���� = new System.Windows.Forms.Button();
			this.btn�O�� = new System.Windows.Forms.Button();
			this.axGT��� = new AxGTABLE32V2Lib.AxGTable32();
			this.btn�m�� = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab����^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn���� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.tex����R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab����R�[�h = new System.Windows.Forms.Label();
			this.lab����� = new System.Windows.Forms.Label();
			this.tex����� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
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
			this.panel1.Controls.Add(this.lab�g�p��~���F);
			this.panel1.Controls.Add(this.lab�g�p��~��);
			this.panel1.Controls.Add(this.lab�Ŕԍ�);
			this.panel1.Controls.Add(this.btn����);
			this.panel1.Controls.Add(this.btn�O��);
			this.panel1.Controls.Add(this.axGT���);
			this.panel1.Controls.Add(this.btn�m��);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(374, 380);
			this.panel1.TabIndex = 0;
			// 
			// lab�g�p��~���F
			// 
			this.lab�g�p��~���F.BackColor = System.Drawing.Color.Silver;
			this.lab�g�p��~���F.Location = new System.Drawing.Point(6, 350);
			this.lab�g�p��~���F.Name = "lab�g�p��~���F";
			this.lab�g�p��~���F.Size = new System.Drawing.Size(28, 22);
			this.lab�g�p��~���F.TabIndex = 78;
			this.lab�g�p��~���F.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lab�g�p��~��
			// 
			this.lab�g�p��~��.Location = new System.Drawing.Point(36, 350);
			this.lab�g�p��~��.Name = "lab�g�p��~��";
			this.lab�g�p��~��.Size = new System.Drawing.Size(76, 22);
			this.lab�g�p��~��.TabIndex = 77;
			this.lab�g�p��~��.Text = "�F�g�p��~��";
			this.lab�g�p��~��.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lab�Ŕԍ�
			// 
			this.lab�Ŕԍ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�Ŕԍ�.ForeColor = System.Drawing.Color.Green;
			this.lab�Ŕԍ�.Location = new System.Drawing.Point(222, 316);
			this.lab�Ŕԍ�.Name = "lab�Ŕԍ�";
			this.lab�Ŕԍ�.Size = new System.Drawing.Size(56, 14);
			this.lab�Ŕԍ�.TabIndex = 76;
			this.lab�Ŕԍ�.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn����
			// 
			this.btn����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn����.ForeColor = System.Drawing.Color.White;
			this.btn����.Location = new System.Drawing.Point(280, 312);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(48, 22);
			this.btn����.TabIndex = 75;
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
			this.btn�O��.Location = new System.Drawing.Point(172, 312);
			this.btn�O��.Name = "btn�O��";
			this.btn�O��.Size = new System.Drawing.Size(48, 22);
			this.btn�O��.TabIndex = 74;
			this.btn�O��.TabStop = false;
			this.btn�O��.Text = "�O��";
			this.btn�O��.Click += new System.EventHandler(this.btn�O��_Click);
			// 
			// axGT���
			// 
			this.axGT���.ContainingControl = this;
			this.axGT���.DataSource = null;
			this.axGT���.Location = new System.Drawing.Point(6, 16);
			this.axGT���.Name = "axGT���";
			this.axGT���.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT���.OcxState")));
			this.axGT���.Size = new System.Drawing.Size(364, 289);
			this.axGT���.TabIndex = 3;
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
			this.btn�m��.Location = new System.Drawing.Point(302, 350);
			this.btn�m��.Name = "btn�m��";
			this.btn�m��.Size = new System.Drawing.Size(64, 22);
			this.btn�m��.TabIndex = 4;
			this.btn�m��.Text = "�m��";
			this.btn�m��.Click += new System.EventHandler(this.btn�m��_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab����^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab����^�C�g��
			// 
			this.lab����^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab����^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab����^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab����^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab����^�C�g��.Name = "lab����^�C�g��";
			this.lab����^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab����^�C�g��.TabIndex = 0;
			this.lab����^�C�g��.Text = "���q�l����";
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
			this.panel5.Controls.Add(this.tex����R�[�h);
			this.panel5.Controls.Add(this.lab����R�[�h);
			this.panel5.Controls.Add(this.lab�����);
			this.panel5.Controls.Add(this.tex�����);
			this.panel5.Controls.Add(this.btn����);
			this.panel5.Location = new System.Drawing.Point(1, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(373, 60);
			this.panel5.TabIndex = 3;
			// 
			// tex����R�[�h
			// 
			this.tex����R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex����R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex����R�[�h.Location = new System.Drawing.Point(74, 6);
			this.tex����R�[�h.MaxLength = 10;
			this.tex����R�[�h.Name = "tex����R�[�h";
			this.tex����R�[�h.Size = new System.Drawing.Size(140, 23);
			this.tex����R�[�h.TabIndex = 0;
			this.tex����R�[�h.Text = "";
			// 
			// lab����R�[�h
			// 
			this.lab����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab����R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab����R�[�h.Location = new System.Drawing.Point(4, 10);
			this.lab����R�[�h.Name = "lab����R�[�h";
			this.lab����R�[�h.Size = new System.Drawing.Size(58, 16);
			this.lab����R�[�h.TabIndex = 46;
			this.lab����R�[�h.Text = "�R�[�h";
			// 
			// lab�����
			// 
			this.lab�����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�����.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�����.Location = new System.Drawing.Point(4, 34);
			this.lab�����.Name = "lab�����";
			this.lab�����.Size = new System.Drawing.Size(70, 16);
			this.lab�����.TabIndex = 6;
			this.lab�����.Text = "���q�l��";
			// 
			// tex�����
			// 
			this.tex�����.BackColor = System.Drawing.SystemColors.Window;
			this.tex�����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�����.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�����.Location = new System.Drawing.Point(74, 30);
			this.tex�����.MaxLength = 20;
			this.tex�����.Name = "tex�����";
			this.tex�����.Size = new System.Drawing.Size(228, 23);
			this.tex�����.TabIndex = 1;
			this.tex�����.Text = "";
			this.tex�����.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�����_KeyDown);
			// 
			// btn����
			// 
			this.btn����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn����.ForeColor = System.Drawing.Color.White;
			this.btn����.Location = new System.Drawing.Point(306, 32);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(64, 22);
			this.btn����.TabIndex = 2;
			this.btn����.TabStop = false;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Location = new System.Drawing.Point(7, 54);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(377, 68);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(7, 122);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(377, 388);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// �������
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
			this.Name = "�������";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ���q�l����";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Activated += new System.EventHandler(this.�������_Activated);
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
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
			if(b�^�p���̂��q�l�̂�){
				lab�g�p��~���F.Visible = false;
				lab�g�p��~��.Visible = false;
			}else{
				lab�g�p��~���F.Visible = true;
				lab�g�p��~��.Visible = true;
			}
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END
			i�A�N�e�B�u�e�f = 0;
			tex����R�[�h.Text = s����R�[�h;
			tex�����.Text = s�����;
			
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
//			axGT���.Cols = 2;
			axGT���.Cols = 4;
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END
// MOD 2006.12.18 ���s�j�����J ���ׂ̗]�������� START
// 2006.07.14 ���s�j�R�{ �X�N���[���P�O�O���Ή� START
////			axGT���.Rows = 15;
//			axGT���.Rows = 100;
// 2006.07.14 ���s�j�R�{ �X�N���[���P�O�O���Ή� END
			axGT���.Rows = 15;
// MOD 2006.12.18 ���s�j�����J ���ׂ̗]�������� END
			axGT���.ColSep = "|";
			axGT���.CaretRow = 1;
			axGT���.NoBeep = true;
			
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
//			axGT���.set_RowsText(0, "|�R�[�h|���q�l��|");
//
//// 2006.07.14 ���s�j�R�{ �X�N���[���P�O�O���Ή� START
////			axGT���.ColsWidth = "0|8|19.4|";
//			axGT���.ColsWidth = "0|7|19.4|";
//// 2006.07.14 ���s�j�R�{ �X�N���[���P�O�O���Ή� END
//			axGT���.ColsAlignHorz = "1|1|0|";
			axGT���.set_RowsText(0, "|�R�[�h|���q�l��|||");
			axGT���.ColsWidth = "0|7|19.4|0|0|";
			axGT���.ColsAlignHorz = "1|1|0|0|0|";
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END
//			axGT���.set_CelForeColor(axGT���.CaretRow,0,111111);
			axGT���.set_CelForeColor(axGT���.CaretRow,0,0x98FB98);  //BGR
			axGT���.set_CelBackColor(axGT���.CaretRow,0,0x006000);

			btn�O��.Enabled = false;
			btn����.Enabled = false;
			lab�Ŕԍ�.Text = "";
			i���ݕŐ� = 1;

			axGT���.CaretRow = 1;
			axGT���_CurPlaceChanged(null,null);
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			s����R�[�h = "";
			s�����     = "";
			this.Close();
		}

		private void axGT���_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			s����R�[�h = axGT���.get_CelText(axGT���.CaretRow,1);
			s�����     = axGT���.get_CelText(axGT���.CaretRow,2);
			if(!s����R�[�h.Equals(""))
				this.Close();
		}

		private void axGT���_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT���.set_CelForeColor(nOldRow,0,0);
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
//			axGT���.set_CelBackColor(nOldRow,0,0xFFFFFF);
			if(axGT���.get_CelText(nOldRow, 3).CompareTo(axGT���.get_CelText(nOldRow, 4)) < 0){
				axGT���.set_CelBackColor(nOldRow,0,0xC0C0C0);
			}else{
				axGT���.set_CelBackColor(nOldRow,0,0xFFFFFF);
			}
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END
//			axGT���.set_CelForeColor(axGT���.CaretRow,0,111111);
			axGT���.set_CelForeColor(axGT���.CaretRow,0,0x98FB98);  //BGR
			axGT���.set_CelBackColor(axGT���.CaretRow,0,0x006000);
			nOldRow = axGT���.CaretRow;

		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			����ꗗ����();
		}

		private void btn�m��_Click(object sender, System.EventArgs e)
		{
			s����R�[�h = axGT���.get_CelText(axGT���.CaretRow,1);
			s�����     = axGT���.get_CelText(axGT���.CaretRow,2);
			if(!s����R�[�h.Equals(""))
				this.Close();
		}

		private void ����ꗗ����()
		{
			i�A�N�e�B�u�e�f = 1;
			tex����R�[�h.Text = tex����R�[�h.Text.Trim();
			tex�����.Text = tex�����.Text.Trim();
			if(!���p�`�F�b�N(tex����R�[�h, "�R�[�h")) return;
// ADD 2008.05.07 ���s�j���� ���q�l���̑S�p�`�F�b�N�̒ǉ� START
			if(!�S�p�`�F�b�N(tex�����, "���q�l��")) return;
// ADD 2008.05.07 ���s�j���� ���q�l���̑S�p�`�F�b�N�̒ǉ� END

			axGT���.Clear();

			tex���b�Z�[�W.Text = "�������D�D�D";

			s����ꗗ = new string[1];
			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
//				string[] sKey  = new string[3];
				string[] sKey  = new string[4];
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END
				sKey[0] = tex����R�[�h.Text;
				sKey[1] = tex�����.Text;
// ADD 2006.11.08 ���s�j�R�{ �X�����O�C�����̐�����o�^����ꍇ�̓X���R�[�h�`�F�b�N�ǉ� START
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX START
//				sKey[2] = gs�X���R�[�h.Trim();
//				if(gs�X���R�[�h.Trim().Length != 0)
				sKey[2] = s�X���R�[�h.Trim();
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
				sKey[3] = (b�^�p���̂��q�l�̂� ? "1" : "");
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END
				if(s�X���R�[�h.Trim().Length != 0)
// MOD 2007.01.18 ���s�j���� ��ʃ��C�A�E�g�ύX END
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					if (sKey[0] == "" )
					{
						//����R�[�h���󔒂̏ꍇ�͓X�R�[�h���Ǘ��ҋ敪������
						string[] sKey2  = new string[1];
						sKey2[0] = sKey[2];
						string[] sList = sv_oji.Sel_Member(gsa���[�U, sKey2);
						if (sList[0].Equals("����I��"))
						{
							if ((sList[4].Equals("3"))||(sList[4].Equals("4")))
							{
								//���q�^�����
								s����ꗗ = sv_oji.Get_MemberTn(gsa���[�U, sKey);
							}
							else
							{
								//���ʉ��
								s����ꗗ = sv_maintenance.Get_MemberTn(gsa���[�U, sKey);
							}
						}
						else
						{
							s����ꗗ = sv_maintenance.Get_MemberTn(gsa���[�U, sKey);
						}
					}
					else if (sKey[0].Substring(0,1) != "J")
					{
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

					s����ꗗ = sv_maintenance.Get_MemberTn(gsa���[�U, sKey);

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
					}
					else
					{
						s����ꗗ = sv_oji.Get_MemberTn(gsa���[�U, sKey);
					}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

				else
// ADD 2006.11.08 ���s�j�R�{ �X�����O�C�����̐�����o�^����ꍇ�̓X���R�[�h�`�F�b�N�ǉ� END
					s����ꗗ = sv_maintenance.Get_Member(gsa���[�U, sKey);
			}
// ADD 2005.05.25 ���s�j�����J �ʐM�G���[�̃��b�Z�[�W�C�� START
			catch (System.Net.WebException)
			{
				s����ꗗ[0] = gs�ʐM�G���[;
			}
// ADD 2005.05.25 ���s�j�����J �ʐM�G���[�̃��b�Z�[�W�C�� END
			catch (Exception ex)
			{
				s����ꗗ[0] = "�ʐM�G���[�F" + ex.Message;
			}
			
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			if (s����ꗗ[0].Equals("����I��"))
			{
				tex���b�Z�[�W.Text = "";
// MOD 2006.12.18 ���s�j�����J ���ׂ̗]�������� START
// MOD 2005.05.12 ���s�j�����J ��s�ڋ� START
//				i�ő�Ő� = (s����ꗗ.Length - 2) / axGT���.Rows + 1;
				i�ő�Ő� = (s����ꗗ.Length - 2) / (axGT���.Rows - 1) + 1;
// MOD 2005.05.12 ���s�j�����J ��s�ڋ� END
				i�ő�Ő� = (s����ꗗ.Length - 2) / (i�ōő�s�� - 1) + 1;
// MOD 2006.12.18 ���s�j�����J ���ׂ̗]�������� END
				if (i���ݕŐ� > i�ő�Ő�)
					i���ݕŐ� = i�ő�Ő�;
				�ŏ��ݒ�();

// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� START
				axGT���.CaretRow = 1;
				axGT���_CurPlaceChanged(null,null);
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� END

				axGT���.Focus();
			}
			else
			{
				if (s����ꗗ[0].Equals("�Y���f�[�^������܂���"))
				{
					tex���b�Z�[�W.Text = "";
					MessageBox.Show("�Y���f�[�^������܂���","���q�l����",MessageBoxButtons.OK);
				}
				else
				{
					tex���b�Z�[�W.Text = s����ꗗ[0];
					i���ݕŐ� = 1;
					btn�O��.Enabled = false;
					btn����.Enabled = false;
					lab�Ŕԍ�.Text = "";
					�r�[�v��();
				}
				tex����R�[�h.Focus();
			}
		}

		private void axGT���_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				s����R�[�h = axGT���.get_CelText(axGT���.CaretRow,1);
				s�����     = axGT���.get_CelText(axGT���.CaretRow,2);
				if(!s����R�[�h.Equals(""))
					this.Close();
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT���, true, true, true, true);
			}
		}

		private void tex�����_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				����ꗗ����();
			}
		}

		private void btn�O��_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�--;
			�ŏ��ݒ�();
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� START
			axGT���.CaretRow = 1;
			axGT���_CurPlaceChanged(null,null);
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� END
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�++;
			�ŏ��ݒ�();
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� START
			axGT���.CaretRow = 1;
			axGT���_CurPlaceChanged(null,null);
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� END
		}

		private void �ŏ��ݒ�()
		{
			axGT���.Clear();
// ADD 2006.12.18 ���s�j�����J ���ׂ̗]�������� START
			axGT���.Rows = 15;
// ADD 2006.12.18 ���s�j�����J ���ׂ̗]�������� END

// MOD 2005.05.12 ���s�j�����J ��s�ڋ� START
// MOD 2006.12.18 ���s�j�����J ���ׂ̗]�������� START
////			i�J�n�� = (i���ݕŐ� - 1) * axGT���.Rows + 1;
//			i�J�n�� = (i���ݕŐ� - 1) * (axGT���.Rows - 1) + 1;
////			i�I���� = i���ݕŐ� * axGT���.Rows;
//			i�I���� = i���ݕŐ� * (axGT���.Rows - 1);
			i�J�n�� = (i���ݕŐ� - 1) * (i�ōő�s�� - 1) + 1;
			i�I���� = i���ݕŐ� * (i�ōő�s�� - 1);
// ADD 2006.12.18 ���s�j�����J ���ׂ̗]�������� END

//			short s�\���� = (short)1;
			short s�\���� = (short)2;
// MOD 2005.05.12 ���s�j�����J ��s�ڋ� END
			for(short sCnt = (short)i�J�n��; sCnt < s����ꗗ.Length && sCnt <= i�I���� ; sCnt++)
			{
// ADD 2006.12.14 ���s�j�����J ���ׂ̗]�������� START
				if(s�\���� > 15)
					axGT���.Rows++;
// ADD 2006.12.14 ���s�j�����J ���ׂ̗]�������� END

				axGT���.set_RowsText(s�\����, s����ꗗ[sCnt]);
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� START
				if(axGT���.get_CelText(s�\����, 3).CompareTo(axGT���.get_CelText(s�\����, 4)) < 0){
					axGT���.set_CelBackColor(s�\����,0,0xC0C0C0);
				}else{
					axGT���.set_CelBackColor(s�\����,0,0xFFFFFF);
				}
// MOD 2010.04.27 ���s�j���� �^�p���̂��q�l�̂ݑΏۋ@�\�̒ǉ� END
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

		private void �������_Activated(object sender, System.EventArgs e)
		{
			if(i�A�N�e�B�u�e�f == 0)
				����ꗗ����();		
		}
	}
}
