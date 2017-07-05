/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSweptDiskSolid : IfcSolidModel 
	{
		public IfcSweptDiskSolid(IfcCurve directrix,
				Double radius,
				Boolean radiusSpecified,
				Double innerRadius,
				Boolean innerRadiusSpecified,
				Double startParam,
				Boolean startParamSpecified,
				Double endParam,
				Boolean endParamSpecified,
				IfcStyledItem styledByItem) : base(styledByItem)
		{
			this.Directrix = directrix;
			this.Radius = radius;
			this.RadiusSpecified = radiusSpecified;
			this.InnerRadius = innerRadius;
			this.InnerRadiusSpecified = innerRadiusSpecified;
			this.StartParam = startParam;
			this.StartParamSpecified = startParamSpecified;
			this.EndParam = endParam;
			this.EndParamSpecified = endParamSpecified;
		}
	}
}