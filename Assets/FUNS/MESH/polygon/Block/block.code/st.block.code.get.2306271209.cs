//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306271209
{
    /// <summary>
    ///
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// СформироватьКодБлока по функции
        /// </summary>
        static public byte fun230627120900_СформироватьКодБлока(Vector3 v, System.Func<Vector3,bool> СуществуетВершина)
        {
                float code = 0;
                var arr = st2305151543.Class.field230515154300_ВекторОтЦентраКубаПоНомеруВершины;
                for (var i = 0; i < arr.Length; i++)
                    code += СуществуетВершина(v + arr[i]) ? Mathf.Pow(2, i) : 0;
                return (byte)code;
        }
        ///exit
    }
}
