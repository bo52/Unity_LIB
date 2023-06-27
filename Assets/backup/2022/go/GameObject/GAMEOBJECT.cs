using UnityEngine;
namespace go2022
{
    using class2022;
    /// <summary>
    /// Игровой Объект на Сцене
    /// </summary>
    public class GAMEOBJECT : CLASS
    {
        public object[] ATRs;
        public GameObject GO;
        public virtual GAMEOBJECT РОДИТЕЛЬ { get; set; }
        public virtual string ID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Type МоноКЛАСС { get; set; }
        #region CREATE
        public GAMEOBJECT(object[] atr, string name, string id)
        {
        }
        public GAMEOBJECT(object[] atrs = null)
        {
            if (atrs == null)
                return;
            //atrs[0] = this;

            GO = this.pow_go(atrs);
        }

        #endregion
        public virtual void ОсобыеНастройки(object[] atrs)
        {
            var SCRIPT = МоноКЛАСС == null ? stExample_method.ДобавитьМоноИгровойОбъект(GO) : stExample_method.ДобавитьМоноИгровойОбъект(GO, МоноКЛАСС);
            SCRIPT?.ОсобыеНастройки(this, atrs);
        }
    }
}