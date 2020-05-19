using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LotteryTicketWindow : UIWindow
{
    public Button m_BackButton;
    public Button m_HomeButton;

    public override void EnterWindow(object o)
    {
        base.EnterWindow(o);
        m_BackButton.onClick.AddListener(OnClickBack);
        m_HomeButton.onClick.AddListener(OnClickHome);
    }

    public override void LeaveWindow()
    {
        base.LeaveWindow();
        m_BackButton.onClick.RemoveListener(OnClickBack);
        m_HomeButton.onClick.RemoveListener(OnClickHome);
    }
}