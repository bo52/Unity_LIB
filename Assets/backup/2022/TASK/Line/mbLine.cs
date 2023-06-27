//Bo52_3101202122031332.DRAWUI.MONO_3101202122031332.
namespace task2022
{
    using mb2022;
    using UnityEngine;
    using UnityEditor;
    /// <summary>
    /// LINE
    /// линия между элементами
    /// </summary>
    public class mbLine: Mono
    {
        static string PRODUCT = "линия между элементами";
        public LineRenderer LINE;
        public GameObject GO;
        static public mbLine Создать(GameObject go, GameObject GO)
        {
            var s = go.AddComponent<mbLine>();
            go.AddComponent<LineRenderer>();
            s.GO = GO;
            return s;
        }
        private void Start()=>LINE = GetComponent<LineRenderer>();
        private void LateUpdate()
        {
            LINE.SetPosition(0, gameObject.transform.position);
            LINE.SetPosition(1, GO.transform.position);
        }
        public void test()
        {
        //code
        }
        static public int test_gui()
        {
        stButton_gui.кнопка("test", 100);
        return 1;
        }
        static public System.Func<int> fun_GUI = () => {
        GUILayout.Label(INFO + " " + PRODUCT);
        return test_gui();
        };
        [CustomEditor(typeof(mbLine))]
        public new class gui : Mono.gui
        {
        }
    }
}
