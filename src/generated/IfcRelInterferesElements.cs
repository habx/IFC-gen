/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcRelInterferesElements : IfcRelConnects 
	{
		public IfcRelInterferesElements(IfcElement relatingElement,
				IfcElement relatedElement,
				IfcConnectionGeometry interferenceGeometry,
				String interferenceType,
				IfcLogical impliedOrder,
				Boolean impliedOrderSpecified) : base()
		{
			this.RelatingElement = relatingElement;
			this.RelatedElement = relatedElement;
			this.InterferenceGeometry = interferenceGeometry;
			this.InterferenceType = interferenceType;
			this.ImpliedOrder = impliedOrder;
			this.ImpliedOrderSpecified = impliedOrderSpecified;
		}
	}
}