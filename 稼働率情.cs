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
	public class �ғ����� : ���ʃt�H�[��
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lab�ғ�����^�C�g��;
		private System.Windows.Forms.Button btn�b�r�u�o��;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label lab�n��R�[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�J�n�n��R�[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�I���n��R�[�h;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lab�X��;
		private System.Windows.Forms.Label label3;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�J�n�X���R�[�h;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�I���X���R�[�h;
		private System.Windows.Forms.Label lab�o�ד�;
		private System.Windows.Forms.NumericUpDown n�o�הN;
		private System.Windows.Forms.NumericUpDown n�o�׌�;
		private System.Windows.Forms.RadioButton rb�S��;
		private System.Windows.Forms.RadioButton rb�f���@������;
		private System.ComponentModel.IContainer components = null;

		public �ғ�����()
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
			this.rb�f���@������ = new System.Windows.Forms.RadioButton();
			this.rb�S�� = new System.Windows.Forms.RadioButton();
			this.n�o�׌� = new System.Windows.Forms.NumericUpDown();
			this.n�o�הN = new System.Windows.Forms.NumericUpDown();
			this.lab�o�ד� = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tex�J�n�X���R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�I���X���R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.lab�X�� = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lab�n��R�[�h = new System.Windows.Forms.Label();
			this.tex�J�n�n��R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex�I���n��R�[�h = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.label1 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab�ғ�����^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn�b�r�u�o�� = new System.Windows.Forms.Button();
			this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
			this.btn���� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.n�o�׌�)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n�o�הN)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.rb�f���@������);
			this.panel1.Controls.Add(this.rb�S��);
			this.panel1.Controls.Add(this.n�o�׌�);
			this.panel1.Controls.Add(this.n�o�הN);
			this.panel1.Controls.Add(this.lab�o�ד�);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.tex�J�n�X���R�[�h);
			this.panel1.Controls.Add(this.tex�I���X���R�[�h);
			this.panel1.Controls.Add(this.lab�X��);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.lab�n��R�[�h);
			this.panel1.Controls.Add(this.tex�J�n�n��R�[�h);
			this.panel1.Controls.Add(this.tex�I���n��R�[�h);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(370, 176);
			this.panel1.TabIndex = 1;
			// 
			// rb�f���@������
			// 
			this.rb�f���@������.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rb�f���@������.Location = new System.Drawing.Point(184, 140);
			this.rb�f���@������.Name = "rb�f���@������";
			this.rb�f���@������.Size = new System.Drawing.Size(106, 24);
			this.rb�f���@������.TabIndex = 11;
			this.rb�f���@������.Text = "�f���@������";
			// 
			// rb�S��
			// 
			this.rb�S��.Checked = true;
			this.rb�S��.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rb�S��.Location = new System.Drawing.Point(120, 140);
			this.rb�S��.Name = "rb�S��";
			this.rb�S��.Size = new System.Drawing.Size(60, 24);
			this.rb�S��.TabIndex = 10;
			this.rb�S��.TabStop = true;
			this.rb�S��.Text = "�S��";
			// 
			// n�o�׌�
			// 
			this.n�o�׌�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.n�o�׌�.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.n�o�׌�.Location = new System.Drawing.Point(180, 100);
			this.n�o�׌�.Maximum = new System.Decimal(new int[] {
																 13,
																 0,
																 0,
																 0});
			this.n�o�׌�.Name = "n�o�׌�";
			this.n�o�׌�.ReadOnly = true;
			this.n�o�׌�.Size = new System.Drawing.Size(44, 23);
			this.n�o�׌�.TabIndex = 9;
			this.n�o�׌�.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.n�o�׌�.Value = new System.Decimal(new int[] {
															   12,
															   0,
															   0,
															   0});
			this.n�o�׌�.ValueChanged += new System.EventHandler(this.n�o�׌�_ValueChanged);
			// 
			// n�o�הN
			// 
			this.n�o�הN.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.n�o�הN.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.n�o�הN.Location = new System.Drawing.Point(118, 100);
			this.n�o�הN.Maximum = new System.Decimal(new int[] {
																 2006,
																 0,
																 0,
																 0});
			this.n�o�הN.Minimum = new System.Decimal(new int[] {
																 2006,
																 0,
																 0,
																 0});
			this.n�o�הN.Name = "n�o�הN";
			this.n�o�הN.ReadOnly = true;
			this.n�o�הN.Size = new System.Drawing.Size(60, 23);
			this.n�o�הN.TabIndex = 8;
			this.n�o�הN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.n�o�הN.Value = new System.Decimal(new int[] {
															   2006,
															   0,
															   0,
															   0});
			// 
			// lab�o�ד�
			// 
			this.lab�o�ד�.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�o�ד�.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�o�ד�.Location = new System.Drawing.Point(36, 102);
			this.lab�o�ד�.Name = "lab�o�ד�";
			this.lab�o�ד�.Size = new System.Drawing.Size(76, 18);
			this.lab�o�ד�.TabIndex = 71;
			this.lab�o�ד�.Text = "�o�הN��";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label3.ForeColor = System.Drawing.Color.LimeGreen;
			this.label3.Location = new System.Drawing.Point(152, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 16);
			this.label3.TabIndex = 70;
			this.label3.Text = "�`";
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
			this.lab�X��.TabIndex = 67;
			this.lab�X��.Text = "�X���R�[�h";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.LimeGreen;
			this.label4.Location = new System.Drawing.Point(152, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "�`";
			// 
			// lab�n��R�[�h
			// 
			this.lab�n��R�[�h.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�n��R�[�h.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�n��R�[�h.Location = new System.Drawing.Point(36, 26);
			this.lab�n��R�[�h.Name = "lab�n��R�[�h";
			this.lab�n��R�[�h.Size = new System.Drawing.Size(76, 18);
			this.lab�n��R�[�h.TabIndex = 65;
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
			this.panel7.Controls.Add(this.lab�ғ�����^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(792, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab�ғ�����^�C�g��
			// 
			this.lab�ғ�����^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab�ғ�����^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�ғ�����^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab�ғ�����^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab�ғ�����^�C�g��.Name = "lab�ғ�����^�C�g��";
			this.lab�ғ�����^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab�ғ�����^�C�g��.TabIndex = 0;
			this.lab�ғ�����^�C�g��.Text = "�ғ��������\�o��";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btn�b�r�u�o��);
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
			this.btn�b�r�u�o��.Location = new System.Drawing.Point(76, 6);
			this.btn�b�r�u�o��.Name = "btn�b�r�u�o��";
			this.btn�b�r�u�o��.Size = new System.Drawing.Size(54, 48);
			this.btn�b�r�u�o��.TabIndex = 2;
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
			// �ғ�����
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
			this.Name = "�ғ�����";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 �ғ��������\�o��";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.�ғ�����_Load);
			this.Closed += new System.EventHandler(this.�ғ�����_Closed);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.n�o�׌�)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n�o�הN)).EndInit();
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
// MOD 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� START
//			dt�J�n���t.Value = new DateTime(System.DateTime.Now.Year, 
//											System.DateTime.Now.Month, 1);
//			dt�I�����t.Value = System.DateTime.Now;
////			dt�I�����t.Value = System.DateTime.Now.AddDays(-1); // �f�t�H���g��O���ɂ���
////			dt�J�n���t.Value = new DateTime(dt�I�����t.Value.Year, 
////											dt�I�����t.Value.Month, 1);
			//�O���P���`����
			int iYear  = System.DateTime.Now.Year;
			int iMonth = System.DateTime.Now.Month;
			if(iMonth == 1)
			{
				iYear--;
				iMonth = 12;
			}
			else
			{
				iMonth--;
			}
			DateTime dt�O�� = new DateTime(iYear, iMonth, 1);
// MOD 2007.02.02 ���s�j���� �����w��̕ύX START
//			dt�J�n���t.Value = dt�O��;
//			dt�I�����t.Value = dt�O��.AddMonths(1).AddDays(-1);
//			dt�J�n���t.Enabled = false;
//			dt�I�����t.Enabled = false;
			//�Q�O�O�V�N�P�����ߋ��̃f�[�^�́~
			n�o�הN.Minimum = 2007;
			n�o�הN.Maximum = dt�O��.Year; // System.DateTime.Now.Year;
// MOD 2007.02.02 ���s�j���� �����w��̕ύX END
			n�o�הN.Value = dt�O��.Year;
			n�o�׌�.Value = dt�O��.Month;
// MOD 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� END
			tex���b�Z�[�W.Text = "";
		}

		private void �ғ�����_Load(object sender, System.EventArgs e)
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
				n�o�הN.Focus();
			}
// ADD 2007.02.16 ���s�j���� �����t�H�[�J�X�̕ύX END
		}

		private void �ғ�����_Closed(object sender, System.EventArgs e)
		{
			���ڃN���A();
// MOD 2007.02.16 ���s�j���� �����t�H�[�J�X�̕ύX START
//// MOD 2007.02.02 ���s�j���� �����w��̕ύX START
////			dt�J�n���t.Focus();
//			n�o�הN.Focus();
//// MOD 2007.02.02 ���s�j���� �����w��̕ύX END
			tex�J�n�n��R�[�h.Text = " ";
			tex�J�n�n��R�[�h.Focus();
// MOD 2007.02.16 ���s�j���� �����t�H�[�J�X�̕ύX END
		}

		private void btn�b�r�u�o��_Click(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W.Text = "";
// MOD 2007.02.02 ���s�j���� �����w��̕ύX START
//			if (dt�J�n���t.Value > dt�I�����t.Value)
//			{
//				MessageBox.Show("���t�͈̔͂����������͂���Ă��܂���","���̓`�F�b�N",MessageBoxButtons.OK );
//				dt�J�n���t.Focus();
//				return;
//			}
//
//			string s�J�n���t = YYYYMMDD�ϊ�(dt�J�n���t.Value);
//			string s�I�����t = YYYYMMDD�ϊ�(dt�I�����t.Value);

			//�����ȍ~�̂��̂��o�͂��悤�Ƃ�����
			if(n�o�הN.Value == System.DateTime.Now.Year
					&& n�o�׌�.Value >= System.DateTime.Now.Month)
			{
				MessageBox.Show("�o�הN�������������͂���Ă��܂���\n�i�O���܂Ŏw��j",
					"���̓`�F�b�N",MessageBoxButtons.OK );
				n�o�׌�.Focus();
				return;
			}

			string s�J�n���t = n�o�הN.Value.ToString();
			if(n�o�׌�.Value < 10) s�J�n���t += "0";
			s�J�n���t += n�o�׌�.Value + "01";
			string s�I�����t = "";
// MOD 2007.02.02 ���s�j���� �����w��̕ύX END
// MOD 2007.10.11 ���s�j���� �f���@�������@�\�̒ǉ� START
			string s�f���@������ = "";
			if(rb�f���@������.Checked) s�f���@������ = "1";
// MOD 2007.10.11 ���s�j���� �f���@�������@�\�̒ǉ� END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sList = new string[2]{"",""};
// MOD 2007.10.11 ���s�j���� �f���@�������@�\�̒ǉ� START
//				string[] sData = new string[6]{
//									tex�J�n�n��R�[�h.Text.Trim(),
//									tex�I���n��R�[�h.Text.Trim(),
//									tex�J�n�X���R�[�h.Text.Trim(),
//									tex�I���X���R�[�h.Text.Trim(),
//									s�J�n���t,
//									s�I�����t
//								};
				string[] sData = new string[7]{
									tex�J�n�n��R�[�h.Text.Trim(),
									tex�I���n��R�[�h.Text.Trim(),
									tex�J�n�X���R�[�h.Text.Trim(),
									tex�I���X���R�[�h.Text.Trim(),
									s�J�n���t,
									s�I�����t,
									s�f���@������
								};
// MOD 2007.10.11 ���s�j���� �f���@�������@�\�̒ǉ� END

				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
// 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� START
//				sList = sv_maintenance.Get_kadouritu_csv(gsa���[�U, sData);
				sList = sv_maintenance.Get_kadouritu_csv2(gsa���[�U, sData);
// 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� END
				this.Cursor = System.Windows.Forms.Cursors.Default;

				if(sList[0].Length == 4)
				{
// 2006.10.02 ���s�j�R�{�@�b�r�u�o�͎��Ɍ��o���s���o�͂��Ȃ��悤�ɂ���B�@DEL START
//					sList[0] = "\"�n��b�c\",\"�X���b�c\",\"�X����\","
//					sList[0] = "\"�n��P�b�c\",\"�n��Q�b�c\",\"�n��P����\",\"�n��Q����\",\"�X���b�c\",\"�X����\","
//						+ "\"�����䐔\",\"�ғ��䐔\",\"�ғ���\""
//					;
// 2006.10.02 ���s�j�R�{�@�b�r�u�o�͎��Ɍ��o���s���o�͂��Ȃ��悤�ɂ���B�@DEL END

					// �f�t�H���g�̃t�H���_���f�X�N�g�b�v�t�H���_�ɂ���
					saveFileDialog1.InitialDirectory
						= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
					saveFileDialog1.Filter = "�b�r�u�t�@�C�� (*.csv)|*.csv";
					byte[] bSJIS;
					if(saveFileDialog1.ShowDialog(this) == DialogResult.OK)
					{
						System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
//						for(int iCnt = 0; iCnt < sList.Length; iCnt++)
						for(int iCnt = 1; iCnt < sList.Length; iCnt++)
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
						MessageBox.Show("�Y���f�[�^������܂���","�ғ������o��",MessageBoxButtons.OK);
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

// ADD 2007.02.02 ���s�j���� �����w��̕ύX START
		private void n�o�׌�_ValueChanged(object sender, System.EventArgs e)
		{
			if(n�o�׌�.Value == 0)
			{
				n�o�׌�.Value = 12;
				if(n�o�הN.Value > n�o�הN.Minimum) n�o�הN.Value--;
				return;
			}
			if(n�o�׌�.Value == 13)
			{
				n�o�׌�.Value = 1;
				if(n�o�הN.Value < n�o�הN.Maximum) n�o�הN.Value++;
				return;
			}
		}
// ADD 2007.02.02 ���s�j���� �����w��̕ύX END

// DEL 2007.02.02 ���s�j���� �����w��̕ύX START
//// ADD 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� START
//		private void dt�J�n���t_ValueChanged(object sender, System.EventArgs e)
//		{
//			dt�J�n���t.Value = new DateTime(dt�J�n���t.Value.Year, 
//				dt�J�n���t.Value.Month, 1);
//
//			//�O���̓��t�̔N�ƌ����ꏏ�̏ꍇ
//			DateTime da�O�� = System.DateTime.Now.AddDays(-1);
//			if(dt�J�n���t.Value.Year == da�O��.Year
//			 && dt�J�n���t.Value.Month == da�O��.Month)
//			{
//				//�O��
//				dt�I�����t.Value = da�O��;
//			}
//			else
//			{
//				//�O���̖���
//				dt�I�����t.Value = dt�J�n���t.Value.AddMonths(1).AddDays(-1);
//			}
//		}
//
//		private void n�o�הN_ValueChanged(object sender, System.EventArgs e)
//		{
//			dt�J�n���t.Value = new DateTime(int.Parse(n�o�הN.Value.ToString()), 
//				int.Parse(n�o�׌�.Value.ToString()), 1);
//		
//			//����
//			dt�I�����t.Value = dt�J�n���t.Value.AddMonths(1).AddDays(-1);
//		}
//
//		private void n�o�׌�_ValueChanged(object sender, System.EventArgs e)
//		{
//			dt�J�n���t.Value = new DateTime(int.Parse(n�o�הN.Value.ToString()), 
//				int.Parse(n�o�׌�.Value.ToString()), 1);
//
//			//����
//			dt�I�����t.Value = dt�J�n���t.Value.AddMonths(1).AddDays(-1);
//		}
//// ADD 2006.10.20 ���s�j���� �ꗗ�\�쐬�̈ꕔ�o�b�`�� END
// DEL 2007.02.02 ���s�j���� �����w��̕ύX END

	}
}
