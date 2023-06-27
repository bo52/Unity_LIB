//Bo52_01022021125742702.DRAWUI.CONTROL_01022021125742702.
namespace test2022
{
    using System.Collections.Generic;
    using UnityEngine;
    /// <summary>
    /// управление.Элементы
    /// </summary>
    public class mbTest_elements:MonoBehaviour
    {
        static List<GameObject> Элементы = new List<GameObject>();
        public void СоздатьМеш()
        {

        }
        public void СоздатьОбъект()
        {
            var go = new GameObject();
            Элементы.Add(go);
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
                СоздатьОбъект();
        }
        private void OnGUI()
        {
            GUIStyle style = new GUIStyle();
            style.fontSize = 32;
            GUI.Label(new Rect(50, 50, 400, 100), "Всего Элементов="+ Элементы.Count, style);
        }
        static public int test_gui()
        {
            stButton_gui.кнопка("test", 100);
            return 1;
        }
    }
}
