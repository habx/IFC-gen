/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSweptDiskSolidPolygonal : IfcSweptDiskSolid 
	{
		public IfcSweptDiskSolidPolygonal(Double filletRadius,
				Boolean filletRadiusSpecified,
				IfcCurve directrix,
				Double radius,
				Boolean radiusSpecified,
				Double innerRadius,
				Boolean innerRadiusSpecified,
				Double startParam,
				Boolean startParamSpecified,
				Double endParam,
				Boolean endParamSpecified,
				IfcStyledItem styledByItem) : base(directrix,
				radius,
				radiusSpecified,
				innerRadius,
				innerRadiusSpecified,
				startParam,
				startParamSpecified,
				endParam,
				endParamSpecified,
				styledByItem)
		{
			this.FilletRadius = filletRadius;
			this.FilletRadiusSpecified = filletRadiusSpecified;
		}
	}
}