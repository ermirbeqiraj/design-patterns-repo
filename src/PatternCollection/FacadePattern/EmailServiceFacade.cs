namespace PatternCollection.FacadePattern;

public class EmailServiceFacade
{
    readonly EmailService _emailService;
    readonly ContentFilterService _contentFilterService;

    public EmailServiceFacade(EmailService emailService, ContentFilterService contentFilterService)
    {
        _emailService = emailService;
        _contentFilterService = contentFilterService;
    }

    public void Send(string from, string to, string subject, string body)
    {
        _emailService.SetSender(from);
        _emailService.SetRecipient(to);
        _emailService.SetContent(subject, body);

        var safeToSend = _contentFilterService.ContentIsAllowed(subject)
                            && _contentFilterService.ContentIsAllowed(body);

        if(!safeToSend)
            throw new ArgumentException("Found some not supported words in your subject or body.");

        _emailService.Send();
    }
}