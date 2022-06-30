namespace Entra21_trabalho_02
{
    partial class MenuPrincipalForm
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
            this.buttonAldeia = new System.Windows.Forms.Button();
            this.buttonChakra = new System.Windows.Forms.Button();
            this.buttonCla = new System.Windows.Forms.Button();
            this.buttonNinja = new System.Windows.Forms.Button();
            this.buttonLider = new System.Windows.Forms.Button();
            this.buttonEquipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAldeia
            // 
            this.buttonAldeia.Location = new System.Drawing.Point(12, 23);
            this.buttonAldeia.Name = "buttonAldeia";
            this.buttonAldeia.Size = new System.Drawing.Size(129, 70);
            this.buttonAldeia.TabIndex = 0;
            this.buttonAldeia.Text = "Aldeia";
            this.buttonAldeia.UseVisualStyleBackColor = true;
            this.buttonAldeia.Click += new System.EventHandler(this.buttonAldeia_Click);
            // 
            // buttonChakra
            // 
            this.buttonChakra.Location = new System.Drawing.Point(185, 23);
            this.buttonChakra.Name = "buttonChakra";
            this.buttonChakra.Size = new System.Drawing.Size(129, 70);
            this.buttonChakra.TabIndex = 1;
            this.buttonChakra.Text = "Chakra";
            this.buttonChakra.UseVisualStyleBackColor = true;
            this.buttonChakra.Click += new System.EventHandler(this.buttonChakra_Click);
            // 
            // buttonCla
            // 
            this.buttonCla.Location = new System.Drawing.Point(362, 23);
            this.buttonCla.Name = "buttonCla";
            this.buttonCla.Size = new System.Drawing.Size(129, 70);
            this.buttonCla.TabIndex = 2;
            this.buttonCla.Text = "Clã";
            this.buttonCla.UseVisualStyleBackColor = true;
            this.buttonCla.Click += new System.EventHandler(this.buttonCla_Click);
            // 
            // buttonNinja
            // 
            this.buttonNinja.Location = new System.Drawing.Point(362, 136);
            this.buttonNinja.Name = "buttonNinja";
            this.buttonNinja.Size = new System.Drawing.Size(129, 70);
            this.buttonNinja.TabIndex = 5;
            this.buttonNinja.Text = "Ninja";
            this.buttonNinja.UseVisualStyleBackColor = true;
            this.buttonNinja.Click += new System.EventHandler(this.buttonNinja_Click);
            // 
            // buttonLider
            // 
            this.buttonLider.Location = new System.Drawing.Point(185, 136);
            this.buttonLider.Name = "buttonLider";
            this.buttonLider.Size = new System.Drawing.Size(129, 70);
            this.buttonLider.TabIndex = 4;
            this.buttonLider.Text = "Líder";
            this.buttonLider.UseVisualStyleBackColor = true;
            this.buttonLider.Click += new System.EventHandler(this.buttonLider_Click);
            // 
            // buttonEquipe
            // 
            this.buttonEquipe.Location = new System.Drawing.Point(12, 136);
            this.buttonEquipe.Name = "buttonEquipe";
            this.buttonEquipe.Size = new System.Drawing.Size(129, 70);
            this.buttonEquipe.TabIndex = 3;
            this.buttonEquipe.Text = "Equipe";
            this.buttonEquipe.UseVisualStyleBackColor = true;
            this.buttonEquipe.Click += new System.EventHandler(this.buttonEquipe_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 236);
            this.Controls.Add(this.buttonNinja);
            this.Controls.Add(this.buttonLider);
            this.Controls.Add(this.buttonEquipe);
            this.Controls.Add(this.buttonCla);
            this.Controls.Add(this.buttonChakra);
            this.Controls.Add(this.buttonAldeia);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonAldeia;
        private Button buttonChakra;
        private Button buttonCla;
        private Button buttonNinja;
        private Button buttonLider;
        private Button buttonEquipe;
    }
}