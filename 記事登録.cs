using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [�L���o�^]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2005.05.25 ���s�j�����J �ʐM�G���[�̃��b�Z�[�W�C�� 
	// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX 
	//--------------------------------------------------------------------------
	// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� 
	//--------------------------------------------------------------------------
	public class �L���o�^ : ���ʃt�H�[��
	{

		private short    nOldRow    = 0;
		private string   s�X�V���� = "";
		private string   s�L�����;
		private string   s�L������;
		private string[] s�L���ꗗ;
		private string[] s�A�����i�e�ꗗ;
		private int      i���ݕŐ�;
		private int      i�ő�Ő�;
		private int      i�J�n��;
		private int      i�I����;
		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label lab�L���^�C�g��;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private AxGTABLE32V2Lib.AxGTable32 axGT�L��;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lab�L����;
		private ���ʃe�L�X�g�{�b�N�X tex�L����;
		private System.Windows.Forms.Label label4;
		private ���ʃe�L�X�g�{�b�N�X tex�L���R�[�h;
		private System.Windows.Forms.Button btn�폜;
		private System.Windows.Forms.Button btn�X�V;
		private System.Windows.Forms.Label lab�Ŕԍ�;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�O��;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmb�L�����;
		private System.Windows.Forms.ComboBox cmb�A�����i�e;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public �L���o�^()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(�L���o�^));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb�A�����i�e = new System.Windows.Forms.ComboBox();
            this.cmb�L����� = new System.Windows.Forms.ComboBox();
            this.lab�Ŕԍ� = new System.Windows.Forms.Label();
            this.btn���� = new System.Windows.Forms.Button();
            this.btn�O�� = new System.Windows.Forms.Button();
            this.btn�X�V = new System.Windows.Forms.Button();
            this.btn�폜 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tex�L���R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab�L���� = new System.Windows.Forms.Label();
            this.tex�L���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.axGT�L�� = new AxGTABLE32V2Lib.AxGTable32();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab�L���^�C�g�� = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
            this.btn���� = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT�L��)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.cmb�A�����i�e);
            this.panel1.Controls.Add(this.cmb�L�����);
            this.panel1.Controls.Add(this.lab�Ŕԍ�);
            this.panel1.Controls.Add(this.btn����);
            this.panel1.Controls.Add(this.btn�O��);
            this.panel1.Controls.Add(this.btn�X�V);
            this.panel1.Controls.Add(this.btn�폜);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tex�L���R�[�h);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lab�L����);
            this.panel1.Controls.Add(this.tex�L����);
            this.panel1.Controls.Add(this.axGT�L��);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 440);
            this.panel1.TabIndex = 0;
            // 
            // cmb�A�����i�e
            // 
            this.cmb�A�����i�e.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb�A�����i�e.Location = new System.Drawing.Point(220, 10);
            this.cmb�A�����i�e.Name = "cmb�A�����i�e";
            this.cmb�A�����i�e.Size = new System.Drawing.Size(138, 20);
            this.cmb�A�����i�e.TabIndex = 2;
            this.cmb�A�����i�e.SelectionChangeCommitted += new System.EventHandler(this.cmb�A�����i�e_SelectionChangeCommitted);
            // 
            // cmb�L�����
            // 
            this.cmb�L�����.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb�L�����.Items.AddRange(new object[] {
            "�A�����i",
            "�A�����i�@���l",
            "���q�^�� �A�����i",
            "���q�^�� �A�����i ���l",
            "�����񋟂̕i���L��"});
            this.cmb�L�����.Location = new System.Drawing.Point(64, 10);
            this.cmb�L�����.Name = "cmb�L�����";
            this.cmb�L�����.Size = new System.Drawing.Size(154, 20);
            this.cmb�L�����.TabIndex = 1;
            this.cmb�L�����.SelectionChangeCommitted += new System.EventHandler(this.cmb�L�����_SelectionChangeCommitted);
            // 
            // lab�Ŕԍ�
            // 
            this.lab�Ŕԍ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�Ŕԍ�.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�Ŕԍ�.Location = new System.Drawing.Point(250, 322);
            this.lab�Ŕԍ�.Name = "lab�Ŕԍ�";
            this.lab�Ŕԍ�.Size = new System.Drawing.Size(48, 14);
            this.lab�Ŕԍ�.TabIndex = 64;
            this.lab�Ŕԍ�.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn����
            // 
            this.btn����.BackColor = System.Drawing.Color.SteelBlue;
            this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn����.ForeColor = System.Drawing.Color.White;
            this.btn����.Location = new System.Drawing.Point(298, 318);
            this.btn����.Name = "btn����";
            this.btn����.Size = new System.Drawing.Size(48, 22);
            this.btn����.TabIndex = 63;
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
            this.btn�O��.Location = new System.Drawing.Point(202, 318);
            this.btn�O��.Name = "btn�O��";
            this.btn�O��.Size = new System.Drawing.Size(48, 22);
            this.btn�O��.TabIndex = 62;
            this.btn�O��.Text = "�O��";
            this.btn�O��.UseVisualStyleBackColor = false;
            this.btn�O��.Click += new System.EventHandler(this.btn�O��_Click);
            // 
            // btn�X�V
            // 
            this.btn�X�V.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�X�V.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�X�V.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�X�V.ForeColor = System.Drawing.Color.White;
            this.btn�X�V.Location = new System.Drawing.Point(210, 410);
            this.btn�X�V.Name = "btn�X�V";
            this.btn�X�V.Size = new System.Drawing.Size(64, 22);
            this.btn�X�V.TabIndex = 6;
            this.btn�X�V.Text = "�ۑ�";
            this.btn�X�V.UseVisualStyleBackColor = false;
            this.btn�X�V.Click += new System.EventHandler(this.btn�X�V_Click);
            // 
            // btn�폜
            // 
            this.btn�폜.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�폜.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�폜.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�폜.ForeColor = System.Drawing.Color.White;
            this.btn�폜.Location = new System.Drawing.Point(282, 410);
            this.btn�폜.Name = "btn�폜";
            this.btn�폜.Size = new System.Drawing.Size(64, 22);
            this.btn�폜.TabIndex = 7;
            this.btn�폜.Text = "�폜";
            this.btn�폜.UseVisualStyleBackColor = false;
            this.btn�폜.Click += new System.EventHandler(this.btn�폜_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(82, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 61;
            this.label4.Text = "�L���R�[�h";
            // 
            // tex�L���R�[�h
            // 
            this.tex�L���R�[�h.BackColor = System.Drawing.SystemColors.Window;
            this.tex�L���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�L���R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�L���R�[�h.Location = new System.Drawing.Point(144, 348);
            this.tex�L���R�[�h.MaxLength = 4;
            this.tex�L���R�[�h.Name = "tex�L���R�[�h";
            this.tex�L���R�[�h.Size = new System.Drawing.Size(42, 23);
            this.tex�L���R�[�h.TabIndex = 4;
            this.tex�L���R�[�h.Text = "1234";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(68, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 14);
            this.label2.TabIndex = 59;
            this.label2.Text = "��";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(68, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 14);
            this.label1.TabIndex = 57;
            this.label1.Text = "��";
            // 
            // lab�L����
            // 
            this.lab�L����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�L����.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�L����.Location = new System.Drawing.Point(82, 382);
            this.lab�L����.Name = "lab�L����";
            this.lab�L����.Size = new System.Drawing.Size(58, 14);
            this.lab�L����.TabIndex = 56;
            this.lab�L����.Text = "�L����";
            // 
            // tex�L����
            // 
            this.tex�L����.BackColor = System.Drawing.SystemColors.Window;
            this.tex�L����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�L����.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex�L����.Location = new System.Drawing.Point(144, 378);
            this.tex�L����.MaxLength = 15;
            this.tex�L����.Name = "tex�L����";
            this.tex�L����.Size = new System.Drawing.Size(206, 23);
            this.tex�L����.TabIndex = 5;
            // 
            // axGT�L��
            // 
            this.axGT�L��.DataSource = null;
            this.axGT�L��.Location = new System.Drawing.Point(80, 38);
            this.axGT�L��.Name = "axGT�L��";
            this.axGT�L��.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT�L��.OcxState")));
            this.axGT�L��.Size = new System.Drawing.Size(194, 272);
            this.axGT�L��.TabIndex = 3;
            this.axGT�L��.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT�L��_CurPlaceChanged);
            this.axGT�L��.CelClick += new AxGTABLE32V2Lib._DGTable32Events_CelClickEventHandler(this.axGT�L��_CelClick);
            this.axGT�L��.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT�L��_KeyDownEvent);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab�L���^�C�g��);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(396, 26);
            this.panel7.TabIndex = 13;
            // 
            // lab�L���^�C�g��
            // 
            this.lab�L���^�C�g��.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab�L���^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�L���^�C�g��.ForeColor = System.Drawing.Color.White;
            this.lab�L���^�C�g��.Location = new System.Drawing.Point(12, 2);
            this.lab�L���^�C�g��.Name = "lab�L���^�C�g��";
            this.lab�L���^�C�g��.Size = new System.Drawing.Size(264, 24);
            this.lab�L���^�C�g��.TabIndex = 0;
            this.lab�L���^�C�g��.Text = "�L���o�^";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PaleGreen;
            this.panel8.Controls.Add(this.tex���b�Z�[�W);
            this.panel8.Controls.Add(this.btn����);
            this.panel8.Location = new System.Drawing.Point(0, 516);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(388, 58);
            this.panel8.TabIndex = 1;
            // 
            // tex���b�Z�[�W
            // 
            this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
            this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
            this.tex���b�Z�[�W.Location = new System.Drawing.Point(126, 4);
            this.tex���b�Z�[�W.Multiline = true;
            this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
            this.tex���b�Z�[�W.ReadOnly = true;
            this.tex���b�Z�[�W.Size = new System.Drawing.Size(256, 50);
            this.tex���b�Z�[�W.TabIndex = 0;
            this.tex���b�Z�[�W.TabStop = false;
            // 
            // btn����
            // 
            this.btn����.ForeColor = System.Drawing.Color.Red;
            this.btn����.Location = new System.Drawing.Point(8, 6);
            this.btn����.Name = "btn����";
            this.btn����.Size = new System.Drawing.Size(54, 48);
            this.btn����.TabIndex = 8;
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
            this.panel6.Size = new System.Drawing.Size(396, 26);
            this.panel6.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(8, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // �L���o�^
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(390, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(396, 607);
            this.Name = "�L���o�^";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 �L���o�^";
            this.Closed += new System.EventHandler(this.�L���o�^_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On�G���^�[�ړ�);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On�G���^�[�L�����Z��);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT�L��)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
			axGT�L��.Cols = 3;
			axGT�L��.Rows = 14;
			axGT�L��.ColSep = "|";

			axGT�L��.set_RowsText(0, "|�R�[�h|�L��|");

			axGT�L��.ColsWidth = "0|4|10.9|0|";
			axGT�L��.ColsAlignHorz = "1|1|0|0|";
            
//			axGT�L��.set_CelForeColor(axGT�L��.CaretRow,0,111111);
			axGT�L��.set_CelForeColor(axGT�L��.CaretRow,0,0x98FB98);  //BGR
			axGT�L��.set_CelBackColor(axGT�L��.CaretRow,0,0x006000);

			axGT�L��.CaretRow = 1;
			cmb�L�����.SelectedIndex = 0;
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX START
			s�L����� = "yusoshohin";
//			s�L������ = "yusoshiji";
			s�L������ = "0000";
			cmb�A�����i�e.Visible = false;
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX END
			i���ݕŐ� = 1;
			�L���ꗗ����();
		}

		private void �L���ꗗ����()
		{
			tex�L���R�[�h.Text = "";
			tex�L����.Text     = "";
			s�X�V����        = "";
			
			s�L���ꗗ = new string[1];
			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX START
//				s�L���ꗗ = sv_maintenance.Get_Kiji(gsa���[�U,"default",s�L������);
				s�L���ꗗ = sv_maintenance.Get_Kiji(gsa���[�U,s�L�����,s�L������);
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX END
			}
// ADD 2005.05.25 ���s�j�����J �ʐM�G���[�̃��b�Z�[�W�C�� START
			catch (System.Net.WebException)
			{
				s�L���ꗗ[0] = gs�ʐM�G���[;
			}
// ADD 2005.05.25 ���s�j�����J �ʐM�G���[�̃��b�Z�[�W�C�� END
			catch (Exception ex)
			{
				s�L���ꗗ[0] = "�ʐM�G���[�F" + ex.Message;
			}
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			tex���b�Z�[�W.Text = s�L���ꗗ[0];
			if(s�L���ꗗ[0].Length == 4) //����I��
			{
				tex���b�Z�[�W.Text = "";
				i�ő�Ő� = (s�L���ꗗ.Length - 2) / axGT�L��.Rows + 1;
				if (i���ݕŐ� > i�ő�Ő�)
					i���ݕŐ� = i�ő�Ő�;
				�ŏ��ݒ�();
			}
			else
			{
				axGT�L��.Clear();
				i���ݕŐ� = 1;
				btn�O��.Enabled = false;
				btn����.Enabled = false;
				lab�Ŕԍ�.Text = "";
				�r�[�v��();
			}
		}

// ADD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX START
		private void �A�����i�e����()
		{
			string[] sList = new string[1];
			cmb�A�����i�e.Items.Clear();

			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� START
//				sList = sv_maintenance.Get_Kiji(gsa���[�U,"yusoshohin","0000");
				sList = sv_maintenance.Get_Kiji(gsa���[�U,s�L�����,"0000");
// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� END
			}
			catch (System.Net.WebException)
			{
				sList[0] = gs�ʐM�G���[;
			}
			catch (Exception ex)
			{
				sList[0] = "�ʐM�G���[�F" + ex.Message;
			}
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			tex���b�Z�[�W.Text = sList[0];
			if(sList[0].Length == 4) //����I��
			{
				if (sList.Length > 1)
				{
					s�A�����i�e�ꗗ = new string[sList.Length - 1];
					for (int iCnt = 1; iCnt < sList.Length; iCnt++)
					{
						string[] s�A�����i�e = sList[iCnt].Split('|');
						if (s�A�����i�e.Length > 2)
						{
							s�A�����i�e�ꗗ[iCnt-1] = s�A�����i�e[1];
							cmb�A�����i�e.Items.Insert(iCnt - 1,s�A�����i�e[2]);
						}
					}
				}
				else
				{
					s�A�����i�e�ꗗ = null;
				}
			}
			else
			{
				s�A�����i�e�ꗗ = null;
			}
			tex���b�Z�[�W.Text = "";
		}
// ADD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX END

		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void axGT�L��_CelClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelClickEvent e)
		{
			tex�L���R�[�h.Text = axGT�L��.get_CelText(axGT�L��.CaretRow,1).Trim();
			tex�L����.Text     = axGT�L��.get_CelText(axGT�L��.CaretRow,2).TrimEnd();
			s�X�V����        = axGT�L��.get_CelText(axGT�L��.CaretRow,3).Trim();
		}

		private void axGT�L��_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT�L��.set_CelForeColor(nOldRow,0,0);
			axGT�L��.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT�L��.set_CelForeColor(axGT�L��.CaretRow,0,111111);
			axGT�L��.set_CelForeColor(axGT�L��.CaretRow,0,0x98FB98);  //BGR
			axGT�L��.set_CelBackColor(axGT�L��.CaretRow,0,0x006000);
			nOldRow = axGT�L��.CaretRow;
			tex�L���R�[�h.Text = axGT�L��.get_CelText(axGT�L��.CaretRow,1).Trim();
			tex�L����.Text     = axGT�L��.get_CelText(axGT�L��.CaretRow,2).TrimEnd();
			s�X�V����          = axGT�L��.get_CelText(axGT�L��.CaretRow,3).Trim();
		}

		private void axGT�L��_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT�L��, true, true, true, true);
			}
		}

		private void btn�X�V_Click(object sender, System.EventArgs e)
		{
			tex�L���R�[�h.Text = tex�L���R�[�h.Text.Trim();
			tex�L����.Text     = tex�L����.Text.TrimEnd();

			if(!�K�{�`�F�b�N(tex�L���R�[�h,"�L���R�[�h")) return;
			if(!�K�{�`�F�b�N(tex�L����,"�L����")) return;

			if(!���p�`�F�b�N(tex�L���R�[�h,"�L���R�[�h")) return;
			if(!�S�p�`�F�b�N(tex�L����,"�L����")) return;

// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� START
//			if(cmb�L�����.SelectedIndex > 2)
			if(cmb�L�����.SelectedIndex >= cmb�L�����.Items.Count)
// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� END
			{
				MessageBox.Show("�L����ʂ�I�����Ă�������",
					"���̓`�F�b�N",MessageBoxButtons.OK);
				cmb�L�����.Focus();
				return;
			}

			try
			{
				tex���b�Z�[�W.Text = "";
				// �J�[�\���������v�ɂ���
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX START
//				String[] sList = sv_maintenance.Sel_Kiji(gsa���[�U,"default",s�L������,tex�L���R�[�h.Text);
				String[] sList = sv_maintenance.Sel_Kiji(gsa���[�U,s�L�����,s�L������,tex�L���R�[�h.Text);
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX END
				// �J�[�\�����f�t�H���g�ɖ߂�
				Cursor = System.Windows.Forms.Cursors.Default;

				// �G���[��
				if(sList[0].Length != 2)
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					return;
				}

				string s�X�V�e�f = sList[3];

				// �X�V���������ƂȂ�ꍇ
				if(s�X�V�e�f == "U" && s�X�V���� != sList[2])
				{
					�r�[�v��();
					DialogResult rst;
					rst = MessageBox.Show("����̃R�[�h�����ɑ��̒[�����o�^����Ă��܂��B\n" 
										+ "�L���ꗗ���ŐV�ɂ��܂����H",
										"�X�V",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Error);
					if(rst == DialogResult.Yes)
					{
						�L���ꗗ����();
					}
					return;
				}

				String[] sIUList;
				string[] sData = new string[7];
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX START
//				sData[0]  = "default";
				sData[0]  = s�L�����;
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX END
				sData[1]  = s�L������;
				sData[2]  = tex�L���R�[�h.Text;
				sData[3]  = tex�L����.Text;
				sData[4]  = "�L���o�^";
				sData[5]  = gs���p�҃R�[�h;
				sData[6]  = s�X�V����;

				DialogResult result;
				if(s�X�V�e�f == "I")
				{
					result = MessageBox.Show("�V�K�o�^���܂����H","�o�^",MessageBoxButtons.YesNo);
					if(result == DialogResult.Yes)
					{
						tex���b�Z�[�W.Text = "�o�^���D�D�D";
						// �J�[�\���������v�ɂ���
						Cursor = System.Windows.Forms.Cursors.AppStarting;
						sIUList = sv_maintenance.Ins_Kiji(gsa���[�U,sData);
						if(sIUList[0].Length == 4)
						{
							�L���ꗗ����();
						}
						else
						{
							tex���b�Z�[�W.Text = sIUList[0];
							�r�[�v��();
						}
						// �J�[�\�����f�t�H���g�ɖ߂�
						Cursor = System.Windows.Forms.Cursors.Default;
					}
				}
				else
				{
					result = MessageBox.Show("���ɑ��݂���f�[�^�ɏ㏑�����܂����H","�X�V",MessageBoxButtons.YesNo);
					if(result == DialogResult.Yes)
					{
						// �J�[�\���������v�ɂ���
						Cursor = System.Windows.Forms.Cursors.AppStarting;
						tex���b�Z�[�W.Text = "�X�V���D�D�D";
						sIUList = sv_maintenance.Upd_Kiji(gsa���[�U,sData);
						if(sIUList[0].Length == 4)
						{
							�L���ꗗ����();
						}
						else
						{
							tex���b�Z�[�W.Text = sIUList[0];
							�r�[�v��();
						}
						// �J�[�\�����f�t�H���g�ɖ߂�
						Cursor = System.Windows.Forms.Cursors.Default;
					}
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
		}

		private void btn�폜_Click(object sender, System.EventArgs e)
		{
			// �󔒏���
			tex�L���R�[�h.Text = tex�L���R�[�h.Text.Trim();

			if(!�K�{�`�F�b�N(tex�L���R�[�h,"�L���R�[�h")) return;
			if(!���p�`�F�b�N(tex�L���R�[�h,"�L���R�[�h")) return;
			
// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� START
//			if(cmb�L�����.SelectedIndex > 2)
			if(cmb�L�����.SelectedIndex >= cmb�L�����.Items.Count)
// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� END
			{
				MessageBox.Show("�L����ʂ�I�����Ă�������",
					"���̓`�F�b�N",MessageBoxButtons.OK);
				cmb�L�����.Focus();
				return;
			}

			try
			{
				tex���b�Z�[�W.Text = "";
				// �J�[�\���������v�ɂ���
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX START
//				String[] sList = sv_maintenance.Sel_Kiji(gsa���[�U,"default",s�L������,tex�L���R�[�h.Text);
				String[] sList = sv_maintenance.Sel_Kiji(gsa���[�U,s�L�����,s�L������,tex�L���R�[�h.Text);
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX END
				// �J�[�\�����f�t�H���g�ɖ߂�
				Cursor = System.Windows.Forms.Cursors.Default;

				string s�X�V�e�f = sList[3];

				String[] sDList;
				string[] sData = new string[5];

				DialogResult result;
				if(s�X�V�e�f == "I")
					MessageBox.Show("�R�[�h(" + tex�L���R�[�h.Text + ")�̃f�[�^�͑��݂��܂���","�폜",MessageBoxButtons.OK);
				else
				{
					result = MessageBox.Show("�R�[�h(" + tex�L���R�[�h.Text + ")�̃f�[�^���폜���܂����H","�폜",MessageBoxButtons.YesNo);
					if(result == DialogResult.Yes)
					{
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX START
//						sData[0] = "default";
						sData[0] = s�L�����;
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX END
						sData[1] = s�L������;
						sData[2] = tex�L���R�[�h.Text;
						sData[3] = "�L���o�^";
						sData[4] = gs���p�҃R�[�h;

						// �J�[�\���������v�ɂ���
						Cursor = System.Windows.Forms.Cursors.AppStarting;
						tex���b�Z�[�W.Text = "�폜���D�D�D";
						sDList = sv_maintenance.Del_Kiji(gsa���[�U,sData);

						if(sDList[0].Length == 4)
						{
							�L���ꗗ����();
						}
						else
						{
							tex���b�Z�[�W.Text = sDList[0];
							�r�[�v��();
						}
						// �J�[�\�����f�t�H���g�ɖ߂�
						Cursor = System.Windows.Forms.Cursors.Default;
					}
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
		}

		private void btn�O��_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�--;
			�ŏ��ݒ�();
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�++;
			�ŏ��ݒ�();
		}
		
		private void �ŏ��ݒ�()
		{
			axGT�L��.Clear();

			i�J�n�� = (i���ݕŐ� - 1) * axGT�L��.Rows + 1;
			i�I���� = i���ݕŐ� * axGT�L��.Rows;

			short s�\���� = (short)1;
			for(short sCnt = (short)i�J�n��; sCnt < s�L���ꗗ.Length && sCnt <= i�I���� ; sCnt++)
			{
				axGT�L��.set_RowsText(s�\����, s�L���ꗗ[sCnt]);
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
			tex�L���R�[�h.Text = axGT�L��.get_CelText(axGT�L��.CaretRow,1).Trim();
			tex�L����.Text     = axGT�L��.get_CelText(axGT�L��.CaretRow,2).TrimEnd();
			s�X�V����          = axGT�L��.get_CelText(axGT�L��.CaretRow,3).Trim();
		}

		private void cmb�L�����_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			//�A�����i�e
			if (cmb�L�����.SelectedIndex == 0)
			{
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX START
				s�L����� = "yusoshohin";
//				s�L������ = "yusoshiji";
				s�L������ = "0000";
				cmb�A�����i�e.Visible = false;
// MOD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX END
				i���ݕŐ� = 1;
				�L���ꗗ����();
			}
// ADD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX START
			//�A�����i�q
			else if (cmb�L�����.SelectedIndex == 1)
			{
				s�L����� = "yusoshohin";
				�A�����i�e����();
				if (s�A�����i�e�ꗗ != null)
				{
					cmb�A�����i�e.Visible = true;
					cmb�A�����i�e.SelectedIndex = 0;
					s�L������ = s�A�����i�e�ꗗ[0];
				}
				else
				{
					cmb�A�����i�e.Visible = false;
					s�L������ = "";
				}
				�L���ꗗ����();
			}
// ADD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX END
// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� START
			//���q�^�� �A�����i�e
			if (cmb�L�����.SelectedIndex == 2)
			{
				s�L����� = "Jyusoshohin";
				s�L������ = "0000";
				cmb�A�����i�e.Visible = false;
				i���ݕŐ� = 1;
				�L���ꗗ����();
			}
			//���q�^�� �A�����i�q
			else if (cmb�L�����.SelectedIndex == 3)
			{
				s�L����� = "Jyusoshohin";
				�A�����i�e����();
				if (s�A�����i�e�ꗗ != null)
				{
					cmb�A�����i�e.Visible = true;
					cmb�A�����i�e.SelectedIndex = 0;
					s�L������ = s�A�����i�e�ꗗ[0];
				}
				else
				{
					cmb�A�����i�e.Visible = false;
					s�L������ = "";
				}
				�L���ꗗ����();
			}
// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� END
			//�����ݒ�̕i���L��
// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� START
//			else if (cmb�L�����.SelectedIndex == 2)
			else if (cmb�L�����.SelectedIndex == 4)
// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� END
			{
// ADD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX START
				s�L����� = "default";
// ADD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX END
				s�L������ = "0000";
				cmb�A�����i�e.Visible = false;
				i���ݕŐ� = 1;
				�L���ꗗ����();
			}
			else
			{
				// ADD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX START
				s�L����� = "";
				// ADD 2005.05.27 ���s�j�ɉ� �A�����i�d�l�ύX END
				s�L������ = "";
			}
		}

		private void cmb�A�����i�e_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			if (cmb�A�����i�e.SelectedIndex < s�A�����i�e�ꗗ.Length)
			{
				s�L����� = "yusoshohin";
// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� START
				//���q�^�� �A�����i�e
				if(cmb�L�����.SelectedIndex == 2 
				|| cmb�L�����.SelectedIndex == 3){
					s�L����� = "Jyusoshohin";
				}
// MOD 2011.06.07 ���s�j���� ���q�^���l�A�����i�Ή� END
				s�L������ = s�A�����i�e�ꗗ[cmb�A�����i�e.SelectedIndex];
				�L���ꗗ����();
			}
		}

		private void �L���o�^_Closed(object sender, System.EventArgs e)
		{
			axGT�L��.CaretRow = 1;
			axGT�L��_CurPlaceChanged(null,null);
			cmb�L�����.Focus();
		}
	}
}
