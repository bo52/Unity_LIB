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
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307011446_ТекстураФайл.Class, IClass
    {
        static new public string INFO = "INFO";
        static Texture2D НулеваяПоверхность;
        static Vector3 ТекущееМестоположение = Vector3.zero;
        static byte РадиусВидимости = 32;
        public override string PATH => "world.zero/texture" + SIZE;

        static int ОпределениеСмещенияВысоты()
        {
            //Случайное число -1 0 +1
            return Mathf.;
        }
        void НачальнаяНулеваяПоверхность()
        {
            int y;
            var tex = ТЕКСТУРА; 
            for (var z = -РадиусВидимости; z <= РадиусВидимости; z++)
                for (var x = -РадиусВидимости; x <= РадиусВидимости; x++)
                {
                    y = ОпределениеСмещенияВысоты();
                }
            Сохранить();
        }
    }
}
