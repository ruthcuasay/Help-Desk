/*
 * Created by SharpDevelop.
 * User: rutht
 * Date: 04/02/2021
 * Time: 5:16 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Data;

namespace HelpDesk
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void AddClick(object sender, EventArgs e)
		
		{

   using (StreamWriter sw = new StreamWriter(@"C:\Users\rutht\OneDrive\Desktop\yes.txt"))
   {
 
            foreach (string item in helpdesk.Items)
            {
               sw.WriteLine(item);
            }
 
            sw.Close();
            
   
			if (priobox.Text == "" || IDbox.Text == "")
			{
				MessageBox.Show("Please fill in the required fields");
				return;
			}
			
		
				
	 if (Int32.Parse(priobox.Text) >=1 && Int32.Parse(priobox.Text) <= 5)
		
		{
		var date = DateTime.Now;
		date = new DateTime(date.Year, date.Day, date.Month, date.Hour, date.Minute, date.Second, date.Kind);
		int g = 0;
		string time = DateTime.Now.AddHours(-g).ToString("HH:mm:ss");﻿	
		helpdesk.Items.Add("      " + "Priority:  " + priobox.Text + "        " + "ID: " + IDbox.Text + "      " + "Time Requested: " + time +   "        " + "Current Time: " +  date);
		priobox.Text = "";
		IDbox.Text ="";
		}
            else
            {
				MessageBox.Show("Priority Number 1-5 only");
            }
        }
   }
		
		void PrioboxKeyPress(object sender, KeyPressEventArgs e)
		
		{
	 if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
    {
        e.Handled = true;
    }
		}
		void IDboxKeyPress(object sender, KeyPressEventArgs e)
		{
	 if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
    {
        e.Handled = true;
   		 }

	}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			IDbox.MaxLength = 4;
			priobox.MaxLength = 1;
		}
			
		void ExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void DelClick(object sender, EventArgs e)
		{

  if (helpdesk.SelectedItems.Count != 0)
        {
            while (helpdesk.SelectedIndex!=-1)
            {
                helpdesk.Items.RemoveAt(helpdesk.SelectedIndex);                  
            }
  
 		 }
  
	}
		
		void FLClick(object sender, EventArgs e)
		
		{
			helpdesk.Items.Clear();
			System.IO.StreamReader file4= new System.IO.StreamReader(@"C:\Users\rutht\OneDrive\Desktop\yes.txt");
			string n;
			Queue <string> v = new Queue <string> ();
			while((n=file4.ReadLine())!= null)
			{
				v.Enqueue(n);
			}
			string[] s =v.ToArray();
			Array.Sort(s);
			Array.Reverse(s);

			foreach (string h in s)
			{
				helpdesk.Items.Add(h);
			}
	
		}
	}
			
}
			            		
 
		
		
	
	

	
			
		
		

		
		
	
		
	

