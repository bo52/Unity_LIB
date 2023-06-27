using UnityEditor;
using UnityEngine;
using Utility2022;

namespace spBuild.Block
{
    public interface Int_ins
    {
        static byte ВыбранныйБлок=0;
        static bool БлокСуществует = false;
        static Vector3 КоординатаБлока => mbBlock_edit.Экз.GetComponent<mbPosition_step>().Координата;
        public void инс()
        {
            stLab_gui.lab("Регион=" + spBuild.Region.mbRegion_edit.КоординатаТекущегоРегиона,220);
            stLab_gui.lab("БлокСуществует=" + БлокСуществует.ToString());
            stLab_gui.lab("ВыбранныйБлок="+ ВыбранныйБлок.ToString(),120);
            stLab_gui.lab("КоординатаБлока=" + КоординатаБлока.ToString(), 220);
            stSlider.ползунок_байты(ref ВыбранныйБлок, 0, 255, (byte b) => {
                IBlock8_vs.МоделиБлоков[b].Загрузить();
            });
            IBlock8_vs.МоделиБлоков[ВыбранныйБлок].Кнопки();
        } 
    }
    public interface Int_sc: Int_ins
    {
        private IBlock8_vs_file ТекущийБлок => IBlock8_vs.МоделиБлоков[Int_ins.ВыбранныйБлок];
        /// <summary>
        /// spBuild.Cube256.mbCube256
        /// </summary>
        private LIB.cs2305141202.IClass EDIT => this as LIB.cs2305141202.IClass;
        public void сц()
        {
            ТекущийБлок.ПоказатьВсеТочки(EDIT);
        }
    }
    public class mbBlock_edit : Cube256.mbCube256, Int_sc
    {
        public override GameObject GO =>spBuild.Region.mbRegion_edit.Экз.gameObject;
        #region object
        static private string _name = "edit_b";
        static public MonoBehaviour MO => Экз;
        static GameObject Этот => MO.gameObject;
        static mbBlock_edit _ins;
        static public mbBlock_edit Экз
        {
            get
            {
                if (_ins == null || _ins.ToString() == "null")
                {
                    LIB.st2305221205.Class.fun230522120501/*Удаление*/(GameObject.Find(_name));
                    var go = stPrefab_method_load.ЗагрузитьПрефаб("zero/zero_obj");
                    go.name = _name;
                    //go.transform.SetParent(spBuild.Region.mbRegion_edit.Экз.transform);
                    go.AddComponent<mbPosition_step>().Выполнить = (Vector3 v) => {
                        //вычисление координаты блока
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
            private void OnSceneGUI() => (target as Int_sc).сц();
            public override void OnInspectorGUI() => (target as Int_ins).инс();
        }
    }
}