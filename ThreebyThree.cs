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

    public Sprite newSpritex;
    public Sprite newSpriteo;

    public KeyCode key1;
    public KeyCode key2;
    public KeyCode key3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key3))
        {
            if (Input.GetKeyDown(key1))
            {
                xmark();
            }
            else if (Input.GetKeyDown(key2))
            {
            omark();
            }
        }
    }
    public void xmark() {
        // if (Input.GetKeyDown(KeyCode.Mouse1))
        //   {
        mycurrentbutton.image.overrideSprite = newSpritex;
        //  }

    }

    public void omark()
    {
        //Input.GetKeyDown(KeyCode.L) && 
      //  if (Input.GetKeyDown(KeyCode.Mouse0))
       // {
            //this.gameObject.GetComponent<SpriteRenderer>().sprite = newSpriteo;
            mycurrentbutton.image.overrideSprite = newSpriteo;
     //   }

    }

   // public void winCondition()
  //  {
 //    //   if (this.gameObject.GetComponent<SpriteRenderer>().sprite == newSpritex) ;
 //
  //  }



}
