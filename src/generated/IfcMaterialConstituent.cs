/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcMaterialConstituent : IfcMaterialDefinition 
	{
		public IfcMaterialConstituent(IfcMaterial material,
				String name,
				String description,
				Double fraction,
				Boolean fractionSpecified,
				String category,
				IfcMaterialDefinitionHasProperties hasProperties) : base(hasProperties)
		{
			this.Material = material;
			this.Name = name;
			this.Description = description;
			this.Fraction = fraction;
			this.FractionSpecified = fractionSpecified;
			this.Category = category;
		}
	}
}