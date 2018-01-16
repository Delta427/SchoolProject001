using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

public bool moveLeft = false;

    

    void Update () 

    {

        if(moveLeft)

        {

            transform.Translate(Vector3.left * Time.deltaTime);

        }

        

        else

        {

            transform.Translate(Vector3.right * Time.deltaTime);

        }

    }

        void OnTriggerEnter (Collider other)
		  //void OnCollisionEnter(Collision collision)
        {

            if(other.tag == "Trigger")

            {

                print("Working");

                moveLeft = !moveLeft;

    

            }

    }

}
