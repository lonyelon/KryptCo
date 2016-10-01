namespace AesGUI
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
            this.components = new System.ComponentModel.Container();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_cry = new System.Windows.Forms.TextBox();
            this.txt_txt = new System.Windows.Forms.TextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.txt_IV = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.grp_data = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_crypto_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_vector = new System.Windows.Forms.Label();
            this.lb_key = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_copy = new System.Windows.Forms.Label();
            this.lb_version = new System.Windows.Forms.Label();
            this.grp_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(69, 60);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(399, 20);
            this.txt_pwd.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_cry
            // 
            this.txt_cry.Location = new System.Drawing.Point(492, 37);
            this.txt_cry.Multiline = true;
            this.txt_cry.Name = "txt_cry";
            this.txt_cry.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_cry.Size = new System.Drawing.Size(309, 437);
            this.txt_cry.TabIndex = 2;
            // 
            // txt_txt
            // 
            this.txt_txt.Location = new System.Drawing.Point(12, 162);
            this.txt_txt.Multiline = true;
            this.txt_txt.Name = "txt_txt";
            this.txt_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_txt.Size = new System.Drawing.Size(474, 283);
            this.txt_txt.TabIndex = 3;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(411, 451);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypt.TabIndex = 4;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(330, 451);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_decrypt.TabIndex = 5;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_IV
            // 
            this.txt_IV.Location = new System.Drawing.Point(69, 86);
            this.txt_IV.Name = "txt_IV";
            this.txt_IV.Size = new System.Drawing.Size(237, 20);
            this.txt_IV.TabIndex = 6;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(393, 86);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 7;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_set
            // 
            this.btn_set.ForeColor = System.Drawing.Color.Black;
            this.btn_set.Location = new System.Drawing.Point(393, 18);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 23);
            this.btn_set.TabIndex = 8;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // grp_data
            // 
            this.grp_data.Controls.Add(this.button1);
            this.grp_data.Controls.Add(this.txt_crypto_pwd);
            this.grp_data.Controls.Add(this.label3);
            this.grp_data.Controls.Add(this.lb_vector);
            this.grp_data.Controls.Add(this.lb_key);
            this.grp_data.Controls.Add(this.btn_generate);
            this.grp_data.Controls.Add(this.btn_set);
            this.grp_data.Controls.Add(this.txt_pwd);
            this.grp_data.Controls.Add(this.txt_IV);
            this.grp_data.Location = new System.Drawing.Point(12, 12);
            this.grp_data.Name = "grp_data";
            this.grp_data.Size = new System.Drawing.Size(474, 120);
            this.grp_data.TabIndex = 9;
            this.grp_data.TabStop = false;
            this.grp_data.Text = "Encryption Data";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(312, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Set key/IV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_crypto_pwd
            // 
            this.txt_crypto_pwd.Location = new System.Drawing.Point(69, 19);
            this.txt_crypto_pwd.Name = "txt_crypto_pwd";
            this.txt_crypto_pwd.Size = new System.Drawing.Size(318, 20);
            this.txt_crypto_pwd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // lb_vector
            // 
            this.lb_vector.AutoSize = true;
            this.lb_vector.Location = new System.Drawing.Point(25, 89);
            this.lb_vector.Name = "lb_vector";
            this.lb_vector.Size = new System.Drawing.Size(38, 13);
            this.lb_vector.TabIndex = 8;
            this.lb_vector.Text = "Vector";
            // 
            // lb_key
            // 
            this.lb_key.AutoSize = true;
            this.lb_key.Location = new System.Drawing.Point(38, 63);
            this.lb_key.Name = "lb_key";
            this.lb_key.Size = new System.Drawing.Size(25, 13);
            this.lb_key.TabIndex = 7;
            this.lb_key.Text = "Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Unencrypted Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Encypted Text";
            // 
            // lb_copy
            // 
            this.lb_copy.AutoSize = true;
            this.lb_copy.Location = new System.Drawing.Point(171, 456);
            this.lb_copy.Name = "lb_copy";
            this.lb_copy.Size = new System.Drawing.Size(153, 13);
            this.lb_copy.TabIndex = 12;
            this.lb_copy.Text = "Made by Lonyelon (@lonyelon)";
            // 
            // lb_version
            // 
            this.lb_version.AutoSize = true;
            this.lb_version.Location = new System.Drawing.Point(12, 456);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(47, 13);
            this.lb_version.TabIndex = 13;
            this.lb_version.Text = "[version]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 483);
            this.Controls.Add(this.lb_version);
            this.Controls.Add(this.lb_copy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_data);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.txt_txt);
            this.Controls.Add(this.txt_cry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_data.ResumeLayout(false);
            this.grp_data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_cry;
        private System.Windows.Forms.TextBox txt_txt;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.TextBox txt_IV;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.GroupBox grp_data;
        private System.Windows.Forms.Label lb_vector;
        private System.Windows.Forms.Label lb_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_copy;
        private System.Windows.Forms.Label lb_version;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_crypto_pwd;
        private System.Windows.Forms.Label label3;
    }
}

