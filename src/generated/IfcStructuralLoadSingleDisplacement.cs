/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcStructuralLoadSingleDisplacement : IfcStructuralLoadStatic 
	{
		public IfcStructuralLoadSingleDisplacement(Double displacementX,
				Boolean displacementXSpecified,
				Double displacementY,
				Boolean displacementYSpecified,
				Double displacementZ,
				Boolean displacementZSpecified,
				Double rotationalDisplacementRX,
				Boolean rotationalDisplacementRXSpecified,
				Double rotationalDisplacementRY,
				Boolean rotationalDisplacementRYSpecified,
				Double rotationalDisplacementRZ,
				Boolean rotationalDisplacementRZSpecified,
				String name) : base(name)
		{
			this.DisplacementX = displacementX;
			this.DisplacementXSpecified = displacementXSpecified;
			this.DisplacementY = displacementY;
			this.DisplacementYSpecified = displacementYSpecified;
			this.DisplacementZ = displacementZ;
			this.DisplacementZSpecified = displacementZSpecified;
			this.RotationalDisplacementRX = rotationalDisplacementRX;
			this.RotationalDisplacementRXSpecified = rotationalDisplacementRXSpecified;
			this.RotationalDisplacementRY = rotationalDisplacementRY;
			this.RotationalDisplacementRYSpecified = rotationalDisplacementRYSpecified;
			this.RotationalDisplacementRZ = rotationalDisplacementRZ;
			this.RotationalDisplacementRZSpecified = rotationalDisplacementRZSpecified;
		}
	}
}