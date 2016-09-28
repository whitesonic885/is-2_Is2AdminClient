using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [���q�l���o��]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// DEL 2005.05.27 ���s�j���� �Z�b�V��������̔p�~ 
	// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX 
	//--------------------------------------------------------------------------
	// MOD 2006.12.11 ���s�j�����J �T�[�}���䐔�ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� 
	//--------------------------------------------------------------------------
	// MOD 2009.11.25 ���s�j���� ���q�l���o�́i�b�r�u�j�̍��ڒǉ� 
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� 
	//--------------------------------------------------------------------------
	public class ������b�r�u�o�� : ���ʃt�H�[��
	{
		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label lab�W��X�^�C�g��;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dtp�r�g�p�J�n��;
		private System.Windows.Forms.DateTimePicker dtp�d�g�p�J�n��;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lab�g�p�I����;
		private System.Windows.Forms.Label lab����R�[�h;
		private System.Windows.Forms.Label lab���p�ғo�^��;
		private System.Windows.Forms.Label lab�g�p�J�n��;
		private System.Windows.Forms.DateTimePicker dtp�r�g�p�I����;
		private System.Windows.Forms.DateTimePicker dtp�d�g�p�I����;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtp�J�n�o�^��;
		private System.Windows.Forms.DateTimePicker dtp�I���o�^��;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn�b�r�u�o��;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�J�n����R�[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�I������R�[�h;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.CheckBox cBox�r�g�p�J�n��;
		private System.Windows.Forms.CheckBox cBox�d�g�p�J�n��;
		private System.Windows.Forms.CheckBox cBox�r�g�p�I����;
		private System.Windows.Forms.CheckBox cBox�d�g�p�I����;
		private System.Windows.Forms.CheckBox cBox�J�n�o�^��;
		private System.Windows.Forms.CheckBox cBox�I���o�^��;
		private System.Windows.Forms.Label lab�r�g�p�J�n��;
		private System.Windows.Forms.Label lab�d�g�p�J�n��;
		private System.Windows.Forms.Label lab�r�g�p�I����;
		private System.Windows.Forms.Label lab�d�g�p�I����;
		private System.Windows.Forms.Label lab�J�n�o�^��;
		private System.Windows.Forms.Label lab�I���o�^��;

		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ������b�r�u�o��()
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab�I���o�^�� = new System.Windows.Forms.Label();
			this.lab�J�n�o�^�� = new System.Windows.Forms.Label();
			this.lab�d�g�p�I���� = new System.Windows.Forms.Label();
			this.lab�r�g�p�I���� = new System.Windows.Forms.Label();
			this.lab�d�g�p�J�n�� = new System.Windows.Forms.Label();
			this.lab�r�g�p�J�n�� = new System.Windows.Forms.Label();
			this.cBox�I���o�^�� = new System.Windows.Forms.CheckBox();
			this.cBox�J�n�o�^�� = new System.Windows.Forms.CheckBox();
			this.cBox�d�g�p�I���� = new System.Windows.Forms.CheckBox();
			this.cBox�r�g�p�I���� = new System.Windows.Forms.CheckBox();
			this.cBox�d�g�p�J�n�� = new System.Windows.Forms.CheckBox();
			this.cBox�r�g�p�J�n�� = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtp�I���o�^�� = new System.Windows.Forms.DateTimePicker();
			this.dtp�J�n�o�^�� = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.dtp�d�g�p�I���� = new System.Windows.Forms.DateTimePicker();
			this.dtp�r�g�p�I���� = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dtp�d�g�p�J�n�� = new System.Windows.Forms.DateTimePicker();
			this.dtp�r�g�p�J�n�� = new System.Windows.Forms.DateTimePicker();
			this.lab�g�p�I���� = new System.Windows.Forms.Label();
			this.lab����R�[�h = new System.Windows.Forms.Label();
			this.tex�J�n����R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label2 = new System.Windows.Forms.Label();
			this.lab���p�ғo�^�� = new System.Windows.Forms.Label();
			this.lab�g�p�J�n�� = new System.Windows.Forms.Label();
			this.tex�I������R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab�W��X�^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn�b�r�u�o�� = new System.Windows.Forms.Button();
			this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.btn���� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.lab�I���o�^��);
			this.panel1.Controls.Add(this.lab�J�n�o�^��);
			this.panel1.Controls.Add(this.lab�d�g�p�I����);
			this.panel1.Controls.Add(this.lab�r�g�p�I����);
			this.panel1.Controls.Add(this.lab�d�g�p�J�n��);
			this.panel1.Controls.Add(this.lab�r�g�p�J�n��);
			this.panel1.Controls.Add(this.cBox�I���o�^��);
			this.panel1.Controls.Add(this.cBox�J�n�o�^��);
			this.panel1.Controls.Add(this.cBox�d�g�p�I����);
			this.panel1.Controls.Add(this.cBox�r�g�p�I����);
			this.panel1.Controls.Add(this.cBox�d�g�p�J�n��);
			this.panel1.Controls.Add(this.cBox�r�g�p�J�n��);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.dtp�I���o�^��);
			this.panel1.Controls.Add(this.dtp�J�n�o�^��);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.dtp�d�g�p�I����);
			this.panel1.Controls.Add(this.dtp�r�g�p�I����);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.dtp�d�g�p�J�n��);
			this.panel1.Controls.Add(this.dtp�r�g�p�J�n��);
			this.panel1.Controls.Add(this.lab�g�p�I����);
			this.panel1.Controls.Add(this.lab����R�[�h);
			this.panel1.Controls.Add(this.tex�J�n����R�[�h);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lab���p�ғo�^��);
			this.panel1.Controls.Add(this.lab�g�p�J�n��);
			this.panel1.Controls.Add(this.tex�I������R�[�h);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(374, 292);
			this.panel1.TabIndex = 1;
			// 
			// lab�I���o�^��
			// 
			this.lab�I���o�^��.BackColor = System.Drawing.Color.White;
			this.lab�I���o�^��.Location = new System.Drawing.Point(226, 260);
			this.lab�I���o�^��.Name = "lab�I���o�^��";
			this.lab�I���o�^��.Size = new System.Drawing.Size(112, 16);
			this.lab�I���o�^��.TabIndex = 94;
			// 
			// lab�J�n�o�^��
			// 
			this.lab�J�n�o�^��.BackColor = System.Drawing.Color.White;
			this.lab�J�n�o�^��.Location = new System.Drawing.Point(30, 260);
			this.lab�J�n�o�^��.Name = "lab�J�n�o�^��";
			this.lab�J�n�o�^��.Size = new System.Drawing.Size(112, 16);
			this.lab�J�n�o�^��.TabIndex = 93;
			// 
			// lab�d�g�p�I����
			// 
			this.lab�d�g�p�I����.BackColor = System.Drawing.Color.White;
			this.lab�d�g�p�I����.Location = new System.Drawing.Point(226, 190);
			this.lab�d�g�p�I����.Name = "lab�d�g�p�I����";
			this.lab�d�g�p�I����.Size = new System.Drawing.Size(112, 16);
			this.lab�d�g�p�I����.TabIndex = 92;
			// 
			// lab�r�g�p�I����
			// 
			this.lab�r�g�p�I����.BackColor = System.Drawing.Color.White;
			this.lab�r�g�p�I����.Location = new System.Drawing.Point(30, 190);
			this.lab�r�g�p�I����.Name = "lab�r�g�p�I����";
			this.lab�r�g�p�I����.Size = new System.Drawing.Size(114, 16);
			this.lab�r�g�p�I����.TabIndex = 91;
			// 
			// lab�d�g�p�J�n��
			// 
			this.lab�d�g�p�J�n��.BackColor = System.Drawing.Color.White;
			this.lab�d�g�p�J�n��.Location = new System.Drawing.Point(226, 118);
			this.lab�d�g�p�J�n��.Name = "lab�d�g�p�J�n��";
			this.lab�d�g�p�J�n��.Size = new System.Drawing.Size(114, 18);
			this.lab�d�g�p�J�n��.TabIndex = 90;
			// 
			// lab�r�g�p�J�n��
			// 
			this.lab�r�g�p�J�n��.BackColor = System.Drawing.Color.White;
			this.lab�r�g�p�J�n��.Location = new System.Drawing.Point(32, 118);
			this.lab�r�g�p�J�n��.Name = "lab�r�g�p�J�n��";
			this.lab�r�g�p�J�n��.Size = new System.Drawing.Size(110, 16);
			this.lab�r�g�p�J�n��.TabIndex = 89;
			// 
			// cBox�I���o�^��
			// 
			this.cBox�I���o�^��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBox�I���o�^��.Location = new System.Drawing.Point(206, 256);
			this.cBox�I���o�^��.Name = "cBox�I���o�^��";
			this.cBox�I���o�^��.Size = new System.Drawing.Size(16, 24);
			this.cBox�I���o�^��.TabIndex = 88;
			this.cBox�I���o�^��.TabStop = false;
			this.cBox�I���o�^��.Click += new System.EventHandler(this.cBox�I���o�^��_Click);
			// 
			// cBox�J�n�o�^��
			// 
			this.cBox�J�n�o�^��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBox�J�n�o�^��.Location = new System.Drawing.Point(12, 256);
			this.cBox�J�n�o�^��.Name = "cBox�J�n�o�^��";
			this.cBox�J�n�o�^��.Size = new System.Drawing.Size(16, 24);
			this.cBox�J�n�o�^��.TabIndex = 87;
			this.cBox�J�n�o�^��.TabStop = false;
			this.cBox�J�n�o�^��.Click += new System.EventHandler(this.cBox�J�n�o�^��_Click);
			// 
			// cBox�d�g�p�I����
			// 
			this.cBox�d�g�p�I����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBox�d�g�p�I����.Location = new System.Drawing.Point(206, 186);
			this.cBox�d�g�p�I����.Name = "cBox�d�g�p�I����";
			this.cBox�d�g�p�I����.Size = new System.Drawing.Size(16, 24);
			this.cBox�d�g�p�I����.TabIndex = 86;
			this.cBox�d�g�p�I����.TabStop = false;
			this.cBox�d�g�p�I����.Click += new System.EventHandler(this.cBox�d�g�p�I����_Click);
			// 
			// cBox�r�g�p�I����
			// 
			this.cBox�r�g�p�I����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBox�r�g�p�I����.Location = new System.Drawing.Point(12, 186);
			this.cBox�r�g�p�I����.Name = "cBox�r�g�p�I����";
			this.cBox�r�g�p�I����.Size = new System.Drawing.Size(16, 24);
			this.cBox�r�g�p�I����.TabIndex = 85;
			this.cBox�r�g�p�I����.TabStop = false;
			this.cBox�r�g�p�I����.Click += new System.EventHandler(this.cBox�r�g�p�I����_Click);
			// 
			// cBox�d�g�p�J�n��
			// 
			this.cBox�d�g�p�J�n��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBox�d�g�p�J�n��.Location = new System.Drawing.Point(206, 114);
			this.cBox�d�g�p�J�n��.Name = "cBox�d�g�p�J�n��";
			this.cBox�d�g�p�J�n��.Size = new System.Drawing.Size(16, 24);
			this.cBox�d�g�p�J�n��.TabIndex = 84;
			this.cBox�d�g�p�J�n��.TabStop = false;
			this.cBox�d�g�p�J�n��.Click += new System.EventHandler(this.cBox�d�g�p�J�n��_Click);
			// 
			// cBox�r�g�p�J�n��
			// 
			this.cBox�r�g�p�J�n��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBox�r�g�p�J�n��.Location = new System.Drawing.Point(12, 114);
			this.cBox�r�g�p�J�n��.Name = "cBox�r�g�p�J�n��";
			this.cBox�r�g�p�J�n��.Size = new System.Drawing.Size(16, 24);
			this.cBox�r�g�p�J�n��.TabIndex = 83;
			this.cBox�r�g�p�J�n��.TabStop = false;
			this.cBox�r�g�p�J�n��.Click += new System.EventHandler(this.cBox�r�g�p�J�n��_Click);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(174, 258);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(26, 22);
			this.label7.TabIndex = 82;
			this.label7.Text = "�`";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtp�I���o�^��
			// 
			this.dtp�I���o�^��.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�I���o�^��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�I���o�^��.Location = new System.Drawing.Point(222, 256);
			this.dtp�I���o�^��.Name = "dtp�I���o�^��";
			this.dtp�I���o�^��.Size = new System.Drawing.Size(138, 23);
			this.dtp�I���o�^��.TabIndex = 8;
			this.dtp�I���o�^��.TabStop = false;
			this.dtp�I���o�^��.DropDown += new System.EventHandler(this.dtp�I���o�^��_DropDown);
			// 
			// dtp�J�n�o�^��
			// 
			this.dtp�J�n�o�^��.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�J�n�o�^��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�J�n�o�^��.Location = new System.Drawing.Point(28, 256);
			this.dtp�J�n�o�^��.Name = "dtp�J�n�o�^��";
			this.dtp�J�n�o�^��.Size = new System.Drawing.Size(138, 23);
			this.dtp�J�n�o�^��.TabIndex = 7;
			this.dtp�J�n�o�^��.TabStop = false;
			this.dtp�J�n�o�^��.DropDown += new System.EventHandler(this.dtp�J�n�o�^��_DropDown);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(174, 188);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 22);
			this.label6.TabIndex = 79;
			this.label6.Text = "�`";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtp�d�g�p�I����
			// 
			this.dtp�d�g�p�I����.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�d�g�p�I����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�d�g�p�I����.Location = new System.Drawing.Point(222, 186);
			this.dtp�d�g�p�I����.Name = "dtp�d�g�p�I����";
			this.dtp�d�g�p�I����.Size = new System.Drawing.Size(138, 23);
			this.dtp�d�g�p�I����.TabIndex = 6;
			this.dtp�d�g�p�I����.TabStop = false;
			this.dtp�d�g�p�I����.DropDown += new System.EventHandler(this.dtp�d�g�p�I����_DropDown);
			// 
			// dtp�r�g�p�I����
			// 
			this.dtp�r�g�p�I����.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�r�g�p�I����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�r�g�p�I����.Location = new System.Drawing.Point(28, 186);
			this.dtp�r�g�p�I����.Name = "dtp�r�g�p�I����";
			this.dtp�r�g�p�I����.Size = new System.Drawing.Size(138, 23);
			this.dtp�r�g�p�I����.TabIndex = 5;
			this.dtp�r�g�p�I����.TabStop = false;
			this.dtp�r�g�p�I����.DropDown += new System.EventHandler(this.dtp�r�g�p�I����_DropDown);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(174, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 22);
			this.label5.TabIndex = 76;
			this.label5.Text = "�`";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtp�d�g�p�J�n��
			// 
			this.dtp�d�g�p�J�n��.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�d�g�p�J�n��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�d�g�p�J�n��.Location = new System.Drawing.Point(222, 114);
			this.dtp�d�g�p�J�n��.Name = "dtp�d�g�p�J�n��";
			this.dtp�d�g�p�J�n��.Size = new System.Drawing.Size(138, 23);
			this.dtp�d�g�p�J�n��.TabIndex = 4;
			this.dtp�d�g�p�J�n��.TabStop = false;
			this.dtp�d�g�p�J�n��.DropDown += new System.EventHandler(this.dtp�d�g�p�J�n��_DropDown);
			// 
			// dtp�r�g�p�J�n��
			// 
			this.dtp�r�g�p�J�n��.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�r�g�p�J�n��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp�r�g�p�J�n��.Location = new System.Drawing.Point(28, 114);
			this.dtp�r�g�p�J�n��.Name = "dtp�r�g�p�J�n��";
			this.dtp�r�g�p�J�n��.Size = new System.Drawing.Size(138, 23);
			this.dtp�r�g�p�J�n��.TabIndex = 3;
			this.dtp�r�g�p�J�n��.TabStop = false;
			this.dtp�r�g�p�J�n��.DropDown += new System.EventHandler(this.dtp�r�g�p�J�n��_DropDown);
			// 
			// lab�g�p�I����
			// 
			this.lab�g�p�I����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�g�p�I����.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�g�p�I����.Location = new System.Drawing.Point(16, 156);
			this.lab�g�p�I����.Name = "lab�g�p�I����";
			this.lab�g�p�I����.Size = new System.Drawing.Size(88, 18);
			this.lab�g�p�I����.TabIndex = 67;
			this.lab�g�p�I����.Text = "�g�p�I����";
			// 
			// lab����R�[�h
			// 
			this.lab����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab����R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab����R�[�h.Location = new System.Drawing.Point(16, 14);
			this.lab����R�[�h.Name = "lab����R�[�h";
			this.lab����R�[�h.Size = new System.Drawing.Size(98, 18);
			this.lab����R�[�h.TabIndex = 61;
			this.lab����R�[�h.Text = "���q�l�R�[�h";
			// 
			// tex�J�n����R�[�h
			// 
			this.tex�J�n����R�[�h.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex�J�n����R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�J�n����R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�J�n����R�[�h.Location = new System.Drawing.Point(12, 42);
			this.tex�J�n����R�[�h.MaxLength = 12;
			this.tex�J�n����R�[�h.Name = "tex�J�n����R�[�h";
			this.tex�J�n����R�[�h.Size = new System.Drawing.Size(154, 23);
			this.tex�J�n����R�[�h.TabIndex = 1;
			this.tex�J�n����R�[�h.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(174, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 22);
			this.label2.TabIndex = 59;
			this.label2.Text = "�`";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab���p�ғo�^��
			// 
			this.lab���p�ғo�^��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���p�ғo�^��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���p�ғo�^��.Location = new System.Drawing.Point(16, 226);
			this.lab���p�ғo�^��.Name = "lab���p�ғo�^��";
			this.lab���p�ғo�^��.Size = new System.Drawing.Size(128, 20);
			this.lab���p�ғo�^��.TabIndex = 57;
			this.lab���p�ғo�^��.Text = "���[�U�[�o�^��";
			// 
			// lab�g�p�J�n��
			// 
			this.lab�g�p�J�n��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�g�p�J�n��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�g�p�J�n��.Location = new System.Drawing.Point(16, 84);
			this.lab�g�p�J�n��.Name = "lab�g�p�J�n��";
			this.lab�g�p�J�n��.Size = new System.Drawing.Size(92, 18);
			this.lab�g�p�J�n��.TabIndex = 56;
			this.lab�g�p�J�n��.Text = "�g�p�J�n��";
			// 
			// tex�I������R�[�h
			// 
			this.tex�I������R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex�I������R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�I������R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�I������R�[�h.Location = new System.Drawing.Point(206, 42);
			this.tex�I������R�[�h.MaxLength = 12;
			this.tex�I������R�[�h.Name = "tex�I������R�[�h";
			this.tex�I������R�[�h.Size = new System.Drawing.Size(154, 23);
			this.tex�I������R�[�h.TabIndex = 2;
			this.tex�I������R�[�h.Text = "";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab�W��X�^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab�W��X�^�C�g��
			// 
			this.lab�W��X�^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�W��X�^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�W��X�^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab�W��X�^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab�W��X�^�C�g��.Name = "lab�W��X�^�C�g��";
			this.lab�W��X�^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab�W��X�^�C�g��.TabIndex = 0;
			this.lab�W��X�^�C�g��.Text = "���q�l���o��";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btn�b�r�u�o��);
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Location = new System.Drawing.Point(0, 354);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(388, 58);
			this.panel8.TabIndex = 2;
			// 
			// btn�b�r�u�o��
			// 
			this.btn�b�r�u�o��.ForeColor = System.Drawing.Color.Blue;
			this.btn�b�r�u�o��.Location = new System.Drawing.Point(76, 6);
			this.btn�b�r�u�o��.Name = "btn�b�r�u�o��";
			this.btn�b�r�u�o��.Size = new System.Drawing.Size(54, 48);
			this.btn�b�r�u�o��.TabIndex = 7;
			this.btn�b�r�u�o��.Text = "�b�r�u�@�o��";
			this.btn�b�r�u�o��.Click += new System.EventHandler(this.btn�b�r�u�o��_Click);
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(140, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(242, 50);
			this.tex���b�Z�[�W.TabIndex = 0;
			this.tex���b�Z�[�W.TabStop = false;
			this.tex���b�Z�[�W.Text = "";
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(7, 50);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(377, 300);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// ������b�r�u�o��
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(388, 412);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.groupBox2);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(394, 444);
			this.Name = "������b�r�u�o��";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ���q�l���o��";
// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� START
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On�G���^�[�ړ�);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On�G���^�[�L�����Z��);
// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� END
            this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.������b�r�u�o��_Closed);
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
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
			���ڏ�����();
		}

		private void ���ڏ�����()
		{
			tex�J�n����R�[�h.Text = " ";
			tex�I������R�[�h.Text = "";

			dtp�r�g�p�J�n��.Value = System.DateTime.Now;
			cBox�r�g�p�J�n��.Checked = false;
			lab�r�g�p�J�n��.Visible = true;

			dtp�d�g�p�J�n��.Value = System.DateTime.Now;
			cBox�d�g�p�J�n��.Checked = false;
			lab�d�g�p�J�n��.Visible = true;

			dtp�r�g�p�I����.Value = System.DateTime.Now;
			cBox�r�g�p�I����.Checked = false;
			lab�r�g�p�I����.Visible = true;

			dtp�d�g�p�I����.Value = System.DateTime.Now;
			cBox�d�g�p�I����.Checked = false;
			lab�d�g�p�I����.Visible = true;

			dtp�J�n�o�^��.Value = System.DateTime.Now;
			cBox�J�n�o�^��.Checked = false;
			lab�J�n�o�^��.Visible = true;

			dtp�I���o�^��.Value = System.DateTime.Now;
			cBox�I���o�^��.Checked = false;
			lab�I���o�^��.Visible = true;

			dtp�r�g�p�J�n��.Value = System.DateTime.Now;
			cBox�r�g�p�J�n��.Checked = false;
			lab�r�g�p�J�n��.Visible = true;

			dtp�d�g�p�J�n��.Value = System.DateTime.Now;
			cBox�d�g�p�J�n��.Checked = false;
			lab�d�g�p�J�n��.Visible = true;

			dtp�r�g�p�I����.Value = System.DateTime.Now;
			cBox�r�g�p�I����.Checked = false;
			lab�r�g�p�I����.Visible = true;

			dtp�d�g�p�I����.Value = System.DateTime.Now;
			cBox�d�g�p�I����.Checked = false;
			lab�d�g�p�I����.Visible = true;
		}
		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn�b�r�u�o��_Click(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W.Text = "";

			tex�J�n����R�[�h.Text = tex�J�n����R�[�h.Text.Trim();
			tex�I������R�[�h.Text = tex�I������R�[�h.Text.Trim();

			if(!���p�`�F�b�N(tex�J�n����R�[�h,"�J�n���q�l�R�[�h")) return;
			if(!���p�`�F�b�N(tex�I������R�[�h,"�I�����q�l�R�[�h")) return;

			if(cBox�r�g�p�J�n��.Checked == true && cBox�d�g�p�J�n��.Checked == true)
			{
				if (dtp�r�g�p�J�n��.Value > dtp�d�g�p�J�n��.Value)
				{
					MessageBox.Show("�g�p�J�n���͈̔͂����������͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK );
					dtp�r�g�p�J�n��.Focus();
					return;
				}
			}
			if(cBox�r�g�p�I����.Checked == true && cBox�d�g�p�I����.Checked == true)
			{
				if (dtp�r�g�p�I����.Value > dtp�d�g�p�I����.Value)
				{
					MessageBox.Show("�g�p�I�����͈̔͂����������͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK );
					dtp�r�g�p�I����.Focus();
					return;
				}
			}
			if(cBox�J�n�o�^��.Checked == true && cBox�I���o�^��.Checked == true)
			{
				if (dtp�J�n�o�^��.Value > dtp�I���o�^��.Value)
				{
					MessageBox.Show("���[�U�[�o�^���͈̔͂����������͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK );
					dtp�J�n�o�^��.Focus();
					return;
				}
			}

			String[] sList;
			string[] sData = new string[8];
			sData[0] = tex�J�n����R�[�h.Text;
			if(sData[0].Length == 0)
			{
				sData[0] = tex�I������R�[�h.Text;
				sData[1] = "";
			}
			else
				sData[1] = tex�I������R�[�h.Text;

			sData[2] = "";
			sData[3] = "";
			if(cBox�r�g�p�J�n��.Checked == true)
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX START
//				sData[2] = dtp�r�g�p�J�n��.Value.ToShortDateString().Replace("/","");
				sData[2] = YYYYMMDD�ϊ�(dtp�r�g�p�J�n��.Value);
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX END

			if(cBox�d�g�p�J�n��.Checked == true)
			{
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX START
				if(sData[2].Length == 0)
//					sData[2] = dtp�d�g�p�J�n��.Value.ToShortDateString().Replace("/","");
					sData[2] = YYYYMMDD�ϊ�(dtp�d�g�p�J�n��.Value);
				else
//					sData[3] = dtp�d�g�p�J�n��.Value.ToShortDateString().Replace("/","");
					sData[3] = YYYYMMDD�ϊ�(dtp�d�g�p�J�n��.Value);
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX END
			}

			sData[4] = "";
			sData[5] = "";
			if(cBox�r�g�p�I����.Checked == true)
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX START
//				sData[4] = dtp�r�g�p�I����.Value.ToShortDateString().Replace("/","");
				sData[4] = YYYYMMDD�ϊ�(dtp�r�g�p�I����.Value);
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX END

			if(cBox�d�g�p�I����.Checked == true)
			{
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX START
				if(sData[4].Length == 0)
//					sData[4] = dtp�d�g�p�I����.Value.ToShortDateString().Replace("/","");
					sData[4] = YYYYMMDD�ϊ�(dtp�d�g�p�I����.Value);
				else
//					sData[5] = dtp�d�g�p�I����.Value.ToShortDateString().Replace("/","");
					sData[5] = YYYYMMDD�ϊ�(dtp�d�g�p�I����.Value);
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX END
			}

			sData[6] = "";
			sData[7] = "";
			if(cBox�J�n�o�^��.Checked == true)
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX START
//				sData[6] = dtp�J�n�o�^��.Value.ToShortDateString().Replace("/","");
				sData[6] = YYYYMMDD�ϊ�(dtp�J�n�o�^��.Value);
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX END

			if(cBox�I���o�^��.Checked == true)
			{
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX START
				if(sData[6].Length == 0)
//					sData[6] = dtp�I���o�^��.Value.ToShortDateString().Replace("/","");
					sData[6] = YYYYMMDD�ϊ�(dtp�I���o�^��.Value);
				else
//					sData[7] = dtp�I���o�^��.Value.ToShortDateString().Replace("/","");
					sData[7] = YYYYMMDD�ϊ�(dtp�I���o�^��.Value);
// MOD 2005.07.08 ���s�j�����J ���t�ϊ��̕ύX END
			}

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				if(sv_maintenance == null)
				{
					sv_maintenance = new is2maintenance.Service1();
// DEL 2005.05.27 ���s�j���� �Z�b�V��������̔p�~ START
//					sv_maintenance.CookieContainer = cContainer;
// DEL 2005.05.27 ���s�j���� �Z�b�V��������̔p�~ END
				}
				sList = sv_maintenance.Get_csvwrite(gsa���[�U, sData);
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
				// ���q�^�����̂ݎ擾
				String[] sList_oji;
				sList_oji =  sv_oji.Get_csvwrite(gsa���[�U, sData);
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

				this.Cursor = System.Windows.Forms.Cursors.Default;

// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
//				if(sList[0].Length == 4)
				if((sList[0].Length == 4) || (sList_oji[0].Length == 4))
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END
				{
					sList[0] = "\"���q�l�R�[�h\",\"���q�l��\",\"�g�p�J�n��\",\"�g�p�I����\","
// MOD 2009.11.25 ���s�j���� ���q�l���o�́i�b�r�u�j�̍��ڒǉ� START
//						+ "\"����R�[�h\",\"���喼\",\"�Ǘ��X���R�[�h\",\"�Ǘ��X����\","
						+ "\"�Ǘ��ҋ敪\",\"�^����\��\",\"���q�l�o�^����\",\"���q�l�X�V����\","
						+ "\"�Z�N�V�����R�[�h\",\"�Z�N�V������\",\"�Ǘ��X���R�[�h\",\"�Ǘ��X����\","
// MOD 2009.11.25 ���s�j���� ���q�l���o�́i�b�r�u�j�̍��ڒǉ� END
						+ "\"�ݒu��Z���P\",\"�ݒu��Z���Q\","
// MOD 2009.11.25 ���s�j���� ���q�l���o�́i�b�r�u�j�̍��ڒǉ� START
						+ "\"Ver.\",\"�X�֔ԍ�\",\"�g�p��\",\"�\����t�m�n\","
						+ "\"�Z�N�V�����o�^����\",\"�Z�N�V�����X�V����\","
// MOD 2009.11.25 ���s�j���� ���q�l���o�́i�b�r�u�j�̍��ڒǉ� END
// MOD 2006.12.11 ���s�j�����J �T�[�}���䐔�ǉ� START
//						+ "\"���p�҃R�[�h\",\"�p�X���[�h\",\"���p�Җ�\",\"���p�ғo�^��\"";
						+ "\"���[�U�R�[�h\",\"�p�X���[�h\",\"���[�U��\",\"���[�U�o�^��\","
// MOD 2009.11.25 ���s�j���� ���q�l���o�́i�b�r�u�j�̍��ڒǉ� START
						+ "\"���˗���R�[�h\",\"���x������֎~\",\"�F�؃G���[��\",\"�p�X���[�h�X�V��\","
						+ "\"���[�U�o�^����\",\"���[�U�X�V����\","
// MOD 2009.11.25 ���s�j���� ���q�l���o�́i�b�r�u�j�̍��ڒǉ� END
						+ "\"�T�[�}���䐔\""
// MOD 2006.12.11 ���s�j�����J �T�[�}���䐔�ǉ� END
// MOD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� START
						+ ",\"�V���A���ԍ��P\",\"��ԂP\",\"�V���A���ԍ��Q\",\"��ԂQ\""
						+ ",\"�V���A���ԍ��R\",\"��ԂR\",\"�V���A���ԍ��S\",\"��ԂS\""
// MOD 2009.03.03 ���s�j���� �T�[�}���V���A���ԍ��̒ǉ� END
						;

					// �f�t�H���g�̃t�H���_���f�X�N�g�b�v�t�H���_�ɂ���
					saveFileDialog1.InitialDirectory
						= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
					saveFileDialog1.Filter = "�b�r�u�t�@�C�� (*.csv)|*.csv";
					byte[] bSJIS;
					if(saveFileDialog1.ShowDialog(this) == DialogResult.OK)
					{
						System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
						for(int iCnt = 0; iCnt < sList.Length; iCnt++)
						{
							bSJIS = toSJIS(sList[iCnt]);
							fs.Write(bSJIS, 0 , bSJIS.Length);
						}
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� START
						sList_oji[0] = sList[0];
						int iCnt_oji;
						if  (sList.Length == 0 )
						{
							iCnt_oji = 0;
						} 
						else
						{
							iCnt_oji = 1;
						}
						for(int iCnt = iCnt_oji; iCnt < sList_oji.Length; iCnt++)
						{
							bSJIS = toSJIS(sList_oji[iCnt]);
							fs.Write(bSJIS, 0 , bSJIS.Length);
						}				
// ADD 2010.12.14 ACT�j�_�� ���q�^���Ή� END

						fs.Close();
						tex���b�Z�[�W.Text = "";
					}
				}
				else
				{
					if (sList[0].Equals("�Y���f�[�^������܂���"))
					{
						tex���b�Z�[�W.Text = "";
						MessageBox.Show("�Y���f�[�^������܂���","�b�r�u�o��",MessageBoxButtons.OK);
					}
					else
					{
						�r�[�v��();
						tex���b�Z�[�W.Text = sList[0];
					}
				}
			}
			catch(Exception ex)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				tex���b�Z�[�W.Text = ex.Message;
			}
			tex�J�n����R�[�h.Focus();
		}

		private void cBox�r�g�p�J�n��_Click(object sender, System.EventArgs e)
		{
			if(cBox�r�g�p�J�n��.Checked == true)
				lab�r�g�p�J�n��.Visible = false;
			else
				lab�r�g�p�J�n��.Visible = true;
		}

		private void cBox�d�g�p�J�n��_Click(object sender, System.EventArgs e)
		{
			if(cBox�d�g�p�J�n��.Checked == true)
				lab�d�g�p�J�n��.Visible = false;
			else
				lab�d�g�p�J�n��.Visible = true;
		}

		private void cBox�r�g�p�I����_Click(object sender, System.EventArgs e)
		{
			if(cBox�r�g�p�I����.Checked == true)
				lab�r�g�p�I����.Visible = false;
			else
				lab�r�g�p�I����.Visible = true;
		}

		private void cBox�d�g�p�I����_Click(object sender, System.EventArgs e)
		{
			if(cBox�d�g�p�I����.Checked == true)
				lab�d�g�p�I����.Visible = false;
			else
				lab�d�g�p�I����.Visible = true;
		}

		private void cBox�J�n�o�^��_Click(object sender, System.EventArgs e)
		{
			if(cBox�J�n�o�^��.Checked == true)
				lab�J�n�o�^��.Visible = false;
			else
				lab�J�n�o�^��.Visible = true;
		}

		private void cBox�I���o�^��_Click(object sender, System.EventArgs e)
		{
			if(cBox�I���o�^��.Checked == true)
				lab�I���o�^��.Visible = false;
			else
				lab�I���o�^��.Visible = true;
		}

		private void dtp�r�g�p�J�n��_DropDown(object sender, System.EventArgs e)
		{
			if(cBox�r�g�p�J�n��.Checked == false)
			{
				cBox�r�g�p�J�n��.Checked = true;
				lab�r�g�p�J�n��.Visible  = false;
			}
		}

		private void dtp�d�g�p�J�n��_DropDown(object sender, System.EventArgs e)
		{
			if(cBox�d�g�p�J�n��.Checked == false)
			{
				cBox�d�g�p�J�n��.Checked = true;
				lab�d�g�p�J�n��.Visible  = false;
			}
		}

		private void dtp�r�g�p�I����_DropDown(object sender, System.EventArgs e)
		{
			if(cBox�r�g�p�I����.Checked == false)
			{
				cBox�r�g�p�I����.Checked = true;
				lab�r�g�p�I����.Visible  = false;
			}
		}

		private void dtp�d�g�p�I����_DropDown(object sender, System.EventArgs e)
		{
			if(cBox�d�g�p�I����.Checked == false)
			{
				cBox�d�g�p�I����.Checked = true;
				lab�d�g�p�I����.Visible  = false;
			}
		}

		private void dtp�J�n�o�^��_DropDown(object sender, System.EventArgs e)
		{
			if(cBox�J�n�o�^��.Checked == false)
			{
				cBox�J�n�o�^��.Checked = true;
				lab�J�n�o�^��.Visible  = false;
			}
		}

		private void dtp�I���o�^��_DropDown(object sender, System.EventArgs e)
		{
			if(cBox�I���o�^��.Checked == false)
			{
				cBox�I���o�^��.Checked = true;
				lab�I���o�^��.Visible  = false;
			}
		}

		private void ������b�r�u�o��_Closed(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W.Text = "";
			tex�J�n����R�[�h.Focus();
		}

	}
}
