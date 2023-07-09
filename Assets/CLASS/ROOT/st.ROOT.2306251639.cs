//empty
//empty
//empty
using UnityEngine;
namespace LIB.st2306251639_ROOT
{
    /// <summary>
    /// Корень МИРА
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// Root
        /// </summary>
        static private GameObject field230625163902_ROOT;
        /// <summary>
        /// ИгровойКорень
        /// </summary>
        static public GameObject prop230625163901_ОбъектКореньМира
        {
            get
            {
                if (field230625163902_ROOT == null) field230625163902_ROOT = GameObject.Find("Root");
                return field230625163902_ROOT;
            }
        }
        /// <summary>
        ///
        /// </summary>
        static public void fun230625163903_ОчиститьКореньМира()
        {
            st2305221205.Class.fun230522120502_УдалениеДочернихОбъектов(prop230625163901_ОбъектКореньМира.transform);
        }
        /// <summary>
        /// 
        /// </summary>
        static public GameObject prop230625163904_НовыйОбъектВКорнеМира(string name = "empty",GameObject Родитель=null)
        {
            GameObject go = new GameObject();
            go.transform.SetParent(Родитель == null?prop230625163901_ОбъектКореньМира.transform: Родитель.transform);
            go.name = name;
            return go;
        }
        ///exit
    }
}
