/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSectionReinforcementProperties : IfcPreDefinedProperties 
	{
		public IfcSectionReinforcementProperties(IfcSectionProperties sectionDefinition,
				IfcSectionReinforcementPropertiesCrossSectionReinforcementDefinitions crossSectionReinforcementDefinitions,
				Double longitudinalStartPosition,
				Boolean longitudinalStartPositionSpecified,
				Double longitudinalEndPosition,
				Boolean longitudinalEndPositionSpecified,
				Double transversePosition,
				Boolean transversePositionSpecified,
				IfcReinforcingBarRoleEnum reinforcementRole,
				Boolean reinforcementRoleSpecified) : base()
		{
			this.SectionDefinition = sectionDefinition;
			this.CrossSectionReinforcementDefinitions = crossSectionReinforcementDefinitions;
			this.LongitudinalStartPosition = longitudinalStartPosition;
			this.LongitudinalStartPositionSpecified = longitudinalStartPositionSpecified;
			this.LongitudinalEndPosition = longitudinalEndPosition;
			this.LongitudinalEndPositionSpecified = longitudinalEndPositionSpecified;
			this.TransversePosition = transversePosition;
			this.TransversePositionSpecified = transversePositionSpecified;
			this.ReinforcementRole = reinforcementRole;
			this.ReinforcementRoleSpecified = reinforcementRoleSpecified;
		}
	}
}