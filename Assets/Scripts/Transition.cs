using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public float time;
    private float _currentTime = 0;
    private bool _isTransited = false;
    
    public GameObject nextObject;
    
    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= time && !_isTransited)
        {
            _isTransited = true;
            nextObject.SetActive(true);
        }
    }

    public void ResetTransition()
    {
        _currentTime = 0;
        _isTransited = false;
    }
}
