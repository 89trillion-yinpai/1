using System;
using UnityEngine.UI;

namespace Assets.Function1._06.Scripts.Controller
{
    public class Buycoin : Duqu
    {
        //金币总数
        public Text wallet;

        //加钱方法
        public void Hit_test(int num)
        {
            int i;
            //强制类型转换成整形进行计算
            i = Convert.ToInt32(wallet.text);
            i += num;
            //再把原本的类型转换回来
            wallet.text = i.ToString();
        }
    }
}