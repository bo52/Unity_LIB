//empty
//empty
//layout.btn
using UnityEngine;
namespace LIB.st2305161151
{
    /// <summary>
    /// 
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// test
        /// </summary>
        static public bool prop230516115100
        {
            get
            {
                return (GUILayout.Button("ТЕСТ"));
            }
        }
        /// <summary>
        /// btnTEST
        /// </summary>
        /// <param name="proc"></param>
        /// <returns></returns>
        static public bool fun230516115101_test(System.Action proc)
        {
            var b = GUILayout.Button("ТЕСТ");
            if (b)
                proc();
            return b;
        }
        /// <summary>
        /// btn
        /// </summary>
        /// <param name="name"></param>
        /// <param name="proc"></param>
        /// <returns></returns>
        static public bool fun230516115102_btn_name(string name = "test", System.Action proc = null)
        {
            var b = GUILayout.Button(name);
            if (b)
                proc?.Invoke();
            return b;
        }
        /// <summary>
        /// кнопка
        /// </summary>
        /// <param name="b"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public bool fun230516115103(bool b, string name = "test")
        {
            return b ? fun230516115104(name) : true;
        }
        /// <summary>
        /// кнопка
        /// </summary>
        /// <param name="name"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        static public bool fun230516115104(string name = "button", ushort width = 100)
        {
            return (GUILayout.Button(name, new GUILayoutOption[] { GUILayout.Width(width) }));
        }
        /// <summary>
        /// кнопка
        /// </summary>
        /// <param name="B"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public bool fun230516115105(ref bool B, string name = "button")
        {
            bool b = (GUILayout.Button(name));
            if (b)
                B = !B;
            return b;
        }
        ///exit
    }
}