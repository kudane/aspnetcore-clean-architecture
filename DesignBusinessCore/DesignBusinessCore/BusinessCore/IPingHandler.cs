namespace DesignBusinessCore.BusinessCore;

public class PingCommand
{
    public string Message { get; set; } = null!;
}

public class PingOutput
{
    public bool Success { get; set; }
}

public interface IPingHandler
{
    // defind [command] and represent [outout]
    public PingOutput Handle(PingCommand command);
}

