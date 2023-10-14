namespace Performance
{
    internal class Property : IIterator
    {
        public string Name => "Property";

        // PROPERTY
        private ISomeService Service { get; }

        public Property(ISomeService service)
        {
            Service = service;
        }

        public void Iterate(int iterations)
        {
            for (var i = 0; i < iterations; i++)
            {
                var _ = Service;
            }
        }

        public void SomeMethodUsingService()
        {
            // Just so the compiler cannot go ahead
            // and downgrade _service to a local variable
            // or otherwise inline it.
            Service.SomeMethod();
        }
    }
}
