namespace Programming101CS.Syllabus.Definitions {
    internal struct SyllabusChapter {
        public int ID { get; private set; }
        public string Title { get; private set; }
        public string Information { get; private set; }
        public string Exercises { get; private set; }

        public SyllabusChapter(int id, string title, string information, string exercises) {
            ID = id;
            Title = title;
            Information = information;
            Exercises = exercises;
        }
    }
}
