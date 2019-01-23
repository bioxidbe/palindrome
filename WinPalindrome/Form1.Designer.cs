namespace WinPalindrome
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnReadFile = new System.Windows.Forms.Button();
            this.LstAll = new System.Windows.Forms.ListBox();
            this.LstPalindrome = new System.Windows.Forms.ListBox();
            this.LstNotPalindrome = new System.Windows.Forms.ListBox();
            this.BtnFilterPalindrome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnReadFile
            // 
            this.BtnReadFile.Location = new System.Drawing.Point(77, 42);
            this.BtnReadFile.Name = "BtnReadFile";
            this.BtnReadFile.Size = new System.Drawing.Size(134, 55);
            this.BtnReadFile.TabIndex = 0;
            this.BtnReadFile.Text = "Lire fichier palindrome";
            this.BtnReadFile.UseVisualStyleBackColor = true;
            this.BtnReadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // LstAll
            // 
            this.LstAll.FormattingEnabled = true;
            this.LstAll.Location = new System.Drawing.Point(34, 103);
            this.LstAll.Name = "LstAll";
            this.LstAll.Size = new System.Drawing.Size(238, 433);
            this.LstAll.TabIndex = 1;
            this.LstAll.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LstPalindrome
            // 
            this.LstPalindrome.FormattingEnabled = true;
            this.LstPalindrome.Location = new System.Drawing.Point(618, 103);
            this.LstPalindrome.Name = "LstPalindrome";
            this.LstPalindrome.Size = new System.Drawing.Size(167, 433);
            this.LstPalindrome.TabIndex = 2;
            // 
            // LstNotPalindrome
            // 
            this.LstNotPalindrome.FormattingEnabled = true;
            this.LstNotPalindrome.Location = new System.Drawing.Point(811, 103);
            this.LstNotPalindrome.Name = "LstNotPalindrome";
            this.LstNotPalindrome.Size = new System.Drawing.Size(163, 433);
            this.LstNotPalindrome.TabIndex = 3;
            // 
            // BtnFilterPalindrome
            // 
            this.BtnFilterPalindrome.Location = new System.Drawing.Point(354, 242);
            this.BtnFilterPalindrome.Name = "BtnFilterPalindrome";
            this.BtnFilterPalindrome.Size = new System.Drawing.Size(174, 129);
            this.BtnFilterPalindrome.TabIndex = 4;
            this.BtnFilterPalindrome.Text = "Filtrer palindrome";
            this.BtnFilterPalindrome.UseVisualStyleBackColor = true;
            this.BtnFilterPalindrome.Click += new System.EventHandler(this.BtnFilterPalindrome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 570);
            this.Controls.Add(this.BtnFilterPalindrome);
            this.Controls.Add(this.LstNotPalindrome);
            this.Controls.Add(this.LstPalindrome);
            this.Controls.Add(this.LstAll);
            this.Controls.Add(this.BtnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnReadFile;
        private System.Windows.Forms.ListBox LstAll;
        private System.Windows.Forms.ListBox LstPalindrome;
        private System.Windows.Forms.ListBox LstNotPalindrome;
        private System.Windows.Forms.Button BtnFilterPalindrome;
    }
}

