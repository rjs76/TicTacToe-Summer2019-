using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/** 
 * Holds data and handles the process for changing the X and Os on the grid of the game. 
 * @author Riviere Seguie
 */
public class WinConMedium : MonoBehaviour
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
    public Image image10;/**< is for the image so it can determine later which sprite it has after*/
    public Image image11;/**< is for the image so it can determine later which sprite it has after*/
    public Image image12;/**< is for the image so it can determine later which sprite it has after*/
    public Image image13;/**< is for the image so it can determine later which sprite it has after*/
    public Image image14;/**< is for the image so it can determine later which sprite it has after*/
    public Image image15;/**< is for the image so it can determine later which sprite it has after*/
    public Image image16;/**< is for the image so it can determine later which sprite it has after*/
    public Image image17;/**< is for the image so it can determine later which sprite it has after*/
    public Image image18;/**< is for the image so it can determine later which sprite it has after*/
    public Image image19;/**< is for the image so it can determine later which sprite it has after*/
    public Image image20;/**< is for the image so it can determine later which sprite it has after*/
    public Image image21;/**< is for the image so it can determine later which sprite it has after*/
    public Image image22;/**< is for the image so it can determine later which sprite it has after*/
    public Image image23;/**< is for the image so it can determine later which sprite it has after*/
    public Image image24;/**< is for the image so it can determine later which sprite it has after*/
    public Image image25;/**< is for the image so it can determine later which sprite it has after*/


    public List<ThreebyThree> Squares;/**< Calling the List from the script "ThreebyThree"*/
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
        //Horizontal
        //Win Combos- 1,2,3,4 or 2,3,4,5 || 6,7,8,9 or 7,8,9,10 || 11,12,13,14 or 12,13,14,15 || 16,17,18,19 or 17,18,19,20 || 21,22,23,24 or 22,23,24,25 
        //Win Combos- 1,2,3,4 or 2,3,4,5
        if (Squares[0].type == Squares[1].type && Squares[1].type == Squares[2].type && Squares[2].type == Squares[3].type)
        {
            if (Squares[0].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[0].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[1].type == Squares[2].type && Squares[2].type == Squares[3].type && Squares[3].type == Squares[4].type)
        {
            if (Squares[4].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[4].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }

        //Win Combos- 6,7,8,9 or 7,8,9,10
        if (Squares[5].type == Squares[6].type && Squares[6].type == Squares[7].type && Squares[7].type == Squares[8].type)
        {
            if (Squares[5].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[5].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[6].type == Squares[7].type && Squares[7].type == Squares[8].type && Squares[8].type == Squares[9].type)
        {
            if (Squares[9].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[9].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }

        //Win Combos- 11,12,13,14 or 12,13,14,15
        if (Squares[10].type == Squares[11].type && Squares[11].type == Squares[12].type && Squares[12].type == Squares[13].type)
        {
            if (Squares[10].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[10].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[11].type == Squares[12].type && Squares[12].type == Squares[13].type && Squares[13].type == Squares[14].type)
        {
            if (Squares[14].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[14].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }

        //Win Combos- 16,17,18,19 or 17,18,19,20
        if (Squares[15].type == Squares[16].type && Squares[16].type == Squares[17].type && Squares[17].type == Squares[18].type)
        {
            if (Squares[15].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[15].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[16].type == Squares[17].type && Squares[17].type == Squares[18].type && Squares[18].type == Squares[19].type)
        {
            if (Squares[19].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[19].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        //Win Combos- 21,22,23,24 or 22,23,24,25
        if (Squares[20].type == Squares[21].type && Squares[21].type == Squares[22].type && Squares[22].type == Squares[23].type)
        {
            if (Squares[20].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[20].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[21].type == Squares[22].type && Squares[22].type == Squares[23].type && Squares[23].type == Squares[24].type)
        {
            if (Squares[24].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[24].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        //Vertical
        //Win Combos- 1,6,11,16 or 6,11,16,21 || 2,7,12,17 or 7,12,17,22 || 3,8,13,18 or 8,13,18,23 || 4,9,14,19 or 9,14,19,24 || 5,10,15,20 or 10,15,20,25 
        //Win Combos- 1,6,11,16 or 6,11,16,21
        if (Squares[0].type == Squares[5].type && Squares[5].type == Squares[10].type && Squares[10].type == Squares[15].type)
        {
            if (Squares[0].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[0].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[5].type == Squares[10].type && Squares[10].type == Squares[15].type && Squares[15].type == Squares[20].type)
        {
            if (Squares[20].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[20].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        //Win Combos- 2,7,12,17 or 7,12,17,22
        if (Squares[1].type == Squares[6].type && Squares[6].type == Squares[11].type && Squares[11].type == Squares[16].type)
        {
            if (Squares[1].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[1].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[6].type == Squares[11].type && Squares[11].type == Squares[16].type && Squares[16].type == Squares[21].type)
        {
            if (Squares[21].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[21].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }

        //Win Combos- 3,8,13,18 or 8,13,18,23
        if (Squares[2].type == Squares[7].type && Squares[7].type == Squares[12].type && Squares[12].type == Squares[17].type)
        {
            if (Squares[2].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[2].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[7].type == Squares[12].type && Squares[12].type == Squares[17].type && Squares[17].type == Squares[22].type)
        {
            if (Squares[22].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[22].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }

        //Win Combos- 4,9,14,19 or 9,14,19,24
        if (Squares[3].type == Squares[8].type && Squares[8].type == Squares[13].type && Squares[13].type == Squares[18].type)
        {
            if (Squares[3].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[3].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[8].type == Squares[13].type && Squares[13].type == Squares[18].type && Squares[18].type == Squares[23].type)
        {
            if (Squares[23].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[23].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }

        //Win Combos- 5,10,15,20 or 10,15,20,25
        if (Squares[4].type == Squares[9].type && Squares[9].type == Squares[14].type && Squares[14].type == Squares[19].type)
        {
            if (Squares[4].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[4].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[9].type == Squares[14].type && Squares[14].type == Squares[19].type && Squares[19].type == Squares[24].type)
        {
            if (Squares[24].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[24].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        //Left Diagnols 
        //Win Combos- 1,7,13,19 or 7,13,19,25 || 2,8,14,20 or 6,12,18,24
        //Win Combos- 1,7,13,19 or 7,13,19,25
        if (Squares[0].type == Squares[6].type && Squares[6].type == Squares[12].type && Squares[12].type == Squares[18].type)
        {
            if (Squares[0].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[0].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[6].type == Squares[12].type && Squares[12].type == Squares[18].type && Squares[18].type == Squares[24].type)
        {
            if (Squares[24].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[24].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        //Win Combos- 2,8,14,20 or 6,12,18,24
        if (Squares[1].type == Squares[7].type && Squares[7].type == Squares[13].type && Squares[13].type == Squares[19].type)
        {
            if (Squares[1].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[1].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[5].type == Squares[11].type && Squares[11].type == Squares[17].type && Squares[17].type == Squares[23].type)
        {
            if (Squares[23].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[23].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        //Right Diagnols 
        //Win Combos- 5,9,13,17 or 9,13,17,21 || 4,8,12,16 or 10,14,18,22
        //Win Combos- 5,9,13,17 or 9,13,17,21
        if (Squares[4].type == Squares[8].type && Squares[8].type == Squares[12].type && Squares[12].type == Squares[16].type)
        {
            if (Squares[4].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[4].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[8].type == Squares[12].type && Squares[12].type == Squares[16].type && Squares[16].type == Squares[20].type)
        {
            if (Squares[20].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[20].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }

        //Win Combos- 4,8,12,16 or 10,14,18,22
        if (Squares[3].type == Squares[7].type && Squares[7].type == Squares[11].type && Squares[11].type == Squares[15].type)
        {
            if (Squares[3].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[3].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }
        if (Squares[9].type == Squares[13].type && Squares[13].type == Squares[17].type && Squares[17].type == Squares[21].type)
        {
            if (Squares[21].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins2");
            }
            if (Squares[21].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins2");
            }

        }

        //Tie
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
                                            if (Squares[9].type == ThreebyThree.squaretype.markx || Squares[9].type == ThreebyThree.squaretype.marko)
                                            {
                                                if (Squares[10].type == ThreebyThree.squaretype.markx || Squares[10].type == ThreebyThree.squaretype.marko)
                                                {
                                                    if (Squares[11].type == ThreebyThree.squaretype.markx || Squares[11].type == ThreebyThree.squaretype.marko)
                                                    {
                                                        if (Squares[12].type == ThreebyThree.squaretype.markx || Squares[12].type == ThreebyThree.squaretype.marko)
                                                        {
                                                            if (Squares[13].type == ThreebyThree.squaretype.markx || Squares[13].type == ThreebyThree.squaretype.marko)
                                                            {
                                                                if (Squares[14].type == ThreebyThree.squaretype.markx || Squares[14].type == ThreebyThree.squaretype.marko)
                                                                {
                                                                    if (Squares[15].type == ThreebyThree.squaretype.markx || Squares[15].type == ThreebyThree.squaretype.marko)
                                                                    {
                                                                        if (Squares[16].type == ThreebyThree.squaretype.markx || Squares[16].type == ThreebyThree.squaretype.marko)
                                                                        {
                                                                            if (Squares[17].type == ThreebyThree.squaretype.markx || Squares[17].type == ThreebyThree.squaretype.marko)
                                                                            {
                                                                                if (Squares[18].type == ThreebyThree.squaretype.markx || Squares[18].type == ThreebyThree.squaretype.marko)
                                                                                {
                                                                                    if (Squares[19].type == ThreebyThree.squaretype.markx || Squares[19].type == ThreebyThree.squaretype.marko)
                                                                                    {
                                                                                        if (Squares[20].type == ThreebyThree.squaretype.markx || Squares[20].type == ThreebyThree.squaretype.marko)
                                                                                        {
                                                                                            if (Squares[21].type == ThreebyThree.squaretype.markx || Squares[21].type == ThreebyThree.squaretype.marko)
                                                                                            {
                                                                                                if (Squares[22].type == ThreebyThree.squaretype.markx || Squares[22].type == ThreebyThree.squaretype.marko)
                                                                                                {
                                                                                                    if (Squares[23].type == ThreebyThree.squaretype.markx || Squares[23].type == ThreebyThree.squaretype.marko)
                                                                                                    {
                                                                                                        if (Squares[24].type == ThreebyThree.squaretype.markx || Squares[24].type == ThreebyThree.squaretype.marko)
                                                                                                        {
                                                                                                            SceneManager.LoadScene("Draw2");
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
                        }
                    }
                }
            }
        }

    }
}
