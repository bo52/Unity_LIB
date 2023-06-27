using UnityEngine;
namespace scr2022
{
    using class2022;
    static public class stMono_component
    {
        static public T ДругойМоноКомпонент<T>(this MonoBehaviour mb) where T : Component
        {
            var s = mb.gameObject.GetComponent<T>();
            if (s == null)
                s = mb.gameObject.AddComponent<T>();
            return s;
        }
        static public T МоноМодуль<T>(this MonoBehaviour mb) => mb.ИгровойОбъект().GetComponent<T>();
        static public Component МоноМодуль(this MonoBehaviour mb, System.Type T) => mb.ИгровойОбъект().GetComponent(T);
    }
}