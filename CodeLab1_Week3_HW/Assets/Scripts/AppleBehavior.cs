using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AppleBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.Instance.Score++;
        transform.position = new Vector2(Random.Range(-7, 7), Random.Range(-5, 5));
    }
}
