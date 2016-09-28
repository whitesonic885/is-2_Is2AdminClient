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
	public class 稼働日登録 : 共通フォーム
	{
		private static Color color平日   = Color.Honeydew;
		private static Color color休日   = Color.LightPink;
		private static Color colorその他 = Color.LightBlue;
		private static Color color休日その他 = Color.Plum;
		private DateTime dt開始日;
		private DateTime dt終了日;
		private int      i開始位置;
		private char[]   c稼働日;		
		private char[]   cその他;		
		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label labメッセージタイトル;
		private System.Windows.Forms.TextBox texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn保存;
		private System.Windows.Forms.Button btn11;
		private System.Windows.Forms.Button btn前月;
		private System.Windows.Forms.Button btn次月;
		private System.Windows.Forms.Button btn67;
		private System.Windows.Forms.Button btn66;
		private System.Windows.Forms.Button btn65;
		private System.Windows.Forms.Button btn64;
		private System.Windows.Forms.Button btn63;
		private System.Windows.Forms.Button btn62;
		private System.Windows.Forms.Button btn61;
		private System.Windows.Forms.Button btn57;
		private System.Windows.Forms.Button btn56;
		private System.Windows.Forms.Button btn55;
		private System.Windows.Forms.Button btn54;
		private System.Windows.Forms.Button btn53;
		private System.Windows.Forms.Button btn52;
		private System.Windows.Forms.Button btn51;
		private System.Windows.Forms.Button btn47;
		private System.Windows.Forms.Button btn46;
		private System.Windows.Forms.Button btn45;
		private System.Windows.Forms.Button btn44;
		private System.Windows.Forms.Button btn43;
		private System.Windows.Forms.Button btn42;
		private System.Windows.Forms.Button btn41;
		private System.Windows.Forms.Button btn37;
		private System.Windows.Forms.Button btn36;
		private System.Windows.Forms.Button btn35;
		private System.Windows.Forms.Button btn34;
		private System.Windows.Forms.Button btn33;
		private System.Windows.Forms.Button btn32;
		private System.Windows.Forms.Button btn31;
		private System.Windows.Forms.Button btn27;
		private System.Windows.Forms.Button btn26;
		private System.Windows.Forms.Button btn25;
		private System.Windows.Forms.Button btn24;
		private System.Windows.Forms.Button btn23;
		private System.Windows.Forms.Button btn22;
		private System.Windows.Forms.Button btn21;
		private System.Windows.Forms.Button btn17;
		private System.Windows.Forms.Button btn16;
		private System.Windows.Forms.Button btn15;
		private System.Windows.Forms.Button btn14;
		private System.Windows.Forms.Button btn13;
		private System.Windows.Forms.Button btn12;
		private System.Windows.Forms.Label lab月月;
		private System.Windows.Forms.Label lab年年;
		private System.Windows.Forms.Label lab年;
		private System.Windows.Forms.Label lab月;
		private System.Windows.Forms.RadioButton rb休日;
		private System.Windows.Forms.RadioButton rbその他;
		private System.Windows.Forms.Label lab土曜日;
		private System.Windows.Forms.Label lab金曜日;
		private System.Windows.Forms.Label lab木曜日;
		private System.Windows.Forms.Label lab水曜日;
		private System.Windows.Forms.Label lab火曜日;
		private System.Windows.Forms.Label lab月曜日;
		private System.Windows.Forms.Label lab日曜日;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 稼働日登録()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(稼働日登録));
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbその他 = new System.Windows.Forms.RadioButton();
			this.rb休日 = new System.Windows.Forms.RadioButton();
			this.lab月 = new System.Windows.Forms.Label();
			this.lab年 = new System.Windows.Forms.Label();
			this.btn次月 = new System.Windows.Forms.Button();
			this.btn前月 = new System.Windows.Forms.Button();
			this.lab月月 = new System.Windows.Forms.Label();
			this.lab年年 = new System.Windows.Forms.Label();
			this.btn67 = new System.Windows.Forms.Button();
			this.btn66 = new System.Windows.Forms.Button();
			this.btn65 = new System.Windows.Forms.Button();
			this.btn64 = new System.Windows.Forms.Button();
			this.btn63 = new System.Windows.Forms.Button();
			this.btn62 = new System.Windows.Forms.Button();
			this.btn61 = new System.Windows.Forms.Button();
			this.btn57 = new System.Windows.Forms.Button();
			this.btn56 = new System.Windows.Forms.Button();
			this.btn55 = new System.Windows.Forms.Button();
			this.btn54 = new System.Windows.Forms.Button();
			this.btn53 = new System.Windows.Forms.Button();
			this.btn52 = new System.Windows.Forms.Button();
			this.btn51 = new System.Windows.Forms.Button();
			this.btn47 = new System.Windows.Forms.Button();
			this.btn46 = new System.Windows.Forms.Button();
			this.btn45 = new System.Windows.Forms.Button();
			this.btn44 = new System.Windows.Forms.Button();
			this.btn43 = new System.Windows.Forms.Button();
			this.btn42 = new System.Windows.Forms.Button();
			this.btn41 = new System.Windows.Forms.Button();
			this.btn37 = new System.Windows.Forms.Button();
			this.btn36 = new System.Windows.Forms.Button();
			this.btn35 = new System.Windows.Forms.Button();
			this.btn34 = new System.Windows.Forms.Button();
			this.btn33 = new System.Windows.Forms.Button();
			this.btn32 = new System.Windows.Forms.Button();
			this.btn31 = new System.Windows.Forms.Button();
			this.btn27 = new System.Windows.Forms.Button();
			this.btn26 = new System.Windows.Forms.Button();
			this.btn25 = new System.Windows.Forms.Button();
			this.btn24 = new System.Windows.Forms.Button();
			this.btn23 = new System.Windows.Forms.Button();
			this.btn22 = new System.Windows.Forms.Button();
			this.btn21 = new System.Windows.Forms.Button();
			this.lab土曜日 = new System.Windows.Forms.Label();
			this.lab金曜日 = new System.Windows.Forms.Label();
			this.lab木曜日 = new System.Windows.Forms.Label();
			this.lab水曜日 = new System.Windows.Forms.Label();
			this.lab火曜日 = new System.Windows.Forms.Label();
			this.lab月曜日 = new System.Windows.Forms.Label();
			this.btn17 = new System.Windows.Forms.Button();
			this.btn16 = new System.Windows.Forms.Button();
			this.btn15 = new System.Windows.Forms.Button();
			this.btn14 = new System.Windows.Forms.Button();
			this.btn13 = new System.Windows.Forms.Button();
			this.btn12 = new System.Windows.Forms.Button();
			this.btn11 = new System.Windows.Forms.Button();
			this.lab日曜日 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.labメッセージタイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn保存 = new System.Windows.Forms.Button();
			this.texメッセージ = new System.Windows.Forms.TextBox();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.rbその他);
			this.panel1.Controls.Add(this.rb休日);
			this.panel1.Controls.Add(this.lab月);
			this.panel1.Controls.Add(this.lab年);
			this.panel1.Controls.Add(this.btn次月);
			this.panel1.Controls.Add(this.btn前月);
			this.panel1.Controls.Add(this.lab月月);
			this.panel1.Controls.Add(this.lab年年);
			this.panel1.Controls.Add(this.btn67);
			this.panel1.Controls.Add(this.btn66);
			this.panel1.Controls.Add(this.btn65);
			this.panel1.Controls.Add(this.btn64);
			this.panel1.Controls.Add(this.btn63);
			this.panel1.Controls.Add(this.btn62);
			this.panel1.Controls.Add(this.btn61);
			this.panel1.Controls.Add(this.btn57);
			this.panel1.Controls.Add(this.btn56);
			this.panel1.Controls.Add(this.btn55);
			this.panel1.Controls.Add(this.btn54);
			this.panel1.Controls.Add(this.btn53);
			this.panel1.Controls.Add(this.btn52);
			this.panel1.Controls.Add(this.btn51);
			this.panel1.Controls.Add(this.btn47);
			this.panel1.Controls.Add(this.btn46);
			this.panel1.Controls.Add(this.btn45);
			this.panel1.Controls.Add(this.btn44);
			this.panel1.Controls.Add(this.btn43);
			this.panel1.Controls.Add(this.btn42);
			this.panel1.Controls.Add(this.btn41);
			this.panel1.Controls.Add(this.btn37);
			this.panel1.Controls.Add(this.btn36);
			this.panel1.Controls.Add(this.btn35);
			this.panel1.Controls.Add(this.btn34);
			this.panel1.Controls.Add(this.btn33);
			this.panel1.Controls.Add(this.btn32);
			this.panel1.Controls.Add(this.btn31);
			this.panel1.Controls.Add(this.btn27);
			this.panel1.Controls.Add(this.btn26);
			this.panel1.Controls.Add(this.btn25);
			this.panel1.Controls.Add(this.btn24);
			this.panel1.Controls.Add(this.btn23);
			this.panel1.Controls.Add(this.btn22);
			this.panel1.Controls.Add(this.btn21);
			this.panel1.Controls.Add(this.lab土曜日);
			this.panel1.Controls.Add(this.lab金曜日);
			this.panel1.Controls.Add(this.lab木曜日);
			this.panel1.Controls.Add(this.lab水曜日);
			this.panel1.Controls.Add(this.lab火曜日);
			this.panel1.Controls.Add(this.lab月曜日);
			this.panel1.Controls.Add(this.btn17);
			this.panel1.Controls.Add(this.btn16);
			this.panel1.Controls.Add(this.btn15);
			this.panel1.Controls.Add(this.btn14);
			this.panel1.Controls.Add(this.btn13);
			this.panel1.Controls.Add(this.btn12);
			this.panel1.Controls.Add(this.btn11);
			this.panel1.Controls.Add(this.lab日曜日);
			this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel1.Location = new System.Drawing.Point(4, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(774, 442);
			this.panel1.TabIndex = 0;
			// 
			// rbその他
			// 
			this.rbその他.BackColor = System.Drawing.Color.LightBlue;
			this.rbその他.Location = new System.Drawing.Point(660, 112);
			this.rbその他.Name = "rbその他";
			this.rbその他.Size = new System.Drawing.Size(64, 23);
			this.rbその他.TabIndex = 120;
			this.rbその他.Text = "その他";
			// 
			// rb休日
			// 
			this.rb休日.BackColor = System.Drawing.Color.LightPink;
			this.rb休日.Checked = true;
			this.rb休日.Location = new System.Drawing.Point(660, 84);
			this.rb休日.Name = "rb休日";
			this.rb休日.Size = new System.Drawing.Size(64, 23);
			this.rb休日.TabIndex = 119;
			this.rb休日.TabStop = true;
			this.rb休日.Text = "休　日";
			// 
			// lab月
			// 
			this.lab月.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab月.ForeColor = System.Drawing.Color.Black;
			this.lab月.Location = new System.Drawing.Point(346, 20);
			this.lab月.Name = "lab月";
			this.lab月.Size = new System.Drawing.Size(22, 20);
			this.lab月.TabIndex = 116;
			this.lab月.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab年
			// 
			this.lab年.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab年.ForeColor = System.Drawing.Color.Black;
			this.lab年.Location = new System.Drawing.Point(262, 20);
			this.lab年.Name = "lab年";
			this.lab年.Size = new System.Drawing.Size(48, 20);
			this.lab年.TabIndex = 115;
			this.lab年.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn次月
			// 
			this.btn次月.Location = new System.Drawing.Point(462, 18);
			this.btn次月.Name = "btn次月";
			this.btn次月.Size = new System.Drawing.Size(50, 24);
			this.btn次月.TabIndex = 0;
			this.btn次月.Text = "次 月";
			this.btn次月.Click += new System.EventHandler(this.btn次月_Click);
			// 
			// btn前月
			// 
			this.btn前月.Location = new System.Drawing.Point(404, 18);
			this.btn前月.Name = "btn前月";
			this.btn前月.Size = new System.Drawing.Size(50, 24);
			this.btn前月.TabIndex = 43;
			this.btn前月.Text = "前 月";
			this.btn前月.Click += new System.EventHandler(this.btn前月_Click);
			// 
			// lab月月
			// 
			this.lab月月.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab月月.ForeColor = System.Drawing.Color.Black;
			this.lab月月.Location = new System.Drawing.Point(370, 20);
			this.lab月月.Name = "lab月月";
			this.lab月月.Size = new System.Drawing.Size(22, 20);
			this.lab月月.TabIndex = 107;
			this.lab月月.Text = "月";
			this.lab月月.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab年年
			// 
			this.lab年年.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab年年.ForeColor = System.Drawing.Color.Black;
			this.lab年年.Location = new System.Drawing.Point(312, 20);
			this.lab年年.Name = "lab年年";
			this.lab年年.Size = new System.Drawing.Size(22, 20);
			this.lab年年.TabIndex = 106;
			this.lab年年.Text = "年";
			this.lab年年.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn67
			// 
			this.btn67.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn67.Location = new System.Drawing.Point(570, 374);
			this.btn67.Name = "btn67";
			this.btn67.Size = new System.Drawing.Size(66, 52);
			this.btn67.TabIndex = 42;
			// 
			// btn66
			// 
			this.btn66.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn66.Location = new System.Drawing.Point(498, 374);
			this.btn66.Name = "btn66";
			this.btn66.Size = new System.Drawing.Size(66, 52);
			this.btn66.TabIndex = 41;
			// 
			// btn65
			// 
			this.btn65.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn65.Location = new System.Drawing.Point(426, 374);
			this.btn65.Name = "btn65";
			this.btn65.Size = new System.Drawing.Size(66, 52);
			this.btn65.TabIndex = 40;
			// 
			// btn64
			// 
			this.btn64.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn64.Location = new System.Drawing.Point(354, 374);
			this.btn64.Name = "btn64";
			this.btn64.Size = new System.Drawing.Size(66, 52);
			this.btn64.TabIndex = 39;
			// 
			// btn63
			// 
			this.btn63.BackColor = System.Drawing.Color.Plum;
			this.btn63.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn63.Location = new System.Drawing.Point(282, 374);
			this.btn63.Name = "btn63";
			this.btn63.Size = new System.Drawing.Size(66, 52);
			this.btn63.TabIndex = 38;
			// 
			// btn62
			// 
			this.btn62.BackColor = System.Drawing.Color.LightBlue;
			this.btn62.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn62.Location = new System.Drawing.Point(210, 374);
			this.btn62.Name = "btn62";
			this.btn62.Size = new System.Drawing.Size(66, 52);
			this.btn62.TabIndex = 37;
			// 
			// btn61
			// 
			this.btn61.BackColor = System.Drawing.Color.LightPink;
			this.btn61.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn61.Location = new System.Drawing.Point(138, 374);
			this.btn61.Name = "btn61";
			this.btn61.Size = new System.Drawing.Size(66, 52);
			this.btn61.TabIndex = 36;
			// 
			// btn57
			// 
			this.btn57.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn57.Location = new System.Drawing.Point(570, 316);
			this.btn57.Name = "btn57";
			this.btn57.Size = new System.Drawing.Size(66, 52);
			this.btn57.TabIndex = 35;
			// 
			// btn56
			// 
			this.btn56.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn56.Location = new System.Drawing.Point(498, 316);
			this.btn56.Name = "btn56";
			this.btn56.Size = new System.Drawing.Size(66, 52);
			this.btn56.TabIndex = 34;
			// 
			// btn55
			// 
			this.btn55.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn55.Location = new System.Drawing.Point(426, 316);
			this.btn55.Name = "btn55";
			this.btn55.Size = new System.Drawing.Size(66, 52);
			this.btn55.TabIndex = 33;
			// 
			// btn54
			// 
			this.btn54.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn54.Location = new System.Drawing.Point(354, 316);
			this.btn54.Name = "btn54";
			this.btn54.Size = new System.Drawing.Size(66, 52);
			this.btn54.TabIndex = 32;
			// 
			// btn53
			// 
			this.btn53.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn53.Location = new System.Drawing.Point(282, 316);
			this.btn53.Name = "btn53";
			this.btn53.Size = new System.Drawing.Size(66, 52);
			this.btn53.TabIndex = 31;
			this.btn53.Text = "31";
			// 
			// btn52
			// 
			this.btn52.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn52.Location = new System.Drawing.Point(210, 316);
			this.btn52.Name = "btn52";
			this.btn52.Size = new System.Drawing.Size(66, 52);
			this.btn52.TabIndex = 30;
			this.btn52.Text = "30";
			// 
			// btn51
			// 
			this.btn51.BackColor = System.Drawing.Color.LightPink;
			this.btn51.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn51.Location = new System.Drawing.Point(138, 316);
			this.btn51.Name = "btn51";
			this.btn51.Size = new System.Drawing.Size(66, 52);
			this.btn51.TabIndex = 29;
			this.btn51.Text = "29";
			// 
			// btn47
			// 
			this.btn47.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn47.Location = new System.Drawing.Point(570, 258);
			this.btn47.Name = "btn47";
			this.btn47.Size = new System.Drawing.Size(66, 52);
			this.btn47.TabIndex = 28;
			this.btn47.Text = "28";
			// 
			// btn46
			// 
			this.btn46.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn46.Location = new System.Drawing.Point(498, 258);
			this.btn46.Name = "btn46";
			this.btn46.Size = new System.Drawing.Size(66, 52);
			this.btn46.TabIndex = 27;
			this.btn46.Text = "27";
			// 
			// btn45
			// 
			this.btn45.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn45.Location = new System.Drawing.Point(426, 258);
			this.btn45.Name = "btn45";
			this.btn45.Size = new System.Drawing.Size(66, 52);
			this.btn45.TabIndex = 26;
			this.btn45.Text = "26";
			// 
			// btn44
			// 
			this.btn44.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn44.Location = new System.Drawing.Point(354, 258);
			this.btn44.Name = "btn44";
			this.btn44.Size = new System.Drawing.Size(66, 52);
			this.btn44.TabIndex = 25;
			this.btn44.Text = "25";
			// 
			// btn43
			// 
			this.btn43.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn43.Location = new System.Drawing.Point(282, 258);
			this.btn43.Name = "btn43";
			this.btn43.Size = new System.Drawing.Size(66, 52);
			this.btn43.TabIndex = 24;
			this.btn43.Text = "24";
			// 
			// btn42
			// 
			this.btn42.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn42.Location = new System.Drawing.Point(210, 258);
			this.btn42.Name = "btn42";
			this.btn42.Size = new System.Drawing.Size(66, 52);
			this.btn42.TabIndex = 23;
			this.btn42.Text = "23";
			// 
			// btn41
			// 
			this.btn41.BackColor = System.Drawing.Color.LightPink;
			this.btn41.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn41.Location = new System.Drawing.Point(138, 258);
			this.btn41.Name = "btn41";
			this.btn41.Size = new System.Drawing.Size(66, 52);
			this.btn41.TabIndex = 22;
			this.btn41.Text = "22";
			// 
			// btn37
			// 
			this.btn37.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn37.Location = new System.Drawing.Point(570, 200);
			this.btn37.Name = "btn37";
			this.btn37.Size = new System.Drawing.Size(66, 52);
			this.btn37.TabIndex = 21;
			this.btn37.Text = "21";
			// 
			// btn36
			// 
			this.btn36.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn36.Location = new System.Drawing.Point(498, 200);
			this.btn36.Name = "btn36";
			this.btn36.Size = new System.Drawing.Size(66, 52);
			this.btn36.TabIndex = 20;
			this.btn36.Text = "20";
			// 
			// btn35
			// 
			this.btn35.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn35.Location = new System.Drawing.Point(426, 200);
			this.btn35.Name = "btn35";
			this.btn35.Size = new System.Drawing.Size(66, 52);
			this.btn35.TabIndex = 19;
			this.btn35.Text = "19";
			// 
			// btn34
			// 
			this.btn34.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn34.Location = new System.Drawing.Point(354, 200);
			this.btn34.Name = "btn34";
			this.btn34.Size = new System.Drawing.Size(66, 52);
			this.btn34.TabIndex = 18;
			this.btn34.Text = "18";
			// 
			// btn33
			// 
			this.btn33.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn33.Location = new System.Drawing.Point(282, 200);
			this.btn33.Name = "btn33";
			this.btn33.Size = new System.Drawing.Size(66, 52);
			this.btn33.TabIndex = 17;
			this.btn33.Text = "17";
			// 
			// btn32
			// 
			this.btn32.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn32.Location = new System.Drawing.Point(210, 200);
			this.btn32.Name = "btn32";
			this.btn32.Size = new System.Drawing.Size(66, 52);
			this.btn32.TabIndex = 16;
			this.btn32.Text = "16";
			// 
			// btn31
			// 
			this.btn31.BackColor = System.Drawing.Color.LightPink;
			this.btn31.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn31.Location = new System.Drawing.Point(138, 200);
			this.btn31.Name = "btn31";
			this.btn31.Size = new System.Drawing.Size(66, 52);
			this.btn31.TabIndex = 15;
			this.btn31.Text = "15";
			// 
			// btn27
			// 
			this.btn27.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn27.Location = new System.Drawing.Point(570, 142);
			this.btn27.Name = "btn27";
			this.btn27.Size = new System.Drawing.Size(66, 52);
			this.btn27.TabIndex = 14;
			this.btn27.Text = "14";
			// 
			// btn26
			// 
			this.btn26.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn26.Location = new System.Drawing.Point(498, 142);
			this.btn26.Name = "btn26";
			this.btn26.Size = new System.Drawing.Size(66, 52);
			this.btn26.TabIndex = 13;
			this.btn26.Text = "13";
			// 
			// btn25
			// 
			this.btn25.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn25.Location = new System.Drawing.Point(426, 142);
			this.btn25.Name = "btn25";
			this.btn25.Size = new System.Drawing.Size(66, 52);
			this.btn25.TabIndex = 12;
			this.btn25.Text = "12";
			// 
			// btn24
			// 
			this.btn24.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn24.Location = new System.Drawing.Point(354, 142);
			this.btn24.Name = "btn24";
			this.btn24.Size = new System.Drawing.Size(66, 52);
			this.btn24.TabIndex = 11;
			this.btn24.Text = "11";
			// 
			// btn23
			// 
			this.btn23.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn23.Location = new System.Drawing.Point(282, 142);
			this.btn23.Name = "btn23";
			this.btn23.Size = new System.Drawing.Size(66, 52);
			this.btn23.TabIndex = 10;
			this.btn23.Text = "10";
			// 
			// btn22
			// 
			this.btn22.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn22.Location = new System.Drawing.Point(210, 142);
			this.btn22.Name = "btn22";
			this.btn22.Size = new System.Drawing.Size(66, 52);
			this.btn22.TabIndex = 9;
			this.btn22.Text = "9";
			// 
			// btn21
			// 
			this.btn21.BackColor = System.Drawing.Color.LightPink;
			this.btn21.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn21.Location = new System.Drawing.Point(138, 142);
			this.btn21.Name = "btn21";
			this.btn21.Size = new System.Drawing.Size(66, 52);
			this.btn21.TabIndex = 8;
			this.btn21.Text = "8";
			// 
			// lab土曜日
			// 
			this.lab土曜日.BackColor = System.Drawing.Color.PaleGreen;
			this.lab土曜日.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab土曜日.ForeColor = System.Drawing.Color.Black;
			this.lab土曜日.Location = new System.Drawing.Point(570, 60);
			this.lab土曜日.Name = "lab土曜日";
			this.lab土曜日.Size = new System.Drawing.Size(66, 18);
			this.lab土曜日.TabIndex = 69;
			this.lab土曜日.Text = "土";
			this.lab土曜日.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab金曜日
			// 
			this.lab金曜日.BackColor = System.Drawing.Color.PaleGreen;
			this.lab金曜日.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab金曜日.ForeColor = System.Drawing.Color.Black;
			this.lab金曜日.Location = new System.Drawing.Point(498, 60);
			this.lab金曜日.Name = "lab金曜日";
			this.lab金曜日.Size = new System.Drawing.Size(66, 18);
			this.lab金曜日.TabIndex = 68;
			this.lab金曜日.Text = "金";
			this.lab金曜日.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab木曜日
			// 
			this.lab木曜日.BackColor = System.Drawing.Color.PaleGreen;
			this.lab木曜日.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab木曜日.ForeColor = System.Drawing.Color.Black;
			this.lab木曜日.Location = new System.Drawing.Point(426, 60);
			this.lab木曜日.Name = "lab木曜日";
			this.lab木曜日.Size = new System.Drawing.Size(66, 18);
			this.lab木曜日.TabIndex = 67;
			this.lab木曜日.Text = "木";
			this.lab木曜日.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab水曜日
			// 
			this.lab水曜日.BackColor = System.Drawing.Color.PaleGreen;
			this.lab水曜日.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab水曜日.ForeColor = System.Drawing.Color.Black;
			this.lab水曜日.Location = new System.Drawing.Point(354, 60);
			this.lab水曜日.Name = "lab水曜日";
			this.lab水曜日.Size = new System.Drawing.Size(66, 18);
			this.lab水曜日.TabIndex = 66;
			this.lab水曜日.Text = "水";
			this.lab水曜日.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab火曜日
			// 
			this.lab火曜日.BackColor = System.Drawing.Color.PaleGreen;
			this.lab火曜日.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab火曜日.ForeColor = System.Drawing.Color.Black;
			this.lab火曜日.Location = new System.Drawing.Point(282, 60);
			this.lab火曜日.Name = "lab火曜日";
			this.lab火曜日.Size = new System.Drawing.Size(66, 18);
			this.lab火曜日.TabIndex = 65;
			this.lab火曜日.Text = "火";
			this.lab火曜日.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab月曜日
			// 
			this.lab月曜日.BackColor = System.Drawing.Color.PaleGreen;
			this.lab月曜日.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab月曜日.ForeColor = System.Drawing.Color.Black;
			this.lab月曜日.Location = new System.Drawing.Point(210, 60);
			this.lab月曜日.Name = "lab月曜日";
			this.lab月曜日.Size = new System.Drawing.Size(66, 18);
			this.lab月曜日.TabIndex = 64;
			this.lab月曜日.Text = "月";
			this.lab月曜日.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn17
			// 
			this.btn17.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn17.Location = new System.Drawing.Point(570, 84);
			this.btn17.Name = "btn17";
			this.btn17.Size = new System.Drawing.Size(66, 52);
			this.btn17.TabIndex = 7;
			this.btn17.Text = "7";
			// 
			// btn16
			// 
			this.btn16.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn16.Location = new System.Drawing.Point(498, 84);
			this.btn16.Name = "btn16";
			this.btn16.Size = new System.Drawing.Size(66, 52);
			this.btn16.TabIndex = 6;
			this.btn16.Text = "6";
			// 
			// btn15
			// 
			this.btn15.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn15.Location = new System.Drawing.Point(426, 84);
			this.btn15.Name = "btn15";
			this.btn15.Size = new System.Drawing.Size(66, 52);
			this.btn15.TabIndex = 5;
			this.btn15.Text = "5";
			// 
			// btn14
			// 
			this.btn14.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn14.Location = new System.Drawing.Point(354, 84);
			this.btn14.Name = "btn14";
			this.btn14.Size = new System.Drawing.Size(66, 52);
			this.btn14.TabIndex = 4;
			this.btn14.Text = "4";
			// 
			// btn13
			// 
			this.btn13.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn13.Location = new System.Drawing.Point(282, 84);
			this.btn13.Name = "btn13";
			this.btn13.Size = new System.Drawing.Size(66, 52);
			this.btn13.TabIndex = 3;
			this.btn13.Text = "3";
			// 
			// btn12
			// 
			this.btn12.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn12.Location = new System.Drawing.Point(210, 84);
			this.btn12.Name = "btn12";
			this.btn12.Size = new System.Drawing.Size(66, 52);
			this.btn12.TabIndex = 2;
			this.btn12.Text = "2";
			// 
			// btn11
			// 
			this.btn11.BackColor = System.Drawing.Color.LightPink;
			this.btn11.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn11.Location = new System.Drawing.Point(138, 84);
			this.btn11.Name = "btn11";
			this.btn11.Size = new System.Drawing.Size(66, 52);
			this.btn11.TabIndex = 1;
			this.btn11.Text = "1";
			// 
			// lab日曜日
			// 
			this.lab日曜日.BackColor = System.Drawing.Color.PaleGreen;
			this.lab日曜日.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab日曜日.ForeColor = System.Drawing.Color.Black;
			this.lab日曜日.Location = new System.Drawing.Point(138, 60);
			this.lab日曜日.Name = "lab日曜日";
			this.lab日曜日.Size = new System.Drawing.Size(66, 18);
			this.lab日曜日.TabIndex = 56;
			this.lab日曜日.Text = "日";
			this.lab日曜日.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.labメッセージタイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(796, 26);
			this.panel7.TabIndex = 0;
			// 
			// labメッセージタイトル
			// 
			this.labメッセージタイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.labメッセージタイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labメッセージタイトル.ForeColor = System.Drawing.Color.White;
			this.labメッセージタイトル.Location = new System.Drawing.Point(12, 2);
			this.labメッセージタイトル.Name = "labメッセージタイトル";
			this.labメッセージタイトル.Size = new System.Drawing.Size(264, 24);
			this.labメッセージタイトル.TabIndex = 0;
			this.labメッセージタイトル.Text = "稼働日登録";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btn保存);
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 518);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(796, 58);
			this.panel8.TabIndex = 2;
			// 
			// btn保存
			// 
			this.btn保存.ForeColor = System.Drawing.Color.Blue;
			this.btn保存.Location = new System.Drawing.Point(76, 6);
			this.btn保存.Name = "btn保存";
			this.btn保存.Size = new System.Drawing.Size(54, 48);
			this.btn保存.TabIndex = 0;
			this.btn保存.Text = "保存";
			this.btn保存.Click += new System.EventHandler(this.btn保存_Click);
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(412, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(376, 50);
			this.texメッセージ.TabIndex = 2;
			this.texメッセージ.TabStop = false;
			this.texメッセージ.Text = "";
			// 
			// btn閉じる
			// 
			this.btn閉じる.ForeColor = System.Drawing.Color.Red;
			this.btn閉じる.Location = new System.Drawing.Point(8, 6);
			this.btn閉じる.Name = "btn閉じる";
			this.btn閉じる.Size = new System.Drawing.Size(54, 48);
			this.btn閉じる.TabIndex = 1;
			this.btn閉じる.TabStop = false;
			this.btn閉じる.Text = "閉じる";
			this.btn閉じる.Click += new System.EventHandler(this.btn閉じる_Click);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(796, 26);
			this.panel6.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(8, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(780, 452);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// 稼働日登録
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 575);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "稼働日登録";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 稼働日登録";
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 START
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 END
            this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.メッセージ登録_Closed);
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			dt開始日 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

			カレンダ初期表示();
			稼働日情報取得();
		}

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn保存_Click(object sender, System.EventArgs e)
		{
			if(b前月_Click) return;
			if(b次月_Click) return;
			稼働日更新();
			if(texメッセージ.Text.Length == 0)
			{
				this.Close();
			}
		}

		private void メッセージ登録_Closed(object sender, System.EventArgs e)
		{
			btn次月.Focus();
		}

		private bool b前月_Click = false;
		private void btn前月_Click(object sender, System.EventArgs e)
		{
			if(b次月_Click) return;
			if(b前月_Click) return;
			b前月_Click = true;
			稼働日更新();
			dt開始日 = dt開始日.AddMonths(-1);
			カレンダ初期表示();
			稼働日情報取得();
			b前月_Click = false;
		}

		private bool b次月_Click = false;
		private void btn次月_Click(object sender, System.EventArgs e)
		{
			if(b前月_Click) return;
			if(b次月_Click) return;
			b次月_Click = true;
			稼働日更新();
			dt開始日 = dt開始日.AddMonths(1);
			カレンダ初期表示();
			稼働日情報取得();
			b次月_Click = false;
		}
		private object[] oBtn日付 = null;
		private void 日付ボタン配列設定(){
			if(oBtn日付 != null) return;
			oBtn日付 = new object[]{
				btn11, btn12, btn13, btn14, btn15, btn16, btn17
				, btn21, btn22, btn23, btn24, btn25, btn26, btn27
				, btn31, btn32, btn33, btn34, btn35, btn36, btn37
				, btn41, btn42, btn43, btn44, btn45, btn46, btn47
				, btn51, btn52, btn53, btn54, btn55, btn56, btn57
				, btn61, btn62, btn63, btn64, btn65, btn66, btn67
			};
			for(int iCnt = 0; iCnt < oBtn日付.Length; iCnt++){
				((Button)oBtn日付[iCnt]).Click += new System.EventHandler(this.btn_Click);
			}
		}
		private void btn_Click(object sender, System.EventArgs e)
		{
			Button btn = ((Button)sender);
			if(btn.BackColor == color平日){
				if(rb休日.Checked){
					btn.BackColor = color休日;
				}else{
					btn.BackColor = colorその他;
				}
			}else if(btn.BackColor == color休日){
				if(rb休日.Checked){
					btn.BackColor = color平日;
				}else{
					btn.BackColor = color休日その他;
				}
			}else if(btn.BackColor == colorその他){
				if(rb休日.Checked){
					btn.BackColor = color休日その他;
				}else{
					btn.BackColor = color平日;
				}
			}else if(btn.BackColor == color休日その他){
				if(rb休日.Checked){
					btn.BackColor = color平日;
				}else{
					btn.BackColor = colorその他;
				}
			}
		}
		private void カレンダ初期表示()
		{
			dt終了日 = dt開始日.AddMonths(1).AddDays(-1);
			rb休日.Checked = true;
			日付ボタン配列設定();

			lab年.Text = dt開始日.Year.ToString();
			lab月.Text = dt開始日.Month.ToString();
			lab年.Refresh();
			lab月.Refresh();

			int iPos;
			int iCnt;

			//ボタンの色の初期設定
			for(iPos = 0; iPos < oBtn日付.Length; iPos++){
				((Button)oBtn日付[iPos]).BackColor = color平日;
			}
			btn11.BackColor = color休日;
			btn21.BackColor = color休日;
			btn31.BackColor = color休日;
			btn41.BackColor = color休日;
			btn51.BackColor = color休日;
			btn61.BackColor = color休日;
			
			//ボタンのテキストと表示の設定
			i開始位置 = 曜日(dt開始日);
			for(iPos = 0; iPos < i開始位置; iPos++){
				((Button)oBtn日付[iPos]).Text = "";
				((Button)oBtn日付[iPos]).Visible = false;
			}
			for(iCnt = 1; iCnt <= dt終了日.Day; iCnt++, iPos++){
				((Button)oBtn日付[iPos]).Text = iCnt.ToString();
				((Button)oBtn日付[iPos]).Visible = true;
			}
			for(; iPos < oBtn日付.Length; iPos++){
				((Button)oBtn日付[iPos]).Text = "";
				((Button)oBtn日付[iPos]).Visible = false;
			}
		}
		private void 稼働日情報取得()
		{
			string   sRet = "";
			string[] s稼働日 = {""};
			string[] sその他 = {""};
			object[] oRet = new object[]{""};
			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				texメッセージ.Text = "稼働日情報取得中．．．";
				if( sv_maintenance == null ) sv_maintenance = new is2maintenance.Service1();
				oRet = sv_maintenance.Get_Kadobi(gsaユーザ, dt開始日.ToString("yyyyMMdd")
															, dt終了日.ToString("yyyyMMdd"));
				texメッセージ.Text = "";
			}
			catch (System.Net.WebException)
			{
				sRet = gs通信エラー;
			}
			catch (Exception ex)
			{
				sRet = "通信エラー：" + ex.Message;
			}
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;
			sRet = (string)(oRet[0]);

			// エラー時
			if(sRet.Length != 4)
			{
				ビープ音();
				texメッセージ.Text = sRet;
				return;
			}
			s稼働日 = (string[])(oRet[1]);
			sその他 = (string[])(oRet[2]);

			//ボタンの色設定
			int iPos;
			int iCnt;
			for(iCnt = 1,iPos = i開始位置; iCnt <= dt終了日.Day; iCnt++, iPos++){
				if(s稼働日[iCnt] == "0" && sその他[iCnt] == "0"){
					((Button)oBtn日付[iPos]).BackColor = color平日;
				}else if(s稼働日[iCnt] == "1" && sその他[iCnt] == "1"){
					((Button)oBtn日付[iPos]).BackColor = color休日その他;
				}else if(s稼働日[iCnt] == "1"){
					((Button)oBtn日付[iPos]).BackColor = color休日;
				}else if(sその他[iCnt] == "1"){
					((Button)oBtn日付[iPos]).BackColor = colorその他;
				}else{
					;	//上記以外は色を変更しない
				}
			}
		}
		private void 稼働日更新()
		{
			int iPos;
			int iCnt;

			//稼働日の値取得
			c稼働日 = new char[dt終了日.Day];
			cその他 = new char[dt終了日.Day];
			for(iCnt = 0,iPos = i開始位置; iCnt < dt終了日.Day; iCnt++, iPos++){
				Color colorBtn = ((Button)oBtn日付[iPos]).BackColor;
				if(colorBtn == color休日 || colorBtn == color休日その他){
					c稼働日[iCnt] = '1';
				}else{
					c稼働日[iCnt] = '0';
				}
				if(colorBtn == colorその他 || colorBtn == color休日その他){
					cその他[iCnt] = '1';
				}else{
					cその他[iCnt] = '0';
				}
			}

			string[] sRet = {""};
			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				texメッセージ.Text = "稼働日更新中．．．";
				if( sv_maintenance == null ) sv_maintenance = new is2maintenance.Service1();
				sRet = sv_maintenance.Upd_Kadobi(gsaユーザ, dt開始日.ToString("yyyyMMdd"), c稼働日, cその他);
				texメッセージ.Text = "";
			}
			catch (System.Net.WebException)
			{
				sRet[0] = gs通信エラー;
			}
			catch (Exception ex)
			{
				sRet[0] = "通信エラー：" + ex.Message;
			}
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			// エラー時
			if(sRet[0].Length != 4)
			{
				ビープ音();
				texメッセージ.Text = sRet[0];
			}
		}
		private int 曜日(DateTime dt)
		{
			switch(dt.DayOfWeek){
				case DayOfWeek.Sunday:
					return 0;
				case DayOfWeek.Monday:
					return 1;
				case DayOfWeek.Tuesday:
					return 2;
				case DayOfWeek.Wednesday:
					return 3;
				case DayOfWeek.Thursday:
					return 4;
				case DayOfWeek.Friday:
					return 5;
				case DayOfWeek.Saturday:
					return 6;
			}
			return -1;
		}
	}
}
