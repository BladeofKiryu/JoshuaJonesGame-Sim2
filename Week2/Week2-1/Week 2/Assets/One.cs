using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {

           
            static int countMultiples(int n)
            {
                int res = 0;
                for (int i = 1; i <= n; i++)
                    if (i % 3 == 0 || i % 7 == 0)
                        res++;

                return res;
            }

            static void Main()
            {
                Console.Write("Count = ");
                Console.WriteLine(countMultiples(25));
            }
        }
    }
}
