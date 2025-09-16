namespace FizzBuzz.Domain
{
    public class FizzbuzzResult
    {
        public List<string> Results { get; set; } = new List<string>();
        public long Start { get; set; }
        public long End { get; set; }

        public int FizzCount { get; set; }
        public int BuzzCount { get; set; }
        public int FizzBuzzCount { get; set; }
        public int TotalCount { get; set; }
    }

}
