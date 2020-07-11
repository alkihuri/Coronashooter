using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerHealth;
    public GameLogic gamelogic;
    Text hp;
    void Start()
    {
        playerHealth = 100;
        hp = GameObject.Find("HealthPoints").GetComponent<Text>();
    }
    public void TakeDamage(int a)
    {
        playerHealth-= a;
       
    }
    // Update is called once per frame
    void Update()
    {
        
        if(playerHealth < 0)
        {
            SceneManager.LoadScene("FinishOnlineScene");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        hp.text = "health " + playerHealth.ToString();
        if (other.tag == "Enemy")
            TakeDamage(1);
    }
}
