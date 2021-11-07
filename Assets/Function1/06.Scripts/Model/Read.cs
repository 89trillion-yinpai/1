using System;

//数据序列化
namespace Assets.Function1._06.Scripts.Model
{
    [Serializable]
    public class Read
    {
        //声明属性及类型
        public string Type;
        public string Num;
        public string ProductId;
        public int SubType;
        public string CostGold;
        public string CostDiamond;

        public bool IsPurchased;
        // Start is called before the first frame update
    }
}