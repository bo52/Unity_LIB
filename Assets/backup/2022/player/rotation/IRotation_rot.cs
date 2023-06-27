using UnityEngine;
namespace mb2022
{
    public interface IRotation_rot : IRotation_param
    {
        static GameObject go;
        /// <summary>
        /// процесс поворота от 0 до 45 грудусов. Если поворот не происходит то -1
        /// </summary>
        static public float rot = -1;
        /// <summary>
        /// видимость только поверхности но не слоёв земли (x,y)
        /// </summary>
        static public bool ТолькоПоверхность = false;
        virtual public void НачалоПоворота() => ТолькоПоверхность = true;
        public GameObject ИгровойПерсонаж => go;
        virtual public void ПослеПоворота() => rot = -1;
        public void Поварачиваем(byte n = 2) => ИгровойПерсонаж.transform.rotation *= Quaternion.AngleAxis(n * b_root, new Vector3(0, 1, 0));
        public void ПроцессПоворота()
        {
            if (rot < 0)
                return;
            if (rot == 0)
            {
                НачалоПоворота();
                ТолькоПоверхность = false;
            }

            Поварачиваем();
            rot += 1;

            if (rot >= 45)
                ПослеПоворота();
        }
    }
}