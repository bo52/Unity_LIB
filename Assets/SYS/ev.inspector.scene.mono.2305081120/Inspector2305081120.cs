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
    IScene СЦЕНА { get; }
}
/// <summary>
/// 
/// </summary>
public class Inspector : go2305082132.Inspector, IInspector
{
    public IScene СЦЕНА => объектСЦЕНА as IScene;
    private Object Scene;
    public Object объектСЦЕНА
    {
        get
        {
            if (Scene == null) Scene = st2305141614.Class.fun230514161403(this,"Scene");
            return Scene;
        }
    }
    public override bool Выполнить()
    {
        GUILayout.Label("КлассМира=" + this.GetType().ToString());
        return base.Выполнить();
    }
}
}
