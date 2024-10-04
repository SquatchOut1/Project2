using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    [SerializeField] private Button tryAgain;
    [SerializeField] private TextMeshProUGUI totalShots;
    [SerializeField] private TextMeshProUGUI HighScore;
    // Start is called before the first frame update
    void Start()
    {
        tryAgain.onClick.AddListener(OnGameStart);
        totalShots.text = "Total Shots: " + MissionDemolition.totalShots.ToString();
        if(!PlayerPrefs.HasKey("HighScore")) {
            HighScore.text = "HighScore: " + MissionDemolition.totalShots.ToString();
            PlayerPrefs.SetInt("Highscore", MissionDemolition.totalShots);
        } 
        else {
            if(MissionDemolition.totalShots < PlayerPrefs.GetInt("HighScore")) {
                PlayerPrefs.SetInt("Highscore", MissionDemolition.totalShots);
            }
            HighScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGameStart() {
        SceneManager.LoadScene("Game");
    }
}
