﻿/*
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
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
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
			Form2 form2= new Form2();
			this.Hide();
			form2.ShowDialog();
			this.Close();
		}
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			Form4 form4= new Form4();
			this.Hide();
			form4.ShowDialog();
			this.Close();
		}
	}
}
