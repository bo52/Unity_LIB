using UnityEditor;
using UnityEngine;
/// <summary>
/// �����,�������������,���������,�������,��������
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
                �����(true);
                �����������(true);
                �������������������(true);
                ���������������(true);
                ��������������(true);
                GUILayout.EndHorizontal();
            }, "������=" + gameObject.��������������(), ref but);
        }
        public override bool ���������()
        {
            base.���������();
            method_inspector();
            return true;
        }
        #endregion
        #region btn
        public virtual bool �������������������(bool ������ = false, System.Action a = null) => stButton_act.�������������("���������", ������, a);
        public virtual bool �������������������(bool ������ = false, System.Action a = null) => stButton_act.�������������("�������������", ������, a);
        #region new
        public virtual GameObject �����������(bool ������ = false, object[] arg = null) => stButton_act.�������������("�����", ������, stMono_go_new.method_new, arg);
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
        public virtual bool ���������������(bool ������ = false, object[] arg = null) => stButton_act.�������������("���������", ������, method_save_mesh, arg);
        #endregion
        #region delete
        public virtual void method_delete() => Object.DestroyImmediate(gameObject);
        public virtual bool ���������������(bool ������ = false, System.Action a = null) => stButton_act.�������������("�������", ������, method_delete);
        #endregion
        #region free
        public void method_free_scene() => stGameObject.����������������(gameObject.transform);
        public virtual bool ��������������(bool ������ = false, System.Action a = null)
        {
            var b = stButton_act.�������������("��������", ������, () =>
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