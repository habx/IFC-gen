/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcPropertySetDefinitionSetwrapper : IfcPropertySetDefinitionSet 
	{
		public IfcPropertySetDefinitionSetwrapper(String id,
				String path,
				String[] pos,
				IfcPropertySet[] items,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize) : base(items,
				itemType,
				cType,
				arraySize)
		{
			this.id = id;
			this.path = path;
			this.pos = pos;
		}
	}
}