// ADD 2007.12.05 KCL) �X�{ ���m�点�ǉ� START
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [���m�点����]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2008.05.15 ACT Vista�Ή��i�S�p���p���݃`�F�b�N�̏ꏊ�ړ��j 
	//--------------------------------------------------------------------------
	// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� 
	//--------------------------------------------------------------------------
	public class ���m�点���� : ���ʃt�H�[��
	{
		public short nOldRow = 0;

		public string s�o�^��;
		public string s�\��;
		public string s�ڍד��e;
		public string s�{�^����;
		public string s�A�h���X;
		public string s�D�揇;
		public string s�V�[�P���X�m��;
		public decimal d�X�V����;
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
		public string s����敪;
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END

		private string[] s���m�点�ꗗ;
		private int      i���ݕŐ�;
		private int      i�ő�Ő�;
		private int      i�J�n��;
		private int      i�I����;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btn�m��;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btn����;
		private AxGTABLE32V2Lib.AxGTable32 axGT���m�点;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lab�Ŕԍ�;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�O��;
		private System.Windows.Forms.Label lab���m�点����;
		private System.Windows.Forms.Label lab�ڍד��e;
		private System.Windows.Forms.Label lab�o�^��;
		private System.Windows.Forms.Label lab�\��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�ڍד��e;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�o�^��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�\��;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ���m�点����()
		{
			//
			// Windows �t�H�[�� �f�U�C�i �T�|�[�g�ɕK�v�ł��B
			//
			InitializeComponent();

			// �X�v���b�h�V�[�g�̏�����
			InitializeAxGTable32();
		}

		#region �X�v���b�h�V�[�g�̏�����
		private void InitializeAxGTable32() 
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(���m�点����));
			this.axGT���m�点 = new AxGTABLE32V2Lib.AxGTable32();
			// 
			// axGT���m�点
			// 
			((System.ComponentModel.ISupportInitialize)(this.axGT���m�点)).BeginInit();
			this.axGT���m�点.ContainingControl = this;
			this.axGT���m�点.DataSource = null;
			this.axGT���m�点.Location = new System.Drawing.Point(8, 8);
			this.axGT���m�点.Name = "axGT���m�点";
			this.axGT���m�点.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT���m�点.OcxState")));
			this.axGT���m�点.Size = new System.Drawing.Size(357, 271);
			this.axGT���m�点.TabIndex = 0;
			this.axGT���m�点.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT���m�点_KeyDownEvent);
			this.axGT���m�点.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT���m�点_CelDblClick);
			this.axGT���m�点.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT���m�点_CurPlaceChanged);
			((System.ComponentModel.ISupportInitialize)(this.axGT���m�点)).EndInit();

			this.panel1.SuspendLayout();
			this.panel1.Controls.Add(this.axGT���m�点);
			this.panel1.ResumeLayout(false);
		}
		#endregion

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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab�Ŕԍ� = new System.Windows.Forms.Label();
			this.btn���� = new System.Windows.Forms.Button();
			this.btn�O�� = new System.Windows.Forms.Button();
			this.btn�m�� = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab���m�点���� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn���� = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lab�ڍד��e = new System.Windows.Forms.Label();
			this.tex�ڍד��e = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�o�^�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�o�^�� = new System.Windows.Forms.Label();
			this.lab�\�� = new System.Windows.Forms.Label();
			this.tex�\�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn���� = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
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
			this.panel7.Controls.Add(this.lab���m�点����);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab���m�点����
			// 
			this.lab���m�点����.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab���m�点����.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���m�点����.ForeColor = System.Drawing.Color.White;
			this.lab���m�点����.Location = new System.Drawing.Point(12, 2);
			this.lab���m�点����.Name = "lab���m�点����";
			this.lab���m�点����.Size = new System.Drawing.Size(264, 24);
			this.lab���m�点����.TabIndex = 0;
			this.lab���m�点����.Text = "���m�点����";
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
			this.panel5.Controls.Add(this.lab�ڍד��e);
			this.panel5.Controls.Add(this.tex�ڍד��e);
			this.panel5.Controls.Add(this.tex�o�^��);
			this.panel5.Controls.Add(this.lab�o�^��);
			this.panel5.Controls.Add(this.lab�\��);
			this.panel5.Controls.Add(this.tex�\��);
			this.panel5.Controls.Add(this.btn����);
			this.panel5.Location = new System.Drawing.Point(1, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(373, 90);
			this.panel5.TabIndex = 3;
			// 
			// lab�ڍד��e
			// 
			this.lab�ڍד��e.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�ڍד��e.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�ڍד��e.Location = new System.Drawing.Point(2, 64);
			this.lab�ڍד��e.Name = "lab�ڍד��e";
			this.lab�ڍד��e.Size = new System.Drawing.Size(72, 16);
			this.lab�ڍד��e.TabIndex = 49;
			this.lab�ڍד��e.Text = "�ڍד��e";
			// 
			// tex�ڍד��e
			// 
			this.tex�ڍד��e.BackColor = System.Drawing.SystemColors.Window;
			this.tex�ڍד��e.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ڍד��e.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�ڍד��e.Location = new System.Drawing.Point(74, 60);
			this.tex�ڍד��e.MaxLength = 1000;
			this.tex�ڍד��e.Name = "tex�ڍד��e";
			this.tex�ڍד��e.Size = new System.Drawing.Size(230, 23);
			this.tex�ڍד��e.TabIndex = 3;
			this.tex�ڍד��e.Text = "";
			this.tex�ڍד��e.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�ڍד��e_KeyDown);
			// 
			// tex�o�^��
			// 
			this.tex�o�^��.BackColor = System.Drawing.SystemColors.Window;
			this.tex�o�^��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�o�^��.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�o�^��.Location = new System.Drawing.Point(74, 8);
			this.tex�o�^��.MaxLength = 10;
			this.tex�o�^��.Name = "tex�o�^��";
			this.tex�o�^��.Size = new System.Drawing.Size(126, 23);
			this.tex�o�^��.TabIndex = 0;
			this.tex�o�^��.Text = "";
			// 
			// lab�o�^��
			// 
			this.lab�o�^��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�o�^��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�o�^��.Location = new System.Drawing.Point(2, 12);
			this.lab�o�^��.Name = "lab�o�^��";
			this.lab�o�^��.Size = new System.Drawing.Size(72, 16);
			this.lab�o�^��.TabIndex = 46;
			this.lab�o�^��.Text = "�o�^��";
			// 
			// lab�\��
			// 
			this.lab�\��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�\��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�\��.Location = new System.Drawing.Point(2, 38);
			this.lab�\��.Name = "lab�\��";
			this.lab�\��.Size = new System.Drawing.Size(72, 16);
			this.lab�\��.TabIndex = 6;
			this.lab�\��.Text = "�\�@��";
			// 
			// tex�\��
			// 
			this.tex�\��.BackColor = System.Drawing.SystemColors.Window;
			this.tex�\��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\��.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex�\��.Location = new System.Drawing.Point(74, 34);
			this.tex�\��.MaxLength = 30;
			this.tex�\��.Name = "tex�\��";
			this.tex�\��.Size = new System.Drawing.Size(230, 23);
			this.tex�\��.TabIndex = 2;
			this.tex�\��.Text = "";
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
			// ���m�点����
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
			this.Name = "���m�点����";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ���m�点����";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.���m�点����_Load);
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ���m�点����_Load(object sender, System.EventArgs e)
		{
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			axGT���m�点.Cols = 4;
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
			axGT���m�点.Rows = 14;
			axGT���m�点.ColSep = "|";
			axGT���m�点.CaretRow = 1;
			axGT���m�点.NoBeep = true;
			
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			axGT���m�点.set_RowsText(0, "|�o�^��|���m�点�i�\��j|||");
//
//			axGT���m�点.ColsWidth = "0|6|19.9|0|0|";
//			axGT���m�点.ColsAlignHorz = "1|0|0|0|0|";
			axGT���m�点.Cols = 5;
			axGT���m�点.set_RowsText(0, "|�o�^��|�敪|���m�点�i�\��j|||");

			axGT���m�点.ColsWidth = "0|5|3.5|17.4|0|0|";
			axGT���m�点.ColsAlignHorz = "1|0|1|0|0|0|";
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
			axGT���m�点.set_CelForeColor(axGT���m�点.CaretRow,0,0x98FB98);  //BGR
			axGT���m�点.set_CelBackColor(axGT���m�点.CaretRow,0,0x006000);

			btn�O��.Enabled = false;
			btn����.Enabled = false;
			lab�Ŕԍ�.Text = "";
			i���ݕŐ� = 1;

			axGT���m�点.CaretRow = 1;
			axGT���m�点_CurPlaceChanged(null,null);

			this.���m�点�ꗗ����();

			tex�o�^��.Focus();
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			// �������ʃN���A
			this.���ڃN���A();

			// ���̃t�H�[�������
			this.Close();
		}

		private void axGT���m�点_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			// ���m�点�f�[�^���擾
			if (this.���m�点���e�擾()) 
			{
				// �擾�ɐ��������ꍇ
				// ���̃t�H�[�������
				this.Close();
			}
		}

		private void axGT���m�点_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT���m�点.set_CelForeColor(nOldRow,0,0);
			axGT���m�点.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGT���m�点.set_CelForeColor(axGT���m�点.CaretRow,0,0x98FB98);  //BGR
			axGT���m�点.set_CelBackColor(axGT���m�点.CaretRow,0,0x006000);
			nOldRow = axGT���m�点.CaretRow;
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			���m�点�ꗗ����();
		}

		private void btn�m��_Click(object sender, System.EventArgs e)
		{
			// ���m�点�f�[�^���擾
			if (this.���m�点���e�擾()) 
			{
				// �擾�ɐ��������ꍇ
				// ���̃t�H�[�������
				this.Close();
			}
		}

		public void ���ڃN���A() 
		{
			// �����f�[�^�N���A
			s�o�^��			= string.Empty;
			s�\��			= string.Empty;
			s�ڍד��e		= string.Empty;
			s�{�^����		= string.Empty;
			s�A�h���X		= string.Empty;
			s�D�揇			= string.Empty;
			s�V�[�P���X�m��	= string.Empty;
			d�X�V����		= 0m;
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
			s����敪		= "0";
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END

			// �\���N���A
			tex�o�^��.Text	= string.Empty;
			tex�\��.Text		= string.Empty;
			tex�ڍד��e.Text	= string.Empty;
		}

		private bool ���m�点���e�擾() 
		{
			bool bResult = false;

			// �I�����ꂽ�f�[�^�����
			string [] sKey = new string [2];
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			sKey[0] = axGT���m�点.get_CelText(axGT���m�点.CaretRow,3);		// �o�^��
//			sKey[1] = axGT���m�点.get_CelText(axGT���m�点.CaretRow,4);		// �V�[�P���X�m��
			sKey[0] = axGT���m�点.get_CelText(axGT���m�点.CaretRow,4);		// �o�^��
			sKey[1] = axGT���m�点.get_CelText(axGT���m�点.CaretRow,5);		// �V�[�P���X�m��
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END

			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			// ���m�点�擾
			tex���b�Z�[�W.Text = "�������D�D�D";
			string [] sRet;
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				sRet = sv_oshirase.Sel_Oshirase(gsa���[�U, sKey);
			}
			catch (System.Net.WebException)
			{
				// �ʐM�G���[����
				sRet = new string [1];
				sRet[0] = gs�ʐM�G���[;
			}
			catch (Exception ex)
			{
				// ���̑��̃G���[����
				sRet = new string [1];
				sRet[0] = "�ʐM�G���[�F" + ex.Message;
			}
			
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			// ���ʏ���
			switch (sRet[0].Trim()) 
			{
				case "����I��" :		// �擾����

					// �߂�l�ݒ�
					s�o�^��			= sRet[1];
					s�\��			= sRet[2];
					s�ڍד��e		= sRet[3].Replace("\n", "\r\n");
					s�{�^����		= sRet[4];
					s�A�h���X		= sRet[5];
					s�D�揇			= sRet[6];
					s�V�[�P���X�m��	= sRet[7];
					d�X�V����		= Convert.ToDecimal(sRet[8]);
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
					if(sRet.Length > 9){
						s����敪	= sRet[9];
					}
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
					tex���b�Z�[�W.Text = string.Empty;

					bResult = true;

					break;

				default :				// �擾���s

					// �߂�l�N���A
					this.���ڃN���A();
					// �G���[���b�Z�[�W�\��
					�r�[�v��();
					tex���b�Z�[�W.Text = sRet[0];

					bResult = false;

					break;
			}

			return bResult;
		}

		private void ���m�点�ꗗ����()
		{
// ADD 2008.05.15 ACT Vista�Ή��i�S�p���p���݃`�F�b�N�̏ꏊ�ړ��j START
			if (!�S�p���p���݃`�F�b�N(tex�\��, "�\��")) return;
			if (!�S�p���p���݃`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;
// ADD 2008.05.15 ACT Vista�Ή��i�S�p���p���݃`�F�b�N�̏ꏊ�ړ��j END

			// ���͎擾
			string sTourokubi	= tex�o�^��.Text.Trim();
			string sHyoudai		= tex�\��.Text.Trim();
			string sSyousai		= tex�ڍד��e.Text.Trim();

			// ���̓`�F�b�N
// DEL 2008.05.15 ACT Vista�Ή��i�S�p���p���݃`�F�b�N�̏ꏊ�ړ��j START
//// ADD 2008.05.07 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� START
//			if (!�S�p���p���݃`�F�b�N(tex�\��, "�\��")) return;
//			if (!�S�p���p���݃`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;
//// ADD 2008.05.07 ���s�j���� �\��A�ڍד��e�̑S�p���p���݃`�F�b�N�̒ǉ� END
// DEL 2008.05.15 ACT Vista�Ή��i�S�p���p���݃`�F�b�N�̏ꏊ�ړ��j END
			// �^�`�F�b�N
			if ((sTourokubi.Length != 0) && !���t�`�F�b�N(tex�o�^��, "�o�^��")) return;
			if ((sHyoudai.Length != 0)   && !�֑������`�F�b�N(tex�\��, "�\��")) return;
			if ((sSyousai.Length != 0)   && !�֑������`�F�b�N(tex�ڍד��e, "�ڍד��e")) return;
			// �o�C�g���`�F�b�N
			if (!�o�C�g���`�F�b�N(tex�\��, "�\��", 60)) return;
			if (!�o�C�g���`�F�b�N(tex�ڍד��e, "�ڍד��e", 2000)) return;

			// �󔒏���
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
//			string [] sKey = new string [5];
			string [] sKey = new string [6];
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END
			sKey[0] = (sTourokubi.Length != 0) 
				? DateTime.Parse(sTourokubi).ToString("yyyyMMdd") : string.Empty;	// �J�n�o�^��
			sKey[1] = sKey[0];			// �I���o�^��
			sKey[2] = sHyoudai;			// �\��
			sKey[3] = sSyousai;			// �ڍד��e
			sKey[4] = string.Empty;		// ��ʂm��
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� START
			sKey[5] = "���m�点����";	// �@�\
// MOD 2009.06.08 ���s�j���� �c�Ə��p���m�点�\���@�\�̒ǉ� END

			// �\�N���A
			axGT���m�点.Clear();

			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			// ���m�点�ꗗ�̎擾
			tex���b�Z�[�W.Text = "�������D�D�D";
			s���m�点�ꗗ = new string [1];
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				s���m�点�ꗗ = sv_oshirase.Get_OshiraseTopN(gsa���[�U, sKey);
			}
			catch (System.Net.WebException)
			{
				// �ʐM�G���[����
				s���m�点�ꗗ[0] = gs�ʐM�G���[;
			}
			catch (Exception ex)
			{
				// ���̑��̃G���[����
				s���m�点�ꗗ[0] = "�ʐM�G���[�F" + ex.Message;
			}
			
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			// ���ʏ���
			switch (s���m�点�ꗗ[0].Trim()) 
			{
				case "����I��" :

					tex���b�Z�[�W.Text = string.Empty;
					i�ő�Ő� = (s���m�点�ꗗ.Length - 2) / (axGT���m�点.Rows - 1) + 1;
					if (i���ݕŐ� > i�ő�Ő�)
						i���ݕŐ� = i�ő�Ő�;
					�ŏ��ݒ�();

					// ��s�ڑI��
					axGT���m�点.CaretRow = 1;
					axGT���m�点_CurPlaceChanged(null, null);

					axGT���m�点.Focus();

					break;

				case "�Y���f�[�^������܂���" :

					tex���b�Z�[�W.Text = string.Empty;
					MessageBox.Show("�Y���f�[�^������܂���", "���m�点����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

					tex�o�^��.Focus();

					break;

				default :

					tex���b�Z�[�W.Text = s���m�点�ꗗ[0];
					i���ݕŐ� = 1;
					btn�O��.Enabled = false;
					btn����.Enabled = false;
					lab�Ŕԍ�.Text = string.Empty;
					�r�[�v��();

					tex�o�^��.Focus();

					break;
			}
		}

		private void axGT���m�点_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				// ���m�点�f�[�^���擾
				if (this.���m�点���e�擾()) 
				{
					// �擾�ɐ��������ꍇ
					// ���̃t�H�[�������
					this.Close();
				}
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT���m�点, true, true, true, true);
			}
		}

		private void tex�ڍד��e_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				���m�点�ꗗ����();
			}
		}

		private void btn�O��_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�--;
			�ŏ��ݒ�();

			axGT���m�点.CaretRow = 1;
			axGT���m�点_CurPlaceChanged(null,null);
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�++;
			�ŏ��ݒ�();

			axGT���m�点.CaretRow = 1;
			axGT���m�点_CurPlaceChanged(null,null);
		}

		private void �ŏ��ݒ�()
		{
			axGT���m�点.Clear();

			i�J�n�� = (i���ݕŐ� - 1) * (axGT���m�点.Rows - 1) + 1;
			i�I���� = i���ݕŐ� * (axGT���m�点.Rows - 1);

			short s�\���� = (short) 2;
			for(short sCnt = (short) i�J�n��; sCnt < s���m�点�ꗗ.Length && sCnt <= i�I����; sCnt++)
			{
				axGT���m�点.set_RowsText(s�\����, s���m�点�ꗗ[sCnt]);
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
			axGT���m�点.Focus();
		}
	}
}
// ADD 2007.12.05 KCL) �X�{ ���m�点�ǉ� END
