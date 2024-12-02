/*
 * Created by SharpDevelop.
 * User: CC1_PC12
 * Date: 29/11/2024
 * Time: 12:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
 
namespace sasaa
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		public Form5()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=CEBcd6ToHJk");
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=8P3lTxmjA-w");
		}
		void PictureBox3Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=Qv-x5wKQQLQ");
		}
		void PictureBox4Click(object sender, EventArgs e)
		{
			
			Process.Start("https://www.youtube.com/watch?v=ZbN5bsNQBGk");
		}
		void BtnvolverClick(object sender, EventArgs e)
		{
			Form4 mn = new Form4();
			this.Hide();
			mn.ShowDialog();
			this.Close();
		}
	}
}
