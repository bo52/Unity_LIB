using UnityEditor;
using UnityEngine;
namespace mesh2023
{
    using gui2023;
    public class mbCube256_test : MonoBehaviour
    {
        [CustomEditor(typeof(mbCube256_test))]
        public class gui : Editor
        {
            private byte КодБлока = 0;
            private IMesh меш = new MESH();
            private Vector3 Координата = Vector3.zero;
            private bool Координата_блок = false;

            public void Земля()
            {
                stCube256.Куб(меш, Координата, 51);
                меш.Закрыть((target as MonoBehaviour).gameObject);
            }

            public override void OnInspectorGUI()
            {
                if (Координата.ползунок_вектор(ref Координата_блок, "Координата", -10, +10)) Земля();

                stBtn.btn("построить землю", Земля);

                КодБлока.ползунок_байты(0, 255, () =>
                {
                    stCube256.Куб(меш, Координата, КодБлока);
                    меш.Закрыть((target as MonoBehaviour).gameObject);
                });
            }
        }
    }
}