using System.Collections.Generic;
using Assets.Function1._06.Scripts.Model;
using SimpleJSON;
using UnityEngine;

namespace Assets.Function1._06.Scripts.Controller
{
    public class Duqu : MonoBehaviour
    {
        //声明存储数据的列表
        public List<Read> item;

        //初始化对象
        private void Awake()
        {
            //读取json数据
            TextAsset txt = Resources.Load<TextAsset>("data");
            JSONNode jsonObject = JSON.Parse(txt.text);
            //创建对象
            for (int i = 0; i < jsonObject[0].Count; i++)
            {
                Read fieldRead = new Read
                {
                    Type = jsonObject[0][i]["type"],
                    Num = jsonObject[0][i]["num"],
                    SubType = jsonObject[0][i]["subType"],
                    ProductId = jsonObject[0][i]["productId"],
                    CostGold = jsonObject[0][i]["costGold"],
                    CostDiamond = jsonObject[0][i]["costDiamond"],
                    IsPurchased = jsonObject[0][i]["isPurchased"]
                };
                item.Add(fieldRead);
            }
        }
    }
}