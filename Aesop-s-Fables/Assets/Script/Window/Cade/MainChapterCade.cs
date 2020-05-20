using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MainChapterCade : MonoBehaviour
{
    public Image m_ChapterImage;
    public Button m_ChpaterButton;
    public Action m_ChapterAction;
    public void Init()
    {
        m_ChpaterButton.onClick.AddListener(OnClickChapter);
    }

    public void OnClickChapter()
    {
        m_ChapterAction();
    }
}