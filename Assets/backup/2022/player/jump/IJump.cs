namespace mb2022
{
    using UnityEngine;
    public interface IJump
    {
        static public bool OnGround = true;
        static public byte force = 20;
        static public Rigidbody R;
        public bool НаЗемле
        {
            get => OnGround;
            set => OnGround = value;
        }
        public byte СилаПрыжка => force;
        public Rigidbody ТвердоеТело => R;
        //static public float speed = 5.0F;
        //static public float jumpSpeed = 6.0F;
        /// <summary>
        /// настроить максимальное расстояние падения луча в зависимости от объекта (от которого падает луч)
        /// </summary>
        static public float distance = 0.0f;
        public void прыжок()
        {
            var ray = new Ray(ТвердоеТело.gameObject.transform.position, Vector3.down);
            НаЗемле = Physics.Raycast(ray, 1.5f);

            if (Input.GetAxis("Jump") != 0)
            {
                if (НаЗемле)
                    ТвердоеТело.AddForce(Vector3.up * СилаПрыжка);
            }
        }
    }
}
