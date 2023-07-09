//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2307091511
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2307031414_Default.IClass
    {
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307031414_Default.Class, IClass
    {
        static new public string INFO = "INFO";
        private byte РазмерРедактора = 8;
        private Vector3 Координата = Vector3.zero;
        private cs2307051313_Словарь_Ulong.IClass Блоки;
        public Class(object Блоки)
        {
            this.Блоки = Блоки as cs2307051313_Словарь_Ulong.IClass;
        } 
        public bool ПоказатьРедакторБлоков()
        {
            cs2307081134_Координата3.Struct Координата3;
            bool b;
            var Перестроить = false;
            for (var x = 0; x < РазмерРедактора; x++)
                for (var y = 0; y < РазмерРедактора; y++)
                    for (var z = 0; z < РазмерРедактора; z++)
                    {
                        Координата3 = new cs2307081134_Координата3.Struct(Координата + new Vector3(x, y, z));

                        b = Блоки.Существует(Координата3.id);
                        if (st2305231603.Class.fun230523160307(b, Координата3.v))
                        {
                            switch (b)
                            {
                                //добавить
                                case false: 
                                    Блоки.Добавить3<cs2307061154_ЦветнойБлок.Class>(Координата3); 
                                    break;
                                //удалить
                                case true: 
                                    Блоки.Remove(Координата3.id); 
                                    break;
                            }
                            Перестроить = true;
                        }
                    }
            return Перестроить;
        }
        public override bool СценаПоУмолчанию()
        {
            return ПоказатьРедакторБлоков();
        }
    }
}
