
namespace MyFirstForm
{
    partial class frmComboBox
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
            this.lbValor = new System.Windows.Forms.Label();
            this.comboDias = new System.Windows.Forms.ComboBox();
            this.btnMostar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(12, 31);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(34, 13);
            this.lbValor.TabIndex = 0;
            this.lbValor.Text = "Valor:";
            // 
            // comboDias
            // 
            this.comboDias.FormattingEnabled = true;
            this.comboDias.Items.AddRange(new object[] {
            "Lunes ",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.comboDias.Location = new System.Drawing.Point(52, 28);
            this.comboDias.Name = "comboDias";
            this.comboDias.Size = new System.Drawing.Size(137, 21);
            this.comboDias.TabIndex = 1;
            this.comboDias.Text = "Sleccione";
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(195, 28);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(75, 23);
            this.btnMostar.TabIndex = 2;
            this.btnMostar.Text = "Mostrar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(277, 28);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(49, 65);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 13);
            this.lbResultado.TabIndex = 4;
            // 
            // frmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 108);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.comboDias);
            this.Controls.Add(this.lbValor);
            this.Name = "frmComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.ComboBox comboDias;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbResultado;
    }
}