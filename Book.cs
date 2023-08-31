using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Net;

public class Book
{
	public string _privaterepository;

	public Book(int id, string authorId, string name, string description, string title)
	{
		this.Id = id;
		this.AuthorId = authorId;
		this.Name = name;
		this.Description = description;
		this.Title = title;
	}

	public List<Book> Books { get; set; } = new List<Book>();

	public int Id { get; set; }

	public string AuthorId { get; set; } 
	
	public string Name { get; set; }

	public string Description { get; set; }

	public string Title { get; set; }

	public List<Book> UpdateBook(int id, string authorId, string name, string description, string title)
	{
		_privaterepository.Update(name);
		return Books;
	}

	public List<Book> InsertBook(int id, string authorId, string name, string description, string title)
	{
		_privaterepository.Insert(name);
		return Books;
	}

	public List<Book> GetBookById(int id, string authorId, string name, string description, string title)
	{
		_privaterepository.GetBookById(name);
		return Books;
	}

	public List<Book> DeleteBook(int id, string authorId, string name, string description, string title)
	{
		_privaterepository.Remove(name);
		return Books;
	}
}
