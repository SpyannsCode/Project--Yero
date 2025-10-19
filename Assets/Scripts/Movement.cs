using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Movement : MonoBehaviour
{
    public int movementSpeed = 5,i = 0;
    void Update()
    {
        transform.position += transform.rotation * new Vector3(0, 0, 1) * Time.deltaTime; 
        i++;
        if (i == 1)
        {
            CheckForTilesOrWalls();
            i = 0;
        }
    }
    private void CheckForTilesOrWalls()
    {
        RaycastHit hit;
        print("checked");
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit))
        {
            print("yipee");
            if (hit.transform.CompareTag("GN"))
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (hit.transform.CompareTag("GW"))
            {
                transform.rotation = Quaternion.Euler(0, -90, 0);
            }
            if (hit.transform.CompareTag("GS"))
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (hit.transform.CompareTag("GE"))
            {
                transform.rotation = Quaternion.Euler(0, -270, 0);
            }
        }
    }
}
