namespace scr2022
{
    using UnityEngine;
    /// <summary>
    /// ������ Q
    /// ������ E
    /// ������ btn
    /// ������� lab
    /// ����� head
    /// </summary>
    public class insQE_head_btn
    {
        public string namLab;

        public bool but=true;
        public System.Func<string> actLab;
        public virtual void actHead()
        {

        }
        public virtual void actButtom()
        {

        }
        public virtual void actQ()
        {

        }
        public virtual void actE()
        {

        }

        public insQE_head_btn(System.Func<string> lab)
        {
            actLab = lab;
        }
        public bool ������������������(string head)
        {
            GUILayout.BeginVertical();
            var b=stFoldout_gui.Foldout(() =>
            {

                GUILayout.BeginHorizontal();
                stLab_gui.lab(namLab+"=" + actLab(), 80);
                if (stButton_gui.������("Q", 20))
                    actQ();
                if (stButton_gui.������("E", 20))
                    actE();
                actHead();
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                actButtom();
                GUILayout.EndHorizontal();

            }, head, ref but);
            GUILayout.EndVertical();
            return b;
        }
    }
}
