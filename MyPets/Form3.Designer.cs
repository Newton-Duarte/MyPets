namespace MyPets
{
    partial class MeusFavoritos
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
            this.label1 = new System.Windows.Forms.Label();
            this.buscarPetsTitle = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Label();
            this.meusFavoritosList = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sua lista de cachorros favoritos";
            // 
            // buscarPetsTitle
            // 
            this.buscarPetsTitle.AutoSize = true;
            this.buscarPetsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarPetsTitle.Location = new System.Drawing.Point(12, 9);
            this.buscarPetsTitle.Name = "buscarPetsTitle";
            this.buscarPetsTitle.Size = new System.Drawing.Size(138, 24);
            this.buscarPetsTitle.TabIndex = 2;
            this.buscarPetsTitle.Text = "Meus Favoritos";
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(12, 61);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(777, 2);
            this.separator.TabIndex = 4;
            // 
            // meusFavoritosList
            // 
            this.meusFavoritosList.FormattingEnabled = true;
            this.meusFavoritosList.Location = new System.Drawing.Point(210, 95);
            this.meusFavoritosList.Name = "meusFavoritosList";
            this.meusFavoritosList.Size = new System.Drawing.Size(350, 277);
            this.meusFavoritosList.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(485, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Remover";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // MeusFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.meusFavoritosList);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarPetsTitle);
            this.Name = "MeusFavoritos";
            this.Text = "Meus Favoritos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label buscarPetsTitle;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.ListBox meusFavoritosList;
        private System.Windows.Forms.Button btnDelete;
    }
}