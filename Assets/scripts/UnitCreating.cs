using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCreating : MonoBehaviour
{
    public Rigidbody jas;
   // private GameObject s;
    private GameObject x;
    
   public void create()
    {
       // s = GameObject.Find("budynek");
        x = GameObject.Find("Cube");
      Rigidbody instiance =  Instantiate(jas, new Vector3(x.transform.position.x, x.transform.position.y, x.transform.position.z),Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         /* if (Input.GetButtonDown("Fire1"))
          {
              create();
          }*/
        
    }
}
