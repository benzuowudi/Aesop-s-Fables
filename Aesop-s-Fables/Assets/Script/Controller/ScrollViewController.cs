using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewController : GameControlle
{
    public override void InitController(object o)
    {
        base.InitController(o);
    }

    public override void ControllerEvent()
    {
        base.ControllerEvent();
    }

    public void ShowCade<T>(Transform _parent, int _cellH, string _path, int _num, List<T> _list)
    {
        _parent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, _cellH * _list.Count);
        for (int i = 0; i < _num; i++)
        {
            int temp = i;
            GameObject kObj = Instantiate<GameObject>(Resources.Load<GameObject>(_path));
            _list.Add(kObj.GetComponent<T>());
            kObj.transform.SetParent(_parent);
        }
    }
}