//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307051154_ЧанкИзЦветныхБлоковЗемлиСКорой
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
        Vector3Int Координата { get; set; }
        int Высота { get; set; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : IClass
    {
        #region ПараматрыКласса
        public int Высота { get => (int)_v.y; set => _v.y = value; }
        private Vector3Int _v = Vector3Int.zero; public Vector3Int Координата { get => _v; set => _v = value; }
        public Class(Vector3Int v, int h = sbyte.MinValue)
        {
            this._v = v;
            Высота = h == sbyte.MinValue ? st2306262206_ВычислитьВысоту.Class.fun230626220611_ВычислитьВысотуЯчеекТекстуры(new Vector2Int(v.x, v.z)) : h;
        }
        #endregion
        static public string INFO = "INFO";
        public Dictionary<ulong, cs2307051205_ЦветнойКодБлока.Class> КораЗемли = new Dictionary<ulong, cs2307051205_ЦветнойКодБлока.Class>();
        public Dictionary<ulong, cs2307051205_ЦветнойКодБлока.Class> БлокиЗемли = new Dictionary<ulong, cs2307051205_ЦветнойКодБлока.Class>();
    }
}
