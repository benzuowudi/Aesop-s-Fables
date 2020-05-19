using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModule : GameModule
{
    private PlayerData m_PlayerData;
    private ChapterData m_ChapterData;
    private List<ChapterCellData> m_ChapterList = new List<ChapterCellData>();

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
        return m_PlayerData;
    }

    public ChapterData GetChapterData()
    {
        return m_ChapterData;
    }

    public List<ChapterCellData> GetChapterList()
    {
        return m_ChapterList;
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

public class ChapterData
{
    public string m_Path = "";
    public float m_Height = 0;
    public float m_Gap = 0;
    public ChapterData(string _path, float _height, float _gap)
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