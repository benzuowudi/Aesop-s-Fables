using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ModuleManager
{
    private static ModuleManager Instance;
    public static ModuleManager GetInstance()
    {
        if (Instance == null)
        {
            Instance = new ModuleManager();
        }
        return Instance;
    }

    private ModuleRegist m_ModuleRegist;

    private Dictionary<Type, GameModule> m_GameModuleDic = new Dictionary<Type, GameModule>();

    public ModuleManager()
    {
        m_ModuleRegist = new ModuleRegist(this);
    }

    public void Init()
    {
        m_ModuleRegist.Regist();
        foreach(var module in m_GameModuleDic.Values)
        {
            module.Init(this);
        }
    }

    public void AddModule<T>() where T : GameModule, new()
    {
        T kModule = new T();
        m_GameModuleDic.Add(typeof(T), kModule);
    }

    public T GetModule<T>() where T : GameModule
    {
        GameModule kGameModule = null;
        m_GameModuleDic.TryGetValue(typeof(T), out kGameModule);
        return kGameModule as T;
    }
}