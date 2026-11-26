namespace Documato.Domain.Entities;

public sealed class Document
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Name { get; private set; } = string.Empty;

    private Document()
    {
    }

    public Document(string name)
    {
        Name = name;
    }
}
