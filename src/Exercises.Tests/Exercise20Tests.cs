using Exercises;

namespace Exercises.Tests;

public class Exercise20Tests
{
    [Fact]
    public void ExtractFileExtensions_ReturnsExtensionWithDot()
    {
        var filePaths = new List<string> { "document.txt", "image.png", "archive.zip", "notes.txt", "photo.jpeg" };

        var result = Exercise20.ExtractFileExtensions(filePaths);

        Assert.Equal(new[] { ".txt", ".png", ".zip", ".txt", ".jpeg" }, result);
    }
}
