using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModule : GameModule
{
    public override IEnumerator InitEvent()
    {
        yield return null;
    }

    public override void LoadData()
    {
        base.LoadData();
    }
}

public class PlayerData
{
    public string m_ImagePath = "";
    public string m_PlayerName = "";
    public string m_Sex = "";
    public string m_Camp = "";
    public string m_Level = "";
    public string m_Introduction = "";
    public string m_MedalImagePath = "";
    public string m_Chpater = "";
    public string m_Roles = "";

    public PlayerData(string _imagePath,string _name,string _sex,string _camp,string _level,string _int,string _medaPath,string _chapter,string _roles)
    {
        m_ImagePath = _imagePath;
        m_PlayerName = _name;
        m_Sex = _sex;
        m_Camp = _camp;
        m_Level = _level;
        m_Introduction = _int;
        m_MedalImagePath = _medaPath;
        m_Chpater = _chapter;
        m_Roles = _roles;
    }
}