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
        public int ВысотаЧанка(Vector2 v)
        {
            var obj = Найти<cs2307071139_ЧанкЗемли.IClass>(v);
            return obj == null ? 0 : obj.РедакторПаралепипеда.H.Высота;
        }
        public void Генерация()
        {
            this.Clear();
            for (var z = -IClass.РадиусВидимости; z <= IClass.РадиусВидимости; z++)
                for (var x = -IClass.РадиусВидимости; x <= IClass.РадиусВидимости; x++)
                {
                    this.ДобавитьЧанк(new Vector2Int(x, z));
                }
        }
        public void ДобавитьЧанк(Vector2Int v)
        {
            var obj = new cs2307071139_ЧанкЗемли.Class(v);
            this.Добавить(v, obj);
            obj.Выполнить();
        }
    }
}
