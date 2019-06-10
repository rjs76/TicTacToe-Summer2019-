using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinConEasy : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image image7;
    public Image image8;
    public Image image9;

    public List<ThreebyThree> Squares;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Squares[0].type == Squares[1].type && Squares[1].type == Squares[2].type)
        {
            if (Squares[0].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[0].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }
    }

    public void Wincon() {

        


    }

}
