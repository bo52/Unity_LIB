//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306252134
{
    /// <summary>
    /// высота в цвет и обратно в диапозоне
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// 
        /// </summary>
        static public uint field230625213405_Max = 65533;
        /// <summary>
        /// 
        /// </summary>
        static public int field230625213402_Zero = 32767;
        /// <summary>
        /// нулевой вектор
        /// </summary>
        static public Vector2Int field230625213403_VZero = new Vector2Int(255,127);
        /// <summary>
        /// нулевой цвет
        /// </summary>
        static public Color32 field230625213404_ColorZero = new Color32(255, 127, 0, 0);
        /// <summary>
        ///
        /// </summary>
        static public int fun230625213400_ColorToHeight(Vector2Int v)
        {
            return v.x + (byte.MaxValue + 1) * v.y - field230625213402_Zero;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">диапозон от -32767 до 32767</param>
        /// <returns></returns>
        static public Vector2Int fun230625213401_HeightToColor(int id)
        {
            id += field230625213402_Zero;
            byte g = (byte)(id / 256.0f);
            byte r = (byte)(id - 256.0f * g);
            return new Vector2Int(r, g);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public void fun230625213406_test(int id = 0)
        {
            var v = st.Class.fun230625213401_HeightToColor(id);
            var c = v.x + (byte.MaxValue + 1) * v.y - st.Class.field230625213402_Zero;
            Debug.Log(v + "=" + c + "=" + id);
        }
        ///exit
    }
}
