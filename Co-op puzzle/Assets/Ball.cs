using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector3 startPos;
    public bool move = false;
    Transform parent;
    public GameObject Face;
    // Start is called before the first frame update
    void Start()
    {
        
        startPos = transform.localPosition;
        parent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        if(move)
        {
            transform.parent = null;
            transform.localPosition += transform.right * Time.deltaTime * 5;
        }

        if(transform.localPosition.x>2|| transform.localPosition.x <-2 || transform.localPosition.y > 2 || transform.localPosition.y < -2)
        {
            transform.localScale = new Vector3(1, 1, 1);
            move = false;
            transform.parent = parent;
            transform.localPosition = startPos;
        }
    }

    public void Fire()
    {
        move = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Goal")
        {
            Face.GetComponent<PuzzleFace>().Complete();
            gameObject.SetActive(false);
        }
    }
}
