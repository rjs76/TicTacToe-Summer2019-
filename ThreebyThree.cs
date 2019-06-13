using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
/** 
 * Holds data and handles the process for changing the X and Os on the grid of the game. 
 * @author Riviere Seguie
 */
public class ThreebyThree : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
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

    //public Button mycurrentbutton;

    public Image image; 
    public Sprite xsprite; /**< when this image turns into a x sprite */
    public Sprite osprtie;

    public KeyCode key1;
    public KeyCode key2;
    public KeyCode key3;
    public bool mouseon = false;
    private bool used = false;
    

    public enum squaretype {empty, markx, marko};
    public squaretype type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key3) && !used)
        {
          //  mouseon = true;
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
        used = true;
        // thisbutton = mycurrentbutton;
        //thisbutton.image.overrideSprite = newSpritex;
        image.overrideSprite = xsprite;
        type = squaretype.markx;
    }

    public void omark()
    {
        used = true;
       // thisbutton = mycurrentbutton;
       //thisbutton.image.overrideSprite = newSpriteo;
        image.overrideSprite = osprtie;
        type = squaretype.marko;
    }

   // public void winCondition()
  //  {
 //    //   if (this.gameObject.GetComponent<SpriteRenderer>().sprite == newSpritex) ;
 //
  //  }
    /** 
     * Detects whether the mouse is on the gameobject.
     * @param pointerEventData the event data for the pointer event.
     */
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        mouseon = true;
        Debug.Log("Mouse is over GameObject.");
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        mouseon = false;
        Debug.Log("Mouse is not over GameObject.");
    }

}
