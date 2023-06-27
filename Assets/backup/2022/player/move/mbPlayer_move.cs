using UnityEngine;
namespace go2022
{
    public class mbPlayer_move : MonoBehaviour, IPlayer_move
    {
        static public string INFO = "MOVING";
        static public string PRODUCT = "по нажатию кнопки движение камеры wasd с учетом 4 сторон поворота";
        private void Update()
        {
            var b = (this as IPlayer_move).СовершилиНажатиеКнопки;
        }
    }
}