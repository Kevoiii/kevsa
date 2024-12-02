/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 01/12/2024
 * Time: 07:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sasaa
{
	/// <summary>
	/// Description of Form7.
	/// </summary>
	public partial class Form7 : Form
	{
		public Form7()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnvolverClick(object sender, EventArgs e)
		{
			Form6 mn = new Form6();
			this.Hide();
			mn.ShowDialog();
			this.Close();
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
	}
}
