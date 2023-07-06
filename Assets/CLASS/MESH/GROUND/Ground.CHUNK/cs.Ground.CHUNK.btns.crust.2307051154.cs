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
    public interface IClass: cs2307052012_ФайловыйЧанкЗемли.IClass
    {
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307052012_ФайловыйЧанкЗемли.Class, IClass
    {
        #region ПараматрыКласса
        public Class(Vector3Int v, int h = sbyte.MinValue):base(v)
        {
            Высота = h == sbyte.MinValue ? st2306262206_ВычислитьВысоту.Class.fun230626220611_ВычислитьВысотуЯчеекТекстуры(new Vector2Int(v.x, v.z)) : h;
        }
        #endregion
        static new public string INFO = "INFO";
    }
}
