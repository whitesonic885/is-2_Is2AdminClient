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
	public class �ғ����o�^ : ���ʃt�H�[��
	{
		private static Color color����   = Color.Honeydew;
		private static Color color�x��   = Color.LightPink;
		private static Color color���̑� = Color.LightBlue;
		private static Color color�x�����̑� = Color.Plum;
		private DateTime dt�J�n��;
		private DateTime dt�I����;
		private int      i�J�n�ʒu;
		private char[]   c�ғ���;		
		private char[]   c���̑�;		
		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label lab���b�Z�[�W�^�C�g��;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn�ۑ�;
		private System.Windows.Forms.Button btn11;
		private System.Windows.Forms.Button btn�O��;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn67;
		private System.Windows.Forms.Button btn66;
		private System.Windows.Forms.Button btn65;
		private System.Windows.Forms.Button btn64;
		private System.Windows.Forms.Button btn63;
		private System.Windows.Forms.Button btn62;
		private System.Windows.Forms.Button btn61;
		private System.Windows.Forms.Button btn57;
		private System.Windows.Forms.Button btn56;
		private System.Windows.Forms.Button btn55;
		private System.Windows.Forms.Button btn54;
		private System.Windows.Forms.Button btn53;
		private System.Windows.Forms.Button btn52;
		private System.Windows.Forms.Button btn51;
		private System.Windows.Forms.Button btn47;
		private System.Windows.Forms.Button btn46;
		private System.Windows.Forms.Button btn45;
		private System.Windows.Forms.Button btn44;
		private System.Windows.Forms.Button btn43;
		private System.Windows.Forms.Button btn42;
		private System.Windows.Forms.Button btn41;
		private System.Windows.Forms.Button btn37;
		private System.Windows.Forms.Button btn36;
		private System.Windows.Forms.Button btn35;
		private System.Windows.Forms.Button btn34;
		private System.Windows.Forms.Button btn33;
		private System.Windows.Forms.Button btn32;
		private System.Windows.Forms.Button btn31;
		private System.Windows.Forms.Button btn27;
		private System.Windows.Forms.Button btn26;
		private System.Windows.Forms.Button btn25;
		private System.Windows.Forms.Button btn24;
		private System.Windows.Forms.Button btn23;
		private System.Windows.Forms.Button btn22;
		private System.Windows.Forms.Button btn21;
		private System.Windows.Forms.Button btn17;
		private System.Windows.Forms.Button btn16;
		private System.Windows.Forms.Button btn15;
		private System.Windows.Forms.Button btn14;
		private System.Windows.Forms.Button btn13;
		private System.Windows.Forms.Button btn12;
		private System.Windows.Forms.Label lab����;
		private System.Windows.Forms.Label lab�N�N;
		private System.Windows.Forms.Label lab�N;
		private System.Windows.Forms.Label lab��;
		private System.Windows.Forms.RadioButton rb�x��;
		private System.Windows.Forms.RadioButton rb���̑�;
		private System.Windows.Forms.Label lab�y�j��;
		private System.Windows.Forms.Label lab���j��;
		private System.Windows.Forms.Label lab�ؗj��;
		private System.Windows.Forms.Label lab���j��;
		private System.Windows.Forms.Label lab�Ηj��;
		private System.Windows.Forms.Label lab���j��;
		private System.Windows.Forms.Label lab���j��;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public �ғ����o�^()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(�ғ����o�^));
			this.panel1 = new System.Windows.Forms.Panel();
			this.rb���̑� = new System.Windows.Forms.RadioButton();
			this.rb�x�� = new System.Windows.Forms.RadioButton();
			this.lab�� = new System.Windows.Forms.Label();
			this.lab�N = new System.Windows.Forms.Label();
			this.btn���� = new System.Windows.Forms.Button();
			this.btn�O�� = new System.Windows.Forms.Button();
			this.lab���� = new System.Windows.Forms.Label();
			this.lab�N�N = new System.Windows.Forms.Label();
			this.btn67 = new System.Windows.Forms.Button();
			this.btn66 = new System.Windows.Forms.Button();
			this.btn65 = new System.Windows.Forms.Button();
			this.btn64 = new System.Windows.Forms.Button();
			this.btn63 = new System.Windows.Forms.Button();
			this.btn62 = new System.Windows.Forms.Button();
			this.btn61 = new System.Windows.Forms.Button();
			this.btn57 = new System.Windows.Forms.Button();
			this.btn56 = new System.Windows.Forms.Button();
			this.btn55 = new System.Windows.Forms.Button();
			this.btn54 = new System.Windows.Forms.Button();
			this.btn53 = new System.Windows.Forms.Button();
			this.btn52 = new System.Windows.Forms.Button();
			this.btn51 = new System.Windows.Forms.Button();
			this.btn47 = new System.Windows.Forms.Button();
			this.btn46 = new System.Windows.Forms.Button();
			this.btn45 = new System.Windows.Forms.Button();
			this.btn44 = new System.Windows.Forms.Button();
			this.btn43 = new System.Windows.Forms.Button();
			this.btn42 = new System.Windows.Forms.Button();
			this.btn41 = new System.Windows.Forms.Button();
			this.btn37 = new System.Windows.Forms.Button();
			this.btn36 = new System.Windows.Forms.Button();
			this.btn35 = new System.Windows.Forms.Button();
			this.btn34 = new System.Windows.Forms.Button();
			this.btn33 = new System.Windows.Forms.Button();
			this.btn32 = new System.Windows.Forms.Button();
			this.btn31 = new System.Windows.Forms.Button();
			this.btn27 = new System.Windows.Forms.Button();
			this.btn26 = new System.Windows.Forms.Button();
			this.btn25 = new System.Windows.Forms.Button();
			this.btn24 = new System.Windows.Forms.Button();
			this.btn23 = new System.Windows.Forms.Button();
			this.btn22 = new System.Windows.Forms.Button();
			this.btn21 = new System.Windows.Forms.Button();
			this.lab�y�j�� = new System.Windows.Forms.Label();
			this.lab���j�� = new System.Windows.Forms.Label();
			this.lab�ؗj�� = new System.Windows.Forms.Label();
			this.lab���j�� = new System.Windows.Forms.Label();
			this.lab�Ηj�� = new System.Windows.Forms.Label();
			this.lab���j�� = new System.Windows.Forms.Label();
			this.btn17 = new System.Windows.Forms.Button();
			this.btn16 = new System.Windows.Forms.Button();
			this.btn15 = new System.Windows.Forms.Button();
			this.btn14 = new System.Windows.Forms.Button();
			this.btn13 = new System.Windows.Forms.Button();
			this.btn12 = new System.Windows.Forms.Button();
			this.btn11 = new System.Windows.Forms.Button();
			this.lab���j�� = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab���b�Z�[�W�^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn�ۑ� = new System.Windows.Forms.Button();
			this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
			this.btn���� = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.rb���̑�);
			this.panel1.Controls.Add(this.rb�x��);
			this.panel1.Controls.Add(this.lab��);
			this.panel1.Controls.Add(this.lab�N);
			this.panel1.Controls.Add(this.btn����);
			this.panel1.Controls.Add(this.btn�O��);
			this.panel1.Controls.Add(this.lab����);
			this.panel1.Controls.Add(this.lab�N�N);
			this.panel1.Controls.Add(this.btn67);
			this.panel1.Controls.Add(this.btn66);
			this.panel1.Controls.Add(this.btn65);
			this.panel1.Controls.Add(this.btn64);
			this.panel1.Controls.Add(this.btn63);
			this.panel1.Controls.Add(this.btn62);
			this.panel1.Controls.Add(this.btn61);
			this.panel1.Controls.Add(this.btn57);
			this.panel1.Controls.Add(this.btn56);
			this.panel1.Controls.Add(this.btn55);
			this.panel1.Controls.Add(this.btn54);
			this.panel1.Controls.Add(this.btn53);
			this.panel1.Controls.Add(this.btn52);
			this.panel1.Controls.Add(this.btn51);
			this.panel1.Controls.Add(this.btn47);
			this.panel1.Controls.Add(this.btn46);
			this.panel1.Controls.Add(this.btn45);
			this.panel1.Controls.Add(this.btn44);
			this.panel1.Controls.Add(this.btn43);
			this.panel1.Controls.Add(this.btn42);
			this.panel1.Controls.Add(this.btn41);
			this.panel1.Controls.Add(this.btn37);
			this.panel1.Controls.Add(this.btn36);
			this.panel1.Controls.Add(this.btn35);
			this.panel1.Controls.Add(this.btn34);
			this.panel1.Controls.Add(this.btn33);
			this.panel1.Controls.Add(this.btn32);
			this.panel1.Controls.Add(this.btn31);
			this.panel1.Controls.Add(this.btn27);
			this.panel1.Controls.Add(this.btn26);
			this.panel1.Controls.Add(this.btn25);
			this.panel1.Controls.Add(this.btn24);
			this.panel1.Controls.Add(this.btn23);
			this.panel1.Controls.Add(this.btn22);
			this.panel1.Controls.Add(this.btn21);
			this.panel1.Controls.Add(this.lab�y�j��);
			this.panel1.Controls.Add(this.lab���j��);
			this.panel1.Controls.Add(this.lab�ؗj��);
			this.panel1.Controls.Add(this.lab���j��);
			this.panel1.Controls.Add(this.lab�Ηj��);
			this.panel1.Controls.Add(this.lab���j��);
			this.panel1.Controls.Add(this.btn17);
			this.panel1.Controls.Add(this.btn16);
			this.panel1.Controls.Add(this.btn15);
			this.panel1.Controls.Add(this.btn14);
			this.panel1.Controls.Add(this.btn13);
			this.panel1.Controls.Add(this.btn12);
			this.panel1.Controls.Add(this.btn11);
			this.panel1.Controls.Add(this.lab���j��);
			this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel1.Location = new System.Drawing.Point(4, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(774, 442);
			this.panel1.TabIndex = 0;
			// 
			// rb���̑�
			// 
			this.rb���̑�.BackColor = System.Drawing.Color.LightBlue;
			this.rb���̑�.Location = new System.Drawing.Point(660, 112);
			this.rb���̑�.Name = "rb���̑�";
			this.rb���̑�.Size = new System.Drawing.Size(64, 23);
			this.rb���̑�.TabIndex = 120;
			this.rb���̑�.Text = "���̑�";
			// 
			// rb�x��
			// 
			this.rb�x��.BackColor = System.Drawing.Color.LightPink;
			this.rb�x��.Checked = true;
			this.rb�x��.Location = new System.Drawing.Point(660, 84);
			this.rb�x��.Name = "rb�x��";
			this.rb�x��.Size = new System.Drawing.Size(64, 23);
			this.rb�x��.TabIndex = 119;
			this.rb�x��.TabStop = true;
			this.rb�x��.Text = "�x�@��";
			// 
			// lab��
			// 
			this.lab��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab��.ForeColor = System.Drawing.Color.Black;
			this.lab��.Location = new System.Drawing.Point(346, 20);
			this.lab��.Name = "lab��";
			this.lab��.Size = new System.Drawing.Size(22, 20);
			this.lab��.TabIndex = 116;
			this.lab��.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab�N
			// 
			this.lab�N.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�N.ForeColor = System.Drawing.Color.Black;
			this.lab�N.Location = new System.Drawing.Point(262, 20);
			this.lab�N.Name = "lab�N";
			this.lab�N.Size = new System.Drawing.Size(48, 20);
			this.lab�N.TabIndex = 115;
			this.lab�N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn����
			// 
			this.btn����.Location = new System.Drawing.Point(462, 18);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(50, 24);
			this.btn����.TabIndex = 0;
			this.btn����.Text = "�� ��";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// btn�O��
			// 
			this.btn�O��.Location = new System.Drawing.Point(404, 18);
			this.btn�O��.Name = "btn�O��";
			this.btn�O��.Size = new System.Drawing.Size(50, 24);
			this.btn�O��.TabIndex = 43;
			this.btn�O��.Text = "�O ��";
			this.btn�O��.Click += new System.EventHandler(this.btn�O��_Click);
			// 
			// lab����
			// 
			this.lab����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab����.ForeColor = System.Drawing.Color.Black;
			this.lab����.Location = new System.Drawing.Point(370, 20);
			this.lab����.Name = "lab����";
			this.lab����.Size = new System.Drawing.Size(22, 20);
			this.lab����.TabIndex = 107;
			this.lab����.Text = "��";
			this.lab����.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab�N�N
			// 
			this.lab�N�N.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�N�N.ForeColor = System.Drawing.Color.Black;
			this.lab�N�N.Location = new System.Drawing.Point(312, 20);
			this.lab�N�N.Name = "lab�N�N";
			this.lab�N�N.Size = new System.Drawing.Size(22, 20);
			this.lab�N�N.TabIndex = 106;
			this.lab�N�N.Text = "�N";
			this.lab�N�N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn67
			// 
			this.btn67.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn67.Location = new System.Drawing.Point(570, 374);
			this.btn67.Name = "btn67";
			this.btn67.Size = new System.Drawing.Size(66, 52);
			this.btn67.TabIndex = 42;
			// 
			// btn66
			// 
			this.btn66.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn66.Location = new System.Drawing.Point(498, 374);
			this.btn66.Name = "btn66";
			this.btn66.Size = new System.Drawing.Size(66, 52);
			this.btn66.TabIndex = 41;
			// 
			// btn65
			// 
			this.btn65.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn65.Location = new System.Drawing.Point(426, 374);
			this.btn65.Name = "btn65";
			this.btn65.Size = new System.Drawing.Size(66, 52);
			this.btn65.TabIndex = 40;
			// 
			// btn64
			// 
			this.btn64.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn64.Location = new System.Drawing.Point(354, 374);
			this.btn64.Name = "btn64";
			this.btn64.Size = new System.Drawing.Size(66, 52);
			this.btn64.TabIndex = 39;
			// 
			// btn63
			// 
			this.btn63.BackColor = System.Drawing.Color.Plum;
			this.btn63.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn63.Location = new System.Drawing.Point(282, 374);
			this.btn63.Name = "btn63";
			this.btn63.Size = new System.Drawing.Size(66, 52);
			this.btn63.TabIndex = 38;
			// 
			// btn62
			// 
			this.btn62.BackColor = System.Drawing.Color.LightBlue;
			this.btn62.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn62.Location = new System.Drawing.Point(210, 374);
			this.btn62.Name = "btn62";
			this.btn62.Size = new System.Drawing.Size(66, 52);
			this.btn62.TabIndex = 37;
			// 
			// btn61
			// 
			this.btn61.BackColor = System.Drawing.Color.LightPink;
			this.btn61.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn61.Location = new System.Drawing.Point(138, 374);
			this.btn61.Name = "btn61";
			this.btn61.Size = new System.Drawing.Size(66, 52);
			this.btn61.TabIndex = 36;
			// 
			// btn57
			// 
			this.btn57.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn57.Location = new System.Drawing.Point(570, 316);
			this.btn57.Name = "btn57";
			this.btn57.Size = new System.Drawing.Size(66, 52);
			this.btn57.TabIndex = 35;
			// 
			// btn56
			// 
			this.btn56.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn56.Location = new System.Drawing.Point(498, 316);
			this.btn56.Name = "btn56";
			this.btn56.Size = new System.Drawing.Size(66, 52);
			this.btn56.TabIndex = 34;
			// 
			// btn55
			// 
			this.btn55.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn55.Location = new System.Drawing.Point(426, 316);
			this.btn55.Name = "btn55";
			this.btn55.Size = new System.Drawing.Size(66, 52);
			this.btn55.TabIndex = 33;
			// 
			// btn54
			// 
			this.btn54.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn54.Location = new System.Drawing.Point(354, 316);
			this.btn54.Name = "btn54";
			this.btn54.Size = new System.Drawing.Size(66, 52);
			this.btn54.TabIndex = 32;
			// 
			// btn53
			// 
			this.btn53.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn53.Location = new System.Drawing.Point(282, 316);
			this.btn53.Name = "btn53";
			this.btn53.Size = new System.Drawing.Size(66, 52);
			this.btn53.TabIndex = 31;
			this.btn53.Text = "31";
			// 
			// btn52
			// 
			this.btn52.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn52.Location = new System.Drawing.Point(210, 316);
			this.btn52.Name = "btn52";
			this.btn52.Size = new System.Drawing.Size(66, 52);
			this.btn52.TabIndex = 30;
			this.btn52.Text = "30";
			// 
			// btn51
			// 
			this.btn51.BackColor = System.Drawing.Color.LightPink;
			this.btn51.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn51.Location = new System.Drawing.Point(138, 316);
			this.btn51.Name = "btn51";
			this.btn51.Size = new System.Drawing.Size(66, 52);
			this.btn51.TabIndex = 29;
			this.btn51.Text = "29";
			// 
			// btn47
			// 
			this.btn47.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn47.Location = new System.Drawing.Point(570, 258);
			this.btn47.Name = "btn47";
			this.btn47.Size = new System.Drawing.Size(66, 52);
			this.btn47.TabIndex = 28;
			this.btn47.Text = "28";
			// 
			// btn46
			// 
			this.btn46.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn46.Location = new System.Drawing.Point(498, 258);
			this.btn46.Name = "btn46";
			this.btn46.Size = new System.Drawing.Size(66, 52);
			this.btn46.TabIndex = 27;
			this.btn46.Text = "27";
			// 
			// btn45
			// 
			this.btn45.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn45.Location = new System.Drawing.Point(426, 258);
			this.btn45.Name = "btn45";
			this.btn45.Size = new System.Drawing.Size(66, 52);
			this.btn45.TabIndex = 26;
			this.btn45.Text = "26";
			// 
			// btn44
			// 
			this.btn44.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn44.Location = new System.Drawing.Point(354, 258);
			this.btn44.Name = "btn44";
			this.btn44.Size = new System.Drawing.Size(66, 52);
			this.btn44.TabIndex = 25;
			this.btn44.Text = "25";
			// 
			// btn43
			// 
			this.btn43.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn43.Location = new System.Drawing.Point(282, 258);
			this.btn43.Name = "btn43";
			this.btn43.Size = new System.Drawing.Size(66, 52);
			this.btn43.TabIndex = 24;
			this.btn43.Text = "24";
			// 
			// btn42
			// 
			this.btn42.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn42.Location = new System.Drawing.Point(210, 258);
			this.btn42.Name = "btn42";
			this.btn42.Size = new System.Drawing.Size(66, 52);
			this.btn42.TabIndex = 23;
			this.btn42.Text = "23";
			// 
			// btn41
			// 
			this.btn41.BackColor = System.Drawing.Color.LightPink;
			this.btn41.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn41.Location = new System.Drawing.Point(138, 258);
			this.btn41.Name = "btn41";
			this.btn41.Size = new System.Drawing.Size(66, 52);
			this.btn41.TabIndex = 22;
			this.btn41.Text = "22";
			// 
			// btn37
			// 
			this.btn37.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn37.Location = new System.Drawing.Point(570, 200);
			this.btn37.Name = "btn37";
			this.btn37.Size = new System.Drawing.Size(66, 52);
			this.btn37.TabIndex = 21;
			this.btn37.Text = "21";
			// 
			// btn36
			// 
			this.btn36.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn36.Location = new System.Drawing.Point(498, 200);
			this.btn36.Name = "btn36";
			this.btn36.Size = new System.Drawing.Size(66, 52);
			this.btn36.TabIndex = 20;
			this.btn36.Text = "20";
			// 
			// btn35
			// 
			this.btn35.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn35.Location = new System.Drawing.Point(426, 200);
			this.btn35.Name = "btn35";
			this.btn35.Size = new System.Drawing.Size(66, 52);
			this.btn35.TabIndex = 19;
			this.btn35.Text = "19";
			// 
			// btn34
			// 
			this.btn34.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn34.Location = new System.Drawing.Point(354, 200);
			this.btn34.Name = "btn34";
			this.btn34.Size = new System.Drawing.Size(66, 52);
			this.btn34.TabIndex = 18;
			this.btn34.Text = "18";
			// 
			// btn33
			// 
			this.btn33.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn33.Location = new System.Drawing.Point(282, 200);
			this.btn33.Name = "btn33";
			this.btn33.Size = new System.Drawing.Size(66, 52);
			this.btn33.TabIndex = 17;
			this.btn33.Text = "17";
			// 
			// btn32
			// 
			this.btn32.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn32.Location = new System.Drawing.Point(210, 200);
			this.btn32.Name = "btn32";
			this.btn32.Size = new System.Drawing.Size(66, 52);
			this.btn32.TabIndex = 16;
			this.btn32.Text = "16";
			// 
			// btn31
			// 
			this.btn31.BackColor = System.Drawing.Color.LightPink;
			this.btn31.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn31.Location = new System.Drawing.Point(138, 200);
			this.btn31.Name = "btn31";
			this.btn31.Size = new System.Drawing.Size(66, 52);
			this.btn31.TabIndex = 15;
			this.btn31.Text = "15";
			// 
			// btn27
			// 
			this.btn27.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn27.Location = new System.Drawing.Point(570, 142);
			this.btn27.Name = "btn27";
			this.btn27.Size = new System.Drawing.Size(66, 52);
			this.btn27.TabIndex = 14;
			this.btn27.Text = "14";
			// 
			// btn26
			// 
			this.btn26.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn26.Location = new System.Drawing.Point(498, 142);
			this.btn26.Name = "btn26";
			this.btn26.Size = new System.Drawing.Size(66, 52);
			this.btn26.TabIndex = 13;
			this.btn26.Text = "13";
			// 
			// btn25
			// 
			this.btn25.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn25.Location = new System.Drawing.Point(426, 142);
			this.btn25.Name = "btn25";
			this.btn25.Size = new System.Drawing.Size(66, 52);
			this.btn25.TabIndex = 12;
			this.btn25.Text = "12";
			// 
			// btn24
			// 
			this.btn24.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn24.Location = new System.Drawing.Point(354, 142);
			this.btn24.Name = "btn24";
			this.btn24.Size = new System.Drawing.Size(66, 52);
			this.btn24.TabIndex = 11;
			this.btn24.Text = "11";
			// 
			// btn23
			// 
			this.btn23.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn23.Location = new System.Drawing.Point(282, 142);
			this.btn23.Name = "btn23";
			this.btn23.Size = new System.Drawing.Size(66, 52);
			this.btn23.TabIndex = 10;
			this.btn23.Text = "10";
			// 
			// btn22
			// 
			this.btn22.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn22.Location = new System.Drawing.Point(210, 142);
			this.btn22.Name = "btn22";
			this.btn22.Size = new System.Drawing.Size(66, 52);
			this.btn22.TabIndex = 9;
			this.btn22.Text = "9";
			// 
			// btn21
			// 
			this.btn21.BackColor = System.Drawing.Color.LightPink;
			this.btn21.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn21.Location = new System.Drawing.Point(138, 142);
			this.btn21.Name = "btn21";
			this.btn21.Size = new System.Drawing.Size(66, 52);
			this.btn21.TabIndex = 8;
			this.btn21.Text = "8";
			// 
			// lab�y�j��
			// 
			this.lab�y�j��.BackColor = System.Drawing.Color.PaleGreen;
			this.lab�y�j��.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�y�j��.ForeColor = System.Drawing.Color.Black;
			this.lab�y�j��.Location = new System.Drawing.Point(570, 60);
			this.lab�y�j��.Name = "lab�y�j��";
			this.lab�y�j��.Size = new System.Drawing.Size(66, 18);
			this.lab�y�j��.TabIndex = 69;
			this.lab�y�j��.Text = "�y";
			this.lab�y�j��.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab���j��
			// 
			this.lab���j��.BackColor = System.Drawing.Color.PaleGreen;
			this.lab���j��.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���j��.ForeColor = System.Drawing.Color.Black;
			this.lab���j��.Location = new System.Drawing.Point(498, 60);
			this.lab���j��.Name = "lab���j��";
			this.lab���j��.Size = new System.Drawing.Size(66, 18);
			this.lab���j��.TabIndex = 68;
			this.lab���j��.Text = "��";
			this.lab���j��.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab�ؗj��
			// 
			this.lab�ؗj��.BackColor = System.Drawing.Color.PaleGreen;
			this.lab�ؗj��.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�ؗj��.ForeColor = System.Drawing.Color.Black;
			this.lab�ؗj��.Location = new System.Drawing.Point(426, 60);
			this.lab�ؗj��.Name = "lab�ؗj��";
			this.lab�ؗj��.Size = new System.Drawing.Size(66, 18);
			this.lab�ؗj��.TabIndex = 67;
			this.lab�ؗj��.Text = "��";
			this.lab�ؗj��.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab���j��
			// 
			this.lab���j��.BackColor = System.Drawing.Color.PaleGreen;
			this.lab���j��.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���j��.ForeColor = System.Drawing.Color.Black;
			this.lab���j��.Location = new System.Drawing.Point(354, 60);
			this.lab���j��.Name = "lab���j��";
			this.lab���j��.Size = new System.Drawing.Size(66, 18);
			this.lab���j��.TabIndex = 66;
			this.lab���j��.Text = "��";
			this.lab���j��.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab�Ηj��
			// 
			this.lab�Ηj��.BackColor = System.Drawing.Color.PaleGreen;
			this.lab�Ηj��.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�Ηj��.ForeColor = System.Drawing.Color.Black;
			this.lab�Ηj��.Location = new System.Drawing.Point(282, 60);
			this.lab�Ηj��.Name = "lab�Ηj��";
			this.lab�Ηj��.Size = new System.Drawing.Size(66, 18);
			this.lab�Ηj��.TabIndex = 65;
			this.lab�Ηj��.Text = "��";
			this.lab�Ηj��.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab���j��
			// 
			this.lab���j��.BackColor = System.Drawing.Color.PaleGreen;
			this.lab���j��.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���j��.ForeColor = System.Drawing.Color.Black;
			this.lab���j��.Location = new System.Drawing.Point(210, 60);
			this.lab���j��.Name = "lab���j��";
			this.lab���j��.Size = new System.Drawing.Size(66, 18);
			this.lab���j��.TabIndex = 64;
			this.lab���j��.Text = "��";
			this.lab���j��.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn17
			// 
			this.btn17.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn17.Location = new System.Drawing.Point(570, 84);
			this.btn17.Name = "btn17";
			this.btn17.Size = new System.Drawing.Size(66, 52);
			this.btn17.TabIndex = 7;
			this.btn17.Text = "7";
			// 
			// btn16
			// 
			this.btn16.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn16.Location = new System.Drawing.Point(498, 84);
			this.btn16.Name = "btn16";
			this.btn16.Size = new System.Drawing.Size(66, 52);
			this.btn16.TabIndex = 6;
			this.btn16.Text = "6";
			// 
			// btn15
			// 
			this.btn15.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn15.Location = new System.Drawing.Point(426, 84);
			this.btn15.Name = "btn15";
			this.btn15.Size = new System.Drawing.Size(66, 52);
			this.btn15.TabIndex = 5;
			this.btn15.Text = "5";
			// 
			// btn14
			// 
			this.btn14.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn14.Location = new System.Drawing.Point(354, 84);
			this.btn14.Name = "btn14";
			this.btn14.Size = new System.Drawing.Size(66, 52);
			this.btn14.TabIndex = 4;
			this.btn14.Text = "4";
			// 
			// btn13
			// 
			this.btn13.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn13.Location = new System.Drawing.Point(282, 84);
			this.btn13.Name = "btn13";
			this.btn13.Size = new System.Drawing.Size(66, 52);
			this.btn13.TabIndex = 3;
			this.btn13.Text = "3";
			// 
			// btn12
			// 
			this.btn12.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn12.Location = new System.Drawing.Point(210, 84);
			this.btn12.Name = "btn12";
			this.btn12.Size = new System.Drawing.Size(66, 52);
			this.btn12.TabIndex = 2;
			this.btn12.Text = "2";
			// 
			// btn11
			// 
			this.btn11.BackColor = System.Drawing.Color.LightPink;
			this.btn11.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn11.Location = new System.Drawing.Point(138, 84);
			this.btn11.Name = "btn11";
			this.btn11.Size = new System.Drawing.Size(66, 52);
			this.btn11.TabIndex = 1;
			this.btn11.Text = "1";
			// 
			// lab���j��
			// 
			this.lab���j��.BackColor = System.Drawing.Color.PaleGreen;
			this.lab���j��.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���j��.ForeColor = System.Drawing.Color.Black;
			this.lab���j��.Location = new System.Drawing.Point(138, 60);
			this.lab���j��.Name = "lab���j��";
			this.lab���j��.Size = new System.Drawing.Size(66, 18);
			this.lab���j��.TabIndex = 56;
			this.lab���j��.Text = "��";
			this.lab���j��.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab���b�Z�[�W�^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(796, 26);
			this.panel7.TabIndex = 0;
			// 
			// lab���b�Z�[�W�^�C�g��
			// 
			this.lab���b�Z�[�W�^�C�g��.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab���b�Z�[�W�^�C�g��.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���b�Z�[�W�^�C�g��.ForeColor = System.Drawing.Color.White;
			this.lab���b�Z�[�W�^�C�g��.Location = new System.Drawing.Point(12, 2);
			this.lab���b�Z�[�W�^�C�g��.Name = "lab���b�Z�[�W�^�C�g��";
			this.lab���b�Z�[�W�^�C�g��.Size = new System.Drawing.Size(264, 24);
			this.lab���b�Z�[�W�^�C�g��.TabIndex = 0;
			this.lab���b�Z�[�W�^�C�g��.Text = "�ғ����o�^";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btn�ۑ�);
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Location = new System.Drawing.Point(0, 518);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(796, 58);
			this.panel8.TabIndex = 2;
			// 
			// btn�ۑ�
			// 
			this.btn�ۑ�.ForeColor = System.Drawing.Color.Blue;
			this.btn�ۑ�.Location = new System.Drawing.Point(76, 6);
			this.btn�ۑ�.Name = "btn�ۑ�";
			this.btn�ۑ�.Size = new System.Drawing.Size(54, 48);
			this.btn�ۑ�.TabIndex = 0;
			this.btn�ۑ�.Text = "�ۑ�";
			this.btn�ۑ�.Click += new System.EventHandler(this.btn�ۑ�_Click);
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(412, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(376, 50);
			this.tex���b�Z�[�W.TabIndex = 2;
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
			this.btn����.TabStop = false;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(796, 26);
			this.panel6.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(8, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(780, 452);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// �ғ����o�^
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 575);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "�ғ����o�^";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 �ғ����o�^";
// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� START
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On�G���^�[�ړ�);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On�G���^�[�L�����Z��);
// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� END
            this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.���b�Z�[�W�o�^_Closed);
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
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
			dt�J�n�� = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

			�J�����_�����\��();
			�ғ������擾();
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn�ۑ�_Click(object sender, System.EventArgs e)
		{
			if(b�O��_Click) return;
			if(b����_Click) return;
			�ғ����X�V();
			if(tex���b�Z�[�W.Text.Length == 0)
			{
				this.Close();
			}
		}

		private void ���b�Z�[�W�o�^_Closed(object sender, System.EventArgs e)
		{
			btn����.Focus();
		}

		private bool b�O��_Click = false;
		private void btn�O��_Click(object sender, System.EventArgs e)
		{
			if(b����_Click) return;
			if(b�O��_Click) return;
			b�O��_Click = true;
			�ғ����X�V();
			dt�J�n�� = dt�J�n��.AddMonths(-1);
			�J�����_�����\��();
			�ғ������擾();
			b�O��_Click = false;
		}

		private bool b����_Click = false;
		private void btn����_Click(object sender, System.EventArgs e)
		{
			if(b�O��_Click) return;
			if(b����_Click) return;
			b����_Click = true;
			�ғ����X�V();
			dt�J�n�� = dt�J�n��.AddMonths(1);
			�J�����_�����\��();
			�ғ������擾();
			b����_Click = false;
		}
		private object[] oBtn���t = null;
		private void ���t�{�^���z��ݒ�(){
			if(oBtn���t != null) return;
			oBtn���t = new object[]{
				btn11, btn12, btn13, btn14, btn15, btn16, btn17
				, btn21, btn22, btn23, btn24, btn25, btn26, btn27
				, btn31, btn32, btn33, btn34, btn35, btn36, btn37
				, btn41, btn42, btn43, btn44, btn45, btn46, btn47
				, btn51, btn52, btn53, btn54, btn55, btn56, btn57
				, btn61, btn62, btn63, btn64, btn65, btn66, btn67
			};
			for(int iCnt = 0; iCnt < oBtn���t.Length; iCnt++){
				((Button)oBtn���t[iCnt]).Click += new System.EventHandler(this.btn_Click);
			}
		}
		private void btn_Click(object sender, System.EventArgs e)
		{
			Button btn = ((Button)sender);
			if(btn.BackColor == color����){
				if(rb�x��.Checked){
					btn.BackColor = color�x��;
				}else{
					btn.BackColor = color���̑�;
				}
			}else if(btn.BackColor == color�x��){
				if(rb�x��.Checked){
					btn.BackColor = color����;
				}else{
					btn.BackColor = color�x�����̑�;
				}
			}else if(btn.BackColor == color���̑�){
				if(rb�x��.Checked){
					btn.BackColor = color�x�����̑�;
				}else{
					btn.BackColor = color����;
				}
			}else if(btn.BackColor == color�x�����̑�){
				if(rb�x��.Checked){
					btn.BackColor = color����;
				}else{
					btn.BackColor = color���̑�;
				}
			}
		}
		private void �J�����_�����\��()
		{
			dt�I���� = dt�J�n��.AddMonths(1).AddDays(-1);
			rb�x��.Checked = true;
			���t�{�^���z��ݒ�();

			lab�N.Text = dt�J�n��.Year.ToString();
			lab��.Text = dt�J�n��.Month.ToString();
			lab�N.Refresh();
			lab��.Refresh();

			int iPos;
			int iCnt;

			//�{�^���̐F�̏����ݒ�
			for(iPos = 0; iPos < oBtn���t.Length; iPos++){
				((Button)oBtn���t[iPos]).BackColor = color����;
			}
			btn11.BackColor = color�x��;
			btn21.BackColor = color�x��;
			btn31.BackColor = color�x��;
			btn41.BackColor = color�x��;
			btn51.BackColor = color�x��;
			btn61.BackColor = color�x��;
			
			//�{�^���̃e�L�X�g�ƕ\���̐ݒ�
			i�J�n�ʒu = �j��(dt�J�n��);
			for(iPos = 0; iPos < i�J�n�ʒu; iPos++){
				((Button)oBtn���t[iPos]).Text = "";
				((Button)oBtn���t[iPos]).Visible = false;
			}
			for(iCnt = 1; iCnt <= dt�I����.Day; iCnt++, iPos++){
				((Button)oBtn���t[iPos]).Text = iCnt.ToString();
				((Button)oBtn���t[iPos]).Visible = true;
			}
			for(; iPos < oBtn���t.Length; iPos++){
				((Button)oBtn���t[iPos]).Text = "";
				((Button)oBtn���t[iPos]).Visible = false;
			}
		}
		private void �ғ������擾()
		{
			string   sRet = "";
			string[] s�ғ��� = {""};
			string[] s���̑� = {""};
			object[] oRet = new object[]{""};
			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				tex���b�Z�[�W.Text = "�ғ������擾���D�D�D";
				if( sv_maintenance == null ) sv_maintenance = new is2maintenance.Service1();
				oRet = sv_maintenance.Get_Kadobi(gsa���[�U, dt�J�n��.ToString("yyyyMMdd")
															, dt�I����.ToString("yyyyMMdd"));
				tex���b�Z�[�W.Text = "";
			}
			catch (System.Net.WebException)
			{
				sRet = gs�ʐM�G���[;
			}
			catch (Exception ex)
			{
				sRet = "�ʐM�G���[�F" + ex.Message;
			}
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;
			sRet = (string)(oRet[0]);

			// �G���[��
			if(sRet.Length != 4)
			{
				�r�[�v��();
				tex���b�Z�[�W.Text = sRet;
				return;
			}
			s�ғ��� = (string[])(oRet[1]);
			s���̑� = (string[])(oRet[2]);

			//�{�^���̐F�ݒ�
			int iPos;
			int iCnt;
			for(iCnt = 1,iPos = i�J�n�ʒu; iCnt <= dt�I����.Day; iCnt++, iPos++){
				if(s�ғ���[iCnt] == "0" && s���̑�[iCnt] == "0"){
					((Button)oBtn���t[iPos]).BackColor = color����;
				}else if(s�ғ���[iCnt] == "1" && s���̑�[iCnt] == "1"){
					((Button)oBtn���t[iPos]).BackColor = color�x�����̑�;
				}else if(s�ғ���[iCnt] == "1"){
					((Button)oBtn���t[iPos]).BackColor = color�x��;
				}else if(s���̑�[iCnt] == "1"){
					((Button)oBtn���t[iPos]).BackColor = color���̑�;
				}else{
					;	//��L�ȊO�͐F��ύX���Ȃ�
				}
			}
		}
		private void �ғ����X�V()
		{
			int iPos;
			int iCnt;

			//�ғ����̒l�擾
			c�ғ��� = new char[dt�I����.Day];
			c���̑� = new char[dt�I����.Day];
			for(iCnt = 0,iPos = i�J�n�ʒu; iCnt < dt�I����.Day; iCnt++, iPos++){
				Color colorBtn = ((Button)oBtn���t[iPos]).BackColor;
				if(colorBtn == color�x�� || colorBtn == color�x�����̑�){
					c�ғ���[iCnt] = '1';
				}else{
					c�ғ���[iCnt] = '0';
				}
				if(colorBtn == color���̑� || colorBtn == color�x�����̑�){
					c���̑�[iCnt] = '1';
				}else{
					c���̑�[iCnt] = '0';
				}
			}

			string[] sRet = {""};
			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				tex���b�Z�[�W.Text = "�ғ����X�V���D�D�D";
				if( sv_maintenance == null ) sv_maintenance = new is2maintenance.Service1();
				sRet = sv_maintenance.Upd_Kadobi(gsa���[�U, dt�J�n��.ToString("yyyyMMdd"), c�ғ���, c���̑�);
				tex���b�Z�[�W.Text = "";
			}
			catch (System.Net.WebException)
			{
				sRet[0] = gs�ʐM�G���[;
			}
			catch (Exception ex)
			{
				sRet[0] = "�ʐM�G���[�F" + ex.Message;
			}
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			// �G���[��
			if(sRet[0].Length != 4)
			{
				�r�[�v��();
				tex���b�Z�[�W.Text = sRet[0];
			}
		}
		private int �j��(DateTime dt)
		{
			switch(dt.DayOfWeek){
				case DayOfWeek.Sunday:
					return 0;
				case DayOfWeek.Monday:
					return 1;
				case DayOfWeek.Tuesday:
					return 2;
				case DayOfWeek.Wednesday:
					return 3;
				case DayOfWeek.Thursday:
					return 4;
				case DayOfWeek.Friday:
					return 5;
				case DayOfWeek.Saturday:
					return 6;
			}
			return -1;
		}
	}
}
