using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

        private void Start()
        {
            int[] points = { 30, 20, 50, 10, 80 };

            for (int i = 0; i < points.Length; i++)
            {
                Debug.Log(points[i]);
            }

            for (int i = points.Length - 1; i >= 0; i--)
            {
                Debug.Log(points[i]);
            }

            //Bossクラスを生成
            Boss lastboss = new Boss();

            //Magic関数を１０回呼び出す
            for (int i = 0; i < 11; i++)
            {
                lastboss.Magic();
            }
        }

    
}
