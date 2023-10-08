using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;
    //�X�R�A��\������e�L�X�g
    private GameObject scoretext;
    //�傫���_�̓��_
    private int Lcloud = 100;
    //�������_�̓��_
    private int Scloud = 5;
    //�傫�����̓��_
    private int Lstar = 10;
    //���������̓��_
    private int Sstar = 1;
    //�X�R�A
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
        //�{�[������ʊO�ɏo���ꍇ
        if(this.transform.position.z<this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
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
        //Scoretext�ɃX�R�A��\��
        this.scoretext.GetComponent<Text>().text = "Score:"+this.score.ToString();
        //Debug.Log("Hit" + collision.gameObject.name);

    }
}
