//empty
//empty
//empty
using UnityEngine;
namespace LIB.go2305221347
{
    public interface IInspector: go2305081120.IInspector
    {
        Texture3D СобранныеТочки { get; }
        new IScene СЦЕНА { get; }
    }
    public class Inspector : go2305081120.Inspector, IInspector
    {
        static byte MAX => st2305221401.Class.field230522140100;
        private Texture3D _points = new Texture3D(MAX, MAX, MAX, TextureFormat.ARGB32, false) ;public Texture3D СобранныеТочки => _points;

        new public IScene СЦЕНА => объектСЦЕНА as IScene;
        override public bool Выполнить()
        {
            st2305221410.Class.fun230522141011(this,0);
            return base.Выполнить();
        }
}
}
