using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MPS.XR;

 
 

//simple test of many of the SXR Input Module handlers
public class SXREventSytemTest : MonoBehaviour,
    ISXRControllerTriggerHandler,
    ISXRControllerTouchpadButtonHandler,
    ISXRControllerTouchpadHandler, ISXRControllerGyroHandler
{


    public void Start()
    {
        SXRInputModule.Register(this, gameObject);
    }

    public void OnTriggerUp()
    {
        print("Game Controller Trigger up!");
    }

    public void OnTriggerDown()
    {
        print("Game Controller Trigger Down!");
    }

    public void OnTriggerClicked()
    {
        print("Game Controller trigger clicked!");
    }

    public void OnTouchpadButtonUp(SXRInputModule.TouchpadDirection dir)
    {
        print("Game Controller Touchpad up! direction=" + dir);
    }

    public void OnTouchpadButtonDown(SXRInputModule.TouchpadDirection dir)
    {
        print("Game Controller Touchpad down! direction=" + dir);
    }

    public void OnTouchpadClicked(SXRInputModule.TouchpadDirection dir)
    {
        print("Game Controller Touchpad clicked! direction=" + dir);
    }

    public void OnTouchpadOn(SXRInputModule.TouchpadDirection direction)
    {
        print("touchpad touch on! direction=" + direction);
    }

    public void OnTouchpadOff(SXRInputModule.TouchpadDirection direction)
    {
        print("touchpad touch off! direction=" + direction);
    }

    public void OnTouchpadMove(Vector2 position)
    {
        print("touchpad movement! position=" + position.x + ", " + position.y);
    }

    public void OnTouchpadSwipe(SXRInputModule.SwipeDirection swipeDirection)
    {
        print("touchpad swipe! direction=" + swipeDirection);
    }

    public void OnOrientation(Quaternion orientation)
    {
        print("Orientation event! orientation=" + orientation.ToString());
    }
}
 


// ```
// ###### Example Script - HitPositionTest

// ```c#
// using MPS.XR;
// using UnityEngine;
// //uses a 3D object as a representation of where pointer is hitting selected object
// public class HitPositionTest : MonoBehaviour, IPointerHitPositionHandler
// {

//     public void Start()
//     {
//         SXRInputModule.Register(this, gameObject);
//     }

//     public void OnPointerHitPosition(GameObject selectedObject, Vector3 hitPosition, Vector3 hitNormal)
//     {
//         transform.position = hitPosition;
//         transform.eulerAngles = hitNormal;
//     }

//     public void OnPointerHitStart(GameObject selectedObject)
//     {
//         if (selectedObject != null)
//         {
//             GetComponent<Renderer>().enabled = true;
//         }
//     }

//     public void OnPointerHitEnd(GameObject deselectedObject)
//     {
//         if (deselectedObject != null)
//         {
//             GetComponent<Renderer>().enabled = false;
//         }
//     }
// }

// ```
// ###### Example Script - GazeButtonTest

// ```c#
// using UnityEngine;
// using UnityEngine.EventSystems;

// public class GazeButtonTest : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
// {

//     public bool is3D = false;

//     public void OnPointerClick(PointerEventData eventData)
//     {
//         print("button Clicked!");
//     }

//     public void OnPointerEnter(PointerEventData eventData)
//     {
//         if (is3D)
//         {
//             GetComponent<Renderer>().material.color = Color.cyan;
//         }
//         //print("pointer entered!");
//     }

//     public void OnPointerExit(PointerEventData eventData)
//     {
//         if (is3D)
//         {
//             GetComponent<Renderer>().material.color = Color.white;
//         }
//         //print("pointer exited!");
//     }
// }

