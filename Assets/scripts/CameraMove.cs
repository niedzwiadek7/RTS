using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public int speed;
    public int wheelspeed;
    
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movespeedx = Input.GetAxis("Horizontal") * Time.deltaTime * speed;// przesuwanie na osi x
        float movespeedy = Input.GetAxis("Vertical") * Time.deltaTime * speed;//przesuwanie na osi y

        transform.Translate(movespeedx, movespeedy, 0 );

        float movespeedz = Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * wheelspeed;
        {
            transform.Translate(0, 0, movespeedz);
        }
        
    }
}
