//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307051626_ЗЕМЛЯ
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2307051313_Словарь_Ulong.IClass
    {
        static public byte РадиусВидимости = 3;
        void ДобавитьЧанк(Vector2Int v, int h);
        int Высота(Vector2 v);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307051313_Словарь_Ulong.Class<cs2307071139_ЧанкЗемли.IClass>, IClass
    {
        static new public string INFO = "INFO";
        public Class()
        {
            Генерация();
        }
        public int Высота(Vector2 v)
        {
            var obj = Найти2<cs2307071139_ЧанкЗемли.IClass>(v);
            return obj == null ? 0 : obj.Высота;
        }
        public void Генерация()
        {
            var ВычислениеВысоты = new cs2306262206_ВычислитьВысоту.Class(this);
            Выполнить();
        }
        public void Выполнить()
        {
            foreach (var obj in this)
                obj.Value.Выполнить();
        }
        public void ДобавитьЧанк(Vector2Int v, int h)
        {
            var obj = new cs2307071139_ЧанкЗемли.Class(this,v, h);
            this.Добавить2(v, obj);
        }
    }
}
