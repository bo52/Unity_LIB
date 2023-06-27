//empty
//empty
//empty
using UnityEditor;
using UnityEngine;
/// <summary>
/// 
/// </summary>
namespace LIB.cs2305161108
{
    public interface IMono
    {
        uint НомерМира { get; }
        go2305081120.IInspector ОбъектМира { get; set; }
        Object ОбновитьОбъектМира { get; }
    }

    public class Mono : MonoBehaviour, IMono
    {
        [SerializeField]
        public string ID;
        private uint _number;
        public uint НомерМира
        {
            get
            {
                if (_number<1000) _number=(uint)System.Type.GetType("IEditorGUILayoutPopup", false, true).GetField("НомерМира").GetValue("null");
                return _number;
            }
        }
        private go2305081120.IInspector ObjectWorld;
        public bool УжеСуществует => ObjectWorld != null && ObjectWorld.GetType().Name.IndexOf(_number.ToString()) > 0 == true;
        public go2305081120.IInspector ОбъектМира
        {
            get
            {
                if (!УжеСуществует) Object.DestroyImmediate(ObjectWorld as Object);
                return (ObjectWorld == null ? st2305141614.Class.fun230514161404(this) : ObjectWorld);
            }
            set => ObjectWorld = value;
        }
        public virtual Object ОбновитьОбъектМира => ОбъектМира as Object;
        public Object ИзменитьМир(uint Number) { _number = Number; return ОбновитьОбъектМира; }
        [CustomEditor(typeof(Mono))]
        public class gui : Editor
        {
            //Манипуляция в Событии на Сцене OnSceneGUI
            public virtual void OnSceneGUI()
            {
                if (target is IMono)
                {
                    Repaint();
                    ((IMono)target).ОбъектМира?.СЦЕНА.Выполнить();
                }
            }
            //Манипуляция в Событии в Инспекторе OnInspectorGUI
            public override void OnInspectorGUI()
            {
                if (target is IMono)
                {
                    DrawDefaultInspector();
                    ((IMono)target).ОбъектМира?.Выполнить();
                }
            }
        }
    }
}
