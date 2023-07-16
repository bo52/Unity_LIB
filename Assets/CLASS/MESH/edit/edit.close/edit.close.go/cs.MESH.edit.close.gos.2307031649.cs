//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2307031649
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2306291123.IClass
    {
        Vector3 КоординатаЧанка { get; set; }
        GameObject Child { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2306291123.Class, IClass
    {
        static new public string INFO = "INFO";
        private GameObject _child; public GameObject Child => _child;
        private Vector3 _ch_v = Vector3.zero; public Vector3 КоординатаЧанка { get => _ch_v; set => _ch_v = value; }
        public Class(GameObject go, cs2307031203_ПараметрыПостройки.Struct param_build) : base(go, param_build)
        {
            st2305221205.Class.fun230522120502_УдалениеДочернихОбъектов(go.transform);
        }
        private GameObject Новый
        {
            get
            {
                _child = new GameObject();
                _child.transform.parent = GO.transform;
                _child.transform.position = КоординатаЧанка;
                return _child;
            }
        }
        public override Mesh Закрыть() => Привязать(Новый);
    }
}
