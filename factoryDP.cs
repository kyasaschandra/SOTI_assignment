using System;

public class FactoryDP
{
	public getClass(string type)
	{
        switch (type)
        {
            case "Tax": return new Tax();
                break;
        }
	}
}

abstract class AbstractClass
{
    protected double amount = 0;
    public abstract getAmount();
	protected int Beds;
        protected double ratePDay;
        public abstract void GetRate();

        public void GetBill(double hours) {
            Console.WriteLine(hours*ratePDay*Beds);
        }
}
class DoubleBedRoom : AbstractClass
    {
        
        public override void GetRate() {
            ratePDay = 1000;
            Beds = 2;
        }

        
    }

    class SingleBedRoom : AbstractClass
    {
        public override void GetRate()
        {
            ratePDay = 800;
            Beds = 1;
        }
    }

    class TripleBedRoom : AbstractClass
    {
        public override void GetRate()
        {
            ratePDay = 1100;
            Beds = 3;
        }
    }

    class GetRoomFactory
    {
        public AbstractClass GetRoom(string RoomType) {
            switch (RoomType) {
                case "SINGLE":
                    return new SingleBedRoom();
		    break;
                case "DOUBLE":
                    return new DoubleBedRoom();
		    break;
                case "TRIPLE":
                    return new TripleBedRoom();
		    break;
                default:
                    return null;
		    break;
            }
        }

    }

