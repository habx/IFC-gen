/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcInventory : IfcGroup 
	{
		public IfcInventory(IfcInventoryJurisdiction jurisdiction,
				IfcInventoryResponsiblePersons responsiblePersons,
				IfcCostValue currentValue,
				IfcCostValue originalValue,
				IfcInventoryTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				String lastUpdateDate,
				IfcRelDefinesByObject isDeclaredBy,
				IfcRelDefinesByType isTypedBy,
				IfcObjectIsDefinedBy isDefinedBy,
				String objectType,
				IfcObjectDefinitionIsNestedBy isNestedBy,
				IfcObjectDefinitionIsDecomposedBy isDecomposedBy) : base(isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.Jurisdiction = jurisdiction;
			this.ResponsiblePersons = responsiblePersons;
			this.CurrentValue = currentValue;
			this.OriginalValue = originalValue;
			this.PredefinedType = predefinedType;
			this.PredefinedTypeSpecified = predefinedTypeSpecified;
			this.LastUpdateDate = lastUpdateDate;
		}
	}
}