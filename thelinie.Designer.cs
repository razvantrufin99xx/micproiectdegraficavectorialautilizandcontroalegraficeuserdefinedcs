/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/29/2024
 * Time: 10:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace linie
{
	partial class thelinie
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.SuspendLayout();
			// 
			// thelinie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "thelinie";
			this.Size = new System.Drawing.Size(371, 2);
			this.Load += new System.EventHandler(this.ThelinieLoad);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.TheliniePaint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThelinieMouseDown);
			this.MouseEnter += new System.EventHandler(this.ThelinieMouseEnter);
			this.MouseLeave += new System.EventHandler(this.ThelinieMouseLeave);
			this.MouseHover += new System.EventHandler(this.ThelinieMouseHover);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThelinieMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThelinieMouseUp);
			this.ResumeLayout(false);

		}
	}
}
