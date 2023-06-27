//using Bo52.constr.PROJ.CLASS;
//Bo52_1804202111532986.Cube.MONO_1804202111532986.
//Bo52_1804202111532986.Cube.MONO
//SCENE.Prefab.MONO
//Cube_1804202111532986
//gui_1804202111532986
namespace task2022
{
    using UnityEditor;
    /// <summary>
    /// PREFAB
    /// префаб КУБ на сцене для Region,Chunk
    /// </summary>
    public class mbPrefab_cube : mbPrefab
    {
        public byte LEVEL = 0;
        public byte H = 3;
        public byte РАДИУС = 10;
        public byte Радиус => (byte)(РАДИУС - 1);
        public byte MAX => (byte)(РАДИУС + 1);
    }
    [CustomEditor(typeof(mbPrefab_cube))]
    public class gui : mbPrefab.gui
    {
    }
}
