/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 01/12/2024
 * Time: 07:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sasaa
{
	/// <summary>
	/// Description of Form6.
	/// </summary>
	public partial class Form6 : Form
	{
		public Form6()
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
			Form5 mn = new Form5();
			this.Hide();
			mn.ShowDialog();
			this.Close();
		}
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			Form7 mn = new Form7();
			this.Hide();
			mn.ShowDialog();
			this.Close();
		}
	}
}
