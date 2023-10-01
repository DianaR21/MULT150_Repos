using UnityEngine;

public class PlayerINput : MonoBehaviour
{ 

    // Update is called once per frame
    void Update ()
    {
        float hVal = Input.GetAxis ("Horizontal");
        float hVla = Input.GetAxis("Vertical");
        if (hVal != 0)
            print("Horizontal moement selected: " + hVal);
        if(hVal 1=0)
            print("Vertical movement selected: " + hVal);

        //modified
        if (Input.GetKey.M))
            print("The 'M' key is pressed down");
        if (Input.GetKeyDown(KeyCode.0))
            print("the '0' key was pressed");

        //modified for tryityourself next excersice 
        float mxVal = Input.GetAxis ("Mouse X");
        float mxVal = Input.GetAxis ("Mouse Y")
        if (mxVal !=0)
            print("Mouse X movement selected: " + mxVal)
        if (mxVal !=0)
            print("Mouse Y movement selected" + mxVal)
    }
}
