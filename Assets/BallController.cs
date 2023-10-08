using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
    //スコアを表示するテキスト
    private GameObject scoretext;
    //大きい雲の得点
    private int Lcloud = 100;
    //小さい雲の得点
    private int Scloud = 5;
    //大きい星の得点
    private int Lstar = 10;
    //小さい星の得点
    private int Sstar = 1;
    //スコア
    private int score = 0;
     

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoretext = GameObject.Find("Scoretext");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if(this.transform.position.z<this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
        

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += Lcloud;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += Scloud;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            score += Lstar;
        }
        else if (collision.gameObject.tag == "SmallStarTag")
        {
            score += Sstar;
        }
        //Scoretextにスコアを表示
        this.scoretext.GetComponent<Text>().text = "Score:"+this.score.ToString();
        //Debug.Log("Hit" + collision.gameObject.name);

    }
}
