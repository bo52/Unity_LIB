using UnityEngine;
/// <summary>
/// jump
/// ������ ������
/// </summary>
namespace mb2022
{
    public class mbJump : MonoBehaviour, IJump
    {
        public Rigidbody ����������� => GetComponent<Rigidbody>();
        void Update() => (this as IJump).������();
    }
}
