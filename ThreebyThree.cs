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
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  //  public void xmark() {
  //      if (Input.GetKeyDown(KeyCode.C) && Input.GetKeyDown(KeyCode.Mouse0))
  //      {
  //          this.gameObject.GetComponent<SpriteRenderer>().sprite = newSpritex;
  //      }

  //  }

    public void omark()
    {
        //&& Input.GetKeyDown(KeyCode.Mouse0)
       // if (Input.GetKeyDown(KeyCode.L))
       // {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = newSpriteo;
            //mycurrentbutton.image.overrideSprite = newSpriteo;
       // }

    }

   // public void winCondition()
  //  {
 //    //   if (this.gameObject.GetComponent<SpriteRenderer>().sprite == newSpritex) ;
 //
  //  }



}
