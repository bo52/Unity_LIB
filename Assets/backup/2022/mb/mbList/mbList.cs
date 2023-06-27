using System.Collections.Generic;
namespace mb2022
{
    /// <summary>
    /// LIST
    /// список префабов абстрактного класса
    /// </summary>
    public class mbList : List<Mono>
    {
        public bool ПоследняяПроверкаСуществованияЭлемента = false;
        public Mono PARENT;
        public mbList(Mono parent) => PARENT = parent;
    }
}
