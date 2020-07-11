using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFace : MonoBehaviour
{
    public GameObject completeLight, p1, p2;
    public Material greenLight;
    public GameObject locked;
    public bool isFinal = false;
    public bool isComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        if (StaticVars.PlayerNumber == 2) //activate puzzle based on player
        {
            p1.SetActive(false);
            p2.SetActive(true);
        }
        else
        {
            p2.SetActive(false);
            p1.SetActive(true);
        }

       if(isFinal&& StaticVars.PlayerNumber == 1)
        {
            locked.SetActive(true);
            p1.SetActive(false);
            p2.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckAllDone())
            UnlockFinal();
    }

    public void Complete()
    {
        completeLight.GetComponent<MeshRenderer>().material = greenLight;
        isComplete = true;

        if (CheckAllDone())
            UnlockFinal();
    }

    public void UnlockFinal()
    {
        if(isFinal)
        locked.SetActive(false);

        if (StaticVars.PlayerNumber == 2) //activate puzzle based on player
        {
            p1.SetActive(false);
            p2.SetActive(true);
        }
        else
        {
            p1.SetActive(true);
            p2.SetActive(false);
        }

    }

    bool CheckAllDone()
    {
        var lightList = GameObject.FindGameObjectsWithTag("Face");
        foreach (GameObject G in lightList)
        {
            if (!G.GetComponent<PuzzleFace>().isComplete)
                return false;

        }
        return true;
    }
}
