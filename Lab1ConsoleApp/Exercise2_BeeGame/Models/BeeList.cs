namespace EXERCISE2_BEEGAME.Models
{
    public class BeeList
    {
        public int count;
        public List<Bee> list = new List<Bee>();
        public BeeList(int count)
        {
            this.count = count;
        }
        public void CreateList(int count)
        {
            list.Clear();
            for (int i = 0; i < count; i++)
            {
                list.Add(new Queen());
                list.Add(new Worker());
                list.Add(new Drone());
            }
        }
        public void CreateList()
        {
            list.Clear();
            Random rand = new Random();

            for (var i = 0; i < 30; i++)
            {
                int type = rand.Next(0, 3);
                switch (type)
                {
                    case 0:
                        list.Add(new Queen());
                        break;
                    case 1:
                        list.Add(new Worker());
                        break;
                    case 2:
                        list.Add(new Drone());
                        break;
                    default:
                        break;
                }
            }
        }
        public void Attack()
        {
            Random random = new Random();
            foreach (var bee in list)
            {
                bee.Damage(random.Next(0, 80));
            }
        }
        public void OutPut()
        {
            foreach (var bee in list)
            {
                Console.WriteLine("{0}:  {1} {2} HP", bee.GetType().Name, bee.GetHealthState(), bee.health);
            }
        }
    }
}