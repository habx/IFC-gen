/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcBlobTexture : IfcSurfaceTexture 
	{
		public IfcBlobTexture(IfcBinary rasterCode,
				String rasterFormat,
				IfcCartesianTransformationOperator2D textureTransform,
				Boolean repeatS,
				Boolean repeatSSpecified,
				Boolean repeatT,
				Boolean repeatTSpecified,
				String mode,
				String[] parameter) : base(textureTransform,
				repeatS,
				repeatSSpecified,
				repeatT,
				repeatTSpecified,
				mode,
				parameter)
		{
			this.RasterCode = rasterCode;
			this.RasterFormat = rasterFormat;
		}
	}
}