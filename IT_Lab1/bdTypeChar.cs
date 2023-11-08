namespace IT_Lab1;

class bdTypeChar : bdType
{
    public override bool Validation(string value)
    {
        char buf;
        if (char.TryParse(value, out buf)) return true;
        return false;
    }
}