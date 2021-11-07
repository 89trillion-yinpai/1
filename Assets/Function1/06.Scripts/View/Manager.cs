using Assets.Function1._06.Scripts.Controller;
using UnityEngine;
using UnityEngine.UI;
public class Manager : Duqu
{
    //声明预制件
    public GameObject Coinprefab;
    public GameObject Cardprefab;
    public GameObject LockPrefab;
    //声明"Duqu"对象，一会读取属性创建ui对象要用
    public Duqu read;
    //声明精灵类型图片
    public Sprite type7;
    public Sprite type13;
    public Sprite type18;
    public Sprite type20;
    
    [System.Obsolete]
    private void Start()
    {
        //根据type创建UI
        for (int i = 0; i < read.item.Count; i++)
        {
            //判断是金币类型的ui搭建
            if (read.item[i].Type == "2") 
            {
                Coinprefab = Instantiate(Coinprefab,transform);
            }
            else
            {
                //创建卡牌对象
                Cardprefab=Instantiate(Cardprefab,transform);
                foreach (Transform obj in Cardprefab.GetComponentsInChildren<Transform>(true))
                {
                    if (obj.name == "cards")
                    {
                        obj.GetComponent<Image>().sprite = TureType(read.item[i].SubType);
                    }
                    if (obj.name == "Coins")
                    {
                        obj.GetComponent<Text>().text=read.item[i].CostGold;
                    }
                }
            }
        }
        for (int i = 0; i < (3 - (read.item.Count % 3)); ++i){}//空位加锁定界面
        {
            Instantiate(LockPrefab,transform);       
        }
    }

    //匹配每张卡牌的图片
    public Sprite TureType(int x)
    {
        
        if (x == 7)
        {
            return type7;
        }
        else if (x == 13)
        {
            return type13;
        }
        else if (x == 18)
        {
            return type18;
        }
        else if (x == 20)
        {
            return type20;
        }
        return null;
    }
}