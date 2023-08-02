namespace WinForm.NotDefteri
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtUsername = new TextBox();
            label5 = new Label();
            MskSifre = new MaskedTextBox();
            BtnGiris = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 423);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 270);
            label1.Name = "label1";
            label1.Size = new Size(350, 15);
            label1.TabIndex = 2;
            label1.Text = "\"Birçok kitap, insanın kendi kalesinin içindeki  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 295);
            label2.Name = "label2";
            label2.Size = new Size(294, 15);
            label2.TabIndex = 3;
            label2.Text = "bilinmeyen odaların anahtarları gibidir.\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(249, 329);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "Franz Kafka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 162);
            label4.Name = "label4";
            label4.Size = new Size(126, 19);
            label4.TabIndex = 5;
            label4.Text = "Kullanıcı Adı";
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.MistyRose;
            TxtUsername.Location = new Point(419, 193);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(124, 26);
            TxtUsername.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 249);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 7;
            label5.Text = "Şifre";
            // 
            // MskSifre
            // 
            MskSifre.BackColor = Color.MistyRose;
            MskSifre.Location = new Point(419, 277);
            MskSifre.Mask = "0000";
            MskSifre.Name = "MskSifre";
            MskSifre.Size = new Size(124, 26);
            MskSifre.TabIndex = 2;
            MskSifre.UseSystemPasswordChar = true;
            MskSifre.ValidatingType = typeof(int);
            // 
            // BtnGiris
            // 
            BtnGiris.BackColor = Color.MistyRose;
            BtnGiris.Location = new Point(430, 342);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(102, 41);
            BtnGiris.TabIndex = 8;
            BtnGiris.Text = "Giriş";
            BtnGiris.UseVisualStyleBackColor = false;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(430, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AcceptButton = BtnGiris;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(609, 422);
            Controls.Add(pictureBox2);
            Controls.Add(BtnGiris);
            Controls.Add(MskSifre);
            Controls.Add(label5);
            Controls.Add(TxtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş Paneli";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtUsername;
        private Label label5;
        private MaskedTextBox MskSifre;
        private Button BtnGiris;
        private PictureBox pictureBox2;
    }
}