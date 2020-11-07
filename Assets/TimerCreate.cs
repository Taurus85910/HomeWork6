using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCreate : MonoBehaviour
{
    private CreateRobber[] _portals;
    private void Start()
    {
        _portals = gameObject.GetComponentsInChildren<CreateRobber>();
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        for (int i = 0; i < _portals.Length; i++)
        {
            _portals[i].Spawn();
            


            if (i == _portals.Length - 1)
                 i = -1;
            yield return new WaitForSeconds(2);
        }      
    }



}
