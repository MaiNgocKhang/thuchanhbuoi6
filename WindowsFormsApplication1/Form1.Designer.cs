namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.listtrai = new System.Windows.Forms.ListBox();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btntatcaPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btntatcaTrai = new System.Windows.Forms.Button();
            this.listphai = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listtrai
            // 
            this.listtrai.FormattingEnabled = true;
            this.listtrai.Items.AddRange(new object[] {
            "Coc",
            "Oi",
            "Xoai",
            "Me",
            "buoi",
            "cam"});
            this.listtrai.Location = new System.Drawing.Point(26, 25);
            this.listtrai.Name = "listtrai";
            this.listtrai.Size = new System.Drawing.Size(120, 199);
            this.listtrai.TabIndex = 1;
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(181, 37);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(44, 37);
            this.btnPhai.TabIndex = 2;
            this.btnPhai.Text = ">";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btntatcaPhai
            // 
            this.btntatcaPhai.Location = new System.Drawing.Point(181, 89);
            this.btntatcaPhai.Name = "btntatcaPhai";
            this.btntatcaPhai.Size = new System.Drawing.Size(44, 37);
            this.btntatcaPhai.TabIndex = 3;
            this.btntatcaPhai.Text = ">>";
            this.btntatcaPhai.UseVisualStyleBackColor = true;
            this.btntatcaPhai.Click += new System.EventHandler(this.btntatcaPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(181, 132);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(44, 37);
            this.btnTrai.TabIndex = 4;
            this.btnTrai.Text = "<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btntatcaTrai
            // 
            this.btntatcaTrai.Location = new System.Drawing.Point(181, 175);
            this.btntatcaTrai.Name = "btntatcaTrai";
            this.btntatcaTrai.Size = new System.Drawing.Size(44, 37);
            this.btntatcaTrai.TabIndex = 5;
            this.btntatcaTrai.Text = "<<";
            this.btntatcaTrai.UseVisualStyleBackColor = true;
            this.btntatcaTrai.Click += new System.EventHandler(this.btntatcaTrai_Click);
            // 
            // listphai
            // 
            this.listphai.FormattingEnabled = true;
            this.listphai.Location = new System.Drawing.Point(263, 37);
            this.listphai.Name = "listphai";
            this.listphai.Size = new System.Drawing.Size(120, 186);
            this.listphai.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 312);
            this.Controls.Add(this.listphai);
            this.Controls.Add(this.btntatcaTrai);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btntatcaPhai);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.listtrai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listtrai;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btntatcaPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btntatcaTrai;
        private System.Windows.Forms.ListBox listphai;
    }
}

