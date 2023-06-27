using UnityEngine;
namespace scr2022
{
    using class2022;
    static public class stMono_component
    {
        static public T �������������������<T>(this MonoBehaviour mb) where T : Component
        {
            var s = mb.gameObject.GetComponent<T>();
            if (s == null)
                s = mb.gameObject.AddComponent<T>();
            return s;
        }
        static public T ����������<T>(this MonoBehaviour mb) => mb.�������������().GetComponent<T>();
        static public Component ����������(this MonoBehaviour mb, System.Type T) => mb.�������������().GetComponent(T);
    }
}