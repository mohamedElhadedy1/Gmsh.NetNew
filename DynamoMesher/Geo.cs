using Autodesk.DesignScript.Geometry;
using Autodesk.DesignScript.Runtime;
using GmshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static GmshNet.Gmsh.Model;

namespace DynamoMesher
{
    using geo = Gmsh.Model.Geo;

    [IsVisibleInDynamoLibrary(false)]
    public class Geo
    {



        [IsVisibleInDynamoLibrary(false)]

        public void Initialize()
        {
            Gmsh.Initialize();
            Gmsh.Option.SetNumber("General.Terminal", 1);
            Gmsh.Model.Add("t1");
        }
         

        [IsVisibleInDynamoLibrary(true)]
        public int GmshPoint(Point point, double meshsize = 0, int tag = -1)
        {
            Initialize();
    
            var fsd = geo.AddPoint(point.X, point.Y, point.Y, meshsize, tag);

            return fsd;
        }

    }
}
