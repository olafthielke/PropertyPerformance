namespace Performance
{
    internal interface IIterator
    {
        string Name { get; }
        void Iterate(int iterations);
        public void SomeMethodUsingService();
    }
}
