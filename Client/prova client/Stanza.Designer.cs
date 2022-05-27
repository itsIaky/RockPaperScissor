
namespace prova_client
{
    partial class Stanza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stanza));
            this.lblOut = new System.Windows.Forms.Label();
            this.btnCrea = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.txtJoin = new System.Windows.Forms.TextBox();
            this.btnEsci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.BackColor = System.Drawing.Color.Transparent;
            this.lblOut.Location = new System.Drawing.Point(155, 69);
            this.lblOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(16, 13);
            this.lblOut.TabIndex = 0;
            this.lblOut.Text = "...";
            // 
            // btnCrea
            // 
            this.btnCrea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrea.BackgroundImage")));
            this.btnCrea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrea.Font = new System.Drawing.Font("Burbank Big Cd Bk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrea.ForeColor = System.Drawing.Color.White;
            this.btnCrea.Location = new System.Drawing.Point(202, 118);
            this.btnCrea.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(70, 40);
            this.btnCrea.TabIndex = 1;
            this.btnCrea.Text = "Crea";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJoin.BackgroundImage")));
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin.Font = new System.Drawing.Font("Burbank Big Cd Bk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.ForeColor = System.Drawing.Color.White;
            this.btnJoin.Location = new System.Drawing.Point(202, 161);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(0);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(70, 40);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Entra";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // txtJoin
            // 
            this.txtJoin.BackColor = System.Drawing.SystemColors.Window;
            this.txtJoin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJoin.Location = new System.Drawing.Point(174, 90);
            this.txtJoin.Margin = new System.Windows.Forms.Padding(2);
            this.txtJoin.Name = "txtJoin";
            this.txtJoin.Size = new System.Drawing.Size(130, 13);
            this.txtJoin.TabIndex = 4;
            // 
            // btnEsci
            // 
            this.btnEsci.BackColor = System.Drawing.Color.Transparent;
            this.btnEsci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsci.Image = global::prova_client.Properties.Resources.esci1;
            this.btnEsci.Location = new System.Drawing.Point(11, 11);
            this.btnEsci.Margin = new System.Windows.Forms.Padding(2);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(60, 50);
            this.btnEsci.TabIndex = 3;
            this.btnEsci.Text = "Esci";
            this.btnEsci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEsci.UseVisualStyleBackColor = false;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Burbank Big Cd Bk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter room ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Burbank Big Cd Bk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inserisci ID della stanza";
            // 
            // Stanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prova_client.Properties.Resources.istockphoto_922545544_170667a;
            this.ClientSize = new System.Drawing.Size(473, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJoin);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.lblOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stanza";
            this.Text = "Stanza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stanza_FormClosing);
            this.Load += new System.EventHandler(this.Stanza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.TextBox txtJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}