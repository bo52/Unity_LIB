//empty
//empty
//empty
using UnityEditor;
using UnityEngine;
/// <summary>
/// 
/// </summary>
namespace LIB.go2305081120
{
    /// <summary>
    /// 
    /// </summary>
    public interface IScene : IEvent
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public class Scene : MyEvent, IScene
    {
        override public bool Выполнить()
        {
            event_MouseKey();
            return false;
        }
        virtual public void event_MouseKey()
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
        }
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
    }
}
