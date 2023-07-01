//empty
//empty
//empty
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
        static class Классы
        {
            public static cs2305071643_Default.IClass X = new cs2307011306_ТекстураЗемли.Class() as cs2305071643_Default.IClass;
        }
        override public bool Выполнить()
        {
            Классы.X.ИнтерфейсПоУмолчанию(Моно.gameObject);
            return base.Выполнить();
        }
    }
}
