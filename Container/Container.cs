namespace Container
{
    public class Container
    {
        private readonly List<int> _container = new(capacity: 5);

        public int MaxLength { get; } = 5;

        public bool TryAdd(int value)
        {
            if (_container.Count == MaxLength)
            {
                return false;
            }

            _container.Add(value);

            return true;
        }

        public void ForceAdd(int value)
        {
            if (_container.Count == MaxLength)
            {
                _container.RemoveAt(0);
            }

            TryAdd(value);
        }

        public int[] GetAll() => _container.ToArray();
    }
}
