//Stat.scene.go.simple
//using Stat.scene.go.mono.oper;
//GAMEOBJECT_simple
using UnityEngine;
/// <summary>
/// 
/// </summary>
namespace LIB.cs2305161704
{
    /// <summary>
    /// go.simple
    /// </summary>
    public class Class
    {
        static public string INFO = "CLASS";
        static public string PRODUCT = "Игровой Объект на Сцене";
        #region ПОЛЯ  
        public object[] ATRs;
        public GameObject GO;
        /// <summary>
        /// Учитывается через NAMBERS!!!
        /// </summary>
        public virtual GAMEOBJECT РОДИТЕЛЬ
        {
            get;
            set;
        }
        #region КАРТОЧКА
        /// <summary>
        /// Учитывается через NAMBERS!!!
        /// </summary>
        public virtual string ID
        {
            get;
            set;
        }

        #region NAME
        /// <summary>
        /// Учитывается через NAMBERS!!!
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }
        public string gName
        {
            get
            {

                return (Name == null ? "" : (Name + "_")) + ID;
            }
        }
        #endregion

        #endregion
        #endregion
        public virtual Mono ОсобыеНастройки(object[] atrs)
        {
            var t = МоноКЛАСС;
            return t == null ? GO.ДобавитьМоноИгровойОбъект() : GO.ДобавитьМоноИгровойОбъект(t);
        }
        /// <summary>
        /// Учитывается через ДЖЕНЕРИК!!!
        /// </summary>
        public virtual System.Type МоноКЛАСС
        {
            get;
            set;
        }
        public Mono МОНО
        {
            get
            {
                return (Mono)GO.GetComponent(МоноКЛАСС);
            }
        }
    }
}
