namespace ConsoleApp2
{
  public abstract class PostDecorator : IPost
    {
        protected IPost _post;
        public PostDecorator(IPost post)
        {
            _post = post;
        }

        public virtual string GetContent()
        {
            return _post.GetContent();
        }
    }
}
