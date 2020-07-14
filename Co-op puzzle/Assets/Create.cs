using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject screenToCreate, screenToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeScreen()
    {
        Instantiate(screenToCreate, GameObject.FindGameObjectWithTag("Canvas").transform);
    }

    public void DestroyScreen()
    {
        Destroy(screenToDestroy);
    }
}
