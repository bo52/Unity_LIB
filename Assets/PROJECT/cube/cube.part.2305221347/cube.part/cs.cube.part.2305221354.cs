//empty
//empty
//Cube_part
using UnityEngine;
namespace LIB.cs2305221354
{
    public interface IClass
    {
        Vector3 Начало { get; }
        byte Высота { get; }
        byte Длинна { get; }
        byte Ширина { get; set; }
    }
    /// <summary>
    ///Cube_part
    /// </summary>
    public class Class:IClass
    {
        static public string INFO = "INFO";
        private byte _h; public byte Высота => _h;
        private byte _w; public byte Длинна => _w;
        private byte _g; public byte Ширина { get => _g; set => _g = value; }
        public Vector3Int Координата;
        public Class(Vector3Int v, byte h, byte w)
        {
            _h = h;
            _w = w;
            _g = 1;
            Координата = v;
        }
        public Vector3 Начало => Координата;
    }
}
