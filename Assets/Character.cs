using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    public GameObject position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0, 0, Time.deltaTime * speed);
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        else if(Input.GetKey(KeyCode.S))
        {
            //transform.position -= new Vector3(0, 0, Time.deltaTime * speed);
            transform.position -= transform.forward * Time.deltaTime * speed;
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * rotateSpeed, 0));
        }

        else if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * -rotateSpeed, 0));
        }

        position.GetComponent<Text>().text = ("Position: " + "(" + transform.position.x.ToString("0.0") + " " + transform.position.y.ToString("0.0") + " " +  transform.position.z.ToString("0.0") + ")");
    }
}
