
namespace projetoaula02
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
            this.rtbCharmander = new System.Windows.Forms.RadioButton();
            this.rbtSquirtle = new System.Windows.Forms.RadioButton();
            this.rbtBulbasaur = new System.Windows.Forms.RadioButton();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbCharmander
            // 
            this.rtbCharmander.AutoSize = true;
            this.rtbCharmander.Checked = true;
            this.rtbCharmander.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCharmander.Location = new System.Drawing.Point(12, 84);
            this.rtbCharmander.Name = "rtbCharmander";
            this.rtbCharmander.Size = new System.Drawing.Size(136, 22);
            this.rtbCharmander.TabIndex = 0;
            this.rtbCharmander.TabStop = true;
            this.rtbCharmander.Text = "Charmander";
            this.rtbCharmander.UseVisualStyleBackColor = true;
            this.rtbCharmander.CheckedChanged += new System.EventHandler(this.rtbCharmander_CheckedChanged);
            // 
            // rbtSquirtle
            // 
            this.rbtSquirtle.AutoSize = true;
            this.rbtSquirtle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSquirtle.Location = new System.Drawing.Point(12, 134);
            this.rbtSquirtle.Name = "rbtSquirtle";
            this.rbtSquirtle.Size = new System.Drawing.Size(93, 22);
            this.rbtSquirtle.TabIndex = 1;
            this.rbtSquirtle.Text = "Squirtle";
            this.rbtSquirtle.UseVisualStyleBackColor = true;
            this.rbtSquirtle.CheckedChanged += new System.EventHandler(this.rbtSquirtle_CheckedChanged);
            // 
            // rbtBulbasaur
            // 
            this.rbtBulbasaur.AutoSize = true;
            this.rbtBulbasaur.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBulbasaur.Location = new System.Drawing.Point(12, 181);
            this.rbtBulbasaur.Name = "rbtBulbasaur";
            this.rbtBulbasaur.Size = new System.Drawing.Size(114, 22);
            this.rbtBulbasaur.TabIndex = 2;
            this.rbtBulbasaur.Text = "Bulbasaur";
            this.rbtBulbasaur.UseVisualStyleBackColor = true;
            this.rbtBulbasaur.CheckedChanged += new System.EventHandler(this.rbtBulbasaur_CheckedChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(78, 29);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(263, 25);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Escolha seu Pokémon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoaula02.Properties.Resources.Charmander;
            this.pictureBox1.Location = new System.Drawing.Point(357, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 475);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 566);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.rbtBulbasaur);
            this.Controls.Add(this.rbtSquirtle);
            this.Controls.Add(this.rtbCharmander);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rtbCharmander;
        private System.Windows.Forms.RadioButton rbtSquirtle;
        private System.Windows.Forms.RadioButton rbtBulbasaur;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

