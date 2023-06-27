using UnityEditor;
using UnityEngine;
/// <summary>
/// Новый,Перезагрузить,Сохранить,УДАЛИТЬ,ОЧИСТИТЬ
/// </summary>
namespace mb2022
{
    using go2022;
    using mb2022;
    public class mbNRSDC : Mono
    {
        #region EDITOR
        protected bool but = false;
        virtual public void method_inspector()
        {
            stFoldout_gui.Foldout(() =>
            {
                GUILayout.BeginHorizontal();
                СТАРТ(true);
                НовыйОбъект(true);
                ПерезагрузитьОбъект(true);
                УдалениеОбъекта(true);
                ОчиститьОбъект(true);
                GUILayout.EndHorizontal();
            }, "Объект=" + gameObject.ВсегоВертексов(), ref but);
        }
        public override bool ИНСПЕКТОР()
        {
            base.ИНСПЕКТОР();
            method_inspector();
            return true;
        }
        #endregion
        #region btn
        public virtual bool СохранитьВсеОбъекты(bool кнопка = false, System.Action a = null) => stButton_act.РаботаОбъекта("СОХРАНИТЬ", кнопка, a);
        public virtual bool ПерезагрузитьОбъект(bool кнопка = false, System.Action a = null) => stButton_act.РаботаОбъекта("Перезагрузить", кнопка, a);
        #region new
        public virtual GameObject НовыйОбъект(bool кнопка = false, object[] arg = null) => stButton_act.РаботаОбъекта("Новый", кнопка, stMono_go_new.method_new, arg);
        #endregion
        #region SAVE
        public virtual GameObject method_save_mesh(object[] arg)
        {
            var m = gameObject.GetComponent<MeshFilter>().sharedMesh;
            if (m == null)
                return null;
            var f = (string)arg[1] + ID + ".asset";
            if (m.name.Length == 0)
            {
                AssetDatabase.CreateAsset(m, f);
                //AssetDatabase.SaveAssets();
            }

            return gameObject;
        }
        public virtual bool СохранитьОбъект(bool кнопка = false, object[] arg = null) => stButton_act.РаботаОбъекта("Сохранить", кнопка, method_save_mesh, arg);
        #endregion
        #region delete
        public virtual void method_delete() => Object.DestroyImmediate(gameObject);
        public virtual bool УдалениеОбъекта(bool кнопка = false, System.Action a = null) => stButton_act.РаботаОбъекта("УДАЛИТЬ", кнопка, method_delete);
        #endregion
        #region free
        public void method_free_scene() => stGameObject.УдалениеОбъектов(gameObject.transform);
        public virtual bool ОчиститьОбъект(bool кнопка = false, System.Action a = null)
        {
            var b = stButton_act.РаботаОбъекта("ОЧИСТИТЬ", кнопка, () =>
            {
                method_free_scene();
                a?.Invoke();
            });
            return b;
        }
        #endregion
        #endregion
        [CustomEditor(typeof(mbNRSDC))]
        public new class gui : Mono.gui
        {
        }
    }
}