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
	public class �ב��l���� : ���ʃt�H�[��
	{
		public short nOldRow = 0;
		public string s����R�[�h;
		public string s����R�[�h;
		public string s�ב��l�R�[�h;
		public string s�J�i����;

		private string[] s�ב��l�ꗗ;
		private int      i���ݕŐ�;
		private int      i�ő�Ő�;
		private int      i�J�n��;
		private int      i�I����;
		private int      i�A�N�e�B�u�e�f = 0;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btn�m��;
		private System.Windows.Forms.Button btn����;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label lab�ב��l�^�C�g��;
		private ���ʃe�L�X�g�{�b�N�X tex�J�i����;
		private ���ʃe�L�X�g�{�b�N�X tex�ב��l�R�[�h;
		private System.Windows.Forms.Label lab�J�i����;
		private System.Windows.Forms.Label lab�ב��l�R�[�h;
		private AxGTABLE32V2Lib.AxGTable32 axGT�ב��l;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lab�Ŕԍ�;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�O��;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public �ב��l����()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(�ב��l����));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab�Ŕԍ� = new System.Windows.Forms.Label();
            this.btn���� = new System.Windows.Forms.Button();
            this.btn�O�� = new System.Windows.Forms.Button();
            this.axGT�ב��l = new AxGTABLE32V2Lib.AxGTable32();
            this.btn�m�� = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tex�J�i���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab�J�i���� = new System.Windows.Forms.Label();
            this.lab�ב��l�R�[�h = new System.Windows.Forms.Label();
            this.tex�ב��l�R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.btn���� = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab�ב��l�^�C�g�� = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.btn���� = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT�ב��l)).BeginInit();
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
            this.panel1.Controls.Add(this.axGT�ב��l);
            this.panel1.Controls.Add(this.btn�m��);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 380);
            this.panel1.TabIndex = 1;
            // 
            // lab�Ŕԍ�
            // 
            this.lab�Ŕԍ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�Ŕԍ�.ForeColor = System.Drawing.Color.Green;
            this.lab�Ŕԍ�.Location = new System.Drawing.Point(600, 316);
            this.lab�Ŕԍ�.Name = "lab�Ŕԍ�";
            this.lab�Ŕԍ�.Size = new System.Drawing.Size(48, 14);
            this.lab�Ŕԍ�.TabIndex = 79;
            this.lab�Ŕԍ�.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn����
            // 
            this.btn����.BackColor = System.Drawing.Color.SteelBlue;
            this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn����.ForeColor = System.Drawing.Color.White;
            this.btn����.Location = new System.Drawing.Point(648, 312);
            this.btn����.Name = "btn����";
            this.btn����.Size = new System.Drawing.Size(48, 22);
            this.btn����.TabIndex = 78;
            this.btn����.TabStop = false;
            this.btn����.Text = "����";
            this.btn����.UseVisualStyleBackColor = false;
            this.btn����.Click += new System.EventHandler(this.btn����_Click);
            // 
            // btn�O��
            // 
            this.btn�O��.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�O��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�O��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�O��.ForeColor = System.Drawing.Color.White;
            this.btn�O��.Location = new System.Drawing.Point(552, 312);
            this.btn�O��.Name = "btn�O��";
            this.btn�O��.Size = new System.Drawing.Size(48, 22);
            this.btn�O��.TabIndex = 77;
            this.btn�O��.TabStop = false;
            this.btn�O��.Text = "�O��";
            this.btn�O��.UseVisualStyleBackColor = false;
            this.btn�O��.Click += new System.EventHandler(this.btn�O��_Click);
            // 
            // axGT�ב��l
            // 
            this.axGT�ב��l.DataSource = null;
            this.axGT�ב��l.Location = new System.Drawing.Point(20, 14);
            this.axGT�ב��l.Name = "axGT�ב��l";
            this.axGT�ב��l.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT�ב��l.OcxState")));
            this.axGT�ב��l.Size = new System.Drawing.Size(696, 289);
            this.axGT�ב��l.TabIndex = 4;
            this.axGT�ב��l.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT�ב��l_CurPlaceChanged);
            this.axGT�ב��l.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT�ב��l_CelDblClick);
            this.axGT�ב��l.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT�ב��l_KeyDownEvent);
            // 
            // btn�m��
            // 
            this.btn�m��.BackColor = System.Drawing.Color.Blue;
            this.btn�m��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�m��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�m��.ForeColor = System.Drawing.Color.White;
            this.btn�m��.Location = new System.Drawing.Point(650, 352);
            this.btn�m��.Name = "btn�m��";
            this.btn�m��.Size = new System.Drawing.Size(64, 22);
            this.btn�m��.TabIndex = 5;
            this.btn�m��.Text = "�m��";
            this.btn�m��.UseVisualStyleBackColor = false;
            this.btn�m��.Click += new System.EventHandler(this.btn�m��_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.tex�J�i����);
            this.panel5.Controls.Add(this.lab�J�i����);
            this.panel5.Controls.Add(this.lab�ב��l�R�[�h);
            this.panel5.Controls.Add(this.tex�ב��l�R�[�h);
            this.panel5.Controls.Add(this.btn����);
            this.panel5.Location = new System.Drawing.Point(1, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 60);
            this.panel5.TabIndex = 3;
            // 
            // tex�J�i����
            // 
            this.tex�J�i����.BackColor = System.Drawing.SystemColors.Window;
            this.tex�J�i����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�J�i����.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.tex�J�i����.Location = new System.Drawing.Point(54, 6);
            this.tex�J�i����.MaxLength = 10;
            this.tex�J�i����.Name = "tex�J�i����";
            this.tex�J�i����.Size = new System.Drawing.Size(120, 23);
            this.tex�J�i����.TabIndex = 1;
            // 
            // lab�J�i����
            // 
            this.lab�J�i����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�J�i����.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�J�i����.Location = new System.Drawing.Point(8, 10);
            this.lab�J�i����.Name = "lab�J�i����";
            this.lab�J�i����.Size = new System.Drawing.Size(34, 16);
            this.lab�J�i����.TabIndex = 46;
            this.lab�J�i����.Text = "�J�i";
            // 
            // lab�ב��l�R�[�h
            // 
            this.lab�ב��l�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�ב��l�R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�ב��l�R�[�h.Location = new System.Drawing.Point(8, 34);
            this.lab�ב��l�R�[�h.Name = "lab�ב��l�R�[�h";
            this.lab�ב��l�R�[�h.Size = new System.Drawing.Size(44, 16);
            this.lab�ב��l�R�[�h.TabIndex = 6;
            this.lab�ב��l�R�[�h.Text = "�R�[�h";
            // 
            // tex�ב��l�R�[�h
            // 
            this.tex�ב��l�R�[�h.BackColor = System.Drawing.SystemColors.Window;
            this.tex�ב��l�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�ב��l�R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�ב��l�R�[�h.Location = new System.Drawing.Point(54, 30);
            this.tex�ב��l�R�[�h.MaxLength = 12;
            this.tex�ב��l�R�[�h.Name = "tex�ב��l�R�[�h";
            this.tex�ב��l�R�[�h.Size = new System.Drawing.Size(166, 23);
            this.tex�ב��l�R�[�h.TabIndex = 2;
            this.tex�ב��l�R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�ב��l�R�[�h_KeyDown);
            // 
            // btn����
            // 
            this.btn����.BackColor = System.Drawing.Color.SteelBlue;
            this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn����.ForeColor = System.Drawing.Color.White;
            this.btn����.Location = new System.Drawing.Point(292, 32);
            this.btn����.Name = "btn����";
            this.btn����.Size = new System.Drawing.Size(64, 22);
            this.btn����.TabIndex = 3;
            this.btn����.TabStop = false;
            this.btn����.Text = "����";
            this.btn����.UseVisualStyleBackColor = false;
            this.btn����.Click += new System.EventHandler(this.btn����_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab�ב��l�^�C�g��);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(794, 26);
            this.panel7.TabIndex = 13;
            // 
            // lab�ב��l�^�C�g��
            // 
            this.lab�ב��l�^�C�g��.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab�ב��l�^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�ב��l�^�C�g��.ForeColor = System.Drawing.Color.White;
            this.lab�ב��l�^�C�g��.Location = new System.Drawing.Point(12, 2);
            this.lab�ב��l�^�C�g��.Name = "lab�ב��l�^�C�g��";
            this.lab�ב��l�^�C�g��.Size = new System.Drawing.Size(264, 24);
            this.lab�ב��l�^�C�g��.TabIndex = 0;
            this.lab�ב��l�^�C�g��.Text = "�ב��l����";
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
            this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
            this.tex���b�Z�[�W.Location = new System.Drawing.Point(416, 4);
            this.tex���b�Z�[�W.Multiline = true;
            this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
            this.tex���b�Z�[�W.ReadOnly = true;
            this.tex���b�Z�[�W.Size = new System.Drawing.Size(376, 50);
            this.tex���b�Z�[�W.TabIndex = 7;
            this.tex���b�Z�[�W.TabStop = false;
            // 
            // btn����
            // 
            this.btn����.ForeColor = System.Drawing.Color.Red;
            this.btn����.Location = new System.Drawing.Point(8, 6);
            this.btn����.Name = "btn����";
            this.btn����.Size = new System.Drawing.Size(54, 48);
            this.btn����.TabIndex = 6;
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
            this.groupBox1.Location = new System.Drawing.Point(26, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(26, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 388);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // �ב��l����
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(794, 575);
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
            this.Name = "�ב��l����";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 �ב��l����";
            this.Activated += new System.EventHandler(this.�ב��l����_Activated);
            this.Closed += new System.EventHandler(this.�ב��l����_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On�G���^�[�ړ�);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On�G���^�[�L�����Z��);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGT�ב��l)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>
		private void Form1_Load(object sender, System.EventArgs e)
		{
			i�A�N�e�B�u�e�f = 0;
			tex�ב��l�R�[�h.Text = s�ב��l�R�[�h;
			axGT�ב��l.Cols = 5;
			axGT�ב��l.Rows = 15;
			axGT�ב��l.ColSep = "|";
			axGT�ב��l.CaretRow = 1;
			axGT�ב��l.NoBeep = true;
			
			axGT�ב��l.set_RowsText(0, "|���O|�Z��|�R�[�h|�d�b�ԍ�|�J�i����|");

			axGT�ב��l.ColsWidth = "0|14.2|14.2|9.7|8.6|7|";
			axGT�ב��l.ColsAlignHorz = "1|0|0|0|0|0|";

//			axGT�ב��l.set_CelForeColor(axGT�ב��l.CaretRow,0,111111);
			axGT�ב��l.set_CelForeColor(axGT�ב��l.CaretRow,0,0x98FB98);  //BGR
			axGT�ב��l.set_CelBackColor(axGT�ב��l.CaretRow,0,0x006000);
			
			btn�O��.Enabled = false;
			btn����.Enabled = false;
			lab�Ŕԍ�.Text = "";
			i���ݕŐ� = 1;
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			s�ב��l�R�[�h = "";
			this.Close();
		}

		private void axGT�ב��l_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			s�ב��l�R�[�h = axGT�ב��l.get_CelText(axGT�ב��l.CaretRow,3);
			if(s�ב��l�R�[�h != "")
				this.Close();
		}

		private void axGT�ב��l_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT�ב��l.set_CelForeColor(nOldRow,0,0);
			axGT�ב��l.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT�ב��l.set_CelForeColor(axGT�ב��l.CaretRow,0,111111);
			axGT�ב��l.set_CelForeColor(axGT�ב��l.CaretRow,0,0x98FB98);  //BGR
			axGT�ב��l.set_CelBackColor(axGT�ב��l.CaretRow,0,0x006000);
			nOldRow = axGT�ב��l.CaretRow;

		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			�ב��l�ꗗ����();
		}

		private void btn�m��_Click(object sender, System.EventArgs e)
		{
			s�ב��l�R�[�h = axGT�ב��l.get_CelText(axGT�ב��l.CaretRow,3);
			if(s�ב��l�R�[�h != "")
				this.Close();
		}

		private void �ב��l�ꗗ����()
		{
			i�A�N�e�B�u�e�f = 1;
			tex�J�i����.Text   = tex�J�i����.Text.Trim();
			tex�ב��l�R�[�h.Text = tex�ב��l�R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�J�i����, "�J�i")) return;
			if(!���p�`�F�b�N(tex�ב��l�R�[�h, "�R�[�h")) return;

			axGT�ב��l.Clear();

			tex���b�Z�[�W.Text = "�������D�D�D";

			s�ב��l�ꗗ = new string[1];
			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey  = new string[4];
				sKey[0] = s����R�[�h;
				sKey[1] = s����R�[�h;
				sKey[2] = tex�ב��l�R�[�h.Text;
				sKey[3] = tex�J�i����.Text;
				s�ב��l�ꗗ = sv_maintenance.Get_Consignor(gsa���[�U, sKey);
			}
// ADD 2005.05.25 ���s�j�����J �ʐM�G���[�̃��b�Z�[�W�C�� START
			catch (System.Net.WebException)
			{
				s�ב��l�ꗗ[0] = gs�ʐM�G���[;
			}
// ADD 2005.05.25 ���s�j�����J �ʐM�G���[�̃��b�Z�[�W�C�� END
			catch (Exception ex)
			{
				s�ב��l�ꗗ[0] = "�ʐM�G���[�F" + ex.Message;
			}
				
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;
			
			if (s�ב��l�ꗗ[0].Equals("����I��"))
			{
				tex���b�Z�[�W.Text = "";
// MOD 2005.05.12 ���s�j�����J ��s�ڋ� START
//				i�ő�Ő� = (s�ב��l�ꗗ.Length - 2) / axGT�ב��l.Rows + 1;
				i�ő�Ő� = (s�ב��l�ꗗ.Length - 2) / (axGT�ב��l.Rows - 1) + 1;
// MOD 2005.05.12 ���s�j�����J ��s�ڋ� END
				if (i���ݕŐ� > i�ő�Ő�)
					i���ݕŐ� = i�ő�Ő�;
				�ŏ��ݒ�();

// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� START
				axGT�ב��l.CaretRow = 1;
				axGT�ב��l_CurPlaceChanged(null,null);
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� END

				axGT�ב��l.Focus();
			}
			else
			{
				if (s�ב��l�ꗗ[0].Equals("�Y���f�[�^������܂���"))
				{
					tex���b�Z�[�W.Text = "";
					MessageBox.Show("�Y���f�[�^������܂���","�ב��l����",MessageBoxButtons.OK);
				}
				else
				{
					tex���b�Z�[�W.Text = s�ב��l�ꗗ[0];
					i���ݕŐ� = 1;
					btn�O��.Enabled = false;
					btn����.Enabled = false;
					lab�Ŕԍ�.Text = "";
					�r�[�v��();
				}
				tex�J�i����.Focus();
			}
		}

		private void axGT�ב��l_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				s�ב��l�R�[�h = axGT�ב��l.get_CelText(axGT�ב��l.CaretRow,3);
				if(s�ב��l�R�[�h != "")
					this.Close();
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT�ב��l, true, true, true, true);
			}
		}

		private void tex�ב��l�R�[�h_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				�ב��l�ꗗ����();
			}		
		}


		private void btn�O��_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�--;
			�ŏ��ݒ�();
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� START
			axGT�ב��l.CaretRow = 1;
			axGT�ב��l_CurPlaceChanged(null,null);
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� END
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�++;
			�ŏ��ݒ�();
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� START
			axGT�ב��l.CaretRow = 1;
			axGT�ב��l_CurPlaceChanged(null,null);
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� END
		}

		private void �ŏ��ݒ�()
		{
			axGT�ב��l.Clear();

// MOD 2005.05.12 ���s�j�����J ��s�ڋ� START
//			i�J�n�� = (i���ݕŐ� - 1) * axGT�ב��l.Rows + 1;
			i�J�n�� = (i���ݕŐ� - 1) * (axGT�ב��l.Rows - 1) + 1;
//			i�I���� = i���ݕŐ� * axGT�ב��l.Rows;
			i�I���� = i���ݕŐ� * (axGT�ב��l.Rows - 1);

//			short s�\���� = (short)1;
			short s�\���� = (short)2;
// MOD 2005.05.12 ���s�j�����J ��s�ڋ� END
			for(short sCnt = (short)i�J�n��; sCnt < s�ב��l�ꗗ.Length && sCnt <= i�I���� ; sCnt++)
			{
				axGT�ב��l.set_RowsText(s�\����, s�ב��l�ꗗ[sCnt]);
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
			axGT�ב��l.Focus();
		}

		private void �ב��l����_Activated(object sender, System.EventArgs e)
		{
			if(i�A�N�e�B�u�e�f == 0)
				�ב��l�ꗗ����();
		}

// ADD 2005.05.25 ���s�j�����J �t�H�[�J�X�ړ� START
		private void �ב��l����_Closed(object sender, System.EventArgs e)
		{
			tex�J�i����.Text     = " ";
			tex�ב��l�R�[�h.Text = "";
			axGT�ב��l.CaretRow = 1;
			axGT�ב��l_CurPlaceChanged(null,null);
			tex�J�i����.Focus();
		}
// ADD 2005.05.25 ���s�j�����J �t�H�[�J�X�ړ� END

	}
}
