/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSurfaceCurveSweptAreaSolid : IfcSweptAreaSolid 
	{
		public IfcSurfaceCurveSweptAreaSolid(IfcCurve directrix,
				IfcSurface referenceSurface,
				Double startParam,
				Boolean startParamSpecified,
				Double endParam,
				Boolean endParamSpecified,
				IfcProfileDef sweptArea,
				IfcAxis2Placement3D position,
				IfcStyledItem styledByItem) : base(sweptArea,
				position,
				styledByItem)
		{
			this.Directrix = directrix;
			this.ReferenceSurface = referenceSurface;
			this.StartParam = startParam;
			this.StartParamSpecified = startParamSpecified;
			this.EndParam = endParam;
			this.EndParamSpecified = endParamSpecified;
		}
	}
}