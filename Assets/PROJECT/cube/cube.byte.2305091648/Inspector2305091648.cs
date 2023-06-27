//empty
//empty
//empty
namespace LIB.go2305091648
{
    public interface IInspector : go2305081120.IInspector
    {
        new IScene СЦЕНА { get; }
        byte КодБлока {get; set; }
        cs2305141202.Class РЕДАКТОР {get;}
        void Земля() 
        {
            КодБлока = 51;
            фун(51);
        }
        void фун(byte b) => РЕДАКТОР.СобратьВертекс(b);
    }
    public class Inspector : go2305081120.Inspector, IInspector
    {
        new public IScene СЦЕНА => объектСЦЕНА as IScene;
        private cs2305141202.Class _edit; public cs2305141202.Class РЕДАКТОР => field(ref _edit,new object[] { Моно.gameObject });
        private byte _code = 0;public byte КодБлока{get => _code;set => _code = value;}
        override public bool Выполнить()
        {
            base.Выполнить();
            st2305161151.Class.fun230516115102_btn_name("построить землю", (this as IInspector).Земля);
            st2305141358.Class.fun230514135802(ref _code, 0, 255, (this as IInspector).фун);
            return false;
        }
    }
}
