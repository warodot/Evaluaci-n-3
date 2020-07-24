using UnityEngine;

public class HoopBehaviour:MonoBehaviour
{
    ScoreBehaviour score;
    public float selfDestructTime = 15;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("CanvasScore").GetComponent<ScoreBehaviour>();
        timer = selfDestructTime;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0 )
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            score.AddScore(10);
        }
    }
}
