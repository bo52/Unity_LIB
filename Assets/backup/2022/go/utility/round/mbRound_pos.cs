//Bo52_10022021160326311.MONO.STAT_10022021160326311
namespace mb2022
{
    using UnityEngine;
    using UnityEditor;
    /// <summary>
    /// MOVE.INT
    /// округлить положение объекта
    /// </summary>
    public class mbRound_pos : Mono
    {
        public byte N = 1;
        [SerializeField]
        public System.Action A;
        public Vector3 Округлить
        {
            get
            {
                var v = gameObject.transform.position / N;
                return N * utility2022.stVector_round_221219.ОкруглитьВектор(v) + 0.5f * (N - 1) * Vector3.one;
            }
        }
        public Vector3Int ВекторРегиона
        {
            get
            {
                var v = gameObject.transform.position;
                v -= 0.5f * (N - 1) * Vector3.one;
                //v/= N;
                return new Vector3Int((int)v.x, (int)v.y, (int)v.z);
            }

        }
        public void Refresh()
        {
            gameObject.transform.position = Округлить;
            gameObject.GetComponent<mbRound_pos>().A?.Invoke();
        }
        [CustomEditor(typeof(mbRound_pos))]
        public new class gui : Mono.gui
        {
            public override void event_MouseUp()=>((mbRound_pos)target).Refresh();
        }
    }
    
}