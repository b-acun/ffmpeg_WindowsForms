
namespace deneme1
{
    partial class progressBar1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(progressBar1));
            this.input_lbl = new System.Windows.Forms.Label();
            this.output_lbl = new System.Windows.Forms.Label();
            this.input1_txtbox = new System.Windows.Forms.TextBox();
            this.output1_txtbox = new System.Windows.Forms.TextBox();
            this.inputSelect_btn = new System.Windows.Forms.Button();
            this.logoSelect_btn = new System.Windows.Forms.Button();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.starting_btn = new System.Windows.Forms.Button();
            this.logoInput_lbl = new System.Windows.Forms.Label();
            this.logoInput_txtbox = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer4 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer4)).BeginInit();
            this.SuspendLayout();
            // 
            // input_lbl
            // 
            this.input_lbl.AutoSize = true;
            this.input_lbl.Location = new System.Drawing.Point(23, 23);
            this.input_lbl.Name = "input_lbl";
            this.input_lbl.Size = new System.Drawing.Size(39, 17);
            this.input_lbl.TabIndex = 0;
            this.input_lbl.Text = "Input";
            this.input_lbl.Click += new System.EventHandler(this.input_lbl_Click);
            // 
            // output_lbl
            // 
            this.output_lbl.AutoSize = true;
            this.output_lbl.Location = new System.Drawing.Point(23, 108);
            this.output_lbl.Name = "output_lbl";
            this.output_lbl.Size = new System.Drawing.Size(51, 17);
            this.output_lbl.TabIndex = 1;
            this.output_lbl.Text = "Output";
            this.output_lbl.Click += new System.EventHandler(this.output_lbl_Click);
            // 
            // input1_txtbox
            // 
            this.input1_txtbox.Location = new System.Drawing.Point(87, 23);
            this.input1_txtbox.Name = "input1_txtbox";
            this.input1_txtbox.Size = new System.Drawing.Size(285, 22);
            this.input1_txtbox.TabIndex = 2;
            this.input1_txtbox.TextChanged += new System.EventHandler(this.input1_txtbox_TextChanged);
            // 
            // output1_txtbox
            // 
            this.output1_txtbox.Location = new System.Drawing.Point(87, 105);
            this.output1_txtbox.Name = "output1_txtbox";
            this.output1_txtbox.Size = new System.Drawing.Size(285, 22);
            this.output1_txtbox.TabIndex = 3;
            this.output1_txtbox.TextChanged += new System.EventHandler(this.output1_txtbox_TextChanged);
            // 
            // inputSelect_btn
            // 
            this.inputSelect_btn.Location = new System.Drawing.Point(378, 19);
            this.inputSelect_btn.Name = "inputSelect_btn";
            this.inputSelect_btn.Size = new System.Drawing.Size(29, 24);
            this.inputSelect_btn.TabIndex = 4;
            this.inputSelect_btn.Text = "...";
            this.inputSelect_btn.UseVisualStyleBackColor = true;
            this.inputSelect_btn.Click += new System.EventHandler(this.inputSelect_btn_Click);
            // 
            // logoSelect_btn
            // 
            this.logoSelect_btn.Location = new System.Drawing.Point(378, 61);
            this.logoSelect_btn.Name = "logoSelect_btn";
            this.logoSelect_btn.Size = new System.Drawing.Size(29, 28);
            this.logoSelect_btn.TabIndex = 5;
            this.logoSelect_btn.Text = "...";
            this.logoSelect_btn.UseVisualStyleBackColor = true;
            this.logoSelect_btn.Click += new System.EventHandler(this.logoSelect_btn_Click);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker3_ProgressChanged);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(440, 12);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(309, 217);
            this.axWindowsMediaPlayer3.TabIndex = 6;
            // 
            // starting_btn
            // 
            this.starting_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.starting_btn.Location = new System.Drawing.Point(131, 238);
            this.starting_btn.Name = "starting_btn";
            this.starting_btn.Size = new System.Drawing.Size(161, 103);
            this.starting_btn.TabIndex = 7;
            this.starting_btn.Text = "START";
            this.starting_btn.UseVisualStyleBackColor = false;
            this.starting_btn.Click += new System.EventHandler(this.starting_btn_Click);
            // 
            // logoInput_lbl
            // 
            this.logoInput_lbl.AutoSize = true;
            this.logoInput_lbl.Location = new System.Drawing.Point(26, 71);
            this.logoInput_lbl.Name = "logoInput_lbl";
            this.logoInput_lbl.Size = new System.Drawing.Size(40, 17);
            this.logoInput_lbl.TabIndex = 11;
            this.logoInput_lbl.Text = "Logo";
            this.logoInput_lbl.Click += new System.EventHandler(this.logoInput_lbl_Click);
            // 
            // logoInput_txtbox
            // 
            this.logoInput_txtbox.Location = new System.Drawing.Point(87, 64);
            this.logoInput_txtbox.Name = "logoInput_txtbox";
            this.logoInput_txtbox.Size = new System.Drawing.Size(285, 22);
            this.logoInput_txtbox.TabIndex = 12;
            this.logoInput_txtbox.TextChanged += new System.EventHandler(this.logoInput_txtbox_TextChanged);
            // 
            // axWindowsMediaPlayer4
            // 
            this.axWindowsMediaPlayer4.Enabled = true;
            this.axWindowsMediaPlayer4.Location = new System.Drawing.Point(440, 238);
            this.axWindowsMediaPlayer4.Name = "axWindowsMediaPlayer4";
            this.axWindowsMediaPlayer4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer4.OcxState")));
            this.axWindowsMediaPlayer4.Size = new System.Drawing.Size(309, 209);
            this.axWindowsMediaPlayer4.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.ClientSize = new System.Drawing.Size(794, 489);
            this.Controls.Add(this.axWindowsMediaPlayer4);
            this.Controls.Add(this.logoInput_txtbox);
            this.Controls.Add(this.logoInput_lbl);
            this.Controls.Add(this.starting_btn);
            this.Controls.Add(this.axWindowsMediaPlayer3);
            this.Controls.Add(this.logoSelect_btn);
            this.Controls.Add(this.inputSelect_btn);
            this.Controls.Add(this.output1_txtbox);
            this.Controls.Add(this.input1_txtbox);
            this.Controls.Add(this.output_lbl);
            this.Controls.Add(this.input_lbl);
            this.Name = "progressBar1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_txtbox;
        private System.Windows.Forms.TextBox output_txtbox;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.Button input_btn;
        private System.Windows.Forms.Button output_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button input1_btn;
        private System.Windows.Forms.Button output1_btn;
        private System.Windows.Forms.Button start1_btn;
        private System.Windows.Forms.Button videoSet_btn;
        private System.Windows.Forms.Button audioSet_btn;
        private System.Windows.Forms.Button editLogo_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label input_lbl;
        private System.Windows.Forms.Label output_lbl;
        private System.Windows.Forms.TextBox input1_txtbox;
        private System.Windows.Forms.TextBox output1_txtbox;
        private System.Windows.Forms.Button inputSelect_btn;
        private System.Windows.Forms.Button logoSelect_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
        private System.Windows.Forms.Button starting_btn;
        private System.Windows.Forms.Label logoInput_lbl;
        private System.Windows.Forms.TextBox logoInput_txtbox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer4;
    }
}

