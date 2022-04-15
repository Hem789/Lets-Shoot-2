using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sensitivity : MonoBehaviour
{
    public static float normal,shoot,zoom;
    public Slider a,b,c;
    void Awake()
    {
        levelData data=SaveManager.StoredItem();
        if(data!=null)
        {
        normal=data.normal;
        shoot=data.zoom;
        zoom=data.scoped;
        if(a!=null)
        {
        a.value=normal;
        b.value=shoot;
        c.value=zoom;
        }
        }
    }
    // Start is called before the first frame update
    public void load()
    {
        levelData data=SaveManager.StoredItem();
        if(data!=null)
        {
        normal=data.normal;
        shoot=data.zoom;
        zoom=data.scoped;
        a.value=normal;
        b.value=shoot;
        c.value=zoom;
        }
        else
        {
            a.value=0.5F;
            b.value=0.34F;
            c.value=0.04F;
        }
    }

    // Update is called once per frame
   
}
