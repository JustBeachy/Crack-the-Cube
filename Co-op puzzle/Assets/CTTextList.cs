using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CTTextList : MonoBehaviour
{
    GameObject Master;
    public TextMeshPro[] list;
    // Start is called before the first frame update
    void Start()
    {
        Master = GameObject.FindGameObjectWithTag("ColorTwisterMaster");
        Master.GetComponent<ColorTwister>().colorTexts = list;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
