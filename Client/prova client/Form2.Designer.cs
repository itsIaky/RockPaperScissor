
namespace prova_client
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnRanked = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSingle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRanked
            // 
            this.btnRanked.BackColor = System.Drawing.Color.Black;
            this.btnRanked.BackgroundImage = global::prova_client.Properties.Resources.download__7_;
            this.btnRanked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanked.ForeColor = System.Drawing.Color.Black;
            this.btnRanked.Image = global::prova_client.Properties.Resources.ranked1;
            this.btnRanked.Location = new System.Drawing.Point(447, 267);
            this.btnRanked.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRanked.Name = "btnRanked";
            this.btnRanked.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRanked.Size = new System.Drawing.Size(133, 141);
            this.btnRanked.TabIndex = 3;
            this.btnRanked.Text = "Combatti per i punti";
            this.btnRanked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRanked.UseVisualStyleBackColor = false;
            this.btnRanked.Click += new System.EventHandler(this.btnRanked_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.Transparent;
            this.btnMulti.BackgroundImage = global::prova_client.Properties.Resources.download__8_;
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Image = global::prova_client.Properties.Resources.multiplayer3;
            this.btnMulti.Location = new System.Drawing.Point(304, 267);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(133, 141);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "Gioca con i tuoi amici";
            this.btnMulti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnSingle
            // 
            this.btnSingle.BackColor = System.Drawing.Color.Transparent;
            this.btnSingle.BackgroundImage = global::prova_client.Properties.Resources.download__6_;
            this.btnSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingle.Image = global::prova_client.Properties.Resources.singleplayer3;
            this.btnSingle.Location = new System.Drawing.Point(165, 267);
            this.btnSingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(133, 141);
            this.btnSingle.TabIndex = 0;
            this.btnSingle.Text = "Single\r\nPlayer";
            this.btnSingle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSingle.UseVisualStyleBackColor = false;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prova_client.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 443);
            this.Controls.Add(this.btnRanked);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSingle);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Gioca";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnRanked;
    }
}