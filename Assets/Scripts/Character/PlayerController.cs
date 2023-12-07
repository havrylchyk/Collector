using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] private int cats;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<Catch>(out var cat)) 
            {
                var catValue = cat.Collect();
                cats += catValue;
            }
        }

    }
  
}
