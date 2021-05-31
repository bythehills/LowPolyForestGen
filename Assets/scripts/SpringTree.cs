using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringTree : MonoBehaviour
{
    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, Random.Range(-90, 90), 0); //generates random rotation on y axis for varied placement
    }

}
