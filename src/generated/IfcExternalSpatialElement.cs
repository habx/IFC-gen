/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcExternalSpatialElement : IfcExternalSpatialStructureElement 
	{
		public IfcExternalSpatialElement(IfcExternalSpatialElementTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				IfcSpatialElementContainsElements containsElements,
				IfcSpatialElementReferencesElements referencesElements,
				String longName,
				IfcObjectPlacement objectPlacement,
				IfcProductRepresentation representation,
				IfcRelDefinesByObject isDeclaredBy,
				IfcRelDefinesByType isTypedBy,
				IfcObjectIsDefinedBy isDefinedBy,
				String objectType,
				IfcObjectDefinitionIsNestedBy isNestedBy,
				IfcObjectDefinitionIsDecomposedBy isDecomposedBy) : base(containsElements,
				referencesElements,
				longName,
				objectPlacement,
				representation,
				isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.PredefinedType = predefinedType;
			this.PredefinedTypeSpecified = predefinedTypeSpecified;
		}
	}
}