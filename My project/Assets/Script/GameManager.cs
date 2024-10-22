using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int score { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //�X�^�[�g���\�b�h
    public void StartGame()
    {
        //SceneData.score = 0;
            SceneManager.LoadScene("Title");
    }

    //�G���h���\�b�h
    public void EndGame()
    {
        //�l�������X�R�A�ƃ��U���g��ʂ֑J��
        //SceneData.score = ScoreScript.instance.GetCurrentScore();

        SceneManager.LoadScene("GameOver");
    }
}
