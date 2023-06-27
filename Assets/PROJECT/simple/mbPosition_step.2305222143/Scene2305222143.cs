//empty
//empty
//empty
using UnityEngine;
namespace LIB.go2305222143
{
    public interface IScene:go2305081120.IScene
    {
        Vector3 Координата { get; set; }
        byte ОтступОкругления { get; }
    }
    public class Scene : go2305081120.Scene, IScene
    {
        private byte _step = 10; public byte ОтступОкругления=>_step;
        public Vector3 _v = Vector3.zero; public Vector3 Координата { get => _v; set => _v = value; }
        public void Вектор_отступ_обновить()
        {
            Координата = ОбъктМира.Моно.gameObject.transform.position / _step;
            Координата = _step * st2305211530.Class.fun230521153001(Координата);
            ОбъктМира.Моно.gameObject.transform.position = Координата + 0.5f * _step * Vector3.one;
        }
        public override void event_MouseMove()
        {
            Вектор_отступ_обновить();
        }
    }
}
