using UnityEditor;
using UnityEngine;
using Utility2022;

namespace spBuild.Block
{
    public interface Int_ins
    {
        static byte �������������=0;
        static bool �������������� = false;
        static Vector3 ��������������� => mbBlock_edit.���.GetComponent<mbPosition_step>().����������;
        public void ���()
        {
            stLab_gui.lab("������=" + spBuild.Region.mbRegion_edit.�������������������������,220);
            stLab_gui.lab("��������������=" + ��������������.ToString());
            stLab_gui.lab("�������������="+ �������������.ToString(),120);
            stLab_gui.lab("���������������=" + ���������������.ToString(), 220);
            stSlider.��������_�����(ref �������������, 0, 255, (byte b) => {
                IBlock8_vs.������������[b].���������();
            });
            IBlock8_vs.������������[�������������].������();
        } 
    }
    public interface Int_sc: Int_ins
    {
        private IBlock8_vs_file ����������� => IBlock8_vs.������������[Int_ins.�������������];
        /// <summary>
        /// spBuild.Cube256.mbCube256
        /// </summary>
        private LIB.cs2305141202.IClass EDIT => this as LIB.cs2305141202.IClass;
        public void ��()
        {
            �����������.����������������(EDIT);
        }
    }
    public class mbBlock_edit : Cube256.mbCube256, Int_sc
    {
        public override GameObject GO =>spBuild.Region.mbRegion_edit.���.gameObject;
        #region object
        static private string _name = "edit_b";
        static public MonoBehaviour MO => ���;
        static GameObject ���� => MO.gameObject;
        static mbBlock_edit _ins;
        static public mbBlock_edit ���
        {
            get
            {
                if (_ins == null || _ins.ToString() == "null")
                {
                    LIB.st2305221205.Class.fun230522120501/*��������*/(GameObject.Find(_name));
                    var go = stPrefab_method_load.���������������("zero/zero_obj");
                    go.name = _name;
                    //go.transform.SetParent(spBuild.Region.mbRegion_edit.���.transform);
                    go.AddComponent<mbPosition_step>().��������� = (Vector3 v) => {
                        //���������� ���������� �����
                    };
                    _ins = go.AddComponent<mbBlock_edit>();
                }
                return _ins;
            }
        }
        #endregion
        [CustomEditor(typeof(mbBlock_edit))]
        public new class gui : Editor
        {
            private void OnSceneGUI() => (target as Int_sc).��();
            public override void OnInspectorGUI() => (target as Int_ins).���();
        }
    }
}