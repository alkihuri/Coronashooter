using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour
{
    // Start is called before the first frame update
    public Text tx;
    void Start()
    {
        tx = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tx.text = GameStatistic.nickName + " \n Score : " + GameStatistic.score + " lvl :" + GameStatistic.lvl + " recovered : " + GameStatistic.numOfEnemies; 
    }
}
