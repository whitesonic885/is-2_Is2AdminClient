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
	/// [お知らせ登録２]
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
	// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 
	//--------------------------------------------------------------------------
	public class お知らせ登録２ : 共通フォーム
	{
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
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
		private is2AdminClient.共通テキストボックス tex会員名;
		private System.Windows.Forms.Button btn会員検索;
		private System.Windows.Forms.Label lab会員コード;
		private is2AdminClient.共通テキストボックス tex会員コード;
		private System.Windows.Forms.Button btn会員実行;
		private System.Windows.Forms.Panel pnlお知らせ;
		private System.Windows.Forms.Label labお知らせ案内メッセージ;
		private is2AdminClient.共通テキストボックス texお知らせ案内メッセージ;
		private System.Windows.Forms.Label lab表示期間;
		private System.Windows.Forms.GroupBox gpお知らせ;
		private System.Windows.Forms.Label lab表示期間記号;
		private System.Windows.Forms.DateTimePicker dt表示期間開始;
		private System.Windows.Forms.DateTimePicker dt表示期間終了;
		private System.Windows.Forms.Label labメッセージ説明;
		private decimal d更新日時		= 0m;

		public お知らせ登録２()
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
			this.pnlお知らせ = new System.Windows.Forms.Panel();
			this.labメッセージ説明 = new System.Windows.Forms.Label();
			this.tex詳細内容 = new is2AdminClient.共通テキストボックス();
			this.lab表示期間記号 = new System.Windows.Forms.Label();
			this.dt表示期間開始 = new System.Windows.Forms.DateTimePicker();
			this.dt表示期間終了 = new System.Windows.Forms.DateTimePicker();
			this.lab表示期間 = new System.Windows.Forms.Label();
			this.texお知らせ案内メッセージ = new is2AdminClient.共通テキストボックス();
			this.labお知らせ案内メッセージ = new System.Windows.Forms.Label();
			this.btn検索 = new System.Windows.Forms.Button();
			this.lab詳細内容 = new System.Windows.Forms.Label();
			this.tex表題 = new is2AdminClient.共通テキストボックス();
			this.lab表題 = new System.Windows.Forms.Label();
			this.lab登録日 = new System.Windows.Forms.Label();
			this.tex登録日 = new is2AdminClient.共通テキストボックス();
			this.tex会員名 = new is2AdminClient.共通テキストボックス();
			this.btn会員検索 = new System.Windows.Forms.Button();
			this.lab会員コード = new System.Windows.Forms.Label();
			this.tex会員コード = new is2AdminClient.共通テキストボックス();
			this.btn会員実行 = new System.Windows.Forms.Button();
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
			this.gpお知らせ = new System.Windows.Forms.GroupBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pnlお知らせ.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.gpお知らせ.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlお知らせ
			// 
			this.pnlお知らせ.BackColor = System.Drawing.Color.Honeydew;
			this.pnlお知らせ.Controls.Add(this.labメッセージ説明);
			this.pnlお知らせ.Controls.Add(this.tex詳細内容);
			this.pnlお知らせ.Controls.Add(this.lab表示期間記号);
			this.pnlお知らせ.Controls.Add(this.dt表示期間開始);
			this.pnlお知らせ.Controls.Add(this.dt表示期間終了);
			this.pnlお知らせ.Controls.Add(this.lab表示期間);
			this.pnlお知らせ.Controls.Add(this.texお知らせ案内メッセージ);
			this.pnlお知らせ.Controls.Add(this.labお知らせ案内メッセージ);
			this.pnlお知らせ.Controls.Add(this.btn検索);
			this.pnlお知らせ.Controls.Add(this.lab詳細内容);
			this.pnlお知らせ.Controls.Add(this.tex表題);
			this.pnlお知らせ.Controls.Add(this.lab表題);
			this.pnlお知らせ.Controls.Add(this.lab登録日);
			this.pnlお知らせ.Controls.Add(this.tex登録日);
			this.pnlお知らせ.Controls.Add(this.tex会員名);
			this.pnlお知らせ.Controls.Add(this.btn会員検索);
			this.pnlお知らせ.Controls.Add(this.lab会員コード);
			this.pnlお知らせ.Controls.Add(this.tex会員コード);
			this.pnlお知らせ.Controls.Add(this.btn会員実行);
			this.pnlお知らせ.Location = new System.Drawing.Point(2, 6);
			this.pnlお知らせ.Name = "pnlお知らせ";
			this.pnlお知らせ.Size = new System.Drawing.Size(776, 444);
			this.pnlお知らせ.TabIndex = 1;
			// 
			// labメッセージ説明
			// 
			this.labメッセージ説明.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labメッセージ説明.ForeColor = System.Drawing.Color.LimeGreen;
			this.labメッセージ説明.Location = new System.Drawing.Point(102, 402);
			this.labメッセージ説明.Name = "labメッセージ説明";
			this.labメッセージ説明.Size = new System.Drawing.Size(540, 18);
			this.labメッセージ説明.TabIndex = 91;
			this.labメッセージ説明.Text = "※[お知らせ案内メッセージ]は、荷主用アプリのメニュー右下に設定期間内表示されます";
			// 
			// tex詳細内容
			// 
			this.tex詳細内容.BackColor = System.Drawing.SystemColors.Window;
			this.tex詳細内容.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex詳細内容.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex詳細内容.Location = new System.Drawing.Point(102, 102);
			this.tex詳細内容.MaxLength = 2000;
			this.tex詳細内容.Multiline = true;
			this.tex詳細内容.Name = "tex詳細内容";
			this.tex詳細内容.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tex詳細内容.Size = new System.Drawing.Size(664, 220);
			this.tex詳細内容.TabIndex = 3;
			this.tex詳細内容.Text = @"国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王";
			// 
			// lab表示期間記号
			// 
			this.lab表示期間記号.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab表示期間記号.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab表示期間記号.Location = new System.Drawing.Point(324, 380);
			this.lab表示期間記号.Name = "lab表示期間記号";
			this.lab表示期間記号.Size = new System.Drawing.Size(18, 16);
			this.lab表示期間記号.TabIndex = 90;
			this.lab表示期間記号.Text = "～";
			this.lab表示期間記号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dt表示期間開始
			// 
			this.dt表示期間開始.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt表示期間開始.Location = new System.Drawing.Point(178, 376);
			this.dt表示期間開始.Name = "dt表示期間開始";
			this.dt表示期間開始.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt表示期間開始.Size = new System.Drawing.Size(144, 23);
			this.dt表示期間開始.TabIndex = 9;
			// 
			// dt表示期間終了
			// 
			this.dt表示期間終了.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt表示期間終了.Location = new System.Drawing.Point(344, 376);
			this.dt表示期間終了.Name = "dt表示期間終了";
			this.dt表示期間終了.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt表示期間終了.Size = new System.Drawing.Size(144, 23);
			this.dt表示期間終了.TabIndex = 10;
			// 
			// lab表示期間
			// 
			this.lab表示期間.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab表示期間.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab表示期間.Location = new System.Drawing.Point(100, 378);
			this.lab表示期間.Name = "lab表示期間";
			this.lab表示期間.Size = new System.Drawing.Size(76, 18);
			this.lab表示期間.TabIndex = 87;
			this.lab表示期間.Text = "表示期間";
			// 
			// texお知らせ案内メッセージ
			// 
			this.texお知らせ案内メッセージ.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.texお知らせ案内メッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texお知らせ案内メッセージ.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.texお知らせ案内メッセージ.Location = new System.Drawing.Point(102, 350);
			this.texお知らせ案内メッセージ.MaxLength = 100;
			this.texお知らせ案内メッセージ.Name = "texお知らせ案内メッセージ";
			this.texお知らせ案内メッセージ.Size = new System.Drawing.Size(664, 23);
			this.texお知らせ案内メッセージ.TabIndex = 8;
			this.texお知らせ案内メッセージ.Text = "国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王";
			// 
			// labお知らせ案内メッセージ
			// 
			this.labお知らせ案内メッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labお知らせ案内メッセージ.ForeColor = System.Drawing.Color.LimeGreen;
			this.labお知らせ案内メッセージ.Location = new System.Drawing.Point(4, 352);
			this.labお知らせ案内メッセージ.Name = "labお知らせ案内メッセージ";
			this.labお知らせ案内メッセージ.Size = new System.Drawing.Size(98, 36);
			this.labお知らせ案内メッセージ.TabIndex = 85;
			this.labお知らせ案内メッセージ.Text = "お知らせ案内メッセージ";
			// 
			// btn検索
			// 
			this.btn検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btn検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn検索.ForeColor = System.Drawing.Color.White;
			this.btn検索.Location = new System.Drawing.Point(236, 10);
			this.btn検索.Name = "btn検索";
			this.btn検索.Size = new System.Drawing.Size(48, 22);
			this.btn検索.TabIndex = 1;
			this.btn検索.TabStop = false;
			this.btn検索.Text = "検索";
			this.btn検索.Click += new System.EventHandler(this.btn検索_Click);
			// 
			// lab詳細内容
			// 
			this.lab詳細内容.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab詳細内容.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab詳細内容.Location = new System.Drawing.Point(4, 104);
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
			this.tex表題.Location = new System.Drawing.Point(102, 72);
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
			this.lab表題.Location = new System.Drawing.Point(4, 74);
			this.lab表題.Name = "lab表題";
			this.lab表題.Size = new System.Drawing.Size(76, 18);
			this.lab表題.TabIndex = 77;
			this.lab表題.Text = "表　題";
			// 
			// lab登録日
			// 
			this.lab登録日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab登録日.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab登録日.Location = new System.Drawing.Point(4, 12);
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
			this.tex登録日.Location = new System.Drawing.Point(102, 10);
			this.tex登録日.MaxLength = 10;
			this.tex登録日.Name = "tex登録日";
			this.tex登録日.Size = new System.Drawing.Size(130, 23);
			this.tex登録日.TabIndex = 0;
			this.tex登録日.Text = "123";
			// 
			// tex会員名
			// 
			this.tex会員名.BackColor = System.Drawing.Color.Honeydew;
			this.tex会員名.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex会員名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex会員名.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex会員名.Location = new System.Drawing.Point(342, 46);
			this.tex会員名.MaxLength = 20;
			this.tex会員名.Name = "tex会員名";
			this.tex会員名.ReadOnly = true;
			this.tex会員名.Size = new System.Drawing.Size(324, 16);
			this.tex会員名.TabIndex = 55;
			this.tex会員名.TabStop = false;
			this.tex会員名.Text = "";
			// 
			// btn会員検索
			// 
			this.btn会員検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btn会員検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn会員検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn会員検索.ForeColor = System.Drawing.Color.White;
			this.btn会員検索.Location = new System.Drawing.Point(236, 42);
			this.btn会員検索.Name = "btn会員検索";
			this.btn会員検索.Size = new System.Drawing.Size(48, 22);
			this.btn会員検索.TabIndex = 13;
			this.btn会員検索.TabStop = false;
			this.btn会員検索.Text = "検索";
			this.btn会員検索.Click += new System.EventHandler(this.btn会員検索_Click);
			// 
			// lab会員コード
			// 
			this.lab会員コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.lab会員コード.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab会員コード.Location = new System.Drawing.Point(4, 44);
			this.lab会員コード.Name = "lab会員コード";
			this.lab会員コード.Size = new System.Drawing.Size(88, 18);
			this.lab会員コード.TabIndex = 56;
			this.lab会員コード.Text = "お客様ｺｰﾄﾞ";
			// 
			// tex会員コード
			// 
			this.tex会員コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex会員コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex会員コード.Location = new System.Drawing.Point(102, 42);
			this.tex会員コード.MaxLength = 10;
			this.tex会員コード.Name = "tex会員コード";
			this.tex会員コード.Size = new System.Drawing.Size(130, 23);
			this.tex会員コード.TabIndex = 0;
			this.tex会員コード.Text = "";
			this.tex会員コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex会員コード_KeyDown);
			this.tex会員コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex会員コード_KeyPress);
			// 
			// btn会員実行
			// 
			this.btn会員実行.BackColor = System.Drawing.Color.Blue;
			this.btn会員実行.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn会員実行.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn会員実行.ForeColor = System.Drawing.Color.White;
			this.btn会員実行.Location = new System.Drawing.Point(288, 42);
			this.btn会員実行.Name = "btn会員実行";
			this.btn会員実行.Size = new System.Drawing.Size(48, 22);
			this.btn会員実行.TabIndex = 1;
			this.btn会員実行.Text = "実行";
			this.btn会員実行.Click += new System.EventHandler(this.btn会員実行_Click);
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
			// gpお知らせ
			// 
			this.gpお知らせ.Controls.Add(this.pnlお知らせ);
			this.gpお知らせ.Location = new System.Drawing.Point(8, 58);
			this.gpお知らせ.Name = "gpお知らせ";
			this.gpお知らせ.Size = new System.Drawing.Size(780, 452);
			this.gpお知らせ.TabIndex = 1;
			this.gpお知らせ.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// お知らせ登録２
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 574);
			this.Controls.Add(this.gpお知らせ);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "お知らせ登録２";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 お知らせ登録";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動２);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル２);
			this.Load += new System.EventHandler(this.出荷状況_Load);
			this.pnlお知らせ.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.gpお知らせ.ResumeLayout(false);
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

//保留 MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//保留			// 部門リストの初期設定
//保留			axGT部門.Cols = 4;
//保留			axGT部門.Rows = 4;
//保留			axGT部門.ColSep = "|";
//保留			axGT部門.CaretRow = 1;
//保留			axGT部門.NoBeep = true;
//保留
//保留			axGT部門.set_RowsText(0, "|コード|セクション名|出力順|郵便番号|");
//保留			axGT部門.ColsWidth = "0|7|20|0|0|";
//保留			axGT部門.ColsAlignHorz = "1|1|0|2|1|";
//保留            
//保留			axGT部門.set_CelForeColor(axGT部門.CaretRow,0,0x98FB98);  //BGR
//保留			axGT部門.set_CelBackColor(axGT部門.CaretRow,0,0x006000);
//保留
//保留			axGT部門.Clear();
//保留			axGT部門.CaretCol = 1;
//保留			axGT部門_CurPlaceChanged(null,null);
//保留 MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
			// 表示の初期化
			項目クリア();

			// フォーカス設定
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			tex表題.Focus();
			tex会員コード.Focus();
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
		}

		private void 項目クリア()
		{
			// 表示クリア
			tex登録日.Text		= DateTime.Now.ToString("yyyy/MM/dd");
			tex表題.Text			= string.Empty;
			tex詳細内容.Text		= string.Empty;
			texメッセージ.Text	= string.Empty;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			texボタン名.Text		= "詳細";
//			texアドレス.Text		= string.Empty;
//// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			cmb会員区分.SelectedIndex = 0;
//			cmb会員区分.Text
//				= (string)cmb会員区分.Items[cmb会員区分.SelectedIndex];
//// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
			tex会員コード.Text = string.Empty;
			tex会員名.Text	   = string.Empty;
//			texお知らせ案内メッセージ.Text = string.Empty;
			texお知らせ案内メッセージ.Text = "★重要なご案内★　お知らせを参照して下さい";
			dt表示期間開始.Value = DateTime.Now;
			dt表示期間終了.Value = DateTime.Now.AddDays(6);
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END

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
			if (gお知検２ == null) gお知検２ = new お知らせ検索２();
			gお知検２.Left = this.Left + 202;
			gお知検２.Top  = this.Top;
			gお知検２.項目クリア();
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
			tex会員コード.Text = tex会員コード.Text.TrimEnd();
			if (!半角チェック(tex会員コード, "お客様コード")) return;
			gお知検２.s会員ＣＤ = tex会員コード.Text;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
			gお知検２.ShowDialog(this);

			// 結果表示
			if (gお知検２.s表題.Trim().Length != 0)
			{
				// 検索結果あり
				tex登録日.Text	= YYYYMMDD変換(gお知検２.s登録日).ToString("yyyy/MM/dd");
				tex表題.Text		= gお知検２.s表題;
				tex詳細内容.Text	= gお知検２.s詳細内容;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//				texボタン名.Text	= gお知検２.sボタン名;
//				texアドレス.Text	= gお知検２.sアドレス;
				tex会員コード.Text	= gお知検２.s会員ＣＤ;
				tex会員名.Text	    = gお知検２.s会員名;
				dt表示期間開始.Value = YYYYMMDD変換(gお知検２.s表示期間開始);
				dt表示期間終了.Value = YYYYMMDD変換(gお知検２.s表示期間終了);
				texお知らせ案内メッセージ.Text 
									 = gお知検２.sメッセージ;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
				s優先順			= gお知検２.s優先順;
				s登録日			= gお知検２.s登録日;
				sシーケンスＮｏ	= gお知検２.sシーケンスＮｏ;
				d更新日時		= gお知検２.d更新日時;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//				if (gお知検索.s会員区分.Equals("2")){
//					cmb会員区分.SelectedIndex = 1;
//				}else{
//					cmb会員区分.SelectedIndex = int.Parse(gお知検索.s会員区分);
//				}
//				cmb会員区分.Text
//						= (string)cmb会員区分.Items[cmb会員区分.SelectedIndex];
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
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
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
			// Trim
			tex登録日.Text = tex登録日.Text.TrimEnd();
			tex会員コード.Text = tex会員コード.Text.TrimEnd();
			tex表題.Text = tex表題.Text.TrimEnd();
			tex詳細内容.Text = tex詳細内容.Text.TrimEnd();
			texお知らせ案内メッセージ.Text = texお知らせ案内メッセージ.Text.TrimEnd();

//			if (!必須チェック(tex会員コード, "お客様コード")) return;
			if(tex会員コード.Text.Trim().Length == 0){
				if(MessageBox.Show(
						"お客様コードが設定されていません。\n"
						+ "管轄の荷主全てにお知らせが表示されます。\n"
						+ "よろしいですか？"
						, "入力チェック"
						, MessageBoxButtons.YesNo) == DialogResult.No){
					tex会員コード.Focus();
					return;
				}
			}
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
			// 入力チェック
			if (!必須チェック(tex登録日, "登録日")) return;
			if (!必須チェック(tex表題, "表題")) return;
			if (!必須チェック(tex詳細内容, "詳細内容")) return;

// ADD 2008.05.07 東都）高木 表題、詳細内容の全角半角混在チェックの追加 START
			if (!全角半角混在チェック(tex表題, "表題")) return;
			if (!全角半角混在チェック(tex詳細内容, "詳細内容")) return;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			if (!全角半角混在チェック(texボタン名, "ボタン名")) return;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
// ADD 2008.05.07 東都）高木 表題、詳細内容の全角半角混在チェックの追加 END

			// 型チェック
			if (!日付チェック(tex登録日, "登録日")) return;
			// 文字チェック
			if (!禁則文字チェック(tex表題, "表題")) return;
			if (!禁則文字チェック(tex詳細内容, "詳細内容")) return;
			// バイト数チェック
			if (!バイト数チェック(tex表題, "表題", 60)) return;
			if (!バイト数チェック(tex詳細内容, "詳細内容", 2000)) return;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			if (!バイト数チェック(texボタン名, "ボタン名", 20)) return;
//			if (!バイト数チェック(texアドレス, "アドレス", 150)) return;
//			// ＵＲＬチェック
//			if ((texアドレス.Text.Trim().Length > 0) && !ＵＲＬチェック(texアドレス, "アドレス")) return;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			if(cmb会員区分.SelectedIndex < 0){
//				MessageBox.Show("会員区分が違います","入力チェック",MessageBoxButtons.OK);
//				return;
//			}
//			cmb会員区分.Text
//				= (string)cmb会員区分.Items[cmb会員区分.SelectedIndex];
			//表示期間チェック
			string s表示期間開始 = dt表示期間開始.Value.ToString("yyyyMMdd");
			string s表示期間終了 = dt表示期間終了.Value.ToString("yyyyMMdd");
			if(s表示期間開始.CompareTo(s表示期間終了) > 0){
				MessageBox.Show("表示期間終了日に誤りがあります。"
								,"入力チェック"
								,MessageBoxButtons.OK);
				dt表示期間終了.Focus();
				return;
			}
			string s表示期間終了上限 = dt表示期間開始.Value.AddDays(6).ToString("yyyyMMdd");
			if(s表示期間終了.CompareTo(s表示期間終了上限) > 0){
				MessageBox.Show("表示期間は、開始日より最長７日間です。"
								,"入力チェック"
								,MessageBoxButtons.OK);
				dt表示期間終了.Focus();
				return;
			}
			if (!半角チェック(tex会員コード, "お客様コード")) return;
			if (!禁則文字チェック(texお知らせ案内メッセージ, "お知らせ案内メッセージ")) return;
			if (!バイト数チェック(texお知らせ案内メッセージ, "お知らせ案内メッセージ", 200)) return;
			// 会員マスタ存在チェック
			if(!会員名検索()){
				MessageBox.Show("お客様(" + tex会員コード.Text + ")が存在しません"
								,"入力チェック"
								,MessageBoxButtons.OK);
				tex会員コード.Focus();
				return;
			}
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END

			// 最終確認
			if (MessageBox.Show("お知らせを新規登録します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No)
				return;

			// 空白除去 ＆ 登録データ設定
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			string [] sKey  = new string [7];
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			string [] sKey  = new string [8];
			string [] sKey  = new string [13];
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
			sKey[0] = DateTime.Parse(tex登録日.Text.Trim()).ToString("yyyyMMdd");
			sKey[1] = tex表題.Text.Trim();
			sKey[2] = tex詳細内容.Text.Trim();
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			sKey[3] = texボタン名.Text.Trim();
//			if (sKey[3].Length == 0) sKey[3] = " ";
//			sKey[4] = texアドレス.Text.Trim();
//			if (sKey[4].Length == 0) sKey[4] = " ";
			sKey[3] = " ";
			sKey[4] = " ";
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
			sKey[5] = "1";
			sKey[6] = gs利用者コード;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			if (cmb会員区分.SelectedIndex == 1){
//				sKey[7] = "2";
//			}else{
//				sKey[7] = cmb会員区分.SelectedIndex.ToString();
//			}
			sKey[7] = "0";	// 一般荷主
			sKey[8] = gs店所コード.Trim();
			if(sKey[8].Length == 0) sKey[8] = " ";
			sKey[9] = tex会員コード.Text;
			if(sKey[9].Length == 0) sKey[9] = " ";
			sKey[10] = texお知らせ案内メッセージ.Text;
			if(sKey[10].Length == 0) sKey[10] = " ";
			sKey[11] = dt表示期間開始.Value.ToString("yyyyMMdd");
			sKey[12] = dt表示期間終了.Value.ToString("yyyyMMdd");
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END

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

// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
			// Trim
			tex登録日.Text = tex登録日.Text.TrimEnd();
			tex会員コード.Text = tex会員コード.Text.TrimEnd();
			tex表題.Text = tex表題.Text.TrimEnd();
			tex詳細内容.Text = tex詳細内容.Text.TrimEnd();
			texお知らせ案内メッセージ.Text = texお知らせ案内メッセージ.Text.TrimEnd();

//			if (!必須チェック(tex会員コード, "お客様コード")) return;
			if(tex会員コード.Text.Trim().Length == 0){
				if(MessageBox.Show(
						"お客様コードが設定されていません。\n"
						+ "管轄の荷主全てにお知らせが表示されます。\n"
						+ "よろしいですか？"
						, "入力チェック"
						, MessageBoxButtons.YesNo) == DialogResult.No){
					tex会員コード.Focus();
					return;
				}
			}
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
			// 入力チェック
			if (!必須チェック(tex登録日, "登録日")) return;
			if (!必須チェック(tex表題, "表題")) return;
			if (!必須チェック(tex詳細内容, "詳細内容")) return;

// ADD 2008.05.08 東都）高木 表題、詳細内容の全角半角混在チェックの追加 START
			if (!全角半角混在チェック(tex表題, "表題")) return;
			if (!全角半角混在チェック(tex詳細内容, "詳細内容")) return;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			if (!全角半角混在チェック(texボタン名, "ボタン名")) return;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
// ADD 2008.05.08 東都）高木 表題、詳細内容の全角半角混在チェックの追加 END

			// 型チェック
			if (!日付チェック(tex登録日, "登録日")) return;
			// 文字チェック
			if (!禁則文字チェック(tex表題, "表題")) return;
			if (!禁則文字チェック(tex詳細内容, "詳細内容")) return;
			// バイト数チェック
			if (!バイト数チェック(tex表題, "表題", 60)) return;
			if (!バイト数チェック(tex詳細内容, "詳細内容", 2000)) return;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			if (!バイト数チェック(texボタン名, "ボタン名", 20)) return;
//			if (!バイト数チェック(texアドレス, "アドレス", 150)) return;
//			// ＵＲＬチェック
//			if ((texアドレス.Text.Trim().Length > 0) && !ＵＲＬチェック(texアドレス, "アドレス")) return;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
			//表示期間チェック
			string s表示期間開始 = dt表示期間開始.Value.ToString("yyyyMMdd");
			string s表示期間終了 = dt表示期間終了.Value.ToString("yyyyMMdd");
			if(s表示期間開始.CompareTo(s表示期間終了) > 0){
				MessageBox.Show("表示期間終了日に誤りがあります。"
								,"入力チェック"
								,MessageBoxButtons.OK);
				dt表示期間終了.Focus();
				return;
			}
			string s表示期間終了上限 = dt表示期間開始.Value.AddDays(6).ToString("yyyyMMdd");
			if(s表示期間終了.CompareTo(s表示期間終了上限) > 0){
				MessageBox.Show("表示期間は、開始日より最長７日間です。"
								,"入力チェック"
								,MessageBoxButtons.OK);
				dt表示期間終了.Focus();
				return;
			}
			if (!半角チェック(tex会員コード, "お客様コード")) return;
			if (!禁則文字チェック(texお知らせ案内メッセージ, "お知らせ案内メッセージ")) return;
			if (!バイト数チェック(texお知らせ案内メッセージ, "お知らせ案内メッセージ", 200)) return;
			// 会員マスタ存在チェック
			if(!会員名検索()){
				MessageBox.Show("お客様(" + tex会員コード.Text + ")が存在しません"
								,"入力チェック"
								,MessageBoxButtons.OK);
				tex会員コード.Focus();
				return;
			}
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
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
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			if(cmb会員区分.SelectedIndex < 0){
//				MessageBox.Show("会員区分が違います","入力チェック",MessageBoxButtons.OK);
//				return;
//			}
//			cmb会員区分.Text
//				= (string)cmb会員区分.Items[cmb会員区分.SelectedIndex];
//// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END

			// 最終確認
			if (MessageBox.Show("お知らせを変更します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No)
				return;

			// 空白除去 ＆ 変更データ設定
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			string [] sKey  = new string [10];
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			string [] sKey  = new string [11];
			string [] sKey  = new string [16];
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
			sKey[0] = DateTime.Parse(tex登録日.Text.Trim()).ToString("yyyyMMdd");
			sKey[1] = sシーケンスＮｏ;
			sKey[2] = d更新日時.ToString();
			sKey[3] = tex表題.Text.Trim();
			sKey[4] = tex詳細内容.Text.Trim();
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//			sKey[5] = texボタン名.Text.Trim();
//			if (sKey[5].Length == 0) sKey[5] = " ";
//			sKey[6] = texアドレス.Text.Trim();
//			if (sKey[6].Length == 0) sKey[6] = " ";
			sKey[5] = " ";
			sKey[6] = " ";
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
			sKey[7] = "1";
			sKey[8] = gs利用者コード;
			sKey[9] = s登録日;
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
//// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			if (cmb会員区分.SelectedIndex == 1){
//				sKey[10] = "2";
//			}else{
//				sKey[10] = cmb会員区分.SelectedIndex.ToString();
//			}
//// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
			sKey[10] = "0";	// 一般荷主
			sKey[11] = gs店所コード.Trim();
			if(sKey[11].Length == 0) sKey[11] = " ";
			sKey[12] = tex会員コード.Text;
			if(sKey[12].Length == 0) sKey[12] = " ";
			sKey[13] = texお知らせ案内メッセージ.Text;
			if(sKey[13].Length == 0) sKey[13] = " ";
			sKey[14] = dt表示期間開始.Value.ToString("yyyyMMdd");
			sKey[15] = dt表示期間終了.Value.ToString("yyyyMMdd");
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
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
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 START
		private void btn会員検索_Click(object sender, System.EventArgs e)
		{
//			tex会員コード.Text = tex会員コード.Text.Trim();
//			if(!半角チェック(tex会員コード, "お客様コード")) return;

			// 検索画面を右側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			if (g会員検索 == null)	 g会員検索 = new 会員検索();
			g会員検索.Left = this.Left + 404;
			g会員検索.Top = this.Top;
			// コードの初期表示
			g会員検索.s会員コード = "";
			g会員検索.s会員名 = "";
			g会員検索.s店所コード = gs店所コード.Trim();
			g会員検索.ShowDialog();
			g会員検索.s店所コード = "";
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g会員検索.s会員コード.Trim().Length > 0){
				tex会員コード.Text = g会員検索.s会員コード;
				tex会員名.Text     = g会員検索.s会員名;
				btn会員実行.Focus();
				btn会員実行_Click(sender, e);
			}else{
				tex会員コード.Focus();
			}
		}

		private void btn会員実行_Click(object sender, System.EventArgs e)
		{
			tex会員コード.Text = tex会員コード.Text.Trim();
			if(tex会員コード.Text.Length == 0) return;
//			if(!必須チェック(tex会員コード, "お客様コード")) return;
			if(!半角チェック(tex会員コード, "お客様コード")) return;
			//会員チェック
			if(会員名検索()){
//保留				部門情報検索(tex会員コード.Text);
				tex表題.Focus();
			}else{
				MessageBox.Show("お客様(" + tex会員コード.Text + ")が存在しません"
								,"入力チェック"
								,MessageBoxButtons.OK);
				tex会員コード.Focus();
				return;
			}
		}
		private bool 会員名検索()
		{
			tex会員名.Text = "";
			if(tex会員コード.Text.Length == 0) return true;
			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool bRet = false;
			try{
				string[] sKey = new string[2];
				String[] sList;
				sKey[0] = tex会員コード.Text;
				sKey[1] = gs店所コード.Trim();
				if(gs店所コード.Trim().Length != 0){
					sList = sv_maintenance.Sel_MemberTn(gsaユーザ, sKey);
				}else{
					sList = sv_maintenance.Sel_Member(gsaユーザ, sKey);
				}
				if(sList[0].Length == 4){
					texメッセージ.Text = "";
					tex会員名.Text = sList[2];
//					s会員更新日時 = sList[6];
//					if(sList.Length < 8){
//						cb出荷実績一覧運賃非表示.Enabled = false;
//						btn会員更新.Enabled = false;
//					}else{
//						if(sList[7].Equals("1")){
//							cb出荷実績一覧運賃非表示.Checked = true;
//						}else{
//							cb出荷実績一覧運賃非表示.Checked = false;
//						}
//						btn会員更新.Enabled = true;
//					}
					bRet = true;
				}else{
					texメッセージ.Text = sList[0];
					ビープ音();
					tex会員名.Text = "";
					tex会員コード.Focus();
				}
			}catch (Exception ex){
				texメッセージ.Text = ex.Message;
				ビープ音();
//				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return bRet;
		}
//保留		private void 部門情報検索(string s会員コード)
//保留		{
//保留			axGT部門.Clear();
//保留			axGT部門.Rows = 4;
//保留			axGT部門.CaretRow = 1;
//保留			axGT部門.CaretCol = 1;
//保留			axGT部門_CurPlaceChanged(null,null);
//保留			
//保留			try{
//保留				string[] sKey  = new string[3];
//保留				sKey[0] = s会員コード;
//保留				sKey[1] = "";
//保留				sKey[2] = "";
//保留				string[] sList = sv_maintenance.Get_Section(gsaユーザ, sKey);
//保留
//保留				if (sList[0].Equals("正常終了") || sList[0].Equals("該当データがありません"))
//保留				{
//保留					texメッセージ.Text = "";
//保留					if (axGT部門.Rows < sList.Length - 1)
//保留					{
//保留						axGT部門.Rows = (short)(sList.Length - 1);
//保留					}
//保留					for(short sCnt = 1; sCnt < sList.Length; sCnt++)
//保留					{
//保留						axGT部門.set_RowsText(sCnt, sList[sCnt]);
//保留					}
//保留					tex表題.Focus();
//保留				}
//保留				else
//保留				{
//保留					texメッセージ.Text = sList[0];
//保留					throw new Exception(sList[0]);
//保留				}
//保留			}
//保留			catch (Exception ex)
//保留			{
//保留				throw new Exception(ex.Message);
//保留			}
//保留		}
//保留		private short nOldRowB = 0;
//保留		private void axGT部門_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
//保留		{
//保留			axGT部門.set_CelForeColor(nOldRowB,0,0);
//保留			axGT部門.set_CelBackColor(nOldRowB,0,0xFFFFFF);
//保留//			axGT部門.set_CelForeColor(axGT部門.CaretRow,0,111111);
//保留			axGT部門.set_CelForeColor(axGT部門.CaretRow,0,0x98FB98);  //BGR
//保留			axGT部門.set_CelBackColor(axGT部門.CaretRow,0,0x006000);
//保留			nOldRowB = axGT部門.CaretRow;
//保留		}

		private void tex会員コード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
				texメッセージ.Text = "";
				btn会員実行_Click(sender, null);
			}
		}

		private void tex会員コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar.ToString().Equals("*")){
				btn会員検索.Focus();
				btn会員検索_Click(sender, null);
				e.Handled = true;
			}
		}

		private void エンター移動２(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(this.ActiveControl.Equals(tex詳細内容)) return;
			base.エンター移動(sender, e);
		}

		private void エンターキャンセル２(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(this.ActiveControl.Equals(tex詳細内容)) return;
			base.エンターキャンセル(sender, e);
		}
// MOD 2010.07.01 東都）高木 営業所用お知らせ登録機能の追加 END
	}
}
// ADD 2007.12.05 KCL) 森本 お知らせ追加 END
