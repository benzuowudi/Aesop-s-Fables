using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoleCade : MonoBehaviour
{
    public Image m_RoleImage;
    public Text m_RoleName;
    public Text m_RoleTitle;
    public Text m_RoleCamp;
    public Text m_RoleDes;
    public Button m_RoleButton;
    public void Init(RolesCellData _role)
    {
        m_RoleName.text = _role.m_RoleName;
        m_RoleTitle.text = _role.m_RoleTitle;
        m_RoleCamp.text = _role.m_RoleCamp;
        m_RoleDes.text = _role.m_RoleDes;
    }
}