using gui2023;
using UnityEngine;
using utility2022;

namespace spRegion.edit
{
    public interface ICustom : IRegion10_bs
    {
    }
}

namespace spBlock.edit
{

    public interface stCustom
    {
        #region ���������
        static public byte ��������� = 0;
        static public string ������������������
        {
            get
            {
                switch (���������)
                {
                    case 255: return "�������� ���������";
                    case 51: return "�������";
                }
                return "�� ��������";
            }
        }
        #endregion
        #region ��������� � �����
        static public void ���()
        {
            //stRegion_curr.���_���������������������(ref ���������);
        }
        static public void ��()
        {
            //if (stRegion_curr.�������)
                //IBlock8.������������[���������].����������������(stRegion_curr.Region_go, ���������);
        }
        static public void ���_����������������(GameObject reg)
        {
            //�������� ����������� � �������
            //IBlock_edit.MO.transform.SetParent(reg.transform);
            //_go.transform.localPosition = ���������;
        }
        static public void ��������������������()=>IBlock8.������������[���������].���������();
        static public void ��������������������() => IBlock8.������������[���������].���������();
        #endregion
    }
}
