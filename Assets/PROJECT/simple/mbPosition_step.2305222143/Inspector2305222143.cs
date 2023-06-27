//empty
//empty
//mbPosition_step
using UnityEngine;
namespace LIB.go2305222143
{
    public interface IInspector: go2305081120.IInspector
    {
        new IScene СЦЕНА { get; }
    }
    /// <summary>
    /// mbPosition_step
    /// </summary>
    public class Inspector: go2305081120.Inspector, IInspector
    {
        private bool active = true;
        new public IScene СЦЕНА => объектСЦЕНА as IScene;
        override public bool Выполнить()
        {
            st2305211538.Class.fun230521153800(ref active, "Активен");
            if (active)
            {
                GUILayout.Label("Координата=" + СЦЕНА.Координата);
                GUILayout.Label("ОтступОкругления=" + СЦЕНА.ОтступОкругления);
            }
            return base.Выполнить();
        }
    }
}
