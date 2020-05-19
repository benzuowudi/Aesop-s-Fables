using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager
{
    private static PathManager Instance;
    public static PathManager GetInstance()
    {
        if (Instance == null)
        {
            Instance = new PathManager();
        }
        return Instance;
    }

    public string ReturnPath()
    {
        return "";
    }

    public string ReturnPath(ResourcsePath _rPath)
    {
        string kPath = _rPath.ToString();
        return kPath;
    }

    public string ReturnPath(ResourcsePath _rPath, PrefabPath _pPath)
    {
        string kPath = _rPath.ToString() + _pPath.ToString();
        return kPath;
    }

    public string ReturnPath(ResourcsePath _rPath, string _name)
    {
        string kPath = _rPath.ToString() + _name;
        return kPath;
    }

    public string ReturnPath(ResourcsePath _rPath, PrefabPath _pPath,string _name)
    {
        string kPath = _rPath.ToString() + _pPath.ToString() + _name;
        return kPath;
    }
}