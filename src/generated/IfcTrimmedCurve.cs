/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcTrimmedCurve : IfcBoundedCurve 
	{
		public IfcTrimmedCurve(IfcCurve basisCurve,
				IfcTrimmedCurveTrim1 trim1,
				IfcTrimmedCurveTrim2 trim2,
				Boolean senseAgreement,
				Boolean senseAgreementSpecified,
				IfcTrimmingPreference masterRepresentation,
				Boolean masterRepresentationSpecified,
				IfcStyledItem styledByItem) : base(styledByItem)
		{
			this.BasisCurve = basisCurve;
			this.Trim1 = trim1;
			this.Trim2 = trim2;
			this.SenseAgreement = senseAgreement;
			this.SenseAgreementSpecified = senseAgreementSpecified;
			this.MasterRepresentation = masterRepresentation;
			this.MasterRepresentationSpecified = masterRepresentationSpecified;
		}
	}
}