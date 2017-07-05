/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcStructuralLoadGroup : IfcGroup 
	{
		public IfcStructuralLoadGroup(IfcLoadGroupTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				IfcActionTypeEnum actionType,
				Boolean actionTypeSpecified,
				IfcActionSourceTypeEnum actionSource,
				Boolean actionSourceSpecified,
				Double coefficient,
				Boolean coefficientSpecified,
				String purpose,
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
			this.PredefinedType = predefinedType;
			this.PredefinedTypeSpecified = predefinedTypeSpecified;
			this.ActionType = actionType;
			this.ActionTypeSpecified = actionTypeSpecified;
			this.ActionSource = actionSource;
			this.ActionSourceSpecified = actionSourceSpecified;
			this.Coefficient = coefficient;
			this.CoefficientSpecified = coefficientSpecified;
			this.Purpose = purpose;
		}
	}
}