using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponBox : MonoBehaviour {
    private PlayerWindow m_PlayerWindow;

    public Button m_BackButton;
    public void InitWeapon(PlayerWindow _window)
    {
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
}