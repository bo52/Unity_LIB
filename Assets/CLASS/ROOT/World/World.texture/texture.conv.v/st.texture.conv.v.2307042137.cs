//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.st2307042137
{
    /// <summary>
    ///
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        public struct Форма
        {
            public struct Размеры
            {
                public byte left;
                public byte right;
                public byte forward;
                public byte back;
                public Размеры(float left, float right, float forward, float back)
                {
                    this.left = (byte)left;
                    this.right = (byte)right;
                    this.forward = (byte)forward;
                    this.back = (byte)back;
                }
            }
            public Размеры Высоты;
            public Размеры Длина;
            public Размеры Ширина1;
            public Размеры Ширина2;
            public byte up;
            public bool СуществуетБлок(Vector3Int v)
            {
                //if v.y>
            }
            public Форма(Vector4 left, Vector4 right, Vector4 back, Vector4 forward, byte up)
            {
                this.up = up;
                Длина = new Размеры(left.x, right.x, back.x, forward.x);
                Высоты = new Размеры(left.y, right.y, back.y, forward.y);
                Ширина1 = new Размеры(left.z, right.z, back.z, forward.z);
                Ширина2 = new Размеры(left.w, right.w, back.w, forward.w);
            }

        }
        /// <summary>
        /// Высоты = 30*4
        /// Длина = 15*4
        /// Ширина1 = 15*4
        /// Ширина2 = 15*4
        /// </summary>
        static public List<Форма> fun230704213700_МассивВекторов = new List<Форма>
        {
            default,
            new Форма(),//1
        };
        ///exit
    }
}
