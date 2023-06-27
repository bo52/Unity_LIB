//Bo52_1003202195706985.FUN.EXISTS.
namespace task2022
{
    using mathf2022;
    using System.Collections.Generic;
    using UnityEngine;
    /// <summary>
    /// по мешу определить существование нулевой вершины блока вектора
    /// </summary>
    static public class stCube256_mesh_vertex0_exist
    {
        static public string INFO = "MESH.BLOCK";
        static public string PRODUCT = "n-вершина блока меша существеут";
        static public bool FIXED = false;

        static public bool ВертексПринадлежитБлокуПоВектору(this Vector3 ВекторБлока,Vector2 item, Vector2[] uv3,int index)=>(item.x == ВекторБлока.x && item.y == ВекторБлока.y && uv3[index].x == ВекторБлока.z);
        static public strCube256_info НулеваяВершинаБлокаСуществует(this Vector3 v0, List<Vector2> uv2, Vector2[] uv3)
        {
            byte НомерВершины = 0;
            foreach (var dv in stMathf_Cube8_vertex.ВершиныКуба)
            {
                Vector3 ВекторБлока = v0 + dv;
                //Найти Вектор Блока
                var indexer = 0;
                foreach (var item in uv2)
                {
                    if (ВекторБлока.ВертексПринадлежитБлокуПоВектору(item, uv3, indexer))
                    {
                        return new strCube256_info(true,НомерВершины, v0, ВекторБлока, (byte)uv3[indexer].y);
                    }
                    indexer++;
                }

                НомерВершины++;
            }
            return new strCube256_info(false, 0, v0, v0, 0);
        }

        
    }
}
