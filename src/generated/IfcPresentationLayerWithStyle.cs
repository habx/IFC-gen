/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcPresentationLayerWithStyle : IfcPresentationLayerAssignment 
	{
		public IfcPresentationLayerWithStyle(IfcPresentationLayerWithStyleLayerStyles layerStyles,
				IfcLogical layerOn,
				Boolean layerOnSpecified,
				IfcLogical layerFrozen,
				Boolean layerFrozenSpecified,
				IfcLogical layerBlocked,
				Boolean layerBlockedSpecified,
				IfcPresentationLayerAssignmentAssignedItems assignedItems,
				String name,
				String description,
				String identifier) : base(assignedItems,
				name,
				description,
				identifier)
		{
			this.LayerStyles = layerStyles;
			this.LayerOn = layerOn;
			this.LayerOnSpecified = layerOnSpecified;
			this.LayerFrozen = layerFrozen;
			this.LayerFrozenSpecified = layerFrozenSpecified;
			this.LayerBlocked = layerBlocked;
			this.LayerBlockedSpecified = layerBlockedSpecified;
		}
	}
}