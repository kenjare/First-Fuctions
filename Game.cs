using System;
namespace HelloWorld
{










    struct item

    {
        public int statBoost;


    }
    class Game
    {

        private bool _gameOver = false;
        private Player _player1;
        private Player _player2;
        private item _Longsword;
        private item _dagger;
        //Run the game
        public void InitializeItem()
        {
           _Longsword.statBoost = 17;
            _dagger.statBoost = 12;
        }
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }
            End();
        }

        //Performed once when the game begins
        public void Start()
        {
        
        
        }


        


    

        void Initializeitems()
        {
            _Longsword.statBoost = 15;
            _dagger.statBoost = 10;
        }
        public void GetInput(out char input, string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.Write("> ");
            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid input");
                }



            }
        }
        public void SelectItems()
        {   //get input from player1
            Console.WriteLine("Welcome! Player one please chopose a weapon.");
            Console.WriteLine("1.Longsword");
            Console.WriteLine("2.Dagger");

            char input;
            GetInput(out input, "Longsword", "Dagger", "Welcome player one  choose a weapon");
            //get input for player 2
            if (input == '1')
            {
                _player1.AddItemToInventory(_Longsword, 0);
            }
            else if (input == '2')
            {

                _player2.AddItemToInventory(_dagger, 0);
            }
            Console.WriteLine("Player 1");
            _player1.PrintStats();
        }
        public void StartBattle()
        {

            Console.WriteLine("Now GO!");

            while (_player1.GetIsAlive() && _player2.GetIsAlive())
            {
                //print player stats to console
                Console.WriteLine("Player1");
                _player1.PrintStats();
                Console.WriteLine("Player2");
                _player2.PrintStats();
                //Player 1 turn start
                //Get player input
                char input;
                GetInput(out input, "Attack", "NO", "Your turn Player 1");

                if (input == '1')
                {
                    _player1.Attack(_player2);
                }
                else
                {
                    Console.WriteLine("NO!!!!!");
                }

                GetInput(out input, "Attack", "NO", "Your turn Player 2");

                if (input == '1')
                {
                    _player2.Attack(_player1);
                }
                else
                {
                    Console.WriteLine("NO!!!!!");
                }
                Console.Clear();
            }
            if (_player1.GetIsAlive())
            {
                Console.WriteLine("Player 1 wins!!1!1!!11!11?");
            }
            else
            {
                Console.WriteLine("Player 2 wins??????????");
            }
            _gameOver = true;
        }


        //prints palyer stats to console
        public Player CreateCharacter()
        {
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            item weapon;
            weapon.statBoost = 27;
        Player player = new Player(name, 100, 10, 5);
            player.AddItemToInventory(weapon,10);
            return player;



        }
        //Repeated until the game ends
        public void Update()
        {
            _player1 = CreateCharacter();

            StartBattle();
        }

        //Performed once when the game ends
        public void End()
        {

        }
    }
}