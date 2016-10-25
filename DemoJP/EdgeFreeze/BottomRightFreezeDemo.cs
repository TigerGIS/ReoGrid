﻿/*****************************************************************************
 * 
 * ReoGrid - .NET 表計算スプレッドシートコンポーネント
 * http://reogrid.net/jp
 *
 * ReoGrid 日本語版デモプロジェクトは MIT ライセンスでリリースされています。
 * 
 * このソフトウェアは無保証であり、このソフトウェアの使用により生じた直接・間接の損害に対し、
 * 著作権者は補償を含むあらゆる責任を負いません。 
 * 
 * Copyright (c) 2012-2016 unvell.com, All Rights Reserved.
 * http://www.unvell.com/jp
 * 
 ****************************************************************************/

using System;
using System.Windows.Forms;

namespace unvell.ReoGrid.Demo.WorksheetDemo.EdgeFreeze
{
	public partial class BottomRightFreezeDemo : UserControl
	{
		public BottomRightFreezeDemo()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			var worksheet = reoGridControl.CurrentWorksheet;
		
			worksheet.Reset(100, 30);

			// freeze to bottom right
			worksheet.FreezeToCell(85, 25, FreezeArea.RightBottom);
		
			worksheet[90, 27] = "frozen region";
			worksheet[5, 3] = "active region";
		}
	}
}
