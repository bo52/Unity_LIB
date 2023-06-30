//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306262134
{
    /// <summary>
    /// блок из координаты и кода
    /// </summary>
    public struct Class
    {
        static public string INFO = "INFO";
        public byte Код;
        public Vector3 Центр;
        public Class(Vector3 ЦентрБлока, byte КодВершиныБлока)
        {
            this.Центр = ЦентрБлока;
            this.Код = КодВершиныБлока;
        }
    }
}
