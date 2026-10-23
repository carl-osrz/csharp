/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 23/10/2026
 * Hora: 07:34 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace multiplica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Location = new System.Drawing.Point(55, 223);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(228, 54);
			this.btnMultiplicar.TabIndex = 0;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(55, 33);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(100, 23);
			this.lbl1.TabIndex = 1;
			this.lbl1.Text = "Número 1:";
			// 
			// lbl2
			// 
			this.lbl2.Location = new System.Drawing.Point(55, 98);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(100, 23);
			this.lbl2.TabIndex = 2;
			this.lbl2.Text = "Número 2:";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(183, 34);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 22);
			this.txt1.TabIndex = 3;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(183, 99);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(100, 22);
			this.txt2.TabIndex = 4;
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(55, 142);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(228, 67);
			this.lblRespuesta.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 301);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.btnMultiplicar);
			this.Name = "MainForm";
			this.Text = "multiplica";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Button btnMultiplicar;
	}
}
