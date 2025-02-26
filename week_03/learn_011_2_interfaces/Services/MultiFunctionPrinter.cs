using learn_011_2_interfaces.Interfaces;

namespace learn_011_2_interfaces.Services;

public class MultiFunctionPrinter : IMultiFunctionPrinter
{
    public void PrintInBlackAndWhite()
    {
        throw new NotImplementedException();
    }

    public void PrintInColor()
    {
        throw new NotImplementedException();
    }

    public void Scan()
    {
        throw new NotImplementedException();
    }

    public void CopyInBlackAndWhite()
    {
        throw new NotImplementedException();
    }

    public void CopyInColor()
    {
        throw new NotImplementedException();
    }

    public void SendEmail(string to, string subject, string body)
    {
        throw new NotImplementedException();
    }
}