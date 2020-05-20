using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChapterBox : MonoBehaviour
{
    private PlayerWindow m_PlayerWindow;
    public Transform m_Content;
    public List<ChapterCade> m_ChapterList = new List<ChapterCade>();
    public Button m_BackButton;
    public void InitChapter(PlayerWindow _window, CadeDate _data, List<ChapterCellData> _cadeList)
    {
        m_PlayerWindow = _window;
        int kCellH = (int)_data.m_Height + (int)_data.m_Gap;
        m_PlayerWindow.GetCtrl<ScrollViewController>().ShowCade(m_Content, kCellH, _data.m_Path, _cadeList.Count, m_ChapterList);
        InitCell(_cadeList);

        m_BackButton.onClick.AddListener(OnClickBack);
    }

    public void Leave()
    {
        m_BackButton.onClick.AddListener(OnClickBack);
    }

    public void OnClickBack()
    {
        gameObject.SetActive(false);
    }

    public void InitCell(List<ChapterCellData> _list)
    {
        for (int i = 0; i < m_ChapterList.Count; i++)
        {
            int temp = i;
            m_ChapterList[temp].Init(_list[temp]);
        }
    }
}