using System;

class Book
{
    private Title title;
    private Author author;
    private Content content;

    public void SetTitle(string titleText)
    {
        title = new Title(titleText);
    }

    public void SetAuthor(string authorName)
    {
        author = new Author(authorName);
    }

    public void SetContent(string contentText)
    {
        content = new Content(contentText);
    }

    public void ShowBook()
    {
        title.Show();
        author.Show();
        content.Show();
    }
}

class Title
{
    private string titleText;

    public Title(string text)
    {
        titleText = text;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Book title: " + titleText);
        Console.ResetColor();
    }
}

class Author
{
    private string authorName;

    public Author(string name)
    {
        authorName = name;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Author: " + authorName);
        Console.ResetColor();
    }
}

class Content
{
    private string contentText;

    public Content(string text)
    {
        contentText = text;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Content: " + contentText);
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();

        book.SetTitle("Harry Potter and the Philosopher's Stone");
        book.SetAuthor("JK Rowling");
        book.SetContent("Chapter 1: Once upon a time there was a boy...");

        book.ShowBook();

        Console.ReadLine();
    }
}