//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306252108
{
    /// <summary>
    /// Заполнить Texture2d
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tex"></param>
        /// <param name="R"></param>
        /// <param name="c"></param>
        static public void fun230625210800_ЗаполнитьКвадратомОдинаковоФлоат(Texture2D tex, uint R, Color c)
        {
            //Число в цвет
            for (byte x = 0; x < R; x++)
                for (byte y = 0; y < R; y++)
                        tex.SetPixel(x, y, c);
            tex.Apply();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tex"></param>
        /// <param name="R"></param>
        static public void fun230625210801_ЗаполнитьКвадратомОдинаковоЗемлюПоУмолчанию(Texture2D tex, uint R)
        {
            var c_zero = st2306252134.Class.field230625213404_ColorZero;
            //Число в цвет
            for (byte x = 0; x < R; x++)
                for (byte y = 0; y < R; y++)
                    tex.SetPixel(x, y, c_zero);
            tex.Apply();
        }
        ///exit
    }
}
