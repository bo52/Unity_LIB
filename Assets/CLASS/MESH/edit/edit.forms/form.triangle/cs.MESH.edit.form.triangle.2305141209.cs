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
    public interface IClass
    {

    }
    public class Class: cs2305141215.Class
    {
        public struct ВершиныТреугольника
        {
            public Vector3 v1;
            public Vector3 v2;
            public Vector3 v3;
            public ВершиныТреугольника(Vector3 v1, Vector3 v2, Vector3 v3)
            {
                this.v1 = v1;
                this.v2 = v2;
                this.v3 = v3;
            }
        }
        public void ДобавитьТреугольник(ВершиныТреугольника vs)
        {
                ДобавитьВершину(vs.v1);
                ДобавитьВершину(vs.v2);
                ДобавитьВершину(vs.v3);
        }
    }
}
