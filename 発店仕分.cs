using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// ���X�d�� �̊T�v�̐����ł��B
	/// </summary>
	public class ���X�d�� : ���ʃt�H�[��
	{
		public short nOldRow = 0;
		private string[] s���X���ꗗ;
		private int      i���ݕŐ�;
		private int      i�ő�Ő�;
		private int      i�J�n��;
		private int      i�I����;
		private int      i���ݕŐ��ێ�;
		private bool     bUpd;
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� START
//		private bool     bCheck;
		private int      iCheck;
		private static string[] s�`�F�b�N���b�Z�[�W = {""
			,"�d�����R�[�h�͔��p�����œ��͂��Ă�������"
			,"�d�����R�[�h�͉p�����œ��͂��Ă�������"
			,"�d�����R�[�h�͂R�����̏ꍇ�A�P�����͉p���œ��͂��Ă�������"
			,"�d�����R�[�h�͂Q�`�R�����œ��͂��Ă�������"
		};
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� END
		
		private string[] sUpdData = new string[16];

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private ���ʃe�L�X�g�{�b�N�X tex���b�Z�[�W;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Label lab�Ŕԍ�;
		private System.Windows.Forms.Button btn����;
		private System.Windows.Forms.Button btn�O��;
		private System.Windows.Forms.Panel panel5;
		private ���ʃe�L�X�g�{�b�N�X tex�����X��;
		private System.Windows.Forms.Label lab�����X��;
		private AxGTABLE32V2Lib.AxGTable32 axGT���X��;
		private System.Windows.Forms.Button btn���;
		private System.Windows.Forms.Button btn�o�^;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private is2AdminClient.���ʃe�L�X�g�{�b�N�X tex���X����;
		public System.Windows.Forms.Label lab���X�d�����R�[�h�o�^;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ���X�d��()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(���X�d��));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn�o�^ = new System.Windows.Forms.Button();
            this.axGT���X�� = new AxGTABLE32V2Lib.AxGTable32();
            this.btn��� = new System.Windows.Forms.Button();
            this.lab�Ŕԍ� = new System.Windows.Forms.Label();
            this.btn���� = new System.Windows.Forms.Button();
            this.btn�O�� = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab���X�d�����R�[�h�o�^ = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tex���b�Z�[�W = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.btn���� = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tex�����X�� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.lab�����X�� = new System.Windows.Forms.Label();
            this.tex���X���� = new is2AdminClient.���ʃe�L�X�g�{�b�N�X();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT���X��)).BeginInit();
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
            this.panel1.Controls.Add(this.btn�o�^);
            this.panel1.Controls.Add(this.axGT���X��);
            this.panel1.Controls.Add(this.btn���);
            this.panel1.Controls.Add(this.lab�Ŕԍ�);
            this.panel1.Controls.Add(this.btn����);
            this.panel1.Controls.Add(this.btn�O��);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 408);
            this.panel1.TabIndex = 1;
            // 
            // btn�o�^
            // 
            this.btn�o�^.BackColor = System.Drawing.Color.Blue;
            this.btn�o�^.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn�o�^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn�o�^.ForeColor = System.Drawing.Color.White;
            this.btn�o�^.Location = new System.Drawing.Point(264, 378);
            this.btn�o�^.Name = "btn�o�^";
            this.btn�o�^.Size = new System.Drawing.Size(48, 22);
            this.btn�o�^.TabIndex = 4;
            this.btn�o�^.Text = "�o�^";
            this.btn�o�^.UseVisualStyleBackColor = false;
            this.btn�o�^.Click += new System.EventHandler(this.btn�o�^_Click);
            // 
            // axGT���X��
            // 
            this.axGT���X��.DataSource = null;
            this.axGT���X��.Location = new System.Drawing.Point(76, 10);
            this.axGT���X��.Name = "axGT���X��";
            this.axGT���X��.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT���X��.OcxState")));
            this.axGT���X��.Size = new System.Drawing.Size(228, 325);
            this.axGT���X��.TabIndex = 0;
            this.axGT���X��.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT���X��_CurPlaceChanged);
            this.axGT���X��.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT���X��_CelDblClick);
            this.axGT���X��.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT���X��_KeyDownEvent);
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
            // lab�Ŕԍ�
            // 
            this.lab�Ŕԍ�.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�Ŕԍ�.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�Ŕԍ�.Location = new System.Drawing.Point(210, 346);
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
            this.btn����.Location = new System.Drawing.Point(258, 342);
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
            this.btn�O��.Location = new System.Drawing.Point(162, 342);
            this.btn�O��.Name = "btn�O��";
            this.btn�O��.Size = new System.Drawing.Size(48, 22);
            this.btn�O��.TabIndex = 62;
            this.btn�O��.Text = "�O��";
            this.btn�O��.UseVisualStyleBackColor = false;
            this.btn�O��.Click += new System.EventHandler(this.btn�O��_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab���X�d�����R�[�h�o�^);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(396, 26);
            this.panel7.TabIndex = 13;
            // 
            // lab���X�d�����R�[�h�o�^
            // 
            this.lab���X�d�����R�[�h�o�^.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab���X�d�����R�[�h�o�^.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab���X�d�����R�[�h�o�^.ForeColor = System.Drawing.Color.White;
            this.lab���X�d�����R�[�h�o�^.Location = new System.Drawing.Point(12, 2);
            this.lab���X�d�����R�[�h�o�^.Name = "lab���X�d�����R�[�h�o�^";
            this.lab���X�d�����R�[�h�o�^.Size = new System.Drawing.Size(264, 24);
            this.lab���X�d�����R�[�h�o�^.TabIndex = 0;
            this.lab���X�d�����R�[�h�o�^.Text = "���X�d�����R�[�h�o�^";
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
            this.panel5.Controls.Add(this.tex���X����);
            this.panel5.Location = new System.Drawing.Point(1, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 36);
            this.panel5.TabIndex = 0;
            // 
            // tex�����X��
            // 
            this.tex�����X��.BackColor = System.Drawing.SystemColors.Window;
            this.tex�����X��.Enabled = false;
            this.tex�����X��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex�����X��.Location = new System.Drawing.Point(76, 6);
            this.tex�����X��.MaxLength = 4;
            this.tex�����X��.Name = "tex�����X��";
            this.tex�����X��.ReadOnly = true;
            this.tex�����X��.Size = new System.Drawing.Size(42, 23);
            this.tex�����X��.TabIndex = 0;
            this.tex�����X��.TabStop = false;
            // 
            // lab�����X��
            // 
            this.lab�����X��.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab�����X��.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab�����X��.Location = new System.Drawing.Point(18, 10);
            this.lab�����X��.Name = "lab�����X��";
            this.lab�����X��.Size = new System.Drawing.Size(58, 16);
            this.lab�����X��.TabIndex = 46;
            this.lab�����X��.Text = "���X��";
            // 
            // tex���X����
            // 
            this.tex���X����.BackColor = System.Drawing.Color.Honeydew;
            this.tex���X����.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex���X����.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex���X����.Location = new System.Drawing.Point(120, 10);
            this.tex���X����.Name = "tex���X����";
            this.tex���X����.ReadOnly = true;
            this.tex���X����.Size = new System.Drawing.Size(150, 16);
            this.tex���X����.TabIndex = 75;
            this.tex���X����.TabStop = false;
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
            // ���X�d��
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
            this.Name = "���X�d��";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 ���X�d�����R�[�h�o�^";
            this.Closed += new System.EventHandler(this.���X�d��_Closed);
            this.Load += new System.EventHandler(this.���X�d��_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On�G���^�[�ړ�);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On�G���^�[�L�����Z��);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGT���X��)).EndInit();
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

		private void ���X�d��_Load(object sender, System.EventArgs e)
		{
			axGT���X��.Cols = 5;
			axGT���X��.Rows = 17;
			axGT���X��.ColSep = "|";
			axGT���X��.NoBeep = true;

			axGT���X��.set_RowsText(0, "|�R�[�h|���X��|�d�����R�[�h|�d�����b�c|�X�V����|");

			axGT���X��.ColsWidth = "0|3|9|5.5|0|0|";
			axGT���X��.ColsAlignHorz = "1|1|0|1|1|1|";

			axGT���X��.set_CelForeColor(axGT���X��.CaretRow,0,0x98FB98);  //BGR
			axGT���X��.set_CelBackColor(axGT���X��.CaretRow,0,0x006000);

			axGT���X��.CaretRow = 1;
			tex�����X��.Text = gs�X���R�[�h;

			���X������();
			���X���ꗗ����();
			tex�����X��.Focus();
		}

		private void ���X���ꗗ����()
		{
			axGT���X��.Clear();

			tex�����X��.Text   = tex�����X��.Text.Trim();
			if (tex�����X��.Text.Length == 0)
			{
				tex�����X��.Text = " ";
			}
			if(!���p�`�F�b�N(tex�����X��,"���X��")) return;

			i���ݕŐ� = 1;
			axGT���X��.CaretRow = 1;
			axGT���X��.set_CelForeColor(nOldRow,0,0);
			axGT���X��.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGT���X��.set_CelForeColor(axGT���X��.CaretRow,0,0x98FB98);  //BGR
			axGT���X��.set_CelBackColor(axGT���X��.CaretRow,0,0x006000);
			nOldRow = axGT���X��.CaretRow;
			
			s���X���ꗗ = new string[1];
			tex���b�Z�[�W.Text = "�������D�D�D";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex�����X��.Text;
				s���X���ꗗ = sv_maintenance.Get_Tyakusiwake(gsa���[�U, sKey);
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(s���X���ꗗ[0].Equals("����I��"))
			{
				tex���b�Z�[�W.Text = "";
				i�ő�Ő� = (s���X���ꗗ.Length - 2) / (axGT���X��.Rows - 1) + 1;
				if (i���ݕŐ� > i�ő�Ő�)
					i���ݕŐ� = i�ő�Ő�;
				�ŏ��ݒ�();
			}
			else
			{
				tex���b�Z�[�W.Text = s���X���ꗗ[0];
				axGT���X��.Clear();
				i���ݕŐ� = 1;
				btn�O��.Enabled = false;
				btn����.Enabled = false;
				lab�Ŕԍ�.Text = "";
				�r�[�v��();
			}
			tex�����X��.Text = tex�����X��.Text.Trim();
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void axGT���X��_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
		}

		private void axGT���X��_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT���X��.set_CelForeColor(nOldRow,0,0);
			axGT���X��.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGT���X��.set_CelForeColor(axGT���X��.CaretRow,0,0x98FB98);  //BGR
			axGT���X��.set_CelBackColor(axGT���X��.CaretRow,0,0x006000);
			nOldRow = axGT���X��.CaretRow;
		}

		private void axGT���X��_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT���X��, true, true, true, true);
			}
		}

		private void btn�o�^_Click(object sender, System.EventArgs e)
		{
			�d�����b�c�`�F�b�N();
			if(bUpd)
			{
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� START
//				if(!bCheck)
//				{
//					MessageBox.Show("�d�����R�[�h�͔��p�����œ��͂��Ă�������",
//						"���̓`�F�b�N",MessageBoxButtons.OK);
//					return;
//				}
				if(iCheck > 0)
				{
					MessageBox.Show(s�`�F�b�N���b�Z�[�W[iCheck],
						"���̓`�F�b�N",MessageBoxButtons.OK);
					return;
				}
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� END
				if(���X�d�����X�V())
				{
					���X���ꗗ����();
				}
			}
		}

		private void btn���_Click(object sender, System.EventArgs e)
		{
			���X���ꗗ����();
		}

		private void btn�O��_Click(object sender, System.EventArgs e)
		{
			�d�����b�c�`�F�b�N();
			if(bUpd)
			{
				DialogResult result = MessageBox.Show("�ύX����Ă���d�����R�[�h���X�V���܂����H","�X�V",MessageBoxButtons.YesNo);
				if(result == DialogResult.Yes)
				{
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� START
//					if(!bCheck)
//					{
//						MessageBox.Show("�d�����R�[�h�͔��p�����œ��͂��Ă�������",
//							"���̓`�F�b�N",MessageBoxButtons.OK);
//						return;
//					}
					if(iCheck > 0)
					{
						MessageBox.Show(s�`�F�b�N���b�Z�[�W[iCheck],
							"���̓`�F�b�N",MessageBoxButtons.OK);
						return;
					}
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� END
					if(!���X�d�����X�V())
					{
						return;
					}
					i���ݕŐ��ێ� = i���ݕŐ�;
					���X���ꗗ����();
					i���ݕŐ�     = i���ݕŐ��ێ�;
				}
			}
			i���ݕŐ�--;
			�ŏ��ݒ�();
			axGT���X��.CaretRow = 1;
			axGT���X��_CurPlaceChanged(null,null);
		}

		private void btn����_Click(object sender, System.EventArgs e)
		{
			�d�����b�c�`�F�b�N();
			if(bUpd)
			{
				DialogResult result = MessageBox.Show("�ύX����Ă���d�����R�[�h���X�V���܂����H","�X�V",MessageBoxButtons.YesNo);
				if(result == DialogResult.Yes)
				{
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� START
//					if(!bCheck)
//					{
//						MessageBox.Show("�d�����R�[�h�͔��p�����œ��͂��Ă�������",
//							"���̓`�F�b�N",MessageBoxButtons.OK);
//						return;
//					}
					if(iCheck > 0)
					{
						MessageBox.Show(s�`�F�b�N���b�Z�[�W[iCheck],
							"���̓`�F�b�N",MessageBoxButtons.OK);
						return;
					}
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� END
					if(!���X�d�����X�V())
					{
						return;
					}
					i���ݕŐ��ێ� = i���ݕŐ�;
					���X���ꗗ����();
					i���ݕŐ�     = i���ݕŐ��ێ�;
				}
			}
			i���ݕŐ�++;
			�ŏ��ݒ�();
			axGT���X��.CaretRow = 1;
			axGT���X��_CurPlaceChanged(null,null);
		}
		
		private void �ŏ��ݒ�()
		{
			axGT���X��.Clear();

			i�J�n�� = (i���ݕŐ� - 1) * (axGT���X��.Rows - 1) + 1;
			i�I���� = i���ݕŐ� * (axGT���X��.Rows - 1);

			short s�\���� = (short)2;
			for(short sCnt = (short)i�J�n��; sCnt < s���X���ꗗ.Length && sCnt <= i�I���� ; sCnt++)
			{
				axGT���X��.set_RowsText(s�\����, s���X���ꗗ[sCnt]);
				axGT���X��.set_CelLocked(s�\����,3,false);
// MOD 2007.02.16 ���s�j���� ���͌������l�`�w�R���ɂ��� START
//				axGT���X��.set_CelMaxLength(s�\����,3,5);
				axGT���X��.set_CelMaxLength(s�\����,3,3);
// MOD 2007.02.16 ���s�j���� ���͌������l�`�w�R���ɂ��� END
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

		private void �d�����b�c�`�F�b�N()
		{
			bUpd = false;
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� START
//			bCheck = true;
			iCheck = 0;
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� END
			int iCnt = 0;
// ADD 2007.02.07 ���s�j���� �f�[�^�N���A�����̒ǉ� START
			sUpdData = new string[16];
// ADD 2007.02.07 ���s�j���� �f�[�^�N���A�����̒ǉ� END

			for(short sCnt = 2; sCnt < 18; sCnt++)
			{
				if(!axGT���X��.get_CelText(sCnt,1).Trim().Equals(""))
				{
					string sNcd = axGT���X��.get_CelText(sCnt,3).Trim();
					string sOcd = axGT���X��.get_CelText(sCnt,4).Trim();
					if(!sNcd.Equals(sOcd))
					{
						bUpd = true;
						if(!sNcd.Trim().Equals(""))
						{
							if(!���p���̓`�F�b�N(sNcd))
							{
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� START
//								bCheck = false;
								iCheck = 1;
								axGT���X��.CaretRow = sCnt;
								axGT���X��_CurPlaceChanged(null,null);
// MOD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� END
								return;
							}
// ADD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� START
							sNcd = sNcd.Trim();
							switch(sNcd.Length)
							{
								case 2:
									//�Q�����̏ꍇ�͉p�����A
									if(!char.IsLetterOrDigit(sNcd[0])
										|| !char.IsLetterOrDigit(sNcd[1]))
									{
										iCheck = 2;
										axGT���X��.CaretRow = sCnt;
										axGT���X��_CurPlaceChanged(null,null);
										return;
									}
									break;
								case 3:
									//�R�����̏ꍇ�͉p�����ŁA�p���͏��Ȃ��Ƃ��P�����܂܂�邱��
									if(!char.IsLetterOrDigit(sNcd[0])
										|| !char.IsLetterOrDigit(sNcd[1])
										|| !char.IsLetterOrDigit(sNcd[2]))
									{
										iCheck = 2;
										axGT���X��.CaretRow = sCnt;
										axGT���X��_CurPlaceChanged(null,null);
										return;
									}
									if(!char.IsLetter(sNcd[0])
										&& !char.IsLetter(sNcd[1])
										&& !char.IsLetter(sNcd[2]))
									{
										iCheck = 3;
										axGT���X��.CaretRow = sCnt;
										axGT���X��_CurPlaceChanged(null,null);
										return;
									}
									break;
								default:
									iCheck = 4;
									axGT���X��.CaretRow = sCnt;
									axGT���X��_CurPlaceChanged(null,null);
									return;
							}
// ADD 2007.01.26 ���s�j���� �R�[�h�`�F�b�N�̒ǉ� END
						}
						else
						{
							sNcd = " ";
						}
						sUpdData[iCnt] = gs�X���R�[�h
									  + ","
									  + axGT���X��.get_CelText(sCnt,1).Trim()
									  + ","
									  + sNcd
									  + ","
									  + "���X�d��"
									  + ","
									  + gs���p�҃R�[�h;
						iCnt++;
					}
				}
				else
				{
					sCnt = 20;
				}
			}
		}

		private bool ���X�d�����X�V()
		{
			if(bUpd)
			{
				try
				{
					string[] sList = sv_maintenance.Ins_TyakuSiwake(gsa���[�U, sUpdData);
					tex���b�Z�[�W.Text = sList[0];
					if (!sList[0].Equals("����I��"))
					{
						�r�[�v��();
						return false;
					}
				}
				catch (Exception ex)
				{
					tex���b�Z�[�W.Text = ex.Message;
					�r�[�v��();
					return false;
				}
			}
			return true;

		}

		private void ���X�d��_Closed(object sender, System.EventArgs e)
		{
			axGT���X��.CaretRow = 1;
			axGT���X��_CurPlaceChanged(null,null);
		}

		private void ���X������()
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			
			try
			{
				string[] sKey  = new string[1];
				sKey[0] = gs�X���R�[�h.Trim();
				string[] sList = sv_maintenance.Sel_Hatuten(gsa���[�U, sKey);

				if (sList[0].Equals("����I��"))
				{
					tex���b�Z�[�W.Text = "";
					tex���X����.Text = sList[1].Trim();
				}
				else
				{
					tex���b�Z�[�W.Text = sList[0];
					�r�[�v��();
				}
			}
			catch (Exception ex)
			{
				tex���b�Z�[�W.Text = ex.Message;
				�r�[�v��();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
		
		private bool ���p���̓`�F�b�N(string sSiwake)
		{
			string sUnicode = sSiwake;
			byte[] bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sUnicode);
			if(bSjis.Length != sUnicode.Length)
			{
				return false;
			}

			return true;
		}
	}
}
