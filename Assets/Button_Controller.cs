using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Controller : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {
       
    }
  
    public void Play() => Application.LoadLevel(1);
    public void exit() => Application.Quit();
    
    public void menu() => Application.LoadLevel(0);
}
