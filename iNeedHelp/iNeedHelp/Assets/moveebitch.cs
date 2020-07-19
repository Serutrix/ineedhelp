using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class moveebitch : MonoBehaviour
{

    public float meoww;





    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * meoww * Time.deltaTime;
    }
}
