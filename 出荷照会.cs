using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using CrystalDecisions.CrystalReports.Engine;

namespace is2AdminClient
{
	/// <summary>
	/// [出荷照会]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// MOD 2007.01.11 東都）高木 行数を10行にする 
	// DEL 2007.01.11 東都）高木 依頼主の必須チェックの廃止 
	// ADD 2007.01.11 東都）高木 送り状番号で検索した時、お客様名、依頼主名を表示 
	// MOD 2007.01.17 東都）高木 一覧表示項目の変更 
	// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 
	// MOD 2007.01.22 東都）高木 デフォルト値の変更 
	// ADD 2007.01.23 東都）高木 画面の調整 
	// MOD 2007.01.23 東都）高木 1000件以上は表示できなくする 
	// ADD 2007.01.25 東都）高木 お客様コードチェックの追加 
	// MOD 2007.01.25 東都）高木 検索条件エラー 
	// MOD 2007.02.02 東都）高木 メッセージ変更 
	// MOD 2007.02.02 東都）高木 1000件以上エラーのメッセージ変更 
	// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 
	// MOD 2007.11.13 KCL) 森本 global対応[会員検索２]画面に変更 
	// MOD 2007.11.14 KCL) 森本 global対応 
	// MOD 2007.11.16 KCL) 森本 global対応 
	//--------------------------------------------------------------------------
	// MOD 2009.05.11 東都）高木 未出荷対応 
	// MOD 2009.09.11 東都）高木 出荷照会で出荷済ＦＧ,送信済ＦＧなどを追加 
	//--------------------------------------------------------------------------
	// MOD 2010.04.06 東都）高木 出荷照会に得意先、郵便番号などを追加 
	// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 
	// MOD 2010.04.30 東都）高木 ＣＳＶ出力機能の追加 
	//--------------------------------------------------------------------------
	// MOD 2010.11.19 東都）高木 配完情報などの取得 
	// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	//--------------------------------------------------------------------------
	// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 
	// MOD 2011.05.20 東都）高木 ＣＳＶ出力形式の追加 
	// MOD 2011.05.20 東都）高木 出荷照会件数の上限解除の解除 
	// MOD 2011.07.14 東都）高木 検索可能な出荷データ期間の明記
	//--------------------------------------------------------------------------
	// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加
	// MOD 2014.03.20 BEVAS）高杉 ＣＳＶ出力に配完日付・時刻を追加
	//--------------------------------------------------------------------------
	// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応
	//--------------------------------------------------------------------------
	public class 出荷照会 : 共通フォーム
	{
		public short OldRow = 0;
		private short nSrow = 0;
		private short nErow = 0;
		private short nWork = 0;
		private string s部門ＣＤ;
		private string s依頼主ＣＤ;
		private string s依頼主名;

		private string[] s出荷一覧;

// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 START
		private string[] sa市区郡
			= {
				  "市原市","市川市","今市市","余市郡","蒲郡市",
				  "郡上市","小郡市","郡山市","高市郡","郡上郡",
				  "廿日市市","四日市市","八日市場市"
			  };
//		private bool gb印刷 = true;
		// 送り状印刷用データセット
		private 送り状データ ds送り状 = new 送り状データ();
		private int i印刷順 = 0;
// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 END



		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lab日時;
		private System.Windows.Forms.TextBox tex重量合計;
		private System.Windows.Forms.TextBox tex個数合計;
		private System.Windows.Forms.Label lab登録件数;
		private System.Windows.Forms.TextBox tex登録件数;
		private System.Windows.Forms.Label lab個数合計;
		private System.Windows.Forms.Label lab重量合計;
		private System.Windows.Forms.Label lab依頼主;
		private 共通テキストボックス tex依頼主コード;
		private System.Windows.Forms.Label lab状態;
		private System.Windows.Forms.TextBox tex依頼主名;
		private System.Windows.Forms.Label labお客様;
		private System.Windows.Forms.Label lab出荷照会タイトル;
		private System.Windows.Forms.TextBox texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Button btn依頼主検索;
		private System.Windows.Forms.Button btn出荷検索;
		private AxGTABLE32V2Lib.AxGTable32 axGT出荷一覧;
		private System.Windows.Forms.DateTimePicker dt開始日付;
		private System.Windows.Forms.DateTimePicker dt終了日付;
		private System.Windows.Forms.ComboBox cmb状態;
		private System.Windows.Forms.ComboBox cmb出荷日;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label lab送り状番号;
		private is2AdminClient.共通テキストボックス tex送り状番号;
		private System.Windows.Forms.Label labお客様名;
		private System.Windows.Forms.TextBox tex認証会員名;
		private System.Windows.Forms.TextBox tex認証利用者名;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnお客様検索;
		private is2AdminClient.共通テキストボックス texお客様コード;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox texお客様名;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmb削除区分;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lab店所;
		private is2AdminClient.共通テキストボックス tex店所;
		private System.Windows.Forms.CheckBox cb運用中のお客様のみ;
		private System.Windows.Forms.Button btnＣＳＶ出力;
		private System.Windows.Forms.TextBox texエントリ計;
		private System.Windows.Forms.Label labエントリ重量計;
		private System.Windows.Forms.Label lab出荷日範囲;
		private System.Windows.Forms.CheckBox cBox配完Ｓ出力;
		private System.Windows.Forms.Button btn実績表印刷;
		private System.Windows.Forms.Button btnラベルイメージ印刷;
		private System.ComponentModel.IContainer components;

		public 出荷照会()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(出荷照会));
			this.panel2 = new System.Windows.Forms.Panel();
			this.texエントリ計 = new System.Windows.Forms.TextBox();
			this.labエントリ重量計 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.axGT出荷一覧 = new AxGTABLE32V2Lib.AxGTable32();
			this.tex重量合計 = new System.Windows.Forms.TextBox();
			this.tex個数合計 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.lab登録件数 = new System.Windows.Forms.Label();
			this.tex登録件数 = new System.Windows.Forms.TextBox();
			this.lab個数合計 = new System.Windows.Forms.Label();
			this.lab重量合計 = new System.Windows.Forms.Label();
			this.lab依頼主 = new System.Windows.Forms.Label();
			this.btn依頼主検索 = new System.Windows.Forms.Button();
			this.tex依頼主コード = new is2AdminClient.共通テキストボックス();
			this.panel5 = new System.Windows.Forms.Panel();
			this.cBox配完Ｓ出力 = new System.Windows.Forms.CheckBox();
			this.lab出荷日範囲 = new System.Windows.Forms.Label();
			this.cb運用中のお客様のみ = new System.Windows.Forms.CheckBox();
			this.tex店所 = new is2AdminClient.共通テキストボックス();
			this.lab店所 = new System.Windows.Forms.Label();
			this.cmb削除区分 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.texお客様名 = new System.Windows.Forms.TextBox();
			this.btnお客様検索 = new System.Windows.Forms.Button();
			this.texお客様コード = new is2AdminClient.共通テキストボックス();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tex送り状番号 = new is2AdminClient.共通テキストボックス();
			this.lab送り状番号 = new System.Windows.Forms.Label();
			this.cmb状態 = new System.Windows.Forms.ComboBox();
			this.lab状態 = new System.Windows.Forms.Label();
			this.cmb出荷日 = new System.Windows.Forms.ComboBox();
			this.btn出荷検索 = new System.Windows.Forms.Button();
			this.tex依頼主名 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dt開始日付 = new System.Windows.Forms.DateTimePicker();
			this.dt終了日付 = new System.Windows.Forms.DateTimePicker();
			this.panel6 = new System.Windows.Forms.Panel();
			this.tex認証利用者名 = new System.Windows.Forms.TextBox();
			this.labお客様 = new System.Windows.Forms.Label();
			this.labお客様名 = new System.Windows.Forms.Label();
			this.tex認証会員名 = new System.Windows.Forms.TextBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab日時 = new System.Windows.Forms.Label();
			this.lab出荷照会タイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnラベルイメージ印刷 = new System.Windows.Forms.Button();
			this.btn実績表印刷 = new System.Windows.Forms.Button();
			this.btnＣＳＶ出力 = new System.Windows.Forms.Button();
			this.texメッセージ = new System.Windows.Forms.TextBox();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.ds送り状)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axGT出荷一覧)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Honeydew;
			this.panel2.Controls.Add(this.texエントリ計);
			this.panel2.Controls.Add(this.labエントリ重量計);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.axGT出荷一覧);
			this.panel2.Controls.Add(this.tex重量合計);
			this.panel2.Controls.Add(this.tex個数合計);
			this.panel2.Controls.Add(this.label21);
			this.panel2.Controls.Add(this.lab登録件数);
			this.panel2.Controls.Add(this.tex登録件数);
			this.panel2.Controls.Add(this.lab個数合計);
			this.panel2.Controls.Add(this.lab重量合計);
			this.panel2.Location = new System.Drawing.Point(0, 6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(764, 344);
			this.panel2.TabIndex = 1;
			// 
			// texエントリ計
			// 
			this.texエントリ計.BackColor = System.Drawing.SystemColors.Window;
			this.texエントリ計.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texエントリ計.Location = new System.Drawing.Point(332, 6);
			this.texエントリ計.Name = "texエントリ計";
			this.texエントリ計.ReadOnly = true;
			this.texエントリ計.Size = new System.Drawing.Size(86, 23);
			this.texエントリ計.TabIndex = 57;
			this.texエントリ計.TabStop = false;
			this.texエントリ計.Text = "";
			this.texエントリ計.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labエントリ重量計
			// 
			this.labエントリ重量計.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.labエントリ重量計.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labエントリ重量計.ForeColor = System.Drawing.Color.Blue;
			this.labエントリ重量計.Location = new System.Drawing.Point(284, 8);
			this.labエントリ重量計.Name = "labエントリ重量計";
			this.labエントリ重量計.Size = new System.Drawing.Size(48, 18);
			this.labエントリ重量計.TabIndex = 56;
			this.labエントリ重量計.Text = "ｴﾝﾄﾘ計";
			this.labエントリ重量計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(564, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(198, 28);
			this.label5.TabIndex = 55;
			this.label5.Text = "※運賃については原票登録データをベースにしております。";
			// 
			// axGT出荷一覧
			// 
			this.axGT出荷一覧.ContainingControl = this;
			this.axGT出荷一覧.DataSource = null;
			this.axGT出荷一覧.Location = new System.Drawing.Point(28, 32);
			this.axGT出荷一覧.Name = "axGT出荷一覧";
			this.axGT出荷一覧.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT出荷一覧.OcxState")));
			this.axGT出荷一覧.Size = new System.Drawing.Size(732, 308);
			this.axGT出荷一覧.TabIndex = 51;
			this.axGT出荷一覧.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT出荷一覧_KeyDownEvent);
			this.axGT出荷一覧.CelClick += new AxGTABLE32V2Lib._DGTable32Events_CelClickEventHandler(this.axGT出荷一覧_CelClick);
			this.axGT出荷一覧.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT出荷一覧_CelDblClick);
			this.axGT出荷一覧.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT出荷一覧_CurPlaceChanged);
			// 
			// tex重量合計
			// 
			this.tex重量合計.BackColor = System.Drawing.SystemColors.Window;
			this.tex重量合計.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex重量合計.Location = new System.Drawing.Point(472, 6);
			this.tex重量合計.Name = "tex重量合計";
			this.tex重量合計.ReadOnly = true;
			this.tex重量合計.Size = new System.Drawing.Size(86, 23);
			this.tex重量合計.TabIndex = 50;
			this.tex重量合計.TabStop = false;
			this.tex重量合計.Text = "";
			this.tex重量合計.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tex個数合計
			// 
			this.tex個数合計.BackColor = System.Drawing.SystemColors.Window;
			this.tex個数合計.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex個数合計.Location = new System.Drawing.Point(206, 6);
			this.tex個数合計.Name = "tex個数合計";
			this.tex個数合計.ReadOnly = true;
			this.tex個数合計.Size = new System.Drawing.Size(70, 23);
			this.tex個数合計.TabIndex = 49;
			this.tex個数合計.TabStop = false;
			this.tex個数合計.Text = "";
			this.tex個数合計.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label21.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.White;
			this.label21.Location = new System.Drawing.Point(0, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(22, 346);
			this.label21.TabIndex = 3;
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab登録件数
			// 
			this.lab登録件数.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab登録件数.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab登録件数.ForeColor = System.Drawing.Color.Blue;
			this.lab登録件数.Location = new System.Drawing.Point(62, 8);
			this.lab登録件数.Name = "lab登録件数";
			this.lab登録件数.Size = new System.Drawing.Size(34, 18);
			this.lab登録件数.TabIndex = 4;
			this.lab登録件数.Text = "件数";
			this.lab登録件数.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tex登録件数
			// 
			this.tex登録件数.BackColor = System.Drawing.SystemColors.Window;
			this.tex登録件数.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex登録件数.Location = new System.Drawing.Point(96, 6);
			this.tex登録件数.Name = "tex登録件数";
			this.tex登録件数.ReadOnly = true;
			this.tex登録件数.Size = new System.Drawing.Size(54, 23);
			this.tex登録件数.TabIndex = 46;
			this.tex登録件数.TabStop = false;
			this.tex登録件数.Text = "";
			this.tex登録件数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lab個数合計
			// 
			this.lab個数合計.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab個数合計.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab個数合計.ForeColor = System.Drawing.Color.Blue;
			this.lab個数合計.Location = new System.Drawing.Point(160, 8);
			this.lab個数合計.Name = "lab個数合計";
			this.lab個数合計.Size = new System.Drawing.Size(46, 18);
			this.lab個数合計.TabIndex = 6;
			this.lab個数合計.Text = "個数計";
			this.lab個数合計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab重量合計
			// 
			this.lab重量合計.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab重量合計.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab重量合計.ForeColor = System.Drawing.Color.Blue;
			this.lab重量合計.Location = new System.Drawing.Point(426, 8);
			this.lab重量合計.Name = "lab重量合計";
			this.lab重量合計.Size = new System.Drawing.Size(46, 18);
			this.lab重量合計.TabIndex = 8;
			this.lab重量合計.Text = "重量計";
			this.lab重量合計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab依頼主
			// 
			this.lab依頼主.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab依頼主.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab依頼主.Location = new System.Drawing.Point(12, 30);
			this.lab依頼主.Name = "lab依頼主";
			this.lab依頼主.Size = new System.Drawing.Size(82, 16);
			this.lab依頼主.TabIndex = 8;
			this.lab依頼主.Text = "ご依頼主";
			// 
			// btn依頼主検索
			// 
			this.btn依頼主検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btn依頼主検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn依頼主検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn依頼主検索.ForeColor = System.Drawing.Color.White;
			this.btn依頼主検索.Location = new System.Drawing.Point(200, 26);
			this.btn依頼主検索.Name = "btn依頼主検索";
			this.btn依頼主検索.Size = new System.Drawing.Size(48, 22);
			this.btn依頼主検索.TabIndex = 3;
			this.btn依頼主検索.TabStop = false;
			this.btn依頼主検索.Text = "検索";
			this.btn依頼主検索.Click += new System.EventHandler(this.btn依頼主検索_Click);
			// 
			// tex依頼主コード
			// 
			this.tex依頼主コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex依頼主コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex依頼主コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex依頼主コード.Location = new System.Drawing.Point(94, 26);
			this.tex依頼主コード.MaxLength = 12;
			this.tex依頼主コード.Name = "tex依頼主コード";
			this.tex依頼主コード.Size = new System.Drawing.Size(102, 23);
			this.tex依頼主コード.TabIndex = 2;
			this.tex依頼主コード.Text = "123456789012";
			this.tex依頼主コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex依頼主コード_KeyDown);
			this.tex依頼主コード.LostFocus += new System.EventHandler(this.tex依頼主コード_LostFocus);
			this.tex依頼主コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex依頼主コード_KeyPress);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Honeydew;
			this.panel5.Controls.Add(this.cBox配完Ｓ出力);
			this.panel5.Controls.Add(this.lab出荷日範囲);
			this.panel5.Controls.Add(this.cb運用中のお客様のみ);
			this.panel5.Controls.Add(this.tex店所);
			this.panel5.Controls.Add(this.lab店所);
			this.panel5.Controls.Add(this.cmb削除区分);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.texお客様名);
			this.panel5.Controls.Add(this.btnお客様検索);
			this.panel5.Controls.Add(this.texお客様コード);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.tex送り状番号);
			this.panel5.Controls.Add(this.lab送り状番号);
			this.panel5.Controls.Add(this.cmb状態);
			this.panel5.Controls.Add(this.lab状態);
			this.panel5.Controls.Add(this.cmb出荷日);
			this.panel5.Controls.Add(this.btn出荷検索);
			this.panel5.Controls.Add(this.tex依頼主名);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.dt開始日付);
			this.panel5.Controls.Add(this.lab依頼主);
			this.panel5.Controls.Add(this.tex依頼主コード);
			this.panel5.Controls.Add(this.btn依頼主検索);
			this.panel5.Controls.Add(this.dt終了日付);
			this.panel5.Location = new System.Drawing.Point(2, 8);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(762, 102);
			this.panel5.TabIndex = 0;
			// 
			// cBox配完Ｓ出力
			// 
			this.cBox配完Ｓ出力.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBox配完Ｓ出力.ForeColor = System.Drawing.Color.LimeGreen;
			this.cBox配完Ｓ出力.Location = new System.Drawing.Point(584, 42);
			this.cBox配完Ｓ出力.Name = "cBox配完Ｓ出力";
			this.cBox配完Ｓ出力.Size = new System.Drawing.Size(162, 16);
			this.cBox配完Ｓ出力.TabIndex = 60;
			this.cBox配完Ｓ出力.Text = "配完日付・時刻をCSV出力";
			// 
			// lab出荷日範囲
			// 
			this.lab出荷日範囲.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab出荷日範囲.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab出荷日範囲.Location = new System.Drawing.Point(644, 60);
			this.lab出荷日範囲.Name = "lab出荷日範囲";
			this.lab出荷日範囲.Size = new System.Drawing.Size(116, 40);
			this.lab出荷日範囲.TabIndex = 59;
			this.lab出荷日範囲.Text = "※過去１年間の出荷データを照会可能です。";
			// 
			// cb運用中のお客様のみ
			// 
			this.cb運用中のお客様のみ.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cb運用中のお客様のみ.ForeColor = System.Drawing.Color.LimeGreen;
			this.cb運用中のお客様のみ.Location = new System.Drawing.Point(584, 24);
			this.cb運用中のお客様のみ.Name = "cb運用中のお客様のみ";
			this.cb運用中のお客様のみ.Size = new System.Drawing.Size(152, 16);
			this.cb運用中のお客様のみ.TabIndex = 58;
			this.cb運用中のお客様のみ.Text = "運用中のお客様のみ対象";
			// 
			// tex店所
			// 
			this.tex店所.BackColor = System.Drawing.SystemColors.Window;
			this.tex店所.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex店所.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.tex店所.Location = new System.Drawing.Point(630, 0);
			this.tex店所.MaxLength = 3;
			this.tex店所.Name = "tex店所";
			this.tex店所.Size = new System.Drawing.Size(36, 23);
			this.tex店所.TabIndex = 57;
			this.tex店所.Text = "123";
			// 
			// lab店所
			// 
			this.lab店所.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab店所.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab店所.Location = new System.Drawing.Point(584, 4);
			this.lab店所.Name = "lab店所";
			this.lab店所.Size = new System.Drawing.Size(46, 16);
			this.lab店所.TabIndex = 56;
			this.lab店所.Text = "店所";
			// 
			// cmb削除区分
			// 
			this.cmb削除区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb削除区分.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cmb削除区分.Items.AddRange(new object[] {
														 "全て",
														 "削除",
														 "出荷分"});
			this.cmb削除区分.Location = new System.Drawing.Point(482, 78);
			this.cmb削除区分.Name = "cmb削除区分";
			this.cmb削除区分.Size = new System.Drawing.Size(76, 24);
			this.cmb削除区分.TabIndex = 55;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(200, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(190, 28);
			this.label4.TabIndex = 54;
			this.label4.Text = "※送り状番号を入力した場合は、上記の検索条件は無視されます。";
			// 
			// texお客様名
			// 
			this.texお客様名.BackColor = System.Drawing.Color.Honeydew;
			this.texお客様名.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.texお客様名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texお客様名.Location = new System.Drawing.Point(252, 4);
			this.texお客様名.Name = "texお客様名";
			this.texお客様名.ReadOnly = true;
			this.texお客様名.Size = new System.Drawing.Size(322, 16);
			this.texお客様名.TabIndex = 53;
			this.texお客様名.TabStop = false;
			this.texお客様名.Text = "国国国国王国国国国王国国国国王国国国国王";
			// 
			// btnお客様検索
			// 
			this.btnお客様検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btnお客様検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnお客様検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnお客様検索.ForeColor = System.Drawing.Color.White;
			this.btnお客様検索.Location = new System.Drawing.Point(200, 0);
			this.btnお客様検索.Name = "btnお客様検索";
			this.btnお客様検索.Size = new System.Drawing.Size(48, 22);
			this.btnお客様検索.TabIndex = 52;
			this.btnお客様検索.TabStop = false;
			this.btnお客様検索.Text = "検索";
			this.btnお客様検索.Click += new System.EventHandler(this.btnお客様検索_Click);
			// 
			// texお客様コード
			// 
			this.texお客様コード.BackColor = System.Drawing.SystemColors.Window;
			this.texお客様コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texお客様コード.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.texお客様コード.Location = new System.Drawing.Point(94, 0);
			this.texお客様コード.MaxLength = 10;
			this.texお客様コード.Name = "texお客様コード";
			this.texお客様コード.Size = new System.Drawing.Size(102, 23);
			this.texお客様コード.TabIndex = 1;
			this.texお客様コード.Text = "1234567890";
			this.texお客様コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texお客様コード_KeyDown);
			this.texお客様コード.LostFocus += new System.EventHandler(this.texお客様コード_LostFocus);
			this.texお客様コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texお客様コード_KeyPress);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label3.ForeColor = System.Drawing.Color.LimeGreen;
			this.label3.Location = new System.Drawing.Point(12, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 51;
			this.label3.Text = "お客様";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.LimeGreen;
			this.label2.Location = new System.Drawing.Point(406, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "状態";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tex送り状番号
			// 
			this.tex送り状番号.BackColor = System.Drawing.SystemColors.Window;
			this.tex送り状番号.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex送り状番号.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex送り状番号.Location = new System.Drawing.Point(94, 78);
			this.tex送り状番号.MaxLength = 11;
			this.tex送り状番号.Multiline = true;
			this.tex送り状番号.Name = "tex送り状番号";
			this.tex送り状番号.Size = new System.Drawing.Size(102, 23);
			this.tex送り状番号.TabIndex = 15;
			this.tex送り状番号.Text = "12345678901";
			// 
			// lab送り状番号
			// 
			this.lab送り状番号.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab送り状番号.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab送り状番号.Location = new System.Drawing.Point(12, 82);
			this.lab送り状番号.Name = "lab送り状番号";
			this.lab送り状番号.Size = new System.Drawing.Size(82, 16);
			this.lab送り状番号.TabIndex = 14;
			this.lab送り状番号.Text = "送り状番号";
			// 
			// cmb状態
			// 
			this.cmb状態.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb状態.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cmb状態.Location = new System.Drawing.Point(482, 52);
			this.cmb状態.Name = "cmb状態";
			this.cmb状態.Size = new System.Drawing.Size(76, 24);
			this.cmb状態.TabIndex = 6;
			this.cmb状態.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb状態_KeyDown);
			// 
			// lab状態
			// 
			this.lab状態.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab状態.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab状態.Location = new System.Drawing.Point(406, 56);
			this.lab状態.Name = "lab状態";
			this.lab状態.Size = new System.Drawing.Size(76, 16);
			this.lab状態.TabIndex = 13;
			this.lab状態.Text = "輸送状況";
			// 
			// cmb出荷日
			// 
			this.cmb出荷日.BackColor = System.Drawing.Color.White;
			this.cmb出荷日.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb出荷日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cmb出荷日.ForeColor = System.Drawing.Color.LimeGreen;
			this.cmb出荷日.Items.AddRange(new object[] {
														"出荷日",
														"登録日"});
			this.cmb出荷日.Location = new System.Drawing.Point(12, 52);
			this.cmb出荷日.Name = "cmb出荷日";
			this.cmb出荷日.Size = new System.Drawing.Size(80, 24);
			this.cmb出荷日.TabIndex = 4;
			// 
			// btn出荷検索
			// 
			this.btn出荷検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btn出荷検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn出荷検索.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn出荷検索.ForeColor = System.Drawing.Color.White;
			this.btn出荷検索.Location = new System.Drawing.Point(564, 60);
			this.btn出荷検索.Name = "btn出荷検索";
			this.btn出荷検索.Size = new System.Drawing.Size(74, 36);
			this.btn出荷検索.TabIndex = 7;
			this.btn出荷検索.TabStop = false;
			this.btn出荷検索.Text = "照会";
			this.btn出荷検索.Click += new System.EventHandler(this.btn出荷検索_Click);
			// 
			// tex依頼主名
			// 
			this.tex依頼主名.BackColor = System.Drawing.Color.Honeydew;
			this.tex依頼主名.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex依頼主名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex依頼主名.Location = new System.Drawing.Point(252, 30);
			this.tex依頼主名.Name = "tex依頼主名";
			this.tex依頼主名.ReadOnly = true;
			this.tex依頼主名.Size = new System.Drawing.Size(322, 16);
			this.tex依頼主名.TabIndex = 12;
			this.tex依頼主名.TabStop = false;
			this.tex依頼主名.Text = "国国国国王国国国国王国国国国王国国国国王";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.LimeGreen;
			this.label1.Location = new System.Drawing.Point(240, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "～";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dt開始日付
			// 
			this.dt開始日付.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt開始日付.Location = new System.Drawing.Point(94, 52);
			this.dt開始日付.Name = "dt開始日付";
			this.dt開始日付.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt開始日付.Size = new System.Drawing.Size(144, 23);
			this.dt開始日付.TabIndex = 4;
			// 
			// dt終了日付
			// 
			this.dt終了日付.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt終了日付.Location = new System.Drawing.Point(260, 52);
			this.dt終了日付.Name = "dt終了日付";
			this.dt終了日付.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt終了日付.Size = new System.Drawing.Size(144, 23);
			this.dt終了日付.TabIndex = 5;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Controls.Add(this.tex認証利用者名);
			this.panel6.Controls.Add(this.labお客様);
			this.panel6.Controls.Add(this.labお客様名);
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
			this.tex認証利用者名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex認証利用者名.ForeColor = System.Drawing.Color.LimeGreen;
			this.tex認証利用者名.Location = new System.Drawing.Point(470, 5);
			this.tex認証利用者名.Name = "tex認証利用者名";
			this.tex認証利用者名.ReadOnly = true;
			this.tex認証利用者名.Size = new System.Drawing.Size(322, 16);
			this.tex認証利用者名.TabIndex = 12;
			this.tex認証利用者名.TabStop = false;
			this.tex認証利用者名.Text = "国国国国国国国国国国王王王王王王王王王王";
			this.tex認証利用者名.Visible = false;
			// 
			// labお客様
			// 
			this.labお客様.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labお客様.ForeColor = System.Drawing.Color.LimeGreen;
			this.labお客様.Location = new System.Drawing.Point(418, 7);
			this.labお客様.Name = "labお客様";
			this.labお客様.Size = new System.Drawing.Size(52, 14);
			this.labお客様.TabIndex = 11;
			this.labお客様.Text = "ユーザー";
			this.labお客様.Visible = false;
			// 
			// labお客様名
			// 
			this.labお客様名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labお客様名.ForeColor = System.Drawing.Color.LimeGreen;
			this.labお客様名.Location = new System.Drawing.Point(14, 8);
			this.labお客様名.Name = "labお客様名";
			this.labお客様名.Size = new System.Drawing.Size(58, 14);
			this.labお客様名.TabIndex = 10;
			this.labお客様名.Text = "お客様名";
			// 
			// tex認証会員名
			// 
			this.tex認証会員名.BackColor = System.Drawing.Color.PaleGreen;
			this.tex認証会員名.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex認証会員名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex認証会員名.ForeColor = System.Drawing.Color.LimeGreen;
			this.tex認証会員名.Location = new System.Drawing.Point(78, 6);
			this.tex認証会員名.Name = "tex認証会員名";
			this.tex認証会員名.ReadOnly = true;
			this.tex認証会員名.Size = new System.Drawing.Size(330, 16);
			this.tex認証会員名.TabIndex = 8;
			this.tex認証会員名.TabStop = false;
			this.tex認証会員名.Text = "999 ○○支店";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab日時);
			this.panel7.Controls.Add(this.lab出荷照会タイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(792, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab日時
			// 
			this.lab日時.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab日時.ForeColor = System.Drawing.Color.White;
			this.lab日時.Location = new System.Drawing.Point(674, 8);
			this.lab日時.Name = "lab日時";
			this.lab日時.Size = new System.Drawing.Size(112, 14);
			this.lab日時.TabIndex = 1;
			this.lab日時.Text = "2005/xx/xx 12:00:00";
			// 
			// lab出荷照会タイトル
			// 
			this.lab出荷照会タイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab出荷照会タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab出荷照会タイトル.ForeColor = System.Drawing.Color.White;
			this.lab出荷照会タイトル.Location = new System.Drawing.Point(12, 2);
			this.lab出荷照会タイトル.Name = "lab出荷照会タイトル";
			this.lab出荷照会タイトル.Size = new System.Drawing.Size(264, 24);
			this.lab出荷照会タイトル.TabIndex = 0;
			this.lab出荷照会タイトル.Text = "出荷照会";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btnラベルイメージ印刷);
			this.panel8.Controls.Add(this.btn実績表印刷);
			this.panel8.Controls.Add(this.btnＣＳＶ出力);
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 2;
			// 
			// btnラベルイメージ印刷
			// 
			this.btnラベルイメージ印刷.ForeColor = System.Drawing.Color.Blue;
			this.btnラベルイメージ印刷.Location = new System.Drawing.Point(260, 6);
			this.btnラベルイメージ印刷.Name = "btnラベルイメージ印刷";
			this.btnラベルイメージ印刷.Size = new System.Drawing.Size(60, 48);
			this.btnラベルイメージ印刷.TabIndex = 8;
			this.btnラベルイメージ印刷.Text = "イメージ　　印刷";
			this.btnラベルイメージ印刷.Click += new System.EventHandler(this.btnラベルイメージ印刷_Click);
			// 
			// btn実績表印刷
			// 
			this.btn実績表印刷.ForeColor = System.Drawing.Color.Blue;
			this.btn実績表印刷.Location = new System.Drawing.Point(168, 6);
			this.btn実績表印刷.Name = "btn実績表印刷";
			this.btn実績表印刷.Size = new System.Drawing.Size(60, 48);
			this.btn実績表印刷.TabIndex = 7;
			this.btn実績表印刷.Text = "実績表　　印刷";
			this.btn実績表印刷.Click += new System.EventHandler(this.btn実績表印刷_Click);
			// 
			// btnＣＳＶ出力
			// 
			this.btnＣＳＶ出力.ForeColor = System.Drawing.Color.Blue;
			this.btnＣＳＶ出力.Location = new System.Drawing.Point(352, 6);
			this.btnＣＳＶ出力.Name = "btnＣＳＶ出力";
			this.btnＣＳＶ出力.Size = new System.Drawing.Size(60, 48);
			this.btnＣＳＶ出力.TabIndex = 6;
			this.btnＣＳＶ出力.Text = "ＣＳＶ　　出力";
			this.btnＣＳＶ出力.Click += new System.EventHandler(this.btnＣＳＶ出力_Click);
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(446, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(344, 50);
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
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.groupBox1.ForeColor = System.Drawing.Color.Green;
			this.groupBox1.Location = new System.Drawing.Point(16, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(768, 114);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel2);
			this.groupBox2.Location = new System.Drawing.Point(16, 162);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(768, 352);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// 出荷照会
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(792, 580);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "出荷照会";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 出荷照会";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.出荷照会_Closed);
			((System.ComponentModel.ISupportInitialize)(this.ds送り状)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axGT出荷一覧)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// ヘッダー項目の設定
			tex認証会員名.Text = gs会員名;
			tex認証利用者名.Text = gs利用者名;
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
			cb運用中のお客様のみ.Checked = true;
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END

			// 日時の初期設定
			lab日時.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;
			// コンボの初期値設定
			cmb出荷日.SelectedIndex = 0;
			cmb状態.Items.Clear();
			cmb状態.Items.AddRange(gsa状態名);
			cmb状態.SelectedIndex = 0;

			// 出荷日の初期設定（当日）
			dt開始日付.Value   = DateTime.Now;
			dt終了日付.Value   = DateTime.Now;
//			部門出荷日情報更新();
//			dt開始日付.Value   = gdt出荷日;
//			dt終了日付.Value   = gdt出荷日;

// MOD 2009.05.11 東都）高木 未出荷対応 START
			// 管理者会員の場合、店所ＣＤを選択可に
			if(gs管理者区分.Equals("1")){
				lab店所.Visible = true;
				tex店所.Visible = true;
			}else{
				lab店所.Visible = false;
				tex店所.Visible = false;
			}
			tex店所.Text = gs店所コード;
// MOD 2009.05.11 東都）高木 未出荷対応 END
// MOD 2014.03.20 BEVAS）高杉 ＣＳＶ出力に配完日付・時刻を追加 START
			cBox配完Ｓ出力.Visible = true;
			cBox配完Ｓ出力.Checked = false;
// MOD 2014.03.20 BEVAS）高杉 ＣＳＶ出力に配完日付・時刻を追加 END
// MOD 2007.06.12 東都）高木 宇都宮などの対応 START
			項目初期化();

// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 START
			// 初期表示の場合、ラベルイメージ印刷ボタンは利用不可
			btnラベルイメージ印刷.Enabled = false;
// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 END

// MOD 2009.09.11 東都）高木 出荷照会で出荷済ＦＧ,送信済ＦＧなどを追加 START
//// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START
////			axGT出荷一覧.Cols = 16;
//			axGT出荷一覧.Cols = 18;
//// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END
// MOD 2010.04.06 東都）高木 出荷照会に得意先、郵便番号などを追加 START
//			axGT出荷一覧.Cols = 24;
// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 START
//			axGT出荷一覧.Cols = 34;
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
//			axGT出荷一覧.Cols = 38;
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 START
//			axGT出荷一覧.Cols = 39;
			axGT出荷一覧.Cols = 40;
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 END
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 END
// MOD 2010.04.06 東都）高木 出荷照会に得意先、郵便番号などを追加 END
// MOD 2009.09.11 東都）高木 出荷照会で出荷済ＦＧ,送信済ＦＧなどを追加 END
// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 START

// MOD 2007.01.11 東都）高木 行数を10行にする START
//			axGT出荷一覧.Rows = 7;
			axGT出荷一覧.Rows = 10;
// MOD 2007.01.11 東都）高木 行数を10行にする END
			axGT出荷一覧.ColSep = "|";

// MOD 2009.09.11 東都）高木 出荷照会で出荷済ＦＧ,送信済ＦＧなどを追加 START
//// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START
////			axGT出荷一覧.set_RowsText(0, "|出荷日|お届け先|個数|重量|保険料（万円）|運賃（万円）|輸送商品／記事・品名|送り状番号|指定日|輸送状況|登録日|お客様番号|ジャーナルＮＯ|日|出日|登録者|");//
////			axGT出荷一覧.ColsWidth =    "0|4|17|4|4.5|6|6|12|7|6|6.5|5|17|0|0|0|0|";
////			axGT出荷一覧.ColsAlignHorz = "1|1|0|2|2|2|2|0|0|1|1|1|0|0|0|0|0|";
//			axGT出荷一覧.set_RowsText(0, "||ﾗﾍﾞﾙ|出荷日|お届け先|個数|重量|送り状番号|お客様番号|指定日|輸送状況|輸送商品／記事・品名|運賃|保険料|登録日|ジャーナルＮＯ|日|出日|登録者|");
////			axGT出荷一覧.ColsWidth =    "0|1.4|1.4|4|17|4|4.5|7|17|6|6.5|12|6|6|5|0|0|0|0|";
////			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.2|3|3.6|6.5|8.5|5.3|4.8|12.8|6|6|5|0|0|0|0|";
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|";
//			axGT出荷一覧.ColsAlignHorz = "1|1|1|1|0|2|2|0|0|1|1|0|2|2|1|0|0|0|0|";
//// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END
// MOD 2010.04.06 東都）高木 出荷照会に得意先、郵便番号などを追加 START
//			axGT出荷一覧.set_RowsText(0, "||ﾗﾍﾞﾙ|出荷日|お届け先|個数|重量|送り状番号|お客様番号|指定日|輸送状況|輸送商品／記事・品名|運賃|保険料|登録日|ジャーナルＮＯ|日|出日|登録者|||||||");
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|";
//			axGT出荷一覧.ColsAlignHorz = "1|1|1|1|0|2|2|0|0|1|1|0|2|2|1|0|0|0|0|0|0|0|0|0|0|";
// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 START
//			axGT出荷一覧.set_RowsText(0, "||ﾗﾍﾞﾙ|出荷日|お届け先|個数|重量|送り状番号|お客様番号|指定日|輸送状況|輸送商品／記事・品名|運賃|保険料|登録日|ジャーナルＮＯ|日|出日|登録者|||||||||||||||||");
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
//			axGT出荷一覧.ColsAlignHorz = "1|1|1|1|0|2|2|0|0|1|1|0|2|2|1|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
//			axGT出荷一覧.set_RowsText(0, "||ﾗﾍﾞﾙ|出荷日|お届け先|個数|重量|送り状番号|お客様番号|指定日|輸送状況|"
//										+"輸送商品／記事・品名|運賃|保険料|登録日|"
//										+"ジャーナルＮＯ|日|出日|登録者|||||||||||||||||||||");
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
//			axGT出荷一覧.ColsAlignHorz = "1|1|1|1|0|2|2|0|0|1|1|"
//										+"0|2|2|1|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 START
//			axGT出荷一覧.set_RowsText(0, "||ﾗﾍﾞﾙ|出荷日|お届け先|個数|ｴﾝﾄﾘ|重量|送り状番号|お客様番号|指定日|輸送状況|"
//										+"輸送商品／記事・品名|運賃|保険料|登録日|"
//										+"ジャーナルＮＯ|日|出日|登録者|||||||||||||||||||||");
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
//			axGT出荷一覧.ColsAlignHorz = "1|1|1|1|0|2|2|2|0|0|1|1|"
//										+"0|2|2|1|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
			axGT出荷一覧.set_RowsText(0, "||ﾗﾍﾞﾙ|出荷日|お届け先|個数|ｴﾝﾄﾘ|重量|送り状番号|お客様番号|指定日|輸送状況|"
										+"配完日付・時刻|輸送商品／記事・品名|運賃|保険料|登録日|"
										+"ジャーナルＮＯ|日|出日|登録者|||||||||||||||||||||");
			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
										+"8.0|13.0|5.7|5.7|3.8|"
										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
			axGT出荷一覧.ColsAlignHorz = "1|1|1|1|0|2|2|2|0|0|1|1|"
										+"1|0|2|2|1|"
										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 END
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 END
// MOD 2010.04.06 東都）高木 出荷照会に得意先、郵便番号などを追加 END
// MOD 2009.09.11 東都）高木 出荷照会で出荷済ＦＧ,送信済ＦＧなどを追加 END
// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 START
// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 END

			axGT出荷一覧.set_CelForeColor(axGT出荷一覧.CaretRow,0,0x98FB98);  //BGR
			axGT出荷一覧.set_CelBackColor(axGT出荷一覧.CaretRow,0,0x006000);

			for(short i = 1; i <= axGT出荷一覧.Rows; i++ )
			{
				axGT出荷一覧.set_CelHeight(i,0,2.3);
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START
//				axGT出荷一覧.set_CelAlignVert(i,2,3);
//				axGT出荷一覧.set_CelAlignVert(i,7,3);
//				axGT出荷一覧.set_CelAlignVert(i,8,3);
				axGT出荷一覧.set_CelAlignVert(i,4,3);
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
//				axGT出荷一覧.set_CelAlignVert(i,7,3);
//				axGT出荷一覧.set_CelAlignVert(i,11,3);
				axGT出荷一覧.set_CelAlignVert(i,8,3);
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 START
//				axGT出荷一覧.set_CelAlignVert(i,12,3);
				axGT出荷一覧.set_CelAlignVert(i,13,3);
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 END
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END
			}

			s部門ＣＤ = "";
			s依頼主ＣＤ = "";
			s依頼主名 = "";
		}

		private void 項目初期化()
		{
			texお客様コード.Text = "";
			texお客様名.Text     = "";
			tex依頼主コード.Text = "";
			tex依頼主名.Text     = "";
			tex送り状番号.Text   = "";
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START
//			rb出荷分.Checked = true;
// MOD 2007.01.22 東都）高木 デフォルト値の変更 START
//			cmb削除区分.SelectedIndex = 2;
			cmb削除区分.SelectedIndex = 0;
// MOD 2007.01.22 東都）高木 デフォルト値の変更 END
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END
			tex登録件数.Text     = "";
			tex個数合計.Text     = "";
			tex重量合計.Text     = "";
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
			texエントリ計.Text = "";
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END

			texメッセージ.Text   = "";
			axGT出荷一覧.Clear();
// MOD 2009.09.11 東都）高木 出荷照会で出荷済ＦＧ,送信済ＦＧなどを追加 START
//// ADD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START
////			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.2|3|3.6|6.5|8.5|5.3|4.8|12.8|6|6|5|0|0|0|0|";
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|";
//// ADD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END
// MOD 2010.04.06 東都）高木 出荷照会に得意先、郵便番号などを追加 START
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|";
// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 END
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 START
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
										+"8.0|13.0|5.7|5.7|3.8|"
										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 END
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 END
// MOD 2010.04.06 東都）高木 出荷照会に得意先、郵便番号などを追加 END
// MOD 2009.09.11 東都）高木 出荷照会で出荷済ＦＧ,送信済ＦＧなどを追加 END
			axGT出荷一覧.CaretRow = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT出荷一覧.CaretCol = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
			axGT出荷一覧_CurPlaceChanged(null,null);

//			桁数表示();
		}

// ADD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START
		private void 桁数表示()
		{
			texお客様コード.Text = "1234567890";
//			texお客様名.Text     = "国国国国王国国国国王国国国国王国国国国王";
			texお客様名.Text     = "お客様名５６７８９０１２３４５６７８９０";
			tex依頼主コード.Text = "123456789012";
//			tex依頼主名.Text     = "国国国国王国国国国王国国国国王国国国国王";
			tex依頼主名.Text     = "ご依頼主名６７８９０１２３４５６７８９０";
			tex送り状番号.Text   = "12345678901";
			tex登録件数.Text     = "5,000";
			tex個数合計.Text     = "999,999";
			tex重量合計.Text     = "99,999,999";
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
			texエントリ計.Text = "99,999,999";
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END

			axGT出荷一覧.Clear();
			axGT出荷一覧.set_RowsText(1,
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 START
//			 "|削|済|10/25|お届け先住所１＿９０１２３４５６７８９０\r\nお届け先名前１＿９０１２３４５６７８９０|999|99,999|12345678901\r\n元払|OKYAKU789012345|10/27必着|未発行|１０ＥＸＰＲＥＳＳ\r\n記事１＿５６７８９０１２３４５|9,999|0|01/16|J1|1|20061025|test|");
			 "|削|済|10/25|お届け先住所１＿９０１２３４５６７８９０\r\nお届け先名前１＿９０１２３４５６７８９０|999|99,999|12345678901\r\n元払|OKYAKU789012345|10/27必着|未発行|2014/10/27 13:00|１０ＥＸＰＲＥＳＳ\r\n記事１＿５６７８９０１２３４５|9,999|0|01/16|J1|1|20061025|test|");
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 END
//			axGT出荷一覧.set_RowsText(2,
//			 "|削|済|10/25|国国国国王国国国国王国国国国王国国国国王\r\n国国国国王国国国国王国国国国王国国国国王|999|99,999|12345678901\r\n元払|OKYAKU789012345|10/27必着|未発行|１０ＥＸＰＲＥＳＳ\r\n記事１＿５６７８９０１２３４５|9,999|0|01/16|J1|1|20061025|test|");
		}
// ADD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn依頼主検索_Click(object sender, System.EventArgs e)
		{
// ADD 2007.01.25 東都）高木 お客様コードチェックの追加 START
			texお客様コード.Text = texお客様コード.Text.Trim();
			if(!必須チェック(texお客様コード,"お客様コード")) return;
			if(!半角チェック(texお客様コード,"お客様コード")) return;
// ADD 2007.01.25 東都）高木 お客様コードチェックの追加 END

// MOD 2009.05.11 東都）高木 未出荷対応 START
			tex店所.Text = tex店所.Text.Trim();
			if(!gs管理者区分.Equals("1")){
				if(!必須チェック(tex店所,"店所コード")) return;
			}
// MOD 2009.05.11 東都）高木 未出荷対応 END

			tex依頼主コード.Text = tex依頼主コード.Text.Trim();
			if(!半角チェック(tex依頼主コード,"依頼主コード")) return;

// MOD 2007.11.14 KCL) 森本 global対応 START
//			if (g依頼検索 == null)	 g依頼検索 = new ご依頼主検索();
//			g依頼検索.Left = this.Left;
//			g依頼検索.Top = this.Top;
//
//			g依頼検索.sKcode = texお客様コード.Text;
//			g依頼検索.sIcode = tex依頼主コード.Text;
//			g依頼検索.ShowDialog();
//
//			if(g依頼検索.sIcode.Trim().Length != 0)
//			{
//				texお客様コード.Text = g依頼検索.sKcode;
//				texお客様名.Text = g依頼検索.sKname;
//				s部門ＣＤ   = g依頼検索.sBcode;
//				s依頼主ＣＤ = g依頼検索.sIcode;
//				s依頼主名   = g依頼検索.sIname;
			if (g依頼検２ == null)	 g依頼検２ = new ご依頼主検索２();
			g依頼検２.Left = this.Left;
			g依頼検２.Top = this.Top;

			g依頼検２.sKcode = texお客様コード.Text;
			g依頼検２.sIcode = tex依頼主コード.Text;
// MOD 2009.05.11 東都）高木 未出荷対応 START
			g依頼検２.s店所コード = tex店所.Text;
// MOD 2009.05.11 東都）高木 未出荷対応 END
			g依頼検２.ShowDialog();

			if(g依頼検２.sIcode.Trim().Length != 0)
			{
				texお客様コード.Text = g依頼検２.sKcode;
				texお客様名.Text = g依頼検２.sKname;
				s部門ＣＤ   = g依頼検２.sBcode;
				s依頼主ＣＤ = g依頼検２.sIcode;
				s依頼主名   = g依頼検２.sIname;
// MOD 2007.11.14 KCL) 森本 global対応 END
				if(s依頼主ＣＤ.Length != 0)
				{
					tex依頼主コード.Text = s依頼主ＣＤ;
					tex依頼主名.Text     = s依頼主名;
					cmb出荷日.Focus();
				}
				else
				{
					tex依頼主コード.Focus();
				}
			}
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			lab日時.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
		}

		private void axGT出荷一覧_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT出荷一覧.set_CelForeColor(OldRow,0,0);
			axGT出荷一覧.set_CelBackColor(OldRow,0,0xFFFFFF);
			if(axGT出荷一覧.SelStartRow == axGT出荷一覧.SelEndRow)
			{
				if(nSrow > nErow)
				{
					nWork = nSrow;
					nSrow = nErow;
					nErow = nWork;
				}
				for(short nCnt = nSrow; nCnt <= nErow; nCnt++)
				{
					axGT出荷一覧.set_CelForeColor(nCnt,0,0);
					axGT出荷一覧.set_CelBackColor(nCnt,0,0xFFFFFF);
				}
			}
			axGT出荷一覧.set_CelForeColor(axGT出荷一覧.SelStartRow,0,0x98FB98);
			axGT出荷一覧.set_CelBackColor(axGT出荷一覧.SelStartRow,0,0x006000);
			axGT出荷一覧.set_CelForeColor(axGT出荷一覧.SelEndRow,0,0x98FB98);
			axGT出荷一覧.set_CelBackColor(axGT出荷一覧.SelEndRow,0,0x006000);
			axGT出荷一覧.set_CelForeColor(axGT出荷一覧.CaretRow,0,0x98FB98);
			axGT出荷一覧.set_CelBackColor(axGT出荷一覧.CaretRow,0,0x006000);

			if(axGT出荷一覧.SelEndRow > axGT出荷一覧.CaretRow
				&& axGT出荷一覧.SelStartRow <= axGT出荷一覧.CaretRow
				&& axGT出荷一覧.get_CelForeColor(axGT出荷一覧.SelEndRow,0) != Color.Black)
			{
				axGT出荷一覧.set_CelForeColor(axGT出荷一覧.SelEndRow,0,0);
				axGT出荷一覧.set_CelBackColor(axGT出荷一覧.SelEndRow,0,0xFFFFFF);
			}

			if(axGT出荷一覧.SelEndRow < axGT出荷一覧.CaretRow
				&& axGT出荷一覧.SelStartRow >= axGT出荷一覧.CaretRow
				&& axGT出荷一覧.get_CelForeColor(axGT出荷一覧.SelEndRow,0) != Color.Black)
			{
				axGT出荷一覧.set_CelForeColor(axGT出荷一覧.SelEndRow,0,0);
				axGT出荷一覧.set_CelBackColor(axGT出荷一覧.SelEndRow,0,0xFFFFFF);
			}

			OldRow = axGT出荷一覧.CaretRow;
			nSrow  = axGT出荷一覧.SelStartRow;
			nErow  = axGT出荷一覧.SelEndRow;

		}

		private void axGT出荷一覧_CelClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelClickEvent e)
		{
			axGT出荷一覧_CurPlaceChanged(null,null);
			if(axGT出荷一覧.SelStartRow != axGT出荷一覧.SelEndRow)
			{
				if(nSrow > nErow)
				{
					nWork = nSrow;
					nSrow = nErow;
					nErow = nWork;
				}
				for(short nCnt = nSrow; nCnt <= nErow; nCnt++)
				{
					axGT出荷一覧.set_CelForeColor(nCnt,0,0x98FB98);
					axGT出荷一覧.set_CelBackColor(nCnt,0,0x006000);
				}
				for(int nCnt = int.Parse(nSrow.ToString()) - 1; nCnt >= 1; nCnt--)
				{
					axGT出荷一覧.set_CelForeColor(short.Parse(nCnt.ToString()),0,0);
					axGT出荷一覧.set_CelBackColor(short.Parse(nCnt.ToString()),0,0xFFFFFF);
				}
				for(int nCnt = int.Parse(nErow.ToString()) + 1; nCnt <= axGT出荷一覧.Rows; nCnt++)
				{
					axGT出荷一覧.set_CelForeColor(short.Parse(nCnt.ToString()),0,0);
					axGT出荷一覧.set_CelBackColor(short.Parse(nCnt.ToString()),0,0xFFFFFF);
				}
			}
		}

		private void btn出荷検索_Click(object sender, System.EventArgs e)
		{
// MOD 2011.05.20 東都）高木 出荷照会件数の上限解除の解除 START
//			string[] sData = new string[10];
			bool bAltKey   = ((GetAsyncKeyState(Keys.Menu) & 0x8000) == 0) ? false : true;
			string[] sData = new string[11];
			sData[10] = (bAltKey) ? "1" : "0";
// MOD 2011.05.20 東都）高木 出荷照会件数の上限解除の解除 END

			if(tex送り状番号.Text.Trim().Length != 0)
			{
				if(texお客様コード.Text.Length == 0)
				{
					texお客様名.Text = "";
				}
				if(tex依頼主コード.Text.Length == 0)
				{
					tex依頼主名.Text = "";
				}

				if(!半角チェック(tex送り状番号,"送り状番号")) return;
//				if(!数値チェック(tex送り状番号,"送り状番号")) return;
			}
			else
			{

				texお客様コード.Text = texお客様コード.Text.Trim();
				tex依頼主コード.Text = tex依頼主コード.Text.Trim();
				if(texお客様コード.Text.Length == 0)
				{
					texお客様名.Text = "";
				}
				if(tex依頼主コード.Text.Length == 0)
				{
					tex依頼主名.Text = "";
				}
// MOD 2009.05.11 東都）高木 未出荷対応 START
//				if(!必須チェック(texお客様コード,"お客様コード")) return;
				if(!gsa状態ＣＤ[cmb状態.SelectedIndex].Equals("90")){
					if(!必須チェック(texお客様コード,"お客様コード")) return;
				}
				tex店所.Text = tex店所.Text.Trim();
				if(!gs管理者区分.Equals("1")){
					if(!必須チェック(tex店所,"店所コード")) return;
				}
// MOD 2009.05.11 東都）高木 未出荷対応 END
				if(!半角チェック(texお客様コード,"お客様コード")) return;
// DEL 2007.01.11 東都）高木 依頼主の必須チェックの廃止 START
//				if(!必須チェック(tex依頼主コード,"依頼主コード")) return;
// DEL 2007.01.11 東都）高木 依頼主の必須チェックの廃止 END
				if(!半角チェック(tex依頼主コード,"依頼主コード")) return;
// ADD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START

				//会員マスタチェック
				texお客様名.Text = "";
// MOD 2009.05.11 東都）高木 未出荷対応 START
				if(texお客様コード.Text.Length > 0){
// MOD 2009.05.11 東都）高木 未出荷対応 END
					お客様検索();
					if(texお客様名.Text.Length == 0){
						MessageBox.Show("お客様コードが正しく入力されていません","入力チェック",MessageBoxButtons.OK );
						texお客様コード.Focus();
						return;
					}

					//荷送人マスタチェック
					tex依頼主コード.Text = tex依頼主コード.Text.Trim();
					if(tex依頼主コード.Text.Length > 0){
						tex依頼主名.Text = "";
						依頼主検索();
						if(tex依頼主名.Text.Length == 0){
							MessageBox.Show("依頼主コードが正しく入力されていません","入力チェック",MessageBoxButtons.OK );
							tex依頼主コード.Focus();
							return;
						}
					}
// MOD 2009.05.11 東都）高木 未出荷対応 START
				}
// MOD 2009.05.11 東都）高木 未出荷対応 END
// ADD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END
				texメッセージ.Text = "";

				if (dt開始日付.Value > dt終了日付.Value)
				{
					MessageBox.Show("日付の範囲が正しく入力されていません","入力チェック",MessageBoxButtons.OK );
					dt開始日付.Focus();
					return;
				}
				string sSdayh = YYYYMMDD変換(dt開始日付.Value.AddMonths(3));
				string sEdayh = YYYYMMDD変換(dt終了日付.Value);
				if (int.Parse(sSdayh) < int.Parse(sEdayh))
				{
					MessageBox.Show("日付の範囲は、３ヶ月以内で指定してください","入力チェック",MessageBoxButtons.OK );
					dt開始日付.Focus();
					return;
				}
			}


			tex登録件数.Text = "";
			tex個数合計.Text = "";
			tex重量合計.Text = "";
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
			texエントリ計.Text = "";
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
			texメッセージ.Text = "検索中．．．";
			axGT出荷一覧.Clear();
// MOD 2009.05.11 東都）高木 未出荷対応 START
			if(tex送り状番号.Text.Trim().Length == 0
					&& gsa状態ＣＤ[cmb状態.SelectedIndex].Equals("90")){
				axGT出荷一覧.set_CelText(0, 4, "お客様");
			}else{
				axGT出荷一覧.set_CelText(0, 4, "お届け先");
			}
// MOD 2009.05.11 東都）高木 未出荷対応 END
// MOD 2009.09.11 東都）高木 出荷照会で出荷済ＦＧ,送信済ＦＧなどを追加 START
//// ADD 2007.01.23 東都）高木 画面の調整 START
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|";
//// ADD 2007.01.23 東都）高木 画面の調整 END
// MOD 2010.04.06 東都）高木 出荷照会に得意先、郵便番号などを追加 START
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 END
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|13.0|6|6|5|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.6|16.6|3|3.4|6.5|8.5|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 START
//			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
//										+"13.0|6|6|5|"
//										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
			axGT出荷一覧.ColsWidth =    "0|1.4|2.2|3.4|16.2|2.4|2.6|2.6|5.8|8.7|5.3|4.6|"
										+"8.0|13.0|5.7|5.7|3.8|"
										+"0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|";
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 END
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
// MOD 2010.11.25 東都）高木 出荷照会に削除日時などを追加 END
// MOD 2010.04.06 東都）高木 出荷照会に得意先、郵便番号などを追加 END
// MOD 2009.09.11 東都）高木 出荷照会で出荷済ＦＧ,送信済ＦＧなどを追加 END
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT出荷一覧.CaretRow = 1;
			axGT出荷一覧.CaretCol = 1;
			axGT出荷一覧_CurPlaceChanged(null,null);
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END

			string sSday = YYYYMMDD変換(dt開始日付.Value);
			string sEday = YYYYMMDD変換(dt終了日付.Value);

			sData[0] = texお客様コード.Text.Trim();

			//ご依頼主検索からとってきた場合は、部門ＣＤを条件に入れる
			if(s依頼主ＣＤ.Trim() == tex依頼主コード.Text.Trim())
			{
				sData[1] = s部門ＣＤ;
			}
			else
			{
				sData[1] = "";
				tex依頼主名.Text = "";
			}

			sData[2] = tex依頼主コード.Text.Trim();
			sData[3] = cmb出荷日.SelectedIndex.ToString();
			sData[4] = sSday;
			sData[5] = sEday;
			sData[6] = gsa状態ＣＤ[cmb状態.SelectedIndex];
			if(tex送り状番号.Text.Trim().Length == 0)
				sData[7] = "";
			else
				sData[7] = tex送り状番号.Text.Trim().PadLeft(15,'0');
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START
//			if(rb全て.Checked)
//				sData[8] = "0";
//			if(rb削除.Checked)
//				sData[8] = "1";
//			if(rb出荷分.Checked)
//				sData[8] = "2";
			switch(cmb削除区分.SelectedIndex)
			{
				case 1:
					sData[8] = "1";		// 削除分
					break;
				case 2:
					sData[8] = "2";		// 出荷分
					break;
				default:
					sData[8] = "0";		// 全て
					break;
			}
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END

// MOD 2009.05.11 東都）高木 未出荷対応 START
//			sData[9] = gs店所コード;
			tex店所.Text = tex店所.Text.Trim();
			sData[9] = tex店所.Text;
// MOD 2009.05.11 東都）高木 未出荷対応 END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				s出荷一覧 = new string[1];
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				s出荷一覧 = sv_maintenance.Get_syukka(gsaユーザ,sData);
				texメッセージ.Text = s出荷一覧[0];
				if(s出荷一覧[0].Length == 4)
				{
					texメッセージ.Text = "";
					tex登録件数.Text = s出荷一覧[1];
					tex個数合計.Text = s出荷一覧[2];
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
//					tex重量合計.Text = s出荷一覧[3];
					string[] sWrk = s出荷一覧[3].Split('|');
					if(sWrk.Length >= 2){
						texエントリ計.Text = sWrk[0];
						tex重量合計.Text   = sWrk[1];
					}else{
						texエントリ計.Text = s出荷一覧[3];
						tex重量合計.Text   = "";
					}
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
// ADD 2007.01.11 東都）高木 送り状番号で検索した時、お客様名、依頼主名を表示 START
					if(tex送り状番号.Text.Trim().Length > 0){
						if(s出荷一覧[4] != null && s出荷一覧[4].Length > 0){
							texお客様コード.Text = "";
							s部門ＣＤ            = "";
							tex依頼主コード.Text = "";

							texお客様名.Text = s出荷一覧[7];
							tex依頼主名.Text = s出荷一覧[9];
						}
					}
// ADD 2007.01.11 東都）高木 送り状番号で検索した時、お客様名、依頼主名を表示 END

// MOD 2007.01.11 東都）高木 行数を10行にする START
//					axGT出荷一覧.Rows = 7;
					axGT出荷一覧.Rows = 10;
// MOD 2007.01.11 東都）高木 行数を10行にする END
					頁情報設定();

// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 START
					// 該当する出荷データが存在した場合のみ、ラベルイメージ印刷ボタンを利用可とする
					btnラベルイメージ印刷.Enabled = true;
// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 END

				}
				else
				{
					if(s出荷一覧[0].Equals("該当データがありません"))
					{
						texメッセージ.Text = "";
						MessageBox.Show("該当データがありません","出荷検索",MessageBoxButtons.OK);
					}
// ADD 2006.12.22 東都）小童谷 5000件チェック以上は表示できなくする START
// MOD 2007.01.23 東都）高木 1000件以上は表示できなくする START
//					else if(int.Parse(s出荷一覧[1].Replace(",","")) > 5000)
					else if(int.Parse(s出荷一覧[1].Replace(",","")) > 1000)
// MOD 2007.01.23 東都）高木 1000件以上は表示できなくする END
					{
						texメッセージ.Text = "";
						tex登録件数.Text = s出荷一覧[1];
						tex個数合計.Text = s出荷一覧[2];
						tex重量合計.Text = s出荷一覧[3];
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
//						tex重量合計.Text = s出荷一覧[3];
						string[] sWrk = s出荷一覧[3].Split('|');
						if(sWrk.Length >= 2){
							texエントリ計.Text = sWrk[0];
							tex重量合計.Text   = sWrk[1];
						}else{
							texエントリ計.Text = s出荷一覧[3];
							tex重量合計.Text   = "";
						}
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
// MOD 2007.02.02 東都）高木 1000件以上エラーのメッセージ変更 START
//// MOD 2007.01.23 東都）高木 1000件以上は表示できなくする START
////						MessageBox.Show("該当データが5000件を超えた為、表示できません。\n"
//						MessageBox.Show("該当データが1000件を超えた為、表示できません。\n"
//// MOD 2007.01.23 東都）高木 1000件以上は表示できなくする END
//										+ "検索条件を変更して、再検索してください。",
						MessageBox.Show("データ件数が、1,000件以上のため表示できません。\n"
										+ "検索条件を絞り込んで下さい。",
// MOD 2007.02.02 東都）高木 1000件以上エラーのメッセージ変更 START
										"出荷検索",MessageBoxButtons.OK);
					}
// ADD 2006.12.22 東都）小童谷 5000件チェック以上は表示できなくする END
					else
					{
						ビープ音();
					}
					tex依頼主コード.Focus();
				}
			}
			catch (System.Net.WebException)
			{
				texメッセージ.Text = gs通信エラー;
				ビープ音();
				tex依頼主コード.Focus();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = "通信エラー：" + ex.Message;
				ビープ音();
				tex依頼主コード.Focus();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			axGT出荷一覧.CaretRow = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT出荷一覧.CaretCol = 1;
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END
			axGT出荷一覧_CurPlaceChanged(sender,null);
		}

// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START
		private void お客様検索()
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				// 検索
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
// MOD 2007.11.14 KCL) 森本 global対応 START
//				String[] sList = sv_maintenance.Get_Sirainusi(gsaユーザ,texお客様コード.Text,"","",gs店所コード);
// MOD 2009.05.11 東都）高木 未出荷対応 START
//				String[] sList = sv_maintenance.Get_Sirainusi2(gsaユーザ,texお客様コード.Text,"","",gs店所コード);
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//				String[] sList = sv_maintenance.Get_Sirainusi2(gsaユーザ,texお客様コード.Text,"","",tex店所.Text);
				String[] sList;
				if ((texお客様コード.Text == "") || (texお客様コード.Text.Substring(0,1) != "J"))
				{
					sList = sv_maintenance.Get_Sirainusi2(gsaユーザ,texお客様コード.Text,"","",tex店所.Text);
				}
				else
				{
					if(sv_oji == null) sv_oji = new is2oji.Service1();
					sList = sv_oji.Get_Sirainusi2(gsaユーザ,texお客様コード.Text,"","",tex店所.Text);
				}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END					
// MOD 2009.05.11 東都）高木 未出荷対応 END
// MOD 2007.11.14 KCL) 森本 global対応 END
				// 正常終了時
				if(sList[0].Length == 4)
				{
					texお客様名.Text   = sList[1];
					texメッセージ.Text = "";
					tex依頼主コード.Focus();
				}
				else if(sList[0].Length == 0)
				{
					texメッセージ.Text = "";
					tex依頼主コード.Focus();
				}
				else
				{
					// 異常終了時
					ビープ音();
					texメッセージ.Text = sList[0];
					texお客様コード.Focus();
				}
			}
			catch (System.Net.WebException)
			{
				texメッセージ.Text = gs通信エラー;
				ビープ音();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = "通信エラー：" + ex.Message;
				ビープ音();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

		}
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END

		private void 依頼主検索()
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				// 検索
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START
//				if(sv_goirai == null) sv_goirai = new is2goirai.Service1();
//				String[] sList = sv_goirai.Get_Sirainusi(gsaユーザ,gs会員ＣＤ,gs部門ＣＤ,s依頼主ＣＤ);
//				// メッセージが[登録]、[更新]の時、正常終了
//				if(sList[0].Length == 2)
//
//				{
//					if(sList[17] == "U")
//					{
//						tex依頼主名.Text     = sList[9];
//						texメッセージ.Text = "";
//						cmb出荷日.Focus();
//					}
//					else
//					{
//						texメッセージ.Text = "";
//						cmb出荷日.Focus();
//					}
//				}
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
// MOD 2007.11.16 KCL) 森本 global対応 START
//// MOD 2007.01.25 東都）高木 検索条件エラー START
////				String[] sList = sv_maintenance.Get_Sirainusi(gsaユーザ,texお客様コード.Text,s部門ＣＤ,s依頼主ＣＤ,gs店所コード);
//				String[] sList = sv_maintenance.Get_Sirainusi(
//					gsaユーザ,  texお客様コード.Text, s部門ＣＤ, tex依頼主コード.Text, gs店所コード);
// MOD 2009.05.11 東都）高木 未出荷対応 START
//				String[] sList = sv_maintenance.Get_Sirainusi2(
//					gsaユーザ,  texお客様コード.Text, s部門ＣＤ, tex依頼主コード.Text, gs店所コード);
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//				String[] sList = sv_maintenance.Get_Sirainusi2(
//					gsaユーザ,  texお客様コード.Text, s部門ＣＤ, tex依頼主コード.Text, tex店所.Text);
				String[] sList;
				if ((texお客様コード.Text == "") || (texお客様コード.Text.Substring(0,1) != "J"))
				{
					sList = sv_maintenance.Get_Sirainusi2(
						gsaユーザ,  texお客様コード.Text, s部門ＣＤ, tex依頼主コード.Text, tex店所.Text);
				}
				else
				{
					if(sv_oji == null) sv_oji = new is2oji.Service1();
					sList = sv_oji.Get_Sirainusi2(
						gsaユーザ,  texお客様コード.Text, s部門ＣＤ, tex依頼主コード.Text, tex店所.Text);
				}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
					
					
// MOD 2009.05.11 東都）高木 未出荷対応 END
// MOD 2007.01.25 東都）高木 検索条件エラー END
// MOD 2007.11.16 KCL) 森本 global対応 END
				// 正常終了時
				if(sList[0].Length == 4)
				{
					tex依頼主名.Text   = sList[3];
					texメッセージ.Text = "";
					cmb出荷日.Focus();
				}
				else if(sList[0].Length == 0)
				{
					texメッセージ.Text = "";
					cmb出荷日.Focus();
				}
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END
				else
				{
					// 異常終了時
					ビープ音();
					texメッセージ.Text = sList[0];
					tex依頼主コード.Focus();
				}
			}
			catch (System.Net.WebException)
			{
				texメッセージ.Text = gs通信エラー;
				ビープ音();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = "通信エラー：" + ex.Message;
				ビープ音();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

		}

// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START
		private void texお客様コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btnお客様検索.Focus();
				btnお客様検索_Click(sender,e);
				e.Handled = true;
			}
		}

		private void texお客様コード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
//				btnお客様検索.Focus();
				// メッセージのクリア
				texメッセージ.Text = "";
				texお客様名.Text   = "";

				// 空白除去
				texお客様コード.Text = texお客様コード.Text.Trim();
				if(texお客様コード.Text.Length != 0)
				{
// MOD 2009.05.11 東都）高木 未出荷対応 START
					tex店所.Text = tex店所.Text.Trim();
					if(!gs管理者区分.Equals("1")){
						if(!必須チェック(tex店所,"店所コード")) return;
					}
// MOD 2009.05.11 東都）高木 未出荷対応 END
					if(!半角チェック(texお客様コード,"お客様コード")) return;

					texメッセージ.Text = "検索中．．．";
//					s依頼主ＣＤ = texお客様コード.Text;
					お客様検索();
				}
			}
		}

		private void texお客様コード_LostFocus(object sender, EventArgs e)
		{
			if(texお客様コード.Text.Trim() == "")
				texお客様名.Text = "";
		}
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END

		private void tex依頼主コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn依頼主検索.Focus();
				btn依頼主検索_Click(sender,e);
				e.Handled = true;
			}		

		}

		private void tex依頼主コード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
//				btn依頼主検索.Focus();
				// メッセージのクリア
				texメッセージ.Text = "";
				tex依頼主名.Text   = "";

// ADD 2007.01.25 東都）高木 お客様コードチェックの追加 START
				texお客様コード.Text = texお客様コード.Text.Trim();
// MOD 2009.05.11 東都）高木 未出荷対応 START
//				if(!必須チェック(texお客様コード,"お客様コード")) return;
				if(!gsa状態ＣＤ[cmb状態.SelectedIndex].Equals("90")){
					if(!必須チェック(texお客様コード,"お客様コード")) return;
				}
				tex店所.Text = tex店所.Text.Trim();
				if(!gs管理者区分.Equals("1")){
					if(!必須チェック(tex店所,"店所コード")) return;
				}
// MOD 2009.05.11 東都）高木 未出荷対応 END
				if(!半角チェック(texお客様コード,"お客様コード")) return;
// ADD 2007.01.25 東都）高木 お客様コードチェックの追加 END

				// 空白除去
				tex依頼主コード.Text = tex依頼主コード.Text.Trim();
				if(tex依頼主コード.Text.Length != 0)
				{
					if(!半角チェック(tex依頼主コード,"依頼主コード")) return;

					texメッセージ.Text = "検索中．．．";
					s依頼主ＣＤ = tex依頼主コード.Text;
					依頼主検索();
				}
			}
		}

		private void axGT出荷一覧_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT出荷一覧, true, true, true, true);
			}
		}

		private void tex依頼主コード_LostFocus(object sender, EventArgs e)
		{
			if(tex依頼主コード.Text.Trim() == "")
				tex依頼主名.Text = "";

		}

		private void 頁情報設定()
		{
//
// MOD 2007.01.11 東都）高木 行数を10行にする START
//			if (s出荷一覧.Length - 4 <= 7)
//			{
//				axGT出荷一覧.Rows = 7;
//			}
//			else if (axGT出荷一覧.Rows < s出荷一覧.Length - 4)
//			{
//				axGT出荷一覧.Rows = (short)(s出荷一覧.Length - 4);
//			}
			if (s出荷一覧.Length - 10 <= 10)
			{
				axGT出荷一覧.Rows = 10;
			}
			else if (axGT出荷一覧.Rows < s出荷一覧.Length - 10)
			{
				axGT出荷一覧.Rows = (short)(s出荷一覧.Length - 10);
			}
// MOD 2007.01.11 東都）高木 行数を10行にする END
			for(short i = 1; i <= axGT出荷一覧.Rows; i++ )
			{
				axGT出荷一覧.set_CelHeight(i,0,2.3);
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 START
//				axGT出荷一覧.set_CelAlignVert(i,2,3);
//				axGT出荷一覧.set_CelAlignVert(i,7,3);
//				axGT出荷一覧.set_CelAlignVert(i,8,3);
				axGT出荷一覧.set_CelAlignVert(i,4,3);
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
//				axGT出荷一覧.set_CelAlignVert(i,7,3);
//				axGT出荷一覧.set_CelAlignVert(i,11,3);
				axGT出荷一覧.set_CelAlignVert(i,8,3);
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 START
//				axGT出荷一覧.set_CelAlignVert(i,12,3);
				axGT出荷一覧.set_CelAlignVert(i,13,3);
// MOD 2014.03.19 BEVAS）高杉 出荷照会に配完日付・時刻を追加 END
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
// MOD 2007.01.17 東都）高木 検索項目、一覧表示項目の変更 END
			}
//
			axGT出荷一覧.Clear();
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 START
			axGT出荷一覧.CaretRow = 1;
			axGT出荷一覧.CaretCol = 1;
			axGT出荷一覧_CurPlaceChanged(null,null);
// ADD 2007.02.21 東都）高木 検索後のカラム位置の調整 END

			short s表示数 = (short)1;
//			for(short sCnt = (short)i開始数; sCnt < s出荷一覧.Length && sCnt <= i終了数 ; sCnt++)
// MOD 2007.01.11 東都）高木 送り状番号で検索した時、お客様名、依頼主名を表示 START
//			for(short sCnt = (short)4; sCnt < s出荷一覧.Length; sCnt++)
			for(short sCnt = (short)10; sCnt < s出荷一覧.Length; sCnt++)
// MOD 2007.01.11 東都）高木 送り状番号で検索した時、お客様名、依頼主名を表示 END
			{
				string sRList = s出荷一覧[sCnt].Replace("\\r\\n","\r\n");
				axGT出荷一覧.set_RowsText(s表示数, sRList);
				s表示数++;
			}
			axGT出荷一覧.Focus();
		}

		private void cmb状態_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btn出荷検索_Click(sender,e);
			}

		}

		private void 出荷照会_Closed(object sender, System.EventArgs e)
		{
			texお客様コード.Focus();
		}

		private void btnお客様検索_Click(object sender, System.EventArgs e)
		{
			texお客様コード.Text = texお客様コード.Text.Trim();
			if(!半角チェック(texお客様コード, "お客様コード")) return;

// MOD 2009.05.11 東都）高木 未出荷対応 START
			tex店所.Text = tex店所.Text.Trim();
			if(!gs管理者区分.Equals("1")){
				if(!必須チェック(tex店所,"店所コード")) return;
			}
// MOD 2009.05.11 東都）高木 未出荷対応 END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2007.11.13 KCL) 森本 global対応[会員検索２]画面に変更 START
//			if (g会員検索 == null)	 g会員検索 = new 会員検索();
//			g会員検索.Left = this.Left + 404;
//			g会員検索.Top = this.Top;
//			g会員検索.s会員コード = "";
//			g会員検索.s会員名 = "";
//// MOD 2007.01.19 東都）高木 画面レイアウト変更もれ START
////			g会員検索.ShowDialog();
//			g会員検索.s店所コード = gs店所コード.Trim();
//			g会員検索.ShowDialog();
//			g会員検索.s店所コード = "";
//// MOD 2007.01.19 東都）高木 画面レイアウト変更もれ END
//			this.Cursor = System.Windows.Forms.Cursors.Default;
//
//			if (g会員検索.s会員コード.Trim().Length != 0)
//			{
//				texお客様コード.Text = g会員検索.s会員コード;
//				texお客様名.Text = g会員検索.s会員名;
			if (g会員検２ == null)	 g会員検２ = new 会員検索２();
			g会員検２.Left = this.Left + 404;
			g会員検２.Top = this.Top;
			g会員検２.s会員コード = "";
			g会員検２.s会員名 = "";
// MOD 2009.05.11 東都）高木 未出荷対応 START
//			g会員検２.s店所コード = gs店所コード.Trim();
			g会員検２.s店所コード = tex店所.Text;
// MOD 2009.05.11 東都）高木 未出荷対応 END
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
			g会員検２.b運用中のお客様のみ = cb運用中のお客様のみ.Checked;
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END
			g会員検２.ShowDialog();
			g会員検２.s店所コード = "";
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if (g会員検２.s会員コード.Trim().Length != 0)
			{
				texお客様コード.Text = g会員検２.s会員コード;
				texお客様名.Text = g会員検２.s会員名;
// MOD 2007.11.13 KCL) 森本 global対応[会員検索２]画面に変更 END
				tex依頼主コード.Focus();
			}
			else
			{
				texお客様コード.Focus();
			}
		}

// MOD 2010.04.30 東都）高木 ＣＳＶ出力機能の追加 START
		private void btnＣＳＶ出力_Click(object sender, System.EventArgs e)
		{
// MOD 2010.11.19 東都）高木 配完情報などの取得 START
			bool bAltKey   = ((GetAsyncKeyState(Keys.Menu) & 0x8000) == 0) ? false : true;
			bool bShiftKey = ((GetAsyncKeyState(Keys.ShiftKey) & 0x8000) == 0) ? false : true;
// MOD 2011.05.20 東都）高木 ＣＳＶ出力形式の追加 START
//			if(bAltKey && bShiftKey){
			if(bAltKey){
// MOD 2011.05.20 東都）高木 ＣＳＶ出力形式の追加 END
				一覧選択ＣＳＶ出力();
				return;
			}
// MOD 2010.11.19 東都）高木 配完情報などの取得 END
// MOD 2011.05.20 東都）高木 ＣＳＶ出力形式の追加 START
//			string[] sData = new string[]{"","","","",""
//											,"","","","",""};
			string sＣＳＶ出力形式 = (bShiftKey) ? "1" : "0";
			string[] sData = new string[]{"","","","",""
										 ,"","","","",""
										 ,sＣＳＶ出力形式
// MOD 2014.03.20 BEVAS）高杉 ＣＳＶ出力に配完日付・時刻を追加 START
										 ,""
// MOD 2014.03.20 BEVAS）高杉 ＣＳＶ出力に配完日付・時刻を追加 END
										};
// MOD 2011.05.20 東都）高木 ＣＳＶ出力形式の追加 END
			texお客様名.Text = "";
			tex依頼主名.Text = "";

			tex店所.Text         = tex店所.Text.TrimEnd();
			texお客様コード.Text = texお客様コード.Text.TrimEnd();
			tex依頼主コード.Text = tex依頼主コード.Text.TrimEnd();
			tex送り状番号.Text   = tex送り状番号.Text.TrimEnd();

			if(tex送り状番号.Text.Trim().Length > 0){
				if(!半角チェック(tex店所        ,"店所コード"  )) return;
				if(!半角チェック(tex送り状番号  ,"送り状番号"  )) return;
			}else{
				//[状態ＣＤ]が[未出荷]以外の時、[お客様コード]が必須
				if(!gsa状態ＣＤ[cmb状態.SelectedIndex].Equals("90")){
					if(!必須チェック(texお客様コード,"お客様コード")) return;
				}
				//[管理者区分]が[管理者]以外の時、[店所コード]が必須
				if(!gs管理者区分.Equals("1")){
					if(!必須チェック(tex店所,"店所コード")) return;
				}
				if(!半角チェック(tex店所        ,"店所コード"  )) return;
				if(!半角チェック(texお客様コード,"お客様コード")) return;
				if(!半角チェック(tex依頼主コード,"依頼主コード")) return;

				//会員マスタチェック
				texお客様名.Text = "";
				if(texお客様コード.Text.Length > 0){
					お客様検索();
					if(texお客様名.Text.Length == 0){
						MessageBox.Show("お客様コードが正しく入力されていません"
										, "入力チェック", MessageBoxButtons.OK );
						texお客様コード.Focus();
						return;
					}

					//荷送人マスタチェック
					tex依頼主コード.Text = tex依頼主コード.Text.Trim();
					if(tex依頼主コード.Text.Length > 0){
						依頼主検索();
						if(tex依頼主名.Text.Length == 0){
							MessageBox.Show("依頼主コードが正しく入力されていません"
											, "入力チェック", MessageBoxButtons.OK );
							tex依頼主コード.Focus();
							return;
						}
					}
				}

				texメッセージ.Text = "";

				if (dt開始日付.Value > dt終了日付.Value){
					MessageBox.Show("日付の範囲が正しく入力されていません"
									, "入力チェック", MessageBoxButtons.OK );
					dt開始日付.Focus();
					return;
				}
				string s開始日付 = YYYYMMDD変換(dt開始日付.Value.AddMonths(3));
				string s終了日付 = YYYYMMDD変換(dt終了日付.Value);
				if (int.Parse(s開始日付) < int.Parse(s終了日付)){
					MessageBox.Show("日付の範囲は、３ヶ月以内で指定してください"
									, "入力チェック", MessageBoxButtons.OK );
					dt開始日付.Focus();
					return;
				}
			}

			sData[0] = texお客様コード.Text;
			//ご依頼主検索からとってきた場合は、部門ＣＤを条件に入れる
			if(s依頼主ＣＤ.Trim() == tex依頼主コード.Text.Trim()){
				sData[1] = s部門ＣＤ;
			}else{
				sData[1] = "";
				tex依頼主名.Text = "";
			}
			sData[2] = tex依頼主コード.Text;
			sData[3] = cmb出荷日.SelectedIndex.ToString();
			sData[4] = YYYYMMDD変換(dt開始日付.Value);;
			sData[5] = YYYYMMDD変換(dt終了日付.Value);
			sData[6] = gsa状態ＣＤ[cmb状態.SelectedIndex];
			if(tex送り状番号.Text.Trim().Length == 0){
				sData[7] = "";
			}else{
				sData[7] = tex送り状番号.Text.Trim().PadLeft(15,'0');
			}
			switch(cmb削除区分.SelectedIndex){
				case 1:
					sData[8] = "1";		// 削除分
					break;
				case 2:
					sData[8] = "2";		// 出荷分
					break;
				default:
					sData[8] = "0";		// 全て
					break;
			}
			sData[9] = tex店所.Text;
// MOD 2014.03.20 BEVAS）高杉 ＣＳＶ出力に配完日付・時刻を追加 START
			if(cBox配完Ｓ出力.Checked)
			{
				sData[11] = "1";
			}
			else
			{
				sData[11] = "";
			}
// MOD 2014.03.20 BEVAS）高杉 ＣＳＶ出力に配完日付・時刻を追加 END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sList = new string[]{""};
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				sList = sv_maintenance.Get_csvwrite3(gsaユーザ,sData);
				if(sList[0].Length == 4){
// MOD 2011.05.20 東都）高木 ＣＳＶ出力形式の追加 START
					if(sＣＳＶ出力形式.Equals("1")){
						//ＣＳＶエントリー形式
						sList[0] = ""
							+ "\"荷受人コード\",\"電話番号\","
							+ "\"住所\",\"住所２\",\"住所３\","
							+ "\"名前\",\"名前２\","
							+ "\"郵便番号\",\"特殊計\",\"着店コード\","
							+ "\"荷送人コード\","
							+ "\"個数\",\"才数\",\"重量\","
							+ "\"輸送商品１\",\"輸送商品２\","
							+ "\"品名記事１\",\"品名記事２\",\"品名記事３\","
							+ "\"配達指定日\",\"お客様管理番号\","
							+ "\"予備\","
							+ "\"元払区分\",\"保険金額\","
							+ "\"出荷日付\",\"登録日付\""
							;
					}else{
// MOD 2011.05.20 東都）高木 ＣＳＶ出力形式の追加 END
						sList[0] = "\"登録日\",\"出荷日\",\"送り状番号\","
							+ "\"荷受人コード\",\"荷受人郵便番号\",\"荷受人電話番号\","
							+ "\"荷受人住所１\",\"荷受人住所２\",\"荷受人住所３\","
							+ "\"荷受人名前１\",\"荷受人名前２\",\"特殊計\",\"着店コード\",\"着店名\","
							+ "\"荷送人コード\",\"荷送人郵便番号\",\"荷送人電話番号\","
							+ "\"荷送人住所１\",\"荷送人住所２\","
							+ "\"荷送人名前１\",\"荷送人名前２\","
							+ "\"個数\",\"重量\","
							+ "\"指定日\",\"輸送商品１\",\"輸送商品２\","
							+ "\"品名記事１\",\"品名記事２\",\"品名記事３\",\"元着区分\","
							+ "\"保険金額\",\"お客様管理番号\","
							+ "\"請求先コード\",\"請求先部課所コード\"";
// MOD 2011.05.20 東都）高木 ＣＳＶ出力形式の追加 START
					}
// MOD 2011.05.20 東都）高木 ＣＳＶ出力形式の追加 END
// MOD 2014.03.20 BEVAS）高杉 ＣＳＶ出力に配完日付・時刻を追加 START
					if(sData[11].Equals("1"))
					{
						sList[0] += ",\"配完日付・時刻\"";
					}
// MOD 2014.03.20 BEVAS）高杉 ＣＳＶ出力に配完日付・時刻を追加 END

					// デフォルトのフォルダをデスクトップフォルダにする
					saveFileDialog1.InitialDirectory
						= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
					saveFileDialog1.Filter = "ＣＳＶファイル (*.csv)|*.csv";
					byte[] bSJIS;
					if(saveFileDialog1.ShowDialog(this) == DialogResult.OK){
						System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
						for(int iCnt = 0; iCnt < sList.Length; iCnt++){
							bSJIS = toSJIS(sList[iCnt]);
							fs.Write(bSJIS, 0 , bSJIS.Length);
						}
						fs.Close();
						texメッセージ.Text = "";
					}
				}else{
					ビープ音();
					texメッセージ.Text = sList[0];
				}
			}catch (System.Net.WebException){
				this.Cursor = System.Windows.Forms.Cursors.Default;
				texメッセージ.Text = gs通信エラー;
			}catch(Exception ex){
				this.Cursor = System.Windows.Forms.Cursors.Default;
				texメッセージ.Text = ex.Message;
// MOD 2010.11.19 東都）高木 配完情報などの取得 START
			}finally{
				this.Cursor = System.Windows.Forms.Cursors.Default;
// MOD 2010.11.19 東都）高木 配完情報などの取得 END
			}
			texお客様コード.Focus();
		}
// MOD 2010.04.30 東都）高木 ＣＳＶ出力機能の追加 END
// MOD 2010.11.19 東都）高木 配完情報などの取得 START
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 START
//		const short n列_送り状番号     =  7;
//		const short n列_輸送状況       = 10;
//		const short n列_ジャーナルＮＯ = 15;
//		const short n列_登録日         = 16;
//		const short n列_会員ＣＤ       = 31;
//		const short n列_部門ＣＤ       = 32;
		const short n列_送り状番号     =  8;
		const short n列_輸送状況       = 11;
		const short n列_ジャーナルＮＯ = 16;
		const short n列_登録日         = 17;
		const short n列_会員ＣＤ       = 32;
		const short n列_部門ＣＤ       = 33;
// MOD 2011.05.06 東都）高木 出荷照会に荷主入力重量、店所入力重量を追加 END
		private void axGT出荷一覧_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
//			if(axGT出荷一覧.SelStartRow != axGT出荷一覧.SelEndRow){
//				MessageBox.Show("複数のデータを選択した状態では実行できません。\r\n"
//					+"１件のみ選択して実行してください。"
//					, "確認", MessageBoxButtons.OK );
//				return;
//			}
//			short n行 = axGT出荷一覧.CaretRow;
			short n列 = axGT出荷一覧.CaretCol;
			short n行開始 = (axGT出荷一覧.SelStartRow <= axGT出荷一覧.SelEndRow)
								? axGT出荷一覧.SelStartRow : axGT出荷一覧.SelEndRow;
			short n行終了 = (axGT出荷一覧.SelStartRow <= axGT出荷一覧.SelEndRow)
								? axGT出荷一覧.SelEndRow : axGT出荷一覧.SelStartRow;
			bool bAltKey   = ((GetAsyncKeyState(Keys.Menu) & 0x8000) == 0) ? false : true;
			bool bShiftKey = ((GetAsyncKeyState(Keys.ShiftKey) & 0x8000) == 0) ? false : true;

			//送り状番号の編集
			string[] sa送り状番号 = new string[]{
				 "","","","",""
				,"","","","",""
			};
			int iCnt送り状 = 0;
			string sw送り状番号 = "";
			for(short n行 = n行開始; n行 <= n行終了; n行++){
				sw送り状番号 = axGT出荷一覧.get_CelText(n行, n列_送り状番号).Trim();
				int iPosEnd = sw送り状番号.IndexOf('\r');
				if(iPosEnd < 1) continue;
				sa送り状番号[iCnt送り状] = sw送り状番号.Substring(0,iPosEnd);
				iCnt送り状++;
			}
			if(iCnt送り状 == 0) return;

			switch(n列){
			case n列_送り状番号:
			case n列_輸送状況:
				if(bAltKey){
					if(bShiftKey){
						配完情報取得２(sa送り状番号[0]);
					}else{
						お荷物配達状況照会一覧(sa送り状番号);
					}
				}
				break;
			}
		}
		private void 一覧選択ＣＳＶ出力()
		{
			short n行開始 = (axGT出荷一覧.SelStartRow <= axGT出荷一覧.SelEndRow)
								? axGT出荷一覧.SelStartRow : axGT出荷一覧.SelEndRow;
			short n行終了 = (axGT出荷一覧.SelStartRow <= axGT出荷一覧.SelEndRow)
								? axGT出荷一覧.SelEndRow : axGT出荷一覧.SelStartRow;

			//出荷キーの編集
			string[] sa出荷キー   = new string[n行終了 - n行開始 +1];
			int iCnt出荷キー = 0;
			string sw送り状番号 = "";
			string sw出荷キー   = "";
			string[] sa送り状番号 = new string[n行終了 - n行開始 +1];
			int iCnt送り状 = 0;
			for(short n行 = n行開始; n行 <= n行終了; n行++){
				sw出荷キー = axGT出荷一覧.get_CelText(n行, n列_会員ＣＤ);
				if(sw出荷キー == null) break;
				if(sw出荷キー.Length == 0) break;
				sw出荷キー += "," + axGT出荷一覧.get_CelText(n行, n列_部門ＣＤ);
				sw出荷キー += "," + axGT出荷一覧.get_CelText(n行, n列_登録日);
				sw出荷キー += "," + axGT出荷一覧.get_CelText(n行, n列_ジャーナルＮＯ);
				sw送り状番号 = axGT出荷一覧.get_CelText(n行, n列_送り状番号).Trim();
				int iPosEnd = sw送り状番号.IndexOf('\r');
				if(iPosEnd > 1){
					sw出荷キー += "," + sw送り状番号.Substring(0,iPosEnd);
					sa送り状番号[iCnt送り状] = sw送り状番号.Substring(0,iPosEnd);
					iCnt送り状++;
				}else{
					sw出荷キー += ",";
				}
				sa出荷キー[iCnt出荷キー] = sw出荷キー;
				iCnt出荷キー++;
			}
			if(iCnt出荷キー == 0){
				return;
			}

// MOD 2011.05.20 東都）高木 ＣＳＶ出力形式の追加 START
//			bool bCtrlKey = ((GetAsyncKeyState(Keys.ControlKey) & 0x8000) == 0) ? false : true;
//			// コントロールキーが押されていない時
//			if(!bCtrlKey){
			bool bShiftKey = ((GetAsyncKeyState(Keys.ShiftKey) & 0x8000) == 0) ? false : true;
			// シフトキーが押されていない時
			if(!bShiftKey){
// MOD 2011.05.20 東都）高木 ＣＳＶ出力形式の追加 END
				if(iCnt送り状 > 0){
//					if(iCnt送り状 == 1){
//						お荷物配達状況照会詳細(sa送り状番号[0]);
//					}else{
						お荷物配達状況照会一覧(sa送り状番号);
//					}
				}
				return;
			}

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try{
				string[] sList = new string[]{""};
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				sList = sv_maintenance.Get_SyukkaEtc(gsaユーザ,sa出荷キー);
				if(sList[0].Length == 4){

					// デフォルトのフォルダをデスクトップフォルダにする
					saveFileDialog1.InitialDirectory
						= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
					saveFileDialog1.Filter = "ＣＳＶファイル (*.csv)|*.csv";
					byte[] bSJIS;
					if(saveFileDialog1.ShowDialog(this) == DialogResult.OK){
						System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
						for(int iCnt = 1; iCnt < sList.Length; iCnt++){
							bSJIS = toSJIS("\"" + sList[iCnt].Replace(",","\",\"'") + "\"");
							fs.Write(bSJIS, 0 , bSJIS.Length);
						}
						fs.Close();
						texメッセージ.Text = "";
					}
				}else{
					ビープ音();
					texメッセージ.Text = sList[0];
				}
			}catch (System.Net.WebException){
				texメッセージ.Text = gs通信エラー;
			}catch(Exception ex){
				texメッセージ.Text = ex.Message;
			}finally{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}
		static string[] sa配完情報 = new string[]{
			 "原票番号","集荷店ＣＤ","集荷日","集荷時刻","発送店ＣＤ","発送日"
			,"到着店ＣＤ","到着日","到着時刻","持出店ＣＤ","持出日","持出時刻"
			,"配完店ＣＤ","配完日","配完時刻","理由ＣＤ"
			,"削除ＦＧ","登録日時","登録ＰＧ","登録者","更新日時","更新ＰＧ","更新者"
		};
		private void 配完情報取得１(string[] sa送り状番号)
		{
			if(sa送り状番号[0].Length == 0) return;
			配完情報取得２(sa送り状番号[0]);
		}
		private void 配完情報取得２(string s送り状番号)
		{
			string[] sData = new string[]{"0000" + s送り状番号};
			string[] sRet  = new string[]{""};
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try{
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				sRet = sv_maintenance.Sel_Haikan(gsaユーザ,sData);
				if(sRet[0].Length != 4){
					MessageBox.Show(sRet[0]
						, "配完データ取得", MessageBoxButtons.OK );
					return;
				}
				if(sRet[1] == null){
					MessageBox.Show("データがありません"
						, "配完データ取得", MessageBoxButtons.OK );
					return;
				}
				string sMsg = "";
				for(int iPos = 1; iPos < sRet.Length; iPos++){
					if(sRet[iPos] == null) break;
					if(iPos < sa配完情報.Length){
						sMsg += sa配完情報[iPos].PadRight(5,'　');
					}
					sMsg += "：["+sRet[iPos]+"]　\n";
				}
				MessageBox.Show(sMsg
					, "配完データ取得", MessageBoxButtons.OK );
			}catch (System.Net.WebException){
				MessageBox.Show(gs通信エラー
					, "配完データ取得", MessageBoxButtons.OK );
			}catch(Exception ex){
				MessageBox.Show(ex.Message
					, "配完データ取得", MessageBoxButtons.OK );
			}finally{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}

		/*********************************************************************
		* お荷物配達状況照会（Ｗｅｂの「お荷物配達状況照会」の表示）
		* 引数：送り状番号の配列
		* 戻値：なし
		**********************************************************************/
		static string[] saUrlお荷物配達状況照会一覧 = new string[]{
			 "http://www2.fukutsu.co.jp/inq/INQJS120?toino="
			,"&some_order_number=0&some_status_message=0&toino="
			,"&some_order_number=1&some_status_message=1&toino="
			,"&some_order_number=2&some_status_message=2&toino="
			,"&some_order_number=3&some_status_message=3&toino="
			,"&some_order_number=4&some_status_message=4&toino="
			,"&some_order_number=5&some_status_message=5&toino="
			,"&some_order_number=6&some_status_message=6&toino="
			,"&some_order_number=7&some_status_message=7&toino="
			,"&some_order_number=8&some_status_message=8&toino="
			,"&some_order_number=9&some_status_message=9&btn1=%8C%9F%81@%8D%F5&order_number="
			,"&status_message="
		};
		private void お荷物配達状況照会一覧(string[] as送り状番号)
		{
			if(as送り状番号[0].Length == 0) return;

			string sUrl = "";
			for(int iCnt = 0; iCnt < saUrlお荷物配達状況照会一覧.Length; iCnt++){
				sUrl += saUrlお荷物配達状況照会一覧[iCnt];
				if(iCnt >= as送り状番号.Length) continue;
				if(as送り状番号[iCnt] == null) continue;
				if(as送り状番号[iCnt].Length == 0) continue;
				sUrl += as送り状番号[iCnt];
			}
			Process.Start("iexplore.exe", sUrl);
		}
		
		/*********************************************************************
		* お荷物配達状況照会詳細（Ｗｅｂの「お荷物配達状況照会」の詳細表示）
		* 引数：送り状番号
		* 戻値：なし
		**********************************************************************/
		static string[] saUrlお荷物配達状況照会詳細 = new string[]{
			 "http://www2.fukutsu.co.jp/inq/INQJS150?toino="
			,"&some_order_number=0&some_status_message=0&toino="
			,"&some_order_number=1&some_status_message=1&toino="
			,"&some_order_number=2&some_status_message=2&toino="
			,"&some_order_number=3&some_status_message=3&toino="
			,"&some_order_number=4&some_status_message=4&toino="
			,"&some_order_number=5&some_status_message=5&toino="
			,"&some_order_number=6&some_status_message=6&toino="
			,"&some_order_number=7&some_status_message=7&toino="
			,"&some_order_number=8&some_status_message=8&toino="
			,"&some_order_number=9&some_status_message=9&order_number="
			,"&status_message="
		};
		private void お荷物配達状況照会詳細(string s送り状番号)
		{
			string sUrl = "";
			for(int iCnt = 0; iCnt < saUrlお荷物配達状況照会詳細.Length; iCnt++){
				sUrl += saUrlお荷物配達状況照会詳細[iCnt];
				if(iCnt == 0 || iCnt == 10){
					sUrl += s送り状番号;
				}
			}
			Process.Start("iexplore.exe", sUrl);
		}

// MOD 2010.11.19 東都）高木 配完情報などの取得 END

// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 START
		private void btn実績表印刷_Click(object sender, System.EventArgs e)
		{
			string s出荷日 = "";
			string s小計キー = "";
			string s小計キー保持 = "";
			string s必着 = "";
			int i個数 = 0;
			int i才数 = 0;
			int i重量 = 0;
			int i保険 = 0;
			int i才数重量 = 0;
			string s運賃才数 = "";
			string s運賃重量 = "";
			int i件数小計 = 0;
			int i個数小計 = 0;
			int i重量小計 = 0;
			int i保険小計 = 0;
			int i運賃 = 0;
			int i運賃小計 = 0;
			string s会員ＣＤ = "";
			string[] sData = new string[10];
			texメッセージ.Text = "";

			texお客様名.Text = "";
			tex依頼主名.Text = "";

			tex店所.Text = tex店所.Text.TrimEnd();
			texお客様コード.Text = texお客様コード.Text.TrimEnd();
			tex依頼主コード.Text = tex依頼主コード.Text.TrimEnd();
			tex送り状番号.Text = tex送り状番号.Text.TrimEnd();

			//送り状番号が入力されていれば、他の条件は無視
			if(tex送り状番号.Text.Trim().Length > 0)
			{
				if(!半角チェック(tex店所, "店所コード")) return;
				if(!半角チェック(tex送り状番号, "送り状番号")) return;
			}
			else
			{
				// [状態ＣＤ]が[未出荷]以外の時、[お客様コード]が必須
				if(!gsa状態ＣＤ[cmb状態.SelectedIndex].Equals("90"))
				{
					if(!必須チェック(texお客様コード, "お客様コード")) return;
				}
				// [管理者区分]が[管理者]以外の時、[店所コード]が必須
				if(!gs管理者区分.Equals("1"))
				{
					if(!必須チェック(tex店所, "店所コード")) return;
				}
				if(!半角チェック(tex店所, "店所コード")) return;
				if(!半角チェック(texお客様コード, "お客様コード")) return;
				if(!半角チェック(tex依頼主コード, "依頼主コード")) return;

				// 会員マスタチェック
				texお客様名.Text = "";
				if(texお客様コード.Text.Length > 0)
				{
					お客様検索();
					if(texお客様名.Text.Length == 0)
					{
						MessageBox.Show("お客様コードが正しく入力されていません", "入力チェック", MessageBoxButtons.OK);
						texお客様コード.Focus();
						return;
					}

					//荷送人マスタチェック
					tex依頼主コード.Text = tex依頼主コード.Text.Trim();
					if(tex依頼主コード.Text.Length > 0)
					{
						依頼主検索();
						if(tex依頼主名.Text.Length == 0)
						{
							MessageBox.Show("依頼主コードが正しく入力されていません", "入力チェック", MessageBoxButtons.OK);
							tex依頼主コード.Focus();
							return;
						}
					}
				}

				texメッセージ.Text = "";

				if (dt開始日付.Value > dt終了日付.Value)
				{
					MessageBox.Show("日付の範囲が正しく入力されていません", "入力チェック", MessageBoxButtons.OK);
					dt開始日付.Focus();
					return;
				}
				string s開始日付 = YYYYMMDD変換(dt開始日付.Value.AddMonths(3));
				string s終了日付 = YYYYMMDD変換(dt終了日付.Value);
				if (int.Parse(s開始日付) < int.Parse(s終了日付))
				{
					MessageBox.Show("日付の範囲は、３ヶ月以内で指定してください", "入力チェック", MessageBoxButtons.OK);
					dt開始日付.Focus();
					return;
				}
			}

			s会員ＣＤ = texお客様コード.Text;
			sData[0] = s会員ＣＤ;

			//ご依頼主検索からとってきた場合は、部門ＣＤを条件に入れる
			if(s依頼主ＣＤ.Trim() == tex依頼主コード.Text.Trim())
			{
				sData[1] = s部門ＣＤ;
			}
			else
			{
				sData[1] = "";
				tex依頼主名.Text = "";
			}

			sData[2] = tex依頼主コード.Text;
			sData[3] = cmb出荷日.SelectedIndex.ToString();
			sData[4] = YYYYMMDD変換(dt開始日付.Value);
			sData[5] = YYYYMMDD変換(dt終了日付.Value);
			sData[6] = gsa状態ＣＤ[cmb状態.SelectedIndex];

			if(tex送り状番号.Text.Trim().Length == 0)
			{
				sData[7] = "";
			}
			else
			{
				sData[7] = tex送り状番号.Text.Trim().PadLeft(15,'0');
			}

			switch(cmb削除区分.SelectedIndex)
			{
				case 1:
					sData[8] = "1";		// 削除分
					break;
				case 2:
					sData[8] = "2";		// 出荷分
					break;
				default:
					sData[8] = "0";		// 全て
					break;
			}

			sData[9] = tex店所.Text;

			string sSday = YYYYMMDD変換(dt開始日付.Value);
			string sEday = YYYYMMDD変換(dt終了日付.Value);

			texメッセージ.Text = "出荷実績一覧印刷中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sRet = new string[1];
				IEnumerator iEnum = null;

				if(sv_maintenance == null)
				{
					sv_maintenance = new is2maintenance.Service1();
				}
				iEnum = sv_maintenance.Get_PublishedPrintData4(gsaユーザ, sData).GetEnumerator();
				iEnum.MoveNext();
				sRet = (string[])iEnum.Current;
				if (sRet[0].Equals("正常終了"))
				{
					出荷実績データ ds = new 出荷実績データ();

					int iCnt = 1;
					//データセットに値をセット
					while (iEnum.MoveNext())
					{
						string[] sList = new string[40];
						sList = (string[])iEnum.Current;
					
						出荷実績データ.table出荷実績Row tr = (出荷実績データ.table出荷実績Row)ds.table出荷実績.NewRow();
						tr.BeginEdit();

						if(cmb出荷日.SelectedIndex == 0)
						{
							// [出荷日]が[出荷日]の場合
							s出荷日 = sList[1].Trim(); //出荷日
						}
						else
						{
							// [出荷日]が[登録日]の場合
							s出荷日 = sList[0].Trim(); //登録日
						}

						/** 改ページキーの設定 */
//						//『出荷日／登録日』のみ
//						s小計キー = s出荷日;
						//『出荷日／登録日』＋『ご依頼主ＣＤ』
						s小計キー = s出荷日 + sList[15];
//						//『出荷日／登録日』＋『得意先ＣＤ』＋『部課ＣＤ』
//						s小計キー = s出荷日 + sList[39] + sList[40];
//						//『出荷日／登録日』＋『得意先ＣＤ』＋『部課ＣＤ』＋『部門ＣＤ』
//						s小計キー = s出荷日 + sList[39] + sList[40] + sList[49];

						if((s小計キー保持 != "") && (s小計キー保持 != s小計キー))
						{
							s小計キー保持 = s小計キー;
							tr.小計フラグ = 1;
							iCnt = 1;
							tr.件数小計 = i件数小計;
							tr.個数小計 = i個数小計;
							tr.重量小計 = i重量小計;
							tr.保険小計 = i保険小計;
							tr.運賃小計 = i運賃小計;
							i件数小計 = 1;
							i個数小計 = 0;
							i重量小計 = 0;
							i保険小計 = 0;
							i運賃小計 = 0;
						}
						else
						{
							if(s小計キー保持 == "")
							{
								s小計キー保持 = s小計キー;
							}
							tr.小計フラグ = 0;
							i件数小計++;
						}

						tr.番号 = iCnt++; //網掛けあり
//						tr.番号 = -1; //網掛けなし

						if(cmb出荷日.SelectedIndex == 0)
						{
							tr.登録日 = sList[0].Substring(4,2) + "/" + sList[0].Substring(6,2);
							tr.出荷日 = "出荷日 " + sList[1].Substring(2,2) + "年" + sList[1].Substring(4,2) + "月" + sList[1].Substring(6,2) + "日";
							tr.日付タイトル = "登録日";
						}
						else
						{
							tr.出荷日 = "登録日 " + sList[0].Substring(2,2) + "年" + sList[0].Substring(4,2) + "月" + sList[0].Substring(6,2) + "日";
							tr.登録日 = sList[1].Substring(4,2) + "/" + sList[1].Substring(6,2);
							tr.日付タイトル = "出荷日";
						}

						if(sList[2].Trim().Length == 0)
						{
							tr.送り状番号 = sList[2].Trim();
						}
						else
						{
							tr.送り状番号 = sList[2].Substring(4,3) + "-" + sList[2].Substring(7,4) + "-" + sList[2].Substring(11,4);
						}

						tr.荷受人コード = sList[3].Trim();
						tr.荷受人郵便番号 = sList[4].Substring(0,3) + "-" + sList[4].Substring(3,4);
						if(sList[5].Trim().Length == 0)
						{
							tr.荷受人電話番号 = sList[6].Trim() + "-" + sList[7].Trim();
						}
						else
						{
							tr.荷受人電話番号 = "(" + sList[5].Trim() + ")" + sList[6].Trim() + "-" + sList[7].Trim();
						}
//						tr.荷受人住所１ = sList[8].Trim() + sList[9].Trim();
//						tr.荷受人住所２ = sList[10].Trim();
//						tr.荷受人名前１ = sList[11].Trim() + "  " + sList[12].Trim();
						tr.荷受人住所１ = sList[8].TrimEnd() + sList[9].TrimEnd();
						tr.荷受人住所２ = sList[10].TrimEnd();
						tr.荷受人名前１ = sList[11].TrimEnd() + "  " + sList[12].TrimEnd();
						tr.着店コード = sList[13].Trim();
						tr.着店名 = sList[14].Trim();

						tr.荷送人コード = sList[15].Trim();
						if(sList[16].Trim().Length != 0)
						{
							tr.荷送人郵便番号 = sList[16].Substring(0,3) + "-" + sList[16].Substring(3,4);
						}

						if(sList[17].Trim().Length == 0)
						{
							tr.荷送人電話番号 = sList[18].Trim() + "-" + sList[19].Trim();
						}
						else
						{
							tr.荷送人電話番号 = "(" + sList[17].Trim() + ")" + sList[18].Trim() + "-" + sList[19].Trim();
						}
//						tr.荷送人住所１ = sList[20].Trim() + sList[21].Trim();
//						tr.荷送人名前１ = sList[22].Trim() + "  " + sList[23].Trim();
//						tr.担当  = sList[24].Trim();
						tr.荷送人住所１ = sList[20].TrimEnd() + sList[21].TrimEnd();
						tr.荷送人名前１ = sList[22].TrimEnd() + "  " + sList[23].TrimEnd();
						tr.担当 = sList[24].TrimEnd();

						i個数 = int.Parse(sList[25].Trim());
						i個数小計 = i個数小計 + i個数;
						tr.個数 = sList[25].Trim();

						i重量 = 0;
						i才数 = 0;
						i才数重量 = 0;
						i重量 = (int)(double.Parse(sList[26].Trim()) + 0.5);
						i才数 = (int)(double.Parse(sList[36].Trim()) + 0.5);
						i才数 = i才数 * 8;
						i才数重量 = i重量 + i才数;
						tr.重量 = i才数重量.ToString("#,##0");
						if(i才数重量 == 0)
						{
							// 運賃才数、運賃重量が未設定の場合は空白
							s運賃才数 = sList[42].TrimEnd();
							s運賃重量 = sList[43].TrimEnd();
							if(s運賃才数.Length == 0 && s運賃重量.Length == 0)
							{
								tr.重量 = "";
							}
						}
						i重量小計 += i才数重量;

						if(sList[37].Trim() == "0")
						{
							s必着 = "必着";
						}
						else
						{
							s必着 = "指定";
						}

						if(sList[27].Trim().Length == 1)
						{
							tr.指定日 = "";
						}
						else
						{
							tr.指定日 = sList[27].Substring(4,2) + "/" + sList[27].Substring(6,2) + s必着;
						}

//						tr.輸送指示１ = sList[28].Trim();
//						tr.輸送指示２ = sList[29].Trim();
//						tr.品名記事１ = sList[30].Trim();
//						tr.品名記事２ = sList[31].Trim();
//						tr.品名記事３ = sList[32].Trim();
						tr.輸送指示１ = sList[28].TrimEnd();
						tr.輸送指示２ = sList[29].TrimEnd();
						tr.品名記事１ = sList[30].TrimEnd();
						tr.品名記事２ = sList[31].TrimEnd();
						tr.品名記事３ = sList[32].TrimEnd();
						if(sList.Length > 44)
						{
//							tr.品名記事４ = sList[44].Trim();
//							tr.品名記事５ = sList[45].Trim();
//							tr.品名記事６ = sList[46].Trim();
							tr.品名記事４ = sList[44].TrimEnd();
							tr.品名記事５ = sList[45].TrimEnd();
							tr.品名記事６ = sList[46].TrimEnd();
						}
						else
						{
							tr.品名記事４ = "";
							tr.品名記事５ = "";
							tr.品名記事６ = "";
						}

						if(sList[33].Trim() == "1")
						{
							tr.元着区分 = "元払";
						}
						else
						{
							if(sList[33].Trim() == "2")
							{
								tr.元着区分 = "着払";
							}
							else
							{
								tr.元着区分 = sList[33].Trim();
							}
						}

						i保険 = int.Parse(sList[34].Trim());
						i保険小計 = i保険小計 + i保険;
						tr.保険金額 = i保険.ToString("#,##0");

						tr.お客様番号 = sList[35].Trim();

						i運賃 = int.Parse(sList[38].Trim());
						i運賃小計 = i運賃小計 + i運賃;
						if(i運賃 == 0)
						{
							tr.運賃 = "*";
						}
						else
						{
							tr.運賃 = i運賃.ToString("#,##0");
						}

//						//『ヘッダ１名称』には、何も印字しない
						tr.ヘッダ１名称 = "";
//						//『ヘッダ１名称』に、請求先情報を印字
//						tr.ヘッダ１名称 = "　請求先" + " " + sList[39].Trim() + " " + sList[40].Trim() + " " + sList[41].Trim();
//						tr.ヘッダ１名称 = "　請求先" + " " + sList[39].TrimEnd() + " " + sList[40].TrimEnd() + " " + sList[41].TrimEnd();
//						//『ヘッダ１名称』に、ご依頼主情報を印字
//						tr.ヘッダ１名称 = "　ご依頼主" + " " + sList[15].Trim() + " " + sList[22].Trim() + " " + sList[23].Trim();
//						tr.ヘッダ１名称 = "　ご依頼主" + " " + sList[15].TrimEnd() + " " + sList[22].TrimEnd() + " " + sList[23].TrimEnd();


						if(sList[48].Trim().Substring(0,1) != "J")
						{
							tr.王子運送FLG = "0";
						}
						else
						{
							tr.王子運送FLG = "1";
						}

						tr.配完日時あり = "配完日付・時刻";
						if(sList[47].Trim() != "")
						{
							tr.配完日時 = "20" + sList[47].Substring(0,2) + "/" + sList[47].Substring(2,2) + "/" + sList[47].Substring(4,2)
								+ " " + sList[47].Substring(6,2) + ":" + sList[47].Substring(8,2);
						}
						else
						{
							tr.配完日時あり = "";
							tr.配完日時 = "";
						}

						tr.会員コード = sList[48].Trim();
						tr.会員名 = sList[49].Trim();

						tr.EndEdit();
						ds.table出荷実績.Rows.Add(tr);
					}

					//合計行を作成
					出荷実績データ.table出荷実績Row tr2 = (出荷実績データ.table出荷実績Row)ds.table出荷実績.NewRow();
					tr2.小計フラグ = 2;
					tr2.番号 = 1;
					tr2.件数小計 = i件数小計;
					tr2.個数小計 = i個数小計;
					tr2.重量小計 = i重量小計;
					tr2.保険小計 = i保険小計;
					tr2.運賃小計 = i運賃小計;
					ds.table出荷実績.Rows.Add(tr2);

					ReportClass cr = new 出荷実績帳票();
//					ReportClass cr = new 出荷実績帳票２();

					//CrystalReportにパラメータとデータセットを渡す
//					cr.SetParameterValue("部門ＣＤ", "");
//					cr.SetParameterValue("部門名",   "");
					cr.SetParameterValue("ご依頼主印字なし", false);
					cr.SetParameterValue("運賃印字なし", false);
					cr.SetParameterValue("社名あり", false);
					cr.SetParameterValue("サブタイトル", "");
					cr.SetDataSource(ds);

					//プレビュー表示
					プレビュー画面 画面 = new プレビュー画面();
					画面.Left = this.Left;
					画面.Top = this.Top;
					画面.crv帳票.PrintReport();
					画面.crv帳票.ReportSource = cr;
					画面.ShowDialog();

					texメッセージ.Text = "";
					try
					{
						cr.Close();
						cr.Dispose();
					}
					catch(Exception)
					{
						;
					}

					//明示的領域開放
					cr = null;
					ds = null;

					//明示的ガベージコレクタ
					System.GC.Collect();
				}
				else
				{
					if(sRet[0].Equals("1000件オーバー"))
					{
						texメッセージ.Text = "データ件数が、1,000件以上のため印刷できません。検索条件を絞り込んで下さい。";
						ビープ音();
					}
					else
					{
						texメッセージ.Text = sRet[0];
						ビープ音();
					}
				}
			}
			catch (System.Net.WebException)
			{
				texメッセージ.Text = gs通信エラー;
				ビープ音();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			texお客様コード.Focus();
		}

		private void btnラベルイメージ印刷_Click(object sender, System.EventArgs e)
		{
			texメッセージ.Text = "";

			//登録日チェック
			if(axGT出荷一覧.get_CelText(axGT出荷一覧.CaretRow,17).Trim().Length == 0)
			{
				return;
			}

			//輸送状況チェック
			string s輸送状況 = gsa状態名[cmb状態.SelectedIndex];
			if(s輸送状況 == "未発行")
			{
				ビープ音();
				MessageBox.Show(
						"未発行データのラベルイメージは、印刷できません。",
						"出荷ラベルイメージ印刷",
						MessageBoxButtons.OK
					);
				cmb状態.Focus();
				return;
			}

			//状態チェック
			string s削除区分 = cmb削除区分.SelectedItem.ToString();
			if(s削除区分 == "削除")
			{
				ビープ音();
				MessageBox.Show(
						"削除された出荷データのラベルイメージは、印刷できません。",
						"出荷ラベルイメージ印刷",
						MessageBoxButtons.OK
					);
				cmb削除区分.Focus();
				return;
			}

			texメッセージ.Text = "ラベルイメージ印刷中．．．";
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			short n開始;
			short n終了;
			if(axGT出荷一覧.SelStartRow > axGT出荷一覧.SelEndRow)
			{
				n終了 = axGT出荷一覧.SelStartRow;
				n開始 = axGT出荷一覧.SelEndRow;
			}
			else
			{
				n開始 = axGT出荷一覧.SelStartRow;
				n終了 = axGT出荷一覧.SelEndRow;
			}

			short n表示開始 = axGT出荷一覧.TopRow;
			string s開始登録日 = axGT出荷一覧.get_CelText(n開始,17).Trim();
			string s開始ジャーナルＮＯ = axGT出荷一覧.get_CelText(n開始,16).Trim();
			string s終了登録日 = axGT出荷一覧.get_CelText(n終了,17).Trim();
			string s終了ジャーナルＮＯ = axGT出荷一覧.get_CelText(n終了,16).Trim();
			string s次行登録日 = "";
			string s次行ジャーナルＮＯ = "";
			short n次行 = (short)(n終了 + 1);
			if(n次行 <= axGT出荷一覧.Rows)
			{
				s次行登録日 = axGT出荷一覧.get_CelText(n次行,17).Trim();
				s次行ジャーナルＮＯ = axGT出荷一覧.get_CelText(n次行,16).Trim();
			}

			送り状データクリア();

			for(short nCnt = n開始 ; nCnt <= n終了; nCnt++)
			{
				try
				{
					// 出荷データの各種ステータスをチェック
					/** (1)削除済の出荷データを選択していないかどうかをチェック */
					string s削除ステータス = axGT出荷一覧.get_CelText(nCnt, 1);
					if(s削除ステータス == "削")
					{
						texメッセージ.Text = "";
						ビープ音();
						Cursor = System.Windows.Forms.Cursors.Default;
						MessageBox.Show(
							"削除された出荷データが含まれます。ラベルイメージは印刷できません。",
							"出荷ラベルイメージ印刷",
							MessageBoxButtons.OK
							);
						return;
					}

					/** (2)ラベル未発行の出荷データを選択していないかどうかをチェック */
					string s発行済ステータス = axGT出荷一覧.get_CelText(nCnt, 2);
					if(s発行済ステータス == " ")
					{
						texメッセージ.Text = "";
						ビープ音();
						Cursor = System.Windows.Forms.Cursors.Default;
						MessageBox.Show(
								"ラベル未発行の出荷データが含まれます。ラベルイメージは印刷できません。",
								"出荷ラベルイメージ印刷",
								MessageBoxButtons.OK
							);
						return;
					}

					string[] sData = new string[4];
					//会員ＣＤ、部門ＣＤ、登録日、ジャーナルＮＯ
					sData[0] = axGT出荷一覧.get_CelText(nCnt, 33); //会員ＣＤ
					sData[1] = axGT出荷一覧.get_CelText(nCnt, 34); //部門ＣＤ
					sData[2] = axGT出荷一覧.get_CelText(nCnt, 18); //登録日
					sData[3] = axGT出荷一覧.get_CelText(nCnt, 17); //ジャーナルＮＯ

					//ラベルイメージ印刷用データ作成
					荷札控え印刷指示(sData, 1, 99);
//					if(!gb印刷)
//					{
//						texメッセージ.Text = "";
//						ビープ音();
//						Cursor = System.Windows.Forms.Cursors.Default;
//						MessageBox.Show("集荷店が違います。印刷できません。", "出荷ラベルイメージ印刷", MessageBoxButtons.OK);
//						return;
//					}
				}
				catch (Exception ex)
				{
					texメッセージ.Text = ex.Message;
					ビープ音();
					Cursor = System.Windows.Forms.Cursors.Default;
					return;
				}
			}

			荷札控え帳票印刷();

			Cursor = System.Windows.Forms.Cursors.Default;

			// 再検索
			btn出荷検索_Click(sender, e);
			一覧カーソル移動(n開始, n終了, n表示開始
				, s開始登録日, s開始ジャーナルＮＯ
				, s終了登録日, s終了ジャーナルＮＯ
				, s次行登録日, s次行ジャーナルＮＯ);
			texメッセージ.Text = "";
		}

		private void 一覧カーソル移動(short n開始, short n終了, short n表示開始
			, string s開始登録日, string s開始ジャーナルＮＯ
			, string s終了登録日, string s終了ジャーナルＮＯ
			, string s次行登録日, string s次行ジャーナルＮＯ)
		{
			//選択行のクリア
			axGT出荷一覧.CaretRow = 1;
			axGT出荷一覧.SelStartRow = 1;
			axGT出荷一覧.SelEndRow = 1;
			axGT出荷一覧.CaretCol = 2;

			//選択行の設定
			short n新開始 = 0;
			short n新終了 = 0;

			//選択開始行と選択終了行がかわらない場合
			if(s開始登録日 == axGT出荷一覧.get_CelText(n開始,17).Trim()
				&& s開始ジャーナルＮＯ == axGT出荷一覧.get_CelText(n開始,16).Trim()
				&& s終了登録日 == axGT出荷一覧.get_CelText(n終了,17).Trim()
				&& s終了ジャーナルＮＯ == axGT出荷一覧.get_CelText(n終了,16).Trim())
			{
				n新開始 = n開始;
				n新終了 = n終了;
			}
			else
			{
				for(short n行 = 1; n行 <= axGT出荷一覧.Rows; n行++)
				{
					//選択開始行の値（登録日、ジャーナルＮＯ）が同じ場合
					if(s開始登録日 == axGT出荷一覧.get_CelText(n行,17).Trim()
						&& s開始ジャーナルＮＯ == axGT出荷一覧.get_CelText(n行,16).Trim())
					{
						n新開始 = n行;
					}
					//選択終了行の値（登録日、ジャーナルＮＯ）が同じ場合
					if(s終了登録日 == axGT出荷一覧.get_CelText(n行,17).Trim()
						&& s終了ジャーナルＮＯ == axGT出荷一覧.get_CelText(n行,16).Trim())
					{
						n新終了 = n行;
						break;
					}
				}
			}
			//スクロール位置の設定
			if(n表示開始 <= axGT出荷一覧.Rows)
			{
				axGT出荷一覧.TopRow = n表示開始;
			}
			//再検索後の一覧に該当データが存在する場合
			if(n新終了 > 0)
			{
				//選択行数が同じ場合
				if(n新開始 > 0 && (n終了 - n開始 == n新終了 - n新開始))
				{
					axGT出荷一覧.CaretRow = n新開始;
					axGT出荷一覧.SelStartRow = n新開始;
					axGT出荷一覧.SelEndRow = n新終了;
				}
				else
				{
					axGT出荷一覧.CaretRow = n新終了;
					axGT出荷一覧.SelStartRow = n新終了;
					axGT出荷一覧.SelEndRow = n新終了;
				}
			}
			else
			{
				if(s次行登録日.Length > 0 && s次行ジャーナルＮＯ.Length > 0)
				{
					for(short n行 = 1; n行 <= axGT出荷一覧.Rows; n行++)
					{
						//選択開始行の値（登録日、ジャーナルＮＯ）が同じ場合
						if(s次行登録日 == axGT出荷一覧.get_CelText(n行,17).Trim()
							&& s次行ジャーナルＮＯ == axGT出荷一覧.get_CelText(n行,16).Trim())
						{
							axGT出荷一覧.CaretRow = n行;
							axGT出荷一覧.SelStartRow = n行;
							axGT出荷一覧.SelEndRow = n行;
							break;
						}
					}
				}
			}
			axGT出荷一覧_CurPlaceChanged(null,null);
		}

		protected static string 担当集荷店所取得(string s会員ＣＤ, string s部門ＣＤ)
		{
			try
			{
				// 部門店所の取得
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				if(sv_oji == null) sv_oji = new is2oji.Service1();
				String[] sRet;
				if (s会員ＣＤ.Substring(0,1) != "J")
				{
					sRet = sv_maintenance.Get_hatuten3(gsaユーザ, s会員ＣＤ, s部門ＣＤ);

				}
				else
				{
					sRet = sv_oji.Get_hatuten3(gsaユーザ, s会員ＣＤ, s部門ＣＤ);
				}

				if(sRet[0].Length == 4)
				{
					return sRet[1];
				}
				else
				{
					ビープ音();
					MessageBox.Show(sRet[0], "集荷店取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch(System.Net.WebException)
			{
				ビープ音();
				MessageBox.Show(gs通信エラー, "通信エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch(Exception ex)
			{
				ビープ音();
				MessageBox.Show(ex.Message, "通信エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return "";
		}

		protected void 荷札控え印刷指示(string[] sData, int i開始, int i終了)
		{
//			gb印刷 = true;
			string s会員ＣＤ = sData[0];
			string s部門ＣＤ = sData[1];

			try
			{
				//印刷データの作成
				string[] sPrintKey = new string[4];
				sPrintKey[0] = s会員ＣＤ;    //会員ＣＤ
				sPrintKey[1] = s部門ＣＤ;    //部門ＣＤ
				sPrintKey[2] = sData[2];	//登録日
				sPrintKey[3] = sData[3];	//ジャーナルＮＯ

				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				if(sv_oji == null) sv_oji = new is2oji.Service1();

				string[] sPrintData;
				if (s会員ＣＤ.Substring(0,1) != "J")
				{
					sPrintData = sv_maintenance.Get_InvoicePrintData(gsaユーザ, sPrintKey);
				}
				else
				{
					sPrintData = sv_oji.Get_InvoicePrintData(gsaユーザ, sPrintKey);
				}

				if (!sPrintData[0].Equals("正常終了"))
				{
					throw new Exception(sPrintData[0]);
				}

//				// 店所チェック
//				string s担当集荷店コード = 担当集荷店所取得(s会員ＣＤ, s部門ＣＤ);
//				/** (1)担当集荷店とログイン店所が違う場合 */
//				if(s担当集荷店コード.Trim() != gs店所コード)
//				{
//					gb印刷 = false;
//					return;
//				}
//				/** (2)担当集荷店と出荷データの発店が違う場合 */
//				if(s担当集荷店コード.Trim() != sPrintData[14].Substring(1, 3))
//				{
//					gb印刷 = false;
//					return;
//				}
//				/** (3)ログイン店所と出荷データの発店が違う場合 */
//				if(gs店所コード != sPrintData[14].Substring(1, 3))
//				{
//					gb印刷 = false;
//					return;
//				}

//				sPrintData[5] = sPrintData[5].Trim(); // 荷受人住所１
//				sPrintData[6] = sPrintData[6].Trim(); // 荷受人住所２
//				sPrintData[7] = sPrintData[7].Trim(); // 荷受人住所３
//				sPrintData[8] = sPrintData[8].Trim(); // 荷受人名前１
//				sPrintData[9] = sPrintData[9].Trim(); // 荷受人名前２
//				sPrintData[18] = sPrintData[18].Trim(); // 荷送人住所１
//				sPrintData[19] = sPrintData[19].Trim(); // 荷送人住所２
//				sPrintData[21] = sPrintData[21].Trim(); // 荷送人名前１
//				sPrintData[22] = sPrintData[22].Trim(); // 荷送人名前２
//				sPrintData[34] = sPrintData[34].Trim(); // 担当者
//				sPrintData[29] = sPrintData[29].Trim(); // 品名記事１
//				sPrintData[30] = sPrintData[30].Trim(); // 品名記事２
//				sPrintData[31] = sPrintData[31].Trim(); // 品名記事３
//				if(sPrintData.Length > 42)
//				{
//					sPrintData[42] = sPrintData[42].Trim(); // 品名記事４
//					sPrintData[43] = sPrintData[43].Trim(); // 品名記事５
//					sPrintData[44] = sPrintData[44].Trim(); // 品名記事６
//				}
				sPrintData[5] = sPrintData[5].TrimEnd(); // 荷受人住所１
				sPrintData[6] = sPrintData[6].TrimEnd(); // 荷受人住所２
				sPrintData[7] = sPrintData[7].TrimEnd(); // 荷受人住所３
				sPrintData[8] = sPrintData[8].TrimEnd(); // 荷受人名前１
				sPrintData[9] = sPrintData[9].TrimEnd(); // 荷受人名前２
				sPrintData[18] = sPrintData[18].TrimEnd(); // 荷送人住所１
				sPrintData[19] = sPrintData[19].TrimEnd(); // 荷送人住所２
				sPrintData[21] = sPrintData[21].TrimEnd(); // 荷送人名前１
				sPrintData[22] = sPrintData[22].TrimEnd(); // 荷送人名前２
				sPrintData[34] = sPrintData[34].TrimEnd(); // 担当者
				sPrintData[29] = sPrintData[29].TrimEnd(); // 品名記事１
				sPrintData[30] = sPrintData[30].TrimEnd(); // 品名記事２
				sPrintData[31] = sPrintData[31].TrimEnd(); // 品名記事３
				if(sPrintData.Length > 42)
				{
					sPrintData[42] = sPrintData[42].TrimEnd(); // 品名記事４
					sPrintData[43] = sPrintData[43].TrimEnd(); // 品名記事５
					sPrintData[44] = sPrintData[44].TrimEnd(); // 品名記事６
				}

				// 個数(sPrintData[23])は使用せず、１回のみ印刷する
//				int iLabel終了 = int.Parse(sPrintData[23]);
				int iLabel終了 = 1;
				if(iLabel終了 > i終了)
				{
					iLabel終了 = i終了;
				}

				for (int iPage = i開始; iPage <= iLabel終了; iPage++)
				{
					送り状データ.table送り状Row tr = (送り状データ.table送り状Row)ds送り状.table送り状.NewRow();
					tr.BeginEdit();
					tr.印刷順 = i印刷順++;

					if(sPrintData[12].Length >= 7)
					{
						tr.荷受人郵便番号 = "〒";
						tr.荷受人郵便番号 += sPrintData[12].Substring(0,3);
						tr.荷受人郵便番号 += "-";
						tr.荷受人郵便番号 += sPrintData[12].Substring(3,4);
					}
					else
					{
						tr.荷受人郵便番号 = "";
					}

					tr.荷受人ＣＤ     = "";
//					tr.荷受人ＣＤ     = sPrintData[1];
					tr.荷受人電話番号 = "(" + sPrintData[2] + ")" + sPrintData[3] + "-" + sPrintData[4];
					if(sPrintData[2].Replace("0","").Trim().Length == 0
						&& sPrintData[3].Replace("0","").Trim().Length == 0
						&& sPrintData[4].Replace("0","").Trim().Length == 0)
					{
						tr.荷受人電話番号 = " ";
					}
					tr.荷受人住所県   = "";
					tr.荷受人住所市   = "";
					tr.荷受人住所町   = "";
					tr.荷受人住所１   = sPrintData[5];
					tr.荷受人住所２   = sPrintData[6];
					tr.荷受人住所３   = sPrintData[7];
					tr.荷受人名前１   = sPrintData[8];
					tr.荷受人名前２   = sPrintData[9];
					if (sPrintData[5].Equals("※※支店止め※※"))
					{
						// 支店止めであるとき、荷受人住所項目に以下の設定を行なう
						// 　・荷受人住所県：「※※支店止め※※」（帳票項目の表示判定に使用、非表示項目）
						// 　・荷受人住所１：「福山通運／王子運送」を印字
						// 　・荷受人住所２：「○○支店／営業所止め」
						// 　・荷受人住所３：何も印字しない
						tr.荷受人住所県 = sPrintData[5];
						if(sPrintData[6].Substring(0, 2) == "王子")
						{
							tr.荷受人住所１ = "王子運送";
						}
						else
						{
							tr.荷受人住所１ = "福山通運";
						}
						tr.荷受人住所３ = "";
					}

					tr.出荷日年       = sPrintData[10];
					if(sPrintData[10].Substring(4, 1) == "0")
					{
						tr.出荷日月       = " " + sPrintData[10].Substring(5, 1);
					}
					else
					{
						tr.出荷日月       = sPrintData[10].Substring(4, 2);
					}

					if(sPrintData[10].Substring(6, 1) == "0")
					{
						tr.出荷日日       = " " + sPrintData[10].Substring(7, 1);
					}
					else
					{
						tr.出荷日日       = sPrintData[10].Substring(6, 2);
					}

					tr.送り状番号     = sPrintData[11].Substring(4,3) + "-" + sPrintData[11].Substring(7,4) + "-" + sPrintData[11].Substring(11,4);
					tr.バーコード     = "A" + sPrintData[11].Substring(4) + "A";

					if(sPrintData[13].Length == 0)
					{
						tr.着店ＣＤ       = "";
					}
					else
					{
						tr.着店ＣＤ       = sPrintData[13].Substring(1);
					}
					if(sPrintData[13].Equals("0000"))
					{
						tr.着店ＣＤ       = "";
					}

					//仕分ＣＤが設定されている場合、仕分ＣＤを印字
					if(sPrintData[37].Length > 0)
					{
						tr.仕分ＣＤ       = sPrintData[37];
					}
					else
					{
						tr.仕分ＣＤ       = "";
					}

					tr.発店ＣＤ       = sPrintData[14].Substring(1, 3);

					//グローバル対応（出荷日、発店の非表示）
					if(sPrintData[14].Substring(1, 3) == "047")
					{
						tr.出荷日年       = "";
						tr.出荷日月       = "";
						tr.出荷日日       = "";
						tr.発店名         = "";
						tr.発店ＣＤ       = "";
					}

					if(sPrintData.Length > 40 && sPrintData[40].Length >= 7)
					{
						tr.荷送人郵便番号 = "〒";
						tr.荷送人郵便番号 += sPrintData[40].Substring(0,3);
						tr.荷送人郵便番号 += "-";
						tr.荷送人郵便番号 += sPrintData[40].Substring(3,4);
					}
					else
					{
						tr.荷送人郵便番号 = "";
					}

					tr.荷送人電話番号 = "(" + sPrintData[15] + ")" + sPrintData[16] + "-" + sPrintData[17];
					tr.荷送人住所１   = 住所編集(sPrintData[18]);
					tr.荷送人住所２   = sPrintData[19];
					tr.荷送人住所３   = sPrintData[18];
					tr.荷送人名前１   = sPrintData[21];
					tr.荷送人名前２   = sPrintData[22];
					tr.担当者         = sPrintData[34];
					tr.個数           = sPrintData[23];

					// 連番は０固定とする。
//					tr.連番           = iPage.ToString();
					tr.連番           = "0";
					tr.重量           = sPrintData[24];

					int i保険料 = int.Parse(sPrintData[25]) * 10;
					if(i保険料 > 0 && i保険料 < 50)
					{
						tr.保険料     = "50";
					}
					else
					{
						string s保険料 = i保険料.ToString();
						if(s保険料.Length == 4)
						{
							s保険料 = s保険料.Insert(1,",");
						}
						else
						{
							if(s保険料.Length == 5)
							{
								s保険料 = s保険料.Insert(2,",");
							}
						}
						tr.保険料     = s保険料;
					}

					string s指定月;
					string s指定日;
					if (sPrintData[26] != null && !sPrintData[26].Equals("") && !sPrintData[26].Equals("0"))
					{
						if(sPrintData[26].Substring(4, 1) == "0")
						{
							s指定月 = " " + sPrintData[26].Substring(5, 1);
						}
						else
						{
							s指定月 = sPrintData[26].Substring(4, 2);
						}

						if(sPrintData[26].Substring(6, 1) == "0")
						{
							s指定日 = " " + sPrintData[26].Substring(7, 1);
						}
						else
						{
							s指定日 = sPrintData[26].Substring(6, 2);
						}

						tr.指定日     = s指定月 + "月" + s指定日 + "日";
						if (sPrintData[36].Equals("0"))
						{
							tr.指定日 += "必着";
						}
						else if (sPrintData[36].Equals("1"))
						{
							tr.指定日 += "指定";
						}
					}
					else
					{
						tr.指定日     = "";
					}

					if(sPrintData[35].Length != 0)
					{
						tr.お客様番号     = "お客様番号:" + sPrintData[35];
					}
					else
					{
						tr.お客様番号     = sPrintData[35];
					}

					tr.輸送記事１     = sPrintData[27];
					tr.輸送記事２     = sPrintData[28];
					tr.品名記事１     = sPrintData[29];
					tr.品名記事２     = sPrintData[30];
					tr.品名記事３     = sPrintData[31];

					if(sPrintData.Length > 42)
					{
						tr.品名記事４ = sPrintData[42];
						tr.品名記事５ = sPrintData[43];
						tr.品名記事６ = sPrintData[44];
					}
					else
					{
						tr.品名記事４ = "";
						tr.品名記事５ = "";
						tr.品名記事６ = "";
					}
					if(tr.品名記事４.Length > 0 || tr.品名記事５.Length > 0 || tr.品名記事６.Length > 0)
					{
						// 全角９文字、又は半角１８文字
						tr.品名記事１ = バイト長カット(tr.品名記事１, 18);
						tr.品名記事２ = バイト長カット(tr.品名記事２, 18);
						tr.品名記事３ = バイト長カット(tr.品名記事３, 18);
						tr.品名記事４ = バイト長カット(tr.品名記事４, 18);
						tr.品名記事５ = バイト長カット(tr.品名記事５, 18);
						tr.品名記事６ = バイト長カット(tr.品名記事６, 18);
					}

					tr.荷受人フォントサイズ拡大FLG = "0";
//					tr.荷受人フォントサイズ拡大FLG = "1";

					if(s会員ＣＤ.Substring(0,1) != "J")
					{
						tr.王子運送FLG = "0";
					}
					else
					{
						tr.王子運送FLG = "1";
					}

					string s重量入力制御 = (sPrintData.Length > 41) ? sPrintData[41] : "0";
					tr.重量入力制御 = s重量入力制御;

					if(tr.発店ＣＤ == "" || tr.発店ＣＤ == "000")
					{
						tr.発店名     = ""; // 発店ＣＤが未設定時(グローバル等)
					}
					else
					{
						if(sPrintData[38] == "")
						{
							tr.発店名     = tr.発店ＣＤ;
						}
						else
						{
							tr.発店名     = sPrintData[38];
						}
					}
					string s着店名 = (sPrintData.Length > 45) ? sPrintData[45] : "";
					if(tr.着店ＣＤ == "" || tr.着店ＣＤ == "000")
					{
						tr.着店名     = ""; // 着店ＣＤが未設定時
					}
					else
					{
						if(s着店名 == "")
						{
							tr.着店名     = tr.着店ＣＤ;
						}
						else
						{
							tr.着店名     = s着店名;
						}
					}
					// ※ラベルのバックの黒塗を[着店名]に設定している為
					//   着店名が表示されない時、バックの色が消えます

// MOD 2016.04.15 BEVAS）松本 社内伝票機能追加対応 START
					//社内伝票であれば、値をセットする
					if(s会員ＣＤ.Substring(0,2).ToUpper().Equals("FK"))
					{
						// 社内伝票であるとき、荷受人住所項目に以下の設定を行なう
						// 　・荷受人住所町　　　　　：「※※社内伝票※※」
						//　　　（帳票項目の表示判定に使用、非表示項目）
						// 　・着店ＣＤ（大）　　　　：印字しない
						// 　・着店ＣＤ（小）　　　　：印字する
						// 　・『社内専用』テキスト：印字する
						tr.荷受人住所町 = "※※社内伝票※※";
					}
// MOD 2016.04.15 BEVAS）松本 社内伝票機能追加対応 END

					tr.EndEdit();

					ds送り状.table送り状.Rows.Add(tr);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected void 荷札控え帳票印刷()
		{
			// 明示的ガベージコレクタ
			System.GC.Collect();

			// プレビュー表示
			送り状控えＡ４帳票 crA4 = new 送り状控えＡ４帳票();

			DataView dv = ds送り状.table送り状.DefaultView;
			dv.Sort = "印刷順 ASC";
			DataTable dt2 = ds送り状.table送り状.Clone();
			foreach (DataRowView drv in dv) 
			{
				dt2.Rows.Add(drv.Row.ItemArray);
			}
			dt2.AcceptChanges();
			crA4.SetDataSource(dt2);

			プレビュー画面 画面 = new プレビュー画面();
			画面.crv帳票.PrintReport();
			画面.crv帳票.ReportSource = crA4;
			画面.ShowDialog();

			// 明示的領域開放
			crA4 = null;
			dv  = null;
			dt2 = null;

			// 明示的ガベージコレクタ
			System.GC.Collect();

			送り状データクリア();
		}

		protected void 送り状データクリア()
		{
			i印刷順 = 0;

			ds送り状.Clear();

			//明示的領域開放
			ds送り状 = null;

			//明示的ガベージコレクタ
			System.GC.Collect();

			//送り状データ領域再作成
			ds送り状 = new 送り状データ();
		}

		protected string 住所編集(string s住所)
		{
			if(s住所.Length <= 2)
			{
				return s住所;
			}

			// 都道府県ハッシュテーブルの作成
			if(h県 == null)
			{
				h県 = new Hashtable();
				for(int iCnt = 1; iCnt < sa県.Length; iCnt++)
				{
					h県.Add(iCnt,sa県[iCnt]);
				}
			}

			string s県名   = "";
			string s市区郡 = "";
			string s編集中 = "";
			string s編集後 = "";
			int    iIndex  = 0;

			// 「神奈川県」、「和歌山県」、「鹿児島県」は４文字で分解し比較する
			if(s住所.StartsWith("神") || s住所.StartsWith("和") || s住所.StartsWith("鹿"))
			{
				if(s住所.Length >= 4)
				{
					s編集中 = s住所.Substring(0,4);
					iIndex  = 4;
				}
			}
			else
			{
				s編集中 = s住所.Substring(0,3);
				iIndex  = 3;
			}

			if(h県.ContainsValue(s編集中))
			{
				s県名   = s編集中;
				s編集中 = s住所.Remove(0,iIndex);
			}
			else
				s編集中 = s住所;

			s市区郡 = s編集中;
			for(int iCnt = 0; iCnt < sa市区郡.Length; iCnt++)
			{
				if(sa市区郡[iCnt].Length <= s市区郡.Length)
				{
					if(sa市区郡[iCnt] == s市区郡.Substring(0,sa市区郡[iCnt].Length))
					{
						s市区郡 = s編集中.Insert(sa市区郡[iCnt].Length," ");
						s編集後 = s県名 + " " + s市区郡;
						return s編集後.Trim();
					}
				}
			}

			for(iIndex = 1; iIndex < s編集中.Length; iIndex++)
			{
				if(s編集中.Substring(iIndex,1) == "市"
					|| s編集中.Substring(iIndex,1) == "区"
					|| s編集中.Substring(iIndex,1) == "郡")
				{
					s市区郡 = s編集中.Insert(iIndex + 1," ");
					break;
				}
			}
			s編集後 = s県名 + " " + s市区郡;
			return s編集後.Trim();
		}

		protected static string バイト長カット(string data, int iMaxLength)
		{
			string sRet = data;
			byte[] bSjis;

			bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(data);
			//範囲内ならそのまま戻す
			if(bSjis.Length <= iMaxLength)
			{
				return sRet;
			}

			try
			{
				string sUnicode;
				for(int iLen = iMaxLength / 2; iLen <= data.Length; iLen++)
				{
					sUnicode = data.Substring(0,iLen);
					bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sUnicode);
					if(bSjis.Length > iMaxLength)
					{
						break;
					}
					sRet = sUnicode;
				}
			}
			catch(Exception)
			{
				;
			}

			return sRet;
		}
// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 END
	}
}
