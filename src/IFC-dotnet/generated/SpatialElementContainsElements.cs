/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcspatialelementcontainselements.htm
	/// </summary>
	internal  partial class SpatialElementContainsElements 
	{
		public RelContainedInSpatialStructure[] IfcRelContainedInSpatialStructure {get;set;}

		public String[] itemType {get;set;}

		public aggregateType[] cType {get;set;}

		public String[] arraySize {get;set;}

		public SpatialElementContainsElements(RelContainedInSpatialStructure[] ifcRelContainedInSpatialStructure,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize)
		{
			this.IfcRelContainedInSpatialStructure = ifcRelContainedInSpatialStructure;
			this.itemType = itemType;
			this.cType = cType;
			this.arraySize = arraySize;
		}
	}
}