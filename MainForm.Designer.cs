/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/29/2024
 * Time: 10:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace linie
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private linie.thelinie thelinie1;
		private linie.thelinie thelinie2;
		
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
			this.thelinie1 = new linie.thelinie();
			this.thelinie2 = new linie.thelinie();
			this.SuspendLayout();
			// 
			// thelinie1
			// 
			this.thelinie1.Location = new System.Drawing.Point(112, 53);
			this.thelinie1.Name = "thelinie1";
			this.thelinie1.Size = new System.Drawing.Size(225, 1);
			this.thelinie1.TabIndex = 0;
			// 
			// thelinie2
			// 
			this.thelinie2.Location = new System.Drawing.Point(101, 146);
			this.thelinie2.Name = "thelinie2";
			this.thelinie2.Size = new System.Drawing.Size(732, 3);
			this.thelinie2.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1086, 500);
			this.Controls.Add(this.thelinie2);
			this.Controls.Add(this.thelinie1);
			this.Name = "MainForm";
			this.Text = "linie";
			this.ResumeLayout(false);

		}
	}
}
