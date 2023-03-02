using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0,0);
    }
    void LateUpdate()
    {
        transform.rotation = Quaternion.identity;
    }
}
