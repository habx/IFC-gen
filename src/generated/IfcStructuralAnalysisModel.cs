/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcStructuralAnalysisModel : IfcSystem 
	{
		public IfcStructuralAnalysisModel(IfcAxis2Placement3D orientationOf2DPlane,
				IfcStructuralAnalysisModelLoadedBy loadedBy,
				IfcStructuralAnalysisModelHasResults hasResults,
				IfcObjectPlacement sharedPlacement,
				IfcAnalysisModelTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				IfcRelDefinesByObject isDeclaredBy,
				IfcRelDefinesByType isTypedBy,
				IfcObjectIsDefinedBy isDefinedBy,
				String objectType,
				IfcObjectDefinitionIsNestedBy isNestedBy,
				IfcObjectDefinitionIsDecomposedBy isDecomposedBy) : base(isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.OrientationOf2DPlane = orientationOf2DPlane;
			this.LoadedBy = loadedBy;
			this.HasResults = hasResults;
			this.SharedPlacement = sharedPlacement;
			this.PredefinedType = predefinedType;
			this.PredefinedTypeSpecified = predefinedTypeSpecified;
		}
	}
}