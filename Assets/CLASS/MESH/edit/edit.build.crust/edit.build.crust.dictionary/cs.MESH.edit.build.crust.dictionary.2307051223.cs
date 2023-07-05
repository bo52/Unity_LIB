//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2307051223_ПостроитьЧанкиКорыОбъекта
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2307051233_ПостроитьЧанкКорыОбъекта.IClass
    {
        public void ПостроитьКоруОбъекта();
    }
    /// <summary>
    ///
    /// </summary>
    public abstract class Class : cs2307051233_ПостроитьЧанкКорыОбъекта.Class, IClass
    {
        static new public string INFO = "INFO";
        #region ПараметрыКласса
        public cs2307051313_Словарь_Ulong.IClass КораОбъекта;
        public Class(cs2307051313_Словарь_Ulong.IClass КораОбъекта, GameObject go) : base(go)
        {
            this.КораОбъекта = КораОбъекта;
        }
        #endregion
        public virtual void ЗакрытьРедактор(cs2307031649.IClass edit, ulong number)
        {
            edit.КоординатаЧанка = КораОбъекта.ПолучитьВектор(number);
            base.ЗакрытьРедактор(edit);
        }
        public virtual void ПостроитьКоруОбъекта()
        {
            var edit = ОткрытьРедактор;
            КораОбъекта.Обойти(
                (ulong key, object val) =>
                {
                    ЗакрытьРедактор(edit, key);
                    return true;
                });
        }
    }
}
