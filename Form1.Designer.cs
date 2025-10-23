namespace SimonDice
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_puntaje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.Mira = new System.Windows.Forms.PictureBox();
            this.Rumi = new System.Windows.Forms.PictureBox();
            this.Leon = new System.Windows.Forms.PictureBox();
            this.Zoey = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rumi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoey)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_puntaje
            // 
            this.lbl_puntaje.AutoSize = true;
            this.lbl_puntaje.Font = new System.Drawing.Font("Onyx", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puntaje.Location = new System.Drawing.Point(327, 9);
            this.lbl_puntaje.Name = "lbl_puntaje";
            this.lbl_puntaje.Size = new System.Drawing.Size(29, 38);
            this.lbl_puntaje.TabIndex = 4;
            this.lbl_puntaje.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Onyx", 45F);
            this.label3.Location = new System.Drawing.Point(87, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 67);
            this.label3.TabIndex = 5;
            this.label3.Text = "Huntrix-Dice";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.Gold;
            this.btn_iniciar.Font = new System.Drawing.Font("Onyx", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_iniciar.Location = new System.Drawing.Point(77, 441);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(204, 48);
            this.btn_iniciar.TabIndex = 6;
            this.btn_iniciar.Text = "Preciona para iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // Mira
            // 
            this.Mira.Image = global::SimonDice.Properties.Resources._4;
            this.Mira.Location = new System.Drawing.Point(196, 272);
            this.Mira.Name = "Mira";
            this.Mira.Size = new System.Drawing.Size(141, 150);
            this.Mira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Mira.TabIndex = 3;
            this.Mira.TabStop = false;
            
            // 
            // Rumi
            // 
            this.Rumi.Image = global::SimonDice.Properties.Resources._3;
            this.Rumi.Location = new System.Drawing.Point(51, 272);
            this.Rumi.Name = "Rumi";
            this.Rumi.Size = new System.Drawing.Size(118, 150);
            this.Rumi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Rumi.TabIndex = 2;
            this.Rumi.TabStop = false;
            
            // 
            // Leon
            // 
            this.Leon.Image = global::SimonDice.Properties.Resources._2;
            this.Leon.Location = new System.Drawing.Point(201, 101);
            this.Leon.Name = "Leon";
            this.Leon.Size = new System.Drawing.Size(136, 150);
            this.Leon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Leon.TabIndex = 1;
            this.Leon.TabStop = false;
            
            // 
            // Zoey
            // 
            this.Zoey.Image = global::SimonDice.Properties.Resources._1;
            this.Zoey.Location = new System.Drawing.Point(52, 101);
            this.Zoey.Name = "Zoey";
            this.Zoey.Size = new System.Drawing.Size(117, 150);
            this.Zoey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Zoey.TabIndex = 0;
            this.Zoey.TabStop = false;
            
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(368, 514);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_puntaje);
            this.Controls.Add(this.Mira);
            this.Controls.Add(this.Rumi);
            this.Controls.Add(this.Leon);
            this.Controls.Add(this.Zoey);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rumi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox p_0;
        private System.Windows.Forms.PictureBox p_1;
        private System.Windows.Forms.PictureBox p_2;
        private System.Windows.Forms.PictureBox p_3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Zoey;
        private System.Windows.Forms.PictureBox Leon;
        private System.Windows.Forms.PictureBox Rumi;
        private System.Windows.Forms.PictureBox Mira;
        private System.Windows.Forms.Label lbl_puntaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_iniciar;
    }
}

