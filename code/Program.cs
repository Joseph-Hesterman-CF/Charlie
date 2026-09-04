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
            "#.....#...#...#.....#.#.#",
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

        var path = Solve(map);

        Console.WriteLine(TryValidate(map, path, out var error)
            ? "Charlie är framme vid puben!"
            : $"Charlie gick vilse: {error}");
    }

    static string Solve(string[] map)
    {
        // Implementera Solve så att den returnerar en string path 
        // bestående av instruktioner U, D, L och R som tar Charlie från A till Z.
        // Example: "RRDDLLUU" betyder att Charlie ska gå höger, höger, ner, ner, vänster, vänster, upp, upp.
        
        return string.Empty;
    }

    static bool TryValidate(string[] map, string path, out string error)
    {
        error = string.Empty;

        var start = FindPosition(map, 'A');
        if (start is null)
        {
            error = "Kartan saknar startpunkten A.";
            return false;
        }

        var (x, y) = start.Value;

        for (var step = 0; step < path.Length; step++)
        {
            var move = path[step];
            (int dx, int dy)? direction = move switch
            {
                'U' => (0, -1),
                'D' => (0, 1),
                'L' => (-1, 0),
                'R' => (1, 0),
                _ => null
            };

            if (direction is null)
            {
                error = $"Ogiltig instruktion '{move}' på steg {step + 1}.";
                return false;
            }

            var (dx, dy) = direction.Value;
            x += dx;
            y += dy;

            if (y < 0 || y >= map.Length || x < 0 || x >= map[y].Length)
            {
                error = $"Charlie lämnar kartan på steg {step + 1}.";
                return false;
            }

            if (map[y][x] == '#')
            {
                error = $"Charlie går in i en vägg på steg {step + 1}.";
                return false;
            }
        }

        if (map[y][x] != 'Z')
        {
            error = "Vägen slutar inte vid Z.";
            return false;
        }

        return true;
    }

    static (int x, int y)? FindPosition(string[] map, char marker)
    {
        for (var y = 0; y < map.Length; y++)
        {
            var x = map[y].IndexOf(marker);
            if (x >= 0)
            {
                return (x, y);
            }
        }

        return null;
    }
}