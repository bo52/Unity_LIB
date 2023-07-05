//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307011306_ТекстураЗемли
{
    /// <summary>
    /// Текстура Земли
    /// </summary>
    public interface IClass : cs2307011446_ТекстураФайл.IClass
    {
        public static int РадиусТекстуры = 4096;
        cs2307031639_ВидимыеЧанкиТекстуры.IClass ВидимыеЧанкиТекстуры { get; }
        Vector3Int НулеваяКоординатаЧанка { get; set; }
        public static int ОтЦентра(int x, int смещение) => x + РадиусТекстуры + смещение;
        Vector3Int КоординатаТекстурыОтЦентра(int x, int h, int z);
        Vector2Int КоординатаТекстурыОтЦентра(int x, int z);
        //Vector2Int КоординатаТекстурыБезЦентра(Vector2Int v);
        void Сбросить();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307011446_ТекстураФайл.Class, IClass
    {
        static new public string INFO = "INFO";
        public override string PATH => "world.zero/texture" + SIZE;
        #region ПараметрыКласса
        private cs2307031639_ВидимыеЧанкиТекстуры.IClass _chs; public cs2307031639_ВидимыеЧанкиТекстуры.IClass ВидимыеЧанкиТекстуры => _chs;
        private Vector3Int _v_zero = Vector3Int.zero; public Vector3Int НулеваяКоординатаЧанка { get => _v_zero; set => _v_zero = value; }
        public Class(GameObject go)
        {
            _chs = new cs2307031639_ВидимыеЧанкиТекстуры.Class(go, this);
        }
        #endregion
        #region ФункцииКласса
        public Vector3Int КоординатаТекстурыОтЦентра(int x, int h, int z) => new Vector3Int(IClass.ОтЦентра(x, НулеваяКоординатаЧанка.x), h, IClass.ОтЦентра(z, НулеваяКоординатаЧанка.z));
        public Vector2Int КоординатаТекстурыОтЦентра(int x, int z) => new Vector2Int(IClass.ОтЦентра(x, НулеваяКоординатаЧанка.x), IClass.ОтЦентра(z, НулеваяКоординатаЧанка.z));
        //public Vector2Int КоординатаТекстурыБезЦентра(Vector2Int v) => 
        #endregion
        public void Сбросить()
        {
            ВидимыеЧанкиТекстуры.Очистить();
        }
        public void Построить()
        {
            st2306262206_ВычислитьВысоту.Class.fun230626220611_ВычислитьВысотуЯчеекТекстуры(this);
        }
    }
}
