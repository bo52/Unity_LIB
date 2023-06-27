using UnityEngine;
namespace go2022
{
    public interface IPlayer_move
    {
        static float SPEED = 1;
        static GameObject GO;
        float Скорость => SPEED;
        GameObject ИгровойОбъект => GO;
        /// <summary>
        /// Векторное направление движения
        /// </summary>
        static readonly public Vector3[] Направление = new Vector3[6]
        {
            Vector3.left,
            Vector3.right,
            Vector3.forward,
            Vector3.back,
            Vector3.down,
            Vector3.up
        };
        /// <summary>
        /// KeyCode Движение Вперед,Назад,Влево,Вправо по поверхности
        /// </summary>
        static public KeyCode[] КнопкиДвижений = new KeyCode[]
        {
            KeyCode.A,
            KeyCode.D,
            KeyCode.W,
            KeyCode.S,
            KeyCode.C,
            KeyCode.Space,
        };
        /// <summary>
        /// направление 0-3 (УЧЁТ четырёх сторон поворота)
        /// Восток - Север - Запад - Юг
        /// </summary>
        static public readonly KeyCode[,] КнопкиДвижений4 = new KeyCode[4, 6] {
            {
                KeyCode.A,
                KeyCode.D,
                KeyCode.W,
                KeyCode.S,
                KeyCode.C,
                KeyCode.Space
            },
            {
                KeyCode.W,
                KeyCode.S,
                KeyCode.D,
                KeyCode.A,
                KeyCode.C,
                KeyCode.Space
            },
            {
                KeyCode.D,
                KeyCode.A,
                KeyCode.S,
                KeyCode.W,
                KeyCode.C,
                KeyCode.Space
            },
            {
                KeyCode.S,
                KeyCode.W,
                KeyCode.A,
                KeyCode.D,
                KeyCode.C,
                KeyCode.Space
            }
        };
        static public sbyte ИндексНажатияКнопки
        {
            get
            {
                for (sbyte i = 0; i < КнопкиДвижений.Length; i++)
                    if (Input.GetKey(КнопкиДвижений[i]))
                        return i;
                return -1;
            }
        }
        public virtual void НовоеПоложениеИгрока(Vector3 v)
        {
        }
        public bool НовоеПоложениеИгрока(sbyte key)
        {
            if (key < 0)
                return false;
            var v = Vector3.MoveTowards(ИгровойОбъект.transform.position, ИгровойОбъект.transform.position + Скорость * Направление[key], Time.deltaTime);

            ИгровойОбъект.transform.position = v;
            НовоеПоложениеИгрока(v);
            return true;
        }
        public bool СовершилиНажатиеКнопки => НовоеПоложениеИгрока(ИндексНажатияКнопки);
    }
}
