//Bo52_05032021142102921.PREFAB.MONO.mbPrefab
using UnityEditor;
using UnityEngine;
namespace task2022
{
    using scr2022;
    using mb2022;
    using go2022;
    using Utility2022;

    /// <summary>
    /// ПРЕФАБ
    ///  mono префаб в контейнере
    /// </summary>
    public class mbPrefab : mbNRSDC
    {
        public mbPrefabs КОНТЕЙНЕР;
        private new bool but = false;
        override public void method_inspector()
        {
            stFoldout_gui.Foldout(() =>
            {
                GUILayout.BeginHorizontal();
                КОНТЕЙНЕР.Список.ОткрытьФайл();
                СохранитьОбъект(true);
                КОНТЕЙНЕР.ПерезагрузитьОбъект(true);
                УдалениеОбъекта(true);
                GUILayout.EndHorizontal();
            },
            "Сохранить,Перезагрузить,УДАЛИТЬ=" + stGameObject.ВсегоВертексов(this.gameObject), ref but);
        }
        public override void ОсобыеНастройки(GAMEOBJECT g, object[] atr)
        {
            КОНТЕЙНЕР = atr?[3] as mbPrefabs;
            base.ОсобыеНастройки(g, atr);

            gameObject.layer = 9;
            stMono_method.ВыполнитьМетод(КОНТЕЙНЕР, "Add", this);
        }

        public override bool ИНСПЕКТОР()
        {
            method_inspector();
            return base.ИНСПЕКТОР();
        }
        #region NEW
        public override GameObject НовыйОбъект(bool кнопка = false, object[] arg = null) => (GameObject)КОНТЕЙНЕР.ВыполнитьМетод("НовыйОбъект", кнопка);
        #endregion
        #region SAVE
        public override bool СохранитьОбъект(bool кнопка = false, object[] arg = null) => base.СохранитьОбъект(кнопка, КОНТЕЙНЕР.Список.args_save_mesh());
        #endregion
        #region DELETE
        public override void method_delete() => КОНТЕЙНЕР.Список.method_delete(this);
        public override bool УдалениеОбъекта(bool кнопка = false, System.Action a = null) => base.УдалениеОбъекта(кнопка, method_delete);
        #endregion
        #region RELOAD
        public void method_reload()
        {
            Selection.objects = null;
            КОНТЕЙНЕР.Список.method_delete_scene(this);
            stPrefab_method_load.ЗагрузитьПрефаб(ID, КОНТЕЙНЕР.Список.DIR(), КОНТЕЙНЕР.gameObject);
        }
        public override bool ПерезагрузитьОбъект(bool кнопка = false, System.Action a = null) => base.ПерезагрузитьОбъект(кнопка, method_reload);
        #endregion
        [CustomEditor(typeof(mbPrefab))]
        public new class gui : mbNRSDC.gui
        {
        }
    }
}