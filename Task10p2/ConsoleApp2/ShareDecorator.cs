namespace ConsoleApp2
{
    public class ShareDecorator : PostDecorator
    {
        public ShareDecorator(IPost post) : base(post) { }

        public override string GetContent()
        {
            return base.GetContent()+ " Поделись с друзьями!"; 
        }
    }
}