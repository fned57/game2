using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeoConroller : MonoBehaviour
{
    // Start is called before the first frame update
    bool timdc = false;
    public GameObject people;
    public Canvas canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetInteger("legs", 0);
        if (timdc)
        {
            float x, y, z;
            x = people.transform.position.x;
            y = people.transform.position.y;
            z = people.transform.position.z;
            //Meo.transform.position = transform.transform.position;

            transform.rotation = people.transform.rotation;

            transform.position = new Vector3(x - 1, y, z - 1);
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
                GetComponent<Animator>().SetInteger("legs", 1);
        }
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Custom simple human_prefab_test"))
        {
            timdc = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name.Equals("GameObject (2)"))
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            
        }
    }

}

