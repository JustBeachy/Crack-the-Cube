using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtons : MonoBehaviour
{
    public GameObject Master;
    
    public int number;

    // Start is called before the first frame update
    void Start()
    {
        Master = GameObject.FindGameObjectWithTag("ColorTwisterMaster");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        
        print("click");
        var combo = Master.GetComponent<ColorTwister>();
        if(combo.userCombo.Count<10)
        combo.userCombo.Add(number);
        if(combo.userCombo[combo.userCombo.Count-1]!=combo.combo[combo.userCombo.Count-1]) //if combo is wrong
        {
            combo.userCombo.Clear();
            combo.userCombo.TrimExcess();
            combo.userCombo.Add(number);
        }
        else if (combo.userCombo.Count==10) // if combo is right
        {
            print("solved");
        }

            


     
    }
}
