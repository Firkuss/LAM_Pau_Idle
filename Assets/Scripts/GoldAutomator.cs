using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class GoldAutomator : MonoBehaviour
{
    public GoldManager goldA;
    public int price;
    public int giver;
    public float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = 1;
        Givebysecond(false);
    }

    public IEnumerator Givebysecond(bool activate)
    {
        yield return new WaitForSeconds(time);
        goldA.goldAmount = goldA.goldAmount + giver;
    }

    public void ChangeAuto()
    {
        if (goldA.goldAmount >= price)
        {
            Givebysecond(true);
            time = time * 0.5f;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
