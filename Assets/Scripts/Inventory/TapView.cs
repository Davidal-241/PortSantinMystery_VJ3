using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapView : MonoBehaviour
{
    public GameObject _item;
    public Transform _slotTapView; 
    public bool _empty;

    // Start is called before the first frame update
    void Start()
    {
        _slotTapView = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
