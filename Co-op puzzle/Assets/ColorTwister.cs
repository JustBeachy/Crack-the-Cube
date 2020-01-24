using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;


public class ColorTwister : MonoBehaviourPunCallbacks
{
    public TextMeshPro[] colorTexts;
    public Color[] colors;
    public string [] Textnames;
    public List<int> combo;
    public List<int> userCombo;
    public Material[] Materials;
    public GameObject Player1Puzzle;
    public GameObject Player2Puzzle;
    // Start is called before the first frame update
    void Start()
    {
        Colorize();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (combo == userCombo)
            print("correct");

        if (Input.GetKeyDown(KeyCode.C))
        {
            PhotonView photonView = PhotonView.Get(this);
            photonView.RPC("Colorize", RpcTarget.All);
        }//remove after testing 
    }
    [PunRPC]
    void Colorize()
    {
        try
        {
            for (int x = 0; x < colorTexts.Length; x++)
            {

                int ranNum = Random.Range(0, 5);
                colorTexts[x].text = Textnames[ranNum]; //random color name
                int ranNum2 = Random.Range(0, 5);
                while (ranNum2 == ranNum) //make sure no duplicate color/text
                    ranNum2 = Random.Range(0, 5);
                colorTexts[x].faceColor = colors[ranNum2];

                combo.Add(ranNum2);//set combo
            }
        }
        catch
        {
           
        }
    }

}
