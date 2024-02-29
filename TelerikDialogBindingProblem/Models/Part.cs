using System.ComponentModel.DataAnnotations;

namespace TelerikDialogBindingProblem.Models;

public sealed record Part
{
    public static IReadOnlyList<Part> All { get; } =
    [
        new Part { Name = "First Part", Price = 1 },
        new Part { Name = "Second Part", Price = 2 },
        new Part { Name = "Third Part", Price = 3 },
        new Part { Name = "Fourth Part", Price = 4 },
        new Part { Name = "Fifth Part", Price = 5 },
        new Part { Name = "Sixth Part", Price = 6 }
    ];

    [Required] public required string Name { get; set; }
    [Required] public required int Price { get; set; }
}

public sealed record PartPlaceDefinition
{
    public static IReadOnlyList<PartPlaceDefinition> All { get; } =
    [
        new PartPlaceDefinition { Name = "First", Amount = 1, Alternatives = [..Part.All.Take(2)] },
        new PartPlaceDefinition { Name = "Second", Amount = 2, Alternatives = [..Part.All.Take(2)] },
        new PartPlaceDefinition { Name = "Third", Amount = 3, Alternatives = [..Part.All.Take(2)] },
        new PartPlaceDefinition { Name = "Fourth", Amount = 4, Alternatives = [..Part.All.Take(2)] },
    ];

    [Required] public required string Name { get; set; }
    [Required] public required int Amount { get; set; }
    [Required] public required List<Part> Alternatives { get; set; } = [];
}