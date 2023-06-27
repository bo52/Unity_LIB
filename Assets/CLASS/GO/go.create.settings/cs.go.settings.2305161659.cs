//empty
//Stat.scene.go.create.settings
//GAMEOBJECT_settings : simple.GAMEOBJECT_simple
using LIB.cs2305161704;
namespace LIB.cs2305161659
{
    /// <summary>
    /// go.settings
    /// </summary>
    public class Class : cs2305161704.Class
    {
        static public new string INFO = "CLASS";
        static public new string PRODUCT = "Игровой Объект на Сцене";
        public void НастроитьИгровойОбъект()
        {
            #region для new и reload объекта
            GO.name = gName;
            GO.transform.parent = РОДИТЕЛЬ == null ? Mono.CONTENT.transform : РОДИТЕЛЬ.GO.transform;
            #endregion
        }
    }
}
