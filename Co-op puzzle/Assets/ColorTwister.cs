using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class ColorTwister : MonoBehaviour
{
    public TextMeshPro[] colorTexts;
    public Color[] colors;
    public List<int> combo;
    public List<int> userCombo;
    public Material[] Materials;
    public GameObject Player1Puzzle;
    public GameObject Player2Puzzle;
    // Start is called before the first frame update
    void Start()
    {
        combo.Add(1);
        combo.Add(2);
        combo.Add(3);
        combo.Add(0);
        combo.Add(4);
        combo.Add(2);

        Colorize();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (combo == userCombo)
            print("correct");

        if (Input.GetKeyDown(KeyCode.C))
        {
           
        }//remove after testing 
    }
   
    void Colorize()
    {
        
          

                colorTexts[0].faceColor = colors[1];
                colorTexts[1].faceColor = colors[2];
                colorTexts[2].faceColor = colors[3];
                colorTexts[3].faceColor = colors[0];
                colorTexts[4].faceColor = colors[4];
                colorTexts[5].faceColor = colors[2];


                
       
    }

}
