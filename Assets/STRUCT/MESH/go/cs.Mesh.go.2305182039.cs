//empty
//empty
//структура из Меш и Go (без файла)
using UnityEngine;
namespace LIB.cs2305182039
{
    /// <summary>
    ///
    /// </summary>
    public struct Class
    {
        static public string INFO = "INFO";
        public GameObject go;
        public Mesh m;
        public Class(Mesh m, GameObject go = null)
        {
            this.m = m;
            this.go = go;
        }
        public void Связать() => st2305072046.Class.fun230507204600_ПривязатьМешКОбъекту(m, go);
    }
}