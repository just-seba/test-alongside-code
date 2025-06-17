// See https://aka.ms/new-console-template for more information
using TestAlongsideCode.ClassLibrary;
using TestAlongsideCode.Console.Configurations;

Console.WriteLine("Hello, World!");

Type[] types =
[
    .. typeof(MainConfiguration).Assembly.GetTypes(),
    .. typeof(MyService).Assembly.GetTypes(),
];

foreach (var type in types)
{
    Console.WriteLine($"- {type.FullName}");
}
