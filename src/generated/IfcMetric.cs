/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcMetric : IfcConstraint 
	{
		public IfcMetric(IfcMetricDataValue dataValue,
				IfcReference referencePath,
				IfcBenchmarkEnum benchmark,
				Boolean benchmarkSpecified,
				String valueSource,
				IfcConstraintCreatingActor creatingActor,
				String name,
				String description,
				IfcConstraintEnum constraintGrade,
				Boolean constraintGradeSpecified,
				String constraintSource,
				String creationTime,
				String userDefinedGrade) : base(creatingActor,
				name,
				description,
				constraintGrade,
				constraintGradeSpecified,
				constraintSource,
				creationTime,
				userDefinedGrade)
		{
			this.DataValue = dataValue;
			this.ReferencePath = referencePath;
			this.Benchmark = benchmark;
			this.BenchmarkSpecified = benchmarkSpecified;
			this.ValueSource = valueSource;
		}
	}
}