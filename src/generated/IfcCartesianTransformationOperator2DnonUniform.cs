/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D 
	{
		public IfcCartesianTransformationOperator2DnonUniform(Double scale2,
				Boolean scale2Specified,
				IfcDirection axis1,
				IfcDirection axis2,
				IfcCartesianPoint localOrigin,
				Double scale,
				Boolean scaleSpecified,
				IfcStyledItem styledByItem) : base(axis1,
				axis2,
				localOrigin,
				scale,
				scaleSpecified,
				styledByItem)
		{
			this.Scale2 = scale2;
			this.Scale2Specified = scale2Specified;
		}
	}
}