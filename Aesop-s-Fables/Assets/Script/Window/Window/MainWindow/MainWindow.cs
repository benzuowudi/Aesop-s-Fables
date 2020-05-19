using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainWindow : UIWindow
{
    public Button m_Player;
    public Button m_FightButton;
    public Button m_LotteryTicketButton;
    public Button m_BackageButton;
    public Button m_ShopButton;
    public Button m_RoomButton;
    public Button m_RolesButton;

    public override void EnterWindow(object o)
    {
        base.EnterWindow(o);
        m_Player.onClick.AddListener(OnClickPlayer);
        m_FightButton.onClick.AddListener(OnClickFightButton);
        m_LotteryTicketButton.onClick.AddListener(OnClickLotteryTicketButton);
        m_BackageButton.onClick.AddListener(OnClickBackageButton);
        m_ShopButton.onClick.AddListener(OnClickShopButton);
        m_RoomButton.onClick.AddListener(OnClickRoomButton);
        m_RolesButton.onClick.AddListener(OnClickRolesButton);
    }

    public override void LeaveWindow()
    {
        base.LeaveWindow();
        m_Player.onClick.RemoveListener(OnClickPlayer);
        m_FightButton.onClick.RemoveListener(OnClickFightButton);
        m_LotteryTicketButton.onClick.RemoveListener(OnClickLotteryTicketButton);
        m_BackageButton.onClick.RemoveListener(OnClickBackageButton);
        m_ShopButton.onClick.RemoveListener(OnClickShopButton);
        m_RoomButton.onClick.RemoveListener(OnClickRoomButton);
        m_RolesButton.onClick.RemoveListener(OnClickRolesButton);
    }

    public void OnClickPlayer()
    {
        ShowWindow(UIName.PlayerWindow, null);
    }

    public void OnClickFightButton()
    {
        ShowWindow(UIName.FightWindow, null);
    }

    public void OnClickLotteryTicketButton()
    {
        ShowWindow(UIName.LotteryTicketWindow, null);
    }

    public void OnClickBackageButton()
    {
        ShowWindow(UIName.BackageWindow, null);
    }

    public void OnClickShopButton()
    {
        ShowWindow(UIName.ShopWindow, null);
    }

    public void OnClickRoomButton()
    {
        ShowWindow(UIName.RoomWindow, null);
    }

    public void OnClickRolesButton()
    {
        ShowWindow(UIName.RolesWindow, null);
    }
}