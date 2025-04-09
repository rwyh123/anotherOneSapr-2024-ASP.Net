namespace Khalevin_s_cool_sapr
{
    public class AppState
    {
        public List<Beam> Beams { get; set; } = new List<Beam>();
        public List<Node> Nodes { get; set; } = new List<Node>();
        public bool IsLeftSupport { get; set; }
        public bool IsRightSupport { get; set; }
    }

}
