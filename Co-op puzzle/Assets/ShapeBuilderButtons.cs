using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBuilderButtons : MonoBehaviour
{
    Sprite childImage;
    public GameObject answerSlot;
    public bool isCorrect;
    // Start is called before the first frame update
    void Start()
    {
        childImage = gameObject.GetComponentInChildren<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        answerSlot.GetComponent<BuilderSlots>().isCorrect = isCorrect;
        answerSlot.GetComponent<BuilderSlots>().CheckComplete();
        answerSlot.GetComponentInChildren<SpriteRenderer>().sprite = childImage;
    }

}
