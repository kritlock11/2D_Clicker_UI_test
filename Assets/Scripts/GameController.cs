using CLICKER2D;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private EnemyController _enemyController;
    private PlayerController _playerController;
    private Touch touch;
    private RaycastHit2D hit;
    public Animator _WeaponsBTN;
    public Animator _ArmorBTN;
    public Animator _PotionsBTN;
    public Animator _FoodBTN;
    public Image _WeaponsBTN_img;
    public Image _ArmorBTN_img;
    public Image _PotionsBTN_img;
    public Image _FoodBTN_img;

    public TextMeshProUGUI TotalDMGText;
    public TextMeshProUGUI _CPSText;
    public TextMeshProUGUI DPSText;

    private float TouchCounter;
    private float time = 1;
    private float _time = 1f;
    public float TouchPerSec;

    public float _SumDamage;

    //swipes




    void Start()
    {
        _enemyController = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyController>();
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }



    void Update()
    {
        TouchDetection();
        MouseToEnemyDamage();
        TouchToEnemyDamage();

        TotalDMGText.text = $"Player Damage: {_playerController.Damage}";
        if (time <= 0)
        {
            _SumDamage = TouchCounter * _playerController.Damage;
            _CPSText.text = $"CPS:{TouchCounter}";
            DPSText.text = $"DPS:{_SumDamage}";
            TouchCounter = 0;
            time = 1;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }

    private bool TouchDetection()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);
        }
        return Input.touchCount > 0;
    }

    private void TouchToEnemyDamage()
    {
        if (TouchDetection())
        {
            if (hit.collider != null && touch.phase == TouchPhase.Began)
            {
                if (hit.collider.CompareTag("Enemy"))
                {
                    _enemyController.TakeDamage(_playerController.Damage);
                    _enemyController.HpSlider.value = _enemyController.CurrentHealth;
                    TouchCounter++;
                }
            }
        }
    }
    private void MouseToEnemyDamage()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Enemy"))
                {
                    _enemyController.TakeDamage(_playerController.Damage);
                    _enemyController.HpSlider.value = _enemyController.CurrentHealth;
                    TouchCounter++;
                }
            }
        }
    }

}
