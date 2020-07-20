using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject GameObject;
    public float height;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newGameObject = Instantiate(GameObject);
            newGameObject.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newGameObject, 15);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
