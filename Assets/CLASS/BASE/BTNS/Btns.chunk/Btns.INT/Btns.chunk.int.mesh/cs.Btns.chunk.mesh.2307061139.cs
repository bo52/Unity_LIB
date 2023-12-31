﻿//Блоки Чанка [Создать Меши]
//empty
//empty
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2307061139_СозданиеМеша
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2305071643_Chunk_default.IClass
    {
        void СформироватьЧанк();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class<TFILE> : cs2305071643_Chunk_default.Class<TFILE>, IClass 
        where TFILE : cs2307091136_ИгровойОбъектФайл.Class,new()
    {

        static new public string INFO = "INFO";
        #region БлокиЧанка
        private cs2307061149_БлокиЧанка_Интерфейс.IClass _chunk_btns; public cs2307061149_БлокиЧанка_Интерфейс.IClass БлокиЧанка=> _chunk_btns;
        #endregion
        public Class(object БлокиЧанка)
        {
            _chunk_btns = БлокиЧанка as cs2307061149_БлокиЧанка_Интерфейс.IClass;
        }

        #region СозданиеЧанкаИзБлоков
        #region ПроверкаСоседнегоЧанка
        public virtual bool ПроверкаСоседнегоЧанка(Vector3 v)
        {
            //ВыходНаВерхнийЧанк
            if (v.y >= БлокиЧанка.ЧАНК.РазмерЧанка) return true;
            //ПроверкаСоседннегоЧанка
            //ВыходНаПравыйЧанк
            if (v.x >= БлокиЧанка.ЧАНК.РазмерЧанка) return true;
            //ВыходНаПереднийЧанк
            if (v.z >= БлокиЧанка.ЧАНК.РазмерЧанка) return true;
            return false;
        }
        public virtual bool ПроверкаСоседнегоЗаднегоЧанка(Vector3 v)
        {
            //ВыходНаНижнийЧанк
            if (v.y < 0) return true;
            //ВыходНаЛевыйЧанк
            if (v.x < 0) return true;
            //ВыходНаЗаднийЧанк
            if (v.z < 0) return true;
            return false;
        }
        #endregion
        public void СформироватьЧанк()
        {
            var Проверен = new List<ulong>();
            БлокиЧанка.Блоки.Обойти((cs2307051205_ЦветнойКодБлока.Class btn) =>
            {
                ОбработкиБлокаЧанка(btn, Проверен);
                return true;
            });
        }
        public void ОбработкиБлокаЧанка(cs2307061154_ЦветнойБлок.Class btn, List<ulong> Проверен)
        {
            cs2307081134_Координата3.Struct.ОбработкаКоординаты(btn.Координата, Проверен,
                (cs2307081134_Координата3.Struct Координата) =>
                {
                    if (ПроверкаСоседнегоЗаднегоЧанка(Координата.v)) return false;
                    //ЭтоЦелыйБлокСПереходомНаНего
                    if (БлокиЧанка.Блоки.Существует(Координата.id)) return true;
                    var КОД = st2306271209.Class.fun230627120900_СформироватьКодБлока(Координата.v,
                        (Vector3 v) =>
                        {
                            if (ПроверкаСоседнегоЧанка(v)) return false;
                            return БлокиЧанка.Блоки.Существует3(v);
                        }
                        );
                    _btns.Добавить(Координата, КОД);
                    return false;
                });
        }
        #endregion
        public override void ФункцияПостройки(cs2305141215.IClass edit)
        {
            БлокиЧанка.Блоки.Обойти((Vector3 v, cs2307051205_ЦветнойКодБлока.Class b) =>
            {
                edit.ДОБАВИТЬ(new cs2306262134.Class(v, b.КОД));
                return true;
            });
        }
        public override Mesh ПостроитьСЗакрытием()
        {
            СформироватьЧанк();
            return base.ПостроитьСЗакрытием();
        }
    }
}
