using System;

try
{
    Console.WriteLine("TerrainDiffusion CLI initialized.");
    
    // MVP logic goes here
    
    return 0; // Success
}
catch (Exception ex)
{
    var originalColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Error.WriteLine($"FATAL ERROR: {ex.Message}");
    Console.ForegroundColor = originalColor;
    
    return 1; // Error
}
