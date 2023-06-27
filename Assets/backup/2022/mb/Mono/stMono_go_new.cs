using UnityEngine;
namespace LIB
{
    using utility2022;
    /// <summary>
    /// ����� ���������� GameObject �� �����
    /// </summary>
    static public class stMono_go_new
    {
        static public string INFO = "GameObject.NEW";
        static public GameObject ������������������(this Mono mb, System.Type T, bool ������ = false, string id = "")
        {
            var arg = new object[] { T, mb.gameObject, id, mb };
            return stButton_fun_new.�����(������, arg);
        }
        static public GameObject method_new(object[] arg)
        {
            var t = (System.Type)(arg?[0]);
            var p = (GameObject)(arg?[1]);
            var id = (string)(arg?[2]);
            return �����(arg, t, p, id);
        }
        static public GameObject �����(object[] arg, System.Type t = null, GameObject p = null, string ID = "")
        {
            GameObject go = new GameObject();
            if (ID == "")
                ID = st2305211638.CLASS.fun230521163800();
            go.name = ID;

            if (p != null)
            {
                go.transform.parent = p.transform;
            }
            if (t != null)
            {
                var mono = (Mono)go.AddComponent(t);
                mono.ID = ID;
                go.name += "(" + mono.�������������() + ")";
                mono.���������������(null, arg);
            }
            return go;
        }
    }
}
