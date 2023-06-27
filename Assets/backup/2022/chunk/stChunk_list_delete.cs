//Bo52_23102020124632493.FUN.
namespace chunk2022
{
    using go2022;
    static public class stChunk_list_delete
    {
        static public string INFO = "ЧАНКИ.УПРАВЛЕНИЕ.УДАЛИТЬ";
        static public string PRODUCT = "удалить все ЧАНКИ из Мира";
        static public void УдалитьОбъектыЧанковИзМира()=>stGameObject.УдалениеОбъектов(stGameObject.CHUNKS.GO.transform);

        static public void УдалитьВсеЧанкиИзМира(bool кнопка)
        {
            if (!(кнопка ? stButton_gui.кнопка("CLEAR", 100) : true))
                return;
            stGameObject.ЧАНКИ.Clear();
            УдалитьОбъектыЧанковИзМира();
        }
    }
}
