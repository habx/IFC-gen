/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSchedulingTime : Entity 
	{
		public IfcSchedulingTime(String name,
				IfcDataOriginEnum dataOrigin,
				Boolean dataOriginSpecified,
				String userDefinedDataOrigin) : base()
		{
			this.Name = name;
			this.DataOrigin = dataOrigin;
			this.DataOriginSpecified = dataOriginSpecified;
			this.UserDefinedDataOrigin = userDefinedDataOrigin;
		}
	}
}