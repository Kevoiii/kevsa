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

namespace sasaa
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
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
			Form3 form3= new Form3();
			this.Hide();
			form3.ShowDialog();
			this.Close();
		}
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			Form5 form5= new Form5();
			this.Hide();
			form5.ShowDialog();
			this.Close();
		}
	}
}
