using UnityEditor;
using UnityEngine;
namespace mb2022
{
    using go2022;
    using scene2022;
    #region Mono
    /// <summary>
    /// универсальный моно класс" + "\n" + "(СТАРТ)
    /// </summary>
    public class Mono : MonoBehaviour
    {
        static public string INFO = "MonoBehaviour";
        [SerializeField]
        public string ID;
        virtual public void ОсобыеНастройки(GAMEOBJECT g, object[] atr)
        {
            if (ID == null)
                return;
            if (ID == "")
                return;
            gameObject.name = ID;
        }
        virtual public void Start() => stMono.ИГРАЕМ = true;
        virtual public bool ИНСПЕКТОР() => true;
        virtual public bool СТАРТ(bool кнопка = false)
        {
            stButton_act.РаботаОбъекта("СТАРТ", кнопка, () => stScene.КлассТекущейСцены.GetMethod("method_install").Invoke(null, null));
            return true;
        }
        virtual public bool СЦЕНА()
        {
            if (stMono.Первый)
            {
                stScene_go.CONTENT.transform.УдалениеОбъектов();
                stMono.Первый = false;
                СТАРТ();
            }
            return true;
        }
        [CustomEditor(typeof(Mono))]
        public class gui : Editor
        {
            #region События Мыши
            virtual public void event_MouseMove()
            {
            }
            virtual public void event_leftMouseUp()
            {
            }
            virtual public void event_rightMouseUp()
            {
            }
            virtual public void event_middleMouseUp()
            {
            }
            virtual public void event_MouseUp()
            {
                switch (Event.current.button)
                {
                    case 0:
                        event_leftMouseUp();
                        break;
                    case 1:
                        event_rightMouseUp();
                        break;
                    case 2:
                        event_middleMouseUp();
                        break;
                }
            }
            virtual public void event_MouseDown()
            {
                switch (Event.current.button)
                {
                    case 0:
                        event_leftMouseDown();
                        break;
                    case 1:
                        event_rightMouseDown();
                        break;
                    case 2:
                        event_middleMouseDown();
                        break;
                }
            }
            virtual public void event_leftCtrlMouseDown()
            {
            }
            virtual public bool event_leftMouseDown()
            {
                if (Event.current.control)
                {
                    event_leftCtrlMouseDown();
                    return true;
                }
                return false;
            }
            virtual public void event_rightMouseDown()
            {
            }
            virtual public void event_middleMouseDown()
            {
            }
            #endregion
            #region События Клавиатуры
            virtual public void event_KeyDown()
            {
            }
            virtual public void event_KeyUp()
            {
            }
            #endregion
            //Манипуляция в Событии на Сцене OnSceneGUI
            public virtual void OnSceneGUI()
            {
                Event e = Event.current;
                int controlID = GUIUtility.GetControlID(FocusType.Passive);
                HandleUtility.AddDefaultControl(controlID);

                switch (e.GetTypeForControl(controlID))
                {
                    case EventType.MouseMove:
                        event_MouseMove();
                        break;
                    case EventType.MouseUp:
                        event_MouseUp();
                        break;
                    case EventType.MouseDown:
                        event_MouseDown();
                        break;
                    case EventType.KeyDown:
                        event_KeyDown();
                        break;
                    case EventType.KeyUp:
                        event_KeyUp();
                        break;
                }
                Repaint();
                if (target is Mono)
                    ((Mono)target).СЦЕНА();
            }
            //Манипуляция в Событии в Инспекторе OnInspectorGUI
            public override void OnInspectorGUI()
            {
                if (target is Mono)
                {
                    DrawDefaultInspector();
                    ((Mono)target).ИНСПЕКТОР();
                }
            }
        }

    }
    #endregion
}

