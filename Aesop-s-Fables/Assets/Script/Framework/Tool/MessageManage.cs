using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MessageManage
{
    private static MessageManage Instance;
    public static MessageManage GetInstance()
    {
        if (Instance == null)
        {
            Instance = new MessageManage();
        }
        return Instance;
    }

    public Dictionary<string, List<Observer>> m_ObserverDic = new Dictionary<string, List<Observer>>();
    public void RegistMessage(string _msg, Action<object> _action)
    {
        Observer kObserver = new Observer(_action);
        Dictionary<string, List<Observer>>.Enumerator kDicE = m_ObserverDic.GetEnumerator();
        while (kDicE.MoveNext())
        {
            if (_msg == kDicE.Current.Key)
            {
                kDicE.Current.Value.Add(kObserver);
                return;
            }
        }
        List<Observer> kList = new List<Observer> { kObserver };
        m_ObserverDic.Add(_msg, kList);
    }

    public void RemoveMessage(string _msg, Action<object> _action)
    {
        if (!m_ObserverDic.ContainsKey(_msg))
        {
            return;
        }
        List<Observer> kList = m_ObserverDic[_msg];
        for (int i = 0; i < kList.Count; i++)
        {
            int temp = i;
            if (_action == kList[temp].m_Action)
            {
                m_ObserverDic[_msg].RemoveAt(temp);
                return;
            }
        }
    }

    public void SendMessage(string _msg,object _object)
    {
        if (!m_ObserverDic.ContainsKey(_msg))
        {
            return;
        }
        List<Observer> kList = m_ObserverDic[_msg];
        for (int i = 0; i < kList.Count; i++)
        {
            int temp = i;
            kList[temp].m_Action(_object);
        }
    }
}

public class Observer
{
    public Action<object> m_Action;
    public Observer(Action<object> _action)
    {
        m_Action = _action;
    }
}