//empty
//empty
//Vertices (stMesh.build.vertices)
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2305141209
{
    /// <summary>
    /// stMesh.build.vertices.cs2305141209
    /// </summary>
    public interface IClass : cs2305141215.IClass
    {
        void ADD(cs2306301359.Class Triangle);
    }
    public class Class : cs2305141215.Class, IClass
    {
        cs2305141202.IClass ВершиныТреугольника;
        public Class(cs2307031203_ПараметрыПостройки.Class param) : base(param)
        {
            ВершиныТреугольника = new cs2305141202.Class(this);
        }
        public void ADD(cs2306301359.Class Triangle)
        {
            ВершиныТреугольника.v1 = Triangle.v1;
            ВершиныТреугольника.v2 = Triangle.v2;
            ВершиныТреугольника.v3 = Triangle.v3;
            ВершиныТреугольника.ДобавитьТреугольник();
        }
    }
}
