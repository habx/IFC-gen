/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcDistributionPort : IfcPort 
	{
		public IfcDistributionPort(IfcFlowDirectionEnum flowDirection,
				Boolean flowDirectionSpecified,
				IfcDistributionPortTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				IfcDistributionSystemEnum systemType,
				Boolean systemTypeSpecified,
				IfcObjectPlacement objectPlacement,
				IfcProductRepresentation representation,
				IfcRelDefinesByObject isDeclaredBy,
				IfcRelDefinesByType isTypedBy,
				IfcObjectIsDefinedBy isDefinedBy,
				String objectType,
				IfcObjectDefinitionIsNestedBy isNestedBy,
				IfcObjectDefinitionIsDecomposedBy isDecomposedBy) : base(objectPlacement,
				representation,
				isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.FlowDirection = flowDirection;
			this.FlowDirectionSpecified = flowDirectionSpecified;
			this.PredefinedType = predefinedType;
			this.PredefinedTypeSpecified = predefinedTypeSpecified;
			this.SystemType = systemType;
			this.SystemTypeSpecified = systemTypeSpecified;
		}
	}
}