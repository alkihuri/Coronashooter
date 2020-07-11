using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetServerAdress : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField inputField;
    void Start()
    {
        
    }

    public void StartLikeFuckinHost()
    {
        GameStatistic.isServerMode = true;
    }
    public void SetServerAddrecFunc()
    {
        GameStatistic.ipAdrsForClient = inputField.text;
        GameStatistic.isServerMode = false; 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
