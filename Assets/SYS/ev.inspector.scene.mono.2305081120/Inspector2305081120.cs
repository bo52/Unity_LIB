//empty
//empty
//empty
using UnityEngine;
/// <summary>
/// 
/// </summary>
namespace LIB.go2305081120
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInspector : go2305082132.IInspector
    {
        cs2307031414_Default.IClass Объект { get; set; }
        IScene СЦЕНА { get; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Inspector : go2305082132.Inspector, IInspector
    {
        public IScene СЦЕНА => объектСЦЕНА as IScene;
        private object Scene;

        private cs2307031414_Default.IClass _obj; public cs2307031414_Default.IClass Объект { get=> _obj; set=> _obj=value; }
        public object объектСЦЕНА
        {
            get
            {
                if (Scene == null) Scene = st2305141614.Class.fun230514161403(this, "Scene");
                return Scene;
            }
        }
        public override bool Выполнить()
        {
            Объект?.ИнтерфейсПоУмолчанию();
            GUILayout.Label("КлассМира=" + this.GetType().ToString());
            return base.Выполнить();
        }
    }
}
