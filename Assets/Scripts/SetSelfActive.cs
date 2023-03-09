using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSelfActive : MonoBehaviour
{
    public bool isActive;

    public void Set()
    {
        gameObject.SetActive(isActive);
    }
}
