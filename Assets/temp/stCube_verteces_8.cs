using UnityEngine;
namespace cube2023
{
    public static class stCube_verteces_8
    {
        /// 8 вершин как куб. Vector3.zero = new Vector3(-1,-1,-1)
        public static readonly Vector3[] ВершиныОтносительноКоординатыБлока = new Vector3[]
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
        public static readonly Vector3Int[] ВершиныОтносительноКоординатыБлока_int =
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
    }
}