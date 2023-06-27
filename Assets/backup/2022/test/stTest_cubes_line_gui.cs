//Bo52_31012021194659952.DRAWUI.GUI.
namespace test2022
{
    using UnityEngine;
    using task2022;
    /// <summary>
    /// куб
    /// создать куб на сцене
    /// </summary>
    static public class stTest_cubes_line_gui
    {
        static public void СоздатьКубНаСцене()
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localScale = new Vector3(3, 1, 1);
            cube.transform.position = new Vector3(0, 0, 0);

            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube2.transform.localScale = new Vector3(3, 1, 1);
            cube2.transform.position = new Vector3(0, 5, 0);

            cube.AddComponent<mbLine>();
            mbLine.Создать(cube, cube2);
        }
        static public int test_gui()
        {
            if (!stButton_gui.кнопка("test", 100))
                return 0;
            СоздатьКубНаСцене();
            return 1;
        }
    }
}
