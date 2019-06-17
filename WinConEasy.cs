using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/** 
 * Holds data and handles the process for changing the X and Os on the grid of the game. 
 * @author Riviere Seguie
 */
public class WinConEasy : MonoBehaviour
{
    public Image image1;/**< is for the image so it can determine later which sprite it has after*/
    public Image image2;/**< is for the image so it can determine later which sprite it has after*/
    public Image image3;/**< is for the image so it can determine later which sprite it has after*/
    public Image image4;/**< is for the image so it can determine later which sprite it has after*/
    public Image image5;/**< is for the image so it can determine later which sprite it has after*/
    public Image image6;/**< is for the image so it can determine later which sprite it has after*/
    public Image image7;/**< is for the image so it can determine later which sprite it has after*/
    public Image image8;/**< is for the image so it can determine later which sprite it has after*/
    public Image image9;/**< is for the image so it can determine later which sprite it has after*/

    public List<ThreebyThree> Squares; /**< Calling the List from the script "ThreebyThree"*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /** 
    * Will update to check as to whether the keys are pressed to check the win condition of the match
    * Otherwise will lead to a Tie for both players
    */

    void Update()
    {
        //KEEP IN MIND EVERY NUMBER IN CODE IS 1 less then the original. For example 1 is 0(zero), and so on. 
        //Win Combos- 1,2,3; 4,5,6; 7,8,9
        if (Squares[0].type == Squares[1].type && Squares[1].type == Squares[2].type)
        {
            if (Squares[0].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins1");
            }
            if (Squares[0].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins1");
            }

        }

        if (Squares[3].type == Squares[4].type && Squares[4].type == Squares[5].type)
        {
            if (Squares[3].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins1");
            }
            if (Squares[3].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins1");
            }

        }


        if (Squares[6].type == Squares[7].type && Squares[7].type == Squares[8].type)
        {
            if (Squares[6].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins1");
            }
            if (Squares[6].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins1");
            }

        }
        //win combos- 1,4,7; 2,5,8 ; 3,6,9 
        if (Squares[0].type == Squares[3].type && Squares[3].type == Squares[6].type)
        {
            if (Squares[0].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins1");
            }
            if (Squares[0].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins1");
            }

        }
        if (Squares[1].type == Squares[4].type && Squares[4].type == Squares[7].type)
        {
            if (Squares[1].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins1");
            }
            if (Squares[1].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins1");
            }

        }

        if (Squares[2].type == Squares[5].type && Squares[5].type == Squares[8].type)
        {
            if (Squares[2].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins1");
            }
            if (Squares[2].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins1");
            }

        }
        //wind cond- 1,5,9; 3,5,7
        if (Squares[0].type == Squares[4].type && Squares[4].type == Squares[8].type)
        {
            if (Squares[0].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins1");
            }
            if (Squares[0].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins1");
            }

        }

        if (Squares[2].type == Squares[4].type && Squares[4].type == Squares[6].type)
        {
            if (Squares[2].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins1");
            }
            if (Squares[2].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins1");
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

        bool tied = true; //Assume they tied
        for (int i = 0; i < 9; i++)
        {
            //A move still exists
            if (Squares[i].type == ThreebyThree.squaretype.empty)
            {
                tied = false; //They cannot have tied, a move exists
            }
        }
        if(tied) //We could not find an open square
        {
            SceneManager.LoadScene("Draw1"); //It must be a draw
        }
        /**
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
                                            SceneManager.LoadScene("Draw1");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
       
    */
    }

   // public void Wincon() {

        


   // }

}
