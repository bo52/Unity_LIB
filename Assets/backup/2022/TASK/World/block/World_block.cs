//namespace Bo52_15102020130526926
//Bo52_15102020130526926.CLASS: Bo52_1510202013173769.CLASS
namespace task2022
{
    using utility2022;
    using UnityEngine;
    /// <summary>
    /// БЛОК.простой
    /// Простой блок в мире
    /// </summary>
    public class World_block: World_vertex
    {
        [SerializeField]
        public byte КодРассчитан;
        public bool[] РазложенныйКОД=>stCube256_vertex8_number.GET_V(КодРассчитан);
        public World_block()
        {
        }
        public World_block(ulong id, byte Код) : base(id)=>Update(Код);
        public World_block(Vector3 v, ulong id, byte Код) : base(id,v)=>Update(Код);
        public World_block(Vector3 v, byte Код):base(v)=>Update(Код);
        public void Update(byte Код)=>КодРассчитан = Код;
    }
}
