//empty
//empty
//empty
using UnityEngine;

namespace LIB.go2306252014
{
    public interface IInspector : go2305081120.IInspector
    {
        new IScene СЦЕНА { get; }
    }
    /// <summary>
    /// Список Миров
    /// </summary>
    public class Inspector : go2305081120.Inspector, IInspector
    {
        new public IScene СЦЕНА => объектСЦЕНА as IScene;
        //private cs2307051626_ЗЕМЛЯ.IClass ЗЕМЛЯ;
        public override bool Тест()
        {
            st2306241300.Class.fun230624130000_НоваяТрехМернаяАльфаТекстура();
            return false;
        }
        public Inspector()
        {
            //ЗЕМЛЯ = new cs2307051626_ЗЕМЛЯ.Class();
        }
    }
}
