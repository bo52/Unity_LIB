//Bo52_17102020101208823.MONO_17102020101208823 ch
//Bo52_16102020101639302.CLASS: Bo52_15102020130526926.CLASS
namespace world2022.ch.block
{
    using utility2022;
    using mb2022;
    using task2022;
    using UnityEngine;
    /// <summary>
    /// ЧАНКИ.БЛОК
    /// блок принадлежит чанку
    /// </summary>
    public class CLASS : World_block
    {
        /// <summary>
        /// определяет что выше или ниже блока нет других блоков
        /// </summary> 
        public ushort НомерТЕКСТУРЫ;
        private Mono CHUNK;
        public IWorld_chunk<CLASS> ЧАНК
        {
            get => (IWorld_chunk<CLASS>)CHUNK;
            set => CHUNK = value as Mono;
        }
        public bool БлокВидим
        {
            get
            {

                if (КодРассчитан == 0)
                    return false;
                if (КодРассчитан == byte.MaxValue)
                    return false;
                //return Bo52_02112020140522454.FUN.БлокВидимИгроку_2d(this)!=-1;
                return true;
            }           
        }
        static public CLASS ЕстьЛокальныйБлок(Mono ch, Vector3Int Вектор_блок)=> IWorld_chunk<CLASS>.ИНТ(ch).БЛОКИ.Найти(Вектор_блок);
        static public CLASS БЛОК(Mono ch, Vector3Int Вектор_блок)
        {
            var CH = IWorld_chunk<CLASS>.ИНТ(ch);
            var b = CH.БЛОКИ.ЭЛЕМЕНТ(Вектор_блок);
            b.ЧАНК = CH;
            return b;
        }
        static public CLASS БЛОК(Mono ch,Vector3 Вектор_блок)
        {
            var b = IWorld_chunk<CLASS>.ИНТ(ch).БЛОКИ.ЭЛЕМЕНТ(Вектор_блок);
            b.CHUNK = ch;
            return b;
        }
        public CLASS(STRUCT str, object obj)
        {
            CHUNK = (Mono)obj;
            КодРассчитан = str.k;
            ИД = str.i;
            СМЕЩЕНИЕ = new Vector3[] { str.x, str.y, str.z };
            КООРДИНАТА = stVector_number_h8.GET_V(ИД);
        }
        public CLASS()
        {

        }
        public CLASS(Mono ch, ulong id, Vector3 v, byte Код = 0) : base(v,id, Код)=>Update(ch);
        public CLASS(Mono ch, ulong id, byte Код=0) : base(id, Код)=>Update(ch);
        public CLASS(Mono ch, Vector3Int v, byte Код) :base(v, Код)=>Update(ch);
        public void Update(Mono ch)
        {
            CHUNK = ch;
            ЧАНК.БЛОКИ.Add(ИД,this);
        }
    }
}
