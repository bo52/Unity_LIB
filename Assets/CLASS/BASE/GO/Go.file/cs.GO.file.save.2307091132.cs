//empty
//empty
//empty
namespace LIB.cs2307091132_GO_file_save
{
    /// <summary>
    /// СохранениеИгровогоОбъекта
    /// </summary>
    public interface IClass: cs2307031414_Default.IClass
    {
        void СохранитьЧанк();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307031414_Default.Class, IClass
    {
        static new public string INFO = "INFO";
        private cs2307091136_GO_file.IClass РаботаСФайлом;
        public void СохранитьЧанк() => st2305161716.Class.fun230516171606_ПереСохранитьМешОбъектаИменем(РаботаСФайлом.GO.ИгровойОбъект, РаботаСФайлом.ФайлИгровогоОбъекта);
        public Class(cs2307091136_GO_file.IClass go)
        {
            РаботаСФайлом = go;
        }
        public override string ИмяКнопки => "СохранитьЧанк";
    }
}
