//empty
//empty
//смещение объекта mbPosition_step : MonoBehaviour
using UnityEngine;
namespace LIB.go2305211505
{
    /// <summary>
    /// mbPosition_step : MonoBehaviour
    /// </summary>
    public interface IScene : go2305081120.IScene
    {
        bool ЭтоРаботает{ get; set; }
        void ИзменитьРаботу();
        void ПоказатьРаботу();
    }
    public class Scene : go2305081120.Scene, go2305081120.IScene
    {
        private bool active = true; public bool ЭтоРаботает { get=> active; set=>active=value; }
        public void ИзменитьРаботу()
        {
            st2305211538.Class.fun230521153800(ref active, "Активен");
        }
        public void ПоказатьРаботу()
        {
            if (active) GUILayout.Label("Координата=" + Координата);
        }
        /// <summary>
        /// Выполнить. после изменения координыты
        /// </summary>
        public System.Action<Vector3> fun2305211512;
        public float step = 1;
        public Vector3 Координата = Vector3.zero;
        public Vector3 Смещение => 0.5f * step * Vector3.one;
        public Vector3 КоординатаОбъекта(Vector3 v) => v /*+Смещение*/;
        public Vector3 ТекКоординатаОбъекта => КоординатаОбъекта(Координата);
        public void Вектор_отступ_обновить()
        {
            var к = ОбъктМира.Моно.gameObject.transform.position / step;
            к = step * st2305211530.Class.fun230521153001(к);
            Координата = к;
            fun2305211512?.Invoke(Координата);
            ОбъктМира.Моно.gameObject.transform.position = КоординатаОбъекта(к);
        }
        public override void event_MouseUp()
        {
            if (active) Вектор_отступ_обновить();
        }
    }
}
