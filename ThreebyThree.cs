using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreebyThree : MonoBehaviour
{

    public GameObject Box1;
  //  public GameObject Box2;
 //   public GameObject Box3;
 //   public GameObject Box4;
 //   public GameObject Box5;
 //   public GameObject Box6;
 //   public GameObject Box7;
  //  public GameObject Box8;
 //   public GameObject Box9;

 //   public GameObject MarkX;
 //   public GameObject MarkO;

    public Button mycurrentbutton;

    private Button thisbutton;
    public Sprite newSpritex;
    public Sprite newSpriteo;

    public KeyCode key1;
    public KeyCode key2;
    public KeyCode key3;
    public bool mouseon = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key3))
        {
            mouseon = true;
            if (Input.GetKeyDown(key1))
            {
                if (mouseon==true)
                {
                    xmark();
                }
            }
            else if (Input.GetKeyDown(key2))
            {
                if (mouseon == true)
                {
                    omark();
                }
            }
        }
    }

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
    }

    public void xmark() {
        thisbutton = mycurrentbutton;
        thisbutton.image.overrideSprite = newSpritex;
    }

    public void omark()
    {
        thisbutton = mycurrentbutton;
        thisbutton.image.overrideSprite = newSpriteo;

    }

   // public void winCondition()
  //  {
 //    //   if (this.gameObject.GetComponent<SpriteRenderer>().sprite == newSpritex) ;
 //
  //  }



}
