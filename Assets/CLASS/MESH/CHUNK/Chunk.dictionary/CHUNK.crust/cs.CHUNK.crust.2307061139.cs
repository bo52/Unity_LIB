//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307061139_КораЧанка
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2307051313_Словарь_Ulong.IClass
    {
        void Добавить(Vector3 v, byte КОД);
        cs2307061149_БлокиЧанка.IClass БлокиЧанка { get; }
        void СформироватьКоруЧанка(System.Func<Vector3, bool> ПроверкаСоседнегоЧанка);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307051313_Словарь_Ulong.Class<cs2307051205_ЦветнойКодБлока.Class>, IClass
    {
        static new public string INFO = "INFO";
        private byte РазмерЧанка = 1;
        #region ОбщийСловарь
        private cs2307061242_СловарныйЧанк.IClass ОбщийСловарь;
        #endregion
        #region Блоки
        public cs2307061149_БлокиЧанка.IClass _btns = new cs2307061149_БлокиЧанка.Class();
        public cs2307061149_БлокиЧанка.IClass БлокиЧанка => _btns;
        #endregion
        public Class(byte РазмерЧанка)
        {
            this.РазмерЧанка = РазмерЧанка;
        }
        #region Добавить
        public void Добавить(Vector3 Вектор, byte КОД) => this.Добавить(new cs2307051205_ЦветнойКодБлока.Class(КОД, Вектор));
        public void Добавить(cs2307081134_Координата3.Class Координата, byte КОД) => this.Добавить(new cs2307051205_ЦветнойКодБлока.Class(КОД, Координата));
        public void Добавить(cs2307051205_ЦветнойКодБлока.Class b) => this.Добавить3(b.Координата.id, b);
        #endregion

        #region СозданиеКорыЧанкаИзБлоков
        public bool ПроверкаСоседнегоЧанка(Vector3 v)
        {
            //ВыходНаВерхнийЧанк
            if (v.y >= РазмерЧанка) return true;
            //ПроверкаСоседннегоЧанка
            //ВыходНаПравыйЧанк
            if (v.x >= РазмерЧанка) return true;
            //ВыходНаПереднийЧанк
            if (v.z >= РазмерЧанка) return true;
            return false;
        }
        public void СформироватьКоруЧанка(System.Func<Vector3, bool> ПроверкаСоседнегоЧанка)
        {
            if (ПроверкаСоседнегоЧанка == null) ПроверкаСоседнегоЧанка = this.ПроверкаСоседнегоЧанка;
            this.Clear();
            var Проверен = new List<ulong>();
            _btns.Обойти((cs2307051205_ЦветнойКодБлока.Class btn) =>
            {
                ОбработкиБлокаЧанка(btn, Проверен, ПроверкаСоседнегоЧанка);
                return true;
            });
        }
        public void ОбработкиБлокаЧанка(cs2307061154_ЦветнойБлок.Class btn, List<ulong> Проверен,System.Func<Vector3, bool> ПроверкаСоседнегоЧанка)
        {
            cs2307081134_Координата3.Class.ОбработкаКоординаты(btn.Координата, Проверен,
                (cs2307081134_Координата3.Class Координата) =>
                {
                    //ВыходНаНижнийЧанк
                    if (Координата.v.y < 0) return false;
                    //ВыходНаЛевыйЧанк
                    if (Координата.v.x < 0) return false;
                    //ВыходНаЗаднийЧанк
                    if (Координата.v.z < 0) return false;
                    //ЭтоЦелыйБлокСПереходомНаНего
                    if (БлокиЧанка.Существует(Координата.id)) return true;
                    var КОД = st2306271209.Class.fun230627120900_СформироватьКодБлока(Координата.v,
                        (Vector3 v) =>
                        {
                            if (ПроверкаСоседнегоЧанка(v)) return false;
                            return БлокиЧанка.Существует3(v);
                        }
                        );
                    this.Добавить(Координата, КОД);
                    //ДобавленНеЦелыйБлок.Выход
                    return false;
                });
        }
        #endregion
    }
}
