/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcStructuralAnalysisModelHasResults : Object 
	{
		public IfcStructuralAnalysisModelHasResults(IfcStructuralResultGroup[] ifcStructuralResultGroup,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize) : base()
		{
			this.IfcStructuralResultGroup = ifcStructuralResultGroup;
			this.itemType = itemType;
			this.cType = cType;
			this.arraySize = arraySize;
		}
	}
}