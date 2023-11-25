using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    private string[] catPaths = {
        "Collection/Cat-1-Sitting_0",
        "Collection/Cat-3-Sitting_0"
    };

    private void Start()
    {
        InvokeRepeating("GenerateRandomCat", 0f, 2f);
    }

    private void GenerateRandomCat()
    {
        int randomIndex = Random.Range(0, catPaths.Length);
        string randomCatPath = catPaths[randomIndex];

        var catPrefab = Resources.Load<GameObject>(randomCatPath);

        if (catPrefab == null)
        {
            Debug.LogError("Prefab not found at path: " + randomCatPath);
            return;
        }

        float randomX = Random.Range(-20f, 20f);
        float randomY = 20f + Random.Range(1f, 10f);
        var randomPosition = new Vector3(randomX, randomY, 0f);

        var catInstance = Instantiate(catPrefab, randomPosition, Quaternion.identity);

        Rigidbody2D catRigidbody = catInstance.GetComponent<Rigidbody2D>();

        if (catRigidbody == null)
        {
            catRigidbody = catInstance.AddComponent<Rigidbody2D>();
        }

        catRigidbody.gravityScale = 0.1f;

    }
}
