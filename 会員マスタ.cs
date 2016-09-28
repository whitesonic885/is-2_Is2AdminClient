using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [お客様情報メンテナンス]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2007.01.27 東都）高木 会員申込への追加 
	// ADD 2007.01.30 東都）高木 パスワード使用可能文字の制限 
	// MOD 2007.02.06 東都）高木 営業所会員対応 
	// DEL 2007.02.06 東都）高木 パスワード使用可能文字チェックの廃止（by 桑田殿） 
	// ADD 2007.02.08 東都）高木 営業所会員対応 
	// ADD 2007.02.15 東都）高木 営業所会員対応 
	// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 東都）高木 設置場所住所の全角チェックの追加 
	// MOD 2008.05.07 東都）高木 メッセージ変更[会員]→[お客様]
	// ADD 2008.05.29 東都）高木 パスワード更新年月日を表示 
	//--------------------------------------------------------------------------
	// ADD 2009.03.03 東都）高木 サーマルシリアル番号の追加 
	// MOD 2009.04.28 東都）高木 削除確認メッセージの追加 
	//--------------------------------------------------------------------------
	// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	//--------------------------------------------------------------------------
	// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 
	//--------------------------------------------------------------------------
	// MOD 2016.03.16 BEVAS）松本 王子運送版グローバル運用対応 
	//--------------------------------------------------------------------------
	// MOD 2016.04.13 BEVAS）松本 社内伝票機能追加対応
	//--------------------------------------------------------------------------
	public class 会員マスタ : 共通フォーム//System.Windows.Forms.Form
	{
// ADD 2005.06.13 東都）小童谷 検索条件追加 START
		private string s部門コード = "";
// ADD 2005.06.13 東都）小童谷 検索条件追加 END
		private string sパスワード = "";
		private string s会員コード = "";
		private string s会員更新日時   = "00000000000000";
		private string s部門更新日時   = "00000000000000";
		private string s利用者更新日時 = "00000000000000";
		private int s認証エラー回数 = 0;
// ADD 2007.01.27 東都）高木 会員申込への追加 START
		private string s管理店所コード = "";
		private string s設置場所県コード = "";
		private string s設置場所住所１   = "";
		private string s簡易ユーザー = "";
// ADD 2007.01.27 東都）高木 会員申込への追加 END

		private short nOldRowB = 0;
		private short nOldRowR = 0;

		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lab日時;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lab会員マスタタイトル;
		private System.Windows.Forms.Button btn会員検索;
		private System.Windows.Forms.Button btn会員実行;
		private System.Windows.Forms.Label lab会員コード;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmb管理者区分;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lab管理者区分;
		private System.Windows.Forms.Label lab会員名;
		private AxGTABLE32V2Lib.AxGTable32 axGT部門;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private 共通テキストボックス tex部門コード;
		private 共通テキストボックス tex部門名;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btn部門登録;
		private System.Windows.Forms.Button btn部門削除;
		private System.Windows.Forms.Button btn部門取消;
		private 共通テキストボックス tex荷送人コード;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label23;
		private 共通テキストボックス tex利用者コード;
		private System.Windows.Forms.Label label25;
		private AxGTABLE32V2Lib.AxGTable32 axGT利用者;
		private System.Windows.Forms.Button btn利用者取消;
		private System.Windows.Forms.Button btn利用者削除;
		private System.Windows.Forms.Button btn利用者登録;
		private System.Windows.Forms.Label lab使用開始日;
		private System.Windows.Forms.Button btn荷送人検索;
		private System.Windows.Forms.Panel pnl会員;
		private System.Windows.Forms.Panel pnl部門;
		private System.Windows.Forms.Panel pnl利用者;
		private 共通テキストボックス tex会員名;
		private 共通テキストボックス tex会員コード;
		private 共通テキストボックス texメッセージ;
		private System.Windows.Forms.Button btn会員登録;
		private System.Windows.Forms.Label lab使用終了日;
		private System.Windows.Forms.Label lab管理店所;
		private System.Windows.Forms.Label lab出力順;
		private System.Windows.Forms.Label lab部門名;
		private System.Windows.Forms.Label lab部門コード;
		private System.Windows.Forms.Label lab荷送人コード;
		private System.Windows.Forms.Label lab利用者名;
		private System.Windows.Forms.Label labパスワード;
		private System.Windows.Forms.Label lab利用者コード;
		private 共通テキストボックス tex管理店所名;
		private 共通テキストボックス tex利用者名;
		private 共通テキストボックス texパスワード;
		private System.Windows.Forms.CheckBox chb使用終了日;
		private System.Windows.Forms.DateTimePicker dtp使用終了日;
		private System.Windows.Forms.DateTimePicker dtp使用開始日;
		private System.Windows.Forms.NumericUpDown num出力順;
		private 共通テキストボックス tex認証利用者名;
		private System.Windows.Forms.Label lab認証利用者名;
		private System.Windows.Forms.Label lab認証会員名;
		private 共通テキストボックス tex認証会員名;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btn住所検索;
		private 共通テキストボックス tex郵便番号２;
		private 共通テキストボックス tex郵便番号１;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lab郵便番号;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btn自動発行;
		private System.Windows.Forms.Button btnパスワードロック;
		private is2AdminClient.共通テキストボックス tex設置先住所１;
		private is2AdminClient.共通テキストボックス tex設置先住所２;
		private System.Windows.Forms.NumericUpDown numサーマル台数;
		private System.Windows.Forms.Label labサーマル;
		private System.Windows.Forms.Label lab設置住所;
		private System.Windows.Forms.Label lab台;
		private System.Windows.Forms.Label lab終了日;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label11;
		private 共通テキストボックス tex簡易ユーザー;
		private System.Windows.Forms.Label lab簡易ユーザー;
		private System.Windows.Forms.CheckBox chbラベル印刷禁止;
		private System.Windows.Forms.Button btn会員削除;
		private System.Windows.Forms.Button btn新規;
		private System.Windows.Forms.Label labパスワード更新日;
		private is2AdminClient.共通テキストボックス texパスワード更新日;
		private is2AdminClient.共通テキストボックス texシリアル番号１;
		private is2AdminClient.共通テキストボックス texシリアル番号２;
		private is2AdminClient.共通テキストボックス texシリアル番号３;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label49;
		private is2AdminClient.共通テキストボックス tex設置場所使用料;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cmbシリアル番号１;
		private System.Windows.Forms.ComboBox cmbシリアル番号２;
		private System.Windows.Forms.ComboBox cmbシリアル番号３;
		private is2AdminClient.共通テキストボックス texシリアル番号４;
		private System.Windows.Forms.ComboBox cmbシリアル番号４;
		private System.Windows.Forms.CheckBox cb運用中のお客様のみ;
		private System.Windows.Forms.CheckBox cb才数重量入力取込;
		private System.Windows.Forms.Button btn社内伝会員発店登録;
		private System.ComponentModel.IContainer components;

		public 会員マスタ()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(会員マスタ));
            this.tex会員名 = new is2AdminClient.共通テキストボックス();
            this.pnl会員 = new System.Windows.Forms.Panel();
            this.cb才数重量入力取込 = new System.Windows.Forms.CheckBox();
            this.btn会員削除 = new System.Windows.Forms.Button();
            this.lab終了日 = new System.Windows.Forms.Label();
            this.chb使用終了日 = new System.Windows.Forms.CheckBox();
            this.dtp使用終了日 = new System.Windows.Forms.DateTimePicker();
            this.lab使用終了日 = new System.Windows.Forms.Label();
            this.btn会員登録 = new System.Windows.Forms.Button();
            this.dtp使用開始日 = new System.Windows.Forms.DateTimePicker();
            this.cmb管理者区分 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab管理者区分 = new System.Windows.Forms.Label();
            this.lab使用開始日 = new System.Windows.Forms.Label();
            this.lab会員名 = new System.Windows.Forms.Label();
            this.btn社内伝会員発店登録 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cb運用中のお客様のみ = new System.Windows.Forms.CheckBox();
            this.btn新規 = new System.Windows.Forms.Button();
            this.btn会員検索 = new System.Windows.Forms.Button();
            this.btn会員実行 = new System.Windows.Forms.Button();
            this.lab会員コード = new System.Windows.Forms.Label();
            this.tex会員コード = new is2AdminClient.共通テキストボックス();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tex認証利用者名 = new is2AdminClient.共通テキストボックス();
            this.lab認証利用者名 = new System.Windows.Forms.Label();
            this.lab認証会員名 = new System.Windows.Forms.Label();
            this.tex認証会員名 = new is2AdminClient.共通テキストボックス();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab日時 = new System.Windows.Forms.Label();
            this.lab会員マスタタイトル = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.texメッセージ = new is2AdminClient.共通テキストボックス();
            this.btn閉じる = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl部門 = new System.Windows.Forms.Panel();
            this.cmbシリアル番号４ = new System.Windows.Forms.ComboBox();
            this.texシリアル番号４ = new is2AdminClient.共通テキストボックス();
            this.cmbシリアル番号３ = new System.Windows.Forms.ComboBox();
            this.cmbシリアル番号２ = new System.Windows.Forms.ComboBox();
            this.cmbシリアル番号１ = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.tex設置場所使用料 = new is2AdminClient.共通テキストボックス();
            this.label34 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.texシリアル番号３ = new is2AdminClient.共通テキストボックス();
            this.texシリアル番号２ = new is2AdminClient.共通テキストボックス();
            this.texシリアル番号１ = new is2AdminClient.共通テキストボックス();
            this.lab簡易ユーザー = new System.Windows.Forms.Label();
            this.tex簡易ユーザー = new is2AdminClient.共通テキストボックス();
            this.lab台 = new System.Windows.Forms.Label();
            this.numサーマル台数 = new System.Windows.Forms.NumericUpDown();
            this.labサーマル = new System.Windows.Forms.Label();
            this.tex設置先住所２ = new is2AdminClient.共通テキストボックス();
            this.tex設置先住所１ = new is2AdminClient.共通テキストボックス();
            this.lab設置住所 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn住所検索 = new System.Windows.Forms.Button();
            this.tex郵便番号２ = new is2AdminClient.共通テキストボックス();
            this.tex郵便番号１ = new is2AdminClient.共通テキストボックス();
            this.label10 = new System.Windows.Forms.Label();
            this.lab郵便番号 = new System.Windows.Forms.Label();
            this.num出力順 = new System.Windows.Forms.NumericUpDown();
            this.tex管理店所名 = new is2AdminClient.共通テキストボックス();
            this.btn部門取消 = new System.Windows.Forms.Button();
            this.btn部門削除 = new System.Windows.Forms.Button();
            this.btn部門登録 = new System.Windows.Forms.Button();
            this.lab管理店所 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lab出力順 = new System.Windows.Forms.Label();
            this.tex部門名 = new is2AdminClient.共通テキストボックス();
            this.label6 = new System.Windows.Forms.Label();
            this.lab部門名 = new System.Windows.Forms.Label();
            this.tex部門コード = new is2AdminClient.共通テキストボックス();
            this.label4 = new System.Windows.Forms.Label();
            this.lab部門コード = new System.Windows.Forms.Label();
            this.axGT部門 = new AxGTABLE32V2Lib.AxGTable32();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl利用者 = new System.Windows.Forms.Panel();
            this.texパスワード更新日 = new is2AdminClient.共通テキストボックス();
            this.labパスワード更新日 = new System.Windows.Forms.Label();
            this.chbラベル印刷禁止 = new System.Windows.Forms.CheckBox();
            this.btnパスワードロック = new System.Windows.Forms.Button();
            this.btn自動発行 = new System.Windows.Forms.Button();
            this.btn荷送人検索 = new System.Windows.Forms.Button();
            this.btn利用者取消 = new System.Windows.Forms.Button();
            this.btn利用者削除 = new System.Windows.Forms.Button();
            this.btn利用者登録 = new System.Windows.Forms.Button();
            this.tex荷送人コード = new is2AdminClient.共通テキストボックス();
            this.lab荷送人コード = new System.Windows.Forms.Label();
            this.tex利用者名 = new is2AdminClient.共通テキストボックス();
            this.label21 = new System.Windows.Forms.Label();
            this.lab利用者名 = new System.Windows.Forms.Label();
            this.texパスワード = new is2AdminClient.共通テキストボックス();
            this.label23 = new System.Windows.Forms.Label();
            this.labパスワード = new System.Windows.Forms.Label();
            this.tex利用者コード = new is2AdminClient.共通テキストボックス();
            this.label25 = new System.Windows.Forms.Label();
            this.lab利用者コード = new System.Windows.Forms.Label();
            this.axGT利用者 = new AxGTABLE32V2Lib.AxGTable32();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnl会員.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnl部門.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numサーマル台数)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num出力順)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGT部門)).BeginInit();
            this.pnl利用者.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT利用者)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tex会員名
            // 
            this.tex会員名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex会員名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex会員名.Location = new System.Drawing.Point(104, 4);
            this.tex会員名.MaxLength = 20;
            this.tex会員名.Name = "tex会員名";
            this.tex会員名.Size = new System.Drawing.Size(326, 23);
            this.tex会員名.TabIndex = 1;
            // 
            // pnl会員
            // 
            this.pnl会員.BackColor = System.Drawing.Color.Honeydew;
            this.pnl会員.Controls.Add(this.cb才数重量入力取込);
            this.pnl会員.Controls.Add(this.btn会員削除);
            this.pnl会員.Controls.Add(this.lab終了日);
            this.pnl会員.Controls.Add(this.chb使用終了日);
            this.pnl会員.Controls.Add(this.dtp使用終了日);
            this.pnl会員.Controls.Add(this.lab使用終了日);
            this.pnl会員.Controls.Add(this.btn会員登録);
            this.pnl会員.Controls.Add(this.dtp使用開始日);
            this.pnl会員.Controls.Add(this.cmb管理者区分);
            this.pnl会員.Controls.Add(this.label7);
            this.pnl会員.Controls.Add(this.label3);
            this.pnl会員.Controls.Add(this.label2);
            this.pnl会員.Controls.Add(this.label1);
            this.pnl会員.Controls.Add(this.lab管理者区分);
            this.pnl会員.Controls.Add(this.lab使用開始日);
            this.pnl会員.Controls.Add(this.tex会員名);
            this.pnl会員.Controls.Add(this.lab会員名);
            this.pnl会員.ForeColor = System.Drawing.Color.LimeGreen;
            this.pnl会員.Location = new System.Drawing.Point(1, 6);
            this.pnl会員.Name = "pnl会員";
            this.pnl会員.Size = new System.Drawing.Size(721, 56);
            this.pnl会員.TabIndex = 1;
            // 
            // cb才数重量入力取込
            // 
            this.cb才数重量入力取込.ForeColor = System.Drawing.Color.LimeGreen;
            this.cb才数重量入力取込.Location = new System.Drawing.Point(466, 34);
            this.cb才数重量入力取込.Name = "cb才数重量入力取込";
            this.cb才数重量入力取込.Size = new System.Drawing.Size(142, 16);
            this.cb才数重量入力取込.TabIndex = 58;
            this.cb才数重量入力取込.Text = "お客様才数、重量取込";
            // 
            // btn会員削除
            // 
            this.btn会員削除.BackColor = System.Drawing.Color.Blue;
            this.btn会員削除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn会員削除.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn会員削除.ForeColor = System.Drawing.Color.White;
            this.btn会員削除.Location = new System.Drawing.Point(666, 30);
            this.btn会員削除.Name = "btn会員削除";
            this.btn会員削除.Size = new System.Drawing.Size(48, 22);
            this.btn会員削除.TabIndex = 57;
            this.btn会員削除.Text = "削除";
            this.btn会員削除.UseVisualStyleBackColor = false;
            this.btn会員削除.Click += new System.EventHandler(this.btn会員削除_Click);
            // 
            // lab終了日
            // 
            this.lab終了日.BackColor = System.Drawing.Color.White;
            this.lab終了日.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab終了日.Location = new System.Drawing.Point(326, 32);
            this.lab終了日.Name = "lab終了日";
            this.lab終了日.Size = new System.Drawing.Size(112, 16);
            this.lab終了日.TabIndex = 56;
            // 
            // chb使用終了日
            // 
            this.chb使用終了日.Location = new System.Drawing.Point(306, 34);
            this.chb使用終了日.Name = "chb使用終了日";
            this.chb使用終了日.Size = new System.Drawing.Size(16, 14);
            this.chb使用終了日.TabIndex = 4;
            this.chb使用終了日.TabStop = false;
            this.chb使用終了日.CheckedChanged += new System.EventHandler(this.chb使用終了日_CheckedChanged);
            // 
            // dtp使用終了日
            // 
            this.dtp使用終了日.CalendarFont = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp使用終了日.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp使用終了日.Location = new System.Drawing.Point(324, 30);
            this.dtp使用終了日.Name = "dtp使用終了日";
            this.dtp使用終了日.Size = new System.Drawing.Size(134, 22);
            this.dtp使用終了日.TabIndex = 5;
            this.dtp使用終了日.TabStop = false;
            this.dtp使用終了日.DropDown += new System.EventHandler(this.dtp使用終了日_DropDown);
            // 
            // lab使用終了日
            // 
            this.lab使用終了日.Location = new System.Drawing.Point(242, 34);
            this.lab使用終了日.Name = "lab使用終了日";
            this.lab使用終了日.Size = new System.Drawing.Size(66, 14);
            this.lab使用終了日.TabIndex = 55;
            this.lab使用終了日.Text = "使用終了日";
            // 
            // btn会員登録
            // 
            this.btn会員登録.BackColor = System.Drawing.Color.Blue;
            this.btn会員登録.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn会員登録.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn会員登録.ForeColor = System.Drawing.Color.White;
            this.btn会員登録.Location = new System.Drawing.Point(612, 30);
            this.btn会員登録.Name = "btn会員登録";
            this.btn会員登録.Size = new System.Drawing.Size(48, 22);
            this.btn会員登録.TabIndex = 6;
            this.btn会員登録.Text = "登録";
            this.btn会員登録.UseVisualStyleBackColor = false;
            this.btn会員登録.Click += new System.EventHandler(this.btn会員登録_Click);
            // 
            // dtp使用開始日
            // 
            this.dtp使用開始日.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp使用開始日.Location = new System.Drawing.Point(104, 30);
            this.dtp使用開始日.Name = "dtp使用開始日";
            this.dtp使用開始日.Size = new System.Drawing.Size(134, 22);
            this.dtp使用開始日.TabIndex = 2;
            // 
            // cmb管理者区分
            // 
            this.cmb管理者区分.Items.AddRange(new object[] {
            "一般会員",
            "管理者会員",
            "営業所会員",
            "王子一般会員",
            "王子営業所会員"});
            this.cmb管理者区分.Location = new System.Drawing.Point(514, 4);
            this.cmb管理者区分.Name = "cmb管理者区分";
            this.cmb管理者区分.Size = new System.Drawing.Size(108, 20);
            this.cmb管理者区分.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(436, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 14);
            this.label7.TabIndex = 51;
            this.label7.Text = "※";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(26, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 14);
            this.label3.TabIndex = 50;
            this.label3.Text = "※";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 14);
            this.label2.TabIndex = 49;
            this.label2.Text = "※";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.label1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 56);
            this.label1.TabIndex = 44;
            this.label1.Text = "お客様";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab管理者区分
            // 
            this.lab管理者区分.Location = new System.Drawing.Point(450, 8);
            this.lab管理者区分.Name = "lab管理者区分";
            this.lab管理者区分.Size = new System.Drawing.Size(66, 14);
            this.lab管理者区分.TabIndex = 19;
            this.lab管理者区分.Text = "管理者区分";
            // 
            // lab使用開始日
            // 
            this.lab使用開始日.Location = new System.Drawing.Point(40, 34);
            this.lab使用開始日.Name = "lab使用開始日";
            this.lab使用開始日.Size = new System.Drawing.Size(66, 14);
            this.lab使用開始日.TabIndex = 15;
            this.lab使用開始日.Text = "使用開始日";
            // 
            // lab会員名
            // 
            this.lab会員名.Location = new System.Drawing.Point(40, 10);
            this.lab会員名.Name = "lab会員名";
            this.lab会員名.Size = new System.Drawing.Size(66, 14);
            this.lab会員名.TabIndex = 9;
            this.lab会員名.Text = "お客様名";
            // 
            // btn社内伝会員発店登録
            // 
            this.btn社内伝会員発店登録.BackColor = System.Drawing.Color.PaleGreen;
            this.btn社内伝会員発店登録.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn社内伝会員発店登録.ForeColor = System.Drawing.Color.Blue;
            this.btn社内伝会員発店登録.Location = new System.Drawing.Point(90, 6);
            this.btn社内伝会員発店登録.Name = "btn社内伝会員発店登録";
            this.btn社内伝会員発店登録.Size = new System.Drawing.Size(54, 48);
            this.btn社内伝会員発店登録.TabIndex = 59;
            this.btn社内伝会員発店登録.Text = "発店　　登録";
            this.btn社内伝会員発店登録.UseVisualStyleBackColor = false;
            this.btn社内伝会員発店登録.Click += new System.EventHandler(this.btn社内伝会員発店登録_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.cb運用中のお客様のみ);
            this.panel5.Controls.Add(this.btn新規);
            this.panel5.Controls.Add(this.btn会員検索);
            this.panel5.Controls.Add(this.btn会員実行);
            this.panel5.Controls.Add(this.lab会員コード);
            this.panel5.Controls.Add(this.tex会員コード);
            this.panel5.Location = new System.Drawing.Point(1, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(609, 32);
            this.panel5.TabIndex = 0;
            // 
            // cb運用中のお客様のみ
            // 
            this.cb運用中のお客様のみ.ForeColor = System.Drawing.Color.LimeGreen;
            this.cb運用中のお客様のみ.Location = new System.Drawing.Point(412, 8);
            this.cb運用中のお客様のみ.Name = "cb運用中のお客様のみ";
            this.cb運用中のお客様のみ.Size = new System.Drawing.Size(152, 16);
            this.cb運用中のお客様のみ.TabIndex = 4;
            this.cb運用中のお客様のみ.Text = "運用中のお客様のみ対象";
            // 
            // btn新規
            // 
            this.btn新規.BackColor = System.Drawing.Color.Blue;
            this.btn新規.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn新規.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn新規.ForeColor = System.Drawing.Color.White;
            this.btn新規.Location = new System.Drawing.Point(344, 5);
            this.btn新規.Name = "btn新規";
            this.btn新規.Size = new System.Drawing.Size(48, 22);
            this.btn新規.TabIndex = 3;
            this.btn新規.Text = "新規";
            this.btn新規.UseVisualStyleBackColor = false;
            this.btn新規.Click += new System.EventHandler(this.btn新規_Click);
            // 
            // btn会員検索
            // 
            this.btn会員検索.BackColor = System.Drawing.Color.SteelBlue;
            this.btn会員検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn会員検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn会員検索.ForeColor = System.Drawing.Color.White;
            this.btn会員検索.Location = new System.Drawing.Point(236, 5);
            this.btn会員検索.Name = "btn会員検索";
            this.btn会員検索.Size = new System.Drawing.Size(48, 22);
            this.btn会員検索.TabIndex = 1;
            this.btn会員検索.TabStop = false;
            this.btn会員検索.Text = "検索";
            this.btn会員検索.UseVisualStyleBackColor = false;
            this.btn会員検索.Click += new System.EventHandler(this.btn会員検索_Click);
            // 
            // btn会員実行
            // 
            this.btn会員実行.BackColor = System.Drawing.Color.Blue;
            this.btn会員実行.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn会員実行.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn会員実行.ForeColor = System.Drawing.Color.White;
            this.btn会員実行.Location = new System.Drawing.Point(290, 5);
            this.btn会員実行.Name = "btn会員実行";
            this.btn会員実行.Size = new System.Drawing.Size(48, 22);
            this.btn会員実行.TabIndex = 2;
            this.btn会員実行.Text = "実行";
            this.btn会員実行.UseVisualStyleBackColor = false;
            this.btn会員実行.Click += new System.EventHandler(this.btn会員実行_Click);
            // 
            // lab会員コード
            // 
            this.lab会員コード.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab会員コード.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab会員コード.Location = new System.Drawing.Point(4, 8);
            this.lab会員コード.Name = "lab会員コード";
            this.lab会員コード.Size = new System.Drawing.Size(86, 16);
            this.lab会員コード.TabIndex = 6;
            this.lab会員コード.Text = "お客様コード";
            // 
            // tex会員コード
            // 
            this.tex会員コード.BackColor = System.Drawing.SystemColors.Window;
            this.tex会員コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex会員コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex会員コード.Location = new System.Drawing.Point(90, 4);
            this.tex会員コード.MaxLength = 10;
            this.tex会員コード.Name = "tex会員コード";
            this.tex会員コード.Size = new System.Drawing.Size(140, 23);
            this.tex会員コード.TabIndex = 0;
            this.tex会員コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex会員コード_KeyPress);
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
            this.tex認証利用者名.Location = new System.Drawing.Point(470, 5);
            this.tex認証利用者名.Name = "tex認証利用者名";
            this.tex認証利用者名.ReadOnly = true;
            this.tex認証利用者名.Size = new System.Drawing.Size(322, 16);
            this.tex認証利用者名.TabIndex = 0;
            this.tex認証利用者名.TabStop = false;
            this.tex認証利用者名.Text = "国国国国国国国国国国王王王王王王王王王王";
            this.tex認証利用者名.Visible = false;
            // 
            // lab認証利用者名
            // 
            this.lab認証利用者名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab認証利用者名.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab認証利用者名.Location = new System.Drawing.Point(418, 7);
            this.lab認証利用者名.Name = "lab認証利用者名";
            this.lab認証利用者名.Size = new System.Drawing.Size(54, 14);
            this.lab認証利用者名.TabIndex = 0;
            this.lab認証利用者名.Text = "ユーザー";
            this.lab認証利用者名.Visible = false;
            // 
            // lab認証会員名
            // 
            this.lab認証会員名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab認証会員名.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab認証会員名.Location = new System.Drawing.Point(12, 7);
            this.lab認証会員名.Name = "lab認証会員名";
            this.lab認証会員名.Size = new System.Drawing.Size(54, 14);
            this.lab認証会員名.TabIndex = 0;
            this.lab認証会員名.Text = "お客様名";
            // 
            // tex認証会員名
            // 
            this.tex認証会員名.BackColor = System.Drawing.Color.PaleGreen;
            this.tex認証会員名.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex認証会員名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex認証会員名.ForeColor = System.Drawing.Color.Green;
            this.tex認証会員名.Location = new System.Drawing.Point(70, 5);
            this.tex認証会員名.Name = "tex認証会員名";
            this.tex認証会員名.ReadOnly = true;
            this.tex認証会員名.Size = new System.Drawing.Size(328, 16);
            this.tex認証会員名.TabIndex = 0;
            this.tex認証会員名.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab日時);
            this.panel7.Controls.Add(this.lab会員マスタタイトル);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(794, 26);
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
            // lab会員マスタタイトル
            // 
            this.lab会員マスタタイトル.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab会員マスタタイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab会員マスタタイトル.ForeColor = System.Drawing.Color.White;
            this.lab会員マスタタイトル.Location = new System.Drawing.Point(12, 2);
            this.lab会員マスタタイトル.Name = "lab会員マスタタイトル";
            this.lab会員マスタタイトル.Size = new System.Drawing.Size(264, 24);
            this.lab会員マスタタイトル.TabIndex = 0;
            this.lab会員マスタタイトル.Text = "お客様情報メンテナンス";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PaleGreen;
            this.panel8.Controls.Add(this.texメッセージ);
            this.panel8.Controls.Add(this.btn閉じる);
            this.panel8.Controls.Add(this.btn社内伝会員発店登録);
            this.panel8.Location = new System.Drawing.Point(0, 516);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(794, 58);
            this.panel8.TabIndex = 4;
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
            this.texメッセージ.TabIndex = 30;
            this.texメッセージ.TabStop = false;
            // 
            // btn閉じる
            // 
            this.btn閉じる.ForeColor = System.Drawing.Color.Red;
            this.btn閉じる.Location = new System.Drawing.Point(8, 6);
            this.btn閉じる.Name = "btn閉じる";
            this.btn閉じる.Size = new System.Drawing.Size(54, 48);
            this.btn閉じる.TabIndex = 29;
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
            // pnl部門
            // 
            this.pnl部門.BackColor = System.Drawing.Color.Honeydew;
            this.pnl部門.Controls.Add(this.cmbシリアル番号４);
            this.pnl部門.Controls.Add(this.texシリアル番号４);
            this.pnl部門.Controls.Add(this.cmbシリアル番号３);
            this.pnl部門.Controls.Add(this.cmbシリアル番号２);
            this.pnl部門.Controls.Add(this.cmbシリアル番号１);
            this.pnl部門.Controls.Add(this.label14);
            this.pnl部門.Controls.Add(this.label49);
            this.pnl部門.Controls.Add(this.tex設置場所使用料);
            this.pnl部門.Controls.Add(this.label34);
            this.pnl部門.Controls.Add(this.label13);
            this.pnl部門.Controls.Add(this.texシリアル番号３);
            this.pnl部門.Controls.Add(this.texシリアル番号２);
            this.pnl部門.Controls.Add(this.texシリアル番号１);
            this.pnl部門.Controls.Add(this.lab簡易ユーザー);
            this.pnl部門.Controls.Add(this.tex簡易ユーザー);
            this.pnl部門.Controls.Add(this.lab台);
            this.pnl部門.Controls.Add(this.numサーマル台数);
            this.pnl部門.Controls.Add(this.labサーマル);
            this.pnl部門.Controls.Add(this.tex設置先住所２);
            this.pnl部門.Controls.Add(this.tex設置先住所１);
            this.pnl部門.Controls.Add(this.lab設置住所);
            this.pnl部門.Controls.Add(this.label9);
            this.pnl部門.Controls.Add(this.btn住所検索);
            this.pnl部門.Controls.Add(this.tex郵便番号２);
            this.pnl部門.Controls.Add(this.tex郵便番号１);
            this.pnl部門.Controls.Add(this.label10);
            this.pnl部門.Controls.Add(this.lab郵便番号);
            this.pnl部門.Controls.Add(this.num出力順);
            this.pnl部門.Controls.Add(this.tex管理店所名);
            this.pnl部門.Controls.Add(this.btn部門取消);
            this.pnl部門.Controls.Add(this.btn部門削除);
            this.pnl部門.Controls.Add(this.btn部門登録);
            this.pnl部門.Controls.Add(this.lab管理店所);
            this.pnl部門.Controls.Add(this.label12);
            this.pnl部門.Controls.Add(this.lab出力順);
            this.pnl部門.Controls.Add(this.tex部門名);
            this.pnl部門.Controls.Add(this.label6);
            this.pnl部門.Controls.Add(this.lab部門名);
            this.pnl部門.Controls.Add(this.tex部門コード);
            this.pnl部門.Controls.Add(this.label4);
            this.pnl部門.Controls.Add(this.lab部門コード);
            this.pnl部門.Controls.Add(this.axGT部門);
            this.pnl部門.Controls.Add(this.label8);
            this.pnl部門.ForeColor = System.Drawing.Color.LimeGreen;
            this.pnl部門.Location = new System.Drawing.Point(1, 6);
            this.pnl部門.Name = "pnl部門";
            this.pnl部門.Size = new System.Drawing.Size(429, 356);
            this.pnl部門.TabIndex = 2;
            // 
            // cmbシリアル番号４
            // 
            this.cmbシリアル番号４.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.cmbシリアル番号４.Items.AddRange(new object[] {
            "",
            "返品",
            "不良品",
            "不明",
            "その他",
            "発送中"});
            this.cmbシリアル番号４.Location = new System.Drawing.Point(230, 284);
            this.cmbシリアル番号４.MaxDropDownItems = 9;
            this.cmbシリアル番号４.Name = "cmbシリアル番号４";
            this.cmbシリアル番号４.Size = new System.Drawing.Size(76, 23);
            this.cmbシリアル番号４.TabIndex = 16;
            // 
            // texシリアル番号４
            // 
            this.texシリアル番号４.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texシリアル番号４.Location = new System.Drawing.Point(100, 284);
            this.texシリアル番号４.MaxLength = 15;
            this.texシリアル番号４.Name = "texシリアル番号４";
            this.texシリアル番号４.Size = new System.Drawing.Size(130, 22);
            this.texシリアル番号４.TabIndex = 15;
            this.texシリアル番号４.Text = "123456789012345";
            // 
            // cmbシリアル番号３
            // 
            this.cmbシリアル番号３.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.cmbシリアル番号３.Items.AddRange(new object[] {
            "",
            "返品",
            "不良品",
            "不明",
            "その他",
            "発送中"});
            this.cmbシリアル番号３.Location = new System.Drawing.Point(230, 262);
            this.cmbシリアル番号３.MaxDropDownItems = 9;
            this.cmbシリアル番号３.Name = "cmbシリアル番号３";
            this.cmbシリアル番号３.Size = new System.Drawing.Size(76, 23);
            this.cmbシリアル番号３.TabIndex = 14;
            // 
            // cmbシリアル番号２
            // 
            this.cmbシリアル番号２.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.cmbシリアル番号２.Items.AddRange(new object[] {
            "",
            "返品",
            "不良品",
            "不明",
            "その他",
            "発送中"});
            this.cmbシリアル番号２.Location = new System.Drawing.Point(230, 240);
            this.cmbシリアル番号２.MaxDropDownItems = 9;
            this.cmbシリアル番号２.Name = "cmbシリアル番号２";
            this.cmbシリアル番号２.Size = new System.Drawing.Size(76, 23);
            this.cmbシリアル番号２.TabIndex = 12;
            // 
            // cmbシリアル番号１
            // 
            this.cmbシリアル番号１.Font = new System.Drawing.Font("MS UI Gothic", 11.25F);
            this.cmbシリアル番号１.Items.AddRange(new object[] {
            "",
            "返品",
            "不良品",
            "不明",
            "その他",
            "発送中"});
            this.cmbシリアル番号１.Location = new System.Drawing.Point(230, 218);
            this.cmbシリアル番号１.MaxDropDownItems = 6;
            this.cmbシリアル番号１.Name = "cmbシリアル番号１";
            this.cmbシリアル番号１.Size = new System.Drawing.Size(76, 23);
            this.cmbシリアル番号１.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(38, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 14);
            this.label14.TabIndex = 112;
            this.label14.Text = "サーマル";
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(260, 314);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(16, 14);
            this.label49.TabIndex = 111;
            this.label49.Text = "円";
            // 
            // tex設置場所使用料
            // 
            this.tex設置場所使用料.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.tex設置場所使用料.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex設置場所使用料.Location = new System.Drawing.Point(206, 308);
            this.tex設置場所使用料.MaxLength = 6;
            this.tex設置場所使用料.Name = "tex設置場所使用料";
            this.tex設置場所使用料.Size = new System.Drawing.Size(54, 21);
            this.tex設置場所使用料.TabIndex = 18;
            this.tex設置場所使用料.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(166, 312);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(42, 14);
            this.label34.TabIndex = 110;
            this.label34.Text = "使用料";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(38, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 14);
            this.label13.TabIndex = 82;
            this.label13.Text = "シリアルＮＯ";
            // 
            // texシリアル番号３
            // 
            this.texシリアル番号３.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texシリアル番号３.Location = new System.Drawing.Point(100, 262);
            this.texシリアル番号３.MaxLength = 15;
            this.texシリアル番号３.Name = "texシリアル番号３";
            this.texシリアル番号３.Size = new System.Drawing.Size(130, 22);
            this.texシリアル番号３.TabIndex = 13;
            this.texシリアル番号３.Text = "123456789012345";
            // 
            // texシリアル番号２
            // 
            this.texシリアル番号２.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texシリアル番号２.Location = new System.Drawing.Point(100, 240);
            this.texシリアル番号２.MaxLength = 15;
            this.texシリアル番号２.Name = "texシリアル番号２";
            this.texシリアル番号２.Size = new System.Drawing.Size(130, 22);
            this.texシリアル番号２.TabIndex = 11;
            this.texシリアル番号２.Text = "123456789012345";
            // 
            // texシリアル番号１
            // 
            this.texシリアル番号１.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texシリアル番号１.Location = new System.Drawing.Point(100, 218);
            this.texシリアル番号１.MaxLength = 15;
            this.texシリアル番号１.Name = "texシリアル番号１";
            this.texシリアル番号１.Size = new System.Drawing.Size(130, 22);
            this.texシリアル番号１.TabIndex = 9;
            this.texシリアル番号１.Text = "123456789012345";
            // 
            // lab簡易ユーザー
            // 
            this.lab簡易ユーザー.Location = new System.Drawing.Point(26, 334);
            this.lab簡易ユーザー.Name = "lab簡易ユーザー";
            this.lab簡易ユーザー.Size = new System.Drawing.Size(74, 14);
            this.lab簡易ユーザー.TabIndex = 76;
            this.lab簡易ユーザー.Text = "ユーザーコード";
            // 
            // tex簡易ユーザー
            // 
            this.tex簡易ユーザー.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.tex簡易ユーザー.Location = new System.Drawing.Point(100, 330);
            this.tex簡易ユーザー.MaxLength = 6;
            this.tex簡易ユーザー.Name = "tex簡易ユーザー";
            this.tex簡易ユーザー.Size = new System.Drawing.Size(82, 21);
            this.tex簡易ユーザー.TabIndex = 19;
            // 
            // lab台
            // 
            this.lab台.Location = new System.Drawing.Point(144, 312);
            this.lab台.Name = "lab台";
            this.lab台.Size = new System.Drawing.Size(18, 14);
            this.lab台.TabIndex = 74;
            this.lab台.Text = "台";
            // 
            // numサーマル台数
            // 
            this.numサーマル台数.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.numサーマル台数.Location = new System.Drawing.Point(100, 308);
            this.numサーマル台数.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numサーマル台数.Name = "numサーマル台数";
            this.numサーマル台数.Size = new System.Drawing.Size(42, 21);
            this.numサーマル台数.TabIndex = 17;
            this.numサーマル台数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labサーマル
            // 
            this.labサーマル.Location = new System.Drawing.Point(38, 312);
            this.labサーマル.Name = "labサーマル";
            this.labサーマル.Size = new System.Drawing.Size(62, 14);
            this.labサーマル.TabIndex = 73;
            this.labサーマル.Text = "設置台数";
            // 
            // tex設置先住所２
            // 
            this.tex設置先住所２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex設置先住所２.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex設置先住所２.Location = new System.Drawing.Point(100, 194);
            this.tex設置先住所２.MaxLength = 20;
            this.tex設置先住所２.Name = "tex設置先住所２";
            this.tex設置先住所２.Size = new System.Drawing.Size(326, 23);
            this.tex設置先住所２.TabIndex = 8;
            // 
            // tex設置先住所１
            // 
            this.tex設置先住所１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex設置先住所１.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex設置先住所１.Location = new System.Drawing.Point(100, 170);
            this.tex設置先住所１.MaxLength = 20;
            this.tex設置先住所１.Name = "tex設置先住所１";
            this.tex設置先住所１.Size = new System.Drawing.Size(326, 23);
            this.tex設置先住所１.TabIndex = 7;
            // 
            // lab設置住所
            // 
            this.lab設置住所.Location = new System.Drawing.Point(38, 174);
            this.lab設置住所.Name = "lab設置住所";
            this.lab設置住所.Size = new System.Drawing.Size(62, 14);
            this.lab設置住所.TabIndex = 72;
            this.lab設置住所.Text = "設置住所";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(24, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 14);
            this.label9.TabIndex = 71;
            this.label9.Text = "※";
            // 
            // btn住所検索
            // 
            this.btn住所検索.BackColor = System.Drawing.Color.SteelBlue;
            this.btn住所検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn住所検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn住所検索.ForeColor = System.Drawing.Color.White;
            this.btn住所検索.Location = new System.Drawing.Point(208, 146);
            this.btn住所検索.Name = "btn住所検索";
            this.btn住所検索.Size = new System.Drawing.Size(48, 22);
            this.btn住所検索.TabIndex = 7;
            this.btn住所検索.TabStop = false;
            this.btn住所検索.Text = "検索";
            this.btn住所検索.UseVisualStyleBackColor = false;
            this.btn住所検索.Click += new System.EventHandler(this.btn住所検索_Click);
            // 
            // tex郵便番号２
            // 
            this.tex郵便番号２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex郵便番号２.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex郵便番号２.Location = new System.Drawing.Point(156, 146);
            this.tex郵便番号２.MaxLength = 4;
            this.tex郵便番号２.Name = "tex郵便番号２";
            this.tex郵便番号２.Size = new System.Drawing.Size(48, 23);
            this.tex郵便番号２.TabIndex = 6;
            this.tex郵便番号２.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex郵便番号２_KeyDown);
            this.tex郵便番号２.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex郵便番号２_KeyPress);
            // 
            // tex郵便番号１
            // 
            this.tex郵便番号１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex郵便番号１.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex郵便番号１.Location = new System.Drawing.Point(100, 146);
            this.tex郵便番号１.MaxLength = 3;
            this.tex郵便番号１.Name = "tex郵便番号１";
            this.tex郵便番号１.Size = new System.Drawing.Size(42, 23);
            this.tex郵便番号１.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(140, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 14);
            this.label10.TabIndex = 70;
            this.label10.Text = "－";
            // 
            // lab郵便番号
            // 
            this.lab郵便番号.Location = new System.Drawing.Point(38, 150);
            this.lab郵便番号.Name = "lab郵便番号";
            this.lab郵便番号.Size = new System.Drawing.Size(62, 14);
            this.lab郵便番号.TabIndex = 69;
            this.lab郵便番号.Text = "郵便番号";
            // 
            // num出力順
            // 
            this.num出力順.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.num出力順.Location = new System.Drawing.Point(270, 98);
            this.num出力順.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.num出力順.Name = "num出力順";
            this.num出力順.Size = new System.Drawing.Size(42, 23);
            this.num出力順.TabIndex = 4;
            this.num出力順.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num出力順.Enter += new System.EventHandler(this.num出力順_Enter);
            // 
            // tex管理店所名
            // 
            this.tex管理店所名.BackColor = System.Drawing.Color.Honeydew;
            this.tex管理店所名.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex管理店所名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex管理店所名.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex管理店所名.Location = new System.Drawing.Point(318, 150);
            this.tex管理店所名.MaxLength = 6;
            this.tex管理店所名.Name = "tex管理店所名";
            this.tex管理店所名.ReadOnly = true;
            this.tex管理店所名.Size = new System.Drawing.Size(90, 16);
            this.tex管理店所名.TabIndex = 8;
            this.tex管理店所名.TabStop = false;
            // 
            // btn部門取消
            // 
            this.btn部門取消.BackColor = System.Drawing.Color.Blue;
            this.btn部門取消.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn部門取消.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn部門取消.ForeColor = System.Drawing.Color.White;
            this.btn部門取消.Location = new System.Drawing.Point(370, 330);
            this.btn部門取消.Name = "btn部門取消";
            this.btn部門取消.Size = new System.Drawing.Size(48, 22);
            this.btn部門取消.TabIndex = 25;
            this.btn部門取消.Text = "取消";
            this.btn部門取消.UseVisualStyleBackColor = false;
            this.btn部門取消.Click += new System.EventHandler(this.btn部門取消_Click);
            // 
            // btn部門削除
            // 
            this.btn部門削除.BackColor = System.Drawing.Color.Blue;
            this.btn部門削除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn部門削除.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn部門削除.ForeColor = System.Drawing.Color.White;
            this.btn部門削除.Location = new System.Drawing.Point(316, 330);
            this.btn部門削除.Name = "btn部門削除";
            this.btn部門削除.Size = new System.Drawing.Size(48, 22);
            this.btn部門削除.TabIndex = 21;
            this.btn部門削除.Text = "削除";
            this.btn部門削除.UseVisualStyleBackColor = false;
            this.btn部門削除.Click += new System.EventHandler(this.btn部門削除_Click);
            // 
            // btn部門登録
            // 
            this.btn部門登録.BackColor = System.Drawing.Color.Blue;
            this.btn部門登録.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn部門登録.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn部門登録.ForeColor = System.Drawing.Color.White;
            this.btn部門登録.Location = new System.Drawing.Point(262, 330);
            this.btn部門登録.Name = "btn部門登録";
            this.btn部門登録.Size = new System.Drawing.Size(48, 22);
            this.btn部門登録.TabIndex = 20;
            this.btn部門登録.Text = "登録";
            this.btn部門登録.UseVisualStyleBackColor = false;
            this.btn部門登録.Click += new System.EventHandler(this.btn部門登録_Click);
            // 
            // lab管理店所
            // 
            this.lab管理店所.Location = new System.Drawing.Point(264, 152);
            this.lab管理店所.Name = "lab管理店所";
            this.lab管理店所.Size = new System.Drawing.Size(54, 14);
            this.lab管理店所.TabIndex = 63;
            this.lab管理店所.Text = "管理店所";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Honeydew;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(214, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 14);
            this.label12.TabIndex = 61;
            this.label12.Text = "※";
            // 
            // lab出力順
            // 
            this.lab出力順.Location = new System.Drawing.Point(228, 102);
            this.lab出力順.Name = "lab出力順";
            this.lab出力順.Size = new System.Drawing.Size(42, 14);
            this.lab出力順.TabIndex = 60;
            this.lab出力順.Text = "出力順";
            // 
            // tex部門名
            // 
            this.tex部門名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex部門名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex部門名.Location = new System.Drawing.Point(100, 122);
            this.tex部門名.MaxLength = 20;
            this.tex部門名.Name = "tex部門名";
            this.tex部門名.Size = new System.Drawing.Size(326, 23);
            this.tex部門名.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(24, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 14);
            this.label6.TabIndex = 55;
            this.label6.Text = "※";
            // 
            // lab部門名
            // 
            this.lab部門名.Location = new System.Drawing.Point(38, 126);
            this.lab部門名.Name = "lab部門名";
            this.lab部門名.Size = new System.Drawing.Size(62, 14);
            this.lab部門名.TabIndex = 54;
            this.lab部門名.Text = "セクション名";
            // 
            // tex部門コード
            // 
            this.tex部門コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex部門コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex部門コード.Location = new System.Drawing.Point(100, 98);
            this.tex部門コード.MaxLength = 12;
            this.tex部門コード.Name = "tex部門コード";
            this.tex部門コード.Size = new System.Drawing.Size(110, 23);
            this.tex部門コード.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 14);
            this.label4.TabIndex = 52;
            this.label4.Text = "※";
            // 
            // lab部門コード
            // 
            this.lab部門コード.Location = new System.Drawing.Point(38, 102);
            this.lab部門コード.Name = "lab部門コード";
            this.lab部門コード.Size = new System.Drawing.Size(62, 14);
            this.lab部門コード.TabIndex = 51;
            this.lab部門コード.Text = "コード";
            // 
            // axGT部門
            // 
            this.axGT部門.DataSource = null;
            this.axGT部門.Location = new System.Drawing.Point(28, 4);
            this.axGT部門.Name = "axGT部門";
            this.axGT部門.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT部門.OcxState")));
            this.axGT部門.Size = new System.Drawing.Size(372, 92);
            this.axGT部門.TabIndex = 1;
            this.axGT部門.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT部門_CurPlaceChanged);
            this.axGT部門.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT部門_CelDblClick);
            this.axGT部門.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT部門_KeyDownEvent);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.label8.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 356);
            this.label8.TabIndex = 44;
            this.label8.Text = "セクション情報";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl利用者
            // 
            this.pnl利用者.BackColor = System.Drawing.Color.Honeydew;
            this.pnl利用者.Controls.Add(this.texパスワード更新日);
            this.pnl利用者.Controls.Add(this.labパスワード更新日);
            this.pnl利用者.Controls.Add(this.chbラベル印刷禁止);
            this.pnl利用者.Controls.Add(this.btnパスワードロック);
            this.pnl利用者.Controls.Add(this.btn自動発行);
            this.pnl利用者.Controls.Add(this.btn荷送人検索);
            this.pnl利用者.Controls.Add(this.btn利用者取消);
            this.pnl利用者.Controls.Add(this.btn利用者削除);
            this.pnl利用者.Controls.Add(this.btn利用者登録);
            this.pnl利用者.Controls.Add(this.tex荷送人コード);
            this.pnl利用者.Controls.Add(this.lab荷送人コード);
            this.pnl利用者.Controls.Add(this.tex利用者名);
            this.pnl利用者.Controls.Add(this.label21);
            this.pnl利用者.Controls.Add(this.lab利用者名);
            this.pnl利用者.Controls.Add(this.texパスワード);
            this.pnl利用者.Controls.Add(this.label23);
            this.pnl利用者.Controls.Add(this.labパスワード);
            this.pnl利用者.Controls.Add(this.tex利用者コード);
            this.pnl利用者.Controls.Add(this.label25);
            this.pnl利用者.Controls.Add(this.lab利用者コード);
            this.pnl利用者.Controls.Add(this.axGT利用者);
            this.pnl利用者.Controls.Add(this.label15);
            this.pnl利用者.ForeColor = System.Drawing.Color.LimeGreen;
            this.pnl利用者.Location = new System.Drawing.Point(0, 6);
            this.pnl利用者.Name = "pnl利用者";
            this.pnl利用者.Size = new System.Drawing.Size(352, 356);
            this.pnl利用者.TabIndex = 3;
            // 
            // texパスワード更新日
            // 
            this.texパスワード更新日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texパスワード更新日.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.texパスワード更新日.Location = new System.Drawing.Point(258, 198);
            this.texパスワード更新日.MaxLength = 8;
            this.texパスワード更新日.Name = "texパスワード更新日";
            this.texパスワード更新日.Size = new System.Drawing.Size(72, 23);
            this.texパスワード更新日.TabIndex = 11;
            // 
            // labパスワード更新日
            // 
            this.labパスワード更新日.Location = new System.Drawing.Point(168, 202);
            this.labパスワード更新日.Name = "labパスワード更新日";
            this.labパスワード更新日.Size = new System.Drawing.Size(90, 14);
            this.labパスワード更新日.TabIndex = 83;
            this.labパスワード更新日.Text = "パスワード更新日";
            // 
            // chbラベル印刷禁止
            // 
            this.chbラベル印刷禁止.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbラベル印刷禁止.Location = new System.Drawing.Point(32, 200);
            this.chbラベル印刷禁止.Name = "chbラベル印刷禁止";
            this.chbラベル印刷禁止.Size = new System.Drawing.Size(100, 16);
            this.chbラベル印刷禁止.TabIndex = 10;
            this.chbラベル印刷禁止.Text = "ﾗﾍﾞﾙ印刷禁止";
            this.chbラベル印刷禁止.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnパスワードロック
            // 
            this.btnパスワードロック.BackColor = System.Drawing.Color.SteelBlue;
            this.btnパスワードロック.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnパスワードロック.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnパスワードロック.ForeColor = System.Drawing.Color.White;
            this.btnパスワードロック.Location = new System.Drawing.Point(106, 222);
            this.btnパスワードロック.Name = "btnパスワードロック";
            this.btnパスワードロック.Size = new System.Drawing.Size(104, 22);
            this.btnパスワードロック.TabIndex = 12;
            this.btnパスワードロック.TabStop = false;
            this.btnパスワードロック.Text = "パスワードロック解除";
            this.btnパスワードロック.UseVisualStyleBackColor = false;
            this.btnパスワードロック.Click += new System.EventHandler(this.btnパスワードロック_Click);
            // 
            // btn自動発行
            // 
            this.btn自動発行.BackColor = System.Drawing.Color.SteelBlue;
            this.btn自動発行.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn自動発行.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn自動発行.ForeColor = System.Drawing.Color.White;
            this.btn自動発行.Location = new System.Drawing.Point(280, 146);
            this.btn自動発行.Name = "btn自動発行";
            this.btn自動発行.Size = new System.Drawing.Size(60, 22);
            this.btn自動発行.TabIndex = 5;
            this.btn自動発行.TabStop = false;
            this.btn自動発行.Text = "自動発行";
            this.btn自動発行.UseVisualStyleBackColor = false;
            this.btn自動発行.Click += new System.EventHandler(this.btn自動発行_Click);
            // 
            // btn荷送人検索
            // 
            this.btn荷送人検索.BackColor = System.Drawing.Color.SteelBlue;
            this.btn荷送人検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn荷送人検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn荷送人検索.ForeColor = System.Drawing.Color.White;
            this.btn荷送人検索.Location = new System.Drawing.Point(264, 170);
            this.btn荷送人検索.Name = "btn荷送人検索";
            this.btn荷送人検索.Size = new System.Drawing.Size(48, 22);
            this.btn荷送人検索.TabIndex = 9;
            this.btn荷送人検索.TabStop = false;
            this.btn荷送人検索.Text = "検索";
            this.btn荷送人検索.UseVisualStyleBackColor = false;
            this.btn荷送人検索.Click += new System.EventHandler(this.btn荷送人検索_Click);
            // 
            // btn利用者取消
            // 
            this.btn利用者取消.BackColor = System.Drawing.Color.Blue;
            this.btn利用者取消.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn利用者取消.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn利用者取消.ForeColor = System.Drawing.Color.White;
            this.btn利用者取消.Location = new System.Drawing.Point(290, 328);
            this.btn利用者取消.Name = "btn利用者取消";
            this.btn利用者取消.Size = new System.Drawing.Size(48, 22);
            this.btn利用者取消.TabIndex = 15;
            this.btn利用者取消.Text = "取消";
            this.btn利用者取消.UseVisualStyleBackColor = false;
            this.btn利用者取消.Click += new System.EventHandler(this.btn利用者取消_Click);
            // 
            // btn利用者削除
            // 
            this.btn利用者削除.BackColor = System.Drawing.Color.Blue;
            this.btn利用者削除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn利用者削除.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn利用者削除.ForeColor = System.Drawing.Color.White;
            this.btn利用者削除.Location = new System.Drawing.Point(236, 328);
            this.btn利用者削除.Name = "btn利用者削除";
            this.btn利用者削除.Size = new System.Drawing.Size(48, 22);
            this.btn利用者削除.TabIndex = 14;
            this.btn利用者削除.Text = "削除";
            this.btn利用者削除.UseVisualStyleBackColor = false;
            this.btn利用者削除.Click += new System.EventHandler(this.btn利用者削除_Click);
            // 
            // btn利用者登録
            // 
            this.btn利用者登録.BackColor = System.Drawing.Color.Blue;
            this.btn利用者登録.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn利用者登録.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn利用者登録.ForeColor = System.Drawing.Color.White;
            this.btn利用者登録.Location = new System.Drawing.Point(182, 328);
            this.btn利用者登録.Name = "btn利用者登録";
            this.btn利用者登録.Size = new System.Drawing.Size(48, 22);
            this.btn利用者登録.TabIndex = 13;
            this.btn利用者登録.Text = "登録";
            this.btn利用者登録.UseVisualStyleBackColor = false;
            this.btn利用者登録.Click += new System.EventHandler(this.btn利用者登録_Click);
            // 
            // tex荷送人コード
            // 
            this.tex荷送人コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex荷送人コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex荷送人コード.Location = new System.Drawing.Point(106, 170);
            this.tex荷送人コード.MaxLength = 12;
            this.tex荷送人コード.Name = "tex荷送人コード";
            this.tex荷送人コード.Size = new System.Drawing.Size(154, 23);
            this.tex荷送人コード.TabIndex = 8;
            this.tex荷送人コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex荷送人コード_KeyDown);
            this.tex荷送人コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex荷送人コード_KeyPress);
            // 
            // lab荷送人コード
            // 
            this.lab荷送人コード.Location = new System.Drawing.Point(36, 176);
            this.lab荷送人コード.Name = "lab荷送人コード";
            this.lab荷送人コード.Size = new System.Drawing.Size(70, 14);
            this.lab荷送人コード.TabIndex = 82;
            this.lab荷送人コード.Text = "荷送人コード";
            // 
            // tex利用者名
            // 
            this.tex利用者名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex利用者名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex利用者名.Location = new System.Drawing.Point(106, 122);
            this.tex利用者名.MaxLength = 20;
            this.tex利用者名.Name = "tex利用者名";
            this.tex利用者名.Size = new System.Drawing.Size(244, 23);
            this.tex利用者名.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Honeydew;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(24, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 14);
            this.label21.TabIndex = 77;
            this.label21.Text = "※";
            // 
            // lab利用者名
            // 
            this.lab利用者名.Location = new System.Drawing.Point(38, 128);
            this.lab利用者名.Name = "lab利用者名";
            this.lab利用者名.Size = new System.Drawing.Size(70, 14);
            this.lab利用者名.TabIndex = 76;
            this.lab利用者名.Text = "ユーザー名";
            // 
            // texパスワード
            // 
            this.texパスワード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texパスワード.Location = new System.Drawing.Point(106, 146);
            this.texパスワード.MaxLength = 40;
            this.texパスワード.Name = "texパスワード";
            this.texパスワード.Size = new System.Drawing.Size(170, 23);
            this.texパスワード.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Honeydew;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(24, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 14);
            this.label23.TabIndex = 74;
            this.label23.Text = "※";
            // 
            // labパスワード
            // 
            this.labパスワード.Location = new System.Drawing.Point(38, 152);
            this.labパスワード.Name = "labパスワード";
            this.labパスワード.Size = new System.Drawing.Size(70, 14);
            this.labパスワード.TabIndex = 73;
            this.labパスワード.Text = "パスワード";
            // 
            // tex利用者コード
            // 
            this.tex利用者コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex利用者コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex利用者コード.Location = new System.Drawing.Point(106, 98);
            this.tex利用者コード.MaxLength = 6;
            this.tex利用者コード.Name = "tex利用者コード";
            this.tex利用者コード.Size = new System.Drawing.Size(82, 23);
            this.tex利用者コード.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Honeydew;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(24, 104);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(16, 14);
            this.label25.TabIndex = 71;
            this.label25.Text = "※";
            // 
            // lab利用者コード
            // 
            this.lab利用者コード.Location = new System.Drawing.Point(38, 104);
            this.lab利用者コード.Name = "lab利用者コード";
            this.lab利用者コード.Size = new System.Drawing.Size(70, 14);
            this.lab利用者コード.TabIndex = 70;
            this.lab利用者コード.Text = "コード";
            // 
            // axGT利用者
            // 
            this.axGT利用者.DataSource = null;
            this.axGT利用者.Location = new System.Drawing.Point(24, 4);
            this.axGT利用者.Name = "axGT利用者";
            this.axGT利用者.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT利用者.OcxState")));
            this.axGT利用者.Size = new System.Drawing.Size(326, 92);
            this.axGT利用者.TabIndex = 0;
            this.axGT利用者.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT利用者_CurPlaceChanged);
            this.axGT利用者.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT利用者_CelDblClick);
            this.axGT利用者.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT利用者_KeyDownEvent);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.label15.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 356);
            this.label15.TabIndex = 44;
            this.label15.Text = "ユ｜ザ｜情報";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(26, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnl会員);
            this.groupBox2.Location = new System.Drawing.Point(4, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnl部門);
            this.groupBox3.Location = new System.Drawing.Point(4, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 364);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnl利用者);
            this.groupBox4.Location = new System.Drawing.Point(438, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 364);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(654, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 31;
            this.label5.Text = "印がある項目は　　必須入力項目です。";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(640, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 14);
            this.label11.TabIndex = 30;
            this.label11.Text = "※";
            // 
            // 会員マスタ
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(794, 580);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(802, 607);
            this.Name = "会員マスタ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 お客様情報メンテナンス";
            this.Closed += new System.EventHandler(this.会員マスタ_Closed);
            this.Load += new System.EventHandler(this.会員マスタ_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
            this.pnl会員.ResumeLayout(false);
            this.pnl会員.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnl部門.ResumeLayout(false);
            this.pnl部門.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numサーマル台数)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num出力順)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGT部門)).EndInit();
            this.pnl利用者.ResumeLayout(false);
            this.pnl利用者.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT利用者)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void 会員マスタ_Load(object sender, System.EventArgs e)
		{
			s部門コード = "";
			tex認証会員名.Text = gs会員名;
			tex認証利用者名.Text = gs利用者名;
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
			cb運用中のお客様のみ.Checked = true;
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END

			初期モード();

			// 日時の初期設定
			lab日時.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;

			// 部門リストの初期設定
			axGT部門.Cols = 4;
			axGT部門.Rows = 4;
			axGT部門.ColSep = "|";
			axGT部門.CaretRow = 1;
			axGT部門.NoBeep = true;

			axGT部門.set_RowsText(0, "|コード|セクション名|出力順|郵便番号|");
//			axGT部門.ColsWidth = "0|7|20|5|7|";
			axGT部門.ColsWidth = "0|7|20|13.6|13.6|";
			axGT部門.ColsAlignHorz = "1|1|0|2|1|";
            
//			axGT部門.set_CelForeColor(axGT部門.CaretRow,0,111111);
			axGT部門.set_CelForeColor(axGT部門.CaretRow,0,0x98FB98);  //BGR
			axGT部門.set_CelBackColor(axGT部門.CaretRow,0,0x006000);

			axGT部門.Clear();
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT部門.CaretCol = 1;
			axGT部門_CurPlaceChanged(null,null);
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END

			// 利用者リストの初期設定
			axGT利用者.Cols = 4;
			axGT利用者.Rows = 4;
			axGT利用者.ColSep = "|";
			axGT利用者.CaretRow = 1;
			axGT利用者.NoBeep = true;

			axGT利用者.set_RowsText(0, "|コード|ユーザー名|セクション|荷送人コード|");
//			axGT利用者.ColsWidth = "0|5|18|5|7|";
			axGT利用者.ColsWidth = "0|5|18.6|11.8|11.8|";
			axGT利用者.ColsAlignHorz = "1|1|0|1|1|";
            
//			axGT利用者.set_CelForeColor(axGT利用者.CaretRow,0,111111);
			axGT利用者.set_CelForeColor(axGT利用者.CaretRow,0,0x98FB98);  //BGR
			axGT利用者.set_CelBackColor(axGT利用者.CaretRow,0,0x006000);

			axGT利用者.Clear();
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT利用者.CaretCol = 1;
			axGT利用者_CurPlaceChanged(null,null);
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
		}

		private void 初期モード()
		{
			会員登録モード();
			部門登録モード();
			利用者登録モード();
			pnl会員.Enabled = false;
			pnl部門.Enabled = false;
			pnl利用者.Enabled = false;
			chb使用終了日.Checked = false;
//			dtp使用終了日.Enabled = false;
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
			cb才数重量入力取込.Checked = false;
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
// MOD 2016.04.13 BEVAS）松本 社内伝票機能追加対応 START
			btn社内伝会員発店登録.Enabled = false;
// MOD 2016.04.13 BEVAS）松本 社内伝票機能追加対応 END
			lab終了日.Visible = true;
			tex会員コード.Focus();
		}
		private void 会員登録モード()
		{
			btn会員登録.Text = "登録";

			tex会員名.Text = "";
			//dtp使用開始日
			cmb管理者区分.SelectedIndex = 0;
// ADD 2007.02.15 東都）高木 営業所会員対応 START
			cmb管理者区分.Text
				= (string)cmb管理者区分.Items[cmb管理者区分.SelectedIndex];
// ADD 2007.02.15 東都）高木 営業所会員対応 END
			
			s会員更新日時 = "00000000000000";
// MOD 2016.04.13 BEVAS）松本 社内伝票機能追加対応 START
			btn社内伝会員発店登録.Enabled = false;
// MOD 2016.04.13 BEVAS）松本 社内伝票機能追加対応 END
		}

		private void 会員更新モード()
		{
			btn会員登録.Text = "更新";
// MOD 2016.04.13 BEVAS）松本 社内伝票機能追加対応 START
			//社内伝会員の場合、発店情報登録画面を起動するボタンを活性化する
			if(tex会員コード.Text.Trim().Substring(0,2) == "FK")
			{
				btn社内伝会員発店登録.Enabled = true;
			}
			else
			{
				btn社内伝会員発店登録.Enabled = false;
			}
// MOD 2016.04.13 BEVAS）松本 社内伝票機能追加対応 END
		}

		private void 部門登録モード()
		{
			tex部門コード.Enabled = true;
			btn部門登録.Text = "登録";
			btn部門削除.Enabled = false;

			tex部門コード.Text = "";
			tex部門名.Text = "";
			num出力順.Text = "0";
			tex郵便番号１.Text = "";
			tex郵便番号２.Text = "";
			tex管理店所名.Text = "";
			tex設置先住所１.Text = "";
			tex設置先住所２.Text = "";
			numサーマル台数.Text = "0";
// ADD 2009.03.03 東都）高木 サーマルシリアル番号の追加 START
			texシリアル番号１.Text = "";
			cmbシリアル番号１.SelectedIndex = 0;
			texシリアル番号２.Text = "";
			cmbシリアル番号２.SelectedIndex = 0;
			texシリアル番号３.Text = "";
			cmbシリアル番号３.SelectedIndex = 0;
			texシリアル番号４.Text = "";
			cmbシリアル番号４.SelectedIndex = 0;
			tex設置場所使用料.Text = "0";
// ADD 2009.03.03 東都）高木 サーマルシリアル番号の追加 END
// ADD 2005.08.08 東都）小童谷 簡易ユーザー初期化 START
			tex簡易ユーザー.Text = "";
// ADD 2005.08.08 東都）小童谷 簡易ユーザー初期化 END

			s部門更新日時 = "00000000000000";

// ADD 2005.06.13 東都）小童谷 ユーザー情報 START
			利用者登録モード();
			axGT利用者.Clear();
			axGT利用者.CaretRow = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT利用者.CaretCol = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
			axGT利用者_CurPlaceChanged(null,null);
			pnl利用者.Enabled = false;
// ADD 2005.06.13 東都）小童谷 ユーザー情報 END

		}

		private void 部門更新モード()
		{
			tex部門コード.Enabled = false;
			btn部門登録.Text = "更新";
			btn部門削除.Enabled = true;

// ADD 2005.06.13 東都）小童谷 ユーザー情報 START
			利用者登録モード();
			axGT利用者.Clear();
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT利用者.CaretRow = 1;
			axGT利用者.CaretCol = 1;
			axGT利用者_CurPlaceChanged(null,null);
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
			pnl利用者.Enabled = true;
// ADD 2005.06.13 東都）小童谷 ユーザー情報 END

		}

		private void 利用者登録モード()
		{
			tex利用者コード.Enabled = true;
			btn利用者登録.Text = "登録";
			btn利用者削除.Enabled = false;

			tex利用者コード.Text = "";
			tex利用者名.Text = "";
			texパスワード.Text = "";
// DEL 2005.06.08 東都）小童谷 再入力削除 START
//			texパスワード再入力.Text = "";
// DEL 2005.06.08 東都）小童谷 再入力削除 END
//			tex利用者部門コード.Text = "";
//			tex利用者部門名.Text = "";
			tex荷送人コード.Text = "";
			btnパスワードロック.Enabled = false;
// ADD 2008.05.29 東都）高木 パスワード更新年月日を表示 START
			texパスワード更新日.Text = "";
// ADD 2008.05.29 東都）高木 パスワード更新年月日を表示 START
// ADD 2005.07.21 東都）高木 店所ユーザ対応 START
			chbラベル印刷禁止.Checked = false;
// ADD 2005.07.21 東都）高木 店所ユーザ対応 END
			
			s利用者更新日時 = "00000000000000";
			s認証エラー回数 = 0;
		}

		private void 利用者更新モード()
		{
			tex利用者コード.Enabled = false;
			btn利用者登録.Text = "更新";
			btn利用者削除.Enabled = true;
			btnパスワードロック.Enabled = false;
		}

		private void tex会員コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn会員検索.Focus();
				会員情報一覧();
				e.Handled = true;
			}
		}

		private void btn会員検索_Click(object sender, System.EventArgs e)
		{
			会員情報一覧();
		}

		private void btn会員実行_Click(object sender, System.EventArgs e)
		{
			会員情報検索();
		}

		private void 会員情報一覧()
		{
			tex会員コード.Text = tex会員コード.Text.Trim();
// MOD 2008.05.07 東都）高木 メッセージ変更[会員]→[お客様] START
//			if(!半角チェック(tex会員コード, "会員コード")) return;
			if(!半角チェック(tex会員コード, "お客様コード")) return;
// MOD 2008.05.07 東都）高木 メッセージ変更[会員]→[お客様] END

			// 検索画面を右側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			会員検索 画面 = new 会員検索();
//			画面.Left = this.Left + 404;
//			画面.Top = this.Top;

			// コードの初期表示
//			画面.s会員コード = tex会員コード.Text.Trim();
//			画面.s会員名 = "";
//			画面.ShowDialog();
			if (g会員検索 == null)	 g会員検索 = new 会員検索();
			g会員検索.Left = this.Left + 404;
			g会員検索.Top = this.Top;

			// コードの初期表示
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし START
//			g会員検索.s会員コード = tex会員コード.Text.Trim();
			g会員検索.s会員コード = "";
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし END
			g会員検索.s会員名 = "";
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
			g会員検索.b運用中のお客様のみ = cb運用中のお客様のみ.Checked;
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END
			g会員検索.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if(画面.s会員コード.Trim().Length > 0)
			if(g会員検索.s会員コード.Trim().Length > 0)
			{
//				tex会員コード.Text = 画面.s会員コード.Trim();
				tex会員コード.Text = g会員検索.s会員コード.Trim();
				会員情報検索();
			}
			else
			{
				tex会員コード.Focus();
			}
// MOD 2005.05.25 東都）小童谷 画面高速化 END
		}

		private void 会員情報検索()
		{
			texメッセージ.Text = "";
			tex会員コード.Text = tex会員コード.Text.Trim();
// MOD 2008.05.07 東都）高木 メッセージ変更[会員]→[お客様] START
//			if(!必須チェック(tex会員コード, "会員コード")) return;
//			if(!半角チェック(tex会員コード, "会員コード")) return;
			if(!必須チェック(tex会員コード, "お客様コード")) return;
			if(!半角チェック(tex会員コード, "お客様コード")) return;
// MOD 2008.05.07 東都）高木 メッセージ変更[会員]→[お客様] END

			s会員コード = tex会員コード.Text.Trim();
			axGT部門.Clear();
			axGT利用者.Clear();
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT部門.CaretRow = 1;
			axGT部門.CaretCol = 1;
			axGT部門_CurPlaceChanged(null,null);
			axGT利用者.CaretRow = 1;
			axGT利用者.CaretCol = 1;
			axGT利用者_CurPlaceChanged(null,null);
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END

			pnl会員.Enabled = true;
			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			axGT部門.CaretRow   = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT部門.CaretCol = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
			axGT部門_CurPlaceChanged(null,null);
			axGT利用者.CaretRow = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT利用者.CaretCol = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
			axGT利用者_CurPlaceChanged(null,null);

			try
			{
				string[] sKey  = new string[1];
				sKey[0] = s会員コード;
				string[] sList = sv_maintenance.Sel_Member(gsaユーザ, sKey);

				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex会員コード.Text = sList[1].Trim();
					tex会員名.Text     = sList[2].Trim();
					if (sList[3].Trim().Equals("00000000"))
						dtp使用開始日.Value = System.DateTime.Now;
					else
//
//						dtp使用開始日.Value = System.DateTime.Parse(sList[3].Substring(0, 4)
//							+ "/" + sList[3].Substring(4, 2)
//							+ "/" + sList[3].Substring(6, 2));
						dtp使用開始日.Value = new DateTime(int.Parse(sList[3].Substring(0, 4)),
															int.Parse(sList[3].Substring(4, 2)),
															int.Parse(sList[3].Substring(6, 2)));
//
					if (sList[4].Trim().Equals("9")){
// MOD 2007.02.06 東都）高木 営業所会員対応 START
//						cmb管理者区分.SelectedIndex = 2;
						cmb管理者区分.SelectedIndex = 0;
						cmb管理者区分.Text = "メンテナンス会員";
// MOD 2007.02.06 東都）高木 営業所会員対応 END
					}else{
						cmb管理者区分.SelectedIndex = int.Parse(sList[4]);
// ADD 2007.02.15 東都）高木 営業所会員対応 START
						cmb管理者区分.Text
							= (string)cmb管理者区分.Items[cmb管理者区分.SelectedIndex];
// ADD 2007.02.15 東都）高木 営業所会員対応 END
					}
					if (sList[5].Trim().Equals("99999999"))
						chb使用終了日.Checked = false;
					else
					{
						chb使用終了日.Checked = true;
//						dtp使用終了日.Value = System.DateTime.Parse(sList[5].Substring(0, 4)
//							+ "/" + sList[5].Substring(4, 2)
//							+ "/" + sList[5].Substring(6, 2));
						dtp使用終了日.Value = new DateTime(int.Parse(sList[5].Substring(0, 4)),
															int.Parse(sList[5].Substring(4, 2)),
															int.Parse(sList[5].Substring(6, 2)));
					}
					s会員更新日時 = sList[6].Trim();
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
					if(sList.Length > 8){
						if(sList[8] == "1"){
							cb才数重量入力取込.Checked = true;
						}else{
							cb才数重量入力取込.Checked = false;
						}
					}
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END

					部門情報検索();
//					利用者情報検索();

					会員更新モード();
					pnl部門.Enabled = true;
					pnl利用者.Enabled = true;

					利用者登録モード();
					部門登録モード();
					tex会員名.Focus();
				}
				else if (sList[0].Equals("該当データがありません"))
				{
					texメッセージ.Text = "新規登録";
					会員登録モード();
					pnl部門.Enabled = false;
					pnl利用者.Enabled = false;
// MOD 2016.04.13 BEVAS）松本 社内伝票機能追加対応 START
					btn社内伝会員発店登録.Enabled = false;
// MOD 2016.04.13 BEVAS）松本 社内伝票機能追加対応 END

					利用者登録モード();
					部門登録モード();
					tex会員名.Focus();
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					会員登録モード();
					tex会員コード.Focus();
					pnl会員.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn会員登録_Click(object sender, System.EventArgs e)
		{
			tex会員名.Text = tex会員名.Text.Trim();
// MOD 2008.05.07 東都）高木 メッセージ変更[会員]→[お客様] START
//			if (!必須チェック(tex会員名, "会員名")) return;
//			if (!全角チェック(tex会員名, "会員名")) return;
			if (!必須チェック(tex会員名, "お客様名")) return;
			if (!全角チェック(tex会員名, "お客様名")) return;
// MOD 2008.05.07 東都）高木 メッセージ変更[会員]→[お客様] END
// ADD 2007.02.08 東都）高木 営業所会員対応 START
			if(cmb管理者区分.SelectedIndex < 0){
				MessageBox.Show("管理者区分が違います","入力チェック",MessageBoxButtons.OK);
				return;
			}
// ADD 2007.02.08 東都）高木 営業所会員対応 END
// ADD 2007.02.15 東都）高木 営業所会員対応 START
			cmb管理者区分.Text
				= (string)cmb管理者区分.Items[cmb管理者区分.SelectedIndex];
// ADD 2007.02.15 東都）高木 営業所会員対応 END
// ADD 2007.02.08 東都）高木 営業所会員対応 START
			if(cmb管理者区分.SelectedIndex < 0){
				MessageBox.Show("管理者区分が違います","入力チェック",MessageBoxButtons.OK);
				return;
			}
// ADD 2007.02.08 東都）高木 営業所会員対応 END
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
			if(cmb管理者区分.SelectedIndex==0 || cmb管理者区分.SelectedIndex==2 )
			{
				if (s会員コード.Substring(0,1)=="J")
				{
					MessageBox.Show("管理者区分が違います","入力チェック",MessageBoxButtons.OK);
					return;
				}
			}else if(cmb管理者区分.SelectedIndex==3 || cmb管理者区分.SelectedIndex==4)
			{
				if (s会員コード.Substring(0,1)!="J")
				{
					MessageBox.Show("管理者区分が違います","入力チェック",MessageBoxButtons.OK);
					return;
				}
			}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END


			texメッセージ.Text = btn会員登録.Text + "中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
//				string[] sKey  = new string[7];
				string[] sKey  = new string[8];
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
				sKey[0] = s会員コード;
				sKey[1] = tex会員名.Text;
				sKey[2] = dtp使用開始日.Value.Year.ToString() + dtp使用開始日.Value.Month.ToString().PadLeft(2, '0') + dtp使用開始日.Value.Day.ToString().PadLeft(2, '0');
				if (chb使用終了日.Checked)
					sKey[3] = dtp使用終了日.Value.Year.ToString() + dtp使用終了日.Value.Month.ToString().PadLeft(2, '0') + dtp使用終了日.Value.Day.ToString().PadLeft(2, '0');
				else
					sKey[3] = "99999999";
// MOD 2007.02.06 東都）高木 営業所会員対応 START
//				if (cmb管理者区分.SelectedIndex == 2)
//					sKey[4] = "9";
//				else
//					sKey[4] = cmb管理者区分.SelectedIndex.ToString();
				sKey[4] = cmb管理者区分.SelectedIndex.ToString();
// MOD 2007.02.06 東都）高木 営業所会員対応 START
				sKey[5] = s会員更新日時;
				sKey[6] = gs利用者コード;
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
				if(cb才数重量入力取込.Checked){
					sKey[7] = "1";
				}else{
					sKey[7] = "0";
				}
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
				if (btn会員登録.Text.Equals("登録"))
				{
					string[] sList = sv_maintenance.Ins_Member(gsaユーザ, sKey);
					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						//会員の追加
						s会員更新日時 = sList[1].Trim();
						会員更新モード();
						pnl部門.Enabled = true;
						pnl利用者.Enabled = true;
					}
					else
					{
						ビープ音();
					}
				}
				else
				{
					string[] sList = sv_maintenance.Upd_Member(gsaユーザ, sKey);
					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						texメッセージ.Text = "";
						//会員の更新
						s会員更新日時 = sList[1].Trim();
						会員更新モード();
						pnl部門.Enabled = true;
						pnl利用者.Enabled = true;
					}
					else
					{
						ビープ音();
					}
				}
				tex会員名.Focus();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

// ADD 2005.08.08 東都）小童谷 会員削除 START
		private void btn会員削除_Click(object sender, System.EventArgs e)
		{
// MOD 2009.04.28 東都）高木 削除確認メッセージの追加 START
			tex会員コード.Text = tex会員コード.Text.Trim();

			// 最終確認
			if (MessageBox.Show("削除してもよろしいですか？", "確認"
					, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No){
				return;
			}
// MOD 2009.04.28 東都）高木 削除確認メッセージの追加 END

			texメッセージ.Text = "削除中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[4];
				sKey[0] = s会員コード;
				sKey[1] = s会員更新日時;
				sKey[2] = gs利用者コード;

				string[] sList = sv_maintenance.Del_Member(gsaユーザ, sKey);
				texメッセージ.Text = sList[0];
				if (sList[0].Equals("正常終了"))
				{
					tex会員コード.Text = "";
					dtp使用開始日.Value = System.DateTime.Now;
					dtp使用終了日.Value = System.DateTime.Now;
					axGT部門.Clear();
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
					axGT部門.CaretRow = 1;
					axGT部門.CaretCol = 1;
					axGT部門_CurPlaceChanged(null,null);
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
					初期モード();
				}
				else
				{
					ビープ音();
				}
				tex会員コード.Focus();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
// ADD 2005.08.08 東都）小童谷 会員削除 END

		private void axGT部門_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			部門検索();
		}
		private void axGT部門_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				部門検索();
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT部門, true, true, true, true);
			}
		}
		
		private void btn部門登録_Click(object sender, System.EventArgs e)
		{
			tex部門コード.Text = tex部門コード.Text.Trim();
			if (!必須チェック(tex部門コード, "セクション")) return;
			if (!半角チェック(tex部門コード, "セクション")) return;

			tex部門名.Text = tex部門名.Text.Trim();
			if (!必須チェック(tex部門名, "セクション名")) return;
			if (!全角チェック(tex部門名, "セクション名")) return;

			if (!範囲チェック(num出力順, "出力順")) return;
			if (!範囲チェック(numサーマル台数, "サーマル台数")) return;
			
			//郵便番号チェック
			tex郵便番号１.Text = tex郵便番号１.Text.Trim();
			tex郵便番号２.Text = tex郵便番号２.Text.Trim();
			if (!必須チェック(tex郵便番号１, "郵便番号１")) return;
			if (!半角チェック(tex郵便番号１, "郵便番号１")) return;
			if (!必須チェック(tex郵便番号２, "郵便番号２")) return;
			if (!半角チェック(tex郵便番号２, "郵便番号２")) return;
			if (!郵便番号検索())
			{
				MessageBox.Show("郵便番号(" + tex郵便番号１.Text + tex郵便番号２.Text + ")が存在しません" ,"入力チェック",MessageBoxButtons.OK);
				tex郵便番号１.Focus();
				return;
			}

// ADD 2008.05.07 東都）高木 設置場所住所の全角チェックの追加 START
			//設置先住所チェック
			tex設置先住所１.Text = tex設置先住所１.Text.Trim();
			tex設置先住所２.Text = tex設置先住所２.Text.Trim();
			if(!全角チェック(tex設置先住所１, "設置先住所１")) return;
			if(!全角チェック(tex設置先住所２, "設置先住所２")) return;
// ADD 2008.05.07 東都）高木 設置場所住所の全角チェックの追加 END
			if (tex設置先住所１.Text.Length == 0) tex設置先住所１.Text = " ";
			if (tex設置先住所２.Text.Length == 0) tex設置先住所２.Text = " ";
			
// ADD 2009.03.03 東都）高木 サーマルシリアル番号の追加 START
			if(!範囲チェック(numサーマル台数, "設置台数")) return;
			texシリアル番号１.Text = texシリアル番号１.Text.TrimEnd();
			texシリアル番号２.Text = texシリアル番号２.Text.TrimEnd();
			texシリアル番号３.Text = texシリアル番号３.Text.TrimEnd();
			texシリアル番号４.Text = texシリアル番号４.Text.TrimEnd();
			tex設置場所使用料.Text = tex設置場所使用料.Text.Trim();
			if(tex設置場所使用料.Text.Length == 0) tex設置場所使用料.Text = "0";
			if(!範囲チェック(tex設置場所使用料, "使用料", 0, 99999)) return;
// ADD 2009.03.03 東都）高木 サーマルシリアル番号の追加 END

// ADD 2005.06.09 東都）小童谷 簡易ユーザー登録 START
			tex簡易ユーザー.Text = tex簡易ユーザー.Text.Trim();
			if (!半角チェック(tex簡易ユーザー, "ユーザー")) return;
			if(tex簡易ユーザー.Text.Trim().Length != 0)
				if(!ユーザー存在チェック()) return;
// ADD 2005.06.09 東都）小童谷 簡易ユーザー登録 END

// MOD 2016.04.13 BEVAS）松本 社内伝票対応 START
			if(tex会員コード.Text.Trim().Substring(0,2) == "FK")
			{
				/** 社内伝票会員の場合、セクション登録時には以下の条件を全て満たしていること */
				//(1) 管理者権限以外では、社内伝票会員のセクション登録を許可しない
				if(gs管理者区分 != "1")
				{
					MessageBox.Show("管理者以外の権限では、社内伝票会員のセクションは登録できません",
						"入力チェック",MessageBoxButtons.OK);
					tex部門コード.Focus();
					return;
				}
				//(2) 社内伝会員の扱店登録がなければエラー（扱店の登録漏れを防ぐ為）
				string[] sKey2  = new string[1];
				sKey2[0] = tex会員コード.Text.Trim();
				string[] sRet2 = sv_maintenance.Sel_HouseSlipMember(gsaユーザ, sKey2);
				if(!sRet2[0].Equals("正常終了"))
				{
					MessageBox.Show("社内伝票会員の場合、セクション情報を登録する前に社内伝票会員の扱店登録を行って下さい",
						"入力チェック",MessageBoxButtons.OK);
					tex部門コード.Focus();
					return;
				}
				//(3) セクションの郵便番号は社内伝票専用郵便番号(XXX-0044)でなければエラー
				string s設置先郵便番号 = tex郵便番号１.Text.Trim() + tex郵便番号２.Text.Trim();
				if(!s設置先郵便番号.Equals(s社内伝票用郵便番号))
				{
					MessageBox.Show("社内伝票会員の場合、設置先の郵便番号は「" + s社内伝票用郵便番号表示用 + "」を使用して下さい",
						"入力チェック",MessageBoxButtons.OK);
					tex郵便番号１.Focus();
					return;
				}
			}
// MOD 2016.04.13 BEVAS）松本 社内伝票対応 END

			texメッセージ.Text = btn部門登録.Text + "中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
// MOD 2009.03.03 東都）高木 サーマルシリアル番号の追加 START
//				string[] sKey  = new string[10];
				string[] sKey  = new string[19];
// MOD 2009.03.03 東都）高木 サーマルシリアル番号の追加 END
				sKey[0] = s会員コード;
				sKey[1] = tex部門コード.Text;
				sKey[2] = tex部門名.Text;
				sKey[3] = num出力順.Text;
				sKey[4] = tex郵便番号１.Text + tex郵便番号２.Text;
				sKey[5] = tex設置先住所１.Text;
				sKey[6] = tex設置先住所２.Text;
				sKey[7] = s部門更新日時;
				sKey[8] = gs利用者コード;
				sKey[9] = numサーマル台数.Text;
// ADD 2009.03.03 東都）高木 サーマルシリアル番号の追加 START
				sKey[10] = texシリアル番号１.Text;
				sKey[11] = cmbシリアル番号１.SelectedIndex.ToString();
				sKey[12] = texシリアル番号２.Text;
				sKey[13] = cmbシリアル番号２.SelectedIndex.ToString();
				sKey[14] = texシリアル番号３.Text;
				sKey[15] = cmbシリアル番号３.SelectedIndex.ToString();
				sKey[16] = texシリアル番号４.Text;
				sKey[17] = cmbシリアル番号４.SelectedIndex.ToString();
				sKey[18] = tex設置場所使用料.Text.Replace(",","").Trim();

				for(int iCnt = 0; iCnt < sKey.Length ; iCnt++)
					if(sKey[iCnt].Length ==0) sKey[iCnt] = " ";
// ADD 2009.03.03 東都）高木 サーマルシリアル番号の追加 END

				if (btn部門登録.Text.Equals("登録"))
				{
					string[] sList = sv_maintenance.Ins_Section(gsaユーザ, sKey);
					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
// ADD 2007.01.27 東都）高木 会員申込への追加 START
						s簡易ユーザー = "";
// ADD 2007.01.27 東都）高木 会員申込への追加 END
// ADD 2005.06.09 東都）小童谷 簡易ユーザー登録 START
						if(tex簡易ユーザー.Text.Trim().Length != 0)
							簡易ユーザー登録();
// ADD 2005.06.09 東都）小童谷 簡易ユーザー登録 END
// ADD 2007.01.27 東都）高木 会員申込への追加 START
						会員申込情報作成();
// ADD 2007.01.27 東都）高木 会員申込への追加 END
						//部門の追加
						部門登録モード();
						部門情報検索();
					}
					else
					{
						ビープ音();
					}
				}
				else
				{
					string[] sList = sv_maintenance.Upd_Section(gsaユーザ, sKey);
					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
// ADD 2005.06.09 東都）小童谷 簡易ユーザー登録 START
						if(tex簡易ユーザー.Text.Trim().Length != 0)
							簡易ユーザー登録();
// ADD 2005.06.09 東都）小童谷 簡易ユーザー登録 END
						//部門の更新
						部門登録モード();
						部門情報検索();
					}
					else
					{
						ビープ音();
					}
				}
				tex部門コード.Focus();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

// ADD 2007.01.27 東都）高木 会員申込への追加 START
		private bool 会員申込情報作成()
		{
			bool bRet = true;

			try{
				string[] sData  = new string[44];
				//受付ＮＯ情報
				sData[0] = " ";		//受付ＮＯ
				sData[1] = s管理店所コード;

				//申込者情報
				sData[2] = " ";		//申込者カナ
				sData[3] = tex会員名.Text;
									//申込者名（※）
				sData[4] = " ";		//申込者郵便
				sData[5] = " ";		//申込者県ＣＤ
				sData[6] = " ";		//申込者住所１
				sData[7] = " ";		//申込者住所２
				// 利用者申込画面では必須だが、利用者登録画面には該当する
				// 入力項目がない為、空白
				sData[8] = " ";		//申込者電話１（※）
				sData[9] = " ";		//申込者電話２（※）
				sData[10] = " ";	//申込者電話３（※）
				sData[11] = " ";	//申込者電話（※）
				sData[12] = " ";	//申込者ＦＡＸ１（未使用）
				sData[13] = " ";	//申込者ＦＡＸ２（未使用）
				sData[14] = " ";	//申込者ＦＡＸ３（未使用）

				sData[15] = " ";	//設置場所情報

				sData[16] = " ";	//設置場所カナ
				sData[17] = tex部門名.Text;
									//設置場所名（※）
				sData[18] = tex郵便番号１.Text + tex郵便番号２.Text;
									//設置場所郵便番号（※）

				//住所１の文字長さが全角１６文字以上の場合
				県編集(tex設置先住所１.Text);
				sData[19] = s設置場所県コード;	//設置場所県コード
				if(s設置場所住所１.Length > 16){
					//注意　住所がカットされる
					sData[20] = s設置場所住所１.Substring(0,16);
				}else{
					sData[20] = s設置場所住所１;
				}
				sData[21] = tex設置先住所２.Text;
				// 利用者申込画面では必須だが、利用者登録画面には該当する
				// 入力項目がない為、空白
				sData[22] = " ";	//設置場所電話１（※）
				sData[23] = " ";	//設置場所電話２（※）
				sData[24] = " ";	//設置場所電話３（※）
				sData[25] = " ";	//設置場所ＦＡＸ１（未使用）
				sData[26] = " ";	//設置場所ＦＡＸ２（未使用）
				sData[27] = " ";	//設置場所ＦＡＸ３（未使用）
				// 利用者申込画面では必須だが、利用者登録画面には該当する
				// 入力項目がない為、空白
				sData[28] = " ";	//設置場所担当者名（※）
				sData[29] = " ";	//設置場所役職名（未使用）
				sData[30] = "0";	//設置場所使用料

				//システム情報
				sData[31] = s会員コード;	//お客様コード
				sData[32] = dtp使用開始日.Value.Year.ToString() 
								+ dtp使用開始日.Value.Month.ToString().PadLeft(2, '0') 
								+ dtp使用開始日.Value.Day.ToString().PadLeft(2, '0');
				sData[33] = tex部門コード.Text;
				sData[34] = tex部門名.Text;
				sData[35] = numサーマル台数.Value.ToString();

				if(s簡易ユーザー.Length > 0){
					sData[36] = s簡易ユーザー;			//ユーザーコード
					sData[37] = tex部門名.Text;			//ユーザー名
					sData[38] = sパスワード;
				}else{
					sData[36] = " ";	//ユーザーコード
					sData[37] = " ";	//ユーザー名
					sData[38] = " ";	//パスワード
				}

				//承認状態情報（_:登録中、1:申請中、2:留保中、3:承認済）
				sData[39] = "3";

				sData[40] = " ";		//メモ
				//更新情報
				sData[41] = " ";		//申込更新日時;
				sData[42] = gs利用者コード;
				sData[43] = "会員登録";	//更新ＰＧ

				for(int iCnt = 0; iCnt < sData.Length ; iCnt++)
					if(sData[iCnt].Length ==0) sData[iCnt] = " ";

				string[] sList = new string[1]{""};

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					if (s会員コード.Substring(0,1) != "J")
					{
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

						sList = sv_maintenance.Ins_Mosikomi(gsaユーザ, sData);

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					}
					else
					{
						sList = sv_oji.Ins_Mosikomi(gsaユーザ, sData);
					}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

				texメッセージ.Text = sList[0];
				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					//s申込更新日時 = sList[1].Trim();
					//tex受付ＮＯ.Text = sList[2].Trim();
//保留
//					登録モード();
//					tex申込者名.Text = " ";
//					tex申込者名.Focus();
				}
				else
				{
					bRet = false;
					if(sList.Length >= 2 && sList[2] != null)
//保留
//					tex受付ＮＯ.Text = sList[2].Trim();
					ビープ音();
				}
			}
			catch (Exception ex)
			{
				bRet = false;
				texメッセージ.Text = ex.Message;
				ビープ音();
//				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			
			return bRet;
		}

		private void 県編集(string s住所)
		{
			//都道府県ハッシュテーブルの作成
			都道府県ハッシュ設定();

			s設置場所県コード = "";
			s設置場所住所１   = s住所;

			if(s住所.Length >= 3)
			{
				//都道府県ＣＤの取得
				string s編集中     = "";
				int    iIndex      = 0;
				// 「神奈川県」、「和歌山県」、「鹿児島県」は４文字で分解し比較する
				if((s住所[0] == '神' || s住所[0] == '和' || s住所[0] == '鹿')
					&& s住所.Length >= 4 
					&& s住所[3] == '県')
				{
					s編集中 = s住所.Substring(0,4);
					iIndex  = 4;
				}
				else
				{
					s編集中 = s住所.Substring(0,3);
					iIndex  = 3;
				}
				Object obj = h県[s編集中];
				if(obj != null)
				{
					s設置場所県コード = ((int)obj).ToString("00");
					s住所 = s住所.Remove(0,iIndex);
					s設置場所住所１ = s住所;
				}
			}
		}
// ADD 2007.01.27 東都）高木 会員申込への追加 END

// ADD 2005.06.09 東都）小童谷 ユーザー存在チェック START
		private bool ユーザー存在チェック()
		{
			bool Bret = false;
			try
			{
				string[] sKey  = new string[2];
				sKey[0] = s会員コード;
				sKey[1] = tex簡易ユーザー.Text.Trim();
				string[] sList = sv_maintenance.Sel_User(gsaユーザ, sKey);

				if (sList[0].Equals("正常終了"))
				{
					tex簡易ユーザー.Focus();
					texメッセージ.Text = "入力されたユーザーは既に登録されています";
					ビープ音();
				}
				else
				{
					if (sList[0].Equals("該当データがありません"))
					{
						Bret = true;
						texメッセージ.Text = "";
					}
					else
					{
						tex簡易ユーザー.Focus();
						texメッセージ.Text = sList[0];
						ビープ音();
					}
				}
			}
			catch (Exception ex)
			{
				tex簡易ユーザー.Focus();
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
			return Bret;
		}
// ADD 2005.06.09 東都）小童谷 ユーザー存在チェック END

// ADD 2005.06.09 東都）小童谷 簡易ユーザー登録 START
		private void 簡易ユーザー登録()
		{
			//パスワード自動取得
			自動発行();

			try
			{
// MOD 2005.07.21 東都）高木 店所ユーザ対応 START
//				string[] sKey  = new string[9];
				string[] sKey  = new string[10];
// MOD 2005.07.21 東都）高木 店所ユーザ対応 END
				sKey[0] = s会員コード;
				sKey[1] = tex簡易ユーザー.Text.Trim();
				sKey[2] = sパスワード;
				sKey[3] = tex部門名.Text.Trim();
				sKey[4] = tex部門コード.Text.Trim();
				sKey[5] = " ";
				sKey[6] = "0";
				sKey[7] = "00000000000000";
				sKey[8] = gs利用者コード;
// ADD 2005.07.21 東都）高木 店所ユーザ対応 START
				sKey[9] = " ";
// ADD 2005.07.21 東都）高木 店所ユーザ対応 END

				string[] sList = sv_maintenance.Ins_User(gsaユーザ, sKey);
				if (sList[0].Equals("正常終了"))
				{
// ADD 2007.01.27 東都）高木 会員申込への追加 START
					s簡易ユーザー = tex簡易ユーザー.Text;
// ADD 2007.01.27 東都）高木 会員申込への追加 END
					//利用者の追加
					tex簡易ユーザー.Text = "";
					利用者情報検索();
				}
				else
				{
					tex簡易ユーザー.Focus();
					texメッセージ.Text = sList[0];
					ビープ音();
				}
			}
			catch (Exception ex)
			{
				tex簡易ユーザー.Focus();
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
		}
// ADD 2005.06.09 東都）小童谷 簡易ユーザー登録 END

		private void btn部門削除_Click(object sender, System.EventArgs e)
		{
			tex部門コード.Text = tex部門コード.Text.Trim();

// MOD 2009.04.28 東都）高木 削除確認メッセージの追加 START
			// 最終確認
			if (MessageBox.Show("削除してもよろしいですか？", "確認"
					, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No){
				return;
			}
// MOD 2009.04.28 東都）高木 削除確認メッセージの追加 END

			texメッセージ.Text = "削除中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[4];
				sKey[0] = s会員コード;
				sKey[1] = tex部門コード.Text;
				sKey[2] = s部門更新日時;
				sKey[3] = gs利用者コード;

				string[] sList = sv_maintenance.Del_Section(gsaユーザ, sKey);
				texメッセージ.Text = sList[0];
				if (sList[0].Equals("正常終了"))
				{
					//部門の削除
					部門登録モード();
					部門情報検索();
				}
				else
				{
					ビープ音();
				}
				tex部門コード.Focus();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn部門取消_Click(object sender, System.EventArgs e)
		{
			部門登録モード();
			tex部門コード.Focus();
		}

		private void 部門検索()
		{
			if (axGT部門.get_CelText(axGT部門.CaretRow,1).Equals("")) return;

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			
			try
			{
				string[] sKey  = new string[2];
				sKey[0] = s会員コード;
				sKey[1] = axGT部門.get_CelText(axGT部門.CaretRow,1).Trim();
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//				string[] sList = sv_maintenance.Sel_Section(gsaユーザ, sKey);
				String[] sList;
				if (s会員コード.Substring(0,1) != "J")
				{
					sList = sv_maintenance.Sel_Section(gsaユーザ, sKey);
				}
				else
				{
					sList = sv_oji.Sel_Section(gsaユーザ, sKey);
				}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END


				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex部門コード.Text = sList[1].Trim();
					tex部門名.Text = sList[2].Trim();
					num出力順.Text = sList[3].Trim();
					tex郵便番号１.Text = sList[4].PadRight(7).Substring(0, 3).Trim();
					tex郵便番号２.Text = sList[4].PadRight(7).Substring(3, 4).Trim();
					tex管理店所名.Text = sList[5].Trim();
					tex設置先住所１.Text = sList[6].Trim();
					tex設置先住所２.Text = sList[7].Trim();
					s部門更新日時 = sList[8].Trim();
					numサーマル台数.Text = sList[9].Trim();
// ADD 2009.03.03 東都）高木 サーマルシリアル番号の追加 START
					if(sList.Length > 10){
						texシリアル番号１.Text = sList[10].Trim();
						cmbシリアル番号１.SelectedIndex = int.Parse(sList[11].Trim());
						texシリアル番号２.Text = sList[12].Trim();
						cmbシリアル番号２.SelectedIndex = int.Parse(sList[13].Trim());
						texシリアル番号３.Text = sList[14].Trim();
						cmbシリアル番号３.SelectedIndex = int.Parse(sList[15].Trim());
						texシリアル番号４.Text = sList[16].Trim();
						cmbシリアル番号４.SelectedIndex = int.Parse(sList[17].Trim());
						int i設置場所使用料 = int.Parse(sList[18].Trim());
						if(i設置場所使用料 > 0)
							tex設置場所使用料.Text = i設置場所使用料.ToString("#,##0");
						else
							tex設置場所使用料.Text = "";
					}
// ADD 2009.03.03 東都）高木 サーマルシリアル番号の追加 END
					部門更新モード();
// ADD 2005.06.13 東都）小童谷 検索条件追加 START
					s部門コード = sList[1].Trim();
					利用者情報検索();
// ADD 2005.06.13 東都）小童谷 検索条件追加 END
					tex部門名.Focus();
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					axGT部門.Focus();
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void 部門情報検索()
		{
			axGT部門.Clear();
			axGT部門.Rows = 4;
			axGT部門.CaretRow = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT部門.CaretCol = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
			axGT部門_CurPlaceChanged(null,null);
			
			try
			{
				string[] sKey  = new string[3];
				sKey[0] = s会員コード;
				sKey[1] = "";
				sKey[2] = "";
				string[] sList = sv_maintenance.Get_Section(gsaユーザ, sKey);

				if (sList[0].Equals("正常終了") || sList[0].Equals("該当データがありません"))
				{
					texメッセージ.Text = "";
					if (axGT部門.Rows < sList.Length - 1)
					{
						axGT部門.Rows = (short)(sList.Length - 1);
					}
					for(short sCnt = 1; sCnt < sList.Length; sCnt++)
					{
						axGT部門.set_RowsText(sCnt, sList[sCnt]);
					}
				}
				else
				{
					texメッセージ.Text = sList[0];
					throw new Exception(sList[0]);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private void axGT利用者_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			利用者検索();
		}

		private void axGT利用者_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				利用者検索();
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT利用者, true, true, true, true);
			}
		}

		private void btn利用者登録_Click(object sender, System.EventArgs e)
		{
			tex利用者コード.Text = tex利用者コード.Text.Trim();
			if (!必須チェック(tex利用者コード, "ユーザー")) return;
			if (!半角チェック(tex利用者コード, "ユーザー")) return;

			tex利用者名.Text = tex利用者名.Text.Trim();
			if (!必須チェック(tex利用者名, "ユーザー名")) return;
			if (!全角チェック(tex利用者名, "ユーザー名")) return;

			texパスワード.Text = texパスワード.Text.Trim();
// DEL 2005.06.08 東都）小童谷 再入力削除 START
//			texパスワード再入力.Text = texパスワード再入力.Text.Trim();
// DEL 2005.06.08 東都）小童谷 再入力削除 END
			if (!必須チェック(texパスワード, "パスワード")) return;
			if (!半角チェック(texパスワード, "パスワード")) return;

// ADD 2008.05.29 東都）高木 パスワード更新年月日を表示 START
			texパスワード更新日.Text = texパスワード更新日.Text.Trim();
			//パスワードが未入力もしくは[会員登録]である場合
			//（項目[登録ＰＧ]を使用している為、[会員登録]になることがある）
			if(texパスワード更新日.Text.Length == 0
					|| texパスワード更新日.Text.Equals("会員登録")){
				//システム日付
				texパスワード更新日.Text = DateTime.Now.ToString("yyyyMMdd");
			}
			if (!半角チェック(texパスワード更新日, "パスワード更新日")) return;
			if(texパスワード更新日.Text.Length != 8){
				MessageBox.Show("パスワード更新日は8桁で入力してください",
					"入力チェック",MessageBoxButtons.OK);
				texパスワード更新日.Focus();
				return;
			}
//			if (!日付チェック(texパスワード更新日, "パスワード更新日")) return;
			if (!数値チェック(texパスワード更新日, "パスワード更新日")) return;
// ADD 2008.05.29 東都）高木 パスワード更新年月日を表示 END

// DEL 2005.06.08 東都）小童谷 再入力削除 START
//			if (!texパスワード.Text.Equals(texパスワード再入力.Text))
//			{
//				MessageBox.Show("パスワードが違います","入力チェック",MessageBoxButtons.OK);
//				return;
//			}
// DEL 2005.06.08 東都）小童谷 再入力削除 END
// DEL 2007.02.06 東都）高木 パスワード使用可能文字チェックの廃止（by 桑田殿） START
//// ADD 2007.01.30 東都）高木 パスワード使用可能文字の制限 START
//			if ( texパスワード.Text.IndexOf('0') >= 0
//				|| texパスワード.Text.IndexOf('1') >= 0
//				|| texパスワード.Text.IndexOf('l') >= 0
//				|| texパスワード.Text.IndexOf('o') >= 0 )
//			{
//				MessageBox.Show("パスワードに、[o(ｵｰ),0(ｾﾞﾛ),l(ｴﾙ),1(ｲﾁ)]の文字は使用できません"
//									, "入力チェック", MessageBoxButtons.OK);
//				return;
//			}
//// ADD 2007.01.30 東都）高木 パスワード使用可能文字の制限 END
// DEL 2007.02.06 東都）高木 パスワード使用可能文字チェックの廃止（by 桑田殿） END

			//部門チェック
			if (!利用者部門検索())
			{
				MessageBox.Show("セクション(" + tex部門コード.Text + ")が存在しません" ,"入力チェック",MessageBoxButtons.OK);
				tex部門コード.Focus();
				return;
			}
			//荷送人チェック
			if (tex荷送人コード.Text.Trim().Length != 0)
			{
				if (!荷送人検索())
				{
					MessageBox.Show("荷送人(" + tex荷送人コード.Text + ")が存在しません" ,"入力チェック",MessageBoxButtons.OK);
					tex荷送人コード.Focus();
					return;
				}
			}
			else
			{
				tex荷送人コード.Text = " ";
			}

			texメッセージ.Text = btn利用者登録.Text + "中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
// MOD 2008.05.29 東都）高木 パスワード更新年月日を表示 START
//// MOD 2005.07.21 東都）高木 店所ユーザ対応 START
////				string[] sKey  = new string[9];
//				string[] sKey  = new string[10];
				string[] sKey  = new string[11];
//// MOD 2005.07.21 東都）高木 店所ユーザ対応 END
// MOD 2008.05.29 東都）高木 パスワード更新年月日を表示 END
				sKey[0] = s会員コード;
				sKey[1] = tex利用者コード.Text;
				sKey[2] = texパスワード.Text;
				sKey[3] = tex利用者名.Text;
// MOD 2005.06.09 東都）小童谷 tex利用者部門コード削除 START
//				sKey[4] = tex利用者部門コード.Text;
				sKey[4] = tex部門コード.Text;
// MOD 2005.06.09 東都）小童谷 tex利用者部門コード削除 END
				sKey[5] = tex荷送人コード.Text;
				sKey[6] = s認証エラー回数.ToString();
				sKey[7] = s利用者更新日時;
				sKey[8] = gs利用者コード;
// ADD 2005.07.21 東都）高木 店所ユーザ対応 START
				sKey[9] = " ";
				if(chbラベル印刷禁止.Checked)
					sKey[9] = "T";
// ADD 2005.07.21 東都）高木 店所ユーザ対応 END
// ADD 2008.05.29 東都）高木 パスワード更新年月日を表示 START
				sKey[10] = texパスワード更新日.Text;
// ADD 2008.05.29 東都）高木 パスワード更新年月日を表示 END

				if (btn利用者登録.Text.Equals("登録"))
				{
					string[] sList = sv_maintenance.Ins_User(gsaユーザ, sKey);
					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						//利用者の追加
						利用者登録モード();
						利用者情報検索();
					}
					else
					{
						ビープ音();
					}
				}
				else
				{
					string[] sList = sv_maintenance.Upd_User(gsaユーザ, sKey);
					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						//利用者の更新
						利用者登録モード();
						利用者情報検索();
					}
					else
					{
						ビープ音();
					}
				}
				tex利用者コード.Focus();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn利用者削除_Click(object sender, System.EventArgs e)
		{
			tex利用者コード.Text = tex利用者コード.Text.Trim();
			
// MOD 2009.04.28 東都）高木 削除確認メッセージの追加 START
			// 最終確認
			if (MessageBox.Show("削除してもよろしいですか？", "確認"
					, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No){
				return;
			}
// MOD 2009.04.28 東都）高木 削除確認メッセージの追加 END

			texメッセージ.Text = "削除中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[4];
				sKey[0] = s会員コード;
				sKey[1] = tex利用者コード.Text;
				sKey[2] = s利用者更新日時;
				sKey[3] = gs利用者コード;

				string[] sList = sv_maintenance.Del_User(gsaユーザ, sKey);
				texメッセージ.Text = sList[0];
				if (sList[0].Equals("正常終了"))
				{
					//利用者の削除
					利用者登録モード();
					利用者情報検索();
				}
				else
				{
					ビープ音();
				}
				tex利用者コード.Focus();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn利用者取消_Click(object sender, System.EventArgs e)
		{
			利用者登録モード();
			tex利用者コード.Focus();
		}

		private void 利用者検索()
		{
			if (axGT利用者.get_CelText(axGT利用者.CaretRow,1).Equals("")) return;

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[2];
				sKey[0] = s会員コード;
				sKey[1] = axGT利用者.get_CelText(axGT利用者.CaretRow,1).Trim();
				string[] sList = sv_maintenance.Sel_User(gsaユーザ, sKey);

				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex利用者コード.Text = sList[1].Trim();
					texパスワード.Text = sList[2].Trim();
// DEL 2005.06.08 東都）小童谷 再入力削除 START
//					texパスワード再入力.Text = sList[2].Trim();
// DEL 2005.06.08 東都）小童谷 再入力削除 END
					tex利用者名.Text = sList[3].Trim();
//					tex利用者部門コード.Text = sList[4].Trim();
//					tex利用者部門名.Text = sList[5].Trim();
					tex荷送人コード.Text = sList[6].Trim();
					s認証エラー回数 = int.Parse(sList[7]);
					s利用者更新日時 = sList[8].Trim();
// ADD 2005.07.21 東都）高木 店所ユーザ対応 START
					if(sList[9] == "T")
						chbラベル印刷禁止.Checked = true;
					else
						chbラベル印刷禁止.Checked = false;
// ADD 2005.07.21 東都）高木 店所ユーザ対応 END
// ADD 2008.05.29 東都）高木 パスワード更新年月日を表示 START
					if(sList.Length > 10){
						texパスワード更新日.Text = sList[10].Trim();
					}
// ADD 2008.05.29 東都）高木 パスワード更新年月日を表示 END
					利用者更新モード();
					tex利用者名.Focus();
					
					if (s認証エラー回数 != 0)
					{
						btnパスワードロック.Enabled = true;
					}
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					axGT利用者.Focus();
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void 利用者情報検索()
		{
			axGT利用者.Clear();
			axGT利用者.Rows = 4;
			axGT利用者.CaretRow = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT利用者.CaretCol = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
			axGT利用者_CurPlaceChanged(null,null);
			
			try
			{
// MOD 2005.06.13 東都）小童谷 検索条件追加 START
//				string[] sKey  = new string[3];
//				sKey[0] = s会員コード;
//				sKey[1] = "";
//				sKey[2] = "";
				string[] sKey  = new string[4];
				sKey[0] = s会員コード;
				sKey[1] = "";
				sKey[2] = "";
				sKey[3] = s部門コード;
// MOD 2005.06.13 東都）小童谷 検索条件追加 END
				string[] sList = sv_maintenance.Get_User(gsaユーザ, sKey);

				if (sList[0].Equals("正常終了") || sList[0].Equals("該当データがありません"))
				{
					texメッセージ.Text = "";
					if (axGT利用者.Rows < sList.Length - 1)
					{
						axGT利用者.Rows = (short)(sList.Length - 1);
					}
					for(short sCnt = 1; sCnt < sList.Length; sCnt++)
					{
						axGT利用者.set_RowsText(sCnt, sList[sCnt]);
					}
				}
				else
				{
					texメッセージ.Text = sList[0];
					throw new Exception(sList[0]);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void chb使用終了日_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chb使用終了日.Checked)
			{
				lab終了日.Visible = false;
//				dtp使用終了日.Enabled = true;
			}
			else
			{
				lab終了日.Visible = true;
//				dtp使用終了日.Enabled = false;
			}
		}

		private void tex郵便番号２_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				if(tex郵便番号１.Text.Length == 3 && tex郵便番号２.Text.Length == 4)
					郵便番号検索();
				else{
					郵便番号一覧();
				}
			}
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
				//				tex管理店所名.Text = 画面.s管理店所.Trim();
				//				tex設置先住所１.Text = 画面.s住所.Trim();
				tex郵便番号１.Text = g住所検索.s郵便番号１.Trim();
				tex郵便番号２.Text = g住所検索.s郵便番号２.Trim();
				tex管理店所名.Text = g住所検索.s管理店所.Trim();
				tex設置先住所１.Text = g住所検索.s住所.Trim();
				tex設置先住所２.Text = "";
				tex設置先住所２.Focus();
			}
			else
			{
				tex郵便番号１.Focus();
			}
// MOD 2005.05.25 東都）小童谷 画面高速化 END
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

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex郵便番号１.Text + tex郵便番号２.Text;
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//				string[] sList = sv_maintenance.Sel_Postcode(gsaユーザ, sKey);
				String[] sList;
				if (s会員コード.Substring(0,1) != "J")
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
					if (s会員コード.Substring(0,1) == "J")
					{
//MOD 2016.03.16 BEVAS）松本 王子運送版グローバル運用対応 START
						//選択した会員が王子グローバル荷主の場合は、下記処理をスキップする
						if(s会員コード.Substring(0,2) != "JG")
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
									tex管理店所名.Text = "";
									ビープ音();
									this.Cursor = System.Windows.Forms.Cursors.Default;
									return false;
								}
							}
							else
							{
								texメッセージ.Text = sList1[0];
								tex管理店所名.Text = "";
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
					tex管理店所名.Text = sList[1].Trim();
					if(tex設置先住所１.Text.Trim().Length == 0 && tex設置先住所２.Text.Trim().Length == 0)
					{
						tex設置先住所１.Text = sList[2].Trim();
						tex設置先住所２.Focus();
					}
					else
						tex設置先住所１.Focus();
// ADD 2007.01.27 東都）高木 会員申込への追加 START
					if(sList.Length > 3)
						s管理店所コード = sList[3].Trim();
					else
						s管理店所コード = "";
// ADD 2007.01.27 東都）高木 会員申込への追加 END
				}
				else
				{
					texメッセージ.Text = sList[0];
					tex管理店所名.Text = "";
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

// DEL 2005.06.10 東都）小童谷 利用者部門削除 START
/*
		private void tex利用者部門コード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				if(tex利用者部門コード.Text.Trim().Length == 0)
					利用者部門一覧();
				else
					利用者部門検索();
			}
		}

		private void tex利用者部門コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn利用者部門検索.Focus();
				利用者部門一覧();
				e.Handled = true;
			}		
		}

		private void btn利用者部門検索_Click(object sender, System.EventArgs e)
		{
			利用者部門一覧();
		}

		private void 利用者部門一覧()
		{
			tex利用者部門コード.Text = tex利用者部門コード.Text.Trim();
			if(!半角チェック(tex利用者部門コード, "セクション")) return;

			// 検索画面を左側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			部門検索 画面 = new 部門検索();
//			画面.Left = this.Left;
//			画面.Top = this.Top;

			// コードの初期表示
//			画面.s会員コード = s会員コード;
//			画面.s部門コード = tex利用者部門コード.Text;
//			画面.s部門名 = "";
//			画面.ShowDialog();
			if (g部門検索 == null)	 g部門検索 = new 部門検索();
			g部門検索.Left = this.Left;
			g部門検索.Top = this.Top;
			// コードの初期表示
			g部門検索.s会員コード = s会員コード;
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし START
//			g部門検索.s部門コード = tex利用者部門コード.Text;
			g部門検索.s部門コード = "";
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし END
			g部門検索.s部門名 = "";
			g部門検索.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (画面.s部門コード.Trim().Length != 0)
			if (g部門検索.s部門コード.Trim().Length != 0)
			{
//				tex利用者部門コード.Text = 画面.s部門コード.Trim();
//				tex利用者部門名.Text = 画面.s部門名.Trim();
				tex利用者部門コード.Text = g部門検索.s部門コード.Trim();
				tex利用者部門名.Text = g部門検索.s部門名.Trim();
				tex荷送人コード.Focus();
			}
			else
			{
				tex利用者部門コード.Focus();
			}
// MOD 2005.05.25 東都）小童谷 画面高速化 END
		}
*/
// DEL 2005.06.10 東都）小童谷 利用者部門削除 END

		private bool 利用者部門検索()
		{
			tex部門コード.Text = tex部門コード.Text.Trim();
			if(!半角チェック(tex部門コード, "部門コード")) return false;

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[2];
				sKey[0] = s会員コード;
				sKey[1] = tex部門コード.Text.Trim();
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//				string[] sList = sv_maintenance.Sel_Section(gsaユーザ, sKey);
				String[] sList;
				if (s会員コード.Substring(0,1) != "J")
				{
					sList = sv_maintenance.Sel_Section(gsaユーザ, sKey);

				}
				else
				{
					sList = sv_oji.Sel_Section(gsaユーザ, sKey);
				}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
//					tex部門名.Text = sList[2].Trim();
				}
				else
				{
					texメッセージ.Text = sList[0];
//					tex部門名.Text = "";
					ビープ音();
					ret =  false;
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				初期モード();
				ret =  false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}
		
		private void tex荷送人コード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				if(tex荷送人コード.Text.Trim().Length != 0)
					荷送人検索();
			}
		}

		private void tex荷送人コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn荷送人検索.Focus();
				荷送人一覧();
				e.Handled = true;
			}		
		}

		private void btn荷送人検索_Click(object sender, System.EventArgs e)
		{
			荷送人一覧();
		}
		
		private void 荷送人一覧()
		{
// MOD 2005.06.09 東都）小童谷 tex利用者部門コード削除 START
//			tex利用者部門コード.Text = tex利用者部門コード.Text.Trim();
//			if(!必須チェック(tex利用者部門コード, "セクション")) return;
//			if(!半角チェック(tex利用者部門コード, "セクション")) return;
			tex部門コード.Text = tex部門コード.Text.Trim();
			if(!必須チェック(tex部門コード, "セクション")) return;
			if(!半角チェック(tex部門コード, "セクション")) return;
// MOD 2005.06.09 東都）小童谷 tex利用者部門コード削除 END
			tex荷送人コード.Text = tex荷送人コード.Text.Trim();
			if(!半角チェック(tex荷送人コード, "荷送人コード")) return;

			// 検索画面を左側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			荷送人検索 画面 = new 荷送人検索();
//			画面.Left = this.Left;
//			画面.Top = this.Top;

			// コードの初期表示
//			画面.s会員コード = s会員コード;
//			画面.s部門コード = tex利用者部門コード.Text.Trim();
//			画面.s荷送人コード = tex荷送人コード.Text.Trim();
//			画面.sカナ略称 = "";
//			画面.ShowDialog();
			if (g荷送検索 == null)	 g荷送検索 = new 荷送人検索();
			g荷送検索.Left = this.Left;
			g荷送検索.Top = this.Top;
			// コードの初期表示
			g荷送検索.s会員コード = s会員コード;
// MOD 2005.06.09 東都）小童谷 tex利用者部門コード削除 START
//			g荷送検索.s部門コード = tex利用者部門コード.Text.Trim();
			g荷送検索.s部門コード = tex部門コード.Text.Trim();
// MOD 2005.06.09 東都）小童谷 tex利用者部門コード削除 END

// MOD 2005.06.02 東都）小童谷 値の引継ぎなし START
//			g荷送検索.s荷送人コード = tex荷送人コード.Text.Trim();
			g荷送検索.s荷送人コード = "";
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし END
			g荷送検索.sカナ略称 = "";
			g荷送検索.ShowDialog();
// MOD 2005.05.25 東都）小童谷 画面高速化 END
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (画面.s荷送人コード.Trim().Length != 0)
			if (g荷送検索.s荷送人コード.Trim().Length != 0)
			{
//				tex荷送人コード.Text = 画面.s荷送人コード.Trim();
				tex荷送人コード.Text = g荷送検索.s荷送人コード.Trim();
				btn利用者登録.Focus();
			}
			else
			{
				tex荷送人コード.Focus();
			}
		}
		
		private bool 荷送人検索()
		{
// MOD 2005.06.09 東都）小童谷 tex利用者部門コード削除 START
//			tex利用者部門コード.Text = tex利用者部門コード.Text.Trim();
//			if(!必須チェック(tex利用者部門コード, "セクション")) return false;
//			if(!半角チェック(tex利用者部門コード, "セクション")) return false;
			tex部門コード.Text = tex部門コード.Text.Trim();
			if(!必須チェック(tex部門コード, "セクション")) return false;
			if(!半角チェック(tex部門コード, "セクション")) return false;
// MOD 2005.06.09 東都）小童谷 tex利用者部門コード削除 END
			tex荷送人コード.Text = tex荷送人コード.Text.Trim();
			if(!半角チェック(tex荷送人コード, "荷送人コード")) return false;

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[3];
				sKey[0] = s会員コード;
// MOD 2005.06.09 東都）小童谷 tex利用者部門コード削除 START
//				sKey[1] = tex利用者部門コード.Text;
				sKey[1] = tex部門コード.Text;
// MOD 2005.06.09 東都）小童谷 tex利用者部門コード削除 END
				sKey[2] = tex荷送人コード.Text;
				string[] sList = sv_maintenance.Sel_Consignor(gsaユーザ, sKey);
				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					ret = false;
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

		private void num出力順_Enter(object sender, System.EventArgs e)
		{
			num出力順.Select(0, num出力順.Text.Length);
		}

		private void btn自動発行_Click(object sender, System.EventArgs e)
		{
			// パスワードのクリア
			texパスワード.Text       = "";

			自動発行();

			texパスワード.Text       = sパスワード;
// DEL 2005.06.08 東都）小童谷 再入力削除 START
//			texパスワード再入力.Text = sパスワード;
// DEL 2005.06.08 東都）小童谷 再入力削除 END
		}

		private void 自動発行()
		{
// MOD 2005.06.08 東都）小童谷 大文字なし START
//			const string s文字 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
// MOD 2007.01.30 東都）高木 パスワード使用可能文字の制限 START
//			const string s文字 = "0123456789abcdefghijklmnopqrstuvwxyz";
			// lと1、0とoは除外する
			const string s文字 = "23456789abcdefghijkmnpqrstuvwxyz";
// MOD 2007.01.30 東都）高木 パスワード使用可能文字の制限 END
// MOD 2005.06.08 東都）小童谷 大文字なし END

			sパスワード = "";

// DEL 2005.06.08 東都）小童谷 再入力削除 START
//			texパスワード再入力.Text = "";
// DEL 2005.06.08 東都）小童谷 再入力削除 END

			Random rdm = new Random();
			int i乱数 = rdm.Next(0,s文字.Length - 1);
			for(int iCnt = 0; iCnt < 6; iCnt++)
			{
				i乱数 = rdm.Next(0,s文字.Length);
				sパスワード += s文字[i乱数];
			}
		}

		private void btnパスワードロック_Click(object sender, System.EventArgs e)
		{
			s認証エラー回数 = 0;
			btnパスワードロック.Enabled = false;
		}

		private void dtp使用終了日_DropDown(object sender, System.EventArgs e)
		{
			chb使用終了日.Checked = true;
			lab終了日.Visible = false;
		}

		private void axGT部門_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT部門.set_CelForeColor(nOldRowB,0,0);
			axGT部門.set_CelBackColor(nOldRowB,0,0xFFFFFF);
//			axGT部門.set_CelForeColor(axGT部門.CaretRow,0,111111);
			axGT部門.set_CelForeColor(axGT部門.CaretRow,0,0x98FB98);  //BGR
			axGT部門.set_CelBackColor(axGT部門.CaretRow,0,0x006000);
			nOldRowB = axGT部門.CaretRow;
		}

		private void axGT利用者_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT利用者.set_CelForeColor(nOldRowR,0,0);
			axGT利用者.set_CelBackColor(nOldRowR,0,0xFFFFFF);
//			axGT利用者.set_CelForeColor(axGT利用者.CaretRow,0,111111);
			axGT利用者.set_CelForeColor(axGT利用者.CaretRow,0,0x98FB98);  //BGR
			axGT利用者.set_CelBackColor(axGT利用者.CaretRow,0,0x006000);
			nOldRowR = axGT利用者.CaretRow;
		}

// ADD 2005.05.25 東都）小童谷 フォーカス移動 START
		private void 会員マスタ_Closed(object sender, System.EventArgs e)
		{
			texメッセージ.Text = "";
			tex会員コード.Text = " ";
//保留 MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
//			cb運用中のお客様のみ.Checked = true;
//保留 MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END
			dtp使用開始日.Value = System.DateTime.Now;
			dtp使用終了日.Value = System.DateTime.Now;
			axGT部門.CaretRow   = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT部門.CaretCol = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
			axGT部門_CurPlaceChanged(null,null);
			axGT利用者.CaretRow = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT利用者.CaretCol = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
			axGT利用者_CurPlaceChanged(null,null);
			tex会員コード.Focus();
		}
// ADD 2005.05.25 東都）小童谷 フォーカス移動 END

// ADD 2005.08.08 東都）小童谷 新規追加 START
		private void btn新規_Click(object sender, System.EventArgs e)
		{
			tex会員コード.Text = " ";
			dtp使用開始日.Value = System.DateTime.Now;
			dtp使用終了日.Value = System.DateTime.Now;
			axGT部門.Clear();
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT部門.CaretRow = 1;
			axGT部門.CaretCol = 1;
			axGT部門_CurPlaceChanged(null,null);
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
			初期モード();
			texメッセージ.Text = "";
		}
// ADD 2005.08.08 東都）小童谷 新規追加 END
// MOD 2016.04.13 BEVAS）松本 社内伝票機能追加対応 START
		private void btn社内伝会員発店登録_Click(object sender, System.EventArgs e)
		{
			if (g社内伝 == null)	 g社内伝 = new 社内伝会員発店マスタ();
			g社内伝.Left = this.Left + (this.Width  - g社内伝.Width)  / 2;
			g社内伝.Top = this.Top;
			g社内伝.ShowDialog();
		}
// MOD 2016.04.13 BEVAS）松本 社内伝票機能追加対応 END
	}
}
