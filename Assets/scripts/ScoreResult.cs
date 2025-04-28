using UnityEngine;
using TMPro;

public class ScoreResult : MonoBehaviour
{
    public TextMeshProUGUI scoretex;
    int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = ScoreManager.getscore();
        scoretex.text = string.Format("SCORE:{0}",score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
