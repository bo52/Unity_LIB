using UnityEngine;
/// <summary>
/// jump
/// прыжки игрока
/// </summary>
namespace mb2022
{
    public class mbJump : MonoBehaviour, IJump
    {
        public Rigidbody ТвердоеТело => GetComponent<Rigidbody>();
        void Update() => (this as IJump).прыжок();
    }
}
