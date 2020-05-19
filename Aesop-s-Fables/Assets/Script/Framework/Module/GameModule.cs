using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModule
{
    private ModuleManager m_ModuleManager;
    public void Init(ModuleManager _manager)
    {
        m_ModuleManager = _manager;
    }

    public virtual IEnumerator InitEvent()
    {
        yield return null;
    }

    public virtual void LoadData()
    {

    }

    public T GetModule<T>() where T : GameModule
    {
        return m_ModuleManager.GetModule<T>();
    }
}
