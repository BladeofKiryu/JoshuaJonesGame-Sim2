using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
             static void Main()
            {
                string str;
                int[] ch_fre = new int[255];
                int i = 0, max, l;
                int ascii;

                Console.Write("\n\nFind maximum occurring character in a string :\n");
                Console.Write("--------------------------------------------------\n");
                Console.Write("Input the string : ");
                str = Console.ReadLine();
                l = str.Length;

                for (i = 0; i < 255; i++)
                {
                    ch_fre[i] = 0;
                }
                
                i = 0;
                while (i < l)
                {
                    ascii = (int)str[i];
                    ch_fre[ascii] += 1;

                    i++;
                }
               
                max = 0;
                for (i = 0; i < 255; i++)
                {
                    if (i != 32)
                    {
                        if (ch_fre[i] > ch_fre[max])
                            max = i;
                    }
                }
                Console.Write("The Highest frequency of character '{0}' is appearing for number of times : {1} \n\n", (char)max, ch_fre[max]);
            }
        }
    }
}
