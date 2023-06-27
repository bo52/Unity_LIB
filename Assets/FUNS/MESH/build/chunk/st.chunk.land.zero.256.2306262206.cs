//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306262206
{
    /// <summary>
    /// 
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// 
        /// </summary>
        static public byte field230626220601_Chunk_R = 64;
        /// <summary>
        /// координата по оси y по умолчанию земли
        /// </summary>
        static public int field230626220602_y_zero = 1;
        /// <summary>
        /// код земли
        /// </summary>
        static public byte field230626220603_code = 51;
        /// <summary>
        /// ИмяЧанка
        /// </summary>
        static public string field230626220604_ИмяЧанка = "chunk." + field230626220603_code + "." + field230626220601_Chunk_R;
        /// <summary>
        ///
        /// </summary>
        static public void fun230626220600_ПостроитьОдинЧанкЗемлиПоУмолчанию(GameObject go)
        {
            var edit = new cs2305141202.Class(go);
            Vector3 v;
            for (var z = 0; z <= field230626220601_Chunk_R; z++)
            {
                for (var x = 0; x <= field230626220601_Chunk_R; x++)
                {
                    v = new Vector3(x, field230626220602_y_zero, z);
                    edit.ИзменитьТекущийБлокИПостроить(new cs2306262134.Class(v, field230626220603_code));
                }
            }
            st2305072046.Class.fun230507204601_ПривязатьМешОтРедактора(edit);
        }
        static public bool fun230626220605_ИнтерфейсПоУмолчанию(GameObject go)
        {
            return st2305161151.Class.fun230516115102_btn_name("default", () => fun230626220600_ПостроитьОдинЧанкЗемлиПоУмолчанию(go));
        }
        ///exit
    }
}
