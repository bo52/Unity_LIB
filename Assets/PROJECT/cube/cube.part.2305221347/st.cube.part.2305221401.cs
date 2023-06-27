//empty
//empty
//empty
using System.Collections.Generic;
using UnityEngine;
namespace LIB.st2305221401
{
    /// <summary>
    /// stCube_buid
    /// cube.part.build
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// MAX
        /// </summary>
        static public byte field230522140100 = 3;
        /// <summary>
        /// empty
        /// </summary>
        static public Color field230522140101 = new Color(0, 0, 0, 0);
        /// <summary>
        /// Файл
        /// </summary>
        static public string field230522140102 => "Assets/Resources/default/empty_3d.asset";
        /// <summary>
        /// Добавить
        /// </summary>
        /// <param name="vs"></param>
        /// <param name="ts"></param>
        /// <param name="ns"></param>
        /// <param name="v"></param>
        static public void fun230522140103(ref List<Vector3> vs, ref List<int> ts, ref List<Vector3> ns, Vector3 v)
        {
            vs.Add(v);
            ts.Add(vs.Count - 1);
            ns.Add(v.normalized);
        }
        /// <summary>
        /// ARR
        /// </summary>
        static public Vector3[] field230522140104 = new Vector3[]
        {
            new Vector3(0,0,0),new Vector3(0,1,0),new Vector3(1,0,0),//4
            new Vector3(1,0,0),new Vector3(0,1,0),new Vector3(1,1,0),//4

            new Vector3(0,0,1),new Vector3(1,0,1),new Vector3(0,1,1),//5
            new Vector3(1,0,1),new Vector3(1,1,1),new Vector3(0,1,1),//5

            new Vector3(0,0,0),new Vector3(0,0,1),new Vector3(0,1,1),
            new Vector3(0,1,0),new Vector3(0,0,0),new Vector3(0,1,1),

            new Vector3(1,1,1),new Vector3(1,0,1),new Vector3(1,0,0),
            new Vector3(1,1,1),new Vector3(1,0,0),new Vector3(1,1,0),

            new Vector3(0,0,0),new Vector3(1,0,0),new Vector3(0,0,1),
            new Vector3(1,0,0),new Vector3(1,0,1),new Vector3(0,0,1),

            new Vector3(0,1,1),new Vector3(1,1,0),new Vector3(0,1,0),
            new Vector3(0,1,1),new Vector3(1,1,1),new Vector3(1,1,0),

        };
        /// <summary>
        /// UV
        /// </summary>
        static private readonly Vector2[] field230522140105 = {
            new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 0),
            new Vector2(0, 1), new Vector2(1, 1), new Vector2(1, 0),

            new Vector2(0, 0), new Vector2(1, 0), new Vector2(0, 1),
            new Vector2(0, 1), new Vector2(1, 0), new Vector2(1, 1),

            new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 0),
            new Vector2(1, 0), new Vector2(1, 1), new Vector2(0, 1),

            new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 0),
            new Vector2(1, 0), new Vector2(1, 1), new Vector2(0, 1),

            new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 0),
            new Vector2(1, 0), new Vector2(1, 1), new Vector2(0, 1),

            new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 0),
            new Vector2(1, 0), new Vector2(1, 1), new Vector2(0, 1),
        };
        /// <summary>
        /// Прямоугольник
        /// </summary>
        /// <param name="vs"></param>
        /// <param name="ts"></param>
        /// <param name="ns"></param>
        /// <param name="uvs"></param>
        /// <param name="v"></param>
        /// <param name="h"></param>
        /// <param name="w"></param>
        /// <param name="s"></param>
        static public void fun230522140106(ref List<Vector3> vs, ref List<int> ts, ref List<Vector3> ns, ref List<Vector2> uvs, Vector3 v, int h, int w, int s)
        {
            var i = 0;
            var delta = 1 / (float)field230522140100;
            foreach (var dv in field230522140104/*Arr*/)
            {
                fun230522140103(ref vs, ref ts, ref ns, delta * (v + Vector3.Scale(dv, h * Vector2.up) + Vector3.Scale(dv, w * Vector2.right) + Vector3.Scale(dv, s * Vector3.forward)));
                uvs.Add(delta * (new Vector2(v.x, v.y) + Vector2.Scale(field230522140105[i], h * Vector2.up) + Vector2.Scale(field230522140105[i], w * Vector2.right)));
                i++;
            }
        }
        /// <summary>
        /// СобратьБыстроМеш
        /// </summary>
        /// <param name="ps"></param>
        /// <returns></returns>
        static public Mesh fun230522140107(this List<cs2305221354.IClass> ps)
        {
            var m = new Mesh();
            List<Vector3> vs = new List<Vector3>();
            List<int> ts = new List<int>();
            List<Vector3> ns = new List<Vector3>();
            List<Vector2> uvs = new List<Vector2>();
            foreach (var part in ps)
                fun230522140106(ref vs, ref ts, ref ns, ref uvs, part.Начало, part.Высота, part.Длинна, part.Ширина);
            m.vertices = vs.ToArray();
            m.triangles = ts.ToArray();
            m.normals = ns.ToArray();
            m.uv = uvs.ToArray();
            return m;
        }
        ///exit
    }
}
