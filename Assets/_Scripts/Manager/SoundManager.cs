
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }
    //fallSound
    public AudioSource fall;
    private int countFallPlay = 1;
    //hitsound
    public AudioSource hit;
    private int countHitPlay = 1;
    //flysound
    public AudioSource fly;

    //chopwindsound
    public AudioSource chopWind;
    private bool _CanChopWindPlay;
    public bool CanChopWindPlay
    {
        get { return _CanChopWindPlay; }
        set { _CanChopWindPlay = value; }
    }
    
   
    private void Awake()
    {
        Instance = this;
    }
    // public static SoundManager GetInstance(){
    //     if(Instance == null){
    //         Instance = new SoundManager();
    //     }
    //     return Instance;
    // }
    //scoreSound
    public AudioSource score;



    // Start is called before the first frame update
    void Start()
    {
        countFallPlay = 1;
        countHitPlay = 1;
    }

    // Update is called once per frame
    public void CanPlayFallSound()
    {
        if (countFallPlay == 1)
        {
            fall.Play();
            countFallPlay--;
        }
    }
    public void CanPlayHitSound()
    {
        if (countHitPlay == 1)
        {
            hit.Play();
            countHitPlay--;
        }
    }
    public void CanPlayFlySound()
    {
        fly.Play();
    }

    public void CanPlayChopWindSound()
    {
        if (CanChopWindPlay)
        {
            chopWind.Play();
            CanChopWindPlay = false;
        }
    }

    public void CanPlayScoreSound()
    {
        score.Play();
    }
    public void PlayChopWindSound(){
        chopWind.Play();
    }
}
