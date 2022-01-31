using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    public PlayerData playerData;
    public BasketMovement bm;

   
    public Text nameText;
    public Text scoreText;
    public Text timerText;

   
    public float timerTime = 60f;
    

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = playerData.playerName;
        playerData.playerScore = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + playerData.playerScore.ToString();

        if (timerTime > 0)
        {
            timerTime -= Time.deltaTime;

            ShowTimeRight(timerTime);
        }
        else
        {
            timerTime = 0;
            SceneManager.LoadScene("EndScene");
        }
        
    }

    void ShowTimeRight(float timer)
    {
        timer += 1;

        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt(timer % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
