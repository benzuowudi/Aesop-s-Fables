using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleRegist
{
    public ModuleManager m_ModuleManager;
    public ModuleRegist(ModuleManager _manager)
    {
        m_ModuleManager = _manager;
    }

    public void Regist()
    {
        m_ModuleManager.AddModule<PlayerModule>();
    }
}