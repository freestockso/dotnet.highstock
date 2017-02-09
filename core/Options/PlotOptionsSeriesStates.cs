using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// A wrapper object for all the series options in specific states.
	/// </summary>
	public class PlotOptionsSeriesStates
	{
		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsSeriesStatesHover Hover { get; set; }

	}

}