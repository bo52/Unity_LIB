using UnityEngine;
namespace scr2022
{
    static public class stMono_prop
    {
        static public object[] ��(this MonoBehaviour mb, string name)
        {
            return (object[])mb.GetType().GetProperty(name).GetValue(mb);
        }
        static public string �������(this MonoBehaviour mb, string name)
        {
            return (string)mb.GetType().GetProperty(name).GetValue(mb);
        }
    }
}