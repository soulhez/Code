using System;

namespace ReadEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GameType gameType = new GameType();
            string[] gameTypeNameArray = Enum.GetNames(gameType.GetType());
            Console.WriteLine("枚举个数：\t{0}", gameTypeNameArray.Length);
            for (int i = 0; i < gameTypeNameArray.Length; i ++)
            {
                Console.WriteLine("{0}", gameTypeNameArray[i]);
            }
        }

        public enum GameType
        {
            MMORPG,
            RPG,
            MOBA,
            RTS,
            FPS
        }
    }
}
