using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOrRotate : MonoBehaviour
{
    public bool isRotateButton;
    public GameObject Ball, Launcher;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        if (isRotateButton && !Ball.GetComponent<Ball>().move)
            Launcher.transform.Rotate(Vector3.forward, 90 * Time.deltaTime, Space.Self);
        else
            Ball.GetComponent<Ball>().Fire();
    }

}
