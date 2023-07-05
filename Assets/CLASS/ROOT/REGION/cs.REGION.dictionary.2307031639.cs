//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307031639_ВидимыеЧанкиТекстуры
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : Dictionary<ulong, GameObject>, IClass
    {
        static public string INFO = "INFO";
        #region ПараметрыКласса
        private GameObject _go; GameObject GO => _go;
        private cs2307011446_ТекстураФайл.Class _TextrueLab; cs2307011446_ТекстураФайл.Class ТекстураЗемли => _TextrueLab;
        public Class(GameObject go, cs2307011446_ТекстураФайл.Class tex)
        {
            _go = go;
            _TextrueLab = tex;
        }
        #endregion
        #region Построить

        private void ФункцияПостройки(cs2305141215.IClass edit)
        {
            var edit_modif = edit as cs2307031649.IClass;
            var v = edit_modif.КоординатаЧанка;
            var c = ТекстураЗемли.ТЕКСТУРА.GetPixel((int)v.x, (int)v.y);
            byte R = 32;
            Vector3Int num;
            byte КодБлока;

            for (var y = 0; y < R; y++)
                for (var x = 0; x < R; x++)
                    for (var z = 0; z < R; z++)
                    {
                        num = new Vector3Int(x, y, z);
                        КодБлока = 0;
                        edit.ДОБАВИТЬ(new cs2306262134.Class(num,КодБлока));
                    }
        }
        #endregion
    }
}
