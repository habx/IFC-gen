/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcPointOnCurve : IfcPoint 
	{
		public IfcPointOnCurve(IfcCurve basisCurve,
				Double pointParameter,
				Boolean pointParameterSpecified,
				IfcStyledItem styledByItem) : base(styledByItem)
		{
			this.BasisCurve = basisCurve;
			this.PointParameter = pointParameter;
			this.PointParameterSpecified = pointParameterSpecified;
		}
	}
}