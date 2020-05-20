using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModule : GameModule
{
    private PlayerData m_PlayerData;
    private CadeDate m_CadeData;
    private List<ChapterCellData> m_ChapterList = new List<ChapterCellData>();
    private List<RolesCellData> m_RolesList = new List<RolesCellData>();

    public override IEnumerator InitEvent()
    {
        yield return null;
    }

    public override void LoadData()
    {
        base.LoadData();
    }

    public PlayerData GetPlayerData()
    {
        if (m_PlayerData == null)
        {
            return null;
        }
        return m_PlayerData;
    }

    public CadeDate GetCadeData()
    {
        if (m_CadeData == null)
        {
            return null;
        }
        return m_CadeData;
    }

    public ChapterCellData GetChapterCellDataByID(int _index)
    {
        if (_index >= m_ChapterList.Count)
        {
            return null;
        }
        return m_ChapterList[_index];
    }

    public List<ChapterCellData> GetChapterList()
    {
        if (m_ChapterList.Count == 0)
        {
            return null;
        }
        return m_ChapterList;
    }

    public RolesCellData GetRoleDataByID(int _index)
    {
        if (_index >= m_RolesList.Count)
        {
            return null;
        }
        return m_RolesList[_index];
    }

    public List<RolesCellData> GetRoles()
    {
        if (m_RolesList.Count == 0)
        {
            return null;
        }
        return m_RolesList;
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

    public PlayerData(string _imagePath, string _name, string _sex, string _camp, string _level, string _int, string _medaPath, string _chapter, string _roles)
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

public class CadeDate
{
    public string m_Path = "";
    public float m_Height = 0;
    public float m_Gap = 0;
    public CadeDate(string _path, float _height, float _gap)
    {
        m_Path = _path;
        m_Height = _height;
        m_Gap = _gap;
    }
}

public class ChapterCellData
{
    public string m_ChapterImagePath = "";
    public int m_ChpaterNum = 0;
    public int m_PointNum = 0;
    public string m_ChapterName = "";
    public string m_ChapterDes = "";
    public int m_ChapterEva = 0;
    public int m_Minute = 0;
    public int m_Scend = 0;

    public ChapterCellData(string _path, int _cNum, int _pNum, string _cName, string _cDes, int _cEva, int _m, int _s)
    {
        m_ChapterImagePath = _path;
        m_ChpaterNum = _cNum;
        m_PointNum = _pNum;
        m_ChapterName = _cName;
        m_ChapterDes = _cDes;
        m_ChapterEva = _cEva;
        m_Minute = _m;
        m_Scend = _s;
    }
}

public class RolesCellData
{
    public string m_Path = "";
    public string m_RoleName = "";
    public string m_RoleCamp = "";
    public string m_RoleTitle = "";
    public string m_RoleDes = "";

    public RolesCellData(string _path, string _name, string _camp, string _title, string _des)
    {
        m_Path = _path;
        m_RoleName = _name;
        m_RoleCamp = _camp;
        m_RoleTitle = _title;
        m_RoleDes = _des;
    }
}