/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSectionReinforcementPropertiesCrossSectionReinforcementDefinitions : Object 
	{
		public IfcSectionReinforcementPropertiesCrossSectionReinforcementDefinitions(IfcReinforcementBarProperties[] ifcReinforcementBarProperties,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize) : base()
		{
			this.IfcReinforcementBarProperties = ifcReinforcementBarProperties;
			this.itemType = itemType;
			this.cType = cType;
			this.arraySize = arraySize;
		}
	}
}