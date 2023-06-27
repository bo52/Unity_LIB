//Bo52_22112020165759438.CLASS.
namespace task2022
{
    using dictionary2022;
    using utility2022;
    using UnityEngine;
    /// <summary>
    /// CHUNK.MAP
    /// карта ЧАНКОВ
    /// </summary>
    public class stChunks_map
    {
        static public ushort РазмерКарты = 1000;
        static public ushort ГлубинаКарты = 100;
        static public DICTIONARY_xml<uint> КартаЧанков = new DICTIONARY_xml<uint>();
        static public string ФАЙЛ=>Application.dataPath + " /chs";
        public enum enNames
        {
            Блок=0,
            Поверхность=1,
        };
        static public ulong Координата(Vector3Int v)=>stVector_min_max.GET_ID(v, РазмерКарты, РазмерКарты);
        static public Vector3 Координата(ulong id)=>stVector_min_max.GET_V(id, РазмерКарты, РазмерКарты);
        public stChunks_map()
        {
        //code
        }
        static public void ПерестроитьКартуПоУмолчанию()
        {
            КартаЧанков.Clear();
            for (var x = -РазмерКарты; x<= РазмерКарты; x++)
                for (var z = -РазмерКарты; z <= РазмерКарты; z++)
                    for (var y = -РазмерКарты; y <= 0; y++)
                    {
                        ulong id = Координата(new Vector3Int(x, y, z));
                        КартаЧанков.Add(id, (uint)(y == 0 ? 1 : 0));
                    }
            КартаЧанков.Сохранить(ФАЙЛ);
            Debug.Log("Карта была перестроена заново по умолчанию !!! " + РазмерКарты);
        }
    }
}
