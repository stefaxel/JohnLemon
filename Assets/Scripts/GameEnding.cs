using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{

    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;

    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;

    private bool m_IsPlayerAtExit;
    private float m_Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_IsPlayerAtExit)
        {
            EndLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    void EndLevel()
    {
        m_Timer += Time.deltaTime;
        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;

        if(m_Timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }
    }
}
