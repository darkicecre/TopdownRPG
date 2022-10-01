using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBandit : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float hp;
    public float rangeAttack;
    public Animator animator;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Blue Witch");
        if(player.transform.position.x-transform.position.x>0){
            transform.localScale = new Vector3(-3,3,1);
        }
        else{
            transform.localScale = new Vector3(3,3,1);

        }
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist<=rangeAttack) 
        {
            animator.SetBool("attack", true);
            // player.GetComponent<Transform>().Hp-=1;
        }
        else
        {
            transform.Translate((player.transform.position - transform.position) * speed*Time.deltaTime);
            animator.SetBool("attack", false);
        }
        
    }
}
