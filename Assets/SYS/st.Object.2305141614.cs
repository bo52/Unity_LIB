//empty
//empty
//empty
using UnityEngine;
/// <summary>
/// stObject
/// </summary>
namespace LIB.st2305141614
{
    /// <summary>
    /// stObject
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// СоздатьОбъектПоИмени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public object fun230514161402_СоздатьОбъектПоИмени(this string name)
        {
            System.Type TestType = System.Type.GetType(name, false, true);
            //если класс не найден
            if (TestType == null) return null;
            //получаем конструктор
            System.Reflection.ConstructorInfo ci = TestType.GetConstructor(new System.Type[] { });

            //вызываем конструтор
            var obj = ci.Invoke(new object[] { });
            return obj;
        }
        /// <summary>
        /// СоздатьОбъектПоИмени
        /// </summary>
        /// <param name="INS"></param>
        /// <param name="ev"></param>
        /// <returns></returns>
        static public object fun230514161403(go2305081120.IInspector INS, string ev)
        {
            var mb = INS.Моно as cs2305161108.IMono;
            var obj = fun230514161402_СоздатьОбъектПоИмени("LIB.go" + mb.НомерМира.ToString() + "." + ev);
            (obj as go2305081120.IEvent).ОбъктМира = INS;
            return obj;
        }
        /// <summary>
        /// СоздатьОбъектПоИмени(Инспектор)
        /// </summary>
        /// <param name="mb"></param>
        /// <returns></returns>
        static public go2305081120.IInspector fun230514161404(cs2305161108.IMono mb)
        {
                var obj = fun230514161402_СоздатьОбъектПоИмени("LIB.go" + mb.НомерМира.ToString() + ".Inspector");
                mb.ОбъектМира = obj as go2305081120.IInspector;
                mb.ОбъектМира.Моно = mb as MonoBehaviour;
                return mb.ОбъектМира;
        }
        /// <summary>
        /// СоздатьИгровойОбъект
        /// </summary>
        /// <param name="number"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        static public cs2305161108.Mono fun230514161406(uint number, GameObject p = null)
        {
            var go = new GameObject();
            go.transform.SetParent(p == null ? st2306251639.Class.prop230625163901_ОбъектКореньМира.transform : p.transform);
            var scr = go.AddComponent<cs2305161108.Mono>();
            return scr;
        }
        ///exit
    }
}