//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306241300
{
    /// <summary>
    /// альфа трехмерная текстура
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// тестовый файл
        /// </summary>
        static public string field230624130001_file_test = "Assets/Resources/test/alpha.asset";
        /// <summary>
        ///
        /// </summary>
        static public void fun230624130000_НоваяТрехМернаяАльфаТекстура(int MAX = 8192)
        {
            var tex = new Texture3D(512, 512, 512, TextureFormat.Alpha8, false);
            //fun230624130002_ЗаполнениеТекстуры(tex);
            fun230624130003_SaveTextureToFile(tex, field230624130001_file_test);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tex"></param>
        static public void fun230624130002_ЗаполнениеТекстуры(Texture3D tex)
        {
            for (byte x = 0; x < tex.height; x++)
                for (byte y = 0; y < tex.height; y++)
                    for (byte z = 0; z < tex.height; z++)
                        tex.SetPixel(x, y, z, new Color(0, 0, 1, 1));
            tex.Apply();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tex"></param>
        /// <param name="f"></param>
        static public void fun230624130003_SaveTextureToFile(Texture3D tex, string f)
        {
            AssetDatabase.CreateAsset(tex, f);
        }
        ///exit
    }
}
