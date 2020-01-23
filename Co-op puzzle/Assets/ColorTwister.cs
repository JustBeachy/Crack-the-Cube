using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorTwister : MonoBehaviour
{
    public TextMesh[] colorTexts;
    public Color[] colors;
    public string [] Textnames;
    public List<int> combo;
    // Start is called before the first frame update
    void Start()
    {
        Colorize();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Colorize()
    {
        for (int x = 0; x < colorTexts.Length; x++)
        {

           int ranNum = Random.Range(0, 4);
            colorTexts[x].text = Textnames[ranNum]; //random color name
            int ranNum2= Random.Range(0, 4); 
            while (ranNum2 == ranNum) //make sure no duplicate color/text
                Random.Range(0, 4);
            colorTexts[x].color = colors[ranNum2];

            combo.Add(ranNum2);//set combo
        }
    }

}
