//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307081134_Координата3
{
    /// <summary>
    ///
    /// </summary>
    public struct Class
    {
        static public string INFO = "INFO";
        static Vector3[] Соседи = new Vector3[]
        {
            new Vector3(-1,-1,-1),new Vector3(0,-1,-1),new Vector3(1,-1,-1),new Vector3(-1,-1,0),new Vector3(0,-1,0),new Vector3(1,-1,0),new Vector3(-1,-1,1),new Vector3(0,-1,1),new Vector3(1,-1,1),
            new Vector3(-1,0,-1),new Vector3(0,0,-1),new Vector3(1,0,-1),new Vector3(-1,0,0),new Vector3(1,0,0),new Vector3(-1,0,1),new Vector3(0,0,1),new Vector3(1,0,1),
            new Vector3(-1,1,-1),new Vector3(0,1,-1),new Vector3(1,1,-1),new Vector3(-1,1,0),new Vector3(0,1,0),new Vector3(1,1,0),new Vector3(-1,1,1),new Vector3(0,1,1),new Vector3(1,1,1),
        };
        public Vector3 v;
        public ulong id;
        public Class(Vector3 v, ulong id)
        {
            this.v = v;
            this.id = id;
        }
        public Class(Vector3 v)
        {
            this.v = v;
            this.id = st2305211702.Class.fun230521170203_ПолучитьНомер(v);
        }
        public Class Сосед(Vector3 dv) => new Class(v + dv);
        #region Обработка
        static public void ОбработкаКоординаты(Vector3 v, List<ulong> Проверен, System.Func<Class, bool> ФункцияГраницы)
        {
            var Координата = new Class(v);
            ОбработкаКоординаты(Координата, Проверен, ФункцияГраницы);
        }
        static public void ОбработкаКоординаты(Class Координата, List<ulong> Проверен, System.Func<Class, bool> ФункцияГраницы)
        {
            if (Проверен.IndexOf(Координата.id) != -1) return;
            //не проверен
            Проверен.Add(Координата.id);
            if (!ФункцияГраницы(Координата)) return;
            foreach (var dv in Соседи)
            {
                ОбработкаКоординаты(Координата.v + dv, Проверен, ФункцияГраницы);
            }
        }
        #endregion
    }
}
