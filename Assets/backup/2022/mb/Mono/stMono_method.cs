using UnityEngine;
namespace mb2022
{
    using utility2022;
    static public class stMono_method
    {
        static public object ��������������(this MonoBehaviour mb, string name, object[] args = null) => mb.GetType().GetMethod(name).Invoke(mb, args);
        static public object ��������������(this MonoBehaviour mb, string name, object arg) => ��������������(mb, name, new object[] { arg });
        static public T ��������������<T>(this MonoBehaviour mb, string name, object[] args = null) => (T)��������������(mb, name, args);
        static public Vector3Int �������������(this Mono mb) => stVector_min_max.GET_V(mb.ID);
    }
}