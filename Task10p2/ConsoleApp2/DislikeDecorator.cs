namespace ConsoleApp2
{
    public class DislikeDecorator : PostDecorator
    {
        public DislikeDecorator(IPost post) : base(post) { }

        public override string GetContent()
        {
            return base.GetContent() + " Не понравилось("; ;
        }
    }
}