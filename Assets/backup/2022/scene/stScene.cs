using UnityEngine.SceneManagement;

namespace scene2022
{
    using go2022;
    static public class stScene
    {
        static public string ������������������������
        {
            get
            {
                var s = SceneManager.GetActiveScene().name;
                var id = s.Substring(s.IndexOf("_") + 1);
                return "Bo52_" + id + ".SCENE";
            }
        }

        static public System.Type �����������������
        {
            get
            {
                var s = SceneManager.GetActiveScene().name;
                var id = s.Substring(s.IndexOf("_") + 1);
                return System.Type.GetType("Bo52_" + id + ".SCENE.unity_" + id);
            }
        }
        static public GAMEOBJECT �����������(string ���) => System.Type.GetType(������������������������ + ".WORLD").GetField(���).GetValue(null) as GAMEOBJECT;


    }
}