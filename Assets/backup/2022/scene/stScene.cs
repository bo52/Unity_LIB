using UnityEngine.SceneManagement;

namespace scene2022
{
    using go2022;
    static public class stScene
    {
        static public string ѕространство“екущей—цены
        {
            get
            {
                var s = SceneManager.GetActiveScene().name;
                var id = s.Substring(s.IndexOf("_") + 1);
                return "Bo52_" + id + ".SCENE";
            }
        }

        static public System.Type  ласс“екущей—цены
        {
            get
            {
                var s = SceneManager.GetActiveScene().name;
                var id = s.Substring(s.IndexOf("_") + 1);
                return System.Type.GetType("Bo52_" + id + ".SCENE.unity_" + id);
            }
        }
        static public GAMEOBJECT ќбъект—цены(string »м€) => System.Type.GetType(ѕространство“екущей—цены + ".WORLD").GetField(»м€).GetValue(null) as GAMEOBJECT;


    }
}