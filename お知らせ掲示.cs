// ADD 2007.11.30 KCL) �X�{ ���m�点�ǉ� START
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace is2AdminClient
{
	/// <summary>
	/// ���m�点�\���t�H�[���̊T�v�̐����ł��B
	/// </summary>
	public class ���m�点�\�� : ���ʃt�H�[��
	{
		/// <summary>
		/// ���I�����̕����F�ł��B
		/// </summary>
		private readonly Color _UnSelectedColor = Color.SeaGreen;
		/// <summary>
		/// ���I�����̕����F�Q�ł��B
		/// </summary>
//		private readonly Color _UnSelectedColor2 = Color.Orange;
//		private readonly Color _UnSelectedColor2 = Color.FromArgb(254, 172, 0);
//		private readonly Color _UnSelectedColor2 = Color.FromArgb(224, 163, 0);
		private readonly Color _UnSelectedColor2 = Color.DarkOrange;

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;		
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lab����;
		private System.Windows.Forms.Label lab���q�l��;
		private System.Windows.Forms.TextBox tex���q�l��;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tex�ڍד��e;
		private System.Windows.Forms.Label lab���m�点�\��;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tex�o�^��;
		private System.Windows.Forms.TextBox tex�\��;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components;

		// �o�^��
		private string _s�o�^�� = string.Empty;
		/// <summary>
		/// ���m�点�̓o�^����ݒ肵�܂��B
		/// </summary>
		public string s�o�^�� 
		{
			set { _s�o�^�� = (value == null) ? string.Empty : value; }
		}
		// �\��
		private string _s�\�� = string.Empty;
		private System.Windows.Forms.Button btn�ڍ�;
		/// <summary>
		/// ���m�点�̕\���ݒ肵�܂��B
		/// </summary>
		public string s�\�� 
		{
			set { _s�\�� = (value == null) ? string.Empty : value; }
		}
		// �ڍד��e
		private string _s�ڍד��e = string.Empty;
		/// <summary>
		/// ���m�点�̏ڍד��e��ݒ肵�܂��B
		/// </summary>
		public string s�ڍד��e 
		{
			set { _s�ڍד��e = (value == null) ? string.Empty : value; }
		}
		// �����F���[�h
		private int _Mode = 0;
		/// <summary>
		/// �����F���[�h��ݒ肵�܂��B
		/// </summary>
		public int i���[�h 
		{
			set
			{
				_Mode = value;
				switch(_Mode){
				case 1:
					tex�o�^��.ForeColor = _UnSelectedColor2;
					tex�\��.ForeColor   = _UnSelectedColor2;
					break;
				default:
					tex�o�^��.ForeColor = _UnSelectedColor;
					tex�\��.ForeColor   = _UnSelectedColor;
					break;
				}
			}
		}
		// �{�^����
		private string _s�{�^���� = string.Empty;
		private System.Windows.Forms.Label lab�F�؉����;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex�F�؉����;
		/// <summary>
		/// �ڍׂ�\������{�^���̃��x����ݒ肵�܂��B
		/// </summary>
		public string s�{�^���� 
		{
			set { _s�{�^���� = (value == null) ? string.Empty : value; }
		}
		// �A�h���X
		private string _s�A�h���X = string.Empty;
		/// <summary>
		/// �ڍ׃f�[�^�̃A�h���X�iURL�j��ݒ肵�܂��B
		/// </summary>
		public string s�A�h���X 
		{
			set { _s�A�h���X = (value == null) ? string.Empty : value; }
		}

		public ���m�点�\��()
		{
			//
			// Windows �t�H�[�� �f�U�C�i �T�|�[�g�ɕK�v�ł��B
			//
			InitializeComponent();
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(���m�点�\��));
			this.panel6 = new System.Windows.Forms.Panel();
			this.lab�F�؉���� = new System.Windows.Forms.Label();
			this.tex�F�؉���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.tex���q�l�� = new System.Windows.Forms.TextBox();
			this.lab���q�l�� = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab���� = new System.Windows.Forms.Label();
			this.lab���m�点�\�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
			this.btn���� = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn�ڍ� = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.tex�\�� = new System.Windows.Forms.TextBox();
			this.tex�o�^�� = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tex�ڍד��e = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Controls.Add(this.lab�F�؉����);
			this.panel6.Controls.Add(this.tex�F�؉����);
			this.panel6.Controls.Add(this.tex���q�l��);
			this.panel6.Controls.Add(this.lab���q�l��);
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(810, 26);
			this.panel6.TabIndex = 12;
			// 
			// lab�F�؉����
			// 
			this.lab�F�؉����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�F�؉����.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�F�؉����.Location = new System.Drawing.Point(16, 8);
			this.lab�F�؉����.Name = "lab�F�؉����";
			this.lab�F�؉����.Size = new System.Drawing.Size(54, 14);
			this.lab�F�؉����.TabIndex = 14;
			this.lab�F�؉����.Text = "���q�l��";
			// 
			// tex�F�؉����
			// 
			this.tex�F�؉����.BackColor = System.Drawing.Color.PaleGreen;
			this.tex�F�؉����.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�F�؉����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�F�؉����.ForeColor = System.Drawing.Color.Green;
			this.tex�F�؉����.Location = new System.Drawing.Point(74, 5);
			this.tex�F�؉����.Name = "tex�F�؉����";
			this.tex�F�؉����.ReadOnly = true;
			this.tex�F�؉����.Size = new System.Drawing.Size(330, 16);
			this.tex�F�؉����.TabIndex = 13;
			this.tex�F�؉����.TabStop = false;
			this.tex�F�؉����.Text = "999 �����x�X";
			// 
			// tex���q�l��
			// 
			this.tex���q�l��.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���q�l��.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex���q�l��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���q�l��.ForeColor = System.Drawing.Color.LimeGreen;
			this.tex���q�l��.Location = new System.Drawing.Point(624, 6);
			this.tex���q�l��.Name = "tex���q�l��";
			this.tex���q�l��.ReadOnly = true;
			this.tex���q�l��.Size = new System.Drawing.Size(162, 16);
			this.tex���q�l��.TabIndex = 12;
			this.tex���q�l��.TabStop = false;
			this.tex���q�l��.Text = "���~�����Q�Q�Q�Q�Q��";
			this.tex���q�l��.Visible = false;
			// 
			// lab���q�l��
			// 
			this.lab���q�l��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���q�l��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���q�l��.Location = new System.Drawing.Point(566, 8);
			this.lab���q�l��.Name = "lab���q�l��";
			this.lab���q�l��.Size = new System.Drawing.Size(52, 14);
			this.lab���q�l��.TabIndex = 11;
			this.lab���q�l��.Text = "���[�U�[";
			this.lab���q�l��.Visible = false;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab����);
			this.panel7.Controls.Add(this.lab���m�点�\��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(792, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab����
			// 
			this.lab����.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab����.ForeColor = System.Drawing.Color.White;
			this.lab����.Location = new System.Drawing.Point(674, 8);
			this.lab����.Name = "lab����";
			this.lab����.Size = new System.Drawing.Size(112, 14);
			this.lab����.TabIndex = 1;
			this.lab����.Text = "2005/xx/xx 12:00:00";
			// 
			// lab���m�点�\��
			// 
			this.lab���m�点�\��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab���m�点�\��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���m�点�\��.ForeColor = System.Drawing.Color.White;
			this.lab���m�点�\��.Location = new System.Drawing.Point(12, 2);
			this.lab���m�点�\��.Name = "lab���m�点�\��";
			this.lab���m�点�\��.Size = new System.Drawing.Size(264, 24);
			this.lab���m�点�\��.TabIndex = 0;
			this.lab���m�点�\��.Text = "���m�点�\��";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 14;
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(456, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(334, 50);
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
			this.btn����.TabIndex = 1;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn�ڍ�);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.tex�\��);
			this.groupBox2.Controls.Add(this.tex�o�^��);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.tex�ڍד��e);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(10, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(770, 440);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			// 
			// btn�ڍ�
			// 
			this.btn�ڍ�.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�ڍ�.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�ڍ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�ڍ�.ForeColor = System.Drawing.Color.White;
			this.btn�ڍ�.Location = new System.Drawing.Point(704, 24);
			this.btn�ڍ�.Name = "btn�ڍ�";
			this.btn�ڍ�.Size = new System.Drawing.Size(48, 22);
			this.btn�ڍ�.TabIndex = 47;
			this.btn�ڍ�.TabStop = false;
			this.btn�ڍ�.Text = "�ڍ�";
			this.btn�ڍ�.Click += new System.EventHandler(this.btn�ڍ�_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(48, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(8, 312);
			this.label3.TabIndex = 46;
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tex�\��
			// 
			this.tex�\��.BackColor = System.Drawing.Color.Honeydew;
			this.tex�\��.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�\��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�\��.ForeColor = System.Drawing.Color.LimeGreen;
			this.tex�\��.Location = new System.Drawing.Point(48, 56);
			this.tex�\��.Name = "tex�\��";
			this.tex�\��.ReadOnly = true;
			this.tex�\��.Size = new System.Drawing.Size(712, 22);
			this.tex�\��.TabIndex = 0;
			this.tex�\��.TabStop = false;
			this.tex�\��.Text = "�\��";
			// 
			// tex�o�^��
			// 
			this.tex�o�^��.BackColor = System.Drawing.Color.Honeydew;
			this.tex�o�^��.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�o�^��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�o�^��.ForeColor = System.Drawing.Color.LimeGreen;
			this.tex�o�^��.Location = new System.Drawing.Point(48, 24);
			this.tex�o�^��.Name = "tex�o�^��";
			this.tex�o�^��.ReadOnly = true;
			this.tex�o�^��.Size = new System.Drawing.Size(136, 22);
			this.tex�o�^��.TabIndex = 0;
			this.tex�o�^��.TabStop = false;
			this.tex�o�^��.Text = "�o�^��";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Lime;
			this.label2.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(48, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(672, 16);
			this.label2.TabIndex = 45;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tex�ڍד��e
			// 
			this.tex�ڍד��e.BackColor = System.Drawing.SystemColors.Window;
			this.tex�ڍד��e.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex�ڍד��e.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex�ڍד��e.Location = new System.Drawing.Point(56, 96);
			this.tex�ڍד��e.MaxLength = 2000;
			this.tex�ڍד��e.Multiline = true;
			this.tex�ڍד��e.Name = "tex�ڍד��e";
			this.tex�ڍד��e.ReadOnly = true;
			this.tex�ڍד��e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tex�ڍד��e.Size = new System.Drawing.Size(664, 310);
			this.tex�ڍד��e.TabIndex = 0;
			this.tex�ڍד��e.TabStop = false;
			this.tex�ڍד��e.Text = "�ڍד��e";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label1.Font = new System.Drawing.Font("�l�r �o�S�V�b�N", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 434);
			this.label1.TabIndex = 44;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ���m�点�\��
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(792, 574);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "���m�点�\��";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ���m�点�\��";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.���m�点�\��_Load);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ���m�点�\��_Load(object sender, System.EventArgs e)
		{
			// �w�b�_�[���ڂ̐ݒ�
			tex�F�؉����.Text = gs�����;
			tex���q�l��.Text = gs���p�Җ�;
//			tex���p����.Text = gs����b�c + " " + gs���喼;

			// �����̏����ݒ�
			lab����.Text		= DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled	= true;

			// ���m�点�\��
			tex�o�^��.Text	= _s�o�^��;
			tex�\��.Text		= _s�\��;
			tex�ڍד��e.Text	= _s�ڍד��e;

			// �ڍ׃{�^���̐ݒ�
			if (_s�A�h���X != string.Empty) 
			{
				// �A�h���X���o�^����Ă���
				// �{�^���̃��x���ݒ�
				if (_s�{�^���� == string.Empty) 
					_s�{�^���� = "�ڍ�";
				btn�ڍ�.Text = _s�{�^����;
				// �{�^���̃T�C�Y�E�\���ʒu����
				int len = _s�{�^����.Length;
				if (len > 2) 
				{
					// �傫���ϒ�
					int diff = (len - 2)*12;
					btn�ڍ�.Size = new Size(48 + diff, 22);
					btn�ڍ�.Location = new Point(704 - diff, 24);
				} 
				else 
				{
					// �f�t�H���g�̑傫���E�ʒu
					btn�ڍ�.Size = new Size(48, 22);
					btn�ڍ�.Location = new Point(704, 24);
				}
				// �{�^���\��
				btn�ڍ�.Visible = true;
			} 
			else 
			{
				// �A�h���X���o�^����Ă��Ȃ�
				// �{�^����\��
				btn�ڍ�.Visible = false;
			}
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			// �ݒ���e�N���A
			_s�o�^��		= string.Empty;
			_s�\��		= string.Empty;
			_s�ڍד��e	= string.Empty;

			// ���̃t�H�[�������	
			this.Close();
		}

		private void btn�ڍ�_Click(object sender, System.EventArgs e)
		{
			// �o�^����Ă���ڍ׃t�@�C���� IE �ŊJ��
			System.Diagnostics.Process.Start("iexplore.exe", _s�A�h���X);
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			// ���t�^���ԕ\��
			lab����.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
		}
	}
}
// ADD 2007.11.30 KCL) �X�{ ���m�点�ǉ� END
