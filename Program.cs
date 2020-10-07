using System;

namespace Lesson01_Enums
{
    public enum OrderStatus
    {
        Quoted = 1,
        Purchased = 2,
        Shipped,
        Delivered
    }

    public enum SampleCounting
    {
        Apple = 5,
        Pear, // 6
        Peach = 2,
        Watermelon, // 3
        Pineapple = 5
    }

    public class Order
    {
        public OrderStatus Status { get; private set; }

        public void AdvanceStatus()
        {
            switch (Status)
            {
                case OrderStatus.Quoted:
                    Status = OrderStatus.Purchased;
                    break;
                case OrderStatus.Purchased:
                    Status = OrderStatus.Shipped;
                    break;
                case OrderStatus.Shipped:
                    Status = OrderStatus.Delivered;
                    break;
            }
        }
    }
}
int status = 3;
if((OrderStatus)status == OrderStatus.Shipped)
{
    // do stuff
}
public enum FruitA
{
    Apple = 1
}
public enum FruitB
{
    Apple = 1
}
FruitA a = FruitA.Apple;
FruitB b = FruitB.Apple;

// compile error, not the same type
if(a == b)
{

}

//valid, now we are comparing integer values
if((int)a == (int)b)
{
    Console.WriteLine("The status with value 3 id: {0}",
        Enum.GetName(typeof(OrderStatus), 3));
}