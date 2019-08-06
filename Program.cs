using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            TossMultipleCoins(8);
            // RandNames();
        }

        //Random Array
        public static void RandomArray(){
            Random rand = new Random();
            int[] newArr = new int[10];
            int min = 25; //I do not like this, not sure how to make it universal since when you create an array all idx values are 0
            int max = 0;
            int sum = 0;
            for(int i = 0; i < 10; i++){
                int j = rand.Next(5,25);
                newArr[i] = j;
                if(j > max){
                    max = j;
                }
                if(j < min){
                    min = j;
                }
                sum = sum + j;
                System.Console.WriteLine(newArr[i]);
            }
            System.Console.WriteLine("Max: " + max + ", Min: " + min + ", Sum: " + sum);
        }

        //Flip a coin
        public static void TossCoin(){
            System.Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int j = rand.Next(0, 2);
            if(j == 0){
                System.Console.WriteLine("Heads!");
            }
            else{
                System.Console.WriteLine("Tails!");
            }
        }

        public static void TossMultipleCoins(int num){
            int heads = 0;
            int tosses = 0;
            Random rand = new Random();
            int i = 0;
            while(i < num){
                tosses++;
                int j = rand.Next(0,2);
                if(j == 0){
                    heads++;
                    System.Console.WriteLine("Heads!");
                }
                else{
                    System.Console.WriteLine("Tails!");
                }
                i++;
            }
            System.Console.WriteLine($"Total number of heads vs. total tossed {heads}:{tosses}"); //Does not work
        }

        //Names
        public static void RandNames(){
            List<string> nameList = new List<string>();
            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sydney");
            Random rand = new Random();
            for(int i = 0; i < 5; i++){ //once again not universal
                int j = rand.Next(0,5);
                string temp = nameList[i];
                nameList[i] = nameList[j];
                nameList[j] = temp;
            }
            for(int i = 0; i < 5; i++){
                if(nameList[i].Length > 4){
                    System.Console.WriteLine(nameList[i]);
                }
            }
        }
    }
}
