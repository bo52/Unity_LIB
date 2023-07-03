//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2306282238
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass: cs2306301501.IClass
    {
    }
    /// <summary>
    /// Чанк51 c сохранением
    /// </summary>
    public class Class : cs2306301501.Class, IClass
    {
        static new public string INFO = "LIB.cs2306282238.Class";
        #region БазовыеПараметры
        /// <summary>
        /// Путь файла
        /// </summary>
        public override string Path => "default/";
        private byte R = cs2305071643_Chunk_default.IClass.Chunk_R;
        /// <summary>
        /// имя файла
        /// </summary>
        public override string NameFile => "chunk." + КодПоУмолчанию + "." + R;
        #endregion
        #region ПараметрыКласса
        public Class(GameObject go) : base(go) { }
        /// <summary>
        /// координата по оси y по умолчанию земли
        /// </summary>
        static public int НулеваяВысота = 1;
        /// <summary>
        /// код земли
        /// </summary>
        static public byte КодПоУмолчанию = 51;
        #endregion
        #region Показать
        public override string ИмяКнопки => "ОдинЧанкМираПоУмолчанию";
        #endregion
        #region Постройка
        public override void ФункцияПостройки(cs2305141215.IClass edit)
        {
            Vector3 v;
            cs2306262134.Class b;
            for (var z = 0; z <= R; z++)
                for (var x = 0; x <= R; x++)
                {
                    v = new Vector3(x, НулеваяВысота, z);
                    b = new cs2306262134.Class(v, КодПоУмолчанию);
                    edit.ДОБАВИТЬ(b);
                }
        }
        #endregion
    }
}
