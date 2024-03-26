using System;
namespace WineApp
{
    public class SoilDictionary
    {
        Dictionary<string, string> soilDataDictionary =
            new Dictionary<string, string>()
            {
                {"TXT-SRF-DOM","Dominant surface textural class of the STU"},
                {"WRB-FULL","Full soil code of the STU from the World Reference Base (WRB) for Soil Resources"},
                {"SLOPE-SEC","Secondary slope class of the STU"},
                {"PAR-MAT-SEC3","Major group code for the secondary parent material of the STU"},
                {"PAR-MAT-SEC2","Second level code for the secondary parent material of the STU"},
                {"PAR-MAT-SEC1","Third level code for the secondary parent material of the STU"},
                {"PAR-MAT-DOM3","Major group code for the dominant parent material of the STU"},
                {"PAR-MAT-DOM2","Second level code for the dominant parent material of the STU"},
                {"PAR-MAT-DOM1","Third level code for the dominant parent material of the STU"},
                {"FAO85-LEV3","Third level soil code of the STU from the FAO-UNESCO Soil Legend"},
                {"FAO85-LEV2","Second level soil code of the STU from the FAO-UNESCO Soil Legend"},
                {"FAO85-LEV1","Soil major group code of the STU from the FAO-UNESCO Soil Legend"},
                {"WR","Dominant annual average soil water regime class of the soil profile of the STU"},
                {"IL","Code for the presence of an impermeable layer within the soil profile of the STU"},
                {"ROO","Depth class of an obstacle to roots within the STU"},
                {"TEXT-SUB-SEC","Secondary sub-surface textural class of the STU"},
                {"TEXT-SUB-DOM","Dominant sub-surface textural class of the STU"},
                {"TEXT-SRF-SEC","Secondary surface textural class of the STU"},
                {"AGLIM2","Code of a secondary limitation to agricultural use of the STU"},
                {"AGLIM1","Code of the most important limitation to agricultural use of the STU"},
                {"PAR-MAT-SEC","Code for secondary parent material of the STU"},
                {"PAR-MAT-DOM","Code for dominant parent material of the STU"},
                {"ZMAX","Maximum elevation above sea level of the STU (in metres)"},
                {"ZMIN","Minimum elevation above sea level of the STU (in metres)"},
                {"SLOPE-DOM","Dominant slope class of the STU"},
                {"FAO85-FULL","Full soil code of the STU from the FAO-UNESCO Soil Legend"},
                {"EAWC_SUB","Subsoil easily available water capacity"},
                {"AWC_SUB","Subsoil available water capacity"},
                {"EAWC_TOP","Topsoil easily available water capacity"},
                {"AWC_TOP","Topsoil available water capacity"},
                {"PD_SUB","Subsoil packing density"},
                {"PD_TOP","Topsoil packing density"},
                {"STR_SUB","Subsoil structure"},
                {"STR_TOP","Topsoil structure"},
                {"TD","Rule infered subsoil texture"},
                {"VS","Volume of stones"},
                {"DR","Depth to rock"},
                {"BS_SUB","Base saturation of the subsoil"},
                {"BS_TOP","Base saturation of the topsoil"},
                {"CEC_SUB","Subsoil cation exchange capacity"},
                {"CEC_TOP","Topsoil cation exchange capacity"},
                {"MIN_SUB","Subsoil mineralogy"},
                {"MIN_TOP","Topsoil mineralogy"},
                {"DIMP","Depth to an impermeable layer"},
                {"DGH","Depth to a gleyed horizon"},
                {"OC_TOP","Topsoil organic carbon content"},
                {"ALT","ELEVATION"},
                {"TEXT","Dominant surface textural class (completed from dominant STU)"},
            };
    }
}

