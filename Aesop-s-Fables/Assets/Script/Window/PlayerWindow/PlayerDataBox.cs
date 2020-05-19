using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDataBox : MonoBehaviour
{
    private PlayerWindow m_PlayerWindow;
    public Button m_WeaponButton;
    public Button m_ChapterButton;
    public Button m_RolesButton;

    public Image m_PlayerImage;
    public Text m_Name;
    public Text m_Sex;
    public Text m_Camp;
    public Text m_Level;
    public Text m_Introduction;

    public Image m_MedalImage;
    public Text m_ChpaterText;
    public Text m_RolesText;

    public void InitPlayerData(PlayerWindow _window)
    {
        m_PlayerWindow = _window;

        m_WeaponButton.onClick.AddListener(OnClickWeapon);
        m_ChapterButton.onClick.AddListener(OnClickChapter);
        m_RolesButton.onClick.AddListener(OnClickRoles);
    }

    public void Leave()
    {
        m_PlayerWindow = null;

        m_WeaponButton.onClick.RemoveListener(OnClickWeapon);
        m_ChapterButton.onClick.RemoveListener(OnClickChapter);
        m_RolesButton.onClick.RemoveListener(OnClickRoles);
    }

    public void OnClickWeapon()
    {
        m_PlayerWindow.m_WeaponBox.gameObject.SetActive(true);
    }

    public void OnClickChapter()
    {
        m_PlayerWindow.m_ChapterBox.gameObject.SetActive(true);
    }

    public void OnClickRoles()
    {
        m_PlayerWindow.m_RolesBox.gameObject.SetActive(true);
    }
}