namespace ConsoleApp2
{
    public class LikeDecorator: PostDecorator
    {
        public LikeDecorator (IPost post) : base (post) { }
        public override string GetContent()
        {
            return base.GetContent() + "Понравилось) ";
        }
    }
}
