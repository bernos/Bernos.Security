﻿namespace Bernos.Security
{
    public interface IPasswordHasher
    {
        string CreateHash(string password);
        bool ValidatePassword(string password, string goodHash);
    }
}