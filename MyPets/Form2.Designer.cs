namespace MyPets
{
    partial class BuscarPets
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
            this.buscarPetsTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Label();
            this.racaCachorro = new System.Windows.Forms.Label();
            this.racaComboBox = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buscarPetsTitle
            // 
            this.buscarPetsTitle.AutoSize = true;
            this.buscarPetsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarPetsTitle.Location = new System.Drawing.Point(12, 9);
            this.buscarPetsTitle.Name = "buscarPetsTitle";
            this.buscarPetsTitle.Size = new System.Drawing.Size(203, 24);
            this.buscarPetsTitle.TabIndex = 0;
            this.buscarPetsTitle.Text = "Encontre seu cachorro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o cachorro para obter mais informações";
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(13, 61);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(777, 2);
            this.separator.TabIndex = 2;
            // 
            // racaCachorro
            // 
            this.racaCachorro.AutoSize = true;
            this.racaCachorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.racaCachorro.Location = new System.Drawing.Point(187, 122);
            this.racaCachorro.Name = "racaCachorro";
            this.racaCachorro.Size = new System.Drawing.Size(139, 17);
            this.racaCachorro.TabIndex = 3;
            this.racaCachorro.Text = "Raça do Cachorro";
            // 
            // racaComboBox
            // 
            this.racaComboBox.FormattingEnabled = true;
            this.racaComboBox.Items.AddRange(new object[] {
            "Caucasian Shepherd Dog",
            "Bouvier des Flandres",
            "Grand Basset Griffon Vendéen",
            "Hokkaido",
            "Japanese Terrier",
            "Hanoverian Scenthound",
            "Tibetan Spaniel",
            "Border Collie",
            "Curly-Coated Retriever",
            "Skye Terrier"});
            this.racaComboBox.Location = new System.Drawing.Point(332, 122);
            this.racaComboBox.Name = "racaComboBox";
            this.racaComboBox.Size = new System.Drawing.Size(178, 21);
            this.racaComboBox.TabIndex = 4;
            this.racaComboBox.Text = "Selecione um cachorro";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(162, 178);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 15);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 166);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(156, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 2);
            this.label3.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(516, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // BuscarPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.racaComboBox);
            this.Controls.Add(this.racaCachorro);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarPetsTitle);
            this.Name = "BuscarPets";
            this.Text = "Buscar Pets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buscarPetsTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Label racaCachorro;
        private System.Windows.Forms.ComboBox racaComboBox;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
    }
}