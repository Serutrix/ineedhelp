using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointi : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score = 0;

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();

    }
}
