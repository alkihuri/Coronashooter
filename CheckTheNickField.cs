using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckTheNickField : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public InputField inf;
    public Button btn;
    // Update is called once per frame
    void Update()
    {
        if(inf.text.Length > 3 && inf.text.Length < 10)
        {
            btn.interactable = true;
        }
        else
        {
            btn.interactable = false; 
        }
    }
}
