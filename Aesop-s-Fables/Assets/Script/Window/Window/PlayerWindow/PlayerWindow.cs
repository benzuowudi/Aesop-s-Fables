using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWindow : UIWindow
{
    public PlayerDataBox m_PlayerDataBox;
    public WeaponBox m_WeaponBox;
    public ChapterBox m_ChapterBox;
    public RolesBox m_RolesBox;

    public Button m_BackButton;
    public Button m_HomeButton;

    public override void EnterWindow(object o)
    {
        base.EnterWindow(o);
        m_BackButton.onClick.AddListener(OnClickBack);
        m_HomeButton.onClick.AddListener(OnClickHome);

        m_PlayerDataBox.InitPlayerData(this);
        m_WeaponBox.InitWeapon(this);
        m_ChapterBox.InitChapter(this, GetModule<PlayerModule>().GetCadeData(), GetModule<PlayerModule>().GetChapterList());
        m_RolesBox.InitRoles(this, GetModule<PlayerModule>().GetCadeData(), GetModule<PlayerModule>().GetRoles());
    }

    public override void LeaveWindow()
    {
        base.LeaveWindow();
        m_BackButton.onClick.RemoveListener(OnClickBack);
        m_HomeButton.onClick.RemoveListener(OnClickHome);

        m_PlayerDataBox.Leave();
        m_WeaponBox.Leave();
        m_ChapterBox.Leave();
        m_RolesBox.Leave();
    }
}