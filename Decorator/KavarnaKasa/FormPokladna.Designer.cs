namespace KavarnaKasa
{
    partial class FormPokladna
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
            this.btnEspresso = new System.Windows.Forms.Button();
            this.btnTurek = new System.Windows.Forms.Button();
            this.btnBezKofein = new System.Windows.Forms.Button();
            this.btnMleko = new System.Windows.Forms.Button();
            this.btnSlehacka = new System.Windows.Forms.Button();
            this.btnSoja = new System.Windows.Forms.Button();
            this.btnCoko = new System.Windows.Forms.Button();
            this.btnCena = new System.Windows.Forms.Button();
            this.lblCena = new System.Windows.Forms.Label();
            this.lstSeznam = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEspresso
            // 
            this.btnEspresso.Location = new System.Drawing.Point(34, 47);
            this.btnEspresso.Name = "btnEspresso";
            this.btnEspresso.Size = new System.Drawing.Size(93, 56);
            this.btnEspresso.TabIndex = 0;
            this.btnEspresso.Text = "Espresso";
            this.btnEspresso.UseVisualStyleBackColor = true;
            this.btnEspresso.Click += new System.EventHandler(this.btnNapoj_Click);
            // 
            // btnTurek
            // 
            this.btnTurek.Location = new System.Drawing.Point(133, 47);
            this.btnTurek.Name = "btnTurek";
            this.btnTurek.Size = new System.Drawing.Size(93, 56);
            this.btnTurek.TabIndex = 1;
            this.btnTurek.Text = "Turek";
            this.btnTurek.UseVisualStyleBackColor = true;
            this.btnTurek.Click += new System.EventHandler(this.btnNapoj_Click);
            // 
            // btnBezKofein
            // 
            this.btnBezKofein.Location = new System.Drawing.Point(232, 47);
            this.btnBezKofein.Name = "btnBezKofein";
            this.btnBezKofein.Size = new System.Drawing.Size(93, 56);
            this.btnBezKofein.TabIndex = 2;
            this.btnBezKofein.Text = "Bez kofein";
            this.btnBezKofein.UseVisualStyleBackColor = true;
            this.btnBezKofein.Click += new System.EventHandler(this.btnNapoj_Click);
            // 
            // btnMleko
            // 
            this.btnMleko.Location = new System.Drawing.Point(32, 162);
            this.btnMleko.Name = "btnMleko";
            this.btnMleko.Size = new System.Drawing.Size(94, 34);
            this.btnMleko.TabIndex = 3;
            this.btnMleko.Text = "Mleko";
            this.btnMleko.UseVisualStyleBackColor = true;
            this.btnMleko.Click += new System.EventHandler(this.btnPridavek_Click);
            // 
            // btnSlehacka
            // 
            this.btnSlehacka.Location = new System.Drawing.Point(132, 162);
            this.btnSlehacka.Name = "btnSlehacka";
            this.btnSlehacka.Size = new System.Drawing.Size(94, 34);
            this.btnSlehacka.TabIndex = 4;
            this.btnSlehacka.Text = "Slehacka";
            this.btnSlehacka.UseVisualStyleBackColor = true;
            this.btnSlehacka.Click += new System.EventHandler(this.btnPridavek_Click);
            // 
            // btnSoja
            // 
            this.btnSoja.Location = new System.Drawing.Point(232, 162);
            this.btnSoja.Name = "btnSoja";
            this.btnSoja.Size = new System.Drawing.Size(94, 34);
            this.btnSoja.TabIndex = 5;
            this.btnSoja.Text = "Soja";
            this.btnSoja.UseVisualStyleBackColor = true;
            this.btnSoja.Click += new System.EventHandler(this.btnPridavek_Click);
            // 
            // btnCoko
            // 
            this.btnCoko.Location = new System.Drawing.Point(32, 202);
            this.btnCoko.Name = "btnCoko";
            this.btnCoko.Size = new System.Drawing.Size(94, 34);
            this.btnCoko.TabIndex = 6;
            this.btnCoko.Text = "Cokolada";
            this.btnCoko.UseVisualStyleBackColor = true;
            this.btnCoko.Click += new System.EventHandler(this.btnPridavek_Click);
            // 
            // btnCena
            // 
            this.btnCena.Location = new System.Drawing.Point(34, 294);
            this.btnCena.Name = "btnCena";
            this.btnCena.Size = new System.Drawing.Size(122, 48);
            this.btnCena.TabIndex = 9;
            this.btnCena.Text = "Cena";
            this.btnCena.UseVisualStyleBackColor = true;
            this.btnCena.Click += new System.EventHandler(this.btnCena_Click);
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCena.ForeColor = System.Drawing.Color.Navy;
            this.lblCena.Location = new System.Drawing.Point(207, 300);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(0, 29);
            this.lblCena.TabIndex = 10;
            // 
            // lstSeznam
            // 
            this.lstSeznam.FormattingEnabled = true;
            this.lstSeznam.Location = new System.Drawing.Point(350, 50);
            this.lstSeznam.Name = "lstSeznam";
            this.lstSeznam.Size = new System.Drawing.Size(156, 225);
            this.lstSeznam.TabIndex = 11;
            // 
            // FormPokladna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.lstSeznam);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.btnCena);
            this.Controls.Add(this.btnCoko);
            this.Controls.Add(this.btnSoja);
            this.Controls.Add(this.btnSlehacka);
            this.Controls.Add(this.btnMleko);
            this.Controls.Add(this.btnBezKofein);
            this.Controls.Add(this.btnTurek);
            this.Controls.Add(this.btnEspresso);
            this.Name = "FormPokladna";
            this.Text = "Pokladna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEspresso;
        private System.Windows.Forms.Button btnTurek;
        private System.Windows.Forms.Button btnBezKofein;
        private System.Windows.Forms.Button btnMleko;
        private System.Windows.Forms.Button btnSlehacka;
        private System.Windows.Forms.Button btnSoja;
        private System.Windows.Forms.Button btnCoko;
        private System.Windows.Forms.Button btnCena;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.ListBox lstSeznam;
    }
}

