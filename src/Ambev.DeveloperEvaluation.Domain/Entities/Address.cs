namespace Ambev.DeveloperEvaluation.Domain.Entities;

public sealed record Address(
    string City,
    string Street,
    int Number,
    string ZipCode,
    string Lat,
    string Long);