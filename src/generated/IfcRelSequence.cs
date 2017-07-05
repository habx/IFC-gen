/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcRelSequence : IfcRelConnects 
	{
		public IfcRelSequence(IfcProcess relatingProcess,
				IfcProcess relatedProcess,
				IfcLagTime timeLag,
				IfcSequenceEnum sequenceType,
				Boolean sequenceTypeSpecified,
				String userDefinedSequenceType) : base()
		{
			this.RelatingProcess = relatingProcess;
			this.RelatedProcess = relatedProcess;
			this.TimeLag = timeLag;
			this.SequenceType = sequenceType;
			this.SequenceTypeSpecified = sequenceTypeSpecified;
			this.UserDefinedSequenceType = userDefinedSequenceType;
		}
	}
}