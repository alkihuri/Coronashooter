using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject [] enemies;
    public GameObject enemyPrefab;
    public GameObject [] pointOfSapawn;
    public bool gameIsOn;
    int countOfEnemy;
    float timer;
    public UnityEngine.UI.Text enemiesCounter;
    public UnityEngine.UI.Text level; 
    void Start()
    {
      timer = 0;
      countOfEnemy = 1;
        pointOfSapawn = GameObject.FindGameObjectsWithTag("Respawn");

        GameStatistic.playerUnderAttack = false; 
       
    }


    private void OnTriggerExit(Collider other)
    {
       
        SceneManager.LoadScene("FinishScene");
    }
    private void OnTriggerStay(Collider other)
    {
      
    }
    // Update is called once per frame
     
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        int numOfEnemies = enemies.Length;

        GameStatistic.lvl = numOfEnemies;
        

         

        try
        {
            enemiesCounter.text = "Num of Enemies - " + numOfEnemies.ToString() ;
        }
        finally
        {

        }

        
        timer = timer  +  Time.deltaTime;
        level.text = "Lvl - " + countOfEnemy.ToString();
        if (timer > 9.99 )
            {
                timer = 0;
             
                SpawnEnemy(countOfEnemy);
                
                countOfEnemy++;

            }
            else
            {
                
            }
      

    }


    public void SpawnEnemy(int count)
    {
        for(int i =0;i < count; i++)
            Instantiate(enemyPrefab, pointOfSapawn[Random.Range(0,2)].transform.position, new Quaternion(0,0,0,0));
    }
}
