namespace mb2022
{
    using UnityEngine;
    public interface IJump
    {
        static public bool OnGround = true;
        static public byte force = 20;
        static public Rigidbody R;
        public bool �������
        {
            get => OnGround;
            set => OnGround = value;
        }
        public byte ���������� => force;
        public Rigidbody ����������� => R;
        //static public float speed = 5.0F;
        //static public float jumpSpeed = 6.0F;
        /// <summary>
        /// ��������� ������������ ���������� ������� ���� � ����������� �� ������� (�� �������� ������ ���)
        /// </summary>
        static public float distance = 0.0f;
        public void ������()
        {
            var ray = new Ray(�����������.gameObject.transform.position, Vector3.down);
            ������� = Physics.Raycast(ray, 1.5f);

            if (Input.GetAxis("Jump") != 0)
            {
                if (�������)
                    �����������.AddForce(Vector3.up * ����������);
            }
        }
    }
}
