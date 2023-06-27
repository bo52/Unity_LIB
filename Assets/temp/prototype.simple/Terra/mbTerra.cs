using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace chunk2023
{
    //using mb2023;
    using go2023;
    using gui2023;
    using mesh2023;
    using utility2023;
    public class mbTerra : mbPosition_step
    {
        static public readonly string PATH = "Assets/Resources/MESHES/terra";
        Dictionary<ulong, GameObject> Чанки = new Dictionary<ulong, GameObject>();
        GameObject go;
        GameObject Terra
        {
            get
            {
                if (go == null) go = GameObject.Find("terra");
                return go;
            }
        }
        #region Загрузить
        public void Загрузить()
        {
            Terra.transform.УдалениеОбъектов();
            PATH.AssetDataBase_dir<Mesh>(Загрузить);
        }
        public GameObject Загрузить(ulong id, Mesh m)
        {
            go = new GameObject();
            go.name = id.ToString();
            go.transform.SetParent(Terra.transform);
            //go.Связать(m, false);
            Чанки.Add(id, go);

            var scr = go.AddComponent<mbChunk_cube>();
            scr.Загрузить();
            return go;
        }
        #endregion
        private ulong current_id;
        private GameObject current_chunk;
        GameObject ТекущийЧанк
        {
            get
            {
                if (current_chunk == null)
                {
                    go = stGo_scene.Земля;
                    //РедакторЧанк.Изменить(go, null, true);
                }
                return go;
            }
        }
        public void Инспектор()
        {
            stBtn.btn("default", Загрузить);
        }
        [CustomEditor(typeof(mbTerra))]
        public new class gui : mbPosition_step.gui
        {
            public override void OnInspectorGUI()
            {
                base.OnInspectorGUI();
                (target as mbTerra).Инспектор();
            }
        }
    }
}