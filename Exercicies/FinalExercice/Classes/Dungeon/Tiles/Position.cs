
namespace Programming101CS.Practice.Solution.Classes.Dungeon.Tiles {
    internal struct Position {
        public int Floor;
        public int X;
        public int Y;

        public Position(int floor, int x, int y) {
            Floor = floor;
            X = x;
            Y = y;
        }

        public override bool Equals(object obj) {
            if (obj != null && obj is Position pos)
                return Floor == pos.Floor && X == pos.X && Y == pos.Y;

            return false;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public static bool operator ==(Position pos1, Position pos2) {
            return pos1.Equals(pos2);
        }

        public static bool operator !=(Position pos1, Position pos2) {
            return !pos1.Equals(pos2);
        }
    }
}
