using UnityEngine;
namespace mb2022
{
    using utility2022;
    static public class stMono_method
    {
        static public object ВыполнитьМетод(this MonoBehaviour mb, string name, object[] args = null) => mb.GetType().GetMethod(name).Invoke(mb, args);
        static public object ВыполнитьМетод(this MonoBehaviour mb, string name, object arg) => ВыполнитьМетод(mb, name, new object[] { arg });
        static public T ВыполнитьМетод<T>(this MonoBehaviour mb, string name, object[] args = null) => (T)ВыполнитьМетод(mb, name, args);
        static public Vector3Int ВекторРегиона(this Mono mb) => stVector_min_max.GET_V(mb.ID);
    }
}