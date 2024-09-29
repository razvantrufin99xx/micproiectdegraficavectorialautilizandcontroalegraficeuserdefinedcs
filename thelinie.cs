/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/29/2024
 * Time: 10:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace linie
{
	/// <summary>
	/// Description of thelinie.
	/// </summary>
	public partial class thelinie : UserControl
	{
		public thelinie()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Graphics g;
		public Color linecolor = Color.Red;
		public int ismousedown = 0;
		void TheliniePaint(object sender, PaintEventArgs e)
		{
			g.DrawLine(new Pen(linecolor),1,1,Width,1);
		}
		void ThelinieLoad(object sender, EventArgs e)
		{
			g  = this.CreateGraphics();
		}
		void ThelinieMouseDown(object sender, MouseEventArgs e)
		{
			linecolor = Color.Blue;
			g.DrawLine(new Pen(linecolor),1,1,Width,1);
			ismousedown = 1;
		}
		void ThelinieMouseUp(object sender, MouseEventArgs e)
		{
			linecolor = Color.Red;
			g.DrawLine(new Pen(linecolor),1,1,Width,1);
			ismousedown = 0;
		}
		void ThelinieMouseMove(object sender, MouseEventArgs e)
		{
			if(ismousedown==1)
			{
				this.Left += e.X;
				this.Top += e.Y;
			}
		}
		void ThelinieMouseHover(object sender, EventArgs e)
		{
			this.BorderStyle = BorderStyle.FixedSingle;
		}
		void ThelinieMouseLeave(object sender, EventArgs e)
		{
			this.BorderStyle = BorderStyle.None;
		}
		void ThelinieMouseEnter(object sender, EventArgs e)
		{
			this.BorderStyle = BorderStyle.FixedSingle;
		}
	}
}
