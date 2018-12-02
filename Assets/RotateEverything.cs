using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateEverything : MonoBehaviour {

    public Material red, blue, green;
    public Material red1, blue1, green1;
    // Use this for initialization
    void Start () {
		
	}
    float i1=0, i2=0, i3=0, i4=0;
    public Text text;
    // Update is called once per frame
    public void Quit()
    {
      //  gameObject.transform.localScale += new Vector3(1, 1, 1);
        Application.Quit();
    }
    void Update () {
        text.text = gameObject.transform.localRotation.ToString() + "        " + gameObject.transform.localEulerAngles.ToString()+"               "+i1.ToString()+" "+i2.ToString()+" "+i3.ToString()+" "+i4.ToString();
      
        {
            if (Input.GetKey(KeyCode.X))
            {
                gameObject.transform.Rotate(1, 0, 0);
                red.color = new Color(256, 0, 0);
            }
            else red.color = Color.white;
            if (Input.GetKey(KeyCode.Y))
            {
                gameObject.transform.Rotate(0, 1, 0);
                blue.color = new Color(0, 0, 256);
            }
            else blue.color = Color.white;
            if (Input.GetKey(KeyCode.Z))
            {
                gameObject.transform.Rotate(0, 0, 1);
                green.color = new Color(0, 256, 0);
            }
            else green.color = Color.white;
            if (Input.GetKey(KeyCode.Alpha1))
            {
                gameObject.transform.RotateAround(new Vector3(1, 0, 0), 0.01f);
                red1.color = Color.red;

            }
            else red1.color = Color.white;
            if (Input.GetKey(KeyCode.Alpha2))
            {
                gameObject.transform.RotateAround(new Vector3(0, 1, 0), 0.01f);
                green1.color = Color.green;
            }
            else green1.color = Color.white;
            if (Input.GetKey(KeyCode.Alpha3))
            {
                gameObject.transform.RotateAround(new Vector3(0, 0, 1), 0.01f);
                blue1.color = Color.blue;
            }
            else blue1.color = Color.white;
        }
       
        //if (Input.GetKey(KeyCode.X))
        //{
        //    gameObject.GetComponent<Transform>().localRotation.Set(i1, 0, 0, 0);
        //    i1 += 0.1f;

        //}
        //if (Input.GetKey(KeyCode.Y))
        //{
        //    gameObject.transform.localRotation.Set(0, i2, 0, 0);
        //    i2 += 0.1f;

        //}
        //if (Input.GetKey(KeyCode.Z))
        //{
        //    gameObject.transform.localRotation.Set(0, 0, i3, 0);
        //    i3 += 0.1f;

        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    gameObject.transform.localRotation.Set(0, 0, 0, i4);
        //    i4 += 0.1f;
        //}
    }
}
