using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public float clickDepth;
    Vector3 localStartPos;
    public AudioClip soundWhenPressed;

    void Start()
    {
        localStartPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            transform.localPosition = localStartPos;
        }
    }

    private void OnMouseDown()
    {
        transform.localPosition -= new Vector3(0, clickDepth, 0);
        if (soundWhenPressed != null)
        {
            GameObject.FindGameObjectWithTag("AudioMaster").GetComponent<AudioSource>().clip = soundWhenPressed;
            GameObject.FindGameObjectWithTag("AudioMaster").GetComponent<AudioSource>().Play();
        }
    }
}
