/*
 * Created by SharpDevelop.
 * User: rutht
 * Date: 04/02/2021
 * Time: 5:16 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HelpDesk
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox helpdesk;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.TextBox priobox;
		private System.Windows.Forms.TextBox IDbox;
		private System.Windows.Forms.Button FL;
		private System.Windows.Forms.Button del;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Label prio;
		private System.Windows.Forms.Label ID;
		private System.Windows.Forms.Panel panel1;
		
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
			this.helpdesk = new System.Windows.Forms.ListBox();
			this.Add = new System.Windows.Forms.Button();
			this.priobox = new System.Windows.Forms.TextBox();
			this.IDbox = new System.Windows.Forms.TextBox();
			this.FL = new System.Windows.Forms.Button();
			this.del = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.prio = new System.Windows.Forms.Label();
			this.ID = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// helpdesk
			// 
			this.helpdesk.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.helpdesk.FormattingEnabled = true;
			this.helpdesk.ItemHeight = 19;
			this.helpdesk.Location = new System.Drawing.Point(8, 63);
			this.helpdesk.MultiColumn = true;
			this.helpdesk.Name = "helpdesk";
			this.helpdesk.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.helpdesk.Size = new System.Drawing.Size(836, 232);
			this.helpdesk.TabIndex = 0;
			// 
			// Add
			// 
			this.Add.BackColor = System.Drawing.Color.Teal;
			this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Add.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Add.Location = new System.Drawing.Point(125, 306);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(140, 32);
			this.Add.TabIndex = 1;
			this.Add.Text = "ADD";
			this.Add.UseVisualStyleBackColor = false;
			this.Add.Click += new System.EventHandler(this.AddClick);
			// 
			// priobox
			// 
			this.priobox.BackColor = System.Drawing.Color.White;
			this.priobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.priobox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.priobox.ForeColor = System.Drawing.Color.Black;
			this.priobox.Location = new System.Drawing.Point(325, 14);
			this.priobox.Multiline = true;
			this.priobox.Name = "priobox";
			this.priobox.Size = new System.Drawing.Size(57, 31);
			this.priobox.TabIndex = 2;
			this.priobox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.priobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrioboxKeyPress);
			// 
			// IDbox
			// 
			this.IDbox.BackColor = System.Drawing.Color.White;
			this.IDbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.IDbox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IDbox.Location = new System.Drawing.Point(539, 16);
			this.IDbox.Multiline = true;
			this.IDbox.Name = "IDbox";
			this.IDbox.Size = new System.Drawing.Size(70, 29);
			this.IDbox.TabIndex = 3;
			this.IDbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FL
			// 
			this.FL.BackColor = System.Drawing.Color.Teal;
			this.FL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.FL.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FL.ForeColor = System.Drawing.Color.AliceBlue;
			this.FL.Location = new System.Drawing.Point(271, 307);
			this.FL.Name = "FL";
			this.FL.Size = new System.Drawing.Size(152, 31);
			this.FL.TabIndex = 4;
			this.FL.Text = "FORM LOAD";
			this.FL.UseVisualStyleBackColor = false;
			this.FL.Click += new System.EventHandler(this.FLClick);
			// 
			// del
			// 
			this.del.BackColor = System.Drawing.Color.Teal;
			this.del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.del.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.del.Location = new System.Drawing.Point(429, 306);
			this.del.Name = "del";
			this.del.Size = new System.Drawing.Size(152, 32);
			this.del.TabIndex = 5;
			this.del.Text = "DELETE";
			this.del.UseVisualStyleBackColor = false;
			this.del.Click += new System.EventHandler(this.DelClick);
			// 
			// exit
			// 
			this.exit.BackColor = System.Drawing.Color.Teal;
			this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.exit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit.ForeColor = System.Drawing.Color.White;
			this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.exit.Location = new System.Drawing.Point(587, 307);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(152, 31);
			this.exit.TabIndex = 6;
			this.exit.Text = "EXIT";
			this.exit.UseVisualStyleBackColor = false;
			this.exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// prio
			// 
			this.prio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.prio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.prio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.prio.Location = new System.Drawing.Point(200, 9);
			this.prio.Name = "prio";
			this.prio.Size = new System.Drawing.Size(119, 45);
			this.prio.TabIndex = 7;
			this.prio.Text = "PRIORITY NO.";
			this.prio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ID
			// 
			this.ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ID.Location = new System.Drawing.Point(429, 9);
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(114, 45);
			this.ID.TabIndex = 8;
			this.ID.Text = "ID NO.";
			this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.exit);
			this.panel1.Controls.Add(this.ID);
			this.panel1.Controls.Add(this.del);
			this.panel1.Controls.Add(this.prio);
			this.panel1.Controls.Add(this.FL);
			this.panel1.Controls.Add(this.IDbox);
			this.panel1.Controls.Add(this.Add);
			this.panel1.Controls.Add(this.priobox);
			this.panel1.Controls.Add(this.helpdesk);
			this.panel1.Location = new System.Drawing.Point(0, -3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(864, 365);
			this.panel1.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(860, 354);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "HelpDesk";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
