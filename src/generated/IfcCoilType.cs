/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcCoilType : IfcEnergyConversionDeviceType 
	{
		public IfcCoilType(IfcCoilTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
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
			this.PredefinedType = predefinedType;
			this.PredefinedTypeSpecified = predefinedTypeSpecified;
		}
	}
}