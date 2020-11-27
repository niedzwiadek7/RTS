using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCasting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    public int x;
    public int y;
    public int z;
    public int a;
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    canvas.SetActive(true);
                }
                else
                {
                    canvas.SetActive(false);
                }

            }
          
        }
            /*  RaycastHit hit;

        if (Physics.Raycast(transform.position, new Vector3(x, y, z), out hit, 10000))
              {
                  if (hit.collider.gameObject.tag == "Player")
                  {
                canvas.SetActive(true);
                a++;
                  }
              }*/

    }
}
