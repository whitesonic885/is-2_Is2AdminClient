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
	public class �o�׏� : ���ʃt�H�[��
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lab�o�׏󋵃^�C�g��;
		private System.Windows.Forms.DateTimePicker dt�J�n���t;
		private System.Windows.Forms.DateTimePicker dt�I�����t;
		private System.Windows.Forms.Button btn�b�r�u�o��;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btn���;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�J�n�X���R�[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�I���X���R�[�h;
		private System.Windows.Forms.Label lab�X��;
		private System.Windows.Forms.Label lab�n��R�[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�J�n�n��R�[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�I���n��R�[�h;
		private System.Windows.Forms.Label lab�o�ד�;
		private System.Windows.Forms.Label lab�X����;
		private System.Windows.Forms.Label lab�n���;
		private System.Windows.Forms.Label lab�o�ד���;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public �o�׏�()
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
			this.lab�o�ד� = new System.Windows.Forms.Label();
			this.lab�X���� = new System.Windows.Forms.Label();
			this.tex�J�n�X���R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�I���X���R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�X�� = new System.Windows.Forms.Label();
			this.lab�n��� = new System.Windows.Forms.Label();
			this.lab�n��R�[�h = new System.Windows.Forms.Label();
			this.tex�J�n�n��R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�I���n��R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�o�ד��� = new System.Windows.Forms.Label();
			this.dt�J�n���t = new System.Windows.Forms.DateTimePicker();
			this.dt�I�����t = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab�o�׏󋵃^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn�b�r�u�o�� = new System.Windows.Forms.Button();
			this.btn��� = new System.Windows.Forms.Button();
			this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
			this.btn���� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.lab�o�ד�);
			this.panel1.Controls.Add(this.lab�X����);
			this.panel1.Controls.Add(this.tex�J�n�X���R�[�h);
			this.panel1.Controls.Add(this.tex�I���X���R�[�h);
			this.panel1.Controls.Add(this.lab�X��);
			this.panel1.Controls.Add(this.lab�n���);
			this.panel1.Controls.Add(this.lab�n��R�[�h);
			this.panel1.Controls.Add(this.tex�J�n�n��R�[�h);
			this.panel1.Controls.Add(this.tex�I���n��R�[�h);
			this.panel1.Controls.Add(this.lab�o�ד���);
			this.panel1.Controls.Add(this.dt�J�n���t);
			this.panel1.Controls.Add(this.dt�I�����t);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(370, 176);
			this.panel1.TabIndex = 1;
			// 
			// lab�o�ד�
			// 
			this.lab�o�ד�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�o�ד�.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�o�ד�.Location = new System.Drawing.Point(36, 102);
			this.lab�o�ד�.Name = "lab�o�ד�";
			this.lab�o�ד�.Size = new System.Drawing.Size(76, 18);
			this.lab�o�ד�.TabIndex = 79;
			this.lab�o�ד�.Text = "�o�ד�";
			// 
			// lab�X����
			// 
			this.lab�X����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�X����.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�X����.Location = new System.Drawing.Point(152, 64);
			this.lab�X����.Name = "lab�X����";
			this.lab�X����.Size = new System.Drawing.Size(22, 16);
			this.lab�X����.TabIndex = 78;
			this.lab�X����.Text = "�`";
			// 
			// tex�J�n�X���R�[�h
			// 
			this.tex�J�n�X���R�[�h.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex�J�n�X���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�J�n�X���R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�J�n�X���R�[�h.Location = new System.Drawing.Point(118, 60);
			this.tex�J�n�X���R�[�h.MaxLength = 3;
			this.tex�J�n�X���R�[�h.Name = "tex�J�n�X���R�[�h";
			this.tex�J�n�X���R�[�h.Size = new System.Drawing.Size(34, 23);
			this.tex�J�n�X���R�[�h.TabIndex = 3;
			this.tex�J�n�X���R�[�h.Text = "123";
			// 
			// tex�I���X���R�[�h
			// 
			this.tex�I���X���R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex�I���X���R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�I���X���R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�I���X���R�[�h.Location = new System.Drawing.Point(174, 60);
			this.tex�I���X���R�[�h.MaxLength = 3;
			this.tex�I���X���R�[�h.Name = "tex�I���X���R�[�h";
			this.tex�I���X���R�[�h.Size = new System.Drawing.Size(34, 23);
			this.tex�I���X���R�[�h.TabIndex = 4;
			this.tex�I���X���R�[�h.Text = "123";
			// 
			// lab�X��
			// 
			this.lab�X��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�X��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�X��.Location = new System.Drawing.Point(36, 64);
			this.lab�X��.Name = "lab�X��";
			this.lab�X��.Size = new System.Drawing.Size(76, 18);
			this.lab�X��.TabIndex = 77;
			this.lab�X��.Text = "�X���R�[�h";
			// 
			// lab�n���
			// 
			this.lab�n���.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�n���.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�n���.Location = new System.Drawing.Point(152, 26);
			this.lab�n���.Name = "lab�n���";
			this.lab�n���.Size = new System.Drawing.Size(22, 16);
			this.lab�n���.TabIndex = 1;
			this.lab�n���.Text = "�`";
			// 
			// lab�n��R�[�h
			// 
			this.lab�n��R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�n��R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�n��R�[�h.Location = new System.Drawing.Point(36, 26);
			this.lab�n��R�[�h.Name = "lab�n��R�[�h";
			this.lab�n��R�[�h.Size = new System.Drawing.Size(76, 18);
			this.lab�n��R�[�h.TabIndex = 76;
			this.lab�n��R�[�h.Text = "�n��R�[�h";
			// 
			// tex�J�n�n��R�[�h
			// 
			this.tex�J�n�n��R�[�h.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex�J�n�n��R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�J�n�n��R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�J�n�n��R�[�h.Location = new System.Drawing.Point(118, 22);
			this.tex�J�n�n��R�[�h.MaxLength = 3;
			this.tex�J�n�n��R�[�h.Name = "tex�J�n�n��R�[�h";
			this.tex�J�n�n��R�[�h.Size = new System.Drawing.Size(34, 23);
			this.tex�J�n�n��R�[�h.TabIndex = 0;
			this.tex�J�n�n��R�[�h.Text = "123";
			// 
			// tex�I���n��R�[�h
			// 
			this.tex�I���n��R�[�h.BackColor = System.Drawing.SystemColors.Window;
			this.tex�I���n��R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�I���n��R�[�h.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex�I���n��R�[�h.Location = new System.Drawing.Point(174, 22);
			this.tex�I���n��R�[�h.MaxLength = 3;
			this.tex�I���n��R�[�h.Name = "tex�I���n��R�[�h";
			this.tex�I���n��R�[�h.Size = new System.Drawing.Size(34, 23);
			this.tex�I���n��R�[�h.TabIndex = 2;
			this.tex�I���n��R�[�h.Text = "123";
			// 
			// lab�o�ד���
			// 
			this.lab�o�ד���.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�o�ד���.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�o�ד���.Location = new System.Drawing.Point(188, 138);
			this.lab�o�ד���.Name = "lab�o�ד���";
			this.lab�o�ד���.Size = new System.Drawing.Size(24, 16);
			this.lab�o�ד���.TabIndex = 48;
			this.lab�o�ד���.Text = "�`";
			// 
			// dt�J�n���t
			// 
			this.dt�J�n���t.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt�J�n���t.Location = new System.Drawing.Point(44, 134);
			this.dt�J�n���t.Name = "dt�J�n���t";
			this.dt�J�n���t.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt�J�n���t.Size = new System.Drawing.Size(144, 23);
			this.dt�J�n���t.TabIndex = 6;
			// 
			// dt�I�����t
			// 
			this.dt�I�����t.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt�I�����t.Location = new System.Drawing.Point(212, 134);
			this.dt�I�����t.Name = "dt�I�����t";
			this.dt�I�����t.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt�I�����t.Size = new System.Drawing.Size(144, 23);
			this.dt�I�����t.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label1.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 404);
			this.label1.TabIndex = 44;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(810, 26);
			this.panel6.TabIndex = 12;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab�o�׏󋵃^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(792, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab�o�׏󋵃^�C�g��
			// 
			this.lab�o�׏󋵃^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�o�׏󋵃^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�o�׏󋵃^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab�o�׏󋵃^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab�o�׏󋵃^�C�g��.Name = "lab�o�׏󋵃^�C�g��";
			this.lab�o�׏󋵃^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab�o�׏󋵃^�C�g��.TabIndex = 0;
			this.lab�o�׏󋵃^�C�g��.Text = "�o�׏󋵈ꗗ�\�o��";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btn�b�r�u�o��);
			this.panel8.Controls.Add(this.btn���);
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Location = new System.Drawing.Point(0, 286);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 2;
			// 
			// btn�b�r�u�o��
			// 
			this.btn�b�r�u�o��.ForeColor = System.Drawing.Color.Blue;
			this.btn�b�r�u�o��.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn�b�r�u�o��.Location = new System.Drawing.Point(134, 6);
			this.btn�b�r�u�o��.Name = "btn�b�r�u�o��";
			this.btn�b�r�u�o��.Size = new System.Drawing.Size(54, 48);
			this.btn�b�r�u�o��.TabIndex = 2;
			this.btn�b�r�u�o��.Text = "�b�r�u�@�o��";
			this.btn�b�r�u�o��.Click += new System.EventHandler(this.btn�b�r�u�o��_Click);
			// 
			// btn���
			// 
			this.btn���.ForeColor = System.Drawing.Color.Blue;
			this.btn���.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn���.Location = new System.Drawing.Point(70, 6);
			this.btn���.Name = "btn���";
			this.btn���.Size = new System.Drawing.Size(54, 48);
			this.btn���.TabIndex = 1;
			this.btn���.Text = "���";
			this.btn���.Click += new System.EventHandler(this.btn���_Click);
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(192, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(194, 50);
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.panel1);
			this.groupBox3.Location = new System.Drawing.Point(10, 78);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(372, 184);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			// 
			// �o�׏�
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(388, 342);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(394, 374);
			this.Name = "�o�׏�";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 �o�׏󋵈ꗗ�\�o��";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.�o�׏�_Load);
			this.Closed += new System.EventHandler(this.�o�׏�_Closed);
			this.Activated += new System.EventHandler(this.�o�׏�_Activated);
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
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

		private void ���ڃN���A()
		{
			tex�J�n�n��R�[�h.Text = "";
			tex�I���n��R�[�h.Text = "";
			tex�J�n�X���R�[�h.Text = "";
			tex�I���X���R�[�h.Text = "";
// ADD 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� START
			if(gs�X���R�[�h.Trim().Length != 0)
			{
				lab�n��R�[�h.Visible     = false;
				tex�J�n�n��R�[�h.Visible = false;
				lab�n���.Visible         = false;
				tex�I���n��R�[�h.Visible = false;

				tex�J�n�X���R�[�h.Text    = gs�X���R�[�h.Trim();
				tex�J�n�X���R�[�h.Enabled = false;
				lab�X����.Visible         = false;
				tex�I���X���R�[�h.Visible = false;
			}else{
				lab�n��R�[�h.Visible     = true;
				tex�J�n�n��R�[�h.Visible = true;
				lab�n���.Visible         = true;
				tex�I���n��R�[�h.Visible = true;

				tex�J�n�X���R�[�h.Text    = "";
				tex�J�n�X���R�[�h.Enabled = true;
				lab�X����.Visible         = true;
				tex�I���X���R�[�h.Visible = true;
			}
// ADD 2007.02.01 ���s�j���� �c�Ə�-�o�׏󋵈ꗗ�Ή� END
// MOD 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� START
//			dt�J�n���t.Value = new DateTime(System.DateTime.Now.Year, 
//											System.DateTime.Now.Month, 1);
//			dt�I�����t.Value = System.DateTime.Now;
			dt�I�����t.Value = System.DateTime.Now.AddDays(-1); // �f�t�H���g��O���ɂ���
// MOD 2007.01.25 ���s�j���� ���׌y���iFJCS)�Ζ{�a���j START
//			dt�J�n���t.Value = new DateTime(dt�I�����t.Value.Year, 
//											dt�I�����t.Value.Month, 1);
			dt�J�n���t.Value = dt�I�����t.Value;
// MOD 2007.01.25 ���s�j���� ���׌y���iFJCS)�Ζ{�a���j END
// MOD 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� END
//�O���P���`����
//			int iYear  = System.DateTime.Now.Year;
//			int iMonth = System.DateTime.Now.Month;
//			if(iMonth == 1)
//			{
//				iYear--;
//				iMonth = 12;
//			}
//			else
//			{
//				iMonth--;
//			}
//			dt�J�n���t.Value = new DateTime(iYear, iMonth, 1);
//			dt�I�����t.Value = dt�J�n���t.Value.AddMonths(1).AddDays(-1);
			tex���b�Z�[�W.Text = "";
		}

		private void �o�׏�_Load(object sender, System.EventArgs e)
		{
			���ڃN���A();
// ADD 2007.02.16 ���s�j���� �����t�H�[�J�X�̕ύX START
			if(gs�X���R�[�h.Trim().Length == 0)
			{
				tex�J�n�n��R�[�h.Text = " ";
				tex�J�n�n��R�[�h.Focus();
			}
			else
			{
				dt�J�n���t.Focus();
			}
// ADD 2007.02.16 ���s�j���� �����t�H�[�J�X�̕ύX END
		}

		private void �o�׏�_Closed(object sender, System.EventArgs e)
		{
			���ڃN���A();
// MOD 2007.02.16 ���s�j���� �����t�H�[�J�X�̕ύX START
//			dt�J�n���t.Focus();
			tex�J�n�n��R�[�h.Text = " ";
			tex�J�n�n��R�[�h.Focus();
// MOD 2007.02.16 ���s�j���� �����t�H�[�J�X�̕ύX END
		}

		private void btn�b�r�u�o��_Click(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W.Text = "";
			if (dt�J�n���t.Value > dt�I�����t.Value)
			{
				MessageBox.Show("���t�͈̔͂����������͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK );
				dt�J�n���t.Focus();
				return;
			}
// ADD 2007.02.01 ���s�j���� �o�׏󋵈ꗗ�\�̕ύX START
			string sSdayh = YYYYMMDD�ϊ�(dt�J�n���t.Value.AddMonths(3));
			string sEdayh = YYYYMMDD�ϊ�(dt�I�����t.Value);
			if (int.Parse(sSdayh) < int.Parse(sEdayh))
			{
				MessageBox.Show("���t�͈̔͂́A�R�����ȓ��Ŏw�肵�Ă�������","���̓`�F�b�N",MessageBoxButtons.OK );
				dt�J�n���t.Focus();
				return;
			}
// ADD 2007.02.01 ���s�j���� �o�׏󋵈ꗗ�\�̕ύX START

			string s�J�n���t = YYYYMMDD�ϊ�(dt�J�n���t.Value);
			string s�I�����t = YYYYMMDD�ϊ�(dt�I�����t.Value);

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sList = new string[2]{"",""};
				string[] sData = new string[6]{
												  tex�J�n�n��R�[�h.Text.Trim(),
												  tex�I���n��R�[�h.Text.Trim(),
												  tex�J�n�X���R�[�h.Text.Trim(),
												  tex�I���X���R�[�h.Text.Trim(),
												  s�J�n���t,
												  s�I�����t
											  };

				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
//				sList = sv_maintenance.Get_syuuka_csv(gsa���[�U, sData);
// MOD 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� START
//				sList = sv_maintenance.Get_syuuka_Inf(gsa���[�U, sData);
				sList = sv_maintenance.Get_syuuka_Inf2(gsa���[�U, sData);
// MOD 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� END
				this.Cursor = System.Windows.Forms.Cursors.Default;

				if(sList[0].Length == 4)
				{
// MOD 2007.02.01 ���s�j���� �o�׏󋵈ꗗ�\�̕ύX START
//					sList[0] = "\"�n��b�c\",\"�X���b�c\",\"�X����\","
//						+ "\"�׎喼\",\"�׎�b�c\",\"�o�ד�\","
//						+ "\"����\",\"��\",\"�d��(Kg)\","
//						+ "\"�^��\",\"���p��\",\"�ی���\""
//						;
					sList[0] = "\"�n��P�b�c\",\"�n��Q�b�c\",\"�X���b�c\","
						+ "\"�X����\",\"���q�l�b�c\",\"���q�l��\","
						+ "\"�Z�N�V�����b�c\",\"�Z�N�V������\","
						+ "\"����\",\"��\",\"�d��(Kg)\","
						+ "\"�^��\",\"���p��\",\"�ی���\""
						;
// MOD 2007.02.01 ���s�j���� �o�׏󋵈ꗗ�\�̕ύX END

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
						fs.Close();
						tex���b�Z�[�W.Text = "";
					}
				}
				else
				{
					if(sList[0].Equals("�Y���f�[�^������܂���"))
					{
						tex���b�Z�[�W.Text = "";
						�r�[�v��();
// MOD 2007.02.15 ���s�j���� ���b�Z�[�W�^�C�g���C�� START
//						MessageBox.Show("�Y���f�[�^������܂���","�ғ������o��",MessageBoxButtons.OK);
						MessageBox.Show("�Y���f�[�^������܂���","�o�׏󋵏��o��",MessageBoxButtons.OK);
// MOD 2007.02.15 ���s�j���� ���b�Z�[�W�^�C�g���C�� END
					}
					else
					{
						�r�[�v��();
						tex���b�Z�[�W.Text = sList[0];
					}
				}
			}
			catch (System.Net.WebException)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				tex���b�Z�[�W.Text = gs�ʐM�G���[;
			}
			catch(Exception ex)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				tex���b�Z�[�W.Text = ex.Message;
			}
		}

		private void btn���_Click(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W.Text = "";
			if (dt�J�n���t.Value > dt�I�����t.Value)
			{
				MessageBox.Show("���t�͈̔͂����������͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK );
				dt�J�n���t.Focus();
				return;
			}
// ADD 2007.02.01 ���s�j���� �o�׏󋵈ꗗ�\�̕ύX START
			string sSdayh = YYYYMMDD�ϊ�(dt�J�n���t.Value.AddMonths(3));
			string sEdayh = YYYYMMDD�ϊ�(dt�I�����t.Value);
			if (int.Parse(sSdayh) < int.Parse(sEdayh))
			{
				MessageBox.Show("���t�͈̔͂́A�R�����ȓ��Ŏw�肵�Ă�������","���̓`�F�b�N",MessageBoxButtons.OK );
				dt�J�n���t.Focus();
				return;
			}
// ADD 2007.02.01 ���s�j���� �o�׏󋵈ꗗ�\�̕ύX START

			string s�J�n���t = YYYYMMDD�ϊ�(dt�J�n���t.Value);
			string s�I�����t = YYYYMMDD�ϊ�(dt�I�����t.Value);

			tex���b�Z�[�W.Text = "�o�׏󋵏��ꗗ������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sList = new string[2]{"",""};
				string[] sData = new string[6]{
												  tex�J�n�n��R�[�h.Text.Trim(),
												  tex�I���n��R�[�h.Text.Trim(),
												  tex�J�n�X���R�[�h.Text.Trim(),
												  tex�I���X���R�[�h.Text.Trim(),
												  s�J�n���t,
												  s�I�����t
											  };

				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
//				sList = sv_maintenance.Get_syuuka_csv(gsa���[�U, sData);
// MOD 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� START
//				IEnumerator iEnum = sv_maintenance.Get_syuuka_Prn(gsa���[�U, sData).GetEnumerator();;
				IEnumerator iEnum = sv_maintenance.Get_syuuka_Prn2(gsa���[�U, sData).GetEnumerator();;
// MOD 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� END

				iEnum.MoveNext();
				this.Cursor = System.Windows.Forms.Cursors.Default;
				sList = (string[])iEnum.Current;
				if (sList[0].Equals("����I��"))
				{

					// �܂��̓f�[�^�Z�b�g�̃C���X�^���X�𐶐�
					�o�׏󋵃f�[�^ ds = new �o�׏󋵃f�[�^();

// ADD 2007.02.01 ���s�j���� �o�׏󋵈ꗗ�\�̕ύX START
					string s�^�C�g���J�n�� = s�J�n���t.Substring(0,4) 
											+ "/" + s�J�n���t.Substring(4,2)
											+ "/" + s�J�n���t.Substring(6,2);
					string s�^�C�g���I���� = s�I�����t.Substring(0,4) 
						+ "/" + s�I�����t.Substring(4,2)
						+ "/" + s�I�����t.Substring(6,2);
// ADD 2007.02.01 ���s�j���� �o�׏󋵈ꗗ�\�̕ύX END

					//�f�[�^�Z�b�g�ɒl���Z�b�g
					while (iEnum.MoveNext())
					{
						string[] sbList = new string[17];
						sbList = (string[])iEnum.Current;

						�o�׏󋵃f�[�^.table�o�׏�Row tr = (�o�׏󋵃f�[�^.table�o�׏�Row)ds.table�o�׏�.NewRow();
						tr.BeginEdit();

// ADD 2007.02.01 ���s�j���� �o�׏󋵈ꗗ�\�̕ύX START
//						tr.�X��CD = sbList[1].Trim();
//						tr.�X���� = sbList[2].Trim();
//						tr.�׎喼 = sbList[3].Trim();
//						tr.�׎�CD = sbList[4].Trim();
//						tr.�o�ד� = sbList[5].Trim();
//						tr.����   = sbList[6].Trim();
//						tr.��   = sbList[7].Trim();
//						tr.�d��   = sbList[8].Trim();
//						tr.�^��   = sbList[9].Trim();
//						tr.���p   = sbList[10].Trim();
//						tr.�ی�   = sbList[11].Trim();
						tr.�n��P�b�c = sbList[0].Trim();
						tr.�n��Q�b�c = sbList[1].Trim();
						tr.�X���b�c   = sbList[2].Trim();
						tr.�X����     = sbList[3].Trim();
						tr.�J�n��     = s�^�C�g���J�n��;
						tr.�I����     = s�^�C�g���I����;
						tr.����b�c   = sbList[4].Trim();
						tr.�����     = sbList[5].Trim();
						tr.����b�c   = sbList[6].Trim();
						tr.���喼     = sbList[7].Trim();
						tr.����       = decimal.Parse(sbList[8].Trim());
						tr.��       = decimal.Parse(sbList[9].Trim());
						tr.�d��       = decimal.Parse(sbList[10].Trim());
						tr.�^��       = decimal.Parse(sbList[11].Trim());
						tr.���p       = decimal.Parse(sbList[12].Trim());
						tr.�ی�       = decimal.Parse(sbList[13].Trim());
// ADD 2007.02.01 ���s�j���� �o�׏󋵈ꗗ�\�̕ύX END

						tr.EndEdit();
						// �Ō�Ƀf�[�^�Z�b�g�ɒǉ�����
						ds.table�o�׏�.Rows.Add(tr);
					}
					�o�׏󋵈ꗗ���|�[�g cr = new �o�׏󋵈ꗗ���|�[�g();
					//CrystalReport�Ƀp�����[�^�ƃf�[�^�Z�b�g��n��
					cr.SetDataSource(ds);

					//�v���r���[�\��
// MOD 2007.02.06 ���s�j���� �v���r���[��ʂ̍����� START
//					�v���r���[��� ��� = new �v���r���[���();
//					���.Left = this.Left;
//					���.Top = this.Top;
//					���.crv���[.PrintReport();
//					���.crv���[.ReportSource = cr;
//					���.ShowDialog();
					if(g�v���r�� == null) g�v���r�� = new �v���r���[���();
					g�v���r��.Left = this.Left;
					g�v���r��.Top = this.Top;
//					g�v���r��.crv���[.PrintReport();
					g�v���r��.crv���[.ReportSource = cr;
					g�v���r��.ShowDialog();
// MOD 2007.02.06 ���s�j���� �v���r���[��ʂ̍����� END

				}
				else
				{
					if(sList[0].Equals("�Y���f�[�^������܂���"))
					{
						tex���b�Z�[�W.Text = "";
						�r�[�v��();
						MessageBox.Show("�Y���f�[�^������܂���","�o�׏󋵈ꗗ�o��",MessageBoxButtons.OK);
					}
					else
					{
						�r�[�v��();
						tex���b�Z�[�W.Text = sList[0];
					}
				}
			}
			catch (System.Net.WebException)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				tex���b�Z�[�W.Text = gs�ʐM�G���[;
			}
			catch(Exception ex)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				tex���b�Z�[�W.Text = ex.Message;
			}
			tex���b�Z�[�W.Text = "";
		}

// ADD 2007.02.16 ���s�j���� �����t�H�[�J�X�̕ύX START
		private void �o�׏�_Activated(object sender, System.EventArgs e)
		{
			if(tex�J�n�n��R�[�h.Visible == false)
				dt�J�n���t.Focus();
		}
// ADD 2007.02.16 ���s�j���� �����t�H�[�J�X�̕ύX END
	}
}
