namespace EXERCISE2_BEEGAME.Models
{
    public class Bee
    {
        public int health { get; protected set; }
        public bool dead;
        protected float deadPoint;
        public Bee()
        {
            health = 100;
            dead = false;
        }
        public int Damage(int damagePoint)
        {

            if (dead != true)
            {
                health = (health >= damagePoint) ? health - damagePoint : 0;
            }
            CheckDead();
            return health;
        }
        public string GetHealthState()
        {
            return dead ? "dead" : "alive";
        }
        public void CheckDead()
        {
            float healthPercent = (float)health / 100;
            if (healthPercent < deadPoint)
            {
                dead = true;
            }
        }
    }
}