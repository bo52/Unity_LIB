using UnityEngine;
namespace scr2022
{
    static public class stMono_field
    {
        static public object ����(this MonoBehaviour mb, string name) => mb.GetType().GetField(name).GetValue(mb);
        static public string ���������(this MonoBehaviour mb, string name) => (string)mb.����(name);
    }
}