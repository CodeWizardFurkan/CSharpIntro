﻿Customer customer1 = new Customer { Id = 1, FirstName = "Furkan", LastName = "Demir", City = "Ankara" };

Customer customer3 = new Customer();
customer3.Id = 3;

Customer customer2 = new Customer(1, "İrem", "Karaca", "İzmir");

Console.WriteLine(customer2.FirstName);




class Customer
{
    public Customer()
    {
        Console.WriteLine("Yapıcı blok çalıştı");
    }

    public Customer(int id, string firstName, string lastName, string city)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}
