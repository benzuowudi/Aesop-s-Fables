using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager Instance;
    public static UIManager GetInstance()
    {
        if (Instance == null)
        {
            Instance = new UIManager();
        }
        return Instance;
    }
    private Canvas m_Canvas;

    private ModuleManager m_ModuleManager;
    private ControllerManager m_ControllerManager;

    private UIWindow m_CurrentWindow = null;
    private UIName m_LastWindow = UIName.none;
    private Dictionary<UIName, UIWindow> m_UIWindowDic = new Dictionary<UIName, UIWindow>();
    public GameObject m_Window { get; set; }

    public void Init(ModuleManager _moduleManager, ControllerManager _ctrlManager, Canvas _canvas)
    {
        m_Canvas = _canvas;
        m_ModuleManager = _moduleManager;
        m_ControllerManager = _ctrlManager;
        UIWindow[] kUIWindows = Resources.FindObjectsOfTypeAll<UIWindow>();
        for (int i = 0; i < kUIWindows.Length; i++)
        {
            int temp = i;
            UIWindow kUIWindow = kUIWindows[temp];
            m_UIWindowDic.Add(kUIWindow.m_UIName, kUIWindow);
        }
    }

    public void ShowWindow(UIName _uiName, object o)
    {
        if (m_CurrentWindow != null)
        {
            m_LastWindow = m_CurrentWindow.m_UIName;
            m_CurrentWindow.LeaveWindow();
        }

        string kPath = GameManager.m_PathManager.ReturnPath(ResourcsePath.Prefab, PrefabPath.Window);
        m_Window = Instantiate<GameObject>(Resources.Load<GameObject>(kPath + _uiName.ToString()), GetCanvas().transform);
        m_CurrentWindow = m_Window.GetComponent<UIWindow>();
        m_CurrentWindow.EnterWindow(o);
    }

    public void CloseWindow(UIName _uiName)
    {
        if (m_CurrentWindow != null && m_CurrentWindow.m_UIName == _uiName)
        {
            m_LastWindow = m_CurrentWindow.m_UIName;
            m_CurrentWindow.LeaveWindow();
            m_CurrentWindow = null;
        }
    }

    public ModuleManager GetModuleManager()
    {
        return m_ModuleManager;
    }

    public Canvas GetCanvas()
    {
        return m_Canvas;
    }

    public UIName GetLastWindow()
    {
        return m_LastWindow;
    }

    public T GetModule<T>() where T : GameModule
    {
        return m_ModuleManager.GetModule<T>();
    }

    public T GetCtrl<T>() where T : GameControlle
    {
        return m_ControllerManager.GetCtrl<T>();
    }
}
