using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtons : MonoBehaviour
{
    public GameObject Master;
    
    public int number;

    public GameObject puzzleFace;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnMouseDown()
    {
       
        
        var combo = Master.GetComponent<ColorTwister>();
        if(combo.userCombo.Count<6)
        combo.userCombo.Add(number);
        if(combo.userCombo[combo.userCombo.Count-1]!=combo.combo[combo.userCombo.Count-1]) //if combo is wrong
        {
            combo.userCombo.Clear();
            combo.userCombo.TrimExcess();
            combo.userCombo.Add(number);
        }
        else if (combo.userCombo.Count==6) // if combo is right
        {
            puzzleFace.GetComponent<PuzzleFace>().Complete();
            print("correct");
        }

            


     
    }
}
