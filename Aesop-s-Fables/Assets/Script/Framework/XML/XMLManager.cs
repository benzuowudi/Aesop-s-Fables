using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;

public class XMLManager
{
    private static XMLManager Instance;
    public static XMLManager GetInstance()
    {
        if (Instance == null)
        {
            Instance = new XMLManager();
        }
        return Instance;
    }

    public void CreateData(string _rootName)
    {
        XmlDocument kXmlDoc = new XmlDocument();
        XmlElement root = kXmlDoc.CreateElement(_rootName);

    }

    public XmlNodeList LoadData(string _path, string _node)
    {
        XmlDocument kXmlDoc = new XmlDocument();
        kXmlDoc.Load(_path);
        XmlNodeList kList = kXmlDoc.SelectSingleNode(_node).ChildNodes;
        return kList;
    }

    public void WirteData()
    {

    }
}