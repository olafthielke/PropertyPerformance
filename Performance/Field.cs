namespace Performance
{
    internal class Field : IIterator
    {
        public string Name => "Field";

        // FIELD
        private readonly ISomeService _service;

        public Field(ISomeService service)
        {
            _service = service;
        }

        public void Iterate(int iterations)
        {
            for (var i = 0; i < iterations; i++)
            {
                var _ = _service;
            }
        }

        public void SomeMethodUsingService()
        {
            // Just so the compiler cannot go ahead
            // and downgrade _service to a local variable
            // or otherwise inline it.
            _service.SomeMethod();
        }
    }
}
