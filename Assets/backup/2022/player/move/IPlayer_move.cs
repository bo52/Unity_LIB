using UnityEngine;
namespace go2022
{
    public interface IPlayer_move
    {
        static float SPEED = 1;
        static GameObject GO;
        float �������� => SPEED;
        GameObject ������������� => GO;
        /// <summary>
        /// ��������� ����������� ��������
        /// </summary>
        static readonly public Vector3[] ����������� = new Vector3[6]
        {
            Vector3.left,
            Vector3.right,
            Vector3.forward,
            Vector3.back,
            Vector3.down,
            Vector3.up
        };
        /// <summary>
        /// KeyCode �������� ������,�����,�����,������ �� �����������
        /// </summary>
        static public KeyCode[] �������������� = new KeyCode[]
        {
            KeyCode.A,
            KeyCode.D,
            KeyCode.W,
            KeyCode.S,
            KeyCode.C,
            KeyCode.Space,
        };
        /// <summary>
        /// ����������� 0-3 (�ר� ������ ������ ��������)
        /// ������ - ����� - ����� - ��
        /// </summary>
        static public readonly KeyCode[,] ��������������4 = new KeyCode[4, 6] {
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
        static public sbyte �������������������
        {
            get
            {
                for (sbyte i = 0; i < ��������������.Length; i++)
                    if (Input.GetKey(��������������[i]))
                        return i;
                return -1;
            }
        }
        public virtual void ��������������������(Vector3 v)
        {
        }
        public bool ��������������������(sbyte key)
        {
            if (key < 0)
                return false;
            var v = Vector3.MoveTowards(�������������.transform.position, �������������.transform.position + �������� * �����������[key], Time.deltaTime);

            �������������.transform.position = v;
            ��������������������(v);
            return true;
        }
        public bool ���������������������� => ��������������������(�������������������);
    }
}
