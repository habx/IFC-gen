/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcGeometricSet : IfcGeometricRepresentationItem 
	{
		public IfcGeometricSet(IfcGeometricSetElements elements,
				IfcStyledItem styledByItem) : base(styledByItem)
		{
			this.Elements = elements;
		}
	}
}