namespace Behavioral.Strategy
{
    public class SimpleCompositor : Compositor
    {
        // "... examines components a line at a time to determine where
        // breaks should go... ignores the stretchability of components,
        // taking only their natural widths into consideration..."
        public override int Compose(Coord[] natural, Coord[] stretch, Coord[] shrink, int componentCount, int lineWidth, int[] breaks)
        {
            var breakCount = 100;
            return breakCount;
        }
    }
}
