//empty
//empty
//альфа текстура
using System.IO;
using UnityEngine;
namespace LIB.st2305272130
{
    /// <summary>
    /// альфа плоская текстура
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// тестовый файл
        /// </summary>
        static public string field230527213001_file_test = Application.dataPath + "/Resources/test/alpha.png";
        /// <summary>
        ///
        /// </summary>
        static public void fun230527213000_НоваяАльфаТекстура(int MAX = 8192)
        {
            Texture2D tex = new Texture2D(MAX, MAX, TextureFormat.Alpha8, false);
            //tex.Apply();
            st2306252021.Class.fun230625202100_SaveTextureToFile(tex, field230527213001_file_test);
        }
        ///exit
    }
}
