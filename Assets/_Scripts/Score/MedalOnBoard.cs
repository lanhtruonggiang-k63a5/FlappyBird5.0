using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MedalOnBoard : MonoBehaviour
{
    private static Image img;
    public Sprite copper, silver, gold, plantinum;

    public static Sprite copperVal, silverVal, goldVal, plantinumVal;
    public static bool isSparkle = false;

    private void Start()
    {

        img = GetComponent<Image>();
        copperVal = copper;
        silverVal = silver;
        goldVal = gold;
        plantinumVal = plantinum;
        // ps= GetComponentInChildren(typeof(ParticleSystem)) as ParticleSystem;
        // private ParticleSystem ps; = GetComponentInChildren<ParticleSystem>();
        isSparkle = false;

    }
    public static void SetMedal(int i)
    {


        if (i >= 10 && i < 20)
        {
            img.sprite = copperVal;
            isSparkle = true;


        }
        else if (i >= 20 && i < 30)
        {
            img.sprite = silverVal;
            isSparkle = true;
        }
        else if (i >= 30 && i < 40)
        {
            img.sprite = goldVal;
        }
        else if (i >= 40)

        {
            //this.gameObject.GetComponent<Image>().sprite = gold;
            //line above will create an MedalOnBoard script on GameObj runtime. So it's lack of 3 sprite.
            img.sprite = plantinumVal;
            isSparkle = true;
        }
    }


}
