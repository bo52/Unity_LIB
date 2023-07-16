//Словарь[Координата,ЦветнойКодБлока].Добавить
//empty
//empty
using UnityEngine;
namespace LIB.cs2307091713_Блоки_Добавление
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2307051313_Словарь_Ulong.IClass
    {
        void Добавить(Vector3 v, byte КОД);
        void Добавить(cs2307081134_Координата3.Struct Координата, byte КОД);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307051313_Словарь_Ulong.Class<cs2307051205_ЦветнойКодБлока.Class>, IClass
    {
        static new public string INFO = "INFO";
        #region Добавить
        public void Добавить(Vector3 Вектор, byte КОД) => this.Добавить(new cs2307051205_ЦветнойКодБлока.Class(КОД, Вектор));
        public void Добавить(cs2307081134_Координата3.Struct Координата, byte КОД) => this.Добавить(new cs2307051205_ЦветнойКодБлока.Class(КОД, Координата));
        public void Добавить(cs2307051205_ЦветнойКодБлока.Class b) => this.Добавить3(b.Координата.id, b);
        #endregion
    }
}
