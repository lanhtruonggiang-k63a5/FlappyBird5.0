// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class RandomShinningPosition : MonoBehaviour
// {
//    private RectTransform rt;
//    private int radius = 35;
   
//    public static bool isSparkle;
//    public Sprite star;
//    public static Sprite starVal;
//    private Image img;
//    [SerializeField] private float spawnTime;

//    private void Start()
//    {
//         rt = GetComponent<RectTransform>();
//         img = GetComponent<Image>();
//         isSparkle = false;
//         starVal= star;
//    }
//     void Update()
//     {
//         Debug.Log("isSparkle"+ isSparkle);

//         if(isSparkle){
//             isSparkle=false;
//             StartCoroutine(Spawn());
//         }
        
//     }
//     private void SpawnSparkle(){
//         // posX = Random.Range(-0.99f,0.99f);
//         // var absX = Mathf.Abs(posX);

//         // posY = Random.Range(-1+absX,1-absX);
//         // Debug.Log("x: "+posX+"y: "+posY);
        
//         // rt.LeanSetLocalPosX(posX*radius);
//         // rt.LeanSetLocalPosY(posY*radius);
//         // Debug.Log(rt.position.ToString());
//         var rand = Random.Range(0.01f, 0.99f);
//         var r = radius * Mathf.Sqrt(rand);
//         var theta = rand *2* Mathf.PI;
//         rt.LeanSetLocalPosX(r*Mathf.Cos(theta));
//         rt.LeanSetLocalPosY(r*Mathf.Sin(theta));


//     }
//     private IEnumerator Spawn(){
//         img.sprite = starVal;
//         SpawnSparkle();
//         yield return new WaitForSeconds(spawnTime);
//         isSparkle=true;
//     }
    
    
// }
