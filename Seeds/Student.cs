using API.Models;
using Bogus;
using System;
using System.Collections.Generic;

public class StudentSeed
{
    public static List<Student> GetListStudents(int count)
    {
        var faker = new Faker<Student>()
            .RuleFor(s => s.Id, f => f.Random.Number(1, count))
            .RuleFor(s => s.Name, f => f.Name.FullName())
            .RuleFor(s => s.Email, (f, u) => f.Internet.Email(u.Name))
            .RuleFor(s => s.Address, f => f.Address.FullAddress());

        return faker.Generate(count);
    }

    public static Student GetStudent()
    {
        var faker = new Faker<Student>()
            .RuleFor(s => s.Id, f => 1)
            .RuleFor(s => s.Name, f => f.Name.FullName())
            .RuleFor(s => s.Email, (f, u) => f.Internet.Email(u.Name))
            .RuleFor(s => s.Address, f => f.Address.FullAddress());

        return faker.Generate();
    }
}