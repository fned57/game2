using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Di_Chuyen : MonoBehaviour
{
    // Start is called before the first frame update
    public float SpeedDiChuyen = 5f;
    public Animator animator;
    public Canvas canvas;
    public Canvas CanhBaoCanvas;
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        

        animator.SetInteger("legs", 5);
     

        DiChuyen(SpeedDiChuyen,1);
        if (Input.GetKey(KeyCode.LeftShift)){
            DiChuyen(SpeedDiChuyen *1.5f, 2);
        }


        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 45f);

        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 45f);

        }
        
       
        

    }
    void DiChuyen(float SpeedDiChuyen, int a)
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * SpeedDiChuyen);
            animator.SetInteger("legs", a);
           
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * SpeedDiChuyen);
            animator.SetInteger("legs",a);
           
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * SpeedDiChuyen);
            animator.SetInteger("legs", a);
           

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * SpeedDiChuyen);
            animator.SetInteger("legs", a);
         
        }
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Duong"))
        {
            
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Duong"))
        {
            CanhBaoCanvas.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Duong"))
        {
            CanhBaoCanvas.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("oto"))
        {
            Time.timeScale = 0;
            canvas.gameObject.SetActive(true);
        }
    }
}
