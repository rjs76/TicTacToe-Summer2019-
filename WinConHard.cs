using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinConHard : MonoBehaviour
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
    public Image image26;
    public Image image27;
    public Image image28;
    public Image image29;
    public Image image30;
    public Image image31;
    public Image image32;
    public Image image33;
    public Image image34;
    public Image image35;
    public Image image36;
    public Image image37;
    public Image image38;
    public Image image39;
    public Image image40;
    public Image image41;
    public Image image42;
    public Image image43;
    public Image image44;
    public Image image45;
    public Image image46;
    public Image image47;
    public Image image48;
    public Image image49;



    public List<ThreebyThree> Squares;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
                                                                                                            if (Squares[25].type == ThreebyThree.squaretype.markx || Squares[25].type == ThreebyThree.squaretype.marko)
                                                                                                            {
                                                                                                                if (Squares[26].type == ThreebyThree.squaretype.markx || Squares[26].type == ThreebyThree.squaretype.marko)
                                                                                                                {
                                                                                                                    if (Squares[27].type == ThreebyThree.squaretype.markx || Squares[27].type == ThreebyThree.squaretype.marko)
                                                                                                                    {
                                                                                                                        if (Squares[28].type == ThreebyThree.squaretype.markx || Squares[28].type == ThreebyThree.squaretype.marko)
                                                                                                                        {
                                                                                                                            if (Squares[29].type == ThreebyThree.squaretype.markx || Squares[29].type == ThreebyThree.squaretype.marko)
                                                                                                                            {
                                                                                                                                if (Squares[30].type == ThreebyThree.squaretype.markx || Squares[30].type == ThreebyThree.squaretype.marko)
                                                                                                                                {
                                                                                                                                    if (Squares[31].type == ThreebyThree.squaretype.markx || Squares[31].type == ThreebyThree.squaretype.marko)
                                                                                                                                    {
                                                                                                                                        if (Squares[32].type == ThreebyThree.squaretype.markx || Squares[32].type == ThreebyThree.squaretype.marko)
                                                                                                                                        {
                                                                                                                                            if (Squares[33].type == ThreebyThree.squaretype.markx || Squares[33].type == ThreebyThree.squaretype.marko)
                                                                                                                                            {
                                                                                                                                                if (Squares[34].type == ThreebyThree.squaretype.markx || Squares[34].type == ThreebyThree.squaretype.marko)
                                                                                                                                                {
                                                                                                                                                    if (Squares[35].type == ThreebyThree.squaretype.markx || Squares[35].type == ThreebyThree.squaretype.marko)
                                                                                                                                                    {
                                                                                                                                                        if (Squares[36].type == ThreebyThree.squaretype.markx || Squares[36].type == ThreebyThree.squaretype.marko)
                                                                                                                                                        {
                                                                                                                                                            if (Squares[37].type == ThreebyThree.squaretype.markx || Squares[37].type == ThreebyThree.squaretype.marko)
                                                                                                                                                            {
                                                                                                                                                                if (Squares[38].type == ThreebyThree.squaretype.markx || Squares[38].type == ThreebyThree.squaretype.marko)
                                                                                                                                                                {
                                                                                                                                                                    if (Squares[39].type == ThreebyThree.squaretype.markx || Squares[39].type == ThreebyThree.squaretype.marko)
                                                                                                                                                                    {
                                                                                                                                                                        if (Squares[40].type == ThreebyThree.squaretype.markx || Squares[40].type == ThreebyThree.squaretype.marko)
                                                                                                                                                                        {
                                                                                                                                                                            if (Squares[41].type == ThreebyThree.squaretype.markx || Squares[41].type == ThreebyThree.squaretype.marko)
                                                                                                                                                                            {
                                                                                                                                                                                if (Squares[42].type == ThreebyThree.squaretype.markx || Squares[42].type == ThreebyThree.squaretype.marko)
                                                                                                                                                                                {
                                                                                                                                                                                    if (Squares[43].type == ThreebyThree.squaretype.markx || Squares[43].type == ThreebyThree.squaretype.marko)
                                                                                                                                                                                    {
                                                                                                                                                                                        if (Squares[44].type == ThreebyThree.squaretype.markx || Squares[44].type == ThreebyThree.squaretype.marko)
                                                                                                                                                                                        {
                                                                                                                                                                                            if (Squares[45].type == ThreebyThree.squaretype.markx || Squares[45].type == ThreebyThree.squaretype.marko)
                                                                                                                                                                                            {
                                                                                                                                                                                                if (Squares[46].type == ThreebyThree.squaretype.markx || Squares[46].type == ThreebyThree.squaretype.marko)
                                                                                                                                                                                                {
                                                                                                                                                                                                    if (Squares[47].type == ThreebyThree.squaretype.markx || Squares[47].type == ThreebyThree.squaretype.marko)
                                                                                                                                                                                                    {
                                                                                                                                                                                                        if (Squares[48].type == ThreebyThree.squaretype.markx || Squares[48].type == ThreebyThree.squaretype.marko)
                                                                                                                                                                                                        {
                                                                                                                                                                                                                SceneManager.LoadScene("Draw3");
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
