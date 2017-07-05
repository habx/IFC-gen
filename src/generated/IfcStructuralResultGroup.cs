/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcStructuralResultGroup : IfcGroup 
	{
		public IfcStructuralResultGroup(IfcStructuralLoadGroup resultForLoadGroup,
				IfcAnalysisTheoryTypeEnum theoryType,
				Boolean theoryTypeSpecified,
				Boolean isLinear,
				Boolean isLinearSpecified,
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
			this.ResultForLoadGroup = resultForLoadGroup;
			this.TheoryType = theoryType;
			this.TheoryTypeSpecified = theoryTypeSpecified;
			this.IsLinear = isLinear;
			this.IsLinearSpecified = isLinearSpecified;
		}
	}
}