//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306301442
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass: cs2306301501.IClass
    {
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2306301501.Class,IClass
    {
        static new public string INFO = "INFO";
        #region БазовыеПараметры
        public override string ИмяКнопки => "ПостроитьТекстуруЗемли";
        /// <summary>
        /// Путь файла
        /// </summary>
        public override string Path => "default/";
        /// <summary>
        /// имя файла
        /// </summary>
        public override string NameFile => "chunk.world.zero";
        #endregion
        #region ПараметрыКласса
        cs2307011306_ТекстураЗемли.IClass ТекстураЗемли;
        public Class(GameObject go):base(go)
        {
            ТекстураЗемли = new cs2307011306_ТекстураЗемли.Class(go);
        }
        #endregion
        #region Показать
        #endregion
        #region Постройка
        private byte ВычислениеКода(Vector3 v)
        {
            return 51;
        }
        public override void ФункцияПостройки(cs2305141215.IClass edit)
        {
            var r = cs2307011306_ТекстураЗемли.IClass.РадиусВидимости;
            var tex = ТекстураЗемли.ТЕКСТУРА;

            Vector3 v;
            float y;
            for (var z= -r; z<= r;z++)
                for (var x = -r; x <= r; x++)
                {
                    y = tex.GetPixel(ТекстураЗемли.ОтЦентра(x), ТекстураЗемли.ОтЦентра(z)).a*255;
                    v = r*new Vector3(x, y, z);

                    edit.ДОБАВИТЬ(new cs2306262134.Class(v, ВычислениеКода(v)));
                }
        }
        #endregion
    }
}
