// ADD 2007.12.05 KCL) 森本 お知らせ追加 START
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [お知らせ登録]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2008.02.07 KCL) 森本 お知らせ修正 
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 東都）高木 表題、詳細内容、ボタンの全角半角混在チェックの追加 
	//--------------------------------------------------------------------------
	// ADD 2008.05.08 東都）高木 表題、詳細内容、ボタンの全角半角混在チェックの追加
	// [変更]ボタン押下時の既存データの変更かどうかのチェックのタイミングも変更
	//--------------------------------------------------------------------------
	// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 
	//--------------------------------------------------------------------------
	public class お知らせ登録 : 共通フォーム
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lab詳細内容;
		private is2AdminClient.共通テキストボックス tex表題;
		private System.Windows.Forms.Label lab表題;
		private System.Windows.Forms.Label lab登録日;
		private is2AdminClient.共通テキストボックス tex登録日;
		private is2AdminClient.共通テキストボックス tex詳細内容;
		private System.Windows.Forms.Label labお知らせ登録タイトル;
		private System.Windows.Forms.Button btn変更;
		private System.Windows.Forms.Button btn保存;
		private System.Windows.Forms.Button btn削除;
		private System.Windows.Forms.Button btn検索;
		private is2AdminClient.共通テキストボックス texボタン名;
		private System.Windows.Forms.Label labボタン名;
		private System.Windows.Forms.Label labアドレス;
		private is2AdminClient.共通テキストボックス texアドレス;
		private System.Windows.Forms.Label lab日時;
		private System.Windows.Forms.Label lab認証会員名;
		private is2AdminClient.共通テキストボックス tex認証利用者名;
		private System.Windows.Forms.Label lab認証利用者名;
		private is2AdminClient.共通テキストボックス tex認証会員名;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components = null;

		private string s優先順			= string.Empty;
		private string s登録日			= string.Empty;
		private string sシーケンスＮｏ	= string.Empty;
		private System.Windows.Forms.ComboBox cmb会員区分;
		private System.Windows.Forms.Label lab会員区分;
		private decimal d更新日時		= 0m;

		public お知らせ登録()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmb会員区分 = new System.Windows.Forms.ComboBox();
			this.lab会員区分 = new System.Windows.Forms.Label();
			this.labアドレス = new System.Windows.Forms.Label();
			this.texアドレス = new is2AdminClient.共通テキストボックス();
			this.labボタン名 = new System.Windows.Forms.Label();
			this.texボタン名 = new is2AdminClient.共通テキストボックス();
			this.btn検索 = new System.Windows.Forms.Button();
			this.lab詳細内容 = new System.Windows.Forms.Label();
			this.tex表題 = new is2AdminClient.共通テキストボックス();
			this.lab表題 = new System.Windows.Forms.Label();
			this.lab登録日 = new System.Windows.Forms.Label();
			this.tex登録日 = new is2AdminClient.共通テキストボックス();
			this.tex詳細内容 = new is2AdminClient.共通テキストボックス();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lab認証会員名 = new System.Windows.Forms.Label();
			this.tex認証利用者名 = new is2AdminClient.共通テキストボックス();
			this.lab認証利用者名 = new System.Windows.Forms.Label();
			this.tex認証会員名 = new is2AdminClient.共通テキストボックス();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab日時 = new System.Windows.Forms.Label();
			this.labお知らせ登録タイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn削除 = new System.Windows.Forms.Button();
			this.btn変更 = new System.Windows.Forms.Button();
			this.btn保存 = new System.Windows.Forms.Button();
			this.texメッセージ = new System.Windows.Forms.TextBox();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.cmb会員区分);
			this.panel1.Controls.Add(this.lab会員区分);
			this.panel1.Controls.Add(this.labアドレス);
			this.panel1.Controls.Add(this.texアドレス);
			this.panel1.Controls.Add(this.labボタン名);
			this.panel1.Controls.Add(this.texボタン名);
			this.panel1.Controls.Add(this.btn検索);
			this.panel1.Controls.Add(this.lab詳細内容);
			this.panel1.Controls.Add(this.tex表題);
			this.panel1.Controls.Add(this.lab表題);
			this.panel1.Controls.Add(this.lab登録日);
			this.panel1.Controls.Add(this.tex登録日);
			this.panel1.Controls.Add(this.tex詳細内容);
			this.panel1.Location = new System.Drawing.Point(2, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(770, 434);
			this.panel1.TabIndex = 1;
			// 
			// cmb会員区分
			// 
			this.cmb会員区分.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.cmb会員区分.Items.AddRange(new object[] {
														 "一般会員",
														 "営業所会員"});
			this.cmb会員区分.Location = new System.Drawing.Point(400, 10);
			this.cmb会員区分.Name = "cmb会員区分";
			this.cmb会員区分.Size = new System.Drawing.Size(108, 24);
			this.cmb会員区分.TabIndex = 85;
			// 
			// lab会員区分
			// 
			this.lab会員区分.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.lab会員区分.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab会員区分.Location = new System.Drawing.Point(318, 12);
			this.lab会員区分.Name = "lab会員区分";
			this.lab会員区分.Size = new System.Drawing.Size(78, 18);
			this.lab会員区分.TabIndex = 86;
			this.lab会員区分.Text = "会員区分";
			// 
			// labアドレス
			// 
			this.labアドレス.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labアドレス.ForeColor = System.Drawing.Color.LimeGreen;
			this.labアドレス.Location = new System.Drawing.Point(10, 408);
			this.labアドレス.Name = "labアドレス";
			this.labアドレス.Size = new System.Drawing.Size(76, 18);
			this.labアドレス.TabIndex = 84;
			this.labアドレス.Text = "アドレス";
			// 
			// texアドレス
			// 
			this.texアドレス.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.texアドレス.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texアドレス.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.texアドレス.Location = new System.Drawing.Point(86, 406);
			this.texアドレス.MaxLength = 150;
			this.texアドレス.Name = "texアドレス";
			this.texアドレス.Size = new System.Drawing.Size(670, 23);
			this.texアドレス.TabIndex = 83;
			this.texアドレス.Text = "国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王";
			// 
			// labボタン名
			// 
			this.labボタン名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labボタン名.ForeColor = System.Drawing.Color.LimeGreen;
			this.labボタン名.Location = new System.Drawing.Point(10, 380);
			this.labボタン名.Name = "labボタン名";
			this.labボタン名.Size = new System.Drawing.Size(76, 18);
			this.labボタン名.TabIndex = 82;
			this.labボタン名.Text = "ボタン名";
			// 
			// texボタン名
			// 
			this.texボタン名.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.texボタン名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texボタン名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.texボタン名.Location = new System.Drawing.Point(86, 378);
			this.texボタン名.MaxLength = 10;
			this.texボタン名.Name = "texボタン名";
			this.texボタン名.Size = new System.Drawing.Size(168, 23);
			this.texボタン名.TabIndex = 81;
			this.texボタン名.Text = "国国国国国王王王王王";
			// 
			// btn検索
			// 
			this.btn検索.BackColor = System.Drawing.Color.Blue;
			this.btn検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn検索.ForeColor = System.Drawing.Color.White;
			this.btn検索.Location = new System.Drawing.Point(248, 10);
			this.btn検索.Name = "btn検索";
			this.btn検索.Size = new System.Drawing.Size(46, 22);
			this.btn検索.TabIndex = 80;
			this.btn検索.TabStop = false;
			this.btn検索.Text = "検索";
			this.btn検索.Click += new System.EventHandler(this.btn検索_Click);
			// 
			// lab詳細内容
			// 
			this.lab詳細内容.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab詳細内容.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab詳細内容.Location = new System.Drawing.Point(10, 68);
			this.lab詳細内容.Name = "lab詳細内容";
			this.lab詳細内容.Size = new System.Drawing.Size(76, 18);
			this.lab詳細内容.TabIndex = 79;
			this.lab詳細内容.Text = "詳細内容";
			// 
			// tex表題
			// 
			this.tex表題.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex表題.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex表題.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex表題.Location = new System.Drawing.Point(86, 38);
			this.tex表題.MaxLength = 60;
			this.tex表題.Name = "tex表題";
			this.tex表題.Size = new System.Drawing.Size(518, 23);
			this.tex表題.TabIndex = 2;
			this.tex表題.Text = "国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王";
			// 
			// lab表題
			// 
			this.lab表題.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab表題.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab表題.Location = new System.Drawing.Point(10, 40);
			this.lab表題.Name = "lab表題";
			this.lab表題.Size = new System.Drawing.Size(76, 18);
			this.lab表題.TabIndex = 77;
			this.lab表題.Text = "表　題";
			// 
			// lab登録日
			// 
			this.lab登録日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab登録日.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab登録日.Location = new System.Drawing.Point(10, 12);
			this.lab登録日.Name = "lab登録日";
			this.lab登録日.Size = new System.Drawing.Size(76, 18);
			this.lab登録日.TabIndex = 76;
			this.lab登録日.Text = "登録日";
			// 
			// tex登録日
			// 
			this.tex登録日.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex登録日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex登録日.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex登録日.Location = new System.Drawing.Point(86, 10);
			this.tex登録日.MaxLength = 10;
			this.tex登録日.Name = "tex登録日";
			this.tex登録日.Size = new System.Drawing.Size(150, 23);
			this.tex登録日.TabIndex = 0;
			this.tex登録日.Text = "123";
			// 
			// tex詳細内容
			// 
			this.tex詳細内容.BackColor = System.Drawing.SystemColors.Window;
			this.tex詳細内容.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex詳細内容.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex詳細内容.Location = new System.Drawing.Point(86, 66);
			this.tex詳細内容.MaxLength = 2000;
			this.tex詳細内容.Multiline = true;
			this.tex詳細内容.Name = "tex詳細内容";
			this.tex詳細内容.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tex詳細内容.Size = new System.Drawing.Size(664, 310);
			this.tex詳細内容.TabIndex = 3;
			this.tex詳細内容.Text = @"国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Controls.Add(this.lab認証会員名);
			this.panel6.Controls.Add(this.tex認証利用者名);
			this.panel6.Controls.Add(this.lab認証利用者名);
			this.panel6.Controls.Add(this.tex認証会員名);
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(810, 26);
			this.panel6.TabIndex = 12;
			// 
			// lab認証会員名
			// 
			this.lab認証会員名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab認証会員名.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab認証会員名.Location = new System.Drawing.Point(16, 8);
			this.lab認証会員名.Name = "lab認証会員名";
			this.lab認証会員名.Size = new System.Drawing.Size(54, 14);
			this.lab認証会員名.TabIndex = 7;
			this.lab認証会員名.Text = "お客様名";
			// 
			// tex認証利用者名
			// 
			this.tex認証利用者名.BackColor = System.Drawing.Color.PaleGreen;
			this.tex認証利用者名.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex認証利用者名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex認証利用者名.ForeColor = System.Drawing.Color.Green;
			this.tex認証利用者名.Location = new System.Drawing.Point(472, 5);
			this.tex認証利用者名.Name = "tex認証利用者名";
			this.tex認証利用者名.ReadOnly = true;
			this.tex認証利用者名.Size = new System.Drawing.Size(322, 16);
			this.tex認証利用者名.TabIndex = 6;
			this.tex認証利用者名.TabStop = false;
			this.tex認証利用者名.Text = "国国国国国国国国国国王王王王王王王王王王";
			this.tex認証利用者名.Visible = false;
			// 
			// lab認証利用者名
			// 
			this.lab認証利用者名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab認証利用者名.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab認証利用者名.Location = new System.Drawing.Point(420, 7);
			this.lab認証利用者名.Name = "lab認証利用者名";
			this.lab認証利用者名.Size = new System.Drawing.Size(54, 14);
			this.lab認証利用者名.TabIndex = 5;
			this.lab認証利用者名.Text = "ユーザー";
			this.lab認証利用者名.Visible = false;
			// 
			// tex認証会員名
			// 
			this.tex認証会員名.BackColor = System.Drawing.Color.PaleGreen;
			this.tex認証会員名.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex認証会員名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex認証会員名.ForeColor = System.Drawing.Color.Green;
			this.tex認証会員名.Location = new System.Drawing.Point(74, 5);
			this.tex認証会員名.Name = "tex認証会員名";
			this.tex認証会員名.ReadOnly = true;
			this.tex認証会員名.Size = new System.Drawing.Size(330, 16);
			this.tex認証会員名.TabIndex = 4;
			this.tex認証会員名.TabStop = false;
			this.tex認証会員名.Text = "999 ○○支店";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab日時);
			this.panel7.Controls.Add(this.labお知らせ登録タイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(798, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab日時
			// 
			this.lab日時.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab日時.ForeColor = System.Drawing.Color.White;
			this.lab日時.Location = new System.Drawing.Point(674, 8);
			this.lab日時.Name = "lab日時";
			this.lab日時.Size = new System.Drawing.Size(112, 14);
			this.lab日時.TabIndex = 2;
			this.lab日時.Text = "2005/xx/xx 12:00:00";
			// 
			// labお知らせ登録タイトル
			// 
			this.labお知らせ登録タイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.labお知らせ登録タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labお知らせ登録タイトル.ForeColor = System.Drawing.Color.White;
			this.labお知らせ登録タイトル.Location = new System.Drawing.Point(12, 2);
			this.labお知らせ登録タイトル.Name = "labお知らせ登録タイトル";
			this.labお知らせ登録タイトル.Size = new System.Drawing.Size(264, 24);
			this.labお知らせ登録タイトル.TabIndex = 0;
			this.labお知らせ登録タイトル.Text = "お知らせ登録";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btn削除);
			this.panel8.Controls.Add(this.btn変更);
			this.panel8.Controls.Add(this.btn保存);
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 2;
			// 
			// btn削除
			// 
			this.btn削除.ForeColor = System.Drawing.Color.Blue;
			this.btn削除.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn削除.Location = new System.Drawing.Point(198, 6);
			this.btn削除.Name = "btn削除";
			this.btn削除.Size = new System.Drawing.Size(54, 48);
			this.btn削除.TabIndex = 3;
			this.btn削除.Text = "削除";
			this.btn削除.Click += new System.EventHandler(this.btn削除_Click);
			// 
			// btn変更
			// 
			this.btn変更.ForeColor = System.Drawing.Color.Blue;
			this.btn変更.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn変更.Location = new System.Drawing.Point(134, 6);
			this.btn変更.Name = "btn変更";
			this.btn変更.Size = new System.Drawing.Size(54, 48);
			this.btn変更.TabIndex = 2;
			this.btn変更.Text = "変更";
			this.btn変更.Click += new System.EventHandler(this.btn変更_Click);
			// 
			// btn保存
			// 
			this.btn保存.ForeColor = System.Drawing.Color.Blue;
			this.btn保存.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn保存.Location = new System.Drawing.Point(70, 6);
			this.btn保存.Name = "btn保存";
			this.btn保存.Size = new System.Drawing.Size(54, 48);
			this.btn保存.TabIndex = 1;
			this.btn保存.Text = "保存";
			this.btn保存.Click += new System.EventHandler(this.btn保存_Click);
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(260, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(530, 50);
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.panel1);
			this.groupBox3.Location = new System.Drawing.Point(10, 62);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(774, 442);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// お知らせ登録
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 575);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "お知らせ登録";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 お知らせ登録";
			this.Load += new System.EventHandler(this.出荷状況_Load);
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void 出荷状況_Load(object sender, System.EventArgs e)
		{
// ADD 2008.02.07 KCL) 森本 お知らせ修正 START
			// タイトル表示
			tex認証会員名.Text = gs会員名;
			tex認証利用者名.Text = gs利用者名;

			// 日時の初期設定
			lab日時.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;
// ADD 2008.02.07 KCL) 森本 お知らせ修正 END

			// 表示の初期化
			項目クリア();

			// フォーカス設定
			tex表題.Focus();
		}

		private void 項目クリア()
		{
			// 表示クリア
			tex登録日.Text		= DateTime.Now.ToString("yyyy/MM/dd");
			tex表題.Text			= string.Empty;
			tex詳細内容.Text		= string.Empty;
			texメッセージ.Text	= string.Empty;
			texボタン名.Text		= "詳細";
			texアドレス.Text		= string.Empty;
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
			cmb会員区分.SelectedIndex = 0;
			cmb会員区分.Text
				= (string)cmb会員区分.Items[cmb会員区分.SelectedIndex];
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END

			// 内部データクリア
			s優先順			= string.Empty;
			s登録日			= string.Empty;
			sシーケンスＮｏ	= string.Empty;
			d更新日時		= 0m;
		}

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			// このフォームを閉じる
			this.Close();
		}

		private void btn検索_Click(object sender, System.EventArgs e)
		{
			// 検索フォーム表示
			if (gお知検索 == null) gお知検索 = new お知らせ検索();
			gお知検索.Left = this.Left + 202;
			gお知検索.Top  = this.Top;
			gお知検索.項目クリア();
			gお知検索.ShowDialog(this);

			// 結果表示
			if (gお知検索.s表題.Trim().Length != 0)
			{
				// 検索結果あり
				tex登録日.Text	= YYYYMMDD変換(gお知検索.s登録日).ToString("yyyy/MM/dd");
				tex表題.Text		= gお知検索.s表題;
				tex詳細内容.Text	= gお知検索.s詳細内容;
				texボタン名.Text	= gお知検索.sボタン名;
				texアドレス.Text	= gお知検索.sアドレス;
				s優先順			= gお知検索.s優先順;
				s登録日			= gお知検索.s登録日;
				sシーケンスＮｏ	= gお知検索.sシーケンスＮｏ;
				d更新日時		= gお知検索.d更新日時;
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
				if (gお知検索.s会員区分.Equals("2")){
					cmb会員区分.SelectedIndex = 1;
				}else{
					cmb会員区分.SelectedIndex = int.Parse(gお知検索.s会員区分);
				}
				cmb会員区分.Text
						= (string)cmb会員区分.Items[cmb会員区分.SelectedIndex];
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
				tex登録日.Focus();
			}
			else
			{
				// 検索結果なし
				tex表題.Focus();
			}

			// メッセージクリア
			texメッセージ.Text = string.Empty;
		}

		private void btn保存_Click(object sender, System.EventArgs e)
		{
			// 入力チェック
			if (!必須チェック(tex登録日, "登録日")) return;
			if (!必須チェック(tex表題, "表題")) return;
			if (!必須チェック(tex詳細内容, "詳細内容")) return;

// ADD 2008.05.07 東都）高木 表題、詳細内容の全角半角混在チェックの追加 START
			if (!全角半角混在チェック(tex表題, "表題")) return;
			if (!全角半角混在チェック(tex詳細内容, "詳細内容")) return;
			if (!全角半角混在チェック(texボタン名, "ボタン名")) return;
// ADD 2008.05.07 東都）高木 表題、詳細内容の全角半角混在チェックの追加 END

			// 型チェック
			if (!日付チェック(tex登録日, "登録日")) return;
			// 文字チェック
			if (!禁則文字チェック(tex表題, "表題")) return;
			if (!禁則文字チェック(tex詳細内容, "詳細内容")) return;
			// バイト数チェック
			if (!バイト数チェック(tex表題, "表題", 60)) return;
			if (!バイト数チェック(tex詳細内容, "詳細内容", 2000)) return;
			if (!バイト数チェック(texボタン名, "ボタン名", 20)) return;
			if (!バイト数チェック(texアドレス, "アドレス", 150)) return;
			// ＵＲＬチェック
			if ((texアドレス.Text.Trim().Length > 0) && !ＵＲＬチェック(texアドレス, "アドレス")) return;
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
			if(cmb会員区分.SelectedIndex < 0){
				MessageBox.Show("会員区分が違います","入力チェック",MessageBoxButtons.OK);
				return;
			}
			cmb会員区分.Text
				= (string)cmb会員区分.Items[cmb会員区分.SelectedIndex];
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END

			// 最終確認
			if (MessageBox.Show("お知らせを新規登録します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No)
				return;

			// 空白除去 ＆ 登録データ設定
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			string [] sKey  = new string [7];
			string [] sKey  = new string [8];
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
			sKey[0] = DateTime.Parse(tex登録日.Text.Trim()).ToString("yyyyMMdd");
			sKey[1] = tex表題.Text.Trim();
			sKey[2] = tex詳細内容.Text.Trim();
			sKey[3] = texボタン名.Text.Trim();
			if (sKey[3].Length == 0) sKey[3] = " ";
			sKey[4] = texアドレス.Text.Trim();
			if (sKey[4].Length == 0) sKey[4] = " ";
			sKey[5] = "1";
			sKey[6] = gs利用者コード;
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
			if (cmb会員区分.SelectedIndex == 1){
				sKey[7] = "2";
			}else{
				sKey[7] = cmb会員区分.SelectedIndex.ToString();
			}
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END

			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			// お知らせの登録
			texメッセージ.Text = "保存中．．．";
			string [] sRet = new string [1];
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				sRet = sv_oshirase.Ins_Oshirase(gsaユーザ, sKey);
			}
			catch (System.Net.WebException)
			{
				// 通信エラー発生
				sRet[0] = gs通信エラー;
			}
			catch (Exception ex)
			{
				// その他のエラー発生
				sRet[0] = "通信エラー：" + ex.Message;
			}
			
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			// 結果処理
			switch (sRet[0].Trim()) 
			{
				case "正常終了" :
					this.項目クリア();
					texメッセージ.Text = "お知らせを登録しました。";
					tex登録日.Focus();

					break;

				default :
					texメッセージ.Text = sRet[0];
					ビープ音();
					tex登録日.Focus();

					break;
			}
		}

		private void btn変更_Click(object sender, System.EventArgs e)
		{
// ADD 2008.05.08 東都）高木 表題、詳細内容の全角半角混在チェックの追加 START
			// 既存データの変更かどうかチェック
			if (sシーケンスＮｏ == string.Empty) 
			{
				// 新規入力データの場合
				ビープ音();
				string msg = "お知らせを変更するには、[検索]を押して変更前のデータを指定して下さい。";
				MessageBox.Show(msg, "入力チェック", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
// ADD 2008.05.08 東都）高木 表題、詳細内容の全角半角混在チェックの追加 END

			// 入力チェック
			if (!必須チェック(tex登録日, "登録日")) return;
			if (!必須チェック(tex表題, "表題")) return;
			if (!必須チェック(tex詳細内容, "詳細内容")) return;

// ADD 2008.05.08 東都）高木 表題、詳細内容の全角半角混在チェックの追加 START
			if (!全角半角混在チェック(tex表題, "表題")) return;
			if (!全角半角混在チェック(tex詳細内容, "詳細内容")) return;
			if (!全角半角混在チェック(texボタン名, "ボタン名")) return;
// ADD 2008.05.08 東都）高木 表題、詳細内容の全角半角混在チェックの追加 END

			// 型チェック
			if (!日付チェック(tex登録日, "登録日")) return;
			// 文字チェック
			if (!禁則文字チェック(tex表題, "表題")) return;
			if (!禁則文字チェック(tex詳細内容, "詳細内容")) return;
			// バイト数チェック
			if (!バイト数チェック(tex表題, "表題", 60)) return;
			if (!バイト数チェック(tex詳細内容, "詳細内容", 2000)) return;
			if (!バイト数チェック(texボタン名, "ボタン名", 20)) return;
			if (!バイト数チェック(texアドレス, "アドレス", 150)) return;
			// ＵＲＬチェック
			if ((texアドレス.Text.Trim().Length > 0) && !ＵＲＬチェック(texアドレス, "アドレス")) return;
// DEL 2008.05.08 東都）高木 表題、詳細内容の全角半角混在チェックの追加 START
//			// 既存データの変更かどうかチェック
//			if (sシーケンスＮｏ == string.Empty) 
//			{
//				// 新規入力データの場合
//				ビープ音();
//				string msg = "お知らせを変更するには、[検索]を押して変更前のデータを指定して下さい。";
//				MessageBox.Show(msg, "入力チェック", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
//				return;
//			}
// DEL 2008.05.08 東都）高木 表題、詳細内容の全角半角混在チェックの追加 END
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
			if(cmb会員区分.SelectedIndex < 0){
				MessageBox.Show("会員区分が違います","入力チェック",MessageBoxButtons.OK);
				return;
			}
			cmb会員区分.Text
				= (string)cmb会員区分.Items[cmb会員区分.SelectedIndex];
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END

			// 最終確認
			if (MessageBox.Show("お知らせを変更します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No)
				return;

			// 空白除去 ＆ 変更データ設定
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			string [] sKey  = new string [10];
			string [] sKey  = new string [11];
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
			sKey[0] = DateTime.Parse(tex登録日.Text.Trim()).ToString("yyyyMMdd");
			sKey[1] = sシーケンスＮｏ;
			sKey[2] = d更新日時.ToString();
			sKey[3] = tex表題.Text.Trim();
			sKey[4] = tex詳細内容.Text.Trim();
			sKey[5] = texボタン名.Text.Trim();
			if (sKey[5].Length == 0) sKey[5] = " ";
			sKey[6] = texアドレス.Text.Trim();
			if (sKey[6].Length == 0) sKey[6] = " ";
			sKey[7] = "1";
			sKey[8] = gs利用者コード;
			sKey[9] = s登録日;
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
			if (cmb会員区分.SelectedIndex == 1){
				sKey[10] = "2";
			}else{
				sKey[10] = cmb会員区分.SelectedIndex.ToString();
			}
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END

			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			// お知らせの変更
			texメッセージ.Text = "変更中．．．";
			string [] sRet = new string [1];
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				sRet = sv_oshirase.Upd_Oshirase(gsaユーザ, sKey);
			}
			catch (System.Net.WebException)
			{
				// 通信エラー発生
				sRet[0] = gs通信エラー;
			}
			catch (Exception ex)
			{
				// その他のエラー発生
				sRet[0] = "通信エラー：" + ex.Message;
			}
			
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			// 結果処理
			switch (sRet[0].Trim()) 
			{
				case "正常終了" :
					this.項目クリア();
					texメッセージ.Text = "お知らせを変更しました。";
					tex登録日.Focus();

					break;

				default :
					texメッセージ.Text = sRet[0];
					ビープ音();
					tex登録日.Focus();

					break;
			}
		}

		private void btn削除_Click(object sender, System.EventArgs e)
		{
			// 入力チェック
			// 既存データの変更かどうかチェック
			if (sシーケンスＮｏ == string.Empty) 
			{
				// 新規入力データの場合
				ビープ音();
				string msg = "お知らせを削除するには、[検索]を押して削除するデータを指定して下さい。";
				MessageBox.Show(msg, "入力チェック", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			// 最終確認
			if (MessageBox.Show("このお知らせを本当に削除してもよろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No) 
				return;

			// 削除データ設定
			string [] sKey  = new string [4];
			sKey[0] = s登録日;
			sKey[1] = sシーケンスＮｏ;
			sKey[2] = d更新日時.ToString();
			sKey[3] = gs利用者コード;

			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			// お知らせの削除
			texメッセージ.Text = "削除中．．．";
			string [] sRet = new string [1];
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				sRet = sv_oshirase.Del_Oshirase(gsaユーザ, sKey);
			}
			catch (System.Net.WebException)
			{
				// 通信エラー発生
				sRet[0] = gs通信エラー;
			}
			catch (Exception ex)
			{
				// その他のエラー発生
				sRet[0] = "通信エラー：" + ex.Message;
			}
			
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			// 結果処理
			switch (sRet[0].Trim()) 
			{
				case "正常終了" :
					this.項目クリア();
					texメッセージ.Text = "お知らせを削除しました。";
					tex登録日.Focus();

					break;

				default :
					texメッセージ.Text = sRet[0];
					ビープ音();
					tex登録日.Focus();

					break;
			}
		}

// ADD 2008.02.07 KCL) 森本 お知らせ修正 START
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			// 日時の初期設定
			lab日時.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
		}
// ADD 2008.02.07 KCL) 森本 お知らせ修正 END
	}
}
// ADD 2007.12.05 KCL) 森本 お知らせ追加 END
