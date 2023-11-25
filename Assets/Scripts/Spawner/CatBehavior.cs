using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehavior : MonoBehaviour
{
    private float groundY = -7.71f;

    private void Update()
    {
        if (transform.position.y <= groundY)
        {
            Destroy(gameObject);
        }
    }
}
