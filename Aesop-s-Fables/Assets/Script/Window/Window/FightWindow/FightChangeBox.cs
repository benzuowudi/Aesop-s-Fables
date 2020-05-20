using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FightChangeBox : MonoBehaviour
{
    private FightWindow m_FightWindow;
    private Action m_CheckMain;
    public List<MainChapterCade> m_CadeList = new List<MainChapterCade>();
    public Button m_MainChapterButton;
    public void InitFightChange(FightWindow _window,Action _toMain)
    {
        m_FightWindow = _window;
        m_MainChapterButton.onClick.AddListener(OnClickFightChange);
    }

    public void OnClickFightChange()
    {
        m_CheckMain();
    }
}