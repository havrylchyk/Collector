using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
    [SerializeField] private int catValue;
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private Collider2D collider;

    public int Collect()
    {
        renderer.enabled = false;
        collider.enabled = false;
        return catValue;
    }
}
