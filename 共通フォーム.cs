using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace is2AdminClient
{
	/// <summary>
	/// [共通フォーム]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// MOD 2008.02.14 東都）高木 Vista対応 
	// ADD 2008.02.14 東都）高木 ＳＪＩＳチェック機能の追加 
	// DEL 2008.05.07 東都）高木 ご依頼主検索削除 
	// ADD 2008.05.07 東都）高木 全角半角混在チェック機能の追加 
	// DEL 2008.05.08 東都）高木 セクション検索削除 
	// MOD 2008.04.11 ACT Vista対応 
	//中止 MOD 2008.12.08 東都）高木 営業所でのパスワード照会対応 
	//--------------------------------------------------------------------------
	// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 
	// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
	// MOD 2009.11.04 東都）高木 お届け先ＣＤに記号[+]を利用可能にする 
	// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 
	//--------------------------------------------------------------------------
	// MOD 2010.05.24 東都）高木 ファイル出力時の改行コードの修正 
	// MOD 2010.06.29 東都）高木 営業所用お知らせ登録機能の追加 
	// MOD 2010.11.19 東都）高木 配完情報などの取得 
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	// ADD 2013.07.12 tdi）綱澤 東京テリトリ移管先ログイン対応
	//--------------------------------------------------------------------------
	// MOD 2016.04.13 BEVAS）松本 社内伝票対応
	//--------------------------------------------------------------------------
	public class 共通フォーム : System.Windows.Forms.Form
	{
		protected static String gs会員コード   = "";
		protected static String gs会員名       = "";
		protected static String gs利用者コード = "";
		protected static String gs利用者名     = "";
		protected static String gs店所コード   = "";
// ADD 2007.02.06 東都）高木 営業所会員対応 START
		protected static String gs管理者区分   = "";
// ADD 2007.02.06 東都）高木 営業所会員対応 END
// ADD 2006.12.06 東都）小童谷 ＩＰアドレス START
		protected static String gsＩＰアドレス = "";
// ADD 2006.12.06 東都）小童谷 ＩＰアドレス END
// ADD 2007.02.06 東都）高木 イメージロードエラー対応 START
		protected static String gsアプリフォルダ = "";
// ADD 2007.02.06 東都）高木 イメージロードエラー対応 END
// MOD 2007.10.26 東都）高木 バージョン情報を表示する START
//		protected static String[] gsaユーザ    = new string[3];
		protected static String[] gsaユーザ = {"","","",""};
// MOD 2007.10.26 東都）高木 バージョン情報を表示する END
		// Ｗｅｂサービス変数
		protected static is2maintenance.Service1  sv_maintenance  = null;
		//Cookieを保存しておくCookieContainer
// ADD 2007.12.11 KCL) 森本 お知らせ追加 START
		protected static is2oshirase.Service1 sv_oshirase = null;
// ADD 2007.12.11 KCL) 森本 お知らせ追加 END
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
		protected static is2oji.Service1 sv_oji = null;
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

// DEL 2005.05.27 東都）高木 セッション制御の廃止 START
//		protected static System.Net.CookieContainer cContainer = new System.Net.CookieContainer();
// DEL 2005.05.27 東都）高木 セッション制御の廃止 END
// ADD 2005.05.25 東都）小童谷 スレッド化 START
		protected static 荷送人検索         g荷送検索  = null;
		protected static 会員マスタ         g会員マス  = null;
		protected static 会員検索           g会員検索  = null;
		protected static 会員情報ＣＳＶ出力 g会員出力  = null;
		protected static 記事登録           g記事登録  = null;
		protected static 集約店マスタ       g集約店マ  = null;
		protected static 住所検索           g住所検索  = null;
		protected static 請求先マスタ       g請求先マ  = null;
		protected static 店所検索           g店所検索  = null;
// DEL 2008.05.08 東都）高木 セクション検索削除 START
//		protected static 部門検索           g部門検索  = null;
// DEL 2008.05.08 東都）高木 セクション検索削除 END
// ADD 2006.07.11 東都）高木 画面変更 START
		protected static 会員加入           g会員加入  = null;
		protected static 加入検索           g加入検索  = null;
		protected static 稼働率情           g稼働率情  = null;
		protected static 出荷状況           g出荷状況  = null;
// ADD 2006.07.11 東都）高木 画面変更 END
// ADD 2006.11.06 東都）高木 店所情報画面の追加 START
		protected static 店所情報           g店所情報  = null;
// ADD 2006.11.06 東都）高木 店所情報画面の追加 END
// ADD 2005.05.25 東都）小童谷 スレッド化 END
// ADD 2005.05.27 東都）高木 メッセージ登録画面の追加 START
		protected static メッセージ登録     gメセ登録  = null;
// ADD 2005.05.27 東都）高木 メッセージ登録画面の追加 END
// ADD 2006.12.12 東都）高木 画面追加 START
		protected static 出荷照会           g出荷照会  = null;
// DEL 2008.05.07 東都）高木 ご依頼主検索削除 START
//		protected static ご依頼主検索       g依頼検索  = null;
// DEL 2008.05.07 東都）高木 ご依頼主検索削除 END
// MOD 2007.01.18 東都）高木 画面名の変更 START
//		protected static 着店仕分           g着店仕分  = null;
		protected static 発店仕分           g発店仕分  = null;
// MOD 2007.01.18 東都）高木 画面名の変更 END
// ADD 2006.12.12 東都）高木 画面追加 END
// ADD 2007.02.06 東都）高木 イメージロードエラー対応 START
		protected static 店所入力           g店所入力 = null;
// ADD 2007.02.06 東都）高木 イメージロードエラー対応 END
// ADD 2007.02.06 東都）高木 プレビュー画面の高速化 START
		protected static プレビュー画面     gプレビュ = null;
// ADD 2007.02.06 東都）高木 プレビュー画面の高速化 END
// ADD 2007.11.13 KCL) 森本 global対応用検索画面追加 START
		protected static 会員検索２         g会員検２  = null;
		protected static ご依頼主検索２     g依頼検２  = null;
// ADD 2007.11.13 KCL) 森本 global対応用検索画面追加 END
// ADD 2007.12.05 KCL) 森本 お知らせ追加 START
		protected static お知らせ登録       gお知登録  = null;
		protected static お知らせ検索       gお知検索  = null;
// ADD 2007.12.05 KCL) 森本 お知らせ追加 END
// MOD 2010.06.29 東都）高木 営業所用お知らせ登録機能の追加 START
		protected static お知らせ登録２     gお知登２  = null;
		protected static お知らせ検索２     gお知検２  = null;
// MOD 2010.06.29 東都）高木 営業所用お知らせ登録機能の追加 END
//中止 MOD 2008.12.08 東都）高木 営業所でのパスワード照会対応 START
//		protected static パスワード照会     gパス照会  = null;
//中止 MOD 2008.12.08 東都）高木 営業所でのパスワード照会対応 END
// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 START
		protected static 稼働日登録         g稼動日登  = null;
// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 END
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
		protected static お知らせ表示    gお知表示   = null;
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 START
		protected static マニュアルダウンロード    gマニュア  = null;
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 END
//ADD 2013.07.12 tdi）綱澤 東京テリトリ移管先ログイン対応 START
		protected static パス入力           gパス入力 = null;
//ADD 2013.07.12 tdi）綱澤 東京テリトリ移管先ログイン対応 END
// MOD 2016.04.13 BEVAS）松本 社内伝票対応 START
		protected static 社内伝会員発店マスタ   g社内伝 = null;
// MOD 2016.04.13 BEVAS）松本 社内伝票対応 END

// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 START
		protected static String gs通信エラー
			= "サーバーとの通信に失敗しました\n"
			+ " ＬＡＮケーブルやネットワーク設定等を確認してください";
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 END
// ADD 2006.08.02 東都）高木 都道府県ＣＤ配列の共通化 START
		protected static string[] sa県
			= { "",												// 都道府県ＣＤ
				  "北海道","青森県","岩手県","宮城県","秋田県",		// 01 -
				  "山形県","福島県","茨城県","栃木県","群馬県",		//    - 10
				  "埼玉県","千葉県","東京都","神奈川県","新潟県",	// 11 -
				  "富山県","石川県","福井県","山梨県","長野県",		//    - 20
				  "岐阜県","静岡県","愛知県","三重県","滋賀県",		// 21 -
				  "京都府","大阪府","兵庫県","奈良県","和歌山県",	//    - 30
				  "鳥取県","島根県","岡山県","広島県","山口県",		// 31 -
				  "徳島県","香川県","愛媛県","高知県","福岡県",		//    - 39
				  "佐賀県","長崎県","熊本県","大分県","宮崎県",		// 41 -
				  "鹿児島県","沖縄県"								//    - 
			  };
// ADD 2006.08.02 東都）高木 都道府県ＣＤ配列の共通化 END
// ADD 2006.11.06 東都）高木 店所情報画面の追加 START
		protected static Hashtable h県 = null;
// ADD 2006.11.06 東都）高木 店所情報画面の追加 END
// ADD 2006.12.12 東都）高木 画面追加 START
		protected static String[] gsa状態ＣＤ = {""};
		protected static String[] gsa状態名   = {""};
// ADD 2006.12.12 東都）高木 画面追加 END
// ADD 2008.04.11 ACT Vista対応 START
		protected static Hashtable gh漢字変換 = null;
// ADD 2008.04.11 ACT Vista対応 END
// MOD 2016.04.13 BEVAS）松本 社内伝票対応 START
		protected static string s社内伝票用郵便番号 = "XXX0044";
		protected static string s社内伝票用郵便番号表示用 = "XXX-0044";
// MOD 2016.04.13 BEVAS）松本 社内伝票対応 END

		[System.Runtime.InteropServices.DllImport("user32.dll")] 
		protected static extern int MessageBeep(uint n); 
// MOD 2010.11.19 東都）高木 配完情報などの取得 START
		[System.Runtime.InteropServices.DllImport("user32.dll")] 
		protected static extern short GetAsyncKeyState(Keys vKey); 
// MOD 2010.11.19 東都）高木 配完情報などの取得 END

		protected void エンター移動(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch(e.KeyCode)
			{
					// [Enter]キーが押された時、次のコントロールへフォーカス移動
				case Keys.Enter:
// MOD 2008.02.14 東都）高木 Vista対応 START
////					System.Windows.Forms.SendKeys.Send("{TAB}");
//					System.Windows.Forms.SendKeys.SendWait("{TAB}");
					// 別の方法 - その１
					//this.ProcessTabKey(!e.Shift);

					// 別の方法 - その２
					this.SelectNextControl(this.ActiveControl, true, true, true, true);
// MOD 2008.02.14 東都）高木 Vista対応 END
					break;
					// [Esc]キーが押された時、フォームを閉じる
				case Keys.Escape:
					Close();
					break;
			}
		}
		protected void エンターキャンセル(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 0x0d)
			{
				e.Handled = true;
			}
		}

		private void InitializeComponent()
		{
			// 
			// 共通フォーム
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Name = "共通フォーム";

		}
	
		protected static bool 必須チェック(TextBox tex, string name)
		{
			if(tex.Text.Length > 0) return true;
			MessageBox.Show("必須項目(" + name + ")が入力されていません",
				"入力チェック",MessageBoxButtons.OK);
			tex.Focus();
			return false;
		}

// ADD 2008.02.14 東都）高木 ＳＪＩＳチェック機能の追加 START
// MOD 2008.04.11 ACT Vista対応 START
//		private static bool ＳＪＩＳチェック(TextBox tex, string name, string sUnicode, byte[] bSjis)
		private static bool ＳＪＩＳチェック(TextBox tex, string name, ref string sUnicode, ref byte[] bSjis)
// MOD 2008.04.11 ACT Vista対応 END
		{
			//逆変換してＳＪＩＳ文字をチェックする
			string sRevUnicode = System.Text.Encoding.GetEncoding("shift-jis").GetString(bSjis);
			string sErrChars = "";
			for(int iPos = 0; iPos < sUnicode.Length && iPos < sRevUnicode.Length; iPos++)
			{
				if(sUnicode[iPos] != sRevUnicode[iPos])
				{
					sErrChars += sUnicode[iPos];
				}
			}
			if(sErrChars.Length > 0)
			{
// MOD 2008.04.11 ACT Vista対応 START
//				MessageBox.Show(name + "に使用できない文字があります\n"
//				+ "『" + sErrChars + "』",
//				"入力チェック",MessageBoxButtons.OK);
//				tex.Focus();
//				return false;
				return 漢字変換(tex, name, ref sUnicode, ref bSjis);
// MOD 2008.04.11 ACT Vista対応 END
			}
			return true;
		}
// ADD 2008.02.14 東都）高木 ＳＪＩＳチェック機能の追加 END

		protected static bool 全角チェック(TextBox tex, string name)
		{
			string sUnicode = tex.Text;
			byte[] bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sUnicode);
// MOD 2008.04.11 ACT Vista対応 START
//// ADD 2008.02.14 東都）高木 ＳＪＩＳチェック機能の追加 START
//			if(!ＳＪＩＳチェック(tex, name, sUnicode, bSjis)) return false;
			if(!ＳＪＩＳチェック(tex, name, ref sUnicode, ref bSjis)) return false;
//// ADD 2008.02.14 東都）高木 ＳＪＩＳチェック機能の追加 END
// MOD 2008.04.11 ACT Vista対応 END
			if(bSjis.Length == sUnicode.Length * 2) return true;
			MessageBox.Show(name + "は全角文字で入力してください",
				"入力チェック",MessageBoxButtons.OK);
			tex.Focus();
			return false;
		}
		protected static bool 半角チェック(TextBox tex, string name)
		{
			string sUnicode = tex.Text;
			byte[] bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sUnicode);
// MOD 2008.04.11 ACT Vista対応 START
//// ADD 2008.02.14 東都）高木 ＳＪＩＳチェック機能の追加 START
//			if(!ＳＪＩＳチェック(tex, name, sUnicode, bSjis)) return false;
			if(!ＳＪＩＳチェック(tex, name, ref sUnicode, ref bSjis)) return false;
//// ADD 2008.02.14 東都）高木 ＳＪＩＳチェック機能の追加 END
// MOD 2008.04.11 ACT Vista対応 END
			if(bSjis.Length != sUnicode.Length)
			{
				MessageBox.Show(name + "は半角文字で入力してください",
					"入力チェック",MessageBoxButtons.OK);
				tex.Focus();
				return false;
			}

			for(int i = 0; i < tex.Text.Length; i++)
			{
				// [!"#$%&'()*,]
				// [:;<=>?]
				// [[]^]
				// [{|}]
				// [\]
// MOD 2009.11.04 東都）高木 お届け先ＣＤに記号[+]を利用可能にする START
//				if((tex.Text[i] >= 0x21 && tex.Text[i] <= 0x2C)
				if((tex.Text[i] >= 0x21 && tex.Text[i] <= 0x2A)
					|| (tex.Text[i] == 0x2C)
// MOD 2009.11.04 東都）高木 お届け先ＣＤに記号[+]を利用可能にする END
					|| (tex.Text[i] >= 0x3A && tex.Text[i] <= 0x3F)
					|| (tex.Text[i] >= 0x5B && tex.Text[i] <= 0x5E)
					|| (tex.Text[i] >= 0x7B && tex.Text[i] <= 0x7D)
					|| (tex.Text[i] == 0xA5))
				{
					MessageBox.Show(name + "に記号が入力されています","入力チェック",MessageBoxButtons.OK);
					tex.Focus();
					return false;
				}
			}
			return true;
		}
// ADD 2008.05.07 東都）高木 全角半角混在チェック機能の追加 START
		protected static bool 全角半角混在チェック(TextBox tex, string name)
		{
			string sUnicode = tex.Text;
			byte[] bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sUnicode);
// MOD 2008.04.11 ACT Vista対応 START
//// ADD 2008.02.14 東都）高木 ＳＪＩＳチェック機能の追加 START
//			if(!ＳＪＩＳチェック(tex, name, sUnicode, bSjis)) return false;
			if(!ＳＪＩＳチェック(tex, name, ref sUnicode, ref bSjis)) return false;
//// ADD 2008.02.14 東都）高木 ＳＪＩＳチェック機能の追加 END
// MOD 2008.04.11 ACT Vista対応 END

			for(int i = 0; i < tex.Text.Length; i++)
			{
				// [!"#$%&'()*,]
				// [:;<=>?]
				// [[]^]
				// [{|}]
				// [\]
// MOD 2009.11.04 東都）高木 お届け先ＣＤに記号[+]を利用可能にする START
//				if((tex.Text[i] >= 0x21 && tex.Text[i] <= 0x2C)
				if((tex.Text[i] >= 0x21 && tex.Text[i] <= 0x2A)
					|| (tex.Text[i] == 0x2C)
// MOD 2009.11.04 東都）高木 お届け先ＣＤに記号[+]を利用可能にする END
					|| (tex.Text[i] >= 0x3A && tex.Text[i] <= 0x3F)
					|| (tex.Text[i] >= 0x5B && tex.Text[i] <= 0x5E)
					|| (tex.Text[i] >= 0x7B && tex.Text[i] <= 0x7D)
					|| (tex.Text[i] == 0xA5))
				{
					MessageBox.Show(name + "に記号が入力されています","入力チェック",MessageBoxButtons.OK);
					tex.Focus();
					return false;
				}
			}
			return true;
		}
// ADD 2008.05.07 東都）高木 全角半角混在チェック機能の追加 END
		protected static bool 数値チェック(TextBox tex, string name)
		{
			try
			{
				int iChk = int.Parse(tex.Text.Replace(",",""));
				return true;
			}
			catch(System.FormatException)
			{
				MessageBox.Show(name + "に数値が入力されていません","入力チェック",MessageBoxButtons.OK);
				tex.Focus();
				
				return false;
			}
		}
		//NumericUpDown用
		protected static bool 範囲チェック(NumericUpDown num, string name)
		{
			try
			{
				int iChk = int.Parse(num.Text.Replace(",", ""));
				if (iChk >= num.Minimum && iChk <= num.Maximum) return true;
				MessageBox.Show(name + "は" + num.Minimum + "～" + num.Maximum + "の間で入力してください","入力チェック",MessageBoxButtons.OK);
				num.Focus();
				return false;
			}
			catch(System.FormatException)
			{
				MessageBox.Show(name + "に数値が入力されていません","入力チェック",MessageBoxButtons.OK);
				num.Focus();
				return false;
			}
		}
// ADD 2006.07.11 東都）高木 画面変更 START
		//TextBox用
		protected static bool 範囲チェック(TextBox tex, string name, int iMinimum, int iMaximum)
		{
			try
			{
				int iChk = int.Parse(tex.Text.Replace(",", ""));
				if (iChk >= iMinimum && iChk <= iMaximum) return true;
				MessageBox.Show(name + "は" + iMinimum + "～" + iMaximum + "の間で入力してください","入力チェック",MessageBoxButtons.OK);
				tex.Focus();
				return false;
			}
			catch(System.FormatException)
			{
				MessageBox.Show(name + "に数値が入力されていません","入力チェック",MessageBoxButtons.OK);
				tex.Focus();
				return false;
			}
		}
// ADD 2006.07.11 東都）高木 画面変更 END

		protected static void ビープ音()
		{
			MessageBeep(0x00000030);
		}

		protected static byte[] toSJIS(string sデータ)
		{
			byte[] bSJIS;
// MOD 2010.05.24 東都）高木 ファイル出力時の改行コードの修正 START
//			bSJIS = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sデータ + "\n");
			bSJIS = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sデータ + "\r\n");
// MOD 2010.05.24 東都）高木 ファイル出力時の改行コードの修正 END
			return bSJIS;
		}

// ADD 2005.07.08 東都）高木 日付変換の変更 START
		protected static string YYYYMMDD変換(DateTime dtDate)
		{
			return dtDate.Year.ToString() + dtDate.ToString("MMdd");
		}
// ADD 2005.07.08 東都）高木 日付変換の変更 END

// ADD 2006.11.06 東都）高木 店所情報画面の追加 START
// MOD 2007.01.27 東都）高木 会員申込への追加 START
//		private static void 都道府県ハッシュ設定()
		protected static void 都道府県ハッシュ設定()
// MOD 2007.01.27 東都）高木 会員申込への追加 END
		{
			//都道府県ハッシュテーブルの作成
			if(h県 == null)
			{
				h県 = new Hashtable();
				for(int iCnt = 1; iCnt < sa県.Length; iCnt++)
				{
					h県.Add(sa県[iCnt], iCnt);
				}
			}
		}

		protected static bool 県名チェック(ComboBox cb県, string name)
		{
			//都道府県ハッシュテーブルの作成
			都道府県ハッシュ設定();

			Object obj = h県[cb県.Text];
			if(obj != null)
			{
				cb県.SelectedIndex = (int)obj;
				return true;
			}
			else
			{
				MessageBox.Show(name + "(" + cb県.Text + ")が存在しません",
					"入力チェック", MessageBoxButtons.OK);
				cb県.Focus();
				return false;
			}
		}

		protected static void 県設定(string s住所, ComboBox cb県, TextBox tex住所１)
		{
			//都道府県ハッシュテーブルの作成
			都道府県ハッシュ設定();

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
					cb県.SelectedIndex = (int)obj;
					s住所 = s住所.Remove(0,iIndex);
					tex住所１.Text = s住所;
				}
			}
		}
// ADD 2006.11.06 東都）高木 店所情報画面の追加 END

// ADD 2007.12.11 KCL) 森本 お知らせ追加 START
		protected static bool 日付チェック(TextBox tex, string name) 
		{
			bool retValue = true;

			try 
			{
				DateTime dt = DateTime.Parse(tex.Text.Trim());
			} 
			catch 
			{
				MessageBox.Show("日付は /（スラッシュ）, -（ハイフン）, .（ピリオド） 等で区切って入力して下さい\n　例 ： 2008/1/1","入力チェック",MessageBoxButtons.OK);
				tex.Focus();

				retValue = false;
			}

			return retValue;
		}
		protected static bool バイト数チェック(TextBox tex, string name, int length) 
		{
			bool retValue = true;

			byte [] byteArray = System.Text.Encoding.Unicode.GetBytes(tex.Text.Trim());
			if (byteArray.Length > length) 
			{
				string msg = string.Format("{0} に入力した文字数が多すぎます", name, length);
				MessageBox.Show(msg, "入力チェック", MessageBoxButtons.OK);
				tex.Focus();

				retValue = false;
			}

			return retValue;
		}
		protected static bool 禁則文字チェック(TextBox tex, string name) 
		{
			bool retValue = true;
			string s禁則文字 = @"[\a\b\f\t\v\|]";

			MatchCollection matchList = Regex.Matches(tex.Text.Trim(), s禁則文字);
			if (matchList.Count > 0)
			{
				string matchChar = " ";
				foreach (Match m in matchList) 
				{
					matchChar += string.Format("{0} ", m.Value);
				}
				string msg = string.Format("{0} に使用できない文字{1}が含まれています", name, matchChar);
				MessageBox.Show(msg, "入力チェック", MessageBoxButtons.OK);
				tex.Focus();

				retValue = false;
			}

			return retValue;
		}
		protected static bool ＵＲＬチェック(TextBox tex, string name) 
		{
			bool retValue = true;
			string sＵＲＬ = @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";

			if (! Regex.IsMatch(tex.Text.Trim(), sＵＲＬ)) 
			{
				string msg = string.Format("{0} がＵＲＬの形式ではありません", name);
				MessageBox.Show(msg, "入力チェック", MessageBoxButtons.OK);
				tex.Focus();

				retValue = false;
			}

			return retValue;
		}
		protected static DateTime YYYYMMDD変換(string sDate) 
		{
			DateTime retValue;

			try 
			{
				retValue = DateTime.ParseExact(
					sDate, 
					"yyyyMMdd",
					System.Globalization.DateTimeFormatInfo.InvariantInfo,
					System.Globalization.DateTimeStyles.None);
			} 
			catch 
			{
				retValue = DateTime.MinValue;
			}

			return retValue;
		}
// ADD 2007.12.11 KCL) 森本 お知らせ追加 END

// ADD 2008.04.11 ACT Vista対応 START
		protected static void 漢字変換ハッシュ設定()
		{
			string [,] s漢字変換 = CharConvUtility.CharConvUtility.GetCharConvTable();
			gh漢字変換  = new Hashtable();
			for(int iCnt = 0; iCnt < s漢字変換.GetLength(0); iCnt++)
			{
				gh漢字変換.Add(s漢字変換[iCnt,0],s漢字変換[iCnt,1]);
			}
		}

		private static bool 漢字変換(TextBox tex, string name, ref string sUnicode, ref byte[] bSjis)
		{
			string sErrChars = "";
			string sOKHChars = "";
			string sNotHChars = "";
			string sAllChars = "";
			string sBefChars = "";
			string sMessage = "";
			string sMessage2 = "";
			string sAfterCode = null;
			int iNotHash = 0;

			string sOneMozi = "";
			string sOneUni = "";
			System.Text.Encoding enc = System.Text.Encoding.GetEncoding("unicodeFFFE");
			//文字列の中から1文字ずつ取り出す
			System.Globalization.TextElementEnumerator Enumerator = System.Globalization.StringInfo.GetTextElementEnumerator(sUnicode);
			while (Enumerator.MoveNext())
			{
				sOneMozi = Enumerator.Current.ToString();

				//取り出した1文字をバイト型に変換
				byte[] bOneCode = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sOneMozi);
				//バイト型をstring型に変換
				string sRevUnicode = System.Text.Encoding.GetEncoding("shift-jis").GetString(bOneCode);

				if(sOneMozi != sRevUnicode)
				{
					//変換テーブルの8桁対応
					byte [] bytes = enc.GetBytes(sOneMozi);
					sOneUni = BitConverter.ToString(bytes).Replace("-","");
					if(sOneUni.Length == 4)
					{
						sOneUni += sOneUni;
					}
					//漢字変換
					sAfterCode = (string)gh漢字変換[sOneUni];
					if(sAfterCode != null)
					{
						if(sAfterCode == "" || sAfterCode == "4040")
						{	
							//変換できない文字を代入
							sNotHChars += sOneMozi;
							sAllChars += sOneMozi;
						}
						else
						{
							//コードから文字を取得
							int iAfter = Convert.ToInt16(sAfterCode,16);
							char cAfter = (char)iAfter;
							string sAfterL = Convert.ToString(cAfter);
							//変換後の文字を代入
							sOKHChars += sAfterL;
							sAllChars += sAfterL;
							//変換前の文字を代入
							sBefChars += sOneMozi;
						}	
					}
					else
					{
						//テーブルに存在しない文字を代入
						sErrChars += sOneMozi;
						sAllChars += sOneMozi;
						sAfterCode = "";
						iNotHash = 1;					
					}	
				}
				else
				{	
					sAllChars += sOneMozi;
				}
			}
			Enumerator.Reset();

			bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sAllChars);
			string sBefMozi = "";
			sBefMozi = sUnicode;

			if(sAfterCode != null)
			{
				if(sNotHChars.Length > 0)
				{
					sMessage = "2";
				}
				else if(sOKHChars.Length > 0)
				{
					sMessage = "1";
				}
			}

			if(iNotHash == 1)
			{
				sMessage2 = "3";
			}

			if(sMessage == "1")
			{
				tex.Text = sAllChars;
				DialogResult result = MessageBox.Show(name + "はVista対応により文字変換をおこないました\n" 
					+ "『" + sBefChars + " → " + sOKHChars + "』", "入力チェック", 
					MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				if (result == DialogResult.Cancel)
				{
					tex.Text = sBefMozi;
					tex.Focus();
					return false;
				}
				else
				{
					sUnicode = sAllChars;
				}
			}
			if(sMessage == "2")
			{
				MessageBox.Show(name + "はVista対応により文字変換がおこなえませんでした\n"
					+ "『" + sNotHChars + " → ? 』",
					"入力チェック",MessageBoxButtons.OK);
				if(sMessage2 != "3")
				{
					tex.Focus();
					return false;
				}
			}
			if(sMessage2 == "3")
			{
				MessageBox.Show(name + "に使用できない文字があります\n"
					+ "『" + sErrChars + " → ? 』",
					"入力チェック",MessageBoxButtons.OK);
				tex.Focus();
				return false;
			}
			return true;
		}
// ADD 2008.04.11 ACT Vista対応 END
	}
}
