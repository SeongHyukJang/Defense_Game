using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] points;
    //public int i = 0;

    private void Awake()
    {
        points = new Transform[transform.childCount];

        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }

        /*while (true)
        {
            if (i == points.Length)
            {
                i = 0;
            }
            points[i] = transform.GetChild(i);
 
            i++;
        }*/

        
    }
}
