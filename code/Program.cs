namespace Charlie;

class Program
{
    static void Main()
    {
        string[] map =
        [
            "#########################",
            "#A..#...#.....#.....#...#",
            "###.#.#.###.###.#.#.###.#",
            "#.#...#...#.#...#.#.....#",
            "#.#######.#.#.###.#####.#",
            "#.......#.#...#...#.....#",
            "#.#####.#.#####.###.#####",
            "#.#.....#.......#...#...#",
            "#.#.###.#########.#####.#",
            "#.#...#.....#...#.....#.#",
            "#####.#####.#.#.#####.#.#",
            "#.....#...#.#.#.....#.#.#",
            "#.#####.#.###.###.###.#.#",
            "#.#...#.#...#.#.#.....#.#",
            "#.#.#.#.###.#.#.#######.#",
            "#...#.#.#...#...#.......#",
            "#.###.#.#.#.###.#####.#.#",
            "#...#...#.#.#.#.......#.#",
            "#.#######.#.#.#########.#",
            "#.#.......#...#.#.....#.#",
            "#.#.#########.#.#.###.#.#",
            "#.#.......#.....#...#...#",
            "#.#######.#########.#####",
            "#.......#..............Z#",
            "#########################"
        ];

        var answer = Solve(map);

        Console.WriteLine("Charlies väg till puben:");
        Console.WriteLine(answer);

        Console.WriteLine(Validate(map, answer)
            ? "Charlie är framme vid puben!"
            : "Charlie gick vilse!");
    }


    static string Solve(string[] map)
    {
        // TODO: Implementera lösningen här.
        return string.Empty;
    }


    static bool Validate(string[] map, string path)
    {
        var x = 0;
        var y = 0;

        // Hitta startpositionen A
        for (var row = 0; row < map.Length; row++)
        {
            for (var col = 0; col < map[row].Length; col++)
            {
                if (map[row][col] == 'A')
                {
                    x = col;
                    y = row;
                }
            }
        }

        foreach (var move in path)
        {
            switch (move)
            {
                case 'U':
                    y--;
                    break;

                case 'D':
                    y++;
                    break;

                case 'L':
                    x--;
                    break;

                case 'R':
                    x++;
                    break;

                default:
                    return false;
            }

            // Kontrollera att Charlie håller sig på kartan
            if (y < 0 || y >= map.Length || x < 0 || x >= map[y].Length)
            {
                return false;
            }

            // Kontrollera Feature Creep-blockeringar
            if (map[y][x] == '#')
            {
                return false;
            }
        }

        // Om true så är Charlie på puben
        return map[y][x] == 'Z';
    }
}