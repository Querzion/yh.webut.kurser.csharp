namespace learn_017_Business.Models;

public class ServiceRegistrationForm : ItemRegistrationForm
{
    public override bool IsService()
    {
        return true;
    }
}