using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNewPlace : MonoBehaviour
{
    public Vector2 newPlace;

    public void ChangePlace()
    {
        transform.localPosition = new Vector3(120, 120, 0);
    }
}
