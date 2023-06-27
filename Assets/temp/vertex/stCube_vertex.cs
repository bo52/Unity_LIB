using UnityEngine;
namespace task2022
{
    static public class stCube_vertex
    {
        static public readonly Vector3Int[] ВершиныКуба = new Vector3Int[8]
        {
            Vector3Int.zero,//0
            Vector3Int.right,//1
            Vector3Int.up,//2
            Vector3Int.right + Vector3Int.up,//3
            Vector3Int.forward,//4
            Vector3Int.right + Vector3Int.forward,//5
            Vector3Int.up + Vector3Int.forward,//6
            Vector3Int.right + Vector3Int.up + Vector3Int.forward,//7
        };
    }
}
