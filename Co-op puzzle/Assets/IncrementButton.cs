using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IncrementButton : MonoBehaviour
{
    TextMeshPro numText;
    int currentNum = 1;
    public int CorrectNumber;
    public GameObject Face;
    // Start is called before the first frame update
    void Start()
    {
        numText = GetComponentInChildren<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        currentNum++;
        if (currentNum > 9)
            currentNum = 1;
        numText.text = currentNum.ToString();

        if (CheckCorrect())
            Face.GetComponent<PuzzleFace>().Complete();
    }

    bool CheckCorrect()
    {
        var lightlist = GameObject.FindGameObjectsWithTag(gameObject.tag);
        foreach (GameObject L in lightlist)
        {
            if (L.GetComponent<IncrementButton>().currentNum != L.GetComponent<IncrementButton>().CorrectNumber)
                return false;

        }
        return true;
    }
}
