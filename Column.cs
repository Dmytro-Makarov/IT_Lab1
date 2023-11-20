namespace IT_Lab1;

class Column
{
    public string cName;
    public bdType cType;
    public string typeName;

    public Column(string cname, string ctype)
    {
        cName = cname;
        typeName = ctype;

        switch (ctype)
        {
            case "Integer":
                cType = new bdTypeInteger();
                break;
            case "Real":
                cType = new bdTypeReal();
                break;
            case "Char":
                cType = new bdTypeChar();
                break;
            case "String":
                cType = new bdTypeString();
                break;
            case "Html":
                cType = new bdTypeHTML();
                break;
            case "StringInvl":
                cType = new bdTypeStringInvl();
                break;
            default:
                cType = new bdTypeString();
                break;
        }
    }
}