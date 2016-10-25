﻿/*****************************************************************************
 * 
 * ReoGrid - .NET Spreadsheet Control
 * 
 * http://reogrid.net
 *
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
 * PURPOSE.
 *
 * ReoGrid and ReoGrid Demo project is released under MIT license.
 *
 * Copyright (c) 2012-2016 Jing <lujing at unvell.com>
 * Copyright (c) 2012-2016 unvell.com, all rights reserved.
 * 
 ****************************************************************************/

namespace unvell.ReoGrid.Demo.Print
{
	partial class PrintMultipleWorksheetDemo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grid = new unvell.ReoGrid.ReoGridControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tckZoom = new System.Windows.Forms.TrackBar();
			this.labZoom = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPrintSetup = new System.Windows.Forms.Button();
			this.btnPreview = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tckZoom)).BeginInit();
			this.SuspendLayout();
			// 
			// grid
			// 
			this.grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.grid.ColumnHeaderContextMenuStrip = null;
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.LeadHeaderContextMenuStrip = null;
			this.grid.Location = new System.Drawing.Point(0, 61);
			this.grid.Name = "grid";
			this.grid.RowHeaderContextMenuStrip = null;
			this.grid.Script = null;
			this.grid.SheetTabContextMenuStrip = null;
			this.grid.SheetTabWidth = 400;
			this.grid.Size = new System.Drawing.Size(833, 492);
			this.grid.TabIndex = 3;
			this.grid.Text = "reoGridControl1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tckZoom);
			this.panel1.Controls.Add(this.labZoom);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnPrintSetup);
			this.panel1.Controls.Add(this.btnPreview);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(833, 61);
			this.panel1.TabIndex = 4;
			// 
			// tckZoom
			// 
			this.tckZoom.LargeChange = 20;
			this.tckZoom.Location = new System.Drawing.Point(593, 18);
			this.tckZoom.Maximum = 100;
			this.tckZoom.Minimum = 10;
			this.tckZoom.Name = "tckZoom";
			this.tckZoom.Size = new System.Drawing.Size(160, 45);
			this.tckZoom.SmallChange = 10;
			this.tckZoom.TabIndex = 6;
			this.tckZoom.TickFrequency = 10;
			this.tckZoom.Value = 50;
			// 
			// labZoom
			// 
			this.labZoom.AutoSize = true;
			this.labZoom.Location = new System.Drawing.Point(759, 25);
			this.labZoom.Name = "labZoom";
			this.labZoom.Size = new System.Drawing.Size(27, 13);
			this.labZoom.TabIndex = 2;
			this.labZoom.Text = "50%";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(149, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Need A4-support printer to preview properly.";
			// 
			// btnPrintSetup
			// 
			this.btnPrintSetup.Location = new System.Drawing.Point(430, 15);
			this.btnPrintSetup.Name = "btnPrintSetup";
			this.btnPrintSetup.Size = new System.Drawing.Size(127, 32);
			this.btnPrintSetup.TabIndex = 1;
			this.btnPrintSetup.Text = "Page Setup...";
			this.btnPrintSetup.UseVisualStyleBackColor = true;
			// 
			// btnPreview
			// 
			this.btnPreview.Location = new System.Drawing.Point(16, 15);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(127, 32);
			this.btnPreview.TabIndex = 0;
			this.btnPreview.Text = "Preview...";
			this.btnPreview.UseVisualStyleBackColor = true;
			// 
			// PrintMultipleWorksheetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 553);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.panel1);
			this.Name = "PrintMultipleWorksheetForm";
			this.Text = "PrintMultipleWorksheetForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tckZoom)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ReoGridControl grid;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TrackBar tckZoom;
		private System.Windows.Forms.Label labZoom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPrintSetup;
		private System.Windows.Forms.Button btnPreview;
	}
}