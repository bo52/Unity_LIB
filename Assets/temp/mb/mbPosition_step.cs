using UnityEditor;
using UnityEngine;
    using gui2023;
    using utility2023;
    public class mbPosition_step : MonoBehaviour
    {
        public byte step = 10;
        public Vector3 Координата = Vector3.zero;
        public void Вектор_отступ_обновить()
        {
            Координата = gameObject.transform.position / step;
            Координата = step * Координата.ОкруглитьВектор_вниз();
            gameObject.transform.position = Координата + 0.5f * step * Vector3.one;
        }
        [CustomEditor(typeof(mbPosition_step))]
        public class gui : Editor
        {
            private bool active = true;
            public void OnSceneGUI()
            {
                Event e = Event.current;
                int controlID = GUIUtility.GetControlID(FocusType.Passive);
                HandleUtility.AddDefaultControl(controlID);
                switch (e.GetTypeForControl(controlID))
                {
                    case EventType.MouseMove:
                        if (active) (target as mbPosition_step).Вектор_отступ_обновить();
                        break;
                }
            }
            public override void OnInspectorGUI()
            {
                stBool.ЛОГИЧЕСКИЙ(ref active, "Активен");
                if (active) GUILayout.Label("Координата=" + (target as mbPosition_step).Координата);
            }
        }
    }