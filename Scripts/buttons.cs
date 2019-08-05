using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/** 
 * Holds data and handles the process for changing the X and Os on the grid of the game. 
 * @author Riviere Seguie
 */
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
    /** 
    * Will take you to the specified unity scene
    */
    public void Playermenu()
    {
        SceneManager.LoadScene("player menu");

    }
    /** 
    * Will take you to the specified unity scene
    */
    public void Playercontrols()
    {
        SceneManager.LoadScene("Playercontrols");
    }
    /** 
    * Will take you to the specified unity scene
    */
    public void PlayerMark()
    {
        SceneManager.LoadScene("MarkMenu");
    }
    /** 
    * Will take you to the specified unity scene
    */
    public void DifficultyMenu()
    {
        SceneManager.LoadScene("DifficultyMenu");
    }
    /** 
    * Will quit the application or game when used
    */
    public void QuitNOW()
    {
        Application.Quit();
    }
    /** 
    * Will take you to the specified unity scene
    */
    public void Easy()
    {
        SceneManager.LoadScene("Easylevel");
    }
    /** 
    * Will take you to the specified unity scene
    */
    public void Medium()
    {
        SceneManager.LoadScene("Mediumlevel");
    }
    /** 
    * Will take you to the specified unity scene
    */
    public void Hard()
    {
        SceneManager.LoadScene("Hardlevel");
    }
    /** 
    * Will take you to the specified unity scene
    */
    public void ContinueEasy()
    {
        SceneManager.LoadScene("ContinueMenu1");
    }
    /** 
    * Will take you to the specified unity scene
    */
    public void ContinueMedium()
    {
        SceneManager.LoadScene("ContinueMenu2");
    }
    /** 
    * Will take you to the specified unity scene
    */
    public void ContinueHard()
    {
        SceneManager.LoadScene("ContinueMenu3");
    }

}
