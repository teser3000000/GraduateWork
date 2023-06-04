using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Sprite pic1;
    public Sprite pic2;

    public Image im;
    void Start()
    {
        im = GetComponent<Image>();
        im.sprite = pic1;
    }
    public void Swap()
    {
        if (im.sprite == pic1)
        {
            im.sprite = pic2;
            return;
        }

        if (im.sprite == pic2)
        {
            im.sprite = pic1;
            return;
        }
    }


}
