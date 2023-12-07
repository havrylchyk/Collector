using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICatFactory 
{
    GameObject CreateCat(Vector3 position);
}
