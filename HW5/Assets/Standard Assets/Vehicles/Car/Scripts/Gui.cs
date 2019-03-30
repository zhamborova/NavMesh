using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gui : MonoBehaviour
{
    public Text r1;
    public Text r2;
    public Text r3;
    public Text t1;
    public Text t2;
    public Text t3;
    public Time1[] times;
 

 

 

    // Update is called once per frame
    void Update()
    {
        if (times[0].finished && times[1].finished && times[2].finished) {
            order();
        }
    }


    void order()
    {
        Sort(times);
        r1.text = times[0].name;
        r2.text = times[1].name;
        r3.text = times[2].name;

        t1.text = times[0].t.ToString("G");
        t2.text = times[1].t.ToString("G");
        t3.text = times[2].t.ToString("G");



    }


    public static void exchange(Time1[] data, int m, int n)
    {
        Time1 temporary =null;

        temporary = data[m];
        data[m] = data[n];
        data[n] = temporary;
    }

  

    public static void Sort(Time1[] data)
    {
        int i, j;
        int N = data.Length;

        for (j = N - 1; j > 0; j--)
        {
            for (i = 0; i < j; i++)
            {
                if (data[i].t > data[i + 1].t)
                    exchange(data, i, i + 1);
            }
        }
    }

}
