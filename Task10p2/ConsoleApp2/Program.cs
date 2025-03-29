using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        IPost post = new BasicPost();
        post = new LikeDecorator(post);
        post = new ShareDecorator(post);

        Console.WriteLine(post.GetContent());
    }
}