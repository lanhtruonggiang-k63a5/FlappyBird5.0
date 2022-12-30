using System.Collections;
using UnityEngine;
public class BirdBehavior : MonoBehaviour
{
    //  public GameManager gameManager;
    // public SoundManager soundManager;
    [SerializeField] private float velocity;
    [SerializeField] private float rotateRate;
    private Rigidbody2D rb;
    private PolygonCollider2D pc;
 
    private Animator anim;

    private bool playing = false;
    private bool isDeath = false;

    public static bool s_isDeath = false;

    // -------------------------------------------------------------------------------------------------

    // [SerializeField]
    // private int _bruhTime = 1;
    // //Set max range
    // [Range(0, 10)] public int maxBruhTime = 8;
    // // use it as change to attribure on runtime
    // public int BruhTime
    // {
    //     get { return _bruhTime; }
    //     set { _bruhTime = Mathf.Clamp(value, 0, maxBruhTime); }
    //     // value is keyword
    // }
    // // In another class: use like attribute 
    // // but actual method(and naming)
    // // BruhTime = 5;
    // // Debug.Log(BruhTime);

    // // use it when change at editor
    // private void OnValidate()
    // {
    //     //ko có nghĩa dù ko sai
    //     _bruhTime = BruhTime;
    //     //set lại sau khi đổi
    //     BruhTime = _bruhTime;
    // }
    // private int _lmaoTime;

    // public int LmaoTime
    // {
    //     // using lamda expression
    //     get => _lmaoTime;
    //     set => _lmaoTime = value;
    // }

    // -------------------------------------------------------------------------------------------------
    //sound
    // public AudioSource fly;
    
    
    // public AudioSource hit;
    // public AudioSource fall;
    // public static int countHitPlay = 1;
    // private int countFallPlay = 1;
    public bool IsDeath()
    {
        return isDeath;
    }

    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pc = GetComponent<PolygonCollider2D>();
        rb.gravityScale = 0f;

        anim = GetComponent<Animator>();
        anim.SetBool("Death", false);
        s_isDeath = false;
    }



    private void Update()
    {

        if (Input.GetMouseButtonDown(0) && !playing)
        {

            if (Pause.clickState == 1 && Pause.onPause != 1)
            {
                OnPressToStart();
            }

        }
        else if (Input.GetMouseButtonDown(0) && !isDeath)
        {
            // if (! GameManager.gameIsPaused && Pause.releaseResume) BirdFly();
            // the same right??

            if (GameManager.gameIsPaused == false && Pause.releaseResume == true) BirdFly();
        }

        BirdNod();


        if (isDeath)
        {
            flashAnim.anim.SetBool("flash", true);
            // flashAnim.anim.SetInteger("bruh",1);
            // flashAnim.flashAnimEnum.
            // gameManager.disappearCanvasGameOver();
            GameManager.Instance.disappearCanvasGameOver();
            StartCoroutine(Death());
        }
    }
    private void OnPressToStart()
    {
        playing = true;
        rb.gravityScale = 1.7f;
        // gameManager.Play();
        GameManager.Instance.Play();
        rb.velocity = Vector2.up * velocity;
        // soundManager.CanPlayFlySound();
        SoundManager.Instance.CanPlayFlySound();
    }
    private void BirdNod()
    {
        rb.rotation += rb.velocity.y * rotateRate;
        rb.rotation = Mathf.Clamp(rb.rotation, -90f, 25f);
    }
    private void BirdFly()
    {
        rb.velocity = Vector2.up * velocity;
        if (Time.timeScale == 1f)
        {
            // soundManager.CanPlayFlySound();
            SoundManager.Instance.CanPlayFlySound();
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        TerrainAnim.anim.gameObject
                .GetComponent<Animator>()
                    .enabled = false;

        if (other.gameObject.CompareTag("Pipe"))
        {
            // CanPlayFallSound();
            // soundManager.CanPlayFallSound();
            SoundManager.Instance.CanPlayFallSound();
        }
        // soundManager.CanPlayHitSound();
        SoundManager.Instance.CanPlayHitSound();
        isDeath = true;
        Vibrator.Vibrate();
        s_isDeath = isDeath;
    }

    private IEnumerator Death()
    {
        PipeMove.speed = 0f;
        anim.SetBool("Death", true);
        yield return new WaitForSeconds(1.1f);
        // gameManager.CallGameOver();
        GameManager.Instance.CallGameOver();
    }
}
