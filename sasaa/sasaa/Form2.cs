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
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
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
			Form1 form1= new Form1();
			this.Hide();
			form1.ShowDialog();
			this.Close();
		}
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			Form3 form3= new Form3();
			this.Hide();
			form3.ShowDialog();
			this.Close();
		}
	}
}
