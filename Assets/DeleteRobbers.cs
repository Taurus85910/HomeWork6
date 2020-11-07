﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteRobbers : MonoBehaviour
{
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Robber>(out Robber robber))
            Destroy(collision.gameObject);
    }
}
