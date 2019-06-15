using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinConMedium : MonoBehaviour
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
    public Image image10;
    public Image image11;
    public Image image12;
    public Image image13;
    public Image image14;
    public Image image15;
    public Image image16;
    public Image image17;
    public Image image18;
    public Image image19;
    public Image image20;
    public Image image21;
    public Image image22;
    public Image image23;
    public Image image24;
    public Image image25;

    public List<ThreebyThree> Squares;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Win Combos- 1,2,3,4 or 2,3,4,5 || 6,7,8,9 or 7,8,9,10 || 11,12,13,14 or 12,13,14,15 || 16,17,18,19 or 17,18,19,20 || 21,22,23,24 or 22,23,24,25 
        //Win Combos- 1,2,3,4 or 2,3,4,5
        if (Squares[0].type == Squares[1].type && Squares[1].type == Squares[2].type && Squares[2].type == Squares[3].type)
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
        if (Squares[1].type == Squares[2].type && Squares[2].type == Squares[3].type && Squares[3].type == Squares[4].type)
        {
            if (Squares[4].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[4].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }

        //Win Combos- 6,7,8,9 or 7,8,9,10
        if (Squares[5].type == Squares[6].type && Squares[6].type == Squares[7].type && Squares[7].type == Squares[8].type)
        {
            if (Squares[5].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[5].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }
        if (Squares[6].type == Squares[7].type && Squares[7].type == Squares[8].type && Squares[8].type == Squares[9].type)
        {
            if (Squares[9].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[9].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }

        //Win Combos- 11,12,13,14 or 12,13,14,15
        if (Squares[10].type == Squares[11].type && Squares[11].type == Squares[12].type && Squares[12].type == Squares[13].type)
        {
            if (Squares[10].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[10].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }
        if (Squares[11].type == Squares[12].type && Squares[12].type == Squares[13].type && Squares[13].type == Squares[14].type)
        {
            if (Squares[14].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[14].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }

        //Win Combos- 16,17,18,19 or 17,18,19,20
        if (Squares[15].type == Squares[16].type && Squares[16].type == Squares[17].type && Squares[17].type == Squares[18].type)
        {
            if (Squares[15].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[15].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }
        if (Squares[16].type == Squares[17].type && Squares[17].type == Squares[18].type && Squares[18].type == Squares[19].type)
        {
            if (Squares[19].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[19].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }

    }
}
