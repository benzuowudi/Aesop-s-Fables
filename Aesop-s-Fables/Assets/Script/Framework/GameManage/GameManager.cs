using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static ModuleManager m_ModuleManager;
    public static UIManager m_UIManager;
    public static ControllerManager m_ControllerManager;
    public static PathManager m_PathManager;
    public static XMLManager m_XMLManager;

    public Canvas m_Canvas;

    public void Start()
    {
        m_ModuleManager = ModuleManager.GetInstance();
        m_UIManager = UIManager.GetInstance();
        m_ControllerManager = ControllerManager.GetInstance();
        m_PathManager = PathManager.GetInstance();
        m_XMLManager = XMLManager.GetInstance();
        InitManager();
        StartGame();
    }

    public void InitManager()
    {
        m_UIManager.Init(m_ModuleManager, m_ControllerManager, m_Canvas);
        m_ControllerManager.InitController(m_ModuleManager);
    }

    public void StartGame()
    {
        m_UIManager.ShowWindow(UIName.MainWindow, null);
    }
}
