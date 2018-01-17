using System;

namespace New_folder
{
    public class Game
    {
        public int obj;
        /*obj=1 Rock
        obj=2 Paper
        obj=3 Scissor */
        public Game()
        {
            obj=0;
        }
        public void TurnIfPc()
        {
            Random random=new Random();
            obj=random.Next(1,4);
            if(obj==1)
            Console.WriteLine("Rock");
            else if(obj==2)
            Console.WriteLine("Paper");
            else 
            Console.WriteLine("Scissor");
        }
        public void TurnIfUser()
        {
            bool check=false;
            while(!check)
            {
                check=true;
            Console.WriteLine("Enter your object");
            string line=Console.ReadLine();
            line=line.ToLower();
            if(line.Equals("rock"))
            obj=1;
            else
            if(line.Equals("paper"))
            obj=2;
            else
            if(line.Equals("scissor"))
            obj=3;
            else
            check=false;
            
            }    
        }
        public void Play(Game user,Game pc)
        {
            if(user.obj==pc.obj)
            {Console.WriteLine("Game Tie");
            return ;
            }
            if(user.obj==1)
            {
                if(pc.obj==2)
                Console.WriteLine("You Lost");
                else
                Console.WriteLine("You Won");
                return;
            }
            if(user.obj==2)
            {
                if(pc.obj==3)
                Console.WriteLine("You Lost");
                else
                Console.WriteLine("You Won");
                return;
            }
            if(user.obj==3)
            {
                if(pc.obj==1)
                Console.WriteLine("You Lost");
                else
                Console.WriteLine("You Won");
            }
        
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game user=new Game();
            Game pc=new Game();
            int choice=9;
            while(choice!=3)
            {
                Console.Clear();
                Console.WriteLine("    *****ROCK PAPER SCISSOR*****");
                Console.WriteLine("Press key for following:");
                Console.WriteLine("1. KNOW THE RULES");
                Console.WriteLine("2. PLAY GAME");
                Console.WriteLine("3. EXIT");
                String line=Console.ReadLine();
                int.TryParse(line,out choice);
                if(choice!=1&&choice!=2&&choice!=3)
                continue;
                if(choice==1)
                {
                    Console.Clear();
                    Console.WriteLine("1.Rock Wins over Scissor");
                    Console.WriteLine("2.Paper Wins Over Rock");
                    Console.WriteLine("3.Scissor Wins over Paper");
                    Console.WriteLine("Press any Key..");
                    string s=Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if(choice==2)
                {
                    Console.Clear();
                    user.TurnIfUser();
                    pc.TurnIfPc();
                    pc.Play(user,pc);
                    Console.ReadLine();
               }
                
    }   
        }
    }
}
