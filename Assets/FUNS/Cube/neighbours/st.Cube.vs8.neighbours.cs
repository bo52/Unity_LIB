//empty
//empty
//обновить вершины соседей куба
using UnityEngine;
using System.Collections.Generic;
namespace LIB.st2305221228
{
    /// <summary>
    /// stCube_neighbours
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// Соседи_путь
        /// </summary>
        static public readonly Vector3[][] field230522122800 =
        {
            new Vector3[]//0
            {
                Vector3.back,
                Vector3.down,
                Vector3.left,

                Vector3.left+Vector3.back,
                Vector3.left+Vector3.down,
                Vector3.left+Vector3.back+Vector3.down,
                Vector3.back+Vector3.down,
            },
            new Vector3[]//1
            {
                Vector3.back,
                Vector3.down,
                Vector3.right,

                Vector3.right+Vector3.back,
                Vector3.right+Vector3.down,
                Vector3.right+Vector3.back+Vector3.down,
                Vector3.back+Vector3.down,
            },
            new Vector3[]//2
            {
                Vector3.back,
                Vector3.up,
                Vector3.left,

                Vector3.left+Vector3.back,
                Vector3.left+Vector3.up,
                Vector3.left+Vector3.back+Vector3.up,
                Vector3.back+Vector3.up,
            },
            new Vector3[]//3
            {
                Vector3.back,
                Vector3.up,
                Vector3.right,

                Vector3.right+Vector3.back,
                Vector3.right+Vector3.up,
                Vector3.right+Vector3.back+Vector3.up,
                Vector3.back+Vector3.up,

            },
            new Vector3[]//4
            {
                Vector3.forward,//3
                Vector3.down,//5
                Vector3.left,//0

                Vector3.left+Vector3.forward,//2
                Vector3.left+Vector3.down,//-1
                Vector3.left+Vector3.forward+Vector3.down,//1
                Vector3.forward+Vector3.down,//4 
            },
            new Vector3[]//5
            {
                Vector3.forward,//3 
                Vector3.down,//5
                Vector3.right,//0

                Vector3.right+Vector3.forward,//2
                Vector3.right+Vector3.down,//-1
                Vector3.right+Vector3.forward+Vector3.down,//1
                Vector3.forward+Vector3.down,//4
            },
            new Vector3[]//6
            {
                Vector3.forward,//5
                Vector3.up,//4
                Vector3.left,//2

                Vector3.left+Vector3.forward,//0
                Vector3.left+Vector3.up,//-1
                Vector3.left+Vector3.forward+Vector3.up,//1
                Vector3.forward+Vector3.up,//3 
            },
            new Vector3[]//7
            {
                Vector3.forward,//5
                Vector3.up,//4
                Vector3.right,//2

                Vector3.right+Vector3.forward,
                Vector3.right+Vector3.up,
                Vector3.right+Vector3.forward+Vector3.up,
                Vector3.forward+Vector3.up,
            },
        };
        /// <summary>
        /// Соседи_номер_вершины
        /// </summary>
        static public readonly byte[][] field230522122801 =
        {
            new byte[]{4,2,1,5,3,7,6},//0
            new byte[]{5,3,0,4,2,6,7},//1
            new byte[]{6,0,3,7,1,5,4},//2
            new byte[]{7,1,2,6,0,4,5},//3
            new byte[]{0,6,5,1,7,3,2},//4   
            new byte[]{1,7,4,0,6,2,3},//5
            new byte[]{2,4,7,3,5,1,0},//6
            new byte[]{3,5,6,2,4,0,1},//7
        };
        /// <summary>
        /// ОбновитьСоседейПоКоординатеБлока
        /// </summary>
        /// <param name="Блок"></param>
        static public void fun230522122802(this cs2305221237.IClass Блок)
        {
            var bs = new List<ulong>();
            //нужно узнать индекс вершины куба из кода
            var i = 0;
            foreach (var сосед_путь in field230522122800[0])
            {
                var v = Блок.Координата.v + сосед_путь;
                var id = st2305211702.CLASS.fun230521170203(v);
                var B = Блок.Карта.ContainsKey(id) ? Блок.Карта[id] : new cs2305221237.Class(v, id, Блок.Карта);

                var b = B.Код + Mathf.Pow(2, field230522122801[0][i]) * (Блок.существует ? 1 : -1);
                B.Код = (byte)(b < 0 ? 0 : b);

                if (B.Код == 0)
                    bs.Add(id);
            }
            var map = Блок.Карта;
            foreach (var b in bs)
                map.Remove(b);
            if (Блок.Код == 0)
                map.Remove(Блок.Координата.ид);
        }
        ///exit
    }
}