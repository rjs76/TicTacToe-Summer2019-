using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AllWinCondtions : MonoBehaviour
{
    public int level;

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
    public Image image26;/**< is for the image so it can determine later which sprite it has after*/
    public Image image27;/**< is for the image so it can determine later which sprite it has after*/
    public Image image28;/**< is for the image so it can determine later which sprite it has after*/
    public Image image29;/**< is for the image so it can determine later which sprite it has after*/
    public Image image30;/**< is for the image so it can determine later which sprite it has after*/
    public Image image31;/**< is for the image so it can determine later which sprite it has after*/
    public Image image32;/**< is for the image so it can determine later which sprite it has after*/
    public Image image33;/**< is for the image so it can determine later which sprite it has after*/
    public Image image34;/**< is for the image so it can determine later which sprite it has after*/
    public Image image35;/**< is for the image so it can determine later which sprite it has after*/
    public Image image36;/**< is for the image so it can determine later which sprite it has after*/
    public Image image37;/**< is for the image so it can determine later which sprite it has after*/
    public Image image38;/**< is for the image so it can determine later which sprite it has after*/
    public Image image39;/**< is for the image so it can determine later which sprite it has after*/
    public Image image40;/**< is for the image so it can determine later which sprite it has after*/
    public Image image41;/**< is for the image so it can determine later which sprite it has after*/
    public Image image42;/**< is for the image so it can determine later which sprite it has after*/
    public Image image43;/**< is for the image so it can determine later which sprite it has after*/
    public Image image44;/**< is for the image so it can determine later which sprite it has after*/
    public Image image45;/**< is for the image so it can determine later which sprite it has after*/
    public Image image46;/**< is for the image so it can determine later which sprite it has after*/
    public Image image47;/**< is for the image so it can determine later which sprite it has after*/
    public Image image48;/**< is for the image so it can determine later which sprite it has after*/
    public Image image49;/**< is for the image so it can determine later which sprite it has after*/

    public List<ThreebyThree> Squares; /**< Calling the List from the script "ThreebyThree"*/

    // Start is called before the first frame update
    //Scene scene = SceneManager.GetActiveScene();
    public Scene scene;
    void Start()
    {
        
    }

    // Update is called once per frame
    /** 
    * Depending upon the level will determine which win condition to use
    * Easy, Medium, or HardWin condition will be called depending upon the level given to it
    */
    void Update()
    {
        if (level == 1)
        {
            EasyWin();
        }
        if (level == 2)
        {
            MediumWin();
        }
        if (level == 3)
        {
            HardWin();
        }
    }
    /** 
    * Will check the Square images to see if they match for the win condition of 3 in a row
    * It will also check for tie game as well
    */
    public void EasyWin()
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

        bool tied = true; //Assume they tied
        for (int i = 0; i < 9; i++)
        {
            //A move still exists
            if (Squares[i].type == ThreebyThree.squaretype.empty)
            {
                tied = false; //They cannot have tied, a move exists
            }
        }
        if (tied) //We could not find an open square
        {
            SceneManager.LoadScene("Draw1"); //It must be a draw
        }
    }
    //
    //
    //
    /** 
    * Will check the Square images to see if they match for the win condition of 4 in a row
    * It will also check for tie game as well
    */
    public void MediumWin()
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
        //Tie breaker
        bool tied = true; //Assume they tied
        for (int i = 0; i < 25; i++)
        {
            //A move still exists
            if (Squares[i].type == ThreebyThree.squaretype.empty)
            {
                tied = false; //They cannot have tied, a move exists
            }
        }
        if (tied) //We could not find an open square
        {
            SceneManager.LoadScene("Draw2"); //It must be a draw
        }
    }
    //
    //
    //
    /** 
    * Will check the Square images to see if they match for the win condition of 5 in a row
    * It will also check for tie game as well
    */
    public void HardWin()
    {
        //Horizontal
        //First Row
        if (Squares[0].type == Squares[1].type && Squares[1].type == Squares[2].type && Squares[2].type == Squares[3].type && Squares[3].type == Squares[4].type)
        {
            if (Squares[0].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[0].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        if (Squares[1].type == Squares[2].type && Squares[2].type == Squares[3].type && Squares[3].type == Squares[4].type && Squares[4].type == Squares[5].type)
        {
            if (Squares[1].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[1].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        if (Squares[2].type == Squares[3].type && Squares[3].type == Squares[4].type && Squares[4].type == Squares[5].type && Squares[5].type == Squares[6].type)
        {
            if (Squares[6].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[6].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //Second Row
        if (Squares[7].type == Squares[8].type && Squares[8].type == Squares[9].type && Squares[9].type == Squares[10].type && Squares[10].type == Squares[11].type)
        {
            if (Squares[7].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[7].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        if (Squares[8].type == Squares[9].type && Squares[9].type == Squares[10].type && Squares[10].type == Squares[11].type && Squares[11].type == Squares[12].type)
        {
            if (Squares[8].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[8].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[9].type == Squares[10].type && Squares[10].type == Squares[11].type && Squares[11].type == Squares[12].type && Squares[12].type == Squares[13].type)
        {
            if (Squares[13].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[13].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        //Third Row
        if (Squares[14].type == Squares[15].type && Squares[15].type == Squares[16].type && Squares[16].type == Squares[17].type && Squares[17].type == Squares[18].type)
        {
            if (Squares[14].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[14].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        if (Squares[15].type == Squares[16].type && Squares[16].type == Squares[17].type && Squares[17].type == Squares[18].type && Squares[18].type == Squares[19].type)
        {
            if (Squares[15].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[15].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[16].type == Squares[17].type && Squares[17].type == Squares[18].type && Squares[18].type == Squares[19].type && Squares[19].type == Squares[20].type)
        {
            if (Squares[20].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[20].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //Fourth Row
        if (Squares[21].type == Squares[22].type && Squares[22].type == Squares[23].type && Squares[23].type == Squares[24].type && Squares[24].type == Squares[25].type)
        {
            if (Squares[21].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[21].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        if (Squares[22].type == Squares[23].type && Squares[23].type == Squares[24].type && Squares[24].type == Squares[25].type && Squares[25].type == Squares[26].type)
        {
            if (Squares[22].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[22].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[23].type == Squares[24].type && Squares[24].type == Squares[25].type && Squares[25].type == Squares[26].type && Squares[26].type == Squares[27].type)
        {
            if (Squares[27].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[27].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //fifth Row
        if (Squares[28].type == Squares[29].type && Squares[29].type == Squares[30].type && Squares[30].type == Squares[31].type && Squares[31].type == Squares[32].type)
        {
            if (Squares[28].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[28].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        if (Squares[29].type == Squares[30].type && Squares[30].type == Squares[31].type && Squares[31].type == Squares[32].type && Squares[32].type == Squares[33].type)
        {
            if (Squares[29].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[29].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[30].type == Squares[31].type && Squares[31].type == Squares[32].type && Squares[32].type == Squares[33].type && Squares[33].type == Squares[34].type)
        {
            if (Squares[34].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[34].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //Sixth Row
        if (Squares[35].type == Squares[36].type && Squares[36].type == Squares[37].type && Squares[37].type == Squares[38].type && Squares[38].type == Squares[39].type)
        {
            if (Squares[35].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[35].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        if (Squares[36].type == Squares[37].type && Squares[37].type == Squares[38].type && Squares[38].type == Squares[39].type && Squares[39].type == Squares[40].type)
        {
            if (Squares[36].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[36].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[37].type == Squares[38].type && Squares[38].type == Squares[39].type && Squares[39].type == Squares[40].type && Squares[40].type == Squares[41].type)
        {
            if (Squares[41].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[41].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        //Seveth Row
        if (Squares[42].type == Squares[43].type && Squares[43].type == Squares[44].type && Squares[44].type == Squares[45].type && Squares[45].type == Squares[46].type)
        {
            if (Squares[42].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[42].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        if (Squares[43].type == Squares[44].type && Squares[44].type == Squares[45].type && Squares[45].type == Squares[46].type && Squares[46].type == Squares[47].type)
        {
            if (Squares[43].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[43].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[44].type == Squares[45].type && Squares[45].type == Squares[46].type && Squares[46].type == Squares[47].type && Squares[47].type == Squares[48].type)
        {
            if (Squares[48].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[48].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //Vertical
        //First Colummn
        if (Squares[0].type == Squares[7].type && Squares[7].type == Squares[14].type && Squares[14].type == Squares[21].type && Squares[21].type == Squares[28].type)
        {
            if (Squares[0].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[0].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        if (Squares[7].type == Squares[14].type && Squares[14].type == Squares[21].type && Squares[21].type == Squares[28].type && Squares[28].type == Squares[35].type)
        {
            if (Squares[7].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[7].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[14].type == Squares[21].type && Squares[21].type == Squares[28].type && Squares[28].type == Squares[35].type && Squares[35].type == Squares[42].type)
        {
            if (Squares[42].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[42].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //Second Colummn
        if (Squares[1].type == Squares[8].type && Squares[8].type == Squares[15].type && Squares[15].type == Squares[22].type && Squares[22].type == Squares[29].type)
        {
            if (Squares[1].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[1].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        if (Squares[8].type == Squares[15].type && Squares[15].type == Squares[22].type && Squares[22].type == Squares[29].type && Squares[29].type == Squares[36].type)
        {
            if (Squares[8].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[8].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        if (Squares[15].type == Squares[22].type && Squares[22].type == Squares[29].type && Squares[29].type == Squares[36].type && Squares[36].type == Squares[43].type)
        {
            if (Squares[43].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[43].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //Third Colummn
        if (Squares[2].type == Squares[9].type && Squares[9].type == Squares[16].type && Squares[16].type == Squares[23].type && Squares[23].type == Squares[30].type)
        {
            if (Squares[2].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[2].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[9].type == Squares[16].type && Squares[16].type == Squares[23].type && Squares[23].type == Squares[30].type && Squares[30].type == Squares[37].type)
        {
            if (Squares[9].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[9].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[16].type == Squares[23].type && Squares[23].type == Squares[30].type && Squares[30].type == Squares[37].type && Squares[37].type == Squares[44].type)
        {
            if (Squares[44].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[44].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //Fourth Colummn
        if (Squares[3].type == Squares[10].type && Squares[10].type == Squares[17].type && Squares[17].type == Squares[24].type && Squares[24].type == Squares[31].type)
        {
            if (Squares[3].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[3].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[10].type == Squares[17].type && Squares[17].type == Squares[24].type && Squares[24].type == Squares[31].type && Squares[31].type == Squares[38].type)
        {
            if (Squares[10].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[10].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[17].type == Squares[24].type && Squares[24].type == Squares[31].type && Squares[31].type == Squares[38].type && Squares[38].type == Squares[45].type)
        {
            if (Squares[45].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[45].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        //Fifth Colummn
        if (Squares[4].type == Squares[11].type && Squares[11].type == Squares[18].type && Squares[18].type == Squares[25].type && Squares[25].type == Squares[32].type)
        {
            if (Squares[4].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[4].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[11].type == Squares[18].type && Squares[18].type == Squares[25].type && Squares[25].type == Squares[32].type && Squares[32].type == Squares[39].type)
        {
            if (Squares[11].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[11].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[18].type == Squares[25].type && Squares[25].type == Squares[32].type && Squares[32].type == Squares[39].type && Squares[39].type == Squares[46].type)
        {
            if (Squares[46].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[46].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        //Sixth Colummn
        if (Squares[5].type == Squares[12].type && Squares[12].type == Squares[19].type && Squares[19].type == Squares[26].type && Squares[26].type == Squares[33].type)
        {
            if (Squares[5].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[5].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[12].type == Squares[19].type && Squares[19].type == Squares[26].type && Squares[26].type == Squares[33].type && Squares[33].type == Squares[40].type)
        {
            if (Squares[12].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[12].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[19].type == Squares[26].type && Squares[26].type == Squares[33].type && Squares[33].type == Squares[40].type && Squares[40].type == Squares[47].type)
        {
            if (Squares[47].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[47].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }

        //Seventh Colummn
        if (Squares[6].type == Squares[13].type && Squares[13].type == Squares[20].type && Squares[20].type == Squares[27].type && Squares[27].type == Squares[34].type)
        {
            if (Squares[6].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[6].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[13].type == Squares[20].type && Squares[20].type == Squares[27].type && Squares[27].type == Squares[34].type && Squares[34].type == Squares[41].type)
        {
            if (Squares[13].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[13].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[20].type == Squares[27].type && Squares[27].type == Squares[34].type && Squares[34].type == Squares[41].type && Squares[41].type == Squares[48].type)
        {
            if (Squares[48].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[48].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //Left Diagnols
        //Top portion
        if (Squares[2].type == Squares[10].type && Squares[10].type == Squares[18].type && Squares[18].type == Squares[26].type && Squares[26].type == Squares[34].type)
        {
            if (Squares[2].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[2].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[1].type == Squares[9].type && Squares[9].type == Squares[17].type && Squares[17].type == Squares[25].type && Squares[25].type == Squares[33].type)
        {
            if (Squares[1].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[1].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[9].type == Squares[17].type && Squares[17].type == Squares[25].type && Squares[25].type == Squares[33].type && Squares[33].type == Squares[41].type)
        {
            if (Squares[41].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[41].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //middle Colummn
        if (Squares[0].type == Squares[8].type && Squares[8].type == Squares[16].type && Squares[16].type == Squares[24].type && Squares[24].type == Squares[32].type)
        {
            if (Squares[0].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[0].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[8].type == Squares[16].type && Squares[16].type == Squares[24].type && Squares[24].type == Squares[32].type && Squares[32].type == Squares[40].type)
        {
            if (Squares[40].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[40].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[16].type == Squares[24].type && Squares[24].type == Squares[32].type && Squares[32].type == Squares[40].type && Squares[40].type == Squares[48].type)
        {
            if (Squares[48].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[48].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //buttom Colummn
        if (Squares[7].type == Squares[15].type && Squares[15].type == Squares[23].type && Squares[23].type == Squares[31].type && Squares[31].type == Squares[39].type)
        {
            if (Squares[7].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[7].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[15].type == Squares[23].type && Squares[23].type == Squares[31].type && Squares[31].type == Squares[39].type && Squares[39].type == Squares[47].type)
        {
            if (Squares[47].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[47].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[14].type == Squares[22].type && Squares[22].type == Squares[30].type && Squares[30].type == Squares[38].type && Squares[38].type == Squares[46].type)
        {
            if (Squares[14].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[14].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //Right Diagnol
        //Top Colummn
        if (Squares[4].type == Squares[10].type && Squares[10].type == Squares[16].type && Squares[16].type == Squares[22].type && Squares[22].type == Squares[28].type)
        {
            if (Squares[4].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[4].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[5].type == Squares[11].type && Squares[11].type == Squares[17].type && Squares[17].type == Squares[23].type && Squares[23].type == Squares[29].type)
        {
            if (Squares[5].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[5].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[11].type == Squares[17].type && Squares[17].type == Squares[23].type && Squares[23].type == Squares[29].type && Squares[29].type == Squares[35].type)
        {
            if (Squares[35].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[35].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //middle Colummn
        if (Squares[6].type == Squares[12].type && Squares[12].type == Squares[18].type && Squares[18].type == Squares[24].type && Squares[24].type == Squares[30].type)
        {
            if (Squares[6].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[6].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[12].type == Squares[18].type && Squares[18].type == Squares[24].type && Squares[24].type == Squares[30].type && Squares[30].type == Squares[36].type)
        {
            if (Squares[36].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[36].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[18].type == Squares[24].type && Squares[24].type == Squares[30].type && Squares[30].type == Squares[36].type && Squares[36].type == Squares[42].type)
        {
            if (Squares[42].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[42].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //buttom Colummn
        if (Squares[13].type == Squares[19].type && Squares[19].type == Squares[25].type && Squares[25].type == Squares[31].type && Squares[31].type == Squares[37].type)
        {
            if (Squares[13].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[13].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[19].type == Squares[25].type && Squares[25].type == Squares[31].type && Squares[31].type == Squares[37].type && Squares[37].type == Squares[43].type)
        {
            if (Squares[43].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[43].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        if (Squares[20].type == Squares[26].type && Squares[26].type == Squares[32].type && Squares[32].type == Squares[38].type && Squares[38].type == Squares[44].type)
        {
            if (Squares[20].type == ThreebyThree.squaretype.markx)
            {
                Debug.Log("PlayerX Wins");
                SceneManager.LoadScene("PlayerXwins3");
            }
            if (Squares[20].type == ThreebyThree.squaretype.marko)
            {
                Debug.Log("PlayerO Wins");
                SceneManager.LoadScene("PlayerOwins3");
            }

        }
        //tie
        bool tied = true; //Assume they tied
        for (int i = 0; i < 49; i++)
        {
            //A move still exists
            if (Squares[i].type == ThreebyThree.squaretype.empty)
            {
                tied = false; //They cannot have tied, a move exists
            }
        }
        if (tied) //We could not find an open square
        {
            SceneManager.LoadScene("Draw3"); //It must be a draw
        }
    }
}
