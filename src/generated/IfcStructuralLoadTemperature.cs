/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcStructuralLoadTemperature : IfcStructuralLoadStatic 
	{
		public IfcStructuralLoadTemperature(Double deltaTConstant,
				Boolean deltaTConstantSpecified,
				Double deltaTY,
				Boolean deltaTYSpecified,
				Double deltaTZ,
				Boolean deltaTZSpecified,
				String name) : base(name)
		{
			this.DeltaTConstant = deltaTConstant;
			this.DeltaTConstantSpecified = deltaTConstantSpecified;
			this.DeltaTY = deltaTY;
			this.DeltaTYSpecified = deltaTYSpecified;
			this.DeltaTZ = deltaTZ;
			this.DeltaTZSpecified = deltaTZSpecified;
		}
	}
}