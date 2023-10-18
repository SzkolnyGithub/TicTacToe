
namespace kolkoIkrzyzykBadowski4c
{
    partial class glowneOkno
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.napis = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Twórz plansze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // napis
            // 
            this.napis.BackColor = System.Drawing.SystemColors.Window;
            this.napis.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.napis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.napis.Location = new System.Drawing.Point(333, 267);
            this.napis.Name = "napis";
            this.napis.Size = new System.Drawing.Size(197, 47);
            this.napis.TabIndex = 3;
            this.napis.Visible = false;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(42, 219);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(120, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // glowneOkno
            // 
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.napis);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "glowneOkno";
            this.Text = "Kółko i Krzyżyk";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glowneOkno_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glowneOkno_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glowneOkno_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label napis;
        private System.Windows.Forms.Button reset;
    }
}

