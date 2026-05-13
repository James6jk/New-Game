using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public int score1 = 0;
    public int score2 = 0;
    
    public TextMeshPro PlayerScore;
    public TextMeshPro Player2Score;
    
    public TextMeshPro TimerText;
    public float timer = 90f;
   
    public GameObject Player1;
    public GameObject Player2;
    
    public float kickP = 15f;
    public float kickR = 1.5f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            TimerText.text = "Time: " + Mathf.CeilToInt(timer).ToString();
        }
        else
        {
            timer = 0;
            TimerText.text = "Time: 0";
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime;
            TimerText.text = "Time: " + Mathf.CeilToInt(timer).ToString();
        }
        else
        {
            timer = 0;
            if (score1 > score2) SceneManager.LoadScene("Player1win");
            if (score2 > score1) SceneManager.LoadScene("Player2win");
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HandleKick(Player1);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            HandleKick(Player2);
        }
        
       
    }

    void HandleKick(GameObject player)
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
    
        if (distance <= kickR)
        {
            Vector2 kickDir = (transform.position - player.transform.position).normalized;
        
            GetComponent<Rigidbody2D>().AddForce(kickDir * kickP, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Goal1")) 
        {
            score1++;
            UpdateScore();
            ResetGame(); 

        }
        if (other.gameObject.CompareTag("Goal")) 
        {
            score2++;
            UpdateScore();
            ResetGame(); 

        }
        
    }
    
    public void UpdateScore()
    {
        PlayerScore.text = score1.ToString();
        
        Player2Score.text = score2.ToString();


    }
    void ResetGame()
    {
        transform.position = new Vector2(0, 0); 
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;

        Player1.transform.position = new Vector2(-7, 0);
        
   
        Player2.transform.position = new Vector2(7, 0);
        
    }

}


