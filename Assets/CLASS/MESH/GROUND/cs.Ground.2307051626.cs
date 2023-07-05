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
    public interface IClass
    {
        static public byte РадиусВидимости = 15;
        static public IClass ВидимаяЧастьЗемли = new Class();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307051313_Словарь_Ulong.Class<cs2307051154_ЧанкИзЦветныхБлоковЗемлиСКорой.IClass>, IClass
    {
        static new public string INFO = "INFO";
        public Class()
        {
            Генерация();
        }
        public void ДобавитьЧанк(Vector3Int v)
        {
            //ЗагрузкаЧанка?
            var obj = new cs2307051154_ЧанкИзЦветныхБлоковЗемлиСКорой.Class(v);
            this.Добавить(v, obj);
        }
        public void Генерация()
        {
            for (var z = -IClass.РадиусВидимости; z <= IClass.РадиусВидимости; z++)
                for (var x = -IClass.РадиусВидимости; x <= IClass.РадиусВидимости; x++)
                {
                    this.ДобавитьЧанк(new Vector3Int(x, 0, z));
                }
        }
    }
}
