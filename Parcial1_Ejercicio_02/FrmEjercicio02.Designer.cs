
namespace Parcial1_Ejercicio_02
{
    partial class FrmEjercicio02
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFrase = new System.Windows.Forms.TextBox();
            this.Btmcalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LstPablabras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa la frase:";
            // 
            // TxtFrase
            // 
            this.TxtFrase.Location = new System.Drawing.Point(134, 28);
            this.TxtFrase.Multiline = true;
            this.TxtFrase.Name = "TxtFrase";
            this.TxtFrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtFrase.Size = new System.Drawing.Size(357, 62);
            this.TxtFrase.TabIndex = 1;
            // 
            // Btmcalcular
            // 
            this.Btmcalcular.Location = new System.Drawing.Point(524, 31);
            this.Btmcalcular.Name = "Btmcalcular";
            this.Btmcalcular.Size = new System.Drawing.Size(75, 59);
            this.Btmcalcular.TabIndex = 2;
            this.Btmcalcular.Text = "CALCULAR";
            this.Btmcalcular.UseVisualStyleBackColor = true;
            this.Btmcalcular.Click += new System.EventHandler(this.Btmcalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RESULTADO";
            // 
            // LstPablabras
            // 
            this.LstPablabras.FormattingEnabled = true;
            this.LstPablabras.Location = new System.Drawing.Point(27, 180);
            this.LstPablabras.Name = "LstPablabras";
            this.LstPablabras.Size = new System.Drawing.Size(265, 147);
            this.LstPablabras.TabIndex = 4;
            // 
            // FrmEjercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstPablabras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btmcalcular);
            this.Controls.Add(this.TxtFrase);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjercicio02";
            this.Text = "Cuenta la Palabra y su Longitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFrase;
        private System.Windows.Forms.Button Btmcalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LstPablabras;
    }
}

