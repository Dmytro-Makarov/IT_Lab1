namespace IT_Lab1;

class bdTypeInteger : bdType
{
    public override bool Validation(string value)
    {
        int buf;
        if (int.TryParse(value, out buf)) return true;
        return false;
    }
}