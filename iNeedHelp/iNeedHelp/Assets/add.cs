using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        pointi.score++;
    }

}
