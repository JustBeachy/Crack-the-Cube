using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderSlots : MonoBehaviour
{
    public bool isCorrect;
    public GameObject Face;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckComplete()
    {
        var answerlist = GameObject.FindGameObjectsWithTag("ShapeSlot");
        if (answerlist[0].GetComponent<BuilderSlots>().isCorrect && answerlist[1].GetComponent<BuilderSlots>().isCorrect && answerlist[2].GetComponent<BuilderSlots>().isCorrect)
        {
            Face.GetComponent<PuzzleFace>().Complete();
        }
    }
}
