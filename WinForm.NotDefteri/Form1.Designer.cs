namespace WinForm.NotDefteri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNote = new TextBox();
            label2 = new Label();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnRemove = new Button();
            BtnExit = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Freestyle Script", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(486, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 35);
            label1.TabIndex = 1;
            label1.Text = "ÖZLÜ SÖZLER";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(22, 101);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(260, 26);
            txtNote.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 69);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 3;
            label2.Text = "SÖZ";
            // 
            // BtnAdd
            // 
            BtnAdd.AccessibleName = "BtnAdd";
            BtnAdd.Location = new Point(101, 143);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(95, 45);
            BtnAdd.TabIndex = 4;
            BtnAdd.Text = "EKLE";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click_1;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(101, 217);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(95, 45);
            BtnEdit.TabIndex = 5;
            BtnEdit.Text = "DÜZENLE";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(101, 290);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(95, 45);
            BtnRemove.TabIndex = 6;
            BtnRemove.Text = "SİL";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(101, 362);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(95, 45);
            BtnExit.TabIndex = 7;
            BtnExit.Text = "ÇIKIŞ";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(372, 84);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(413, 365);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(797, 461);
            Controls.Add(listBox1);
            Controls.Add(BtnExit);
            Controls.Add(BtnRemove);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Controls.Add(label2);
            Controls.Add(txtNote);
            Controls.Add(label1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Özlü Sözler";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNote;
        private Label label2;
        private Button BtnEdit;
        private Button BtnRemove;
        private Button BtnExit;
        private ListBox listBox1;
        public Button BtnAdd;
    }
}