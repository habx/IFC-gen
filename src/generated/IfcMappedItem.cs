/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcMappedItem : IfcRepresentationItem 
	{
		public IfcMappedItem(IfcRepresentationMap mappingSource,
				IfcCartesianTransformationOperator mappingTarget,
				IfcStyledItem styledByItem) : base(styledByItem)
		{
			this.MappingSource = mappingSource;
			this.MappingTarget = mappingTarget;
		}
	}
}