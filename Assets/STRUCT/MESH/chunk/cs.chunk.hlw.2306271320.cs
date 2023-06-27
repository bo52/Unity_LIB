//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306271320
{
    /// <summary>
    ///
    /// </summary>
    public struct Class
    {
        static public string INFO = "INFO";
        public byte Высота;//y
        public byte Длинна;//x
        public byte Ширина;//z
        public Class(byte Высота, byte Длинна, byte Ширина)
        {
            this.Высота = Высота;
            this.Длинна = Длинна;
            this.Ширина = Ширина;
        }
        public Class(Vector3 v)
        {
            this.Высота = (byte)v.y;
            this.Длинна = (byte)v.x;
            this.Ширина = (byte)v.z;
        }
        public string PATH => "chunk.hlw";
        public string ИмяЧанка => PATH + "." + Высота + "." + Длинна + "." + Ширина;
    }
}
