using Programming101CS.Helpers;

namespace Programming101CS.Practice.Solution.Classes.Dungeon.Tiles {
    internal class DungeonTile {
        public Position Position => position;
        public DungeonTileType Type => type;

        private Position position;
        private DungeonTileType type;

        public DungeonTile(Position pos) {
            position = pos;
            type = DungeonTileType.Empty;
        }

        public void ChangeType(DungeonTileType newType) {
            type = newType;
        }

        public void PrintTile() {
            switch (type) {
                case DungeonTileType.Empty:
                    PrintTools.Write("x", ConsoleColor.Gray);
                    break;
                case DungeonTileType.Stair:
                    PrintTools.Write("m", ConsoleColor.Green);
                    break;
                case DungeonTileType.Treasure:
                    PrintTools.Write("▣", ConsoleColor.Yellow);
                    break;
            }
        }
    }
}
