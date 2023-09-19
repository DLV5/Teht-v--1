public class PlayerData
{
    public string name;

    private int _health;
    public int Health 
    {
        get => _health;
        set
        {
            _health = value;
            if (_health > 100) _health = 100;
            if (_health <= 0) _health = 1;
        }
    }

    public PlayerData(string name, int health)
    {
        this.name = name;
        Health = health;
    }
}
