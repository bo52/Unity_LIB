//empty
//empty
//соединить меши Bo52_31122020214713583.STAT.MESHES.
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// stMesh.combine.cs2305072045
/// </summary>
namespace LIB.st2305072045
{
    /// <summary>
    /// Соединение
    /// cоединение МЕШЕЙ
    /// stMesh.combine.cs2305072045
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// ПересчётМеш
        /// </summary>
        /// <param name="m"></param>
        static public void fun230507204500(this Mesh m)
        {
            m.RecalculateBounds();
            m.RecalculateNormals();
        }
        /// <summary>
        /// ToMesh
        /// </summary>
        /// <param name="combine"></param>
        /// <returns></returns>
        static public Mesh fun230507204501(this CombineInstance[] combine)
        {
            var mesh = new Mesh();
            mesh.CombineMeshes(combine, true, false);

            fun230507204500(mesh);
            return mesh;
        }
        /// <summary>
        /// ToMesh
        /// </summary>
        /// <param name="ms"></param>
        /// <returns></returns>
        static public Mesh fun230507204502(List<Mesh> ms)
        {
            Mesh M = null;
            if (ms.Count != 0)
            {
                if (ms.Count == 1)
                    M = ms[0];
                else
                {
                    var combine = new CombineInstance[ms.Count];
                    var cnt = 0;
                    foreach (var m in ms)
                    {
                        combine[cnt].mesh = m;
                        cnt++;
                    }
                    M = fun230507204501(combine);
                }
            }
            return M;
        }
        /// <summary>
        /// СоединитьМеши
        /// </summary>
        /// <param name="ms"></param>
        /// <returns></returns>
        static public Mesh fun230507204503(this List<Mesh> ms)
        {
            var combine = new CombineInstance[ms.Count];
            var cnt = 0;
            //По одинаковому цвету собрать треугольники
            foreach (var m in ms)
            {
                combine[cnt].mesh = m;
                cnt++;
            }
            return fun230507204501(combine);
        }
        ///exit
    }
}
