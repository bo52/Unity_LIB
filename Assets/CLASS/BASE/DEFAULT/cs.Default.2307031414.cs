//empty
//empty
//empty
namespace LIB.cs2307031414_Default
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
        string ИмяКнопки { get; }
        void Выполнить();
        bool ИнтерфейсПоУмолчанию();
        bool СценаПоУмолчанию();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : IClass
    {
        static public string INFO = "INFO";
        public virtual string ИмяКнопки => "ВЫПОЛНИТЬ";
        public virtual void Выполнить() => this.GetType().GetMethod(ИмяКнопки)?.Invoke(this,new object[] { }); 
        public virtual bool ИнтерфейсПоУмолчанию()
        {
            return st2305161151.Class.fun230516115102_btn_name(ИмяКнопки, Выполнить);
        }
        public virtual bool СценаПоУмолчанию() => false;
        public T СоздатьЭкземпляр<T>(IClass obj) where T : class => st2307091409.Class.fun230709140901_СоздатьЭкземпляр<T>(obj);
    }
}
