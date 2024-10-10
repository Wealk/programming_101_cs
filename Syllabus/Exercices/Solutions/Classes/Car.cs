namespace Programming101CS.Syllabus.Exercices.Solutions.Classes {
    internal class Car : IPurchaseItem {
        private const float MAX_FUEL_VALUE = 2500f;
        private const float STEP_DISTANCE_REDUCTION = 25.75f;
        private const float SIZE_VALUE = 20050.5f;

        private float fuel;
        private float consommer;
        private float distance;
        private SizeType size;

        public float GetFuel() {
            return fuel;
        }

        protected void SetFuel(float value) {
            fuel = value;
        }

        public float GetConsommer() {
            return consommer;
        }

        protected void SetConsommer(float value) {
            consommer = value;
        }

        public float GetDistance() {
            return distance;
        }

        protected void SetDistance(float value) {
            distance = value;
        }

        public SizeType GetSize() {
            return size;
        }

        protected void SetSize(SizeType value) {
            size = value;
        }

        public Car(SizeType s) {
            fuel = 100;
            consommer = GetConsommer(s);
            distance = 0;
            size = s;
        }

        public void Move() {
            if (fuel > 0) {
                distance++;
                fuel -= consommer;
            }
        }

        private float GetConsommer(SizeType s) {
            return s switch {
                SizeType.Big => 15.5f,
                SizeType.Medium => 7.5f,
                SizeType.Small => 4.5f
            };
        }

        public float GetPurchasePrice() {
            var purchasePrice = 0f;
            purchasePrice += (fuel / 100f * MAX_FUEL_VALUE);
            purchasePrice -= (distance * STEP_DISTANCE_REDUCTION);
            purchasePrice += ((int)(size + 1) * SIZE_VALUE);

            return purchasePrice;
        }
    }
}
