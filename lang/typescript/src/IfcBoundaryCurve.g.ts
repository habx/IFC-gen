
import {BaseIfc} from "./BaseIfc"
import {IfcPresentationLayerAssignment} from "./IfcPresentationLayerAssignment.g"
import {IfcStyledItem} from "./IfcStyledItem.g"
import {IfcDimensionCount} from "./IfcDimensionCount.g"
import {IfcCompositeCurveSegment} from "./IfcCompositeCurveSegment.g"
import {IfcLogical} from "./IfcLogical.g"
import {IfcInteger} from "./IfcInteger.g"
import {IfcSurface} from "./IfcSurface.g"
import {IfcCompositeCurveOnSurface} from "./IfcCompositeCurveOnSurface.g"

/**
 * http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboundarycurve.htm
 */
export class IfcBoundaryCurve extends IfcCompositeCurveOnSurface {

    constructor(segments : Array<IfcCompositeCurveSegment>, selfIntersect : IfcLogical) {
        super(segments,selfIntersect)
    }
    getStepParameters() : string {
        var parameters = new Array<string>();
		parameters.push(BaseIfc.toStepValue(this.Segments))
		parameters.push(BaseIfc.toStepValue(this.SelfIntersect))

        return parameters.join();
    }
}