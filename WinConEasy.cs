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
    public int counter;


    public List<ThreebyThree> Squares;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //KEEP IN MIND EVERY NUMBER IN CODE IS 1 less then the original. For example 1 is 0(zero), and so on. 
        //Win Combos- 1,2,3; 4,5,6; 7,8,9
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

        if (Squares[3].type == Squares[4].type && Squares[4].type == Squares[5].type)
        {
            if (Squares[3].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[3].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }


        if (Squares[6].type == Squares[7].type && Squares[7].type == Squares[8].type)
        {
            if (Squares[6].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[6].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }
        //win combos- 1,4,7; 2,5,8 ; 3,6,9 
        if (Squares[0].type == Squares[3].type && Squares[3].type == Squares[6].type)
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
        if (Squares[1].type == Squares[4].type && Squares[4].type == Squares[7].type)
        {
            if (Squares[1].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[1].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }

        if (Squares[2].type == Squares[5].type && Squares[5].type == Squares[8].type)
        {
            if (Squares[2].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[2].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }
        //wind cond- 1,5,9; 3,5,7
        if (Squares[0].type == Squares[4].type && Squares[4].type == Squares[8].type)
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

        if (Squares[2].type == Squares[4].type && Squares[4].type == Squares[6].type)
        {
            if (Squares[2].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins");
            }
            if (Squares[2].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins");
            }

        }
        //Tie if there is any marks on the grid and there are 9 of them in which tehre are no more moves
        // and the players have yet to do any of the matches above
        // if (Squares[0].type == ThreebyThree.squaretype.markx || Squares[0].type == ThreebyThree.squaretype.marko && Squares[0].type == Squares[1].type && Squares[1].type == Squares[2].type && Squares[2].type == Squares[3].type &&
        //    Squares[3].type == Squares[4].type && Squares[4].type == Squares[5].type && Squares[5].type == Squares[6].type && 
        //    Squares[6].type == Squares[7].type && Squares[7].type == Squares[8].type)
        // {
        //         Debug.Log("Tie");
        //         SceneManager.LoadScene("Draw");
        // }
        if (Squares[0].type == ThreebyThree.squaretype.markx || Squares[0].type == ThreebyThree.squaretype.marko)
        {
            if (Squares[1].type == ThreebyThree.squaretype.markx || Squares[1].type == ThreebyThree.squaretype.marko)
            {
                if (Squares[2].type == ThreebyThree.squaretype.markx || Squares[2].type == ThreebyThree.squaretype.marko)
                {
                    if (Squares[3].type == ThreebyThree.squaretype.markx || Squares[3].type == ThreebyThree.squaretype.marko)
                    {
                        if (Squares[4].type == ThreebyThree.squaretype.markx || Squares[4].type == ThreebyThree.squaretype.marko)
                        {
                            if (Squares[5].type == ThreebyThree.squaretype.markx || Squares[5].type == ThreebyThree.squaretype.marko)
                            {
                                if (Squares[6].type == ThreebyThree.squaretype.markx || Squares[6].type == ThreebyThree.squaretype.marko)
                                {
                                    if (Squares[7].type == ThreebyThree.squaretype.markx || Squares[7].type == ThreebyThree.squaretype.marko)
                                    {
                                        if (Squares[8].type == ThreebyThree.squaretype.markx || Squares[8].type == ThreebyThree.squaretype.marko)
                                        {
                                            SceneManager.LoadScene("Draw");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
       

    }

   // public void Wincon() {

        


   // }

}
