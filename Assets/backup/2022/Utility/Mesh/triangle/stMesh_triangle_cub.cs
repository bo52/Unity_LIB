//Bo52_10102020132151712.TEST.MESHES.
namespace utility2022
{
    using UnityEngine;
    using System.Collections.Generic;
    using Utility2023;

    /// <summary>
    /// Куб
    /// Работа с Мешем (Куб)
    /// </summary>
    static public class stMesh_triangle_cub
    {
        static private readonly Vector3[,] МассивДляКуба = new Vector3[,]
        {
            {Vector3.right,Vector3.zero,Vector3.right + Vector3.up },
            {Vector3.zero,Vector3.up,Vector3.right + Vector3.up },
            
            {Vector3.forward,Vector3.forward + Vector3.right,Vector3.forward + Vector3.right + Vector3.up },
            {Vector3.forward + Vector3.up,Vector3.forward,Vector3.forward + Vector3.right + Vector3.up },

            {Vector3.zero,Vector3.forward,Vector3.forward + Vector3.up },
            {Vector3.up,Vector3.zero,Vector3.forward + Vector3.up },
            
            {Vector3.right + Vector3.forward,Vector3.right,Vector3.right + Vector3.forward + Vector3.up },
            {Vector3.right,Vector3.right + Vector3.up,Vector3.right + Vector3.forward + Vector3.up },

            {Vector3.up+Vector3.right,Vector3.up,Vector3.forward + Vector3.up+Vector3.right},
            {Vector3.up,Vector3.up+Vector3.forward,Vector3.forward + Vector3.up+Vector3.right},

            {Vector3.zero,Vector3.right,Vector3.forward + Vector3.right},
            {Vector3.forward,Vector3.zero,Vector3.forward +Vector3.right},
        };
        static public Mesh СобратьКубМеш(Vector3 v0, float N)
        {
            var n = Mathf.Pow(3,N);
            List<Mesh> ms = new List<Mesh>();
            for (var i = 0; i < 12; i++)
            {
                stMesh_triangle.СобратьТреугольныйМеш(new Vector3[] { v0 + n * МассивДляКуба[i, 0], v0 + n * МассивДляКуба[i, 1], v0 + n * МассивДляКуба[i, 2] });
            }
            return stMesh_combine.СоединитьМеши(ms);
        }
    }
}
