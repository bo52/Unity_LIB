using UnityEditor;
using UnityEngine;
//_05032021134152564
namespace task2022
{
    using go2022;
    using gui2023;
    using mb2022;
    /// <summary>
    /// контейнер MONO префабов
    /// </summary>
    public class mbPrefabs : mbNRSDC
    {
        static public new string INFO = "NRSDC";
        public System.Type P;
        #region СПИСОК
        private mbList _Список;
        public mbList Список
        {
            get
            {
                if (_Список == null)
                {
                    _Список = new mbList(this);
                }
                return _Список;
            }
        }
        public void Add(object obj)=>Список.Add(obj as Mono);
        #endregion
        #region КАРТОЧКА
        /// <summary>
        /// часть пути к файлам
        /// </summary>
        public virtual string PATH
        {
            get;
            set;
        }
        //!
        public override void ОсобыеНастройки(GAMEOBJECT g, object[] atr)
        {
            base.ОсобыеНастройки(g, atr);
            Список.ЗагрузитьПрефабы();
        }
        #endregion
        protected new bool but = false;
        //
        public override bool ИНСПЕКТОР()
        {
            stFoldout.Foldout(() =>
                {
                    GUILayout.BeginHorizontal();
                    Список.ОткрытьФайл();
                    ПерезагрузитьОбъект(true);
                    GUILayout.EndHorizontal();
                }, "Префабы=" + Список.Count, ref but);
            return base.ИНСПЕКТОР();
        }
        public override bool СохранитьВсеОбъекты(bool кнопка = false, System.Action a = null)
        {

            return base.СохранитьВсеОбъекты(кнопка, () =>
             {
                 foreach (var m in Список)
                 {
                     (m as mbNRSDC).СохранитьОбъект();
                 }
             });
        }

        public override bool ПерезагрузитьОбъект(bool кнопка = false, System.Action a = null) => base.ПерезагрузитьОбъект(кнопка, Список.ЗагрузитьПрефабы);
        public override bool ОчиститьОбъект(bool кнопка = false, System.Action a = null) => base.ОчиститьОбъект(кнопка, Список.УдалитьВсеПрефабы);
        [CustomEditor(typeof(mbPrefabs))]
        public new class gui : mbNRSDC.gui
        {
        }
    }
}