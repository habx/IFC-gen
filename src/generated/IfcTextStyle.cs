/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcTextStyle : IfcPresentationStyle 
	{
		public IfcTextStyle(IfcTextStyleForDefinedFont textCharacterAppearance,
				IfcTextStyleTextModel textStyle,
				IfcTextStyleTextFontStyle textFontStyle,
				Boolean modelOrDraughting,
				Boolean modelOrDraughtingSpecified,
				String name) : base(name)
		{
			this.TextCharacterAppearance = textCharacterAppearance;
			this.TextStyle = textStyle;
			this.TextFontStyle = textFontStyle;
			this.ModelOrDraughting = modelOrDraughting;
			this.ModelOrDraughtingSpecified = modelOrDraughtingSpecified;
		}
	}
}