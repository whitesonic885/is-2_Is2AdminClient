using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [請求先情報メンテナンス]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// MOD 2008.05.02 東都）高木 管理店所の制御の修正 
	// ADD 2008.11.20 東都）高木 得意先部課コードの空白時対応 
	//                Oracle入替時の設定移行もれ？ or バージョンによる差異
	//--------------------------------------------------------------------------
	// MOD 2009.05.28 東都）高木 出荷実績一覧運賃非表示対応 
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	//--------------------------------------------------------------------------
	// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 
	//--------------------------------------------------------------------------
	// MOD 2016.03.16 BEVAS）松本 王子運送版グローバル運用対応 
	//--------------------------------------------------------------------------
	// MOD 2016.04.13 BEVAS）松本 社内伝票対応
	//--------------------------------------------------------------------------
	public class 請求先マスタ : 共通フォーム
	{
// DEL 2007.01.18 東都）高木 画面レイアウト変更 START
//		private string s管理店所コード = "";
// DEL 2007.01.18 東都）高木 画面レイアウト変更 END
		private string s郵便番号 = "";
		private string s更新日時 = "";
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 START
		private string s会員ＣＤ = "";
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 END
		private short nOldRow = 0;
// MOD 2009.05.28 東都）高木 出荷実績一覧運賃非表示対応 START
		private string s会員更新日時 = "";
// MOD 2009.05.28 東都）高木 出荷実績一覧運賃非表示対応 END

		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lab日時;
		private System.Windows.Forms.Label lab記事コード;
		private 共通テキストボックス texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lab請求先タイトル;
		private 共通テキストボックス tex管理店所コード;
		private System.Windows.Forms.Label lab得意先部課名;
		private System.Windows.Forms.Label lab会員コード;
		private 共通テキストボックス tex会員コード;
		private System.Windows.Forms.Button btn管理店所検索;
		private System.Windows.Forms.Button btn会員検索;
		private 共通テキストボックス tex会員名;
		private System.Windows.Forms.Button btn請求先取消;
		private System.Windows.Forms.Button btn請求先削除;
		private System.Windows.Forms.Button btn請求先登録;
		private System.Windows.Forms.Label lab管理店所名;
		private 共通テキストボックス tex管理店所名;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lab得意先コード;
		private System.Windows.Forms.Label lab得意先部課コード;
		private AxGTABLE32V2Lib.AxGTable32 axGT請求先;
		private 共通テキストボックス tex得意先コード;
		private 共通テキストボックス tex得意先部課コード;
		private 共通テキストボックス tex得意先部課名;
		private System.Windows.Forms.Panel pnl請求先;
		private 共通テキストボックス tex認証利用者名;
		private System.Windows.Forms.Label lab認証利用者名;
		private System.Windows.Forms.Label lab認証会員名;
		private 共通テキストボックス tex認証会員名;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lab郵便番号;
		private System.Windows.Forms.Button btn住所検索;
		private 共通テキストボックス tex郵便番号２;
		private 共通テキストボックス tex郵便番号１;
		private System.Windows.Forms.Label label10;
		private 共通テキストボックス tex郵便番号店所;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private is2AdminClient.共通テキストボックス tex部門数;
		private System.Windows.Forms.Button btn会員実行;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cb出荷実績一覧運賃非表示;
		private System.Windows.Forms.Button btn会員更新;
		private System.Windows.Forms.GroupBox gpお客様;
		private System.ComponentModel.IContainer components;

		public 請求先マスタ()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(請求先マスタ));
            this.pnl請求先 = new System.Windows.Forms.Panel();
            this.btn会員更新 = new System.Windows.Forms.Button();
            this.cb出荷実績一覧運賃非表示 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tex部門数 = new is2AdminClient.共通テキストボックス();
            this.label5 = new System.Windows.Forms.Label();
            this.tex郵便番号店所 = new is2AdminClient.共通テキストボックス();
            this.btn住所検索 = new System.Windows.Forms.Button();
            this.tex郵便番号２ = new is2AdminClient.共通テキストボックス();
            this.tex郵便番号１ = new is2AdminClient.共通テキストボックス();
            this.label10 = new System.Windows.Forms.Label();
            this.lab郵便番号 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tex得意先部課名 = new is2AdminClient.共通テキストボックス();
            this.tex得意先部課コード = new is2AdminClient.共通テキストボックス();
            this.tex得意先コード = new is2AdminClient.共通テキストボックス();
            this.lab得意先部課コード = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab得意先コード = new System.Windows.Forms.Label();
            this.axGT請求先 = new AxGTABLE32V2Lib.AxGTable32();
            this.tex管理店所名 = new is2AdminClient.共通テキストボックス();
            this.lab管理店所名 = new System.Windows.Forms.Label();
            this.btn請求先取消 = new System.Windows.Forms.Button();
            this.btn請求先削除 = new System.Windows.Forms.Button();
            this.btn請求先登録 = new System.Windows.Forms.Button();
            this.tex会員名 = new is2AdminClient.共通テキストボックス();
            this.btn会員検索 = new System.Windows.Forms.Button();
            this.lab得意先部課名 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lab会員コード = new System.Windows.Forms.Label();
            this.tex会員コード = new is2AdminClient.共通テキストボックス();
            this.btn会員実行 = new System.Windows.Forms.Button();
            this.gpお客様 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn管理店所検索 = new System.Windows.Forms.Button();
            this.lab記事コード = new System.Windows.Forms.Label();
            this.tex管理店所コード = new is2AdminClient.共通テキストボックス();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tex認証利用者名 = new is2AdminClient.共通テキストボックス();
            this.lab認証利用者名 = new System.Windows.Forms.Label();
            this.lab認証会員名 = new System.Windows.Forms.Label();
            this.tex認証会員名 = new is2AdminClient.共通テキストボックス();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab日時 = new System.Windows.Forms.Label();
            this.lab請求先タイトル = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.texメッセージ = new is2AdminClient.共通テキストボックス();
            this.btn閉じる = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnl請求先.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT請求先)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl請求先
            // 
            this.pnl請求先.BackColor = System.Drawing.Color.Honeydew;
            this.pnl請求先.Controls.Add(this.btn会員更新);
            this.pnl請求先.Controls.Add(this.cb出荷実績一覧運賃非表示);
            this.pnl請求先.Controls.Add(this.label4);
            this.pnl請求先.Controls.Add(this.tex部門数);
            this.pnl請求先.Controls.Add(this.label5);
            this.pnl請求先.Controls.Add(this.tex郵便番号店所);
            this.pnl請求先.Controls.Add(this.btn住所検索);
            this.pnl請求先.Controls.Add(this.tex郵便番号２);
            this.pnl請求先.Controls.Add(this.tex郵便番号１);
            this.pnl請求先.Controls.Add(this.label10);
            this.pnl請求先.Controls.Add(this.lab郵便番号);
            this.pnl請求先.Controls.Add(this.label2);
            this.pnl請求先.Controls.Add(this.tex得意先部課名);
            this.pnl請求先.Controls.Add(this.tex得意先部課コード);
            this.pnl請求先.Controls.Add(this.tex得意先コード);
            this.pnl請求先.Controls.Add(this.lab得意先部課コード);
            this.pnl請求先.Controls.Add(this.label3);
            this.pnl請求先.Controls.Add(this.lab得意先コード);
            this.pnl請求先.Controls.Add(this.axGT請求先);
            this.pnl請求先.Controls.Add(this.tex管理店所名);
            this.pnl請求先.Controls.Add(this.lab管理店所名);
            this.pnl請求先.Controls.Add(this.btn請求先取消);
            this.pnl請求先.Controls.Add(this.btn請求先削除);
            this.pnl請求先.Controls.Add(this.btn請求先登録);
            this.pnl請求先.Controls.Add(this.tex会員名);
            this.pnl請求先.Controls.Add(this.btn会員検索);
            this.pnl請求先.Controls.Add(this.lab得意先部課名);
            this.pnl請求先.Controls.Add(this.label1);
            this.pnl請求先.Controls.Add(this.label22);
            this.pnl請求先.Controls.Add(this.lab会員コード);
            this.pnl請求先.Controls.Add(this.tex会員コード);
            this.pnl請求先.Controls.Add(this.btn会員実行);
            this.pnl請求先.Controls.Add(this.gpお客様);
            this.pnl請求先.Location = new System.Drawing.Point(1, 6);
            this.pnl請求先.Name = "pnl請求先";
            this.pnl請求先.Size = new System.Drawing.Size(667, 366);
            this.pnl請求先.TabIndex = 1;
            // 
            // btn会員更新
            // 
            this.btn会員更新.BackColor = System.Drawing.Color.Blue;
            this.btn会員更新.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn会員更新.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn会員更新.ForeColor = System.Drawing.Color.White;
            this.btn会員更新.Location = new System.Drawing.Point(600, 64);
            this.btn会員更新.Name = "btn会員更新";
            this.btn会員更新.Size = new System.Drawing.Size(48, 22);
            this.btn会員更新.TabIndex = 90;
            this.btn会員更新.Text = "更新";
            this.btn会員更新.UseVisualStyleBackColor = false;
            this.btn会員更新.Click += new System.EventHandler(this.btn会員更新_Click);
            // 
            // cb出荷実績一覧運賃非表示
            // 
            this.cb出荷実績一覧運賃非表示.ForeColor = System.Drawing.Color.LimeGreen;
            this.cb出荷実績一覧運賃非表示.Location = new System.Drawing.Point(422, 64);
            this.cb出荷実績一覧運賃非表示.Name = "cb出荷実績一覧運賃非表示";
            this.cb出荷実績一覧運賃非表示.Size = new System.Drawing.Size(174, 22);
            this.cb出荷実績一覧運賃非表示.TabIndex = 89;
            this.cb出荷実績一覧運賃非表示.Text = "出荷実績一覧：運賃表示なし";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(34, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 14);
            this.label4.TabIndex = 88;
            this.label4.Text = "※";
            // 
            // tex部門数
            // 
            this.tex部門数.BackColor = System.Drawing.Color.Honeydew;
            this.tex部門数.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex部門数.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex部門数.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex部門数.Location = new System.Drawing.Point(152, 332);
            this.tex部門数.MaxLength = 10;
            this.tex部門数.Name = "tex部門数";
            this.tex部門数.ReadOnly = true;
            this.tex部門数.Size = new System.Drawing.Size(28, 16);
            this.tex部門数.TabIndex = 87;
            this.tex部門数.TabStop = false;
            this.tex部門数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(48, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 14);
            this.label5.TabIndex = 86;
            this.label5.Text = "セクション数";
            // 
            // tex郵便番号店所
            // 
            this.tex郵便番号店所.BackColor = System.Drawing.Color.Honeydew;
            this.tex郵便番号店所.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex郵便番号店所.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex郵便番号店所.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex郵便番号店所.Location = new System.Drawing.Point(304, 308);
            this.tex郵便番号店所.MaxLength = 6;
            this.tex郵便番号店所.Name = "tex郵便番号店所";
            this.tex郵便番号店所.ReadOnly = true;
            this.tex郵便番号店所.Size = new System.Drawing.Size(74, 16);
            this.tex郵便番号店所.TabIndex = 85;
            this.tex郵便番号店所.TabStop = false;
            // 
            // btn住所検索
            // 
            this.btn住所検索.BackColor = System.Drawing.Color.SteelBlue;
            this.btn住所検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn住所検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn住所検索.ForeColor = System.Drawing.Color.White;
            this.btn住所検索.Location = new System.Drawing.Point(252, 304);
            this.btn住所検索.Name = "btn住所検索";
            this.btn住所検索.Size = new System.Drawing.Size(48, 22);
            this.btn住所検索.TabIndex = 3;
            this.btn住所検索.TabStop = false;
            this.btn住所検索.Text = "検索";
            this.btn住所検索.UseVisualStyleBackColor = false;
            this.btn住所検索.Click += new System.EventHandler(this.btn住所検索_Click);
            // 
            // tex郵便番号２
            // 
            this.tex郵便番号２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex郵便番号２.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex郵便番号２.Location = new System.Drawing.Point(200, 304);
            this.tex郵便番号２.MaxLength = 4;
            this.tex郵便番号２.Name = "tex郵便番号２";
            this.tex郵便番号２.Size = new System.Drawing.Size(48, 23);
            this.tex郵便番号２.TabIndex = 8;
            this.tex郵便番号２.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex郵便番号２_KeyDown);
            this.tex郵便番号２.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex郵便番号２_KeyPress);
            // 
            // tex郵便番号１
            // 
            this.tex郵便番号１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex郵便番号１.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex郵便番号１.Location = new System.Drawing.Point(150, 304);
            this.tex郵便番号１.MaxLength = 3;
            this.tex郵便番号１.Name = "tex郵便番号１";
            this.tex郵便番号１.Size = new System.Drawing.Size(38, 23);
            this.tex郵便番号１.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(188, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 84;
            this.label10.Text = "－";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab郵便番号
            // 
            this.lab郵便番号.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab郵便番号.Location = new System.Drawing.Point(48, 310);
            this.lab郵便番号.Name = "lab郵便番号";
            this.lab郵便番号.Size = new System.Drawing.Size(95, 14);
            this.lab郵便番号.TabIndex = 79;
            this.lab郵便番号.Text = "郵便番号";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(34, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 14);
            this.label2.TabIndex = 78;
            this.label2.Text = "※";
            // 
            // tex得意先部課名
            // 
            this.tex得意先部課名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex得意先部課名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex得意先部課名.Location = new System.Drawing.Point(150, 278);
            this.tex得意先部課名.MaxLength = 10;
            this.tex得意先部課名.Name = "tex得意先部課名";
            this.tex得意先部課名.Size = new System.Drawing.Size(170, 23);
            this.tex得意先部課名.TabIndex = 6;
            // 
            // tex得意先部課コード
            // 
            this.tex得意先部課コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex得意先部課コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex得意先部課コード.Location = new System.Drawing.Point(150, 254);
            this.tex得意先部課コード.MaxLength = 6;
            this.tex得意先部課コード.Name = "tex得意先部課コード";
            this.tex得意先部課コード.Size = new System.Drawing.Size(82, 23);
            this.tex得意先部課コード.TabIndex = 5;
            // 
            // tex得意先コード
            // 
            this.tex得意先コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex得意先コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex得意先コード.Location = new System.Drawing.Point(150, 230);
            this.tex得意先コード.MaxLength = 10;
            this.tex得意先コード.Name = "tex得意先コード";
            this.tex得意先コード.Size = new System.Drawing.Size(130, 23);
            this.tex得意先コード.TabIndex = 4;
            // 
            // lab得意先部課コード
            // 
            this.lab得意先部課コード.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab得意先部課コード.Location = new System.Drawing.Point(48, 260);
            this.lab得意先部課コード.Name = "lab得意先部課コード";
            this.lab得意先部課コード.Size = new System.Drawing.Size(95, 14);
            this.lab得意先部課コード.TabIndex = 77;
            this.lab得意先部課コード.Text = "得意先部課コード";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(34, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 14);
            this.label3.TabIndex = 76;
            this.label3.Text = "※";
            // 
            // lab得意先コード
            // 
            this.lab得意先コード.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab得意先コード.Location = new System.Drawing.Point(48, 236);
            this.lab得意先コード.Name = "lab得意先コード";
            this.lab得意先コード.Size = new System.Drawing.Size(95, 14);
            this.lab得意先コード.TabIndex = 75;
            this.lab得意先コード.Text = "得意先コード";
            // 
            // axGT請求先
            // 
            this.axGT請求先.DataSource = null;
            this.axGT請求先.Location = new System.Drawing.Point(30, 96);
            this.axGT請求先.Name = "axGT請求先";
            this.axGT請求先.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT請求先.OcxState")));
            this.axGT請求先.Size = new System.Drawing.Size(624, 128);
            this.axGT請求先.TabIndex = 3;
            this.axGT請求先.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT請求先_CurPlaceChanged);
            this.axGT請求先.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT請求先_CelDblClick);
            this.axGT請求先.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT請求先_KeyDownEvent);
            // 
            // tex管理店所名
            // 
            this.tex管理店所名.BackColor = System.Drawing.Color.Honeydew;
            this.tex管理店所名.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex管理店所名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex管理店所名.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex管理店所名.Location = new System.Drawing.Point(150, 10);
            this.tex管理店所名.MaxLength = 6;
            this.tex管理店所名.Name = "tex管理店所名";
            this.tex管理店所名.ReadOnly = true;
            this.tex管理店所名.Size = new System.Drawing.Size(74, 16);
            this.tex管理店所名.TabIndex = 73;
            this.tex管理店所名.TabStop = false;
            // 
            // lab管理店所名
            // 
            this.lab管理店所名.BackColor = System.Drawing.Color.Honeydew;
            this.lab管理店所名.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab管理店所名.Location = new System.Drawing.Point(48, 12);
            this.lab管理店所名.Name = "lab管理店所名";
            this.lab管理店所名.Size = new System.Drawing.Size(95, 14);
            this.lab管理店所名.TabIndex = 72;
            this.lab管理店所名.Text = "管理店所名";
            // 
            // btn請求先取消
            // 
            this.btn請求先取消.BackColor = System.Drawing.Color.Blue;
            this.btn請求先取消.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn請求先取消.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn請求先取消.ForeColor = System.Drawing.Color.White;
            this.btn請求先取消.Location = new System.Drawing.Point(446, 336);
            this.btn請求先取消.Name = "btn請求先取消";
            this.btn請求先取消.Size = new System.Drawing.Size(48, 22);
            this.btn請求先取消.TabIndex = 11;
            this.btn請求先取消.Text = "取消";
            this.btn請求先取消.UseVisualStyleBackColor = false;
            this.btn請求先取消.Click += new System.EventHandler(this.btn請求先取消_Click);
            // 
            // btn請求先削除
            // 
            this.btn請求先削除.BackColor = System.Drawing.Color.Blue;
            this.btn請求先削除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn請求先削除.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn請求先削除.ForeColor = System.Drawing.Color.White;
            this.btn請求先削除.Location = new System.Drawing.Point(392, 336);
            this.btn請求先削除.Name = "btn請求先削除";
            this.btn請求先削除.Size = new System.Drawing.Size(48, 22);
            this.btn請求先削除.TabIndex = 10;
            this.btn請求先削除.Text = "削除";
            this.btn請求先削除.UseVisualStyleBackColor = false;
            this.btn請求先削除.Click += new System.EventHandler(this.btn請求先削除_Click);
            // 
            // btn請求先登録
            // 
            this.btn請求先登録.BackColor = System.Drawing.Color.Blue;
            this.btn請求先登録.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn請求先登録.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn請求先登録.ForeColor = System.Drawing.Color.White;
            this.btn請求先登録.Location = new System.Drawing.Point(338, 336);
            this.btn請求先登録.Name = "btn請求先登録";
            this.btn請求先登録.Size = new System.Drawing.Size(48, 22);
            this.btn請求先登録.TabIndex = 9;
            this.btn請求先登録.Text = "登録";
            this.btn請求先登録.UseVisualStyleBackColor = false;
            this.btn請求先登録.Click += new System.EventHandler(this.btn請求先登録_Click);
            // 
            // tex会員名
            // 
            this.tex会員名.BackColor = System.Drawing.Color.Honeydew;
            this.tex会員名.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex会員名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex会員名.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex会員名.Location = new System.Drawing.Point(392, 44);
            this.tex会員名.MaxLength = 20;
            this.tex会員名.Name = "tex会員名";
            this.tex会員名.ReadOnly = true;
            this.tex会員名.Size = new System.Drawing.Size(258, 16);
            this.tex会員名.TabIndex = 9;
            this.tex会員名.TabStop = false;
            // 
            // btn会員検索
            // 
            this.btn会員検索.BackColor = System.Drawing.Color.SteelBlue;
            this.btn会員検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn会員検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn会員検索.ForeColor = System.Drawing.Color.White;
            this.btn会員検索.Location = new System.Drawing.Point(286, 40);
            this.btn会員検索.Name = "btn会員検索";
            this.btn会員検索.Size = new System.Drawing.Size(48, 22);
            this.btn会員検索.TabIndex = 1;
            this.btn会員検索.TabStop = false;
            this.btn会員検索.Text = "検索";
            this.btn会員検索.UseVisualStyleBackColor = false;
            this.btn会員検索.Click += new System.EventHandler(this.btn会員検索_Click);
            // 
            // lab得意先部課名
            // 
            this.lab得意先部課名.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab得意先部課名.Location = new System.Drawing.Point(48, 284);
            this.lab得意先部課名.Name = "lab得意先部課名";
            this.lab得意先部課名.Size = new System.Drawing.Size(95, 14);
            this.lab得意先部課名.TabIndex = 52;
            this.lab得意先部課名.Text = "得意先部課名";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 14);
            this.label1.TabIndex = 51;
            this.label1.Text = "※";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.label22.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 366);
            this.label22.TabIndex = 50;
            this.label22.Text = "請求先情報";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab会員コード
            // 
            this.lab会員コード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab会員コード.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab会員コード.Location = new System.Drawing.Point(50, 46);
            this.lab会員コード.Name = "lab会員コード";
            this.lab会員コード.Size = new System.Drawing.Size(95, 14);
            this.lab会員コード.TabIndex = 19;
            this.lab会員コード.Text = "お客様コード";
            // 
            // tex会員コード
            // 
            this.tex会員コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex会員コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex会員コード.Location = new System.Drawing.Point(150, 40);
            this.tex会員コード.MaxLength = 10;
            this.tex会員コード.Name = "tex会員コード";
            this.tex会員コード.Size = new System.Drawing.Size(130, 23);
            this.tex会員コード.TabIndex = 0;
            this.tex会員コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex会員コード_KeyDown);
            this.tex会員コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex会員コード_KeyPress);
            // 
            // btn会員実行
            // 
            this.btn会員実行.BackColor = System.Drawing.Color.Blue;
            this.btn会員実行.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn会員実行.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn会員実行.ForeColor = System.Drawing.Color.White;
            this.btn会員実行.Location = new System.Drawing.Point(338, 40);
            this.btn会員実行.Name = "btn会員実行";
            this.btn会員実行.Size = new System.Drawing.Size(48, 22);
            this.btn会員実行.TabIndex = 2;
            this.btn会員実行.Text = "実行";
            this.btn会員実行.UseVisualStyleBackColor = false;
            this.btn会員実行.Click += new System.EventHandler(this.btn会員実行_Click);
            // 
            // gpお客様
            // 
            this.gpお客様.Location = new System.Drawing.Point(30, 28);
            this.gpお客様.Name = "gpお客様";
            this.gpお客様.Size = new System.Drawing.Size(624, 64);
            this.gpお客様.TabIndex = 91;
            this.gpお客様.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.btn管理店所検索);
            this.panel5.Controls.Add(this.lab記事コード);
            this.panel5.Controls.Add(this.tex管理店所コード);
            this.panel5.Location = new System.Drawing.Point(1, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 32);
            this.panel5.TabIndex = 0;
            // 
            // btn管理店所検索
            // 
            this.btn管理店所検索.BackColor = System.Drawing.Color.SteelBlue;
            this.btn管理店所検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn管理店所検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn管理店所検索.ForeColor = System.Drawing.Color.White;
            this.btn管理店所検索.Location = new System.Drawing.Point(178, 4);
            this.btn管理店所検索.Name = "btn管理店所検索";
            this.btn管理店所検索.Size = new System.Drawing.Size(48, 22);
            this.btn管理店所検索.TabIndex = 1;
            this.btn管理店所検索.TabStop = false;
            this.btn管理店所検索.Text = "検索";
            this.btn管理店所検索.UseVisualStyleBackColor = false;
            this.btn管理店所検索.Click += new System.EventHandler(this.btn管理店所検索_Click);
            // 
            // lab記事コード
            // 
            this.lab記事コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab記事コード.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab記事コード.Location = new System.Drawing.Point(8, 7);
            this.lab記事コード.Name = "lab記事コード";
            this.lab記事コード.Size = new System.Drawing.Size(110, 17);
            this.lab記事コード.TabIndex = 6;
            this.lab記事コード.Text = "管理店所コード";
            // 
            // tex管理店所コード
            // 
            this.tex管理店所コード.BackColor = System.Drawing.SystemColors.Window;
            this.tex管理店所コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex管理店所コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex管理店所コード.Location = new System.Drawing.Point(128, 4);
            this.tex管理店所コード.MaxLength = 4;
            this.tex管理店所コード.Name = "tex管理店所コード";
            this.tex管理店所コード.Size = new System.Drawing.Size(42, 23);
            this.tex管理店所コード.TabIndex = 0;
            this.tex管理店所コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex管理店所コード_KeyDown);
            this.tex管理店所コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex管理店所コード_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleGreen;
            this.panel6.Controls.Add(this.tex認証利用者名);
            this.panel6.Controls.Add(this.lab認証利用者名);
            this.panel6.Controls.Add(this.lab認証会員名);
            this.panel6.Controls.Add(this.tex認証会員名);
            this.panel6.Location = new System.Drawing.Point(0, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(810, 26);
            this.panel6.TabIndex = 12;
            // 
            // tex認証利用者名
            // 
            this.tex認証利用者名.BackColor = System.Drawing.Color.PaleGreen;
            this.tex認証利用者名.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex認証利用者名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex認証利用者名.ForeColor = System.Drawing.Color.Green;
            this.tex認証利用者名.Location = new System.Drawing.Point(622, 5);
            this.tex認証利用者名.Name = "tex認証利用者名";
            this.tex認証利用者名.ReadOnly = true;
            this.tex認証利用者名.Size = new System.Drawing.Size(162, 16);
            this.tex認証利用者名.TabIndex = 3;
            this.tex認証利用者名.TabStop = false;
            this.tex認証利用者名.Visible = false;
            // 
            // lab認証利用者名
            // 
            this.lab認証利用者名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab認証利用者名.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab認証利用者名.Location = new System.Drawing.Point(564, 7);
            this.lab認証利用者名.Name = "lab認証利用者名";
            this.lab認証利用者名.Size = new System.Drawing.Size(54, 14);
            this.lab認証利用者名.TabIndex = 4;
            this.lab認証利用者名.Text = "ユーザー";
            this.lab認証利用者名.Visible = false;
            // 
            // lab認証会員名
            // 
            this.lab認証会員名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab認証会員名.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab認証会員名.Location = new System.Drawing.Point(12, 7);
            this.lab認証会員名.Name = "lab認証会員名";
            this.lab認証会員名.Size = new System.Drawing.Size(52, 14);
            this.lab認証会員名.TabIndex = 1;
            this.lab認証会員名.Text = "お客様名";
            // 
            // tex認証会員名
            // 
            this.tex認証会員名.BackColor = System.Drawing.Color.PaleGreen;
            this.tex認証会員名.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex認証会員名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex認証会員名.ForeColor = System.Drawing.Color.Green;
            this.tex認証会員名.Location = new System.Drawing.Point(68, 5);
            this.tex認証会員名.Name = "tex認証会員名";
            this.tex認証会員名.ReadOnly = true;
            this.tex認証会員名.Size = new System.Drawing.Size(328, 16);
            this.tex認証会員名.TabIndex = 2;
            this.tex認証会員名.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab日時);
            this.panel7.Controls.Add(this.lab請求先タイトル);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(792, 26);
            this.panel7.TabIndex = 13;
            // 
            // lab日時
            // 
            this.lab日時.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab日時.ForeColor = System.Drawing.Color.White;
            this.lab日時.Location = new System.Drawing.Point(674, 8);
            this.lab日時.Name = "lab日時";
            this.lab日時.Size = new System.Drawing.Size(112, 14);
            this.lab日時.TabIndex = 1;
            this.lab日時.Text = "2005/xx/xx 12:00:00";
            // 
            // lab請求先タイトル
            // 
            this.lab請求先タイトル.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab請求先タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab請求先タイトル.ForeColor = System.Drawing.Color.White;
            this.lab請求先タイトル.Location = new System.Drawing.Point(12, 2);
            this.lab請求先タイトル.Name = "lab請求先タイトル";
            this.lab請求先タイトル.Size = new System.Drawing.Size(264, 24);
            this.lab請求先タイトル.TabIndex = 0;
            this.lab請求先タイトル.Text = "請求先情報メンテナンス";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PaleGreen;
            this.panel8.Controls.Add(this.texメッセージ);
            this.panel8.Controls.Add(this.btn閉じる);
            this.panel8.Location = new System.Drawing.Point(0, 516);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(792, 58);
            this.panel8.TabIndex = 2;
            // 
            // texメッセージ
            // 
            this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
            this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texメッセージ.ForeColor = System.Drawing.Color.Red;
            this.texメッセージ.Location = new System.Drawing.Point(414, 4);
            this.texメッセージ.Multiline = true;
            this.texメッセージ.Name = "texメッセージ";
            this.texメッセージ.ReadOnly = true;
            this.texメッセージ.Size = new System.Drawing.Size(376, 50);
            this.texメッセージ.TabIndex = 1;
            this.texメッセージ.TabStop = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(43, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnl請求先);
            this.groupBox2.Location = new System.Drawing.Point(21, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 374);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // 請求先マスタ
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(792, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 607);
            this.Name = "請求先マスタ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 請求先情報メンテナンス";
            this.Closed += new System.EventHandler(this.請求先マスタ_Closed);
            this.Load += new System.EventHandler(this.請求先マスタ_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
            this.pnl請求先.ResumeLayout(false);
            this.pnl請求先.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT請求先)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 START
        protected void Onエンター移動(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.エンター移動(sender, e);
        }

        protected void Onエンターキャンセル(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            base.エンターキャンセル(sender, e);
        }
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 END

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		private void 請求先マスタ_Load(object sender, System.EventArgs e)
		{
			tex認証会員名.Text = gs会員名;
			tex認証利用者名.Text = gs利用者名;

			初期モード();
			
			// 日時の初期設定
			lab日時.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;

			// 請求先リストの初期設定
			axGT請求先.Cols = 7;
			axGT請求先.Rows = 6;
			axGT請求先.ColSep = "|";
			axGT請求先.CaretRow = 1;
			axGT請求先.CaretCol = 2;
			axGT請求先.NoBeep = true;			

// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//			axGT請求先.set_RowsText(0, "|郵便番号|得意先コード|部課コード|部課名|お客様コード|お客様名|更新日時|");
//			axGT請求先.ColsWidth = "0|0|6|5|10|6|19.5|0|";
//			axGT請求先.ColsAlignHorz = "1|1|1|1|0|1|0|0|";
			axGT請求先.set_RowsText(0, "|郵便番号|お客様コード|お客様名|得意先コード|部課コード|部課名|更新日時|");
			axGT請求先.ColsWidth = "0|0|6|14.5|6|5|15|0|";
			axGT請求先.ColsAlignHorz = "1|1|1|0|1|1|0|0|";
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
            
			axGT請求先.set_CelForeColor(axGT請求先.CaretRow,0,0x98FB98);  //BGR
			axGT請求先.set_CelBackColor(axGT請求先.CaretRow,0,0x006000);

			if(gs店所コード.Trim().Length != 0)
			{
				tex管理店所コード.Text = gs店所コード.Trim();
				tex管理店所コード.Enabled = false;
				btn管理店所検索.Visible = false;
// DEL 2007.01.18 東都）高木 画面レイアウト変更 START
//				btn請求先実行.Visible = false;
//				s管理店所コード   =  tex管理店所コード.Text;
// DEL 2007.01.18 東都）高木 画面レイアウト変更 END
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//				if(請求先一覧検索())
//				{
//					請求先登録モード();
//					pnl請求先.Enabled = true;
//					axGT請求先.CaretRow = 1;
//					axGT請求先_CurPlaceChanged(null,null);
//					tex郵便番号１.Focus();
//				}
//				else
//				{
//					ビープ音();
//					tex管理店所コード.Focus();
//					初期モード();
//					axGT請求先.Clear();
//					tex管理店所名.Text = "";
//					pnl請求先.Enabled = false;
//				}
				管理店所検索();
				初期モード１();
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
			}
			else
			{
// ADD 2008.05.02 東都）高木 管理店所の制御の修正 START
				tex管理店所コード.Text    = "";
				tex管理店所コード.Enabled = true;
				btn管理店所検索.Visible   = true;
// ADD 2008.05.02 東都）高木 管理店所の制御の修正 END
				axGT請求先.Clear();
			}
// ADD 2007.01.18 東都）高木 画面レイアウト変更 START
//			桁数表示();
// ADD 2007.01.18 東都）高木 画面レイアウト変更 END
		}

// ADD 2007.01.18 東都）高木 画面レイアウト変更 START
		private void 桁数表示()
		{
			tex会員名.Text = "会員名４５６７８９０１２３４５６７８９０";
			tex郵便番号店所.Text = "店所名４";
			tex部門数.Text = "";
		}

		private void 初期モード１()
		{
			請求先登録モード();
			pnl請求先.Enabled = true;

			tex会員コード.Enabled = true;
			btn会員検索.Enabled = true;
			btn会員実行.Enabled = true;
// MOD 2009.05.28 東都）高木 出荷実績一覧運賃非表示対応 START
			cb出荷実績一覧運賃非表示.Checked = false;
			btn会員更新.Enabled = false;
// MOD 2009.05.28 東都）高木 出荷実績一覧運賃非表示対応 END

			axGT請求先.Clear();
			axGT請求先.CaretRow = 1;
			axGT請求先_CurPlaceChanged(null,null);
			axGT請求先.Enabled = false;
			tex得意先コード.Enabled = false;
			tex得意先部課コード.Enabled = false;
			tex得意先部課名.Enabled = false;
			tex郵便番号１.Enabled = false;
			tex郵便番号２.Enabled = false;
// MOD 2007.01.22 東都）高木 画面修正 START
//			btn管理店所検索.Enabled = false;
			btn住所検索.Enabled = false;
// MOD 2007.01.22 東都）高木 画面修正 END

			btn請求先登録.Text = "登録";
			btn請求先削除.Enabled = false;
// ADD 2007.01.22 東都）高木 画面修正 START
			btn請求先登録.Enabled = false;
			btn請求先取消.Enabled = false;
// ADD 2007.01.22 東都）高木 画面修正 END

			tex会員コード.Text = " ";
// ADD 2007.01.22 東都）高木 画面修正 START
			tex会員名.Text = "";
// ADD 2007.01.22 東都）高木 画面修正 END
			tex会員コード.Focus();
		}
// ADD 2007.01.18 東都）高木 画面レイアウト変更 END

		private void 初期モード()
		{
			請求先登録モード();
			pnl請求先.Enabled = false;
			tex管理店所コード.Focus();
		}

		private void 請求先登録モード()
		{
			tex得意先コード.Enabled = true;
			tex得意先部課コード.Enabled = true;
// ADD 2007.01.18 東都）高木 画面レイアウト変更 START
			tex得意先部課名.Enabled = true;
			tex郵便番号１.Enabled = true;
			tex郵便番号２.Enabled = true;
// ADD 2007.01.18 東都）高木 画面レイアウト変更 END
// ADD 2007.01.22 東都）高木 画面修正 START
			btn住所検索.Enabled = true;
// ADD 2007.01.22 東都）高木 画面修正 END
			btn請求先登録.Text = "登録";
			btn請求先削除.Enabled = false;
// ADD 2007.01.22 東都）高木 画面修正 START
			btn請求先登録.Enabled = true;
			btn請求先取消.Enabled = true;
// ADD 2007.01.22 東都）高木 画面修正 END

			tex郵便番号１.Text = "";
			tex郵便番号２.Text = "";
			tex郵便番号店所.Text = "";
			tex得意先コード.Text = "";
			tex得意先部課コード.Text = "";
			tex得意先部課名.Text = "";
// DEL 2007.01.18 東都）高木 画面レイアウト変更 START
//			tex会員コード.Text = "";
//			tex会員名.Text = "";
// DEL 2007.01.18 東都）高木 画面レイアウト変更 END
			tex部門数.Text = "";
// ADD 2007.01.18 東都）高木 画面レイアウト変更 START
			s更新日時 = "";
// ADD 2007.01.18 東都）高木 画面レイアウト変更 END
		}

		private void 請求先更新モード()
		{
			tex得意先コード.Enabled = false;
			tex得意先部課コード.Enabled = false;
			btn請求先登録.Text = "更新";
			btn請求先削除.Enabled = true;
// ADD 2007.01.22 東都）高木 画面修正 START
			btn請求先登録.Enabled = true;
			btn請求先取消.Enabled = true;
// ADD 2007.01.22 東都）高木 画面修正 END
		}

		private void tex管理店所コード_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				axGT請求先.CaretRow = 1;
				axGT請求先_CurPlaceChanged(null,null);

				texメッセージ.Text = "";
				tex管理店所コード.Text = tex管理店所コード.Text.Trim();
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//				if(tex管理店所コード.Text.Length == 0)
//					btn管理店所検索_Click(null,null);
//				else
//					btn請求先実行_Click(sender,e);
				if(tex管理店所コード.Text.Length == 0){
					btn管理店所検索_Click(null,null);
				}else{
					if(管理店所検索()){
						tex管理店所コード.Enabled = false;
						btn管理店所検索.Enabled = false;
						初期モード１();
					}else{
						tex管理店所コード.Focus();
					}
				}
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
			}
		}

		private void tex管理店所コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn管理店所検索.Focus();
				btn管理店所検索_Click(sender,e);
				e.Handled = true;
			}				
		}

		private void btn管理店所検索_Click(object sender, System.EventArgs e)
		{
			tex管理店所コード.Text = tex管理店所コード.Text.Trim();
			if(!半角チェック(tex管理店所コード, "管理店所コード")) return;

			// 検索画面を右側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			店所検索 画面 = new 店所検索();
//			画面.Left = this.Left + 404;
//			画面.Top = this.Top;

			// コードの初期表示
//			画面.s店所コード = tex管理店所コード.Text;
//			画面.ShowDialog();
			if (g店所検索 == null)	 g店所検索 = new 店所検索();
			g店所検索.Left = this.Left + 404;
			g店所検索.Top = this.Top;

			// コードの初期表示
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし START
//			g店所検索.s店所コード = tex管理店所コード.Text;
			g店所検索.s店所コード = "";
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし END
			g店所検索.s店所名 = "";
			g店所検索.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

////		tex管理店所コード.Text = 画面.s店所コード;
//			tex管理店所コード.Text = g店所検索.s店所コード;
// MOD 2005.05.25 東都）小童谷 画面高速化 END
//			if(tex管理店所コード.Text.Length > 0)
			if(g店所検索.s店所コード.Length > 0)
			{
				tex管理店所コード.Text = g店所検索.s店所コード;
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//				tex管理店所コード.Focus();
//				btn請求先実行_Click(sender, e);
				tex管理店所名.Text = g店所検索.s店所名;

				tex管理店所コード.Enabled = false;
				btn管理店所検索.Enabled = false;
				初期モード１();
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
			}
			else
			{
				tex管理店所コード.Focus();
			}
		}

		private bool 管理店所検索()
		{
			tex管理店所コード.Text = tex管理店所コード.Text.Trim();
			if(!半角チェック(tex管理店所コード, "管理店所コード")) return false;

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex管理店所コード.Text;
				string[] sList = sv_maintenance.Sel_Shop(gsaユーザ, sKey);
				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex管理店所名.Text = sList[1];
				}
				else
				{
					if(sList[0].Equals("該当データがありません"))
						texメッセージ.Text = "";
					else
						texメッセージ.Text = sList[0];
					ビープ音();
					ret =  false;
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
				ret = false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}

// DEL 2007.01.18 東都）高木 画面レイアウト変更 START
//		private void btn請求先実行_Click(object sender, System.EventArgs e)
//		{
//			texメッセージ.Text = "";
//
//			tex管理店所コード.Text = tex管理店所コード.Text.Trim();
//			if(!必須チェック(tex管理店所コード, "管理店所コード")) return;
//			if(!半角チェック(tex管理店所コード, "管理店所コード")) return;
//
//			s管理店所コード   =  tex管理店所コード.Text;
//			if(請求先一覧検索())
//			{
//				請求先登録モード();
//				pnl請求先.Enabled = true;
//				axGT請求先.CaretRow = 1;
//				axGT請求先_CurPlaceChanged(null,null);
//				tex郵便番号１.Focus();
//			}
//			else
//			{
//				ビープ音();
//				tex管理店所コード.Focus();
//				初期モード();
//				axGT請求先.Clear();
//				tex管理店所名.Text = "";
//				pnl請求先.Enabled = false;
//			}
//		}
// DEL 2007.01.18 東都）高木 画面レイアウト変更 END

		private bool 請求先一覧検索()
		{
			axGT請求先.Clear();
			axGT請求先.Rows = 6;
			axGT請求先.CaretRow = 1;
// ADD 2007.01.18 東都）高木 画面レイアウト変更 START
			axGT請求先_CurPlaceChanged(null,null);
			axGT請求先.ColsWidth = "0|0|6|14.5|6|5|15|0|";
// ADD 2007.01.18 東都）高木 画面レイアウト変更 END

			bool bRet = false;
// DEL 2007.01.18 東都）高木 画面レイアウト変更 START
//			axGT請求先.Clear();
// DEL 2007.01.18 東都）高木 画面レイアウト変更 END
			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
// DEL 2007.01.18 東都）高木 画面レイアウト変更 START
//				//管理店所チェック
//				if (!管理店所検索())
//				{
//					MessageBox.Show("管理店所(" + tex管理店所コード.Text + ")が存在しません" ,"入力チェック",MessageBoxButtons.OK);
//					tex管理店所コード.Focus();
//					return false;
//				}
// DEL 2007.01.18 東都）高木 画面レイアウト変更 END

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
				String[] sList;
				tex会員コード.Text = tex会員コード.Text.Trim();
				if (tex会員コード.Text == "")
				{
					String[] sKey1 = new string[1];
					sKey1[0] = tex管理店所コード.Text.Trim();
					string[] sList1 = sv_oji.Sel_Member(gsaユーザ, sKey1);

					if (sList1[0].Equals("正常終了"))
					{
						if ((sList1[4] != "3") && (sList1[4] != "4"))
						{
							sList = sv_maintenance.Get_Claim2(gsaユーザ, tex管理店所コード.Text, tex会員コード.Text);
						}
						else
						{
							sList = sv_oji.Get_Claim2(gsaユーザ, tex管理店所コード.Text, tex会員コード.Text);
						}
					}
					else
					{
						sList = sv_maintenance.Get_Claim2(gsaユーザ, tex管理店所コード.Text, tex会員コード.Text);
					}
				}
				else if (tex会員コード.Text.Substring(0,1) != "J")
				{
//					// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//					//				String[] sList = sv_maintenance.Get_Claim(gsaユーザ, tex管理店所コード.Text.Trim());
//					String[] sList = sv_maintenance.Get_Claim2(gsaユーザ, tex管理店所コード.Text, tex会員コード.Text);
//					// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
					sList = sv_maintenance.Get_Claim2(gsaユーザ, tex管理店所コード.Text, tex会員コード.Text);
				}
				else
				{
					sList = sv_oji.Get_Claim2(gsaユーザ, tex管理店所コード.Text, tex会員コード.Text);
				}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
				if(sList[0].Equals("正常終了") || sList[0].Equals("該当データがありません"))
					{
						texメッセージ.Text = "";
						if (axGT請求先.Rows < sList.Length - 1)
						{
							axGT請求先.Rows = (short)(sList.Length - 1);
						}
						for(short nCnt = 1; nCnt < sList.Length; nCnt++)
						{
							axGT請求先.set_RowsText(nCnt, sList[nCnt]);
						}
						bRet = true;
					}
					else
					{
						texメッセージ.Text = sList[0];
					}

			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return bRet;
		}

		private void axGT請求先_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//			string s得意先 = axGT請求先.get_CelText(axGT請求先.CaretRow,2);
			string s得意先 = axGT請求先.get_CelText(axGT請求先.CaretRow,4);
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
			if(!s得意先.Equals(""))
			{
				tex郵便番号１.Text       = axGT請求先.get_CelText(axGT請求先.CaretRow,1).PadRight(7).Substring(0, 3);
				tex郵便番号２.Text       = axGT請求先.get_CelText(axGT請求先.CaretRow,1).PadRight(7).Substring(3, 4);
				tex郵便番号店所.Text     = tex管理店所名.Text;
				tex得意先コード.Text     = s得意先;
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//				tex得意先部課コード.Text = axGT請求先.get_CelText(axGT請求先.CaretRow,3);
//				tex得意先部課名.Text     = axGT請求先.get_CelText(axGT請求先.CaretRow,4);
//				tex会員コード.Text       = axGT請求先.get_CelText(axGT請求先.CaretRow,5);
//				tex会員名.Text           = axGT請求先.get_CelText(axGT請求先.CaretRow,6);
				tex得意先部課コード.Text = axGT請求先.get_CelText(axGT請求先.CaretRow,5);
				tex得意先部課名.Text     = axGT請求先.get_CelText(axGT請求先.CaretRow,6);
				tex会員コード.Text       = axGT請求先.get_CelText(axGT請求先.CaretRow,2);
				tex会員名.Text           = axGT請求先.get_CelText(axGT請求先.CaretRow,3);
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
				s郵便番号                = axGT請求先.get_CelText(axGT請求先.CaretRow,1);
				s更新日時                = axGT請求先.get_CelText(axGT請求先.CaretRow,7);
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 START
				s会員ＣＤ                = axGT請求先.get_CelText(axGT請求先.CaretRow,2);
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 END

				//セクション数の取得
				this.Cursor = System.Windows.Forms.Cursors.AppStarting;
				string[] sSectionKey = new string[2];
				sSectionKey[0] = tex会員コード.Text;
				sSectionKey[1] = tex郵便番号１.Text.Trim() + tex郵便番号２.Text.Trim();
				string[] sSectionList = sv_maintenance.Sel_SectionCount(gsaユーザ, sSectionKey);
				if (sSectionList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex部門数.Text = sSectionList[1];
					請求先更新モード();
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//					tex郵便番号１.Focus();
					tex得意先部課名.Focus();
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
				}
				else
				{
					texメッセージ.Text = sSectionList[0];
					ビープ音();
					初期モード();
				}
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}

		private void axGT請求先_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//				string s得意先 = axGT請求先.get_CelText(axGT請求先.CaretRow,2);
				string s得意先 = axGT請求先.get_CelText(axGT請求先.CaretRow,4);
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
				if(!s得意先.Equals(""))
				{
					tex郵便番号１.Text       = axGT請求先.get_CelText(axGT請求先.CaretRow,1).PadRight(7).Substring(0, 3);
					tex郵便番号２.Text       = axGT請求先.get_CelText(axGT請求先.CaretRow,1).PadRight(7).Substring(3, 4);
					tex郵便番号店所.Text     = tex管理店所名.Text;
					tex得意先コード.Text     = s得意先;
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//					tex得意先部課コード.Text = axGT請求先.get_CelText(axGT請求先.CaretRow,3);
//					tex得意先部課名.Text     = axGT請求先.get_CelText(axGT請求先.CaretRow,4);
//					tex会員コード.Text       = axGT請求先.get_CelText(axGT請求先.CaretRow,5);
//					tex会員名.Text           = axGT請求先.get_CelText(axGT請求先.CaretRow,6);
					tex得意先部課コード.Text = axGT請求先.get_CelText(axGT請求先.CaretRow,5);
					tex得意先部課名.Text     = axGT請求先.get_CelText(axGT請求先.CaretRow,6);
					tex会員コード.Text       = axGT請求先.get_CelText(axGT請求先.CaretRow,2);
					tex会員名.Text           = axGT請求先.get_CelText(axGT請求先.CaretRow,3);
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
					s郵便番号                = axGT請求先.get_CelText(axGT請求先.CaretRow,1);
					s更新日時                = axGT請求先.get_CelText(axGT請求先.CaretRow,7);
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 START
					s会員ＣＤ                = axGT請求先.get_CelText(axGT請求先.CaretRow,2);
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 END

					//セクション数の取得
					this.Cursor = System.Windows.Forms.Cursors.AppStarting;
					string[] sSectionKey = new string[2];
					sSectionKey[0] = tex会員コード.Text;
					sSectionKey[1] = tex郵便番号１.Text.Trim() + tex郵便番号２.Text.Trim();
					string[] sSectionList = sv_maintenance.Sel_SectionCount(gsaユーザ, sSectionKey);
					if (sSectionList[0].Equals("正常終了"))
					{
						texメッセージ.Text = "";
						tex部門数.Text = sSectionList[1];
						請求先更新モード();
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//						tex郵便番号１.Focus();
						tex得意先部課名.Focus();
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
					}
					else
					{
						texメッセージ.Text = sSectionList[0];
						ビープ音();
						初期モード();
					}
					this.Cursor = System.Windows.Forms.Cursors.Default;
				}
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT請求先, true, true, true, true);
			}
		}
		
		private void tex郵便番号２_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				if(tex郵便番号１.Text.Length == 3 && tex郵便番号２.Text.Length == 4)
					郵便番号検索();
				else
					郵便番号一覧();
			}
// ADD 2006.11.09 東都）山本 会員検索画面からの復帰にてセクション数を表示する様に修正 START
			セクション数取得();
// ADD 2006.11.09 東都）山本 会員検索画面からの復帰にてセクション数を表示する様に修正 END
		}

		private void tex郵便番号２_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn住所検索.Focus();
				郵便番号一覧();
				e.Handled = true;
			}
		}

		private void btn住所検索_Click(object sender, System.EventArgs e)
		{
			郵便番号一覧();
// ADD 2006.11.09 東都）山本 会員検索画面からの復帰にてセクション数を表示する様に修正 START
			セクション数取得();
// ADD 2006.11.09 東都）山本 会員検索画面からの復帰にてセクション数を表示する様に修正 END
		}

		private void 郵便番号一覧()
		{

			tex郵便番号１.Text = tex郵便番号１.Text.Trim();
			tex郵便番号２.Text = tex郵便番号２.Text.Trim();
			if(!半角チェック(tex郵便番号１, "郵便番号１")) return;
			if(!半角チェック(tex郵便番号２, "郵便番号２")) return;

			// 検索画面を右側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			住所検索 画面 = new 住所検索();
//			画面.Left = this.Left + 404;
//			画面.Top = this.Top;

			// コードの初期表示
//			画面.s郵便番号１ = tex郵便番号１.Text;
//			画面.s郵便番号２ = tex郵便番号２.Text;
//			画面.s管理店所   = "";
//			画面.ShowDialog();
			if (g住所検索 == null)	 g住所検索 = new 住所検索();
			g住所検索.Left = this.Left + 404;
			g住所検索.Top = this.Top;
			// コードの初期表示
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし START
//			g住所検索.s郵便番号１ = tex郵便番号１.Text;
//			g住所検索.s郵便番号２ = tex郵便番号２.Text;
			g住所検索.s郵便番号１ = "";
			g住所検索.s郵便番号２ = "";
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし END
			g住所検索.s管理店所   = "";
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
			g住所検索.sお客様ＣＤ = tex会員コード.Text.Trim();
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
			g住所検索.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (画面.s郵便番号１.Trim().Length != 0)
			if (g住所検索.s郵便番号１.Trim().Length != 0)
			{
//				tex郵便番号１.Text = 画面.s郵便番号１.Trim();
//				tex郵便番号２.Text = 画面.s郵便番号２.Trim();
//				tex郵便番号店所.Text = 画面.s管理店所.Trim();
				tex郵便番号１.Text = g住所検索.s郵便番号１.Trim();
				tex郵便番号２.Text = g住所検索.s郵便番号２.Trim();
				tex郵便番号店所.Text = g住所検索.s管理店所.Trim();
				this.SelectNextControl(btn住所検索, true, true, true, true);
// MOD 2005.05.25 東都）小童谷 画面高速化 END
			}
			else
			{
				tex郵便番号１.Focus();
			}
		}

		private bool 郵便番号検索()
		{
			tex郵便番号１.Text = tex郵便番号１.Text.Trim();
			tex郵便番号２.Text = tex郵便番号２.Text.Trim();
			if (!必須チェック(tex郵便番号１, "郵便番号１")) return false;
			if (!半角チェック(tex郵便番号１, "郵便番号１")) return false;
			if (!必須チェック(tex郵便番号２, "郵便番号２")) return false;
			if (!半角チェック(tex郵便番号２, "郵便番号２")) return false;
			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool bRet = false;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex郵便番号１.Text + tex郵便番号２.Text;
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//				string[] sList = sv_maintenance.Sel_Postcode(gsaユーザ, sKey);
				String[] sList;
				tex会員コード.Text = tex会員コード.Text.Trim();
				if ((tex会員コード.Text == "") || (tex会員コード.Text.Substring(0,1) != "J"))
				{
					sList = sv_maintenance.Sel_Postcode(gsaユーザ, sKey);
				}
				else
				{
					sList = sv_oji.Sel_Postcode(gsaユーザ, sKey);
				}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
				if (sList[0].Equals("正常終了"))
				{
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					if((tex会員コード.Text != "") && (tex会員コード.Text.Substring(0,1) == "J"))
					{
//MOD 2016.03.16 BEVAS）松本 王子運送版グローバル運用対応 START
						//選択した郵便番号がグローバル専用郵便番号の場合は、下記処理をスキップする
						if(sList[3].Trim() != "047")
						{
//MOD 2016.03.16 BEVAS）松本 王子運送版グローバル運用対応 END
							String[] sKey1 = new string[1];
							sKey1[0] = sList[3].Trim();
							string[] sList1 = sv_oji.Sel_Member(gsaユーザ, sKey1);

							if (sList1[0].Equals("正常終了"))
							{
								if ((sList1[4] != "3") && (sList1[4] != "4"))
								{
									texメッセージ.Text = "指定した住所は、セクション登録不可能エリアです";
									tex郵便番号店所.Text = "";
									ビープ音();
									this.Cursor = System.Windows.Forms.Cursors.Default;
									return false;
								}
							}
							else
							{
								texメッセージ.Text = sList1[0];
								tex郵便番号店所.Text = "";
								ビープ音();
								this.Cursor = System.Windows.Forms.Cursors.Default;
								return false;
							}
//MOD 2016.03.16 BEVAS）松本 王子運送版グローバル運用対応 START
						}
//MOD 2016.03.16 BEVAS）松本 王子運送版グローバル運用対応 END
					}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
					texメッセージ.Text = "";
					tex郵便番号店所.Text = sList[1];
					bRet = true;
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					tex郵便番号店所.Text = "";
					tex郵便番号１.Focus();
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return bRet;
		}

		private void tex会員コード_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				tex会員コード.Text = tex会員コード.Text.Trim();
				if(tex会員コード.Text.Length == 0)
					btn会員検索_Click(sender,e);
				else
				{
					tex会員コード.Text = tex会員コード.Text.Trim();
//					if(!半角チェック(tex会員コード, "会員コード")) return;
					if(!半角チェック(tex会員コード, "お客様コード")) return;
					会員名検索();
// ADD 2007.01.18 東都）高木 画面レイアウト変更 START
					btn会員実行.Focus();
//					btn会員実行_Click(sender,e);
// ADD 2007.01.18 東都）高木 画面レイアウト変更 END
				}
			}
		}

		private void tex会員コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn会員検索.Focus();
				btn会員検索_Click(sender, e);
				e.Handled = true;
			}				
		}

		private bool 会員名検索()
		{
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//			tex会員コード.Text = tex会員コード.Text.Trim();
//			if (!必須チェック(tex会員コード, "会員コード")) return false;
//			if (!半角チェック(tex会員コード, "会員コード")) return false;
			tex会員名.Text = "";
			tex部門数.Text = "";
			if (tex会員コード.Text.Length == 0) return true;
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool bRet = false;
			try
			{
				string[] sKey = new string[2];
				String[] sList;
				sKey[0] = tex会員コード.Text;
// ADD 2006.11.08 東都）山本 店所ログイン時の請求先登録する場合の店所コードチェック追加 START
				sKey[1] = gs店所コード.Trim();
				if(gs店所コード.Trim().Length != 0)
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					if ((tex会員コード.Text == "") || (tex会員コード.Text.Substring(0,1) != "J"))
					{
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
						sList = sv_maintenance.Sel_MemberTn(gsaユーザ, sKey);
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					}
					else
					{
						sList = sv_oji.Sel_MemberTn(gsaユーザ, sKey);
					}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
						// ADD 2006.11.08 東都）山本 店所ログイン時の請求先登録する場合の店所コードチェック追加 END
						sList = sv_maintenance.Sel_Member(gsaユーザ, sKey);
				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex会員名.Text = sList[2];
// MOD 2009.05.28 東都）高木 出荷実績一覧運賃非表示対応 START
					s会員更新日時 = sList[6];
					if(sList.Length < 8){
						cb出荷実績一覧運賃非表示.Enabled = false;
						btn会員更新.Enabled = false;
					}else{
						if(sList[7].Equals("1")){
							cb出荷実績一覧運賃非表示.Checked = true;
						}else{
							cb出荷実績一覧運賃非表示.Checked = false;
						}
						btn会員更新.Enabled = true;
					}
// MOD 2009.05.28 東都）高木 出荷実績一覧運賃非表示対応 END
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//					string[] sSectionKey = new string[2];
//					sSectionKey[0] = tex会員コード.Text;
//					sSectionKey[1] = tex郵便番号１.Text.Trim() + tex郵便番号２.Text.Trim();
//					string[] sSectionList = sv_maintenance.Sel_SectionCount(gsaユーザ, sSectionKey);
//					if (sSectionList[0].Equals("正常終了"))
//					{
//						texメッセージ.Text = "";
//						tex部門数.Text = sSectionList[1];
//						bRet = true;
//					}
//					else
//					{
//						texメッセージ.Text = sSectionList[0];
//						ビープ音();
//						tex会員名.Text = "";
//						tex部門数.Text = "";
//						tex会員コード.Focus();
//					}
					tex部門数.Text = "";
					bRet = true;
					セクション数取得();
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					tex会員名.Text = "";
					tex部門数.Text = "";
					tex会員コード.Focus();
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return bRet;
		}

		private void btn会員検索_Click(object sender, System.EventArgs e)
		{
			tex会員コード.Text = tex会員コード.Text.Trim();
			if(!半角チェック(tex会員コード, "お客様コード")) return;

			// 検索画面を右側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			会員検索 画面 = new 会員検索();
//			画面.Left = this.Left + 404;
//			画面.Top = this.Top;
//
//			// コードの初期表示
//			画面.s会員コード = tex会員コード.Text;
//			画面.ShowDialog();
			if (g会員検索 == null)	 g会員検索 = new 会員検索();
			g会員検索.Left = this.Left + 404;
			g会員検索.Top = this.Top;
			// コードの初期表示
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし START
//			g会員検索.s会員コード = tex会員コード.Text;
			g会員検索.s会員コード = "";
			g会員検索.s会員名 = "";
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし END
// ADD 2007.01.18 東都）高木 画面レイアウト変更 START
			g会員検索.s店所コード = tex管理店所コード.Text.Trim();
// ADD 2007.01.18 東都）高木 画面レイアウト変更 END
			g会員検索.ShowDialog();
// ADD 2007.01.18 東都）高木 画面レイアウト変更 START
			g会員検索.s店所コード = "";
// ADD 2007.01.18 東都）高木 画面レイアウト変更 END
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (画面.s会員コード.Trim().Length != 0)
			if (g会員検索.s会員コード.Trim().Length != 0)
			{
//				tex会員コード.Text = 画面.s会員コード;
//				tex会員名.Text     = 画面.s会員名;
				tex会員コード.Text = g会員検索.s会員コード;
				tex会員名.Text     = g会員検索.s会員名;
// ADD 2006.11.09 東都）山本 会員検索画面からの復帰にてセクション数を表示する様に修正 START
				セクション数取得();
// ADD 2006.11.09 東都）山本 会員検索画面からの復帰にてセクション数を表示する様に修正 END
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//				btn請求先登録.Focus();
//// MOD 2005.05.25 東都）小童谷 画面高速化 END
				btn会員実行.Focus();
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
			}
			else
			{
				tex会員コード.Focus();
			}
		}

		private void btn請求先登録_Click(object sender, System.EventArgs e)
		{
			int nRet;

			tex得意先コード.Text     =  tex得意先コード.Text.Trim();
			tex得意先部課コード.Text =  tex得意先部課コード.Text.Trim();
			tex得意先部課名.Text     =  tex得意先部課名.Text.Trim();
			tex会員コード.Text       =  tex会員コード.Text.Trim();

// ADD 2007.01.22 東都）高木 画面レイアウト変更 START
			if(!必須チェック(tex会員コード, "お客様コード")) return;
// ADD 2007.01.22 東都）高木 画面レイアウト変更 END
			if(!必須チェック(tex得意先コード, "得意先コード")) return;
			if (tex得意先部課コード.Text.Length == 0)
			{
				tex得意先部課コード.Text = " ";
			}
			if(!必須チェック(tex得意先部課名, "得意先部課名")) return;
// DEL 2007.01.22 東都）高木 画面レイアウト変更 START
//			if(!必須チェック(tex会員コード, "会員コード")) return;
// DEL 2007.01.22 東都）高木 画面レイアウト変更 END

// ADD 2007.01.22 東都）高木 画面レイアウト変更 START
			if(!半角チェック(tex会員コード, "お客様コード")) return;
// ADD 2007.01.22 東都）高木 画面レイアウト変更 END
			if(!半角チェック(tex得意先コード, "得意先コード")) return;
			if(!半角チェック(tex得意先部課コード, "得意先部課コード")) return;
// DEL 2007.01.22 東都）高木 画面レイアウト変更 START
//			if(!半角チェック(tex会員コード, "会員コード")) return;
// DEL 2007.01.22 東都）高木 画面レイアウト変更 END
			if(!全角チェック(tex得意先部課名, "得意先部課名")) return;

			//郵便番号チェック
// MOD 2006.11.08 東都）山本 店所ログイン時の請求先登録する場合の店所コードチェック追加 START
//			if (!郵便番号検索())
			if ((nRet = 郵便番号チェック()) != 0)
// MOD 2006.11.08 東都）山本 店所ログイン時の請求先登録する場合の店所コードチェック追加 END
			{
// ADD 2006.11.08 東都）山本 店所ログイン時の請求先登録する場合の店所コードチェック追加 START
// MOD 2007.01.22 東都）高木 画面レイアウト変更 START
//				if(nRet != -1)
//					MessageBox.Show("入力された郵便番号の店所コードが管理店所コードと一致していません。","入力チェック",MessageBoxButtons.OK);
//				else
//// ADD 2006.11.08 東都）山本 店所ログイン時の請求先登録する場合の店所コードチェック追加 END
//					MessageBox.Show("郵便番号(" + tex郵便番号１.Text.Trim() + tex郵便番号２.Text.Trim() + ")が存在しません" ,"入力チェック",MessageBoxButtons.OK);
//				tex郵便番号１.Focus();
				switch(nRet)
				{
				case -1:
					MessageBox.Show("郵便番号(" + tex郵便番号１.Text.Trim() + tex郵便番号２.Text.Trim() + ")が存在しません",
									"入力チェック",MessageBoxButtons.OK);
					tex郵便番号１.Focus();
					break;
				case -2:
					MessageBox.Show("入力された郵便番号の店所コードが管理店所コードと一致していません。",
									"入力チェック",MessageBoxButtons.OK);
					tex郵便番号１.Focus();
					break;
				case -3:
					break;
				}
// MOD 2007.01.22 東都）高木 画面レイアウト変更 END
				return;
			}

			//会員チェック
			if (!会員名検索())
			{
//				MessageBox.Show("会員(" + tex会員コード.Text + ")が存在しません" ,"入力チェック",MessageBoxButtons.OK);
				MessageBox.Show("お客様(" + tex会員コード.Text + ")が存在しません" ,"入力チェック",MessageBoxButtons.OK);
				tex会員コード.Focus();
				return;
			}

// MOD 2016.04.13 BEVAS）松本 社内伝票対応 START
			if(tex会員コード.Text.Trim().Substring(0,2).ToUpper() == "FK")
			{
				/** 社内伝票会員の場合、請求先登録時には以下の条件を全て満たしていること */
				//(1) 管理者権限以外では、社内伝票会員の請求先登録を許可しない
				if(gs管理者区分 != "1")
				{
					MessageBox.Show("管理者以外の権限では、社内伝票会員の請求先は登録できません",
									"入力チェック",MessageBoxButtons.OK);
					tex会員コード.Focus();
					return;
				}
				//(2) 社内伝会員の扱店登録がなければエラー（扱店の登録漏れを防ぐ為）
				string[] sKey2  = new string[1];
				sKey2[0] = tex会員コード.Text.Trim();
				string[] sRet2 = sv_maintenance.Sel_HouseSlipMember(gsaユーザ, sKey2);
				if(!sRet2[0].Equals("正常終了"))
				{
					MessageBox.Show("社内伝票会員の場合、請求先情報を登録する前に社内伝票会員の扱店登録を行って下さい",
									"入力チェック",MessageBoxButtons.OK);
					tex会員コード.Focus();
					return;
				}
				//(3) 社内伝票会員の場合、請求先の郵便番号は社内伝票専用郵便番号(XXX-0044)でなければエラー
				string s請求先郵便番号 = tex郵便番号１.Text.Trim() + tex郵便番号２.Text.Trim();
				if(!s請求先郵便番号.Equals(s社内伝票用郵便番号))
				{
					MessageBox.Show("社内伝票会員の場合、請求先の郵便番号は「" + s社内伝票用郵便番号表示用 + "」を使用して下さい",
									"入力チェック",MessageBoxButtons.OK);
					tex郵便番号１.Focus();
					return;
				}
			}
// MOD 2016.04.13 BEVAS）松本 社内伝票対応 END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 START
//				string[] sKey  = new string[9];
				string[] sKey  = new string[10];
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 END
				sKey[0] = tex郵便番号１.Text.Trim() + tex郵便番号２.Text.Trim();
				sKey[1] = tex得意先コード.Text;
				sKey[2] = tex得意先部課コード.Text;
				sKey[3] = tex得意先部課名.Text;
				sKey[4] = tex会員コード.Text;
				sKey[5] = "請求先マ";
				sKey[6] = gs利用者コード;
				sKey[7] = s郵便番号;
				sKey[8] = s更新日時;
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 START
				sKey[9] = s会員ＣＤ;
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 END

				//請求先の追加更新
				if (btn請求先登録.Text.Equals("登録"))
				{
					//請求先の追加
					texメッセージ.Text = "登録中．．．";

					string[] sList = sv_maintenance.Ins_Claim(gsaユーザ, sKey);

					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						請求先一覧検索();
						請求先登録モード();
					}
					else
					{
						ビープ音();
					}
				}
				else
				{
					//請求先の更新
					texメッセージ.Text = "更新中．．．";

					string[] sList = sv_maintenance.Upd_Claim(gsaユーザ, sKey);

					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						請求先一覧検索();
						請求先登録モード();
					}
					else
					{
						ビープ音();
					}
				}
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//				tex郵便番号１.Focus();
				tex得意先コード.Focus();
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn請求先削除_Click(object sender, System.EventArgs e)
		{
			//請求先の削除
			texメッセージ.Text = "削除中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

// ADD 2008.11.20 東都）高木 得意先部課コードの空白時対応 START
//			tex得意先コード.Text     =  tex得意先コード.Text.Trim();
//			tex得意先部課コード.Text =  tex得意先部課コード.Text.Trim();
//			if(!必須チェック(tex得意先コード, "得意先コード")) return;
			if (tex得意先部課コード.Text.Length == 0)
			{
				tex得意先部課コード.Text = " ";
			}
//			if(!半角チェック(tex得意先コード, "得意先コード")) return;
//			if(!半角チェック(tex得意先部課コード, "得意先部課コード")) return;
// ADD 2008.11.20 東都）高木 得意先部課コードの空白時対応 END

			try
			{
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 START
//				string[] sKey  = new string[6];
				string[] sKey  = new string[7];
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 END
				sKey[0] = s郵便番号;
				sKey[1] = tex得意先コード.Text;
				sKey[2] = tex得意先部課コード.Text;
				sKey[3] = "請求先マ";
				sKey[4] = gs利用者コード;
				sKey[5] = s更新日時;
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 START
				sKey[6] = s会員ＣＤ;
// MOD 2011.03.09 東都）高木 請求先マスタの主キーに[会員ＣＤ]を追加 END

				string[] sList = sv_maintenance.Del_Claim(gsaユーザ, sKey);

				texメッセージ.Text = sList[0];
				if (sList[0].Equals("正常終了"))
				{
					請求先一覧検索();
					請求先登録モード();
				}
				else
				{
					ビープ音();
				}
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//				tex郵便番号１.Focus();
				tex得意先コード.Focus();
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn請求先取消_Click(object sender, System.EventArgs e)
		{
// MOD 2007.01.22 東都）高木 画面修正 START
//			請求先登録モード();
			初期モード１();
// MOD 2007.01.22 東都）高木 画面修正 END
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//			tex郵便番号１.Focus();
			texメッセージ.Text = "";

// DEL 2007.01.22 東都）高木 画面修正 START
//			tex会員コード.Text = "";
//			tex会員名.Text = "";
//
//			axGT請求先.Clear();
//			axGT請求先.CaretRow = 1;
//			axGT請求先_CurPlaceChanged(null,null);
//			axGT請求先.Enabled = false;
// DEL 2007.01.22 東都）高木 画面修正 END

// MOD 2007.01.22 東都）高木 画面修正 START
//			if(gs店所コード.Trim().Length != 0)
//			{
//				tex会員コード.Enabled = true;
//				btn会員検索.Enabled = true;
//				btn会員実行.Enabled = true;
//				tex会員コード.Text = " ";
//				tex会員コード.Focus();
//			}else{
			if(gs店所コード.Trim().Length == 0)
			{
// DEL 2007.01.22 東都）高木 画面修正 START
				tex会員コード.Enabled = false;
				btn会員検索.Enabled = false;
				btn会員実行.Enabled = false;

				tex管理店所コード.Enabled = true;
				btn管理店所検索.Enabled = true;
				tex管理店所コード.Text = " ";
				tex管理店所名.Text = "";
				tex管理店所コード.Focus();
				pnl請求先.Enabled = false;
			}
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
		}

		private void axGT請求先_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT請求先.set_CelForeColor(nOldRow,0,0);
			axGT請求先.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT請求先.set_CelForeColor(axGT請求先.CaretRow,0,111111);
			axGT請求先.set_CelForeColor(axGT請求先.CaretRow,0,0x98FB98);  //BGR
			axGT請求先.set_CelBackColor(axGT請求先.CaretRow,0,0x006000);
			nOldRow = axGT請求先.CaretRow;
		}

// ADD 2005.05.25 東都）小童谷 フォーカス移動 START
		private void 請求先マスタ_Closed(object sender, System.EventArgs e)
		{
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//			tex管理店所コード.Text = " ";
//			texメッセージ.Text = "";
//			tex管理店所名.Text = "";
//			axGT請求先.CaretRow = 1;
//			axGT請求先_CurPlaceChanged(null,null);
//			tex管理店所コード.Focus();
			btn請求先取消_Click(sender, e);
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
// ADD 2008.02.14 東都）高木 営業所で使用後、管理で使用した時の初期表示障害対応 START
			tex管理店所コード.Text    = " ";
			tex管理店所コード.Enabled = true;
			btn管理店所検索.Visible   = true;
			tex管理店所名.Text        = "";
			texメッセージ.Text        = "";
// MOD 2009.05.28 東都）高木 出荷実績一覧運賃非表示対応 START
			cb出荷実績一覧運賃非表示.Checked = false;
			btn会員更新.Enabled = false;
// MOD 2009.05.28 東都）高木 出荷実績一覧運賃非表示対応 END

			tex管理店所コード.Focus();
// ADD 2008.02.14 東都）高木 営業所で使用後、管理で使用した時の初期表示障害対応 END
		}
// ADD 2005.05.25 東都）小童谷 フォーカス移動 END

// ADD 2006.11.08 東都）山本 店所ログイン時の請求先登録する場合の店所コードチェック追加 START
		private int 郵便番号チェック()
		{
			tex郵便番号１.Text = tex郵便番号１.Text.Trim();
			tex郵便番号２.Text = tex郵便番号２.Text.Trim();
// MOD 2007.01.22 東都）高木 画面レイアウト変更 START
//			if (!必須チェック(tex郵便番号１, "郵便番号１")) return -1;
//			if (!半角チェック(tex郵便番号１, "郵便番号１")) return -1;
//			if (!必須チェック(tex郵便番号２, "郵便番号２")) return -1;
//			if (!半角チェック(tex郵便番号２, "郵便番号２")) return -1;
			if (!必須チェック(tex郵便番号１, "郵便番号１")) return -3;
			if (!必須チェック(tex郵便番号２, "郵便番号２")) return -3;
			if (!半角チェック(tex郵便番号１, "郵便番号１")) return -3;
			if (!半角チェック(tex郵便番号２, "郵便番号２")) return -3;
// MOD 2007.01.22 東都）高木 画面レイアウト変更 END
			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			int bRet = -1;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex郵便番号１.Text + tex郵便番号２.Text;
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//				string[] sList = sv_maintenance.Sel_Postcode1(gsaユーザ, sKey);
				String[] sList;
				tex会員コード.Text = tex会員コード.Text.Trim();
				if ((tex会員コード.Text == "") || (tex会員コード.Text.Substring(0,1) != "J"))
				{
					sList = sv_maintenance.Sel_Postcode1(gsaユーザ, sKey);

				}
				else
				{
					sList = sv_oji.Sel_Postcode1(gsaユーザ, sKey);
				}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

				if (sList[0].Equals("正常終了"))
				{
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					if ((tex会員コード.Text != "") && (tex会員コード.Text.Substring(0,1) == "J"))
					{
//MOD 2016.03.16 BEVAS）松本 王子運送版グローバル運用対応 START
						//選択した会員が王子グローバル荷主の場合は、下記処理をスキップする
						if(tex会員コード.Text.Substring(0,2) != "JG")
						{
//MOD 2016.03.16 BEVAS）松本 王子運送版グローバル運用対応 END
							String[] sKey1 = new string[1];
							sKey1[0] = sList[4].Trim();
							string[] sList1 = sv_oji.Sel_Member(gsaユーザ, sKey1);
							if (sList1[0].Equals("正常終了"))
							{
								if ((sList1[4] != "3") && (sList1[4] != "4"))
								{
									texメッセージ.Text = "指定した住所は、セクション登録不可能エリアです";
									tex郵便番号店所.Text = "";
									ビープ音();
									this.Cursor = System.Windows.Forms.Cursors.Default;
									return -3;
								}
							}
							else
							{
								texメッセージ.Text = sList[0];
								ビープ音();
								tex郵便番号店所.Text = "";
								tex郵便番号１.Focus();
								this.Cursor = System.Windows.Forms.Cursors.Default;
								return -3;
							}
//MOD 2016.03.16 BEVAS）松本 王子運送版グローバル運用対応 START
						}
//MOD 2016.03.16 BEVAS）松本 王子運送版グローバル運用対応 END
					}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

					texメッセージ.Text = "";
					tex郵便番号店所.Text = sList[1];
					if(gs店所コード.Trim().Length != 0)
					{
						if(gs店所コード.Trim() != sList[4].Trim())
						{
							texメッセージ.Text = "入力された郵便番号の店所コードが管理店所コードと一致していません。";
							bRet = -2;
						}
						else
							bRet = 0;
					}
					else
						bRet = 0;
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					tex郵便番号店所.Text = "";
					tex郵便番号１.Focus();
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return bRet;
		}
// ADD 2006.11.08 東都）山本 店所ログイン時の請求先登録する場合の店所コードチェック追加 END
// ADD 2006.11.09 東都）山本 会員検索画面からの復帰にてセクション数を表示する様に修正 START
		private void セクション数取得()
		{
			if((tex会員コード.Text.Trim().Length != 0)&&
			   (tex郵便番号１.Text.Trim().Length != 0)&&
			   (tex郵便番号２.Text.Trim().Length != 0))     // 会員コードと郵便番号の入力あり？
			{
				texメッセージ.Text = "";
				string[] sSectionKey = new string[2];
				sSectionKey[0] = tex会員コード.Text;
				sSectionKey[1] = tex郵便番号１.Text.Trim() + tex郵便番号２.Text.Trim();
				string[] sSectionList = sv_maintenance.Sel_SectionCount(gsaユーザ, sSectionKey);
															// セクション数の取得
				if (sSectionList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex部門数.Text = sSectionList[1];
				}
				else
				{
					texメッセージ.Text = sSectionList[0];
					ビープ音();
// DEL 2007.01.18 東都）高木 画面レイアウト変更 START
//					tex会員名.Text = "";
// DEL 2007.01.18 東都）高木 画面レイアウト変更 END
					tex部門数.Text = "";
				}
			}
			return;
		}
// ADD 2006.11.09 東都）山本 会員検索画面からの復帰にてセクション数を表示する様に修正 START
// ADD 2007.01.18 東都）高木 画面レイアウト変更 START
		private void btn会員実行_Click(object sender, System.EventArgs e)
		{
			tex会員コード.Text = tex会員コード.Text.Trim();
//			if(!必須チェック(tex会員コード, "お客様コード")) return;
			if(!半角チェック(tex会員コード, "お客様コード")) return;
			//会員チェック
			if(!会員名検索())
			{
				MessageBox.Show("お客様(" + tex会員コード.Text + ")が存在しません" ,"入力チェック",MessageBoxButtons.OK);
				tex会員コード.Focus();
				return;
			}

			if(請求先一覧検索())
			{
				axGT請求先.Enabled = true;
				請求先登録モード();
				tex得意先コード.Focus();
			}
		}
// ADD 2007.01.18 東都）高木 画面レイアウト変更 END
// MOD 2009.05.28 東都）高木 出荷実績一覧運賃非表示対応 START
		private void btn会員更新_Click(object sender, System.EventArgs e)
		{
			tex会員コード.Text = tex会員コード.Text.Trim();
			if(!必須チェック(tex会員コード, "お客様コード")) return;
			if(!半角チェック(tex会員コード, "お客様コード")) return;

			texメッセージ.Text = "お客様情報更新中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey = new string[5];
				sKey[0] = tex会員コード.Text;
				if(cb出荷実績一覧運賃非表示.Checked){
					sKey[1] = "1";
				}else{
					sKey[1] = "0";
				}
				sKey[2] = s会員更新日時;
				sKey[3] = "請求先マ";
				sKey[4] = gs利用者コード;
				string[] sList = sv_maintenance.Upd_Member2(gsaユーザ, sKey);
				if (sList[0].Equals("正常終了"))
				{
					s会員更新日時 = sList[1];
					texメッセージ.Text = "";
					MessageBox.Show("更新しました" ,"お客様情報更新",MessageBoxButtons.OK);
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
// MOD 2009.05.28 東都）高木 出荷実績一覧運賃非表示対応 END
	}
}
