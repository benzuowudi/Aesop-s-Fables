using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindow : MonoBehaviour
{
    public UIName m_UIName = UIName.none;

    public virtual void EnterWindow(object o)
    {
    }

    public virtual void LeaveWindow()
    {
        Destroy(gameObject);
    }

    public void ShowWindow(UIName _name, object o)
    {
        GameManager.m_UIManager.ShowWindow(_name, o);
    }

    public void HideWindow(UIName _name)
    {
        GameManager.m_UIManager.CloseWindow(_name);
    }

    public ModuleManager GetModuleManager()
    {
        return GameManager.m_UIManager.GetModuleManager();
    }

    public virtual void OnClickBack()
    {
        ShowWindow(GameManager.m_UIManager.GetLastWindow(), null);
    }

    public virtual void OnClickHome()
    {
        ShowWindow(UIName.MainWindow, null);
    }

    public T GetModule<T>() where T : GameModule
    {
        return GameManager.m_UIManager.GetModule<T>();
    }

    public T GetCtrl<T>() where T : GameControlle
    {
        return GameManager.m_UIManager.GetCtrl<T>();
    }

    public PathManager GetPath()
    {
        return GameManager.m_PathManager;
    }
}