using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyboardPopup : MonoBehaviour
{
    TouchScreenKeyboard keyboard;
    string check;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        keyboard = TouchScreenKeyboard.Open("");

        if (keyboard != null)
        {
            check = keyboard.text;
            if (check.ToLower() == "complete")
                SceneManager.LoadScene(0);

        }
    }
}
