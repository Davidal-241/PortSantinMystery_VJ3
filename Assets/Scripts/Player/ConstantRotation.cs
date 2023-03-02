using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    private void Start()
    {
       
    }
    void LateUpdate()
    {
        transform.rotation = Quaternion.identity;
    }
}
