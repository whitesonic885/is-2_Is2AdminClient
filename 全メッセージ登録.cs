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
	public class ���b�Z�[�W�o�^ : ���ʃt�H�[��
	{
		public string s����R�[�h;

		private short    nOldRow    = 0;
		private string   s���b�Z�[�W�R�[�h = "";
		private string   s�X�V���� = "";
		private string[] s���b�Z�[�W�ꗗ;
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
		private System.Windows.Forms.Label lab���b�Z�[�W�^�C�g��;
		private System.Windows.Forms.TextBox tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label lab���b�Z�[�W��;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W��;
		private System.Windows.Forms.Button btn�X�V;
		private System.Windows.Forms.Label lab�Ŕԍ�;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�O��;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmb���b�Z�[�W���;
		private AxGTABLE32V2Lib.AxGTable32 axGT���b�Z�[�W;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ���b�Z�[�W�o�^()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(���b�Z�[�W�o�^));
			this.panel1 = new System.Windows.Forms.Panel();
			this.axGT���b�Z�[�W = new AxGTABLE32V2Lib.AxGTable32();
			this.cmb���b�Z�[�W��� = new System.Windows.Forms.ComboBox();
			this.lab�Ŕԍ� = new System.Windows.Forms.Label();
			this.btn���� = new System.Windows.Forms.Button();
			this.btn�O�� = new System.Windows.Forms.Button();
			this.btn�X�V = new System.Windows.Forms.Button();
			this.lab���b�Z�[�W�� = new System.Windows.Forms.Label();
			this.tex���b�Z�[�W�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab���b�Z�[�W�^�C�g�� = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tex���b�Z�[�W = new System.Windows.Forms.TextBox();
			this.btn���� = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axGT���b�Z�[�W)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.axGT���b�Z�[�W);
			this.panel1.Controls.Add(this.cmb���b�Z�[�W���);
			this.panel1.Controls.Add(this.lab�Ŕԍ�);
			this.panel1.Controls.Add(this.btn����);
			this.panel1.Controls.Add(this.btn�O��);
			this.panel1.Controls.Add(this.btn�X�V);
			this.panel1.Controls.Add(this.lab���b�Z�[�W��);
			this.panel1.Controls.Add(this.tex���b�Z�[�W��);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(767, 440);
			this.panel1.TabIndex = 0;
			// 
			// axGT���b�Z�[�W
			// 
			this.axGT���b�Z�[�W.ContainingControl = this;
			this.axGT���b�Z�[�W.DataSource = null;
			this.axGT���b�Z�[�W.Location = new System.Drawing.Point(42, 38);
			this.axGT���b�Z�[�W.Name = "axGT���b�Z�[�W";
			this.axGT���b�Z�[�W.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT���b�Z�[�W.OcxState")));
			this.axGT���b�Z�[�W.Size = new System.Drawing.Size(664, 272);
			this.axGT���b�Z�[�W.TabIndex = 65;
			this.axGT���b�Z�[�W.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT���b�Z�[�W_KeyDownEvent);
			this.axGT���b�Z�[�W.CelClick += new AxGTABLE32V2Lib._DGTable32Events_CelClickEventHandler(this.axGT���b�Z�[�W_CelClick);
			this.axGT���b�Z�[�W.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT���b�Z�[�W_CurPlaceChanged);
			// 
			// cmb���b�Z�[�W���
			// 
			this.cmb���b�Z�[�W���.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb���b�Z�[�W���.Items.AddRange(new object[] {
															"�V�X�e�����b�Z�[�W",
															"�X�����b�Z�[�W",
															"������b�Z�[�W"});
			this.cmb���b�Z�[�W���.Location = new System.Drawing.Point(42, 10);
			this.cmb���b�Z�[�W���.Name = "cmb���b�Z�[�W���";
			this.cmb���b�Z�[�W���.Size = new System.Drawing.Size(138, 20);
			this.cmb���b�Z�[�W���.TabIndex = 1;
			this.cmb���b�Z�[�W���.SelectionChangeCommitted += new System.EventHandler(this.cmb���b�Z�[�W���_SelectionChangeCommitted);
			// 
			// lab�Ŕԍ�
			// 
			this.lab�Ŕԍ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab�Ŕԍ�.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab�Ŕԍ�.Location = new System.Drawing.Point(608, 322);
			this.lab�Ŕԍ�.Name = "lab�Ŕԍ�";
			this.lab�Ŕԍ�.Size = new System.Drawing.Size(48, 14);
			this.lab�Ŕԍ�.TabIndex = 64;
			this.lab�Ŕԍ�.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn����
			// 
			this.btn����.BackColor = System.Drawing.Color.SteelBlue;
			this.btn����.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn����.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn����.ForeColor = System.Drawing.Color.White;
			this.btn����.Location = new System.Drawing.Point(656, 318);
			this.btn����.Name = "btn����";
			this.btn����.Size = new System.Drawing.Size(48, 22);
			this.btn����.TabIndex = 63;
			this.btn����.Text = "����";
			this.btn����.Click += new System.EventHandler(this.btn����_Click);
			// 
			// btn�O��
			// 
			this.btn�O��.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�O��.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�O��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�O��.ForeColor = System.Drawing.Color.White;
			this.btn�O��.Location = new System.Drawing.Point(560, 318);
			this.btn�O��.Name = "btn�O��";
			this.btn�O��.Size = new System.Drawing.Size(48, 22);
			this.btn�O��.TabIndex = 62;
			this.btn�O��.Text = "�O��";
			this.btn�O��.Click += new System.EventHandler(this.btn�O��_Click);
			// 
			// btn�X�V
			// 
			this.btn�X�V.BackColor = System.Drawing.Color.SteelBlue;
			this.btn�X�V.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn�X�V.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn�X�V.ForeColor = System.Drawing.Color.White;
			this.btn�X�V.Location = new System.Drawing.Point(646, 410);
			this.btn�X�V.Name = "btn�X�V";
			this.btn�X�V.Size = new System.Drawing.Size(64, 22);
			this.btn�X�V.TabIndex = 5;
			this.btn�X�V.Text = "�ۑ�";
			this.btn�X�V.Click += new System.EventHandler(this.btn�X�V_Click);
			// 
			// lab���b�Z�[�W��
			// 
			this.lab���b�Z�[�W��.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab���b�Z�[�W��.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab���b�Z�[�W��.Location = new System.Drawing.Point(44, 382);
			this.lab���b�Z�[�W��.Name = "lab���b�Z�[�W��";
			this.lab���b�Z�[�W��.Size = new System.Drawing.Size(58, 14);
			this.lab���b�Z�[�W��.TabIndex = 56;
			this.lab���b�Z�[�W��.Text = "���b�Z�[�W��";
			// 
			// tex���b�Z�[�W��
			// 
			this.tex���b�Z�[�W��.BackColor = System.Drawing.SystemColors.Window;
			this.tex���b�Z�[�W��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W��.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex���b�Z�[�W��.Location = new System.Drawing.Point(106, 378);
			this.tex���b�Z�[�W��.MaxLength = 15;
			this.tex���b�Z�[�W��.Name = "tex���b�Z�[�W��";
			this.tex���b�Z�[�W��.Size = new System.Drawing.Size(630, 23);
			this.tex���b�Z�[�W��.TabIndex = 4;
			this.tex���b�Z�[�W��.Text = "�������������������P�������������������Q�������������������R�������������������S�������������������T";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab���b�Z�[�W�^�C�g��);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(794, 26);
			this.panel7.TabIndex = 13;
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
			this.lab���b�Z�[�W�^�C�g��.Text = "���b�Z�[�W�o�^";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.tex���b�Z�[�W);
			this.panel8.Controls.Add(this.btn����);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 1;
			// 
			// tex���b�Z�[�W
			// 
			this.tex���b�Z�[�W.BackColor = System.Drawing.Color.PaleGreen;
			this.tex���b�Z�[�W.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex���b�Z�[�W.ForeColor = System.Drawing.Color.Red;
			this.tex���b�Z�[�W.Location = new System.Drawing.Point(536, 4);
			this.tex���b�Z�[�W.Multiline = true;
			this.tex���b�Z�[�W.Name = "tex���b�Z�[�W";
			this.tex���b�Z�[�W.ReadOnly = true;
			this.tex���b�Z�[�W.Size = new System.Drawing.Size(256, 50);
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
			this.btn����.TabIndex = 7;
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
			this.panel6.Size = new System.Drawing.Size(794, 26);
			this.panel6.TabIndex = 15;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(8, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(774, 448);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// ���b�Z�[�W�o�^
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 574);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "���b�Z�[�W�o�^";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ���b�Z�[�W�o�^";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.�G���^�[�ړ�);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.�G���^�[�L�����Z��);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axGT���b�Z�[�W)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>

		private void Form1_Load(object sender, System.EventArgs e)
		{
			axGT���b�Z�[�W.Cols = 4;
			axGT���b�Z�[�W.Rows = 14;
			axGT���b�Z�[�W.ColSep = "|";

			axGT���b�Z�[�W.set_RowsText(0, "|�X���R�[�h|�X����|�X�����b�Z�[�W|");

			axGT���b�Z�[�W.ColsWidth = "0|7|8|36|0|";
			axGT���b�Z�[�W.ColsAlignHorz = "1|1|0|0|0|";
            
//			axGT���b�Z�[�W.set_CelForeColor(axGT���b�Z�[�W.CaretRow,0,111111);
			axGT���b�Z�[�W.set_CelForeColor(axGT���b�Z�[�W.CaretRow,0,0x98FB98);  //BGR
			axGT���b�Z�[�W.set_CelBackColor(axGT���b�Z�[�W.CaretRow,0,0x006000);

			axGT���b�Z�[�W.CaretRow = 1;
			cmb���b�Z�[�W���.SelectedIndex = 0;
			s����R�[�h = "yusoshiji";
			i���ݕŐ� = 1;
			���b�Z�[�W�ꗗ����();
		}

		private void ���b�Z�[�W�ꗗ����()
		{

			s���b�Z�[�W�R�[�h = "";
			tex���b�Z�[�W��.Text     = "";
			s�X�V����        = "";

			s���b�Z�[�W�ꗗ = new string[1];
			// �J�[�\���������v�ɂ���
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{

				if (cmb���b�Z�[�W���.SelectedIndex == 0)
				{
					tex���b�Z�[�W��.MaxLength      = 500;
					if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
					s���b�Z�[�W�ꗗ = sv_maintenance.Get_Kiji(gsa���[�U,"default","yusoshiji");
				}
				else if (cmb���b�Z�[�W���.SelectedIndex == 1)
				{
					tex���b�Z�[�W��.MaxLength      = 100;
					if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
					s���b�Z�[�W�ꗗ = sv_maintenance.Get_Kiji(gsa���[�U,"default","yusoshiji");
				}
				else
				{
					tex���b�Z�[�W��.MaxLength      = 100;
					if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
					s���b�Z�[�W�ꗗ = sv_maintenance.Get_Kiji(gsa���[�U,"default","yusoshiji");
				}
			
			}
			catch (Exception ex)
			{
				s���b�Z�[�W�ꗗ[0] = "�ʐM�G���[�F" + ex.Message;
			}
			// �J�[�\�����f�t�H���g�ɖ߂�
			Cursor = System.Windows.Forms.Cursors.Default;

			tex���b�Z�[�W.Text = s���b�Z�[�W�ꗗ[0];
			if(s���b�Z�[�W�ꗗ[0].Length == 4) //����I��
			{
				tex���b�Z�[�W.Text = "";
				i�ő�Ő� = (s���b�Z�[�W�ꗗ.Length - 2) / axGT���b�Z�[�W.Rows + 1;
				if (i���ݕŐ� > i�ő�Ő�) i���ݕŐ� = i�ő�Ő�;
				�ŏ��ݒ�();
			}
			else
			{
				axGT���b�Z�[�W.Clear();
				i���ݕŐ� = 1;
				btn�O��.Enabled = false;
				btn����.Enabled = false;
				lab�Ŕԍ�.Text = "";
				�r�[�v��();
			}
		}
		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void axGT���b�Z�[�W_CelClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelClickEvent e)
		{
			s���b�Z�[�W�R�[�h = axGT���b�Z�[�W.get_CelText(axGT���b�Z�[�W.CaretRow,1).Trim();
			tex���b�Z�[�W��.Text     = axGT���b�Z�[�W.get_CelText(axGT���b�Z�[�W.CaretRow,3).Trim();
			s�X�V����        = axGT���b�Z�[�W.get_CelText(axGT���b�Z�[�W.CaretRow,4).Trim();
		}

		private void axGT���b�Z�[�W_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT���b�Z�[�W.set_CelForeColor(nOldRow,0,0);
			axGT���b�Z�[�W.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT���b�Z�[�W.set_CelForeColor(axGT���b�Z�[�W.CaretRow,0,111111);
			axGT���b�Z�[�W.set_CelForeColor(axGT���b�Z�[�W.CaretRow,0,0x98FB98);  //BGR
			axGT���b�Z�[�W.set_CelBackColor(axGT���b�Z�[�W.CaretRow,0,0x006000);
			nOldRow = axGT���b�Z�[�W.CaretRow;
			s���b�Z�[�W�R�[�h = axGT���b�Z�[�W.get_CelText(axGT���b�Z�[�W.CaretRow,1).Trim();
			tex���b�Z�[�W��.Text     = axGT���b�Z�[�W.get_CelText(axGT���b�Z�[�W.CaretRow,3).Trim();
			s�X�V����        = axGT���b�Z�[�W.get_CelText(axGT���b�Z�[�W.CaretRow,4).Trim();
		}

		private void axGT���b�Z�[�W_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT���b�Z�[�W, true, true, true, true);
			}
		}

		private void btn�X�V_Click(object sender, System.EventArgs e)
		{
			tex���b�Z�[�W��.Text     = tex���b�Z�[�W��.Text.Trim();

//			if(!�S�p�`�F�b�N(tex���b�Z�[�W��,"���b�Z�[�W��")) return;

			try
			{
				tex���b�Z�[�W.Text = "";
				// �J�[�\���������v�ɂ���
				Cursor = System.Windows.Forms.Cursors.AppStarting;

				String[] sList = {""};

//				if(cmb���b�Z�[�W���.SelectedIndex == 0)
//				{
//					if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
//					String[] sList = sv_maintenance.Sel_Kiji(gsa���[�U,"default",s����R�[�h,"");
//				}
//				else if (cmb���b�Z�[�W���.SelectedIndex == 1)
//				{
//					if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
//					String[] sList = sv_maintenance.Sel_Kiji(gsa���[�U,"default",s����R�[�h,"");
//				}
//				else
//				{
//					 if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
//					 String[] sList = sv_maintenance.Sel_Kiji(gsa���[�U,"default",s����R�[�h,"");
//				}

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
										+ "���b�Z�[�W�ꗗ���ŐV�ɂ��܂����H",
										"�X�V",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Error);
					if(rst == DialogResult.Yes)
					{
						���b�Z�[�W�ꗗ����();
					}
					return;
				}

				String[] sIUList;
				string[] sData = new string[7];
				sData[0]  = "default";
				sData[1]  = s����R�[�h;
				sData[2]  = s���b�Z�[�W�R�[�h;
				sData[3]  = tex���b�Z�[�W��.Text;
				sData[4]  = "���b�Z�[�W�o�^";
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
							���b�Z�[�W�ꗗ����();
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
							���b�Z�[�W�ꗗ����();
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
			axGT���b�Z�[�W.Clear();

			i�J�n�� = (i���ݕŐ� - 1) * axGT���b�Z�[�W.Rows + 1;
			i�I���� = i���ݕŐ� * axGT���b�Z�[�W.Rows;

			short s�\���� = (short)1;
//			for(short sCnt = (short)i�J�n��; sCnt < s���b�Z�[�W�ꗗ.Length && sCnt <= i�I���� ; sCnt++)
//			{
//				axGT���b�Z�[�W.set_RowsText(s�\����, s���b�Z�[�W�ꗗ[sCnt]);
//				s�\����++;
//			}

//���f�[�^
//			axGT���b�Z�[�W.set_RowsText(s�\����, "|123456789012|��������������������|�������������������P���������������ĂQ�Ȃɂʂ˂̂��������R�������������������S�����ĂƂȂɂʂ˂T|");
//			s�\����++;
//			axGT���b�Z�[�W.set_RowsText(s�\����, "|is2|�V�X�e����Ж�|�������������������P���������������ĂQ�Ȃɂʂ˂̂��������R�������������������S�����ĂƂȂɂʂ˂T�������������������P���������������ĂQ�Ȃɂʂ˂̂��������R�������������������S�����ĂƂȂɂʂ˂T|");
//			s�\����++;
//			axGT���b�Z�[�W.set_RowsText(s�\����, "|264|�[�J|�������������������P���������������ĂQ�Ȃɂʂ˂̂��������R�������������������S�����ĂƂȂɂʂ˂T|");
//			s�\����++;
//			axGT���b�Z�[�W.set_RowsText(s�\����, "|0862312511|���s���|�������������������P���������������ĂQ�Ȃɂʂ˂̂��������R�������������������S�����ĂƂȂɂʂ˂T|");

			axGT���b�Z�[�W.set_RowsText(s�\����, "|264|�[�J|�[�J�x�X�p�̃��b�Z�[�W�ł�|");
			s�\����++;
			axGT���b�Z�[�W.set_RowsText(s�\����, "|265|��z|�����́E���ᔽ�ł��肢���܂�|");
			s�\����++;
			axGT���b�Z�[�W.set_RowsText(s�\����, "|266|����||");
			s�\����++;
			axGT���b�Z�[�W.set_RowsText(s�\����, "|268|�Y�a|�l�`�w���\���p�ł��P�������������������Q�������������������R�������������������S�������������������T|");
			s�\����++;
			
			
			lab�Ŕԍ�.Text = i���ݕŐ�.ToString() + " / " + i�ő�Ő�.ToString();
			if (i���ݕŐ� == 1)
				btn�O��.Enabled = false;
			else
				btn�O��.Enabled = true;
			if (i���ݕŐ� == i�ő�Ő�)
				btn����.Enabled = false;
			else
				btn����.Enabled = true;
			s���b�Z�[�W�R�[�h = axGT���b�Z�[�W.get_CelText(axGT���b�Z�[�W.CaretRow,1).Trim();
			tex���b�Z�[�W��.Text     = axGT���b�Z�[�W.get_CelText(axGT���b�Z�[�W.CaretRow,3).Trim();
			s�X�V����          = axGT���b�Z�[�W.get_CelText(axGT���b�Z�[�W.CaretRow,4).Trim();
		}

		private void cmb���b�Z�[�W���_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			i���ݕŐ� = 1;
			���b�Z�[�W�ꗗ����();
		}

	}
}
