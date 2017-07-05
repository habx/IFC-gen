/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcReinforcingBarType : IfcReinforcingElementType 
	{
		public IfcReinforcingBarType(IfcReinforcingBarTypeBendingParameters bendingParameters,
				IfcReinforcingBarTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				Double nominalDiameter,
				Boolean nominalDiameterSpecified,
				Double crossSectionArea,
				Boolean crossSectionAreaSpecified,
				Double barLength,
				Boolean barLengthSpecified,
				IfcReinforcingBarSurfaceEnum barSurface,
				Boolean barSurfaceSpecified,
				String bendingShapeCode,
				String elementType,
				IfcTypeProductRepresentationMaps representationMaps,
				String tag,
				IfcTypeObjectHasPropertySets hasPropertySets,
				String applicableOccurrence,
				IfcObjectDefinitionIsNestedBy isNestedBy,
				IfcObjectDefinitionIsDecomposedBy isDecomposedBy) : base(elementType,
				representationMaps,
				tag,
				hasPropertySets,
				applicableOccurrence,
				isNestedBy,
				isDecomposedBy)
		{
			this.BendingParameters = bendingParameters;
			this.PredefinedType = predefinedType;
			this.PredefinedTypeSpecified = predefinedTypeSpecified;
			this.NominalDiameter = nominalDiameter;
			this.NominalDiameterSpecified = nominalDiameterSpecified;
			this.CrossSectionArea = crossSectionArea;
			this.CrossSectionAreaSpecified = crossSectionAreaSpecified;
			this.BarLength = barLength;
			this.BarLengthSpecified = barLengthSpecified;
			this.BarSurface = barSurface;
			this.BarSurfaceSpecified = barSurfaceSpecified;
			this.BendingShapeCode = bendingShapeCode;
		}
	}
}