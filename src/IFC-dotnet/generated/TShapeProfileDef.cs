/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctshapeprofiledef.htm
	/// </summary>
	internal  partial class TShapeProfileDef : ParameterizedProfileDef 
	{
		public Double Depth {get;set;}

		public Double FlangeWidth {get;set;}

		public Double WebThickness {get;set;}

		public Double FlangeThickness {get;set;}

		public Double FilletRadius {get;set;}

		public Double FlangeEdgeRadius {get;set;}

		public Double WebEdgeRadius {get;set;}

		public Double WebSlope {get;set;}

		public Double FlangeSlope {get;set;}

		public TShapeProfileDef(Double depth,
				Double flangeWidth,
				Double webThickness,
				Double flangeThickness,
				Double filletRadius,
				Double flangeEdgeRadius,
				Double webEdgeRadius,
				Double webSlope,
				Double flangeSlope,
				Axis2Placement2D position,
				ProfileDefHasProperties hasProperties,
				ProfileTypeEnum profileType,
				String profileName) : base(position,
				hasProperties,
				profileType,
				profileName)
		{
			this.Depth = depth;
			this.FlangeWidth = flangeWidth;
			this.WebThickness = webThickness;
			this.FlangeThickness = flangeThickness;
			this.FilletRadius = filletRadius;
			this.FlangeEdgeRadius = flangeEdgeRadius;
			this.WebEdgeRadius = webEdgeRadius;
			this.WebSlope = webSlope;
			this.FlangeSlope = flangeSlope;
		}
	}
}