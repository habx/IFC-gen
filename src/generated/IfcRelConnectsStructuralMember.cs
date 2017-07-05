/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcRelConnectsStructuralMember : IfcRelConnects 
	{
		public IfcRelConnectsStructuralMember(IfcStructuralMember relatingStructuralMember,
				IfcStructuralConnection relatedStructuralConnection,
				IfcBoundaryCondition appliedCondition,
				IfcStructuralConnectionCondition additionalConditions,
				IfcAxis2Placement3D conditionCoordinateSystem,
				Double supportedLength,
				Boolean supportedLengthSpecified) : base()
		{
			this.RelatingStructuralMember = relatingStructuralMember;
			this.RelatedStructuralConnection = relatedStructuralConnection;
			this.AppliedCondition = appliedCondition;
			this.AdditionalConditions = additionalConditions;
			this.ConditionCoordinateSystem = conditionCoordinateSystem;
			this.SupportedLength = supportedLength;
			this.SupportedLengthSpecified = supportedLengthSpecified;
		}
	}
}