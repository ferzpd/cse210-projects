using system;

public class   Entry
{
    public string Date { get; set; }
    public string prompt { get; set; }
    public string response { get; set; }

    public Entry(string Date, string proimpot, string response)
    {
        Date = date;
        prompt = proimpot;
        Response = response;

    }
    public override string ToStirng()
    {
        return $"{Date} | {prompt} | {response}";
    }  


}