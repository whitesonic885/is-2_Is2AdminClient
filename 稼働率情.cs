using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// Form1 の概要の説明です。
	/// </summary>
	public class 稼働率情 : 共通フォーム
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lab稼働率情タイトル;
		private System.Windows.Forms.Button btnＣＳＶ出力;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label lab地区コード;
		private is2AdminClient.共通テキストボックス tex開始地区コード;
		private is2AdminClient.共通テキストボックス tex終了地区コード;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lab店所;
		private System.Windows.Forms.Label label3;
		private is2AdminClient.共通テキストボックス tex開始店所コード;
		private is2AdminClient.共通テキストボックス tex終了店所コード;
		private System.Windows.Forms.Label lab出荷日;
		private System.Windows.Forms.NumericUpDown n出荷年;
		private System.Windows.Forms.NumericUpDown n出荷月;
		private System.Windows.Forms.RadioButton rb全件;
		private System.Windows.Forms.RadioButton rbデモ機を除く;
		private System.ComponentModel.IContainer components = null;

		public 稼働率情()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
			//
		}

		/// <summary>
		/// 使用されているリソースに後処理を実行します。
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

		#region Windows フォーム デザイナで生成されたコード 
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbデモ機を除く = new System.Windows.Forms.RadioButton();
			this.rb全件 = new System.Windows.Forms.RadioButton();
			this.n出荷月 = new System.Windows.Forms.NumericUpDown();
			this.n出荷年 = new System.Windows.Forms.NumericUpDown();
			this.lab出荷日 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tex開始店所コード = new is2AdminClient.共通テキストボックス();
			this.tex終了店所コード = new is2AdminClient.共通テキストボックス();
			this.lab店所 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lab地区コード = new System.Windows.Forms.Label();
			this.tex開始地区コード = new is2AdminClient.共通テキストボックス();
			this.tex終了地区コード = new is2AdminClient.共通テキストボックス();
			this.label1 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab稼働率情タイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnＣＳＶ出力 = new System.Windows.Forms.Button();
			this.texメッセージ = new System.Windows.Forms.TextBox();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.n出荷月)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n出荷年)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.rbデモ機を除く);
			this.panel1.Controls.Add(this.rb全件);
			this.panel1.Controls.Add(this.n出荷月);
			this.panel1.Controls.Add(this.n出荷年);
			this.panel1.Controls.Add(this.lab出荷日);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.tex開始店所コード);
			this.panel1.Controls.Add(this.tex終了店所コード);
			this.panel1.Controls.Add(this.lab店所);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.lab地区コード);
			this.panel1.Controls.Add(this.tex開始地区コード);
			this.panel1.Controls.Add(this.tex終了地区コード);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(370, 176);
			this.panel1.TabIndex = 1;
			// 
			// rbデモ機を除く
			// 
			this.rbデモ機を除く.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rbデモ機を除く.Location = new System.Drawing.Point(184, 140);
			this.rbデモ機を除く.Name = "rbデモ機を除く";
			this.rbデモ機を除く.Size = new System.Drawing.Size(106, 24);
			this.rbデモ機を除く.TabIndex = 11;
			this.rbデモ機を除く.Text = "デモ機を除く";
			// 
			// rb全件
			// 
			this.rb全件.Checked = true;
			this.rb全件.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rb全件.Location = new System.Drawing.Point(120, 140);
			this.rb全件.Name = "rb全件";
			this.rb全件.Size = new System.Drawing.Size(60, 24);
			this.rb全件.TabIndex = 10;
			this.rb全件.TabStop = true;
			this.rb全件.Text = "全件";
			// 
			// n出荷月
			// 
			this.n出荷月.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.n出荷月.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.n出荷月.Location = new System.Drawing.Point(180, 100);
			this.n出荷月.Maximum = new System.Decimal(new int[] {
																 13,
																 0,
																 0,
																 0});
			this.n出荷月.Name = "n出荷月";
			this.n出荷月.ReadOnly = true;
			this.n出荷月.Size = new System.Drawing.Size(44, 23);
			this.n出荷月.TabIndex = 9;
			this.n出荷月.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.n出荷月.Value = new System.Decimal(new int[] {
															   12,
															   0,
															   0,
															   0});
			this.n出荷月.ValueChanged += new System.EventHandler(this.n出荷月_ValueChanged);
			// 
			// n出荷年
			// 
			this.n出荷年.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.n出荷年.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.n出荷年.Location = new System.Drawing.Point(118, 100);
			this.n出荷年.Maximum = new System.Decimal(new int[] {
																 2006,
																 0,
																 0,
																 0});
			this.n出荷年.Minimum = new System.Decimal(new int[] {
																 2006,
																 0,
																 0,
																 0});
			this.n出荷年.Name = "n出荷年";
			this.n出荷年.ReadOnly = true;
			this.n出荷年.Size = new System.Drawing.Size(60, 23);
			this.n出荷年.TabIndex = 8;
			this.n出荷年.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.n出荷年.Value = new System.Decimal(new int[] {
															   2006,
															   0,
															   0,
															   0});
			// 
			// lab出荷日
			// 
			this.lab出荷日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab出荷日.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab出荷日.Location = new System.Drawing.Point(36, 102);
			this.lab出荷日.Name = "lab出荷日";
			this.lab出荷日.Size = new System.Drawing.Size(76, 18);
			this.lab出荷日.TabIndex = 71;
			this.lab出荷日.Text = "出荷年月";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label3.ForeColor = System.Drawing.Color.LimeGreen;
			this.label3.Location = new System.Drawing.Point(152, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 16);
			this.label3.TabIndex = 70;
			this.label3.Text = "～";
			// 
			// tex開始店所コード
			// 
			this.tex開始店所コード.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex開始店所コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex開始店所コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex開始店所コード.Location = new System.Drawing.Point(118, 60);
			this.tex開始店所コード.MaxLength = 3;
			this.tex開始店所コード.Name = "tex開始店所コード";
			this.tex開始店所コード.Size = new System.Drawing.Size(34, 23);
			this.tex開始店所コード.TabIndex = 3;
			this.tex開始店所コード.Text = "123";
			// 
			// tex終了店所コード
			// 
			this.tex終了店所コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex終了店所コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex終了店所コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex終了店所コード.Location = new System.Drawing.Point(174, 60);
			this.tex終了店所コード.MaxLength = 3;
			this.tex終了店所コード.Name = "tex終了店所コード";
			this.tex終了店所コード.Size = new System.Drawing.Size(34, 23);
			this.tex終了店所コード.TabIndex = 4;
			this.tex終了店所コード.Text = "123";
			// 
			// lab店所
			// 
			this.lab店所.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab店所.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab店所.Location = new System.Drawing.Point(36, 64);
			this.lab店所.Name = "lab店所";
			this.lab店所.Size = new System.Drawing.Size(76, 18);
			this.lab店所.TabIndex = 67;
			this.lab店所.Text = "店所コード";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.LimeGreen;
			this.label4.Location = new System.Drawing.Point(152, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "～";
			// 
			// lab地区コード
			// 
			this.lab地区コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab地区コード.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab地区コード.Location = new System.Drawing.Point(36, 26);
			this.lab地区コード.Name = "lab地区コード";
			this.lab地区コード.Size = new System.Drawing.Size(76, 18);
			this.lab地区コード.TabIndex = 65;
			this.lab地区コード.Text = "地区コード";
			// 
			// tex開始地区コード
			// 
			this.tex開始地区コード.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex開始地区コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex開始地区コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex開始地区コード.Location = new System.Drawing.Point(118, 22);
			this.tex開始地区コード.MaxLength = 3;
			this.tex開始地区コード.Name = "tex開始地区コード";
			this.tex開始地区コード.Size = new System.Drawing.Size(34, 23);
			this.tex開始地区コード.TabIndex = 0;
			this.tex開始地区コード.Text = "123";
			// 
			// tex終了地区コード
			// 
			this.tex終了地区コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex終了地区コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex終了地区コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex終了地区コード.Location = new System.Drawing.Point(174, 22);
			this.tex終了地区コード.MaxLength = 3;
			this.tex終了地区コード.Name = "tex終了地区コード";
			this.tex終了地区コード.Size = new System.Drawing.Size(34, 23);
			this.tex終了地区コード.TabIndex = 2;
			this.tex終了地区コード.Text = "123";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.panel7.Controls.Add(this.lab稼働率情タイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(792, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab稼働率情タイトル
			// 
			this.lab稼働率情タイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab稼働率情タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab稼働率情タイトル.ForeColor = System.Drawing.Color.White;
			this.lab稼働率情タイトル.Location = new System.Drawing.Point(12, 2);
			this.lab稼働率情タイトル.Name = "lab稼働率情タイトル";
			this.lab稼働率情タイトル.Size = new System.Drawing.Size(264, 24);
			this.lab稼働率情タイトル.TabIndex = 0;
			this.lab稼働率情タイトル.Text = "稼働率調査表出力";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btnＣＳＶ出力);
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 286);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 2;
			// 
			// btnＣＳＶ出力
			// 
			this.btnＣＳＶ出力.ForeColor = System.Drawing.Color.Blue;
			this.btnＣＳＶ出力.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btnＣＳＶ出力.Location = new System.Drawing.Point(76, 6);
			this.btnＣＳＶ出力.Name = "btnＣＳＶ出力";
			this.btnＣＳＶ出力.Size = new System.Drawing.Size(54, 48);
			this.btnＣＳＶ出力.TabIndex = 2;
			this.btnＣＳＶ出力.Text = "ＣＳＶ　出力";
			this.btnＣＳＶ出力.Click += new System.EventHandler(this.btnＣＳＶ出力_Click);
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(140, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(242, 50);
			this.texメッセージ.TabIndex = 1;
			this.texメッセージ.TabStop = false;
			this.texメッセージ.Text = "";
			// 
			// btn閉じる
			// 
			this.btn閉じる.ForeColor = System.Drawing.Color.Red;
			this.btn閉じる.Location = new System.Drawing.Point(8, 6);
			this.btn閉じる.Name = "btn閉じる";
			this.btn閉じる.Size = new System.Drawing.Size(54, 48);
			this.btn閉じる.TabIndex = 0;
			this.btn閉じる.TabStop = false;
			this.btn閉じる.Text = "閉じる";
			this.btn閉じる.Click += new System.EventHandler(this.btn閉じる_Click);
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
			// 稼働率情
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
			this.Name = "稼働率情";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 稼働率調査表出力";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.稼働率情_Load);
			this.Closed += new System.EventHandler(this.稼働率情_Closed);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.n出荷月)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n出荷年)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void 項目クリア()
		{
			tex開始地区コード.Text = "";
			tex終了地区コード.Text = "";
			tex開始店所コード.Text = "";
			tex終了店所コード.Text = "";
// MOD 2006.10.20 東都）高木 一覧表作成の一部バッチ化 START
//			dt開始日付.Value = new DateTime(System.DateTime.Now.Year, 
//											System.DateTime.Now.Month, 1);
//			dt終了日付.Value = System.DateTime.Now;
////			dt終了日付.Value = System.DateTime.Now.AddDays(-1); // デフォルトを前日にする
////			dt開始日付.Value = new DateTime(dt終了日付.Value.Year, 
////											dt終了日付.Value.Month, 1);
			//前月１日～末日
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
			DateTime dt前月 = new DateTime(iYear, iMonth, 1);
// MOD 2007.02.02 東都）高木 条件指定の変更 START
//			dt開始日付.Value = dt前月;
//			dt終了日付.Value = dt前月.AddMonths(1).AddDays(-1);
//			dt開始日付.Enabled = false;
//			dt終了日付.Enabled = false;
			//２００７年１月より過去のデータは×
			n出荷年.Minimum = 2007;
			n出荷年.Maximum = dt前月.Year; // System.DateTime.Now.Year;
// MOD 2007.02.02 東都）高木 条件指定の変更 END
			n出荷年.Value = dt前月.Year;
			n出荷月.Value = dt前月.Month;
// MOD 2006.10.20 東都）高木 一覧表作成の一部バッチ化 END
			texメッセージ.Text = "";
		}

		private void 稼働率情_Load(object sender, System.EventArgs e)
		{
			項目クリア();
// ADD 2007.02.16 東都）高木 初期フォーカスの変更 START
			if(gs店所コード.Trim().Length == 0)
			{
				tex開始地区コード.Text = " ";
				tex開始地区コード.Focus();
			}
			else
			{
				n出荷年.Focus();
			}
// ADD 2007.02.16 東都）高木 初期フォーカスの変更 END
		}

		private void 稼働率情_Closed(object sender, System.EventArgs e)
		{
			項目クリア();
// MOD 2007.02.16 東都）高木 初期フォーカスの変更 START
//// MOD 2007.02.02 東都）高木 条件指定の変更 START
////			dt開始日付.Focus();
//			n出荷年.Focus();
//// MOD 2007.02.02 東都）高木 条件指定の変更 END
			tex開始地区コード.Text = " ";
			tex開始地区コード.Focus();
// MOD 2007.02.16 東都）高木 初期フォーカスの変更 END
		}

		private void btnＣＳＶ出力_Click(object sender, System.EventArgs e)
		{
			texメッセージ.Text = "";
// MOD 2007.02.02 東都）高木 条件指定の変更 START
//			if (dt開始日付.Value > dt終了日付.Value)
//			{
//				MessageBox.Show("日付の範囲が正しく入力されていません","入力チェック",MessageBoxButtons.OK );
//				dt開始日付.Focus();
//				return;
//			}
//
//			string s開始日付 = YYYYMMDD変換(dt開始日付.Value);
//			string s終了日付 = YYYYMMDD変換(dt終了日付.Value);

			//当月以降のものを出力しようとした時
			if(n出荷年.Value == System.DateTime.Now.Year
					&& n出荷月.Value >= System.DateTime.Now.Month)
			{
				MessageBox.Show("出荷年月が正しく入力されていません\n（前月まで指定可）",
					"入力チェック",MessageBoxButtons.OK );
				n出荷月.Focus();
				return;
			}

			string s開始日付 = n出荷年.Value.ToString();
			if(n出荷月.Value < 10) s開始日付 += "0";
			s開始日付 += n出荷月.Value + "01";
			string s終了日付 = "";
// MOD 2007.02.02 東都）高木 条件指定の変更 END
// MOD 2007.10.11 東都）高木 デモ機を除く機能の追加 START
			string sデモ機を除く = "";
			if(rbデモ機を除く.Checked) sデモ機を除く = "1";
// MOD 2007.10.11 東都）高木 デモ機を除く機能の追加 END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sList = new string[2]{"",""};
// MOD 2007.10.11 東都）高木 デモ機を除く機能の追加 START
//				string[] sData = new string[6]{
//									tex開始地区コード.Text.Trim(),
//									tex終了地区コード.Text.Trim(),
//									tex開始店所コード.Text.Trim(),
//									tex終了店所コード.Text.Trim(),
//									s開始日付,
//									s終了日付
//								};
				string[] sData = new string[7]{
									tex開始地区コード.Text.Trim(),
									tex終了地区コード.Text.Trim(),
									tex開始店所コード.Text.Trim(),
									tex終了店所コード.Text.Trim(),
									s開始日付,
									s終了日付,
									sデモ機を除く
								};
// MOD 2007.10.11 東都）高木 デモ機を除く機能の追加 END

				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
// 2006.10.20 東都）高木 一覧表作成の一部バッチ化 START
//				sList = sv_maintenance.Get_kadouritu_csv(gsaユーザ, sData);
				sList = sv_maintenance.Get_kadouritu_csv2(gsaユーザ, sData);
// 2006.10.20 東都）高木 一覧表作成の一部バッチ化 END
				this.Cursor = System.Windows.Forms.Cursors.Default;

				if(sList[0].Length == 4)
				{
// 2006.10.02 東都）山本　ＣＳＶ出力時に見出し行を出力しないようにする。　DEL START
//					sList[0] = "\"地区ＣＤ\",\"店所ＣＤ\",\"店所名\","
//					sList[0] = "\"地区１ＣＤ\",\"地区２ＣＤ\",\"地区１名称\",\"地区２名称\",\"店所ＣＤ\",\"店所名\","
//						+ "\"導入台数\",\"稼動台数\",\"稼動率\""
//					;
// 2006.10.02 東都）山本　ＣＳＶ出力時に見出し行を出力しないようにする。　DEL END

					// デフォルトのフォルダをデスクトップフォルダにする
					saveFileDialog1.InitialDirectory
						= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
					saveFileDialog1.Filter = "ＣＳＶファイル (*.csv)|*.csv";
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
						texメッセージ.Text = "";
					}
				}
				else
				{
					if(sList[0].Equals("該当データがありません"))
					{
						texメッセージ.Text = "";
						ビープ音();
						MessageBox.Show("該当データがありません","稼働率情報出力",MessageBoxButtons.OK);
					}
					else
					{
						ビープ音();
						texメッセージ.Text = sList[0];
					}
				}
			}
			catch (System.Net.WebException)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				texメッセージ.Text = gs通信エラー;
			}
			catch(Exception ex)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				texメッセージ.Text = ex.Message;
			}
		}

// ADD 2007.02.02 東都）高木 条件指定の変更 START
		private void n出荷月_ValueChanged(object sender, System.EventArgs e)
		{
			if(n出荷月.Value == 0)
			{
				n出荷月.Value = 12;
				if(n出荷年.Value > n出荷年.Minimum) n出荷年.Value--;
				return;
			}
			if(n出荷月.Value == 13)
			{
				n出荷月.Value = 1;
				if(n出荷年.Value < n出荷年.Maximum) n出荷年.Value++;
				return;
			}
		}
// ADD 2007.02.02 東都）高木 条件指定の変更 END

// DEL 2007.02.02 東都）高木 条件指定の変更 START
//// ADD 2006.10.20 東都）高木 一覧表作成の一部バッチ化 START
//		private void dt開始日付_ValueChanged(object sender, System.EventArgs e)
//		{
//			dt開始日付.Value = new DateTime(dt開始日付.Value.Year, 
//				dt開始日付.Value.Month, 1);
//
//			//前日の日付の年と月が一緒の場合
//			DateTime da前日 = System.DateTime.Now.AddDays(-1);
//			if(dt開始日付.Value.Year == da前日.Year
//			 && dt開始日付.Value.Month == da前日.Month)
//			{
//				//前日
//				dt終了日付.Value = da前日;
//			}
//			else
//			{
//				//前月の末日
//				dt終了日付.Value = dt開始日付.Value.AddMonths(1).AddDays(-1);
//			}
//		}
//
//		private void n出荷年_ValueChanged(object sender, System.EventArgs e)
//		{
//			dt開始日付.Value = new DateTime(int.Parse(n出荷年.Value.ToString()), 
//				int.Parse(n出荷月.Value.ToString()), 1);
//		
//			//末日
//			dt終了日付.Value = dt開始日付.Value.AddMonths(1).AddDays(-1);
//		}
//
//		private void n出荷月_ValueChanged(object sender, System.EventArgs e)
//		{
//			dt開始日付.Value = new DateTime(int.Parse(n出荷年.Value.ToString()), 
//				int.Parse(n出荷月.Value.ToString()), 1);
//
//			//末日
//			dt終了日付.Value = dt開始日付.Value.AddMonths(1).AddDays(-1);
//		}
//// ADD 2006.10.20 東都）高木 一覧表作成の一部バッチ化 END
// DEL 2007.02.02 東都）高木 条件指定の変更 END

	}
}
