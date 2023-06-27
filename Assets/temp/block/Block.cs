using System.Collections.Generic;
using UnityEngine;
namespace block2023
{
    using cube2023;
    using utility2023;

    public class Block : IBlock
    {
        private byte code = 0;
        private Dictionary<ulong, IBlock> map;
        private stVector_ulong_data координата;
        #region IBlock
        public stVector_ulong_data Координата => координата;
        public byte Код
        {
            get => code;
            set => code = value;
        }
        public bool существует => Код.ПервыйИндексКодаСуществует();
        public Dictionary<ulong, IBlock> Карта => map;
        #endregion
        public Block(Vector3 v, ulong id, Dictionary<ulong, IBlock> map, byte code = 0)
        {
            this.map = map;
            координата = new stVector_ulong_data(v, id);
            Код = code;
            map.Add(координата.ид, this);
            //работа с соедями
        }
        public void ИзменитьКод()
        {
            this.ОбновитьСоседейПоКоординатеБлока();
        }
    }
}