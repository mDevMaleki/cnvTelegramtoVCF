namespace cvtTGCtoVCF;
public class Rootobject
{
    public List<TelegramContact> List { get; set; }
}

public class TelegramContact
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string phone_number { get; set; }
    public DateTime date { get; set; }
    public string date_unixtime { get; set; }
}
