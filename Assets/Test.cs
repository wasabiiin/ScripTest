using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;    // int型の変数mpを宣言し、53で初期化してください

    // 攻撃用の関数
    public void Attack(){
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage){
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // mpを消費して魔法攻撃をするMagic関数を作ってください
    public void Magic(){

        if (mp >= 5){
            // 魔法が使える場合
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        } else {
            // 魔法が使えない場合    
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour {
    private void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();

        //防御用の関数を呼び出す
        lastboss.Defence(3);
    }

    //Update is called once per frame
    private void Update()
    {
        
    }

}

