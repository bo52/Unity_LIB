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
        #region –азнЅлока
        static public byte –азнЅлока = 0;
        static public string –азновидностьЅлока
        {
            get
            {
                switch (–азнЅлока)
                {
                    case 255: return "заполнен полностью";
                    case 51: return "вершина";
                }
                return "не определЄн";
            }
        }
        #endregion
        #region »нспектор и —цена
        static public void »нс()
        {
            //stRegion_curr.инс_–абота—Ѕлоком¬–егионе(ref –азнЅлока);
        }
        static public void —ц()
        {
            //if (stRegion_curr.—ущЅлок)
                //IBlock8.ћоделиЅлоков[–азнЅлока].ѕоказать¬се“очки(stRegion_curr.Region_go, –азнЅлока);
        }
        static public void »нс_ќбновить–едактор(GameObject reg)
        {
            //редактор размещаетс€ в регионе
            //IBlock_edit.MO.transform.SetParent(reg.transform);
            //_go.transform.localPosition = “ек¬ектор;
        }
        static public void —охранить“екущийЅлок()=>IBlock8.ћоделиЅлоков[–азнЅлока].—охранить();
        static public void «агрузить“екущийЅлок() => IBlock8.ћоделиЅлоков[–азнЅлока].загрузить();
        #endregion
    }
}
