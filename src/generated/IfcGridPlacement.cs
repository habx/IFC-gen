/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcGridPlacement : IfcObjectPlacement 
	{
		public IfcGridPlacement(IfcVirtualGridIntersection placementLocation,
				IfcGridPlacementPlacementRefDirection placementRefDirection) : base()
		{
			this.PlacementLocation = placementLocation;
			this.PlacementRefDirection = placementRefDirection;
		}
	}
}