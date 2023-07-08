//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2306262206_ВычислитьВысоту
{
    /// <summary>
    /// 
    /// </summary>
    public class Class
    {
        static public string INFO = "INFO";
        #region Ссылки
        #endregion
        #region СтатФункции
        /// <summary>
        /// 
        /// </summary>
        static int ОпределениеСмещенияНачальнойВысоты => Random.Range(-128, 128);
        /// <summary>
        /// 
        /// </summary>
        static int ОпределениеСмещенияВысоты => Random.Range(-1, 1);
        /// <summary>
        /// 
        /// </summary>
        static public Vector3Int ВекторПервойВершиныПоОси = Vector3Int.zero;
        /// <summary>
        /// 
        /// </summary>
        static public Vector3Int ВекторПоследнейВершиныПоОси = Vector3Int.zero;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        #region ФункцииКласса
        private cs2307051626_ЗЕМЛЯ.IClass Словарь;
        private static int R = cs2307051626_ЗЕМЛЯ.IClass.РадиусВидимости;
        public Class(cs2307051626_ЗЕМЛЯ.IClass Словарь)
        {
            Словарь.Clear();
            this.Словарь = Словарь;
            ВычислитьВысотуЯчеекВысоты();
        }
        static Vector3Int Вычисление(int x, int z)
        {
            if (z == -R & x == -R) return ВычислениеПервойВершины;
            if (x == -R) return ВычислениеСледующейЗетВершины;
            return ВычислениеСледующейВершины;
        }
        /// <summary>
        /// 
        /// </summary>
        static Vector3Int ВычислениеПервойВершины
        {
            get
            {
                ВекторПервойВершиныПоОси = new Vector3Int(0, ОпределениеСмещенияНачальнойВысоты, 0);
                ВекторПоследнейВершиныПоОси = ВекторПервойВершиныПоОси;
                return ВекторПоследнейВершиныПоОси;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static Vector3Int ВычислениеСледующейЗетВершины
        {
            get
            {
                ВекторПервойВершиныПоОси += new Vector3Int(0, ОпределениеСмещенияВысоты, 0);
                ВекторПоследнейВершиныПоОси = ВекторПервойВершиныПоОси;
                return ВекторПоследнейВершиныПоОси;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static Vector3Int ВычислениеСледующейВершины
        {
            get
            {
                ВекторПоследнейВершиныПоОси += new Vector3Int(0, ОпределениеСмещенияВысоты, 0);
                return ВекторПоследнейВершиныПоОси;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="TexLab"></param>
        static public void Сбросить()
        {
            ВекторПоследнейВершиныПоОси = Vector3Int.zero;
            ВекторПервойВершиныПоОси = Vector3Int.zero;
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="TexLab"></param>
        public void ВычислитьВысотуЯчеекВысоты()
        {
            Сбросить();
            for (var z = -R; z <= R; z++)
                for (var x = -R; x <= R; x++)
                {
                    Вычисление(x, z);
                    Словарь.ДобавитьЧанк(new Vector2Int(x, z), ВекторПоследнейВершиныПоОси.y);
                }
        }
        ///exit
    }
}
