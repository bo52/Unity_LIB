//empty
//empty
//empty
using UnityEngine;
namespace LIB.st2305071640
{
    /// <summary>
    /// stExample.method
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// ДобавитьМоноИгровойОбъект
        /// </summary>
        /// <param name="go"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        static public Mono fun230507164000(this GameObject go, System.Type t)
        {
            var comp = go.GetComponent(t);
            if (comp == null)
                comp = go.AddComponent(t);
            return (Mono)comp;
        }
        /// <summary>
        /// ДобавитьМоноИгровойОбъект
        /// </summary>
        /// <param name="go"></param>
        /// <returns></returns>
        static public Mono fun230507164001(this GameObject go)
        {
            System.Type t = System.Type.GetType(go.ПолноеИмяТипа());
            if (t == null)
                return null;
            return fun230507164000(go, t);
        }
        /// <summary>
        /// ВыполнитьМетод
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="name"></param>
        /// <param name="args"></param>
        static public void fun230507164002(this object obj, string name, object[] args = null) => obj.GetType().GetMethod(name).Invoke(obj, args);
        /// <summary>
        /// ВыполнитьМетод
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="name"></param>
        /// <param name="arg"></param>
        static public void fun230507164003(this object obj, string name, object arg = null) => obj.GetType().GetMethod(name).Invoke(obj, new object[] { arg });
        ///exit
    }
}