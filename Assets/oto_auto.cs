using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oto_auto : MonoBehaviour
{
    public float speed = 6f;
    int Di = 1;
    float rotation_y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.x < -40f && transform.position.x > -42f)
        {
            if (transform.position.z > -22f && transform.position.z < -21f)
            {
                transform.position = new Vector3(-41.2f, -2.7f, -22.2f);
            }
        }
        else if (transform.position.x > -39f && transform.position.x < -36f)
        {
            if (transform.position.z > -54f && transform.position.z < -53f)
            {

                transform.position = new Vector3(-37.92f, -2.7f, -53.38f);
            }
        }
        if ( transform.position.x <-200f || transform.position.z > 85f)
        {
            transform.position = new Vector3(-89.9f, -2.7f, 3.7f);
            transform.localRotation = Quaternion.Euler(0, -90, 0);
        }
        else if(transform.position.z < -120f )
        {
            transform.position = new Vector3(-37.8f, -2.7f, -119f);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if(transform.position.z > 8f)
        {
            transform.position = new Vector3(78.3f, -2.7f, -67.4f);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("no_duong"))
        {
            int a = Random.Range(0, 20);
            
            if(a < 3)
            {
                transform.position = new Vector3(78.3f, -2.7f, -67.4f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            else if(a<6)
            {
                transform.position = new Vector3(-37.8f, -2.7f, -119f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            else if(a<9)
            {
                transform.position = new Vector3(-89.9f, -2.7f, 3.7f);
                transform.localRotation = Quaternion.Euler(0, -90, 0);
            }
            else
            {
                transform.position = new Vector3(-154.7f, -2.7f, -43.6f);
                transform.localRotation = Quaternion.Euler(0, 90, 0);
            }

               
        }
        if (other.tag.Equals("nga"))
        {
            rotation_y = transform.rotation.y * 10;
        }
        
        if (other.name.Equals("t_r"))
        {
            Di = Random.Range(0, 10);
            Di = Di > 5 ? 0 : 1;
        }
        else if (other.name.Equals("l_r"))
        {
            Di = Random.Range(0, 10);
            Di = Di > 5 ? 1 : 2;
        }
        else if (other.name.Equals("t_l"))
        {
            Di = Random.Range(0, 10);
            Di = Di > 5 ? 0 : 2;
            Di = 0;
        }
        else if (other.name.Equals("t_r_l"))
        {
            Di = Random.Range(0, 10);
            if (Di < 3)
                Di = 0;
            else if (Di < 6)
                Di = 1;
            else
                Di = 2;
        }
        else if (other.name.Equals("t"))
        {
            Di = 0;
        }else if (other.name.Equals("r"))
        {
            Di = 1;
        }
        else if (other.name.Equals("test"))
        {
            Di = 1;
        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("nga"))
        {
            
            if (Di == 1)
                transform.Rotate(Vector3.down * Time.deltaTime * 20f);
            else if (Di == 2)
                transform.Rotate(Vector3.up );
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("nga"))
        {
            if (Di == 1)
            {
                if (rotation_y >= 5f)
                {
                    transform.localRotation = Quaternion.Euler(0, 0, 0);
                    
                }
                else if (rotation_y >= -2f)
                {
                    transform.localRotation = Quaternion.Euler(0, -90, 0);
                }
                    
                else if (rotation_y >= -8f)
                {
                    transform.localRotation = Quaternion.Euler(0, -180, 0);
                }
                else
                {
                    transform.localRotation = Quaternion.Euler(0, 90, 0);
                }

            }else if(Di == 2)
            {
                if (rotation_y >= 5f)
                {
                    transform.localRotation = Quaternion.Euler(0, 180, 0);
                }
                else if (rotation_y >= -2f)
                {
                    transform.localRotation = Quaternion.Euler(0, 90, 0);
                }

                else if (rotation_y >= -8f)
                {
                    transform.localRotation = Quaternion.Euler(0, 0, 0);

                }
                else
                {
                    transform.localRotation = Quaternion.Euler(0, -90, 0);
                }
            }
                
        }
    }
}
