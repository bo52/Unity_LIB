//empty
//IBlock8_vs
//empty
using UnityEngine;
namespace LIB.st2305151543
{
    /// <summary>
    /// 
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// ВершиныОтносительноКоординатыБлока
        /// 8 вершин как куб. Vector3.zero = new Vector3(-1,-1,-1)
        /// </summary>
        static public readonly Vector3[] field230515154300_ВекторОтЦентраКубаПоНомеруВершины = new Vector3[]
        {
            Vector3.zero,//0
            Vector3.right,//1
            Vector3.up,//2
            Vector3.right+Vector3.up,//3
            Vector3.forward,//4
            Vector3.right+Vector3.forward,//5
            Vector3.up+Vector3.forward,//6
            Vector3.right+Vector3.up+Vector3.forward,//7
        };
        /// <summary>
        /// ВершиныОтносительноКоординатыБлока int
        /// </summary>
        static public readonly Vector3Int[] field230515154301 =
        {
            Vector3Int.zero,//0
            Vector3Int.left,//1
            Vector3Int.down,//2
            Vector3Int.down+Vector3Int.left,//3
            Vector3Int.back,//4
            Vector3Int.left+Vector3Int.back,//5
            Vector3Int.down+Vector3Int.back,//6
            Vector3Int.left+Vector3Int.down+Vector3Int.back,//7
        };
        /// <summary>
        /// ВекторПоЦентруКуба
        /// </summary>
        /// <param name="ИндексВершины"></param>
        /// <returns></returns>
        static public Vector3 fun230515154302_ВекторВершиныПоЦентруКуба(byte ИндексВершины)
        {
            return field230515154300_ВекторОтЦентраКубаПоНомеруВершины[ИндексВершины] - 0.5f * Vector3.one;
        }
        ///exit
    }
}