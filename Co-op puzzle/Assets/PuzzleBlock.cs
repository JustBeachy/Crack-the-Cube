using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PuzzleBlock : MonoBehaviour
{
    float mousex;
    float mousey;
    public GameObject[] Modules;
    Random rnd = new Random();
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < Modules.Length; x++)
        {
            int rand = Random.Range(0, 6); //shuffle array
            var holder = Modules[rand];
            Modules[rand] = Modules[x];
            Modules[x] = holder;

        }
        
        Instantiate(Modules[0], Vector3.zero, Quaternion.Euler(new Vector3(0, 0, 0))).transform.parent=gameObject.transform;
        Instantiate(Modules[1], Vector3.zero, Quaternion.Euler(new Vector3(180, 0, 0))).transform.parent = gameObject.transform; 
        Instantiate(Modules[2], Vector3.zero, Quaternion.Euler(new Vector3(-90, 0, 0))).transform.parent = gameObject.transform; 
        Instantiate(Modules[3], Vector3.zero, Quaternion.Euler(new Vector3(90, 0, 0))).transform.parent = gameObject.transform; 
        Instantiate(Modules[4], Vector3.zero, Quaternion.Euler(new Vector3(0, 0, 90))).transform.parent = gameObject.transform; 
        Instantiate(Modules[5], Vector3.zero, Quaternion.Euler(new Vector3(0, 0, -90))).transform.parent = gameObject.transform;

  
       

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetMouseButton(0))//for pc testing
        {
            float rotX = Input.GetAxis("Mouse X") * 400 * Time.deltaTime;
            float rotY = Input.GetAxis("Mouse Y") * 400 * Time.deltaTime;

            transform.Rotate(Vector3.up, -rotX, Space.World);
            transform.Rotate(Vector3.right, rotY, Space.World);
        } 
        */
        
        if (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            
            float rotX = Input.GetTouch(0).deltaPosition.x * 10 * Time.deltaTime;
            float rotY = Input.GetTouch(0).deltaPosition.y * 10 * Time.deltaTime;

            transform.Rotate(Vector3.up, -rotX, Space.World);
            transform.Rotate(Vector3.right, rotY, Space.World);
        }
        
    }


    private void OnMouseDrag()
    {
        //transform.Rotate(new Vector3( Input.mousePosition.y-mousey,mousex - Input.mousePosition.x, 0));
       // OnMouseDown();

   
    }
}
