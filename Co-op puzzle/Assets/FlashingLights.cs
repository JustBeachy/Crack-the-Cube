using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLights : MonoBehaviour
{
    Material lightOffMat;
    public Material lightOnMat;
    float timer;
    public float delay;
    public int flashAmount;
    int flashcountdown;
    
    // Start is called before the first frame update
    void Start()
    {
        lightOffMat = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
       
        timer += Time.deltaTime;

        if(timer>=delay)
        {
            flashcountdown = flashAmount;
            StartCoroutine(Flash());
            timer = -2;
           
        }
    }

    private IEnumerator Flash()
    {
        GetComponent<MeshRenderer>().material=lightOnMat;
        flashcountdown--;

       
        yield return new WaitForSeconds(.2f);

        GetComponent<MeshRenderer>().material = lightOffMat;

        if (flashcountdown > 0)
        {
            yield return new WaitForSeconds(.2f);
            StartCoroutine(Flash());
        }

       
    }
}
