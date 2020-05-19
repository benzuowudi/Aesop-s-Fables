using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ControllerManager
{
    private static ControllerManager Instance;
    public static ControllerManager GetInstance()
    {
        if (Instance == null)
        {
            Instance = new ControllerManager();
        }
        return Instance;
    }

    public ModuleManager m_ModuleManager;
    public GameControlleRegist m_GameControlleRegist;
    private Dictionary<Type, GameControlle> m_ControllerDic = new Dictionary<Type, GameControlle>();

    public ControllerManager()
    {
        m_GameControlleRegist = new GameControlleRegist(this);
    }

    public void InitController(ModuleManager _moduleManager)
    {
        m_ModuleManager = _moduleManager;
        m_GameControlleRegist.Regist();

        Dictionary<Type, GameControlle>.Enumerator kDicE = m_ControllerDic.GetEnumerator();
        while (kDicE.MoveNext())
        {
            kDicE.Current.Value.InitController(null);
        }
    }

    public void AddController<T>() where T : GameControlle, new()
    {
        T kController = new T();
        m_ControllerDic.Add(typeof(T), kController);
    }

    public T GetCtrl<T>() where T : GameControlle
    {
        GameControlle kCtrl = null;
        m_ControllerDic.TryGetValue(typeof(T), out kCtrl);
        return kCtrl as T;
    }
}
