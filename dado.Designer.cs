namespace Ldado
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
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.btnLanzar2 = new System.Windows.Forms.Button();
            this.btn2Dados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(12, 97);
            this.txtMuestra.Multiline = true;
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(364, 219);
            this.txtMuestra.TabIndex = 0;
            this.txtMuestra.TextChanged += new System.EventHandler(this.txtMuestra_TextChanged);
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(12, 30);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(96, 23);
            this.btnLanzar.TabIndex = 1;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // btnLanzar2
            // 
            this.btnLanzar2.Location = new System.Drawing.Point(152, 30);
            this.btnLanzar2.Name = "btnLanzar2";
            this.btnLanzar2.Size = new System.Drawing.Size(92, 23);
            this.btnLanzar2.TabIndex = 2;
            this.btnLanzar2.Text = "Lanzar 2 veces";
            this.btnLanzar2.UseVisualStyleBackColor = true;
            this.btnLanzar2.Click += new System.EventHandler(this.btnLanzar2_Click);
            // 
            // btn2Dados
            // 
            this.btn2Dados.Location = new System.Drawing.Point(274, 30);
            this.btn2Dados.Name = "btn2Dados";
            this.btn2Dados.Size = new System.Drawing.Size(102, 23);
            this.btn2Dados.TabIndex = 3;
            this.btn2Dados.Text = "Lanzar 2 dados";
            this.btn2Dados.UseVisualStyleBackColor = true;
            this.btn2Dados.Click += new System.EventHandler(this.btn2Dados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 328);
            this.Controls.Add(this.btn2Dados);
            this.Controls.Add(this.btnLanzar2);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.txtMuestra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Button btnLanzar2;
        private System.Windows.Forms.Button btn2Dados;
    }
}

