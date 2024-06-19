namespace AneelAndLevi_Bug_Project {
    public interface IDangerBug
    {
        public string Name { get; set; }
        public bool CanBite { get; set; }
        public bool Legs { get; set; }
        public bool CanMove { get; set; }
        public string GoodStuff { get; set; }
        public PlagueType Plague { get; set; }
        public void DisplayProperties();
    }
}
