using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeGen : MonoBehaviour
{
    public int ammount = 2;
    public float spawnRadius = 30;
    public float minRadius = 25;
    public int maxSize = 100;
    public int minSize = 100;
    public GameObject treeObject;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ammount; i++)
        {
            float x = Random.Range(-spawnRadius, spawnRadius);
            float z = Random.Range(-spawnRadius, spawnRadius);
            if (Mathf.Abs(x) + Mathf.Abs(z) < minRadius)
            {
                if (Random.value > 0.5)
                {
                    if (Random.value > 0.5)
                        x = Random.Range(minRadius, spawnRadius);
                    else
                        x = Random.Range(-minRadius, -spawnRadius);
                }
                else
                {
                    if (Random.value > 0.5)
                        z = Random.Range(minRadius, spawnRadius);
                    else
                        z = Random.Range(-minRadius, -spawnRadius);
                }
            }
            GameObject createdTree = Instantiate(treeObject, new Vector3(x, 0, z), Quaternion.identity);
            int randRotation = Random.Range(0, 180);
            float randSize = Random.Range(minSize, maxSize);
            createdTree.transform.Rotate(new Vector3(-90, 0, randRotation));
            createdTree.transform.localScale = new Vector3(randSize, randSize, randSize);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
