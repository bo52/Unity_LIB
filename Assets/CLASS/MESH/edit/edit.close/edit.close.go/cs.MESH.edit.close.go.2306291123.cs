//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2306291123
{
    /// <summary>
    /// MESH с GO
    /// </summary>
    public interface IClass : cs2305141208.IClass
    {
        GameObject GO { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class: cs2305141208.Class,IClass
    {
        static public string INFO = "INFO";
        private GameObject _go; public GameObject GO => _go;
        public Class(GameObject go, cs2305141208.Class.ПараметрыПостройки param_build) :base(param_build) => this._go = go;
        public override Mesh Закрыть()
        {
            var M = base.Закрыть();
            st2305072046.Class.fun230507204600_ПривязатьМешКОбъекту(M, GO);
            return M;
        }
    }
}
