/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcIndexedPolygonalFace : IfcTessellatedItem 
	{
		public IfcIndexedPolygonalFace(Int64[] coordIndex,
				IfcStyledItem styledByItem) : base(styledByItem)
		{
			this.CoordIndex = coordIndex;
		}
	}
}