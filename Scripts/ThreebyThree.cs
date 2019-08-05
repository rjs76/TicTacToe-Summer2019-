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

    public GameObject Box1; /**< is for the image so it can determine later which sprite it has after*/
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

    public Image image; /**< is for the image so it can determine later which sprite it has after*/
    public Sprite xsprite; /**< when this image turns into a x sprite */
    public Sprite osprtie; /**< when this image turns into a o sprite */

    public KeyCode key1;/**<Custom key for changing the image to x mark*/
    public KeyCode key2;/**<Custom key for changing the image to o mark*/
    public KeyCode key3;/**<Custom key for making sure the mouseis changing the correct image to mark*/
    public bool mouseon = false; /**<to initialize that the mouse is off*/
    private bool used = false; /**<to help initialize that the mouse is off*/
    //  public int counters;

    public enum squaretype {empty, markx, marko};  /**<to make a list values of for the marks*/
    public squaretype type;  /**<to initialize the inital value of the types above*/

    //public static int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    /** 
    * Will update to check as to whether the keys are pressed to call either the xmark() or omark() function
    */

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
                   // counter += 1;
                   // Debug.Log("Counter" + counter);
                }
            }
            else if (Input.GetKeyDown(key2))
            {
                if (mouseon == true)
                {
                    omark();
                 //   counter += 1;
                  //  Debug.Log("Counter" + counter);

                }
            }
        }

     
    }

    /** 
     * When called will change the sprite of the blank image to X sprite
     */
    public void xmark() {
        used = true;
        image.overrideSprite = xsprite;
        type = squaretype.markx;
 
    }
    /** 
     * When called will change the sprite of the blank image to O sprite
     */
    public void omark()
    {
        used = true;
        image.overrideSprite = osprtie;
        type = squaretype.marko;

    }

    /** 
     * Detects whether the mouse is on the gameobject.
     * @param pointerEventData the event data for the pointer event.
     */
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        mouseon = true;
     //   Debug.Log("Mouse is over GameObject.");
    }
    /** 
     * Detects whether the mouse is off the gameobject.
     * @param pointerEventData the event data for the pointer event.
     */
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        mouseon = false;
        Debug.Log("Mouse is not over GameObject.");
    }

}
