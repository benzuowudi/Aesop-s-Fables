using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RolesBox : MonoBehaviour
{
    private PlayerWindow m_PlayerWindow;
    public Transform m_Content;
    public List<RoleCade> m_RoleCadeList = new List<RoleCade>();
    public Button m_BackButton;
    public void InitRoles(PlayerWindow _window, CadeDate _data, List<RolesCellData> _cadeList)
    {
        m_PlayerWindow = _window;
        int kCellH = (int)_data.m_Height + (int)_data.m_Gap;
        m_PlayerWindow.GetCtrl<ScrollViewController>().ShowCade(m_Content, kCellH, _data.m_Path, _cadeList.Count, m_RoleCadeList);
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

    public void InitCell(List<RolesCellData> _list)
    {
        for (int i = 0; i < m_RoleCadeList.Count; i++)
        {
            int temp = i;
            m_RoleCadeList[temp].Init(_list[temp]);
        }
    }
}