/*Create a C# program to manage a photo book using object-oriented programming.

To start, create a class called PhotoBook with a private attribute numPages of type int. It must also have
a public method GetNumberPages that will return the number of photo book pages.

The default constructor will create an album with 16 pages. There will be an additional 
constructor, with which we can specify the number of pages we want in the album.

There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

Finally create a PhotoBookTest class to perform the following actions:

Create a default photo book and show the number of pages
Create a photo book with 24 pages and show the number of pages
Create a large photo book and show the number of pages*/


using System;
public class PhotoBook
{
    protected int numPages;

    public int GetNumberPages()
    {
        return numPages;
    }

    public PhotoBook()
    {
        numPages = 16;
    }

    public PhotoBook(int numPages)
    {
        this.numPages = numPages;
    }
}

public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook()
    {
        numPages = 64;
    }
}

public class PhotoBookTest
{
    public static void Main()
    {
        PhotoBook album = new PhotoBook();
        Console.WriteLine(album.GetNumberPages());

        PhotoBook album2 = new PhotoBook(24);
        Console.WriteLine(album2.GetNumberPages());

        BigPhotoBook album3 = new BigPhotoBook();
        Console.WriteLine(album3.GetNumberPages());
    }
}