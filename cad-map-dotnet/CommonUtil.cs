using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using System.Data;
using Autodesk.AutoCAD.Geometry;

namespace cad_map_dotnet
{
    public static class CommonUtil
    {
        // Get all vertices of a Polyline object and return as comma separated values
        public static string GetPolyLineCoordinates(Polyline pl)
        {
            var vCount = pl.NumberOfVertices;
            Point2d coord;
            string coords = "";
            int i;
            for (i = 0; i <= vCount - 1; i++)
            {
                coord = pl.GetPoint2dAt(i);
                coords += coord[0].ToString() + "," + coord[1].ToString();
                if ((i < vCount - 1))
                    coords += ",";
            }
            return coords;
        }
    }
}
