using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCatFactor: MonoBehaviour, ICatFactory
{
        private string[] catPaths = {
        "Collection/Cat-1-Sitting_0",
        "Collection/Cat-3-Sitting_0"
    };

        public GameObject CreateCat(Vector3 position)
        {
            int randomIndex = Random.Range(0, catPaths.Length);
            string randomCatPath = catPaths[randomIndex];

            var catPrefab = Resources.Load<GameObject>(randomCatPath);

            if (catPrefab == null)
            {
                Debug.LogError("Prefab not found at path: " + randomCatPath);
                return null;
            }

            var catInstance = Instantiate(catPrefab, position, Quaternion.identity);

            Rigidbody2D catRigidbody = catInstance.GetComponent<Rigidbody2D>();

            if (catRigidbody == null)
            {
                catRigidbody = catInstance.AddComponent<Rigidbody2D>();
            }

            catRigidbody.gravityScale = 0.1f;

            return catInstance;
        }
    }