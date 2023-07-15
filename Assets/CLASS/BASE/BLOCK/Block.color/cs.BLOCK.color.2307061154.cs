//Блок.Цвет наследует интерфейс.Координата
//empty
//empty
using UnityEngine;
namespace LIB.cs2307061154_ЦветнойБлок
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass: cs2307081134_Координата3.IClass
    {
        static Color32 Green = new Color32(211, 151, 0, 255);
        Color32 Цвет { get; set; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307081134_Координата3.Class, IClass
    {
        static public string INFO = "INFO";
        private Color32 _c = IClass.Green; public Color32 Цвет { get => _c; set => _c = value; }
        public Class(cs2307081134_Координата3.Struct v):base(v)
        {
        }
        public Class(Vector3 v) : base(v)
        {
        }
        public Class(cs2307081134_Координата3.Struct v,Color32 c) : base(v)
        {
            this._c = c;
        }
    }
}
