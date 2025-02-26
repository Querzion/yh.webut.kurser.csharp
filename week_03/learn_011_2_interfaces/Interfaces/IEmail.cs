namespace learn_011_2_interfaces.Interfaces;

public interface IEmail
{
    void SendEmail(string to, string subject, string body);
}