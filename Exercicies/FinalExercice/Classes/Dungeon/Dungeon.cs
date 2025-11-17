using Programming101CS.Helpers;
using Programming101CS.Practice.Solution.Classes.Dungeon.Tiles;
using Programming101CS.Practice.Solution.Classes.Entities;

namespace Programming101CS.Practice.Solution.Classes.Dungeon {
    internal class Dungeon {
        public Position TreasurePosition => treasurePosition;
        public Position[] StairsPosition => stairsPosition;

        private int Floors => map.Length;
        private int Size => map[0].GetLength(0);

        private DungeonTile[][,] map;
        private Position treasurePosition;
        private Position[] stairsPosition;
        private Random random;

        public Dungeon(int floors, int dungeonSize) {
            map = new DungeonTile[floors][,];
            for (var f = 0; f < floors; f++) {
                map[f] = new DungeonTile[dungeonSize, dungeonSize];
                for (var y = 0; y < dungeonSize; y++)
                    for (var x = 0; x < dungeonSize; x++)
                        map[f][y, x] = new DungeonTile(new Position(f, x, y));
            }

            stairsPosition = new Position[2];
            random = new Random();
        }

        public void AddStairs() {
            var position = GetAvailableRandomPosition(0);
            map[position.Floor][position.Y, position.X].ChangeType(DungeonTileType.Stair);
            map[position.Floor + 1][position.Y, position.X].ChangeType(DungeonTileType.Stair);

            stairsPosition[0] = map[position.Floor][position.Y, position.X].Position;
            stairsPosition[1] = map[position.Floor + 1][position.Y, position.X].Position;
        }

        public void AddTreasure() {
            var position = GetAvailableRandomPosition(Floors - 1);
            map[position.Floor][position.Y, position.X].ChangeType(DungeonTileType.Treasure);
            treasurePosition = position;
        }

        public Position GetAvailableRandomPosition(int floor, List<Enemy> enemies = null) {
            var posX = random.Next(0, Size);
            var posY = random.Next(0, Size);
            while (map[floor][posY, posX].Type != DungeonTileType.Empty || (enemies != null && enemies.Any(e => e.Position == map[floor][posY, posX].Position))) {
                posX = random.Next(0, Size);
                posY = random.Next(0, Size);
            }

            return map[floor][posY, posX].Position;
        }

        public Position GetAvailableRandomWallPosition(int floor, List<Enemy> enemies) {
            var wallPosition = (DirectionType)random.Next(0, 4);
            var positionValue = random.Next(0, Size);
            Position position = default;
            switch (wallPosition) {
                case DirectionType.North:
                    while (map[floor][0, positionValue].Type != DungeonTileType.Empty || enemies.Any(e => e.Position == map[floor][0, positionValue].Position))
                        positionValue = random.Next(0, Size);
                    position = map[floor][0, positionValue].Position;
                    break;
                case DirectionType.East:
                    while (map[floor][positionValue, Size - 1].Type != DungeonTileType.Empty || enemies.Any(e => e.Position == map[floor][positionValue, Size - 1].Position))
                        positionValue = random.Next(0, Size);
                    position = map[floor][positionValue, Size - 1].Position;
                    break;
                case DirectionType.South:
                    while (map[floor][Size - 1, positionValue].Type != DungeonTileType.Empty || enemies.Any(e => e.Position == map[floor][Size - 1, positionValue].Position))
                        positionValue = random.Next(Size - 1, Size);
                    position = map[floor][Size - 1, positionValue].Position;
                    break;
                case DirectionType.West:
                    while (map[floor][positionValue, 0].Type != DungeonTileType.Empty || enemies.Any(e => e.Position == map[floor][positionValue, 0].Position))
                        positionValue = random.Next(0, Size);
                    position = map[floor][positionValue, 0].Position;
                    break;
            }

            return position;
        }

        public DirectionType[] GetAvailableDirections(Adventurer adventurer) {
            var availableDirections = new List<DirectionType>();
            var colindantTiles = GetColindantTiles(adventurer.Position);
            if (colindantTiles[(int)DirectionType.North] != null) availableDirections.Add(DirectionType.North);
            if (colindantTiles[(int)DirectionType.East] != null) availableDirections.Add(DirectionType.East);
            if (colindantTiles[(int)DirectionType.South] != null) availableDirections.Add(DirectionType.South);
            if (colindantTiles[(int)DirectionType.West] != null) availableDirections.Add(DirectionType.West);

            return [.. availableDirections];
        }

        public DirectionType[] GetAvailableDirections(Enemy enemy, Enemy[] enemies) {
            var availableDirections = new List<DirectionType>();
            var colindantTiles = GetColindantTiles(enemy.Position);
            if (colindantTiles[(int)DirectionType.North] != null && colindantTiles[(int)DirectionType.North].Type == DungeonTileType.Empty && !enemies.Any(e => e.Position == colindantTiles[(int)DirectionType.North].Position))
                availableDirections.Add(DirectionType.North);
            if (colindantTiles[(int)DirectionType.East] != null && colindantTiles[(int)DirectionType.East].Type == DungeonTileType.Empty && !enemies.Any(e => e.Position == colindantTiles[(int)DirectionType.East].Position))
                availableDirections.Add(DirectionType.East);
            if (colindantTiles[(int)DirectionType.South] != null && colindantTiles[(int)DirectionType.South].Type == DungeonTileType.Empty && !enemies.Any(e => e.Position == colindantTiles[(int)DirectionType.South].Position))
                availableDirections.Add(DirectionType.South);
            if (colindantTiles[(int)DirectionType.West] != null && colindantTiles[(int)DirectionType.West].Type == DungeonTileType.Empty && !enemies.Any(e => e.Position == colindantTiles[(int)DirectionType.West].Position))
                availableDirections.Add(DirectionType.West);

            return [.. availableDirections];
        }

        private DungeonTile[] GetColindantTiles(Position center) {
            var tiles = new DungeonTile[4];
            if (center.Y > 0) tiles[0] = map[center.Floor][center.Y - 1, center.X];
            if (center.X < Size - 1) tiles[1] = map[center.Floor][center.Y, center.X + 1];
            if (center.Y < Size - 1) tiles[2] = map[center.Floor][center.Y + 1, center.X];
            if (center.X > 0) tiles[3] = map[center.Floor][center.Y, center.X - 1];

            return tiles;
        }

        public void PrintDungeon(Adventurer adventurer, Enemy[] enemies) {
            for (var y = 0; y < map[adventurer.Position.Floor].GetLength(0); y++) {
                for (var x = 0; x < map[adventurer.Position.Floor].GetLength(1); x++) {
                    var tile = map[adventurer.Position.Floor][y, x];
                    if (enemies.Any(e => e.Position == tile.Position)) PrintTools.Write("O", ConsoleColor.Red);
                    else if (tile.Position == adventurer.Position) PrintTools.Write("o", ConsoleColor.Cyan);
                    else tile.PrintTile();
                }

                Console.WriteLine();
            }
        }
    }
}
