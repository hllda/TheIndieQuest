﻿using System;
using System.IO;
namespace Day_1_Mission_2_Flying_Ability
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Projects\TheIndieQuest\Week 6\Day 1 Mission 2 Flying ability\MonsterManual.txt";
            string manual = File.ReadAllText(path);

            String[] monster = manual.Split("\n\n");

            for(int i = 0; i < monster.Length; i++)
            {
                String[] info = monster[i].Split("\n");

                Console.Write(info[0]);
                Console.Write(" - Can fly: ");
                if(info[4].Contains(" fly ") == true)
                {
                    Console.Write("True");
                }

                else
                {
                    Console.Write("False");
                }

                Console.WriteLine();
            }
        }
    }
}

