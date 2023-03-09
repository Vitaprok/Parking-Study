using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveToObject : MonoBehaviour
{
    public GameObject obj;
    public bool targetActive;

    public void SetActiveTo()
    {
        obj.SetActive(targetActive);
    }
}
