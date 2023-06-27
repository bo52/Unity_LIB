using UnityEngine;
namespace mathf2022
{
    static public class stMathf_Cube8_vertex
    {
        static public readonly Vector3Int[] ВершиныКуба =
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