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
        void ПостроитьВсюПоверхностьЗемли();
        void Добавить(Vector3 v);
        void Очистить();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : Dictionary<ulong, GameObject>, IClass
    {
        static public string INFO = "INFO";
        #region ПараметрыКласса
        private Vector3 _v_zero = Vector3.zero; public Vector3 НулеваяКоординатаЧанка { get => _v_zero; set => _v_zero = value; }
        private GameObject _go; GameObject GO => _go;
        private cs2307011446_ТекстураФайл.Class _TextrueLab; cs2307011446_ТекстураФайл.Class ТекстураЗемли => _TextrueLab;
        public Class(GameObject go, cs2307011446_ТекстураФайл.Class tex)
        {
            _go = go;
            _TextrueLab = tex;
        }
        #endregion
        #region ФункцииКласса
        public void Очистить() => this.Clear();
        public void Добавить(Vector3 v) => this.Add(ПолучитьНомер(v), null);
        public Vector3 ПолучитьВектор(ulong id) => st2305211702.CLASS.fun230521170204_ПолучитьВектор(id);
        public ulong ПолучитьНомер(Vector3 v) => st2305211702.CLASS.fun230521170203_ПолучитьНомер(v);
        #endregion
        #region Построить
        public void ПостроитьВсюПоверхностьЗемли()
        {
            cs2307031649.IClass edit = new cs2307031649.Class(GO, _param_build);
            foreach (var val in this)
            {
                edit.КоординатаЧанка = ПолучитьВектор(val.Key);
                edit.Закрыть();
                this[val.Key] = edit.Child;
            }
        }
        private cs2307031203_ПараметрыПостройки.Class _param_build => new cs2307031203_ПараметрыПостройки.Class(ФункцияПостройки);
        private void ФункцияПостройки(cs2305141215.IClass edit)
        {
            //ТекстураЗемли
        }
        #endregion
        //смещение
        public void СмещениеНулевойКоординатыЗемли(Vector3 dv)
        {
            НулеваяКоординатаЧанка += dv;
            //switch (dv)
            //{
            //case Vector3.left:break;
            //}
        }
    }
}
