using UnityEngine;
namespace go2022
{
    using class2022;
    /// <summary>
    /// ������� ������ �� �����
    /// </summary>
    public class GAMEOBJECT : CLASS
    {
        public object[] ATRs;
        public GameObject GO;
        public virtual GAMEOBJECT �������� { get; set; }
        public virtual string ID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Type ��������� { get; set; }
        #region CREATE
        public GAMEOBJECT(object[] atr, string name, string id)
        {
        }
        public GAMEOBJECT(object[] atrs = null)
        {
            if (atrs == null)
                return;
            //atrs[0] = this;

            GO = this.pow_go(atrs);
        }

        #endregion
        public virtual void ���������������(object[] atrs)
        {
            var SCRIPT = ��������� == null ? stExample_method.�������������������������(GO) : stExample_method.�������������������������(GO, ���������);
            SCRIPT?.���������������(this, atrs);
        }
    }
}