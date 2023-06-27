using UnityEngine;
namespace mb2022
{
    using go2022;
    public interface IRotation_pov : IRotation_rot
    {
        /// <summary>
        /// обновить кнопки и b_root,rot,pov
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static public bool НАСТРОИТЬДвижениеПослеПоворота(byte i)
        {
            if (i == byte.MaxValue)
                return false;
            b_root = НаправлениеПоворота[i];
            rot = 0;
            pov -= b_root;
            if (pov < 0)
                pov = 3;
            if (pov > 3)
                pov = 0;

            IPlayer_move_pov.ОбновитьКнопкиДвижений(pov);
            НачатПоворот = true;
            return true;
        }
        static bool НастроитьДвижениеПослеПоворота(byte i)
        {
            if (!Input.GetKeyDown(КнопкиПоворота[i]))
                return false;
            return НАСТРОИТЬДвижениеПослеПоворота(i);
        }
        static public void НачатьПоворот()
        {
            if (rot > -1)
                return;

            for (byte i = 0; i < КнопкиПоворота.Length; i++)
            {
                if (НастроитьДвижениеПослеПоворота(i))
                    return;
            }
        }
        void update()
        {
            НачатьПоворот();
            ПроцессПоворота();
        }
    }
}
