namespace HelloWorld
{
using System;




    struct player
    {
        public string name;
        public int health;
        public int damage;
    }

    struct item
    {
        public int statBoost;


    }
    class Game
    {
        bool _gameOver = false;
        player _player1;
        player _player2;
        item Longsword;
        item dagger;
        //Run the game
        public void Run()
        {
            Start();

            while(_gameOver == false)
            {
                Update();
            }
            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            InitializePlayers();
            Initializeitems();

        }
        
        public void InitializePlayers()
        {
            _player1.health = 100;
            _player1.damage = 5;

            _player1.health = 100;
            _player2.damage = 5;

        }
        void Initializeitems()
        {
            Longsword.statBoost = 15;
            dagger.statBoost = 10;
        }
    public void GetInput(out char input, string option1, string option2, string query)
    {
        Console.WriteLine(query);
        Console.WriteLine("1." + option1);
        Console.WriteLine("2." + option2);
        Console.Write("> ");
        input = ' ';
        while(input != '1' && input != '2')
        {
            input = Console.ReadKey().KeyChar;
            if(input != '1' && input != '2')
            {
                Console.WriteLine("Invalid input");
            }
             


        }
    }

        public void StartBattle()
        {
            
            Console.WriteLine("Now GO!");

            while (_player1.health > 0 && _player2.health > 0)
            {
                //print player stats to console
                Console.WriteLine("Player1");
                PrintStats(_player1);
                Console.WriteLine("Player2");
                PrintStats(_player2);
                //Player 1 turn start
                //Get player input
                char input;
                GetInput(out input, "Attack", "NO", "Your turn Player 1");

                if (input == '1')
                {
                    _player2.health -= _player1.damage;
                    Console.WriteLine("Player 2 took " + _player1.damage + " damage!");
                }
                else
                {
                    Console.WriteLine("NO!!!!!");
                }

                GetInput(out input, "Attack", "NO", "Your turn Player 2");

                if (input == '1')
                {
                    _player1.health -= _player2.damage;
                    Console.WriteLine("Player 1 took " + _player2.damage + " damage!");
                }
                else
                {
                    Console.WriteLine("NO!!!!!");
                }
                Console.Clear();
            }
            if (_player1.health > 0)
            {
                Console.WriteLine("Player 1 wins!!1!1!!11!11?");
            }
            else
            {
                Console.WriteLine("Player 2 wins??????????");
            }
            _gameOver = true;
        }
        public void EquipItems()
    {   //get input from player1
        Console.WriteLine("Welcome! Player one please chopose a weapon.");
        Console.WriteLine("1.Longsword");
        Console.WriteLine("2.Dagger");
        
        char input;
        GetInput(out  input, "Longsword", "Dagger", "Welcome player one please choose a weapon");
        //get input for player 2
            if(input == '1')
        {
            _player1.damage += Longsword.statBoost;
        }
            else if(input == '2')
        {
            _player2.damage += dagger.statBoost;
        }Console.WriteLine("Player 1");
            PrintStats(_player1);
    }   
       
                
        //prints palyer stats to console
        public void PrintStats(player player)
        {
            Console.WriteLine("Health:" + player.health);
            Console.WriteLine("Damage:" + player.damage);
        }
        //Repeated until the game ends
        public void Update()
        {
            EquipItems();
            StartBattle();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
