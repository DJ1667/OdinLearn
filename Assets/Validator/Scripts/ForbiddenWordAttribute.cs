using System;

public class ForbiddenWordAttribute : Attribute
{
    public string[] ForbiddenWords;

    public ForbiddenWordAttribute(params string[] forbiddenWords) => ForbiddenWords = forbiddenWords;
}