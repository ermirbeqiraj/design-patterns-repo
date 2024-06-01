namespace PatternCollection.FacadePattern;

public sealed class EmailService 
{
    string? _from;  
    string? _to;
    string? _subject;
    string? _body;

    public EmailService()
    {
        
    }

    public void SetSender(string from)
    {
        _from = from;
    }

    public void SetRecipient(string to)
    {
        _to = to;
    }

    public void SetContent(string subject, string body)
    {
        _subject = subject;
        _body = body;
    }

    public void Send()
    {

    }
}
