namespace MayinTarlasi.UI
{
    partial class MayinTarlasi
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
            btnYeniOyun = new Button();
            grpMayinlar = new GroupBox();
            SuspendLayout();
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Location = new Point(12, 12);
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.Size = new Size(94, 29);
            btnYeniOyun.TabIndex = 0;
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.UseVisualStyleBackColor = true;
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // grpMayinlar
            // 
            grpMayinlar.Location = new Point(12, 47);
            grpMayinlar.Name = "grpMayinlar";
            grpMayinlar.Size = new Size(776, 391);
            grpMayinlar.TabIndex = 1;
            grpMayinlar.TabStop = false;
            // 
            // MayinTarlasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpMayinlar);
            Controls.Add(btnYeniOyun);
            Name = "MayinTarlasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mayın Tarlası";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYeniOyun;
        private GroupBox grpMayinlar;
    }
}
