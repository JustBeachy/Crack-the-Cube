using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyboardPopup : MonoBehaviour
{
    TouchScreenKeyboard keyboard;
    string check;
    public GameObject winScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(keyboard.status==TouchScreenKeyboard.Status.Done)
        {
            check = keyboard.text;
            if (check.ToLower() == "complete")
                Instantiate(winScreen, GameObject.FindGameObjectWithTag("Canvas").transform);
        }
    }

    private void OnMouseUpAsButton()
    {
        keyboard = TouchScreenKeyboard.Open("");

        
    }
}
