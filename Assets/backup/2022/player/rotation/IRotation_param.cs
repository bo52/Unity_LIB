using UnityEngine;
namespace mb2022
{
    public interface IRotation_param
    {
        #region pov
        /// <summary>
        /// текущий индекс строки массива "копки движений" игрока от 0 до 3
        /// </summary>
        static public sbyte pov = 0;
        static public byte СТОРОНА
        {
            get
            {
                switch (pov)
                {
                    case 0: return 4;
                    case 1: return 1;
                    case 2: return 5;
                    case 3: return 0;
                }
                return 4;
            }
        }
        #endregion
        /// <summary>
        /// индексы поворота влево и вправо
        /// </summary>
        static public readonly sbyte[] НаправлениеПоворота = new sbyte[2] { -1, +1 };
        /// <summary>
        /// кнопки поворота влево и вправо
        /// </summary>
        static public readonly string[] КнопкиПоворота = new string[2] { "e", "q" };
        static public readonly Vector3[] ВекторыПоворота = new Vector3[4] {
            new Vector3(1, 0, 0),
            new Vector3(0, 0, 1),
            new Vector3(1, 0, 0),
            new Vector3(0, 0, 1),
        };
        /// <summary>
        /// текущее значение из массива НаправлениеПоворота
        /// определяет правильное направление при повороте
        /// </summary>
        static public sbyte b_root = 1;
        static public bool НачатПоворот = false;
    }
}