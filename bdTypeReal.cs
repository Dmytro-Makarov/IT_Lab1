namespace IT_Lab1;

class bdTypeReal : bdType
{
    public override bool Validation(string value)
    {
        double buf;
        if (double.TryParse(value, out buf)) return true;
        return false;
    }
}