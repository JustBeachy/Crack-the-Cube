using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class PuzzleBlock : MonoBehaviour
{
    float mousex;
    float mousey;
    public GameObject[] Modules;
    public GameObject TestMaster;
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

        if (PhotonNetwork.IsMasterClient)
        {
           
            var p1= PhotonNetwork.Instantiate(Path.Combine("Prefabs", "ColorTwisterP1"), transform.position, Quaternion.identity);
            p1.transform.parent = gameObject.transform;

           // PhotonNetwork.InstantiateSceneObject(Path.Combine("Prefabs", "ColorTwisterMaster"), transform.position, Quaternion.identity);
        }
        else
        {

            var p2 = PhotonNetwork.Instantiate(Path.Combine("Prefabs", "ColorTwisterP2"), transform.position, Quaternion.identity);
            p2.transform.parent = gameObject.transform;
        }


    }

    // Update is called once per frame
    void Update()
    {
        object[] disable = GameObject.FindGameObjectsWithTag("Puzzle"); //hide objects not owned by the user
        foreach (GameObject g in disable)
        {
            if(!g.GetComponent<PhotonView>().IsMine)
            g.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        mousex = Input.mousePosition.x;
        mousey = Input.mousePosition.y;
    }

    private void OnMouseDrag()
    {
        transform.Rotate(new Vector3( Input.mousePosition.y-mousey,mousex - Input.mousePosition.x, 0));
        OnMouseDown();
    }
}
