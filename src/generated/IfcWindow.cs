/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcWindow : IfcBuildingElement 
	{
		public IfcWindow(Double overallHeight,
				Boolean overallHeightSpecified,
				Double overallWidth,
				Boolean overallWidthSpecified,
				IfcWindowTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				IfcWindowTypePartitioningEnum partitioningType,
				Boolean partitioningTypeSpecified,
				String userDefinedPartitioningType,
				IfcRelProjectsElement hasProjections,
				IfcRelVoidsElement hasOpenings,
				String tag,
				IfcObjectPlacement objectPlacement,
				IfcProductRepresentation representation,
				IfcRelDefinesByObject isDeclaredBy,
				IfcRelDefinesByType isTypedBy,
				IfcObjectIsDefinedBy isDefinedBy,
				String objectType,
				IfcObjectDefinitionIsNestedBy isNestedBy,
				IfcObjectDefinitionIsDecomposedBy isDecomposedBy) : base(hasProjections,
				hasOpenings,
				tag,
				objectPlacement,
				representation,
				isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.OverallHeight = overallHeight;
			this.OverallHeightSpecified = overallHeightSpecified;
			this.OverallWidth = overallWidth;
			this.OverallWidthSpecified = overallWidthSpecified;
			this.PredefinedType = predefinedType;
			this.PredefinedTypeSpecified = predefinedTypeSpecified;
			this.PartitioningType = partitioningType;
			this.PartitioningTypeSpecified = partitioningTypeSpecified;
			this.UserDefinedPartitioningType = userDefinedPartitioningType;
		}
	}
}