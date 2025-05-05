using Autodesk.DesignScript.Runtime;
using GmshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GmshNet.Gmsh.Model;

namespace DynamoMesher
{
    using geo = Gmsh.Model.Geo;
    [IsVisibleInDynamoLibrary(false)]
    public class HelperGeometry
    {
        [IsVisibleInDynamoLibrary(false)]
       public class GmshPoint
        {
            //public Autodesk.DesignScript.Geometry.Point _point;
            //public double _meshsize;
            //public int _tag;
            //public GmshPoint(Autodesk.DesignScript.Geometry.Point point, double meshsize = 0, int tag = -1)
            //{
            //    _point = point;
            //    _meshsize = meshsize;
            //    _tag = tag;

            //}
  
       }

        [IsVisibleInDynamoLibrary(false)]

        public void ToGmsh(Autodesk.DesignScript.Geometry.Point point, double meshsize = 0, int tag = -1)
        {

            geo.AddPoint(point.X, point.Y, point.Y, meshsize, tag);

        }



        //public static Autodesk.DesignScript.Geometry.Point ToAutodesk()
        //{
        //    Autodesk.DesignScript.Geometry.Point point =null;

        //    return point;
        //}
        //public static void ToGmsh(this Autodesk.DesignScript.Geometry.Point point, double meshsize = 0, int tag = -1)
        //{
        //    geo.AddPoint(point.X, point.Y, point.Y, meshsize, tag);

        //}



    }

}
