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
            public static string ОдинЧанкЗемлиПоУмолчанию51 = cs2306282238.Class.INFO;
            public static string Выбранный = ОдинЧанкЗемлиПоУмолчанию51;
            public static cs2306301501.IDefault X = st2305141614.Class.fun230514161402_СоздатьОбъектПоИмени(ОдинЧанкЗемлиПоУмолчанию51) as cs2306301501.IDefault;
        }
        override public bool Выполнить()
        {
            Классы.X.ИнтерфейсПоУмолчанию(Моно.gameObject);
            return base.Выполнить();
        }
    }
}
