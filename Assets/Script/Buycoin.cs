using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.UI;
 
public class Buycoin : MonoBehaviour
{
    public Text wallet;
    public void Hit_test(int num)//加钱方法
    {
        int i;
        i =Convert.ToInt32(wallet.text);//强制类型转换成整形进行计算
        i += num;
        wallet.text = i.ToString();//再把原本的类型转换回来
    }
}