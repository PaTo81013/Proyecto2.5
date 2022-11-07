using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI UIScore;
    private float hp=3;
    private float score=0;
    public float HP => hp;
    public float Score => score;
     void Start()
    {
        UIScore.text = Score.ToString("Score: " + Score);
    }
    public void IncreaseScore(float plus)
    {
        score += plus;
        UIScore.text = Score.ToString("Score: " + Score);
    }
    
}
