using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	public float restartDelay = 5f;
    public Camera cam1;
    public Camera cam2;


    Animator anim;
	float restartTimer;

    void Start()
    {
        cam1.rect = new Rect(0, 0, 0.5f, 1);
        cam2.rect = new Rect(0.5f, 0, 0.5f, 1);
    }



    void Awake()
    {
        anim = GetComponent<Animator>();

    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");

			restartTimer += Time.deltaTime;

			if (restartTimer >= restartDelay) {
				Application.LoadLevel(Application.loadedLevel);
			}
        }
    }
}
