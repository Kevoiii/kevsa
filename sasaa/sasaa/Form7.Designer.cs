/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 01/12/2024
 * Time: 07:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sasaa
{
	partial class Form7
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnvolver;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnvolver = new System.Windows.Forms.Button();
			this.btninicio = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Purple;
			this.label1.Location = new System.Drawing.Point(72, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(535, 158);
			this.label1.TabIndex = 27;
			this.label1.Text = "Gracias por\r\nsu atención";
			// 
			// btnvolver
			// 
			this.btnvolver.BackColor = System.Drawing.Color.Thistle;
			this.btnvolver.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnvolver.Location = new System.Drawing.Point(12, 224);
			this.btnvolver.Name = "btnvolver";
			this.btnvolver.Size = new System.Drawing.Size(75, 23);
			this.btnvolver.TabIndex = 37;
			this.btnvolver.Text = "<";
			this.btnvolver.UseVisualStyleBackColor = false;
			this.btnvolver.Click += new System.EventHandler(this.BtnvolverClick);
			// 
			// btninicio
			// 
			this.btninicio.BackColor = System.Drawing.Color.Thistle;
			this.btninicio.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btninicio.Location = new System.Drawing.Point(599, 224);
			this.btninicio.Name = "btninicio";
			this.btninicio.Size = new System.Drawing.Size(75, 23);
			this.btninicio.TabIndex = 38;
			this.btninicio.Text = "Inicio";
			this.btninicio.UseVisualStyleBackColor = false;
			this.btninicio.Click += new System.EventHandler(this.BtninicioClick);
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 279);
			this.Controls.Add(this.btninicio);
			this.Controls.Add(this.btnvolver);
			this.Controls.Add(this.label1);
			this.Name = "Form7";
			this.Text = "Form7";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btninicio;
	}
}
