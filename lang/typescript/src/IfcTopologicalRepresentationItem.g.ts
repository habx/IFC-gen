
import {BaseIfc} from "./BaseIfc"
import {IfcPresentationLayerAssignment} from "./IfcPresentationLayerAssignment.g"
import {IfcStyledItem} from "./IfcStyledItem.g"
import {IfcRepresentationItem} from "./IfcRepresentationItem.g"

/**
 * http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctopologicalrepresentationitem.htm
 */
export abstract class IfcTopologicalRepresentationItem extends IfcRepresentationItem {

    constructor() {
        super()
    }
}