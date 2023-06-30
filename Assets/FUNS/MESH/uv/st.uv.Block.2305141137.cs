//empty
//empty
//empty
using System.Collections.Generic;
using UnityEngine;
namespace LIB.st2305141137
{
    /// <summary>
    /// stMesh.cube.uv.cs2305141137
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// Arr
        /// </summary>
        public static readonly Vector2[] field230514113700_first_square = new Vector2[]
        {
            Vector2.zero,//0
            Vector2.right,//1
            Vector2.up,//2
            Vector2.right+Vector2.up,//3
        };
        /// <summary>
        /// faces
        /// </summary>
        public static readonly Dictionary<byte, byte>[] field230514113701_face_square = new Dictionary<byte, byte>[]
        {
            new Dictionary<byte,byte>(){{0,0},{2,2},{4,1},{6,3}},//0
            new Dictionary<byte,byte>(){{1,0},{3,2},{5,1},{7,3},},//1
            new Dictionary<byte,byte>(){{0,0},{1,1},{4,2},{5,3},},//2
            new Dictionary<byte,byte>(){{2,0},{3,1},{6,2},{7,3},},//3
            new Dictionary<byte,byte>(){{0,0},{1,1},{2,2},{3,3},},//4
            new Dictionary<byte,byte>(){{4,0},{5,1},{6,2},{7,3},},//5
        };
        /// <summary>
        /// Вектор
        /// </summary>
        /// <param name="f"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Vector2 fun230514113702(this byte f, byte i)
        {
            return field230514113700_first_square[field230514113701_face_square[f][i]];
        }
        ///exit
    }
}