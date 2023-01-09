using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tab : MonoBehaviour
{
    public GameObject _item;
    public int _ID;
    public string _type;
    public string _description;
    
    public bool _empty;
    public Sprite _icon;

    public Transform _slotIconGameObject;
    public GameObject _view;

    private void Start()
    {
        _slotIconGameObject = transform.GetChild(0);
    }

    public void UpdateSlot()
    {
        _slotIconGameObject.GetComponent<Image>().sprite = _icon;
    }
}
