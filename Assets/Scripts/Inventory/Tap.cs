using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tap : MonoBehaviour
{
    public GameObject _item;
    public int _ID;
    public string _type;
    public string _description;
    
    public bool _empty;
    public Sprite _icon;

    public Transform _slotIconGameObject;

    private void Start()
    {
        _slotIconGameObject = transform.GetChild(0);
    }

    public void UpdateSlot()
    {
        _slotIconGameObject.GetComponent<Image>().sprite = _icon;
    }

    public void UseItem()
    {

    }

}
