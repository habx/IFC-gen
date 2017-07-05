/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcCShapeProfileDef : IfcParameterizedProfileDef 
	{
		public IfcCShapeProfileDef(Double depth,
				Boolean depthSpecified,
				Double width,
				Boolean widthSpecified,
				Double wallThickness,
				Boolean wallThicknessSpecified,
				Double girth,
				Boolean girthSpecified,
				Double internalFilletRadius,
				Boolean internalFilletRadiusSpecified,
				IfcAxis2Placement2D position,
				IfcProfileDefHasProperties hasProperties,
				IfcProfileTypeEnum profileType,
				Boolean profileTypeSpecified,
				String profileName) : base(position,
				hasProperties,
				profileType,
				profileTypeSpecified,
				profileName)
		{
			this.Depth = depth;
			this.DepthSpecified = depthSpecified;
			this.Width = width;
			this.WidthSpecified = widthSpecified;
			this.WallThickness = wallThickness;
			this.WallThicknessSpecified = wallThicknessSpecified;
			this.Girth = girth;
			this.GirthSpecified = girthSpecified;
			this.InternalFilletRadius = internalFilletRadius;
			this.InternalFilletRadiusSpecified = internalFilletRadiusSpecified;
		}
	}
}