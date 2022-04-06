using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.RemoteConfig;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    private int ScoreNumber = 0;

    public struct userAttributes
    {

    }

    public struct appAttributes
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        ConfigManager.FetchCompleted += ConfigureManager_FetchCompleted;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
    }


    private void ConfigureManager_FetchCompleted(ConfigResponse obj)
    {
        switch(obj.requestOrigin)
        {
            case ConfigOrigin.Default:
                Debug.Log("Asetuksia ei nyt ladattu, käytä oletusarvoja");
                ScoreNumber = 0;
                ScoreText.text = "Your score is: " + ScoreNumber.ToString();
                break;
            case ConfigOrigin.Cached:
                Debug.Log("Asetukset ladattu välimuistista");
                ScoreNumber = ConfigManager.appConfig.GetInt("scoreCloud", 0);
                ScoreText.text = "Your score is" + ScoreNumber.ToString();
                break;
            case ConfigOrigin.Remote:
                Debug.Log("Asetukset ladattu pilvestä");
                ScoreNumber = ConfigManager.appConfig.GetInt("scoreCloud", 0);
                ScoreText.text = "Your score is: " + ScoreNumber.ToString();
                break;
        }
    }
   
    // Update is called once per frame
    void Update()
    {

    }
}