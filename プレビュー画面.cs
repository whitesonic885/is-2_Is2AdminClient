using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace is2AdminClient
{
	/// <summary>
	/// Form1 �̊T�v�̐����ł��B
	/// </summary>
	public class �v���r���[��� : System.Windows.Forms.Form
	{
		public CrystalDecisions.Windows.Forms.CrystalReportViewer crv���[;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public �v���r���[���()
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
				if(components != null)
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
			this.crv���[ = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// crv���[
			// 
			this.crv���[.ActiveViewIndex = -1;
// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� START
            //this.crv���[.DisplayGroupTree = false;
            this.crv���[.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
// MOD 2016.9.27 Vivouac) �e�r Visual Studio 2013�`���Ή� END
            this.crv���[.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crv���[.Location = new System.Drawing.Point(0, 0);
			this.crv���[.Name = "crv���[";
			this.crv���[.ReportSource = null;
			this.crv���[.Size = new System.Drawing.Size(792, 573);
			this.crv���[.TabIndex = 0;
			// 
			// �v���r���[���
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.Add(this.crv���[);
			this.Name = "�v���r���[���";
			this.Text = "���[���";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
