﻿namespace MicroservicesReference.Users.Core.Model;

public class User
{
    public Guid Id { get; set; }
    public required string Email { get; set; }
}