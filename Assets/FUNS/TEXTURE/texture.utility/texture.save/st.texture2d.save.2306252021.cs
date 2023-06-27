//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306252021
{
    /// <summary>
    ///
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// размер текстуры
        /// </summary>
        static public string field230625202101_test = "Assets/Resources/test/texture.png";
        /// <summary>
        /// сохранить текстуру
        /// </summary>
        /// <param name="texture">2D текстура</param>
        /// <param name="f">файл сохранения (корень директории asset)</param>
        static public void fun230625202100_SaveTextureToFile(Texture2D texture, string f="")
        {
            var открыть = f == "";
            if (открыть) f = field230625202101_test;
            byte[] bytes = texture.EncodeToPNG();
            FileStream file = new FileStream(f, FileMode.Create);
            BinaryWriter binary = new BinaryWriter(file);
            binary.Write(bytes);
            file.Close();
            if (открыть) LIB.st2306261354.Class.fun230626135400_ОткрытьФайл(f);
        }
        ///exit
    }
}
