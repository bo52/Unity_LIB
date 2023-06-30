//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306261718
{
    /// <summary>
    /// верстка блока по тесту
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        ///
        /// </summary>
        static public Vector2[] fun230626171800_ВерсткаБлока(this cs2306291643.IClass Редактор)
        {
            return new Vector2[8]
            {
                Vector2.zero,
                //uv2 Координата вершины блока
                new Vector2(Редактор.ТекущийБлок.Центр.x,Редактор.ТекущийБлок.Центр.y),
                //uv3 Координата вершины блока и КодВешиныБлока
                new Vector2(Редактор.ТекущийБлок.Центр.z,Редактор.ТекущийБлок.Код),
                Vector2.zero,
                Vector2.zero,
                Vector2.zero,
                Vector2.zero,
                Vector2.zero,
            };
        }
        ///exit
    }
}
