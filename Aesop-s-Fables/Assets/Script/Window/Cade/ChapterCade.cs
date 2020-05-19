using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChapterCade : MonoBehaviour
{
    public Text m_ChapterText;
    public Text m_ChapterName;
    public Text m_ChapterDes;
    public Text m_ChapterTime;
    public Text m_ChapterEva;
    public Button m_ChapterButton;

    public void Init(ChapterCellData _data)
    {
        m_ChapterText.text = GetChapterText(_data.m_ChpaterNum, _data.m_PointNum);
        m_ChapterName.text = _data.m_ChapterName;
        m_ChapterDes.text = _data.m_ChapterDes;
        m_ChapterTime.text = GetChapterTime(_data.m_Minute, _data.m_Scend);
        m_ChapterEva.text = ((Eva)_data.m_ChapterEva).ToString();
    }

    public string GetChapterText(int _cNum, int _pNum)
    {
        return _cNum.ToString() + "_" + _pNum.ToString();
    }

    public string GetChapterTime(int _m, int _s)
    {
        string kMinute = _m.ToString();
        string kScend = _s.ToString();
        if (_m < 10)
        {
            kMinute = "0" + _m.ToString();
        }
        if (_s < 10)
        {
            kScend = "0" + _s.ToString();
        }
        return kMinute + ":" + kScend;
    }
}