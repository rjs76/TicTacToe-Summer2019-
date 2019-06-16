using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Playermenu()
    {
        SceneManager.LoadScene("player menu");

    }
    public void Playercontrols()
    {
        SceneManager.LoadScene("Playercontrols");
    }
    public void PlayerMark()
    {
        SceneManager.LoadScene("MarkMenu");
    }
    public void DifficultyMenu()
    {
        SceneManager.LoadScene("DifficultyMenu");
    }
    public void QuitNOW()
    {
        Application.Quit();
    }
    public void Easy()
    {
        SceneManager.LoadScene("Easylevel");
    }
    public void Medium()
    {
        SceneManager.LoadScene("Mediumlevel");
    }
    public void Hard()
    {
        SceneManager.LoadScene("Hardlevel");
    }
    public void ContinueEasy()
    {
        SceneManager.LoadScene("ContinueMenu1");
    }
    public void ContinueMedium()
    {
        SceneManager.LoadScene("ContinueMenu2");
    }
    public void ContinueHard()
    {
        SceneManager.LoadScene("ContinueMenu3");
    }

}
