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
	public class �W��X�}�X�^ : ���ʃt�H�[��
	{
		public short nOldRow = 0;
		private string[] s�W��X�ꗗ;
		private string   s�X�V���� = "00000000000000";
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
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lab�Ŕԍ�;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�O��;
		private ���ʃe�L�X�g�{�b�N�X tex�W�דX�R�[�h;
		private ���ʃe�L�X�g�{�b�N�X tex�W��X�R�[�h;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label lab�W�דX;
		private System.Windows.Forms.Label lab�W��X;
		private ���ʃe�L�X�g�{�b�N�X tex�����X��;
		private System.Windows.Forms.Label lab�����X��;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtp�g�p�J�n��;
		private AxGTABLE32V2Lib.AxGTable32 axGT�W��X;
		public System.Windows.Forms.Label lab�W��X�^�C�g��;
		private System.Windows.Forms.Button btn���;
		private System.Windows.Forms.Button btn�폜;
		private System.Windows.Forms.Button btn�o�^;
		private System.Windows.Forms.Button btn�W��X����;
		private System.Windows.Forms.Button btn�W�דX����;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private ���ʃe�L�X�g�{�b�N�X tex�W�דX��;
		private ���ʃe�L�X�g�{�b�N�X tex�W��X��;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public �W��X�}�X�^()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(�W��X�}�X�^));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tex�W��X�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.tex�W�דX�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.btn��� = new System.Windows.Forms.Button();
            this.btn�폜 = new System.Windows.Forms.Button();
            this.btn�o�^ = new System.Windows.Forms.Button();
            this.dtp�g�p�J�n�� = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn�W��X���� = new System.Windows.Forms.Button();
            this.btn�W�דX���� = new System.Windows.Forms.Button();
            this.lab�Ŕԍ� = new System.Windows.Forms.Label();
            this.btn���� = new System.Windows.Forms.Button();
            this.btn�O�� = new System.Windows.Forms.Button();
            this.lab�W�דX = new System.Windows.Forms.Label();
            this.tex�W�דX�R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab�W��X = new System.Windows.Forms.Label();
            this.tex�W��X�R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.axGT�W��X = new AxGTABLE32V2Lib.AxGTable32();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab�W��X�^�C�g�� = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.btn���� = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tex�����X�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab�����X�� = new System.Windows.Forms.Label();
            this.btn���� = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT�W��X)).BeginInit();
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
            this.panel1.Controls.Add(this.tex�W��X��);
            this.panel1.Controls.Add(this.tex�W�דX��);
            this.panel1.Controls.Add(this.btn���);
            this.panel1.Controls.Add(this.btn�폜);
            this.panel1.Controls.Add(this.btn�o�^);
            this.panel1.Controls.Add(this.dtp�g�p�J�n��);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn�W��X����);
            this.panel1.Controls.Add(this.btn�W�דX����);
            this.panel1.Controls.Add(this.lab�Ŕԍ�);
            this.panel1.Controls.Add(this.btn����);
            this.panel1.Controls.Add(this.btn�O��);
            this.panel1.Controls.Add(this.lab�W�דX);
            this.panel1.Controls.Add(this.tex�W�דX�R�[�h);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lab�W��X);
            this.panel1.Controls.Add(this.tex�W��X�R�[�h);
            this.panel1.Controls.Add(this.axGT�W��X);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 408);
            this.panel1.TabIndex = 1;
            // 
            // tex�W��X��
            // 
            this.tex�W��X��.BackColor = System.Drawing.Color.Honeydew;
            this.tex�W��X��.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex�W��X��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�W��X��.Location = new System.Drawing.Point(244, 314);
            this.tex�W��X��.Name = "tex�W��X��";
            this.tex�W��X��.ReadOnly = true;
            this.tex�W��X��.Size = new System.Drawing.Size(74, 16);
            this.tex�W��X��.TabIndex = 74;
            this.tex�W��X��.TabStop = false;
            // 
            // tex�W�דX��
            // 
            this.tex�W�דX��.BackColor = System.Drawing.Color.Honeydew;
            this.tex�W�דX��.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex�W�דX��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�W�דX��.Location = new System.Drawing.Point(244, 284);
            this.tex�W�דX��.Name = "tex�W�דX��";
            this.tex�W�דX��.ReadOnly = true;
            this.tex�W�דX��.Size = new System.Drawing.Size(74, 16);
            this.tex�W�דX��.TabIndex = 73;
            this.tex�W�דX��.TabStop = false;
            // 
            // btn���
            // 
            this.btn���.BackColor = System.Drawing.Color.Blue;
            this.btn���.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn���.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn���.ForeColor = System.Drawing.Color.White;
            this.btn���.Location = new System.Drawing.Point(318, 378);
            this.btn���.Name = "btn���";
            this.btn���.Size = new System.Drawing.Size(48, 22);
            this.btn���.TabIndex = 6;
            this.btn���.Text = "���";
            this.btn���.UseVisualStyleBackColor = false;
            this.btn���.Click += new System.EventHandler(this.btn���_Click);
            // 
            // btn�폜
            // 
            this.btn�폜.BackColor = System.Drawing.Color.Blue;
            this.btn�폜.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�폜.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�폜.ForeColor = System.Drawing.Color.White;
            this.btn�폜.Location = new System.Drawing.Point(264, 378);
            this.btn�폜.Name = "btn�폜";
            this.btn�폜.Size = new System.Drawing.Size(48, 22);
            this.btn�폜.TabIndex = 5;
            this.btn�폜.Text = "�폜";
            this.btn�폜.UseVisualStyleBackColor = false;
            this.btn�폜.Click += new System.EventHandler(this.btn�폜_Click);
            // 
            // btn�o�^
            // 
            this.btn�o�^.BackColor = System.Drawing.Color.Blue;
            this.btn�o�^.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�o�^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�o�^.ForeColor = System.Drawing.Color.White;
            this.btn�o�^.Location = new System.Drawing.Point(210, 378);
            this.btn�o�^.Name = "btn�o�^";
            this.btn�o�^.Size = new System.Drawing.Size(48, 22);
            this.btn�o�^.TabIndex = 4;
            this.btn�o�^.Text = "�o�^";
            this.btn�o�^.UseVisualStyleBackColor = false;
            this.btn�o�^.Click += new System.EventHandler(this.btn�o�^_Click);
            // 
            // dtp�g�p�J�n��
            // 
            this.dtp�g�p�J�n��.Location = new System.Drawing.Point(144, 342);
            this.dtp�g�p�J�n��.Name = "dtp�g�p�J�n��";
            this.dtp�g�p�J�n��.Size = new System.Drawing.Size(108, 19);
            this.dtp�g�p�J�n��.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(62, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 14);
            this.label3.TabIndex = 68;
            this.label3.Text = "��";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(76, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 67;
            this.label4.Text = "�g�p�J�n��";
            // 
            // btn�W��X����
            // 
            this.btn�W��X����.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�W��X����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�W��X����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�W��X����.ForeColor = System.Drawing.Color.White;
            this.btn�W��X����.Location = new System.Drawing.Point(190, 310);
            this.btn�W��X����.Name = "btn�W��X����";
            this.btn�W��X����.Size = new System.Drawing.Size(48, 22);
            this.btn�W��X����.TabIndex = 66;
            this.btn�W��X����.TabStop = false;
            this.btn�W��X����.Text = "����";
            this.btn�W��X����.UseVisualStyleBackColor = false;
            this.btn�W��X����.Click += new System.EventHandler(this.btn�W��X����_Click);
            // 
            // btn�W�דX����
            // 
            this.btn�W�דX����.BackColor = System.Drawing.Color.SteelBlue;
            this.btn�W�דX����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�W�דX����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�W�דX����.ForeColor = System.Drawing.Color.White;
            this.btn�W�דX����.Location = new System.Drawing.Point(190, 280);
            this.btn�W�דX����.Name = "btn�W�דX����";
            this.btn�W�דX����.Size = new System.Drawing.Size(48, 22);
            this.btn�W�דX����.TabIndex = 65;
            this.btn�W�דX����.TabStop = false;
            this.btn�W�דX����.Text = "����";
            this.btn�W�דX����.UseVisualStyleBackColor = false;
            this.btn�W�דX����.Click += new System.EventHandler(this.btn�W�דX����_Click);
            // 
            // lab�Ŕԍ�
            // 
            this.lab�Ŕԍ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�Ŕԍ�.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�Ŕԍ�.Location = new System.Drawing.Point(260, 256);
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
            this.btn����.Location = new System.Drawing.Point(308, 252);
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
            this.btn�O��.Location = new System.Drawing.Point(212, 252);
            this.btn�O��.Name = "btn�O��";
            this.btn�O��.Size = new System.Drawing.Size(48, 22);
            this.btn�O��.TabIndex = 62;
            this.btn�O��.Text = "�O��";
            this.btn�O��.UseVisualStyleBackColor = false;
            this.btn�O��.Click += new System.EventHandler(this.btn�O��_Click);
            // 
            // lab�W�דX
            // 
            this.lab�W�דX.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�W�דX.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�W�דX.Location = new System.Drawing.Point(76, 286);
            this.lab�W�דX.Name = "lab�W�דX";
            this.lab�W�דX.Size = new System.Drawing.Size(66, 14);
            this.lab�W�דX.TabIndex = 61;
            this.lab�W�דX.Text = "�W�דX";
            // 
            // tex�W�דX�R�[�h
            // 
            this.tex�W�דX�R�[�h.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tex�W�דX�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�W�דX�R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�W�דX�R�[�h.Location = new System.Drawing.Point(144, 280);
            this.tex�W�דX�R�[�h.MaxLength = 4;
            this.tex�W�דX�R�[�h.Name = "tex�W�דX�R�[�h";
            this.tex�W�דX�R�[�h.Size = new System.Drawing.Size(42, 23);
            this.tex�W�דX�R�[�h.TabIndex = 1;
            this.tex�W�דX�R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�W�דX�R�[�h_KeyDown);
            this.tex�W�דX�R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�W�דX�R�[�h_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(62, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 14);
            this.label2.TabIndex = 59;
            this.label2.Text = "��";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 14);
            this.label1.TabIndex = 57;
            this.label1.Text = "��";
            // 
            // lab�W��X
            // 
            this.lab�W��X.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�W��X.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�W��X.Location = new System.Drawing.Point(76, 316);
            this.lab�W��X.Name = "lab�W��X";
            this.lab�W��X.Size = new System.Drawing.Size(66, 14);
            this.lab�W��X.TabIndex = 56;
            this.lab�W��X.Text = "�W��X";
            // 
            // tex�W��X�R�[�h
            // 
            this.tex�W��X�R�[�h.BackColor = System.Drawing.SystemColors.Window;
            this.tex�W��X�R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�W��X�R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex�W��X�R�[�h.Location = new System.Drawing.Point(144, 310);
            this.tex�W��X�R�[�h.MaxLength = 4;
            this.tex�W��X�R�[�h.Name = "tex�W��X�R�[�h";
            this.tex�W��X�R�[�h.Size = new System.Drawing.Size(42, 23);
            this.tex�W��X�R�[�h.TabIndex = 2;
            this.tex�W��X�R�[�h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�W��X�R�[�h_KeyDown);
            this.tex�W��X�R�[�h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex�W��X�R�[�h_KeyPress);
            // 
            // axGT�W��X
            // 
            this.axGT�W��X.DataSource = null;
            this.axGT�W��X.Location = new System.Drawing.Point(16, 10);
            this.axGT�W��X.Name = "axGT�W��X";
            this.axGT�W��X.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT�W��X.OcxState")));
            this.axGT�W��X.Size = new System.Drawing.Size(339, 235);
            this.axGT�W��X.TabIndex = 0;
            this.axGT�W��X.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT�W��X_CurPlaceChanged);
            this.axGT�W��X.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT�W��X_CelDblClick);
            this.axGT�W��X.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT�W��X_KeyDownEvent);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab�W��X�^�C�g��);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(396, 26);
            this.panel7.TabIndex = 13;
            // 
            // lab�W��X�^�C�g��
            // 
            this.lab�W��X�^�C�g��.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab�W��X�^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�W��X�^�C�g��.ForeColor = System.Drawing.Color.White;
            this.lab�W��X�^�C�g��.Location = new System.Drawing.Point(12, 2);
            this.lab�W��X�^�C�g��.Name = "lab�W��X�^�C�g��";
            this.lab�W��X�^�C�g��.Size = new System.Drawing.Size(264, 24);
            this.lab�W��X�^�C�g��.TabIndex = 0;
            this.lab�W��X�^�C�g��.Text = "�W��X��񃁃��e�i���X";
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
            this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
            this.tex���b�Z�[�W.Location = new System.Drawing.Point(70, 4);
            this.tex���b�Z�[�W.Multiline = true;
            this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
            this.tex���b�Z�[�W.ReadOnly = true;
            this.tex���b�Z�[�W.Size = new System.Drawing.Size(312, 50);
            this.tex���b�Z�[�W.TabIndex = 0;
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
            this.panel6.Size = new System.Drawing.Size(396, 26);
            this.panel6.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.tex�����X��);
            this.panel5.Controls.Add(this.lab�����X��);
            this.panel5.Controls.Add(this.btn����);
            this.panel5.Location = new System.Drawing.Point(1, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 36);
            this.panel5.TabIndex = 0;
            // 
            // tex�����X��
            // 
            this.tex�����X��.BackColor = System.Drawing.SystemColors.Window;
            this.tex�����X��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�����X��.Location = new System.Drawing.Point(88, 6);
            this.tex�����X��.MaxLength = 4;
            this.tex�����X��.Name = "tex�����X��";
            this.tex�����X��.Size = new System.Drawing.Size(42, 23);
            this.tex�����X��.TabIndex = 0;
            this.tex�����X��.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex�����X��_KeyDown);
            // 
            // lab�����X��
            // 
            this.lab�����X��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�����X��.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�����X��.Location = new System.Drawing.Point(8, 10);
            this.lab�����X��.Name = "lab�����X��";
            this.lab�����X��.Size = new System.Drawing.Size(76, 16);
            this.lab�����X��.TabIndex = 46;
            this.lab�����X��.Text = "�W�דX";
            // 
            // btn����
            // 
            this.btn����.BackColor = System.Drawing.Color.SteelBlue;
            this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn����.ForeColor = System.Drawing.Color.White;
            this.btn����.Location = new System.Drawing.Point(292, 8);
            this.btn����.Name = "btn����";
            this.btn����.Size = new System.Drawing.Size(64, 22);
            this.btn����.TabIndex = 1;
            this.btn����.TabStop = false;
            this.btn����.Text = "����";
            this.btn����.UseVisualStyleBackColor = false;
            this.btn����.Click += new System.EventHandler(this.btn����_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(7, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(7, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 416);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // �W��X�}�X�^
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
            this.Name = "�W��X�}�X�^";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 �W��X��񃁃��e�i���X";
            this.Closed += new System.EventHandler(this.�W��X�}�X�^_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On�G���^�[�ړ�);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On�G���^�[�L�����Z��);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT�W��X)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
			axGT�W��X.Cols = 6;
			axGT�W��X.Rows = 12;
			axGT�W��X.ColSep = "|";
			axGT�W��X.NoBeep = true;

			axGT�W��X.set_RowsText(0, "|�R�[�h|�W�דX||�R�[�h|�W��X|�g�p�J�n��");

			axGT�W��X.ColsWidth = "0|4|5|2|4|5|6";
			axGT�W��X.ColsAlignHorz = "1|1|0|1|1|0|1|";

//			axGT�W��X.set_CelForeColor(axGT�W��X.CaretRow,0,111111);
			axGT�W��X.set_CelForeColor(axGT�W��X.CaretRow,0,0x98FB98);  //BGR
			axGT�W��X.set_CelBackColor(axGT�W��X.CaretRow,0,0x006000);

			axGT�W��X.CaretRow = 1;
			tex�����X��.Text = " ";
			�W��X�ꗗ����();
			�W��X�o�^���[�h();
			tex�����X��.Focus();
		}

		private void �W��X�o�^���[�h()
		{
			tex�W�דX�R�[�h.Enabled = true;
			btn�W�דX����.Enabled = true;
			btn�o�^.Text = "�o�^";
			btn�폜.Enabled = false;

			tex�W�דX�R�[�h.Text = "";
			tex�W�דX��.Text = "";
			tex�W��X�R�[�h.Text = "";
			tex�W��X��.Text = "";
			dtp�g�p�J�n��.Value = System.DateTime.Now;

			s�X�V���� = "00000000000000";
		}

		private void �W��X�X�V���[�h()
		{
			tex�W�דX�R�[�h.Enabled = false;
			btn�W�דX����.Enabled = false;
			btn�o�^.Text = "�X�V";
			btn�폜.Enabled = true;
		}

		private void �W��X�ꗗ����()
		{
			axGT�W��X.Clear();

			tex�����X��.Text   = tex�����X��.Text.Trim();
			if (tex�����X��.Text.Length == 0)
			{
				tex�����X��.Text = " ";
			}
			if(!���p�`�F�b�N(tex�����X��,"�W�דX")) return;

			i���ݕŐ� = 1;
			axGT�W��X.CaretRow = 1;
			axGT�W��X.set_CelForeColor(nOldRow,0,0);
			axGT�W��X.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT�W��X.set_CelForeColor(axGT�W��X.CaretRow,0,111111);
			axGT�W��X.set_CelForeColor(axGT�W��X.CaretRow,0,0x98FB98);  //BGR
			axGT�W��X.set_CelBackColor(axGT�W��X.CaretRow,0,0x006000);
			nOldRow = axGT�W��X.CaretRow;
			
			s�W��X�ꗗ = new string[1];
			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�����X��.Text;
				s�W��X�ꗗ = sv_maintenance.Get_ConnectShop(gsa���[�U, sKey);
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(s�W��X�ꗗ[0].Equals("����I��"))
			{
				tex���b�Z�[�W.Text = "";
// MOD 2005.05.12 ���s�j�����J ��s�ڋ� START
//				i�ő�Ő� = (s�W��X�ꗗ.Length - 2) / axGT�W��X.Rows + 1;
				i�ő�Ő� = (s�W��X�ꗗ.Length - 2) / (axGT�W��X.Rows - 1) + 1;
// MOD 2005.05.12 ���s�j�����J ��s�ڋ� END
				if (i���ݕŐ� > i�ő�Ő�)
					i���ݕŐ� = i�ő�Ő�;
				�ŏ��ݒ�();
			}
			else
			{
				tex���b�Z�[�W.Text = s�W��X�ꗗ[0];
				axGT�W��X.Clear();
				i���ݕŐ� = 1;
				btn�O��.Enabled = false;
				btn����.Enabled = false;
				lab�Ŕԍ�.Text = "";
				�r�[�v��();
			}
			tex�����X��.Text = tex�����X��.Text.Trim();
		}

		private void �W��X����()
		{
			if (axGT�W��X.get_CelText(axGT�W��X.CaretRow,1).Equals("")) return;

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			
			try
			{
				string[] sKey  = new string[1];
				sKey[0] = axGT�W��X.get_CelText(axGT�W��X.CaretRow,1).Trim();
				string[] sList = sv_maintenance.Sel_ConnectShop(gsa���[�U, sKey);

				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex�W�דX�R�[�h.Text = sList[1].Trim();
					tex�W�דX��.Text     = sList[2].Trim();
					tex�W��X�R�[�h.Text = sList[3].Trim();
					tex�W��X��.Text     = sList[4].Trim();					
					try
					{
//						System.DateTime dt���t = System.DateTime.Parse(sList[5].Substring(0, 4) + "/" + sList[5].Substring(4, 2) + "/" + sList[5].Substring(6, 2));
						System.DateTime dt���t = new DateTime(int.Parse(sList[5].Substring(0, 4)),int.Parse(sList[5].Substring(4, 2)),int.Parse(sList[5].Substring(6, 2)));
						dtp�g�p�J�n��.Value = dt���t;
					}
					catch
					{
						dtp�g�p�J�n��.Value = System.DateTime.Now;
					}
		 		    s�X�V����            = sList[6].Trim();
					�W��X�X�V���[�h();
					tex�W��X�R�[�h.Focus();
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					axGT�W��X.Focus();
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�W��X�o�^���[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
		
		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void tex�����X��_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				�W��X�ꗗ����();
				tex�W�דX�R�[�h.Focus();
			}
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			�W��X�ꗗ����();
			tex�W�דX�R�[�h.Focus();
		}

		private void axGT�W��X_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			�W��X����();
		}

		private void axGT�W��X_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT�W��X.set_CelForeColor(nOldRow,0,0);
			axGT�W��X.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT�W��X.set_CelForeColor(axGT�W��X.CaretRow,0,111111);
			axGT�W��X.set_CelForeColor(axGT�W��X.CaretRow,0,0x98FB98);  //BGR
			axGT�W��X.set_CelBackColor(axGT�W��X.CaretRow,0,0x006000);
			nOldRow = axGT�W��X.CaretRow;
		}

		private void axGT�W��X_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 13)
			{
				�W��X����();
			}
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT�W��X, true, true, true, true);
			}
		}

		private void btn�o�^_Click(object sender, System.EventArgs e)
		{
			//�W�דX�`�F�b�N
			if (!�W�דX������())
			{
				MessageBox.Show("�W�דX(" + tex�W�דX�R�[�h.Text + ")�����݂��܂���" ,"���̓`�F�b�N",MessageBoxButtons.OK);
				tex�W�דX�R�[�h.Focus();
				return;
			}
			//�W��X�`�F�b�N
			if (!�W��X������())
			{
				MessageBox.Show("�W��X(" + tex�W��X�R�[�h.Text + ")�����݂��܂���" ,"���̓`�F�b�N",MessageBoxButtons.OK);
				tex�W��X�R�[�h.Focus();
				return;
			}

			tex���b�Z�[�W.Text = btn�o�^.Text + "���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[8];
				sKey[0] = tex�W�דX�R�[�h.Text;
				sKey[1] = tex�W��X�R�[�h.Text;
				sKey[2] = dtp�g�p�J�n��.Value.Year.ToString() + dtp�g�p�J�n��.Value.Month.ToString().PadLeft(2, '0') + dtp�g�p�J�n��.Value.Day.ToString().PadLeft(2, '0');
				sKey[3] = s�X�V����;
				sKey[4] = gs���p�҃R�[�h;

				if (btn�o�^.Text.Equals("�o�^"))
				{
					string[] sList = sv_maintenance.Ins_ConnectShop(gsa���[�U, sKey);
					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
						//�W��X�̒ǉ�
						�W��X�o�^���[�h();
						�W��X�ꗗ����();
					}
					else
					{
						�r�[�v��();
					}
				}
				else
				{
					string[] sList = sv_maintenance.Upd_ConnectShop(gsa���[�U, sKey);
					tex���b�Z�[�W.Text = sList[0];
					if (sList[0].Equals("����I��"))
					{
						//�W��X�̍X�V
						�W��X�o�^���[�h();
						�W��X�ꗗ����();
					}
					else
					{
						�r�[�v��();
					}
				}
				tex�W�דX�R�[�h.Focus();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�W��X�o�^���[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;		
		}

		private void btn�폜_Click(object sender, System.EventArgs e)
		{
			tex�W�דX�R�[�h.Text = tex�W�דX�R�[�h.Text.Trim();
			
			tex���b�Z�[�W.Text = "�폜���D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[3];
				sKey[0] = tex�W�דX�R�[�h.Text;
				sKey[1] = s�X�V����;
				sKey[2] = gs���p�҃R�[�h;

				string[] sList = sv_maintenance.Del_ConnectShop(gsa���[�U, sKey);
				tex���b�Z�[�W.Text = sList[0];
				if (sList[0].Equals("����I��"))
				{
					//���p�҂̍폜
					�W��X�o�^���[�h();
					�W��X�ꗗ����();
				}
				else
				{
					�r�[�v��();
				}
				tex�W��X�R�[�h.Focus();
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�W��X�o�^���[�h();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn���_Click(object sender, System.EventArgs e)
		{
			�W��X�o�^���[�h();
		}

		private void btn�W�דX����_Click(object sender, System.EventArgs e)
		{
			�W�דX���ꗗ();
		}

		private void tex�W�דX�R�[�h_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				if(tex�W�דX�R�[�h.Text.Length < 3)
					�W�דX���ꗗ();
				else
					�W�דX������();
			}
		}

		private void tex�W�דX�R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�W�דX����.Focus();
				�W�דX���ꗗ();
				e.Handled = true;
			}		
		}

		private void �W�דX���ꗗ()
		{
			tex�W�דX�R�[�h.Text = tex�W�דX�R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�W�דX�R�[�h, "�W�דX�R�[�h")) return;

			// ������ʂ��E���ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			�X������ ��� = new �X������();
//			���.Left = this.Left - 202;
//			���.Top = this.Top;

			// �R�[�h�̏����\��
//			���.s�X���R�[�h = tex�W�דX�R�[�h.Text;
//			���.s�X���� = "";
//			���.ShowDialog();
			if (g�X������ == null)	 g�X������ = new �X������();
			g�X������.Left = this.Left - 202;
			g�X������.Top = this.Top;
			// �R�[�h�̏����\��
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� START
//			g�X������.s�X���R�[�h = tex�W�דX�R�[�h.Text;
			g�X������.s�X���R�[�h = "";
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� END
			g�X������.s�X���� = "";
			g�X������.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (���.s�X���R�[�h.Trim().Length != 0)
			if (g�X������.s�X���R�[�h.Trim().Length != 0)
			{
//				tex�W�דX�R�[�h.Text = ���.s�X���R�[�h.Trim();
//				tex�W�דX��.Text = ���.s�X����.Trim();
				tex�W�דX�R�[�h.Text = g�X������.s�X���R�[�h.Trim();
				tex�W�דX��.Text = g�X������.s�X����.Trim();
				tex�W��X�R�[�h.Focus();
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
			}
			else
			{
				tex�W�דX�R�[�h.Focus();
			}
		}

		private bool �W�דX������()
		{
			tex�W�דX�R�[�h.Text = tex�W�דX�R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�W�דX�R�[�h, "�W�דX�R�[�h")) return false;

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�W�דX�R�[�h.Text;
				string[] sList = sv_maintenance.Sel_Shop(gsa���[�U, sKey);
				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex�W�דX��.Text = sList[1];
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					ret =  false;
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�W��X�o�^���[�h();
				ret = false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}

		private void btn�W��X����_Click(object sender, System.EventArgs e)
		{
			�W��X���ꗗ();
		}

		private void tex�W��X�R�[�h_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex���b�Z�[�W.Text = "";
				if(tex�W��X�R�[�h.Text.Length < 3)
					�W��X���ꗗ();
				else
					�W��X������();
			}
		}

		private void tex�W��X�R�[�h_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn�W��X����.Focus();
				�W��X���ꗗ();
				e.Handled = true;
			}		
		}

		private void �W��X���ꗗ()
		{
			tex�W��X�R�[�h.Text = tex�W��X�R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�W��X�R�[�h, "�W��X�R�[�h")) return;

			// ������ʂ��E���ɕ\������
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 ���s�j�����J ��ʍ����� START
//			�X������ ��� = new �X������();
//			���.Left = this.Left - 202;
//			���.Top = this.Top;

			// �R�[�h�̏����\��
//			���.s�X���R�[�h = tex�W��X�R�[�h.Text;
//			���.s�X���� = "";
//			���.ShowDialog();
			if (g�X������ == null)	 g�X������ = new �X������();
			g�X������.Left = this.Left - 202;
			g�X������.Top = this.Top;
			// �R�[�h�̏����\��
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� START
//			g�X������.s�X���R�[�h = tex�W��X�R�[�h.Text;
			g�X������.s�X���R�[�h = "";
// MOD 2005.06.02 ���s�j�����J �l�̈��p���Ȃ� END
			g�X������.s�X���� = "";
			g�X������.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (���.s�X���R�[�h.Trim().Length != 0)
			if (g�X������.s�X���R�[�h.Trim().Length != 0)
			{
//				tex�W��X�R�[�h.Text = ���.s�X���R�[�h.Trim();
//				tex�W��X��.Text = ���.s�X����.Trim();
				tex�W��X�R�[�h.Text = g�X������.s�X���R�[�h.Trim();
				tex�W��X��.Text = g�X������.s�X����.Trim();
				dtp�g�p�J�n��.Focus();
// MOD 2005.05.25 ���s�j�����J ��ʍ����� END
			}
			else
			{
				tex�W��X�R�[�h.Focus();
			}
		}

		private bool �W��X������()
		{
			tex�W��X�R�[�h.Text = tex�W��X�R�[�h.Text.Trim();
			if(!���p�`�F�b�N(tex�W��X�R�[�h, "�W��X�R�[�h")) return false;

			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�W��X�R�[�h.Text;
				string[] sList = sv_maintenance.Sel_Shop(gsa���[�U, sKey);
				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex�W��X��.Text = sList[1];
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
					ret =  false;
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
				�W��X�o�^���[�h();
				ret = false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}

		private void btn�O��_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�--;
			�ŏ��ݒ�();
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� START
			axGT�W��X.CaretRow = 1;
			axGT�W��X_CurPlaceChanged(null,null);
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� END
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			i���ݕŐ�++;
			�ŏ��ݒ�();
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� START
			axGT�W��X.CaretRow = 1;
			axGT�W��X_CurPlaceChanged(null,null);
// ADD 2005.05.12 ���s�j�����J ��s�ڑI�� END
		}
		
		private void �ŏ��ݒ�()
		{
			axGT�W��X.Clear();

// MOD 2005.05.12 ���s�j�����J ��s�ڋ� START
//			i�J�n�� = (i���ݕŐ� - 1) * axGT�W��X.Rows + 1;
			i�J�n�� = (i���ݕŐ� - 1) * (axGT�W��X.Rows - 1) + 1;
//			i�I���� = i���ݕŐ� * axGT�W��X.Rows;
			i�I���� = i���ݕŐ� * (axGT�W��X.Rows - 1);

//			short s�\���� = (short)1;
			short s�\���� = (short)2;
// MOD 2005.05.12 ���s�j�����J ��s�ڋ� START
			for(short sCnt = (short)i�J�n��; sCnt < s�W��X�ꗗ.Length && sCnt <= i�I���� ; sCnt++)
			{
				axGT�W��X.set_RowsText(s�\����, s�W��X�ꗗ[sCnt]);
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
		}

		private void �W��X�}�X�^_Closed(object sender, System.EventArgs e)
		{
			axGT�W��X.CaretRow = 1;
			axGT�W��X_CurPlaceChanged(null,null);
			tex�����X��.Focus();
		}

	}
}
