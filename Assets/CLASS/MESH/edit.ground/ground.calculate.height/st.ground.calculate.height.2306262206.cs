//empty
//empty
//empty
using UnityEngine;
namespace LIB.st2306262206_ВычислитьВысоту
{
    /// <summary>
    /// 
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        #region Ссылки
        #endregion
        #region СтатФункции
        /// <summary>
        /// 
        /// </summary>
        static int fun230626220602_ОпределениеСмещенияНачальнойВысоты => Random.Range(-128, 128);
        /// <summary>
        /// 
        /// </summary>
        static int fun230626220603_ОпределениеСмещенияВысоты => Random.Range(-1, 1);
        /// <summary>
        /// 
        /// </summary>
        static public Vector3Int fun230626220604_ВекторПервойВершиныПоОси = Vector3Int.zero;
        /// <summary>
        /// 
        /// </summary>
        static public Vector3Int fun230626220605_ВекторПоследнейВершиныПоОси = Vector3Int.zero;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        #region ФункцииКласса
        static Vector3Int fun230626220606_Вычисление(int x, int z)
        {
            var R = cs2307051626_ЗЕМЛЯ.IClass.РадиусВидимости;
            if (z == -R & x == -R) return fun230626220607_ВычислениеПервойВершины;
            if (x == -R) return fun230626220608_ВычислениеСледующейЗетВершины;
            return fun230626220609_ВычислениеСледующейВершины;
        }
        /// <summary>
        /// 
        /// </summary>
        static Vector3Int fun230626220607_ВычислениеПервойВершины
        {
            get
            {
                fun230626220604_ВекторПервойВершиныПоОси = new Vector3Int(0, fun230626220602_ОпределениеСмещенияНачальнойВысоты, 0);
                fun230626220605_ВекторПоследнейВершиныПоОси = fun230626220604_ВекторПервойВершиныПоОси;
                return fun230626220605_ВекторПоследнейВершиныПоОси;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static Vector3Int fun230626220608_ВычислениеСледующейЗетВершины
        {
            get
            {
                fun230626220604_ВекторПервойВершиныПоОси += new Vector3Int(0, fun230626220603_ОпределениеСмещенияВысоты, 0);
                fun230626220605_ВекторПоследнейВершиныПоОси = fun230626220604_ВекторПервойВершиныПоОси;
                return fun230626220605_ВекторПоследнейВершиныПоОси;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static Vector3Int fun230626220609_ВычислениеСледующейВершины
        {
            get
            {
                fun230626220605_ВекторПоследнейВершиныПоОси += new Vector3Int(0, fun230626220603_ОпределениеСмещенияВысоты, 0);
                return fun230626220605_ВекторПоследнейВершиныПоОси;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="TexLab"></param>
        static public void fun230626220610_Сбросить()
        {
            fun230626220605_ВекторПоследнейВершиныПоОси = Vector3Int.zero;
            fun230626220604_ВекторПервойВершиныПоОси = Vector3Int.zero;
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="TexLab"></param>
        static public int fun230626220611_ВычислитьВысотуЯчеекТекстуры(Vector2Int Координата)
        {
            fun230626220610_Сбросить();
            fun230626220606_Вычисление(Координата.x, Координата.y);
            return fun230626220605_ВекторПоследнейВершиныПоОси.y;
        }
        ///exit
    }
}
