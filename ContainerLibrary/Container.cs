namespace ContainerLibrary;

    public class Container<T>
    {
        private readonly List<T> _container = new(capacity: 5);

        public int MaxLength { get; } = 5;

        public bool TryAdd(T value)
        {
            if (_container.Count == MaxLength)
            {
                return false;
            }

            _container.Add(value);

            return true;
        }

        public void ForceAdd(T value)
        {
            if (_container.Count == MaxLength)
            {
                _container.RemoveAt(0);
            }

            TryAdd(value);
        }

        public T[] GetAll() => _container.ToArray();
    }
