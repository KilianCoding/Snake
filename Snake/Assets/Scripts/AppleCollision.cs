using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleCollision : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreText.text = score.ToString();
        var newX = Random.RandomRange(-29, 29);
        var newY = Random.RandomRange(-14, 14);
        this.transform.position = new Vector2 (newX, 14);
    }
}
