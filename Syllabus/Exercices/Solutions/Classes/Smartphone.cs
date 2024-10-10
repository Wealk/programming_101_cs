namespace Programming101CS.Syllabus.Exercices.Solutions.Classes {
    internal class Smartphone : IPurchaseItem {
        private const float MAX_DATE_VALUE = 500f;
        private const float DATE_REDUCTION = 15;
        private const float SIZE_VALUE = 25;

        private DateTime releaseYear;
        private SizeType size;

        public DateTime GetReleaseYear() {
            return releaseYear;
        }

        protected void SetReleaseYear(DateTime value) {
            releaseYear = value;
        }

        public SizeType GetSizeType() {
            return size;
        }

        protected void SetSizeType(SizeType value) {
            size = value;
        }

        public Smartphone(DateTime release, SizeType s) {
            releaseYear = release;
            size = s;
        }

        public float GetPurchasePrice() {
            var purchasePrice = 0f;
            purchasePrice += ((MAX_DATE_VALUE - ((DateTime.Today - releaseYear).Days / 365f) * DATE_REDUCTION));
            purchasePrice -= ((int)(size + 1) * SIZE_VALUE);

            return purchasePrice;
        }
    }
}
