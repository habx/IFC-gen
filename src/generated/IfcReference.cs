/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcReference : Entity 
	{
		public IfcReference(IfcReference innerReference,
				String typeIdentifier,
				String attributeIdentifier,
				String instanceName,
				Int64[] listPositions) : base()
		{
			this.InnerReference = innerReference;
			this.TypeIdentifier = typeIdentifier;
			this.AttributeIdentifier = attributeIdentifier;
			this.InstanceName = instanceName;
			this.ListPositions = listPositions;
		}
	}
}