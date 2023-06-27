//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306252050
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
        static public ushort field230625205001_R = 8192;
        /// <summary>
        /// размер игрового объекта чанка 
        /// </summary>
        static public ushort field230625205003_Chunk_R = 128;
        /// <summary>
        ///
        /// </summary>
        static public void fun230625205000_СоздатьТекстуруЗемлиПоУмолчанию()
        {
            Texture2D tex = new Texture2D(field230625205001_R, field230625205001_R, TextureFormat.RG32, false);
            //st2306252108.Class.fun230625210801_ЗаполнитьКвадратомОдинаковоЗемлюПоУмолчанию(tex, field230625205001_R); долго
            st2306252021.Class.fun230625202100_SaveTextureToFile(tex);
        }
        /// <summary>
        /// 
        /// </summary>
        static public void fun230625205002_ПостроитьОдинЧанкЗемлиПоУмолчанию()
        {

        }
        ///exit
    }
}
