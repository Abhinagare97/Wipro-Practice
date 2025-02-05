﻿using System;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;

class Book
{
    // Define properties
    // Complete Step 1:............
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, string isbn)
    {
        this.Author = author;
        this.Title = title;
        this.ISBN = isbn;
    }

    // Define constructor
    // Complete Step 2:............
}

class Library
{
    // Define collection to store books
    // Complete Step 3:............
    List<Book> books = new List<Book>();


    // Add method to add a book
    // Complete Step 4:............
    public void AddBook(Book b)
    {
        books.Add(b);
    }

    // Add method to remove a book by ISBN
    // Complete Step 5:............
    public void RemoveBook(string isbn)
    {
        foreach (Book b in books)
        {
            if (b.ISBN == isbn)
            {
                books.Remove(b);

            }
        }
    }

    // Add method to list all books
    // Complete Step 6:............
    public void ListBooks()
    {
        Console.WriteLine("Listing all books:");

        foreach (Book b in books)
        {
            Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, ISBN: {b.ISBN}");

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        bool exit = false;

        while (!exit)
        {

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List Books");
            Console.WriteLine("4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Prompt for book details and add book
                    // Complete Step 7:............
                    Console.WriteLine("Enter book title:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter book author:");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter book ISBN:");
                    string isbn = Console.ReadLine();
                    Book b = new Book(title, author, isbn);
                    library.AddBook(b);
                    break;
                case 2:
                    // Prompt for ISBN and remove book
                    // Complete Step 8:............
                    Console.WriteLine("Enter the ISBN");
                    string i = Console.ReadLine();
                    library.RemoveBook(i);

                    break;
                case 3:
                    // List all books
                    // Complete Step 9:............
                    library.ListBooks();

                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}