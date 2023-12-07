using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    private ICatFactory catFactory;

    private void Start()
    {
        catFactory = new RandomCatFactor();
        InvokeRepeating("GenerateRandomCat", 0f, 2f);
    }

    private void GenerateRandomCat()
    {
        float randomX = Random.Range(-20f, 20f);
        float randomY = 20f + Random.Range(1f, 10f);
        var randomPosition = new Vector3(randomX, randomY, 0f);

        var catInstance = catFactory.CreateCat(randomPosition);
    }
}
