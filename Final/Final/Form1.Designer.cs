namespace Final
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dersBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dersBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grid1Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Ders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Vize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Ortalama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1Check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grid2Ders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2Ortalama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.grid3Ders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid3High = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid3Low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.grid4Ders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid4Sayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.grid5Ders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid5Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid5Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.grid6Ders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid6Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.grid8Ders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid8Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid8Ortalama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.grid9Ders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid9VizeOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.grid10Ders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid10Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid10Ortalama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yaş:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(71, 27);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(155, 20);
            this.txtAd.TabIndex = 2;
            this.txtAd.Text = "Aziz Mert ZENGİN";
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(71, 53);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(155, 20);
            this.txtYas.TabIndex = 3;
            this.txtYas.Text = "19";
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(71, 106);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(155, 20);
            this.txtVize.TabIndex = 7;
            this.txtVize.Text = "90";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(71, 132);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(155, 20);
            this.txtFinal.TabIndex = 6;
            this.txtFinal.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vize:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ders Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Final:";
            // 
            // dersBox1
            // 
            this.dersBox1.FormattingEnabled = true;
            this.dersBox1.Location = new System.Drawing.Point(71, 79);
            this.dersBox1.Name = "dersBox1";
            this.dersBox1.Size = new System.Drawing.Size(155, 21);
            this.dersBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dersBox2
            // 
            this.dersBox2.FormattingEnabled = true;
            this.dersBox2.Location = new System.Drawing.Point(67, 200);
            this.dersBox2.Name = "dersBox2";
            this.dersBox2.Size = new System.Drawing.Size(121, 21);
            this.dersBox2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ders Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid1Ad,
            this.grid1Yas,
            this.grid1Ders,
            this.grid1Vize,
            this.grid1Final,
            this.grid1Ortalama,
            this.grid1Check});
            this.dataGridView1.Location = new System.Drawing.Point(232, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 154);
            this.dataGridView1.TabIndex = 14;
            // 
            // grid1Ad
            // 
            this.grid1Ad.HeaderText = "Ad Soyad";
            this.grid1Ad.Name = "grid1Ad";
            // 
            // grid1Yas
            // 
            this.grid1Yas.HeaderText = "Yaş";
            this.grid1Yas.Name = "grid1Yas";
            // 
            // grid1Ders
            // 
            this.grid1Ders.HeaderText = "Ders Adı";
            this.grid1Ders.Name = "grid1Ders";
            // 
            // grid1Vize
            // 
            this.grid1Vize.HeaderText = "Vize";
            this.grid1Vize.Name = "grid1Vize";
            // 
            // grid1Final
            // 
            this.grid1Final.HeaderText = "Final";
            this.grid1Final.Name = "grid1Final";
            // 
            // grid1Ortalama
            // 
            this.grid1Ortalama.HeaderText = "Ortalama";
            this.grid1Ortalama.Name = "grid1Ortalama";
            // 
            // grid1Check
            // 
            this.grid1Check.HeaderText = "Geçti/Kaldı";
            this.grid1Check.Name = "grid1Check";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(404, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(485, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(566, 187);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(647, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(728, 187);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 22;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(809, 187);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(890, 187);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 24;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid2Ders,
            this.grid2Ortalama});
            this.dataGridView2.Location = new System.Drawing.Point(28, 269);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(261, 94);
            this.dataGridView2.TabIndex = 25;
            // 
            // grid2Ders
            // 
            this.grid2Ders.HeaderText = "Ders Adı";
            this.grid2Ders.Name = "grid2Ders";
            // 
            // grid2Ortalama
            // 
            this.grid2Ortalama.HeaderText = "Ortalama";
            this.grid2Ortalama.Name = "grid2Ortalama";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid3Ders,
            this.grid3High,
            this.grid3Low});
            this.dataGridView3.Location = new System.Drawing.Point(323, 269);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(349, 94);
            this.dataGridView3.TabIndex = 26;
            // 
            // grid3Ders
            // 
            this.grid3Ders.HeaderText = "Ders Adı";
            this.grid3Ders.Name = "grid3Ders";
            // 
            // grid3High
            // 
            this.grid3High.HeaderText = "En Yüksek";
            this.grid3High.Name = "grid3High";
            // 
            // grid3Low
            // 
            this.grid3Low.HeaderText = "En Düşük";
            this.grid3Low.Name = "grid3Low";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid4Ders,
            this.grid4Sayi});
            this.dataGridView4.Location = new System.Drawing.Point(697, 269);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(258, 94);
            this.dataGridView4.TabIndex = 27;
            // 
            // grid4Ders
            // 
            this.grid4Ders.HeaderText = "Ders Adı";
            this.grid4Ders.Name = "grid4Ders";
            // 
            // grid4Sayi
            // 
            this.grid4Sayi.HeaderText = "Sayı";
            this.grid4Sayi.Name = "grid4Sayi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "dataGridView1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "dataGridView2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "dataGridView3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(759, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "dataGridView4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "dataGridView5";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid5Ders,
            this.grid5Ad,
            this.grid5Yas});
            this.dataGridView5.Location = new System.Drawing.Point(28, 402);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(347, 94);
            this.dataGridView5.TabIndex = 33;
            // 
            // grid5Ders
            // 
            this.grid5Ders.HeaderText = "Ders Adı";
            this.grid5Ders.Name = "grid5Ders";
            // 
            // grid5Ad
            // 
            this.grid5Ad.HeaderText = "Ad Soyad";
            this.grid5Ad.Name = "grid5Ad";
            // 
            // grid5Yas
            // 
            this.grid5Yas.HeaderText = "Yaş";
            this.grid5Yas.Name = "grid5Yas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "dataGridView6";
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid6Ders,
            this.grid6Sira});
            this.dataGridView6.Location = new System.Drawing.Point(404, 402);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(249, 94);
            this.dataGridView6.TabIndex = 35;
            // 
            // grid6Ders
            // 
            this.grid6Ders.HeaderText = "Ders Adı";
            this.grid6Ders.Name = "grid6Ders";
            // 
            // grid6Sira
            // 
            this.grid6Sira.HeaderText = "Başarı Sırası";
            this.grid6Sira.Name = "grid6Sira";
            // 
            // dataGridView8
            // 
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid8Ders,
            this.grid8Ad,
            this.grid8Ortalama});
            this.dataGridView8.Location = new System.Drawing.Point(659, 402);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.Size = new System.Drawing.Size(347, 94);
            this.dataGridView8.TabIndex = 36;
            // 
            // grid8Ders
            // 
            this.grid8Ders.HeaderText = "Ders Adı";
            this.grid8Ders.Name = "grid8Ders";
            // 
            // grid8Ad
            // 
            this.grid8Ad.HeaderText = "Ad Soyad";
            this.grid8Ad.Name = "grid8Ad";
            // 
            // grid8Ortalama
            // 
            this.grid8Ortalama.HeaderText = "Ortalama";
            this.grid8Ortalama.Name = "grid8Ortalama";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(759, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "dataGridView8";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 511);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "dataGridView9";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(392, 511);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "dataGridView10";
            // 
            // dataGridView9
            // 
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid9Ders,
            this.grid9VizeOrt});
            this.dataGridView9.Location = new System.Drawing.Point(28, 538);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.Size = new System.Drawing.Size(261, 94);
            this.dataGridView9.TabIndex = 40;
            // 
            // grid9Ders
            // 
            this.grid9Ders.HeaderText = "Ders Adı";
            this.grid9Ders.Name = "grid9Ders";
            // 
            // grid9VizeOrt
            // 
            this.grid9VizeOrt.HeaderText = "Vize Ortalaması";
            this.grid9VizeOrt.Name = "grid9VizeOrt";
            // 
            // dataGridView10
            // 
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid10Ders,
            this.grid10Ad,
            this.grid10Ortalama});
            this.dataGridView10.Location = new System.Drawing.Point(312, 538);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.Size = new System.Drawing.Size(365, 94);
            this.dataGridView10.TabIndex = 41;
            // 
            // grid10Ders
            // 
            this.grid10Ders.HeaderText = "Ders Adı";
            this.grid10Ders.Name = "grid10Ders";
            // 
            // grid10Ad
            // 
            this.grid10Ad.HeaderText = "Ad Soyad";
            this.grid10Ad.Name = "grid10Ad";
            // 
            // grid10Ortalama
            // 
            this.grid10Ortalama.HeaderText = "Ortalama";
            this.grid10Ortalama.Name = "grid10Ortalama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 644);
            this.Controls.Add(this.dataGridView10);
            this.Controls.Add(this.dataGridView9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView8);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dersBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dersBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dersBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox dersBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Ders;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2Ortalama;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Ders;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Vize;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Ortalama;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid3Ders;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid3High;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid3Low;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid5Ders;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid5Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid5Yas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid6Ders;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid6Sira;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid8Ders;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid8Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid8Ortalama;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid9Ders;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid9VizeOrt;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid10Ders;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid10Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid10Ortalama;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid4Ders;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid4Sayi;
    }
}

