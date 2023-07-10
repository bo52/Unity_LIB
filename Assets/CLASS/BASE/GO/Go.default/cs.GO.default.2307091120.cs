//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2307091120_ИгровойОбъект
{
    /// <summary>
    /// Класс содержит игровой объект
    /// </summary>
    public interface IClass : cs2307031414_Default.IClass
    {
        GameObject ИгровойОбъект { get; }
        GameObject НовыйИгровойОбъект { get; }
        cs2307091136_ИгровойОбъектФайл.IClass РаботаСФайлом { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class<TFILE> : cs2307031414_Default.Class, IClass where TFILE : cs2307091136_ИгровойОбъектФайл.Class, new()
    {
        static new public string INFO = "INFO";
        public virtual string ИмяИгровогоОбъекта => "empty";
        private GameObject _go;
        private GameObject _parent = null;
        private cs2307091136_ИгровойОбъектФайл.IClass _file; public cs2307091136_ИгровойОбъектФайл.IClass РаботаСФайлом => _file;
        public Class()
        {
        }
        public Class(GameObject p)
        {
            _parent = p;
            _file = st2307091409.Class.fun230709140901_СоздатьЭкземпляр<TFILE>(this);
        }
        public virtual GameObject НовыйИгровойОбъект => st2306251639_ROOT.Class.prop230625163904_НовыйОбъектВКорнеМира(ИмяИгровогоОбъекта, _parent);
        public virtual GameObject ИгровойОбъект
        {
            get
            {
                if (_go == null)
                {
                    _go = GameObject.Find(ИмяИгровогоОбъекта);
                    if (_go == null)
                    {
                        _go = НовыйИгровойОбъект;
                    }
                }
                return _go;
            }
        }
        public override bool ИнтерфейсПоУмолчанию()
        {
            _file.ИнтерфейсПоУмолчанию();
            return base.ИнтерфейсПоУмолчанию();
        }
    }
}
