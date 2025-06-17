using System;
using System.ComponentModel.DataAnnotations;

namespace TestAlongsideCode.Console.Configurations;

public class MainConfiguration
{
    public required string Environment { get; init; }

    public void Validate()
    {
        if (string.IsNullOrEmpty(Environment))
        {
            throw new ValidationException($"{nameof(Environment)} is required.");
        }
    }
}
