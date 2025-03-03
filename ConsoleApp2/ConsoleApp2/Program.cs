using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ConsoleApp5
{
    public class Map
    {
        static char[,] map =
        {
            { '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█','█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█','█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', 'G', '█'},
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '█' },
        { '█', ' ', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█','█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█','█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'}
        };
        public static Stopwatch stopwatch = new Stopwatch(); // 스톱워치 객체 생성

        public static int playerX = 22, playerY = 1, stageNum = 0;
        public static List<(int x, int y, int direction)> enemies = new List<(int, int, int)>
        {
            (2, 2, -1), (2, 3, -1),(3, 4, -1), (3, 5, -1),(4, 6, -1),(4, 7, -1),(5, 8, -1),(5, 9, -1), (6, 10, -1),(6, 11, -1),(7, 12, -1), (7, 13, -1),(8, 14, -1),(8, 15, -1), (9, 16, -1),(9, 17, -1),(10, 18, -1),(10, 19, -1),(11, 20, -1),(11, 21, -1), (12, 22, -1),(12, 23, -1),(13, 24, -1),(13, 25, -1),(2, 30, -1),(2, 31, -1),(3, 32, -1),(3, 33, -1),(4, 34, -1),(4, 35, -1),(5, 36, -1),(5, 37, -1),(6, 38, -1),(6, 39, -1),(7, 40, -1),(7, 41, -1),(8, 42, -1),(8, 43, -1),(9, 44, -1),(9, 45, -1),(10, 46, -1),(10, 47, -1),(11, 48, -1),(11, 49, -1),(12, 50, -1),(12, 51, -1),(13, 52, -1),(13, 53, -1),(14, 54, -1),(14, 55, -1)
            //(1, 1, -1), (2, 1, -1), (3, 58, -1), (4, 58, -1), (5, 1, -1), (6, 1, -1), (7, 58, -1), (8, 58, -1), (9, 1, -1), (10, 1, -1), (11, 58, -1), (12, 58, -1), (13, 1, -1), (14, 1, -1), (15, 58, -1), (16, 58, -1), (17, 1, -1), (18, 1, -1), (19, 58, -1), (20, 58, -1)
        };
        public static List<(int x, int y, int direction)> enemies2 = new List<(int, int, int)>
        {
            (1, 1, -1), (2, 1, -1), (3, 58, -1), (4, 58, -1), (5, 1, -1), (6, 1, -1), (7, 58, -1), (8, 58, -1), (9, 1, -1), (10, 1, -1), (11, 58, -1), (12, 58, -1), (13, 1, -1), (14, 1, -1), (15, 58, -1), (16, 58, -1), (17, 1, -1), (18, 1, -1), (19, 58, -1), (20, 58, -1)
            //(1, 2, -1), (1, 3, -1), (20, 4, 1), (20, 5, 1), (1, 6, -1), (1, 7, -1),(20, 8, 1), (20, 9, 1), (1, 10, -1), (1, 11, -1),(20, 12, 1), (20, 13, 1), (1, 14, -1), (1, 15, -1),(20, 16, 1), (20, 17, 1), (1, 18, -1), (1, 19, -1),(20, 20, 1), (20, 21, 1), (1, 22, -1), (1, 23, -1),(20, 24, 1), (20, 25, 1), (1, 26, -1), (1, 27, -1), (20, 28, 1), (20, 29, 1), (1, 30, -1), (1, 31, -1),(20, 32, 1), (20, 33, 1), (1, 34, -1), (1, 35, -1),(20, 36, 1), (20, 37, 1), (1, 38, -1), (1, 39, -1),(20, 40, 1), (20, 41, 1), (1, 42, -1), (1, 43, -1),(20, 44, 1), (20, 45, 1), (1, 46, -1), (1, 47, -1),(20, 48, 1), (20, 49, 1), (1, 50, -1), (1, 51, -1),(20, 52, 1), (20, 53, 1), (1, 54, -1), (1, 55, -1)
        };
        public static List<(int x, int y, int direction)> enemies3 = new List<(int, int, int)>
        {
            (1, 2, -1), (1, 3, -1), (20, 4, 1), (20, 5, 1), (1, 6, -1), (1, 7, -1),(20, 8, 1), (20, 9, 1), (1, 10, -1), (1, 11, -1),(20, 12, 1), (20, 13, 1), (1, 14, -1), (1, 15, -1),(20, 16, 1), (20, 17, 1), (1, 18, -1), (1, 19, -1),(20, 20, 1), (20, 21, 1), (1, 22, -1), (1, 23, -1),(20, 24, 1), (20, 25, 1), (1, 26, -1), (1, 27, -1), (20, 28, 1), (20, 29, 1), (1, 30, -1), (1, 31, -1),(20, 32, 1), (20, 33, 1), (1, 34, -1), (1, 35, -1),(20, 36, 1), (20, 37, 1), (1, 38, -1), (1, 39, -1),(20, 40, 1), (20, 41, 1), (1, 42, -1), (1, 43, -1),(20, 44, 1), (20, 45, 1), (1, 46, -1), (1, 47, -1),(20, 48, 1), (20, 49, 1), (1, 50, -1), (1, 51, -1),(20, 52, 1), (20, 53, 1), (1, 54, -1), (1, 55, -1)
            //(2, 2, -1), (2, 3, -1),(3, 4, -1), (3, 5, -1),(4, 6, -1),(4, 7, -1),(5, 8, -1),(5, 9, -1), (6, 10, -1),(6, 11, -1),(7, 12, -1), (7, 13, -1),(8, 14, -1),(8, 15, -1), (9, 16, -1),(9, 17, -1),(10, 18, -1),(10, 19, -1),(11, 20, -1),(11, 21, -1), (12, 22, -1),(12, 23, -1),(13, 24, -1),(13, 25, -1),(2, 30, -1),(2, 31, -1),(3, 32, -1),(3, 33, -1),(4, 34, -1),(4, 35, -1),(5, 36, -1),(5, 37, -1),(6, 38, -1),(6, 39, -1),(7, 40, -1),(7, 41, -1),(8, 42, -1),(8, 43, -1),(9, 44, -1),(9, 45, -1),(10, 46, -1),(10, 47, -1),(11, 48, -1),(11, 49, -1),(12, 50, -1),(12, 51, -1),(13, 52, -1),(13, 53, -1),(14, 54, -1),(14, 55, -1),(15, 56, -1),(15, 57, -1)
        };
        public static bool isRunning = true;

        public static void CreateMap()
        {
            Console.Clear();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (stageNum == 0)
                    {
                        if (i == playerX && j == playerY)
                            Console.Write('▲');
                        else if (enemies.Exists(e => e.x == i && e.y == j))
                            Console.Write('●');
                        else
                            Console.Write(map[i, j]);
                    }
                    if (stageNum == 1)
                    {
                        if (i == playerX && j == playerY)
                            Console.Write('▲');
                        else if (enemies2.Exists(e => e.x == i && e.y == j))
                            Console.Write('●');
                        else
                            Console.Write(map[i, j]);
                    }
                    if (stageNum == 2)
                    {
                        if (i == playerX && j == playerY)
                            Console.Write('▲');
                        else if (enemies3.Exists(e => e.x == i && e.y == j))
                            Console.Write('●');
                        else
                            Console.Write(map[i, j]);
                    }

                }
                Console.WriteLine();
            }
        }
        public static void RestartGame()
        {
            playerX = 22; playerY = 1;
            Console.Clear();
            Console.WriteLine("게임 오버! 다시 시작합니다...");
            Thread.Sleep(1000);
        }
        public static void PlayerMove()
        {
            if (!Console.KeyAvailable) return;
            ConsoleKey key = Console.ReadKey(true).Key;
            int newX = playerX, newY = playerY;

            switch (key)
            {
                case ConsoleKey.UpArrow: newX--; break;
                case ConsoleKey.DownArrow: newX++; break;
                case ConsoleKey.LeftArrow: newY--; break;
                case ConsoleKey.RightArrow: newY++; break;
            }

            if (map[newX, newY] != '█')
            {
                playerX = newX;
                playerY = newY;
            }
            if (map[playerX, playerY] == 'G')
            {
                Console.Clear();
                Map.stageNum++;
                if (Map.stageNum == 3)
                {
                    Console.Clear();
                    stopwatch.Stop(); // 스톱워치 중지
                    Console.WriteLine($"플레이타임: {stopwatch.Elapsed.Minutes}분 {stopwatch.Elapsed.Seconds}초");
                    Console.WriteLine("축하합니다! 클리어했습니다!");
                    Thread.Sleep(5000);
                    isRunning = false;
                }
                StageName();

            }
            if (enemies.Exists(e => e.x == playerX && e.y == playerY))
            {
                RestartGame();
            }
            if (enemies2.Exists(e => e.x == playerX && e.y == playerY))
            {
                RestartGame();
            }
            if (enemies3.Exists(e => e.x == playerX && e.y == playerY))
            {
                RestartGame();
            }
        }
        public static void explainGame()
        {
            Console.SetCursorPosition(36, 8);
            Console.WriteLine("게임 설명");
            Console.SetCursorPosition(34, 9);
            Console.WriteLine("이동 : 방향키");
            Console.SetCursorPosition(26, 10);
            Console.WriteLine("목적지를 향해서 가시면 됩니다.");
            Console.SetCursorPosition(27, 11);
            Console.WriteLine("단. 적들이 돌아다니기때문에");
            Console.SetCursorPosition(26, 12);
            Console.WriteLine("잘 피해서 목적지로 가시면됩니다.");
            Console.SetCursorPosition(27, 15);
            Console.WriteLine("Press the P key to GameStart");
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.P)
                {

                    CreateMap();
                    break;
                }
            }
        }
        public static void StartMap()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.SetCursorPosition(0, 8);

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("  _   _   ___  ______ ______  _____  _____  _____   _____   ___  ___  ___ _____ ");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine(" | | | | / _ \\ | ___ \\|  _  \\|  ___|/  ___||_   _| |  __ \\ / _ \\ |  \\/  ||  ___|");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine(" | |_| |/ /_\\ \\| |_/ /| | | || |__  \\ `--.   | |   | |  \\// /_\\ \\| .  . || |__  ");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(" |  _  ||  _  ||    / | | | ||  __|  `--. \\  | |   | | __ |  _  || |\\/| ||  __| ");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine(" | | | || | | || |\\ \\ | |/ / | |___ /\\__/ /  | |   | |_\\ \\| | | || |  | || |___ ");
            Console.SetCursorPosition(0, 14);
            Console.WriteLine(" \\_| |_/\\_| |_/\\_| \\_||___/  \\____/ \\____/   \\_/    \\____/\\_| |_/\\_|  |_/\\____/ ");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Console.SetCursorPosition(28, 16);
            Console.WriteLine("Press the P key to start");

            // 사용자가 'P' 키를 입력할 때까지 대기
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.P)
                {
                    Console.Clear();
                    explainGame();
                    break;
                }
            }
        }
        public static void MoveEnemies()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                var (x, y, direction) = enemies[i];
                int newX = x + direction;
                if (map[newX, y] == '█') direction *= -1;
                enemies[i] = (x + direction, y, direction);
            }

            // 적 이동 후 플레이어와 충돌 체크
            if (enemies.Exists(e => e.x == playerX && e.y == playerY))
            {
                RestartGame();
            }
        }
        public static void MoveEnemies2()
        {
            for (int i = 0; i < enemies2.Count; i++)
            {
                var (x, y, direction) = enemies2[i];
                int newY = y + direction;
                if (map[x, newY] == '█') direction *= -1;
                enemies2[i] = (x, y + direction, direction);
                
            }

            // 적 이동 후 플레이어와 충돌 체크
            if (enemies2.Exists(e => e.x == playerX && e.y == playerY))
            {
                RestartGame();
            }
        }
        public static void MoveEnemies3()
        {
            for (int i = 0; i < enemies3.Count; i++)
            {
                var (x, y, direction) = enemies3[i];
                int newX = x + direction;
                if (map[newX, y] == '█') direction *= -1;
                enemies3[i] = (x + direction, y, direction);
            }

            // 적 이동 후 플레이어와 충돌 체크
            if (enemies3.Exists(e => e.x == playerX && e.y == playerY))
            {
                RestartGame();
            }
        }
        public static void StageName()
        {
            if (Map.stageNum == 0)
            {
                Console.Clear();
                Console.SetCursorPosition(14, 8);
                Console.WriteLine(" _____  _____   ___   _____  _____   __ ");
                Console.SetCursorPosition(14, 9);
                Console.WriteLine("/  ___||_   _| / _ \\ |  __ \\|  ___| /  |");
                Console.SetCursorPosition(14, 10);
                Console.WriteLine("\\ `--.   | |  / /_\\ \\| |  \\/| |__   `| |");
                Console.SetCursorPosition(14, 11);
                Console.WriteLine(" `--. \\  | |  |  _  || | __ |  __|   | | ");
                Console.SetCursorPosition(14, 12);
                Console.WriteLine("/\\__/ /  | |  | | | || |_\\ \\| |___  _| |_");
                Console.SetCursorPosition(14, 13);
                Console.WriteLine("\\____/   \\_/  \\_| |_/ \\____/\\____/  \\___/");
                Thread.Sleep(1000);
            }
            else if (Map.stageNum == 1)
            {
                playerX = 22;
                playerY = 1;
                Console.Clear();
                Console.SetCursorPosition(14, 8);
                Console.WriteLine(" _____  _____   ___   _____  _____   _____ ");
                Console.SetCursorPosition(14, 9);
                Console.WriteLine("/  ___||_   _| / _ \\ |  __ \\|  ___| / __  \\");
                Console.SetCursorPosition(14, 10);
                Console.WriteLine("\\ `--.   | |  / /_\\ \\| |  \\/| |__   `' / /'");
                Console.SetCursorPosition(14, 11);
                Console.WriteLine("`--. \\  | |  |  _  || | __ |  __|    / /  ");
                Console.SetCursorPosition(14, 12);
                Console.WriteLine("/\\__/ /  | |  | | | || |_\\ \\| |___  ./ /___");
                Console.SetCursorPosition(14, 13);
                Console.WriteLine("\\____/   \\_/  \\_| |_/ \\____/\\____/  \\_____/");
                Thread.Sleep(1000);
            }
            else if (Map.stageNum == 2)
            {
                playerX = 22;
                playerY = 1;
                Console.Clear();
                Console.SetCursorPosition(14, 8);
                Console.WriteLine(" _____  _____   ___   _____  _____   _____ ");
                Console.SetCursorPosition(14, 9);
                Console.WriteLine("/  ___||_   _| / _ \\ |  __ \\|  ___| |____ |");
                Console.SetCursorPosition(14, 10);
                Console.WriteLine("\\ `--.   | |  / /_\\ \\| |  \\/| |__       / /");
                Console.SetCursorPosition(14, 11);
                Console.WriteLine(" `--. \\  | |  |  _  || | __ |  __|      \\ \\");
                Console.SetCursorPosition(14, 12);
                Console.WriteLine("/\\__/ /  | |  | | | || |_\\ \\| |___  .___/ /");
                Console.SetCursorPosition(14, 13);
                Console.WriteLine("\\____/   \\_/  \\_| |_/ \\____/\\____/  \\____/ ");
                Thread.Sleep(1000);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = new UTF8Encoding(false);
            Console.CursorVisible = false;
            Map.StartMap();
            Map.StageName();
            Map.stopwatch.Start();
            while (Map.isRunning)
            {
                Map.PlayerMove();
                Map.CreateMap();




                if (Map.stageNum == 0)
                    Map.MoveEnemies();
                else if (Map.stageNum == 1)
                    Map.MoveEnemies2();
                else if (Map.stageNum == 2)
                    Map.MoveEnemies3();
                Thread.Sleep(10);
            }
        }
    }
}