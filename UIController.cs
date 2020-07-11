using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text hostAdres;

    public Text playerHealth_text;

     public void SetNick(InputField inf )
    {
        if(inf.text.Length > 3)
            GameStatistic.nickName = inf.text;
    

    }


    void Start()
    {
        hostAdres.enabled = GameStatistic.isServerMode;
        try
        { 
            if (GameStatistic.isServerMode)
            {
                 
                 hostAdres.text = GameStatistic.ipAdrFromHost;
            }
            else
            {

            }
        }
        finally
        {

        }
          
       // Cursor.lockState = CursorLockMode.None;
    }
    public void StartGame()
    {

        Application.OpenURL("https://www.t.me/alkihuri");
    }

    public void StartMsg()
    {

    }

    public void StartGameScene()
    {
        SceneManager.LoadScene("Game");

    }
    public void StartStartScene()
    {
        SceneManager.LoadScene("StartScene");

    }

    public void StartServerScene()
    {
        SceneManager.LoadScene("SetServerAdres");

    }
   
    public void StartOnlineGameScene()
    {
        SceneManager.LoadScene("GameOnline");

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Update is called once per frame
    void Update()
    {
         

    }

}
