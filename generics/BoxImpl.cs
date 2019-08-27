namespace generics
{
    
    public class Box<T>
    {
        public T Item { get; set; }

        public Box(T item)
        {
            Item = item;
        }

        public override string ToString()
        {
            return Item.ToString();
        }
    }
}